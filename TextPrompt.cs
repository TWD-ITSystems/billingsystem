using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BillingSystem
{

    public static class TextPrompt
    {
        public static string ShowDialog(string labeltext, string formcaption)
        {
            Form prompt = new Form();
            prompt.Width = 220;
            prompt.Height = 150;
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = formcaption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 30, Top = 20,AutoSize=false,Width=200, Text = labeltext };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 170 };
            Button confirmation = new Button() { Text = "Ok", Left = 60, Width = 80, Top = 80, DialogResult = DialogResult.OK,TextAlign=ContentAlignment.MiddleCenter };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public static string ShowDialog(string labeltext, string formcaption,string txbox_default_value,string additional_note)
        {
            Form prompt = new Form();
            prompt.Width = 220;
            prompt.Height = 190;
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
            prompt.ControlBox = false;
            prompt.Text = formcaption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 30, Top = 20, AutoSize = false, Width = 150,Height=30,TextAlign=ContentAlignment.MiddleCenter ,Text = labeltext };
            TextBox textBox = new TextBox() { Left = 20, Top = 70, Width = 170, TextAlign=HorizontalAlignment.Center };
            Button confirmation = new Button() { Text = "Ok", Left = 65, Width = 80, Top = 100, DialogResult = DialogResult.OK};
            Label noteLabel = new Label() { Left = 30, Top = 130, AutoSize = false, Width = 150, Height = 30, TextAlign = ContentAlignment.MiddleLeft, Text = string.Format("Note: {0}",additional_note) };
            textBox.Text = txbox_default_value;
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(noteLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
