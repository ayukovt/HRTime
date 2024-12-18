using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

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
            // Minimize the form to the tray
            this.Hide(); // This hides the form without closing it
    
            // Show balloon tip (optional)
            TrayApplicationManager trybarManager = TrayApplicationManager.Instance;  // Use existing instance
            trybarManager.TrayIcon.BalloonTipText = "Minimized to system tray.";
            trybarManager.TrayIcon.ShowBalloonTip(500);
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
                Debug.WriteLine("textbox is empty msgbox");
                MessageBox.Show("Please enter something in the text box first.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                My.MySettingsProperty.Settings.Username = ForeverTextBox1.Text;
                My.MySettingsProperty.Settings.Save();
                Debug.WriteLine("name = " + ForeverTextBox1.Text);
            }
            if (fourchanTerms.Any(term => Strings.InStr(ForeverTextBox1.Text, term, Constants.vbTextCompare) > 0))
            {
                Debug.WriteLine("4chan term msgbox");
                MessageBox.Show("4chan term detected. please get off 4chan and go outside im begging you", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                My.MySettingsProperty.Settings.Username = ForeverTextBox1.Text;
                My.MySettingsProperty.Settings.Save();
                Debug.WriteLine("name = " + ForeverTextBox1.Text);
            }
        }

        private void FoxButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ForeverTextBox2.Text))
            {
                if (Path.GetExtension(ForeverTextBox2.Text).ToLower() == ".wav")
                {
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
                    MessageBox.Show("Invalid file type. Please select a valid .wav audio file.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                My.MySettingsProperty.Settings.FirstSetupNeeded = "true";
                My.MySettingsProperty.Settings.Save();
                Application.Restart();
            }
        }

        private void FoxButton3_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml");
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
            OpenFileDialog1.Filter = "wav files|*.wav";
            OpenFileDialog1.Title = "Select the reminder audio file";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine("filedialog opened");
                ForeverTextBox2.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) + @"\" + Path.GetFileName(OpenFileDialog1.FileName);
            }
        }
    }
}
