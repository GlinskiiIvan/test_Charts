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
            graphics.DrawString("Y", new Font("10_IC_1", 12), Brushes.Black, width / 2 + 10, 0);
            graphics.DrawString("X", new Font("10_IC_1", 12), Brushes.Black, width-15, height / 2 + 10); //width, height / 2


            // Координатная сетка и отметки на координатных осях
            int lx = -width / 20;
            for (int i = 10; i < width; i += 10)
            {
                graphics.DrawLine(new Pen(Color.Black, 2), 0+i, height/2-5, 0+i, height/2+5); // метка на оси OX
                //graphics.DrawString(lx.ToString(), new Font("10_IC_1", 7), Brushes.Black, 0 + i -5, height / 2 + 5); // подписи меток
                //graphics.DrawLine(new Pen(Color.Gray, 1), 0 + i, 0, 0 + i, height); // Горизонтальная линия сетки
                ++lx;
            }
            int ly = height / 20;
            for (int i = 10; i < height; i += 10)
            {
                graphics.DrawLine(new Pen(Color.Black, 2), width / 2 - 5, 0 + i, width / 2 + 5, 0 + i); // метка на оси OY
                //graphics.DrawString(ly.ToString(), new Font("10_IC_1", 7), Brushes.Black, width / 2 + 5, 0 + i - 5); // подписи меток
                //graphics.DrawLine(new Pen(Color.Gray, 1), 0, 0 + i, width, 0 + i); // Вертикальная линия сетки
                --ly;
            }

            label1.Text = width.ToString();
            label2.Text = height.ToString();
        }

        private void button_createChart_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox_chart.CreateGraphics();
            Pen pen = new Pen(Color.Red, 2);

            int width = pictureBox_chart.Width;
            int height = pictureBox_chart.Height;

            double a = Convert.ToDouble(textBox_a.Text);
            double b = Convert.ToDouble(textBox_b.Text);
            double c = Convert.ToDouble(textBox_c.Text);

            double D = (int)Math.Pow(b, 2) - 4 * a * c;

            double x0 = -(b / (2 * a));
            double y0 = -(D / (4 * a));           

            label3.Text = D.ToString() + " " + x0.ToString() + " " + y0.ToString();

            // y = x^2
            PointF[] points = new PointF[1000];
            int idx = 0;

            if (a == 0)
            {
                for (int i = -points.Length / 2; i < points.Length / 2; i++)
                {
                    points[idx] = new PointF(i + width / 2, -(float)(a * Math.Pow(i, 2) + b * i + c) + height / 2 + -(float)c*10);
                    ++idx;
                }
            } else
            {
                for (int i = -points.Length / 2; i < points.Length / 2; i++)
                {
                    //points[idx] = new Point(i + width/2 - (int)x0, -(int)Math.Pow(i, 2) / 50 + height/2 + -((int)y0));
                    //points[idx] = new PointF(i + width / 2 + (float)x0*10, -(float)Math.Pow(i, 2) / 10 + height / 2 + -(float)y0*10);
                    points[idx] = new PointF(i + width / 2 + (float)x0 * 10, -(float)(a * Math.Pow(i, 2) + b * i + c) / 10 + height / 2 + -(float)y0 * 10);

                    ++idx;
                }
            }

            graphics.DrawLines(pen, points);
        }
    }
}
