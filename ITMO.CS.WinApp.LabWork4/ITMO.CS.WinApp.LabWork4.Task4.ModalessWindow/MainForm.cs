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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClickHere_Click(object sender, EventArgs e)
        {
            ModallesWindow form = new ModallesWindow();
            form.Show(this);
        }
        public string SolData
        {
            get
            {
                return textBoxInfo.Text;
            }

            set
            {
                textBoxInfo.Text = value;
            }
        }
    }

  
}
