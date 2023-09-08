using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Collections;


namespace BillingSystem
{
    public partial class frmDownloadAgents : Form
    {
        public string username = "";
        dbCommercialEntities dbContext = new dbCommercialEntities();
        DBRemix dbfData;
        string[] dbParams = { "CTR", "REF", "NAME", "ACCTNO", "ZONE", "CURRENT", "ARREARS", "OTHERS", "DATE" };
        string tablename = "";
        int counter = 0;

        public frmDownloadAgents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /**
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\temp;Extended Properties=dBase III";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = "CREATE TABLE NC1 (Id Integer, Changed Double, Name Text)";
                command.ExecuteNonQuery();
            }
            MessageBox.Show("TABLE has been created");
             */
            

            DialogResult result = openFileDialog1.ShowDialog();

            counter = 0;
            string fileName = "";
            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.SafeFileName;
                tablename = fileName;
                dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);
                //dbfData.DeleteDatabase(fileName);  // clear database
            }
            else
            {
                return;
            }

            //return;  //uncomment if clear database;
            List<int> pIDS = getBillProcID();

            int i = pIDS.Count();
            decimal mtr_mtn = Convert.ToDecimal(dbContext.tbSettings.First().meter_mtn);
            string oldtext = this.Text;
            foreach (int IDS in pIDS)
            {
                var billDetails = dbContext.tbBillingDetails.Where(x => x.billproc_id == IDS && x.arrears <= 0).Select(x=>x);
                if (billDetails != null)
                {
                    foreach (var rows in billDetails)
                    {

                        tbMaster mastData = getMasterData(rows.master_id);
                        AgentClass ncDBF = new AgentClass();
                        ncDBF.ctr = 1;
                        ncDBF.@ref = rows.billingdetails_id.ToString();
                        ncDBF.name = mastData.name.TrimEnd();
                        ncDBF.acctno = mastData.acctno.TrimEnd();
                        ncDBF.zone = cmbZoneBook.Text;
                        ncDBF.current = Convert.ToDecimal(rows.current) + mtr_mtn;
                        ncDBF.arrears = Convert.ToDecimal(rows.arrears);
                        ncDBF.others = Convert.ToDecimal(rows.inst_fee);
                        ncDBF.date = Convert.ToDateTime(rows.date_pres);
                        this.Text = oldtext + string.Format("  [ No. of Records: {1} - Saving ..{0}.. ]", mastData.name.TrimEnd(), counter.ToString());
                        saveToDBF(ncDBF);
                    }
                    saveToAgentHistory();
                    this.Text = oldtext;
                }
                else
                {
                    MessageBox.Show("No Records found.");
                }
            }
        }

        private void saveToAgentHistory()
        {
            tbDownloadAgentsHistory agent = new tbDownloadAgentsHistory();
            agent.agent_name = txtAgentName.Text;
            agent.billmonth = cmbBillMonth.Text;
            agent.dlagent_date = DateTime.Now;
            agent.downloadby = username;
            agent.numrec = counter;
            agent.zonebook = cmbZoneBook.Text;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                dbcontext.AddTotbDownloadAgentsHistories(agent);
                dbcontext.SaveChanges();
            }
            MessageBox.Show(string.Format("Download to {0} is done", tablename));
            this.tbDownloadAgentsHistoryTableAdapter.Fill(this.dsAgentHistory.tbDownloadAgentsHistory);
        }

        private void saveToDBF(AgentClass agentData)
        {
            ArrayList dbValues = new ArrayList();            
            dbValues.Add(agentData.ctr);
            dbValues.Add(agentData.@ref);
            dbValues.Add(agentData.name);
            dbValues.Add(agentData.acctno);
            dbValues.Add(agentData.zone);
            dbValues.Add(agentData.current);
            dbValues.Add(agentData.arrears);
            dbValues.Add(agentData.others);
            dbValues.Add(agentData.date);
            dbfData.SaveToOLEDatabase(tablename, dbValues, dbParams);
            counter++;
        }

        private tbMaster getMasterData(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMaster query = dbcontext.tbMasters.First(x => x.master_id == masterID);
                return query;
            }
        }
       
        private List<int> getBillProcID()
        {
            List<int> procIDs = new List<int>();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                int billingID = (int)cmbBillMonth.SelectedValue;
                var query = (from em in dbcontext.tbBillProcessings
                             where em.billing_id == billingID &&
                             em.zone_book.Equals(cmbZoneBook.Text)
                             select em);
                if (query != null)
                {
                    foreach (var elf in query)
                    {                        
                        procIDs.Add(elf.bill_process_id);
                    }
                }
            }
            return procIDs;
        }

        private void frmDownloadAgents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAgentHistory.tbDownloadAgentsHistory' table. You can move, or remove it, as needed.
            this.tbDownloadAgentsHistoryTableAdapter.Fill(this.dsAgentHistory.tbDownloadAgentsHistory);
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            tbZoneBindingSource.DataSource = dbContext.tbZones;
        }

    }
}
