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
    public partial class formBAMApprove : Form
    {
        public int userID = 0;

        public formBAMApprove()
        {
            InitializeComponent();
        }

        private void formBAMApprove_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBAMEntries.vwBAMEntries' table. You can move, or remove it, as needed.
            this.vwBAMEntriesTableAdapter.Fill(this.dsBAMEntries.vwBAMEntries);
            toolStripStatusLabel1.Text = string.Format("Total No. of BAMs: {0}",vwBAMEntriesBindingSource.Count);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using(formBAMApproved frmBAMApp = new formBAMApproved())
            {
                frmBAMApp.bamdetail_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("bamdetail_id").ToString());
                frmBAMApp.userID = this.userID;
                frmBAMApp.ShowDialog();
            }
            this.vwBAMEntriesTableAdapter.Fill(this.dsBAMEntries.vwBAMEntries);
            toolStripStatusLabel1.Text = string.Format("Total No. of BAMs: {0}", vwBAMEntriesBindingSource.Count);
        }
    }
}
