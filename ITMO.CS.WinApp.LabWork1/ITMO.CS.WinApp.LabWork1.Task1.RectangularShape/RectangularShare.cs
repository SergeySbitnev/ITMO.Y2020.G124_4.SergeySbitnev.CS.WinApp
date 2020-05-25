using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork1.Task1.RectangularShape
{
    public partial class RectangularShare : Form
    {
        public RectangularShare()
        {
            InitializeComponent();
        }

        private void BorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void Opacity_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void RectangularShare_Load(object sender, EventArgs e)
        {

        }
    }
}
