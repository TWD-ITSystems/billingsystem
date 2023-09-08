using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace BillingSystem
{
    public partial class formMeterReaderFile : Form
    {
        dbCommercialEntities context = new dbCommercialEntities();
        GlobalFunctions globfunc = new GlobalFunctions();
        public formMeterReaderFile()
        {
            InitializeComponent();
        }

        private void formMeterReaderFile_Load(object sender, EventArgs e)
        {
            tbZoneBindingSource.DataSource = context.tbZones;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int fromCard = 0;
            int toCard = 0;

            if (!(int.TryParse(textBox1.Text, out fromCard)))
            {
                MessageBox.Show("Please input a valid cardno in From:");
                return;
            }

            if (!(int.TryParse(textBox2.Text, out toCard)))
            {
                MessageBox.Show("Please input a valid cardno in To:");
                return;
            }

            

            ArrayList param = new ArrayList();            
            string rs_str = "";
            string zonebook = globfunc.getZoneName((int)comboBox1.SelectedValue);
            string mtr_rdr = globfunc.getMtrReaderByZone(zonebook);
            rs_str = comboBox1.Text;
            param.Add(rs_str);
            param.Add(zonebook);
            param.Add(mtr_rdr);
            param.Add(fromCard);
            param.Add(toCard);
            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 5;
            frmRpt.param = param;
            frmRpt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList param = new ArrayList();
            string zonebook = globfunc.getZoneName((int)comboBox1.SelectedValue);
            int zoneid = (int)comboBox1.SelectedValue;
            param.Add(zoneid);
            param.Add(zonebook);
            frmReport frmRpt = new frmReport();
            frmRpt.rptMode = 7;
            frmRpt.param = param;
            frmRpt.Show();
        }
    }
}
