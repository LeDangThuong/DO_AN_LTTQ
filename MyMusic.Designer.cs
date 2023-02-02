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
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.Artist = new System.Windows.Forms.TabPage();
            this.Albums = new System.Windows.Forms.TabPage();
            this.Songs = new System.Windows.Forms.TabPage();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.Songs);
            this.metroSetTabControl1.Controls.Add(this.Artist);
            this.metroSetTabControl1.Controls.Add(this.Albums);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(715, 338);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(4, 42);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(707, 292);
            this.Artist.TabIndex = 1;
            this.Artist.Text = "Nghệ sĩ thực hiện";
            // 
            // Albums
            // 
            this.Albums.Location = new System.Drawing.Point(4, 42);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(707, 292);
            this.Albums.TabIndex = 2;
            this.Albums.Text = "Albums";
            // 
            // Songs
            // 
            this.Songs.Location = new System.Drawing.Point(4, 42);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(707, 292);
            this.Songs.TabIndex = 0;
            this.Songs.Text = "Bài hát";
            // 
            // MyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroSetTabControl1);
            this.Name = "MyMusic";
            this.Size = new System.Drawing.Size(724, 350);
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private System.Windows.Forms.TabPage Songs;
        private System.Windows.Forms.TabPage Artist;
        private System.Windows.Forms.TabPage Albums;
    }
}
