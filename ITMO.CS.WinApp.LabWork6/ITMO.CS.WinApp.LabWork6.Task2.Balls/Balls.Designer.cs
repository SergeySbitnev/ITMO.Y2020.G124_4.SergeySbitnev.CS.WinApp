namespace ITMO.CS.WinApp.LabWork6.Task2.Balls
{
    partial class Balls
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
            this.timerBalls = new System.Windows.Forms.Timer(this.components);
            this.checkBoxGo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timerBalls
            // 
            this.timerBalls.Enabled = true;
            this.timerBalls.Interval = 10;
            this.timerBalls.Tick += new System.EventHandler(this.timerBalls_Tick);
            // 
            // checkBoxGo
            // 
            this.checkBoxGo.AutoSize = true;
            this.checkBoxGo.Location = new System.Drawing.Point(13, 13);
            this.checkBoxGo.Name = "checkBoxGo";
            this.checkBoxGo.Size = new System.Drawing.Size(42, 17);
            this.checkBoxGo.TabIndex = 0;
            this.checkBoxGo.Text = "GO";
            this.checkBoxGo.UseVisualStyleBackColor = true;
            this.checkBoxGo.CheckedChanged += new System.EventHandler(this.checkBoxGo_CheckedChanged);
            // 
            // Balls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxGo);
            this.Name = "Balls";
            this.Text = "Balls";
            this.Load += new System.EventHandler(this.Balls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerBalls;
        private System.Windows.Forms.CheckBox checkBoxGo;
    }
}

