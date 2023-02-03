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
using System.Media;
using WMPLib;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace DO_AN_LTTQ
{
    public partial class Form1 : Form
    {
        private List<MediaItem> mediaItems = new List<MediaItem>();
        
        // LẤY TÊN FILE
        string[] files;
        string filename;
        string[] paths;

        // LẤY GIÁ TRỊ INDEX CỦA FILE
        private int iOfListIndex;
        private int indexNow = -1;
        private float angles = 0;
        private int status;
        
        private List<MediaItem> FullNhac = new List<MediaItem>();
        private List<MediaItem> NhacDangChay = new List<MediaItem>();
        private List<MediaItem> NhacTaiLen = new List<MediaItem>();
        private List<MediaItem> NhacDaNghe = new List<MediaItem>();
        private List<MediaItem> NhacDuocChon = new List<MediaItem>();  
        private List<string> DanhSach = new List<string>();
        private List<int> listIndex = new List<int>();


        private List<MediaItem> mediaItemsLove = new List<MediaItem>();
        private List<MediaItem> mediaItemsAlbum = new List<MediaItem>();
        private List<MediaItem> mediaItemsThuVien = new List<MediaItem>();

        
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
            string[] tenBaiHat;
            string[] tenTacGia;

            int i = -1;
            foreach (string file in files)
            {
                item = new MediaItem();
                getFilename = Path.GetFileName(file);


                tenBaiHat = getFilename.Split('-');
                item.lblTenBaiHat.Text = tenBaiHat[0];

                tenTacGia = tenBaiHat[1].Split('.');
                item.lblTacGia.Text = tenTacGia[0];

                i++;
                item.Tag = (string)file + "|" + i;
                item.picMediaItem.Tag = (string)file + "|" + i;
                item.lblTenBaiHat.Tag = (string)file + "|" + i;
                item.lblTacGia.Tag = (string)file + "|" + i;

                try
                {
                    var f = TagLib.File.Create(file);
                    var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                    item.picMediaItem.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));


                }
                catch
                {
                    item.picMediaItem.Image = Properties.Resources.musical_note;
                }

                item.MediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.PicMediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.LblTenBaiHat_Click += new EventHandler(item_MediaItem_Click);
                item.Dock = DockStyle.Top;
                flowPanelMedia.Controls.Add(item);
                mediaItems.Add(item);

            }
        }
        int check_forplaybutton = 0;
        
        private void item_MediaItem_Click(object sender, EventArgs e)
        {
            MediaItem item = (MediaItem)sender;
            player.URL = (string)item.Tag;
            player.Ctlcontrols.play();
            timer1.Enabled = true;

            try
            {
                play_button.Image = Properties.Resources.pause;
                check_forplaybutton = 1;
                
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
                var f = TagLib.File.Create((string)item.Tag);
                var bin = (byte[])(f.Tag.Pictures[0].Data.Data);
                picboxAvatar.Image = System.Drawing.Image.FromStream(new MemoryStream(bin));
 
            }
            catch
            {
                
            }

            name_of_song.Text = item.lblTenBaiHat.Text;
            lblTacGiaNhac.Text = item.lblTacGia.Text;

            MediaItem itemOld = (MediaItem)player.Tag;
            if (itemOld != null)
                itemOld.BackColor = System.Drawing.SystemColors.ControlLight;

            item.BackColor = System.Drawing.Color.Gray;

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


        #region Next and Previous
        //
        //HÀM BIẾN NEXT AND PREVIOUS
        //

        private void NextSong()
        {
            switch (next_button.Tag as string)
            {
                case "On":
                    if (iOfListIndex + 1 >= listIndex.Count)
                    {
                        indexNow = listIndex[0];
                        iOfListIndex = 0;
                    }
                    else
                    {
                        indexNow = listIndex[++iOfListIndex];
                    }
                    break;
                default:
                    indexNow = (indexNow + 1 >= NhacDangChay.Count) ? 0 : indexNow + 1;
                    break;
            }
        }
        private void PreviousSong()
        {
            switch (rewind_button.Tag as string)
            {
                case "On":
                    if (iOfListIndex - 1 < 0)
                    {
                        iOfListIndex = listIndex.Count - 1;
                        indexNow = listIndex[iOfListIndex];

                    }
                    else
                    {
                        indexNow = listIndex[--iOfListIndex];
                    }
                    break;
                default:
                    indexNow = (indexNow - 1 < 0) ? NhacDangChay.Count - 1 : indexNow - 1;
                    break;
            }
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
            //
            // TUA NHANH ĐI 10s nhạc
            //
            //
            // LÙI NHẠC LẠI 1 bài
            //
        private void rewind_button_Click(object sender, EventArgs e)
        {
            if (indexNow == -1) return;
            PreviousSong(); // set index song next
            autoNextSongTimer.Start();
            timer1.Start();
            angles = 0;
        }
        //
        // TIẾN NHẠC 1 bài
        //
        private void next_button_Click(object sender, EventArgs e)
        {
            if (indexNow == -1) return;
            // song pre
            NextSong();
            autoNextSongTimer.Start();
            timer1.Start();
            angles = 0;
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

        #endregion

        #region Time_of_Song
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

        private void autoNextSongTimer_Tick(object sender, EventArgs e)
        {

        }




        // Thu Vien Click

    }
}
