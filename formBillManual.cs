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
    public partial class formBillManual : Form
    {
        
        public int userID = 0;
        public string userName = string.Empty;
        int mtrReader_id = 0;
        int zoneID = 0;
        classMasterData mData = new classMasterData();
        GlobalFunctions globalfunc = new GlobalFunctions();
        decimal mtr_mtn = 0;
        int billproc_id = 0;
        int billing_id = 0;
        string billmonth = "";
        string zonebook = "";
        Telerik.WinControls.UI.GridViewRowCollection gridRows;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                int masterID = globalfunc.getMasterID(this.txtAcctNo.Text);
                frmShowLedger frmLedger = new frmShowLedger(masterID);
                //frmShowLedger frmLedger = new frmShowLedger(masterID);
                frmLedger.Show();
                
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public formBillManual()
        {
            
            InitializeComponent();
        }

        private void formBillManual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            panel1.Height = 100;
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);            
            loadZones();
            loadRemarks();
            txtEncoder.Text = userName;
            cmbZone_SelectedIndexChanged(sender, e);
            mtr_mtn = globalfunc.getMeterMtn();
        }

        private void loadZones()
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbZones
                             select en);
                tbZoneBindingSource.DataSource = query;
            }
        }

        private void loadRemarks()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from en in dbcontext.tbServiceRequestCodes
                             select en.code_desc);
                cmbRemarks.Items.AddRange(query.ToArray());
            }
        }

        private void cmbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbZone tst = (tbZone)cmbZone.SelectedValue;
            if (tst != null)
            {
                mtrReader_id = (int)tst.mtr_reader;
                zoneID = (int)tst.zone_id;
                setMeterReader(mtrReader_id);
            }
        }

        private void setMeterReader(int mtrRdr)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from en in dbcontext.tbMeterReaders
                             where en.mr_id == mtrRdr
                             select en.mr_name).SingleOrDefault();
                if (query != null)
                {
                    txtMtrReader.Text = query.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
            if (checkBillFile())
            {
                MessageBox.Show("Billfile is already been made. Please use the checking module to edit.","Error");
            }
            else
            {
                panel1.Height = 152;
                panelCombo.Enabled = false;
                btnCancel.Show();
                button1.Hide();
                txtAcctNo.Focus();
                
             //   var test = gridBilling.Rows.Where(p => p.Cells[0].IsSelected == true);
            } */

            panel1.Height = 152;
            panelCombo.Enabled = false;
            btnCancel.Show();
            button1.Hide();
            zonebook = cmbZone.Text;
            billmonth = cmbBilling.Text;
            txtAcctNo.Focus();
            
        }

        private bool checkBillFile()
        {
            string zone = cmbZone.Text;
            int billID = (int)cmbBilling.SelectedValue;
            bool resultval = false;
            using(dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var billfile = (from en in dbcontext.tbBillProcessings
                                where (en.billing_id == billID) && (en.zone_book.Equals(zone))
                                select en);
                if (billfile != null) 
                {
                    if (billfile.Count() > 0)
                    {
                        resultval = true;
                    }
                }
            }
            return resultval;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Height = 100;
            gridBilling.Rows.Clear();
            panelCombo.Enabled = true;
            cmbZone_SelectedIndexChanged(sender, e);
            button1.Show();
            btnCancel.Hide();
            btnSave.Hide();
            labelRecNum.Text = "";
            //var test = gridBilling.Rows.Where(p => p.Cells[0].Value.Equals(true));
            //foreach (var cell in test)
            //{
            //    MessageBox.Show(cell.Cells[2].Value.ToString());
            //}
        }

        private void txtAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!checkAccount(txtAcctNo.Text))
                {
                    mData = searchData();
                    if (mData != null)
                    {
                        labelName.Text = mData.name;
                        spinPrev.Value = Convert.ToInt32(mData.rdg_prev);
                        spinPres.Focus();
                        cmbRemarks.SelectedIndex = 20;
                        btnLedger.Show();
                    }
                    else
                    {
                        txtAcctNo.SelectAll();
                        clearData();
                        btnLedger.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Account No. is already in the list. Please delete it first.");
                    txtAcctNo.SelectAll();
                    btnLedger.Hide();
                }
            }
        }

        private classMasterData searchData()
        {
            classMasterData MasterData = new classMasterData();            
            using(dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = (from m in dbcontext.tbMasters
                             join mA in dbcontext.tbMasterAccts on m.master_id equals mA.master_id
                             where m.acctno.Equals(txtAcctNo.Text)
                             select new
                             {
                                 master_id = m.master_id,
                                 cardno = m.cardno,
                                 acctno = m.acctno,
                                 name = m.name,
                                 zone_id = m.zone_id,
                                 rdg_pres = mA.rdg_pres,
                                 ave_vol = mA.ave_vol,
                                 date_pres = m.last_read_date
                             }).SingleOrDefault();
                if (query != null)
                {
                    if (query.zone_id != zoneID)
                    {
                        MessageBox.Show(string.Format("Account is not from Zone {0}", cmbZone.Text));
                        return null;
                    }
                    MasterData.master_id = query.master_id;
                    MasterData.acctno = query.acctno;
                    //MasterData.cardno = query.cardno;
                    MasterData.name = query.name;
                    MasterData.rdg_prev = query.rdg_pres.HasValue?(int)query.rdg_pres:0;    // pres will now be prev
                    MasterData.ave_vol = query.ave_vol.HasValue ? (int)query.ave_vol : 0;
                    MasterData.readtime = DateTime.Now.TimeOfDay.ToString();
                    MasterData.remarks = cmbRemarks.Text;
                    if (query.date_pres.HasValue)
                    {
                        MasterData.date_prev = (DateTime)query.date_pres;
                    }
                }
                else
                {
                    MessageBox.Show("Account no. not found. ");
                    return null;
                }
                
            }
            return MasterData;
        }

        private void spinPres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (spinPres.Value >= spinPrev.Value)
                {
                    decimal penalty = 0.00m;
                    decimal current = 0.00m;
                    int cuM = Convert.ToInt32(spinPres.Value) - Convert.ToInt32(spinPrev.Value);
                    current = globalfunc.processCurrent(mData.master_id, cuM);
                    penalty = globalfunc.computePenalty(current);
                    gridBilling.Rows.Add(false, mData.master_id, mData.cardno, txtAcctNo.Text, 
                                         mData.name, spinPres.Value.ToString(), spinPrev.Value.ToString(), 
                                         cuM, cmbRemarks.Text, current,penalty,
                                         mData.date_prev,mData.readtime,mData.ave_vol
                                         );
                    labelRecNum.Text = string.Format("Record count: {0}", gridBilling.Rows.Count);
                    txtAcctNo.SelectAll();
                    txtAcctNo.Focus();
                    clearData();
                    if (!btnSave.Visible) {btnSave.Visible=true;}
                }
                else
                {
                    MessageBox.Show("Negative Reading detected. Please check again.");
                    spinPres.SelectAll();                    
                }
            }
        }

        private void clearData()
        {
            labelName.Text = string.Empty;
            spinPrev.Value = 0;
            spinPres.Value = 0;
            cmbRemarks.SelectedIndex = 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowcount = gridBilling.Rows.Count();
            for (int i = rowcount; i > 0; i--)
            {
                if (gridBilling.Rows[i - 1].Cells[0].Value.Equals(true))
                {
                    gridBilling.Rows[i - 1].Delete();
                }
            }
            labelRecNum.Text = string.Format("Record count: {0}", gridBilling.Rows.Count);
        }

        private bool checkAccount(string acctno)
        {
            bool retval = false;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        

            var isPresent = gridBilling.Rows.Where(p => p.Cells[3].Value.Equals(acctno));
            if (isPresent.Count() > 0)
            {
                retval = true;               
            }
            return retval;
        }

        private void centerToForm(Control control,bool show=false)
        {
            control.Left = (this.Width - control.Width) / 2;
            control.Top = (this.Height - control.Height) / 2;
            control.Visible = show;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gridRows = gridBilling.Rows;
            billproc_id = saveBillProcessing();
            centerToForm(progressPanel1,true);
            backgroundWorker1.RunWorkerAsync();
        }

        private int saveBillProcessing()
        {
            int retval = 0;
            tbBillProcessing billproc = new tbBillProcessing();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                billproc.billing_id = Convert.ToInt32(cmbBilling.SelectedValue);
                billproc.zone_book = cmbZone.Text;
                billproc.meter_reader = txtMtrReader.Text;
                billproc.date_processed = dateToday.Value;
                billproc.processed_by = (short)userID;

                dbcontext.AddTotbBillProcessings(billproc);
                dbcontext.SaveChanges();
                retval = billproc.bill_process_id;
            }
            return retval;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (var rows in gridRows)
                {
                    tbBillingDetail billDetails = new tbBillingDetail();

                    billDetails.ave_vol = Convert.ToInt32(rows.Cells[13].Value);
                    billDetails.current = Convert.ToDecimal(rows.Cells[9].Value);
                    billDetails.date_pres = datePres.Value;
                    billDetails.date_prev = Convert.ToDateTime(rows.Cells[11].Value);
                    billDetails.volume = Convert.ToInt32(rows.Cells[7].Value);
                    billDetails.penalty = Convert.ToDecimal(rows.Cells[10].Value);
                    billDetails.mtr_mtn = mtr_mtn;
                    billDetails.rdg_prev = Convert.ToInt32(rows.Cells[6].Value);
                    billDetails.rdg_pres = Convert.ToInt32(rows.Cells[5].Value);
                    billDetails.master_id = Convert.ToInt32(rows.Cells[1].Value);
                    billDetails.billproc_id = billproc_id;                    
                    billDetails.readtime = DateTime.Parse(rows.Cells[12].Value.ToString()).ToString("HH:mm");
                    billDetails.remarks = rows.Cells[8].Value.ToString();
                    billDetails.mtr_read_by = mtrReader_id;
                    billDetails.read_edit_by = userID;

                    dbcontext.AddTotbBillingDetails(billDetails);
                    dbcontext.SaveChanges();
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressPanel1.Hide();
            MessageBox.Show("Billfile has been saved successfully and now ready for checking.");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //var dRecords = dbcontext.tbMRSUploads.Where(x => x.Field<string>("md_billno").Length == 10).Select(x => x);
                var dRecords = dbcontext.tbMRSUploads.Where(x =>x.md_billno.Length==10 && x.md_billmonth.Equals(billmonth) && x.md_zone.Equals(zonebook)).Select(x => x);
                foreach (var drec in dRecords)
                {
                    

                }
            }
        }

   }
}       
