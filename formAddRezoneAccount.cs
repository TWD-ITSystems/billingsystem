using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Configuration;
using System.Data.SqlClient;



namespace BillingSystem
{
    public partial class formAddRezoneAccount : Form
    {
        GlobalFunctions gfunc = new GlobalFunctions();
        List<string> accountList = new List<string>();
        
        Dictionary<string, string> masterAcctno = new Dictionary<string, string>();

        public formAddRezoneAccount()
        {
            InitializeComponent();
        }

        private void formAddRezoneAccount_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadAcctNoToList();
           
        }

        private void LoadAcctNoToList()
        {
            masterAcctno.Clear();
           string conStr = ConfigurationManager.ConnectionStrings["LiveServer"].ConnectionString;
           using(SqlConnection conn=new SqlConnection(conStr))
           using (SqlCommand cmd = new SqlCommand("dbo.spQueryAccountNos", conn))
           {
               cmd.CommandType = CommandType.StoredProcedure;               
               conn.Open();
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
               {                   
                   masterAcctno[reader["acctno"].ToString()] = reader["name"].ToString();
               }
           }          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string name = getName(textBox1.Text);
                if( name.Length > 0)
                {
                    textBox2.Text = name;
                    if (accountList.Contains(textBox1.Text))
                    {

                        MessageBox.Show("Duplicate record detected");
                        textBox1.SelectAll();
                    }
                    else
                    {
                        accountList.Add(textBox1.Text);
                        //radGridView1.Rows.Add(false, textBox1.Text, textBox2.Text, comboBox1.Text);

                        GridViewDataRowInfo dataRowInfo = new GridViewDataRowInfo(this.radGridView1.MasterView);
                        dataRowInfo.Cells[0].Value = false;
                        dataRowInfo.Cells[1].Value = textBox1.Text;
                        dataRowInfo.Cells[2].Value = textBox2.Text;
                        dataRowInfo.Cells[3].Value = comboBox1.Text;
                        radGridView1.Rows.Insert(0, dataRowInfo);

                        //radGridView1.Rows.Insert
                        textBox1.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Account Number. Please check.");
                    textBox1.SelectAll();
                }
            }
        }


        string getName(string acctno)
        {
            return masterAcctno[acctno];         
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            int rowcount = radGridView1.Rows.Count();
            for (int i = rowcount; i > 0; i--)
            {
                if (radGridView1.Rows[i - 1].Cells[0].Value.Equals(true))
                {                
                    accountList.Remove(radGridView1.Rows[i - 1].Cells[1].Value.ToString());
                    radGridView1.Rows[i - 1].Delete();                    
                }
            }
           
        }

        private void formAddRezoneAccount_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radGridView1.Rows.Count > 0)
            {
                DialogResult dlgResult = MessageBox.Show("Do you want to save the records?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    using (dbRezoneEntities rezoneContext = new dbRezoneEntities())
                    {
                       // Dictionary<string, int> rezoneList = rezoneContext.tbRezones.Select(x => x).ToDictionary(x => x.acctno, x => x.rezone_id);

                        foreach (GridViewRowInfo rowInfo in radGridView1.Rows)
                        {
                            string acctno = rowInfo.Cells[1].Value.ToString(); 
                            string newzone = rowInfo.Cells[3].Value.ToString();

                            //bool acctForEdit = rezoneList.ContainsKey(acctno);
                            //if (acctForEdit)
                            //{
                            //    tbRezone acctEdit = rezoneContext.tbRezones.FirstOrDefault(x => x.rezone_id == rezoneList[acctno]);
                            //    acctEdit.old_zone = acctEdit.new_zone;
                            //    acctEdit.new_zone = newzone;
                            //}
                            //else
                            //{
                                tbRezone reZone = new tbRezone();
                                reZone.acctno = acctno;
                                reZone.new_zone = newzone ;
                                reZone.date_added = DateTime.Now;
                                rezoneContext.AddTotbRezones(reZone);
                           // }
                        }
                        rezoneContext.SaveChanges();
                        MessageBox.Show("Records successfully saved.");
                        radGridView1.Rows.Clear();
                        accountList.Clear();
                    }
                }
            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();            
        }

    }
}
