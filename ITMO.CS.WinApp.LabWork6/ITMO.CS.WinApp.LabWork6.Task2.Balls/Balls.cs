using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork6.Task2.Balls
{
    public partial class Balls : Form
    {
        Point location = new Point(50, 50);
        Point speed = new Point(5, 5);

        public Balls()
        {
            InitializeComponent();
        }

        private void Go()
        {
            location = new Point(location.X + speed.X, location.Y + speed.Y);

            if (location.X + 0 > ClientRectangle.Width || location.X <0)
            {
                speed = new Point(-speed.X, speed.Y);
            }

            if (location.Y + 10 > ClientRectangle.Height || location.Y <0)
            {
                speed = new Point(speed.X, -speed.Y);
            }
        }

        private void Ball()
        {
            Graphics gr = Graphics.FromHwnd(this.Handle);
            gr.FillEllipse(Brushes.Cyan, location.X, location.Y, 10, 10);
            Go();
        }

        private void timerBalls_Tick(object sender, EventArgs e)
        {
            Refresh();
            Ball();
        }

        private void checkBoxGo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGo.Checked)
            {
                timerBalls.Enabled = true;
            }
            else
            {
                timerBalls.Enabled = false;
            }
        }

        private void Balls_Load(object sender, EventArgs e)
        {
            if (checkBoxGo.Checked)
            {
                timerBalls.Enabled = true;
            }
            else
            {
                timerBalls.Enabled = false;
            }
        }
    }
}
