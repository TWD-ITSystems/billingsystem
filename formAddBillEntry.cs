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
    public partial class formAddBillEntry : Form
    {
        
        public int billproc_id = 0;
        public int userID = 0;
        public int zoneID = 0;
        public int meter_reader = 0;

        int master_id = 0;
        int current_volume = 0;
        tbBillingDetail bill_to_add = new tbBillingDetail();
        Boolean is_present_in_billfile = true;
        int billdetails_id = 0;
        DateTime date_pres = new DateTime();
        DateTime date_prev = new DateTime();
        decimal mtr_mtn = 0;

        public formAddBillEntry()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        { 
            
            if (e.KeyChar == 13)
            {
                using (dbCommercialEntities context = new dbCommercialEntities())
                {

                        var query = (from mast in context.tbMasters
                                     where mast.acctno == txtAcctNo.Text
                                     select new { master_id = mast.master_id, name = mast.name ,cardno=mast.cardno, zone = mast.zone_id,last_read_date=mast.last_read_date}).SingleOrDefault();
                        if (query != null)
                        {
                            if (zoneID != (int)query.zone)
                            {
                                DialogResult dialog = MessageBox.Show(string.Format("        Acct No. is not from zone {0}. \n Do you want to add this to billfile?.", new GlobalFunctions().getZoneName(zoneID)),"Zone Error",MessageBoxButtons.YesNo);
                                if (dialog == DialogResult.No)
                                {
                                    txtAcctNo.SelectAll();
                                    txtAcctNo.Focus();
                                    return;
                                }
                            }
                            master_id = (int)query.master_id;
                            setdsMasterQuery((int)query.master_id);
                            //lastReadDate = new GlobalFunctions().getPreviousReadDate(master_id, new GlobalFunctions().getBillingID(billproc_id));
                            labelName.Text = query.name;
                            labelCardNo.Text = string.Format("Card No.: {0}", query.cardno);
                        
                        }
                        else
                        {
                            MessageBox.Show("Acct No. not found in master");
                            txtAcctNo.SelectAll();
                            return;
                        }

                    {
                        tbBillingDetail bill_query = (from bill in context.tbBillingDetails
                                                      where bill.master_id == master_id && bill.billproc_id == billproc_id
                                                      select bill).SingleOrDefault();
                        if (bill_query != null)
                        {
                            DialogResult result = MessageBox.Show("Account No. is already in Bill file. \n Do you want to edit this instead?", "Edit Record", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                txtRdgPrev.Text = string.Format("{0}", bill_query.rdg_prev);
                                txtRdgPres.Text = string.Format("{0}", bill_query.rdg_pres);
                                datePrev.Value = (DateTime)bill_query.date_prev;
                                txtRdgPres.SelectAll();
                                txtRdgPres.Focus();
                                is_present_in_billfile = true;
                                billdetails_id = (int)bill_query.billingdetails_id;
                                btnLedger.Show();
                            }
                            else
                            {
                                txtAcctNo.SelectAll();
                                txtAcctNo.Focus();
                                labelName.Text = "";
                                return;
                            }
                        }
                        else
                        {

                            is_present_in_billfile = false;

                            DialogResult result = MessageBox.Show("Do you want to add this account to billfile?", "Add Record", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                tbMasterAcct mast_acct = (from mast_act in context.tbMasterAccts
                                                          where mast_act.master_id == master_id
                                                          select mast_act).Single();

                                txtRdgPrev.Text = mast_acct.rdg_prev.ToString();                  // previous reading   
                                bill_to_add.master_id = master_id;
                            }
                        }
                    }
                } // end using

                txtRdgPres.Focus();
                txtRdgPres.SelectAll();
            }
        } // end  private void txtAcctNo_KeyPress(object sender, KeyPressEventArgs e)

        private void setdsMasterQuery(int master_id)
        {
            this.tbMasterBindingSource.RemoveFilter();
            this.tbMasterBindingSource.Filter = "master_id =" + master_id.ToString();
        }
        
        private void txtRdgPres_KeyPress(object sender, KeyPressEventArgs e)
        {
            decimal current = 0;
            if (datePres.Value.Equals(new DateTime(1, 1, 1)))
            {
                MessageBox.Show("Please set Present Reading Date.");
                return;
            }
            if (datePrev.Value.Equals(new DateTime(1, 1, 1)))
            {
                MessageBox.Show("Please set Previous Reading Date.");
                return;
            }
            if (e.KeyChar == 13)
            { 

                current_volume = Convert.ToInt32(txtRdgPres.Text) - Convert.ToInt32(txtRdgPrev.Text);
                if (current_volume < 0)
                {
                    MessageBox.Show("Negative reading detected.");
                    txtRdgPres.SelectAll();
                    txtRdgPres.Focus();
                    return;
                }

                current = new GlobalFunctions().processCurrent(master_id, current_volume);
                current = current + new GlobalFunctions().getMeterMtn();
                if (is_present_in_billfile)
                {
                    radGridView1.Rows.Add(false, txtAcctNo.Text, labelName.Text,
                            string.Format("{0}", current), txtRdgPres.Text,
                            txtRdgPrev.Text, string.Format("{0}", current_volume),true,billdetails_id,datePres.Value,datePrev.Value);
                }
                else
                {
                    radGridView1.Rows.Add(false, txtAcctNo.Text, labelName.Text,
                            string.Format("{0}", current), txtRdgPres.Text,
                            txtRdgPrev.Text, string.Format("{0}", current_volume), false, 0, datePres.Value, datePrev.Value);
                }
                txtAcctNo.Focus();
                txtAcctNo.SelectAll();
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int bdetails_id = 0,master_id=0,currvol = 0;
            decimal current = 0;
            decimal mtr_mtn = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                mtr_mtn = new GlobalFunctions().getMeterMtn();
                for (int i = 0; i < radGridView1.Rows.Count(); i++)
                {
                    if (radGridView1.Rows[i].Cells[7].Value.Equals(true))
                    {
                        bdetails_id = Convert.ToInt32(radGridView1.Rows[i].Cells[8].Value.ToString());
                        tbBillingDetail bill_edit = (from en in dbcontext.tbBillingDetails
                                                     where en.billingdetails_id == bdetails_id
                                                     select en).Single();
                        master_id = bill_edit.master_id;
                        current = (decimal)radGridView1.Rows[i].Cells[3].Value;
                        bill_edit.date_pres = Convert.ToDateTime(radGridView1.Rows[i].Cells[9].Value);
                        bill_edit.date_prev = Convert.ToDateTime(radGridView1.Rows[i].Cells[10].Value);
                        bill_edit.current = current;
                        bill_edit.mtr_mtn = mtr_mtn;
                        bill_edit.rdg_pres = Convert.ToInt32(radGridView1.Rows[i].Cells[4].Value.ToString());
                        bill_edit.rdg_prev = Convert.ToInt32(radGridView1.Rows[i].Cells[5].Value.ToString());
                        bill_edit.volume = Convert.ToInt32(radGridView1.Rows[i].Cells[6].Value.ToString());
                        currvol = (int)bill_edit.rdg_pres - (int)bill_edit.rdg_prev;
                        bill_edit.read_edit_by = userID;
                        
                        dbcontext.SaveChanges();
                    }
                    else
                    {
                        bill_to_add.billproc_id = billproc_id;
                        master_id = new GlobalFunctions().getMasterID(radGridView1.Rows[i].Cells[1].Value.ToString());

                        bill_to_add.date_pres = Convert.ToDateTime(radGridView1.Rows[i].Cells[9].Value);
                        bill_to_add.date_prev = Convert.ToDateTime(radGridView1.Rows[i].Cells[10].Value);
                        current = (decimal)radGridView1.Rows[i].Cells[3].Value;
                        bill_to_add.current = current;
                        bill_to_add.mtr_mtn = mtr_mtn;
                        bill_to_add.rdg_pres = Convert.ToInt32(radGridView1.Rows[i].Cells[4].Value.ToString());
                        bill_to_add.rdg_prev = Convert.ToInt32(radGridView1.Rows[i].Cells[5].Value.ToString());
                        bill_to_add.volume = Convert.ToInt32(radGridView1.Rows[i].Cells[6].Value.ToString());
                        currvol = (int)bill_to_add.rdg_pres - (int)bill_to_add.rdg_prev;
                        bill_to_add.remarks = "OK";
                        bill_to_add.inst_fee = new GlobalFunctions().getIF2(master_id);
                        bill_to_add.arrears = new GlobalFunctions().getArrears(master_id);
                        bill_to_add.ave_vol = new GlobalFunctions().getAverageVolume(master_id);
                        bill_to_add.mtr_dmg = new GlobalFunctions().getDmgMtr(master_id);
                        bill_to_add.read_edit_by = userID;
                        bill_to_add.mtr_read_by = meter_reader;
                       // bill_to_add.mtr_mtn = new GlobalFunctions().getMeterMtn();

                        dbcontext.tbBillingDetails.AddObject(bill_to_add);
                        dbcontext.SaveChanges();
                    }
                }
                MessageBox.Show("Billfile entries has been saved successfully.");
                Close();
            }
        }

        private void getDatePresPrev()
        {
            using (dbCommercialEntities dcontext = new dbCommercialEntities())
            {
                var query = (from en in dcontext.tbBillingDetails
                             where en.billproc_id == billproc_id && en.date_pres != null
                             select new { master_id=en.master_id,datepres = en.date_pres, dateprev = en.date_prev }).First();
                int mast = (int)query.master_id;
                date_pres = (DateTime)query.datepres;
                date_prev = (DateTime)query.dateprev;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete all records marked with check. \n Proceed ?", "Delete Record", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int rowcount = radGridView1.Rows.Count();
                    for (int i = rowcount; i > 0; i--)
                    {
                        if (radGridView1.Rows[i-1].Cells[0].Value.Equals(true))
                        {
                            radGridView1.Rows[i-1].Delete();
                        }
                    }
                    if (radGridView1.Rows.Count() <= 0)
                    {
                        btnSave.Enabled = false;
                    }
                }
                catch 
                {
                    return;
                }
            }
        }

        private void formAddBillEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMaster.tbMaster' table. You can move, or remove it, as needed.
            this.tbMasterTableAdapter.Fill(this.dsMaster.tbMaster);
            getDatePresPrev();
        }

        private void txtRdgPrev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtRdgPres.SelectAll();
                txtRdgPres.Focus();
            }
        }

        private void tbMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbMasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsMaster);

        }

        private void btnLedger_Click(object sender, EventArgs e)
        {
            frmShowLedger frmLedger = new frmShowLedger();
            frmLedger.masterID = master_id;
            frmLedger.Show();
        }



    }
}
