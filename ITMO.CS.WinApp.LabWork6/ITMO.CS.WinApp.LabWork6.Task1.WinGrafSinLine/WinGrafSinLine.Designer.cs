namespace ITMO.CS.WinApp.LabWork6.Task1.WinGrafSinLine
{
    partial class WinGrafSinLine
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
            this.groupBoxSumSin = new System.Windows.Forms.GroupBox();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.textBoxSinRight = new System.Windows.Forms.TextBox();
            this.textBoxSinLeft = new System.Windows.Forms.TextBox();
            this.labelSinEnd = new System.Windows.Forms.Label();
            this.labelSinStart = new System.Windows.Forms.Label();
            this.labelSinCenter = new System.Windows.Forms.Label();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxSumSin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSumSin
            // 
            this.groupBoxSumSin.Controls.Add(this.buttonEdit);
            this.groupBoxSumSin.Controls.Add(this.buttonPayment);
            this.groupBoxSumSin.Controls.Add(this.textBoxSinRight);
            this.groupBoxSumSin.Controls.Add(this.textBoxSinLeft);
            this.groupBoxSumSin.Controls.Add(this.labelSinEnd);
            this.groupBoxSumSin.Controls.Add(this.labelSinStart);
            this.groupBoxSumSin.Controls.Add(this.labelSinCenter);
            this.groupBoxSumSin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSumSin.Name = "groupBoxSumSin";
            this.groupBoxSumSin.Size = new System.Drawing.Size(442, 94);
            this.groupBoxSumSin.TabIndex = 0;
            this.groupBoxSumSin.TabStop = false;
            this.groupBoxSumSin.Text = "Сумма синусов";
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(351, 22);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(75, 23);
            this.buttonPayment.TabIndex = 6;
            this.buttonPayment.Text = "Расчет";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // textBoxSinRight
            // 
            this.textBoxSinRight.Location = new System.Drawing.Point(188, 22);
            this.textBoxSinRight.Name = "textBoxSinRight";
            this.textBoxSinRight.Size = new System.Drawing.Size(100, 20);
            this.textBoxSinRight.TabIndex = 5;
            // 
            // textBoxSinLeft
            // 
            this.textBoxSinLeft.Location = new System.Drawing.Point(32, 22);
            this.textBoxSinLeft.Name = "textBoxSinLeft";
            this.textBoxSinLeft.Size = new System.Drawing.Size(100, 20);
            this.textBoxSinLeft.TabIndex = 4;
            // 
            // labelSinEnd
            // 
            this.labelSinEnd.AutoSize = true;
            this.labelSinEnd.Location = new System.Drawing.Point(292, 25);
            this.labelSinEnd.Name = "labelSinEnd";
            this.labelSinEnd.Size = new System.Drawing.Size(22, 13);
            this.labelSinEnd.TabIndex = 3;
            this.labelSinEnd.Text = "* x)";
            // 
            // labelSinStart
            // 
            this.labelSinStart.AutoSize = true;
            this.labelSinStart.Location = new System.Drawing.Point(6, 25);
            this.labelSinStart.Name = "labelSinStart";
            this.labelSinStart.Size = new System.Drawing.Size(25, 13);
            this.labelSinStart.TabIndex = 1;
            this.labelSinStart.Text = "Sin(";
            // 
            // labelSinCenter
            // 
            this.labelSinCenter.AutoSize = true;
            this.labelSinCenter.Location = new System.Drawing.Point(136, 25);
            this.labelSinCenter.Name = "labelSinCenter";
            this.labelSinCenter.Size = new System.Drawing.Size(52, 13);
            this.labelSinCenter.TabIndex = 2;
            this.labelSinCenter.Text = "* x) + Sin(";
            // 
            // panelPaint
            // 
            this.panelPaint.Location = new System.Drawing.Point(12, 112);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(442, 225);
            this.panelPaint.TabIndex = 1;
            this.panelPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaint_Paint);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(9, 61);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(417, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Отдельная форма";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // WinGrafSinLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.panelPaint);
            this.Controls.Add(this.groupBoxSumSin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinGrafSinLine";
            this.Text = "WinGrafSinLine";
            this.groupBoxSumSin.ResumeLayout(false);
            this.groupBoxSumSin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSumSin;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox textBoxSinRight;
        private System.Windows.Forms.TextBox textBoxSinLeft;
        private System.Windows.Forms.Label labelSinEnd;
        private System.Windows.Forms.Label labelSinStart;
        private System.Windows.Forms.Label labelSinCenter;
        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.Button buttonEdit;
    }
}

