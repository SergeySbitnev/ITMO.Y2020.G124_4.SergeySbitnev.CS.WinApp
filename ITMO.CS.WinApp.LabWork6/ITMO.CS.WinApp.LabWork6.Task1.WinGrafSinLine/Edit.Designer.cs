namespace ITMO.CS.WinApp.LabWork6.Task1.WinGrafSinLine
{
    partial class Edit
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
            this.textBoxFirstValue = new System.Windows.Forms.TextBox();
            this.textBoxSecondValue = new System.Windows.Forms.TextBox();
            this.labelFirtsValue = new System.Windows.Forms.Label();
            this.labelSecondValue = new System.Windows.Forms.Label();
            this.buttonPress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstValue
            // 
            this.textBoxFirstValue.Location = new System.Drawing.Point(113, 6);
            this.textBoxFirstValue.Name = "textBoxFirstValue";
            this.textBoxFirstValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstValue.TabIndex = 0;
            // 
            // textBoxSecondValue
            // 
            this.textBoxSecondValue.Location = new System.Drawing.Point(113, 45);
            this.textBoxSecondValue.Name = "textBoxSecondValue";
            this.textBoxSecondValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondValue.TabIndex = 1;
            // 
            // labelFirtsValue
            // 
            this.labelFirtsValue.AutoSize = true;
            this.labelFirtsValue.Location = new System.Drawing.Point(12, 9);
            this.labelFirtsValue.Name = "labelFirtsValue";
            this.labelFirtsValue.Size = new System.Drawing.Size(95, 13);
            this.labelFirtsValue.TabIndex = 2;
            this.labelFirtsValue.Text = "Первое значение";
            // 
            // labelSecondValue
            // 
            this.labelSecondValue.AutoSize = true;
            this.labelSecondValue.Location = new System.Drawing.Point(12, 48);
            this.labelSecondValue.Name = "labelSecondValue";
            this.labelSecondValue.Size = new System.Drawing.Size(93, 13);
            this.labelSecondValue.TabIndex = 3;
            this.labelSecondValue.Text = "Второе значение";
            // 
            // buttonPress
            // 
            this.buttonPress.Location = new System.Drawing.Point(219, 6);
            this.buttonPress.Name = "buttonPress";
            this.buttonPress.Size = new System.Drawing.Size(59, 59);
            this.buttonPress.TabIndex = 4;
            this.buttonPress.Text = "ЖМИ";
            this.buttonPress.UseVisualStyleBackColor = true;
            this.buttonPress.Click += new System.EventHandler(this.buttonPress_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 77);
            this.Controls.Add(this.buttonPress);
            this.Controls.Add(this.labelSecondValue);
            this.Controls.Add(this.labelFirtsValue);
            this.Controls.Add(this.textBoxSecondValue);
            this.Controls.Add(this.textBoxFirstValue);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstValue;
        private System.Windows.Forms.TextBox textBoxSecondValue;
        private System.Windows.Forms.Label labelFirtsValue;
        private System.Windows.Forms.Label labelSecondValue;
        private System.Windows.Forms.Button buttonPress;
    }
}