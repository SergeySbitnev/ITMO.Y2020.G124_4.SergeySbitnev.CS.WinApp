namespace ITMO.CS.WinApp.LabWork1.Task5.RoundForm
{
    partial class RoundForm
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
            this.ButtomClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtomClose
            // 
            this.ButtomClose.Location = new System.Drawing.Point(160, 170);
            this.ButtomClose.Name = "ButtomClose";
            this.ButtomClose.Size = new System.Drawing.Size(80, 30);
            this.ButtomClose.TabIndex = 0;
            this.ButtomClose.Text = "CLOSE";
            this.ButtomClose.UseVisualStyleBackColor = true;
            this.ButtomClose.Click += new System.EventHandler(this.ButtomClose_Click);
            // 
            // RoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.ButtomClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoundForm";
            this.Text = "Round Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtomClose;
    }
}

