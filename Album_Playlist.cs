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
        #region Propeties
        private List<MediaItem> songs = new List<MediaItem>();
        public List<MediaItem> Songs { get => songs; }
        private AlbumDetails albumDetails = new AlbumDetails();
        public AlbumDetails fDetails { get { albumDetails.TotalSong = songs.Count; return albumDetails; } }
        public uMyplaylist()
        {
            InitializeComponent();
        }
        #endregion

        #region Method
        public event EventHandler BtnImage_Click;
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
        public static Album_Playlist CreateArtist(MediaItem song)
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
