using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork2.Task8.KeyPressValidatingErrorProvide
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void checkBoxExtended_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtended.Checked == true)
            {
                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(6, 111);
                lbl.Size = new System.Drawing.Size(31, 13);
                lbl.Name = "labelPIN2";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                groupBoxRegistrationData.Controls.Add(lbl);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(47, 108);
                txt.Size = new System.Drawing.Size(200, 20);
                txt.Name = "textBoxPIN2";
                txt.TabIndex = 1;
                txt.Text = "";
                txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPIN2_KeyPress);
                groupBoxRegistrationData.Controls.Add(txt);
            }
            else
            {
                int lcv;
                lcv = groupBoxRegistrationData.Controls.Count;
                while (lcv > 4)
                {
                    groupBoxRegistrationData.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The Name field cannot contain numbers!");
                errorProviderName.SetError(textBoxName, "Must be letter");
            }
        }

        //private void textBoxPIN_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("The PIN field cannot contain letters!");
        //    }
        //}

        private void textBoxPIN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The PIN field cannot contain letters!");
            }
        }

        private void textBoxPIN_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPIN.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBoxPIN.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("The PIN field cannot contain letters!");
                }
            }
        }
    }
}
