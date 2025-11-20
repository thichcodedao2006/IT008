using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            this.BackColor = randomColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = (this.ClientSize.Height - button1.Height) / 2;    
        }
    }
}
