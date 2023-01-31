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
            this.picMediaItem = new System.Windows.Forms.PictureBox();
            this.lblTenBaiHat = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTacGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMediaItem)).BeginInit();
            this.SuspendLayout();
            // 
            // picMediaItem
            // 
            this.picMediaItem.Location = new System.Drawing.Point(3, 3);
            this.picMediaItem.Name = "picMediaItem";
            this.picMediaItem.Size = new System.Drawing.Size(90, 90);
            this.picMediaItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMediaItem.TabIndex = 0;
            this.picMediaItem.TabStop = false;
            // 
            // lblTenBaiHat
            // 
            this.lblTenBaiHat.AutoSize = true;
            this.lblTenBaiHat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenBaiHat.IsDerivedStyle = true;
            this.lblTenBaiHat.Location = new System.Drawing.Point(96, 17);
            this.lblTenBaiHat.Name = "lblTenBaiHat";
            this.lblTenBaiHat.Size = new System.Drawing.Size(101, 22);
            this.lblTenBaiHat.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTenBaiHat.StyleManager = null;
            this.lblTenBaiHat.TabIndex = 1;
            this.lblTenBaiHat.Text = "Tên bài hát";
            this.lblTenBaiHat.ThemeAuthor = "Narwin";
            this.lblTenBaiHat.ThemeName = "MetroLite";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(97, 48);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(56, 18);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả";
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenBaiHat);
            this.Controls.Add(this.picMediaItem);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(348, 97);
            ((System.ComponentModel.ISupportInitialize)(this.picMediaItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picMediaItem;
        public MetroSet_UI.Controls.MetroSetLabel lblTenBaiHat;
        public System.Windows.Forms.Label lblTacGia;
    }
}
