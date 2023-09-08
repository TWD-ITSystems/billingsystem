using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class formPassword : Form
    {
        public bool access_allow { get; set; }

        string mode = "";

        public formPassword()
        {
            InitializeComponent();
        }

        public formPassword(string pass_mode):this()
        {
            mode = pass_mode;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string password="";
                if (mode.Equals("delete"))
                {
                    password = new GlobalFunctions().getPassword("delete");
                    if (textBox1.Text.Equals(password))
                    {
                        this.access_allow = true;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    { 
                        this.access_allow = false;
                        this.DialogResult = DialogResult.No;
                    }
                }
                this.Close();
            }
        }
    }
}
