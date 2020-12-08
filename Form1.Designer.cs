
namespace RE4_Configurator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_resWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ResolutionPresets = new System.Windows.Forms.ComboBox();
            this.chk_EnableVSync = new System.Windows.Forms.CheckBox();
            this.chk_EnableFullscreen = new System.Windows.Forms.CheckBox();
            this.cb_AntiAliasing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Anisotropy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_ShadowQuality = new System.Windows.Forms.ComboBox();
            this.rb_Texture_Original = new System.Windows.Forms.RadioButton();
            this.rb_Texture_HD = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_EnablePostProcessing = new System.Windows.Forms.CheckBox();
            this.chk_EnableMotionBlur = new System.Windows.Forms.CheckBox();
            this.rb_FPSoff = new System.Windows.Forms.RadioButton();
            this.rb_FPS30 = new System.Windows.Forms.RadioButton();
            this.rb_FPS60 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_EnableSubtitles = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_resHeight = new System.Windows.Forms.TextBox();
            this.txt_hertz = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_EnableLaser = new System.Windows.Forms.CheckBox();
            this.lbl_num_blue = new System.Windows.Forms.Label();
            this.lbl_num_green = new System.Windows.Forms.Label();
            this.lbl_num_red = new System.Windows.Forms.Label();
            this.btn_rgbpicker = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_resWidth
            // 
            this.txt_resWidth.Location = new System.Drawing.Point(238, 57);
            this.txt_resWidth.Name = "txt_resWidth";
            this.txt_resWidth.Size = new System.Drawing.Size(78, 23);
            this.txt_resWidth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resolution:";
            // 
            // cb_ResolutionPresets
            // 
            this.cb_ResolutionPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ResolutionPresets.FormattingEnabled = true;
            this.cb_ResolutionPresets.Items.AddRange(new object[] {
            "Custom",
            "HD (720p)",
            "Full-HD (1080p)",
            "Quad-HD (1440p)",
            "Ultra-HD (2160p)"});
            this.cb_ResolutionPresets.Location = new System.Drawing.Point(84, 57);
            this.cb_ResolutionPresets.Name = "cb_ResolutionPresets";
            this.cb_ResolutionPresets.Size = new System.Drawing.Size(131, 23);
            this.cb_ResolutionPresets.TabIndex = 4;
            this.cb_ResolutionPresets.SelectedIndexChanged += new System.EventHandler(this.cb_ResolutionPresets_SelectedIndexChanged);
            // 
            // chk_EnableVSync
            // 
            this.chk_EnableVSync.AutoSize = true;
            this.chk_EnableVSync.Location = new System.Drawing.Point(12, 131);
            this.chk_EnableVSync.Name = "chk_EnableVSync";
            this.chk_EnableVSync.Size = new System.Drawing.Size(137, 19);
            this.chk_EnableVSync.TabIndex = 5;
            this.chk_EnableVSync.Text = "Wait for Vertical Sync";
            this.chk_EnableVSync.UseVisualStyleBackColor = true;
            // 
            // chk_EnableFullscreen
            // 
            this.chk_EnableFullscreen.AutoSize = true;
            this.chk_EnableFullscreen.Location = new System.Drawing.Point(12, 106);
            this.chk_EnableFullscreen.Name = "chk_EnableFullscreen";
            this.chk_EnableFullscreen.Size = new System.Drawing.Size(149, 19);
            this.chk_EnableFullscreen.TabIndex = 6;
            this.chk_EnableFullscreen.Text = "Enable fullscreen mode";
            this.chk_EnableFullscreen.UseVisualStyleBackColor = true;
            // 
            // cb_AntiAliasing
            // 
            this.cb_AntiAliasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AntiAliasing.FormattingEnabled = true;
            this.cb_AntiAliasing.Items.AddRange(new object[] {
            "Off",
            "2X",
            "4X",
            "8X"});
            this.cb_AntiAliasing.Location = new System.Drawing.Point(115, 246);
            this.cb_AntiAliasing.Name = "cb_AntiAliasing";
            this.cb_AntiAliasing.Size = new System.Drawing.Size(74, 23);
            this.cb_AntiAliasing.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Anti-aliasing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Anisotropy filter:";
            // 
            // cb_Anisotropy
            // 
            this.cb_Anisotropy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Anisotropy.FormattingEnabled = true;
            this.cb_Anisotropy.Items.AddRange(new object[] {
            "Off",
            "2X",
            "4X",
            "8X",
            "16X"});
            this.cb_Anisotropy.Location = new System.Drawing.Point(115, 275);
            this.cb_Anisotropy.Name = "cb_Anisotropy";
            this.cb_Anisotropy.Size = new System.Drawing.Size(74, 23);
            this.cb_Anisotropy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Shadow quality:";
            // 
            // cb_ShadowQuality
            // 
            this.cb_ShadowQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ShadowQuality.FormattingEnabled = true;
            this.cb_ShadowQuality.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cb_ShadowQuality.Location = new System.Drawing.Point(115, 304);
            this.cb_ShadowQuality.Name = "cb_ShadowQuality";
            this.cb_ShadowQuality.Size = new System.Drawing.Size(74, 23);
            this.cb_ShadowQuality.TabIndex = 11;
            // 
            // rb_Texture_Original
            // 
            this.rb_Texture_Original.AutoSize = true;
            this.rb_Texture_Original.Location = new System.Drawing.Point(126, 348);
            this.rb_Texture_Original.Name = "rb_Texture_Original";
            this.rb_Texture_Original.Size = new System.Drawing.Size(67, 19);
            this.rb_Texture_Original.TabIndex = 13;
            this.rb_Texture_Original.TabStop = true;
            this.rb_Texture_Original.Text = "Original";
            this.rb_Texture_Original.UseVisualStyleBackColor = true;
            // 
            // rb_Texture_HD
            // 
            this.rb_Texture_HD.AutoSize = true;
            this.rb_Texture_HD.Location = new System.Drawing.Point(199, 348);
            this.rb_Texture_HD.Name = "rb_Texture_HD";
            this.rb_Texture_HD.Size = new System.Drawing.Size(42, 19);
            this.rb_Texture_HD.TabIndex = 14;
            this.rb_Texture_HD.TabStop = true;
            this.rb_Texture_HD.Text = "HD";
            this.rb_Texture_HD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Texture quality:";
            // 
            // chk_EnablePostProcessing
            // 
            this.chk_EnablePostProcessing.AutoSize = true;
            this.chk_EnablePostProcessing.Location = new System.Drawing.Point(12, 156);
            this.chk_EnablePostProcessing.Name = "chk_EnablePostProcessing";
            this.chk_EnablePostProcessing.Size = new System.Drawing.Size(149, 19);
            this.chk_EnablePostProcessing.TabIndex = 16;
            this.chk_EnablePostProcessing.Text = "Enable post-processing";
            this.chk_EnablePostProcessing.UseVisualStyleBackColor = true;
            // 
            // chk_EnableMotionBlur
            // 
            this.chk_EnableMotionBlur.AutoSize = true;
            this.chk_EnableMotionBlur.Location = new System.Drawing.Point(12, 181);
            this.chk_EnableMotionBlur.Name = "chk_EnableMotionBlur";
            this.chk_EnableMotionBlur.Size = new System.Drawing.Size(127, 19);
            this.chk_EnableMotionBlur.TabIndex = 17;
            this.chk_EnableMotionBlur.Text = "Enable motion blur";
            this.chk_EnableMotionBlur.UseVisualStyleBackColor = true;
            // 
            // rb_FPSoff
            // 
            this.rb_FPSoff.AutoSize = true;
            this.rb_FPSoff.Location = new System.Drawing.Point(13, 10);
            this.rb_FPSoff.Name = "rb_FPSoff";
            this.rb_FPSoff.Size = new System.Drawing.Size(42, 19);
            this.rb_FPSoff.TabIndex = 18;
            this.rb_FPSoff.TabStop = true;
            this.rb_FPSoff.Text = "Off";
            this.rb_FPSoff.UseVisualStyleBackColor = true;
            // 
            // rb_FPS30
            // 
            this.rb_FPS30.AutoSize = true;
            this.rb_FPS30.Location = new System.Drawing.Point(67, 10);
            this.rb_FPS30.Name = "rb_FPS30";
            this.rb_FPS30.Size = new System.Drawing.Size(37, 19);
            this.rb_FPS30.TabIndex = 19;
            this.rb_FPS30.TabStop = true;
            this.rb_FPS30.Text = "30";
            this.rb_FPS30.UseVisualStyleBackColor = true;
            // 
            // rb_FPS60
            // 
            this.rb_FPS60.AutoSize = true;
            this.rb_FPS60.Location = new System.Drawing.Point(115, 10);
            this.rb_FPS60.Name = "rb_FPS60";
            this.rb_FPS60.Size = new System.Drawing.Size(37, 19);
            this.rb_FPS60.TabIndex = 20;
            this.rb_FPS60.TabStop = true;
            this.rb_FPS60.Text = "60";
            this.rb_FPS60.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "FPS limit:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_FPSoff);
            this.panel1.Controls.Add(this.rb_FPS60);
            this.panel1.Controls.Add(this.rb_FPS30);
            this.panel1.Location = new System.Drawing.Point(84, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 38);
            this.panel1.TabIndex = 22;
            // 
            // chk_EnableSubtitles
            // 
            this.chk_EnableSubtitles.AutoSize = true;
            this.chk_EnableSubtitles.Location = new System.Drawing.Point(12, 206);
            this.chk_EnableSubtitles.Name = "chk_EnableSubtitles";
            this.chk_EnableSubtitles.Size = new System.Drawing.Size(108, 19);
            this.chk_EnableSubtitles.TabIndex = 23;
            this.chk_EnableSubtitles.Text = "Enable subtitles";
            this.chk_EnableSubtitles.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(272, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(221, 263);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "Some informations will be displayed here:\n";
            // 
            // txt_resHeight
            // 
            this.txt_resHeight.Location = new System.Drawing.Point(342, 57);
            this.txt_resHeight.Name = "txt_resHeight";
            this.txt_resHeight.Size = new System.Drawing.Size(78, 23);
            this.txt_resHeight.TabIndex = 25;
            // 
            // txt_hertz
            // 
            this.txt_hertz.Location = new System.Drawing.Point(446, 57);
            this.txt_hertz.Name = "txt_hertz";
            this.txt_hertz.Size = new System.Drawing.Size(47, 23);
            this.txt_hertz.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "X";
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Location = new System.Drawing.Point(367, 378);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(126, 23);
            this.btn_SaveSettings.TabIndex = 28;
            this.btn_SaveSettings.Text = "Save settings";
            this.btn_SaveSettings.UseVisualStyleBackColor = true;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(37, 32);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(263, 45);
            this.trackBar1.TabIndex = 30;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_EnableLaser);
            this.groupBox1.Controls.Add(this.lbl_num_blue);
            this.groupBox1.Controls.Add(this.lbl_num_green);
            this.groupBox1.Controls.Add(this.lbl_num_red);
            this.groupBox1.Controls.Add(this.btn_rgbpicker);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(16, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 170);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laser color:";
            // 
            // chk_EnableLaser
            // 
            this.chk_EnableLaser.AutoSize = true;
            this.chk_EnableLaser.Location = new System.Drawing.Point(390, 122);
            this.chk_EnableLaser.Name = "chk_EnableLaser";
            this.chk_EnableLaser.Size = new System.Drawing.Size(68, 19);
            this.chk_EnableLaser.TabIndex = 32;
            this.chk_EnableLaser.Text = "Enabled";
            this.chk_EnableLaser.UseVisualStyleBackColor = true;
            // 
            // lbl_num_blue
            // 
            this.lbl_num_blue.AutoSize = true;
            this.lbl_num_blue.Location = new System.Drawing.Point(306, 123);
            this.lbl_num_blue.Name = "lbl_num_blue";
            this.lbl_num_blue.Size = new System.Drawing.Size(13, 15);
            this.lbl_num_blue.TabIndex = 38;
            this.lbl_num_blue.Text = "0";
            // 
            // lbl_num_green
            // 
            this.lbl_num_green.AutoSize = true;
            this.lbl_num_green.Location = new System.Drawing.Point(306, 79);
            this.lbl_num_green.Name = "lbl_num_green";
            this.lbl_num_green.Size = new System.Drawing.Size(13, 15);
            this.lbl_num_green.TabIndex = 37;
            this.lbl_num_green.Text = "0";
            // 
            // lbl_num_red
            // 
            this.lbl_num_red.AutoSize = true;
            this.lbl_num_red.Location = new System.Drawing.Point(306, 35);
            this.lbl_num_red.Name = "lbl_num_red";
            this.lbl_num_red.Size = new System.Drawing.Size(13, 15);
            this.lbl_num_red.TabIndex = 36;
            this.lbl_num_red.Text = "0";
            // 
            // btn_rgbpicker
            // 
            this.btn_rgbpicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rgbpicker.Location = new System.Drawing.Point(387, 28);
            this.btn_rgbpicker.Name = "btn_rgbpicker";
            this.btn_rgbpicker.Size = new System.Drawing.Size(71, 66);
            this.btn_rgbpicker.TabIndex = 32;
            this.btn_rgbpicker.UseVisualStyleBackColor = true;
            this.btn_rgbpicker.Click += new System.EventHandler(this.btn_rgbpicker_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 15);
            this.label11.TabIndex = 35;
            this.label11.Text = "B:";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(37, 120);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(263, 45);
            this.trackBar3.TabIndex = 34;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 15);
            this.label10.TabIndex = 33;
            this.label10.Text = "G:";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(37, 76);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(263, 45);
            this.trackBar2.TabIndex = 32;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "R:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.txt_hertz);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_resHeight);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chk_EnableSubtitles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chk_EnableMotionBlur);
            this.Controls.Add(this.chk_EnablePostProcessing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rb_Texture_HD);
            this.Controls.Add(this.rb_Texture_Original);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_ShadowQuality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Anisotropy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_AntiAliasing);
            this.Controls.Add(this.chk_EnableFullscreen);
            this.Controls.Add(this.chk_EnableVSync);
            this.Controls.Add(this.cb_ResolutionPresets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_resWidth);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_resWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ResolutionPresets;
        private System.Windows.Forms.CheckBox chk_EnableVSync;
        private System.Windows.Forms.CheckBox chk_EnableFullscreen;
        private System.Windows.Forms.ComboBox cb_AntiAliasing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Anisotropy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_ShadowQuality;
        private System.Windows.Forms.RadioButton rb_Texture_Original;
        private System.Windows.Forms.RadioButton rb_Texture_HD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_EnablePostProcessing;
        private System.Windows.Forms.CheckBox chk_EnableMotionBlur;
        private System.Windows.Forms.RadioButton rb_FPSoff;
        private System.Windows.Forms.RadioButton rb_FPS30;
        private System.Windows.Forms.RadioButton rb_FPS60;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_EnableSubtitles;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_resHeight;
        private System.Windows.Forms.TextBox txt_hertz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SaveSettings;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_rgbpicker;
        private System.Windows.Forms.Label lbl_num_blue;
        private System.Windows.Forms.Label lbl_num_green;
        private System.Windows.Forms.Label lbl_num_red;
        private System.Windows.Forms.CheckBox chk_EnableLaser;
        private System.Windows.Forms.Timer timer1;
    }
}

