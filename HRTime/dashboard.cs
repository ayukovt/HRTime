using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Shapes;
using AutoUpdaterDotNET;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Path = System.IO.Path;

namespace HRTime
{

    public partial class dashboard
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public dashboard()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void dashboard_Close(object sender, EventArgs e)
        {
            var trayappman = new TrayApplicationManager();
            trayappman.TrayIcon.BalloonTipText = "Minimized to system tray.";
            trayappman.TrayIcon.ShowBalloonTip(500);
        }
        private void ForeverButton1_Click(object sender, EventArgs e)
        {
            MoonLabel2.Text = "Username";
            MaterialTabControl1.SelectedTab = TabPage1;
        }

        private void ForeverButton2_Click(object sender, EventArgs e)
        {
            MoonLabel2.Text = "Frequency";
            MaterialTabControl1.SelectedTab = TabPage2;
        }

        private void ForeverButton3_Click(object sender, EventArgs e)
        {
            MoonLabel2.Text = "Alert Sound";
            MaterialTabControl1.SelectedTab = TabPage3;
        }

        private void ForeverButton4_Click(object sender, EventArgs e)
        {
            MoonLabel2.Text = "Updater";
            MaterialTabControl1.SelectedTab = TabPage4;
        }

        private void ForeverButton5_Click(object sender, EventArgs e)
        {
            MoonLabel2.Text = "Reset";
            MaterialTabControl1.SelectedTab = TabPage5;
        }

        private void ForeverButton6_Click(object sender, EventArgs e)
        {
            MoonLabel2.Text = "About";
            MaterialTabControl1.SelectedTab = TabPage6;
        }

        private void ForeverButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ForeverButton7_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void URLOpen(string Url)
        {

            var OpenURL = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = "explorer.exe",
                Arguments = Url
            };

