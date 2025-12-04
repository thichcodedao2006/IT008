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

namespace Bai04
{
    public partial class WordForm : Form
    {
        private string CurFilePath = null;
        public WordForm()
        {
            InitializeComponent();
            cbbFont.Items.Clear();  
            InstalledFontCollection install = new InstalledFontCollection();
            foreach (FontFamily font in install.Families)
            {
                string fontName = font.Name;    
                cbbFont.Items.Add(fontName);
            }
            Reset();
        }

        private void Reset()
        {
            rtxbText.Clear();
            CurFilePath = null;
            cbbFont.Text = "Tahoma";
            cbbText.Text = "14";
            rtxbText.Font = new System.Drawing.Font("Tahoma", 14f);
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            DialogResult r = font.ShowDialog();
            if (r == DialogResult.OK)
            {
                rtxbText.Font = font.Font;
                rtxbText.ForeColor = font.Color;
                cbbFont.Text = font.Font.Name;
                cbbText.Text = font.Font.Size.ToString();
            }    
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font currentFont = rtxbText.SelectionFont ?? rtxbText.Font;
            FontStyle style = currentFont.Style;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style ^ FontStyle.Bold);
            rtxbText.SelectionFont = newFont;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font currentFont = rtxbText.SelectionFont ?? rtxbText.Font;
            FontStyle style = currentFont.Style;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style ^ FontStyle.Italic);
            rtxbText.SelectionFont = newFont;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font currentFont = rtxbText.SelectionFont ?? rtxbText.Font;
            FontStyle style = currentFont.Style;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style ^ FontStyle.Underline);
            rtxbText.SelectionFont = newFont;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Tệp tin văn bản (*.txt)|*.txt|Tệp Rich Text (*.rtf)|*.rtf";
            DialogResult r = openFile.ShowDialog();
            if (r == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                CurFilePath = openFile.FileName;
                RichTextBoxStreamType streamType;
                if (openFile.FilterIndex == 2)
                {
                    streamType = RichTextBoxStreamType.RichText;
                }
                else if (openFile.FilterIndex == 1)
                {
                    streamType = RichTextBoxStreamType.PlainText;
                }
                else
                {
                    if (System.IO.Path.GetExtension(filePath).ToLower() == ".rtf")
                    {
                        streamType = RichTextBoxStreamType.RichText;
                    }
                    else
                    {
                        streamType = RichTextBoxStreamType.PlainText;
                    }
                }
                rtxbText.LoadFile(filePath, streamType);
            }    
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurFilePath == null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Tệp Rich Text (*.rtf)|*.rtf";
                DialogResult r = save.ShowDialog();
                if (r == DialogResult.OK)
                {
                    string filePath = save.FileName;
                    CurFilePath = save.FileName;
                    RichTextBoxStreamType streamType;
                    streamType = RichTextBoxStreamType.RichText;
                    rtxbText.SaveFile(filePath, streamType);
                }
            }
            else
            {
                RichTextBoxStreamType streamType = (System.IO.Path.GetExtension(CurFilePath).ToLower() == ".rtf")
                                          ? RichTextBoxStreamType.RichText
                                          : RichTextBoxStreamType.PlainText;
                rtxbText.SaveFile(CurFilePath, streamType);
                MessageBox.Show("Lưu thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r= MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (CurFilePath == null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Tệp Rich Text (*.rtf)|*.rtf";
                DialogResult r = save.ShowDialog();
                if (r == DialogResult.OK)
                {
                    string filePath = save.FileName;
                    CurFilePath = save.FileName;
                    RichTextBoxStreamType streamType;
                    streamType = RichTextBoxStreamType.RichText;
                    rtxbText.SaveFile(filePath, streamType);
                }
            }
            else
            {
                RichTextBoxStreamType streamType = (System.IO.Path.GetExtension(CurFilePath).ToLower() == ".rtf")
                                          ? RichTextBoxStreamType.RichText
                                          : RichTextBoxStreamType.PlainText;
                rtxbText.SaveFile(CurFilePath, streamType);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFont.SelectedIndex != -1)
            {
                string font = cbbFont.Items[cbbFont.SelectedIndex].ToString();
                Font currentFont = rtxbText.SelectionFont ?? rtxbText.Font;
                rtxbText.SelectionFont = new System.Drawing.Font(font, currentFont.Size, currentFont.Style);
            }
        }

        private void cbbText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbText.SelectedIndex != -1)
            {
                int Size = Convert.ToInt32(cbbText.Items[cbbText.SelectedIndex]);
                Font currentFont = rtxbText.SelectionFont ?? rtxbText.Font;
                rtxbText.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, Size, currentFont.Style);
            }
        }
    }
}
