using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class ManageForm : Form
    {
        private List<TextBox> ListTextbox = new List<TextBox>();
        public ManageForm()
        {
            InitializeComponent();
            ListTextbox.Add(txbSTKForm);
            ListTextbox.Add(txbNameCusForm);
            ListTextbox.Add(txbAddressForm);
            ListTextbox.Add(txbAddressForm);
        }

        private void txbSTKForm_Leave(object sender, EventArgs e)
        {
            string txt = txbSTKForm.Text;
            if (txt.Length == 0)
            {
                errorProvider1.SetError(txbSTKForm, "Vui lòng điền đầy đủ thông tin");
            } else
            {
                errorProvider1.Clear();
            }
        }

        private void txbNameCusForm_Leave(object sender, EventArgs e)
        {
            string txt = txbNameCusForm.Text;
            if (txt.Length == 0)
            {
                errorProvider2.SetError(txbNameCusForm, "Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txbAddressForm_Leave(object sender, EventArgs e)
        {
            string txt = txbAddressForm.Text;
            if (txt.Length == 0)
            {
                errorProvider3.SetError(txbAddressForm, "Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txbMoneyAccountForm_Leave(object sender, EventArgs e)
        {
            string txt = txbMoneyAccountForm.Text;
            if (txt.Length == 0)
            {
                errorProvider4.SetError(txbMoneyAccountForm, "Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in ListTextbox)
            {
                if (txt.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            string stk = txbSTKForm.Text;
            string name = txbNameCusForm.Text;
            string address = txbAddressForm.Text;
            string money = txbMoneyAccountForm.Text;
            for (int i=0;i<(int)lvShowForm.Items.Count;i++)
            {
                if (lvShowForm.Items[i].SubItems[1].Text == stk)
                {
                    lvShowForm.Items[i].SubItems[2].Text = name;
                    lvShowForm.Items[i].SubItems[3].Text = address;
                    lvShowForm.Items[i].SubItems[4].Text = money;
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TotalMoney();
                    return;
                }
            }
            int STT = (int)lvShowForm.Items.Count + 1;
            ListViewItem item = new ListViewItem(STT.ToString());
            item.SubItems.Add(stk);
            item.SubItems.Add(name);
            item.SubItems.Add(address);
            item.SubItems.Add(money);
            lvShowForm.Items.Add(item);
            MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TotalMoney();
        }

        private void txbSTKForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;   
        }

        private void txbNameCusForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' ')
            {
                return;
            }
            e.Handled = true;
        }

        private void txbMoneyAccountForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void TotalMoney()
        {
            long totalMoney = 0;
            for (int i=0;i<(int)lvShowForm.Items.Count;i++)
            {
                totalMoney += Convert.ToInt64(lvShowForm.Items[i].SubItems[4].Text);
            }
            txbTotalForm.Text = totalMoney.ToString();
        }

        private void btnOutForm_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r= MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r== DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void btnEraseForm_Click(object sender, EventArgs e)
        {
            string stk = txbSTKForm.Text;
            for (int i=0;i<(int)lvShowForm.Items.Count; i++)
            {
                if (lvShowForm.Items[i].SubItems[1].Text == stk)
                {
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Bạn có chắc muốn xóa số tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        for (int j = i + 1; j < (int)lvShowForm.Items.Count; j++)
                        {
                            lvShowForm.Items[j].SubItems[0].Text = Convert.ToString(Convert.ToInt32(lvShowForm.Items[j].SubItems[0].Text) - 1);
                        }
                        lvShowForm.Items.RemoveAt(i);
                        MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TotalMoney();
                    }
                    return;
                }
            }
            MessageBox.Show("Không tồn tại số tài khoản cần xóa", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvShowForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShowForm.SelectedItems.Count > 0 )
            {
                ListViewItem curItem = lvShowForm.SelectedItems[0];
                txbSTKForm.Text = curItem.SubItems[1].Text;
                txbNameCusForm.Text = curItem.SubItems[2].Text;
                txbAddressForm.Text = curItem.SubItems[3].Text;
                txbMoneyAccountForm.Text = curItem.SubItems[4].Text;
            }
        }
    }
}
