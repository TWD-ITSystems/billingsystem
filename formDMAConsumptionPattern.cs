using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Threading.Tasks;


namespace BillingSystem
{
    public partial class formDMAConsumptionPattern : Form
    {
        public int userID;
        string conStr = ConfigurationManager.ConnectionStrings["BillingSystem.Properties.Settings.dbCommercialConnectionString"].ConnectionString;
        GlobalFunctions gfunc = new GlobalFunctions();
        DataTable dt;

        public formDMAConsumptionPattern()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text += " [ Processing ... Please wait for a while ] ";
            label10.Text = string.Format("Billmonth({0})", comboBox1.Text);

            List<int> minVals =new List<int>{ 0, 6, 11, 21, 31, 41, 51 };
            List<int> maxVals = new List<int>{ 5, 10, 20, 30, 40, 50, 100000 };
            int billingID = (int)comboBox1.SelectedValue;
            radGridView1.Rows.Clear();

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var criteria = dbcontext.tbDMALists;
                int search_str = 0;
                dsDMAPattern.Clear();
                dt = dsDMAPattern.Tables[0];
                DataRow dr;
                foreach(tbDMAList dma in criteria)
                {
                    
                    dr = dt.NewRow();
                    search_str = dma.dma_id;
                    dr["dma"] = dma.subd_name;
                    int nosc = 0;
                    int totalvol = 0;
                    int idx_sc = 0;
                    int idx_vol = 0;
                    int cntr = 1;
                    int totsc = 0;
                    int totvol = 0;
                    for (int i = 0; i < minVals.Count; i++)
                    {
                        getDMAData(search_str, billingID, minVals[i], maxVals[i], ref nosc, ref totalvol);
                        idx_sc = cntr + i;
                        idx_vol = (cntr + 1) + i;
                        dr[idx_sc] = nosc;
                        dr[idx_vol] = totalvol;
                        cntr++;
                        totsc += nosc;
                        totvol += totalvol;
                    }
                    dr[15] = totsc;
                    dr[16] = totvol;
                    dt.Rows.Add(dr);
                    radGridView1.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4],
                        dr[5], dr[6], dr[7], dr[8], dr[9], dr[10], dr[11], dr[12], dr[13], dr[14], dr[15],dr[16]);
                }
                
            }
            btnPrint.Show();
            this.Text = "DMA Consumption Pattern";
        }

        private void getDMAData(int searchStr, int billingID, int minVol, int maxVol,ref int noSC, ref int totalVol)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            using (SqlCommand cmd = new SqlCommand("dbo.getDMAPattern", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@address", SqlDbType.Int);
                cmd.Parameters.Add("@billingID", SqlDbType.Int);
                cmd.Parameters.Add("@minVol", SqlDbType.Int);
                cmd.Parameters.Add("@maxVol", SqlDbType.Int);
                cmd.Parameters.Add("@noSC", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@totalVol", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@address"].Value = searchStr;
                cmd.Parameters["@billingID"].Value = billingID;
                cmd.Parameters["@minVol"].Value = minVol;
                cmd.Parameters["@maxVol"].Value = maxVol;

                conn.Open();
                cmd.ExecuteNonQuery();

                noSC = Int32.TryParse(cmd.Parameters["@noSC"].Value.ToString(),out noSC)?noSC:0;
                totalVol = Int32.TryParse(cmd.Parameters["@totalVol"].Value.ToString(), out totalVol)? totalVol:0;
            }
        }

        private void formDMAConsumptionPattern_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            param.Add(comboBox1.Text);
            param.Add(gfunc.getUserFullName(userID));
            frmReport frmRpt = new frmReport(dsDMAPattern);
            frmRpt.rptMode = 26;
            frmRpt.param = param;
            frmRpt.Show();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            btnPrint.Hide();

        }





    }
}
