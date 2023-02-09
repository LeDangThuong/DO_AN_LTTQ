namespace DO_AN_LTTQ
{
    partial class uYeuThich
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
            this.flowPnelYeuThich = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTrong = new System.Windows.Forms.Label();
            this.flowPnelYeuThich.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPnelYeuThich
            // 
            this.flowPnelYeuThich.AutoScroll = true;
            this.flowPnelYeuThich.Controls.Add(this.lblTrong);
            this.flowPnelYeuThich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnelYeuThich.Location = new System.Drawing.Point(0, 0);
            this.flowPnelYeuThich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowPnelYeuThich.Name = "flowPnelYeuThich";
            this.flowPnelYeuThich.Size = new System.Drawing.Size(825, 460);
            this.flowPnelYeuThich.TabIndex = 0;
            // 
            // lblTrong
            // 
            this.lblTrong.AutoSize = true;
            this.lblTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrong.Location = new System.Drawing.Point(225, 203);
            this.lblTrong.Margin = new System.Windows.Forms.Padding(225, 203, 2, 0);
            this.lblTrong.Name = "lblTrong";
            this.lblTrong.Size = new System.Drawing.Size(342, 24);
            this.lblTrong.TabIndex = 0;
            this.lblTrong.Text = "Chưa có bài hát nào được yêu thích";
            this.lblTrong.Visible = false;
            // 
            // uYeuThich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowPnelYeuThich);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "uYeuThich";
            this.Size = new System.Drawing.Size(825, 460);
            this.flowPnelYeuThich.ResumeLayout(false);
            this.flowPnelYeuThich.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowPnelYeuThich;
        public System.Windows.Forms.Label lblTrong;
    }
}
