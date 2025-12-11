using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class MediaForm : Form
    {
        public MediaForm()
        {
            InitializeComponent();
            DateTime current = DateTime.Now;
            int day = current.Day;
            int month = current.Month;
            int year = current.Year;
            int hour = current.Hour;
            int minute = current.Minute;
            int second = current.Second;
            string d = day.ToString("00");
            string m = month.ToString("00");
            string y = year.ToString("0000");
            string h = hour.ToString("00");
            string mi = minute.ToString("00");
            string s = second.ToString("00");
            string TT = current.ToString("tt");
            string txt = $"Hôm nay là ngày {d}/{m}/{y} - Bây giờ là {h}:{mi}:{s} {TT}";
            tslabel.Text = txt;
            Clock.Start();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            int day = current.Day;
            int month = current.Month;
            int year = current.Year;
            int hour = current.Hour;
            int minute = current.Minute;    
            int second = current.Second;
            string d = day.ToString("00");
            string m =month.ToString("00");
            string y = year.ToString("0000");
            string h = hour.ToString("00");
            string mi = minute.ToString("00");
            string s = second.ToString("00");
            string TT = current.ToString("tt");
            string txt = $"Hôm nay là ngày {d}/{m}/{y} - Bây giờ là {h}:{mi}:{s} {TT}";
            tslabel.Text = txt;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Tất cả tệp (*.*)|*.*|Avi File (*.avi)|*.avi|MPEG File (*.mpeg)|*.mpeg|Wav File (*.wav)|*.wav|Midi File (*.midi)|*.midi|MP4 File (*.mp4)|*.mp4|MP3 File (*.mp3)|*.mp3";
            DialogResult r = openFile.ShowDialog();
            if (r == DialogResult.OK)
            {
                WPMPlayer.URL = openFile.FileName;  
            }    
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
