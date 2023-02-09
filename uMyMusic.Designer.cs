namespace DO_AN_LTTQ
{
    partial class uMyMusic
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
            this.flowPanelMedia = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowPanelMedia
            // 
            this.flowPanelMedia.AutoScroll = true;
            this.flowPanelMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelMedia.Location = new System.Drawing.Point(0, 0);
            this.flowPanelMedia.Name = "flowPanelMedia";
            this.flowPanelMedia.Size = new System.Drawing.Size(869, 469);
            this.flowPanelMedia.TabIndex = 0;
            // 
            // uMyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanelMedia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uMyMusic";
            this.Size = new System.Drawing.Size(869, 469);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowPanelMedia;
    }
}
