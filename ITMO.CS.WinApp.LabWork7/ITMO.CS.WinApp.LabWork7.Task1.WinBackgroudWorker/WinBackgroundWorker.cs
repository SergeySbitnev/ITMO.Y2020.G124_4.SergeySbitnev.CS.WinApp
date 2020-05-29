using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork7.Task1.WinBackgroudWorker
{
    public partial class WinBackgroundWorker : Form
    {
        public WinBackgroundWorker()
        {
            InitializeComponent();
        }

        private void textBoxSecondsToSleep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The field should contain only numbers!!!");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int sec;
            sec = int.Parse(e.Argument.ToString());
            for (int step = 1; step <= sec; step++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                System.Threading.Thread.Sleep(1000);
                backgroundWorker1.ReportProgress((int)(step * 100 / sec));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
            {
                MessageBox.Show("Run Completed");
            }
            else
            {
                MessageBox.Show("Run Canceled");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!(textBoxSecondsToSleep.Text == ""))
            {
                int sec = int.Parse(textBoxSecondsToSleep.Text);
                backgroundWorker1.RunWorkerAsync(sec);
            }
            else
            {
                MessageBox.Show("The field cannot be empty!!!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
