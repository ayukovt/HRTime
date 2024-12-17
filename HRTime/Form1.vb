Imports System.Configuration
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports AutoUpdaterDotNET
Imports Microsoft.Win32
Imports ReaLTaiizor.Controls

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each argument As String In My.Application.CommandLineArgs
            If argument = "-debug" Then
                dashboard.Text = "[DEBUG] HRTime Settings"
                firstsetup.Text = "[DEBUG] HRTime First Setup"
            End If

            If argument = "-alert" Then
                ' will be useful once we start using task scheduling
                alert.Show()
            End If
        Next
        Dim fontName As String = "Poppins"
        Dim fontSize As Single = 12.0F

        Using fontTester As New Font(fontName, fontSize, FontStyle.Regular, GraphicsUnit.Pixel) ' before anyone says anything yes I could just bundle the font in the exe but mf I use like 4 different variants (which means 4 .ttf files) and there's like
            If fontTester.Name = fontName Then                                                  ' 50 different fucking labels that use all of these variants interchangeably I can't just make a list of labels and set the font of everything in code to "Poppins"
                Debug.WriteLine("poppins font detected. continuing.")                           ' bc thats just not gonna work (or im just stupid) idk ill figure it out at some point
            Else
                Dim fontmissingConfirmation As DialogResult = MessageBox.Show("Poppins has not been detected. HRTime requires Poppins to be installed on the system for displaying the UI correctly. Download font?", "HRTime",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If fontmissingConfirmation = Windows.Forms.DialogResult.Yes Then
                    dashboard.URLOpen("https://fonts.google.com/specimen/Poppins")
                    Application.Exit()
                End If
            End If
        End Using
        AutoUpdater.RunUpdateAsAdmin = False
        If My.Settings.AutoUpCheck = "True" Then
            AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml")
            My.Settings.UpLastChecked = DateTime.Now
            My.Settings.Save()
            dashboard.MoonLabel25.Text = My.Settings.UpLastChecked
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
        dashboard.MoonLabel23.Text = now
        Label1.Text = now
        If (My.Settings.NextDoseDate = Label1.Text) Then ' apparently vbnet cant read now.ToString directly (prob bc theres no string to output it to or smth idfk I suck at this)
            alert.Show()                                 ' so for now, we have this janky ass workaround with a label until we figure out how task scheduling works
        End If                                           ' puppy needs her wife to cuddle after releasing this monstrosity,,,, waaaaaaaa
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
