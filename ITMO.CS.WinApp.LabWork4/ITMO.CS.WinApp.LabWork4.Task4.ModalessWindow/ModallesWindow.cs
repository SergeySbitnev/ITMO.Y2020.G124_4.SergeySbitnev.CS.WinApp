using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork4.Task4.ModalessWindow
{
    public partial class ModallesWindow : Form
    {
        public ModallesWindow()
        {
            InitializeComponent();
        }

        private void buttonTransferTo_Click(object sender, EventArgs e)
        {
            string s = textBoxFirst.Text + " " + textBoxSecond.Text + " " + textBoxThird.Text;
            MainForm form = this.Owner as MainForm;
            if (form != null)
            {
                form.SolData = s;
            }

            this.Close();
        }
    }
}
