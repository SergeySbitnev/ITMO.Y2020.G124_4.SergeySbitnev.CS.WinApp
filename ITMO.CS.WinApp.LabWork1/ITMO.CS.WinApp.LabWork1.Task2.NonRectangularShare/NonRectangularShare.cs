using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork1.Task2.NonRectangularShare
{
    public partial class NonRectangularShare : Form
    {
        public NonRectangularShare()
        {
            InitializeComponent();
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NonRectangularShare_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Width, 0) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
