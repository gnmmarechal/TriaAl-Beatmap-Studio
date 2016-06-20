namespace TriaAl_Beatmap_Studio
{
    partial class mainform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.media_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.song_title_textbox = new System.Windows.Forms.TextBox();
            this.composer_textbox = new System.Windows.Forms.TextBox();
            this.songtitle_label = new System.Windows.Forms.Label();
            this.composer_label = new System.Windows.Forms.Label();
            this.load_metadata = new System.Windows.Forms.CheckBox();
            this.beat_input_textbox = new System.Windows.Forms.TextBox();
            this.beat_input_label = new System.Windows.Forms.Label();
            this.debug_textbox = new System.Windows.Forms.TextBox();
            this.ms_label = new System.Windows.Forms.Label();
            this.ms_display = new System.Windows.Forms.Label();
            this.debug_listbox = new System.Windows.Forms.ListBox();
            this.totext_button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.mapper_label = new System.Windows.Forms.Label();
            this.mapper_textbox = new System.Windows.Forms.TextBox();
            this.textbox_clear = new System.Windows.Forms.Button();
            this.list_clear = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.deleteone_button = new System.Windows.Forms.Button();
            this.dif_settings_label = new System.Windows.Forms.Label();
            this.ez_radio = new System.Windows.Forms.RadioButton();
            this.normal_radio = new System.Windows.Forms.RadioButton();
            this.hard_radio = new System.Windows.Forms.RadioButton();
            this.ez_dif = new System.Windows.Forms.Label();
            this.normal_dif = new System.Windows.Forms.Label();
            this.hard_dif = new System.Windows.Forms.Label();
            this.ez_dif_num = new System.Windows.Forms.TextBox();
            this.normal_dif_num = new System.Windows.Forms.TextBox();
            this.hard_dif_num = new System.Windows.Forms.TextBox();
            this.timer_export = new System.Windows.Forms.Timer(this.components);
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualBeatInserterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // media_player
            // 
            this.media_player.Enabled = true;
            this.media_player.Location = new System.Drawing.Point(320, 27);
            this.media_player.Name = "media_player";
            this.media_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media_player.OcxState")));
            this.media_player.Size = new System.Drawing.Size(460, 46);
            this.media_player.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicFileToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // musicFileToolStripMenuItem
            // 
            this.musicFileToolStripMenuItem.Name = "musicFileToolStripMenuItem";
            this.musicFileToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.musicFileToolStripMenuItem.Text = "Audio File";
            this.musicFileToolStripMenuItem.Click += new System.EventHandler(this.musicFileToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // song_title_textbox
            // 
            this.song_title_textbox.Location = new System.Drawing.Point(76, 27);
            this.song_title_textbox.Name = "song_title_textbox";
            this.song_title_textbox.Size = new System.Drawing.Size(238, 20);
            this.song_title_textbox.TabIndex = 2;
            // 
            // composer_textbox
            // 
            this.composer_textbox.Location = new System.Drawing.Point(76, 57);
            this.composer_textbox.Name = "composer_textbox";
            this.composer_textbox.Size = new System.Drawing.Size(238, 20);
            this.composer_textbox.TabIndex = 3;
            // 
            // songtitle_label
            // 
            this.songtitle_label.AutoSize = true;
            this.songtitle_label.Location = new System.Drawing.Point(12, 30);
            this.songtitle_label.Name = "songtitle_label";
            this.songtitle_label.Size = new System.Drawing.Size(58, 13);
            this.songtitle_label.TabIndex = 4;
            this.songtitle_label.Text = "Song Title:";
            // 
            // composer_label
            // 
            this.composer_label.AutoSize = true;
            this.composer_label.Location = new System.Drawing.Point(12, 60);
            this.composer_label.Name = "composer_label";
            this.composer_label.Size = new System.Drawing.Size(57, 13);
            this.composer_label.TabIndex = 5;
            this.composer_label.Text = "Composer:";
            // 
            // load_metadata
            // 
            this.load_metadata.AutoSize = true;
            this.load_metadata.Checked = true;
            this.load_metadata.CheckState = System.Windows.Forms.CheckState.Checked;
            this.load_metadata.Location = new System.Drawing.Point(15, 113);
            this.load_metadata.Name = "load_metadata";
            this.load_metadata.Size = new System.Drawing.Size(140, 17);
            this.load_metadata.TabIndex = 6;
            this.load_metadata.Text = "Load Metadata from File";
            this.load_metadata.UseVisualStyleBackColor = true;
            // 
            // beat_input_textbox
            // 
            this.beat_input_textbox.Location = new System.Drawing.Point(80, 231);
            this.beat_input_textbox.Name = "beat_input_textbox";
            this.beat_input_textbox.Size = new System.Drawing.Size(100, 20);
            this.beat_input_textbox.TabIndex = 7;
            this.beat_input_textbox.TextChanged += new System.EventHandler(this.beat_input_textbox_TextChanged);
            // 
            // beat_input_label
            // 
            this.beat_input_label.AutoSize = true;
            this.beat_input_label.Location = new System.Drawing.Point(15, 234);
            this.beat_input_label.Name = "beat_input_label";
            this.beat_input_label.Size = new System.Drawing.Size(59, 13);
            this.beat_input_label.TabIndex = 8;
            this.beat_input_label.Text = "Beat Input:";
            // 
            // debug_textbox
            // 
            this.debug_textbox.Location = new System.Drawing.Point(515, 83);
            this.debug_textbox.Multiline = true;
            this.debug_textbox.Name = "debug_textbox";
            this.debug_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debug_textbox.Size = new System.Drawing.Size(265, 355);
            this.debug_textbox.TabIndex = 9;
            // 
            // ms_label
            // 
            this.ms_label.AutoSize = true;
            this.ms_label.Location = new System.Drawing.Point(13, 449);
            this.ms_label.Name = "ms_label";
            this.ms_label.Size = new System.Drawing.Size(29, 13);
            this.ms_label.TabIndex = 10;
            this.ms_label.Text = "MS: ";
            // 
            // ms_display
            // 
            this.ms_display.AutoSize = true;
            this.ms_display.Location = new System.Drawing.Point(49, 449);
            this.ms_display.Name = "ms_display";
            this.ms_display.Size = new System.Drawing.Size(0, 13);
            this.ms_display.TabIndex = 11;
            // 
            // debug_listbox
            // 
            this.debug_listbox.FormattingEnabled = true;
            this.debug_listbox.Location = new System.Drawing.Point(356, 83);
            this.debug_listbox.Name = "debug_listbox";
            this.debug_listbox.Size = new System.Drawing.Size(143, 355);
            this.debug_listbox.TabIndex = 12;
            this.debug_listbox.SelectedIndexChanged += new System.EventHandler(this.debug_listbox_SelectedIndexChanged);
            // 
            // totext_button
            // 
            this.totext_button.Location = new System.Drawing.Point(547, 444);
            this.totext_button.Name = "totext_button";
            this.totext_button.Size = new System.Drawing.Size(71, 23);
            this.totext_button.TabIndex = 13;
            this.totext_button.Text = "Write";
            this.totext_button.UseVisualStyleBackColor = true;
            this.totext_button.Click += new System.EventHandler(this.totext_button_Click);
            // 
            // export_button
            // 
            this.export_button.Enabled = false;
            this.export_button.Location = new System.Drawing.Point(705, 444);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(75, 23);
            this.export_button.TabIndex = 14;
            this.export_button.Text = "Export";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // mapper_label
            // 
            this.mapper_label.AutoSize = true;
            this.mapper_label.Location = new System.Drawing.Point(12, 87);
            this.mapper_label.Name = "mapper_label";
            this.mapper_label.Size = new System.Drawing.Size(46, 13);
            this.mapper_label.TabIndex = 16;
            this.mapper_label.Text = "Mapper:";
            // 
            // mapper_textbox
            // 
            this.mapper_textbox.Location = new System.Drawing.Point(76, 87);
            this.mapper_textbox.Name = "mapper_textbox";
            this.mapper_textbox.Size = new System.Drawing.Size(238, 20);
            this.mapper_textbox.TabIndex = 17;
            // 
            // textbox_clear
            // 
            this.textbox_clear.Location = new System.Drawing.Point(624, 444);
            this.textbox_clear.Name = "textbox_clear";
            this.textbox_clear.Size = new System.Drawing.Size(75, 23);
            this.textbox_clear.TabIndex = 18;
            this.textbox_clear.Text = "Clear";
            this.textbox_clear.UseVisualStyleBackColor = true;
            this.textbox_clear.Click += new System.EventHandler(this.textbox_clear_Click);
            // 
            // list_clear
            // 
            this.list_clear.Location = new System.Drawing.Point(288, 386);
            this.list_clear.Name = "list_clear";
            this.list_clear.Size = new System.Drawing.Size(62, 23);
            this.list_clear.TabIndex = 19;
            this.list_clear.Text = "Clear";
            this.list_clear.UseVisualStyleBackColor = true;
            this.list_clear.Click += new System.EventHandler(this.list_clear_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(288, 357);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(62, 23);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // deleteone_button
            // 
            this.deleteone_button.Location = new System.Drawing.Point(288, 415);
            this.deleteone_button.Name = "deleteone_button";
            this.deleteone_button.Size = new System.Drawing.Size(62, 23);
            this.deleteone_button.TabIndex = 21;
            this.deleteone_button.Text = "Delete";
            this.deleteone_button.UseVisualStyleBackColor = true;
            this.deleteone_button.Click += new System.EventHandler(this.deleteone_button_Click);
            // 
            // dif_settings_label
            // 
            this.dif_settings_label.AutoSize = true;
            this.dif_settings_label.Location = new System.Drawing.Point(15, 317);
            this.dif_settings_label.Name = "dif_settings_label";
            this.dif_settings_label.Size = new System.Drawing.Size(91, 13);
            this.dif_settings_label.TabIndex = 22;
            this.dif_settings_label.Text = "Difficulty Settings:";
            // 
            // ez_radio
            // 
            this.ez_radio.AutoSize = true;
            this.ez_radio.Location = new System.Drawing.Point(224, 369);
            this.ez_radio.Name = "ez_radio";
            this.ez_radio.Size = new System.Drawing.Size(48, 17);
            this.ez_radio.TabIndex = 23;
            this.ez_radio.Text = "Easy";
            this.ez_radio.UseVisualStyleBackColor = true;
            // 
            // normal_radio
            // 
            this.normal_radio.AutoSize = true;
            this.normal_radio.Checked = true;
            this.normal_radio.Location = new System.Drawing.Point(224, 392);
            this.normal_radio.Name = "normal_radio";
            this.normal_radio.Size = new System.Drawing.Size(58, 17);
            this.normal_radio.TabIndex = 24;
            this.normal_radio.TabStop = true;
            this.normal_radio.Text = "Normal";
            this.normal_radio.UseVisualStyleBackColor = true;
            // 
            // hard_radio
            // 
            this.hard_radio.AutoSize = true;
            this.hard_radio.Location = new System.Drawing.Point(224, 415);
            this.hard_radio.Name = "hard_radio";
            this.hard_radio.Size = new System.Drawing.Size(48, 17);
            this.hard_radio.TabIndex = 25;
            this.hard_radio.Text = "Hard";
            this.hard_radio.UseVisualStyleBackColor = true;
            // 
            // ez_dif
            // 
            this.ez_dif.AutoSize = true;
            this.ez_dif.Location = new System.Drawing.Point(16, 338);
            this.ez_dif.Name = "ez_dif";
            this.ez_dif.Size = new System.Drawing.Size(33, 13);
            this.ez_dif.TabIndex = 26;
            this.ez_dif.Text = "Easy:";
            this.ez_dif.Click += new System.EventHandler(this.ez_dif_Click);
            // 
            // normal_dif
            // 
            this.normal_dif.AutoSize = true;
            this.normal_dif.Location = new System.Drawing.Point(16, 362);
            this.normal_dif.Name = "normal_dif";
            this.normal_dif.Size = new System.Drawing.Size(43, 13);
            this.normal_dif.TabIndex = 27;
            this.normal_dif.Text = "Normal:";
            // 
            // hard_dif
            // 
            this.hard_dif.AutoSize = true;
            this.hard_dif.Location = new System.Drawing.Point(16, 386);
            this.hard_dif.Name = "hard_dif";
            this.hard_dif.Size = new System.Drawing.Size(33, 13);
            this.hard_dif.TabIndex = 28;
            this.hard_dif.Text = "Hard:";
            // 
            // ez_dif_num
            // 
            this.ez_dif_num.Location = new System.Drawing.Point(71, 335);
            this.ez_dif_num.Name = "ez_dif_num";
            this.ez_dif_num.Size = new System.Drawing.Size(35, 20);
            this.ez_dif_num.TabIndex = 29;
            this.ez_dif_num.TextChanged += new System.EventHandler(this.ez_dif_num_TextChanged);
            // 
            // normal_dif_num
            // 
            this.normal_dif_num.Location = new System.Drawing.Point(71, 360);
            this.normal_dif_num.Name = "normal_dif_num";
            this.normal_dif_num.Size = new System.Drawing.Size(35, 20);
            this.normal_dif_num.TabIndex = 30;
            // 
            // hard_dif_num
            // 
            this.hard_dif_num.Location = new System.Drawing.Point(71, 386);
            this.hard_dif_num.Name = "hard_dif_num";
            this.hard_dif_num.Size = new System.Drawing.Size(35, 20);
            this.hard_dif_num.TabIndex = 31;
            // 
            // timer_export
            // 
            this.timer_export.Enabled = true;
            this.timer_export.Tick += new System.EventHandler(this.timer_export_Tick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualBeatInserterToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // manualBeatInserterToolStripMenuItem
            // 
            this.manualBeatInserterToolStripMenuItem.Name = "manualBeatInserterToolStripMenuItem";
            this.manualBeatInserterToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.manualBeatInserterToolStripMenuItem.Text = "Manual Beat Inserter";
            this.manualBeatInserterToolStripMenuItem.Click += new System.EventHandler(this.manualBeatInserterToolStripMenuItem_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 474);
            this.Controls.Add(this.hard_dif_num);
            this.Controls.Add(this.normal_dif_num);
            this.Controls.Add(this.ez_dif_num);
            this.Controls.Add(this.hard_dif);
            this.Controls.Add(this.normal_dif);
            this.Controls.Add(this.ez_dif);
            this.Controls.Add(this.hard_radio);
            this.Controls.Add(this.normal_radio);
            this.Controls.Add(this.ez_radio);
            this.Controls.Add(this.dif_settings_label);
            this.Controls.Add(this.deleteone_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.list_clear);
            this.Controls.Add(this.textbox_clear);
            this.Controls.Add(this.mapper_textbox);
            this.Controls.Add(this.mapper_label);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.totext_button);
            this.Controls.Add(this.debug_listbox);
            this.Controls.Add(this.ms_display);
            this.Controls.Add(this.ms_label);
            this.Controls.Add(this.debug_textbox);
            this.Controls.Add(this.beat_input_label);
            this.Controls.Add(this.beat_input_textbox);
            this.Controls.Add(this.load_metadata);
            this.Controls.Add(this.composer_label);
            this.Controls.Add(this.songtitle_label);
            this.Controls.Add(this.composer_textbox);
            this.Controls.Add(this.song_title_textbox);
            this.Controls.Add(this.media_player);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "TriaAl Beatmap Studio - v1.0.1 Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.media_player)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer media_player;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicFileToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox song_title_textbox;
        private System.Windows.Forms.TextBox composer_textbox;
        private System.Windows.Forms.Label songtitle_label;
        private System.Windows.Forms.Label composer_label;
        private System.Windows.Forms.CheckBox load_metadata;
        private System.Windows.Forms.TextBox beat_input_textbox;
        private System.Windows.Forms.Label beat_input_label;
        private System.Windows.Forms.TextBox debug_textbox;
        private System.Windows.Forms.Label ms_label;
        private System.Windows.Forms.Label ms_display;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button totext_button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Label mapper_label;
        private System.Windows.Forms.TextBox mapper_textbox;
        private System.Windows.Forms.Button textbox_clear;
        private System.Windows.Forms.Button list_clear;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button deleteone_button;
        private System.Windows.Forms.Label dif_settings_label;
        private System.Windows.Forms.RadioButton ez_radio;
        private System.Windows.Forms.RadioButton normal_radio;
        private System.Windows.Forms.RadioButton hard_radio;
        private System.Windows.Forms.Label ez_dif;
        private System.Windows.Forms.Label normal_dif;
        private System.Windows.Forms.Label hard_dif;
        private System.Windows.Forms.TextBox ez_dif_num;
        private System.Windows.Forms.TextBox normal_dif_num;
        private System.Windows.Forms.TextBox hard_dif_num;
        private System.Windows.Forms.Timer timer_export;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualBeatInserterToolStripMenuItem;
        public System.Windows.Forms.ListBox debug_listbox;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}

