using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        private Form2 f;
        public Form1()
        {
            InitializeComponent();
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Text = "Đây là Constructor của Form.";
            flpanelTextForm1.Controls.Add(lb);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Text = "Đây là sự kiện Load của Form.";
            flpanelTextForm1.Controls.Add(lb);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Text = "Form đang được Activated.";
            flpanelTextForm1.Controls.Add(lb);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Text = "Đây là sự kiện Shown của Form.";
            flpanelTextForm1.Controls.Add(lb);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Label lb = new Label();
            lb.AutoSize = true;
            lb.Text = "Form đang bị Deactivate.";
            flpanelTextForm1.Controls.Add(lb);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Đây là sự kiện Form_Closing. Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r== DialogResult.No)
            {
                e.Cancel = true;
            } 

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Đây là sự kiện Form_Closed.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenChildFormForm1_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.Show();
        }

        private void btnCloseChildFormForm1_Click(object sender, EventArgs e)
        {
            try
            {
                f.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
