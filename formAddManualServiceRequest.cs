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
    public partial class formAddManualServiceRequest : Form
    {
        public int userID;
        GlobalFunctions gfunc = new GlobalFunctions();
        List<ServiceRequest> srList = new List<ServiceRequest>();
        ServiceRequest srequest ;

        public formAddManualServiceRequest()
        {            
            InitializeComponent();
        }

        private void txtAcctNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            srequest = null;
            if (e.KeyChar == 13)
            {
                using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                {
                    string acctno = txtAcctNo.Text.Trim();
                    tbMaster master = dbcontext.tbMasters.FirstOrDefault(x => x.acctno.Equals(acctno));
                    if (master != null)
                    {
                        srequest = new ServiceRequest();
                        srequest.master_id = master.master_id;
                        srequest.acctno = master.acctno;
                        txtName.Text = master.name.Trim();
                        srequest.name = txtName.Text;
                        comboBox1.Focus();
                      
                    }
                    else
                    {
                        txtName.Clear();
                        MessageBox.Show("Account not found");
                    }
                }
     
            }
        }

        private void formAddManualServiceRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsServiceRequestCodes.tbServiceRequestCodes' table. You can move, or remove it, as needed.
            this.tbServiceRequestCodesTableAdapter.Fill(this.dsServiceRequestCodes.tbServiceRequestCodes);
            LoadServiceRequestCodes();
        }

        private void LoadServiceRequestCodes()
        {
            List<string> srList = new List<string>();
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                var query = dbcontext.tbServiceRequestCodes;
                foreach (tbServiceRequestCode sr in query)
                {
                    srList.Add(string.Format("{0}-{1}", sr.sr_code, sr.code_desc));
                }
            }
            comboBox1.Items.AddRange(srList.ToArray());
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (comboBox1.Text.Length == 0)
                {
                    MessageBox.Show("Please specify complain.");
                    return;
                }
                btnAddToList.Focus();
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (txtAcctNo.TextLength == 6)
            {
                string[] strCode = comboBox1.Text.Split('-');
                srequest.complain_id = gfunc.getServiceRequestCodeID(strCode[0]);
                srequest.desc = strCode[1];
                srList.Add(srequest);
                PopulateColumns();
                button2.Enabled = true;
                txtName.Clear();
                txtAcctNo.Focus();
            }

        }

        private void PopulateColumns()
        {
            gridControl1.DataSource = srList;
            gridView1.PopulateColumns();
            gridView1.Columns[0].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[0].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[0].Caption = "AcctNo";
            gridView1.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Columns[1].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[1].Caption = "Name";
            gridView1.Columns[2].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[2].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[2].Caption = "Complain";
            gridView1.Columns[3].Visible = false;
            gridView1.Columns[4].Visible = false;
            gridControl1.Refresh();
        }

        private void btnAddToList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnAddToList_Click(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            gridView1.DeleteSelectedRows();            
            PopulateColumns();
            if (gridView1.DataRowCount <= 0)
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Save"))
            {
                DialogResult dlg = MessageBox.Show("Do you want to save this list?", "Saved List", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    foreach (ServiceRequest sr in srList)
                    {
                        saveServiceRequest(sr);
                    }
                    MessageBox.Show("List is saved successfully.");
                    button2.Text = "Print";
                }
            }
            else if (button2.Text.Equals("Print"))
            {
                DialogResult dlgPrint = MessageBox.Show("Do you want to print the records in the list? Please check your printer first.", "Print List", MessageBoxButtons.YesNo);
                if (dlgPrint == DialogResult.Yes)
                {
                    using (dbCommercialEntities dbcontext = new dbCommercialEntities())
                    {
                    
                        for (int i = 0;i<gridView1.DataRowCount;i++)
                        {
                                DevExpress.XtraGrid.Columns.GridColumn col = gridView1.Columns.ColumnByFieldName("acctno");
                                string acctno = gridView1.GetRowCellValue(i, col).ToString();
                                int masterID = Convert.ToInt32(gridView1.GetRowCellValue(i,gridView1.Columns.ColumnByFieldName("master_id").ToString()));
                                string mtrNo = gfunc.getMeterNumber(acctno);

                                tbServiceRequest SRtoPrint = dbcontext.tbServiceRequests.FirstOrDefault(x => x.request_recd_date == DateTime.Today && x.encoder_id == userID && x.master_id==masterID);
                                if (SRtoPrint != null)
                                {
                                    ArrayList paramArr = new ArrayList();
                                    paramArr.Add(mtrNo);
                                    paramArr.Add(Convert.ToInt32(SRtoPrint.sr_id));


                                    const string DATAUSER = "commsys";
                                    const string DATAPASS = "comm123";
                                    const string DATABASE = "dbCommercial";
                                    const string SERVER = @"BILLSERVER\SQLEXPRESS";

                                    rptServiceRequest rptServ = new rptServiceRequest();
                                    rptServ.DataSourceConnections.Clear();
                                    rptServ.DataSourceConnections[0].SetConnection(SERVER, DATABASE, false);
                                    rptServ.DataSourceConnections[0].SetLogon(DATAUSER, DATAPASS);
                                    rptServ.SetParameterValue("paramMeter", paramArr[0]);
                                    rptServ.SetParameterValue("paramSRID", paramArr[1]);
                                    rptServ.PrintToPrinter(1, false, 1, 1);
                                }
                        }
                        MessageBox.Show("Printing is finished.");
                       
                    }
                }
            }
            
        }

        private void saveServiceRequest(ServiceRequest serv)
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbServiceRequest new_service = new tbServiceRequest();
                new_service.complain_desc = serv.desc;
                new_service.master_id = serv.master_id;
                new_service.complain_id = serv.complain_id;
                new_service.requested_by = gfunc.getUserInitials(userID);
                new_service.encoder_id = userID;
                new_service.request_recd_date = DateTime.Today;
                int newsrno = gfunc.getLastServiceRequestNo() + 1;
                new_service.sr_no = newsrno.ToString();

                dbcontext.AddTotbServiceRequests(new_service);
                dbcontext.SaveChanges();
               
            }
        }
        
 
    }
}
