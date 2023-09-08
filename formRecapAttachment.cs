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
    public partial class formRecapAttachment : Form
    {
        public formRecapAttachment()
        {
            InitializeComponent();
        }

        private void formRecapAttachment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            cmbBillmonth.SelectedIndex = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            int zoneid = (int)cmbZone.SelectedValue;
            int billingid = (int)cmbBillmonth.SelectedValue;
            param.Add(textBox1.Text);
            param.Add(textBox2.Text);
            param.Add(billingid);
            param.Add(zoneid);
            param.Add(cmbBillmonth.Text);
            param.Add(cmbZone.Text);
            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 9;
            frmRpt.param = param;
            frmRpt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            int zoneid = (int)cmbZone.SelectedValue;
            int billingid = (int)cmbBillmonth.SelectedValue;
            param.Add(textBox1.Text);
            param.Add(textBox2.Text);
            param.Add(billingid);
            param.Add(zoneid);
            param.Add(cmbBillmonth.Text);
            param.Add(cmbZone.Text);
            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 10;
            frmRpt.param = param;
            frmRpt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            string billmonth = cmbBillmonth.Text;
            param.Add(billmonth);
            param.Add(textBox1.Text);
            param.Add(textBox2.Text);
            param.Add(textBox3.Text);
            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 15;
            frmRpt.param = param;
            frmRpt.Show();

        }
    }
}
