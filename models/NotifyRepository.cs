using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace BillingSystem.models
{
    class NotifyRepository:NotificationTransaction
    {
        enum MessageClassification {
            SPACER,BILLING,WELCOME,ADVISORY,PAYMENT,EMPLOYEES,DUEDATE,DISCONNECTION,RECONNECTION
        }

        enum SendType
        {
           SPACER,SMS,EMAIL,MESSENGER
        }

        NotificationTransaction notification;
        private int _count;        
        string strNotifyCon,strCommercialCon;
        List<int> forProcessAccounts;
        Dictionary<int, string> bodyTemplates;
        Dictionary<int, int> messageTemplates;
        public int Count { get { return _count; } }
        

        public NotifyRepository()
        {
            strNotifyCon = getNotifyServer();
            strCommercialCon = getCommercialServer();
          //  _count = getNotificationCount();
          //  Console.WriteLine(records);
        }

      

        private List<int> getWelcomedAccounts()
        {
            List<int> tempList = new List<int>();
            using (var sqlCon = new SqlConnection(strNotifyCon))
            {
                sqlCon.Open();
                using (var sqlCmd = new SqlCommand("Select master_id from tbNotifyTransactions where msgclass_id=2",sqlCon))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())  
                            {                               
                                tempList.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
                sqlCon.Close();
            }
            return tempList;
        }

        private List<int> getGADAccountsWithMobile()
        {
            List<int> tempList = new List<int>();
            using (var sqlCon = new SqlConnection(strCommercialCon))
            {
                sqlCon.Open();
                using (var sqlCmd = new SqlCommand("select master_id FROM tbMasterGAD where (mobileno <> '') and (len(mobileno) = 11)", sqlCon))
                {
                    using (var reader = sqlCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tempList.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
                sqlCon.Close();
            }
            return tempList;

        }

        public void getAccountsForWelcome()
        {
            List<int> welcomedAccounts;
            List<int> gadAccounts;

            welcomedAccounts = getWelcomedAccounts();
            gadAccounts = getGADAccountsWithMobile();

            forProcessAccounts = gadAccounts.Except<int>(welcomedAccounts).ToList<int>();

           // Console.WriteLine(string.Format("Welcome:{0} -- GAD:{1} -- NotWelcomed:{2}",welcomedAccounts.Count(),gadAccounts.Count(),result.Count()));

          
        }

        public string processEnrollWelcome(int msgclassID)
        {
            //foreach (int masterID in accountsList)
            //{

            //}
            return "";
           
        }

        private void saveTotbNotifyTransactions(int masterID, string valuesList=null)
        {
            //field list  msgclass_id,sendtype_id,values_list,status,master_id,destination,added_by,added_date
            const string query = @"Insert into dbNotifyTransactions (msgclass_id,sendtype_id,values_list,
                master_id,destination,added_by,added_date) values (@msgclass_id,@sendtype_id,@values_list,
                @master_id,@destination,@added_by,@added_date)";
            using (var sqlConn = new SqlConnection(strNotifyCon))
            {
                sqlConn.Open();
                using (var cmd = new SqlCommand(query, sqlConn))
                {
                    cmd.Parameters.AddWithValue("@msgclass_id", (int)MessageClassification.WELCOME);
                    cmd.Parameters.AddWithValue("@sendtype_id", (int)SendType.SMS);
                    cmd.Parameters.AddWithValue("@values_list", valuesList);


                }
            }
        }

        private string getMobileNumber(int masterID)
        {
            string result;
            const string query = @"Select mobileno from tbMasterGAD where master_id=@masterID";
            using (var sqlConn = new SqlConnection(strCommercialCon))
            {
                sqlConn.Open();
                using(var cmd = new SqlCommand(query,sqlConn))
                {
                    cmd.Parameters.AddWithValue("@masterID", master_id);
                    result = (string)cmd.ExecuteScalar();
                }
                sqlConn.Close();
            }
            return result;
        }

        private void getMessageTemplate(int msgclassID)
        {
            int result;
            const string query = "Select msgclass_id,msgtemplate_id from tbMessageClassification where msgclass_id";
            using (var sqlConn = new SqlConnection(strNotifyCon))
            {
                sqlConn.Open();
                using (var sqlComm = new SqlCommand(query , sqlConn))
                {
                    using (var reader = sqlComm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                messageTemplates.Add(reader.GetInt32(0), reader.GetInt32(1));
                            }
                        }
                    }
                }
                sqlConn.Close();
            }            
        }

        private void getTemplateBody()
        {           
            const string query = "Select msgtemplate_id,bodytext from tbMessageTemplate";          
            using (var sqlConn = new SqlConnection(strNotifyCon))
            {
                sqlConn.Open();
                using (var sqlComm = new SqlCommand(query, sqlConn))
                {
                    using (var reader = sqlComm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                bodyTemplates.Add(reader.GetInt32(0), reader.GetString(1));
                            }
                        }
                    }
                }
                sqlConn.Close();
            } 
        }

        private int getNotificationCount()
        {
            int result;
            using (var sqlConn = new SqlConnection(strNotifyCon))
            {
                sqlConn.Open();
                using (var sqlComm = new SqlCommand("Select count(*) from tbNotifyTransactions", sqlConn))
                {
                    result= (int)sqlComm.ExecuteScalar();
                }
                sqlConn.Close();
            }
            return result;
        }

        private string getNotifyServer()
        {
           return ConfigurationManager.ConnectionStrings["Notification"].ConnectionString;
        }

        private string getCommercialServer()
        {
            return ConfigurationManager.ConnectionStrings["BillingSystem.Properties.Settings.dbCommercialConnectionString"].ConnectionString;
        }
    }
}
