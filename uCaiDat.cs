using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LTTQ
{
    public partial class uCaiDat : UserControl
    {
        private Timer Out_timer;
        public uCaiDat()
        {
            InitializeComponent();
            cbMinute.SelectedIndex = 0;
            lbl_time.Text = ConvertToMinute(15 * 60);
        }

        private void uCaiDat_Load(object sender, EventArgs e)
        {

        }
        private int i = 0;
        private void TimeOut_Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeOut_Switch.Checked)
            {
               
                TimeOut_lbl.Text = "On";
                cbMinute.Enabled = true;
                Out_timer = new Timer();
                Out_timer.Interval = 1000;
                Out_timer.Start();
                Out_timer.Tick += Out_timer_Tick;
                i = int.Parse(cbMinute.Text) * 60;
            }
            else
            {
                TimeOut_lbl.Text = "Off";
                lbl_time.Text = "00:00";
                cbMinute.Enabled = false;
                Out_timer.Stop();
                Out_timer.Dispose();
            }
        }
        public static string ConvertToMinute(double Second)
        {
            int minute = (int)Second / 60;
            int second = (int)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
        }
        private void Out_timer_Tick(object sender, EventArgs e)
        {
            if (i >= 0)
            {
                lbl_time.Text = ConvertToMinute(i);
                i--;
            }
            else
            {
                Timer timer = sender as Timer;
                timer.Stop();
                timer.Dispose();
                Application.Exit();
            }
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbMinute_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = int.Parse(cbMinute.Text) * 60;
        }

        private void Theme_Switch_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}