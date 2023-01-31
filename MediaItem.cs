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
        public MediaItem()
        {
            InitializeComponent();
        }

        static Form1 frm1 = new Form1();
        private void MediaItem_Click(object sender, EventArgs e)
        {
            MediaItem item = (MediaItem)sender;
            frm1.player.URL = (string) item.Tag;
            frm1.player.Ctlcontrols.play();

            
        }

        private void picMediaItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            frm1.player.URL = (string)pictureBox.Tag;
            frm1.player.Ctlcontrols.play();
        }

        private void lblTenBaiHat_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            frm1.player.URL = (string)lbl.Tag;
            frm1.player.Ctlcontrols.play();
        }
    }
}
