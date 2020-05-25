using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork1.Task5.RoundForm
{
    public partial class RoundForm : Form
    {
        public RoundForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 400, 400);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void ButtomClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
