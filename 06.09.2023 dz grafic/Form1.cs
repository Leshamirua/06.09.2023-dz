using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06._09._2023_dz_grafic
{
    public partial class Form1 : Form
    {
        int indexCombobox;
        Graphics graphics;
        Bitmap bitmap;
        Graphics graff; 
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(this.Width, this.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(pictureBox1.Image = bitmap);
            graphics.DrawLine(Pens.Black, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            graphics.DrawLine(Pens.Black, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);

            graff = pictureBox1.CreateGraphics();
            graff = Graphics.FromImage(pictureBox1.Image = bitmap);

            int a = 1, b = 0, c = 0;
            double x, y;
            int _x = pictureBox1.Width / 2;
            int _y = pictureBox1.Height / 2;

            Bitmap bit = new Bitmap(1, 1);
            bit.SetPixel(0, 0, Color.Blue);
            switch (indexCombobox)
            {
                case 0:
                    graff.DrawLine(Pens.Blue, 50, 378, 378, 50);
                    break;
                case 1:
                    graff.DrawLine(Pens.Blue, 50, 358, 378, 30);
                    break;
                case 2:
                    for (double i = 0; i < 100; i += 0.01)
                    {
                        x = i;
                        y = (a * (x * x)) + ((b * x) + c);
                        graff.DrawImageUnscaled(bit, _x + (int)x, _y - (int)y);
                        graff.DrawImageUnscaled(bit, _x - (int)x, _y - (int)y);
                    }
                    break;
                case 3:
                    int _x2 = 280;
                    int _y2 = 190;

                    for (double i = 0; i < 10000; i += 0.01)
                    {
                        x = i;
                        y = (a * (x * x)) + ((b * x) + c);
                        graff.DrawImageUnscaled(bit, _x2 + (int)x, _y2 - (int)y);
                        graff.DrawImageUnscaled(bit, _x2 - (int)x, _y2 - (int)y);
                    }
                    break;
                case 4:
                    for (double i = 0; i < 10000; i += 0.01)
                    {
                        x = i;
                        y = (a * (x * x)) + ((b * x) + c);
                        graff.DrawImageUnscaled(bit, _x + (int)x, _y - (int)y);
                        graff.DrawImageUnscaled(bit, _x - (int)x, _y + (int)y);
                    }
                    break;
                case 5:
                    int _x3 = pictureBox1.Width / 2;
                    int _y3 = pictureBox1.Height / 2;

                    for (double i = 0; i < 10000; i += 0.01)
                    {
                        x = i;
                        y = (a * (x * x)) + ((b * x) + c);
                        graff.DrawImageUnscaled(bit, _x3 + (int)y, _y3 - (int)x);
                    }
                    break;

                case 6:
                    Point[] points = new Point[1000];

                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 10 + pictureBox1.Height / 2));
                    }
                    graff.DrawLines(Pens.Blue, points);
                    break;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    indexCombobox = 0; break;
                case 1:
                    indexCombobox = 1; break;
                case 2:
                    indexCombobox = 2; break;
                case 3:
                    indexCombobox = 3; break;
                case 4:
                    indexCombobox = 4; break;
                case 5:
                    indexCombobox = 5; break;
                case 6:
                    indexCombobox = 6; break;
            }
        }
    }
}
