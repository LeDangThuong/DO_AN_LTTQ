using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TagLib.Tiff;

namespace DO_AN_LTTQ
{
    public partial class Form1 : Form
    {
        #region Properties
        private List<MediaItem> mediaItems = new List<MediaItem>();
        private List<SongItem> songItems = new List<SongItem>();    

        //// LẤY TÊN FILE
        string[] files;
        //string filename;
        //string[] paths;

        


        // SANG
        MediaItem itemPlay = new MediaItem();
        MediaItem itemPlayed = new MediaItem();
        private MediaItem itemRecent = new MediaItem();
        int iPlay;
        private string getFilename = null;
        string[] divideFilename = new string[2];

        //THUONG
        private List<SongIn4> songIn4s = new List<SongIn4>();
        private SongItem SongRecent = new SongItem();
        

        //TINH
        private List<MediaItem> mediaItemsLove = new List<MediaItem>();
        private List<MediaItem> mediaItemsAlbum = new List<MediaItem>();
        

        private List<cAlbum> albums = new List<cAlbum>();
        #endregion
        public Form1()
        {

            InitializeComponent();


        }

        #region Load Song
        private void btnTaiNhac_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Zing Music|*.mp3";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
            }
           
            MediaItem item;
            string[] tenBaiHat;
            string[] tenTacGia;
            if (files == null)
                return;
            int i = -1;
            foreach (string file in files)
            {
                item = new MediaItem();
                SongItem songItem = new SongItem();
                getFilename = Path.GetFileName(file);


                tenBaiHat = getFilename.Split('-');
                item.lblTenBaiHat.Text = tenBaiHat[0].Trim();

                
                tenTacGia = tenBaiHat[1].Split('.');
                item.lblTacGia.Text = tenTacGia[0].Trim();

                //Thuong
                songItem.lblSongName.Text = tenBaiHat[0].Trim();
                songItem.lblArtistName.Text = tenTacGia[0].Trim();
                

                i++;
                item.Tag = (string)file + "|" + i;
                item.picMediaItem.Tag = (string)file + "|" + i;
                item.lblTenBaiHat.Tag = (string)file + "|" + i;
                item.lblTacGia.Tag = (string)file + "|" + i;

                songItem.Tag = (string)file + "|" + i;
                songItem.lblSongName.Tag = (string)file + "|" + i;    
                songItem.lblArtistName.Tag = (string)file + "|" + i;
                songItem.pictureBoxSong.Tag = (string)file + "|" + i;
                TagLib.File time = TagLib.File.Create(file, TagLib.ReadStyle.Average);

                var duration = time.Properties.Duration.TotalSeconds;
                int minute = (int)duration / 60;
                float second = (float)duration % 60;

                songItem.lblTotalTime.Text = minute.ToString("00") + ":" + second.ToString("00");


                try
                {
                    var f = TagLib.File.Create(file);
                    var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                    item.picMediaItem.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));

