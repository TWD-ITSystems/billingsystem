using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BillingSystem
{
    public partial class formMasterViewer : Form
    {
       // int totalAcct = 0;
        public formMasterViewer()
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

        private void formMasterViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMaster.tbMaster' table. You can move, or remove it, as needed.
            
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            // TODO: This line of code loads data into the 'dsMasterDetails.vwMasterDetails' table. You can move, or remove it, as needed.
            //this.vwMasterDetailsTableAdapter.Fill(this.dsMasterDetails.vwMasterDetails);

            //this.tbMasterTableAdapter.Fill(this.dsMaster.tbMaster);
            groupBox1.Show();
            //var taskm = Task.Factory.StartNew(() => { this.tbMasterTableAdapter.Fill(this.dsMaster.tbMaster); });
            //var task = Task.Factory.StartNew(() => { int totalAcct = this.vwMasterDetailsTableAdapter.Fill(this.dsMasterDetails.vwMasterDetails);});
            var taskm = Task.Factory.StartNew(() => { this.tbMasterTableAdapter.FillBySProc(this.dsMaster.tbMaster); });
            var task = Task.Factory.StartNew(() => { int totalAcct = this.vwMasterDetailsTableAdapter.FillBySProc(this.dsMasterDetails.vwMasterDetails); });
            task.ContinueWith((previousTask) => { if (task.IsCompleted) groupBox1.Hide();},TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btnLedger_Click(object sender, EventArgs e)
        {
            if (!Single_Instance_Child("frmShowLedger"))
            {
                frmShowLedger frmLedger = new frmShowLedger(Convert.ToInt32(this.master_idSpinEdit.Value));
                //frmShowLedger frmLedger = new frmShowLedger(masterID);
               // frmLedger.MdiParent = this;
                frmLedger.StartPosition = FormStartPosition.CenterScreen;
                frmLedger.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

    }
}
