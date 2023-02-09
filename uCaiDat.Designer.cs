namespace DO_AN_LTTQ
{
    partial class uCaiDat
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
            this.panel_time = new System.Windows.Forms.Panel();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.lbl_time = new Krypton.Toolkit.KryptonLabel();
            this.TimeOut_lbl = new Krypton.Toolkit.KryptonLabel();
            this.lbl_Minute = new Krypton.Toolkit.KryptonLabel();
            this.TimeOut_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.TimeOut_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.theme_panel = new System.Windows.Forms.Panel();
            this.lbl_Theme = new Krypton.Toolkit.KryptonLabel();
            this.Theme_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Theme_Button = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel_time.SuspendLayout();
            this.theme_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_time
            // 
            this.panel_time.Controls.Add(this.cbMinute);
            this.panel_time.Controls.Add(this.lbl_time);
            this.panel_time.Controls.Add(this.TimeOut_lbl);
            this.panel_time.Controls.Add(this.lbl_Minute);
            this.panel_time.Controls.Add(this.TimeOut_Switch);
            this.panel_time.Controls.Add(this.TimeOut_Button);
            this.panel_time.Location = new System.Drawing.Point(117, 179);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(413, 129);
            this.panel_time.TabIndex = 15;
            // 
            // cbMinute
            // 
            this.cbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinute.Enabled = false;
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "120"});
            this.cbMinute.Location = new System.Drawing.Point(26, 83);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(121, 24);
            this.cbMinute.TabIndex = 17;
            this.cbMinute.SelectedIndexChanged += new System.EventHandler(this.cbMinute_SelectedIndexChanged);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = false;
            this.lbl_time.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_time.Location = new System.Drawing.Point(272, 83);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(95, 27);
            this.lbl_time.TabIndex = 18;
            this.lbl_time.Values.Text = "00:00";
            // 
            // TimeOut_lbl
            // 
            this.TimeOut_lbl.AutoSize = false;
            this.TimeOut_lbl.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.TimeOut_lbl.Location = new System.Drawing.Point(341, 22);
            this.TimeOut_lbl.Name = "TimeOut_lbl";
            this.TimeOut_lbl.Size = new System.Drawing.Size(56, 27);
            this.TimeOut_lbl.TabIndex = 17;
            this.TimeOut_lbl.Values.Text = "Off";
            // 
            // lbl_Minute
            // 
            this.lbl_Minute.AutoSize = false;
            this.lbl_Minute.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_Minute.Location = new System.Drawing.Point(164, 83);
            this.lbl_Minute.Name = "lbl_Minute";
            this.lbl_Minute.Size = new System.Drawing.Size(56, 27);
            this.lbl_Minute.TabIndex = 17;
            this.lbl_Minute.Values.Text = "Phút";
            // 
            // TimeOut_Switch
            // 
            this.TimeOut_Switch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOut_Switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeOut_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TimeOut_Switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TimeOut_Switch.Location = new System.Drawing.Point(262, 19);
            this.TimeOut_Switch.Name = "TimeOut_Switch";
            this.TimeOut_Switch.Size = new System.Drawing.Size(60, 30);
            this.TimeOut_Switch.TabIndex = 17;
            this.TimeOut_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TimeOut_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TimeOut_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TimeOut_Switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TimeOut_Switch.CheckedChanged += new System.EventHandler(this.TimeOut_Switch_CheckedChanged);
            // 
            // TimeOut_Button
            // 
            this.TimeOut_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TimeOut_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TimeOut_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TimeOut_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TimeOut_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TimeOut_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.TimeOut_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TimeOut_Button.ForeColor = System.Drawing.Color.Black;
            this.TimeOut_Button.Image = global::DO_AN_LTTQ.Properties.Resources.clock;
            this.TimeOut_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TimeOut_Button.ImageOffset = new System.Drawing.Point(0, 20);
            this.TimeOut_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.TimeOut_Button.Location = new System.Drawing.Point(4, 4);
            this.TimeOut_Button.Margin = new System.Windows.Forms.Padding(4);
            this.TimeOut_Button.Name = "TimeOut_Button";
            this.TimeOut_Button.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.TimeOut_Button.Size = new System.Drawing.Size(270, 60);
            this.TimeOut_Button.TabIndex = 16;
            this.TimeOut_Button.Text = "Thời Gian Tắt";
            this.TimeOut_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.TimeOut_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2TileButton1.Image = global::DO_AN_LTTQ.Properties.Resources.log_out;
            this.guna2TileButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2TileButton1.ImageOffset = new System.Drawing.Point(0, 20);
            this.guna2TileButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2TileButton1.Location = new System.Drawing.Point(121, 315);
            this.guna2TileButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.guna2TileButton1.Size = new System.Drawing.Size(231, 45);
            this.guna2TileButton1.TabIndex = 14;
            this.guna2TileButton1.Text = "Thoát";
            this.guna2TileButton1.TextOffset = new System.Drawing.Point(0, -10);
            this.guna2TileButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // theme_panel
            // 
            this.theme_panel.Controls.Add(this.lbl_Theme);
            this.theme_panel.Controls.Add(this.Theme_Switch);
            this.theme_panel.Controls.Add(this.Theme_Button);
            this.theme_panel.Location = new System.Drawing.Point(117, 73);
            this.theme_panel.Name = "theme_panel";
            this.theme_panel.Size = new System.Drawing.Size(413, 100);
            this.theme_panel.TabIndex = 16;
            // 
            // lbl_Theme
            // 
            this.lbl_Theme.AutoSize = false;
            this.lbl_Theme.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lbl_Theme.Location = new System.Drawing.Point(354, 41);
            this.lbl_Theme.Name = "lbl_Theme";
            this.lbl_Theme.Size = new System.Drawing.Size(56, 27);
            this.lbl_Theme.TabIndex = 19;
            this.lbl_Theme.Values.Text = "Sáng";
            // 
            // Theme_Switch
            // 
            this.Theme_Switch.Checked = true;
            this.Theme_Switch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Theme_Switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Theme_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Theme_Switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Theme_Switch.Location = new System.Drawing.Point(272, 38);
            this.Theme_Switch.Name = "Theme_Switch";
            this.Theme_Switch.Size = new System.Drawing.Size(60, 30);
            this.Theme_Switch.TabIndex = 18;
            this.Theme_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Theme_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Theme_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Theme_Switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Theme_Switch.CheckedChanged += new System.EventHandler(this.Theme_Switch_CheckedChanged);
            // 
            // Theme_Button
            // 
            this.Theme_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Theme_Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Theme_Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Theme_Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Theme_Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Theme_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Theme_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Theme_Button.ForeColor = System.Drawing.Color.Black;
            this.Theme_Button.Image = global::DO_AN_LTTQ.Properties.Resources.theme;
            this.Theme_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Theme_Button.ImageOffset = new System.Drawing.Point(0, 20);
            this.Theme_Button.ImageSize = new System.Drawing.Size(45, 45);
            this.Theme_Button.Location = new System.Drawing.Point(0, 18);
            this.Theme_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Theme_Button.Name = "Theme_Button";
            this.Theme_Button.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Theme_Button.Size = new System.Drawing.Size(265, 60);
            this.Theme_Button.TabIndex = 17;
            this.Theme_Button.Text = "Chủ Đề";
            this.Theme_Button.TextOffset = new System.Drawing.Point(0, -10);
            this.Theme_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // uCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.theme_panel);
            this.Controls.Add(this.panel_time);
            this.Controls.Add(this.guna2TileButton1);
            this.Name = "uCaiDat";
            this.Size = new System.Drawing.Size(1106, 537);
            this.Load += new System.EventHandler(this.uCaiDat_Load);
            this.panel_time.ResumeLayout(false);
            this.theme_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private System.Windows.Forms.Panel panel_time;
        private Guna.UI2.WinForms.Guna2TileButton TimeOut_Button;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TimeOut_Switch;
        private Krypton.Toolkit.KryptonLabel lbl_Minute;
        private Krypton.Toolkit.KryptonLabel TimeOut_lbl;
        private Krypton.Toolkit.KryptonLabel lbl_time;
     
        private System.Windows.Forms.Panel theme_panel;
        public Guna.UI2.WinForms.Guna2ToggleSwitch Theme_Switch;
        private Guna.UI2.WinForms.Guna2TileButton Theme_Button;
        public Krypton.Toolkit.KryptonLabel lbl_Theme;
        private System.Windows.Forms.ComboBox cbMinute;
    }
}
