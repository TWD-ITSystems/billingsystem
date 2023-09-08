using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.EntityClient;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace BillingSystem
{
    public partial class formBackupDatabase : Form
    {
        public int userID = 0;
        public string userInitials = "";
        GlobalFunctions gfunc = new GlobalFunctions();
        string filename = "";
        string sqlserver = "";
    

        public formBackupDatabase()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Close"))
            {
                Close();
                
            }
            else
            {
                

                    DialogResult dlgResult = MessageBox.Show("Do you really want to backup the Commercial Database ?", "Backup", MessageBoxButtons.YesNo);
                    if (dlgResult == DialogResult.Yes)
                    {
                        progressBar1.Value = 0;
                        try
                        {
                            //Server dbServer = new Server(new ServerConnection(@".\SQLSERVERDEV", "commsys", "comm123"));
                            Server dbServer = new Server(new ServerConnection(sqlserver, "commsys", "comm123"));
                            Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = "dbCommercial" };
                            //dbBackup.Devices.AddDevice(string.Format(@"C:\backup\forced\{0}.bak","forced"+DateTime.Now.ToShortDateString()),DeviceType.File);
                            string test = String.Format("forced-{0}.bak", DateTime.Now.ToShortDateString());
                            test = test.Replace("/", "-");
                            filename = test;
                            dbBackup.Devices.AddDevice("C:\\backup\\forced\\" + test, DeviceType.File);
                            // dbBackup.Devices.AddDevice(string.Format(@"C:\temp\{0}.bak", "forced" + DateTime.Now.ToShortDateString()), DeviceType.File);
                            dbBackup.Initialize = true;
                            dbBackup.PercentComplete += dbBackup_PercentComplete;
                            dbBackup.Complete += dbBackup_Complete;
                            
                            dbBackup.SqlBackupAsync(dbServer);
                            lblStatus.Text = "Status: Backup in progress..";
                            button1.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.InnerException.ToString(), "Message");
                        }
                    }
              
            }
        }

      

        void saveBackupLog()
        {
            using (dbCommercialEntities dbcontext = new dbCommercialEntities())
            {
                tbBackupLog backupLog = new tbBackupLog();
                backupLog.done_by = userInitials;
                backupLog.trans_date = DateTime.Now;
                backupLog.machine_address = Environment.MachineName;
                backupLog.filename = filename;
                dbcontext.AddTotbBackupLogs(backupLog);
                dbcontext.SaveChanges();
            }



        }

        void dbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });

                button1.Invoke((MethodInvoker)delegate
                {
                    button1.Text = "Close";
                    button1.Enabled = true;
                });
                saveBackupLog();

            }
           
        }

        void dbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
           progressBar1.Invoke((MethodInvoker)delegate{
               progressBar1.Value = e.Percent;
               progressBar1.Update();
           });
           lblPercent.Invoke((MethodInvoker)delegate
           {
               lblPercent.Text = string.Format("{0} %", e.Percent);
           });
               
        }

        private void formBackupDatabase_Load(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["dbCommercialEntities"].ConnectionString;

            EntityConnectionStringBuilder entityConnectionStringBuilder = new EntityConnectionStringBuilder(conStr);
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(entityConnectionStringBuilder.ProviderConnectionString);
            string server = sqlConnectionStringBuilder.DataSource;
            textBox1.Text = server;
            sqlserver = server;
        }

     

      

    }
}
