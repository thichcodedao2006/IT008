using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class SinhVienForm : Form
    {
        public SinhVienForm()
        {
            InitializeComponent();
        }

        private bool CheckInfo()
        {
            if (txbID.Text == "" || txbName.Text =="" || cbbMajor.SelectedIndex==-1)
            {
                return false;
            }    
            if (cbMale.Checked == false && cbFemale.Checked == false)
            {
                return false;
            }
            return true;
                
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            bool HaveExist = false;
            string MSSV = txbID.Text;
            string Name = txbName.Text;
            string Major = "";
            if (cbbMajor.SelectedItem != null)
            {
                Major = cbbMajor.SelectedItem.ToString();
            }
            string Gender = "Nam";
            if (cbFemale.Checked == true)
            {
                Gender = "Nữ";
            }
            string NumberSub = Convert.ToString(lvCurChoose.Items.Count);
            ListViewItem item = new ListViewItem("*");
            for (int i=0;i<(int)lvShow.Items.Count;i++)
            {
                if (lvShow.Items[i].SubItems[1].Text == MSSV)
                {
                    HaveExist = true;
                    lvShow.Items[i].SubItems[2].Text = Name;
                    lvShow.Items[i].SubItems[3].Text = Major;
                    lvShow.Items[i].SubItems[4].Text = Gender;
                    lvShow.Items[i].SubItems[5].Text = NumberSub;
                    break;
                }
            }
            if (!HaveExist)
            {
                item.SubItems.Add(MSSV);
                item.SubItems.Add(Name);
                item.SubItems.Add(Major);
                item.SubItems.Add(Gender);
                item.SubItems.Add(NumberSub);
                lvShow.Items.Add(item);
            }
            MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbName.Text = "";
            cbMale.Checked = false;
            cbFemale.Checked = false;
            btnDeleteSub_Click(sender, e);  
            cbbMajor.SelectedIndex = -1;
        }

        private void btnChooseSub_Click(object sender, EventArgs e)
        {
            if (lvChoose.SelectedItems.Count > 0)
            {
                List<ListViewItem> list = new List<ListViewItem>();
                for (int i=0;i<(int)lvChoose.SelectedItems.Count;i++)
                {
                    list.Add(lvChoose.SelectedItems[i]);
                }    
                foreach (ListViewItem item in list)
                {
                    lvChoose.Items.Remove(item);
                    lvCurChoose.Items.Add(item);
                }    
            }    
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list = new List<ListViewItem>();
            for (int i = 0; i < (int)lvCurChoose.Items.Count; i++)
            {
                list.Add(lvCurChoose.Items[i]);
            }
            foreach (ListViewItem item in list)
            {
                lvCurChoose.Items.Remove(item);
                lvChoose.Items.Add(item);
            }
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked == true && cbFemale.Checked == true)
            {
                cbFemale.Checked = false;
            }    
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked == true && cbFemale.Checked == true)
            {
                cbMale.Checked = false;
            }
        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }    
            e.Handled = true;
        }

        private void txbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl (e.KeyChar) || e.KeyChar == ' ')
            {
                return;
            }    
            e.Handled = true;
        }

        private void SinhVienForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count > 0)
            {
                ListViewItem cur_item = lvShow.SelectedItems[0];
                txbID.Text = cur_item.SubItems[1].Text;
                txbName.Text = cur_item.SubItems[2].Text;
                cbbMajor.Text = cur_item.SubItems[3].Text;
                if (cur_item.SubItems[4].Text == "Nam")
                {
                    cbMale.Checked = true;
                    cbFemale.Checked = false;
                } else
                {
                    cbMale.Checked = false;
                    cbFemale.Checked = true;
                }
            }
        }
    }
}