            Process.Start(OpenURL);

        }

        private void ForeverButton9_Click(object sender, EventArgs e)
        {
            URLOpen("https://twitter.com/0xilis");
        }

        private void ForeverButton10_Click(object sender, EventArgs e)
        {
            URLOpen("https://twitter.com/kittymeowder");
        }

        private void ForeverButton11_Click(object sender, EventArgs e)
        {
            URLOpen("https://github.com/0xilis"); // mac (ew) user smh
        }

        private void ForeverButton12_Click(object sender, EventArgs e)
        {
            URLOpen("https://www.github.com/Kat-Kipling"); // goated dev ily kat mwahh (platonically)
        }

        private void FoxLinkLabel1_Click(object sender, EventArgs e)
        {
            URLOpen(FoxLinkLabel1.Text);
        }

        private void FoxLinkLabel2_Click(object sender, EventArgs e)
        {
            URLOpen(FoxLinkLabel2.Text);
        }

        private void NightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            URLOpen("https://ko-fi.com/ayukovt"); // the pupy :3
        }

        private void FoxButton5_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.alert.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            moonLabel33.Text = My.MySettingsProperty.Settings.Username;
            moonLabel34.Text = My.MySettingsProperty.Settings.AudioPath;
            moonLabel35.Text = My.MySettingsProperty.Settings.NextDoseDate;
            moonLabel36.Text = My.MySettingsProperty.Settings.INTERVAL_TYPE;
            moonLabel37.Text = My.MySettingsProperty.Settings.INTERVAL_VALUE;
            moonLabel38.Text = My.MySettingsProperty.Settings.AutoUpdate;
            moonLabel39.Text = My.MySettingsProperty.Settings.AutoUpCheck;
            moonLabel41.Text = My.MySettingsProperty.Settings.FirstSetupNeeded;
            if (string.IsNullOrEmpty(My.MySettingsProperty.Settings.UpLastChecked))
            {
                MoonLabel25.Text = "null";
            }
            else
            {
                MoonLabel25.Text = My.MySettingsProperty.Settings.UpLastChecked;
            }
            if (My.MySettingsProperty.Settings.FirstSetupNeeded == "true")
            {
                MaterialTabControl1.SelectedTab = TabPage7;
                ForeverButton1.Hide();
                ForeverButton2.Hide();
                ForeverButton3.Hide();
                ForeverButton4.Hide();
                ForeverButton5.Hide();
                ForeverButton6.Hide();
            }
            else
            {
                MaterialTabControl1.SelectedTab = TabPage1;
            }
            if (My.MySettingsProperty.Settings.AutoUpdate == "True")
            {
                ParrotCheckBox2.Checked = true;
                ParrotCheckBox1.Checked = true;
            }
            if (My.MySettingsProperty.Settings.AutoUpCheck == "True")
            {
                ParrotCheckBox1.Checked = true;
            }
            ForeverTextBox1.Text = My.MySettingsProperty.Settings.Username;
            ForeverTextBox2.Text = My.MySettingsProperty.Settings.AudioPath;
        }

        private void FoxButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ForeverTextBox1.Text))
            {
                MessageBox.Show("Please enter something in the text box first.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                My.MySettingsProperty.Settings.Username = ForeverTextBox1.Text;
                My.MySettingsProperty.Settings.Save();
                MessageBox.Show("Username has been successfully changed.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (fourchanTerms.Any(term => Strings.InStr(ForeverTextBox1.Text, term, Constants.vbTextCompare) > 0))
            {
                MessageBox.Show("4chan term detected. please get off 4chan and go outside im begging you", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                My.MySettingsProperty.Settings.Username = ForeverTextBox1.Text;
                My.MySettingsProperty.Settings.Save();
                MessageBox.Show("Username has been successfully changed.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FoxButton2_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Audio path has been successfully changed.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FoxButton4_Click(object sender, EventArgs e)
        {
            var resetConfirmation = MessageBox.Show("Are you sure you want to reset user settings?", "HRTime", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resetConfirmation == DialogResult.Yes)
            {
                My.MySettingsProperty.Settings.Username = null;
                My.MySettingsProperty.Settings.NextDoseDate = null;
                My.MySettingsProperty.Settings.INTERVAL_TYPE = null;
                My.MySettingsProperty.Settings.INTERVAL_VALUE = null;
                My.MySettingsProperty.Settings.AudioPath = null;
                My.MySettingsProperty.Settings.AutoUpdate = null;
                My.MySettingsProperty.Settings.AutoUpCheck = null;
                My.MySettingsProperty.Settings.FirstSetupNeeded = "true";
                My.MySettingsProperty.Settings.Save();
                Application.Restart();
            }
        }

        private void FoxButton3_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://ayuworks.xyz/hrtime_updater.xml");
            My.MySettingsProperty.Settings.UpLastChecked = Conversions.ToString(DateTime.Now);
            My.MySettingsProperty.Settings.Save();
            MoonLabel25.Text = My.MySettingsProperty.Settings.UpLastChecked;
        }

        private void ParrotCheckBox1_Click(object sender, EventArgs e)
        {
            if (ParrotCheckBox1.Checked == false) // its reversed bc the checkbox state changes *after* the click event btw
            {
                My.MySettingsProperty.Settings.AutoUpCheck = "True";
                My.MySettingsProperty.Settings.Save();
            }
            else
            {
                My.MySettingsProperty.Settings.AutoUpCheck = "False";
                My.MySettingsProperty.Settings.Save();
            }
        }

        private void ParrotCheckBox2_Click(object sender, EventArgs e)
        {
            if (ParrotCheckBox2.Checked == false) // same goes here
            {
                ParrotCheckBox1.Checked = true;
                My.MySettingsProperty.Settings.AutoUpdate = "True";
                My.MySettingsProperty.Settings.AutoUpCheck = "True";
                My.MySettingsProperty.Settings.Save();
            }
            else
            {
                My.MySettingsProperty.Settings.AutoUpdate = "False";
                My.MySettingsProperty.Settings.Save();
            }
        }

        private List<string> fourchanTerms = new List<string>() {
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
            "mogs", "repper", "hsts" }; // copied from firstsetup bc apparently i cant just reference it in a different .cs file

        private void FoxButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Audio files|*.mp3;*.wav;*.aac;*.wma";
            OpenFileDialog1.Title = "Select the reminder audio file";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ForeverTextBox2.Text = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName) + @"\" + System.IO.Path.GetFileName(OpenFileDialog1.FileName);
            }
        }

        private void foxButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\" + Environment.UserName + @"\AppData\Local\ayuworks.xyz\");
        }

        private void foxButton8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
