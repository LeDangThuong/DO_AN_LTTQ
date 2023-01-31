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
        public MediaItem()
        {
            InitializeComponent();
        }

        

        
        private void mediaItem_Click(object sender, EventArgs e)
        {
            if (MediaItem_Click != null)
            {
                MediaItem_Click.Invoke(this, e);
            }    

        }

        private void picMediaItem_Click(object sender, EventArgs e)
        {
            if(PicMediaItem_Click != null)
            {
                PicMediaItem_Click.Invoke(this,e);
            }    
        }

        private void lblTenBaiHat_Click(object sender, EventArgs e)
        {
            if(LblTenBaiHat_Click != null)
            {
                LblTenBaiHat_Click.Invoke(this, e);
            }    
        }
    }
}
