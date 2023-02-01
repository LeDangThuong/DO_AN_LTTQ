using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LTTQ
{
    public partial class AlbumDetails : UserControl
    {
        private static ResourceManager resource;
        private static CultureInfo culture;
        public event EventHandler Back_Click;
        public event EventHandler PlayALl_Click;

        public AlbumDetails()
        {
            InitializeComponent();
        }
        public Image ImageShow
        {
            get
            {
                return image.Image;
            }
            set
            {
                image.Image = value;
                background.BackgroundImage = new Bitmap(PlaylistDetails.CropImage(value));
            }
        }
        public string NameFull
        {
            get
            {
                return lblPlaylistName.Text;
            }
            set
            {
                lblPlaylistName.Text = value;
            }
        }
        public int TotalSong
        {
            set
            {
                lblTotalSongs.Text = value.ToString();
            }
        }
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Back_Click?.Invoke(sender, e);
        }

        private void btnPlayAll_Click(object sender, EventArgs e)
        {
            PlayALl_Click?.Invoke(sender, e);
        }
    }
}
