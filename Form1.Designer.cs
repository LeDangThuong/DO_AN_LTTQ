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
            this.panel3 = new System.Windows.Forms.Panel();
            this.About_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.TrangChu_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.CaiDat_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.ThuVien_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.Album_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.YeuThich_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.searching_button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searching_textbox = new Sipaa.Framework.STextBox();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.picboxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.picture_theme = new System.Windows.Forms.PictureBox();
            this.btnTaiNhac = new System.Windows.Forms.Button();
            this.home_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autoNextSongTimer = new System.Windows.Forms.Timer(this.components);
            this.rotateTimer = new System.Windows.Forms.Timer(this.components);
            this.flowPanelMedia = new System.Windows.Forms.FlowLayoutPanel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.uMyMusic = new DO_AN_LTTQ.uMyMusic();
            this.uAlbumDetail1 = new DO_AN_LTTQ.uAlbumDetail();
            this.uAlbum = new DO_AN_LTTQ.uAlbum();
            this.uAbout = new DO_AN_LTTQ.uAbout();
            this.uCaiDat = new DO_AN_LTTQ.uCaiDat();
            this.uYeuThich1 = new DO_AN_LTTQ.uYeuThich();
            this.myMusic2 = new DO_AN_LTTQ.MyMusic();
            this.uReName1 = new DO_AN_LTTQ.uReName();
            this.uNewAlbum1 = new DO_AN_LTTQ.uNewAlbum();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bottom_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_theme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.searching_button);
            this.panel1.Controls.Add(this.searching_textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 603);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.About_Button);
            this.panel3.Controls.Add(this.TrangChu_Button);
            this.panel3.Controls.Add(this.CaiDat_Button);
            this.panel3.Controls.Add(this.ThuVien_Button);
            this.panel3.Controls.Add(this.Album_Button);
            this.panel3.Controls.Add(this.YeuThich_Button);
            this.panel3.Location = new System.Drawing.Point(13, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 510);
            this.panel3.TabIndex = 6;
            // 
            // About_Button
            // 
            this.About_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.About_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.About_Button.FillColor = System.Drawing.SystemColors.Control;
            this.About_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Button.ForeColor = System.Drawing.Color.Black;
            this.About_Button.Image = global::DO_AN_LTTQ.Properties.Resources.question;
            this.About_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.About_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.About_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.About_Button.Location = new System.Drawing.Point(-1, 394);
            this.About_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.About_Button.Name = "About_Button";
            this.About_Button.Padding = new System.Windows.Forms.Padding(0, 0, 7, 6);
            this.About_Button.Size = new System.Drawing.Size(387, 64);
            this.About_Button.TabIndex = 37;
            this.About_Button.Text = "About";
            this.About_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.About_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.About_Button.Click += new System.EventHandler(this.About_Button_Click);
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
            this.TrangChu_Button.Location = new System.Drawing.Point(0, 14);
            this.TrangChu_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrangChu_Button.Name = "TrangChu_Button";
            this.TrangChu_Button.Padding = new System.Windows.Forms.Padding(0, 0, 7, 6);
            this.TrangChu_Button.Size = new System.Drawing.Size(385, 64);
            this.TrangChu_Button.TabIndex = 11;
            this.TrangChu_Button.Text = "Trang chủ";
            this.TrangChu_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.TrangChu_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.TrangChu_Button.Click += new System.EventHandler(this.TrangChu_Button_Click);
            // 
            // CaiDat_Button
            // 
            this.CaiDat_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CaiDat_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CaiDat_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CaiDat_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CaiDat_Button.FillColor = System.Drawing.SystemColors.Control;
            this.CaiDat_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaiDat_Button.ForeColor = System.Drawing.Color.Black;
            this.CaiDat_Button.Image = global::DO_AN_LTTQ.Properties.Resources.setting;
            this.CaiDat_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaiDat_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.CaiDat_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.CaiDat_Button.Location = new System.Drawing.Point(0, 318);
            this.CaiDat_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CaiDat_Button.Name = "CaiDat_Button";
            this.CaiDat_Button.Padding = new System.Windows.Forms.Padding(0, 0, 7, 6);
            this.CaiDat_Button.Size = new System.Drawing.Size(387, 64);
            this.CaiDat_Button.TabIndex = 36;
            this.CaiDat_Button.Text = "Cài đặt";
            this.CaiDat_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.CaiDat_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.CaiDat_Button.Click += new System.EventHandler(this.CaiDat_Button_Click);
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
            this.ThuVien_Button.Location = new System.Drawing.Point(-1, 91);
            this.ThuVien_Button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ThuVien_Button.Name = "ThuVien_Button";
            this.ThuVien_Button.Padding = new System.Windows.Forms.Padding(0, 0, 7, 6);
            this.ThuVien_Button.Size = new System.Drawing.Size(387, 64);
            this.ThuVien_Button.TabIndex = 12;
            this.ThuVien_Button.Text = "Thư viện";
            this.ThuVien_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.ThuVien_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ThuVien_Button.Click += new System.EventHandler(this.ThuVien_Button_Click);
            // 
            // Album_Button
            // 
            this.Album_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Album_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Album_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Album_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Album_Button.FillColor = System.Drawing.SystemColors.Control;
            this.Album_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album_Button.ForeColor = System.Drawing.Color.Black;
            this.Album_Button.Image = ((System.Drawing.Image)(resources.GetObject("Album_Button.Image")));
            this.Album_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Album_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.Album_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Album_Button.Location = new System.Drawing.Point(0, 242);
            this.Album_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Album_Button.Name = "Album_Button";
            this.Album_Button.Padding = new System.Windows.Forms.Padding(0, 0, 7, 6);
            this.Album_Button.Size = new System.Drawing.Size(385, 64);
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
            this.YeuThich_Button.FillColor = System.Drawing.SystemColors.Control;
            this.YeuThich_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.YeuThich_Button.ForeColor = System.Drawing.Color.Black;
            this.YeuThich_Button.Image = ((System.Drawing.Image)(resources.GetObject("YeuThich_Button.Image")));
            this.YeuThich_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.YeuThich_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.YeuThich_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.YeuThich_Button.Location = new System.Drawing.Point(0, 166);
            this.YeuThich_Button.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.YeuThich_Button.Name = "YeuThich_Button";
            this.YeuThich_Button.Padding = new System.Windows.Forms.Padding(0, 0, 7, 6);
            this.YeuThich_Button.Size = new System.Drawing.Size(385, 64);
            this.YeuThich_Button.TabIndex = 13;
            this.YeuThich_Button.Text = "Yêu thích";
            this.YeuThich_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.YeuThich_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.YeuThich_Button.Click += new System.EventHandler(this.YeuThich_Button_Click);
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
            this.searching_button.Location = new System.Drawing.Point(353, 20);
            this.searching_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searching_button.Name = "searching_button";
            this.searching_button.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.searching_button.Size = new System.Drawing.Size(35, 34);
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
            this.searching_textbox.Location = new System.Drawing.Point(12, 16);
            this.searching_textbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searching_textbox.Multiline = false;
            this.searching_textbox.Name = "searching_textbox";
            this.searching_textbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.searching_textbox.PasswordChar = false;
            this.searching_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searching_textbox.PlaceholderText = "";
            this.searching_textbox.Size = new System.Drawing.Size(387, 50);
            this.searching_textbox.TabIndex = 35;
            this.searching_textbox.Texts = "Tìm kiếm";
            this.searching_textbox.UnderlinedStyle = false;
            this.searching_textbox._TextChanged += new System.EventHandler(this.searching_textbox__TextChanged);
            this.searching_textbox.Enter += new System.EventHandler(this.searching_textbox_Enter);
            this.searching_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searching_textbox_KeyDown);
            this.searching_textbox.Leave += new System.EventHandler(this.searching_textbox_Leave);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.SystemColors.Control;
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
            this.bottom_panel.Location = new System.Drawing.Point(0, 603);
            this.bottom_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1669, 177);
            this.bottom_panel.TabIndex = 1;
            // 
            // picboxAvatar
            // 
            this.picboxAvatar.ImageRotate = 0F;
            this.picboxAvatar.Location = new System.Drawing.Point(37, 20);
            this.picboxAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxAvatar.Name = "picboxAvatar";
            this.picboxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picboxAvatar.Size = new System.Drawing.Size(145, 145);
            this.picboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAvatar.TabIndex = 14;
            this.picboxAvatar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1547, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "0:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "0:00";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(445, 0);
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
            this.volumn_button.Location = new System.Drawing.Point(1323, 76);
            this.volumn_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volumn_button.Name = "volumn_button";
            this.volumn_button.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.volumn_button.Size = new System.Drawing.Size(85, 66);
            this.volumn_button.TabIndex = 9;
            this.volumn_button.Click += new System.EventHandler(this.volumn_button_Click);
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
            this.metroSetTrackBar1.Location = new System.Drawing.Point(1415, 100);
            this.metroSetTrackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroSetTrackBar1.Maximum = 100;
            this.metroSetTrackBar1.Minimum = 0;
            this.metroSetTrackBar1.Name = "metroSetTrackBar1";
            this.metroSetTrackBar1.Size = new System.Drawing.Size(117, 16);
            this.metroSetTrackBar1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTrackBar1.StyleManager = null;
            this.metroSetTrackBar1.TabIndex = 8;
            this.metroSetTrackBar1.Text = "metroSetTrackBar1";
            this.metroSetTrackBar1.ThemeAuthor = "Narwin";
            this.metroSetTrackBar1.ThemeName = "MetroLite";
            this.metroSetTrackBar1.Value = 15;
            this.metroSetTrackBar1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.metroSetTrackBar1.Scroll += new MetroSet_UI.Controls.MetroSetTrackBar.ScrollEventHandler(this.metroSetTrackBar1_Scroll);
            this.metroSetTrackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroSetTrackBar1_MouseDown);
            // 
            // repeat_button
            // 
            this.repeat_button.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.repeat_button.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.repeat_button.Image = ((System.Drawing.Image)(resources.GetObject("repeat_button.Image")));
            this.repeat_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.repeat_button.ImageRotate = 0F;
            this.repeat_button.ImageSize = new System.Drawing.Size(33, 33);
            this.repeat_button.Location = new System.Drawing.Point(1065, 76);
            this.repeat_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.repeat_button.Name = "repeat_button";
            this.repeat_button.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.repeat_button.Size = new System.Drawing.Size(85, 66);
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
            this.shuffle_button.Location = new System.Drawing.Point(561, 76);
            this.shuffle_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shuffle_button.Name = "shuffle_button";
            this.shuffle_button.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.shuffle_button.Size = new System.Drawing.Size(85, 66);
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
            this.next_button.Location = new System.Drawing.Point(931, 76);
            this.next_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next_button.Name = "next_button";
            this.next_button.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.next_button.Size = new System.Drawing.Size(85, 66);
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
            this.rewind_button.Location = new System.Drawing.Point(683, 76);
            this.rewind_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rewind_button.Name = "rewind_button";
            this.rewind_button.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.rewind_button.Size = new System.Drawing.Size(85, 66);
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
            this.play_button.Location = new System.Drawing.Point(807, 76);
            this.play_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.play_button.Name = "play_button";
            this.play_button.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.play_button.Size = new System.Drawing.Size(85, 66);
            this.play_button.TabIndex = 3;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            this.play_button.MouseEnter += new System.EventHandler(this.play_button_MouseEnter);
            this.play_button.MouseLeave += new System.EventHandler(this.play_button_MouseLeave);
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(313, 20);
            this.guna2TrackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TrackBar1.Maximum = 300;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(1200, 28);
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
            this.lblTacGiaNhac.Location = new System.Drawing.Point(217, 100);
            this.lblTacGiaNhac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacGiaNhac.Name = "lblTacGiaNhac";
            this.lblTacGiaNhac.Size = new System.Drawing.Size(132, 29);
            this.lblTacGiaNhac.TabIndex = 1;
            this.lblTacGiaNhac.Text = "Tên tác giả";
            // 
            // name_of_song
            // 
            this.name_of_song.AutoSize = true;
            this.name_of_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_song.Location = new System.Drawing.Point(203, 66);
            this.name_of_song.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_of_song.Name = "name_of_song";
            this.name_of_song.Size = new System.Drawing.Size(133, 29);
            this.name_of_song.TabIndex = 1;
            this.name_of_song.Text = "Tên bài hát";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.picture_theme);
            this.panel2.Controls.Add(this.btnTaiNhac);
            this.panel2.Controls.Add(this.home_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(405, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 110);
            this.panel2.TabIndex = 2;
            // 
            // picture_theme
            // 
            this.picture_theme.Image = global::DO_AN_LTTQ.Properties.Resources.moonlight;
            this.picture_theme.Location = new System.Drawing.Point(1188, 31);
            this.picture_theme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_theme.Name = "picture_theme";
            this.picture_theme.Size = new System.Drawing.Size(47, 46);
            this.picture_theme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_theme.TabIndex = 6;
            this.picture_theme.TabStop = false;
            this.picture_theme.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnTaiNhac
            // 
            this.btnTaiNhac.BackColor = System.Drawing.Color.Gray;
            this.btnTaiNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiNhac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTaiNhac.Location = new System.Drawing.Point(991, 25);
            this.btnTaiNhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiNhac.Name = "btnTaiNhac";
            this.btnTaiNhac.Size = new System.Drawing.Size(179, 52);
            this.btnTaiNhac.TabIndex = 3;
            this.btnTaiNhac.Text = "Tải Nhạc";
            this.btnTaiNhac.UseVisualStyleBackColor = false;
            this.btnTaiNhac.Click += new System.EventHandler(this.btnTaiNhac_Click);
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.Location = new System.Drawing.Point(21, 16);
            this.home_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(292, 61);
            this.home_label.TabIndex = 0;
            this.home_label.Text = "Media Player";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowPanelMedia
            // 
            this.flowPanelMedia.Location = new System.Drawing.Point(0, 0);
            this.flowPanelMedia.Name = "flowPanelMedia";
            this.flowPanelMedia.Size = new System.Drawing.Size(200, 100);
            this.flowPanelMedia.TabIndex = 0;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(435, 3);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(333, 23);
            this.player.TabIndex = 10;
            this.player.Visible = false;
            // 
            // uMyMusic
            // 
            this.uMyMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uMyMusic.Location = new System.Drawing.Point(409, 110);
            this.uMyMusic.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uMyMusic.Name = "uMyMusic";
            this.uMyMusic.Size = new System.Drawing.Size(1263, 494);
            this.uMyMusic.TabIndex = 3;
            this.uMyMusic.Load += new System.EventHandler(this.uMyMusic_Load);
            // 
            // uAlbumDetail1
            // 
            this.uAlbumDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uAlbumDetail1.Location = new System.Drawing.Point(405, 110);
            this.uAlbumDetail1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uAlbumDetail1.Name = "uAlbumDetail1";
            this.uAlbumDetail1.Size = new System.Drawing.Size(1269, 494);
            this.uAlbumDetail1.TabIndex = 13;
            this.uAlbumDetail1.Load += new System.EventHandler(this.uAlbumDetail1_Load);
            // 
            // uAlbum
            // 
            this.uAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uAlbum.Location = new System.Drawing.Point(407, 110);
            this.uAlbum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uAlbum.Name = "uAlbum";
            this.uAlbum.Size = new System.Drawing.Size(1275, 494);
            this.uAlbum.TabIndex = 9;
            this.uAlbum.Load += new System.EventHandler(this.uAlbum1_Load);
            // 
            // uAbout
            // 
            this.uAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uAbout.Location = new System.Drawing.Point(407, 110);
            this.uAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uAbout.Name = "uAbout";
            this.uAbout.Size = new System.Drawing.Size(1275, 494);
            this.uAbout.TabIndex = 10;
            // 
            // uCaiDat
            // 
            this.uCaiDat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCaiDat.Location = new System.Drawing.Point(408, 110);
            this.uCaiDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uCaiDat.Name = "uCaiDat";
            this.uCaiDat.Size = new System.Drawing.Size(1275, 494);
            this.uCaiDat.TabIndex = 11;
            // 
            // uYeuThich1
            // 
            this.uYeuThich1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uYeuThich1.AutoScroll = true;
            this.uYeuThich1.Location = new System.Drawing.Point(405, 110);
            this.uYeuThich1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uYeuThich1.Name = "uYeuThich1";
            this.uYeuThich1.Size = new System.Drawing.Size(1267, 494);
            this.uYeuThich1.TabIndex = 10;
            // 
            // myMusic2
            // 
            this.myMusic2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myMusic2.Location = new System.Drawing.Point(405, 110);
            this.myMusic2.Margin = new System.Windows.Forms.Padding(5);
            this.myMusic2.Name = "myMusic2";
            this.myMusic2.Size = new System.Drawing.Size(1276, 494);
            this.myMusic2.TabIndex = 15;
            // 
            // uReName1
            // 
            this.uReName1.BackColor = System.Drawing.Color.LightGray;
            this.uReName1.Location = new System.Drawing.Point(807, 119);
            this.uReName1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uReName1.Name = "uReName1";
            this.uReName1.Size = new System.Drawing.Size(533, 448);
            this.uReName1.TabIndex = 14;
            this.uReName1.Load += new System.EventHandler(this.uReName1_Load);
            // 
            // uNewAlbum1
            // 
            this.uNewAlbum1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uNewAlbum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uNewAlbum1.Location = new System.Drawing.Point(821, 119);
            this.uNewAlbum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uNewAlbum1.Name = "uNewAlbum1";
            this.uNewAlbum1.Size = new System.Drawing.Size(472, 411);
            this.uNewAlbum1.TabIndex = 12;
            this.uNewAlbum1.Load += new System.EventHandler(this.uNewAlbum1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.uMyMusic);
            this.Controls.Add(this.uAlbumDetail1);
            this.Controls.Add(this.uAlbum);
            this.Controls.Add(this.uAbout);
            this.Controls.Add(this.uCaiDat);
            this.Controls.Add(this.uYeuThich1);
            this.Controls.Add(this.myMusic2);
            this.Controls.Add(this.uReName1);
            this.Controls.Add(this.uNewAlbum1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TST Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_theme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private Guna.UI2.WinForms.Guna2TileButton CaiDat_Button;
        private Guna.UI2.WinForms.Guna2TileButton About_Button;
        private System.Windows.Forms.Button btnTaiNhac;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public System.Windows.Forms.Label name_of_song;

        public System.Windows.Forms.Label lblTacGiaNhac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
      
        private System.Windows.Forms.Panel panel3;
      
        private Guna.UI2.WinForms.Guna2CirclePictureBox picboxAvatar;
        private uAlbum uAlbum;
       
        private System.Windows.Forms.Timer autoNextSongTimer;
        private System.Windows.Forms.Timer rotateTimer;
      
        

        private System.Windows.Forms.FlowLayoutPanel flowPanelMedia;

        private uMyMusic uMyMusic;
        private uAbout uAbout;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.PictureBox picture_theme;
        private uCaiDat uCaiDat;
        private uNewAlbum uNewAlbum1;
        private uAlbumDetail uAlbumDetail1;
        private uReName uReName1;

        private uYeuThich uYeuThich1;
        private MyMusic myMusic2;
    }
}

