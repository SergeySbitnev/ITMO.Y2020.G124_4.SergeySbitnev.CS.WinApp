using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ITMO.CS.WinApp.LabWork6.Task3.WindowsFormsChart
{
    public partial class WindowsFormsChart : Form
    {
        static int k = 10;
        Dat d1 = new Dat(k);

        public WindowsFormsChart()
        {
            InitializeComponent();

            for (int step = 1; step <= k; step++)
            {
                chart1.Series["Series1"].Points.AddXY(step, d1.random(10));
            }

            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].LegendText = "Ветер м/с";
        }

        public void chartPlot(int d, string leg)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int step = 1; step <= k; step++)
            {
                chart1.Series["Series1"].Points.AddXY(step, d1.random(d));
            }

            if (checkBoxColumnSpline.Checked == true)
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            }
            else
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Spline;
            }
            
                      
            
            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].LegendText = leg;
        }

        private void radioButtonHumidity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHumidity.Checked == true)
            {
                chartPlot(100, "Влажность");
            }
        }

        private void radioButtonTemperature_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTemperature.Checked == true)
            {
                chartPlot(30, "Температура");
            }
        }
    }
}
