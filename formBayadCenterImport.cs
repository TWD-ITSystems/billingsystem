using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace BillingSystem
{ 
    public partial class formBayadCenterImport : Form
    {
        public int userID = 0;
        decimal totalCollected = 0;
        int totalRecords = 0;
        GlobalFunctions gfunc = new GlobalFunctions();

        decimal mtrmtn = 0;
        decimal totalAmt = 0;
        int rec_count = 0;
        int unrec_acct = 0;
        int amt_error = 0;
        string firstday;

        public formBayadCenterImport()
        {
            InitializeComponent();
        }

        private void formBayadCenterImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            mtrmtn = gfunc.getMeterMtn();
            if (DateTime.Today.CompareTo(new DateTime(2021,9,17)) > 0)
            {
                button2.Visible = false;
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                totalRecords = 0;
                totalCollected = 0;
                radGridView1.Rows.Clear();
                try
                {
                    using (TextFieldParser csvParser = new TextFieldParser(path))
                    {
                        csvParser.SetDelimiters(new string[] { "," });
                        csvParser.HasFieldsEnclosedInQuotes = true;
                        csvParser.ReadLine();
                        while (!csvParser.EndOfData)
                        {
                            string[] fields = csvParser.ReadFields();
                            string branchID = fields[1];
                            string transDate = fields[2];
                            string acctno = fields[3];
                            string name = fields[4];
                            string collected = fields[5];
                            totalRecords++;
                            totalCollected += Decimal.Parse(collected);
                            AddToGrid(branchID, transDate, acctno.PadLeft(6, '0'), name, collected);
                            //radGridView1.Rows.Add(false, branchID, transDate, acctno.PadLeft(6, '0'), name, collected);

                        }
                    }
                    
                    if (unrec_acct > 0)
                    {
                        MessageBox.Show(string.Format("There are {0} unrecognized accounts. Please verify the records.",unrec_acct));
                    }else{
                        MessageBox.Show("Import is successful.");
                        btnSave.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect CSV format. Please delete unnecessary data in the file.","Error Reading File");
                }
                labelTotalRecords.Text = string.Format("Number of Records : {0}", totalRecords);
                labelTotalAmt.Text = string.Format("Total Collected Amount : {0}", totalCollected);
            }
        }

        private void AddToGrid(string branchID, string transDate, string acctno, string name, string collected)
        {

            decimal arrears = 0;
            decimal collected_amt = 0;
            decimal running_amt = 0;
            decimal current = 0;
            decimal penalty = 0;
            decimal ifpay = 0;
            decimal mtrmtnPay = 0;
            decimal advpay = 0;
            int billingID = gfunc.getBillingID(comboBox1.Text);
          
        

            int masterID = gfunc.getMasterID(acctno);
            string zoneproc = gfunc.getZoneName(gfunc.getZoneID(masterID));
            string zoneUID = zoneproc.Length > 0 ? zoneproc.Substring(0, 2) : "";
            string refnum = "";
 

            if (masterID == 0)
            {
                radGridView1.Rows.Add(true,
                                 "",
                                 "No Accnt",
                                 "ERROR",
                                 name,
                                 0,
                                 0,
                                 0,
                                 0,
                                 0,
                                 0, 0);
                unrec_acct++;
                return;
            }

            if (branchID.Length > 10)
            {
                refnum = branchID.Substring(0, 9);
            }
            else
            {
                refnum = branchID;
            }


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                ifpay = checkIF(masterID);
                current = checkCurrent(masterID, Convert.ToDateTime(transDate), billingID);
                penalty = checkPenalty(masterID, Convert.ToDateTime(transDate), billingID);
                arrears = checkArrears(masterID);
                collected_amt = Convert.ToDecimal(collected);
                running_amt = collected_amt;
                totalAmt += collected_amt;

                if (ifpay > 0)
                {
                    if (collected_amt > ifpay)
                    {
                        running_amt = running_amt - ifpay;
                    }
                    else
                    {
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
            
            /**
           radGridView1.Rows.Add(false,
                               string.Format("{0:n}", transDate),
                               refnum,
                               acctno,
                               name,
                               collected_amt.ToString("n"),
                               current,
                               arrears, 
                               penalty,
                               ifpay,
                               mtrmtnPay, advpay,
                               zoneUID, masterID);
            */
            radGridView1.Rows.Add(false, branchID, transDate, acctno, name,collected_amt.ToString("n"), current, arrears,penalty, ifpay, mtrmtnPay,advpay, zoneUID,masterID);

            rec_count++;
            System.Threading.Thread.CurrentThread.Join(10);
            // break;

            
            //radGridView1.Rows.Add(false, branchID, transDate, p, name, collected);

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

        private decimal checkPenalty(int masterID, DateTime dt, int billingID)
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

        private decimal checkCurrent(int masterID, DateTime dt, int billingID)
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
            decimal arrears = 0;
            string[] firstdaytemp = comboBox1.Text.Split('-');
            firstday = string.Format("{0}/1/{1}", firstdaytemp[0], firstdaytemp[1]);
            //  decimal billingID = 97;
            //  int ledgerID = 0;
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                DateTime dt = new DateTime();

                dt = DateTime.Parse(firstday);
                tbLedger ledger = dbcontext.tbLedgers.Where(x => x.master_id == masterID && x.trans_date < dt).OrderByDescending(x => x.ledger_id).FirstOrDefault();
                //tbLedger ledger = dbcontext.tbLedgers.Where(x => x.master_id == masterID).OrderByDescending(x => x.ledger_id).First();
                if (ledger != null)
                {
                    if (ledger.balance > 0)
                    {
                        arrears = Convert.ToDecimal(ledger.balance);
                    }
                    else
                    {
                        arrears = 0;
                    }
                }

            }
            return arrears;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int rowcount = radGridView1.Rows.Count();
            if (rowcount <= 0)
            {
                MessageBox.Show("No records detected.");
                return;              
            }
            decimal colAmt = 0;
            for (int i = rowcount; i > 0; i--)
            {
                colAmt = 0;
                if (radGridView1.Rows[i - 1].Cells[0].Value.Equals(true))
                {
                    colAmt = decimal.TryParse(radGridView1.Rows[i - 1].Cells[5].Value.ToString(), out colAmt) ? colAmt : 0;
                    radGridView1.Rows[i - 1].Delete();
                    totalCollected -= colAmt;
                    totalRecords--;
                }
            }

            Boolean haveErrorAccounts = checkErrorAccounts();
            btnSave.Enabled = haveErrorAccounts ? false : true;
            labelTotalRecords.Text = string.Format("Number of Records : {0}", totalRecords);
            labelTotalAmt.Text = string.Format("Total Collected Amount : {0}", totalCollected);
        }

        private bool checkErrorAccounts()
        {
            Boolean result = false;
            int rowcount = radGridView1.Rows.Count();           
            decimal colAmt = 0;
            for (int i = rowcount; i > 0; i--)
            {
                colAmt = 0;
                if (radGridView1.Rows[i - 1].Cells[3].Value.Equals("ERROR"))
                {
                    result = true;
                }
            }
            return result;
        }


        private bool checkIfPosted(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var bankCol = dbcontext.tbBankCollections.SingleOrDefault(x => x.master_id == masterID && x.billmonth.Equals(comboBox1.Text) && x.collect_agent.Equals("BAYAD"));
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Do you want to save the data?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                //button2_Click(sender, e);
                if (checkIfPosted(Convert.ToInt32(radGridView1.Rows[0].Cells[13].Value)))
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
                        bank.date_collected = Convert.ToDateTime(radGridView1.Rows[i].Cells[2].Value);
                        bank.collect_agent = "BAYAD";
                        bank.billmonth = comboBox1.Text;
                        bank.zone = radGridView1.Rows[i].Cells[12].Value.ToString();
                        if (radGridView1.Rows[i].Cells[1].Value.ToString().Length > 10)
                        {
                            bank.refnum = radGridView1.Rows[i].Cells[1].Value.ToString().Substring(0,9);
                        }
                        else
                        {
                            bank.refnum = radGridView1.Rows[i].Cells[1].Value.ToString();
                        }
                        bank.current = Convert.ToDecimal(radGridView1.Rows[i].Cells[6].Value);
                        bank.arrears = Convert.ToDecimal(radGridView1.Rows[i].Cells[7].Value);
                        bank.penalty = Convert.ToDecimal(radGridView1.Rows[i].Cells[8].Value);
                        bank.others = Convert.ToDecimal(radGridView1.Rows[i].Cells[9].Value); // IF
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
                    MessageBox.Show("Bayad Centers Payments has been posted successfully.");
                    this.Text = oldtxt;
                    radGridView1.Rows.Clear();
                    Close();
                    

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime sept = new DateTime(2021,09,15);
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var qBayadCenter = dbcontext.tbBankCollections.Where(x => x.collect_agent.Equals("BAYAD") && x.billmonth.Equals("09-2021") && (x.date_collected.Value.CompareTo(sept) >= 0)).Select(x => x);

                int total = qBayadCenter.Count();
                int notBalance = 0;
                string notStr="";
                foreach (tbBankCollection tbBank in qBayadCenter)
                {
                    decimal current = Convert.ToDecimal(tbBank.current);
                    decimal collected = Convert.ToDecimal(tbBank.totalamt);
                    decimal arrears = Convert.ToDecimal(tbBank.arrears);
                    decimal advpay = Convert.ToDecimal(tbBank.advpay);
                    decimal penalty = Convert.ToDecimal(tbBank.penalty);                                             
                  
                     if (current > 5)
                    {
                        tbBank.mtr_mtn = 5;
                        tbBank.current = current - 5;
                    }
                   
                }
                //MessageBox.Show(string.Format("Not balance {0}", notBalance));

                dbcontext.SaveChanges();
                MessageBox.Show("Done repair");

            }
        }
    }
}
