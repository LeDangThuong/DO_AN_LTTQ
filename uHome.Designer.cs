namespace DO_AN_LTTQ
{
    partial class uHome
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
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flowPanelMedia.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelMedia
            // 
            this.flowPanelMedia.Controls.Add(this.guna2VScrollBar1);
            this.flowPanelMedia.Location = new System.Drawing.Point(6, 3);
            this.flowPanelMedia.Name = "flowPanelMedia";
            this.flowPanelMedia.Size = new System.Drawing.Size(846, 472);
            this.flowPanelMedia.TabIndex = 0;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(3, 3);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 300);
            this.guna2VScrollBar1.TabIndex = 0;
            // 
            // uHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPanelMedia);
            this.Name = "uHome";
            this.Size = new System.Drawing.Size(852, 478);
            this.flowPanelMedia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowPanelMedia;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
    }
}
