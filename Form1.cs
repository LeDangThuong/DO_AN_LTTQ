﻿using System;
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

namespace DO_AN_LTTQ
{
    public partial class Form1 : Form
    {
        List<MediaItem> mediaItems = new List<MediaItem>();
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
                    item.picMediaItem.Image = Image.FromFile(@"D:\DOAN IT008\icon\music.png");
                }

                item.MediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.PicMediaItem_Click += new EventHandler(item_MediaItem_Click);
                item.LblTenBaiHat_Click += new EventHandler(item_MediaItem_Click);
                item.Dock = DockStyle.Top;
                flowPanelMedia.Controls.Add(item);
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
                picboxAvatar.Image = Image.FromStream(new MemoryStream(bin));
                
            }
            catch
            {
                picboxAvatar.Image = Image.FromFile(@"D:\DOAN IT008\icon\music.png");
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

        private void play_button_Click(object sender, EventArgs e)
        {  
        }
    }
}
