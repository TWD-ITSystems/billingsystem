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
    public partial class formBlacklistMenu : Form
    {
        public int userID = 0;
        public int userAccess = 0;
        GlobalFunctions gfunc = new GlobalFunctions();

        public formBlacklistMenu()
        {
            InitializeComponent();
        }

        private void formBlacklistMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBlacklist.tbBlacklistAccounts' table. You can move, or remove it, as needed.
            this.tbBlacklistAccountsTableAdapter.Fill(this.dsBlacklist.tbBlacklistAccounts);
            toolStripButton3.Enabled = (tbBlacklistAccountsBindingSource.Count != 0);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (formBlacklistAdd frmBlackAdd = new formBlacklistAdd())
            {
                frmBlackAdd.userID = this.userID;
                frmBlackAdd.ShowDialog();
            }
            this.tbBlacklistAccountsTableAdapter.Fill(dsBlacklist.tbBlacklistAccounts);
            gridView1.RefreshData();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("status").ToString().Equals("active"))
            {
                MessageBox.Show("Cannot unblock this account. It's already active.","Unblock");
            }
            else
            {
                unblockedAccount(Convert.ToInt32(gridView1.GetFocusedRowCellValue("blacklist_id").ToString()));
            }
        }

        private void unblockedAccount(int blacklistID)
        {
            DialogResult dlg = MessageBox.Show("Do you want to unblock this account?", "Unblock", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {

                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    tbBlacklistAccount tbBlack = dbcontext.tbBlacklistAccounts.FirstOrDefault(x => x.blacklist_id == blacklistID);
                    if (tbBlack != null)
                    {
                        tbBlack.status = "active";
                        tbBlack.unblocked_by = gfunc.getUserInitials(userID);
                        tbBlack.unblocked_date = DateTime.Today;
                    }
                    dbcontext.SaveChanges();
                    MessageBox.Show("Account is now active.");
                    this.tbBlacklistAccountsTableAdapter.Fill(dsBlacklist.tbBlacklistAccounts);
                    gridView1.RefreshData();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            printableComponentLink1.CreateDocument();
            printableComponentLink1.ShowPreview();
        }
    }
}