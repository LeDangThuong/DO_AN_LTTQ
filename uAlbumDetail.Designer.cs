namespace DO_AN_LTTQ
{
    partial class uAlbumDetail
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
            this.paneldetail = new System.Windows.Forms.Panel();
            this.panelAlbumDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.SLSong_lbl = new Krypton.Toolkit.KryptonLabel();
            this.NameSong_lbl = new System.Windows.Forms.Label();
            this.AddSong_button = new Guna.UI2.WinForms.Guna2TileButton();
            this.Delete_button = new Guna.UI2.WinForms.Guna2TileButton();
            this.Rename_button = new Guna.UI2.WinForms.Guna2TileButton();
            this.PlayList_button = new Guna.UI2.WinForms.Guna2TileButton();
            this.back_pic = new System.Windows.Forms.PictureBox();
            this.dalbum_pic = new System.Windows.Forms.PictureBox();
            this.paneldetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalbum_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldetail
            // 
            this.paneldetail.Controls.Add(this.AddSong_button);
            this.paneldetail.Controls.Add(this.Delete_button);
            this.paneldetail.Controls.Add(this.Rename_button);
            this.paneldetail.Controls.Add(this.PlayList_button);
            this.paneldetail.Controls.Add(this.back_pic);
            this.paneldetail.Controls.Add(this.NameSong_lbl);
            this.paneldetail.Controls.Add(this.SLSong_lbl);
            this.paneldetail.Location = new System.Drawing.Point(226, 3);
            this.paneldetail.Name = "paneldetail";
            this.paneldetail.Size = new System.Drawing.Size(795, 190);
            this.paneldetail.TabIndex = 2;
            // 
            // panelAlbumDetail
            // 
            this.panelAlbumDetail.AutoScroll = true;
            this.panelAlbumDetail.Location = new System.Drawing.Point(0, 195);
            this.panelAlbumDetail.Name = "panelAlbumDetail";
            this.panelAlbumDetail.Size = new System.Drawing.Size(1024, 309);
            this.panelAlbumDetail.TabIndex = 3;
            // 
            // SLSong_lbl
            // 
            this.SLSong_lbl.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.SLSong_lbl.Location = new System.Drawing.Point(37, 70);
            this.SLSong_lbl.Name = "SLSong_lbl";
            this.SLSong_lbl.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.SLSong_lbl.Size = new System.Drawing.Size(87, 27);
            this.SLSong_lbl.TabIndex = 1;
            this.SLSong_lbl.Values.Text = "0 Bài Hát";
            // 
            // NameSong_lbl
            // 
            this.NameSong_lbl.Font = new System.Drawing.Font("Lucida Handwriting", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSong_lbl.ForeColor = System.Drawing.Color.Maroon;
            this.NameSong_lbl.Location = new System.Drawing.Point(5, 22);
            this.NameSong_lbl.Name = "NameSong_lbl";
            this.NameSong_lbl.Size = new System.Drawing.Size(310, 45);
            this.NameSong_lbl.TabIndex = 2;
            this.NameSong_lbl.Text = "Name Album";
            this.NameSong_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddSong_button
            // 
            this.AddSong_button.BackColor = System.Drawing.Color.White;
            this.AddSong_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddSong_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddSong_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddSong_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddSong_button.FillColor = System.Drawing.SystemColors.Control;
            this.AddSong_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddSong_button.ForeColor = System.Drawing.Color.DarkRed;
            this.AddSong_button.Image = global::DO_AN_LTTQ.Properties.Resources.add;
            this.AddSong_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSong_button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.AddSong_button.ImageSize = new System.Drawing.Size(30, 30);
            this.AddSong_button.Location = new System.Drawing.Point(278, 117);
            this.AddSong_button.Margin = new System.Windows.Forms.Padding(5);
            this.AddSong_button.Name = "AddSong_button";
            this.AddSong_button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.AddSong_button.Size = new System.Drawing.Size(164, 54);
            this.AddSong_button.TabIndex = 16;
            this.AddSong_button.Text = "Add To";
            this.AddSong_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddSong_button.TextOffset = new System.Drawing.Point(0, -10);
            this.AddSong_button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_button.FillColor = System.Drawing.SystemColors.Control;
            this.Delete_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Delete_button.ForeColor = System.Drawing.Color.DarkRed;
            this.Delete_button.Image = global::DO_AN_LTTQ.Properties.Resources.delete;
            this.Delete_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete_button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.Delete_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Delete_button.Location = new System.Drawing.Point(626, 117);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(5);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Delete_button.Size = new System.Drawing.Size(138, 54);
            this.Delete_button.TabIndex = 17;
            this.Delete_button.Text = "Xóa";
            this.Delete_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Delete_button.TextOffset = new System.Drawing.Point(0, -10);
            this.Delete_button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // Rename_button
            // 
            this.Rename_button.BackColor = System.Drawing.Color.White;
            this.Rename_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rename_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rename_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rename_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rename_button.FillColor = System.Drawing.SystemColors.Control;
            this.Rename_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Rename_button.ForeColor = System.Drawing.Color.DarkRed;
            this.Rename_button.Image = global::DO_AN_LTTQ.Properties.Resources.rename;
            this.Rename_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Rename_button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.Rename_button.ImageSize = new System.Drawing.Size(30, 30);
            this.Rename_button.Location = new System.Drawing.Point(452, 117);
            this.Rename_button.Margin = new System.Windows.Forms.Padding(5);
            this.Rename_button.Name = "Rename_button";
            this.Rename_button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Rename_button.Size = new System.Drawing.Size(164, 54);
            this.Rename_button.TabIndex = 16;
            this.Rename_button.Text = "ReName";
            this.Rename_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Rename_button.TextOffset = new System.Drawing.Point(0, -10);
            this.Rename_button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // PlayList_button
            // 
            this.PlayList_button.BackColor = System.Drawing.Color.White;
            this.PlayList_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PlayList_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PlayList_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PlayList_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PlayList_button.FillColor = System.Drawing.SystemColors.Control;
            this.PlayList_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PlayList_button.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayList_button.Image = global::DO_AN_LTTQ.Properties.Resources.play_button;
            this.PlayList_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PlayList_button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.PlayList_button.ImageSize = new System.Drawing.Size(30, 30);
            this.PlayList_button.Location = new System.Drawing.Point(115, 117);
            this.PlayList_button.Margin = new System.Windows.Forms.Padding(5);
            this.PlayList_button.Name = "PlayList_button";
            this.PlayList_button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.PlayList_button.Size = new System.Drawing.Size(149, 54);
            this.PlayList_button.TabIndex = 15;
            this.PlayList_button.Text = "Play All";
            this.PlayList_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PlayList_button.TextOffset = new System.Drawing.Point(0, -10);
            this.PlayList_button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // back_pic
            // 
            this.back_pic.Image = global::DO_AN_LTTQ.Properties.Resources.back;
            this.back_pic.Location = new System.Drawing.Point(26, 140);
            this.back_pic.Name = "back_pic";
            this.back_pic.Size = new System.Drawing.Size(67, 25);
            this.back_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_pic.TabIndex = 3;
            this.back_pic.TabStop = false;
            // 
            // dalbum_pic
            // 
            this.dalbum_pic.Image = global::DO_AN_LTTQ.Properties.Resources.album;
            this.dalbum_pic.Location = new System.Drawing.Point(0, 0);
            this.dalbum_pic.Name = "dalbum_pic";
            this.dalbum_pic.Size = new System.Drawing.Size(225, 193);
            this.dalbum_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dalbum_pic.TabIndex = 1;
            this.dalbum_pic.TabStop = false;
            // 
            // uAlbumDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAlbumDetail);
            this.Controls.Add(this.paneldetail);
            this.Controls.Add(this.dalbum_pic);
            this.Name = "uAlbumDetail";
            this.Size = new System.Drawing.Size(1024, 504);
            this.paneldetail.ResumeLayout(false);
            this.paneldetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalbum_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dalbum_pic;
        private System.Windows.Forms.Panel paneldetail;
        private System.Windows.Forms.FlowLayoutPanel panelAlbumDetail;
        private Krypton.Toolkit.KryptonLabel SLSong_lbl;
        private System.Windows.Forms.Label NameSong_lbl;
        private System.Windows.Forms.PictureBox back_pic;
        private Guna.UI2.WinForms.Guna2TileButton PlayList_button;
        private Guna.UI2.WinForms.Guna2TileButton AddSong_button;
        private Guna.UI2.WinForms.Guna2TileButton Delete_button;
        private Guna.UI2.WinForms.Guna2TileButton Rename_button;
    }
}
