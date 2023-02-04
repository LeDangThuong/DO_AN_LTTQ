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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxAvatar = new System.Windows.Forms.PictureBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnTaiNhac = new System.Windows.Forms.Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.home_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uMyMusic = new DO_AN_LTTQ.uMyMusic();
            this.uAbout = new DO_AN_LTTQ.uAbout();
            this.uAlbum1 = new DO_AN_LTTQ.uAlbum();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 636);
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
            this.panel3.Location = new System.Drawing.Point(23, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 455);
            this.panel3.TabIndex = 6;
            // 
            // About_Button
            // 
            this.About_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.About_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.About_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.About_Button.FillColor = System.Drawing.Color.Gainsboro;
            this.About_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Button.ForeColor = System.Drawing.Color.Black;
            this.About_Button.Image = global::DO_AN_LTTQ.Properties.Resources.question;
            this.About_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.About_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.About_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.About_Button.Location = new System.Drawing.Point(5, 374);
            this.About_Button.Margin = new System.Windows.Forms.Padding(5);
            this.About_Button.Name = "About_Button";
            this.About_Button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.About_Button.Size = new System.Drawing.Size(327, 60);
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
            this.TrangChu_Button.FillColor = System.Drawing.Color.Gainsboro;
            this.TrangChu_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangChu_Button.ForeColor = System.Drawing.Color.Black;
            this.TrangChu_Button.Image = ((System.Drawing.Image)(resources.GetObject("TrangChu_Button.Image")));
            this.TrangChu_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TrangChu_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.TrangChu_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.TrangChu_Button.Location = new System.Drawing.Point(5, 24);
            this.TrangChu_Button.Margin = new System.Windows.Forms.Padding(5);
            this.TrangChu_Button.Name = "TrangChu_Button";
            this.TrangChu_Button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.TrangChu_Button.Size = new System.Drawing.Size(327, 60);
            this.TrangChu_Button.TabIndex = 11;
            this.TrangChu_Button.Text = "Trang chủ";
            this.TrangChu_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.TrangChu_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.TrangChu_Button.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // CaiDat_Button
            // 
            this.CaiDat_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CaiDat_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CaiDat_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CaiDat_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CaiDat_Button.FillColor = System.Drawing.Color.Gainsboro;
            this.CaiDat_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaiDat_Button.ForeColor = System.Drawing.Color.Black;
            this.CaiDat_Button.Image = global::DO_AN_LTTQ.Properties.Resources.setting;
            this.CaiDat_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaiDat_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.CaiDat_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.CaiDat_Button.Location = new System.Drawing.Point(5, 304);
            this.CaiDat_Button.Margin = new System.Windows.Forms.Padding(5);
            this.CaiDat_Button.Name = "CaiDat_Button";
            this.CaiDat_Button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.CaiDat_Button.Size = new System.Drawing.Size(327, 60);
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
            this.ThuVien_Button.FillColor = System.Drawing.Color.Gainsboro;
            this.ThuVien_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ThuVien_Button.ForeColor = System.Drawing.Color.Black;
            this.ThuVien_Button.Image = ((System.Drawing.Image)(resources.GetObject("ThuVien_Button.Image")));
            this.ThuVien_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ThuVien_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.ThuVien_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.ThuVien_Button.Location = new System.Drawing.Point(5, 94);
            this.ThuVien_Button.Margin = new System.Windows.Forms.Padding(5);
            this.ThuVien_Button.Name = "ThuVien_Button";
            this.ThuVien_Button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ThuVien_Button.Size = new System.Drawing.Size(327, 60);
            this.ThuVien_Button.TabIndex = 12;
            this.ThuVien_Button.Text = "Thư viện";
            this.ThuVien_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.ThuVien_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ThuVien_Button.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // Album_Button
            // 
            this.Album_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Album_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Album_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Album_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Album_Button.FillColor = System.Drawing.Color.Gainsboro;
            this.Album_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album_Button.ForeColor = System.Drawing.Color.Black;
            this.Album_Button.Image = ((System.Drawing.Image)(resources.GetObject("Album_Button.Image")));
            this.Album_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Album_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.Album_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Album_Button.Location = new System.Drawing.Point(5, 234);
            this.Album_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Album_Button.Name = "Album_Button";
            this.Album_Button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Album_Button.Size = new System.Drawing.Size(327, 60);
            this.Album_Button.TabIndex = 14;
            this.Album_Button.Text = "Album";
            this.Album_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.Album_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Album_Button.Click += new System.EventHandler(this.guna2TileButton4_Click);
            // 
            // YeuThich_Button
            // 
            this.YeuThich_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.YeuThich_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.YeuThich_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.YeuThich_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.YeuThich_Button.FillColor = System.Drawing.Color.Gainsboro;
            this.YeuThich_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.YeuThich_Button.ForeColor = System.Drawing.Color.Black;
            this.YeuThich_Button.Image = ((System.Drawing.Image)(resources.GetObject("YeuThich_Button.Image")));
            this.YeuThich_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.YeuThich_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.YeuThich_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.YeuThich_Button.Location = new System.Drawing.Point(5, 164);
            this.YeuThich_Button.Margin = new System.Windows.Forms.Padding(5);
            this.YeuThich_Button.Name = "YeuThich_Button";
            this.YeuThich_Button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.YeuThich_Button.Size = new System.Drawing.Size(327, 60);
            this.YeuThich_Button.TabIndex = 13;
            this.YeuThich_Button.Text = "Yêu thích";
            this.YeuThich_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.YeuThich_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.YeuThich_Button.Click += new System.EventHandler(this.guna2TileButton3_Click);
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
            this.searching_button.Location = new System.Drawing.Point(347, 23);
            this.searching_button.Margin = new System.Windows.Forms.Padding(5);
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
            this.searching_textbox.Location = new System.Drawing.Point(23, 20);
            this.searching_textbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.searching_textbox.Multiline = false;
            this.searching_textbox.Name = "searching_textbox";
            this.searching_textbox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.searching_textbox.PasswordChar = false;
            this.searching_textbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searching_textbox.PlaceholderText = "";
            this.searching_textbox.Size = new System.Drawing.Size(374, 50);
            this.searching_textbox.TabIndex = 35;
            this.searching_textbox.Texts = "Tìm kiếm";
            this.searching_textbox.UnderlinedStyle = false;
            this.searching_textbox.Enter += new System.EventHandler(this.searching_textbox_Enter);
            this.searching_textbox.Leave += new System.EventHandler(this.searching_textbox_Leave);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.SystemColors.Control;
            this.bottom_panel.Controls.Add(this.label2);
            this.bottom_panel.Controls.Add(this.label1);
            this.bottom_panel.Controls.Add(this.picboxAvatar);
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
            this.bottom_panel.Location = new System.Drawing.Point(0, 636);
            this.bottom_panel.Margin = new System.Windows.Forms.Padding(4);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(1575, 171);
            this.bottom_panel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1507, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "5:00";
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
            // picboxAvatar
            // 
            this.picboxAvatar.Location = new System.Drawing.Point(36, 44);
            this.picboxAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.picboxAvatar.Name = "picboxAvatar";
            this.picboxAvatar.Size = new System.Drawing.Size(123, 114);
            this.picboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAvatar.TabIndex = 11;
            this.picboxAvatar.TabStop = false;
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
            // volumn_button
            // 
            this.volumn_button.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.volumn_button.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.volumn_button.Image = ((System.Drawing.Image)(resources.GetObject("volumn_button.Image")));
            this.volumn_button.ImageOffset = new System.Drawing.Point(0, 0);
            this.volumn_button.ImageRotate = 0F;
            this.volumn_button.ImageSize = new System.Drawing.Size(32, 32);
            this.volumn_button.Location = new System.Drawing.Point(1291, 76);
            this.volumn_button.Margin = new System.Windows.Forms.Padding(4);
            this.volumn_button.Name = "volumn_button";
            this.volumn_button.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.volumn_button.Size = new System.Drawing.Size(85, 66);
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
            this.metroSetTrackBar1.Location = new System.Drawing.Point(1384, 100);
            this.metroSetTrackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.metroSetTrackBar1.Maximum = 100;
            this.metroSetTrackBar1.Minimum = 0;
            this.metroSetTrackBar1.Name = "metroSetTrackBar1";
            this.metroSetTrackBar1.Size = new System.Drawing.Size(95, 16);
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
            this.repeat_button.Location = new System.Drawing.Point(1025, 76);
            this.repeat_button.Margin = new System.Windows.Forms.Padding(4);
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
            this.shuffle_button.Location = new System.Drawing.Point(501, 76);
            this.shuffle_button.Margin = new System.Windows.Forms.Padding(4);
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
            this.next_button.Location = new System.Drawing.Point(887, 76);
            this.next_button.Margin = new System.Windows.Forms.Padding(4);
            this.next_button.Name = "next_button";
            this.next_button.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.next_button.Size = new System.Drawing.Size(85, 66);
            this.next_button.TabIndex = 5;
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
            this.rewind_button.Location = new System.Drawing.Point(636, 76);
            this.rewind_button.Margin = new System.Windows.Forms.Padding(4);
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
            this.play_button.Location = new System.Drawing.Point(760, 76);
            this.play_button.Margin = new System.Windows.Forms.Padding(4);
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
            this.guna2TrackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TrackBar1.Maximum = 500;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(1165, 28);
            this.guna2TrackBar1.TabIndex = 2;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2TrackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2TrackBar1_MouseDown);
            // 
            // lblTacGiaNhac
            // 
            this.lblTacGiaNhac.AutoSize = true;
            this.lblTacGiaNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGiaNhac.Location = new System.Drawing.Point(217, 100);
            this.lblTacGiaNhac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTacGiaNhac.Name = "lblTacGiaNhac";
            this.lblTacGiaNhac.Size = new System.Drawing.Size(133, 29);
            this.lblTacGiaNhac.TabIndex = 1;
            this.lblTacGiaNhac.Text = "Tên bài hát";
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
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnAn);
            this.panel2.Controls.Add(this.btnTaiNhac);
            this.panel2.Controls.Add(this.guna2ComboBox1);
            this.panel2.Controls.Add(this.home_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(409, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 91);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DO_AN_LTTQ.Properties.Resources.moonlight;
            this.pictureBox1.Location = new System.Drawing.Point(1104, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAn
            // 
            this.btnAn.BackColor = System.Drawing.Color.Gray;
            this.btnAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAn.Location = new System.Drawing.Point(420, 16);
            this.btnAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(179, 52);
            this.btnAn.TabIndex = 3;
            this.btnAn.Text = "Ẩn/Hiện";
            this.btnAn.UseVisualStyleBackColor = false;
            this.btnAn.Click += new System.EventHandler(this.btnAn_Click);
            // 
            // btnTaiNhac
            // 
            this.btnTaiNhac.BackColor = System.Drawing.Color.Gray;
            this.btnTaiNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiNhac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTaiNhac.Location = new System.Drawing.Point(620, 16);
            this.btnTaiNhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiNhac.Name = "btnTaiNhac";
            this.btnTaiNhac.Size = new System.Drawing.Size(179, 52);
            this.btnTaiNhac.TabIndex = 3;
            this.btnTaiNhac.Text = "Tải Nhạc";
            this.btnTaiNhac.UseVisualStyleBackColor = false;
            this.btnTaiNhac.Click += new System.EventHandler(this.btnTaiNhac_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Open file(s)",
            "Open folder",
            "Open URL"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(851, 21);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(185, 36);
            this.guna2ComboBox1.TabIndex = 1;
            // 
            // home_label
            // 
            this.home_label.AutoSize = true;
            this.home_label.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label.Location = new System.Drawing.Point(21, 16);
            this.home_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(226, 61);
            this.home_label.TabIndex = 0;
            this.home_label.Text = "Trang chủ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uMyMusic
            // 
            this.uMyMusic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uMyMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uMyMusic.Location = new System.Drawing.Point(0, 0);
            this.uMyMusic.Name = "uMyMusic";
            this.uMyMusic.Size = new System.Drawing.Size(1575, 807);
            this.uMyMusic.TabIndex = 4;
            // 
            // uAbout
            // 
            this.uAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uAbout.Location = new System.Drawing.Point(0, 0);
            this.uAbout.Name = "uAbout";
            this.uAbout.Size = new System.Drawing.Size(1575, 807);
            this.uAbout.TabIndex = 5;
            // 
            // uAlbum1
            // 
            this.uAlbum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uAlbum1.Location = new System.Drawing.Point(0, 0);
            this.uAlbum1.Name = "uAlbum1";
            this.uAlbum1.Size = new System.Drawing.Size(1575, 807);
            this.uAlbum1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 807);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.uMyMusic);
            this.Controls.Add(this.uAbout);
            this.Controls.Add(this.uAlbum1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TileButton Album_Button;
        private Guna.UI2.WinForms.Guna2TileButton YeuThich_Button;
        private Guna.UI2.WinForms.Guna2TileButton ThuVien_Button;
        private Guna.UI2.WinForms.Guna2TileButton TrangChu_Button;
        private System.Windows.Forms.Button btnTaiNhac;
        public AxWMPLib.AxWindowsMediaPlayer player;
        public System.Windows.Forms.PictureBox picboxAvatar;
        public System.Windows.Forms.Label name_of_song;
        private System.Windows.Forms.Button btnAn;
        public System.Windows.Forms.Label lblTacGiaNhac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TileButton About_Button;
        private Guna.UI2.WinForms.Guna2TileButton CaiDat_Button;
        private uMyMusic uMyMusic;
        private uAbout uAbout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private uAlbum uAlbum1;
    }
}

