﻿namespace DO_AN_LTTQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searching_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searching_textbox = new Sipaa.Framework.STextBox();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.volumn_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.metroSetTrackBar1 = new MetroSet_UI.Controls.MetroSetTrackBar();
            this.repeat_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.shuffle_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.next_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.rewind_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.play_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.name_of_song = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.open_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.home_button = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.searching_button);
            this.panel1.Controls.Add(this.searching_textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 476);
            this.panel1.TabIndex = 0;
            // 
            // searching_button
            // 
            this.searching_button.BackColor = System.Drawing.Color.White;
            this.searching_button.CheckedState.ImageSize = new System.Drawing.Size(28, 28);
            this.searching_button.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.searching_button.Image = ((System.Drawing.Image)(resources.GetObject("searching_button.Image")));
            this.searching_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.searching_button.ImageRotate = 0F;
            this.searching_button.ImageSize = new System.Drawing.Size(25, 25);
            this.searching_button.Location = new System.Drawing.Point(208, 17);
            this.searching_button.Name = "searching_button";
            this.searching_button.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.searching_button.Size = new System.Drawing.Size(26, 28);
            this.searching_button.TabIndex = 10;
            // 
            // searching_textbox
            // 
            this.searching_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.searching_textbox.BorderColor = System.Drawing.Color.Black;
            this.searching_textbox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.searching_textbox.BorderRadius = 0;
            this.searching_textbox.BorderSize = 2;
            this.searching_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searching_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searching_textbox.Location = new System.Drawing.Point(13, 13);
            this.searching_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.searching_textbox.Multiline = false;
            this.searching_textbox.Name = "searching_textbox";
            this.searching_textbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searching_textbox.PasswordChar = false;
            this.searching_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searching_textbox.PlaceholderText = "";
            this.searching_textbox.Size = new System.Drawing.Size(225, 35);
            this.searching_textbox.TabIndex = 1;
            this.searching_textbox.Texts = "Tìm kiếm";
            this.searching_textbox.UnderlinedStyle = false;
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.bottom_panel.Controls.Add(this.guna2CirclePictureBox1);
            this.bottom_panel.Controls.Add(this.volumn_button);
            this.bottom_panel.Controls.Add(this.metroSetTrackBar1);
            this.bottom_panel.Controls.Add(this.repeat_button);
            this.bottom_panel.Controls.Add(this.shuffle_button);
            this.bottom_panel.Controls.Add(this.next_button);
            this.bottom_panel.Controls.Add(this.rewind_button);
            this.bottom_panel.Controls.Add(this.play_button);
            this.bottom_panel.Controls.Add(this.guna2TrackBar1);
            this.bottom_panel.Controls.Add(this.name_of_song);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 476);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1198, 139);
            this.bottom_panel.TabIndex = 1;
            // 
            // volumn_button
            // 
            this.volumn_button.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.volumn_button.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.volumn_button.Image = ((System.Drawing.Image)(resources.GetObject("volumn_button.Image")));
            this.volumn_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.volumn_button.ImageRotate = 0F;
            this.volumn_button.ImageSize = new System.Drawing.Size(32, 32);
            this.volumn_button.Location = new System.Drawing.Point(968, 62);
            this.volumn_button.Name = "volumn_button";
            this.volumn_button.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.volumn_button.Size = new System.Drawing.Size(64, 54);
            this.volumn_button.TabIndex = 9;
            this.volumn_button.Click += new System.EventHandler(this.volumn_button_Click);
            // 
            // metroSetTrackBar1
            // 
            this.metroSetTrackBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTrackBar1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.metroSetTrackBar1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.metroSetTrackBar1.DisabledHandlerColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.metroSetTrackBar1.DisabledValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.metroSetTrackBar1.HandlerColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.metroSetTrackBar1.IsDerivedStyle = true;
            this.metroSetTrackBar1.Location = new System.Drawing.Point(1038, 81);
            this.metroSetTrackBar1.Maximum = 100;
            this.metroSetTrackBar1.Minimum = 0;
            this.metroSetTrackBar1.Name = "metroSetTrackBar1";
            this.metroSetTrackBar1.Size = new System.Drawing.Size(71, 16);
            this.metroSetTrackBar1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTrackBar1.StyleManager = null;
            this.metroSetTrackBar1.TabIndex = 8;
            this.metroSetTrackBar1.Text = "metroSetTrackBar1";
            this.metroSetTrackBar1.ThemeAuthor = "Narwin";
            this.metroSetTrackBar1.ThemeName = "MetroLite";
            this.metroSetTrackBar1.Value = 50;
            this.metroSetTrackBar1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // repeat_button
            // 
            this.repeat_button.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.repeat_button.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.repeat_button.Image = ((System.Drawing.Image)(resources.GetObject("repeat_button.Image")));
            this.repeat_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.repeat_button.ImageRotate = 0F;
            this.repeat_button.ImageSize = new System.Drawing.Size(33, 33);
            this.repeat_button.Location = new System.Drawing.Point(769, 62);
            this.repeat_button.Name = "repeat_button";
            this.repeat_button.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.repeat_button.Size = new System.Drawing.Size(64, 54);
            this.repeat_button.TabIndex = 7;
            // 
            // shuffle_button
            // 
            this.shuffle_button.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.shuffle_button.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.shuffle_button.Image = ((System.Drawing.Image)(resources.GetObject("shuffle_button.Image")));
            this.shuffle_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.shuffle_button.ImageRotate = 0F;
            this.shuffle_button.ImageSize = new System.Drawing.Size(32, 32);
            this.shuffle_button.Location = new System.Drawing.Point(376, 62);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.shuffle_button.Size = new System.Drawing.Size(64, 54);
            this.shuffle_button.TabIndex = 6;
            // 
            // next_button
            // 
            this.next_button.CheckedState.ImageSize = new System.Drawing.Size(48, 48);
            this.next_button.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.next_button.Image = ((System.Drawing.Image)(resources.GetObject("next_button.Image")));
            this.next_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.next_button.ImageRotate = 0F;
            this.next_button.ImageSize = new System.Drawing.Size(40, 40);
            this.next_button.Location = new System.Drawing.Point(665, 62);
            this.next_button.Name = "next_button";
            this.next_button.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.next_button.Size = new System.Drawing.Size(64, 54);
            this.next_button.TabIndex = 5;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // rewind_button
            // 
            this.rewind_button.CheckedState.ImageSize = new System.Drawing.Size(48, 48);
            this.rewind_button.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.rewind_button.Image = ((System.Drawing.Image)(resources.GetObject("rewind_button.Image")));
            this.rewind_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.rewind_button.ImageRotate = 0F;
            this.rewind_button.ImageSize = new System.Drawing.Size(40, 40);
            this.rewind_button.Location = new System.Drawing.Point(477, 62);
            this.rewind_button.Name = "rewind_button";
            this.rewind_button.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.rewind_button.Size = new System.Drawing.Size(64, 54);
            this.rewind_button.TabIndex = 4;
            this.rewind_button.MouseEnter += new System.EventHandler(this.rewind_button_MouseEnter);
            this.rewind_button.MouseLeave += new System.EventHandler(this.rewind_button_MouseLeave);
            // 
            // play_button
            // 
            this.play_button.CheckedState.ImageSize = new System.Drawing.Size(48, 48);
            this.play_button.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.play_button.Image = ((System.Drawing.Image)(resources.GetObject("play_button.Image")));
            this.play_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.play_button.ImageRotate = 0F;
            this.play_button.ImageSize = new System.Drawing.Size(40, 40);
            this.play_button.Location = new System.Drawing.Point(570, 62);
            this.play_button.Name = "play_button";
            this.play_button.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.play_button.Size = new System.Drawing.Size(64, 54);
            this.play_button.TabIndex = 3;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(132, 16);
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(977, 23);
            this.guna2TrackBar1.TabIndex = 2;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // name_of_song
            // 
            this.name_of_song.AutoSize = true;
            this.name_of_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_song.Location = new System.Drawing.Point(128, 79);
            this.name_of_song.Name = "name_of_song";
            this.name_of_song.Size = new System.Drawing.Size(88, 20);
            this.name_of_song.TabIndex = 1;
            this.name_of_song.Text = "Tên bài hát";
            this.name_of_song.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.open_cb);
            this.panel2.Controls.Add(this.home_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(288, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 476);
            this.panel2.TabIndex = 2;
            // 
            // open_cb
            // 
            this.open_cb.BackColor = System.Drawing.Color.Transparent;
            this.open_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.open_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.open_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.open_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.open_cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.open_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.open_cb.ItemHeight = 30;
            this.open_cb.Location = new System.Drawing.Point(710, 17);
            this.open_cb.Name = "open_cb";
            this.open_cb.Size = new System.Drawing.Size(129, 36);
            this.open_cb.TabIndex = 1;
            // 
            // home_button
            // 
            this.home_button.AutoSize = true;
            this.home_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.Location = new System.Drawing.Point(22, 11);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(102, 37);
            this.home_button.TabIndex = 0;
            this.home_button.Text = "Home";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(36, 35);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottom_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label name_of_song;
        private Guna.UI2.WinForms.Guna2ImageButton play_button;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Guna.UI2.WinForms.Guna2ImageButton shuffle_button;
        private Guna.UI2.WinForms.Guna2ImageButton next_button;
        private Guna.UI2.WinForms.Guna2ImageButton rewind_button;
        private Guna.UI2.WinForms.Guna2ImageButton repeat_button;
        private MetroSet_UI.Controls.MetroSetTrackBar metroSetTrackBar1;
        private Guna.UI2.WinForms.Guna2ImageButton volumn_button;
        private Sipaa.Framework.STextBox searching_textbox;
        private Guna.UI2.WinForms.Guna2ImageButton searching_button;
        private System.Windows.Forms.Label home_button;
        private Guna.UI2.WinForms.Guna2ComboBox open_cb;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
