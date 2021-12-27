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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBConnection.getInstance();
        }

        private void sale_click(object sender, EventArgs e)
        {
            sale s = new sale();
            s.Owner = this;
            this.Hide();
            s.Show();
            s.Left = this.Left;
            s.Top = this.Top;
        }

        private void incoming_button_Click(object sender, EventArgs e)
        {
            Income i = new Income();
            i.Owner = this;
            this.Hide();
            i.Show();
            i.Left = this.Left;
            i.Top = this.Top;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.getInstance().CloseConnection();
        }
    }
}
