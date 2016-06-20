using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TriaAl_Beatmap_Studio
{
    public partial class Beat_Inserter : Form
    {
        public Beat_Inserter()
        {
            InitializeComponent();
        }

        private void Beat_Inserter_Load(object sender, EventArgs e)
        {
            beat_type_combobox.Text = "Hit";
            beat_column_combobox.Text = "1";
        }

        private void addbeat_button_Click(object sender, EventArgs e)
        {
            //  mainform.debug_listbox.Items.Add((object)(beattime_textbox.Text + ", true, 1"));
            Properties.Settings.Default.time = Convert.ToInt32(beattime_textbox.Text);
            if (beat_type_combobox.Text == "Hit")
            {
                Properties.Settings.Default.hold = false;
            }
            else
            {
                Properties.Settings.Default.hold = true;
            }
            Properties.Settings.Default.position = Convert.ToInt16(beat_column_combobox.Text);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }
    }
}
