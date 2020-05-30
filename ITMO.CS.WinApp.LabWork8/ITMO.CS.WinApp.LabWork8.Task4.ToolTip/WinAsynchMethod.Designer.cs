namespace ITMO.CS.WinApp.LabWork8.Task4.ToolTip
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
            this.components = new System.ComponentModel.Container();
            this.labelValueA = new System.Windows.Forms.Label();
            this.labelValueB = new System.Windows.Forms.Label();
            this.textBoxValueA = new System.Windows.Forms.TextBox();
            this.textBoxValueB = new System.Windows.Forms.TextBox();
            this.buttonSumma = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.helpProvider1.SetHelpString(this.textBoxValueA, "For input integer A");
            this.textBoxValueA.Location = new System.Drawing.Point(90, 6);
            this.textBoxValueA.Name = "textBoxValueA";
            this.helpProvider1.SetShowHelp(this.textBoxValueA, true);
            this.textBoxValueA.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueA.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxValueA, "For input integer A");
            // 
            // textBoxValueB
            // 
            this.helpProvider1.SetHelpString(this.textBoxValueB, "For input integer B");
            this.textBoxValueB.Location = new System.Drawing.Point(273, 6);
            this.textBoxValueB.Name = "textBoxValueB";
            this.helpProvider1.SetShowHelp(this.textBoxValueB, true);
            this.textBoxValueB.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueB.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxValueB, "For input integer B");
            // 
            // buttonSumma
            // 
            this.helpProvider1.SetHelpString(this.buttonSumma, "Sum");
            this.buttonSumma.Location = new System.Drawing.Point(15, 47);
            this.buttonSumma.Name = "buttonSumma";
            this.helpProvider1.SetShowHelp(this.buttonSumma, true);
            this.buttonSumma.Size = new System.Drawing.Size(75, 23);
            this.buttonSumma.TabIndex = 4;
            this.buttonSumma.Text = "Сумма";
            this.toolTip1.SetToolTip(this.buttonSumma, "Sum");
            this.buttonSumma.UseVisualStyleBackColor = true;
            this.buttonSumma.Click += new System.EventHandler(this.buttonSumma_Click);
            // 
            // buttonWork
            // 
            this.helpProvider1.SetHelpString(this.buttonWork, "Start work");
            this.buttonWork.Location = new System.Drawing.Point(115, 126);
            this.buttonWork.Name = "buttonWork";
            this.helpProvider1.SetShowHelp(this.buttonWork, true);
            this.buttonWork.Size = new System.Drawing.Size(75, 23);
            this.buttonWork.TabIndex = 5;
            this.buttonWork.Text = "Работа";
            this.toolTip1.SetToolTip(this.buttonWork, "Start work");
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\ITMO\\CS.WinAPP\\Lab\\ITMO.CS.WinApp.LabWork8\\ITMO.CS.WinApp.LabWork8.Task4.ToolT" +
    "ip\\help.docx";
            // 
            // buttonHelp
            // 
            this.helpProvider1.SetHelpString(this.buttonHelp, "Open HelpFile");
            this.buttonHelp.Location = new System.Drawing.Point(322, 126);
            this.buttonHelp.Name = "buttonHelp";
            this.helpProvider1.SetShowHelp(this.buttonHelp, true);
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "HELP";
            this.toolTip1.SetToolTip(this.buttonHelp, "Open HelpFile");
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // WinAsynchMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonSumma);
            this.Controls.Add(this.textBoxValueB);
            this.Controls.Add(this.textBoxValueA);
            this.Controls.Add(this.labelValueB);
            this.Controls.Add(this.labelValueA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

