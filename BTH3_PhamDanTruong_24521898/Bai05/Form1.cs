using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbNumber1Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char tmp = e.KeyChar;
            string txt = tb.Text;
            if (tmp == ',')
            {
                if (txt.Length == 0 || txt.IndexOf(tmp) != -1)
                {
                    e.Handled = true;
                }
            }
            else if (tmp == '-')
            {
                if (txt.IndexOf(tmp) != -1 || txt.Length > 0)
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsDigit(tmp))
            {
                if ((txt.Length > 0 && txt[0] == '0') || (txt.Length > 1 && txt[0] == '-' && txt[1] == '0')) // Ton tai so 0 dang truoc
                {
                    if (txt.IndexOf(',') == -1)
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (!Char.IsControl(tmp)) e.Handled = true;
        }

        private void txbNumber2Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char tmp = e.KeyChar;
            string txt = tb.Text;
            if (tmp == ',')
            {
                if (txt.Length == 0 || txt.IndexOf(tmp) != -1)
                {
                    e.Handled = true;
                }
            }
            else if (tmp == '-')
            {
                if (txt.IndexOf(tmp) != -1 || txt.Length > 0)
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsDigit(tmp))
            {
                if ((txt.Length > 0 && txt[0] == '0') || (txt.Length > 1 && txt[0] == '-' && txt[1] == '0')) // Ton tai so 0 dang truoc
                {
                    if (txt.IndexOf(',') == -1)
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (!Char.IsControl(tmp)) e.Handled = true;
        }

        private void txbNumber1Form1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string txt = tb.Text;
            if (txt.Length == 0)
            {
                errorProvider1.SetError(txbNumber1Form1, "Không để trống");
            }
            else errorProvider1.Clear();
        }

        private void txbNumber2Form1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string txt = tb.Text;
            if (txt.Length == 0)
            {
                errorProvider2.SetError(txbNumber2Form1, "Không để trống");
            }
            else errorProvider2.Clear();
        }

        private void btnPlusForm1_Click(object sender, EventArgs e)
        {
            string txt1 = txbNumber1Form1.Text;
            string txt2 = txbNumber2Form1.Text;
            if (txt1.Length == 0 || txt2.Length ==0)
            {
                MessageBox.Show("Không được để trống","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float num1 = Convert.ToSingle(txt1);
            float num2 = Convert.ToSingle(txt2);
            float ans = num1 + num2;
            txbAnswerForm1.Text = $"{ans}";
        }

        private void btnMinusForm1_Click(object sender, EventArgs e)
        {
            string txt1 = txbNumber1Form1.Text;
            string txt2 = txbNumber2Form1.Text;
            if (txt1.Length == 0 || txt2.Length == 0)
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float num1 = Convert.ToSingle(txt1);
            float num2 = Convert.ToSingle(txt2);
            float ans = num1 - num2;
            txbAnswerForm1.Text = $"{ans}";
        }

        private void btnMulForm1_Click(object sender, EventArgs e)
        {
            string txt1 = txbNumber1Form1.Text;
            string txt2 = txbNumber2Form1.Text;
            if (txt1.Length == 0 || txt2.Length == 0)
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float num1 = Convert.ToSingle(txt1);
            float num2 = Convert.ToSingle(txt2);
            float ans = num1 * num2;
            txbAnswerForm1.Text = $"{ans}";
        }

        private void btnDivideForm1_Click(object sender, EventArgs e)
        {
            string txt1 = txbNumber1Form1.Text;
            string txt2 = txbNumber2Form1.Text;
            if (txt1.Length == 0 || txt2.Length == 0)
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float num1 = Convert.ToSingle(txt1);
            float num2 = Convert.ToSingle(txt2);
            if (num2==0)
            {
                MessageBox.Show("Lỗi","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                float ans = num1 / num2;
                txbAnswerForm1.Text = $"{ans}";
            }    
        }
    }
}
