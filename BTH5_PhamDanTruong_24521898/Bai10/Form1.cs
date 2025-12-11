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

namespace Bai10
{
    public partial class Form1 : Form
    {
        private int x1, x2, y1, y2;
        private Pen DrawingPen = new Pen(Color.Red, 10f);
        Random random = new Random();   

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            x1 = random.Next(0, 300);
            x2 = random.Next(0, 300);
            y1 = random.Next(0, 400);
            y2 = random.Next(0, 400);
            g.DrawLine(DrawingPen, x1,y1,x2,y2);
        }

        private void UpdatePen(object sender, EventArgs e)
        {

        }

        private void cbbDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDashStyle.SelectedIndex != -1)
            {
                string dashStyleName = cbbDashStyle.Items[cbbDashStyle.SelectedIndex].ToString();
                DrawingPen.DashStyle = (DashStyle)Enum.Parse(typeof (DashStyle), dashStyleName);
                panel2.Invalidate();
            }    
        }

        private void cbbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbWidth.SelectedIndex != -1)
            {
                float width = (float)Convert.ToDouble(cbbWidth.Items[cbbWidth.SelectedIndex].ToString());
                DrawingPen.Width = width;
                panel2.Invalidate();
            }    
        }

        private void cbbLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLineJoin.SelectedIndex != -1)
            {
                string linejoinName = cbbLineJoin.Items[cbbLineJoin.SelectedIndex].ToString();
                DrawingPen.LineJoin = (LineJoin)Enum.Parse(typeof (LineJoin), linejoinName);
                panel2.Invalidate();
            }    
        }

        private void cbbDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDashCap.SelectedIndex != -1)
            {
                string dashcapName = cbbDashCap.Items[cbbDashCap.SelectedIndex].ToString();
                DrawingPen.DashCap = (DashCap)Enum.Parse(typeof(DashCap), dashcapName);
                panel2.Invalidate();
            }
        }

        private void cbbStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStartCap.SelectedIndex != -1)
            {
                string startcapName = cbbStartCap.Items[cbbStartCap.SelectedIndex].ToString();  
                DrawingPen.StartCap = (LineCap)Enum.Parse(typeof(LineCap), startcapName);
                panel2.Invalidate();
            }    
        }

        private void cbbEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbEndCap.SelectedIndex != -1)
            {
                string endcapName = cbbEndCap.Items[cbbEndCap.SelectedIndex].ToString();
                DrawingPen.EndCap = (LineCap)Enum.Parse(typeof(LineCap), endcapName);
                panel2.Invalidate();
            }    
        }

        public Form1()
        {
            InitializeComponent();
            LoadPenOptions();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadPenOptions()
        {
            cbbDashStyle.DataSource = Enum.GetNames(typeof(DashStyle));
            cbbDashStyle.SelectedItem = "DashDot"; 
            cbbLineJoin.DataSource = Enum.GetNames(typeof(LineJoin));
            cbbLineJoin.SelectedItem = "Round"; 
            cbbDashCap.DataSource = Enum.GetNames(typeof(DashCap));
            cbbDashCap.SelectedItem = "Triangle";
            string[] lineCapNames = Enum.GetNames(typeof(LineCap));
            cbbStartCap.DataSource = new BindingSource(lineCapNames, null);
            cbbEndCap.DataSource = new BindingSource(lineCapNames, null);
            cbbStartCap.SelectedItem = "Triangle";
            cbbEndCap.SelectedItem = "RoundAnchor";
        }
    }
}
