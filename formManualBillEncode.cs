using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace BillingSystem
{
    public partial class formManualBillEncode : Form
    {
        public int userID=0;
        public string username="";

        bool isEncoded = false;
        GlobalFunctions gfunc = new GlobalFunctions();
        public formManualBillEncode()
        {
            InitializeComponent();
        }

        private void formManualBillEncode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsZoneLookup.tbZoneLookup' table. You can move, or remove it, as needed.
            this.tbZoneLookupTableAdapter.Fill(this.dsZoneLookup.tbZoneLookup);
            // TODO: This line of code loads data into the 'dsZoneLookup.tbZoneLookup' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dsBilling.tbBilling' table. You can move, or remove it, as needed.
            this.tbBillingTableAdapter.Fill(this.dsBilling.tbBilling);
            username = gfunc.getUserInitials(userID);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBillMonth.Text + " = Zone :" + comboZone.Text);
            string zone = comboZone.Text.PadLeft(2, '0');
           
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //var qData = dbcontext.tbManualBills.Where(x => x.zone.Substring(0, 2).StartsWith(zone) && x.billmonth.Equals(comboBillMonth.Text)).OrderBy(x => new {x.zone ,x.cardno});
                var qData = dbcontext.tbManualBills.Where(x => x.zone.Substring(0, 2).StartsWith(zone) && x.billmonth.Equals(comboBillMonth.Text));
                
                foreach (tbManualBill tbData in qData)
                {
                    radGridView1.Rows.Add(false,
                        tbData.acctno,
                        tbData.name,
                        tbData.prev_rdg,
                        tbData.pres_rdg,
                        tbData.manual_id,
                        tbData.prev_rdg_date.Value.ToShortDateString(), //[6] date previous
                        tbData.pres_rdg_date, //[7] date present
                        tbData.volume, //[8] Volume
                        tbData.current_amt,  // [9] current
                        tbData.arrears,   // [10] Arrears
                        tbData.instfee,   // [11] Inst Fee
                        tbData.current_amt + tbData.arrears + tbData.instfee,  // [12] Total Bill
                        tbData.penalty,  // [13] Penalty
                        tbData.cardno, // [14] Card No.
                        tbData.zone,   // [15]   zone
                        tbData.master_id,  // [16]  masterid
                        tbData.encoded_by,       //  [17] encoder
                        tbData.date_processed     //  [18] billing date
                        );
                
                }

                if (qData.Count() > 0)
                {
                    btnDelete.Show();
                    btnPrint.Show();
                    btnSave.Show();
                    btnAddEntry.Show();
                }
            }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Column.Index != 0)
                {
                    int prev = Convert.ToInt32(radGridView1.CurrentRow.Cells[3].Value);
                    int pres = Convert.ToInt32(radGridView1.CurrentRow.Cells[4].Value);
                    int mastID = Convert.ToInt32(radGridView1.CurrentRow.Cells[16].Value);
                    int diff = pres - prev;
                    try
                    {

                        if (diff < 0) throw new NullReferenceException("Negative reading detected.");
                        isEncoded = true;
                    }
                    catch (Exception ex)
                    {
                        diff = 0;
                        MessageBox.Show("Invalid input detected.Setting to 0 volume.");
                        radGridView1.CurrentCell.Value = prev;
                    }
                    radGridView1.CurrentRow.Cells[8].Value = diff;
                    decimal current = gfunc.processCurrent(mastID, diff);
                    decimal arrears = gfunc.getArrears(mastID);
                    decimal iffee = gfunc.getIF2(mastID);

                    radGridView1.CurrentRow.Cells[9].Value = current;
                    radGridView1.CurrentRow.Cells[10].Value = arrears;
                    radGridView1.CurrentRow.Cells[11].Value = iffee;
                    radGridView1.CurrentRow.Cells[12].Value = current + arrears + iffee;
                    radGridView1.CurrentRow.Cells[13].Value = gfunc.computePenalty(current);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detected please try again.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowcount = radGridView1.Rows.Count();
                for (int i = rowcount; i > 0; i--)
                {
                    if (radGridView1.Rows[i - 1].Cells[0].Value.Equals(true))
                    {
                        radGridView1.Rows[i - 1].Delete();
                    }
                }
                if (radGridView1.Rows.Count() <= 0)
                {
                   btnSave.Enabled = false;
                }
            }
            catch
            {
                return;
            }
        }

        private void comboZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radGridView1.RowCount > 0)
            {
                radGridView1.Rows.Clear();
                btnDelete.Hide();
                btnPrint.Hide();
                btnSave.Hide();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEncoded)
            {
                DialogResult dlgResult = MessageBox.Show("Do you want to save the entries?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                    {
                       // var gridData = radGridView1.Rows.Select(x => x);
                        var gridData = radGridView1.Rows.Where(x=>x.Cells[4].Value != null);
                        foreach (var cell in gridData)
                        {
                            int recID = Convert.ToInt32(cell.Cells[5].Value.ToString());
                            int presRdg = Convert.ToInt32(cell.Cells[4].Value.ToString());
                            int prevRdg = Convert.ToInt32(cell.Cells[3].Value.ToString());
                            int volume = Convert.ToInt32(cell.Cells[8].Value.ToString());
                            int masterID = gfunc.getMasterID(cell.Cells[1].Value.ToString());
                            decimal currentAmt = Convert.ToDecimal(cell.Cells[9].Value.ToString());
                            decimal penalty = Convert.ToDecimal(cell.Cells[13].Value.ToString());
                            decimal arrears = Convert.ToDecimal(cell.Cells[10].Value.ToString());
                            decimal instfee = Convert.ToDecimal(cell.Cells[11].Value.ToString());
                            int ave_vol = gfunc.getAverageVolume(masterID);
                            string prev_rdg_date = cell.Cells[6].Value.ToString();

                          
                            if (recID != -1)
                            {
                               tbManualBill manualBill = dbcontext.tbManualBills.First(x => x.manual_id == recID);
                                manualBill.pres_rdg = presRdg;
                                manualBill.pres_rdg_date = dtBilledDate.Value;
                                manualBill.prev_rdg = prevRdg;
                                manualBill.volume = volume;
                                manualBill.arrears = arrears;
                                manualBill.penalty = penalty;
                                manualBill.instfee = instfee;
                                manualBill.encoded_by = username;
                                manualBill.date_processed = DateTime.Today;
                                manualBill.ave_vol = ave_vol;
                                manualBill.processed = 1;

                                if (currentAmt <= 0)
                                {
                                    manualBill.current_amt = gfunc.processCurrent(masterID, volume) + gfunc.getMeterMtn();
                                }
                                else
                                {
                                    manualBill.current_amt = currentAmt;
                                }
                            }
                            else
                            {
                                tbManualBill addManual = new tbManualBill();
                                addManual.pres_rdg = presRdg;
                                addManual.pres_rdg_date = dtBilledDate.Value;
                                addManual.volume = volume;
                                addManual.arrears = arrears;
                                addManual.instfee = instfee;
                                addManual.penalty = penalty;
                                addManual.encoded_by = username;
                                addManual.date_processed = DateTime.Today;
                                addManual.date_added = DateTime.Today;
                                addManual.ave_vol = ave_vol;
                                addManual.name = cell.Cells[2].Value.ToString();
                                addManual.acctno = cell.Cells[1].Value.ToString();
                                addManual.address = gfunc.getMasterAddress(masterID);
                                addManual.zone =  cell.Cells[15].Value.ToString();
                                addManual.cardno = Convert.ToInt32(cell.Cells[14].Value.ToString());
                                addManual.billmonth = comboBillMonth.Text;
                                addManual.prev_rdg = prevRdg;
                                addManual.prev_rdg_date = Convert.ToDateTime(prev_rdg_date);
                                addManual.master_id = Convert.ToInt32(cell.Cells[16].Value.ToString());
                                addManual.meter_num = gfunc.getMeterNumber(cell.Cells[1].Value.ToString());
                                addManual.ctgy = gfunc.getCategory(masterID);
                                addManual.mtrmaintenance = gfunc.getMeterMtn();
                                addManual.septagefee = 0;
                                addManual.dmgmtr = 0;
                                addManual.processed = 1;
                                if (currentAmt <= 0)
                                {
                                    addManual.current_amt = gfunc.processCurrent(masterID, volume) + gfunc.getMeterMtn();
                                }
                                else
                                {
                                    addManual.current_amt = currentAmt;
                                }
                                dbcontext.AddTotbManualBills(addManual);
                            }
                        }
                        dbcontext.SaveChanges();
                        radGridView1.Rows.Clear();
                        MessageBox.Show("Manual bills has been saved successfully.");
                        btnLoad.PerformClick();
                    }
                }
            }
            else
            {
                MessageBox.Show("there is nothing to be save");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            //ArrayList param = new ArrayList();
            //string zone = comboZone.Text.PadLeft(2, '0');
            //string billmonth = comboBillMonth.Text;
            //param.Add(username);
            //param.Add(zone);
            //param.Add(billmonth);
            
            //frmReport frmRpt = new frmReport();
            //frmRpt.rptMode = 28;
            //frmRpt.param = param;
            //frmRpt.Show();

            string filepath = "";
            string filename = "";
            string msg_text = "";
            DialogResult result =  folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                filepath = folderBrowserDialog1.SelectedPath;
                string appPath = Application.StartupPath;
                string sourceFile = string.Format(@"{0}\templates\BILL0000.DBF", appPath);
                string newFile = string.Format(@"{0}\BILL{1}99.DBF", filepath, comboZone.Text.PadLeft(2, '0'));
                filename = string.Format("BILL{0}99.DBF", comboZone.Text.PadLeft(2, '0'));

                if (File.Exists(newFile))
                {
                    DialogResult resultEx = MessageBox.Show(string.Format("{0} already exists. Do you want to overwrite.", filename), "File Exists", MessageBoxButtons.OKCancel);
                    if (resultEx == DialogResult.OK)
                    {
                        File.Copy(sourceFile, newFile, true);
                        msg_text = "has been created.";
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    File.Copy(sourceFile, newFile);
                    msg_text = "has been created.";
                }
            }
            else
            {
                return;
            }


            //var dsData = radGridView1.Rows.Select(x => x);
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                //var qData = dbcontext.tbManualBills.Where(x => x.zone.Substring(0, 2).StartsWith(zone) && x.billmonth.Equals(comboBillMonth.Text)).OrderBy(x => new { x.zone, x.cardno });
               //  var qData = dbcontext.tbManualBills.Where(x => x.zone.Substring(0, 2).StartsWith(zone) && x.billmonth.Equals(comboBillMonth.Text)).OrderBy(x => new {x.zone ,x.cardno});
                string padZone = comboZone.Text.PadLeft(2, '0');
                var qData = dbcontext.tbManualBills.Where(x => x.zone.Substring(0, 2).StartsWith(padZone) && x.billmonth.Equals(comboBillMonth.Text) && x.current_amt > 0 && x.refnum.Length > 3);
                
                DBRemix saveDBF = new DBRemix(filepath, true);

                ArrayList saveData = new ArrayList();
                string[] paramList = { "AVE", "ACCTNO", "ZONE", "NAME", "ADDRESS", "METNO", "CTGRY", "CARDNO",
                                       "DATEPREV", "PREVRDG", 
                                       "ENCODER", "OTHERS", "ARREARS","CURRENT","PENALTY","DATEPRES","PRESRDG","VOLUME","REF" };
                
                foreach (var upRec in qData)
                {
                    saveData.Clear();
                    saveData.Add(upRec.ave_vol);
                    saveData.Add(upRec.acctno);
                    saveData.Add(upRec.zone);
                    saveData.Add(upRec.name);
                    if (upRec.address.Length >= 30)
                    {
                        saveData.Add(upRec.address.Substring(0, 30));
                    }
                    else
                    {
                        saveData.Add(upRec.address);
                    }
                        saveData.Add(upRec.meter_num);
                    saveData.Add(upRec.ctgy);
                    saveData.Add(upRec.cardno);
                    saveData.Add(upRec.prev_rdg_date.Value.ToShortDateString());
                    saveData.Add(upRec.prev_rdg);                   
                    saveData.Add(upRec.encoded_by.Substring(0,3));
                    saveData.Add(upRec.instfee);
                    saveData.Add(upRec.arrears);
                    saveData.Add(upRec.current_amt);
                    saveData.Add(upRec.penalty);
                    saveData.Add(upRec.pres_rdg_date.Value.ToShortDateString());
                    saveData.Add(upRec.pres_rdg);
                    saveData.Add(upRec.volume);
                    saveData.Add(upRec.refnum);
                    if (upRec.printed_times.HasValue)
                    {
                        upRec.printed_times += 1;
                    }
                    else
                    {
                        upRec.printed_times=1;
                    }
                   
                    saveDBF.SaveToOLEDatabase(filename, saveData, paramList);
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Export is successfull."); 
            }

        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            using (formManualBillAddEntry frmAddNew = new formManualBillAddEntry())
            {
                frmAddNew.zone = comboZone.Text;
                frmAddNew.billmonth = comboBillMonth.Text;
                DialogResult result = frmAddNew.ShowDialog();
                String acctno = "";
                if (result == DialogResult.OK)
                 acctno = frmAddNew.acctno;
                addManualEntry(acctno);
            }
        }

        private void addManualEntry(string acctno)
        {
            int masterID = gfunc.getMasterID(acctno);
            string zone = gfunc.getZoneName(acctno).Substring(0,2);
            string thiszone = comboZone.Text.PadLeft(2, '0');
            if (zone.Equals(thiszone))
            {              
                int dblaccount = radGridView1.Rows.Where(x => x.Cells[1].Value.Equals(acctno)).Count();
                if (dblaccount > 0)
                {
                    MessageBox.Show("Account is already on the list.");
                }
                else
                {
                    radGridView1.Rows.Add(
                        false, // [0] checkbox
                        acctno, // [1] acctno
                        gfunc.getMasterName(masterID), // [2]  Name
                        gfunc.getLastReading(masterID),  //  [3] prev rdg
                        string.Empty,  // [4] pres rdg
                        "-1",  // [5]  manual id
                        gfunc.getPrevDate(masterID), // [6]  Date Previous
                        string.Empty, // [7] Date Present
                        string.Empty, // [8]  Volume
                        string.Empty, // [9]  Current
                        string.Empty, // [10] Arrears
                        string.Empty, // [11] Inst Fee
                        string.Empty, // [12] Total Bill
                        string.Empty, // [13] Penalty
                        gfunc.getCardNo(masterID),  // [14] Card No.
                        gfunc.getZoneName(acctno), // [15] Zone
                        masterID, // [16]  Masterid
                        string.Empty, // [17] encoder
                        string.Empty // [18] Billing Date
                        );

                }

            }
            else
            {
                MessageBox.Show("Account is on different zone. Request denied.");
            }
        }



        


        
    }
}
