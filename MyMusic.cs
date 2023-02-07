using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_AN_LTTQ
{
    public partial class MyMusic : UserControl
    {
        public MyMusic()
        {
            InitializeComponent();
            ScrollSongs.Value = PanelMusic.VerticalScroll.Value;
            ScrollSongs.Minimum = PanelMusic.VerticalScroll.Minimum;
            ScrollSongs.Maximum = PanelMusic.VerticalScroll.Maximum;    

            PanelMusic.ControlAdded+= PanelMusic_ControlAdded;
            PanelMusic.ControlRemoved+= PanelMusic_ControlRemoved;
        }

        private void PanelMusic_ControlAdded(object sender, ControlEventArgs e)
        {
            //ScrollSongs.Minimum = PanelMusic.VerticalScroll.Minimum;
        }

        private void PanelMusic_ControlRemoved(object sender, ControlEventArgs e)
        {
            //ScrollSongs.Maximum = PanelMusic.VerticalScroll.Maximum;
        }

        private void ScrollSongs_Scroll(object sender, ScrollEventArgs e)
        {
            PanelMusic.VerticalScroll.Value = ScrollSongs.Value;
        }
    }
        
}
