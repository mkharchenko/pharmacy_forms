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
    public partial class Income : Form
    {
        int last_index = -1;
        public Income()
        {
            InitializeComponent();
        }

        private void Income_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Left = this.Left;
            this.Owner.Top = this.Top;
            this.Owner.Show();
        }

        private void Income_VisibleChanged(object sender, EventArgs e)
        {
            updateMedicines();
            updateProviders();
            updateAddForm();
        }
        public void updateProviders()
        {
            provider_combobox.DataSource = null;
            List<Provider> providers = DBConnection.getInstance().getProviders();
            provider_combobox.DataSource = providers;
        }

        public void updateMedicines()
        {
            med_listbox.DataSource = null;
            List<Medicine> meds = DBConnection.getInstance().getMedicines();
            med_listbox.DataSource = meds;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string key_word = searchbox.Text;
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

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            last_index = -1;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int amount = 0;
            try
            {
                amount = Convert.ToInt32(amount_textbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно заполнено поле добавления");
                return;
            }
            if (med_listbox.SelectedItem == null)
            {
                MessageBox.Show("Не выбран медикамент");
                return;
            }
            if ((med_listbox.SelectedItem as Medicine).LeftOver + amount < 0)
            {
                MessageBox.Show("Неправильно указано количество");
                return;
            }
            DBConnection.getInstance().AddAmount((med_listbox.SelectedItem as Medicine), amount);
            updateMedicines();
            amount_textbox.Text = "";
        }

        private void newmed_button_Click(object sender, EventArgs e)
        {
            string med_title = title_textbox.Text;
            double price = 0;
            bool receipt_needed = prescription_checkbox.Checked;
            int amount = 0;
            string provider_title = "";
            if (title_textbox.Text == "" || price_textbox.Text == "" || quantity_textbox.Text == "")
            {
                MessageBox.Show("Неправильно заполнены поля формы.");
                return;
            }
            if (provider_combobox.SelectedItem == null)
            {
                MessageBox.Show("Не выбран поставщик лекарства.");
                return;
            }
            try
            {
                price = Convert.ToDouble(price_textbox.Text);
                amount = Convert.ToInt32(quantity_textbox.Text);
                provider_title = (provider_combobox.SelectedItem as Provider).title;
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно заполнены поля формы.");
                return;
            }
            Medicine med = new Medicine(med_title, price, receipt_needed, provider_title, amount);
            Medicine.AddMedicine(med);
            updateMedicines();
            updateAddForm();
        }
        public void updateAddForm()
        {
            title_textbox.Text = "";
            price_textbox.Text = "";
            quantity_textbox.Text = "";
            prescription_checkbox.Checked = false;
        }
    }
}
