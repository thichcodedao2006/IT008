using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class ControlForm : Form
    {
        private List<ListViewItem> l;
        public ControlForm()
        {
            InitializeComponent();
            l = new List<ListViewItem>();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.ShowDialog();
            if (f.AddButton1)
            {
                AddListView(f.MSSV, f.Name1, f.Major, f.DTB);
                f.AddButton1 = false;
            }    
        }


        public void AddListView(string MSSV, string name, string major, string DTB)
        {
            ListViewItem item = new ListViewItem();
            int stt = (int)lvShow.Items.Count +1;
            item.SubItems.Add(stt.ToString());
            item.SubItems.Add(MSSV);
            item.SubItems.Add(name);
            item.SubItems.Add(major);
            item.SubItems.Add(DTB);
            lvShow.Items.Add(item);
            l.Add(item);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.ShowDialog();
            if (f.AddButton1)
            {
                AddListView(f.MSSV, f.Name1, f.Major, f.DTB);
                f.AddButton1 = false;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            lvShow.Items.Clear();
            string txt = toolStripTextBox1.Text;
            txt = txt.ToLower();
            if (txt == "")
            {
                foreach (ListViewItem item in l)
                {
                    ListViewItem clone = (ListViewItem)item.Clone();
                    lvShow.Items.Add(item);
                }
                return;
            }    

            foreach (ListViewItem item in l)
            {
                string name = item.SubItems[3].Text;
                name = name.ToLower();
                if (name.Contains(txt))
                {
                    ListViewItem clone = (ListViewItem)item.Clone();
                    lvShow.Items.Add(item);
                }
            }
        }
    }
}
