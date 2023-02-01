using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DO_AN_LTTQ
{
    public partial class Form1 : Form
    {
        //Tao tug list cho moi trang
        List<MediaItem> mediaItems = new List<MediaItem>();
        List<MediaItem> mediaItemsLove = new List<MediaItem>();
        List<MediaItem> mediaItemsAlbum = new List<MediaItem>();
        List<MediaItem> mediaItemsThuVien = new List<MediaItem>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Rewind_MouseEnter(object sender, EventArgs e)
        {
            rewind_button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void Rewind_MouseLeave(object sender, EventArgs e)
        {
            rewind_button.BackColor = Color.FromArgb(249, 249, 249);
        }

        string[] files;
        string filename;
        private void btnTaiNhac_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
            }

            MediaItem item;
            string[] tenBaiHat;
            string[] tenTacGia;

            foreach(string file in files)
            {
                item = new MediaItem();
                filename = Path.GetFileName(file);
                

                tenBaiHat = filename.Split('-');
                item.lblTenBaiHat.Text = tenBaiHat[0];

                tenTacGia = tenBaiHat[1].Split('.');
                item.lblTacGia.Text = tenTacGia[0];

                item.Tag = file;
                item.picMediaItem.Tag = file;
                item.lblTenBaiHat.Tag = file;
                item.lblTacGia.Tag = file;

                try
                {
                    var f = TagLib.File.Create(file);
                    var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                    item.picMediaItem.Image = Image.FromStream(new MemoryStream(bin));

                }
                catch
                {

                }
                mediaItems.Add(item);
                flowPanelMedia.Controls.Add(item);
            }

            
        }
        // Tim kiem doi mau
        private void searching_textbox_Enter(object sender, EventArgs e)
        {
            if (searching_textbox.Texts.ToString() == "Tìm kiếm")
            {
                searching_textbox.Texts = "";
                searching_textbox.ForeColor = Color.Black;
            }
        }

        private void searching_textbox_Leave(object sender, EventArgs e)
        {
            if (searching_textbox.Texts.ToString() == "")
            {
                searching_textbox.Texts = "Tìm kiếm";
                searching_textbox.ForeColor = Color.Silver;
            }
        }
        // Thu Vien Click
        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            home_label.Text = "Thư viện";
            flowPanelMedia.Controls.Clear();
            searching_textbox.Texts = "Tìm kiếm";
        }
        // Yeu Thich Click
        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            home_label.Text = "Yêu thích";
            flowPanelMedia.Controls.Clear();
            searching_textbox.Texts = "Tìm kiếm";
        }
        // Album Click
        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            home_label.Text = "Album";
            flowPanelMedia.Controls.Clear();
            searching_textbox.Texts = "Tìm kiếm";
        }
        // Trang Chu Click
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            home_label.Text = "Home";
            flowPanelMedia.Controls.Clear();
            foreach( MediaItem i in mediaItems)
            {
                flowPanelMedia.Controls.Add(i);
            }
        }
        // Su Kien Tim Kiem
        private void searching_button_Click(object sender, EventArgs e)
        {
            home_label.Text = "Kết quả tìm kiếm";
            flowPanelMedia.Controls.Clear();
            foreach(MediaItem i in mediaItems)
            {
                if(string.Compare(i.lblTacGia.Text,searching_textbox.Texts) == 0)
                {
                    flowPanelMedia.Controls.Add(i);
                }
                else
                {
                    if (string.Compare(i.lblTenBaiHat.Text, searching_textbox.Texts) == 0)
                        flowPanelMedia.Controls.Add(i);
                }
            }
        }
    }
}
