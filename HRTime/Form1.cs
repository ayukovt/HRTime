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

            //i am so sorry for pulling a yandev please forgive me ill fix this at some point (or pls commit a better way on github im gonna praise u forever if u do)
            My.MyProject.Forms.dashboard.FoxButton5.Hide();
            My.MyProject.Forms.dashboard.foxButton7.Hide();
            My.MyProject.Forms.dashboard.foxButton8.Hide();
            My.MyProject.Forms.dashboard.MoonLabel22.Hide();
            My.MyProject.Forms.dashboard.MoonLabel23.Hide();
            My.MyProject.Forms.dashboard.moonLabel26.Hide();
            My.MyProject.Forms.dashboard.moonLabel27.Hide();
            My.MyProject.Forms.dashboard.moonLabel28.Hide();
            My.MyProject.Forms.dashboard.moonLabel29.Hide();
            My.MyProject.Forms.dashboard.moonLabel30.Hide();
            My.MyProject.Forms.dashboard.moonLabel31.Hide();
            My.MyProject.Forms.dashboard.moonLabel32.Hide();
            My.MyProject.Forms.dashboard.moonLabel33.Hide();
            My.MyProject.Forms.dashboard.moonLabel34.Hide();
            My.MyProject.Forms.dashboard.moonLabel35.Hide();
            My.MyProject.Forms.dashboard.moonLabel36.Hide();
            My.MyProject.Forms.dashboard.moonLabel37.Hide();
            My.MyProject.Forms.dashboard.moonLabel38.Hide();
            My.MyProject.Forms.dashboard.moonLabel39.Hide();
            My.MyProject.Forms.dashboard.moonLabel40.Hide();
            My.MyProject.Forms.dashboard.moonLabel41.Hide();

            foreach (string argument in My.MyProject.Application.CommandLineArgs)
            {
                if (argument == "-debug")
                {
                    My.MyProject.Forms.dashboard.Text = "[DEBUG] HRTime Settings";
                    My.MyProject.Forms.firstsetup.Text = "[DEBUG] HRTime First Setup";
                    My.MyProject.Forms.dashboard.FoxButton5.Show();
                    My.MyProject.Forms.dashboard.foxButton7.Show();
                    My.MyProject.Forms.dashboard.foxButton8.Show();
                    My.MyProject.Forms.dashboard.MoonLabel22.Show();
                    My.MyProject.Forms.dashboard.MoonLabel23.Show();
                    My.MyProject.Forms.dashboard.moonLabel26.Show();
                    My.MyProject.Forms.dashboard.moonLabel27.Show();
                    My.MyProject.Forms.dashboard.moonLabel28.Show();
                    My.MyProject.Forms.dashboard.moonLabel29.Show();
                    My.MyProject.Forms.dashboard.moonLabel30.Show();
                    My.MyProject.Forms.dashboard.moonLabel31.Show();
                    My.MyProject.Forms.dashboard.moonLabel32.Show();
                    My.MyProject.Forms.dashboard.moonLabel33.Show();
                    My.MyProject.Forms.dashboard.moonLabel34.Show();
                    My.MyProject.Forms.dashboard.moonLabel35.Show();
                    My.MyProject.Forms.dashboard.moonLabel36.Show();
                    My.MyProject.Forms.dashboard.moonLabel37.Show();
                    My.MyProject.Forms.dashboard.moonLabel38.Show();
                    My.MyProject.Forms.dashboard.moonLabel39.Show();
                    My.MyProject.Forms.dashboard.moonLabel40.Show();
                    My.MyProject.Forms.dashboard.moonLabel41.Show();
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