namespace ITMO.CS.WinApp.LabWork5.Task3.WinAnim
{
    partial class WinAnim
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
            this.buttonManifestation = new System.Windows.Forms.Button();
            this.buttonHorSlide = new System.Windows.Forms.Button();
            this.buttonCenterSlide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonManifestation
            // 
            this.buttonManifestation.Location = new System.Drawing.Point(12, 12);
            this.buttonManifestation.Name = "buttonManifestation";
            this.buttonManifestation.Size = new System.Drawing.Size(180, 23);
            this.buttonManifestation.TabIndex = 0;
            this.buttonManifestation.Text = "Проявление";
            this.buttonManifestation.UseVisualStyleBackColor = true;
            this.buttonManifestation.Click += new System.EventHandler(this.buttonManifestation_Click);
            // 
            // buttonHorSlide
            // 
            this.buttonHorSlide.Location = new System.Drawing.Point(198, 12);
            this.buttonHorSlide.Name = "buttonHorSlide";
            this.buttonHorSlide.Size = new System.Drawing.Size(180, 23);
            this.buttonHorSlide.TabIndex = 1;
            this.buttonHorSlide.Text = "Горизонтальное проявление";
            this.buttonHorSlide.UseVisualStyleBackColor = true;
            this.buttonHorSlide.Click += new System.EventHandler(this.buttonHorSlide_Click);
            // 
            // buttonCenterSlide
            // 
            this.buttonCenterSlide.Location = new System.Drawing.Point(384, 12);
            this.buttonCenterSlide.Name = "buttonCenterSlide";
            this.buttonCenterSlide.Size = new System.Drawing.Size(180, 23);
            this.buttonCenterSlide.TabIndex = 2;
            this.buttonCenterSlide.Text = "Появление из центра";
            this.buttonCenterSlide.UseVisualStyleBackColor = true;
            this.buttonCenterSlide.Click += new System.EventHandler(this.buttonCenterSlide_Click);
            // 
            // WinAnim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCenterSlide);
            this.Controls.Add(this.buttonHorSlide);
            this.Controls.Add(this.buttonManifestation);
            this.Name = "WinAnim";
            this.Text = "Анимация формы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonManifestation;
        private System.Windows.Forms.Button buttonHorSlide;
        private System.Windows.Forms.Button buttonCenterSlide;
    }
}

