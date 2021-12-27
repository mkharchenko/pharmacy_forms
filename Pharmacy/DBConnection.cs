using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Pharmacy
{
    public class DBConnection //Singleton
    {
        private OracleConnection connection;

        private static DBConnection instance;
        private DBConnection()
        {
            string user_id = "PHARMACY";
            string password = "235689";
            string data_source = "localhost:1521/XEPDB1";

            connection = new OracleConnection();

            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();

            ocsb.Password = password;
            ocsb.UserID = user_id;
            ocsb.DataSource = data_source;

            connection.ConnectionString = ocsb.ConnectionString;
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к базе данных. " + ex.Message);
            }
        }
        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отключении от базы данных. " + ex.Message);
            }
        }
        public void CommitChanges()
        {
            string query = "COMMIT";
            if (connection.State == System.Data.ConnectionState.Open)
            {
                OracleCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        private OracleDataReader select(string query)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                OracleCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                OracleDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        private void ExNonQuery(string query)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                OracleCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        public List<Employee> getPharmacists()
        {
            List<Employee> emp = new List<Employee>();

            string query = "SELECT * FROM employees " +
                "WHERE job_id = " +
                "(SELECT job_id FROM jobs " +
                "WHERE job_title = 'pharmacist')";
            OracleDataReader dataReader = select(query);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    emp.Add(new Employee(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3)));
                }
            }
            dataReader.Close();

            return emp;
        }
        public List<Medicine> getMedicines()
        {
            List<Medicine> meds = new List<Medicine>();

            string query = "SELECT m.medicine_title, m.price, m.prescription_needed, p.provider_title, m.leftover " +
                "FROM medicines m " +
                "INNER JOIN providers p " +
                "ON m.provider_id = p.provider_id";
            OracleDataReader dataReader = select(query);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    meds.Add(new Medicine(dataReader.GetString(0), dataReader.GetDouble(1), Convert.ToBoolean(dataReader.GetInt32(2)), dataReader.GetString(3), dataReader.GetInt32(4)));
                }
            }
            dataReader.Close();

            return meds;
        }
        public List<Provider> getProviders()
        {
            List<Provider> providers = new List<Provider>();

            string query = "SELECT provider_title FROM providers";
            OracleDataReader dataReader = select(query);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    providers.Add(new Provider(dataReader.GetString(0)));
                }
            }
            dataReader.Close();

            return providers;
        }
        public void AddPurchase(Employee pharmacist)
        {
            string query = "INSERT INTO purchases (pharmacist_id) " +
                "(SELECT employee_id FROM employees " +
                "WHERE first_name = '" + pharmacist.first_name + "' AND " +
                "last_name = '" + pharmacist.last_name + "')";
            ExNonQuery(query);
            CommitChanges();
        }
        public int FindLastPurchase(Employee pharmacist)
        {
            int ans = 0;
            string query = "SELECT max(purchase_id) " +
                "FROM purchases " +
                "WHERE pharmacist_id IN " +
                "(SELECT employee_id " +
                "FROM employees " +
                "WHERE first_name = '" + pharmacist.first_name + "' " +
                "AND last_name = '" + pharmacist.last_name + "')";
            OracleDataReader dataReader = select(query);
            if (dataReader.HasRows)
            {
                if (dataReader.Read())
                {
                    ans = dataReader.GetInt32(0);
                    dataReader.Close();
                    return ans;
                }
            }
            throw new ArgumentNullException();
        }
        public void AddPurchasePart(PurchasePart med, int purchase_id)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string query = "INSERT INTO purchase_parts (purchase_id, medicine_id, amount, discount, prescription_number) " +
                "(SELECT " + purchase_id.ToString() + ", medicine_id, " + med.amount.ToString() + ", " + med.getDiscount.ToString(nfi) + ", '" + med.prescription_number + "' " +
                "FROM medicines " +
                "WHERE medicine_title = '" + med.medicine_title + "' " +
                "AND price = " + med.price.ToString(nfi) + " " +
                "AND provider_id IN " +
                "(SELECT provider_id FROM providers WHERE provider_title = '" + med.provider_title + "'))";
            ExNonQuery(query);
            query = "UPDATE medicines " +
                "SET leftover = leftover - " + med.amount.ToString(nfi) + " " +
                "WHERE medicine_title = '" + med.medicine_title + "' " +
                "AND price = " + med.price.ToString(nfi) + " " +
                "AND provider_id IN " +
                "(SELECT provider_id FROM providers WHERE provider_title = '" + med.provider_title + "')";
            ExNonQuery(query);
            CommitChanges();
        }
        public void AddAmount(Medicine med, int amount)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string query = "UPDATE medicines " +
                "SET leftover = leftover + " + amount.ToString(nfi) + " " +
                "WHERE medicine_title = '" + med.medicine_title + "' " +
                "AND price = " + med.price.ToString(nfi) + " " +
                "AND provider_id IN " +
                "(SELECT provider_id FROM providers WHERE provider_title = '" + med.provider_title + "')";
            ExNonQuery(query);
            CommitChanges();
        }
        public void AddMedicine(Medicine med)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string query = "INSERT INTO medicines (medicine_title, price, prescription_needed, provider_id, leftover) " +
                "(SELECT '" + med.medicine_title + "', " + med.price.ToString(nfi) + ", " + Convert.ToInt32(med.prescription_needed).ToString() + ", provider_id, " + med.LeftOver + " " +
                "FROM providers " +
                "WHERE provider_title = '" + med.provider_title + "')";
            ExNonQuery(query);
            CommitChanges();
        }
        private List<Purchase> GetPurchases(string query)
        {
            List<Purchase> purchases = new List<Purchase>();
            OracleDataReader dataReader = select(query);
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    purchases.Add(new Purchase(dataReader.GetInt32(0), new Employee(dataReader.GetString(1), dataReader.GetString(2), 0),
                        dataReader.GetDateTime(3), dataReader.GetDouble(4)));
                }
            }
            dataReader.Close();
            return purchases;
        }
    }
}
