using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;

namespace BillingSystem
{
    public partial class frmReport : Form
    {
        public int rptMode = 0;
        public ArrayList param = new ArrayList();



        const string DATAUSER = "commsys";
        const string DATAPASS = "comm123";
        const string DATABASE = "dbCommercial";
        const string DBRAFFLE = "dbRaffle";

        GlobalFunctions gfunc = new GlobalFunctions();
        string SERVER = "";
        dsDMAResult dsDMAData;
        dsDMAPattern dsDMAPattern;
             

        decimal mtrmtn = 0;

        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(dsDMAResult dsDMA)
        {
            dsDMAData = dsDMA;
            InitializeComponent();
        }

        public frmReport(dsDMAPattern dsPattern)
        {
            dsDMAPattern = dsPattern;
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                //SERVER = @"BILLSERVER\SQLEXPRESS";
                SERVER = ConfigurationManager.ConnectionStrings["ServerNew"].ConnectionString;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
               // SERVER = @"127.0.0.1\SQLEXPRESS";
                SERVER = @"SERVER_REZONE\SQLAGING";
                //SERVER = @"TWD-MISD-GPC\SQLSERVERDEV";

                //SERVER = @"127.0.0.1";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SERVER = @"TWD-MISD-GPC\SQLSERVERDEV";
            }else
            {
                SERVER = @"BILLSERVER1";
                
            }
                      

            switch (rptMode)
            {
                case 1:
                    rptBillfile billfile = new rptBillfile();       
             
                    billfile.DataSourceConnections.Clear();
                    billfile.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    billfile.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);

                    billfile.SetParameterValue("paramZoneBook", param[0]);
                    billfile.SetParameterValue("paramBillMonth", param[1]);
                    billfile.RecordSelectionFormula = "{tbBillingDetails.billproc_id} = " + param[2].ToString();
                    //billfile.SetDatabaseLogon(DATAUSER, DATAPASS, SERVER, DATABASE);
                    crystalReportViewer1.ReportSource = billfile;
                    crystalReportViewer1.Refresh();
                    break;
                case 2:
                    //rptBillPrint billview = new rptBillPrint();
                    //billview.SetDatabaseLogon(DATAUSER,DATAPASS);
                    //crystalReportViewer1.ReportSource = billview;
                    //crystalReportViewer1.Refresh();
                    break;
                case 3:

                    //rptBillPrint billprint = new rptBillPrint();
                    //billprint.SetDatabaseLogon(DATAUSER, DATAPASS);
                    //crystalReportViewer1.ReportSource = billprint;
                    //crystalReportViewer1.PrintReport();                    
                    break;
                case 4:
                    rptMasterAccts rptMActs = new rptMasterAccts();
                    //rptMActs.SetParameterValue("paramZone", param[0]);
                    rptMActs.DataSourceConnections.Clear();
                    rptMActs.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptMActs.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptMActs.RecordSelectionFormula = "{tbMaster.zone_id}=" + param[0].ToString();
                    //rptMActs.SetDatabaseLogon(DATAUSER, DATAPASS,SERVER,DATABASE);
                    crystalReportViewer1.ReportSource = rptMActs;
                    crystalReportViewer1.Refresh();
                    break;

                case 5:
                    RptMeterReaderFile rptMtrRdrFile = new RptMeterReaderFile();
                    rptMtrRdrFile.DataSourceConnections.Clear();
                    rptMtrRdrFile.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptMtrRdrFile.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptMtrRdrFile.RecordSelectionFormula = "{tbZone.zone_name}='" + param[0].ToString() + "' and {tbMaster.status}<> 'X' and {tbMaster.cardno}>=" + Convert.ToInt32(param[3].ToString()) + "and {tbMaster.cardno}<=" + Convert.ToInt32(param[4].ToString());
                    rptMtrRdrFile.SetParameterValue("pZone", param[1].ToString());
                    rptMtrRdrFile.SetParameterValue("pMeterReader", param[2].ToString());
                    rptMtrRdrFile.SetParameterValue("paramFrom", param[3]);
                    rptMtrRdrFile.SetParameterValue("paramTo", param[4]);
                    crystalReportViewer1.ReportSource = rptMtrRdrFile;
                    crystalReportViewer1.Refresh();
                    break;

