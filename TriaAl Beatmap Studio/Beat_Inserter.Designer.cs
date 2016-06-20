namespace TriaAl_Beatmap_Studio
{
    partial class Beat_Inserter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beat_Inserter));
            this.beattime_textbox = new System.Windows.Forms.TextBox();
            this.beat_type_combobox = new System.Windows.Forms.ComboBox();
            this.beat_column_combobox = new System.Windows.Forms.ComboBox();
            this.addbeat_button = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.notetype_label = new System.Windows.Forms.Label();
            this.note_pos_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beattime_textbox
            // 
            this.beattime_textbox.Location = new System.Drawing.Point(12, 29);
            this.beattime_textbox.Name = "beattime_textbox";
            this.beattime_textbox.Size = new System.Drawing.Size(100, 20);
            this.beattime_textbox.TabIndex = 0;
            // 
            // beat_type_combobox
            // 
            this.beat_type_combobox.FormattingEnabled = true;
            this.beat_type_combobox.Items.AddRange(new object[] {
            "Hit",
            "Hold"});
            this.beat_type_combobox.Location = new System.Drawing.Point(118, 29);
            this.beat_type_combobox.Name = "beat_type_combobox";
            this.beat_type_combobox.Size = new System.Drawing.Size(58, 21);
            this.beat_type_combobox.TabIndex = 1;
            // 
            // beat_column_combobox
            // 
            this.beat_column_combobox.FormattingEnabled = true;
            this.beat_column_combobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.beat_column_combobox.Location = new System.Drawing.Point(182, 29);
            this.beat_column_combobox.Name = "beat_column_combobox";
            this.beat_column_combobox.Size = new System.Drawing.Size(45, 21);
            this.beat_column_combobox.TabIndex = 2;
            // 
            // addbeat_button
            // 
            this.addbeat_button.Location = new System.Drawing.Point(233, 48);
            this.addbeat_button.Name = "addbeat_button";
            this.addbeat_button.Size = new System.Drawing.Size(75, 23);
            this.addbeat_button.TabIndex = 3;
            this.addbeat_button.Text = "Add";
            this.addbeat_button.UseVisualStyleBackColor = true;
            this.addbeat_button.Click += new System.EventHandler(this.addbeat_button_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(12, 10);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(55, 13);
            this.time_label.TabIndex = 4;
            this.time_label.Text = "Time (ms):";
            // 
            // notetype_label
            // 
            this.notetype_label.AutoSize = true;
            this.notetype_label.Location = new System.Drawing.Point(118, 9);
            this.notetype_label.Name = "notetype_label";
            this.notetype_label.Size = new System.Drawing.Size(34, 13);
            this.notetype_label.TabIndex = 5;
            this.notetype_label.Text = "Type:";
            // 
            // note_pos_label
            // 
            this.note_pos_label.AutoSize = true;
            this.note_pos_label.Location = new System.Drawing.Point(179, 9);
            this.note_pos_label.Name = "note_pos_label";
            this.note_pos_label.Size = new System.Drawing.Size(47, 13);
            this.note_pos_label.TabIndex = 6;
            this.note_pos_label.Text = "Position:";
            // 
            // Beat_Inserter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 83);
            this.Controls.Add(this.note_pos_label);
            this.Controls.Add(this.notetype_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.addbeat_button);
            this.Controls.Add(this.beat_column_combobox);
            this.Controls.Add(this.beat_type_combobox);
            this.Controls.Add(this.beattime_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Beat_Inserter";
            this.Text = "Manual Beat Inserter";
            this.Load += new System.EventHandler(this.Beat_Inserter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox beattime_textbox;
        private System.Windows.Forms.ComboBox beat_type_combobox;
        private System.Windows.Forms.ComboBox beat_column_combobox;
        private System.Windows.Forms.Button addbeat_button;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label notetype_label;
        private System.Windows.Forms.Label note_pos_label;
    }
}