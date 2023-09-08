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
    public partial class formAddJournalEntry : Form
    {
        public string AcctTitle
        {
            get { return textBox1.Text; }
        }

        public string AcctCode
        {
            get { return comboBox1.Text; }
        }

        public decimal AcctAmount
        {
            get { return Convert.ToDecimal(textBox2.Text); }
        }

        public formAddJournalEntry()
        {
            InitializeComponent();
        }

        private void formAddJournalEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBAMLookup.tbBAMLookup' table. You can move, or remove it, as needed.
            this.tbBAMLookupTableAdapter.Fill(this.dsBAMLookup.tbBAMLookup);
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            comboBox1.KeyPress +=new KeyPressEventHandler(textBox1_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox1.SelectAll();

        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) SendKeys.Send("{TAB}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please indicate Account title.");
            }
            else
            {
                decimal amt = 0;
                bool amt_is_ok = decimal.TryParse(textBox2.Text,out amt);
                if (amt_is_ok)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Amount detected. Please correct accordingly.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