                case 6:
                    rptBillPaid rptPaid = new rptBillPaid();

                    rptPaid.DataSourceConnections.Clear();
                    rptPaid.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptPaid.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);

                    rptPaid.RecordSelectionFormula = "{tbBankCollections.date_collected} in #" + param[2] + "# to #" + param[3] + "# and {tbBankCollections.collect_agent}='" + param[4].ToString() + "'";
                    rptPaid.SetParameterValue("paramBank", param[0].ToString());
                    rptPaid.SetParameterValue("paramDates", param[1].ToString());
                    rptPaid.SetParameterValue("paramPrepared", param[5].ToString());
                    rptPaid.SetParameterValue("paramNoted", param[6].ToString());
                    rptPaid.SetParameterValue("paramChecked", param[7].ToString());
                    rptPaid.SetParameterValue("paramRemarks", param[8].ToString());
                    crystalReportViewer1.ReportSource = rptPaid;
                    crystalReportViewer1.Refresh();
                    break;
                case 7:
                    rptMasterArrears rptArrears = new rptMasterArrears();

                    rptArrears.DataSourceConnections.Clear();
                    rptArrears.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptArrears.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);

                    rptArrears.RecordSelectionFormula = "{tbMaster.zone_id}=" + param[0] + " and {tbMasterAccts.bill_arrears}>0 and {tbMasterAccts.bill_balance}> 0 and {tbMaster.status} <> 'X'";
                    rptArrears.SetParameterValue("paramZone", param[1]);
                    crystalReportViewer1.ReportSource = rptArrears;
                    crystalReportViewer1.Refresh();
                    break;
                case 8:
                    xtalIFBalance rptIF = new xtalIFBalance();

                    rptIF.DataSourceConnections.Clear();
                    rptIF.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptIF.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    crystalReportViewer1.ReportSource = rptIF;
                    crystalReportViewer1.Refresh();
                    break;
                case 9:
                    mtrmtn = gfunc.getMeterMtn();

                    rptRecapAttach rptRecap = new rptRecapAttach();

                    rptRecap.DataSourceConnections.Clear();
                    rptRecap.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptRecap.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptRecap.SetParameterValue("mtrmtn", mtrmtn);
                    rptRecap.SetParameterValue("preparedby", param[0].ToString());
                    rptRecap.SetParameterValue("verifiedby", param[1].ToString());
                    rptRecap.SetParameterValue("billing_id", param[2]);
                    rptRecap.SetParameterValue("zoneid", param[3]);

                    crystalReportViewer1.ReportSource = rptRecap;
                    crystalReportViewer1.Refresh();
                    //  crystalReportViewer1.PrintReport();
                    break;

                case 10:
                    mtrmtn = gfunc.getMeterMtn();
                    rptRecapAttachSummary rptSummary = new rptRecapAttachSummary();
                    rptSummary.DataSourceConnections.Clear();
                    rptSummary.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptSummary.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptSummary.SetParameterValue("billmonth", param[4].ToString());
                    rptSummary.SetParameterValue("zone", param[5].ToString());
                    rptSummary.SetParameterValue("mtrmtn", mtrmtn);

                    crystalReportViewer1.ReportSource = rptSummary;
                    crystalReportViewer1.Refresh();
                    break;

                case 11:
                    rptAgingActiveCtgy rptAging = new rptAgingActiveCtgy();
                    rptAging.DataSourceConnections.Clear();
                    rptAging.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptAging.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptAging.SetParameterValue("paramDate", param[0]);
                    rptAging.SetParameterValue("paramMode", param[1]);
                    rptAging.SetParameterValue("paramBillMonth", param[2]);
                    rptAging.SetParameterValue("paramBal", param[3]);
                    rptAging.SetParameterValue("paramNegBal", param[4]);
                    rptAging.SetParameterValue("paramZeroBal", param[5]);
                    rptAging.SetParameterValue("paramPrepared", param[6]);
                    rptAging.SetParameterValue("paramDesignation", param[7]);
                    rptAging.SetParameterValue("paramCommMngr", param[8]);
                    rptAging.SetParameterValue("paramNoted", param[9]);

                    crystalReportViewer1.ReportSource = rptAging;
                    crystalReportViewer1.Refresh();
                    break;

                case 12:
                    rptAgingZone rptAgeZone = new rptAgingZone();
                    rptAgeZone.DataSourceConnections.Clear();
                    rptAgeZone.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptAgeZone.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptAgeZone.SetParameterValue("paramGenDate", param[0]);
                    rptAgeZone.SetParameterValue("paramStatus", param[1]);
                    rptAgeZone.SetParameterValue("paramBillID", param[2]);
                    rptAgeZone.SetParameterValue("paramPrepared", param[3]);
                    rptAgeZone.SetParameterValue("paramDesignation", param[4]);
                    rptAgeZone.SetParameterValue("paramVerified", param[5]);
                    rptAgeZone.SetParameterValue("paramNoted", param[6]);

                    crystalReportViewer1.ReportSource = rptAgeZone;
                    crystalReportViewer1.Refresh();
                    break;

                case 13:
                    rptAgingRecap rptAgeRecap = new rptAgingRecap();
                    rptAgeRecap.DataSourceConnections.Clear();
                    rptAgeRecap.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptAgeRecap.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);

                    rptAgeRecap.SetParameterValue("paramGenDate", param[0]);
                    rptAgeRecap.SetParameterValue("paramBillID", param[1]);
                    rptAgeRecap.SetParameterValue("paramPrepared", param[2]);
                    rptAgeRecap.SetParameterValue("paramDesignation", param[3]);
                    rptAgeRecap.SetParameterValue("paramVerify", param[4]);
                    rptAgeRecap.SetParameterValue("paramNoted", param[5]);

                    crystalReportViewer1.ReportSource = rptAgeRecap;
                    crystalReportViewer1.Refresh();
                    break;

                case 14:
                    rptRecapPenaltyDetailed rptPnlt = new rptRecapPenaltyDetailed();

                    rptPnlt.DataSourceConnections.Clear();
                    rptPnlt.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptPnlt.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    //rptPnlt.SetParameterValue("billmonth", param[0]);
                    rptPnlt.SetParameterValue("paramFirstDate", param[0]);
                    rptPnlt.SetParameterValue("paramLastDate", param[1]);
                    crystalReportViewer1.ReportSource = rptPnlt;
                    crystalReportViewer1.Refresh();
                    break;
                case 15:
                    rptBillingSummary rptSumm = new rptBillingSummary();
                    rptSumm.DataSourceConnections.Clear();
                    rptSumm.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptSumm.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptSumm.SetParameterValue("parambillmonth", param[0]);
                    rptSumm.SetParameterValue("paramPrepared", param[1]);
                    rptSumm.SetParameterValue("paramVerified", param[2]);
                    rptSumm.SetParameterValue("paramDesignation", param[3]);
                    crystalReportViewer1.ReportSource = rptSumm;
                    crystalReportViewer1.Refresh();
                    break;

                case 16:
                    rptSeniorDetailed rptSenior = new rptSeniorDetailed();
                    rptSenior.DataSourceConnections.Clear();
                    rptSenior.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptSenior.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptSenior.SetParameterValue("paramBillingID", param[0]);
                    rptSenior.SetParameterValue("paramBillMonth", param[1]);
                    crystalReportViewer1.ReportSource = rptSenior;
                    crystalReportViewer1.Refresh();
                    break;
                case 17:
                    rptBAMDetailed rptBAM = new rptBAMDetailed();
                    rptBAM.DataSourceConnections.Clear();
                    rptBAM.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptBAM.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptBAM.SetParameterValue("paramBillMonth", param[0]);
                    rptBAM.SetParameterValue("paramStartDate", param[1]);
                    rptBAM.SetParameterValue("paramEndDate", param[2]);
                    crystalReportViewer1.ReportSource = rptBAM;
                    crystalReportViewer1.Refresh();
                    break;

                case 18:
                    rptPaymentRecap rptPayRecap = new rptPaymentRecap();
                    rptPayRecap.DataSourceConnections.Clear();
                    rptPayRecap.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptPayRecap.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptPayRecap.SetParameterValue("paramMonth", param[0]);
                    rptPayRecap.SetParameterValue("paramDateStart", param[1]);
                    rptPayRecap.SetParameterValue("paramDateEnd", param[2]);
                    crystalReportViewer1.ReportSource = rptPayRecap;
                    crystalReportViewer1.Refresh();
                    break;

                case 19:
                    rptDailyBillingCollection rptDailyBill = new rptDailyBillingCollection();
                    rptDailyBill.DataSourceConnections.Clear();
                    rptDailyBill.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptDailyBill.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptDailyBill.SetParameterValue("paramPrepared", param[0]);
                    rptDailyBill.SetParameterValue("paramJobDesc", param[1]);
                    rptDailyBill.SetParameterValue("paramDivMngr", param[2]);
                    rptDailyBill.SetParameterValue("paramDeptMngr", param[3]);
                    rptDailyBill.SetParameterValue("paramDate", param[4]);
                    crystalReportViewer1.ReportSource = rptDailyBill;
                    crystalReportViewer1.Refresh();
                    break;

                case 20:
                    rptReconPayments rptPay = new rptReconPayments();
                    rptPay.DataSourceConnections.Clear();
                    rptPay.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptPay.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptPay.SetParameterValue("paramTransdate", param[0]);
                    crystalReportViewer1.ReportSource = rptPay;
                    crystalReportViewer1.Refresh();
                    break;

                case 21:
                    rptDisconnectedAccts rptDiscAcct = new rptDisconnectedAccts();
                    rptDiscAcct.DataSourceConnections.Clear();
                    rptDiscAcct.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptDiscAcct.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptDiscAcct.SetParameterValue("paramDate", param[0]);
                    rptDiscAcct.SetParameterValue("paramCategory", param[1]);
                    rptDiscAcct.SetParameterValue("paramCategoryType", param[2]);
                    rptDiscAcct.SetParameterValue("paramPrepared", param[3]);
                    rptDiscAcct.SetParameterValue("paramUserDesc", param[4]);
                    rptDiscAcct.SetParameterValue("paramApproved", param[5]);
                    rptDiscAcct.SetParameterValue("paramHeadDesc", param[6]);
                    crystalReportViewer1.ReportSource = rptDiscAcct;
                    crystalReportViewer1.Refresh();
                    break;

                case 22:
                    rptDiscoAcctsSummary rptDiscSumm = new rptDiscoAcctsSummary();
                    rptDiscSumm.DataSourceConnections.Clear();
                    rptDiscSumm.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptDiscSumm.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptDiscSumm.SetParameterValue("paramDate", param[0]);
                    rptDiscSumm.SetParameterValue("paramUser", param[1]);
                    rptDiscSumm.SetParameterValue("paramUserDesc", param[2]);
                    rptDiscSumm.SetParameterValue("paramChecked", param[3]);
                    rptDiscSumm.SetParameterValue("paramNoted", param[4]);
                    crystalReportViewer1.ReportSource = rptDiscSumm;
                    crystalReportViewer1.Refresh();
                    break;

                case 23:
                    rptDMAConsumption rptDMA = new rptDMAConsumption();     
                    
                   // rptDMA.DataSourceConnections.Clear();
                   // rptDMA.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                   // rptDMA.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    //rptDiscSumm.SetParameterValue("paramDate", param[0]);
                    //rptDiscSumm.SetParameterValue("paramUser", param[1]);
                    //rptDiscSumm.SetParameterValue("paramUserDesc", param[2]);
                    //rptDiscSumm.SetParameterValue("paramChecked", param[3]);
                    rptDMA.SetDataSource(dsDMAData);
                    rptDMA.SetParameterValue("paramBilling", param[0]);
                    rptDMA.SetParameterValue("paramExtract", param[1]);
                    rptDMA.SetParameterValue("paramDesig", param[2]);
                    crystalReportViewer1.ReportSource = rptDMA;
                    crystalReportViewer1.Refresh();
                    break;

                case 24:
                    rptBAM rptbam = new rptBAM();
                    rptbam.DataSourceConnections.Clear();
                    rptbam.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptbam.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptbam.SetParameterValue("paramApproved", param[0]);
                    rptbam.SetParameterValue("paramDesignation", param[1]);
                    rptbam.SetParameterValue("paramBamid", param[2]);
                    crystalReportViewer1.ReportSource = rptbam;
                    crystalReportViewer1.Refresh();
                    break;

                case 25:
                    rptConsumptionPattern rptPattern = new rptConsumptionPattern();
                    rptPattern.DataSourceConnections.Clear();
                    rptPattern.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptPattern.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptPattern.SetParameterValue("paramBillingID", param[0]);
                    rptPattern.SetParameterValue("paramCum", param[1]);
                    rptPattern.SetParameterValue("paramBillmonth", param[2]);
                    rptPattern.SetParameterValue("paramZoneID", param[3]);
                    rptPattern.SetParameterValue("paramPreparedby", param[4]);
                    crystalReportViewer1.ReportSource = rptPattern;
                    crystalReportViewer1.Refresh();
                    break;

                case 26:
                    rptDMAPattern rptDMAPattern = new rptDMAPattern();
                    rptDMAPattern.SetDataSource(dsDMAPattern);
                    rptDMAPattern.SetParameterValue("paramBillMonth", param[0]);
                    rptDMAPattern.SetParameterValue("paramPreparedby", param[1]);
                    crystalReportViewer1.ReportSource = rptDMAPattern;
                    crystalReportViewer1.Refresh();
                    break;

                case 27:
                    /**
                     rptDiscoAcctsSummary rptDiscSumm = new rptDiscoAcctsSummary();
                    rptDiscSumm.DataSourceConnections.Clear();
                    rptDiscSumm.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptDiscSumm.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptDiscSumm.SetParameterValue("paramDate", param[0]);
                    rptDiscSumm.SetParameterValue("paramUser", param[1]);
                    rptDiscSumm.SetParameterValue("paramUserDesc", param[2]);
                    rptDiscSumm.SetParameterValue("paramChecked", param[3]);
                    rptDiscSumm.SetParameterValue("paramNoted", param[4]);
                    crystalReportViewer1.ReportSource = rptDiscSumm;
                    crystalReportViewer1.Refresh();
                    break;
                    */
                    rptRaffleEntries rptREntries = new rptRaffleEntries();
                    rptREntries.DataSourceConnections.Clear();
                    rptREntries.DataSourceConnections[0].SetConnection(SERVER, DBRAFFLE, false);
                    rptREntries.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptREntries.SetParameterValue("raffleID", param[0]);
                    rptREntries.SetParameterValue("raffleperiod", param[1]);
                    crystalReportViewer1.ReportSource = rptREntries;
                    crystalReportViewer1.Refresh();
                    

                    break;
                case 28:
                    rptManualBillFile rptManual = new rptManualBillFile();
                    rptManual.DataSourceConnections.Clear();
                    rptManual.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptManual.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptManual.SetParameterValue("preparedby", param[0]);
                    rptManual.SetParameterValue("zone", param[1]);
                    rptManual.SetParameterValue("billmonth", param[2]);
                    crystalReportViewer1.ReportSource = rptManual;
                    crystalReportViewer1.Refresh();
                    break;

                case 29:
                    rptBAMBatchDetails rptBatch = new rptBAMBatchDetails();
                    rptBatch.DataSourceConnections.Clear();
                    rptBatch.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptBatch.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    rptBatch.SetParameterValue("paramPreparedBy", param[0]);
                    rptBatch.SetParameterValue("paramBAMID", param[1]);                    
                    crystalReportViewer1.ReportSource = rptBatch;
                    crystalReportViewer1.Refresh();
                    break;

                case 30:
                    ManualBillYellow rptManualBillYellow = new ManualBillYellow();
                    rptManualBillYellow.DataSourceConnections.Clear();
                    rptManualBillYellow.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                    rptManualBillYellow.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                    crystalReportViewer1.ReportSource = rptManualBillYellow;
                    crystalReportViewer1.Refresh();
                    break;
            }
        }
    }
}