                    //Thuong
                    var f1 = TagLib.File.Create(file);
                    var bin1 = (byte[])(f1.Tag.Pictures[0].Data.Data);
                    songItem.pictureBoxSong.Image = System.Drawing.Image.FromStream(new MemoryStream(bin1));

                    

                }
                catch
                {
                    item.picMediaItem.Image = Properties.Resources.DefaultMusic;
                    songItem.pictureBoxSong.Image = Properties.Resources.DefaultMusic;
                }

                item.MediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.PicMediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.LblTenBaiHat_Click += new EventHandler(item_MediaItem_Click);

                //item.picboxYeuThich.Tag = item;
                item.PicboxYeuThich_Click += new EventHandler(item_picboxYeuThich_Click);

                
                item.Dock = DockStyle.Top;
                uMyMusic.flowPanelMedia.Controls.Add(item);
                mediaItems.Add(item);

                //Thuong
               
                songItem.SongItem_Click += new EventHandler(item_SongItem_Click);
                //songItem.PictureBoxSong_Click += new EventHandler(item_SongItem_Click);
                //songItem.LblArtistName_Click += new EventHandler(item_SongItem_Click);
                //songItem.LblSongName_Click += new EventHandler(item_SongItem_Click);
                songItem.ButtonPlay_Click += new EventHandler(play_ministyle_Click);
                songItem.Dock = DockStyle.Top;
                songItems.Add(songItem);
                myMusic2.PanelSongs.Controls.Add(songItem);

            }
        }




        #endregion

        #region  Mini PlayButton SongItem
        private void play_ministyle_Click(object sender, EventArgs e)
        {
            SongItem songItem = sender as SongItem;
            if (check_forplaybutton == 0)
            {
                songItem.playButton_image.Image = Properties.Resources.pause_black;
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
                songItem.playButton_image.Image = Properties.Resources.play1;
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
        #endregion

        #region SongItem 
        private void item_SongItem_Click (object sender, EventArgs e)
        {
            
            SongItem songItem = (SongItem)sender;
            
            foreach (SongItem song in myMusic2.PanelSongs.Controls)
            {
                song.BackColor = System.Drawing.SystemColors.Control;
                song.playButton_image.Image = Properties.Resources.play1;
              
            }
            songItem.BackColor = System.Drawing.Color.LightGray;
            songItem.playButton_image.Image = Properties.Resources.pause_black;


            foreach (MediaItem i in uMyMusic.flowPanelMedia.Controls)
            {
                if (String.Compare(i.lblTenBaiHat.Text, songItem.lblSongName.Text, true) == 0)
                {
                    i.BackColor = System.Drawing.Color.Gray;
                    
                }
                else
                {
                    i.BackColor = System.Drawing.SystemColors.Control;
                    
                }
            }
            string filename = (string)songItem.Tag;
            string[] part;
            part = filename.Split('|');
            player.URL = part[0];
            player.Ctlcontrols.play();

            
            try
            {
                play_button.Image = Properties.Resources.pause;
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
            name_of_song.Text = songItem.lblSongName.Text;
            lblTacGiaNhac.Text = songItem.lblArtistName.Text;
            MediaItem mediaItem = new MediaItem();
            foreach (MediaItem media in uMyMusic.flowPanelMedia.Controls)
            {
                if (String.Compare(media.lblTenBaiHat.Text, songItem.lblSongName.Text) == 0)
                {
                    mediaItem = media;
                }
            }
            player.Tag = mediaItem;
        }

        
        #endregion

        #region pictureboxYeuThich
        private void item_picboxYeuThich_Click(object sender, EventArgs e)
        {
            MediaItem item = (MediaItem)sender;

            if(item.checkYeuThich.Checked)
            {
                item.picboxYeuThich.Image = Properties.Resources.heart_white;
                item.checkYeuThich.Checked = false;

                string str1, str2;

                str1 = (string)item.Tag;

                foreach (MediaItem i in mediaItemsLove)
                {
                    str2 = (string)i.Tag;

                    if (String.Compare(str1, str2, true) == 0)
                    {
                        mediaItemsLove.Remove(i);
                        uYeuThich1.flowPnelYeuThich.Controls.Remove(i);
                        break;
                    }    
                    
                }    

            }
            else
            {

                item.picboxYeuThich.Image = Properties.Resources.heart_red;
                item.checkYeuThich.Checked = true;

                MediaItem itemYeuThich = new MediaItem();

                itemYeuThich.picMediaItem.Image = item.picMediaItem.Image;
                itemYeuThich.picboxYeuThich.Image = item.picboxYeuThich.Image;
                itemYeuThich.lblTenBaiHat.Text = item.lblTenBaiHat.Text;
                itemYeuThich.lblTacGia.Text = item.lblTacGia.Text;
                itemYeuThich.MediaItem_Click += new EventHandler(item_MediaItem_Click);
                itemYeuThich.PicMediaItem_Click += new EventHandler(item_MediaItem_Click);
                itemYeuThich.LblTenBaiHat_Click += new EventHandler(item_MediaItem_Click);

                itemYeuThich.PicboxYeuThich_Click += new EventHandler(picbox_itemYeuThich_Click);
                itemYeuThich.checkYeuThich.Checked = true;
                itemYeuThich.Tag = item.Tag;

                uYeuThich1.flowPnelYeuThich.Controls.Add(itemYeuThich);
                mediaItemsLove.Add(itemYeuThich);
            }
            
            
            if(mediaItemsLove.Count ==0)
            {
                uYeuThich1.lblTrong.Visible = true;
            }    

        }

        private void picbox_itemYeuThich_Click(object sender, EventArgs e)
        {
            MediaItem item = (MediaItem)sender;

            if (item.checkYeuThich.Checked)
            {
                item.picboxYeuThich.Image = Properties.Resources.heart_white;
                mediaItemsLove.Remove(item);
                uYeuThich1.flowPnelYeuThich.Controls.Remove(item);

                string str1, str2;

                str1 = (string)item.Tag;

                foreach(MediaItem i in mediaItems)
                {
                    str2 = (string)i.Tag;

                    if(String.Compare(str1,str2,true) == 0)
                    {
                        i.picboxYeuThich.Image = Properties.Resources.heart_white;
                        i.checkYeuThich.Checked = false;
                    }    
                }    
            }

            if (mediaItemsLove.Count == 0)
            {
                uYeuThich1.lblTrong.Visible = true;
            }
        }
        #endregion

        #region MediaItem

        int check_forplaybutton = 0;

        private void item_MediaItem_Click(object sender, EventArgs e)
        {
            MediaItem item = (MediaItem)sender;
            foreach(MediaItem i in uMyMusic.flowPanelMedia.Controls)
            {
                if (string.Compare(item.lblTenBaiHat.Text, i.lblTenBaiHat.Text) == 0)
                {
                    i.BackColor = System.Drawing.Color.Gray;
                }
                else
                {
                    i.BackColor = System.Drawing.SystemColors.Control;
                }
            }
            item.BackColor = System.Drawing.Color.Gray;

            foreach (SongItem song in myMusic2.PanelSongs.Controls)
            {
                if (String.Compare(item.lblTenBaiHat.Text, song.lblSongName.Text, true) == 0)
                {
                    song.BackColor = System.Drawing.Color.LightGray;
                    song.playButton_image.Image = Properties.Resources.pause_black;
                }
                else
                {
                    song.BackColor = System.Drawing.SystemColors.Control;
                    song.playButton_image.Image = Properties.Resources.play1;
                }
            }

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
            player.Tag = item;
            if (albums.Count > 0)
            {
                for (int i = 0; i < albums.Count; i++)
                {
                    foreach (MediaItem itemAlblum in albums[i].albumDetail)
                    {
                        if(String.Compare(item.lblTenBaiHat.Text, itemAlblum.lblTenBaiHat.Text) == 0)
                        {
                            itemAlblum.BackColor = System.Drawing.Color.Gray;
                        }
                        else
                        {
                            itemAlblum.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                        }
                    }
                }
            }
            if(mediaItemsLove.Count > 0)
            {
                foreach (Control i in uYeuThich1.flowPnelYeuThich.Controls)
                {
                    
                    try
                    {
                        MediaItem mediaItemmedia = (MediaItem)i;
                        if (String.Compare(item.lblTenBaiHat.Text, mediaItemmedia.lblTenBaiHat.Text) == 0)
                        {
                            i.BackColor = System.Drawing.Color.Gray;
                        }
                        else
                        {
                            i.BackColor = System.Drawing.SystemColors.Control;

                        }
                    }
                    catch { }
                }
            }
            
            
        }

      
        private void btnAn_Click(object sender, EventArgs e)
        {
            foreach (MediaItem item in mediaItems)
            {
                if (item.Visible == true)
                    item.Visible = false;
                else
                    item.Visible = true;
            }
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

            if (mediaItems.Count == 0)
            {
                return;
            }
            MediaItem media = (MediaItem)player.Tag;
            getFilename = (string)media.Tag;

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

            //itemPlayed.BackColor = System.Drawing.SystemColors.Control;
            

            foreach(MediaItem mediaItem in uMyMusic.flowPanelMedia.Controls)
            {
                if (String.Compare(itemPlay.lblTenBaiHat.Text, mediaItem.lblTenBaiHat.Text, true) == 0)
                {
                    mediaItem.BackColor = System.Drawing.Color.Gray;
                }
                else
                {

                    mediaItem.BackColor = System.Drawing.SystemColors.Control;
                }
            }
            //
            foreach (SongItem songItem in myMusic2.PanelSongs.Controls)
            {
                if (String.Compare(songItem.lblSongName.Text, itemPlay.lblTenBaiHat.Text, true) == 0)
                {
                    songItem.BackColor = System.Drawing.Color.LightGray;
                    songItem.playButton_image.Image = Properties.Resources.pause_black;
                    
                }
                else
                {
                    songItem.BackColor = System.Drawing.SystemColors.Control;
                    songItem.playButton_image.Image = Properties.Resources.play1;
                    
                }
            }
            // Tinh fix
            if (albums.Count > 0)
            {
                for (int i = 0; i < albums.Count; i++)
                {
                    foreach (MediaItem itemAlblum in albums[i].albumDetail)
                    {
                        if (String.Compare(itemPlay.lblTenBaiHat.Text, itemAlblum.lblTenBaiHat.Text) == 0)
                        {
                            itemAlblum.BackColor = System.Drawing.Color.Gray;
                        }
                        else
                        {
                            itemAlblum.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                        }
                    }
                }
            }
            if (mediaItemsLove.Count > 0)
            {
                foreach (Control i in uYeuThich1.flowPnelYeuThich.Controls)
                {

                    try
                    {
                        MediaItem mediaItemmedia = (MediaItem)i;
                        if (String.Compare(itemPlay.lblTenBaiHat.Text, mediaItemmedia.lblTenBaiHat.Text) == 0)
                        {
                            i.BackColor = System.Drawing.Color.Gray;
                        }
                        else
                        {
                            i.BackColor = System.Drawing.SystemColors.Control;

                        }
                    }
                    catch { }
                }
            }
            try
            {
                play_button.Image = Properties.Resources.pause;
                check_forplaybutton = 1;
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

            if (mediaItems.Count == 0)
            {
                return;
            }
            MediaItem media = (MediaItem)player.Tag;
            getFilename = (string)media.Tag;

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

            //itemPlayed.BackColor = System.Drawing.SystemColors.Control;


            foreach (MediaItem mediaItem in uMyMusic.flowPanelMedia.Controls)
            {
                if (String.Compare(itemPlay.lblTenBaiHat.Text, mediaItem.lblTenBaiHat.Text, true) == 0)
                {
                    mediaItem.BackColor = System.Drawing.Color.Gray;
                }
                else
                {

                    mediaItem.BackColor = System.Drawing.SystemColors.Control;
                }
            }
            foreach (SongItem songItem in myMusic2.PanelSongs.Controls)
            {
                if (String.Compare(songItem.lblSongName.Text, itemPlay.lblTenBaiHat.Text, true) == 0)
                {
                    songItem.BackColor = System.Drawing.Color.LightGray;
                    songItem.playButton_image.Image = Properties.Resources.pause_black;
                }
                else
                {
                    songItem.BackColor = System.Drawing.SystemColors.Control;
                    songItem.playButton_image.Image = Properties.Resources.play1;
                }
            }
            //Tinh fix
            if (albums.Count > 0)
            {
                for (int i = 0; i < albums.Count; i++)
                {
                    foreach (MediaItem itemAlblum in albums[i].albumDetail)
                    {
                        if (String.Compare(itemPlay.lblTenBaiHat.Text, itemAlblum.lblTenBaiHat.Text) == 0)
                        {
                            itemAlblum.BackColor = System.Drawing.Color.Gray;
                        }
                        else
                        {
                            itemAlblum.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                        }
                    }
                }
            }
            if (mediaItemsLove.Count > 0)
            {
                foreach (Control i in uYeuThich1.flowPnelYeuThich.Controls)
                {

                    try
                    {
                        MediaItem mediaItemmedia = (MediaItem)i;
                        if (String.Compare(itemPlay.lblTenBaiHat.Text, mediaItemmedia.lblTenBaiHat.Text) == 0)
                        {
                            i.BackColor = System.Drawing.Color.Gray;
                        }
                        else
                        {
                            i.BackColor = System.Drawing.SystemColors.Control;

                        }
                    }
                    catch { }
                }
            }
            try
            {
                play_button.Image = Properties.Resources.pause;
                check_forplaybutton = 1;
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
        #region SETTING BUTTON
        //
        // VOLUME
        //
        int check_volume = 0;
        private void volumn_button_Click(object sender, EventArgs e)
        {
            if (check_volume == 0)
            {
                if (checkSangToi == 0)
                    volumn_button.Image = Properties.Resources.volume_mute;
                else
                    volumn_button.Image = Properties.Resources.volume_mute_white;
                player.settings.volume = 0;
                metroSetTrackBar1.Enabled= false;
                check_volume = 1;

            }
            else if (check_volume == 1)
            {
                if (checkSangToi == 0)
                    volumn_button.Image = Properties.Resources.volume_white;
                else
                    volumn_button.Image = Properties.Resources.volume_white1;
                player.settings.volume = metroSetTrackBar1.Value;
                metroSetTrackBar1.Enabled = true;
                check_volume = 0;
            }

        }
        private void play_button_Click(object sender, EventArgs e)
        {
            MediaItem mediaItem = (MediaItem)player.Tag;
            SongItem SONG_ITEM = new SongItem();
            foreach(SongItem songItem in myMusic2.PanelSongs.Controls)
            {
                if(String.Compare(mediaItem.lblTenBaiHat.Text, songItem.lblSongName.Text) == 0)
                {
                    SONG_ITEM = songItem;
                }
            }
            if (check_forplaybutton == 0)
            {
                play_button.Image = Properties.Resources.pause;
                SONG_ITEM.playButton_image.Image = Properties.Resources.pause_black;
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
                SONG_ITEM.playButton_image.Image = Properties.Resources.play1;
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
                var rnd = new Random();
                mediaItems = mediaItems.OrderBy(item => rnd.Next()).ToList();
                player.settings.setMode("shuffle", true);

            }
            else
            {
                mediaItems = mediaItems.OrderBy(item => item.lblTenBaiHat.Text).ToList();
                shuffle_button.Image = Properties.Resources.shuffle;
                check_shuffle = 0;
                player.settings.setMode("shuffle", false);
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
                player.settings.setMode("loop", true);
            }
            
            else if (flag_repeat == 1)
            {
                repeat_button.Image = Properties.Resources.repeat;
                
                flag_repeat = 0;
                player.settings.setMode("loop", false);
            }
        }

        #endregion

        #region Time of song
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
            if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                MediaItem mediaItem = (MediaItem)player.Tag;
                next_button_Click(mediaItem, e);
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

        #region MUSIC TRACKBAR AND VOLUME
        private void metroSetTrackBar1_Scroll(object sender)
        {
            player.settings.volume = metroSetTrackBar1.Value;
            if(metroSetTrackBar1.Value == 0)
            {
                volumn_button.Image = Properties.Resources.volume_mute;
            }
            else
            {
                volumn_button.Image = Properties.Resources.volume_white;
            } 
                
        }


        // CHỈNH THANH TRACK_BAR CÓ THỂ NHẤN ĐƯỢC
        private void guna2TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
                player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / guna2TrackBar1.Width;         
        }
        private void metroSetTrackBar1_MouseDown(object sender, MouseEventArgs e)
        {

            metroSetTrackBar1.Value = e.X;
            player.settings.volume = metroSetTrackBar1.Value;
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
        // Thu Vien Click
        private void ThuVien_Button_Click(object sender, EventArgs e)
        {
            home_label.Text = "Thư viện";
            myMusic2.BringToFront();
            //flowPanelMedia.Controls.Clear();
            SetSearch();
            //ChangeNormalColorOnPanelLeft(sender);
            
         
        }
        // Yeu Thich Click
        private void YeuThich_Button_Click(object sender, EventArgs e)
        {

            home_label.Text = "Yêu thích";
            //flowPanelMedia.Controls.Clear();
            uYeuThich1.BringToFront();

            if (mediaItemsLove.Count == 0)
            {
                uYeuThich1.lblTrong.Visible = true;
            }
            else
            {
                uYeuThich1.lblTrong.Visible = false;
            }

            SetSearch();
            //ChangeNormalColorOnPanelLeft(sender);
        
        }
        
        // Album Click

        private void Album_Button_Click(object sender, EventArgs e)
        {
            uAlbum.BringToFront();
            home_label.Text = "Album";
            //uMyMusic.Controls.Clear();

            //flowPanelMedia.Visible = false;
            SetSearch();
            //ChangeNormalColorOnPanelLeft(sender);
            UpdateAlbum();

        }
        // Trang Chu Click
        private void TrangChu_Button_Click(object sender, EventArgs e)
        {
            home_label.Text = TrangChu_Button.Text;
            uMyMusic.flowPanelMedia.Controls.Clear();
            foreach(MediaItem item in mediaItems)
            {
                uMyMusic.flowPanelMedia.Controls.Add(item);
            }    
            uMyMusic.BringToFront();
            SetSearch();
            //ChangeNormalColorOnPanelLeft(sender);

        }

        // About Click
        private void About_Button_Click(object sender, EventArgs e)
        {
            home_label.Text = About_Button.Text;
            uAbout.BringToFront();
            SetSearch();
            //ChangeNormalColorOnPanelLeft(sender);

        }
        // Cai Dat Click
        private void CaiDat_Button_Click(object sender, EventArgs e)
        {
            home_label.Text = CaiDat_Button.Text;
            uCaiDat.BringToFront();
            SetSearch();
           // ChangeNormalColorOnPanelLeft(sender);

        }
        // Su Kien Tim Kiem
        private void searching_button_Click(object sender, EventArgs e)
        {
            home_label.Text = "Kết quả tìm kiếm";
            
            uMyMusic.flowPanelMedia.Controls.Clear();

            
            foreach (MediaItem i in mediaItems)
            {
                
                if (String.Compare(i.lblTacGia.Text, searching_textbox.Texts, true) == 0)
                {
                    
                    uMyMusic.flowPanelMedia.Controls.Add(i);
                }
                else if (String.Compare(i.lblTenBaiHat.Text, searching_textbox.Texts, true) == 0)
                        uMyMusic.flowPanelMedia.Controls.Add(i);
               
            }
            uMyMusic.BringToFront();
        }
        //Mau Button
       
        
        
        
        private void SetSearch()
        {
            searching_textbox.Texts = "Tìm kiếm";
            searching_textbox.ForeColor = System.Drawing.Color.Silver;
        }
        #endregion

        // Mau Nen
        #region DoiMau
        private int checkSangToi = 0;
        private System.Drawing.Color colorLeTrai = System.Drawing.Color.FromArgb(240, 240, 240);
        private System.Drawing.Color colorVungLamViec = System.Drawing.Color.FromArgb(240, 240, 240);
        private System.Drawing.Color colorText = System.Drawing.Color.FromArgb(15, 15, 15);
        private System.Drawing.Color colorMedia = System.Drawing.Color.FromArgb(240, 240, 240);
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (checkSangToi == 0)
            {
                uCaiDat.Theme_Switch.Checked = false;
                colorLeTrai = System.Drawing.Color.FromArgb(29, 35, 41);
                colorVungLamViec = System.Drawing.Color.FromArgb(58, 70, 82);
                colorText = System.Drawing.Color.FromArgb(240, 240, 240);
                colorMedia = System.Drawing.Color.FromArgb(68, 69, 69);

                TrangChu_Button.Image = Properties.Resources.home_white;
                ThuVien_Button.Image = Properties.Resources.musical_white;
                YeuThich_Button.Image = Properties.Resources.hear_removetoWhite;
                Album_Button.Image = Properties.Resources.music_album_white;
                About_Button.Image = Properties.Resources.aboutwhite;
                CaiDat_Button.Image = Properties.Resources.settingwhite;
                picture_theme.Image = Properties.Resources.crescent_moon;

                if (check_forplaybutton == 0)
                {
                    play_button.Image = Properties.Resources.play_buttonwhite;
                }
                else
                {
                    play_button.Image = Properties.Resources.pause_white;
                }

                next_button.Image = Properties.Resources.next_white;
                rewind_button.Image = Properties.Resources.back_White;

                if (check_volume == 0)
                {
                    volumn_button.Image = Properties.Resources.volume_white1;
                }
                else
                {
                    volumn_button.Image = Properties.Resources.volume_mute_white;
                }



                checkSangToi = 1;

            }
            else
            {
                uCaiDat.Theme_Switch.Checked = true;
                colorLeTrai = System.Drawing.Color.FromArgb(240, 240, 240);
                colorVungLamViec = System.Drawing.Color.FromArgb(240, 240, 240);
                colorText = System.Drawing.Color.FromArgb(15, 15, 15);
                colorMedia = System.Drawing.Color.FromArgb(240, 240, 240);

                TrangChu_Button.Image = Properties.Resources.home1;
                ThuVien_Button.Image = Properties.Resources.musical_note;
                YeuThich_Button.Image = Properties.Resources.heart_white;
                Album_Button.Image = Properties.Resources.albumIcon;
                About_Button.Image = Properties.Resources.question;
                CaiDat_Button.Image = Properties.Resources.setting;
                picture_theme.Image = Properties.Resources.moonlight;

                if (check_forplaybutton == 0)
                {
                    play_button.Image = Properties.Resources.play_rounded_button;
                }
                else
                {
                    play_button.Image = Properties.Resources.pause;
                }

                next_button.Image = Properties.Resources.next;
                rewind_button.Image = Properties.Resources.back1;

                if (check_volume == 0)
                {
                    volumn_button.Image = Properties.Resources.volume_black;
                }
                else
                {
                    volumn_button.Image = Properties.Resources.volum_mute_black;
                }



                checkSangToi = 0;
            }

            DoiMau();


        }
        private void DoiMau()
        {
            panel1.BackColor = colorLeTrai;
            panel2.BackColor = colorVungLamViec;
            bottom_panel.BackColor = colorVungLamViec;
            uMyMusic.BackColor = colorVungLamViec;
            TrangChu_Button.FillColor = colorLeTrai;
            ThuVien_Button.FillColor = colorLeTrai;
            YeuThich_Button.FillColor = colorLeTrai;
            Album_Button.FillColor = colorLeTrai;
            CaiDat_Button.FillColor = colorLeTrai;
            About_Button.FillColor = colorLeTrai;



            this.ForeColor = colorText;
            TrangChu_Button.ForeColor = colorText;
            ThuVien_Button.ForeColor = colorText;
            YeuThich_Button.ForeColor = colorText;
            Album_Button.ForeColor = colorText;
            CaiDat_Button.ForeColor = colorText;
            About_Button.ForeColor = colorText;
            myMusic2.ForeColor = System.Drawing.SystemColors.ControlText;

            foreach (MediaItem item in uMyMusic.flowPanelMedia.Controls)
            {

                item.ForeColor = System.Drawing.SystemColors.ControlText; ;
            }
        }

        #endregion
        #region Theme
        private void Theme_Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (!uCaiDat.Theme_Switch.Checked)
            {
                
                picture_theme.Image = Properties.Resources.crescent_moon;
                colorLeTrai = System.Drawing.Color.FromArgb(29, 35, 41);
                colorVungLamViec = System.Drawing.Color.FromArgb(58, 70, 82);
                colorText = System.Drawing.Color.FromArgb(240, 240, 240);
                colorMedia = System.Drawing.Color.FromArgb(68, 69, 69);

                TrangChu_Button.Image = Properties.Resources.home_white;
                ThuVien_Button.Image = Properties.Resources.musical_white;
                YeuThich_Button.Image = Properties.Resources.hear_removetoWhite;
                Album_Button.Image = Properties.Resources.music_album_white;
                About_Button.Image = Properties.Resources.aboutwhite;
                CaiDat_Button.Image = Properties.Resources.settingwhite;
                picture_theme.Image = Properties.Resources.crescent_moon;

                if (check_forplaybutton == 0)
                {
                    play_button.Image = Properties.Resources.play_buttonwhite;
                }
                else
                {
                    play_button.Image = Properties.Resources.pause_white;
                }

                next_button.Image = Properties.Resources.next_white;
                rewind_button.Image = Properties.Resources.back_White;

                if (check_volume == 0)
                {
                    volumn_button.Image = Properties.Resources.volume_white1;
                }
                else
                {
                    volumn_button.Image = Properties.Resources.volume_mute_white;
                }



                checkSangToi = 0;

                uCaiDat.lbl_Theme.Text = "Tối";

            }
            else
            {
                
                picture_theme.Image = Properties.Resources.moonlight;

                colorLeTrai = System.Drawing.Color.FromArgb(240, 240, 240);
                colorVungLamViec = System.Drawing.Color.FromArgb(240, 240, 240);
                colorText = System.Drawing.Color.FromArgb(15, 15, 15);
                colorMedia = System.Drawing.Color.FromArgb(240, 240, 240);

                TrangChu_Button.Image = Properties.Resources.home1;
                ThuVien_Button.Image = Properties.Resources.musical_note;
                YeuThich_Button.Image = Properties.Resources.heart_white;
                Album_Button.Image = Properties.Resources.albumIcon;
                About_Button.Image = Properties.Resources.question;
                CaiDat_Button.Image = Properties.Resources.setting;
                picture_theme.Image = Properties.Resources.moonlight;

                if (check_forplaybutton == 0)
                {
                    play_button.Image = Properties.Resources.play_rounded_button;
                }
                else
                {
                    play_button.Image = Properties.Resources.pause;
                }

                next_button.Image = Properties.Resources.next;
                rewind_button.Image = Properties.Resources.back1;

                if (check_volume == 0)
                {
                    volumn_button.Image = Properties.Resources.volume_black;
                }
                else
                {
                    volumn_button.Image = Properties.Resources.volum_mute_black;
                }



                checkSangToi = 1;
                uCaiDat.lbl_Theme.Text = "Sáng";

            }
            DoiMau();
        }

        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            
            uCaiDat.Theme_Switch.CheckedChanged += new System.EventHandler(Theme_Switch_CheckedChanged);

        }
        #endregion
        // Tao Album
        #region Album
        // Tao Album
        private void NewAlbum_Button_Click(object sender, EventArgs e)
        {
            uNewAlbum1.BringToFront();
        }
        
        private void uAlbum1_Load(object sender, EventArgs e)
        {
            uAlbum.NewAlbum_Button.Click += new System.EventHandler(this.NewAlbum_Button_Click);
            
        }
        
    
        
        //Su Kien NewAbum Laod
        private void uNewAlbum1_Load(object sender, EventArgs e)
        {
            uNewAlbum1.f_Cancel_Album.Click += new EventHandler(f_Cancel_Album_Click);
            uNewAlbum1.f_Ok_Album.Click += new EventHandler(f_Ok_Album_Click);
        }
        private void f_Cancel_Album_Click(object sender, EventArgs e)
        {
           UpdateUName();
        }
        private void f_Ok_Album_Click(object sender, EventArgs e)
        {
            if (uNewAlbum1.f_Name_txt.Texts == "Nhập Tên Album")
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập tên album");
                return;
            }
            if (uNewAlbum1.f_Name_txt.Texts == string.Empty)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập tên album");
                return;
            }
            try 
            {
                j++;
                if(albums.Count > 0) 
                { 
                    for(int i = 0; i < albums.Count; i++)
                    {
                        if (string.Compare(uNewAlbum1.f_Name_txt.Texts, albums[i].NameAlbum()) == 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Tên Album Đã Tồn Tại");
                            return;
                        }
                    }
                }
                cAlbum item = new cAlbum();
                item.OneAlbum = new uOneAlbum();
                item.albumDetail = new List<MediaItem>();
                item.OneAlbum.lbl_onealbum.Text = uNewAlbum1.f_Name_txt.Texts;
                item.OneAlbum.lbl_onealbum.Tag = j;
                item.OneAlbum.onealbum_pic.Tag= j;
                albums.Add(item);
                uAlbum.panelalbum.Controls.Clear();
                foreach (cAlbum items in albums)
                {
                    items.OneAlbum.Dock = DockStyle.Top;
                    items.OneAlbum.lbl_onealbum.Click += new EventHandler(lbl_onealbum_Click);
                    items.OneAlbum.onealbum_pic.Click += new EventHandler(onealbum_pic_Click);
                    uAlbum.panelalbum.Controls.Add(items.OneAlbum);

                }
                UpdateUName();
                System.Windows.Forms.MessageBox.Show("Thêm Album Thành Công");
             
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
               
            }
            
        }
        private void UpdateUName()
        {
            uNewAlbum1.SendToBack();
            uNewAlbum1.f_Name_txt.Texts = "Nhập Tên Album";
            uNewAlbum1.f_Name_txt.ForeColor = System.Drawing.Color.Silver;
        }
        #endregion
        // Chi tiet Album
        #region AlbumDetail
        int j = -1;
        // One Album Click
        private void onealbum_pic_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PictureBox tam = (System.Windows.Forms.PictureBox)sender;
            int vitri = Int32.Parse(tam.Tag.ToString());
            cAlbum item = albums[vitri];
            uAlbumDetail1.NameSong_lbl.Text = item.NameAlbum();
            uAlbumDetail1.SLSong_lbl.Text = item.albumDetail.Count + " Bài Hát";
            uAlbumDetail1.NameSong_lbl.Tag = vitri;
            uAlbumDetail1.panelAlbumDetail.Controls.Clear();
            if (item.albumDetail.Count > 0)
            {
                foreach (MediaItem filse in item.albumDetail)
                {
                    uAlbumDetail1.panelAlbumDetail.Controls.Add(filse);
                        
                }
            }
            uAlbumDetail1.back_pic.Visible = uAlbumDetail1.PlayList_button.Visible = uAlbumDetail1.AddSong_button.Visible =
                uAlbumDetail1.Delete_button.Visible = uAlbumDetail1.Rename_button.Visible = true;
            uAlbumDetail1.AlbumOkList_Button.Visible = false;
            uAlbumDetail1.BringToFront();
           
        }
        private void lbl_onealbum_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Label tam = (System.Windows.Forms.Label)sender;
            int vitri = Int32.Parse(tam.Tag.ToString());
            cAlbum item = albums[vitri];
            uAlbumDetail1.NameSong_lbl.Text = item.NameAlbum();
            uAlbumDetail1.SLSong_lbl.Text = item.albumDetail.Count + " Bài Hát";
            uAlbumDetail1.NameSong_lbl.Tag = vitri;
            uAlbumDetail1.panelAlbumDetail.Controls.Clear();
            if (item.albumDetail.Count > 0)
            {
                foreach (MediaItem filse in item.albumDetail)
                {
                    uAlbumDetail1.panelAlbumDetail.Controls.Add(filse);

                }
            }
            uAlbumDetail1.back_pic.Visible = uAlbumDetail1.PlayList_button.Visible = uAlbumDetail1.AddSong_button.Visible =
                uAlbumDetail1.Delete_button.Visible = uAlbumDetail1.Rename_button.Visible = true;
            uAlbumDetail1.AlbumOkList_Button.Visible = false;
            uAlbumDetail1.BringToFront();
            
        }
        // Detail Album Load
        private void uAlbumDetail1_Load(object sender, EventArgs e)
        {
            uAlbumDetail1.back_pic.Click += new EventHandler(back_pic_Click);
            uAlbumDetail1.AddSong_button.Click += new System.EventHandler(this.AddSong_button_Click);
            uAlbumDetail1.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            uAlbumDetail1.Rename_button.Click += new System.EventHandler(this.Rename_button_Click);
            uAlbumDetail1.PlayList_button.Click += new System.EventHandler(this.PlayList_button_Click);
            uAlbumDetail1.AlbumOkList_Button.Click += new EventHandler(AlbumOkList_Button_Click);
        }
        //

        private void AlbumOkList_Button_Click(object sender, EventArgs e)
        {
            int vitri = Int32.Parse(uAlbumDetail1.NameSong_lbl.Tag.ToString());
            uAlbumDetail1.SLSong_lbl.Text = albums[vitri].albumDetail.Count.ToString() + " Bài Hát";
            uAlbumDetail1.back_pic.Visible = uAlbumDetail1.PlayList_button.Visible = uAlbumDetail1.AddSong_button.Visible =
               uAlbumDetail1.Delete_button.Visible = uAlbumDetail1.Rename_button.Visible = true;
            uAlbumDetail1.AlbumOkList_Button.Visible = false;
            uAlbumDetail1.panelAlbumDetail.Controls.Clear();
            foreach(MediaItem item in albums[vitri].albumDetail)
            {
                uAlbumDetail1.panelAlbumDetail.Controls.Add(item);
            }
            mediaItemsAlbum.Clear();
        }

        // Tro Lai
        private void back_pic_Click(object sender, EventArgs e)
        {
            uAlbum.BringToFront();
        }

        // Play All
        private void PlayList_button_Click(object sender, EventArgs e)
        {

            int vitri = Int32.Parse(uAlbumDetail1.NameSong_lbl.Tag.ToString());
            for(int i = albums[vitri].albumDetail.Count - 1; i>= 0;i--)
            {
                MediaItem item = albums[vitri].albumDetail[i];
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
                    picboxAvatar.Image = Properties.Resources.repeat;
                }

                name_of_song.Text = item.lblTenBaiHat.Text;
                lblTacGiaNhac.Text = item.lblTacGia.Text;

                MediaItem itemOld = (MediaItem)player.Tag;
                if (itemOld != null)
                    itemOld.BackColor = System.Drawing.SystemColors.ControlLight;

                item.BackColor = System.Drawing.Color.Gray;

                player.Tag = item;
            }
        }
        // Them Bai Hat Vao
        private void AddSong_button_Click(object sender, EventArgs e)
        {
            UpdatelAlbumPic();
            uAlbumDetail1.panelAlbumDetail.Controls.Clear();
            uAlbumDetail1.back_pic.Visible = uAlbumDetail1.PlayList_button.Visible = uAlbumDetail1.AddSong_button.Visible =
                uAlbumDetail1.Delete_button.Visible = uAlbumDetail1.Rename_button.Visible = false;
            uAlbumDetail1.AlbumOkList_Button.Visible = true;
            foreach(MediaItem item in mediaItemsAlbum)
            {
                uAlbumDetail1.panelAlbumDetail.Controls.Add(item);
            }
        }
        //Su Kien Them Vao
        private void picbox_itemnew_Click(object sender, EventArgs e)
        {
            MediaItem item = sender as MediaItem;
            int vitri = Int32.Parse(uAlbumDetail1.NameSong_lbl.Tag.ToString());
            foreach(MediaItem item2 in albums[vitri].albumDetail)
            {
                if(string.Compare(item.lblTacGia.Text,item2.lblTacGia.Text)==0 &&
                    string.Compare(item.lblTenBaiHat.Text, item2.lblTenBaiHat.Text) == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Bài Hát Đã Tồn Tại Trong Album");
                    return;
                }
            }
            
          
            albums[vitri].albumDetail.Add(item);
            mediaItemsAlbum.Remove(item);
            uAlbumDetail1.panelAlbumDetail.Controls.Clear();
            foreach (MediaItem items in mediaItemsAlbum)
            {
                uAlbumDetail1.panelAlbumDetail.Controls.Add(items);
            }

        }
        // Doi Ten
        private void Rename_button_Click(object sender, EventArgs e)
        {
            uReName1.BringToFront();
           
        }
        // Xoa
        private void Delete_button_Click(object sender, EventArgs e)
        {
            DialogResult h = System.Windows.Forms.MessageBox.Show
                ("Bạn có chắc muốn xóa album không?", "Question", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                int vitri = Int32.Parse(uAlbumDetail1.NameSong_lbl.Tag.ToString());
                albums.RemoveAt(vitri);
                UpdateAlbum();
                System.Windows.Forms.MessageBox.Show("Xóa Thành Công");
            }
            j--;
          
        }
        private void UpdateAlbum()
        {
            uAlbum.panelalbum.Controls.Clear();
            foreach (cAlbum items in albums)
            {
                uAlbum.panelalbum.Controls.Add(items.OneAlbum);
            }
            uAlbum.BringToFront();
        }
        // Su Kien Load Anh
        private void UpdatelAlbumPic()
        {
            mediaItemsAlbum.Clear();
            foreach (MediaItem item in mediaItems)
            {
                MediaItem itemnew = new MediaItem();

                itemnew.picMediaItem.Image = item.picMediaItem.Image;
                itemnew.picboxYeuThich.Image = Properties.Resources.add;
                itemnew.lblTenBaiHat.Text = item.lblTenBaiHat.Text;
                itemnew.lblTacGia.Text = item.lblTacGia.Text;
                itemnew.MediaItem_Click += new EventHandler(item_MediaItem_Click);
                itemnew.PicMediaItem_Click += new EventHandler(item_MediaItem_Click);
                itemnew.LblTenBaiHat_Click += new EventHandler(item_MediaItem_Click);

                itemnew.PicboxYeuThich_Click += new EventHandler(picbox_itemnew_Click);

                itemnew.Tag = item.Tag;
                mediaItemsAlbum.Add(itemnew);
            }


        }
        #endregion
        // Doi Ten Album
        #region AlbumReName
        // Su Kien Doi Ten
        private void uReName1_Load(object sender, EventArgs e)
        {
            uReName1.f_ReOk_Album.Click += new EventHandler(f_ReOk_Album_Click);
            uReName1.f_ReCancel_Album.Click += new EventHandler(f_ReCancel_Album_Click);
        }
        private void f_ReOk_Album_Click(object sender, EventArgs e)
        {
            if(uReName1.f_ReName_txt.Texts == "Nhập Tên Album Mới")
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập tên Album mới");
                return;
            }    
            for(int i = 0; i < albums.Count; i++)
            {
                if (string.Compare(uReName1.f_ReName_txt.Texts, albums[i].NameAlbum()) == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Tên Album Đã Tồn Tại");
                    return;
                }
            }
            int vitri = Int32.Parse(uAlbumDetail1.NameSong_lbl.Tag.ToString());
            albums[vitri].OneAlbum.lbl_onealbum.Text = uReName1.f_ReName_txt.Texts;
            uAlbumDetail1.NameSong_lbl.Text = albums[vitri].OneAlbum.lbl_onealbum.Text;
            UpdateUReName();
            System.Windows.Forms.MessageBox.Show("Đổi Tên Thành Công");
            
        }
    

        private void f_ReCancel_Album_Click(object sender, EventArgs e)
        {
           UpdateUReName();
        }
        private void UpdateUReName()
        {
            uReName1.SendToBack();
            uReName1.f_ReName_txt.Texts = "Nhập Tên Album Mới";
            uReName1.f_ReName_txt.ForeColor = System.Drawing.Color.Silver;
        }
        #endregion

        #region SEARCHING
        private void searching_textbox__TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(searching_textbox.Texts))
            {
                foreach(MediaItem mediaItem in mediaItems)
                {
                    uMyMusic.flowPanelMedia.Controls.Add(mediaItem);
                }

                uMyMusic.BringToFront();
            }    
        }

        private void searching_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                home_label.Text = "Kết quả tìm kiếm";

                uMyMusic.flowPanelMedia.Controls.Clear();


                foreach (MediaItem i in mediaItems)
                {

                    if (String.Compare(i.lblTacGia.Text, searching_textbox.Texts, true) == 0)
                    {

                        uMyMusic.flowPanelMedia.Controls.Add(i);
                    }
                    else if (String.Compare(i.lblTenBaiHat.Text, searching_textbox.Texts, true) == 0)
                        uMyMusic.flowPanelMedia.Controls.Add(i);

                }
                uMyMusic.BringToFront();
            }
        }

        private void uMyMusic_Load(object sender, EventArgs e)
        {

        }
        #endregion

       
    }
}
