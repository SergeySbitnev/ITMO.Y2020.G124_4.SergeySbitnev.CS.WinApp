namespace ITMO.CS.WinApp.LabWork1.Task3.HeritableForm
{
    partial class NonRectangularShare
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
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(12, 12);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonCloseForm.TabIndex = 0;
            this.ButtonCloseForm.Text = "Close Form";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // NonRectangularShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NonRectangularShare";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NonRectangularShare_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button ButtonCloseForm;
    }
}

