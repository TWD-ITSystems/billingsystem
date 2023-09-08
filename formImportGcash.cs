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

namespace BillingSystem
{
    public partial class formImportGcash : Form
    {
        public int userID;
        GlobalFunctions gfunc = new GlobalFunctions();
        decimal mtrmtn = 0;
        decimal totalAmt = 0;
        int rec_count = 0;
        int unrec_acct = 0;
        int amt_error = 0;
        string firstday;


        public formImportGcash()
        {
            InitializeComponent();
        }

        private decimal checkArrears(int masterID)
        {
            decimal arrears = 0; 


            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct arrears_rec = (from tbMastAct in dbcontext.tbMasterAccts
                                            where tbMastAct.master_id == masterID 
                                            select tbMastAct).Single();

                arrears = arrears_rec.bill_arrears.HasValue ? (decimal)arrears_rec.bill_arrears: 0;
            }
            return arrears; 
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


        private tbMasterAcct getAccount(int masterID)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbMasterAcct table = dbcontext.tbMasterAccts.SingleOrDefault(x => x.master_id == masterID);
                return table;
            }

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


        private void load_xls()
        {

            radGridView1.Rows.Clear();
            string filename = "";
            mtrmtn = gfunc.getMeterMtn();




            rec_count = 0;
            unrec_acct = 0;
            amt_error = 0;
            totalAmt = 0;

            showSummary();
            decimal arrears = 0;
            decimal collected_amt = 0;
            decimal running_amt = 0;
            decimal current = 0;
            decimal penalty = 0;
            decimal ifpay = 0;
            decimal mtrmtnPay = 0;
            decimal advpay = 0;
            int billingID = gfunc.getBillingID(comboBox1.Text);
            DialogResult result = openFileDialog1.ShowDialog();
            string extend_mode = "";
            if (result == DialogResult.OK)
            {
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

                    try
                    {

                        var data = ds.Tables["tbCollect"].AsEnumerable();
                        var query = data.Select(x => new
                          {
                              details = x.Field<string>("details"),
                              transdate = x.Field<string>("transdatetime"),
                              billpay = x.Field<string>("type"),
                              refnum = x.Field<string>("transid"),
                              channel = x.Field<string>("channel"),
                              collected_amt = x.Field<double>("amount")
                              //collected_amt = 0
                          }).Where(x => x.billpay.Equals("billpay"));

                        foreach (var payAcctno in query)
                        {
                            try
                            {
                                string acctno = payAcctno.details.Substring(4, 6);
                                int masterID = gfunc.getMasterID(acctno);
                                if (masterID == 0)
                                {
                                    MessageBox.Show("Please resolve the account of " + payAcctno.details, "Unknown Format Error");
                                    return;
                                }

                            }
                            catch
                            {
                                MessageBox.Show("Please resolve the account of " + payAcctno.details, "Unknown Format Error");
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

                                string acctno = payData.details.Substring(4, 6);
                                int masterID = gfunc.getMasterID(acctno);
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
                                                     payData.details,
                                                     0,
                                                     0,
                                                     0,
                                                     0,
                                                     0,
                                                     0, 0);
                                    unrec_acct++;
                                    continue;
                                }

                                if (payData.refnum.Length > 10)
                                {
                                    refnum = payData.refnum;
                                }
                                else
                                {
                                    refnum = payData.refnum;
                                }


                                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                                {
                                    ifpay = checkIF(masterID);
                                    current = checkCurrent(masterID, Convert.ToDateTime(payData.transdate), billingID);
                                    penalty = checkPenalty(masterID, Convert.ToDateTime(payData.transdate), billingID);
                                    arrears = checkArrears(masterID);
                                    //arrears = checkArrears(masterID);
                                    collected_amt = Convert.ToDecimal(payData.collected_amt);
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

                                radGridView1.Rows.Add(false,
                                                   string.Format("{0:d}", Convert.ToDateTime(payData.transdate)),
                                                   refnum,
                                                   acctno,
                                                   gfunc.getAcctName(acctno),
                                                   payData.collected_amt,
                                                   current,
                                                   arrears,
                                                   penalty,
                                                   ifpay,
                                                   mtrmtnPay, advpay,
                                                   zoneUID, masterID);



                                rec_count++;
                                   System.Threading.Thread.CurrentThread.Join(10);
                                // break;
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("Excel format not supported. Please check the GCASH report.", "Unknown Format Error");
                            return;
                        }



                    }
                    catch (InvalidCastException ex)
                    {
                       // MessageBox.Show("Invalid format detected. Please convert to TEXT format the transid column","GCASH Import....");
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                MessageBox.Show("Import is Successful","GCASH Import...");
                button2.Show();
                button3.Show();
                showSummary();
            }
        }

        private void showSummary()
        {
            totalAmt = 0;
            rec_count = 0;
            if (radGridView1.Rows.Count > radGridView1.ChildRows.Count)
            {
                foreach (var row in radGridView1.ChildRows)
                {
                    decimal amt = Convert.ToDecimal(row.Cells[5].Value);
                    totalAmt += amt;
                }
                rec_count = radGridView1.ChildRows.Count;
            }
            else
            {
                foreach (var row in radGridView1.Rows)
                {
                    decimal amt = Convert.ToDecimal(row.Cells[5].Value);
                    totalAmt += amt;
                }
                rec_count = radGridView1.Rows.Count;

            }
            labelAmt.Text = string.Format("Total Amount : {0:n}", totalAmt);
            labelCount.Text = string.Format("Total Records : {0}", rec_count);
            labelUnrecognized.Text = string.Format("Unrecognized Accounts : {0}", unrec_acct);
            labelError.Text = string.Format("Error in Amount : {0}", amt_error);
        }

        private void formImportGcash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            radGridView1.EnableCustomFiltering = true;
            radGridView1.EnableFiltering = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_xls();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dgBox = MessageBox.Show("Do you really want to save this data?Please check first the BILLMONTH", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgBox == DialogResult.Yes)
            {
                button2_Click(sender, e);
                if (checkIfPosted(Convert.ToInt32(radGridView1.Rows[0].Cells[12].Value)))
                {
                    MessageBox.Show("This file is already been posted.");
                    return;
                }

                string oldtxt = this.Text;
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {

                    
                    if (radGridView1.Rows.Count == radGridView1.ChildRows.Count)
                    {
                        for (int i = 0; i < radGridView1.Rows.Count; i++)
                        {
                            tbBankCollection bank = new tbBankCollection();
                            bank.master_id = Convert.ToInt32(radGridView1.Rows[i].Cells[13].Value);
                            bank.date_collected = Convert.ToDateTime(radGridView1.Rows[i].Cells[1].Value);
                            bank.collect_agent = "GCASH";
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
                            bank.advpay = Convert.ToDecimal(radGridView1.Rows[i].Cells[11].Value); bank.posted_by = gfunc.getUserInitials(userID); bank.date_posted = DateTime.Today; dbcontext.AddTotbBankCollections(bank); this.Text = string.Format("Saving ... {0}", bank.master_id);
                            //tbMasterAcct mastacc = dbcontext.tbMasterAccts.Single(x => x.master_id == bank.master_id);
                        }
                    }
                    else
                    {
                        foreach (var rows in radGridView1.ChildRows)
                        {
                            tbBankCollection bank = new tbBankCollection();
                            bank.master_id = Convert.ToInt32(rows.Cells[13].Value);
                            bank.date_collected = Convert.ToDateTime(rows.Cells[1].Value);
                            bank.collect_agent = "GCASH";
                            bank.billmonth = comboBox1.Text;
                            bank.zone = rows.Cells[12].Value.ToString();
                            bank.refnum = rows.Cells[2].Value.ToString();
                            bank.current = Convert.ToDecimal(rows.Cells[6].Value);
                            bank.arrears = Convert.ToDecimal(rows.Cells[7].Value);
                            bank.penalty = Convert.ToDecimal(rows.Cells[8].Value);
                            bank.others = Convert.ToDecimal(rows.Cells[9].Value);
                            bank.senior = 0;
                            bank.totalamt = Convert.ToDecimal(rows.Cells[5].Value);
                            bank.mtr_mtn = Convert.ToDecimal(rows.Cells[10].Value);
                            bank.advpay = Convert.ToDecimal(rows.Cells[11].Value);

                            bank.posted_by = gfunc.getUserInitials(userID);
                            bank.date_posted = DateTime.Today;

                            dbcontext.AddTotbBankCollections(bank);
                            this.Text = string.Format("Saving ... {0}", bank.master_id);

                        }
                    }
                    dbcontext.SaveChanges();
                    MessageBox.Show("GCash Payments has been posted successfully.");
                    this.Text = oldtxt;
                    radGridView1.Rows.Clear();
                    showSummary();
                    button2.Hide();
                    button3.Hide();
                }
            }
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
                    if (radGridView1.Rows[i - 1].Cells[3].Value.Equals("DMTR") || radGridView1.Rows[i - 1].Cells[3].Value.Equals("ERROR"))
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

        private void radGridView1_CustomFiltering(object sender, Telerik.WinControls.UI.GridViewCustomFilteringEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                e.Visible = true;

            }
            else
            {
                 string tbox = e.Row.Cells[1].Value.ToString();
                 if (tbox.Equals(txtFilter.Text))
                 {
                     decimal amt = Convert.ToDecimal(e.Row.Cells[5].Value.ToString());
                     e.Visible = true;
                 }
                 else
                 {
                     e.Visible = false;
                 }

            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                radGridView1.MasterTemplate.Refresh();
                tabControl1.SelectedIndex = 0;
                showSummary();
            }
            tabControl1.TabPages[1].Text = string.Format(" Filter Dates by [ {0} ]", txtFilter.Text);
        }

        private void btnFilterClear_Click(object sender, EventArgs e)
        {
            txtFilter.Clear();
            radGridView1.MasterTemplate.Refresh();
            tabControl1.SelectedIndex = 0;
            showSummary();
            tabControl1.TabPages[1].Text = string.Format(" Filter Dates by [ {0} ]", txtFilter.Text);
        }

   

    }   
}
