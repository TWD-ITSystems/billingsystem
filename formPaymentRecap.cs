using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BillingSystem
{
    public partial class formPaymentRecap : Form
    {
        public formPaymentRecap()
        {
            InitializeComponent();
        }

        private void formPaymentRecap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] bDate = comboBox1.Text.Split('-');
            int month = Convert.ToInt32(bDate[0]);
            int year = Convert.ToInt32(bDate[1]);
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            string str_month = string.Format("{0:Y}", startDate);
            ArrayList param = new ArrayList();
            param.Add(str_month);
            param.Add(startDate.Date);
            param.Add(endDate.Date);
            frmReport fRecap = new frmReport();
            fRecap.param = param;
            fRecap.rptMode = 18;
            fRecap.Show();

        }
    }
}
