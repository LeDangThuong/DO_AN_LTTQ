namespace DO_AN_LTTQ
{
    partial class uAlbum
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
            this.panelalbumtile = new System.Windows.Forms.Panel();
            this.NewAlbum_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.panelalbum = new System.Windows.Forms.FlowLayoutPanel();
            this.panelalbumtile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelalbumtile
            // 
            this.panelalbumtile.BackColor = System.Drawing.SystemColors.Control;
            this.panelalbumtile.Controls.Add(this.NewAlbum_Button);
            this.panelalbumtile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelalbumtile.Location = new System.Drawing.Point(0, 0);
            this.panelalbumtile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelalbumtile.Name = "panelalbumtile";
            this.panelalbumtile.Size = new System.Drawing.Size(1107, 55);
            this.panelalbumtile.TabIndex = 15;
            // 
            // NewAlbum_Button
            // 
            this.NewAlbum_Button.BackColor = System.Drawing.SystemColors.Control;
            this.NewAlbum_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NewAlbum_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NewAlbum_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NewAlbum_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NewAlbum_Button.FillColor = System.Drawing.Color.White;
            this.NewAlbum_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.NewAlbum_Button.ForeColor = System.Drawing.Color.Black;
            this.NewAlbum_Button.Image = global::DO_AN_LTTQ.Properties.Resources.add;
            this.NewAlbum_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NewAlbum_Button.ImageOffset = new System.Drawing.Point(-3, 20);
            this.NewAlbum_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.NewAlbum_Button.Location = new System.Drawing.Point(0, 0);
            this.NewAlbum_Button.Margin = new System.Windows.Forms.Padding(5);
            this.NewAlbum_Button.Name = "NewAlbum_Button";
            this.NewAlbum_Button.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.NewAlbum_Button.Size = new System.Drawing.Size(241, 54);
            this.NewAlbum_Button.TabIndex = 14;
            this.NewAlbum_Button.Text = "New Album";
            this.NewAlbum_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.NewAlbum_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // panelalbum
            // 
            this.panelalbum.Location = new System.Drawing.Point(0, 60);
            this.panelalbum.Name = "panelalbum";
            this.panelalbum.Size = new System.Drawing.Size(1107, 461);
            this.panelalbum.TabIndex = 16;
            // 
            // uAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelalbum);
            this.Controls.Add(this.panelalbumtile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uAlbum";
            this.Size = new System.Drawing.Size(1107, 537);
            this.panelalbumtile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panelalbumtile;
        public Guna.UI2.WinForms.Guna2TileButton NewAlbum_Button;
        public System.Windows.Forms.FlowLayoutPanel panelalbum;
    }
}
