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
using System.Windows;
using DO_AN_LTTQ.Properties;
using System.Resources;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using AxWMPLib;
using System.Web.UI;
using Guna.UI2.WinForms;
using Krypton.Toolkit;

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
                    item.picMediaItem.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));
                   
                }
                catch
                {
                    item.picMediaItem.Image = System.Drawing.Image.FromFile(@"D:\DOAN IT008\icon\music.png");
                }

                item.MediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.PicMediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.LblTenBaiHat_Click += new EventHandler(item_MediaItem_Click);
                item.Dock = DockStyle.Top;
                uMyMusic.Controls.Add(item);
                uMyMusic.BringToFront();
                mediaItems.Add(item);
            }

            
        }

        private void item_MediaItem_Click(object sender, EventArgs e)
        {
            MediaItem item = (MediaItem)sender;
            player.URL = (string)item.Tag;
            player.Ctlcontrols.play();

            try
            {
                var f = TagLib.File.Create((string)item.Tag);
                var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                picboxAvatar.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));
                
            }
            catch
            {
                picboxAvatar.Image = System.Drawing.Image.FromFile(@"D:\DOAN IT008\icon\music.png");
            }

            name_of_song.Text = item.lblTenBaiHat.Text;
            lblTacGiaNhac.Text = item.lblTacGia.Text;

            MediaItem itemOld = (MediaItem)player.Tag;
            if (itemOld != null)
                itemOld.BackColor = System.Drawing.SystemColors.ControlLight;

            item.BackColor = Color.Gray;

            player.Tag = item;
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            foreach(MediaItem item in mediaItems)
            {
                if(item.Visible == true)     
                    item.Visible = false;
                else 
                    item.Visible = true;
            }   
        }

        private void next_button_MouseEnter(object sender, EventArgs e)
        {
            next_button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void next_button_MouseLeave(object sender, EventArgs e)
        {
            next_button.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void play_button_MouseEnter(object sender, EventArgs e)
        {
            play_button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void play_button_MouseLeave(object sender, EventArgs e)
        {
            play_button.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void shuffle_button_MouseEnter(object sender, EventArgs e)
        {
            shuffle_button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void shuffle_button_MouseLeave(object sender, EventArgs e)
        {
            shuffle_button.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void repeat_button_MouseEnter(object sender, EventArgs e)
        {
            repeat_button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void repeat_button_MouseLeave(object sender, EventArgs e)
        {
            repeat_button.BackColor = Color.FromArgb(249, 249, 249);
        }

        private void volumn_button_MouseEnter(object sender, EventArgs e)
        {
            volumn_button.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void volumn_button_MouseLeave(object sender, EventArgs e)
        {
            volumn_button.BackColor = Color.FromArgb(249, 249, 249);
        }

        // Xử lý khi click vào textbox, xóa chữ bên trong textbox;
        bool checking = false;
        private void searching_textbox_Click(object sender, EventArgs e)
        {
            String b = searching_textbox.Texts;
            if (!checking)
            {
                searching_textbox.Texts = String.Empty;
                checking = true;
            }
        }


        //
        // ĐỔI ICON PLAY BUTTON
        //
        int check_forplaybutton = 0;
        private void play_button_Click(object sender, EventArgs e)
        {
            
            if (check_forplaybutton == 0)
            {
                play_button.Image = Properties.Resources.pause;
                //
                // CHẠY NHẠC 
                //
                player.Ctlcontrols.play();
                check_forplaybutton = 1;
                timer1.Enabled = true;
            }    
            else if(check_forplaybutton == 1)
            {
                play_button.Image = Properties.Resources.play_rounded_button;
                //
                // DỪNG NHẠC
                //
                player.Ctlcontrols.pause();
                //
                check_forplaybutton = 0;
                timer1.Enabled = false;
            }


            
            
        }
        //
        // TUA NHANH ĐI 10s nhạc
        //
        int check_rewindbutton = 0;
        private void rewind_button_Click(object sender, EventArgs e)
        {
            
        }

        //
        // THAY ĐỔI ICON SHUFFLE
        //
        int check_shuffle = 0;
        private void shuffle_button_Click(object sender, EventArgs e)
        {
            if(check_shuffle == 0)
            {
                shuffle_button.Image = Properties.Resources.random;
                check_shuffle = 1;
            }
            else
            {
                shuffle_button.Image = Properties.Resources.shuffle;
                check_shuffle = 0;
            } 
                
        }
        //
        // Thay đổi ICON REPEAT
        //
        int flag_repeat = 0;

        private void repeat_button_Click(object sender, EventArgs e)
        {
            if( flag_repeat == 0)
            {
                repeat_button.Image = Properties.Resources.repeat_once;
                flag_repeat = 1;
            }
            else if(flag_repeat == 1)
            {
                repeat_button.Image= Properties.Resources.repeat_infinity;
                flag_repeat = 2;
            }    
            else if( flag_repeat == 2)
            {
                repeat_button.Image = Properties.Resources.repeat;
                flag_repeat = 0;
            }    
        }

        /// <summary>
        /// THỜI GIAN NHẠC CHẠY 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                guna2TrackBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }    
            try
            {
                label1.Text = player.Ctlcontrols.currentPositionString;
                label2.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch 
            {
                    
            }
        }

        private void metroSetTrackBar1_Scroll(object sender)
        {
            player.settings.volume = metroSetTrackBar1.Value;
        }

        private void guna2TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / guna2TrackBar1.Width;
        }

        private void guna2TrackBar1_MouseHover(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / guna2TrackBar1.Width;
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
            //flowPanelMedia.Controls.Clear();
            SetSearch();
            ChangeNormalColorOnPanelLeft(sender);
        }
        // Yeu Thich Click
        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            
            home_label.Text = "Yêu thích";
            //flowPanelMedia.Controls.Clear();
            SetSearch();
            ChangeNormalColorOnPanelLeft(sender);
        }
        // Album Click
        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            uAlbum1.BringToFront();
            home_label.Text = "Album";
            uMyMusic.Controls.Clear();


            //flowPanelMedia.Visible = false;
            SetSearch();
            ChangeNormalColorOnPanelLeft(sender);
        }
        // Trang Chu Click
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            
            home_label.Text = TrangChu_Button.Text;
            uMyMusic.Controls.Clear();
            foreach( MediaItem i in mediaItems)
            {
                uMyMusic.Controls.Add(i);
            }
            uMyMusic.BringToFront();
            SetSearch();
            ChangeNormalColorOnPanelLeft(sender);
        }
        // Su Kien Tim Kiem
        private void searching_button_Click(object sender, EventArgs e)
        {
            home_label.Text = "Kết quả tìm kiếm";
            uMyMusic.Controls.Clear();
            foreach(MediaItem i in mediaItems)
            {
                if(string.Compare(i.lblTacGia.Text,searching_textbox.Texts) == 0)
                {
                    uMyMusic.Controls.Add(i);
                }
                else
                {
                    if (string.Compare(i.lblTenBaiHat.Text, searching_textbox.Texts) == 0)
                        uMyMusic.Controls.Add(i);
                }
            }
        }
        //Mau Button
        Color ColorButton = new Color();
        
        
        private void CaiDat_Button_Click(object sender, EventArgs e)
        {
            home_label.Text = CaiDat_Button.Text;
            ChangeNormalColorOnPanelLeft(sender);
            SetSearch();
        }
        public void ChangeNormalColorOnPanelLeft(object sender)
        {
            Guna2TileButton btn = sender as Guna2TileButton;
            btn.FillColor = ColorButton;
            foreach (Guna2TileButton item in panel3.Controls)
            {
                if (item.Name != btn.Name && item.FillColor != Color.Gainsboro)
                {
                    Guna2TileButton btn1 = item as Guna2TileButton;
                    btn1.FillColor = Color.Gainsboro;
                }
            }
        }
        private void SetSearch()
        {
            searching_textbox.Texts = "Tìm kiếm";
            searching_textbox.ForeColor = Color.Silver;
        }
        private void About_Button_Click(object sender, EventArgs e)
        {
            home_label.Text = About_Button.Text;

            uAbout.BringToFront();
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panel1.BackColor == System.Drawing.SystemColors.Control)
            {
                panel1.BackColor = Color.DimGray;
                bottom_panel.BackColor = Color.DimGray;
                panel2.BackColor = Color.DimGray;
                panel3.BackColor = Color.DimGray;
                pictureBox1.Image = global::DO_AN_LTTQ.Properties.Resources.crescent_moon;
                ColorButton = Color.White;
            }
            else
            {
                panel1.BackColor = System.Drawing.SystemColors.Control;
                bottom_panel.BackColor = System.Drawing.SystemColors.Control;
                
                panel2.BackColor = System.Drawing.SystemColors.Control;
                panel3.BackColor = System.Drawing.SystemColors.Control;
                pictureBox1.Image = global::DO_AN_LTTQ.Properties.Resources.moonlight;
                ColorButton = Color.DarkGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorButton = Color.DarkGray;
        }
    }
}
