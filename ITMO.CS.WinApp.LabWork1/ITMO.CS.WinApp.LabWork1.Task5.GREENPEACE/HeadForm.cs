using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork1.Task5.GREENPEACE
{
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            GREENPEACE newGREENPEACE = new GREENPEACE();
            newGREENPEACE.Show();
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
