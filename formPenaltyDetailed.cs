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
    public partial class formPenaltyDetailed : Form
    {
        GlobalFunctions gfunc = new GlobalFunctions();

        public formPenaltyDetailed()
        {
            InitializeComponent();
        }

        private void formPenaltyDetailed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int billing_id = (int)comboBox1.SelectedValue;
            ArrayList param = new ArrayList();

            if (radioButton1.Checked)
            {
                string[] strBillMonth = comboBox1.Text.Split('-');
                int lastDayofmonth = DateTime.DaysInMonth(Convert.ToInt32(strBillMonth[1]),Convert.ToInt32(strBillMonth[0]));
                DateTime firstDate = new DateTime(Convert.ToInt32(strBillMonth[1]),Convert.ToInt32(strBillMonth[0]),1);
                DateTime lastDate = new DateTime(Convert.ToInt32(strBillMonth[1]),Convert.ToInt32(strBillMonth[0]),lastDayofmonth,23,59,59);
                //param.Add(billing_id);
                param.Add(firstDate);
                param.Add(lastDate);
                frmReport fPenalty = new frmReport();
                fPenalty.param = param;
                fPenalty.rptMode = 14;
                fPenalty.Show();
            }
            if (radioButton2.Checked)
            {
                param.Add(billing_id);
                param.Add(comboBox1.Text);
                frmReport fSenior = new frmReport();
                fSenior.param = param;
                fSenior.rptMode = 16;
                fSenior.Show();
            }
        }
    }
}
