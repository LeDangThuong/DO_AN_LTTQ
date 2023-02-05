using DO_AN_LTTQ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LTTQ
{
    public partial class MediaItem : UserControl
    {
        public event EventHandler MediaItem_Click;
        public event EventHandler PicMediaItem_Click;
        public event EventHandler LblTenBaiHat_Click;
        public event EventHandler PicboxYeuThich_Click;

        public event MouseEventHandler Mouse_Click;
        public MediaItem()
        {
            InitializeComponent();
        }
        internal string SongName
        {
            get
            {
                return lblTenBaiHat.Text;
            }
            set
            {
                lblTenBaiHat.Text = value;
            }
        }
        internal string ArtistName
        {
            get
            {
                return lblTenBaiHat.Text;
            }
            set
            {
                lblTacGia.Text = value;
            }

        }
        
        
        internal Image ImageSong
        {
            get
            {
                return picMediaItem.Image;
            }
            set
            {
                picMediaItem.Image = value;
            }
        }
        
        internal string Album
        {
            get; set;
        }
        private void mediaItem_Click(object sender, EventArgs e)
        {
            if (MediaItem_Click != null)
            {
                MediaItem_Click?.Invoke(this, e);
            }    

        }

        private void picMediaItem_Click(object sender, EventArgs e)
        {
            if(PicMediaItem_Click != null)
            {
                PicMediaItem_Click?.Invoke(this,e);
            }
           
        }

        private void lblTenBaiHat_Click(object sender, EventArgs e)
        {
            if(LblTenBaiHat_Click != null)
            {
                LblTenBaiHat_Click?.Invoke(this, e);
            }    
        }

        private void picMediaItem_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Click?.Invoke(this, e);   
        }

        private void picboxYeuThich_Click(object sender, EventArgs e)
        {
            if (PicboxYeuThich_Click != null)
            {
                PicboxYeuThich_Click?.Invoke(this, e);
            }    
        }
    }
}
