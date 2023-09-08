using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace BillingSystem
{
    public partial class formViewBillYellow : Form
    {
        public string paramFilterStr = "";
        public string paramPaycenters = "";
        

        rptBillPrint report = new rptBillPrint();

        public formViewBillYellow()
        {
            InitializeComponent();
        }


        private void formViewBillYellow_Load(object sender, EventArgs e)
        {
            
            printControl1.PrintingSystem = report.PrintingSystem;
            report.FindControl("xrPictureBox1", true).Visible = false;
            if (paramFilterStr.Length > 0)
            {
                report.FilterString = paramFilterStr;
            }
           // report.FilterString = "[uid] = 2013719406";
            report.RequestParameters = false;
            report.Parameters["paycenters"].Value = paramPaycenters;                     
            report.CreateDocument();          
            report.RequestParameters = false;


        }

     
    }
}
