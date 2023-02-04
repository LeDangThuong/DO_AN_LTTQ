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
            this.Artist = new System.Windows.Forms.TabPage();
            this.Albums = new System.Windows.Forms.TabPage();
            this.Songs = new System.Windows.Forms.TabPage();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.TabControl1.AnimateTime = 200;
            this.TabControl1.BackgroundColor = System.Drawing.Color.White;
            this.TabControl1.Controls.Add(this.Songs);
            this.TabControl1.Controls.Add(this.Artist);
            this.TabControl1.Controls.Add(this.Albums);
            this.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl1.IsDerivedStyle = true;
            this.TabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.TabControl1.Location = new System.Drawing.Point(3, 3);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 1;
            this.TabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl1.Size = new System.Drawing.Size(959, 447);
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
            // Artist
            // 
            this.Artist.Location = new System.Drawing.Point(4, 42);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(951, 401);
            this.Artist.TabIndex = 1;
            this.Artist.Text = "Nghệ sĩ thực hiện";
            // 
            // Albums
            // 
            this.Albums.Location = new System.Drawing.Point(4, 42);
            this.Albums.Name = "Albums";
            this.Albums.Size = new System.Drawing.Size(954, 401);
            this.Albums.TabIndex = 2;
            this.Albums.Text = "Albums";
            // 
            // Songs
            // 
            this.Songs.Location = new System.Drawing.Point(4, 42);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(954, 401);
            this.Songs.TabIndex = 0;
            this.Songs.Text = "Bài hát";
            // 
            // MyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl1);
            this.Name = "MyMusic";
            this.Size = new System.Drawing.Size(965, 453);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl TabControl1;
        private System.Windows.Forms.TabPage Songs;
        private System.Windows.Forms.TabPage Artist;
        private System.Windows.Forms.TabPage Albums;
    }
}
