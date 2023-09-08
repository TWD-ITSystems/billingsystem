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
    public partial class formBAMDetailed : Form
    {
        public formBAMDetailed()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string[] strdate = comboBox1.Text.Split('-');
            int month = Convert.ToInt32(strdate[0]);
            int year = Convert.ToInt32(strdate[1]);
            int num_of_days = DateTime.DaysInMonth(year, month);
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, num_of_days);

            ArrayList param = new ArrayList();
            param.Add(comboBox1.Text);
            param.Add(startDate.Date);
            param.Add(endDate.Date);
            frmReport frmRpt = new frmReport();
            frmRpt.param = param;
            frmRpt.rptMode = 17;
            frmRpt.Show();
        }

        private void formBAMDetailed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
        }
    }
}
