using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txbSource.Text = fbd.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txbDes.Text = fbd.SelectedPath;
                }
            }
        }
        private async void btnCopy_Click(object sender, EventArgs e)
        {
            string sourcePath = txbSource.Text;
            string targetPath = txbDes.Text;
            if (!Directory.Exists(sourcePath) || !Directory.Exists(targetPath))
            {
                MessageBox.Show("Đường dẫn nguồn hoặc đích không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnCopy.Enabled = false;
            progressBar1.Value = 0;
            string[] files = Directory.GetFiles(sourcePath);
            int totalFiles = files.Length;
            if (totalFiles == 0)
            {
                lbStatus.Text = "Không có tệp tin nào trong thư mục nguồn.";
                btnCopy.Enabled = true;
                return;
            }
            for (int i = 0; i < totalFiles; i++)
            {
                string sourceFile = files[i];
                string fileName = Path.GetFileName(sourceFile);
                string targetFile = Path.Combine(targetPath, fileName);
                lbStatus.Text = $"Đang sao chép: {sourceFile}";
                await Task.Run(() => File.Copy(sourceFile, targetFile, true));
                int progressPercentage = (int)(((double)(i + 1) / totalFiles) * 100);
                progressBar1.Value = progressPercentage;
            }
            lbStatus.Text = $"Hoàn tất sao chép {totalFiles} tệp tin.";
            btnCopy.Enabled = true; 
        }
    }
}
