using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class CalculatorForm : Form
    {
        private decimal Number1 = 0; // So thu nhat
        private string current_operand = "."; // Phep toan
        private decimal memoryvalue = 0; // Phục vụ cho các nút liên quan memory
        bool isWaitingForSecondOperand = false; // So thu hai se duoc hien thi tren textBox
        bool EqualButton = false; // Dung de ghi de 
        public CalculatorForm()
        {
            InitializeComponent();
            txbAnswerForm.Text = "0";
        }

        // Đưa máy tính trở lại trạng thái ban đầu
        private void Reset()
        {
            Number1 = 0;
            current_operand = ".";
            isWaitingForSecondOperand = false;
            EqualButton = false;
            txbAnswerForm.Text = "0";
        }

        // Nhập các nút số (1..9) hoặc dấu thập phân
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button_Clicked = (Button)sender;
            string digit = button_Clicked.Text;
            string txt = txbAnswerForm.Text;
            if (digit == ",")
            {
                if (txt == "0" || txt.IndexOf(',') == -1)
                {
                    txbAnswerForm.Text += digit;
                }
                return;
            }
            // Neu bat dau nhap so thu nhat hoac bat dau nhap so thu hai
            if (txbAnswerForm.Text == "0" || isWaitingForSecondOperand || EqualButton)
            {
                txbAnswerForm.Text = digit;
                isWaitingForSecondOperand = false;
                EqualButton = false;
            } else
            {
                // Kiem soat do dai cua so nhap vao
                if (txt.Length == txbAnswerForm.MaxLength)
                {
                    return;
                }
                txbAnswerForm.Text += digit;
            }
        }

        // Nhập toán hạng (+, -, x, /)
        private void Opearand_Click(object sender, EventArgs e)
        {
            // Da co phep toan
            if (current_operand != "." && !isWaitingForSecondOperand)
            {
                btnEqualForm_Click(sender, e);
                EqualButton = false;    
            } else if (current_operand != "." && isWaitingForSecondOperand)
            {
                return;
            }    
            Button button_Clicked = (Button)sender;
            string operand = button_Clicked.Text;
            isWaitingForSecondOperand = true;
            current_operand = operand;
            Number1 = decimal.Parse(txbAnswerForm.Text);
            txbAnswerForm.Text = operand;
        }

        // Nhập dấu = 
        private void btnEqualForm_Click(object sender, EventArgs e)
        {
            decimal Number2 = new decimal();
            try
            {
                Number2 = decimal.Parse(txbAnswerForm.Text);
            }
            catch
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            switch (current_operand)
            {
                case "+":
                    {
                        string ans = Convert.ToString(Number1 + Number2);
                        if (ans.Length > txbAnswerForm.MaxLength)
                        {
                            Reset();
                            MessageBox.Show("The result is out of range", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        txbAnswerForm.Text = ans;
                        break;
                    }
                case "-":
                    {
                        string ans = Convert.ToString(Number1 - Number2);
                        if (ans.Length > txbAnswerForm.MaxLength)
                        {
                            Reset();
                            MessageBox.Show("The result is out of range", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        txbAnswerForm.Text = ans;
                        break;
                    }
                case "x":
                    {
                        string ans = Convert.ToString(Number1 * Number2);
                        if (ans.Length > txbAnswerForm.MaxLength)
                        {
                            Reset();
                            MessageBox.Show("The result is out of range", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        txbAnswerForm.Text = ans;
                        break;
                    }
                case "/":
                    {
                        if (Number2 == 0)
                        {
                            Reset();
                            MessageBox.Show("Error when dividing for zero", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        decimal res = Number1 / Number2;
                        string ans = res.ToString("G10");
                        txbAnswerForm.Text = ans;
                        break;
                    }
            }
            current_operand = ".";
            EqualButton = true; 
        }

        // Nhập dấu chuyển dương/ âm
        private void btnOptForm_Click(object sender, EventArgs e)
        {
            decimal tmp = new decimal();
            try
            {
                tmp = decimal.Parse(txbAnswerForm.Text);
            }
            catch
            {
                MessageBox.Show("Error","Notification",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tmp ==0)
            {
                return;
            }
            tmp = tmp * -1;
            txbAnswerForm.Text = tmp.ToString();
        }

        // Nhập dấu tính phần trăm dựa trên số hạng thứ nhất
        private void btnPerForm_Click(object sender, EventArgs e)
        {
            decimal tmp = new decimal();
            try
            {
                tmp = decimal.Parse(txbAnswerForm.Text);
            }
            catch
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tmp = (Number1 * tmp) / 100;
            txbAnswerForm.Text = tmp.ToString();
        }

        // Tính toán căn bậc hai dựa trên số hiện tại trên màn hình 
        private void btnSqrtForm_Click(object sender, EventArgs e)
        {
            decimal tmp = new decimal();
            try
            {
                tmp = decimal.Parse(txbAnswerForm.Text);
            }
            catch
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tmp < 0)
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            tmp = (decimal)Math.Sqrt((double)tmp);
            txbAnswerForm.Text = tmp.ToString();
        }

        // Tính nghịch đảo phân số dựa trên số hiện tại trên màn hình 
        private void btnPhanSoForm_Click(object sender, EventArgs e)
        {
            decimal tmp = new decimal();
            try
            {
                tmp = decimal.Parse(txbAnswerForm.Text);
            }
            catch
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tmp ==0)
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            tmp = 1 / tmp;
            txbAnswerForm.Text = tmp.ToString();
        }

        // Xóa bằng nút BackSpace
        private void btnBackSForm_Click(object sender, EventArgs e)
        {
            if (EqualButton)
            {
                return;
            }
            string txt = txbAnswerForm.Text;
            if (txt == "+" || txt == "-" || txt == "x" || txt =="/")
            {
                current_operand = ".";
                txbAnswerForm.Text = Number1.ToString();
                Number1 = 0;
                isWaitingForSecondOperand = false;
                return;
            }
            if (txt.Length==1 || txt.Length == 2 && txt[0]=='-')
            {
                txbAnswerForm.Text = "0";
            } else
            {
                txbAnswerForm.Text = txt.Remove(txt.Length-1);
            }
        }

        // Xóa bằng nút C
        private void btnCForm_Click(object sender, EventArgs e)
        {
            Reset();
        }

        // Xóa bằng nút CE
        private void btnCEForm_Click(object sender, EventArgs e)
        {
            if (EqualButton)
            {
                Reset();
                return;
            } 
                
            string txt = txbAnswerForm.Text;
            if (txt == "+" || txt == "-" || txt == "x" || txt == "/")
            {
                return;
            }
            txbAnswerForm.Text = "0";
        }

        // Nút MC 
        private void btnMCForm_Click(object sender, EventArgs e)
        {
            memoryvalue = 0;
        }

        // Nút MR
        private void btnMRForm_Click(object sender, EventArgs e)
        {
            txbAnswerForm.Text = memoryvalue.ToString();
            isWaitingForSecondOperand = false;
            EqualButton = false;
        }

        // Nút MS
        private void btnMSForm_Click(object sender, EventArgs e)
        {
            try
            {
                memoryvalue = decimal.Parse(txbAnswerForm.Text);
            }
            catch
            {
                MessageBox.Show("Error","Notification",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút M+
        private void btnMPlusForm_Click(object sender, EventArgs e)
        {
            decimal Current = new decimal();
            try
            {
                Current = decimal.Parse(txbAnswerForm.Text);
            }
            catch
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            memoryvalue += Current;
        }
    }
}
