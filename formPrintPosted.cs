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
    public partial class formPrintPosted : Form
    {
        public formPrintPosted()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            string bank = comboBox1.SelectedValue.ToString();
            string period = "";

            period = string.Format("Collection from {0:d} to {1:d}", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            param.Add(comboBox1.Text);
            param.Add(period);
            param.Add(dateTimePicker1.Value.ToShortDateString());
            param.Add(dateTimePicker2.Value.ToShortDateString());
            param.Add(bank);
            param.Add(txtPrepared.Text);
            param.Add(txtNoted.Text);
            param.Add(txtChecked.Text);
            param.Add(txtRemarks.Text);

            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 6;
            frmRpt.param = param;
            frmRpt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formPrintPosted_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBankCodes.tbBankCodes' table. You can move, or remove it, as needed.
            this.tbBankCodesTableAdapter.Fill(this.dsBankCodes.tbBankCodes);

        }
    }
}
