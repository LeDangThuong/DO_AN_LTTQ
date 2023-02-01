using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_LTTQ
{
    internal class Sort
    {
        #region Properties static
        public static readonly ISortSongFromAToZ iCompareAToZ = new ISortSongFromAToZ();
        public static readonly ISortSongFromZToA iCompareZToA = new ISortSongFromZToA();

        public static readonly ISortArtistAtoZ iCompareArtistAtoZ = new ISortArtistAtoZ();
        public static readonly ISortArtistZtoA iCompareArtistZtoA = new ISortArtistZtoA();

        public static readonly ISortAlbumAtoZ iCompareAlbumAtoZ = new ISortAlbumAtoZ();
        public static readonly ISortAlbumZtoA iCompareAlbumZtoA = new ISortAlbumZtoA();

        public static readonly ISortRanDom iRanDom = new ISortRanDom();
        private static readonly Random random = new Random();

        #endregion


        #region Sort Songs
        public class ISortSongFromAToZ : IComparer<MediaItem>
        {
            public int Compare(MediaItem x, MediaItem y)
            {
                return x.SongName.CompareTo(y.SongName);
            }
        }
        public class ISortSongFromZToA : IComparer<MediaItem>
        {
            public int Compare(MediaItem a, MediaItem b)
            {
                return b.SongName.CompareTo(a.SongName);
            }
        }
        #endregion

        #region Artist
        public class ISortArtistAtoZ : IComparer<Album_Playlist>
        {
            public int Compare(Album_Playlist a, Album_Playlist b)
            {
                return a.PlaylistName.CompareTo(b.PlaylistName);
            }
        }
        public class ISortArtistZtoA : IComparer<Album_Playlist>
        {
            public int Compare(Album_Playlist a, Album_Playlist b)
            {
                return b.PlaylistName.CompareTo(a.PlaylistName);
            }
        }
        #endregion

        #region Albums
        public class ISortAlbumAtoZ : IComparer<Album_Playlist>
        {
            public int Compare(Album_Playlist a, Album_Playlist b)
            {
                return a.PlaylistName.CompareTo(b.PlaylistName);
            }
        }
        public class ISortAlbumZtoA : IComparer<Album_Playlist>
        {
            public int Compare(Album_Playlist a, Album_Playlist b)
            {
                return b.PlaylistName.CompareTo(a.PlaylistName);
            }
        }
        #endregion

        #region Random
        public class ISortRanDom : IComparer<int>
        {
            public int Compare(int a, int b)
            {

                int x = random.Next(0, 40);
                if (x % 5 < 2)
                    return 1;
                else
                    if (x % 11 < 7)
                    return -1;
                else
                    return 0;
            }
        }
        #endregion
    }
}
