using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HRTime
{

    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            My.MyProject.Forms.dashboard.FoxButton5.Hide();
            My.MyProject.Forms.dashboard.MoonLabel22.Hide();
            My.MyProject.Forms.dashboard.MoonLabel23.Hide();
            foreach (string argument in My.MyProject.Application.CommandLineArgs)
            {
                if (argument == "-debug")
                {
                    My.MyProject.Forms.dashboard.Text = "[DEBUG] HRTime Settings";
                    My.MyProject.Forms.firstsetup.Text = "[DEBUG] HRTime First Setup";
                    My.MyProject.Forms.dashboard.FoxButton5.Show();
                    My.MyProject.Forms.dashboard.MoonLabel22.Show();
                    My.MyProject.Forms.dashboard.MoonLabel23.Show();
                }

                if (argument == "-alert")
                {
                    // will be useful once we start using task scheduling
                    My.MyProject.Forms.alert.Show();
                }
            }
            string fontName = "Poppins";
            float fontSize = 12.0f;

            using (var fontTester = new Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel)) // before anyone says anything yes I could just bundle the font in the exe but mf I use like 4 different variants (which means 4 .ttf files) and there's like
            {
                if ((fontTester.Name ?? "") == (fontName ?? ""))                                         // 50 different fucking labels that use all of these variants interchangeably I can't just make a list of labels and set the font of everything in code to "Poppins"
                {
                    Debug.WriteLine("poppins font detected. continuing.");                               // bc thats just not gonna work (or im just stupid) idk ill figure it out at some point
                }
                else
                {
                    var fontmissingConfirmation = MessageBox.Show("Poppins has not been detected. HRTime requires Poppins to be installed on the system for displaying the UI correctly. Download font?", "HRTime", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (fontmissingConfirmation == DialogResult.Yes)
                    {
                        My.MyProject.Forms.dashboard.URLOpen("https://fonts.google.com/specimen/Poppins");
                        Application.Exit();
                    }
                }
            }
            AutoUpdater.RunUpdateAsAdmin = false;
            if (My.MySettingsProperty.Settings.AutoUpCheck == "True")
            {
                AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml");
                My.MySettingsProperty.Settings.UpLastChecked = Conversions.ToString(DateTime.Now);
                My.MySettingsProperty.Settings.Save();
                My.MyProject.Forms.dashboard.MoonLabel25.Text = My.MySettingsProperty.Settings.UpLastChecked;
            }
            if (My.MySettingsProperty.Settings.AutoUpdate == "True")
            {
                AutoUpdater.Mandatory = true;
                AutoUpdater.UpdateMode = Mode.ForcedDownload;
                AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml");
            }
            NotifyIcon1.Visible = true;
            WindowState = FormWindowState.Minimized;
            Opacity = 0d;
            if (My.MySettingsProperty.Settings.FirstSetupNeeded == "false")
            {
                Debug.WriteLine("firstsetupneeded = " + My.MySettingsProperty.Settings.FirstSetupNeeded);
                Debug.WriteLine("running handler tasks..");
                Interaction.MsgBox("kiss ur sister");
            }
            else if (My.MySettingsProperty.Settings.FirstSetupNeeded == "true" | string.IsNullOrEmpty(My.MySettingsProperty.Settings.FirstSetupNeeded))
            {
                My.MySettingsProperty.Settings.FirstSetupNeeded = "true";
                My.MySettingsProperty.Settings.Save();
                Debug.WriteLine("running firstsetup..");
                My.MyProject.Forms.firstsetup.Show();
            }
            Timer1.Enabled = true;
            Timer1.Start();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            My.MyProject.Forms.dashboard.Show();
            NotifyIcon1.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Probably best to look into how to schedule a task in windows Task Scheduler, and schedule it in the setup section

            // there seems to be an issue idk if anyone else can recreate it but after going through firstsetup, change the date and time right before "NextDoseDate". Normally it should trigger the alert but for some reason it doesn't
            // HOWEVER when you restart the exe and manually go into the user.config file and change the NextDoseDate string value (didn't test yet restarting the exe and then just changing the system time), suddenly the alert gets triggered just fine

            var now = DateTime.Now;
            My.MyProject.Forms.dashboard.MoonLabel23.Text = Conversions.ToString(now);
            Label1.Text = Conversions.ToString(now);
            if ((My.MySettingsProperty.Settings.NextDoseDate ?? "") == (Label1.Text ?? "")) // apparently vbnet (now C# so check back at this and rewrite later) cant read now.ToString directly (prob bc theres no string to output it to or smth idfk I suck at this)
            {                                                                               // so for now, we have this janky ass workaround with a label until we figure out how task scheduling works
                My.MyProject.Forms.alert.Show();                                            // puppy needs her wife to cuddle after releasing this monstrosity,,,, waaaaaaaa
            }                                                                    
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}