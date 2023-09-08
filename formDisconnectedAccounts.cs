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
    public partial class formDisconnectedAccounts : Form
    {
        public int userID = 0;
        GlobalFunctions gfunc = new GlobalFunctions();

        public formDisconnectedAccounts()
        {
            InitializeComponent();
        }

        private void formDisconnectedAccounts_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            const int COMMERCIAL_DEPT = 3;

            string fullname = gfunc.getUserFullName(userID).ToUpper();
            string jobdesc = gfunc.getUserJobDesc(userID);
            string deptHead = gfunc.getDeptDivHead(COMMERCIAL_DEPT);
            string deptHeadDesc = gfunc.getDeptDivHeadDescription(COMMERCIAL_DEPT);
            int ctgy = Int32.TryParse(comboBox1.Text.Substring(0, 2),out ctgy)?ctgy:0;

            ArrayList paramList = new ArrayList();
            paramList.Add(dateTimePicker1.Value);
            paramList.Add(ctgy);
            paramList.Add(comboBox1.Text.Substring(4));
            paramList.Add(fullname);
            paramList.Add(jobdesc);
            paramList.Add(deptHead);
            paramList.Add(deptHeadDesc);

            frmReport rpt = new frmReport();
            rpt.rptMode = 21;
            rpt.param = paramList;
            rpt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int COMMERCIAL_DEPT = 3;
            const int OGM = 1;

            string fullname = gfunc.getUserFullName(userID).ToUpper();
            string jobdesc = gfunc.getUserJobDesc(userID);
            string deptHead = gfunc.getDeptDivHead(COMMERCIAL_DEPT);
            string gm = gfunc.getDeptDivHead(OGM);

            ArrayList paramList = new ArrayList();
            paramList.Add(dateTimePicker1.Value);
            paramList.Add(fullname);
            paramList.Add(jobdesc);
            paramList.Add(deptHead);
            paramList.Add(gm);


            frmReport rpt = new frmReport();
            rpt.rptMode = 22;
            rpt.param = paramList;
            rpt.Show();
        }
    }
}
