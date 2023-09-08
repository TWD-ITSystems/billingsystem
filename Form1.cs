using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.IO;
using BillingSystem.models;
using System.Threading.Tasks;

namespace BillingSystem
{
    public partial class MainForm : Form
    {
        public string username = "";
        public int userID = 0;
        public int access_code = 0;
        

        public MainForm()
        {
            InitializeComponent();
        }

        // -------------------- User Defined Functions -------------------
        private Boolean Single_Instance_Child(string form_name)
        {
            Form[] childforms = this.MdiChildren;
            Boolean return_value = false;

            if (childforms.Length == 0)
            {
                return_value = false;
            }
            else
            {
                foreach (Form chform in childforms)
                {
                    if (chform.Name == form_name)
                    {
                        chform.Activate();
                        chform.StartPosition = FormStartPosition.Manual;
                        chform.Location = new Point(0, 0);
                        chform.WindowState = FormWindowState.Normal;
                        return_value = true;
                        break;
                    }
                    else
                    {
                        return_value = false;
                    }
                }

            }

            return return_value;
        }

        //---------------- end user defined functions



        private void billingHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Single_Instance_Child("formBillingSchedule"))
            {
                formBillingSchedule frmBillingSchedule = new formBillingSchedule();
                frmBillingSchedule.MdiParent = this;
                frmBillingSchedule.StartPosition = FormStartPosition.Manual;
                frmBillingSchedule.Location = new Point(0, 0);
                frmBillingSchedule.Show();                
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Billing System ?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void ManualEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formManualEntry"))
            {
                formManualEntry frmManualEntry = new formManualEntry();
                frmManualEntry.MdiParent = this;
                frmManualEntry.StartPosition = FormStartPosition.Manual;
                frmManualEntry.Location = new Point(0, 0);
                frmManualEntry.Show();
            }    
        }

