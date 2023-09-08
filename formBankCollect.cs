using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class formBankCollect : Form
    {
        public int userID = 0;

        GlobalFunctions globfunc = new GlobalFunctions();
        int masterID = 0;
        string billmonth = "";
        decimal TotalAmount = 0;
        int record_count = 0;
        decimal mtr_mtn = 0;
        public formBankCollect()
        {
            InitializeComponent();
        }

        private void formBankCollect_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBankCodes.tbBankCodes' table. You can move, or remove it, as needed.
            this.tbBankCodesTableAdapter.Fill(this.dsBankCodes.tbBankCodes);
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

        }

        private void txtAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtAcctNo.Text.Length < 6)
                {
                    MessageBox.Show("Account No. must be 6 char. in length.Please check.");
                    txtAcctNo.SelectAll();
                    return;
                }
                if (checkAccount(txtAcctNo.Text))
                {
                    MessageBox.Show("Account No. is already in the list.");
                    txtAcctNo.SelectAll();
                    return;
                }
               
                masterID = globfunc.getMasterID(txtAcctNo.Text);
                if (masterID == 0)
                {
                    MessageBox.Show("Account No. not found.");
                    txtAcctNo.SelectAll();
                    return;
                }
                billmonth = cmbBillMonth.Text;
                decimal? subTotal = 0;
                mtr_mtn = globfunc.getMeterMtn();
                cleartext();
                txtName.Text = globfunc.getMasterName(masterID);
                string zoneproc = globfunc.getZoneName(globfunc.getZoneID(masterID));
                txtZone.Text = zoneproc.Substring(0, 2);
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    tbBillingDetail billDetail = dbcontext.tbBillingDetails.FirstOrDefault(x => x.mrs_ref.Equals(billmonth) && x.master_id == masterID);
                    if (billDetail == null)
                    {
                        DialogResult dManual = MessageBox.Show("No Bill found. Do you want to enter payment manually?", "Manual Entry", MessageBoxButtons.YesNo);
                        if (dManual == DialogResult.Yes)
                        {
                            txtRefNo.Focus();
                        }
                        else
                        {
                            cleartext();
                            txtAcctNo.SelectAll();
                            return;
                        }
                    }
                    else
                    {
                        decimal penalty =checkIfPenalize(masterID);
                        subTotal = billDetail.current + billDetail.inst_fee + billDetail.arrears + billDetail.senior + mtr_mtn+billDetail.mtr_dmg+penalty;
                        txtRefNo.Text = billDetail.bill_ref_num;

                        txtCurrent.Text = string.Format("{0:#,##0.00}", billDetail.current);
                        txtArrears.Text = string.Format("{0:#,##0.00}", billDetail.arrears);
                        txtOthers.Text = string.Format("{0:#,##0.00}", billDetail.inst_fee);
                        txtSenior.Text = string.Format("{0:#,##0.00}", billDetail.senior);
                        txtDM.Text = string.Format("{0:#,##0.00}", billDetail.mtr_dmg);
                        txtTotal.Text = string.Format("{0:#,##0.00}", subTotal);
                        txtMtrMtn.Text = string.Format("{0:#,##0.00}", mtr_mtn);
                        txtPenalty.Text = string.Format("{0:#,##0.00}", penalty);
                        
                        btnAddToList.Focus();
                    }
                }
            }
        }

        private decimal checkIfPenalize(int masterID)
        {
            int billingID = (int)cmbBillMonth.SelectedValue;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var penalty_amt = dbcontext.tbLedgers.SingleOrDefault(x => x.code.Equals("PNLT") && x.master_id == masterID && x.billing_id == billingID);
                if (penalty_amt != null)
                {
                    return Convert.ToDecimal(penalty_amt.amount);
                }
                else
                {
                    return 0;
                }
            }
        }
        private void cleartext()
        {
            txtRefNo.Clear(); txtName.Clear(); txtZone.Clear(); txtCurrent.Clear();
            txtArrears.Clear(); txtOthers.Clear(); txtTotal.Clear(); txtSenior.Clear();
            txtMtrMtn.Clear(); txtDM.Clear(); txtPenalty.Clear();
        }

        private void txtAcctNo_Click(object sender, EventArgs e)
        {
            txtAcctNo.SelectAll();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            

            decimal current = decimal.TryParse(txtCurrent.Text, out current) ? current : 0;
            decimal arrears = decimal.TryParse(txtArrears.Text, out arrears) ? arrears : 0;
            decimal others = decimal.TryParse(txtOthers.Text, out others) ? others : 0;
            decimal senior = decimal.TryParse(txtSenior.Text, out senior) ? senior : 0;
            decimal mtrmtn = decimal.TryParse(txtMtrMtn.Text, out mtrmtn) ? mtrmtn : 0;
            decimal dmtr = decimal.TryParse(txtDM.Text, out dmtr) ? dmtr : 0;
            decimal total = decimal.TryParse(txtTotal.Text,out total)?total:0;
            decimal penalty = decimal.TryParse(txtPenalty.Text, out penalty) ? penalty : 0;

            //total = current + arrears + others + senior + mtrmtn;

            radGridView1.Rows.Add(false, txtRefNo.Text, txtAcctNo.Text, txtName.Text,txtZone.Text,
                current, arrears,penalty,others,dmtr,senior,total,masterID);
            TotalAmount = TotalAmount + total;
            record_count++;

            labelNumRec.Text = string.Format("Number of Records : {0}", record_count);
            labelTotalAmt.Text = string.Format("Total Amount : {0:#,##0.00}", TotalAmount);

            cleartext();
            txtAcctNo.Focus();
            txtAcctNo.SelectAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowcount = radGridView1.Rows.Count();
            for (int i = rowcount; i > 0; i--)
            {
                if (radGridView1.Rows[i - 1].Cells[0].Value.Equals(true))
                {
                    decimal amt = Convert.ToDecimal(radGridView1.Rows[i - 1].Cells[11].Value);
                    radGridView1.Rows[i - 1].Delete();

                    TotalAmount = TotalAmount - amt;
                    record_count--;
                }
            }
            labelNumRec.Text = string.Format("Number of Records : {0}", record_count);
            labelTotalAmt.Text = string.Format("Total Amount : {0:#,##0.00}", TotalAmount);
        }

        private bool checkAccount(string acctno)
        {
            bool retval = false;

            var racctno = radGridView1.Rows.Where(x => x.Cells[2].Value.Equals(acctno));
            if (racctno.Count() > 0)
            {
                retval = true;
            }
            return retval;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldtxt = this.Text;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                for (int i = 0; i < radGridView1.Rows.Count; i++)
                {
                    tbBankCollection bank = new tbBankCollection();

                    
                    bank.date_collected = Convert.ToDateTime(dtCollectDate.Value.ToShortDateString());
                    bank.collect_agent = comboBox1.Text;
                    bank.billmonth = cmbBillMonth.Text;
                    bank.zone = radGridView1.Rows[i].Cells[4].Value.ToString();
                    bank.refnum = radGridView1.Rows[i].Cells[1].Value.ToString();
                    bank.current = Convert.ToDecimal(radGridView1.Rows[i].Cells[5].Value);
                    bank.arrears = Convert.ToDecimal(radGridView1.Rows[i].Cells[6].Value);
                    bank.penalty = Convert.ToDecimal(radGridView1.Rows[i].Cells[7].Value);
                    bank.others = Convert.ToDecimal(radGridView1.Rows[i].Cells[8].Value);
                    bank.dmg_mtr = Convert.ToDecimal(radGridView1.Rows[i].Cells[9].Value);
                    bank.senior = Convert.ToDecimal(radGridView1.Rows[i].Cells[10].Value);
                    bank.totalamt = Convert.ToDecimal(radGridView1.Rows[i].Cells[11].Value);
                    bank.master_id = Convert.ToInt32(radGridView1.Rows[i].Cells[12].Value);


                    bank.mtr_mtn = bank.current>0?mtr_mtn:0;


                    bank.posted_by = globfunc.getUserInitials(userID);
                    bank.date_posted = DateTime.Now;

                    dbcontext.AddTotbBankCollections(bank);
                    this.Text = string.Format("Saving ... {0}", bank.master_id);
                    //tbMasterAcct mastacc = dbcontext.tbMasterAccts.Single(x => x.master_id == bank.master_id);


                }
                dbcontext.SaveChanges();
                MessageBox.Show("Payments has been posted successfully.");
                this.Text = oldtxt;
                radGridView1.Rows.Clear();
                cleartext();
                record_count = 0;
                TotalAmount = 0;
                labelNumRec.ResetText();
                labelTotalAmt.ResetText();
            }
        }

        private void txtCurrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                decimal current = decimal.TryParse(txtCurrent.Text, out current) ? current : 0;
                decimal arrears = decimal.TryParse(txtArrears.Text, out arrears) ? arrears : 0;
                decimal others = decimal.TryParse(txtOthers.Text, out others) ? others : 0;
                decimal senior = decimal.TryParse(txtSenior.Text, out senior) ? senior : 0;
                decimal mtrmtn = decimal.TryParse(txtMtrMtn.Text, out mtrmtn) ? mtrmtn : 0;
                decimal dmtr = decimal.TryParse(txtDM.Text, out dmtr) ? dmtr : 0;
                decimal penalty = decimal.TryParse(txtPenalty.Text, out penalty) ? penalty : 0;
                decimal total = 0;
                mtrmtn = current <= 0 ? 0 : mtr_mtn;
                txtMtrMtn.Text = mtrmtn.ToString();
                total = current + arrears + others + senior + mtrmtn+dmtr+penalty;
                txtTotal.Text = total.ToString("#,##0.00");
            }
        }

        private void txtRefNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCurrent.Focus();
                txtCurrent.SelectAll();
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAddToList.Focus();
            }
        }


    }
}
