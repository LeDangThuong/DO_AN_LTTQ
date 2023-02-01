﻿namespace DO_AN_LTTQ
{
    partial class PlaylistDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.background = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.lblTotalSongs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayAll = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelSong = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.background);
            this.panel1.Controls.Add(this.image);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 182);
            this.panel1.TabIndex = 0;
            // 
            // background
            // 
            this.background.Controls.Add(this.btnBack);
            this.background.Controls.Add(this.btnDelete);
            this.background.Controls.Add(this.btnRename);
            this.background.Controls.Add(this.btnPlayAll);
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.lblTotalSongs);
            this.background.Controls.Add(this.lblPlaylistName);
            this.background.Location = new System.Drawing.Point(195, 3);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(723, 176);
            this.background.TabIndex = 1;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(3, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(186, 176);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.Location = new System.Drawing.Point(3, 0);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(245, 50);
            this.lblPlaylistName.TabIndex = 1;
            this.lblPlaylistName.Text = "NameOfSong";
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSongs.Location = new System.Drawing.Point(47, 50);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(32, 25);
            this.lblTotalSongs.TabIndex = 2;
            this.lblTotalSongs.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Songs";
            // 
            // btnPlayAll
            // 
            this.btnPlayAll.Location = new System.Drawing.Point(119, 128);
            this.btnPlayAll.Name = "btnPlayAll";
            this.btnPlayAll.Size = new System.Drawing.Size(75, 34);
            this.btnPlayAll.TabIndex = 4;
            this.btnPlayAll.Text = "Play All";
            this.btnPlayAll.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(276, 128);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 34);
            this.btnRename.TabIndex = 5;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(451, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(4, 128);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // panelSong
            // 
            this.panelSong.Location = new System.Drawing.Point(3, 191);
            this.panelSong.Name = "panelSong";
            this.panelSong.Size = new System.Drawing.Size(918, 245);
            this.panelSong.TabIndex = 1;
            // 
            // PlaylistDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSong);
            this.Controls.Add(this.panel1);
            this.Name = "PlaylistDetails";
            this.Size = new System.Drawing.Size(927, 439);
            this.panel1.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnPlayAll;
        private System.Windows.Forms.Panel panelSong;
    }
}
