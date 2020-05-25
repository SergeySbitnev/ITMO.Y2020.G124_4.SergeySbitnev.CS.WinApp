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
    public partial class GREENPEACE : Form
    {
        public GREENPEACE()
        {
            InitializeComponent();
        }

        private void GREENPEACE_Load(object sender, EventArgs e)
        {
            Point[] myRombus =
            {
                new Point (0, this.Width/2),
                new Point (this.Height/2, 0),
                new Point (this.Height, this.Width/2),
                new Point (this.Height/2, this.Width)
            };
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(myRombus);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

        }

        private void ButtomGreenpeace_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
