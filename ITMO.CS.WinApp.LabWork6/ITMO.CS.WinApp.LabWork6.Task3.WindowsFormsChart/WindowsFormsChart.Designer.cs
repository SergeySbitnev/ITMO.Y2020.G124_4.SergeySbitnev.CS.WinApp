namespace ITMO.CS.WinApp.LabWork6.Task3.WindowsFormsChart
{
    partial class WindowsFormsChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.radioButtonHumidity = new System.Windows.Forms.RadioButton();
            this.radioButtonTemperature = new System.Windows.Forms.RadioButton();
            this.checkBoxColumnSpline = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 360);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(349, 354);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.radioButtonTemperature);
            this.groupBoxParameters.Controls.Add(this.radioButtonHumidity);
            this.groupBoxParameters.Location = new System.Drawing.Point(374, 13);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(200, 86);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // radioButtonHumidity
            // 
            this.radioButtonHumidity.AutoSize = true;
            this.radioButtonHumidity.Location = new System.Drawing.Point(7, 20);
            this.radioButtonHumidity.Name = "radioButtonHumidity";
            this.radioButtonHumidity.Size = new System.Drawing.Size(81, 17);
            this.radioButtonHumidity.TabIndex = 0;
            this.radioButtonHumidity.TabStop = true;
            this.radioButtonHumidity.Text = "Влажность";
            this.radioButtonHumidity.UseVisualStyleBackColor = true;
            this.radioButtonHumidity.CheckedChanged += new System.EventHandler(this.radioButtonHumidity_CheckedChanged);
            // 
            // radioButtonTemperature
            // 
            this.radioButtonTemperature.AutoSize = true;
            this.radioButtonTemperature.Location = new System.Drawing.Point(7, 44);
            this.radioButtonTemperature.Name = "radioButtonTemperature";
            this.radioButtonTemperature.Size = new System.Drawing.Size(92, 17);
            this.radioButtonTemperature.TabIndex = 1;
            this.radioButtonTemperature.TabStop = true;
            this.radioButtonTemperature.Text = "Температура";
            this.radioButtonTemperature.UseVisualStyleBackColor = true;
            this.radioButtonTemperature.CheckedChanged += new System.EventHandler(this.radioButtonTemperature_CheckedChanged);
            // 
            // checkBoxColumnSpline
            // 
            this.checkBoxColumnSpline.AutoSize = true;
            this.checkBoxColumnSpline.Location = new System.Drawing.Point(375, 106);
            this.checkBoxColumnSpline.Name = "checkBoxColumnSpline";
            this.checkBoxColumnSpline.Size = new System.Drawing.Size(95, 17);
            this.checkBoxColumnSpline.TabIndex = 2;
            this.checkBoxColumnSpline.Text = "Column/Spline";
            this.checkBoxColumnSpline.UseVisualStyleBackColor = true;
            // 
            // WindowsFormsChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 391);
            this.Controls.Add(this.checkBoxColumnSpline);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.panel1);
            this.Name = "WindowsFormsChart";
            this.Text = "WindowsFormsChart";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.RadioButton radioButtonTemperature;
        private System.Windows.Forms.RadioButton radioButtonHumidity;
        private System.Windows.Forms.CheckBox checkBoxColumnSpline;
    }
}

