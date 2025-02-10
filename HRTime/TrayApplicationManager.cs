using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace HRTime
{
    public partial class TrayApplicationManager
    {
        private void OpenMenuItem_Click(object sender, System.EventArgs e)
        {
            HRTime.My.MyProject.Forms.dashboard.Show();
            TrayIcon.Visible = false;
        }

        private void ExitMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HRTime.My.MyProject.Forms.dashboard.Show();
            TrayIcon.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Probably best to look into how to schedule a task in windows Task Scheduler, and schedule it in the setup section

            // there seems to be an issue idk if anyone else can recreate it but after going through firstsetup, change the date and time right before "NextDoseDate". Normally it should trigger the alert but for some reason it doesn't
            // HOWEVER when you restart the exe and manually go into the user.config file and change the NextDoseDate string value (didn't test yet restarting the exe and then just changing the system time), suddenly the alert gets triggered just fine

            var now = DateTime.Now;
            My.MyProject.Forms.dashboard.MoonLabel23.Text = Conversions.ToString(now);
            if ((My.MySettingsProperty.Settings.NextDoseDate ?? "") == (My.MyProject.Forms.dashboard.MoonLabel23.Text ?? "")) // apparently vbnet (now C# so check back at this and rewrite later) cant read now.ToString directly (prob bc theres no string to output it to or smth idfk I suck at this)
            {                                                                                                                 // so for now, we have this janky ass workaround with a label until we figure out how task scheduling works
                My.MyProject.Forms.alert.Show();                                                                              // puppy needs her wife to cuddle after releasing this monstrosity,,,, waaaaaaaa
            }
        }
    }

} //end of root namespace