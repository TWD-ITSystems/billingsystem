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
    public partial class formReconUpdate : Form
    {
        public int userID = 0;
        string acctno = "";
        string name = "";
        string mtrnum = "";
        GlobalFunctions gfunc = new GlobalFunctions();

        public formReconUpdate()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMeter.Mask = "A-000000000";
                txtMeter.Enabled = true;
                txtMeter.Focus();
                txtReading.Enabled = true;
                txtRemarks.Enabled = true;
                txtRemarks.Clear();
            }
            else
            {
                txtMeter.Clear();
                txtMeter.Enabled = false;
                txtReading.Enabled = false;
                txtRemarks.Enabled = false;
            }
        }

        private void txtAcctno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (txtAcctno.TextLength == 6))
            {
                acctno = txtAcctno.Text;
                name = gfunc.getAcctName(acctno);
                mtrnum = gfunc.getMeterNumber(acctno);
                if (name.Length > 0)
                {
                    txtOldmtr.Text = mtrnum.TrimEnd();
                    btnAdd.Focus();
                    //btnAdd.PerformClick();
                    //txtAcctno.SelectAll();
                }
                else
                {
                    txtReading.Clear();
                    checkBox1.Checked = false;
                    txtAcctno.Focus();
                    txtAcctno.SelectAll();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowcount = radGridView1.Rows.Count();
                for (int i = rowcount; i > 0; i--)
                {
                    if (radGridView1.Rows[i - 1].Cells[0].Value.Equals(true))
                    {
                        radGridView1.Rows[i - 1].Delete();
                    }
                }
                if (radGridView1.Rows.Count() <= 0)
                {
                    btnUpdate.Enabled = false;
                }
            }
            catch
            {
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string status = "";
            acctno = txtAcctno.Text;
            name = gfunc.getAcctName(acctno);
            status = gfunc.getStatus(gfunc.getMasterID(acctno));
            if (name.Length <= 0)
            {
                txtAcctno.SelectAll();
                txtAcctno.Focus();
                return;
            }
            /**
            if (!status.Trim().Equals("X"))
            {
                MessageBox.Show("Account is not disconnected(not marked X).");
                txtAcctno.SelectAll();
                txtAcctno.Focus();
                return;
            }*/
            var queryAcct = radGridView1.Rows.Where(x => x.Cells[1].Value.Equals(acctno));
            int qcount = queryAcct.Count();
            if (qcount > 0)
            {
                MessageBox.Show("Account No. is already added.");
                txtAcctno.SelectAll();
                txtAcctno.Focus();
                return;
            }
            if (checkBox1.Checked == true)
            {
                string newmeter = txtMeter.Text;
                int reading = Int32.TryParse(txtReading.Text, out reading) ? reading : 0;
                radGridView1.Rows.Add(false, acctno, name, newmeter,reading, dateTimePicker1.Value.ToShortDateString(),txtRemarks.Text,txtTeam.Text);
            }
            else
            {
                radGridView1.Rows.Add(false, acctno, name, "", "", dateTimePicker1.Value.ToShortDateString(),txtRemarks.Text,txtTeam.Text);
            }
            checkBox1.Checked = false;
            btnUpdate.Enabled = true;
            txtAcctno.SelectAll();
            txtAcctno.Focus();
            txtOldmtr.Clear();
        }

        private void txtMeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtReading.Focus();
                txtReading.SelectAll();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAcctno_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult lresult = MessageBox.Show("Do you want to save the entries?", "Save", MessageBoxButtons.YesNo);
            if (lresult == DialogResult.Yes)
            {
                saveEntries();
                MessageBox.Show("Accounts has been updated.");
                radGridView1.Rows.Clear();
                btnUpdate.Enabled = false;
            }
        }

        private void saveEntries()
        {
            var queryGrid = radGridView1.Rows;
            int masterID = 0;
            string userName = gfunc.getUserInitials(userID);
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo cell in queryGrid)
                {
                    string acctno = cell.Cells[1].Value.ToString();
                    DateTime reccodate = Convert.ToDateTime(cell.Cells[5].Value);
                    string meterno = cell.Cells[3].Value.ToString();
                    string lastreading = cell.Cells[4].Value.ToString();
                    string reconteam = cell.Cells[7].Value.ToString();

                    var qMaster = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                    qMaster.status = "";
                    qMaster.last_reco_date = reccodate.Date;
                    qMaster.last_edit_by = userName;
                    qMaster.last_edit_date = DateTime.Now.Date;
                    masterID = qMaster.master_id;
                    int initialReading = -1;
                    initialReading = Int32.TryParse(lastreading, out initialReading) ? initialReading : -1;
                    ProcessDisconnected(masterID,reconteam,reccodate,initialReading);
                    if (meterno.Length > 0)
                    {
                        string remarks = cell.Cells[6].Value.ToString();
                        string oldmtr = gfunc.getMeterNumber(acctno);
                        qMaster.meter_id = gfunc.saveNewMeterNo(masterID, meterno,oldmtr, reccodate.Date, remarks);
                    }
                    if (lastreading.Length > 0)
                    {
                        int reading;
                        if (Int32.TryParse(lastreading, out reading))
                        {
                            var qAcct = dbcontext.tbMasterAccts.FirstOrDefault(x => x.master_id == masterID);
                            qAcct.rdg_pres = reading;
                        }

                    }
                    
                }
                dbcontext.SaveChanges();
            }
        }

        private void ProcessDisconnected(int masterid,string recTeam,DateTime recoDate,int lastreading)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //tbDiscoEntry query = dbcontext.tbDiscoEntries.Where(x => x.processed == 0 && x.master_id == masterid).SingleOrDefault();
                //List<tbDiscoEntry> query = dbcontext.tbDiscoEntries.Where(x => x.processed == 0 && x.master_id == masterid).ToList<tbDiscoEntry>().OrderByDescending(x => x.disco_id).Select(x => x);
                //List<tbDiscoEntry> query = dbcontext.tbDiscoEntries.Where(x => x.processed == 0 && x.master_id == masterid).OrderByDescending(x => x.disco_id).ToList<tbDiscoEntry>();
                var query = dbcontext.tbDiscoEntries.Where(x => x.processed == 0 && x.master_id == masterid).OrderByDescending(x => x.disco_id);
                int cn = query.Count();
                foreach (tbDiscoEntry en in query)
                {
                    Console.WriteLine(en.disco_id);
                    int id = en.disco_id;
                    en.processed = 1;
                    en.processed_by = gfunc.getUserInitials(userID);
                    en.processed_date = DateTime.Today;
                    en.recon_team = recTeam;
                    en.recon_date = recoDate;
                    if (lastreading != -1)
                    { 
                        en.initial_reading_recon = lastreading;
                    }
                    break;
                }                                              
                dbcontext.SaveChanges();
            }
        }

        private void formReconUpdate_Load(object sender, EventArgs e)
        {
            button1.Visible = userID == 2;
        }

        private int RepairReconnectedAccounts()
        {
            int retval = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var queryDisco = dbcontext.tbDiscoEntries.Where(x => x.processed == 0 );
                if ((queryDisco != null) || (queryDisco.Count() > 0))
                {
                    foreach (tbDiscoEntry rDisco in queryDisco)
                    {
                        int masterID = Convert.ToInt32(rDisco.master_id);
                        DateTime recoDate = gfunc.getRecoDate(masterID);
                        DateTime discoDate = Convert.ToDateTime(rDisco.disco_date);

                        if (recoDate >= discoDate)
                        {
                            rDisco.processed = 1;
                            rDisco.processed_by = gfunc.getUserInitials(userID);
                            rDisco.processed_date = DateTime.Today;
                            markActive(masterID);

                        }
                    }

                    dbcontext.SaveChanges();
                }
            }
            return retval;
        }


        private void markActive(int masterid)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbMasters.FirstOrDefault(x => x.master_id == masterid);
                if (query != null)
                {
                    if (query.status.Trim().Equals("X"))
                    {
                        query.status = "";
                    }
                }
                dbcontext.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RepairReconnectedAccounts();
            MessageBox.Show("Repair is done");
        }

    }
}
