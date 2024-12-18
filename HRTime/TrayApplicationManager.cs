using System.Windows.Forms;

namespace HRTime
{
    public partial class TrayApplicationManager
    {

        private void OpenMenuItem_Click(object sender, System.EventArgs e)
        {
            HRTime.My.MyProject.Forms.dashboard.Show();
        }

        private void ExitMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HRTime.My.MyProject.Forms.dashboard.Show();
        }
    }

} //end of root namespace