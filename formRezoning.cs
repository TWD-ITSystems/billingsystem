using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Data.OleDb;
using DevExpress.XtraWaitForm;
using System.Diagnostics;

namespace BillingSystem
{
    public partial class formRezoning : Form
    {
        public int userID = 0;
        int global_counter = 0;
        string filename = "";
        string filepath = "";
        string fileExt = "";
        string fullfilename = "";
        GlobalFunctions gfunc=new GlobalFunctions();
        Stopwatch stopwatch;
        int noZones = 0;

        public formRezoning()
        {
            InitializeComponent();
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;              
                button2.Enabled = true;
                filepath = Path.GetDirectoryName(textBox1.Text);
                filename = openFileDialog1.SafeFileName;
                fileExt = Path.GetExtension(filename);
                fullfilename = openFileDialog1.FileName;
            }          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Close"))
            {
                Close();
            }
            else
            {
                stopwatch = new Stopwatch();
                stopwatch.Start();
                label1.Visible = true;
                label1.Text = "Processing Please wait...";
                button2.Enabled = false;
                progressBarControl1.Show();
                var task = Task.Factory.StartNew(() => doProcessing());
                task.ContinueWith((previousTask) =>
                {
                    if (task.IsCompleted)
                        ending();
                }, TaskScheduler.FromCurrentSynchronizationContext());


            }
        }



        private void ending()
        {
            label1.Text = "Elapsed Time: " + stopwatch.Elapsed;
            progressBarControl1.Hide();
            button2.Text = "Close";
            button2.Enabled = true;
            MessageBox.Show("Processing done. \r Total Records:[ " + global_counter + " ] \r Accnt w/ Empty Zones:[ " + noZones + " ]");
        }


        private void doProcessing()
        {
            string connString = "";
            string query = "";

            if (fileExt.ToUpper().Equals(".DBF"))
            {
                connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", filepath);
                query = string.Format("Select [ACCTNO],[ZONE_NAME],[NEWZONE] from [{0}]", filename);
            }
            else if (fileExt.ToUpper().Equals(".XLS"))
            {
                connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;data source={0};Extended Properties=Excel 8.0;", fullfilename);                
                query = "Select [ACCTNO],[ZONE_NAME],[NEWZONE] from [Sheet1$]";
                filename = "Sheet1";
            }else if (fileExt.ToUpper().Equals(".XLSX")){
                connString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;IMEX=1;HDR=YES'", fullfilename);
                query = "Select [ACCTNO],[ZONE_NAME],[NEWZONE] from [Sheet1$]";
                filename = "Sheet1";
            }

            
            
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    MessageBox.Show("Error opening file.");
                }
                
                using (OleDbDataAdapter myAdapter = new OleDbDataAdapter(query, conn))
                {
                    DataSet myDataset = new DataSet();
                    try
                    {
                        myAdapter.Fill(myDataset, filename);
                    }
                    catch
                    {
                        MessageBox.Show("Please rename worksheet to Sheet1.");
                    }

                    var dTable = myDataset.Tables[0].AsEnumerable();
                    var dRows = dTable.Select(x => x);


                    int rowcount = dRows.Count();    
                   
                    using (dbRezoneEntities rezoneContext = new dbRezoneEntities())
                    {
                        List<string> listNewZones = rezoneContext.tbNewZones.Select(x=>x.newzone_name).ToList();
                        //Dictionary<string,int> listAcctNo = rezoneContext.tbRezones.Select(x => x).ToDictionary(x=>x.acctno,x=>x.rezone_id);

                        foreach (var row in dRows)
                        {
                            string newzoneStr = row["NEWZONE"].ToString();
                            string acctno = row["ACCTNO"].ToString();
                            string oldzone = row["ZONE_NAME"].ToString();
                            if (newzoneStr.Length == 0) 
                            {
                                noZones++;
                                continue;
                            }
                            else if (newzoneStr.Length == 1)
                            {
                                newzoneStr = "Z-0" + newzoneStr;
                            }
                            else if (newzoneStr.Length == 2)
                            {
                                newzoneStr = "Z-" + newzoneStr;
                            }
                            string newzone = newzoneStr.Substring(2);

                            bool validNewzone = listNewZones.Contains(newzone);
                          //  bool acctForEdit = listAcctNo.ContainsKey(acctno);

                            //if (acctForEdit)
                            //{
                            //    if (validNewzone)
                            //    {
                            //        tbRezone acctEdit = rezoneContext.tbRezones.FirstOrDefault(x => x.rezone_id == listAcctNo[acctno]);
                            //        acctEdit.old_zone = oldzone;
                            //        acctEdit.new_zone = newzone;
                            //    }
                            //}
                            //else
                            //{
                                tbRezone newAcct = new tbRezone();
                                newAcct.old_zone = oldzone;
                                newAcct.new_zone = newzone;
                                newAcct.acctno = acctno;
                                newAcct.date_added = DateTime.Now;
                                rezoneContext.AddTotbRezones(newAcct);
                              //  MessageBox.Show(acctno + " - " + oldzone + " - " + newzone);
                            //}
                            global_counter++;
                            //MessageBox.Show(acctno + " -- " + acctnoEdit.ToString());
                        }
                        rezoneContext.SaveChanges();                        
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<tbZone> oldZones = new List<tbZone>();

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                oldZones = dbcontext.tbZones.ToList();
            }


            using (dbRezoneEntities rezoneContext = new dbRezoneEntities())
            {
                int cnt = 0;
                foreach (tbZone zone in oldZones)
                {
                    tbNewZone newZone = new tbNewZone();
                    newZone.newzone_name = zone.zone_name;
                    rezoneContext.AddTotbNewZones(newZone);
                    cnt++;
                }
                rezoneContext.SaveChanges();
                MessageBox.Show("Records Saved : " + cnt.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
