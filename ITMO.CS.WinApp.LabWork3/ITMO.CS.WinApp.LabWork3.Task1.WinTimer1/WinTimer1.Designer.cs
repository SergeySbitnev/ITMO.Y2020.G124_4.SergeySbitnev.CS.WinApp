namespace ITMO.CS.WinApp.LabWork3.Task1.WinTimer1
{
    partial class WinTimer1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControlTimer1 = new ITMO.CS.WinApp.LabWork3.Task1.WinTimer1.UserControlTimer();
            this.userControl11 = new ITMO.CS.WinApp.LabWork3.Task1.UserControlTimerDLL.UserControl1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserControl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserControlDLL";
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(99, 12);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(103, 27);
            this.userControlTimer1.TabIndex = 0;
            this.userControlTimer1.TimeEnable = true;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(121, 59);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(124, 27);
            this.userControl11.TabIndex = 4;
            this.userControl11.TimeEnable = true;
            // 
            // WinTimer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 173);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlTimer1);
            this.Name = "WinTimer1";
            this.Text = "WinTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlTimer userControlTimer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UserControlTimerDLL.UserControl1 userControl11;
    }
}

