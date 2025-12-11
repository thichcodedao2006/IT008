using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private const int RADIUS = 150; 
        private Point center;           
        private float secondLength = 130; 
        private float minuteLength = 100; 
        private float hourLength = 70;    
        private Pen secondPen = new Pen(Color.White, 1);
        private Pen minutePen = new Pen(Color.White, 2);
        private Pen hourPen = new Pen(Color.White, 3);
        private Brush dotBrush = new SolidBrush(Color.White);
        public Form1()
        {
            InitializeComponent();
            this.ClockPanel.Paint += panel1_Paint;
            this.ClockTime.Tick += timer1_Tick;
            center = new Point(ClockPanel.Width / 2, ClockPanel.Height / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockPanel.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            DateTime now = DateTime.Now;
            DrawClockFace(g);
            DrawHand(g, now.Hour % 12 + now.Minute / 60.0, 12, hourLength, hourPen);
            DrawHand(g, now.Minute + now.Second / 60.0, 60, minuteLength, minutePen);
            DrawHand(g, now.Second, 60, secondLength, secondPen);
            g.FillEllipse(dotBrush, center.X - 5, center.Y - 5, 10, 10);
        }

        private void DrawHand(Graphics g, double value, int maxValue, float length, Pen pen)
        {
            double angle = (value / maxValue * 360) - 90;
            double radians = angle * Math.PI / 180;
            int x = center.X + (int)(length * Math.Cos(radians));
            int y = center.Y + (int)(length * Math.Sin(radians));
            g.DrawLine(pen, center, new Point(x, y));
        }

        private void DrawClockFace(Graphics g)
        {
            for (int i = 0; i < 60; i++)
            {
                double angle = (i * 6) - 90; 
                double radians = angle * Math.PI / 180;
                int x = center.X + (int)(RADIUS * Math.Cos(radians));
                int y = center.Y + (int)(RADIUS * Math.Sin(radians));
                int size = (i % 5 == 0) ? 6 : 3;
                g.FillEllipse(dotBrush, x - size / 2, y - size / 2, size, size);
            }
        }
    }
}
