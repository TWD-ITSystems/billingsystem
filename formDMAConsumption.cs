using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Collections;

namespace BillingSystem
{
    public partial class formDMAConsumption : Form
    {
        public int userID = 0;
        string conStr = ConfigurationManager.ConnectionStrings["BillingSystem.Properties.Settings.dbCommercialConnectionString"].ConnectionString;
        GlobalFunctions gfunc = new GlobalFunctions();
        public formDMAConsumption()
        {
            InitializeComponent();
        }

        private void formDMAConsumption_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.radGridView1.PrintPreview();
            DataTable dT = dsDMAResult.Tables[0];
            DataRow dr ;

            foreach (var cells in radGridView1.Rows)
            {
                dr = dT.NewRow();
                dr[0] = cells.Cells[0].Value.ToString();
                dr[1] = Convert.ToInt32(cells.Cells[1].Value.ToString());
                dr[2] = Convert.ToInt32(cells.Cells[2].Value.ToString());
                dr[3] = cells.Cells[3].Value.ToString();
                dT.Rows.Add(dr);
            }

            ArrayList param = new ArrayList();
            param.Add(comboBox1.Text);
            param.Add(gfunc.getUserFullName(userID));
            param.Add(gfunc.getUserJobDesc(userID));
            frmReport frmRpt = new frmReport(dsDMAResult);
            frmRpt.rptMode = 23;
            frmRpt.param = param;
            frmRpt.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int billing_id = (int)comboBox1.SelectedValue;
            dsDMAResult.Clear();
            radGridView1.Rows.Clear();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                string dma_address = "";
                int dma_searchstr = 0;
                int noSC = 0;
                int totalVol = 0;
                string dateRead = "";

                var dma_entries = dbcontext.tbDMALists;
                foreach (tbDMAList dma in dma_entries)
                {
                    dma_address = dma.subd_name;
                    dma_searchstr = dma.dma_id;
                    getDMAData(dma_searchstr, billing_id,ref noSC, ref totalVol,ref dateRead);
                    radGridView1.Rows.Add(dma_address, noSC.ToString(), totalVol.ToString(), dateRead);
                }
            }
        }

        private void getDMAData(int searchStr, int billingID, ref int noSC, ref int totalVol,ref string dateRead)
        {
            DateTime minDate = new DateTime();
            DateTime maxDate = new DateTime();
            using(SqlConnection conn=new SqlConnection(conStr))
            using(SqlCommand cmd = new SqlCommand("dbo.getDMAData",conn))
            {   
                cmd.CommandType=CommandType.StoredProcedure;

                cmd.Parameters.Add("@address", SqlDbType.Int);
                cmd.Parameters.Add("@billingID", SqlDbType.Int);
                cmd.Parameters.Add("@noSC", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@totalVol", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@minReadDate", SqlDbType.DateTime).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@maxReadDate", SqlDbType.DateTime).Direction = ParameterDirection.Output;

                cmd.Parameters["@address"].Value = searchStr;
                cmd.Parameters["@billingID"].Value = billingID;

                conn.Open();
                cmd.ExecuteNonQuery();

                noSC = Int32.TryParse(cmd.Parameters["@noSC"].Value.ToString(),out noSC)?noSC:0;
                totalVol = Int32.TryParse(cmd.Parameters["@totalVol"].Value.ToString(),out totalVol)?totalVol:0;
                minDate = DateTime.TryParse(cmd.Parameters["@minReadDate"].Value.ToString(),out minDate)?minDate:new DateTime(1900,1,1);
                maxDate = DateTime.TryParse(cmd.Parameters["@maxReadDate"].Value.ToString(),out maxDate)?maxDate:new DateTime(1900,1,1);
                if ((minDate == new DateTime(1900,1,1)) || (maxDate==new DateTime(1900,1,1)))
                {
                    dateRead = "No Data";
                }else{
                    dateRead = string.Format("{0:d} - {1:d}", minDate, maxDate);
                }
            }
        }
    }
}
