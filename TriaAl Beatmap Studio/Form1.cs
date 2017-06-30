using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TagLib;

namespace TriaAl_Beatmap_Studio
{

    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        string music_filename;
        double startTime;
        double timepaused;
        bool paused = true;
        double starttimepause, mathe;
        bool playing = false;
        int format = 1;
        string filename;
        public int timers;
        private void musicFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_music_dialog = new OpenFileDialog();
            open_music_dialog.Filter = "Vorbis Ogg File Format (*.ogg)|*.ogg|Waveform Audio File Format (*.wav)|*.wav|All Files (*.*)|*.*";
            open_music_dialog.Multiselect = false;
            open_music_dialog.FilterIndex = 1;
            DialogResult result = open_music_dialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                song_title_textbox.Text = "";
                composer_textbox.Text = "";
                music_filename = open_music_dialog.FileName;
                if (music_filename.EndsWith(".ogg"))
                {
                    load_metadata.Checked = false;
                }
                if (load_metadata.Checked)
                {

                    try
                    {
                        TagLib.File tagFile = TagLib.File.Create(music_filename);
                        song_title_textbox.Text = tagFile.Tag.Title;
                        composer_textbox.Text = tagFile.Tag.AlbumArtists[0];
                    }
                    catch (Exception a) { };

                }
                media_player.URL = music_filename;
                timer1.Start();
                startTime = (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
                ms_display.Text = "";

            }
            else
            {
                MessageBox.Show("Error. Invalid file.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (media_player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (playing == true)
                {
                    timepaused = (Math.Round((DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds - this.startTime)) - starttimepause;
                    playing = false;
                    paused = true;
                }
                mathe = (Math.Round((DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds - this.startTime)) - timepaused;
                ms_display.Text = mathe.ToString();
            }
            if (media_player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                startTime = (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
                timepaused = 0;
                starttimepause = 0;
            }
            if (media_player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                if (paused == true)
                {
                    starttimepause = mathe;
                    paused = false;
                    playing = true;
                }
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TriaAl Beatmap Studio\nMade by gnmmarechal/gnmpolicemata\n\nhttp://gs2012.xyz\nhttp://youtube.com/gnmpolicemata\n\nSpecial thanks to Rinnegatamante.");
        }

        private void totext_button_Click(object sender, EventArgs e)
        {
            export_button.Enabled = true;
            debug_textbox.Clear();
            if (mapper_textbox.Text == "")
                mapper_textbox.Text = "John Doe";
            debug_textbox.AppendLine("--Generated with TriaAl Beatmap Studio");
            debug_textbox.AppendLine("--Using beatmap file format:");
            debug_textbox.AppendLine("beatmap_format = "+ format);
            debug_textbox.AppendLine("beatmap_author = \"" + mapper_textbox.Text + "\"");
            debug_textbox.AppendLine("--Song information:");
            debug_textbox.AppendLine("song_title = \"" + song_title_textbox.Text + "\"");
            debug_textbox.AppendLine("song_composer = \"" + composer_textbox.Text + "\"");
            debug_textbox.AppendLine("--Difficulty Information:");
            debug_textbox.AppendLine("l1 = " + ez_dif_num.Text);
            debug_textbox.AppendLine("l2 = " + normal_dif_num.Text);
            debug_textbox.AppendLine("l3 = " + hard_dif_num.Text);
            debug_textbox.AppendLine(" ");
            debug_textbox.AppendLine("--Beatmap:");
            debug_textbox.AppendLine("if mode == \"Easy\" then ");
            debug_textbox.Text += Environment.NewLine + System.IO.File.ReadAllText("easy.tbs");
            debug_textbox.AppendLine("elseif mode == \"Normal\" then");
            debug_textbox.Text += Environment.NewLine + System.IO.File.ReadAllText("normal.tbs");
            debug_textbox.AppendLine("elseif mode == \"Hard\" then");
            debug_textbox.Text += Environment.NewLine + System.IO.File.ReadAllText("hard.tbs");
            debug_textbox.AppendLine("end");
        }

        private void textbox_clear_Click(object sender, EventArgs e)
        {
            debug_textbox.Clear();
        }

        private void list_clear_Click(object sender, EventArgs e)
        {
            debug_listbox.Items.Clear();
        }

        private void deleteone_button_Click(object sender, EventArgs e)
        {
            debug_listbox.Items.Remove(debug_listbox.SelectedItem);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
            if (ez_radio.Checked)
            {
                filename = "easy.tbs";
            }
            if (normal_radio.Checked)
            {
                filename = "normal.tbs";
            }
            if (hard_radio.Checked)
            {
                filename = "hard.tbs";
            }
            if (System.IO.File.Exists(filename))
            {
                System.IO.File.Delete(filename);
            }
            debug_textbox.AppendLine("\tnotes = {{" + debug_listbox.Items[0] + "},");
            int index = 1;
            while (index < debug_listbox.Items.Count)
            {
                debug_textbox.AppendLine("\t\t\t {" + debug_listbox.Items[index] + "},");
                checked { ++index; }
            }
            debug_textbox.Text = debug_textbox.Text.Remove(debug_textbox.Text.LastIndexOf(Environment.NewLine));
            debug_textbox.AppendLine("\t\t\t {" + debug_listbox.Items[index-1] + "}");
            debug_textbox.AppendLine("\t\t\t}");
            System.IO.File.WriteAllText(filename, debug_textbox.Text);
            debug_textbox.Clear();
        }

        private void ez_dif_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void ez_dif_Click(object sender, EventArgs e)
        {

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_beatmap_dialog = new SaveFileDialog();
            save_beatmap_dialog.Filter = "Lua Script (*.lua)|*.lua";
            save_beatmap_dialog.FilterIndex = 1;
            DialogResult result = save_beatmap_dialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                export_button.Enabled = false;
                System.IO.File.WriteAllText(save_beatmap_dialog.FileName, debug_textbox.Text);
            }
                
        }

        private void timer_export_Tick(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("easy.tbs") & System.IO.File.Exists("normal.tbs") & System.IO.File.Exists("hard.tbs") & String.IsNullOrWhiteSpace(ez_dif_num.Text) == false & String.IsNullOrWhiteSpace(normal_dif_num.Text) == false & String.IsNullOrWhiteSpace(hard_dif_num.Text) == false & String.IsNullOrWhiteSpace(composer_textbox.Text) == false & String.IsNullOrWhiteSpace(song_title_textbox.Text) == false)
            {
                totext_button.Enabled = true;
            }
            else
            {
                totext_button.Enabled = false;
            }
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            
            if (Properties.Settings.Default.time != -1)
            {
                debug_listbox.Items.Add((object)(Properties.Settings.Default.time + ", " + (Convert.ToString(!Properties.Settings.Default.hold)).ToLower() + ", " + Properties.Settings.Default.position));
                Properties.Settings.Default.time = -1;
                Properties.Settings.Default.hold = false;
                Properties.Settings.Default.position = 0;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }

        }

        private void manualBeatInserterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beat_Inserter beatinserter = new Beat_Inserter();
            beatinserter.Show();
        }

        private void debug_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void beat_input_textbox_TextChanged(object sender, EventArgs e)
        {
            //For regular notes
            if (media_player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (beat_input_textbox.Text == "1")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", true, 1"));

                }
                if (beat_input_textbox.Text == "2")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", true, 2"));
                }
                if (beat_input_textbox.Text == "3")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", true, 3"));
                }
                if (beat_input_textbox.Text == "4")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", true, 4"));
                }
                //For Hold notes
                if (beat_input_textbox.Text == "Q" || beat_input_textbox.Text == "q")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", false, 1"));
                }
                if (beat_input_textbox.Text == "W" || beat_input_textbox.Text == "w")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", false, 2"));
                }
                if (beat_input_textbox.Text == "E" || beat_input_textbox.Text == "e")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", false, 3"));
                }
                if (beat_input_textbox.Text == "R" || beat_input_textbox.Text == "r")
                {
                    debug_listbox.Items.Add((object)(ms_display.Text + ", false, 4"));
                }
                debug_listbox.SelectedIndex = checked(debug_listbox.Items.Count - 1);
            }
            beat_input_textbox.Text = "";
        }
    }
    public static class WinFormsExtensions
    {
        public static void AppendLine(this System.Windows.Forms.TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
