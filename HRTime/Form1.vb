Imports System.Configuration
Imports AutoUpdaterDotNET
Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoUpdater.RunUpdateAsAdmin = False
        If My.Settings.AutoUpCheck = "True" Then
            AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml")
        End If
        If My.Settings.AutoUpdate = "True" Then
            AutoUpdater.Mandatory = True
            AutoUpdater.UpdateMode = Mode.ForcedDownload
            AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml")
        End If
        NotifyIcon1.Visible = True
        WindowState = FormWindowState.Minimized
        Me.Opacity = 0
        If My.Settings.FirstSetupNeeded = "false" Then
            Debug.WriteLine("firstsetupneeded = " & My.Settings.FirstSetupNeeded)
            Debug.WriteLine("running handler tasks..")
            MsgBox("kiss ur sister")
        Else
            If My.Settings.FirstSetupNeeded = "true" Or My.Settings.FirstSetupNeeded = "" Then
                My.Settings.FirstSetupNeeded = "true"
                My.Settings.Save()
                Debug.WriteLine("running firstsetup..")
                firstsetup.Show()
            End If
        End If
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        dashboard.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Probably best to look into how to use VB to schedule a task in windows Task Scheduler, and schedule it in the setup section

        ' there seems to be an issue idk if anyone else can recreate it but after going through firstsetup, change the date and time right before "NextDoseDate". Normally it should trigger the alert but for some reason it doesn't
        ' HOWEVER when you restart the exe and manually go into the user.config file and change the NextDoseDate string value (didn't test yet restarting the exe and then just changing the system time), suddenly the alert gets triggered just fine

        Dim now As DateTime = DateTime.Now
        dashboard.MoonLabel23.Text = now.ToString("MM/dd/yyyy HH:mm:ss")
        Label1.Text = now.ToString("MM/dd/yyyy HH:mm:ss")
        If (My.Settings.NextDoseDate = Label1.Text) Then ' apparently vbnet cant read now.ToString directly (prob bc theres no string to output it to or smth idfk I suck at this)
            alert.Show()                                 ' so for now, we have this janky ass workaround with a label until we figure out how task scheduling works
        End If                                           ' puppy needs her wife to cuddle after releasing this monstrosity,,,, waaaaaaaa
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
