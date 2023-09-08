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
    public partial class formPrintAging : Form
    {
        int billing_id = 0;
        public formPrintAging()
        {
            InitializeComponent();
        }

        private void formPrintAging_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string comm_mngr = dbcontext.tbDeptDivisionHeads.First(x => x.DeptDiv.Equals("Commercial")).DeptDivHead;
                string gm = dbcontext.tbDeptDivisionHeads.First(x => x.DeptDiv.Equals("OGM")).DeptDivHead;

                txtVerify.Text = comm_mngr;
                txtNoted.Text = gm;

                comboBox1.SelectedIndex = 0;
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            billing_id = (int)cmbBillMonth.SelectedValue;
            string dategen = getGenerationDate(billing_id);
            
            int balances = 0;
            int negbalance = 0;
            int zerobalance = 0;
            string status = comboBox1.Text.Equals("active")?"":"X";

            if (dategen.Length <= 0)
            {
                MessageBox.Show(string.Format("No aging for the billmonth of {0}. Please generate first.", cmbBillMonth.Text));
                return;
            }

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                if (status.Equals("X"))
                {
                    balances = dbcontext.tbMasterAgings.Where(x => x.billing_id == billing_id && x.ctgy != 0 && x.zone_id != 0 && x.status.Equals(status)).Count(x => x.balance > 0);
                    negbalance = dbcontext.tbMasterAgings.Where(x => x.billing_id == billing_id && x.ctgy != 0 && x.zone_id != 0 && x.status.Equals(status)).Count(x => x.balance < 0);
                    zerobalance = dbcontext.tbMasterAgings.Where(x => x.billing_id == billing_id && x.ctgy != 0 && x.zone_id != 0 && x.status.Equals(status)).Count(x => x.balance == 0);
                }
                else
                {
                    balances = dbcontext.tbMasterAgings.Where(x => x.billing_id == billing_id && x.ctgy != 0 && x.zone_id != 0 && (x.status.Equals(status) || x.status.Equals("E"))).Count(x => x.balance > 0);
                    negbalance = dbcontext.tbMasterAgings.Where(x => x.billing_id == billing_id && x.ctgy != 0 && x.zone_id != 0 && (x.status.Equals(status) || x.status.Equals("E"))).Count(x => x.balance < 0);
                    zerobalance = dbcontext.tbMasterAgings.Where(x => x.billing_id == billing_id && x.ctgy != 0 && x.zone_id != 0 && (x.status.Equals(status) || x.status.Equals("E"))).Count(x => x.balance == 0);
                }
                
                
            }


            ArrayList param = new ArrayList();
            param.Add(dategen);
            param.Add(comboBox1.Text); //status : active;inactive
            param.Add(cmbBillMonth.Text);
            param.Add(balances);
            param.Add(negbalance);
            param.Add(zerobalance);
            param.Add(txtPrepared.Text);
            param.Add(txtDesignation.Text);
            param.Add(txtVerify.Text);
            param.Add(txtNoted.Text);

            frmReport fReport = new frmReport();
            fReport.param = param;
            fReport.rptMode = 11;
            fReport.Show();
        }


        private string getGenerationDate(int billing_id)
        {
            string retval = "";

            string[] billstr = cmbBillMonth.Text.Split('-');
            int month_int = Convert.ToInt32(billstr[0]);
            int year_int = Convert.ToInt32(billstr[1]);
            int daysinmonth = DateTime.DaysInMonth(year_int,month_int);
            DateTime lastmonthdate = new DateTime(year_int,month_int,daysinmonth);
            retval = lastmonthdate.ToShortDateString();
            return retval;
        }

        private void btnZone_Click(object sender, EventArgs e)
        {
            billing_id = (int)cmbBillMonth.SelectedValue;
            string dategen = getGenerationDate(billing_id);
            string status = comboBox1.Text.Equals("active") ? " " : "X";
           
            if (dategen.Length <= 0)
            {
                MessageBox.Show(string.Format("No aging for the billmonth of {0}. Please generate first.", cmbBillMonth.Text));
                return;
            }

            ArrayList param = new ArrayList();
            param.Add(dategen);
            param.Add(status); //status : active;inactive
            param.Add(billing_id);
            param.Add(txtPrepared.Text);
            param.Add(txtDesignation.Text);
            param.Add(txtVerify.Text);
            param.Add(txtNoted.Text);

            frmReport fReport = new frmReport();
            fReport.param = param;
            fReport.rptMode = 12;
            fReport.Show();
        }

        private void btnRecap_Click(object sender, EventArgs e)
        {
            billing_id = (int)cmbBillMonth.SelectedValue;
            string dategen = getGenerationDate(billing_id);
            
            if (dategen.Length <= 0)
            {
                MessageBox.Show(string.Format("No aging for the billmonth of {0}. Please generate first.", cmbBillMonth.Text));
                return;
            }

            ArrayList param = new ArrayList();
            param.Add(dategen);
            param.Add(billing_id);
            param.Add(txtPrepared.Text);
            param.Add(txtDesignation.Text);
            param.Add(txtVerify.Text);
            param.Add(txtNoted.Text);

            frmReport fReport = new frmReport();
            fReport.param = param;
            fReport.rptMode = 13;
            fReport.Show();
        }
    }
}
