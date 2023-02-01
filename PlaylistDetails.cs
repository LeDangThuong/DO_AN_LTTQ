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
    public partial class PlaylistDetails : UserControl
    {

        public event EventHandler PlayAll_Click;
        public event EventHandler Rename_Click;
        public event EventHandler Delete_Click;
        public event EventHandler Back_Click;
        public PlaylistDetails()
        {
            InitializeComponent();

        }
        public void AddSong(MediaItem value)
        {
            panelSong.Controls.Add(value);
        }
        public static Image CropImage (Image img)
        {
            Rectangle cropArea = new Rectangle(Point.Empty, new Size(img.Size.Width, img.Size.Height / 4));
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
    }
}
