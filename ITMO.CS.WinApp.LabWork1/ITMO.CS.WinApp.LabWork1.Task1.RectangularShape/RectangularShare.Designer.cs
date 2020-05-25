namespace ITMO.CS.WinApp.LabWork1.Task1.RectangularShape
{
    partial class RectangularShare
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
            this.BorderStyle = new System.Windows.Forms.Button();
            this.ButtomResize = new System.Windows.Forms.Button();
            this.ButtomOpacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorderStyle
            // 
            this.BorderStyle.Location = new System.Drawing.Point(12, 12);
            this.BorderStyle.Name = "BorderStyle";
            this.BorderStyle.Size = new System.Drawing.Size(156, 156);
            this.BorderStyle.TabIndex = 0;
            this.BorderStyle.Text = "Border Style";
            this.BorderStyle.UseVisualStyleBackColor = true;
            this.BorderStyle.Click += new System.EventHandler(this.BorderStyle_Click);
            // 
            // ButtomResize
            // 
            this.ButtomResize.Location = new System.Drawing.Point(174, 12);
            this.ButtomResize.Name = "ButtomResize";
            this.ButtomResize.Size = new System.Drawing.Size(75, 75);
            this.ButtomResize.TabIndex = 1;
            this.ButtomResize.Text = "Resize";
            this.ButtomResize.UseVisualStyleBackColor = true;
            this.ButtomResize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // ButtomOpacity
            // 
            this.ButtomOpacity.Location = new System.Drawing.Point(174, 93);
            this.ButtomOpacity.Name = "ButtomOpacity";
            this.ButtomOpacity.Size = new System.Drawing.Size(75, 75);
            this.ButtomOpacity.TabIndex = 2;
            this.ButtomOpacity.Text = "Opacity";
            this.ButtomOpacity.UseVisualStyleBackColor = true;
            this.ButtomOpacity.Click += new System.EventHandler(this.Opacity_Click);
            // 
            // RectangularShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtomOpacity);
            this.Controls.Add(this.ButtomResize);
            this.Controls.Add(this.BorderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "RectangularShare";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.Load += new System.EventHandler(this.RectangularShare_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BorderStyle;
        private System.Windows.Forms.Button ButtomResize;
        private System.Windows.Forms.Button ButtomOpacity;
    }
}

