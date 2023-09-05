using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MPE.Classes;
using MTP;

namespace MPE
{
    public partial class DrawingForm : Form
    {
        public Button taskButton;
        public Task1 solver;
        public Task2Solver task2;
        public DrawingForm(Button taskButton, InputHelper inputHelper)
        {
            this.taskButton = taskButton;
            solver = new Task1(inputHelper);
            task2 = new Task2Solver(inputHelper);
            InitializeComponent();
        }
        public void Draw1(Chart chart1, Chart chart2)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            double[] tValues = { 0, 2, 5, 20, 75, 200 }; //Фиксируем t, x = z, y = f(x,t)
            for(int i = 0; i < 6; ++i)
            {
                chart1.Series[i].LegendText = string.Format("t = {0}", tValues[i]);
                double a = 0, b = solver.lx / 2, h = 0.1, x, y; // 0 < z < 5
                chart1.Series[i].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = solver.GetFunctionValue(x, tValues[i]);
                    chart1.Series[i].Points.AddXY(x, y);
                    x += h;
                }
            }
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            double[] zValues = { 0, 1, 2, 3, 4, 5 }; //Фиксируем z, x = t, y = f(z,x)
            for (int i = 0; i < 6; ++i)
            {
                chart2.Series[i].LegendText = string.Format("z = {0}", zValues[i]);
                double a = 0, b = solver.T, h = 0.1, x, y; // 0 < t < 200
                chart2.Series[i].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = solver.GetFunctionValue(zValues[i], x);
                    chart2.Series[i].Points.AddXY(x, y);
                    x += h;
                }
            }
        }

        public void Draw2(Chart chart1, Chart chart2)
        {
            var valuesForT = new List<double> { 0.01, 2, 5, 20, 75, 200 };
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            for (int i = 0; i < valuesForT.Count; ++i)
            {
                chart1.Series[i].LegendText = string.Format("t = {0}", valuesForT[i]);
                double a = 0, b = task2.GetLy(), h = 0.01, x, y;
                chart1.Series[i].Points.Clear();
                x = a;
                task2.SetT(valuesForT[i]);
                while (x <= b)
                {
                    task2.SetY(x);
                    y = task2.GetPartialSum();
                    chart1.Series[i].Points.AddXY(x, y);    
                    x += h;
                }
            }
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            var valuesForY = new List<double> {2.8, 1, 2, 3, 4, 5};
            for (int i = 0; i < valuesForY.Count; ++i)
            {
                chart2.Series[i].LegendText = string.Format("y = {0}", valuesForY[i]);
                double a = 0, b = task2.GetTr(), h=0.1, x, y;
                chart2.Series[i].Points.Clear();
                x = a;
                task2.SetY(valuesForY[i]);
                while (x <= b)
                {
                    task2.SetT(x);
                    y = task2.GetPartialSum();
                    chart2.Series[i].Points.AddXY(x, y);
                    x+=h;
                }
            }
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Axis ax = new Axis
            {
                Title = "Время t, c"
            };
            chart2.ChartAreas[0].AxisX = ax;
            string temp, coord;
            if (taskButton.Text == " 2 подзадача")
            {
                temp = "Температура w, °C";
                coord = "Координата y, см";
            }
            else
            {
                temp = "Температура v, °C";
                coord = "Координата z, см";
            }
            Axis ay = new Axis
            {
                Title = temp
            };
            ay.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            ax.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            chart2.ChartAreas[0].AxisY = ay;
            Axis ax2 = new Axis
            {
                Title = coord
            };
            ax2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            chart1.ChartAreas[0].AxisX = ax2;
            chart1.ChartAreas[0].AxisY = ay;
            if (taskButton.Text == " 2 подзадача")
            {
                Draw2(chart1, chart2);
            }
            else 
            {
                Draw1(chart1, chart2);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
