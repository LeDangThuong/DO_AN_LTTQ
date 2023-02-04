using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO_AN_LTTQ
{
    internal class cAlbum
    {
        public uOneAlbum OneAlbum { get; set; }
        public uAlbumDetail albumDetail { get; set; }
        public string NameAlbum()
        {
            return OneAlbum.lbl_onealbum.Text;
        }

    }
}
