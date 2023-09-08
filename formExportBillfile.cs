using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Collections;

namespace BillingSystem
{
    public partial class formExportBillfile : Form
    {
        GlobalFunctions global_func = new GlobalFunctions();

        public formExportBillfile()
        {
            InitializeComponent();
        }

        private void formExportBillfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsZone.tbZone' table. You can move, or remove it, as needed.
            this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            string fileName = "";
            string tablename = "";
            string filePath = "";
            DBRemix dbfData;
            string billmonth = cmbBillmonth.Text;
            string zonebook = cmbZone.Text;
            

            if (result == DialogResult.OK)
            {

                filePath = folderBrowserDialog1.SelectedPath;
                string appPath = Application.StartupPath;
                string sourceFile = string.Format(@"{0}\templates\BILL0000.DBF", appPath);
                string newFile = string.Format(@"{0}\BILL{1}.DBF", filePath, cmbZone.Text.Substring(0,2));              
                fileName = string.Format("BILL{0}.DBF", cmbZone.Text.Substring(0,2));
                File.Copy(sourceFile, newFile, true);
                tablename = fileName;
                dbfData = new DBRemix(filePath, false);
                
            }
            else
            {
                return;
            }

 
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", filePath);
            int counter = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var dRows = dbcontext.tbMRSUploads.Where(x => x.md_billmonth.Equals(billmonth) && x.md_zone.Equals(zonebook));
                int cnt = dRows.Count();
                foreach (var row in dRows)
                {
                    string acctno = row.md_acctno.ToString();
                    if (row.md_billno == null) continue;
                    if (row.md_billno.Length < 10)  continue; //ref. no is not valid..dnt process

                    int volume = Int32.TryParse(row.md_volume, out volume) ? volume : 0;
                    if (volume < 0) continue; //volume is negative dont process

                    if (checkIfPresent(acctno)) continue;

                    tbMaster qMaster = dbcontext.tbMasters.SingleOrDefault(x => x.acctno.Equals(acctno));
                    if (qMaster == null) continue;
                    string cardno = qMaster.cardno.ToString();
                    string name = qMaster.name;
                    string refnum = row.md_billno.Substring(0,7);
                    int masterID = qMaster.master_id;
                    string address = qMaster.address.Substring(0,30);
                    string metno = global_func.getMeterNumber(acctno);
                    DateTime datepres = Convert.ToDateTime(row.md_dateuploaded);
                    int presrdg = Int32.TryParse(row.md_presrdg.ToString(),out presrdg)?presrdg:0;
                    int prevrdg = Int32.TryParse(row.md_prevrdg.ToString(),out prevrdg)?prevrdg:0;
                    string encoder=row.md_encoder.ToString();
                    decimal current = decimal.TryParse(row.md_billamount.ToString(),out current)?current:0;
                    current = (current > 0)?current + 5:0;
                    int ave = global_func.getAverageVolume(masterID);
                    string ctgry = qMaster.category.ToString();
                    string zone = zonebook;
                    decimal penalty = global_func.computePenalty(current);

                    tbMrsDownload qDownload = dbcontext.tbMrsDownloads.SingleOrDefault(x=>x.md_acctno.Equals(acctno) && x.md_zone.Equals(zone) && x.md_status.Equals("A"));
                    DateTime dateprev = Convert.ToDateTime(qDownload.md_dateprev);

                    string[] dbParams = { "AVE","ACCTNO", "ZONE", "NAME", "ADDRESS", "METNO", "CTGRY", "CARDNO", "CURRENT", "PENALTY", "DATEPRES", "DATEPREV", "PRESRDG", "PREVRDG", "VOLUME","REF", "ENCODER", "DATE"};

//"AVE","ACCTNO", "ZONE", "NAME", "ADDRESS", "METNO", "CTGRY", "CARDNO", "CURRENT", "PENALTY", 
//"DATEPRES", "DATEPREV", "PRESRDG", "PREVRDG", "VOLUME","REF", "ENCODER", "DATE"


                    ArrayList dbValues = new ArrayList();
                    dbValues.Add(ave);
                    dbValues.Add(acctno);
                    dbValues.Add(zone);
                    dbValues.Add(name);
                    dbValues.Add(address);
                    dbValues.Add(metno);
                    dbValues.Add(ctgry);
                    dbValues.Add(cardno);
                    dbValues.Add(current);
                    dbValues.Add(penalty);
                    dbValues.Add(datepres);
                    dbValues.Add(dateprev);
                    dbValues.Add(presrdg);
                    dbValues.Add(prevrdg);
                    dbValues.Add(volume);
                    dbValues.Add(refnum);
                    dbValues.Add(encoder);
                    dbValues.Add(datepres);

                    dbfData.SaveToOLEDatabase(tablename, dbValues, dbParams);

                    this.Text = string.Format("Total Count[{0}] - Saving Acctno {1}",counter,acctno);
                    counter++;
                  }
                MessageBox.Show("Processing done");
                listBox1.Items.Add(fileName);
             
                }

                //tablename = fileName;
                //dbfData = new DBRemix(Path.GetDirectoryName(openFileDialog1.FileName), false);
            
        }


        private bool checkIfPresent(string acctno)
        {
            bool retval = false;
            string filePath =@"D:\shared\BILLFILE_JUNE";
            string connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", filePath);
            string fileName = "BILL1202.DBF";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = string.Format("Select [ACCTNO] from [{0}]", fileName);
                using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                {
                    DataSet myDataset = new DataSet();
                    myAdapter.Fill(myDataset, fileName);

                    var dTable = myDataset.Tables[0].AsEnumerable();
                    var dRows = dTable.Select(x => new { ACCTNO = x["ACCTNO"] });
                    var dCount = dRows.Where(x => x.ACCTNO.Equals(acctno));
                    retval = (dCount.Count() > 0) ? true : false;
                }
            }

            return retval;
        }
    }
}
