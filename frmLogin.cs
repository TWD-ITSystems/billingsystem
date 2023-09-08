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


namespace BillingSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UserLogin user = new UserLogin(txUser.Text, txPass.Text);
            if (user.validateLogin())
            {
                MainForm mainForm = new MainForm();
                mainForm.username = user._username;
                mainForm.userID = user._userID;
                mainForm.access_code = user._accesscode;
                mainForm.Show();
                this.Hide();
                new GlobalFunctions().saveLastLogin(user._userID);
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txUser.Clear();
                txPass.Clear();
                txUser.Focus();
            }
        }

        private void txUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txPass.Focus();
            }
        }

        private void txPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings[1].ToString();
            MessageBox.Show(constr);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string oldtext = this.Text;
            string newtext = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = string.Format("{0} [{1}]", oldtext, newtext);

         
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["dbCommercialEntities"].ConnectionString;
          
            EntityConnectionStringBuilder entityConnectionStringBuilder = new EntityConnectionStringBuilder(conStr);
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(entityConnectionStringBuilder.ProviderConnectionString);
            string server = sqlConnectionStringBuilder.DataSource;            
            label5.Text = "[ SERVER: " + server + " ]";
        }
    }
}
