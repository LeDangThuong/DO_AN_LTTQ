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
    public partial class uNewAlbum : UserControl
    {
        public uNewAlbum()
        {
            InitializeComponent();
        }

        private void f_Name_txt_Leave(object sender, EventArgs e)
        {
            if (f_Name_txt.Texts.ToString() == "")
            {
                f_Name_txt.Texts = "Nhập Tên Album";
                f_Name_txt.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void f_Name_txt_Enter(object sender, EventArgs e)
        {
            if (f_Name_txt.Texts.ToString() == "Nhập Tên Album")
            {
                f_Name_txt.Texts = "";
                f_Name_txt.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
