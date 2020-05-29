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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void buttonPress_Click(object sender, EventArgs e)
        {
            WinGrafSinLine frm1 = this.Owner as WinGrafSinLine;

            try
            {

                frm1.firstFactor = double.Parse(textBoxFirstValue.Text);
                frm1.secondFactor = double.Parse(textBoxSecondValue.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данных возникла ошибка: \n" + er.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            this.Close();
            frm1.Refresh();
        }
    }
}
