using HRTime.My;
using System;
using System.Windows.Forms;

namespace HRTime
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            HRTime.My.MyProject.Forms.Form1.Show();
            Application.Run(new TrayApplicationContext());
        }

    }

} //end of root namespace