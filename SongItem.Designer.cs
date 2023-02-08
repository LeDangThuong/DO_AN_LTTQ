namespace DO_AN_LTTQ
{
    partial class SongItem
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
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.OptionButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBoxSong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSongName
            // 
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSongName.Location = new System.Drawing.Point(207, 6);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(225, 58);
            this.lblSongName.TabIndex = 56;
            this.lblSongName.Text = "1.Attention";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSongName.Click += new System.EventHandler(this.songItem_Click);
            // 
            // lblArtistName
            // 
            this.lblArtistName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArtistName.AutoEllipsis = true;
            this.lblArtistName.BackColor = System.Drawing.Color.Transparent;
            this.lblArtistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblArtistName.Location = new System.Drawing.Point(399, 6);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(236, 58);
            this.lblArtistName.TabIndex = 57;
            this.lblArtistName.Text = "Charlie Puth";
            this.lblArtistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArtistName.Click += new System.EventHandler(this.songItem_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalTime.Location = new System.Drawing.Point(672, 29);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(39, 14);
            this.lblTotalTime.TabIndex = 58;
            this.lblTotalTime.Text = "03:58";
            this.lblTotalTime.Click += new System.EventHandler(this.songItem_Click);
            // 
            // OptionButton
            // 
            this.OptionButton.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.OptionButton.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.OptionButton.Image = global::DO_AN_LTTQ.Properties.Resources.options_list;
            this.OptionButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.OptionButton.ImageRotate = 0F;
            this.OptionButton.ImageSize = new System.Drawing.Size(20, 20);
            this.OptionButton.Location = new System.Drawing.Point(833, 6);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.OptionButton.Size = new System.Drawing.Size(35, 58);
            this.OptionButton.TabIndex = 61;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // pictureBoxSong
            // 
            this.pictureBoxSong.BackgroundImage = global::DO_AN_LTTQ.Properties.Resources.DefaultMusic;
            this.pictureBoxSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSong.Location = new System.Drawing.Point(17, 7);
            this.pictureBoxSong.Name = "pictureBoxSong";
            this.pictureBoxSong.Size = new System.Drawing.Size(54, 54);
            this.pictureBoxSong.TabIndex = 0;
            this.pictureBoxSong.TabStop = false;
            this.pictureBoxSong.Click += new System.EventHandler(this.songItem_Click);
            this.pictureBoxSong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSong_MouseDown);
            // 
            // SongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OptionButton);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblArtistName);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.pictureBoxSong);
            this.Name = "SongItem";
            this.Size = new System.Drawing.Size(921, 64);
            this.Click += new System.EventHandler(this.songItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBoxSong;
        public System.Windows.Forms.Label lblSongName;
        public System.Windows.Forms.Label lblArtistName;
        public System.Windows.Forms.Label lblTotalTime;
        public Guna.UI2.WinForms.Guna2ImageButton OptionButton;
    }
}
