using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;


namespace BillingSystem
{
    public partial class formBAMEntry : Form
    {

        public int userID = 0;
        const string DATAUSER = "commsys";
        const string DATAPASS = "comm123";
        const string DATABASE = "dbCommercial";
        string SERVER ="";

        GlobalFunctions globfunc = new GlobalFunctions();

        public formBAMEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var from = new formBAMEntryNew())
            {
                from.userID = this.userID;
                from.ShowDialog();

                
            }
        }

        private void formBAMEntry_Load(object sender, EventArgs e)
        {
            this.vwBAMEntriesTableAdapter.Fill(this.dsBAMEntries.vwBAMEntries);
            toolStripStatusLabel1.Text = string.Format("No. of BAMs : {0}", vwBAMEntriesBindingSource.Count);
            SERVER = ConfigurationManager.ConnectionStrings["ServerNew"].ConnectionString;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (formBAMEntryNew frmBAMnew = new formBAMEntryNew())
            {
                frmBAMnew.userID = this.userID;
                frmBAMnew.ShowDialog();
            }

            this.vwBAMEntriesTableAdapter.Fill(this.dsBAMEntries.vwBAMEntries);
            gridView1.RefreshData();
            
            toolStripStatusLabel1.Text = string.Format("No. of BAMs : {0}", vwBAMEntriesBindingSource.Count);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           int bamdetailID= Convert.ToInt32(gridView1.GetFocusedRowCellValue("bamdetail_id").ToString());
           string bamNo = gridView1.GetFocusedRowCellValue("bamno").ToString();
           DialogResult result = MessageBox.Show(string.Format("Do you want to print BAM No. : {0}",bamNo),"Print",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if (result == DialogResult.Yes)
           {
                ArrayList paramArr = new ArrayList();
                paramArr.Add(globfunc.getDeptDivHead(6));
                paramArr.Add(string.Format("{0}-{1} Division", globfunc.getDeptDivHeadDescription(6), globfunc.getDeptName(6)));
                paramArr.Add(bamdetailID);

                rptBAM rptbam = new rptBAM();
                rptbam.DataSourceConnections.Clear();
                rptbam.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                rptbam.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                rptbam.SetParameterValue("paramApproved", paramArr[0]);
                rptbam.SetParameterValue("paramDesignation", paramArr[1]);
                rptbam.SetParameterValue("paramBamid", paramArr[2]);
                rptbam.PrintToPrinter(1, false, 1, 1);
           }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            using (formBAMApproved frmBAMApp = new formBAMApproved(1,"View"))
            {
                frmBAMApp.bamdetail_id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("bamdetail_id").ToString());
                frmBAMApp.userID = this.userID;
                frmBAMApp.ShowDialog();
            }
        }


    }
}
