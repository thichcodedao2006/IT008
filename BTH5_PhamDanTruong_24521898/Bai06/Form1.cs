using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllFonts();
        }

        private void ShowAllFonts()
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            int y = 10;
            foreach (FontFamily font in fonts.Families)
            {
                try
                {
                    Label lbl = new Label();
                    lbl.Text = font.Name;
                    lbl.Font = new Font(font.Name, 18, FontStyle.Regular);
                    lbl.Location = new Point(10, y);
                    lbl.AutoSize = true;

                    panel1.Controls.Add(lbl);
                    y += 40;
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
