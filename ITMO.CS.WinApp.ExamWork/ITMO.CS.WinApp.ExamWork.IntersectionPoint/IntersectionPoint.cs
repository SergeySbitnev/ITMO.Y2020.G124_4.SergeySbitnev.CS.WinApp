using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.ExamWork.IntersectionPoint
{
    public partial class IntersectionPoint : Form
    {
        Point pointA, pointB, pointC, pointD;

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
            {
                System.Threading.Thread.Sleep(1000);
                labelAnswer.Text = Point.SearchForTheIntersectionPoint(pointA, pointB, pointC, pointD);
            }
            else
            {
                labelAnswer.Text = "";
                progressBar1.Value = 0;
                MessageBox.Show("Поиск отменен!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPointAx.Text = "";
            textBoxPointAy.Text = "";
            textBoxPointBx.Text = "";
            textBoxPointBy.Text = "";
            textBoxPointCx.Text = "";
            textBoxPointCy.Text = "";
            textBoxPointDx.Text = "";
            textBoxPointDy.Text = "";
            labelAnswer.Text = "";
            progressBar1.Value = 0;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int step = 1; step <= 5; step++)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                System.Threading.Thread.Sleep(1000);
                backgroundWorker.ReportProgress((int)(step * 100 / 5));
            }
        }

        public IntersectionPoint()
        {
            InitializeComponent();
        }

        private void buttonSearchIntersectionPoint_Click(object sender, EventArgs e)
        {
            labelAnswer.Text = "";
            try
            {
                pointA = new Point(double.Parse(textBoxPointAx.Text), double.Parse(textBoxPointAy.Text));
                pointB = new Point(double.Parse(textBoxPointBx.Text), double.Parse(textBoxPointBy.Text));
                pointC = new Point(double.Parse(textBoxPointCx.Text), double.Parse(textBoxPointCy.Text));
                pointD = new Point(double.Parse(textBoxPointDx.Text), double.Parse(textBoxPointDy.Text));

                backgroundWorker.RunWorkerAsync();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
            

            //AsyncSearchIntersectionPoint search = new AsyncSearchIntersectionPoint(SearchIntersectionPoint);
            //AsyncCallback call = new AsyncCallback(CallBackMethod);
            //search.BeginInvoke(pointA, pointB, pointC, pointD, call, search);
        }








        //private void CallBackMethod(IAsyncResult ar)
        //{
        //    AsyncSearchIntersectionPoint search = (AsyncSearchIntersectionPoint)ar.AsyncState;
        //    MessageBox.Show(search.EndInvoke(ar));
        //}

        //private delegate string AsyncSearchIntersectionPoint(Point pointA, Point pointB, Point pointC, Point pointD);

        //private string SearchIntersectionPoint(Point pointA, Point pointB, Point pointC, Point pointD)
        //{
        //    SearchForm a = new SearchForm();
        //    a.Show();
            
        //    for (int step = 1; step <= 5; step++)
        //    {
        //        System.Threading.Thread.Sleep(1000);
        //    }
        //    a.Close();
        //    return Point.SearchForTheIntersectionPoint(pointA, pointB, pointC, pointD);
        //}
    }
}
