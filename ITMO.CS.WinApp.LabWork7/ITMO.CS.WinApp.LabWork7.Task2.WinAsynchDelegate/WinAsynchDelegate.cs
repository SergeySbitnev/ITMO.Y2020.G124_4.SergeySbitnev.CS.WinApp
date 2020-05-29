using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork7.Task2.WinAsynchDelegate
{
    public partial class WinAsynchDelegate : Form
    {
        bool Cancel;

        public WinAsynchDelegate()
        {
            InitializeComponent();
        }

        private void TimeConsumingMethod(int seconds)
        {
            for (int step = 1; step <= seconds; step++)
            {
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(step * 100) / seconds);
                if (Cancel)
                {
                    break;
                }
            }
            if (Cancel)
            {
                MessageBox.Show("Cancelled");
                Cancel = false;
            }
            else
            {
                MessageBox.Show("Complete");
            }
        }

        private delegate void TimeConsumingMethodDelegate(int seconds);

        public delegate void SetProgressDelegate(int val);

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The field should contain only numbers!!!");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate del = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            del.BeginInvoke(int.Parse(textBoxSeconds.Text), null, null);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
