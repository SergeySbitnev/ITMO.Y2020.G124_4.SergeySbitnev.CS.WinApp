namespace ITMO.CS.WinApp.ExamWork.IntersectionPoint
{
    partial class IntersectionPoint
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
            this.groupBoxSegmentAB = new System.Windows.Forms.GroupBox();
            this.labelSegmentABy = new System.Windows.Forms.Label();
            this.labelSegmentABx = new System.Windows.Forms.Label();
            this.textBoxPointBy = new System.Windows.Forms.TextBox();
            this.textBoxPointBx = new System.Windows.Forms.TextBox();
            this.textBoxPointAy = new System.Windows.Forms.TextBox();
            this.textBoxPointAx = new System.Windows.Forms.TextBox();
            this.labelPointB = new System.Windows.Forms.Label();
            this.labelPointA = new System.Windows.Forms.Label();
            this.groupBoxSegmentCD = new System.Windows.Forms.GroupBox();
            this.labelSegmentCDy = new System.Windows.Forms.Label();
            this.labelSegmentCDx = new System.Windows.Forms.Label();
            this.textBoxPointDy = new System.Windows.Forms.TextBox();
            this.textBoxPointDx = new System.Windows.Forms.TextBox();
            this.textBoxPointCy = new System.Windows.Forms.TextBox();
            this.textBoxPointCx = new System.Windows.Forms.TextBox();
            this.labelPointD = new System.Windows.Forms.Label();
            this.labelPointC = new System.Windows.Forms.Label();
            this.buttonSearchIntersectionPoint = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxSegmentAB.SuspendLayout();
            this.groupBoxSegmentCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSegmentAB
            // 
            this.groupBoxSegmentAB.Controls.Add(this.labelSegmentABy);
            this.groupBoxSegmentAB.Controls.Add(this.labelSegmentABx);
            this.groupBoxSegmentAB.Controls.Add(this.textBoxPointBy);
            this.groupBoxSegmentAB.Controls.Add(this.textBoxPointBx);
            this.groupBoxSegmentAB.Controls.Add(this.textBoxPointAy);
            this.groupBoxSegmentAB.Controls.Add(this.textBoxPointAx);
            this.groupBoxSegmentAB.Controls.Add(this.labelPointB);
            this.groupBoxSegmentAB.Controls.Add(this.labelPointA);
            this.groupBoxSegmentAB.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSegmentAB.Name = "groupBoxSegmentAB";
            this.groupBoxSegmentAB.Size = new System.Drawing.Size(204, 108);
            this.groupBoxSegmentAB.TabIndex = 0;
            this.groupBoxSegmentAB.TabStop = false;
            this.groupBoxSegmentAB.Text = "Отрезок AB";
            // 
            // labelSegmentABy
            // 
            this.labelSegmentABy.AutoSize = true;
            this.labelSegmentABy.Location = new System.Drawing.Point(143, 18);
            this.labelSegmentABy.Name = "labelSegmentABy";
            this.labelSegmentABy.Size = new System.Drawing.Size(12, 13);
            this.labelSegmentABy.TabIndex = 7;
            this.labelSegmentABy.Text = "y";
            // 
            // labelSegmentABx
            // 
            this.labelSegmentABx.AutoSize = true;
            this.labelSegmentABx.Location = new System.Drawing.Point(87, 18);
            this.labelSegmentABx.Name = "labelSegmentABx";
            this.labelSegmentABx.Size = new System.Drawing.Size(12, 13);
            this.labelSegmentABx.TabIndex = 6;
            this.labelSegmentABx.Text = "x";
            // 
            // textBoxPointBy
            // 
            this.textBoxPointBy.Location = new System.Drawing.Point(124, 61);
            this.textBoxPointBy.Name = "textBoxPointBy";
            this.textBoxPointBy.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointBy.TabIndex = 5;
            // 
            // textBoxPointBx
            // 
            this.textBoxPointBx.Location = new System.Drawing.Point(68, 61);
            this.textBoxPointBx.Name = "textBoxPointBx";
            this.textBoxPointBx.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointBx.TabIndex = 4;
            // 
            // textBoxPointAy
            // 
            this.textBoxPointAy.Location = new System.Drawing.Point(124, 35);
            this.textBoxPointAy.Name = "textBoxPointAy";
            this.textBoxPointAy.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointAy.TabIndex = 3;
            // 
            // textBoxPointAx
            // 
            this.textBoxPointAx.Location = new System.Drawing.Point(68, 35);
            this.textBoxPointAx.Name = "textBoxPointAx";
            this.textBoxPointAx.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointAx.TabIndex = 2;
            // 
            // labelPointB
            // 
            this.labelPointB.AutoSize = true;
            this.labelPointB.Location = new System.Drawing.Point(14, 64);
            this.labelPointB.Name = "labelPointB";
            this.labelPointB.Size = new System.Drawing.Size(47, 13);
            this.labelPointB.TabIndex = 1;
            this.labelPointB.Text = "Точка B";
            // 
            // labelPointA
            // 
            this.labelPointA.AutoSize = true;
            this.labelPointA.Location = new System.Drawing.Point(14, 38);
            this.labelPointA.Name = "labelPointA";
            this.labelPointA.Size = new System.Drawing.Size(47, 13);
            this.labelPointA.TabIndex = 0;
            this.labelPointA.Text = "Точка A";
            // 
            // groupBoxSegmentCD
            // 
            this.groupBoxSegmentCD.Controls.Add(this.labelSegmentCDy);
            this.groupBoxSegmentCD.Controls.Add(this.labelSegmentCDx);
            this.groupBoxSegmentCD.Controls.Add(this.textBoxPointDy);
            this.groupBoxSegmentCD.Controls.Add(this.textBoxPointDx);
            this.groupBoxSegmentCD.Controls.Add(this.textBoxPointCy);
            this.groupBoxSegmentCD.Controls.Add(this.textBoxPointCx);
            this.groupBoxSegmentCD.Controls.Add(this.labelPointD);
            this.groupBoxSegmentCD.Controls.Add(this.labelPointC);
            this.groupBoxSegmentCD.Location = new System.Drawing.Point(222, 12);
            this.groupBoxSegmentCD.Name = "groupBoxSegmentCD";
            this.groupBoxSegmentCD.Size = new System.Drawing.Size(204, 108);
            this.groupBoxSegmentCD.TabIndex = 1;
            this.groupBoxSegmentCD.TabStop = false;
            this.groupBoxSegmentCD.Text = "Отрезок CD";
            // 
            // labelSegmentCDy
            // 
            this.labelSegmentCDy.AutoSize = true;
            this.labelSegmentCDy.Location = new System.Drawing.Point(143, 18);
            this.labelSegmentCDy.Name = "labelSegmentCDy";
            this.labelSegmentCDy.Size = new System.Drawing.Size(12, 13);
            this.labelSegmentCDy.TabIndex = 7;
            this.labelSegmentCDy.Text = "y";
            // 
            // labelSegmentCDx
            // 
            this.labelSegmentCDx.AutoSize = true;
            this.labelSegmentCDx.Location = new System.Drawing.Point(87, 18);
            this.labelSegmentCDx.Name = "labelSegmentCDx";
            this.labelSegmentCDx.Size = new System.Drawing.Size(12, 13);
            this.labelSegmentCDx.TabIndex = 6;
            this.labelSegmentCDx.Text = "x";
            // 
            // textBoxPointDy
            // 
            this.textBoxPointDy.Location = new System.Drawing.Point(124, 61);
            this.textBoxPointDy.Name = "textBoxPointDy";
            this.textBoxPointDy.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointDy.TabIndex = 5;
            // 
            // textBoxPointDx
            // 
            this.textBoxPointDx.Location = new System.Drawing.Point(68, 61);
            this.textBoxPointDx.Name = "textBoxPointDx";
            this.textBoxPointDx.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointDx.TabIndex = 4;
            // 
            // textBoxPointCy
            // 
            this.textBoxPointCy.Location = new System.Drawing.Point(124, 35);
            this.textBoxPointCy.Name = "textBoxPointCy";
            this.textBoxPointCy.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointCy.TabIndex = 3;
            // 
            // textBoxPointCx
            // 
            this.textBoxPointCx.Location = new System.Drawing.Point(68, 35);
            this.textBoxPointCx.Name = "textBoxPointCx";
            this.textBoxPointCx.Size = new System.Drawing.Size(50, 20);
            this.textBoxPointCx.TabIndex = 2;
            // 
            // labelPointD
            // 
            this.labelPointD.AutoSize = true;
            this.labelPointD.Location = new System.Drawing.Point(14, 64);
            this.labelPointD.Name = "labelPointD";
            this.labelPointD.Size = new System.Drawing.Size(48, 13);
            this.labelPointD.TabIndex = 1;
            this.labelPointD.Text = "Точка D";
            // 
            // labelPointC
            // 
            this.labelPointC.AutoSize = true;
            this.labelPointC.Location = new System.Drawing.Point(14, 38);
            this.labelPointC.Name = "labelPointC";
            this.labelPointC.Size = new System.Drawing.Size(47, 13);
            this.labelPointC.TabIndex = 0;
            this.labelPointC.Text = "Точка C";
            // 
            // buttonSearchIntersectionPoint
            // 
            this.buttonSearchIntersectionPoint.Location = new System.Drawing.Point(12, 127);
            this.buttonSearchIntersectionPoint.Name = "buttonSearchIntersectionPoint";
            this.buttonSearchIntersectionPoint.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchIntersectionPoint.TabIndex = 2;
            this.buttonSearchIntersectionPoint.Text = "Поиск";
            this.buttonSearchIntersectionPoint.UseVisualStyleBackColor = true;
            this.buttonSearchIntersectionPoint.Click += new System.EventHandler(this.buttonSearchIntersectionPoint_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(174, 126);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(255, 126);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(12, 171);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(0, 13);
            this.labelAnswer.TabIndex = 6;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(93, 127);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // IntersectionPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 213);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearchIntersectionPoint);
            this.Controls.Add(this.groupBoxSegmentCD);
            this.Controls.Add(this.groupBoxSegmentAB);
            this.MaximizeBox = false;
            this.Name = "IntersectionPoint";
            this.Text = "Intersection Point";
            this.groupBoxSegmentAB.ResumeLayout(false);
            this.groupBoxSegmentAB.PerformLayout();
            this.groupBoxSegmentCD.ResumeLayout(false);
            this.groupBoxSegmentCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSegmentAB;
        private System.Windows.Forms.TextBox textBoxPointAy;
        private System.Windows.Forms.TextBox textBoxPointAx;
        private System.Windows.Forms.Label labelPointB;
        private System.Windows.Forms.Label labelPointA;
        private System.Windows.Forms.TextBox textBoxPointBy;
        private System.Windows.Forms.TextBox textBoxPointBx;
        private System.Windows.Forms.Label labelSegmentABy;
        private System.Windows.Forms.Label labelSegmentABx;
        private System.Windows.Forms.GroupBox groupBoxSegmentCD;
        private System.Windows.Forms.Label labelSegmentCDy;
        private System.Windows.Forms.Label labelSegmentCDx;
        private System.Windows.Forms.TextBox textBoxPointDy;
        private System.Windows.Forms.TextBox textBoxPointDx;
        private System.Windows.Forms.TextBox textBoxPointCy;
        private System.Windows.Forms.TextBox textBoxPointCx;
        private System.Windows.Forms.Label labelPointD;
        private System.Windows.Forms.Label labelPointC;
        private System.Windows.Forms.Button buttonSearchIntersectionPoint;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelAnswer;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonClear;
    }
}

