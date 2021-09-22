using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCharts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button_createChart_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox_chart.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            // Размеры области построения графика
            int width = pictureBox_chart.Width;
            int height = pictureBox_chart.Height;

            // Получение коэффициентов квадратного уравнения
            double a = Convert.ToDouble(textBox_a.Text);
            double b = Convert.ToDouble(textBox_b.Text);
            double c = Convert.ToDouble(textBox_c.Text);

            // Дискрименань
            double D = (int)Math.Pow(b, 2) - 4 * a * c;

            // Вершина графика
            double x0 = -(b / (2 * a));
            double y0 = -(D / (4 * a));

            // Вывод информации о параболе
            textBox_info.Text = "";
            if(a != 0)
            {
                textBox_info.Text += "Дискрименант равен: " + D.ToString();
                textBox_info.Text += Environment.NewLine;
                textBox_info.Text += Environment.NewLine;
                textBox_info.Text += "Вершина параболы:";
                textBox_info.Text += Environment.NewLine;
                textBox_info.Text += "x0: " + x0.ToString();
                textBox_info.Text += Environment.NewLine;
                textBox_info.Text += "y0: " + y0.ToString();
                textBox_info.Text += Environment.NewLine;
            }
            
            // Расчет точек графика
            PointF[] points = new PointF[1000];
            int idx = 0;

            if (a == 0)
            {
                for (int i = -points.Length / 2; i < points.Length / 2; i++)
                {
                    points[idx] = new PointF(i + width / 2, -(float)(b * i + c) + height / 2 + -(float)(c*20-c));
                    ++idx;
                }
            } else
            {
                for (int i = -points.Length / 2; i < points.Length / 2; i++)
                {
                    points[idx] = new PointF(i + width / 2 + (float)x0 * 20, -(float)(a * Math.Pow(i, 2) + b * i + c) / 38 + height / 2 + -(float)y0 * 20);
                    ++idx;
                }
            }

            // Отрисовка графика
            graphics.DrawLines(pen, points);
        }

        private void pictureBox_chart_Layout(object sender, LayoutEventArgs e)
        {
            Graphics graphics = pictureBox_chart.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            // Размеры области построения графика
            int width = pictureBox_chart.Width;
            int height = pictureBox_chart.Height;

            // Координатные оси
            graphics.DrawLine(pen, width / 2, 0, width / 2, height);
            graphics.DrawLine(pen, 0, height / 2, width, height / 2);

            // Стрелки координатных осей
            graphics.DrawLine(pen, width / 2, 0, width / 2 + 5, 10);
            graphics.DrawLine(pen, width / 2, 0, width / 2 - 5, 10);
            graphics.DrawLine(pen, width, height / 2, width - 10, height / 2 + 5);
            graphics.DrawLine(pen, width, height / 2, width - 10, height / 2 - 5);

            // Подписи координатных осей
            graphics.DrawString("Y", new Font("10_IC_1", 12), Brushes.Black, width / 2 + 10, -5);
            graphics.DrawString("X", new Font("10_IC_1", 12), Brushes.Black, width - 15, height / 2 + 10); //width, height / 2


            // Координатная сетка и отметки на координатных осях
            int lx = -width / 40 + 1;
            for (int i = 20; i < width - 20; i += 20)
            {
                if (lx != 0)
                {
                    graphics.DrawLine(new Pen(Color.Gray, 1), 0 + i + 10, 0, 0 + i + 10, height); // Горизонтальная линия сетки
                    graphics.DrawString(lx.ToString(), new Font("10_IC_1", 8, FontStyle.Bold), Brushes.Black, 0 + i + 5, height / 2 + 5); // подписи меток
                }
                graphics.DrawLine(new Pen(Color.Black, 2), 0 + i + 10, height / 2 - 5, 0 + i + 10, height / 2 + 5); // метка на оси OX

                ++lx;
            }

            int ly = height / 40 - 1;
            for (int i = 20; i < height; i += 20)
            {
                if (ly != 0)
                {
                    graphics.DrawLine(new Pen(Color.Gray, 1), 0, 0 + i, width, 0 + i); // Вертикальная линия сетки
                    graphics.DrawString(ly.ToString(), new Font("10_IC_1", 8, FontStyle.Bold), Brushes.Black, width / 2 + 5, 0 + i - 5); // подписи меток
                }
                graphics.DrawLine(new Pen(Color.Black, 2), width / 2 - 5, 0 + i, width / 2 + 5, 0 + i); // метка на оси OY

                --ly;
            }
        }
    }
}
