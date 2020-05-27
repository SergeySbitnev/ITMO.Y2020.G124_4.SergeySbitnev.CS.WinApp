namespace ITMO.CS.WinApp.LabWork4.Task4.ModalessWindow
{
    partial class ModallesWindow
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
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.textBoxThird = new System.Windows.Forms.TextBox();
            this.buttonTransferTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Location = new System.Drawing.Point(13, 13);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(259, 20);
            this.textBoxFirst.TabIndex = 0;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(13, 40);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(259, 20);
            this.textBoxSecond.TabIndex = 1;
            // 
            // textBoxThird
            // 
            this.textBoxThird.Location = new System.Drawing.Point(13, 67);
            this.textBoxThird.Name = "textBoxThird";
            this.textBoxThird.Size = new System.Drawing.Size(259, 20);
            this.textBoxThird.TabIndex = 2;
            // 
            // buttonTransferTo
            // 
            this.buttonTransferTo.Location = new System.Drawing.Point(13, 112);
            this.buttonTransferTo.Name = "buttonTransferTo";
            this.buttonTransferTo.Size = new System.Drawing.Size(259, 23);
            this.buttonTransferTo.TabIndex = 3;
            this.buttonTransferTo.Text = "Transfer to...";
            this.buttonTransferTo.UseVisualStyleBackColor = true;
            this.buttonTransferTo.Click += new System.EventHandler(this.buttonTransferTo_Click);
            // 
            // ModallesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.buttonTransferTo);
            this.Controls.Add(this.textBoxThird);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ModallesWindow";
            this.Text = "ModallesWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.TextBox textBoxThird;
        private System.Windows.Forms.Button buttonTransferTo;
    }
}