using System.Drawing;
namespace DO_AN_LTTQ
{
    partial class MediaItem
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
            this.lblTenBaiHat = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.picboxYeuThich = new System.Windows.Forms.PictureBox();
            this.picMediaItem = new System.Windows.Forms.PictureBox();
            this.checkYeuThich = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxYeuThich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMediaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenBaiHat
            // 
            this.lblTenBaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBaiHat.IsDerivedStyle = true;
            this.lblTenBaiHat.Location = new System.Drawing.Point(72, 14);
            this.lblTenBaiHat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenBaiHat.Name = "lblTenBaiHat";
            this.lblTenBaiHat.Size = new System.Drawing.Size(186, 22);
            this.lblTenBaiHat.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTenBaiHat.StyleManager = null;
            this.lblTenBaiHat.TabIndex = 1;
            this.lblTenBaiHat.Text = "Tên bài hát";
            this.lblTenBaiHat.ThemeAuthor = "Narwin";
            this.lblTenBaiHat.ThemeName = "MetroLite";
            this.lblTenBaiHat.Click += new System.EventHandler(this.lblTenBaiHat_Click);
            // 
            // lblTacGia
            // 
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(73, 39);
            this.lblTacGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(185, 18);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả";
            this.lblTacGia.Click += new System.EventHandler(this.lblTenBaiHat_Click);
            // 
            // picboxYeuThich
            // 
            this.picboxYeuThich.Image = global::DO_AN_LTTQ.Properties.Resources.heart_white;
            this.picboxYeuThich.Location = new System.Drawing.Point(274, 23);
            this.picboxYeuThich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picboxYeuThich.Name = "picboxYeuThich";
            this.picboxYeuThich.Size = new System.Drawing.Size(22, 24);
            this.picboxYeuThich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxYeuThich.TabIndex = 3;
            this.picboxYeuThich.TabStop = false;
            this.picboxYeuThich.Click += new System.EventHandler(this.picboxYeuThich_Click);
            // 
            // picMediaItem
            // 
            this.picMediaItem.Location = new System.Drawing.Point(2, 2);
            this.picMediaItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMediaItem.Name = "picMediaItem";
            this.picMediaItem.Size = new System.Drawing.Size(68, 73);
            this.picMediaItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMediaItem.TabIndex = 0;
            this.picMediaItem.TabStop = false;
            this.picMediaItem.Click += new System.EventHandler(this.picMediaItem_Click);
            this.picMediaItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMediaItem_MouseDown);
            // 
            // checkYeuThich
            // 
            this.checkYeuThich.AutoSize = true;
            this.checkYeuThich.Location = new System.Drawing.Point(274, 53);
            this.checkYeuThich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkYeuThich.Name = "checkYeuThich";
            this.checkYeuThich.Size = new System.Drawing.Size(15, 14);
            this.checkYeuThich.TabIndex = 4;
            this.checkYeuThich.UseVisualStyleBackColor = true;
            this.checkYeuThich.Visible = false;
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.checkYeuThich);
            this.Controls.Add(this.picboxYeuThich);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenBaiHat);
            this.Controls.Add(this.picMediaItem);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(308, 79);
            this.Click += new System.EventHandler(this.mediaItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picboxYeuThich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMediaItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picMediaItem;
        public MetroSet_UI.Controls.MetroSetLabel lblTenBaiHat;
        public System.Windows.Forms.Label lblTacGia;
        public System.Windows.Forms.PictureBox picboxYeuThich;
        public System.Windows.Forms.CheckBox checkYeuThich;
    }
}
