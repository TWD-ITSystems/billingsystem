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
    public partial class formMasterAcctEdit : Form
    {
        public int userID = 0;

        int masterID = 0;
        GlobalFunctions gFunc = new GlobalFunctions();
        int zoneuid = 0;

        public formMasterAcctEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterID = gFunc.getMasterID(textBox1.Text);
            if (masterID != 0)
            {
                label2.Text = string.Format("Master ID : {0}", masterID);
                
                labelName.Text = string.Format("Name : {0}", gFunc.getMasterName(masterID));
                zoneuid = gFunc.getZoneUIDbyMaster(masterID);
                label3.Text = string.Format("Zoneuid: {0}", zoneuid);
                this.tbLedgerTableAdapter.FillByMasterID(this.dsLedger.tbLedger, masterID);
                this.tbMasterAcctsTableAdapter.FillByMasterID(this.dsMasterAccts.tbMasterAccts, masterID);
                this.tbBillingDetailsTableAdapter.FillByMasterID(this.dsBillingDetails.tbBillingDetails, masterID);
            }
            else
            {
                labelName.Text = "Name :";
                MessageBox.Show("Account no. not found.");
            }
        }

        private void tbMasterAcctsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void formMasterAcctEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBillingDetails.tbBillingDetails' table. You can move, or remove it, as needed.
            //this.tbBillingDetailsTableAdapter.Fill(this.dsBillingDetails.tbBillingDetails);
            // TODO: This line of code loads data into the 'dsLedger.tbLedger' table. You can move, or remove it, as needed.
            //this.tbLedgerTableAdapter.Fill(this.dsLedger.tbLedger);
            // TODO: This line of code loads data into the 'dsMasterAccts.tbMasterAccts' table. You can move, or remove it, as needed.
            //this.tbMasterAcctsTableAdapter.Fill(this.dsMasterAccts.tbMasterAccts);
            if (userID!=2)
            {
                tbLedgerGridControl.EmbeddedNavigator.Buttons.Remove.Visible = false;
                tbLedgerGridControl.EmbeddedNavigator.Buttons.Edit.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbMasterAcctsBindingSource.EndEdit();
            this.tbLedgerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsMasterAccts);
            this.tableAdapterManager1.UpdateAll(this.dsLedger);
            MessageBox.Show("Master Accounts has been updated.");
            this.tbLedgerTableAdapter.FillByMasterID(this.dsLedger.tbLedger, 0);
            this.tbMasterAcctsTableAdapter.FillByMasterID(this.dsMasterAccts.tbMasterAccts, 0);
            this.tbBillingDetailsTableAdapter.FillByMasterID(this.dsBillingDetails.tbBillingDetails, 0);
            textBox1.Focus();
            textBox1.SelectAll();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.PerformClick();
            }
        }

        private void tbLedgerGridControl_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType.ToString().Equals("Append"))
            {
                MessageBox.Show(string.Format("Please set the Zoneuid to {0}.",zoneuid),"Append");
            }

        }

        private void tbLedgerBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
       
        }
    }
}
