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
    public partial class AddForm : Form
    {
        private bool addButton;
        private string mSSV;
        private string name;
        private string major;
        private string dTB;

        public bool AddButton1 { get => addButton; set => addButton = value; }
        public string MSSV { get => mSSV; set => mSSV = value; }
        public string Name1 { get => name; set => name = value; }
        public string Major { get => major; set => major = value; }
        public string DTB { get => dTB; set => dTB = value; }

        public AddForm()
        {
            addButton = false;
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addButton = true;
            mSSV = txbMSSV.Text;
            name = txbName.Text;
            major = cbbMajor.Text;
            dTB = txbDTB.Text;
            MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo");
            this.Close();
        }

        private void txbMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==' ')
            {
                e.Handled = true;
            }    
        }

        private void txbDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit((char)e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar))
            {
                return;
            }    
            e.Handled = true;
        }

        private void txbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled |= true;  
            }    
        }
    }
}