        private void printBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("frmPrintBills"))
            {
                frmPrintBills fPrintBills = new frmPrintBills();
                fPrintBills.MdiParent = this;
                fPrintBills.StartPosition = FormStartPosition.Manual;
                fPrintBills.Location = new Point(0, 0);
                fPrintBills.Show();

                //formViewBillYellow fPrintBills = new formViewBillYellow();
                //fPrintBills.MdiParent = this;
                //fPrintBills.StartPosition = FormStartPosition.Manual;
                //fPrintBills.Location = new Point(0, 0);                
                //fPrintBills.Show();               
               
            }    
        }

        private void manualEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formBillManual"))
            {
                formBillManual fBillManual = new formBillManual();
                fBillManual.MdiParent = this;
                fBillManual.StartPosition = FormStartPosition.Manual;
                fBillManual.Location = new Point(0, 0);
                fBillManual.userID = userID;
                fBillManual.userName = username;
                fBillManual.Show();
            }
        }

        private void generateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formGenerateWizard"))
            {
                formGenerateWizard frmBillingGenerate = new formGenerateWizard();
                frmBillingGenerate.MdiParent = this;
                frmBillingGenerate.StartPosition = FormStartPosition.Manual;
                frmBillingGenerate.Location = new Point(0, 0);
                frmBillingGenerate.Show();
            }
        }

        private void masterAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formMasterAcctsRpt"))
            {
                formMasterAcctsRpt frmMasterAcct = new formMasterAcctsRpt();
                frmMasterAcct.MdiParent = this;
                frmMasterAcct.StartPosition = FormStartPosition.CenterScreen;
                frmMasterAcct.Show();
            }
        }

        private void uploadDataToMRSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void downloadDataFromMRSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formMRSDownload"))
            {
                formMRSDownload frmMrsDownload = new formMRSDownload();
                frmMrsDownload.MdiParent = this;
                frmMrsDownload.StartPosition = FormStartPosition.CenterScreen;
                frmMrsDownload.username = this.username;
                frmMrsDownload.Show();
            }
        }

        private void newDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formMRSUpload"))
            {
                formMRSUpload frmMrsUpload = new formMRSUpload();
                frmMrsUpload.MdiParent = this;
                frmMrsUpload.StartPosition = FormStartPosition.CenterScreen;
                frmMrsUpload.username = this.username;
                frmMrsUpload.userID = this.userID;
                frmMrsUpload.access_code = this.access_code;
                frmMrsUpload.Show();
            }
        }

        private void billFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formBillFileRpt"))
            {
                formBillFileRpt frmBillFileRpt = new formBillFileRpt();
                frmBillFileRpt.MdiParent = this;
                frmBillFileRpt.StartPosition = FormStartPosition.CenterScreen;
                frmBillFileRpt.username = this.username;
                frmBillFileRpt.Show();
            }
        }

        private void downloadToAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("frmDownloadAgents"))
            {
                frmDownloadAgents frmToAgents = new frmDownloadAgents();
                frmToAgents.MdiParent = this;
                frmToAgents.StartPosition = FormStartPosition.CenterScreen;
                frmToAgents.username = this.username;
                frmToAgents.Show();
            }
        }

        private void dataRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                if (!Single_Instance_Child("formDataRepair"))
                {
                    formDataRepair frmRepair = new formDataRepair();
                    frmRepair.MdiParent = this;
                    frmRepair.StartPosition = FormStartPosition.CenterScreen;
                    frmRepair.userID = this.userID;
                    frmRepair.username = this.username;
                    frmRepair.Show();
                }
            
        }

        private void viewUpdateMasterHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formViewUploadHistory"))
            {
                formViewUploadHistory frmUpload = new formViewUploadHistory();
                frmUpload.MdiParent = this;
                frmUpload.StartPosition = FormStartPosition.CenterScreen;
                frmUpload.Show();
            }
        }

        private void masterViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formMasterViewer"))
            {
                formMasterViewer frmMaster = new formMasterViewer();
                frmMaster.MdiParent = this;
                frmMaster.StartPosition = FormStartPosition.CenterScreen;
                frmMaster.Show();
            }
        }

        private void meterReaderFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formMeterReaderFile"))
            {
                formMeterReaderFile frmMtrRdr = new formMeterReaderFile();
                frmMtrRdr.MdiParent = this;
                frmMtrRdr.StartPosition = FormStartPosition.CenterScreen;
                frmMtrRdr.Show();
            }
        }

        private void generatePenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formGeneratePenalty"))
            {
                formGeneratePenalty frmPenalty = new formGeneratePenalty();
                frmPenalty.MdiParent = this;
                frmPenalty.StartPosition = FormStartPosition.CenterScreen;
                frmPenalty.userID = userID;
                frmPenalty.Show();
            }
        }

        private void exportToBillfiledbfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formExportBillfile"))
            {
                formExportBillfile frmExport = new formExportBillfile();
                frmExport.MdiParent = this;
                frmExport.StartPosition = FormStartPosition.CenterScreen;
                frmExport.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            dataRepairToolStripMenuItem.Visible = (access_code==101)?true:false;
            masterAcctEditorToolStripMenuItem.Visible = (access_code >= 101) ? true : false;
            billingToolStripMenuItem.Enabled = (access_code >= 101) ? true : false;
            collectionsToolStripMenuItem.Enabled = (access_code >= 101) ? true : false;
            mRSToolStripMenuItem.Enabled = (access_code >= 101) ? true : false;
#if !DEBUG
            outstandingBAMToolStripMenuItem.Enabled = (access_code == 103) ? true : false;
#endif 


            //string conStr = ConfigurationManager.ConnectionStrings["dbCommercialEntities"].ConnectionString;
            string conStr = ConfigurationManager.ConnectionStrings["dbCommercialEntities"].ConnectionString;
            string oldtext = this.Text;

            EntityConnectionStringBuilder entityConnectionStringBuilder = new EntityConnectionStringBuilder(conStr);
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(entityConnectionStringBuilder.ProviderConnectionString);
            string server = sqlConnectionStringBuilder.DataSource;

            this.Text = oldtext + " [ SERVER: " + server + " ]";

            switch (access_code)
            {
                case 101:
                case 103:
                case 104:
                case 105:
                    blacklistToolStripMenuItem.Enabled = true;
                    toolStripButton2.Visible = true;
                    break;
                default:
                     blacklistToolStripMenuItem.Enabled = false;
                    toolStripButton2.Visible = false;
                    break;
            }

            processExternalTools();

            Task.Factory.StartNew(() => LoadNotify());
            
    
        }


        private Task LoadNotify()
        {
            return Task.Factory.StartNew(() =>
             {
                 var notify = new NotifyRepository();
                // int totalRec = notify.getAccountsForWelcome().Count();
                 int totalRec = 0;
                 labelNotifyCount.Invoke(new Action<int>((x) => labelNotifyCount.Text = x.ToString()), totalRec);
             }
            );
        }

        private void processExternalTools()
        {           
            listDirectories();
        }

        private void listDirectories()
        {

            List<string> dNames = Directory.GetDirectories(Application.StartupPath+"\\External").ToList();                   
            foreach (string en in dNames)
            {
                string appName = Path.GetFileName(en);                   
                ToolStripMenuItem newItem = new ToolStripMenuItem(appName);                
                newItem.Click += toolStripMenuItem_Click;
                externalToolsToolStripMenuItem.DropDownItems.Add(newItem);
            }
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            string appPath = string.Format(@"{0}\External\{1}\{2}.exe", Application.StartupPath, ((ToolStripMenuItem)sender).Text,((ToolStripMenuItem)sender).Text);
            try
            {
                System.Diagnostics.Process.Start(appPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}.exe not found.", ((ToolStripMenuItem)sender).Text));
            }          
        }


        private void masterEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formMasterEditor"))
            {
                formMasterEditor frmMast = new formMasterEditor();
                frmMast.MdiParent = this;
                frmMast.StartPosition = FormStartPosition.CenterScreen;
                frmMast.userID = userID;
                frmMast.Show();
            }
        }

        private void postPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formBankCollect"))
            {
                formBankCollect frmBank = new formBankCollect();
                frmBank.MdiParent = this;
                frmBank.StartPosition = FormStartPosition.CenterScreen;
                frmBank.userID = userID;
                frmBank.Show();
            }
        }

        private void printPostedPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formPrintPosted"))
            {
                formPrintPosted frmPosted = new formPrintPosted();
                frmPosted.MdiParent = this;
                frmPosted.StartPosition = FormStartPosition.CenterScreen;
               //frmPosted.userID = userID;
                frmPosted.Show();
            }
        }

        private void masterAcctEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            formMasterAcctEdit frmMastAcct = new formMasterAcctEdit();
            frmMastAcct.userID = userID;
            frmMastAcct.Show();
        }

        private void iF2BalanceAsOfTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 8;
            frmRpt.Show();
        }

        private void recapOfSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generateRecapOfSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRecapSales frmRecap = new formRecapSales();
            frmRecap.Show();
        }

        private void printRecapOfSalesAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRecapAttachment frmRecapAttach = new formRecapAttachment();
            frmRecapAttach.Show();
        }

        private void generateAgingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGenerateAging frmAge = new formGenerateAging();
            frmAge.Show();
        }

        private void printAgingReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPrintAging print = new formPrintAging();
            print.Show();
        }

        private void penaltiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPenaltyDetailed frmPnlt = new formPenaltyDetailed();
            frmPnlt.Show();
        }

        private void bAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBAMDetailed frmBAM = new formBAMDetailed();
            frmBAM.Show();
        }

        private void prepareAccountsForNextBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProcessAccounts frmProcess = new formProcessAccounts();
            frmProcess.userID = userID;
            frmProcess.Show();
        }

        private void dailySummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDailySummary frmDaily = new formDailySummary();
            frmDaily.userID = userID;
            frmDaily.Show();
        }

        private void updatePostedPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUpdateBankCollection frmUpdateBank = new formUpdateBankCollection();
            frmUpdateBank.userID = userID;
            frmUpdateBank.Show();
        }

        private void paymentRecapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPaymentRecap frmPayRecap = new formPaymentRecap();
            frmPayRecap.Show();
        }

        private void updateDiscoAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDiscoUpdate frmDisco = new formDiscoUpdate();
            frmDisco.userID = userID;
            frmDisco.Show();
        }

        private void updateReconnectedAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReconUpdate frmRecon = new formReconUpdate();
            frmRecon.userID = userID;
            frmRecon.Show();
        }

        private void serviceRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServiceRequestMenu formService = new frmServiceRequestMenu();
            formService.userID = userID;
            formService.Show();
        }

        private void changeMeterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChangeMeter frmChangeMeter = new formChangeMeter();
            frmChangeMeter.userID = userID;
            frmChangeMeter.Show();
        }

        private void dailyReportOnBillingAndCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBillingCollection frmBillColl = new formBillingCollection();
            frmBillColl.userID = userID;
            frmBillColl.Show();
        }

        private void reconPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReconPayments frmReconPay = new formReconPayments();
            frmReconPay.Show();
        }

        private void checkUnbilledAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCheckBilling frmCheck = new formCheckBilling();
            frmCheck.Show();
        }

        private void cardNoBatchEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChangeCardNo frmChange = new formChangeCardNo();
            frmChange.Show();
        }

        private void disconnectedAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDisconnectedAccounts frmDiscoAcct = new formDisconnectedAccounts();
            frmDiscoAcct.userID = userID;
            frmDiscoAcct.Show();
        }

        private void bAMMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBAMEntry frmBam = new formBAMEntry();
            frmBam.userID = userID;
            frmBam.Show();
        }

        private void dMAMonthlyConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDMAConsumption frmDMA = new formDMAConsumption();
            frmDMA.userID = userID;
            frmDMA.Show();
        }

        private void outstandingBAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBAMApprove frmBAM = new formBAMApprove();
            frmBAM.userID = userID;
            frmBAM.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formMasterViewer"))
            {
                formMasterViewer frmMaster = new formMasterViewer();
                frmMaster.MdiParent = this;
                frmMaster.StartPosition = FormStartPosition.CenterScreen;
                frmMaster.Show();
            }
        }

        private void governmentPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGovPenalty frmGovPenalty = new formGovPenalty();
            frmGovPenalty.userID = userID;
            frmGovPenalty.Show();
        }

        private void zoneLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formZoneLookup frmZone = new formZoneLookup();
            frmZone.Show();
        }

        private void manageMetersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMeterMenu frmMeterMenu = new formMeterMenu();
            frmMeterMenu.Show();
        }

        private void consumptionPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsumptionPatternChecker frmConsumption = new formConsumptionPatternChecker();
            frmConsumption.userID = userID;
            frmConsumption.Show();
        }

        private void dailyConsumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDMAConsumption frmDMA = new formDMAConsumption();
            frmDMA.userID = userID;
            frmDMA.Show();
        }

        private void consumptionPatternToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formDMAConsumptionPattern frmDMAPattern = new formDMAConsumptionPattern();
            frmDMAPattern.userID = userID;
            frmDMAPattern.Show();
        }

        private void accountInfoLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAccountInfoFill frmAcctFill = new formAccountInfoFill();
            frmAcctFill.userID = userID;
            frmAcctFill.Show();
        }

        private void importECPAYPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formECPAYImport frmECPay = new formECPAYImport();
            frmECPay.userID = userID;
            frmECPay.Show();
        }

        private void blacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBlacklistMenu frmBlack = new formBlacklistMenu();
            frmBlack.userID = this.userID;
            frmBlack.Show();
        }

        private void dMAAccountsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDMAMenu frmDMA = new formDMAMenu();
            frmDMA.userID = this.userID;
            frmDMA.Show();
        }

        private void damageMetersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDamageMeters frmDMTR = new formDamageMeters();
            frmDMTR.userID = this.userID;
            frmDMTR.Show();
        }

        private void serviceRequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmServiceRequestMenu formService = new frmServiceRequestMenu();
            formService.userID = userID;
            formService.Show();
        }

        private void addManualRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAddManualServiceRequest frmManual = new formAddManualServiceRequest();
            frmManual.userID = userID;
            frmManual.Show();
        }

        private void serviceRequestMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServiceRequestMenu formService = new frmServiceRequestMenu();
            formService.userID = userID;
            formService.Show();
        }

        private void importBayadCenterPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBayadCenterImport frmBYD = new formBayadCenterImport();
            frmBYD.userID = userID;
            frmBYD.Show();
        }

        private void oRSeriesRepairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formORSeriesRepair frmORRepair = new formORSeriesRepair();
            frmORRepair.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formBlacklistMenu frmBlack = new formBlacklistMenu();
            frmBlack.userID = this.userID;
            frmBlack.Show();
        }

        private void rezoningBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadRezoningFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Single_Instance_Child("formRezoning"))
            {
                formRezoning frmRezone = new formRezoning();
                frmRezone.MdiParent = this;
                frmRezone.StartPosition = FormStartPosition.CenterScreen;
                frmRezone.Show();
            }
        }

        private void addRezonedAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Single_Instance_Child("formAddRezoneAccount"))
            {
                formAddRezoneAccount frmAddRezone = new formAddRezoneAccount();
                frmAddRezone.MdiParent = this;
                frmAddRezone.StartPosition = FormStartPosition.CenterScreen;
                frmAddRezone.Show();
            }
        }

        private void checkDigitTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formCheckDigitTester"))
            {
                formCheckDigitTester frmCheckDigit = new formCheckDigitTester();
                frmCheckDigit.MdiParent = this;
                frmCheckDigit.StartPosition = FormStartPosition.CenterScreen;
                frmCheckDigit.Show();
            }
        }

        private void updateToRezoneServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("formUpdateRezoning"))
            {
                formUpdateRezoning frmUpdateRezone = new formUpdateRezoning();
                frmUpdateRezone.MdiParent = this;
                frmUpdateRezone.StartPosition = FormStartPosition.CenterScreen;
                frmUpdateRezone.Show();
            }

        }

        private void tWDCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rafflePeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRafflePeriod frmRafflePeriod = new formRafflePeriod();
            frmRafflePeriod.username = username;
            frmRafflePeriod.Show();
        }

        private void generateEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRaffleGenerateEntries frmRaffleGenerate = new formRaffleGenerateEntries();
            frmRaffleGenerate.username = username;
            frmRaffleGenerate.Show();
        }

        private void printEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRafflePrint frmRPrint = new formRafflePrint();
            frmRPrint.username = username;
            frmRPrint.Show();
        }

        private void dormantMonitoringToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDormantMonitor frmDormant = new formDormantMonitor();
            frmDormant.Show();
        }

        private void encodeReadingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formManualBillEncode frmManual = new formManualBillEncode();
            frmManual.userID = userID;
            frmManual.username = username;
            frmManual.Show();
        }

        private void batchBAMEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBAMBatchEntry fBAMbatch = new frmBAMBatchEntry();
            fBAMbatch.userID = userID;
            fBAMbatch.userInitials = username;
            fBAMbatch.Show();
        }

        private void updateManualBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printBillsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            formManualBillPrint frmManualPrint = new formManualBillPrint();
            frmManualPrint.Show();
        }

        private void performBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBackupDatabase frmBackup = new formBackupDatabase();
            frmBackup.userID = userID;
            frmBackup.userInitials = username;
            frmBackup.Show();
        }

        private void backupLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBackupLog frmLog = new formBackupLog();
            frmLog.Show();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            //NotifyRepository notify = new NotifyRepository();
            //List<int> result = notify.getAccountsForWelcome();
           // MessageBox.Show(notify.processEnrollWelcome(2));
        }

        private void printManualBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (formManualBillPrint frmBillPrint = new formManualBillPrint())
            {
                frmBillPrint.username = new GlobalFunctions().getUserInitials(userID);
                frmBillPrint.ShowDialog();
            }
        }

        private void updateManualBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void importGcashPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (formImportGcash frmGcash = new formImportGcash())
            {

                frmGcash.userID = userID;
                frmGcash.ShowDialog();

            }
        }





    }
}
