using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFont();
            rbCenter.Tag = "Center";
            rbLeft.Tag = "Left";
            rbRight.Tag = "Right";
        }

        private void LoadFont()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbbFont.Items.Add(font.Name);
            }    
        }

        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            FontStyle currentStyle = rtxbText.Font.Style;
            currentStyle ^= FontStyle.Bold;
            rtxbText.Font = new System.Drawing.Font(rtxbText.Font, currentStyle);
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            FontStyle currentStyle = rtxbText.Font.Style;
            currentStyle ^= FontStyle.Italic;   
            rtxbText.Font = new System.Drawing.Font(rtxbText.Font, currentStyle);
        }

        private void cbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            FontStyle currentStyle = rtxbText.Font.Style;
            currentStyle ^= FontStyle.Underline;    
            rtxbText.Font = new System.Drawing.Font(rtxbText.Font, currentStyle);
        }
        private void AlignChange(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if (btn.Checked)
            {
               if (btn.Tag is string txt)
                {
                    if (txt == "Left")
                    {
                        rtxbText.SelectionAlignment = HorizontalAlignment.Left;
                    } else if (txt == "Center")
                    {
                        rtxbText.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    else
                    {
                        rtxbText.SelectionAlignment = HorizontalAlignment.Right;
                    } 
                        
                }    
            }    
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                rtxbText.ForeColor = color.Color;
                ColorButton.BackColor = color.Color;
            }    
        }

        private void cbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFont.SelectedIndex != -1)
            {
                Font currentFont = rtxbText.Font;
                currentFont = new Font(cbbFont.Items[cbbFont.SelectedIndex].ToString(), currentFont.Size, currentFont.Style);
                rtxbText.Font = currentFont;
                cbbFont.Text = cbbFont.Items[cbbFont.SelectedIndex].ToString();
            }    
        }

        private void cbbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSize.SelectedIndex != -1)
            {
                Font currentFont = rtxbText.Font;
                currentFont = new Font(currentFont.FontFamily, Convert.ToInt32(cbbSize.Items[cbbSize.SelectedIndex]), currentFont.Style);
                rtxbText.Font = currentFont;
                cbbSize.Text = cbbSize.Items[cbbSize.SelectedIndex].ToString();
            }    
        }
    }
}
