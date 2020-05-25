namespace ITMO.CS.WinApp.LabWork1.Task5.GREENPEACE
{
    partial class GREENPEACE
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
            this.ButtomGreenpeace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtomGreenpeace
            // 
            this.ButtomGreenpeace.Location = new System.Drawing.Point(325, 329);
            this.ButtomGreenpeace.Name = "ButtomGreenpeace";
            this.ButtomGreenpeace.Size = new System.Drawing.Size(136, 69);
            this.ButtomGreenpeace.TabIndex = 0;
            this.ButtomGreenpeace.Text = "GREENPEACE";
            this.ButtomGreenpeace.UseVisualStyleBackColor = true;
            this.ButtomGreenpeace.Click += new System.EventHandler(this.ButtomGreenpeace_Click);
            // 
            // GREENPEACE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.ButtomGreenpeace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GREENPEACE";
            this.Text = "GREENPEACE";
            this.Load += new System.EventHandler(this.GREENPEACE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtomGreenpeace;
    }
}

