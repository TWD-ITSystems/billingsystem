using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
using Telerik.WinControls.UI.Export;
using System.IO;

namespace BillingSystem
{
 
    public partial class formECPAYImport : Form
    {
      
        public int userID;
        string strWorksheetName = "ABSTRACT OF COLLECTION REPORT";
        GlobalFunctions gfunc = new GlobalFunctions();
        decimal mtrmtn = 0;
        decimal totalAmt = 0;
        int rec_count = 0;
        int unrec_acct = 0;
        int amt_error = 0;
        string firstday;
        

        public formECPAYImport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            radGridView1.Rows.Clear();
            string filename = "";
            mtrmtn = gfunc.getMeterMtn();
           



            rec_count = 0;
            unrec_acct = 0;
            amt_error = 0;
            totalAmt = 0;

          
            decimal arrears = 0;
            decimal collected_amt = 0;
            decimal running_amt = 0;
            decimal current = 0;
            decimal penalty = 0;
            decimal ifpay = 0;
            decimal mtrmtnPay = 0;
            decimal advpay = 0;
            showSummary();
            int billingID = gfunc.getBillingID(comboBox1.Text);
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //filename = openFileDialog1.FileName;
                //string connStr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;data source={0};Extended Properties=Excel 8.0;", openFileDialog1.FileName);
                //string adaptStr = string.Format("Select * from [{0}$]", strWorksheetName);
                 string extend_mode = "";
                filename = openFileDialog1.FileName;
              if (Path.GetExtension(filename)==".xls")  {
                  extend_mode = "Excel 8.0";
              }else if(Path.GetExtension(filename)==".xlsx"){
                  extend_mode = "Excel 12.0";
              }
              string connStr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{0}';Extended Properties='{1};HDR=YES;IMEX=1;';", openFileDialog1.FileName, extend_mode);

                string sheet1 = "";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                    sheet1 = dtSchema.Rows[0].Field<string>("TABLE_NAME");
                }
                string adaptStr = string.Format("Select * from [{0}]", sheet1);


