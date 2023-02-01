using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LTTQ
{
    public partial class Album_Playlist : UserControl
    {
        public Album_Playlist()
        {
            InitializeComponent();
        }
        public Image PlaylistImage
        {
            get
            {
                return btnImage.BackgroundImage;
            }
            set
            {
                btnImage.BackgroundImage = value;
            }
        }
        public string PlaylistName
        {
            get
            {
                return lblPlaylist.Text;
            }
            set
            {
                lblPlaylist.Text = value;
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            BtnImage_Click?.Invoke(this, e);
        }
        public static uMyplaylist CreateArtist(uSong song)
        {
            uMyplaylist artist = new uMyplaylist();
            artist.songs.Add(song);
            artist.labelPlaylistName.Text = song.ArtistName;
            artist.btnImage.BackgroundImage = song.ImageSong;
            artist.albumDetails.ImageShow = song.ImageSong;
            artist.albumDetails.NameFull = song.ArtistName;
            return artist;
        }

        public static uMyplaylist CreateAlbum(uSong song)
        {
            uMyplaylist album = new uMyplaylist();
            album.songs.Add(song);
            album.labelPlaylistName.Text = song.Album;
            album.btnImage.BackgroundImage = song.ImageSong;
            album.albumDetails.ImageShow = song.ImageSong;
            album.albumDetails.NameFull = song.ArtistName;
            return album;
        }
        #endregion
    }
}
