using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        private Pen DrawingPen = new Pen(Color.Black, 1);
        private Color CurColor = Color.Black;
        private float curWidth = 1f;
        private Brush CurBrush;

        private Point StartPoint, EndPoint;
        private bool IsDrawing = false;
        public Form1()
        {
            InitializeComponent();
            CurBrush = new SolidBrush(Color.Green);
            rbSolid.Checked = true;
            rbSolid.Tag = "Solid";
            rbHatch.Tag = "Hatch";
            rbTexture.Tag = "Texture";
            rbLinear.Tag = "Linear";
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDrawing = true;
                StartPoint = e.Location;
                EndPoint = e.Location;
            }    
        }

        private Rectangle GetDrawingRect()
        {
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int w = Math.Abs(StartPoint.X - EndPoint.X);
            int h = Math.Abs(StartPoint.Y - EndPoint.Y);
            return new Rectangle(x, y, w, h);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                panel2.Invalidate();
                EndPoint = e.Location;
            }    
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                IsDrawing = false;
                panel2.Invalidate();    
            }    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //if (!IsDrawing) return;
            Graphics g = e.Graphics;
            Rectangle rect = GetDrawingRect();

            if (rbLine.Checked)
            {
                g.DrawLine(DrawingPen, StartPoint, EndPoint);
            } else if (rbRectangle.Checked)
            {
                g.FillRectangle(CurBrush, rect);    
            } else if (rbElipse.Checked)
            {
                g.FillEllipse(CurBrush, rect);  
            }    
        }

        private void txbWidth_TextChanged(object sender, EventArgs e)
        {
            if (DrawingPen != null) DrawingPen.Dispose();
            try
            {
                curWidth = (float)Convert.ToDouble(txbWidth.Text);
            }
            catch
            {
                curWidth = 1f;
            } 
            DrawingPen = new Pen(CurColor, curWidth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DrawingPen != null) DrawingPen.Dispose();
            ColorDialog Color = new ColorDialog();
            if (Color.ShowDialog() == DialogResult.OK)
            {
                CurColor = Color.Color;
                DrawingPen = new Pen(CurColor, curWidth);
            }    
        }

        private void txbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }    
            e.Handled = true;   
        }

        private void RadioButton_Changed(object sender, EventArgs e)
        {
            if (CurBrush != null) CurBrush.Dispose();
            RadioButton btn = (RadioButton)sender;
            Rectangle clientRect = panel2.ClientRectangle;
            if (btn.Checked)
            {
                if (btn.Tag is string tag)
                {
                    if (tag == "Solid")
                    {
                        CurBrush = new SolidBrush(Color.Green);
                    } else if (tag == "Hatch")
                    {
                        CurBrush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                    } else if (tag == "Texture")
                    {
                        Bitmap bitmap = Properties.Resources.Texture;
                        CurBrush = new TextureBrush(bitmap);
                    } else if (tag == "Linear")
                    {
                        CurBrush = new LinearGradientBrush(clientRect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                    }    
                }    
            }    
        }


    }
}
