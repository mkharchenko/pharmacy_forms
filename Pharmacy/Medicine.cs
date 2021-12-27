using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public class Medicine
    {
        public string medicine_title { get; protected set; }
        public double price { get; protected set; }
        public bool prescription_needed { get; protected set; }
        public string provider_title { get; protected set; }
        private int leftover;
        public int LeftOver
        {
            get
            {
                return leftover;
            }
            set
            {
                if (value >= 0)
                {
                    leftover = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public Medicine() { }
        public Medicine(string med_title, double price, bool pr_needed, string pr_title, int leftover)
        {
            this.medicine_title = med_title;
            this.price = price;
            this.prescription_needed = pr_needed;
            this.provider_title = pr_title;
            this.leftover = leftover;
        }
        public static void AddMedicine(Medicine med)
        {
            List<Medicine> meds = DBConnection.getInstance().getMedicines();
            foreach (var m in meds)
            {
                if (m.medicine_title == med.medicine_title && m.price == med.price && m.provider_title == med.provider_title)
                {
                    MessageBox.Show("Попытка добавить уже существующее лекарство");
                }
            }
            DBConnection.getInstance().AddMedicine(med);
        }
        public override string ToString()
        {
            return medicine_title + ", Цена: " + price.ToString() + ", Остаток: " + leftover.ToString();
        }
    }
}
