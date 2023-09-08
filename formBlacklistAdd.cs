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
    public partial class formBlacklistAdd : Form
    {
        public int userID = 0;
        GlobalFunctions gfunc = new GlobalFunctions();
        int masterID = 0;

        public formBlacklistAdd()
        {
            InitializeComponent();
        }

        private void txAcctno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txName.Clear();
                txMessage.Clear();
                txReason.Clear();
                masterID = 0;

                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    tbMaster mast = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(txAcctno.Text));
                    if (mast == null)
                    {
                        MessageBox.Show("Account No. not found.");
                        txAcctno.SelectAll();
                        return;
                    }
                    masterID = mast.master_id;
                    txName.Text = mast.name;
                    txReason.Focus();
                }
            }
        }

        private bool checkIfBlocked(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbBlacklistAccount black = dbcontext.tbBlacklistAccounts.FirstOrDefault(x=>x.master_id==masterID && x.status.Equals("blocked"));
                return (black != null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txAcctno.TextLength != 6)
            {
                MessageBox.Show("Account No. is invalid.");
                return;
            }

            if (txReason.TextLength == 0)
            {
                MessageBox.Show("Please input reason for blocking.");
                return;
            }

            if (checkIfBlocked(masterID))
            {
                MessageBox.Show("This Account is already blocked.");
                txAcctno.SelectAll();
                return;
            }

            DialogResult dlg = MessageBox.Show("Are you sure to block this account?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                tbBlacklistAccount blocknew = new tbBlacklistAccount();
                blocknew.master_id = masterID;
                blocknew.acctno = txAcctno.Text;
                blocknew.name = txName.Text;
                blocknew.block_reason = txReason.Text;
                blocknew.blocked_date = DateTime.Today;
                blocknew.date_encoded = DateTime.Now;
                blocknew.added_by = gfunc.getUserInitials(userID);
                blocknew.status = "blocked";
                if (txMessage.TextLength > 0)
                {
                    blocknew.warning_message = txMessage.Text;
                }

                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    dbcontext.AddTotbBlacklistAccounts(blocknew);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Account has been blocked successfully.");
                }
                Close();
            }
        }

    }
}
