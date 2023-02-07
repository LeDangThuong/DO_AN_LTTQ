namespace DO_AN_LTTQ
{
    partial class MyMusic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Arrange = new System.Windows.Forms.TabPage();
            this.TabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.PanelMusic = new System.Windows.Forms.Panel();
            this.ScrollSongs = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Optional_label = new System.Windows.Forms.Label();
            this.TotalTime_label = new System.Windows.Forms.Label();
            this.ArtistName = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.PanelMusic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Arrange
            // 
            this.Arrange.Location = new System.Drawing.Point(4, 42);
            this.Arrange.Name = "Arrange";
            this.Arrange.Size = new System.Drawing.Size(957, 411);
            this.Arrange.TabIndex = 0;
            this.Arrange.Text = "Sắp xếp theo";
            // 
            // TabControl1
            // 
            this.TabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.TabControl1.AnimateTime = 200;
            this.TabControl1.BackgroundColor = System.Drawing.Color.White;
            this.TabControl1.Controls.Add(this.Arrange);
            this.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl1.IsDerivedStyle = true;
            this.TabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.TabControl1.Location = new System.Drawing.Point(0, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl1.Size = new System.Drawing.Size(965, 457);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.Speed = 100;
            this.TabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.TabControl1.StyleManager = null;
            this.TabControl1.TabIndex = 2;
            this.TabControl1.ThemeAuthor = "White";
            this.TabControl1.ThemeName = "MetroLite";
            this.TabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TabControl1.UseAnimation = false;
            // 
            // PanelMusic
            // 
            this.PanelMusic.Controls.Add(this.ScrollSongs);
            this.PanelMusic.Location = new System.Drawing.Point(4, 82);
            this.PanelMusic.Name = "PanelMusic";
            this.PanelMusic.Size = new System.Drawing.Size(957, 442);
            this.PanelMusic.TabIndex = 3;
            this.PanelMusic.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PanelMusic_ControlAdded);
            this.PanelMusic.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PanelMusic_ControlRemoved);
            // 
            // ScrollSongs
            // 
            this.ScrollSongs.InUpdate = false;
            this.ScrollSongs.LargeChange = 10;
            this.ScrollSongs.Location = new System.Drawing.Point(951, 0);
            this.ScrollSongs.Name = "ScrollSongs";
            this.ScrollSongs.ScrollbarSize = 13;
            this.ScrollSongs.Size = new System.Drawing.Size(13, 591);
            this.ScrollSongs.TabIndex = 0;
            this.ScrollSongs.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollSongs_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Optional_label);
            this.panel1.Controls.Add(this.TotalTime_label);
            this.panel1.Controls.Add(this.ArtistName);
            this.panel1.Controls.Add(this.SongName);
            this.panel1.Location = new System.Drawing.Point(4, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 37);
            this.panel1.TabIndex = 4;
            // 
            // Optional_label
            // 
            this.Optional_label.AutoSize = true;
            this.Optional_label.Location = new System.Drawing.Point(907, 10);
            this.Optional_label.Name = "Optional_label";
            this.Optional_label.Size = new System.Drawing.Size(34, 13);
            this.Optional_label.TabIndex = 3;
            this.Optional_label.Text = "Thêm";
            // 
            // TotalTime_label
            // 
            this.TotalTime_label.AutoSize = true;
            this.TotalTime_label.Location = new System.Drawing.Point(740, 10);
            this.TotalTime_label.Name = "TotalTime_label";
            this.TotalTime_label.Size = new System.Drawing.Size(51, 13);
            this.TotalTime_label.TabIndex = 2;
            this.TotalTime_label.Text = "Thời gian";
            // 
            // ArtistName
            // 
            this.ArtistName.AutoSize = true;
            this.ArtistName.Location = new System.Drawing.Point(562, 10);
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.Size = new System.Drawing.Size(54, 13);
            this.ArtistName.TabIndex = 1;
            this.ArtistName.Text = "Tên ca sĩ";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Location = new System.Drawing.Point(276, 10);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(61, 13);
            this.SongName.TabIndex = 0;
            this.SongName.Text = "Tên bài hát";
            // 
            // MyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMusic);
            this.Controls.Add(this.TabControl1);
            this.Name = "MyMusic";
            this.Size = new System.Drawing.Size(965, 665);
            this.TabControl1.ResumeLayout(false);
            this.PanelMusic.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage Arrange;
        public MetroSet_UI.Controls.MetroSetTabControl TabControl1;
        public System.Windows.Forms.Panel PanelMusic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Optional_label;
        private System.Windows.Forms.Label TotalTime_label;
        private System.Windows.Forms.Label ArtistName;
        private System.Windows.Forms.Label SongName;
        private Guna.UI2.WinForms.Guna2VScrollBar ScrollSongs;
    }
}
