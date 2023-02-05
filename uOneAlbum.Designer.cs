namespace DO_AN_LTTQ
{
    partial class uOneAlbum
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
            this.lbl_onealbum = new System.Windows.Forms.Label();
            this.onealbum_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.onealbum_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_onealbum
            // 
            this.lbl_onealbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_onealbum.Location = new System.Drawing.Point(0, 182);
            this.lbl_onealbum.Name = "lbl_onealbum";
            this.lbl_onealbum.Size = new System.Drawing.Size(251, 34);
            this.lbl_onealbum.TabIndex = 1;
            this.lbl_onealbum.Text = "Album";
            this.lbl_onealbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onealbum_pic
            // 
            this.onealbum_pic.Image = global::DO_AN_LTTQ.Properties.Resources.album;
            this.onealbum_pic.Location = new System.Drawing.Point(0, 0);
            this.onealbum_pic.Name = "onealbum_pic";
            this.onealbum_pic.Size = new System.Drawing.Size(251, 179);
            this.onealbum_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onealbum_pic.TabIndex = 0;
            this.onealbum_pic.TabStop = false;
            // 
            // uOneAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_onealbum);
            this.Controls.Add(this.onealbum_pic);
            this.Name = "uOneAlbum";
            this.Size = new System.Drawing.Size(251, 216);
            ((System.ComponentModel.ISupportInitialize)(this.onealbum_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lbl_onealbum;
        public System.Windows.Forms.PictureBox onealbum_pic;
    }
}
