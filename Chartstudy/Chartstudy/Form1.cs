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

namespace Chartstudy
{
    public partial class Form1 : Form
    {
        double increse = 0.0;

        public Form1()
        {
            InitializeComponent();

            
            chart1.ChartAreas[0].AxisY.Maximum = 1.0;
            chart1.ChartAreas[0].AxisY.Minimum = -1.0;

            chart1.ChartAreas[0].AxisX.Maximum = 3.14*2.0;
            chart1.ChartAreas[0].AxisX.Minimum = 0.0;

        }

        private void btSin_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            

            Series aSine = new Series();

            aSine.ChartType = SeriesChartType.Line;
            aSine.Color = Color.Brown;

            

            for(double i= 0.0; i< Math.PI * 2.0; i+= 0.1)
            {
                aSine.Points.AddXY(i, Math.Sin(i));
            }

            //aSine.Points.AddXY(0.0, 0.0);
            //aSine.Points.AddXY(1.0, 1.0);
            chart1.Series.Add(aSine);

            timer1.Start();
        }

        private void btCos_Click(object sender, EventArgs e)
        {
            Series aCosine = new Series();
            aCosine.ChartType = SeriesChartType.Line;

            for(double i = 0; i<Math.PI * 2.0; i += 0.1)
            {
                aCosine.Points.AddXY(i, Math.Cos(i));
            }

            chart1.Series.Add(aCosine);

            
        }

        private void btTan_Click(object sender, EventArgs e)
        {
            Series aTan = new Series();
            aTan.ChartType = SeriesChartType.Line;

            for (double i = 0; i < Math.PI * 2.0; i += 0.1)
            {
                aTan.Points.AddXY(i, Math.Tan(i));
            }

            chart1.Series.Add(aTan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            increse += 0.1;
            chart1.Series.Clear();
            Series aSine = chart1.Series.Add("sin");
            Series aCos = chart1.Series.Add("Cos");
            aSine.ChartType = SeriesChartType.Line;
            aCos.ChartType = SeriesChartType.Line;
            for (double i = 0.0; i < Math.PI * 2.0; i += 0.1)
            {
                aSine.Points.AddXY(i, Math.Sin(i- increse));
                aCos.Points.AddXY(i, Math.Cos(i - increse));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
