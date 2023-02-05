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
    public partial class uReName : UserControl
    {
        public uReName()
        {
            InitializeComponent();
        }

        private void f_ReName_txt_Enter(object sender, EventArgs e)
        {
            if (f_ReName_txt.Texts.ToString() == "Nhập Tên Album Mới")
            {
                f_ReName_txt.Texts = "";
                f_ReName_txt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void f_ReName_txt_Leave(object sender, EventArgs e)
        {
            if (f_ReName_txt.Texts.ToString() == "")
            {
                f_ReName_txt.Texts = "Nhập Tên Album Mới";
                f_ReName_txt.ForeColor = System.Drawing.Color.Silver;
            }
        }
    }
}
