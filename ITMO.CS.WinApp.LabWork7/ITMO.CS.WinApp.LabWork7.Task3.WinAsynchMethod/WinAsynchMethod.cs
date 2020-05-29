using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork7.Task3.WinAsynchMethod
{
    public partial class WinAsynchMethod : Form
    {
        public WinAsynchMethod()
        {
            InitializeComponent();
        }

        private delegate int AsyncSumm(int a, int b);

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void buttonSumma_Click(object sender, EventArgs e)
        {
            int a, b;

            try
            {
                a = Int32.Parse(textBoxValueA.Text);
                b = Int32.Parse(textBoxValueB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошика!");
                textBoxValueA.Text = textBoxValueB.Text = "";
                return;
            }
                       
            AsyncSumm summDelegate = new AsyncSumm(Summ);
            AsyncCallback cd = new AsyncCallback(CallBackMethod);
            summDelegate.BeginInvoke(a, b, cd, summDelegate);
        }

        private void CallBackMethod (IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }
    }
}
