namespace DO_AN_LTTQ
{
    partial class AlbumDetails
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
            this.background = new System.Windows.Forms.Panel();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblTotalSongs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.btnPlayAll);
            this.background.Controls.Add(this.btnBack);
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.lblTotalSongs);
            this.background.Controls.Add(this.lblPlaylistName);
            this.background.Location = new System.Drawing.Point(217, 3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(518, 192);
            this.background.TabIndex = 1;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(3, 9);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(245, 50);
            this.lblPlaylistName.TabIndex = 0;
            this.lblPlaylistName.Text = "NameOfSong";
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSongs.Location = new System.Drawing.Point(40, 59);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(32, 25);
            this.lblTotalSongs.TabIndex = 1;
            this.lblTotalSongs.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Songs";
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.BackgroundImage = global::DO_AN_LTTQ.Properties.Resources.play11;
            this.btnPlayAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayAll.Location = new System.Drawing.Point(117, 145);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Size = new System.Drawing.Size(143, 44);
            this.btnPlayAll.TabIndex = 4;
            this.btnPlayAll.Text = "Play All";
            this.btnPlayAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayAll.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::DO_AN_LTTQ.Properties.Resources.previous;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(3, 145);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(3, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(208, 192);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // AlbumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.background);
            this.Controls.Add(this.image);
            this.Name = "AlbumDetails";
            this.Size = new System.Drawing.Size(738, 198);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Button btnPlayAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.Label lblPlaylistName;
    }
}
