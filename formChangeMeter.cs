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
    public partial class formChangeMeter : Form
    {
        public int userID = 0;

        GlobalFunctions gfunc = new GlobalFunctions();
        string acctno = "";
        string name = "";
        string newMet = "";
        string currMet = "";

        public formChangeMeter()
        {
            InitializeComponent();
        }



        private void formChangeMeter_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           

           
            var queryAcct = radGridView1.Rows.Where(x => x.Cells[1].Value.Equals(acctno));
            int qcount = queryAcct.Count();
            if (qcount > 0)
            {
                MessageBox.Show("Account No. is already added.");
                ClearData();
                txtAcctno.SelectAll();
                txtAcctno.Focus();
                return;
            }

            radGridView1.Rows.Add(false, acctno, name, newMet, txtReading.Text, dateTimePicker1.Value.ToShortDateString(),txtOldMet.Text);
            btnUpdate.Enabled = true;
            ClearData();
            comboBox1.SelectedIndex = 0;
            txtAcctno.SelectAll();
            txtAcctno.Focus();

        }

        private void txtAcctno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                acctno = txtAcctno.Text;
                name = gfunc.getAcctName(acctno);
                currMet = gfunc.getMeterNumber(acctno);
                labelName.Text = string.Format("Name: {0}",name);
                txtOldMet.Text = currMet;
                if (name.Length <= 0)
                {
                    MessageBox.Show(string.Format("Account No.: {0} not found. ", acctno));
                    txtAcctno.SelectAll();
                    txtAcctno.Focus();
                    return;
                }
                txtNewMet.SelectAll();
                txtNewMet.Focus();                
            }
        }

        private void txtNewMet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtNewMet.TextLength <= 0)
                {
                    MessageBox.Show("Please input new meter no.");
                    txtNewMet.Focus();
                    return;
                }
                newMet = string.Format("{0}{1}", comboBox1.Text, txtNewMet.Text);
                txtReading.SelectAll();
                txtReading.Focus();
            }
        }

        private void txtReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnAdd.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearData()
        {
            comboBox1.SelectedIndex = 0;
            txtNewMet.Clear();
            txtReading.Text = "0";
            labelName.Text = "Name:";
            txtOldMet.Clear();
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

        private void txtAcctno_Click(object sender, EventArgs e)
        {
            txtAcctno.SelectAll();
        }

        private void saveEntries()
        {
            string newMet = "";
            string oldmet = "";
            var queryGrid = radGridView1.Rows;
            string userName = gfunc.getUserInitials(userID);
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo cell in queryGrid)
                {
                    string acctno = cell.Cells[1].Value.ToString();
                    int masterID = gfunc.getMasterID(acctno);
                    DateTime date_replaced = Convert.ToDateTime(cell.Cells[5].Value);
                    newMet = cell.Cells[3].Value.ToString();
                    oldmet = cell.Cells[6].Value.ToString();


                    var qMaster = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                    qMaster.last_edit_by = userName;
                    qMaster.last_edit_date = DateTime.Now.Date;

                    tbMeter tMeter = new tbMeter();
                    tMeter.master_id = masterID;
                    tMeter.date_installed = date_replaced;
                    tMeter.meterno = newMet;
                    tMeter.prev_meter = oldmet;
                    qMaster.meter_id = saveMeter(tMeter);
                }
                dbcontext.SaveChanges();
            }
        }

        private int saveMeter(tbMeter newMet)
        {
            int recID = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                dbcontext.AddTotbMeters(newMet);
                dbcontext.SaveChanges();
                var returnID = newMet.meter_id;
                recID = returnID;
            }
            return recID;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            saveEntries();
            MessageBox.Show("Master table has been updated.");
            ClearData();
            radGridView1.Rows.Clear();
        }
    }
}
