using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class TimeForm : Form
    {
        public TimeForm()
        {
            InitializeComponent();
            TimeCheck.Start();
        }

        private void UpdateTime()
        {
            DateTime curTime = DateTime.Now;
            string TextTime = curTime.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt",
                                                System.Globalization.CultureInfo.InvariantCulture);
            label1.Text = TextTime;
        }

        private void TimeForm_Load(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void TimeCheck_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void TimeForm_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;

        }
    }
}
