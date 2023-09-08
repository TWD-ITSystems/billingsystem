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
    public partial class formDiscoUpdate : Form
    {
        public int userID = 0;
        GlobalFunctions gfunc = new GlobalFunctions();

        public formDiscoUpdate()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string acctno = txtAcctno.Text;
            var queryAcct = radGridView1.Rows.Where(x => x.Cells[1].Value.Equals(acctno));
            int qcount = queryAcct.Count();
            if (qcount > 0)
            {
                MessageBox.Show("Account No. is already added.");
            }
            else
            {
                string name = gfunc.getAcctName(acctno);
                int reading = int.TryParse(txtReading.Text,out reading)?reading:0;
                if ((txtAcctno.TextLength == 6) && (Int32.TryParse(txtReading.Text, out reading)) && (cmbTeams.Text.Length > 3))
                {
                      string zone = gfunc.getZoneName(acctno);
                      radGridView1.Rows.Add(false, acctno, name, zone, dateTimePicker1.Value.ToShortDateString(),reading.ToString(),txtTime.Value,cmbTeams.Text);                 
                      btnUpdate.Enabled = true;
                      txtReading.Text = "";
                      txtAcctno.Focus();
                      txtAcctno.SelectAll();
                }
                else
                {
                    MessageBox.Show("Invalid entries found. Please check your data.");
                }
                
            }
        }

        private void txtAcctno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (txtAcctno.TextLength == 6))
            {
                string acctno = txtAcctno.Text;
                var queryAcct = radGridView1.Rows.Where(x => x.Cells[1].Value.Equals(acctno));
                int qcount = queryAcct.Count();
                if (qcount > 0)
                {
                    MessageBox.Show("Account No. is already added.");
                }
                else
                {
                    string name = gfunc.getAcctName(acctno);
                    int masterID = gfunc.getMasterID(acctno);
                    if (name.Length > 0)
                    {
                        txtReading.Text = gfunc.getLastReading(masterID).ToString();
                        txtReading.Focus();
                        txtReading.SelectAll();
                        //  string zone = gfunc.getZoneName(acctno);
                        //  radGridView1.Rows.Add(false, acctno, name, zone, dateTimePicker1.Value.ToShortDateString());                 
                        //  btnUpdate.Enabled = true;
                    }
                    else
                    {
                        txtAcctno.Focus();
                        txtAcctno.SelectAll();
                    }
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
         
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveEntries()
        {
            var queryGrid = radGridView1.Rows;
            string userName = gfunc.getUserInitials(userID);
            string discoTeam = string.Empty;
            int last_reading = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo cell in queryGrid)
                {
                    string acctno = cell.Cells[1].Value.ToString();
                    DateTime discodate = Convert.ToDateTime(cell.Cells[4].Value);
                    discoTeam = cell.Cells[7].Value.ToString();
                    var qMaster = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                    //qMaster.status = "X ";
                    qMaster.last_disco_date = discodate.Date;
                    qMaster.last_edit_by = userName;
                    qMaster.last_edit_date = DateTime.Now.Date;

                    tbDiscoEntry disco = new tbDiscoEntry();
                    disco.disco_date = discodate.Date;
                    disco.entry_by = userName;
                    disco.master_id = gfunc.getMasterID(acctno);
                    //disco.zoneid = Convert.ToInt32(gfunc.getZoneUIDbyMaster(Convert.ToInt32(disco.master_id)));
                    disco.zoneid = gfunc.getZoneID((Convert.ToInt32(disco.master_id)));                    
                    disco.disco_team = discoTeam;

                    disco.last_reading_disco = Int32.TryParse(cell.Cells[5].Value.ToString(), out last_reading) ? last_reading : 0;
                    disco.entry_date = DateTime.Today;
                    
                    dbcontext.AddTotbDiscoEntries(disco);
                }
                dbcontext.SaveChanges();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbDiscoEntries.Where(x => x.processed == 0);
                if (query != null)
                {
                    foreach (tbDiscoEntry dEntry in query)
                    {
                        dEntry.zoneid = Convert.ToInt32(gfunc.getZoneID(Convert.ToInt32(dEntry.master_id)));
                    }
                    dbcontext.SaveChanges();
                    MessageBox.Show("Repair done");
                }
            }
        }

        private void formDiscoUpdate_Load(object sender, EventArgs e)
        {
            button1.Visible= userID == 2;
            txtTime.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);
            cmbTeams.KeyPress+=new KeyPressEventHandler(txtTime_KeyPress);
        }

        private void txtReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            int reading = 0;
            if ((e.KeyChar == 13) && (Int32.TryParse(txtReading.Text, out reading)))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }




    }
}
