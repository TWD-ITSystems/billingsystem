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
    public partial class formMasterEditor : Form
    {
        public int userID;       

        GlobalFunctions global_func = new GlobalFunctions();
        int current_zone = 0;
        string current_meter = "";

        public formMasterEditor()
        {
            InitializeComponent();
        }

        private void txtAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.tbZoneTableAdapter.Fill(this.dsZone.tbZone);
                int cnt= this.tbMasterTableAdapter.FillByMasterAcctno(this.dsMaster.tbMaster, txtAcctNo.Text);
                if (cnt > 0)
                {

                    string test = zone_nameComboBox.SelectedValue.ToString();
                    current_zone = Convert.ToInt32(zone_nameComboBox.SelectedValue.ToString());
                    int meterid = Convert.ToInt32(meter_idSpinEdit.Value);
                    int x = this.tbMetersTableAdapter.FillByMeterID(this.dsMeters.tbMeters, meterid);
                    current_meter = meternoTextEdit.Text;
                    int masterid = Convert.ToInt32(master_idSpinEdit.Value);
                    this.tbMasterAcctsTableAdapter.FillByMasterID(this.dsMasterAccts.tbMasterAccts,masterid);
                }
                else
                {
                    current_meter = "";
                    current_zone = 0;
                    MessageBox.Show("Account No. not found.");
                    txtAcctNo.SelectAll();
                    txtAcctNo.Focus();
                }

            }
        }

        private void tbMasterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void formMasterEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMasterAccts.tbMasterAccts' table. You can move, or remove it, as needed.
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zoneID = Convert.ToInt32(zone_nameComboBox.SelectedValue.ToString());
            DataRowView currentMaster = (DataRowView)tbMasterBindingSource.Current;
            if (zoneID != current_zone)
            {
                currentMaster["zone_id"] = zoneID;
            }

            if (currentMaster["name"].ToString().Length == 0 || currentMaster["address"].ToString().Length == 0)
            {
                MessageBox.Show("Name or Address cannot be blank.Please check");
                return;
            }
            currentMaster["address"] = currentMaster["address"].ToString().Trim();
            currentMaster["last_edit_by"] = global_func.getUserInitials(userID);
            currentMaster["last_edit_date"] = DateTime.Now;

            this.Validate();
            this.tbMasterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsMaster);

            this.tbMetersBindingSource.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.dsMeters);

            this.tbMasterAcctsBindingSource.EndEdit();
            this.tableAdapterManager3.UpdateAll(this.dsMasterAccts);

         

            MessageBox.Show("Changes to Master Data has been posted.","Saving");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            statusTextEdit.Text = "X";
            last_disco_dateDateEdit.Focus();
            last_disco_dateDateEdit.ShowPopup();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statusTextEdit.Text = "";
            last_reco_dateDateEdit.Focus();
            last_reco_dateDateEdit.ShowPopup();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
