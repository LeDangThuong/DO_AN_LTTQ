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
        public event EventHandler SongItem_Click;
        public event EventHandler LblSongName_Click;
        public event EventHandler LblArtistName_Click;
        public event EventHandler LblTotalTime_Click;
        public event EventHandler PictureBoxSong_Click;
        public event EventHandler ButtonPlay_Click;
        
        internal event EventHandler ButtonOption_Click;
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

        internal static SongItem CreateSong(MediaFiles file, SongIn4 info, EventHandler click, int i, ContextMenuStrip menuStripSong, MouseEventHandler mouseClick)
        {
            SongItem song = new SongItem();
            info.SetPath(file.FilePath);
            song.Path = file.FilePath;
            info.SetPath(file.FilePath);
            song.ImageSong = info.LoadImageSong;
            song.TenBaiHat = info.BaiHat;
            song.TenTacGia = info.TacGia;
            
            song.Duration = info.Duration;
            song.TotalTime = Form1.ConvertToMinute(song.Duration);
            song.BackColor = (i % 2 == 0) ? Color.Silver : Color.Gainsboro;
            song.ButtonPlay_Click += click;
            song.Mouse_Click += mouseClick;
            song.ContextMenuStrip = menuStripSong;
            song.Album = info.Album;
            return song;
        }
        #endregion

        #region Mouse
        private void pictureBoxSong_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Click?.Invoke(this, e);
        }
        #endregion

        #region Event

        private void songItem_Click(object sender, EventArgs e)
        {
            if (SongItem_Click != null)
            {
                SongItem_Click?.Invoke(this, e);
            }
        }
        private void lblSongName_Click(object sender, EventArgs e)
        {

        }
        private void lblArtistName_Click(object sender, EventArgs e)
        {

        }
        private void lblTotalTime_Click(object sender, EventArgs e)
        {

        }
        private void pictureBoxSong_Click(object sender, EventArgs e)
        {
            if (PictureBoxSong_Click != null)
            {
                PictureBoxSong_Click(sender, e);
            }
        }
        #endregion
    }
}
