using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DO_AN_LTTQ
{
    public partial class Form1 : Form
    {
        #region Properties
        private List<MediaItem> mediaItems = new List<MediaItem>();

        //// LẤY TÊN FILE
        string[] files;
        //string filename;
        //string[] paths;




        // SANG
        MediaItem itemPlay = new MediaItem();
        MediaItem itemPlayed = new MediaItem();
        int iPlay;
        private string getFilename = null;
        string[] divideFilename = new string[2];

        

        //THUONG
        public static List<SongItem> songItems = new List<SongItem>();    

        //TINH
        private List<MediaItem> mediaItemsLove = new List<MediaItem>();
        private List<MediaItem> mediaItemsAlbum = new List<MediaItem>();
        private List<MediaItem> mediaItemsThuVien = new List<MediaItem>();

        #endregion
        public Form1()
        {

            InitializeComponent();


        }

        #region SETTINGS_SONG
        private void btnTaiNhac_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
            }

            MediaItem item;
            SongItem songItem;
            string[] tenBaiHat;
            string[] tenTacGia;

            int i = -1;

            foreach (string file in files)
            {
                
                item = new MediaItem();
                songItem = new SongItem();
                getFilename = Path.GetFileName(file);


                tenBaiHat = getFilename.Split('-');
                item.lblTenBaiHat.Text = tenBaiHat[0];

                tenTacGia = tenBaiHat[1].Split('.');
                item.lblTacGia.Text = tenTacGia[0];

                // Thuong
                songItem.playButton.Image = Properties.Resources.play11;
                songItem.lblSongName.Text = tenBaiHat[0];
                songItem.lblArtistName.Text = tenTacGia[0];

                try
                {
                    TagLib.File f = TagLib.File.Create(file, TagLib.ReadStyle.Average);
                    
                    var duration = (int)f.Properties.Duration.TotalSeconds;

                    int minute = (int)duration / 60;
                    int second = (int)duration % 60;
                     
                    songItem.lblTotalTime.Text = minute.ToString("00") + ":" + second.ToString("00");

                }
                catch
                {

                }

                i++;
                item.Tag = (string)file + "|" + i;
                item.picMediaItem.Tag = (string)file + "|" + i;
                item.lblTenBaiHat.Tag = (string)file + "|" + i;
                item.lblTacGia.Tag = (string)file + "|" + i;
                
                // Thuong
                songItem.Tag = (string)file + "|" + i;
                songItem.pictureBoxSong.Tag = (string)file + "|" + i;
                songItem.lblSongName.Tag = (string)file + "|" + i;
                songItem.lblArtistName.Tag = (string)file + "|" + i;
                
               

                try
                {
                    var f = TagLib.File.Create(file);
                    var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                    item.picMediaItem.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));

                    //Thuong
                    songItem.pictureBoxSong.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));
                }
                catch
                {
                    item.picMediaItem.BackgroundImage = Properties.Resources.DefaultMusic;
                    item.picMediaItem.BackgroundImageLayout = ImageLayout.Zoom;
                }

                item.MediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.PicMediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.LblTenBaiHat_Click += new EventHandler(item_MediaItem_Click);
                item.Dock = DockStyle.Top;


                songItem.Dock = DockStyle.Top;

                uHome_Main.flowPanelMedia.Controls.Add(item);
                uHome_Main.flowPanelMedia.BringToFront();
                
                mediaItems.Add(item);
                songItems.Add(songItem);
                myMusic1.PanelMusic.Controls.Add(songItem);
                

                //k++;
            }
        }
        #endregion


        #region SETTING 

        int check_forplaybutton = 0;

        private void item_MediaItem_Click(object sender, EventArgs e)
        {
            MediaItem item = (MediaItem)sender;

            string filename = (string)item.Tag;
            string[] part;
            part = filename.Split('|');
            player.URL = part[0];
            player.Ctlcontrols.play();
            try
            {
                play_button.Image = Properties.Resources.pause;
                check_forplaybutton = 1;
                timer1.Enabled = true;
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
                //var f = TagLib.File.Create((string)item.Tag);
                var f = TagLib.File.Create(part[0]);
                var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                picboxAvatar.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));

            }
            catch
            {
                picboxAvatar.Image = Properties.Resources.DefaultMusic;
                
            }

            name_of_song.Text = item.lblTenBaiHat.Text;
            lblTacGiaNhac.Text = item.lblTacGia.Text;

            MediaItem itemOld = (MediaItem)player.Tag;
            if (itemOld != null)
                itemOld.BackColor = System.Drawing.SystemColors.ControlLight;

            item.BackColor = System.Drawing.Color.Gray;

            player.Tag = item;
        }

       
        #endregion
        #region SETTING_COLORBACK
        private void next_button_MouseEnter(object sender, EventArgs e)
        {
            next_button.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void next_button_MouseLeave(object sender, EventArgs e)
        {
            next_button.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
        }

        private void play_button_MouseEnter(object sender, EventArgs e)
        {
            play_button.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void play_button_MouseLeave(object sender, EventArgs e)
        {
            play_button.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
        }

        private void shuffle_button_MouseEnter(object sender, EventArgs e)
        {
            shuffle_button.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void shuffle_button_MouseLeave(object sender, EventArgs e)
        {
            shuffle_button.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
        }

        private void repeat_button_MouseEnter(object sender, EventArgs e)
        {
            repeat_button.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void repeat_button_MouseLeave(object sender, EventArgs e)
        {
            repeat_button.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
        }

        private void volumn_button_MouseEnter(object sender, EventArgs e)
        {
            volumn_button.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void volumn_button_MouseLeave(object sender, EventArgs e)
        {
            volumn_button.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
        }
        private void Rewind_MouseEnter(object sender, EventArgs e)
        {
            rewind_button.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
        }

        private void Rewind_MouseLeave(object sender, EventArgs e)
        {
            rewind_button.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
        }
        #endregion


        #region SEARCHING
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
        public static string ConvertToMinute(double Second)
        {
            int minute = (int)Second / 60;
            int second = (int)Second % 60;
            return minute.ToString("00") + ":" + second.ToString("00");
        }

        #endregion
        #region Tiến Nhạc
        private void next_button_Click(object sender, EventArgs e)
        {
            itemPlayed = (MediaItem)player.Tag;

            getFilename = (string)itemPlayed.Tag;

            divideFilename = getFilename.Split('|');

            iPlay = Int32.Parse(divideFilename[1]);

            if (iPlay < mediaItems.Count - 1)
            {
                itemPlay = mediaItems[++iPlay];
            }
            else
            {
                itemPlay = mediaItems[0];
            }

            getFilename = (string)itemPlay.Tag;
            divideFilename = getFilename.Split('|');

            player.URL = (string)divideFilename[0];
            player.Ctlcontrols.play();


            name_of_song.Text = itemPlay.lblTenBaiHat.Text;
            lblTacGiaNhac.Text = itemPlay.lblTacGia.Text;

            itemPlayed.BackColor = System.Drawing.SystemColors.ControlLight;
            itemPlay.BackColor = System.Drawing.Color.Gray;

            try
            {

                //var f = TagLib.File.Create((string)item.Tag);
                var f = TagLib.File.Create(divideFilename[0]);
                var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                picboxAvatar.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));

            }
            catch
            {
                picboxAvatar.Image = Properties.Resources.DefaultMusic;
            }

            player.Tag = itemPlay;
        }

        #endregion

        #region Lùi Nhạc
        private void rewind_button_Click(object sender, EventArgs e)
        {
            itemPlayed = (MediaItem)player.Tag;

            getFilename = (string)itemPlayed.Tag;

            divideFilename = getFilename.Split('|');

            iPlay = Int32.Parse(divideFilename[1]);

            if (iPlay > 0)
            {
                itemPlay = mediaItems[--iPlay];
            }
            else
            {
                itemPlay = mediaItems[mediaItems.Count - 1];
            }

            getFilename = (string)itemPlay.Tag;
            divideFilename = getFilename.Split('|');

            player.URL = (string)divideFilename[0];
            player.Ctlcontrols.play();


            name_of_song.Text = itemPlay.lblTenBaiHat.Text;
            lblTacGiaNhac.Text = itemPlay.lblTacGia.Text;

            itemPlayed.BackColor = System.Drawing.SystemColors.ControlLight;
            itemPlay.BackColor = System.Drawing.Color.Gray;

            try
            {

                //var f = TagLib.File.Create((string)item.Tag);
                var f = TagLib.File.Create(divideFilename[0]);
                var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                picboxAvatar.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));

            }
            catch
            {
                picboxAvatar.Image = Properties.Resources.DefaultMusic;
            }

            player.Tag = itemPlay;
        }

        #endregion

        //
        // ĐỔI ICON PLAY BUTTON
        //
        #region SETTING_BUTTON
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
            else if (check_forplaybutton == 1)
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

        // TUA NHANH ĐI 10s nhạc
        //
       


        //
        // THAY ĐỔI ICON SHUFFLE
        //
        int check_shuffle = 0;
        private void shuffle_button_Click(object sender, EventArgs e)
        {
            if (check_shuffle == 0)
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
            if (flag_repeat == 0)
            {
                repeat_button.Image = Properties.Resources.repeat_once;
                flag_repeat = 1;
            }
            else if (flag_repeat == 1)
            {
                repeat_button.Image = Properties.Resources.repeat_infinity;
                flag_repeat = 2;
            }
            else if (flag_repeat == 2)
            {
                repeat_button.Image = Properties.Resources.repeat;
                flag_repeat = 0;
            }
        }

        #endregion

        #region Time_of_Song
        /// <summary>
        /// THỜI GIAN NHẠC CHẠY 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
        #endregion
        //
        // CHỈNH THANH ÂM NHẠC
        //

        #region MUSIC_TRACKBAR AND VOLUME
        private void metroSetTrackBar1_Scroll(object sender)
        {
            player.settings.volume = metroSetTrackBar1.Value;
        }


        // CHỈNH THANH TRACK_BAR CÓ THỂ NHẤN ĐƯỢC
        private void guna2TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / guna2TrackBar1.Width;
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            player.Ctlcontrols.currentPosition = e.NewValue;
        }
        //
        // CHỈNH VOLUME
        //

        #endregion
        // Tim kiem doi mau

        #region keyDown
        private void searching_textbox_Enter(object sender, EventArgs e)
        {
            if (searching_textbox.Texts.ToString() == "Tìm kiếm")
            {
                searching_textbox.Texts = "";
                searching_textbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void searching_textbox_Leave(object sender, EventArgs e)
        {
            if (searching_textbox.Texts.ToString() == "")
            {
                searching_textbox.Texts = "Tìm kiếm";
                searching_textbox.ForeColor = System.Drawing.Color.Silver;
            }
        }
        // Trang Chu Click
        private void TrangChu_Button_Click(object sender, EventArgs e)
        {

            home_label.Text = TrangChu_Button.Text;
            
            uHome_Main.Visible = true;
            myMusic1.Visible = false;
            uAlbum1.Visible = false;
            foreach (MediaItem i in mediaItems)
            {

                uHome_Main.flowPanelMedia.Controls.Add(i);
            }
            //flowPanelMedia.BringToFront();
            //SetSearch();
           
            
        }
        // Thu Vien Click
        private void ThuVien_Button_Click(object sender, EventArgs e)
        {
            home_label.Text = "Thư viện";
            //flowPanelMedia.Controls.Clear();
            //SetSearch();
            
            myMusic1.Visible = true;
            uHome_Main.Visible = false;
            uAlbum1.Visible = false;

        }
        // Yeu Thich Click
        private void YeuThich_Button_Click(object sender, EventArgs e)
        {

            home_label.Text = "Yêu thích";
            //flowPanelMedia.Controls.Clear();
            //SetSearch();
        }
        
        // Album Click

        private void Album_Button_Click(object sender, EventArgs e)
        {
            
            home_label.Text = "Album";
            

            //flowPanelMedia.Visible = false;
            //SetSearch();
            
            uAlbum1.Visible = true;
            myMusic1.Visible = false;
            uHome_Main.Visible = false;
        }
        

        // Su Kien Tim Kiem
        private void searching_button_Click(object sender, EventArgs e)
        {
            home_label.Text = "Kết quả tìm kiếm";
            //flowPanelMedia.Controls.Clear();
            foreach (MediaItem i in mediaItems)
            {
                if (string.Compare(i.lblTacGia.Text, searching_textbox.Texts) == 0)
                {
                    //flowPanelMedia.Controls.Add(i);
                }
                else
                {
                    if (string.Compare(i.lblTenBaiHat.Text, searching_textbox.Texts) == 0) ;
                        //flowPanelMedia.Controls.Add(i);
                }
            }
        }
        //Mau Button
        System.Drawing.Color ColorButton = new System.Drawing.Color();


        #endregion
        #region HELLO
        public void ChangeNormalColorOnPanelLeft(object sender)
        {
            Guna2TileButton btn = sender as Guna2TileButton;
            btn.FillColor = ColorButton;
            foreach (Guna2TileButton item in panel3.Controls)
            {
                if (item.Name != btn.Name && item.FillColor != System.Drawing.Color.Gainsboro)
                {
                    Guna2TileButton btn1 = item as Guna2TileButton;
                    btn1.FillColor = System.Drawing.Color.Gainsboro;
                }
            }
        }
        private void SetSearch()
        {
            searching_textbox.Texts = "Tìm kiếm";
            searching_textbox.ForeColor = System.Drawing.Color.Silver;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == System.Drawing.SystemColors.Control)
            {
                panel1.BackColor = System.Drawing.Color.DimGray;
                bottom_panel.BackColor = System.Drawing.Color.DimGray;
                panel2.BackColor = System.Drawing.Color.DimGray;
                panel3.BackColor = System.Drawing.Color.DimGray;
                pictureBox1.Image = global::DO_AN_LTTQ.Properties.Resources.crescent_moon;
                ColorButton = System.Drawing.Color.White;
            }
            else
            {
                panel1.BackColor = System.Drawing.SystemColors.Control;
                bottom_panel.BackColor = System.Drawing.SystemColors.Control;

                panel2.BackColor = System.Drawing.SystemColors.Control;
                panel3.BackColor = System.Drawing.SystemColors.Control;
                pictureBox1.Image = global::DO_AN_LTTQ.Properties.Resources.moonlight;
                ColorButton = System.Drawing.Color.DarkGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorButton = System.Drawing.Color.DarkGray;
        }




        #endregion

        

    }
}

