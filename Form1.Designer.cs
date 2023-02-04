using System.Drawing;

namespace DO_AN_LTTQ
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TrangChu_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.Album_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.YeuThich_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.ThuVien_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searching_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searching_textbox = new Sipaa.Framework.STextBox();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.picboxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.volumn_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.metroSetTrackBar1 = new MetroSet_UI.Controls.MetroSetTrackBar();
            this.repeat_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.shuffle_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.next_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.rewind_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.play_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblTacGiaNhac = new System.Windows.Forms.Label();
            this.name_of_song = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaiNhac = new System.Windows.Forms.Button();
            this.home_label = new System.Windows.Forms.Label();
            this.uMyMusic = new DO_AN_LTTQ.uMyMusic();
            this.uMyMusic1 = new DO_AN_LTTQ.uMyMusic();
            this.uAlbum1 = new DO_AN_LTTQ.uAlbum();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autoNextSongTimer = new System.Windows.Forms.Timer(this.components);
            this.rotateTimer = new System.Windows.Forms.Timer(this.components);
            this.myMusic1 = new DO_AN_LTTQ.MyMusic();
            this.flowPanelMedia = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.searching_button);
            this.panel1.Controls.Add(this.searching_textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 512);
            this.panel1.TabIndex = 0;
            // 
            // TrangChu_Button
            // 
            this.TrangChu_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TrangChu_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TrangChu_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TrangChu_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TrangChu_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TrangChu_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TrangChu_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangChu_Button.ForeColor = System.Drawing.Color.Black;
            this.TrangChu_Button.Image = ((System.Drawing.Image)(resources.GetObject("TrangChu_Button.Image")));
            this.TrangChu_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TrangChu_Button.ImageOffset = new System.Drawing.Point(0, 20);
            this.TrangChu_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.TrangChu_Button.Location = new System.Drawing.Point(3, 16);
            this.TrangChu_Button.Name = "TrangChu_Button";
            this.TrangChu_Button.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.TrangChu_Button.Size = new System.Drawing.Size(211, 40);
            this.TrangChu_Button.TabIndex = 11;
            this.TrangChu_Button.Text = "Trang chủ";
            this.TrangChu_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.TrangChu_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.TrangChu_Button.Click += new System.EventHandler(this.TrangChu_Button_Click);
            // 
            // Album_Button
            // 
            this.Album_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Album_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Album_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Album_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Album_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Album_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album_Button.ForeColor = System.Drawing.Color.Black;
            this.Album_Button.Image = ((System.Drawing.Image)(resources.GetObject("Album_Button.Image")));
            this.Album_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Album_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.Album_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Album_Button.Location = new System.Drawing.Point(3, 154);
            this.Album_Button.Name = "Album_Button";
            this.Album_Button.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.Album_Button.Size = new System.Drawing.Size(211, 40);
            this.Album_Button.TabIndex = 14;
            this.Album_Button.Text = "Album";
            this.Album_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.Album_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Album_Button.Click += new System.EventHandler(this.Album_Button_Click);
            // 
            // YeuThich_Button
            // 
            this.YeuThich_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.YeuThich_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.YeuThich_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.YeuThich_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.YeuThich_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.YeuThich_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.YeuThich_Button.ForeColor = System.Drawing.Color.Black;
            this.YeuThich_Button.Image = ((System.Drawing.Image)(resources.GetObject("YeuThich_Button.Image")));
            this.YeuThich_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.YeuThich_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.YeuThich_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.YeuThich_Button.Location = new System.Drawing.Point(3, 108);
            this.YeuThich_Button.Name = "YeuThich_Button";
            this.YeuThich_Button.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.YeuThich_Button.Size = new System.Drawing.Size(211, 40);
            this.YeuThich_Button.TabIndex = 13;
            this.YeuThich_Button.Text = "Yêu thích";
            this.YeuThich_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.YeuThich_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.YeuThich_Button.Click += new System.EventHandler(this.YeuThich_Button_Click);
            // 
            // ThuVien_Button
            // 
            this.ThuVien_Button.BackColor = System.Drawing.SystemColors.Control;
            this.ThuVien_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ThuVien_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ThuVien_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ThuVien_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ThuVien_Button.FillColor = System.Drawing.SystemColors.Control;
            this.ThuVien_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ThuVien_Button.ForeColor = System.Drawing.Color.Black;
            this.ThuVien_Button.Image = ((System.Drawing.Image)(resources.GetObject("ThuVien_Button.Image")));
            this.ThuVien_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ThuVien_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.ThuVien_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.ThuVien_Button.Location = new System.Drawing.Point(0, 63);
            this.ThuVien_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ThuVien_Button.Name = "ThuVien_Button";
            this.ThuVien_Button.Padding = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.ThuVien_Button.Size = new System.Drawing.Size(214, 49);
            this.ThuVien_Button.TabIndex = 12;
            this.ThuVien_Button.Text = "Thư viện";
            this.ThuVien_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.ThuVien_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ThuVien_Button.Click += new System.EventHandler(this.ThuVien_Button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TrangChu_Button);
            this.panel3.Controls.Add(this.ThuVien_Button);
            this.panel3.Controls.Add(this.Album_Button);
            this.panel3.Controls.Add(this.YeuThich_Button);
            this.panel3.Location = new System.Drawing.Point(13, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 301);
            this.panel3.TabIndex = 6;
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
            this.searching_button.Location = new System.Drawing.Point(195, 15);
            this.searching_button.Name = "searching_button";
            this.searching_button.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.searching_button.Size = new System.Drawing.Size(26, 28);
            this.searching_button.TabIndex = 10;
            this.searching_button.Click += new System.EventHandler(this.searching_button_Click);
            // 
            // searching_textbox
            // 
            this.searching_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.searching_textbox.BorderColor = System.Drawing.Color.Black;
            this.searching_textbox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.searching_textbox.BorderRadius = 0;
            this.searching_textbox.BorderSize = 2;
            this.searching_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searching_textbox.ForeColor = System.Drawing.Color.Silver;
            this.searching_textbox.Location = new System.Drawing.Point(13, 13);
            this.searching_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.searching_textbox.Multiline = false;
            this.searching_textbox.Name = "searching_textbox";
            this.searching_textbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searching_textbox.PasswordChar = false;
            this.searching_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searching_textbox.PlaceholderText = "";
            this.searching_textbox.Size = new System.Drawing.Size(214, 36);
            this.searching_textbox.TabIndex = 35;
            this.searching_textbox.Texts = "Tìm kiếm";
            this.searching_textbox.UnderlinedStyle = false;
            this.searching_textbox.Enter += new System.EventHandler(this.searching_textbox_Enter);
            this.searching_textbox.Leave += new System.EventHandler(this.searching_textbox_Leave);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.bottom_panel.Controls.Add(this.picboxAvatar);
            this.bottom_panel.Controls.Add(this.label2);
            this.bottom_panel.Controls.Add(this.label1);
            this.bottom_panel.Controls.Add(this.player);
            this.bottom_panel.Controls.Add(this.volumn_button);
            this.bottom_panel.Controls.Add(this.metroSetTrackBar1);
            this.bottom_panel.Controls.Add(this.repeat_button);
            this.bottom_panel.Controls.Add(this.shuffle_button);
            this.bottom_panel.Controls.Add(this.next_button);
            this.bottom_panel.Controls.Add(this.rewind_button);
            this.bottom_panel.Controls.Add(this.play_button);
            this.bottom_panel.Controls.Add(this.guna2TrackBar1);
            this.bottom_panel.Controls.Add(this.lblTacGiaNhac);
            this.bottom_panel.Controls.Add(this.name_of_song);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 512);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1135, 113);
            this.bottom_panel.TabIndex = 1;
            // 
            // picboxAvatar
            // 
            this.picboxAvatar.ImageRotate = 0F;
            this.picboxAvatar.Location = new System.Drawing.Point(28, 16);
            this.picboxAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picboxAvatar.Name = "picboxAvatar";
            this.picboxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picboxAvatar.Size = new System.Drawing.Size(109, 118);
            this.picboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAvatar.TabIndex = 14;
            this.picboxAvatar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1130, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "5:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "0:00";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(435, 3);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(333, 23);
            this.player.TabIndex = 10;
            this.player.Visible = false;
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
            this.volumn_button.MouseEnter += new System.EventHandler(this.volumn_button_MouseEnter);
            this.volumn_button.MouseLeave += new System.EventHandler(this.volumn_button_MouseLeave);
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
            this.metroSetTrackBar1.Value = 30;
            this.metroSetTrackBar1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.metroSetTrackBar1.Scroll += new MetroSet_UI.Controls.MetroSetTrackBar.ScrollEventHandler(this.metroSetTrackBar1_Scroll);
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
            this.repeat_button.Click += new System.EventHandler(this.repeat_button_Click);
            this.repeat_button.MouseEnter += new System.EventHandler(this.repeat_button_MouseEnter);
            this.repeat_button.MouseLeave += new System.EventHandler(this.repeat_button_MouseLeave);
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
            this.shuffle_button.Click += new System.EventHandler(this.shuffle_button_Click);
            this.shuffle_button.MouseEnter += new System.EventHandler(this.shuffle_button_MouseEnter);
            this.shuffle_button.MouseLeave += new System.EventHandler(this.shuffle_button_MouseLeave);
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
            this.next_button.MouseEnter += new System.EventHandler(this.next_button_MouseEnter);
            this.next_button.MouseLeave += new System.EventHandler(this.next_button_MouseLeave);
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
            this.rewind_button.Click += new System.EventHandler(this.rewind_button_Click);
            this.rewind_button.MouseEnter += new System.EventHandler(this.Rewind_MouseEnter);
            this.rewind_button.MouseLeave += new System.EventHandler(this.Rewind_MouseLeave);
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
            this.play_button.MouseEnter += new System.EventHandler(this.play_button_MouseEnter);
            this.play_button.MouseLeave += new System.EventHandler(this.play_button_MouseLeave);
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(235, 16);
            this.guna2TrackBar1.Maximum = 300;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(874, 23);
            this.guna2TrackBar1.TabIndex = 2;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBar1.Value = 0;
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            this.guna2TrackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2TrackBar1_MouseDown);
            // 
            // lblTacGiaNhac
            // 
            this.lblTacGiaNhac.AutoSize = true;
            this.lblTacGiaNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGiaNhac.Location = new System.Drawing.Point(163, 81);
            this.lblTacGiaNhac.Name = "lblTacGiaNhac";
            this.lblTacGiaNhac.Size = new System.Drawing.Size(88, 20);
            this.lblTacGiaNhac.TabIndex = 1;
            this.lblTacGiaNhac.Text = "Tên bài hát";
            // 
            // name_of_song
            // 
            this.name_of_song.AutoSize = true;
            this.name_of_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_song.Location = new System.Drawing.Point(152, 54);
            this.name_of_song.Name = "name_of_song";
            this.name_of_song.Size = new System.Drawing.Size(88, 20);
            this.name_of_song.TabIndex = 1;
            this.name_of_song.Text = "Tên bài hát";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.btnTaiNhac);
            this.panel2.Controls.Add(this.home_label);
            this.panel2.Controls.Add(this.uMyMusic);
            this.panel2.Controls.Add(this.uMyMusic1);
            this.panel2.Controls.Add(this.uAlbum1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 512);
            this.panel2.TabIndex = 2;
            // 
            // btnTaiNhac
            // 
            this.btnTaiNhac.BackColor = System.Drawing.Color.Gray;
            this.btnTaiNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiNhac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTaiNhac.Location = new System.Drawing.Point(465, 13);
            this.btnTaiNhac.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiNhac.Name = "btnTaiNhac";
            this.btnTaiNhac.Size = new System.Drawing.Size(134, 42);
            this.btnTaiNhac.TabIndex = 3;
            this.btnTaiNhac.Text = "Tải Nhạc";
            this.btnTaiNhac.UseVisualStyleBackColor = false;
            this.btnTaiNhac.Click += new System.EventHandler(this.btnTaiNhac_Click);
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.Location = new System.Drawing.Point(16, 13);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(164, 45);
            this.home_label.TabIndex = 0;
            this.home_label.Text = "Trang chủ";
            // 
            // uMyMusic
            // 
            this.uMyMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uMyMusic.Location = new System.Drawing.Point(0, 80);
            this.uMyMusic.Margin = new System.Windows.Forms.Padding(2);
            this.uMyMusic.Name = "uMyMusic";
            this.uMyMusic.Size = new System.Drawing.Size(895, 432);
            this.uMyMusic.TabIndex = 7;
            // 
            // uMyMusic1
            // 
            this.uMyMusic1.Location = new System.Drawing.Point(0, 76);
            this.uMyMusic1.Margin = new System.Windows.Forms.Padding(2);
            this.uMyMusic1.Name = "uMyMusic1";
            this.uMyMusic1.Size = new System.Drawing.Size(882, 436);
            this.uMyMusic1.TabIndex = 8;
            // 
            // uAlbum1
            // 
            this.uAlbum1.Location = new System.Drawing.Point(0, 80);
            this.uAlbum1.Margin = new System.Windows.Forms.Padding(2);
            this.uAlbum1.Name = "uAlbum1";
            this.uAlbum1.Size = new System.Drawing.Size(884, 432);
            this.uAlbum1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(828, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myMusic1
            // 
            this.myMusic1.Location = new System.Drawing.Point(0, 0);
            this.myMusic1.Name = "myMusic1";
            this.myMusic1.Size = new System.Drawing.Size(965, 453);
            this.myMusic1.TabIndex = 0;
            // 
            // flowPanelMedia
            // 
            this.flowPanelMedia.Location = new System.Drawing.Point(0, 0);
            this.flowPanelMedia.Name = "flowPanelMedia";
            this.flowPanelMedia.Size = new System.Drawing.Size(200, 100);
            this.flowPanelMedia.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottom_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Label home_label;
        private Guna.UI2.WinForms.Guna2TileButton Album_Button;
        private Guna.UI2.WinForms.Guna2TileButton YeuThich_Button;
        private Guna.UI2.WinForms.Guna2TileButton ThuVien_Button;
        private Guna.UI2.WinForms.Guna2TileButton TrangChu_Button;
        private System.Windows.Forms.Button btnTaiNhac;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public System.Windows.Forms.Label name_of_song;
        private System.Windows.Forms.Button btnAn;
        public System.Windows.Forms.Label lblTacGiaNhac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private uAbout uAbout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private uMyMusic uMyMusic;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxAvatar;
        private uMyMusic uMyMusic1;
        private uAlbum uAlbum1;
        private MyMusic My_Music;
        private System.Windows.Forms.Timer autoNextSongTimer;
        private System.Windows.Forms.Timer rotateTimer;

        private MyMusic myMusic1;

        private System.Windows.Forms.FlowLayoutPanel flowPanelMedia;
    }
}

