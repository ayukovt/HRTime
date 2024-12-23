using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Documents;
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
            var daboard = My.MyProject.Forms.dashboard;
            //i am so sorry for pulling a yandev please forgive me ill fix this at some point (or pls commit a better way on github im gonna praise u forever if u do)
            daboard.FoxButton5.Hide();
            daboard.foxButton7.Hide();
            daboard.foxButton8.Hide();
            daboard.MoonLabel22.Hide();
            daboard.MoonLabel23.Hide();
            daboard.moonLabel26.Hide();
            daboard.moonLabel27.Hide();
            daboard.moonLabel28.Hide();
            daboard.moonLabel29.Hide();
            daboard.moonLabel30.Hide();
            daboard.moonLabel31.Hide();
            daboard.moonLabel32.Hide();
            daboard.moonLabel33.Hide();
            daboard.moonLabel34.Hide();
            daboard.moonLabel35.Hide();
            daboard.moonLabel36.Hide();
            daboard.moonLabel37.Hide();
            daboard.moonLabel38.Hide();
            daboard.moonLabel39.Hide();
            daboard.moonLabel40.Hide();
            daboard.moonLabel41.Hide();

            foreach (string argument in My.MyProject.Application.CommandLineArgs)
            {
                if (argument == "-debug")
                {
                    daboard.Text = "[DEBUG] HRTime Settings";
                    My.MyProject.Forms.firstsetup.Text = "[DEBUG] HRTime First Setup";
                    daboard.FoxButton5.Show();
                    daboard.foxButton7.Show();
                    daboard.foxButton8.Show();
                    daboard.MoonLabel22.Show();
                    daboard.MoonLabel23.Show();
                    daboard.moonLabel26.Show();
                    daboard.moonLabel27.Show();
                    daboard.moonLabel28.Show();
                    daboard.moonLabel29.Show();
                    daboard.moonLabel30.Show();
                    daboard.moonLabel31.Show();
                    daboard.moonLabel32.Show();
                    daboard.moonLabel33.Show();
                    daboard.moonLabel34.Show();
                    daboard.moonLabel35.Show();
                    daboard.moonLabel36.Show();
                    daboard.moonLabel37.Show();
                    daboard.moonLabel38.Show();
                    daboard.moonLabel39.Show();
                    daboard.moonLabel40.Show();
                    daboard.moonLabel41.Show();
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
                AutoUpdater.Start("https://ayuworks.xyz/hrtime_updater.xml");
                My.MySettingsProperty.Settings.UpLastChecked = Conversions.ToString(DateTime.Now);
                My.MySettingsProperty.Settings.Save();
                My.MyProject.Forms.dashboard.MoonLabel25.Text = My.MySettingsProperty.Settings.UpLastChecked;
            }
            if (My.MySettingsProperty.Settings.AutoUpdate == "True")
            {
                AutoUpdater.Mandatory = true;
                AutoUpdater.UpdateMode = Mode.ForcedDownload;
                AutoUpdater.Start("https://ayuworks.xyz/hrtime_updater.xml");
            }
            WindowState = FormWindowState.Minimized;
            Opacity = 0d;
            if (My.MySettingsProperty.Settings.FirstSetupNeeded == "false")
            {
                Debug.WriteLine("running handler tasks..");
            }
            else if (My.MySettingsProperty.Settings.FirstSetupNeeded == "true" | string.IsNullOrEmpty(My.MySettingsProperty.Settings.FirstSetupNeeded))
            {
                My.MySettingsProperty.Settings.FirstSetupNeeded = "true";
                My.MySettingsProperty.Settings.Save();
                My.MyProject.Forms.firstsetup.Show();
            }
            var trayapp = new TrayApplicationManager();
            trayapp.timer1.Start();
            trayapp.TrayIcon.Visible = false;
            Close();
        }
    }
}