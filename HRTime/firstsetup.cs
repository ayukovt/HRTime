using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HRTime
{

    public partial class firstsetup
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public firstsetup()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void firstsetup_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void FoxButton1_Click(object sender, EventArgs e)
        {
            MaterialTabControl1.SelectedTab = TabPage2;
        }

        private void FoxButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ForeverTextBox1.Text))
            {
                MessageBox.Show("Please enter something in the text box first.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                My.MySettingsProperty.Settings.Username = ForeverTextBox1.Text;
                My.MySettingsProperty.Settings.Save();
                MaterialTabControl1.SelectedTab = TabPage3;
            }
            var fourchanTerms = new List<string>() { 
                "passoid", "gigahon", "ogrehon", 
                "ogre", "boymoder", "manmoder", 
                "tranny", "gorillamoder", "brickhon", 
                "boomerhon", "bitterhon", "heighthon", 
                "honmoder", "innerhon", "outerhon", 
                "rapehon", "reddithon", "ribcagehon", 
                "shadowhon", "shoulderhon", "sneedhon", 
                "twinkhon", "iwnbam", "gayden", 
                "poonbro", "pooner", "tunapoon", 
                "gigapoon", "manlet", "tranner", 
                "troon", "transmaxxing", "youngshit", 
                "midshit", "oldshit", "agp", "husstuss", 
                "boyremove", "trannerexia", "luckshit", 
                "malefail", "mog", "mogging",
                "mogs", "repper", "hsts" };
            if (fourchanTerms.Any(term => Strings.InStr(ForeverTextBox1.Text, term, Constants.vbTextCompare) > 0))
            {
                Debug.WriteLine("4chan term msgbox");
                MessageBox.Show("4chan term detected. please get off 4chan and go outside im begging you", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                My.MySettingsProperty.Settings.Username = ForeverTextBox1.Text;
                My.MySettingsProperty.Settings.Save();
                MaterialTabControl1.SelectedTab = TabPage3;
            }
        }

        private void FoxButton3_Click(object sender, EventArgs e)
        {
            if (DungeonNumeric1.Value == 0L)
            {
                MessageBox.Show("Invalid amount.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Logic for setting settings for schedule
                // As mentioned in the handler section, this is probably shit
                // Look into adding a Windows Task Scheduler entry for a job that runs based on the given interval and displays a form
                if (DungeonComboBox1.SelectedItem.ToString().Trim() == "day(s)")
                {
                    My.MySettingsProperty.Settings.NextDoseDate = Conversions.ToString(DateTime.Now.AddDays(DungeonNumeric1.Value));
                    My.MySettingsProperty.Settings.INTERVAL_TYPE = "day";
                    My.MySettingsProperty.Settings.INTERVAL_VALUE = DungeonNumeric1.Value.ToString();
                }
                else if (DungeonComboBox1.SelectedItem.ToString().Trim() == "week(s)")
                {
                    My.MySettingsProperty.Settings.NextDoseDate = Conversions.ToString(DateTime.Now.AddDays(DungeonNumeric1.Value * 7L)); // + 7 from the given value as we're adding days, but this is for week. 1 * 7 = 7, 2 * 7 = 14 (2 weeks), 3 * 7 = 21 (3 weeks), etc
                    My.MySettingsProperty.Settings.INTERVAL_TYPE = "week";
                    My.MySettingsProperty.Settings.INTERVAL_VALUE = (DungeonNumeric1.Value * 7L).ToString();
                }
                else if (DungeonComboBox1.SelectedItem.ToString().Trim() == "month(s)")
                {
                    My.MySettingsProperty.Settings.NextDoseDate = Conversions.ToString(DateTime.Now.AddMonths((int)DungeonNumeric1.Value));
                    My.MySettingsProperty.Settings.INTERVAL_TYPE = "month";
                    My.MySettingsProperty.Settings.INTERVAL_VALUE = DungeonNumeric1.Value.ToString();
                }
                else
                {
                    MessageBox.Show("An unknown error has occured, please tell exactly what you did and report it on GitHub issues so we can diagnose it.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                My.MySettingsProperty.Settings.Save();
                MaterialTabControl1.SelectedTab = TabPage4;
            }
        }

        private void FoxButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Audio files|*.mp3;*.wav;*.aac;*.wma";
            OpenFileDialog1.Title = "Select the reminder audio file";
            // We do DialogResult.OK to ensure it was confirmed by the user before saving so if for whatever reason the universe implodes upon itself and somehow the dialog box crashes (???) it won't save NULL and permanently crash HRTime
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ForeverTextBox2.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) + @"\" + Path.GetFileName(OpenFileDialog1.FileName);
            }
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void FoxButton4_Click(object sender, EventArgs e)
        {
            // I think with the check I added in FoxButton5, this is impossible to be NULL, but just in case...
            if (!string.IsNullOrEmpty(ForeverTextBox2.Text))
            {

                // The most important check: MAKE SURE IT IS A .WAV FILE.
                // technically this can be improved if a user is dumb and renames a .mp3 file to .wav and doesn't actually convert it but honestly that's on them...
                var extnCheck = Path.GetExtension(ForeverTextBox2.Text).ToLower();

                if (extnCheck == ".wav" || extnCheck == ".mp3" || extnCheck == ".aac" || extnCheck == ".wma")
                {

                    // If a user, for some reason, selects a file that doesn't exist. This seems impossible and like a useless check but this actually can help us for cases when we don't have read permission for a file, so it deserves to be here.

                    if (File.Exists(ForeverTextBox2.Text))
                    {
                        My.MySettingsProperty.Settings.AudioPath = ForeverTextBox2.Text;
                        My.MySettingsProperty.Settings.Save();
                        Debug.WriteLine("audiodir = " + ForeverTextBox2.Text);
                        MaterialTabControl1.SelectedTab = TabPage5;
                    }
                    else
                    {
                        MessageBox.Show("The selected audio file does not exist. Please choose a valid file.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file type. Please select a valid audio file.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an audio file first.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void FoxButton6_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.AutoUpdate = "True";
            My.MySettingsProperty.Settings.AutoUpCheck = "True";
            My.MySettingsProperty.Settings.Save();
            MaterialTabControl1.SelectedTab = TabPage6;
        }

        private void FoxButton7_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.AutoUpdate = "False";
            My.MySettingsProperty.Settings.Save();
            MaterialTabControl1.SelectedTab = TabPage6;
        }

        private void FoxButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HRTime is currently in very early alpha stage. If any issues occur, report it to the devs on github.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            My.MySettingsProperty.Settings.FirstSetupNeeded = "false";
            My.MySettingsProperty.Settings.Save();
            Close();
            Application.Restart(); // workaround for the Form1 (now moved to TrayApplicationManager, idk if the bug still exists) bug until we either switch to task scheduling or figure out the issue
        }

        private void ForeverButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ForeverButton7_Click(object sender, EventArgs e)
        {
            var exitConfirmation = MessageBox.Show("Do you want to exit? Any unsaved settings will be lost.", "HRTime", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (exitConfirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}