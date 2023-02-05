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
            this.lblTenBaiHat.Location = new System.Drawing.Point(96, 17);
            this.lblTenBaiHat.Name = "lblTenBaiHat";
            this.lblTenBaiHat.Size = new System.Drawing.Size(248, 27);
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
            this.lblTacGia.Location = new System.Drawing.Point(97, 48);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(247, 22);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả";
            this.lblTacGia.Click += new System.EventHandler(this.lblTenBaiHat_Click);
            // 
            // picboxYeuThich
            // 
            this.picboxYeuThich.Image = global::DO_AN_LTTQ.Properties.Resources.heart_white;
            this.picboxYeuThich.Location = new System.Drawing.Point(366, 28);
            this.picboxYeuThich.Name = "picboxYeuThich";
            this.picboxYeuThich.Size = new System.Drawing.Size(30, 30);
            this.picboxYeuThich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxYeuThich.TabIndex = 3;
            this.picboxYeuThich.TabStop = false;
            this.picboxYeuThich.Click += new System.EventHandler(this.picboxYeuThich_Click);
            // 
            // picMediaItem
            // 
            this.picMediaItem.Location = new System.Drawing.Point(3, 2);
            this.picMediaItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMediaItem.Name = "picMediaItem";
            this.picMediaItem.Size = new System.Drawing.Size(91, 90);
            this.picMediaItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMediaItem.TabIndex = 0;
            this.picMediaItem.TabStop = false;
            this.picMediaItem.Click += new System.EventHandler(this.picMediaItem_Click);
            this.picMediaItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMediaItem_MouseDown);
            // 
            // checkYeuThich
            // 
            this.checkYeuThich.AutoSize = true;
            this.checkYeuThich.Location = new System.Drawing.Point(366, 65);
            this.checkYeuThich.Name = "checkYeuThich";
            this.checkYeuThich.Size = new System.Drawing.Size(18, 17);
            this.checkYeuThich.TabIndex = 4;
            this.checkYeuThich.UseVisualStyleBackColor = true;
            this.checkYeuThich.Visible = false;
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.checkYeuThich);
            this.Controls.Add(this.picboxYeuThich);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenBaiHat);
            this.Controls.Add(this.picMediaItem);
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(410, 97);
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
