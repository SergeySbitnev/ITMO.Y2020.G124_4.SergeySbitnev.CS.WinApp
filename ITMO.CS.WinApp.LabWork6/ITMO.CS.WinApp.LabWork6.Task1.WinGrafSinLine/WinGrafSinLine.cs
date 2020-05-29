using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork6.Task1.WinGrafSinLine
{
    public partial class WinGrafSinLine : Form
    {
        public double firstFactor, secondFactor;

        private void panelPaint_Paint(object sender, PaintEventArgs e)
        {
            double t = 0;
            Point firstPoint, secondPoint;
            int w = (int)panelPaint.Width;
            int h = (int)panelPaint.Height;
            int y = h / 2;

            for (int step = 0; step < w; step++)
            {
                firstPoint = new Point(step, y);
                t = Operation.SummSin(step, firstFactor, secondFactor);
                y = (int)(t * h / 5);
                y = y + h / 2;

                secondPoint = new Point(step, y);
                Graphics dc = e.Graphics;
                Pen point = new Pen(Color.Red, 1);
                dc.DrawLine(point, firstPoint, secondPoint);

            }
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            try
            {
                firstFactor = double.Parse(textBoxSinLeft.Text);
                secondFactor = double.Parse(textBoxSinRight.Text);
                panelPaint.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit editF = new Edit();
            editF.Show(this);
        }

        public WinGrafSinLine()
        {
            InitializeComponent();
            firstFactor = 0.1;
            secondFactor = 0.04;
        }
    }
}
