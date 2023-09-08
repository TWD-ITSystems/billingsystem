using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace BillingSystem
{
    class UserLogin
    {
        private string username="";
        private string userpass="";
        private int userID = 0;
        private string fullname;
        private int access_code = 0;

        public UserLogin(string uname, string upass)
        {
            username = uname;
            userpass = upass;
        }

        public bool validateLogin()
        {
            //const string conStr = @"Server=BILLSERVER\SQLEXPRESS;Database=dbCommercial;User Id=commsys;Password=comm123;";            
            string conStr = ConfigurationManager.ConnectionStrings[1].ToString();

            string query = "Select * from tbUsers where user_name=@uname AND pass_word=@upass";
            int recCount = 0;
            int isBilling = 0;
            using (SqlConnection conn = new SqlConnection(conStr)) 
            {
                try
                {
                    conn.Open();
               
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@upass", userpass);
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            recCount++;
                            fullname = dataReader["fullname"].ToString();
                            userID = dataReader.GetInt32(0);
                            access_code = Convert.ToInt32(dataReader["access_code"].ToString());
                            if (!Convert.IsDBNull(dataReader.GetValue(5)))
                            {
                                isBilling = dataReader.GetInt32(5);
                            }
                            else
                            {
                                isBilling = 0;
                            }

                        }
                    }
                    if (isBilling==0) {                        
                        return false;
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);                 
                }

            }
            
            return (recCount>0)?true:false;
        }

        public string _username
        {
            get
            {
                return fullname;
            }
        }

        public int _userID
        {
            get
            {
                return userID;
            }

        }

        public int _accesscode
        {
            get{
                return access_code;
            }
        }

    }
}
