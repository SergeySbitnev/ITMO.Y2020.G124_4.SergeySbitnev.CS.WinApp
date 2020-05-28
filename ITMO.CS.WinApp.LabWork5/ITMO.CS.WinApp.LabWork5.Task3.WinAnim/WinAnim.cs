using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CS.WinApp.LabWork5.Task3.WinAnim
{
    public partial class WinAnim : Form
    {
        public WinAnim()
        {
            InitializeComponent();
        }

        private void buttonManifestation_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 300,
                WinAPIClass.AnimateWindowFlags.AW_ACTIVATE |
                WinAPIClass.AnimateWindowFlags.AW_BLEND);
            this.buttonManifestation.Invalidate();
            this.buttonHorSlide.Invalidate();
            this.buttonCenterSlide.Invalidate();
        }

        private void buttonHorSlide_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 300,
                WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE |
                WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.buttonManifestation.Invalidate();
            this.buttonHorSlide.Invalidate();
            this.buttonCenterSlide.Invalidate();
        }

        private void buttonCenterSlide_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinAPIClass.AnimateWindow(this, 300,
                WinAPIClass.AnimateWindowFlags.AW_CENTER |
                WinAPIClass.AnimateWindowFlags.AW_SLIDE);
            this.buttonManifestation.Invalidate();
            this.buttonHorSlide.Invalidate();
            this.buttonCenterSlide.Invalidate();
        }
    }
}
