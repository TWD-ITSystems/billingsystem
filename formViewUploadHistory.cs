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
    public partial class formViewUploadHistory : Form
    {
        public formViewUploadHistory()
        {
            InitializeComponent();
        }

        private void formViewUploadHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsUploadHistory.tbMRSUploadHistory' table. You can move, or remove it, as needed.
            this.tbMRSUploadHistoryTableAdapter.Fill(this.dsUploadHistory.tbMRSUploadHistory);
            tabControl1.SelectedTab = tabPage1;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
      
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
      
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                DataRowView currRec = (DataRowView)tbMRSUploadHistoryBindingSource.Current;
                if (currRec == null) return;
                this.pMRSDownloadUploadTableAdapter.Fill(dsMRSDownUpload.pMRSDownloadUpload, currRec["up_zonebook"].ToString(), currRec["up_billmonth"].ToString());
            }
            else
            {
                this.tbMRSUploadHistoryTableAdapter.Fill(this.dsUploadHistory.tbMRSUploadHistory);
            }
        }
    }
}
