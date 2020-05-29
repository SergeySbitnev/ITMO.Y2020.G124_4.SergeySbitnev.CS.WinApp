namespace ITMO.CS.WinApp.LabWork7.Task3.WinAsynchMethod
{
    partial class WinAsynchMethod
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
            this.labelValueA = new System.Windows.Forms.Label();
            this.labelValueB = new System.Windows.Forms.Label();
            this.textBoxValueA = new System.Windows.Forms.TextBox();
            this.textBoxValueB = new System.Windows.Forms.TextBox();
            this.buttonSumma = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValueA
            // 
            this.labelValueA.AutoSize = true;
            this.labelValueA.Location = new System.Drawing.Point(12, 9);
            this.labelValueA.Name = "labelValueA";
            this.labelValueA.Size = new System.Drawing.Size(65, 13);
            this.labelValueA.TabIndex = 0;
            this.labelValueA.Text = "Значение А";
            // 
            // labelValueB
            // 
            this.labelValueB.AutoSize = true;
            this.labelValueB.Location = new System.Drawing.Point(202, 9);
            this.labelValueB.Name = "labelValueB";
            this.labelValueB.Size = new System.Drawing.Size(65, 13);
            this.labelValueB.TabIndex = 1;
            this.labelValueB.Text = "Значение В";
            // 
            // textBoxValueA
            // 
            this.textBoxValueA.Location = new System.Drawing.Point(90, 6);
            this.textBoxValueA.Name = "textBoxValueA";
            this.textBoxValueA.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueA.TabIndex = 2;
            // 
            // textBoxValueB
            // 
            this.textBoxValueB.Location = new System.Drawing.Point(273, 6);
            this.textBoxValueB.Name = "textBoxValueB";
            this.textBoxValueB.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueB.TabIndex = 3;
            // 
            // buttonSumma
            // 
            this.buttonSumma.Location = new System.Drawing.Point(15, 47);
            this.buttonSumma.Name = "buttonSumma";
            this.buttonSumma.Size = new System.Drawing.Size(75, 23);
            this.buttonSumma.TabIndex = 4;
            this.buttonSumma.Text = "Сумма";
            this.buttonSumma.UseVisualStyleBackColor = true;
            this.buttonSumma.Click += new System.EventHandler(this.buttonSumma_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Location = new System.Drawing.Point(115, 126);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(75, 23);
            this.buttonWork.TabIndex = 5;
            this.buttonWork.Text = "Работа";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // WinAsynchMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonSumma);
            this.Controls.Add(this.textBoxValueB);
            this.Controls.Add(this.textBoxValueA);
            this.Controls.Add(this.labelValueB);
            this.Controls.Add(this.labelValueA);
            this.Name = "WinAsynchMethod";
            this.Text = "Асинхронный запуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValueA;
        private System.Windows.Forms.Label labelValueB;
        private System.Windows.Forms.TextBox textBoxValueA;
        private System.Windows.Forms.TextBox textBoxValueB;
        private System.Windows.Forms.Button buttonSumma;
        private System.Windows.Forms.Button buttonWork;
    }
}

