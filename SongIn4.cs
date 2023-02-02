using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_LTTQ
{
    internal class SongIn4
    {
        public static readonly Image Imagedefault = Properties.Resources.DefaultMusic;
        private TagLib.File file;


        internal SongIn4 (string filePath)
        {
            this.file = TagLib.File.Create (filePath);
        }
        internal SongIn4() { }


        #region GET INFORMATION OF SONG
        public string Title
        {
            get
            {
                if(file.Tag.Title is null)
                {
                    return null;
                }
                return file.Tag.Title.Trim();
            }
        }

        public string TenTacGia
        {
            get
            {
                if (file.Tag.FirstPerformer is null)
                {
                    return string.Empty;
                }
                else return file.Tag.FirstPerformer.Trim();
            }
        }

        public string Song
        {
            get
            {
                if (file.Tag.Title is null)
                    return null;
                else return file.Tag.Title.Trim();
            }
        }
        public string Album
        {
            get
            {
                if (file.Tag.Album is null)
                    return string.Empty;
                else
                    return file.Tag.Album.Trim();
            }
        }
        public System.Drawing.Image LoadImageSong
        {
            get
            {
                TagLib.IPicture firstPicture = file.Tag.Pictures.FirstOrDefault();
                System.Drawing.Image image;

                if (firstPicture != null && firstPicture.Data.Data.Length != 0)
                {
                    var mStream = new MemoryStream();
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    image = System.Drawing.Image.FromStream(mStream);
                    mStream.Dispose();
                }
                else
                {
                    image = Properties.Resources.DefaultMusic;
                }
                return image;
            }
        }

        public double Duration
        {
            get => file.Properties.Duration.TotalSeconds;
        }

        #endregion

        #region SetPath

        internal void SetPath (string filePath)
        {
            if(file != null)
            {
                file.Dispose();
            }
            try
            {
                this.file = TagLib.File.Create(filePath);
            }
            catch
            {

            }
        }
        #endregion

        #region XỬ LÝ DỮ LIỆU

        public void Save()
        {
            file.Save();    
        }

        public static void Save(string filePath, string songTitle, string songArtist, string albumTitle, string albumArtist)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
            {
                if (songTitle != null)
                    file.Tag.Title = songTitle;
                if (songArtist != null)
                    file.Tag.Performers = new string[] { songArtist };
                if (albumTitle != null)
                    file.Tag.Album = albumTitle;
                if (albumArtist != null)
                    file.Tag.AlbumArtists = new string[] { albumArtist };
                file.Save();
            }
        }

        internal static string GetTitle(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Title;
        }
        internal static string GetArtist(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.FirstPerformer;
        }
        internal static string GetSong(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Title;
        }
        internal static string GetAlbum(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.Album;
        }
        internal static string GetAlbumArtist(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return file.Tag.FirstAlbumArtist;
        }

        public static string ConvertToMinute(double Second)
        {
            uint minute = (uint)Second / 60;
            uint second = (uint)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
        }
        internal static string GetLength(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
                return ConvertToMinute(file.Properties.Duration.TotalSeconds);
        }
        internal static System.Drawing.Image GetImageSong(string filePath)
        {
            using (TagLib.File file = TagLib.File.Create(filePath))
            {
                TagLib.IPicture firstPicture = file.Tag.Pictures.FirstOrDefault();
                System.Drawing.Image image;

                if (firstPicture != null && firstPicture.Data.Data.Length != 0)
                {
                    var mStream = new MemoryStream();
                    byte[] pData = firstPicture.Data.Data;
                    mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                    var bm = new Bitmap(mStream, false);
                    mStream.Dispose();
                    image = bm;
                }
                else
                {
                    image = Properties.Resources.DefaultMusic;
                }
                return image;
            }
        }
        #endregion

    }
}
