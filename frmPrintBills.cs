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
    public partial class frmPrintBills : Form
    {
        int billing_id = 0;
        string zone_book = "";
        DataSet dsBillPrint = new DataSet();
        DateTime dueOffice = new DateTime();
        DateTime dueBank = new DateTime();
        DateTime dateDisco = new DateTime();
        int intRef = 0;
        int billproc_id = 0;
        bool isPrinted = false;
        bool soloPrint = false;
        bool printArrears = false;
        string cardnum="";
        int UID = 0;

        public frmPrintBills()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            bool ok_int = false;

            //frmReport fReport = new frmReport();
            //fReport.rptMode = 2;
            //fReport.ShowDialog();



            if (txtStartBillRef.TextLength <= 0)
            {
                MessageBox.Show("Please set the Bill Reference No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try { intRef = int.Parse(txtStartBillRef.Text); ok_int = true; }
            catch
            {
                ok_int = false;
                MessageBox.Show("Invalid Bill Reference No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ok_int)
            {
                dueBank = Convert.ToDateTime(dtBank.EditValue);
                dueOffice = Convert.ToDateTime(dtPenalty.EditValue);
                dateDisco = Convert.ToDateTime(dtDisco.EditValue);
                zone_book = cmbZone.Text;
                progressPanel1.Show();
                billproc_id = getBillProcID();
                cardnum = txtStartCardNo.Text.Trim();
                backgroundWorker1.RunWorkerAsync();
            }            
        }


        private void frmPrintBills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            this.Height = 130;
            load_Zone();
            load_PaymentCenter();
            labelNote.Hide();
            progressPanel1.Hide();
        }

        private void load_Zone()
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbZones select en);

                tbZoneBindingSource.DataSource = query;
            }
        }

        private void load_PaymentCenter()
        {
            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                string query = (from en in context.tbSettings
                                select en.collecting_agents).FirstOrDefault();
                txtAgents.Text = query;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                txtAgents.Text = "TAGUM WATER DISTRICT OFFICE";
                printArrears = true;
            }
            else
            {
                printArrears = false;
                load_PaymentCenter();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int billproc_id = 0;                        
            billproc_id = getBillProcID();
            if (billproc_id > 0 )
            {
                labelNote.Text = "Billfile is ready for printing";
                labelNote.ForeColor = Color.Blue;
                labelNote.Show();
                this.Height = 495;
                getDueDates();
                isPrinted = new GlobalFunctions().getBillPrinted(billproc_id).HasValue;

            }
            else
            {
                this.Height = 130;
                labelNote.Text = "Billfile not yet finalized.";
                labelNote.ForeColor = Color.Red;
                labelNote.Show();
            }

        }

        private void getDueDates()
        {
            int billing_id = (int)cmbMonth.SelectedValue;
            string zoneStr = cmbZone.Text;
            string zoneS = "";
            if (zoneStr.Length == 4)
            {
                zoneS = zoneStr.Substring(0, 2);
            }
            else if (zoneStr.Length == 3)
            {
                zoneS = zoneStr.Substring(0, 1);
            }
            else
            {
                MessageBox.Show("Wrong Zone No. has been detected.");
            }
                        
            int zone = Convert.ToInt32(zoneS);

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillingSchedules
                             where en.billing_id == billing_id && en.zone == zone
                             select en).SingleOrDefault();
                if (query != null)
                {
                    if (query.date_due_bank.HasValue) dtBank.EditValue = query.date_due_bank;
                    if (query.date_due_office.HasValue) dtPenalty.EditValue = query.date_due_office;
                    if (query.date_due_disco_noarrears.HasValue) dtDisco.EditValue = query.date_due_disco_noarrears;
                    //MessageBox.Show(DateTime.Parse(dtBank.EditValue.ToString()).ToShortDateString());                    
                }

            }
        }

        private int getBillProcID()
        {
            int temp;
            int billID;
            string zonebook;

            billID = (int)cmbMonth.SelectedValue;
            zonebook = cmbZone.Text;
            temp = new GlobalFunctions().checkBillFinalized(billID, zonebook);

            return temp;
        }  //end getBillProcID

        private void processBillToPrint(int billref)
        {
            
            int billrefcounter = 0;

             UID = new GlobalFunctions().generateUID();
             using (dbCommercialEntities context = new dbCommercialEntities())
             {
                 
                 var query = (from en in context.tbBillingDetails
                              where en.billproc_id == billproc_id
                              select en);
                 if (printArrears)
                 {
                     query = query.Where(a => a.arrears > 0);
                 }
                 //if (soloPrint && (cardnum.Length > 0))
                 //{
                 //    query = query.Where(a => a.tbMaster.cardno.Equals(cardnum));
                 //    if (query != null)
                 //    {

                 //    }
                 //}
                 //else if (soloPrint && (cardnum.Length == 0))
                 //{
                 //    MessageBox.Show("Please specify card no. to print.");
                 //    return;
                 //}                 


                    if (query != null)
                    {
                        int tst = query.Count();
                        billrefcounter = billref;
                        foreach (tbBillingDetail bill in query)
                        {

                            //if ((soloPrint == false) && (cardnum.Length > 0))
                            //{
                            //    int a = bill.tbMaster.cardno;
                            //    int cStart = int.TryParse(cardnum.Trim(), out cStart) ? cStart : 0;
                            //    if (a < cStart) continue;                                
                            //}
                            //tbBillPrinted billforprint = new tbBillPrinted();

                            //billforprint.acctno = bill.tbMaster.acctno;
                            //int cardno = bill.tbMaster.cardno;
                            //billforprint.card_no = cardno;
                            //billforprint.class_type = bill.tbMaster.category;
                            //billforprint.zone_book = zone_book;
                            //billforprint.address = bill.tbMaster.address;
                            //billforprint.arrears = checkDecimal(bill.arrears);
                            //billforprint.bill_month = getBillMonth(bill.billproc_id);
                            //billforprint.bill_ref_no = billrefcounter.ToString();
                            //billforprint.billing_id = billing_id;
                            //billforprint.current = checkDecimal(bill.current);
                            //billforprint.dmg_mtr = checkDecimal(bill.mtr_dmg);
                            //billforprint.duedate_bank = dueBank;
                            //billforprint.duedate_surcharge = dueOffice;
                            //billforprint.date_disco = dateDisco;
                            //billforprint.from_to = getFromTo(Convert.ToDateTime(bill.date_pres), Convert.ToDateTime(bill.date_prev));
                            //billforprint.fullname = bill.tbMaster.name;
                            //billforprint.if2 = checkDecimal(bill.inst_fee);
                            //billforprint.master_id = bill.master_id;
                            //billforprint.meter_no = new GlobalFunctions().getMeterNumber(bill.tbMaster.meter_id);
                            //billforprint.mtr_mtn = checkDecimal(bill.mtr_mtn);
                            //billforprint.rdg_pres = (int)bill.rdg_pres;
                            //billforprint.rdg_prev = (int)bill.rdg_prev;
                            //billforprint.senior = checkDecimal(bill.senior);
                            //billforprint.surcharge = checkDecimal(bill.penalty);
                            //billforprint.volume = (int)bill.volume;
                            //decimal total = checkDecimal(bill.current) + checkDecimal(bill.mtr_mtn) + checkDecimal(bill.arrears) + checkDecimal(bill.mtr_dmg) + checkDecimal(bill.inst_fee) + checkDecimal(bill.senior);

                            //billforprint.total = total;
                            //billforprint.total_w_surcharge = total + billforprint.surcharge;
                            //context.tbBillPrinteds.AddObject(billforprint);
                            //billforprint.uid = UID;
                            //billrefcounter++;
                        }
                        context.SaveChanges();
                    }
                }
        }   //end processBillToPrint


        private string getFromTo(DateTime datepres,DateTime dateprev)
        {
            string retval = "";
            string date1, date2;            

            date1 = datepres.ToShortDateString();
            date2 = dateprev.ToShortDateString();

            retval = string.Format("{0} - {1}", date2, date1);

            return retval;
        } //end getFromTo

        private string getBillMonth(int billprocID)
        {
            string retval = "";
            string[] str_split;
            

            using (dbCommercialEntities context = new dbCommercialEntities())
            {
                var query = (from en in context.tbBillProcessings
                             join em in context.tbBillings on en.billing_id equals em.billing_id
                             where en.bill_process_id == billprocID
                             select new { billmon = em.billing_desc,billingID = em.billing_id }).SingleOrDefault();
                if (query != null)
                {
                    string temp = query.billmon.ToString();
                    billing_id = query.billingID;
                    str_split = temp.Split('-');
                    retval = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(Convert.ToInt32(str_split[0]));
                    retval = string.Format("{0} {1}", retval, str_split[1]);                    
                }                             
            }
            return retval;
        }  // end getBillMonth

        private decimal checkDecimal(decimal? decValue)
        {
            decimal retVal = 0;

            try
            {
                retVal = (decimal)decValue;
            }
            catch { retVal = 0; }
            return retVal;
        } // end checkValuesDecimal

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            processBillToPrint(intRef);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string paramStr = "";
            progressPanel1.Hide();
            
            if (printArrears)
            {
                paramStr = "arrears > 0";
            }
            else
            {
                if (soloPrint)
                {
                    paramStr = paramStr + " card_no ";
                }                
            }
            formViewBillYellow fReport = new formViewBillYellow();
            fReport.paramPaycenters = txtAgents.Text;
            fReport.paramFilterStr = "[arrears] > 0";
            fReport.Show();            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                soloPrint = true;
                
            }
            else if (radioButton5.Checked)
            {
                soloPrint = false;
            }
            txtStartCardNo.Focus();
        }

        private void txtStartCardNo_Validating(object sender, CancelEventArgs e)
        {
            if (soloPrint)
            {
                if (txtStartCardNo.TextLength == 0)
                {
                    MessageBox.Show("Please specify Card No. to print.");
                    e.Cancel = true;
                }
            }
        } 

        
    


    }
}
