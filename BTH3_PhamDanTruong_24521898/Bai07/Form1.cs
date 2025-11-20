using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class MovieForm : Form
    {
        private Color DefaultColor, BlueColor, YellowColor;
        private List<Button> ListButton = new List<Button>();
        private void ChangeColor(object o)
        {
            Button btn = (Button)o;
            if (btn.BackColor == DefaultColor)
            {
                btn.BackColor = BlueColor;
            } else if (btn.BackColor == BlueColor)
            {
                btn.BackColor = DefaultColor;
            } else if (btn.BackColor == YellowColor)
            {
                MessageBox.Show("Chỗ ngồi đã có người chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnNum2Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btnNum3Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btnNum4Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn5Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn6Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn7Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn8Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn9Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn10Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn11Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn12Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn13Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn14Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private void btn15Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }

        private int Price(int numb)
        {
            switch(numb)
            {
                case 1: case 2: case 3: case 4: case 5:
                    return 5000;
                case 6: case 7: case 8: case 9: case 10:
                    return 6500;
                case 11: case 12: case 13: case 14: case 15:
                    return 8000;
            }
            return 0;
        }
        private void btnChooseForm_Click(object sender, EventArgs e)
        {
            int ToTal = 0;
            foreach (Button btn in ListButton)
            {
                if (btn.BackColor == BlueColor)
                {
                    int numb = Convert.ToInt32(btn.Text);
                    ToTal += Price(numb);
                    btn.BackColor = YellowColor;
                }
            }
           txbMoneyForm.Text = ToTal.ToString();
        }

        private void btnCancleForm_Click(object sender, EventArgs e)
        {
            foreach (Button btn in ListButton)
            {
                if (btn.BackColor == BlueColor)
                {
                    btn.BackColor = DefaultColor;
                }
            }
            txbMoneyForm.Text = "0";
        }

        private void btnEndForm_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }    
        }

        public MovieForm()
        {
            InitializeComponent();
            DefaultColor = btn10Form.BackColor;
            BlueColor = Color.FromArgb(0, 255, 255);
            YellowColor = Color.FromArgb(255, 255, 0);
            ListButton.Add(btnNum1Form);
            ListButton.Add(btnNum2Form);
            ListButton.Add(btnNum3Form);
            ListButton.Add(btnNum4Form);
            ListButton.Add(btn5Form);
            ListButton.Add(btn6Form);
            ListButton.Add(btn7Form);
            ListButton.Add(btn8Form);
            ListButton.Add(btn9Form);
            ListButton.Add(btn10Form);
            ListButton.Add(btn11Form);
            ListButton.Add(btn12Form);
            ListButton.Add(btn13Form);
            ListButton.Add(btn14Form);
            ListButton.Add(btn15Form);
        }

        private void btnNum1Form_Click(object sender, EventArgs e)
        {
            ChangeColor(sender);
        }


    }
}
