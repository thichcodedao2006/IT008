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
    public partial class MouseAndKeyForm : Form
    {
        public MouseAndKeyForm()
        {
            InitializeComponent();
            flpText.MouseDown += new MouseEventHandler(MouseAndKeyForm_MouseDown);
        }

        private void MouseAndKeyForm_MouseDown(object sender, MouseEventArgs e)
        {
            string txt1 = "Nút chuột vừa được nhấn: " + e.Button.ToString();
            string txt2 = "Tọa độ chuột vừa được nhấn: " + e.Location.ToString();
            Label l1 = new Label();
            Label l2 = new Label();
            l1.Text = txt1;
            l2.Text = txt2;
            l1.AutoSize = true;
            l2.AutoSize = true;
            flpText.Controls.Add(l1);
            flpText.Controls.Add(l2);
        }

        private void MouseAndKeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            string keycode = e.KeyCode.ToString();
            string modi = "";
            if (e.Modifiers != Keys.None)
            {
                modi = e.Modifiers.ToString();
            }
            Label l1 = new Label();
            l1.Text = "KeyCode của phím vừa được nhấn: " + keycode;
            Label l2 = new Label();
            l2.Text = "Control của phím: " + modi;
            l1.AutoSize = true;
            l2.AutoSize = true;
            flpText.Controls.Add(l1);
            flpText.Controls.Add(l2);
        }

        private void MouseAndKeyForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keychar = e.KeyChar.ToString();
            int asc = (int)e.KeyChar;
            string Asc = asc.ToString();
            Label l1 = new Label();
            Label l2 = new Label();
            l1.Text = "Phím vừa được nhấn là: " + keychar;
            l2.Text = "Mã ASCII của phím là: " + Asc;
            l1.AutoSize = true;
            l2.AutoSize = true;
            flpText.Controls.Add(l1);
            flpText.Controls.Add(l2);

        }
    }
}
