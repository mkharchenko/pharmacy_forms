using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class sale : Form
    {
        Purchase purchase;
        int last_index = -1;
        public sale()
        {
            InitializeComponent();
            purchase = new Purchase();
        }

        private void sale_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Left = this.Left;
            this.Owner.Top = this.Top;
            this.Owner.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatePharmacists()
        {
            pharmacists_combobox.DataSource = null;
            List<Employee> emp = DBConnection.getInstance().getPharmacists();
            pharmacists_combobox.DataSource = emp;
        }

        public void updateMedicines()
        {
            med_listbox.DataSource = null;
            List<Medicine> meds = DBConnection.getInstance().getMedicines();
            med_listbox.DataSource = meds;
        }

        private void sale_VisibleChanged(object sender, EventArgs e)
        {
            updatePharmacists();
            updateMedicines();
            UpdateSaleTexts();
        }

        private void med_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (med_listbox.SelectedItem != null)
            {
                prescription_box.Enabled = (med_listbox.SelectedItem as Medicine).prescription_needed;
            }
            else
            {
                prescription_box.Enabled = false;
            }
            prescription_box.Text = "";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int amount = 0;
            int discount = 0;
            string prescription_number = "";
            try
            {
                amount = Convert.ToInt32(quantity_box.Text);
                discount = Convert.ToInt32(discount_textbox.Text);
                prescription_number = prescription_box.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно заполнены поля формы");
                return;
            }
            if (amount <= 0 || amount > (med_listbox.SelectedItem as Medicine).LeftOver)
            {
                MessageBox.Show("Неправильно указано количество товара");
                return;
            }
            if ((med_listbox.SelectedItem as Medicine).prescription_needed && prescription_box.Text == "")
            {
                MessageBox.Show("Не указан номер рецепта.");
                return;
            }
            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("Неправильно указана скидка");
                return;
            }
            Medicine toAdd = (med_listbox.SelectedItem as Medicine);
            if (purchase.isInPurchase(toAdd))
            {
                MessageBox.Show("Данный медикамент уже находится в чеке.");
                return;
            }
            purchase.purchases.Add(new PurchasePart(toAdd, amount, discount, prescription_number));
            UpdatePurchase();
        }

        private void medsearch_button_Click(object sender, EventArgs e)
        {
            string key_word = medsearch_box.Text;
            for (int i = last_index + 1; i < med_listbox.Items.Count; i++)
            {
                if ((med_listbox.DataSource as List<Medicine>)[i].medicine_title.Contains(key_word))
                {
                    last_index = i;
                    med_listbox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void medsearch_box_TextChanged(object sender, EventArgs e)
        {
            last_index = -1;
        }
        private void UpdateSumLabel()
        {
            SumLabel.Text = "Итого: " + purchase.getSum().ToString();
        }
        private void UpdateSaleTexts()
        {
            quantity_box.Text = "0";
            prescription_box.Text = "";
            discount_textbox.Text = "0";
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (sales_listbox.SelectedItem != null)
            {
                purchase.DeletePurchasePart(sales_listbox.SelectedItem as PurchasePart);
                UpdatePurchase();
            }
        }
        private void UpdatePurchase()
        {
            sales_listbox.DataSource = null;
            sales_listbox.DataSource = purchase.purchases;
            UpdateSumLabel();
            UpdateSaleTexts();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (pharmacists_combobox.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать фармацевта");
                return;
            }
            purchase.CommitPurchase(pharmacists_combobox.SelectedItem as Employee);
            purchase = new Purchase();
            UpdatePurchase();
            updateMedicines();
        }
    }
}
