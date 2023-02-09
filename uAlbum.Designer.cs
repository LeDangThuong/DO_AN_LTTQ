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
            this.panelalbum = new System.Windows.Forms.FlowLayoutPanel();
            this.NewAlbum_Button = new DO_AN_LTTQ.VButton();
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
            this.panelalbumtile.Size = new System.Drawing.Size(1107, 78);
            this.panelalbumtile.TabIndex = 15;
            // 
            // panelalbum
            // 
            this.panelalbum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelalbum.Location = new System.Drawing.Point(0, 133);
            this.panelalbum.Name = "panelalbum";
            this.panelalbum.Size = new System.Drawing.Size(1107, 404);
            this.panelalbum.TabIndex = 16;
            // 
            // NewAlbum_Button
            // 
            this.NewAlbum_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewAlbum_Button.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewAlbum_Button.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.NewAlbum_Button.BorderRadius = 20;
            this.NewAlbum_Button.BorderSize = 0;
            this.NewAlbum_Button.FlatAppearance.BorderSize = 0;
            this.NewAlbum_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewAlbum_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAlbum_Button.ForeColor = System.Drawing.Color.Black;
            this.NewAlbum_Button.Image = global::DO_AN_LTTQ.Properties.Resources.add1;
            this.NewAlbum_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewAlbum_Button.Location = new System.Drawing.Point(14, 3);
            this.NewAlbum_Button.Name = "NewAlbum_Button";
            this.NewAlbum_Button.Size = new System.Drawing.Size(228, 54);
            this.NewAlbum_Button.TabIndex = 15;
            this.NewAlbum_Button.Text = "New Album";
            this.NewAlbum_Button.TextColor = System.Drawing.Color.Black;
            this.NewAlbum_Button.UseVisualStyleBackColor = false;
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
        public System.Windows.Forms.FlowLayoutPanel panelalbum;
        public VButton NewAlbum_Button;
    }
}
