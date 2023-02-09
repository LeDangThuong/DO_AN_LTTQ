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
            this.TabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.Songs = new System.Windows.Forms.TabPage();
            this.PanelName = new System.Windows.Forms.Panel();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.PanelSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.TabControl1.SuspendLayout();
            this.PanelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.TabControl1.AnimateTime = 200;
            this.TabControl1.BackgroundColor = System.Drawing.Color.White;
            this.TabControl1.Controls.Add(this.Songs);
            this.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl1.IsDerivedStyle = true;
            this.TabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.TabControl1.Location = new System.Drawing.Point(3, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl1.Size = new System.Drawing.Size(947, 401);
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
            // Songs
            // 
            this.Songs.Location = new System.Drawing.Point(4, 42);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(939, 355);
            this.Songs.TabIndex = 0;
            this.Songs.Text = "Bài hát";
            // 
            // PanelName
            // 
            this.PanelName.Controls.Add(this.lblOptions);
            this.PanelName.Controls.Add(this.lblTime);
            this.PanelName.Controls.Add(this.lblArtist);
            this.PanelName.Controls.Add(this.lblSong);
            this.PanelName.Location = new System.Drawing.Point(3, 48);
            this.PanelName.Name = "PanelName";
            this.PanelName.Size = new System.Drawing.Size(947, 33);
            this.PanelName.TabIndex = 4;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(826, 11);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(52, 13);
            this.lblOptions.TabIndex = 4;
            this.lblOptions.Text = "Lựa chọn";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(674, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Thời lượng";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(436, 11);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(74, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Ca sĩ thể hiện";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(231, 11);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(61, 13);
            this.lblSong.TabIndex = 0;
            this.lblSong.Text = "Tên bài hát";
            // 
            // PanelSongs
            // 
            this.PanelSongs.AutoScroll = true;
            this.PanelSongs.Location = new System.Drawing.Point(3, 75);
            this.PanelSongs.Name = "PanelSongs";
            this.PanelSongs.Size = new System.Drawing.Size(947, 329);
            this.PanelSongs.TabIndex = 5;
            // 
            // MyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelSongs);
            this.Controls.Add(this.PanelName);
            this.Controls.Add(this.TabControl1);
            this.Name = "MyMusic";
            this.Size = new System.Drawing.Size(965, 560);
            this.Load += new System.EventHandler(this.MyMusic_Load);
            this.TabControl1.ResumeLayout(false);
            this.PanelName.ResumeLayout(false);
            this.PanelName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Songs;
        public System.Windows.Forms.Panel PanelName;
        public System.Windows.Forms.Label lblOptions;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblSong;
        public MetroSet_UI.Controls.MetroSetTabControl TabControl1;
        public System.Windows.Forms.FlowLayoutPanel PanelSongs;
    }
}
