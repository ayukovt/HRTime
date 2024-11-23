Imports System.Configuration
Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
        WindowState = FormWindowState.Minimized
        Me.Opacity = 0
        If My.Settings.FirstSetupNeeded = "false" Then
            Debug.WriteLine("firstsetupneeded = ")
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
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        dashboard.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Logic for timer. Commented out as currently this'll open dialogs every tick in the minute it's scheduled for
        ' Probably best to look into how to use VB to schedule a task in windows Task Scheduler, and schedule it in the setup section

        'Dim now As DateTime = DateTime.Now
        'If (My.Settings.NextDoseDate = now.Date) Then
        'MessageBox.Show("Pog")
        'Else
        'Timer1.Start()
        'End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
