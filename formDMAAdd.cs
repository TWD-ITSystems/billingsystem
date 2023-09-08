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
    public partial class formDMAAdd : Form
    {
        public int userID  { get; set; }
        int totalRec = 0;
        List<int> rowList = new List<int>();
        GlobalFunctions gfunc = new GlobalFunctions();

        public formDMAAdd()
        {
            InitializeComponent();
        }

        private void formDMAAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDMAList.tbDMAList' table. You can move, or remove it, as needed.
            this.tbDMAListTableAdapter.Fill(this.dsDMAList.tbDMAList);
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    tbMaster master = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(textBox1.Text));
                    if (master == null)
                    {
                        MessageBox.Show("Account No. not found.");
                        textBox1.SelectAll();
                        return;
                    }
                    if (checkinList(master.master_id))
                    {
                        MessageBox.Show("Account No. is already in the list.");
                        textBox1.SelectAll();
                        return;
                    }

                    if (checkDMAList(master.master_id))
                    {
                        MessageBox.Show("Account No. is already in DMA list.");
                        textBox1.SelectAll();
                        return;
                    }
                    rowList.Add(master.master_id);
                    radGridView1.Rows.Add(false, textBox1.Text, master.name, master.address, comboBox1.SelectedValue, master.master_id);
                    textBox1.SelectAll();
                    totalRec++;
                    if (btnSave.Enabled==false) btnSave.Enabled= true;
                    label4.Text = totalRec.ToString();
                }
            }
        }

        private bool checkinList(int masterID)
        {
            if (rowList.Contains(masterID))
            {
                return true;
            }
            return false;
        }

        private bool checkDMAList(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbDMAEntry entry = dbcontext.tbDMAEntries.FirstOrDefault(x => x.master_id == masterID && x.dma_id!=0);
                if (entry != null) return true;
            }
            return false;
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
                        int testing = Convert.ToInt32(radGridView1.Rows[i-1].Cells[5].Value);
                        rowList.Remove(testing);
                        radGridView1.Rows[i - 1].Delete();
                        totalRec--;
                    }
                }
                if (radGridView1.Rows.Count() <= 0)
                {
                    btnSave.Enabled = false;
                }
                
                label4.Text = totalRec.ToString();
            }
            catch
            {}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the list?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    foreach(var currow in radGridView1.Rows)
                    {
                        tbDMAEntry entry = new tbDMAEntry();
                        entry.master_id = Convert.ToInt32(currow.Cells[5].Value);
                        entry.dma_id = Convert.ToInt32(currow.Cells[4].Value);
                        entry.added_by = gfunc.getUserInitials(userID);
                        entry.date_added = DateTime.Today;
                        dbcontext.AddTotbDMAEntries(entry);
                    }
                    dbcontext.SaveChanges();
                    MessageBox.Show("DMA List has been saved successfully.");
                    Close();
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll(); 
        }


    }
}
