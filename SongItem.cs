using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DO_AN_LTTQ
{
    public partial class SongItem : UserControl
    {
        public SongItem()
        {
            InitializeComponent();
            playButton.Image = Properties.Resources.pause_black;
        }

        
        AxWindowsMediaPlayer player = new AxWindowsMediaPlayer();
        public event EventHandler ButtonPlay_Click;
        public event EventHandler ButtonOption_Click;
        public event MouseEventHandler Mouse_Click;
        internal double Duration { get; set; }
        private string path;

        #region Constructure

        internal string TenBaiHat
        {
            get
            {
                return lblSongName.Text;
            }
            set
            {
                lblSongName.Text = value;
            }
        }
        internal string TenTacGia
        {
            get
            {
                return lblArtistName.Text;
            }
            set
            {
                lblArtistName.Text = value;
            }
        }
        
        internal string TotalTime
        {
            get
            {
                return lblTotalTime.Text;
            }
            set
            {
                lblTotalTime.Text = value;
            }
        }
        internal System.Drawing.Image ImageSong
        {
            get
            {
                return pictureBoxSong.Image;
            }
            set
            {
                pictureBoxSong.Image = value;
            }
        }
        internal System.Drawing.Image ImageButton
        {
            get
            {
                return playButton.Image;
            }
            set
            {
                playButton.Image = value;
            }
        }
        internal string Album
        {
            get; set;
        }
        internal string Path { get => path; private set => path = value; }
        #endregion 


        #region CLICK
        int check_playbutton = 0;
        private void playButton_Click(object sender, EventArgs e)
        {
            if (ButtonPlay_Click != null)
                ButtonPlay_Click(this, e);
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            if (ButtonOption_Click != null)
                ButtonOption_Click(this, e);
        }
        #endregion

        #region UPLOAD NHẠC

        #endregion

        #region Mouse
        private void pictureBoxSong_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Click?.Invoke(this, e);
        }

        #endregion

        
    }
}
