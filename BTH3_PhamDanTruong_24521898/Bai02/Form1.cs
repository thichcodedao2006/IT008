using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = rand.Next(0, this.ClientSize.Width - 100);
            int y = rand.Next(0, this.ClientSize.Height - 100);
            Point point = new Point(x, y);
            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

            string textToDraw = "Paint Event";

            using (Font drawFont = new Font("Arial", 20, FontStyle.Bold))
            using (SolidBrush drawBrush = new SolidBrush(randomColor))
            {
                g.DrawString(textToDraw, drawFont, drawBrush, point);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            btnDrawForm1.Left = (this.ClientSize.Width - btnDrawForm1.Width) / 2;
            btnDrawForm1.Top = (this.ClientSize.Height - btnDrawForm1.Height) / 2;  
        }

        private void btnDrawForm1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
