using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace HRTime
{

    public partial class alert
    {
        public alert()
        {
            InitializeComponent();
        }
        private void alert_Load(object sender, EventArgs e)
        {
            SetBounds(Screen.GetWorkingArea(this).Width - Width, Screen.GetWorkingArea(this).Height - Height, Width, Height);
            if (System.IO.File.Exists(My.MySettingsProperty.Settings.AudioPath))
            {
                My.MyProject.Computer.Audio.Play(My.MySettingsProperty.Settings.AudioPath);
            }
            else
            {
                MessageBox.Show("The specified audio file could not be found. Please update your audio path in settings.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void alert_Close(object sender, EventArgs e)
        {
            My.MyProject.Computer.Audio.Stop();
        }

        private void FoxButton2_Click(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.INTERVAL_TYPE == "day")
            {
                My.MySettingsProperty.Settings.NextDoseDate = Conversions.ToString(DateTime.Now.AddDays(Conversions.ToDouble(My.MySettingsProperty.Settings.INTERVAL_VALUE)));
            }
            else if (My.MySettingsProperty.Settings.INTERVAL_TYPE == "week")
            {
                My.MySettingsProperty.Settings.NextDoseDate = Conversions.ToString(DateTime.Now.AddDays(Conversions.ToDouble(My.MySettingsProperty.Settings.INTERVAL_VALUE) * 7d));
            }
            else if (My.MySettingsProperty.Settings.INTERVAL_TYPE == "month")
            {
                My.MySettingsProperty.Settings.NextDoseDate = Conversions.ToString(DateTime.Now.AddMonths(Conversions.ToInteger(My.MySettingsProperty.Settings.INTERVAL_VALUE)));
            }
            My.MySettingsProperty.Settings.Save();
            if (cuteNamesHehe.Any(term => (term ?? "") == (My.MySettingsProperty.Settings.Username ?? "")))
            {
                MessageBox.Show(My.MySettingsProperty.Settings.Username + "! Keep it up <3", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Good job, " + My.MySettingsProperty.Settings.Username + "! Keep it up <3", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            My.MyProject.Forms.Form1.NotifyIcon1.BalloonTipText = "Your next HRT reminder will run on: " + My.MySettingsProperty.Settings.NextDoseDate;
            My.MyProject.Forms.Form1.NotifyIcon1.ShowBalloonTip(500);
            Close();
        }

        private List<string> cuteNamesHehe = new List<string>() { 
            "good girl", "good boy", "good enby", 
            "good puppy", "good kitty", "good bunny", 
            "good bun", "good rat", "good dog", 
            "good cat", "good mouse", "good mousie", 
            "good poss", "good posombe", "good possum" };
    }
}