                using (var adapter = new OleDbDataAdapter(adaptStr, connStr))
                {
                    var ds = new DataSet();
                    adapter.Fill(ds, "tbCollect");

                    var data = ds.Tables["tbCollect"].AsEnumerable();

                  var query = data.Select(x => new
                    {
                        acctno = x.Field<string>("Account Number"),
                        transdate = x.Field<string>("Transaction Date"),
                        refnum = x.Field<string>("Branch Name"),
                        name = x.Field<string>("Identifier"),
                        collected_amt = x.Field<double>("Trans Amount")
                        //collected_amt = 0
                    });

                  foreach (var payAcctno in query)
                  {
                      try
                      {                      
                          int masterID = gfunc.getMasterID(payAcctno.acctno);                          
                          if (masterID==0)
                          {
                              MessageBox.Show("Please resolve the account of " + payAcctno.name, "Unknown Format Error");
                              return;
                          }
                       
                      }catch     
                      {                   
                      MessageBox.Show("Please resolve the account of "+payAcctno.name,"Unknown Format Error");
                      return;
                      }

                  }
  
                  //var query1 = query.Where(x => x.acctno != null && x.acctno.Trim().Contains(payData.acctno)).Select(x => x);
                  //var query1 = query.Where(x => x.acctno != null && x.acctno.Trim().Contains("005342")).Select(x => x);
                  //MessageBox.Show("Records to Process: " + query1.Count());
                  try
                  {
                      foreach (var payData in query)
                      {

                          int masterID = gfunc.getMasterID(payData.acctno);
                          string zoneproc = gfunc.getZoneName(gfunc.getZoneID(masterID));
                          string zoneUID = zoneproc.Substring(0, 2);
                          string refnum = "";
                          arrears = 0;
                          current = 0;
                          advpay = 0;
                          mtrmtnPay = 0;

                          if (masterID == 0)
                          {
                              radGridView1.Rows.Add(true,
                                               "",
                                               "No Accnt",
                                               "ERROR",
                                               payData.name,
                                               0,
                                               0,
                                               0,
                                               0,
                                               0,                                               
                                               0,0);
                              unrec_acct++;
                              continue;
                          }

                          if (payData.refnum.Length > 10)
                          {
                              refnum = payData.refnum.Substring(0, 9);
                          }
                          else
                          {
                              refnum = payData.refnum;
                          }

                         
                          using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                          {
                              ifpay = checkIF(masterID);
                              current = checkCurrent(masterID,Convert.ToDateTime(payData.transdate),billingID);
                              penalty = checkPenalty(masterID, Convert.ToDateTime(payData.transdate),billingID);
                              arrears = checkArrears(masterID);
                              collected_amt = Convert.ToDecimal(payData.collected_amt);
                              running_amt=collected_amt;
                              totalAmt += collected_amt;

                              if (ifpay > 0)
                              {
                                  if (collected_amt > ifpay) 
                                  {
                                      running_amt = running_amt - ifpay;
                                  }else{
                                      running_amt = 0;
                                  }

                              }

                              if (arrears > 0)
                              {
                                  if (running_amt >= arrears)
                                  {
                                      running_amt = running_amt - arrears;
                                  }
                                  else
                                  {
                                      arrears = running_amt;
                                      running_amt = 0;
                                  }
                              }
                              else
                              {
                                  arrears = 0;
                              }


                              if ((running_amt > 0) && (current > 0))
                              {
                                  if (running_amt >= current)
                                  {
                                      running_amt = running_amt - current;
                                      current = current - mtrmtn;
                                      mtrmtnPay = mtrmtn;
                                  }
                                  else
                                  {
                                      current = running_amt;
                                      current = current - mtrmtn;
                                      mtrmtnPay = mtrmtn;
                                      running_amt = 0;
                                  }

                              }
                              else
                              {
                                  current = 0;
                                  mtrmtnPay = 0;
                              }

                              if ((running_amt > 0) && (penalty > 0))
                              {
                                  if (running_amt >= penalty)
                                  {
                                      running_amt = running_amt - penalty;

                                  }
                                  else
                                  {
                                      penalty = running_amt;
                                      running_amt = 0;
                                  }
                              }
                              else
                              {
                                  penalty = 0;
                              }

                              //original place of arrears
                              /**
                              if (arrears > 0)
                              {
                                  if (running_amt >= arrears)
                                  {
                                      running_amt = running_amt - arrears;
                                  }
                                  else
                                  {
                                      arrears = running_amt;
                                      running_amt = 0;
                                  }
                              }
                              else
                              {
                                  arrears = 0;
                              }
                              */
                              if (running_amt > 0)
                              {
                                  advpay = running_amt;
                              }
                          }

                          radGridView1.Rows.Add(false,
                                             string.Format("{0:n}", payData.transdate),
                                             refnum,
                                             payData.acctno,
                                             payData.name,
                                             payData.collected_amt.ToString("n"),
                                             current,
                                             arrears,
                                             penalty,
                                             ifpay,
                                             mtrmtnPay,advpay,
                                             zoneUID, masterID);



                          rec_count++;
                          System.Threading.Thread.CurrentThread.Join(10);
                         // break;
                       }
                  }
                  catch (ArgumentException ex)
                  {
                      MessageBox.Show(ex.Message);
                      MessageBox.Show("Excel format not supported. Please check the ECPAY report.","Unknown Format Error");
                      return;
                  }
                }
                MessageBox.Show("Import is Successful","ECPAY import....");
                button2.Show();
                button3.Show();
                showSummary();

            }
           

        }

        private void showSummary()
        {
            labelAmt.Text = string.Format("Total Amount : {0:n}", totalAmt);
            labelCount.Text = string.Format("Total Records : {0}", rec_count);
            labelUnrecognized.Text = string.Format("Unrecognized Accounts : {0}", unrec_acct);
            labelError.Text = string.Format("Error in Amount : {0}", amt_error);
        }


        

        private decimal checkIF(int masterID)
        {
            decimal IFamt = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct table = dbcontext.tbMasterAccts.SingleOrDefault(x => x.master_id == masterID);
                if (table != null)
                {
                    if ((Convert.ToBoolean(table.isIF) && table.IFBalance > 0))
                    {
                        if (table.IFBalance < table.IFMonthlyPay)
                        {
                            IFamt = Convert.ToDecimal(table.IFBalance);
                        }
                        else
                        {
                            IFamt = Convert.ToDecimal(table.IFMonthlyPay);
                        }
                    }
                }
            }
            return IFamt;
        }



        private decimal checkPenalty(int masterID,DateTime dt,int billingID)
        {
            decimal penalty = 0;
            //int billingID = 97; // 06-2020
            
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var data = dbcontext.tbLedgers.SingleOrDefault(x => x.master_id == masterID && x.billing_id == billingID && x.code.Equals("PNLT") && x.trans_date <= dt);
                if (data != null)
                {          
                        penalty = Convert.ToDecimal(data.amount);            
                }
                else
                {
                    penalty = 0;
                }
            }
            return penalty;
        }

        private decimal checkCurrent(int masterID,DateTime dt,int billingID)
        {
            decimal current = 0;
            //int billingID = 97;// 06-2020
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var data = dbcontext.tbLedgers.SingleOrDefault(x => x.master_id == masterID && x.billing_id == billingID && x.code.Equals("BILL") && x.trans_date <= dt);
                if (data != null)
                {
                    current = Convert.ToDecimal(data.amount);
                }
                else
                {
                    current = 0;
                }
            }
            return current;
        }



        private decimal checkArrears(int masterID)
        {
            //decimal arrears = 0;
          //  decimal billingID = 97;
          //  int ledgerID = 0;
         //   using (dbCommercialEntities dbcontext = new dbCommercialEntities())
           // {
               // DateTime dt = new DateTime();

               //     dt = DateTime.Parse(firstday);
               //     tbLedger ledger = dbcontext.tbLedgers.Where(x => x.master_id == masterID && x.trans_date < dt).OrderByDescending(x => x.ledger_id).FirstOrDefault();
               //     //tbLedger ledger = dbcontext.tbLedgers.Where(x => x.master_id == masterID).OrderByDescending(x => x.ledger_id).First();
               //     if (ledger != null)
               //     {
               //         if (ledger.balance > 0)
               //         {
               //             arrears = Convert.ToDecimal(ledger.balance);
               //         }
               //         else
               //         {
               //             arrears = 0;
               //         }
               //     }

               //}                
               // return arrears;
           // }
            decimal arrears = 0;


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct arrears_rec = (from tbMastAct in dbcontext.tbMasterAccts
                                            where tbMastAct.master_id == masterID
                                            select tbMastAct).Single();

                arrears = arrears_rec.bill_arrears.HasValue ? (decimal)arrears_rec.bill_arrears : 0;
            }
            return arrears; 
            }
        

        private tbMasterAcct getAccount(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct table = dbcontext.tbMasterAccts.SingleOrDefault(x => x.master_id == masterID);
                return table;
            }

        }

        private void formECPAYImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);

           // button4.Visible=false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowcount = radGridView1.Rows.Count();
            decimal colAmt = 0;
            for (int i = rowcount; i > 0; i--)
            {
                colAmt = 0;
                if (radGridView1.Rows[i - 1].Cells[0].Value.Equals(true))
                {
                    rec_count--;
                    if (radGridView1.Rows[i - 1].Cells[3].Value.Equals("DMTR")||radGridView1.Rows[i - 1].Cells[3].Value.Equals("ERROR"))
                    {
                        unrec_acct--;
                    }

                    if (radGridView1.Rows[i - 1].Cells[4].Value.Equals("***ERROR AMOUNT***"))
                    {
                        amt_error--;
                        colAmt = decimal.TryParse(radGridView1.Rows[i - 1].Cells[5].Value.ToString(), out colAmt) ? colAmt : 0;
                    }

                    radGridView1.Rows[i - 1].Delete();
                }
                
                totalAmt -= colAmt;
            }
            labelAmt.Text = string.Format("Total Amount : {0:n}", totalAmt);
            labelCount.Text = string.Format("Total Records : {0}", rec_count);
            labelUnrecognized.Text = string.Format("Unrecognized Accounts : {0}", unrec_acct);
            labelError.Text = string.Format("Error in Amount : {0}", amt_error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dgBox = MessageBox.Show("Do you really want to save this data?Please check first the BILLMONTH", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgBox == DialogResult.Yes)
            {
                button2_Click(sender,e);
                if (checkIfPosted(Convert.ToInt32(radGridView1.Rows[0].Cells[12].Value)))
                {
                    MessageBox.Show("This file is already been posted.");
                    return;
                }

                string oldtxt = this.Text;
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    for (int i = 0; i < radGridView1.Rows.Count; i++)
                    {

                        tbBankCollection bank = new tbBankCollection();

                        bank.master_id = Convert.ToInt32(radGridView1.Rows[i].Cells[13].Value);
                        bank.date_collected = Convert.ToDateTime(radGridView1.Rows[i].Cells[1].Value);
                        bank.collect_agent = "ECPAY";
                        bank.billmonth = comboBox1.Text;
                        bank.zone = radGridView1.Rows[i].Cells[12].Value.ToString();
                        bank.refnum = radGridView1.Rows[i].Cells[2].Value.ToString();
                        bank.current = Convert.ToDecimal(radGridView1.Rows[i].Cells[6].Value);
                        bank.arrears = Convert.ToDecimal(radGridView1.Rows[i].Cells[7].Value);
                        bank.penalty = Convert.ToDecimal(radGridView1.Rows[i].Cells[8].Value);
                        bank.others = Convert.ToDecimal(radGridView1.Rows[i].Cells[9].Value);
                        bank.senior = 0;
                        bank.totalamt = Convert.ToDecimal(radGridView1.Rows[i].Cells[5].Value);
                        bank.mtr_mtn = Convert.ToDecimal(radGridView1.Rows[i].Cells[10].Value);
                        bank.advpay = Convert.ToDecimal(radGridView1.Rows[i].Cells[11].Value);

                        bank.posted_by = gfunc.getUserInitials(userID);
                        bank.date_posted = DateTime.Today;

                        dbcontext.AddTotbBankCollections(bank);
                        this.Text = string.Format("Saving ... {0}", bank.master_id);
                        //tbMasterAcct mastacc = dbcontext.tbMasterAccts.Single(x => x.master_id == bank.master_id);


                    }
                    dbcontext.SaveChanges();
                    MessageBox.Show("Payments has been posted successfully.");
                    this.Text = oldtxt;
                    radGridView1.Rows.Clear();
                    button2.Hide();
                    button3.Hide();
                }
            }
        }

        private bool checkIfPosted(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var bankCol = dbcontext.tbBankCollections.SingleOrDefault(x => x.master_id == masterID && x.billmonth.Equals(comboBox1.Text) && x.collect_agent.Equals("ECPAY"));
                if (bankCol != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private decimal getPenalty(int masterID)
        {
            int billID = (int)comboBox1.SelectedValue;
            decimal penalty = 0;

            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbLedger ledger = dbcontext.tbLedgers.SingleOrDefault(x => x.code.Equals("PNLT") && x.master_id == masterID && x.billing_id==billID);
                if (ledger != null)
                {
                    penalty = Convert.ToDecimal(ledger.amount);
                }
            }
            return penalty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            //{
            //    var ecpayments = dbcontext.tbBankCollections.Where(x => x.zone.Equals("5.00"));
            //    foreach (tbBankCollection bankpay in ecpayments)
            //    {
            //        string zone = string.Format("{0:00}", gfunc.getZoneUIDbyMaster((int)bankpay.master_id));
            //        bankpay.zone = zone;
            //    }
            //    int totalrec = ecpayments.Count();
            //    dbcontext.SaveChanges();
            //    MessageBox.Show(string.Format("{0} records repaired", totalrec));
            //}                     
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                for (int i = 0; i < radGridView1.Rows.Count; i++)
                {
                    this.Text = "Processing..." + radGridView1.Rows[i].Cells[4].Value;

                    int masterID = Convert.ToInt32(radGridView1.Rows[i].Cells[13].Value);
                    decimal totalamt = Convert.ToDecimal(radGridView1.Rows[i].Cells[5].Value);
                    DateTime dt = Convert.ToDateTime(radGridView1.Rows[i].Cells[1].Value);
                    tbBankCollection bank = dbcontext.tbBankCollections.SingleOrDefault(x => x.billmonth.Equals("06-2020") && x.collect_agent.Equals("ECPAY") && x.master_id == masterID &&
                                            x.totalamt == totalamt && x.date_collected==dt);                                    

                    bank.current = Convert.ToDecimal(radGridView1.Rows[i].Cells[6].Value);
                    bank.arrears = Convert.ToDecimal(radGridView1.Rows[i].Cells[7].Value);
                    bank.penalty = Convert.ToDecimal(radGridView1.Rows[i].Cells[8].Value);
                    bank.others = Convert.ToDecimal(radGridView1.Rows[i].Cells[9].Value);
                    bank.totalamt = Convert.ToDecimal(radGridView1.Rows[i].Cells[5].Value);
                    bank.advpay = Convert.ToDecimal(radGridView1.Rows[i].Cells[11].Value);
                    bank.mtr_mtn = Convert.ToDecimal(radGridView1.Rows[i].Cells[10].Value);


                }

                dbcontext.SaveChanges();
            }
            MessageBox.Show("Repair done");
                        

                       
        }

        private void labelError_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button4.Show();
        }

       


    }
}


