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
    public partial class formUpdateRezoning : Form
    {      
        private int totalRecords = 0;        
        private int pgCntr = 0;
        private List<string> zonesList = new List<string>();
        private List<string> invalidAccounts = new List<string>();
        private List<string> unknownAccounts = new List<string>();
        GlobalFunctions gfunc = new GlobalFunctions();

        public formUpdateRezoning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (dbRezoneEntities rezoneContext = new dbRezoneEntities())
            {

                panel1.Visible = !panel1.Visible;
                pbZone.Value = 0;
                pbUpdate.Value = 0;
                pgCntr = 0;
                totalRecords = rezoneContext.tbRezones.Count();                
                pbZone.Maximum = totalRecords;
                pbUpdate.Maximum = totalRecords;
                zonesList.Clear();
                invalidAccounts.Clear();
                unknownAccounts.Clear();
            }
            backgroundWorker1.RunWorkerAsync();            
        }
     

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (dbRezoneEntities rezoneContext = new dbRezoneEntities())
            {
                var rezoneQuery = rezoneContext.tbRezones.Select(x => x);
                zonesList = rezoneContext.tbNewZones.Select(x => x.newzone_name).ToList();
                foreach (tbRezone rzData in rezoneQuery)
                {
                    System.Threading.Thread.Sleep(5);
                    if (!zonesList.Contains(rzData.new_zone))
                    {
                        invalidAccounts.Add(string.Format("A#{0}--Zone:{1}", rzData.acctno, rzData.new_zone));
                    }
                    backgroundWorker1.ReportProgress(pgCntr);
                    pgCntr++;
                }
            }            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
            label2.Text = string.Format("Validating Zones.....[Invalid Zones:{0}]", invalidAccounts.Count);          
            label2.Refresh();
            pbZone.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = true;
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            pgCntr = 0;
            List<tbRezone> updateList = queryRezoneData();
            Dictionary<string, int> zoneidList = LoadZoneIDs();     
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {                              
                foreach (tbRezone rzData in updateList)
                {
                    tbMaster masterData = dbcontext.tbMasters.SingleOrDefault(x => x.acctno.Equals(rzData.acctno));
                    if (masterData != null)
                    {
                        if (zoneidList.ContainsKey(rzData.new_zone))
                        {
                            masterData.zone_id = zoneidList[rzData.new_zone];
                        }
                    }
                    else
                    {
                        unknownAccounts.Add(rzData.acctno);
                    }

                   // System.Threading.Thread.Sleep(2);                    
                    backgroundWorker2.ReportProgress(pgCntr);
                    pgCntr++;
                }
              //  dbcontext.SaveChanges();
            }            
        }

        private List<tbRezone> queryRezoneData()
        {
            using (dbRezoneEntities rezoneContext = new dbRezoneEntities())
            return rezoneContext.tbRezones.Select(x => x).ToList<tbRezone>();
        }

        private Dictionary<string,int> LoadZoneIDs()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                return dbcontext.tbZones.Select(x => x).ToDictionary(x => x.zone_name, x => x.zone_id);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label3.Text = string.Format("Applying Updates.....[Invalid Account No.:{0}]", unknownAccounts.Count);         
            label3.Refresh();          
            pbUpdate.Value = e.ProgressPercentage;
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if ((invalidAccounts.Count > 0) || (unknownAccounts.Count > 0))
            {
                DialogResult dlgResult = MessageBox.Show("Processing done. There are invalid entries. \n Do you want to see the list?", "Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    string liststr = "";
                    if (invalidAccounts.Count > 0)
                        liststr = processInvalidZones();
                    if (unknownAccounts.Count > 0)
                        liststr = liststr + processInvalidAccounts();
                    SaveToFile(liststr);
                }
            }
            else
            {
                MessageBox.Show("Processing done.");
            }                      
            panel2.Visible = false;
        }

        private void SaveToFile(string liststr)
        {
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            try
            {
                gfunc.saveLogFile(filename, liststr,false);
                process1.StartInfo.FileName = "Notepad.exe";
                process1.StartInfo.Arguments = filename;
                process1.Start();
            }
            catch
            {
                MessageBox.Show("Error saving list. Please check user permission.");
            }
        }

        private string processInvalidAccounts()
        {
            string str = "Invalid Account Numbers \n";
            foreach (string x in unknownAccounts)
            {
                str = str + x + "\n";
            }            
            return str;
        }

        private string processInvalidZones()
        {
            string str = "Entries with invalid zones \n";
            foreach (string x in invalidAccounts)
            {
                str = str + x + "\n";
            }
            str = str + "------------------\n";
            return str;
        }

    }
}
