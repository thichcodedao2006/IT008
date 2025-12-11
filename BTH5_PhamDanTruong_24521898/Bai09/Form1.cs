using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 200;
            int y = 200;
            int w = 200;
            int h = 150;
            Pen pen = new Pen(Color.DarkBlue, 3);
            Brush brush = new SolidBrush(Color.Maroon);
            string choice = comboBox1.SelectedItem.ToString();
            switch (choice)
            {
                case "Circle":
                    g.DrawEllipse(pen, x, y, 150, 150);
                    break;

                case "Square":
                    g.DrawRectangle(pen, x, y, 150, 150);
                    break;

                case "Ellipse":
                    g.DrawEllipse(pen, x, y, w, h);
                    break;

                case "Pie":
                    g.DrawPie(pen, x, y, w, h, 0, 180);
                    break;

                case "Filled Circle":
                    g.FillEllipse(brush, x, y, 150, 150);
                    break;

                case "Filled Square":
                    g.FillRectangle(brush, x, y, 150, 150);
                    break;

                case "Filled Ellipse":
                    g.FillEllipse(brush, x, y, w, h);
                    break;

                case "Filled Pie":
                    g.FillPie(brush, x, y, w, h, 0, 180);
                    break;
            }
        }
    }
}
