/** Sample in using
DBRemix tst = new DBRemix(@"192.168.1.44\SQLEXPRESS","dbTWD","sa","administrator");
ArrayList test = new ArrayList();
test.Add("Jocelyn S. Emotin, CPA");
test.Add("Finance Services");
test.Add("Administrative");
tst.SaveToDatabase("tbDivision",test,"division_manager","division_name","department");
*/


using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BillingSystem
{
    class DBRemix
    {
        private string connString;
        private string query;

        public DBRemix()
        {
           // connString = @"BILLSERVER\SQLEXPRESS;Database=dbTWD;User Id=commuser;Password=comm123;";
           // connString = @"Server=127.0.0.1\SQLEXPRESS;Database=dbTWD;User Id=commuser;Password=comm123;";
        }

        public DBRemix(string dbprovider)
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\project\data;Extended Properties=dBASE III;";
        }

        public DBRemix(string pathfile, Boolean mode)
        {

            connString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=dBASE III;", pathfile);
           // Console.WriteLine(connString);

        }

        public DBRemix(string server,string database,string user,string pass)
        {
           // string conStr = @"Server=pServer;Database=pDatabase;User Id=pUser;Password=pPass;";
            connString = @"Server=" + @server + ";Database=" + database + ";User Id=" + user + ";Password=" + pass + ";";          
            connString = connString.Replace("\\",@"\");           

        }

     

        private void ProcessInsertQuery(string table,params string[] test)
        {
            string qry1 = "INSERT INTO "+table + "(";
            string qry2 = ") VALUES (";
            for (int i = 0; i < test.Length; i++)
            {
                if (i == test.Length - 1)
                {
                    qry1 = qry1 + string.Format("[{0}]",test[i]);
                    qry2 = qry2 + "@" + test[i]+")";
                }else
                {
                    qry1 = qry1 + string.Format("[{0}]", test[i]) + ",";
                    qry2 = qry2 + "@" + test[i] + ",";
                }
            }

            query = qry1 + qry2;
        }

        private void ProcessUpdateQuery(string table,string wherecon, params string[] test)
        {
            string qry1 = "UPDATE " + table + " SET ";
            string qry2 = "";
            string qry3 = " WHERE "+wherecon;
            for (int i = 0; i < test.Length; i++)
            {
                if (i == test.Length - 1)
                {
                    qry2 = qry2 + "["+ test[i] + "]=@"+test[i];
                    
                }
                else
                {
                    qry2 = qry2 + "[" + test[i] + "]=@" + test[i] + ",";
                }
            }
            query = qry1 + qry2 + qry3;
        }

        public void UpdateToDatabase(string table, string wherecon, ArrayList dbValues, params string[] dbParams)
        {
            ProcessUpdateQuery(table, wherecon, dbParams);
            using (SqlConnection conn = new SqlConnection(@connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int index = 0;
                    foreach (var element in dbValues)
                    {
                        cmd.Parameters.AddWithValue("@" + dbParams[index], element);
                        index++;
                    }
                    cmd.ExecuteNonQuery();
                }               
            }
        }

        public void OLEDBUpdateToDatabase(string table, string wherecon, ArrayList dbValues, params string[] dbParams)
        {
            ProcessUpdateQuery(table, wherecon, dbParams);
            using (OleDbConnection conn = new OleDbConnection(@connString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    int index = 0;
                    foreach (var element in dbValues)
                    {
                        cmd.Parameters.AddWithValue("@" + dbParams[index], element);
                        index++;                     
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteDatabase(string table)
        {
            using (OleDbConnection conn = new OleDbConnection(@connString))
            {
                using (OleDbCommand cmdtxt = conn.CreateCommand())
                {
                    conn.Open();

                    cmdtxt.CommandText = string.Format("Delete from [{0}]",table);
                    cmdtxt.ExecuteNonQuery();
                }
            }
        }

        public void SaveToDatabase(string table,ArrayList dbValues,params string[] dbParams)
        {

            ProcessInsertQuery(table,dbParams);
            
            using (SqlConnection conn = new SqlConnection(@connString)) 
            {
                /**
                try
                { */
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int index = 0;
                        foreach (var element in dbValues)
                        {
                            cmd.Parameters.AddWithValue("@"+dbParams[index], element);
                            index++;
                        }
                       
                        cmd.ExecuteNonQuery();
                    }
         /**
                }
                   
                catch
                {
                    MessageBox.Show("Database server not found. Please contact PGS to check connection.", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }*/
            }
        }

        public void SaveToOLEDatabase(string table, ArrayList dbValues, params string[] dbParams)
        {
            ProcessInsertQuery(table, dbParams);

            using (OleDbConnection conn = new OleDbConnection(@connString))
            {
                /**
                try
                { */
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    int index = 0;
                    foreach (var element in dbValues)
                    {
                        cmd.Parameters.AddWithValue("@" + dbParams[index], element);
                        index++;
                    }
                  //  Console.WriteLine(query);
                    cmd.ExecuteNonQuery();
                }
                /**
                       }
                   
                       catch
                       {
                           MessageBox.Show("Database server not found. Please contact PGS to check connection.", "Database Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           Application.Exit();
                       }*/
            }
        }

        public Boolean CheckDatabaseValue(string table, string condition)
        {
            query = "Select * from " + table + " where " + condition;
            int recCount = 0;
            using (SqlConnection conn=new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            recCount++;
                        }
                    }
                }

            }
            return (recCount > 0) ? true : false;
        } 

        public DateTime GetServerDateTime()
        {
            DateTime server_date = new DateTime();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select GETDATE()", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            server_date = reader.GetDateTime(0);
                        }
                    }

                }
            }
            return server_date;
        }

        public int GetLastID(string table)
        {
            int lastrec = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select IDENT_CURRENT('" + table+"') as lastID", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lastrec = Int32.Parse(reader["lastID"].ToString());
                        }
                    }

                }
            }   
            return lastrec;
        }

        public string GetColumnValue(string table, string columnname, string wherecon)
        {
            string foundvalue="0";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Select "+columnname+ " from "+table+ " where "+ wherecon , conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foundvalue = reader[columnname].ToString();
                        }
                    }

                }
            }
            return foundvalue;
        }

        public string GetOledbColumnValue(string table, string columnname, string wherecon)
        {
            
            string foundvalue = "0";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("Select [" + columnname + "] from " + table + " where " + wherecon, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foundvalue = reader[columnname].ToString();
                        }
                    }

                }
            }
            return foundvalue;
        }
    
    
    }
}
