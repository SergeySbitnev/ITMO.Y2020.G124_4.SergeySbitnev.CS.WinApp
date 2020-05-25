namespace ITMO.CS.WinApp.LabWork3.Task3.WinButNum
{
    partial class WinButNum
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
            this.clickButton1 = new ITMO.CS.WinApp.LabWork3.Task3.WinButNum.ClickButton();
            this.SuspendLayout();
            // 
            // clickButton1
            // 
            this.clickButton1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clickButton1.Location = new System.Drawing.Point(12, 12);
            this.clickButton1.Name = "clickButton1";
            this.clickButton1.Size = new System.Drawing.Size(776, 426);
            this.clickButton1.TabIndex = 0;
            this.clickButton1.Text = "CLICK HERE";
            this.clickButton1.UseVisualStyleBackColor = true;
            // 
            // WinButNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clickButton1);
            this.Name = "WinButNum";
            this.Text = "WinButNum";
            this.ResumeLayout(false);

        }

        #endregion

        private ClickButton clickButton1;
    }
}

