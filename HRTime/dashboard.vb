﻿Imports System.IO
Imports AutoUpdaterDotNET
Imports Microsoft.Win32

Public Class dashboard

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub dashboard_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub dashboard_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.NotifyIcon1.Visible = True
        Form1.NotifyIcon1.BalloonTipText = "Minimized to system tray."
        Form1.NotifyIcon1.ShowBalloonTip(500)
    End Sub
    Private Sub ForeverButton1_Click(sender As Object, e As EventArgs) Handles ForeverButton1.Click
        MoonLabel2.Text = "Username"
        MaterialTabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub ForeverButton2_Click(sender As Object, e As EventArgs) Handles ForeverButton2.Click
        MoonLabel2.Text = "Frequency"
        MaterialTabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub ForeverButton3_Click(sender As Object, e As EventArgs) Handles ForeverButton3.Click
        MoonLabel2.Text = "Alert Sound"
        MaterialTabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub ForeverButton4_Click(sender As Object, e As EventArgs) Handles ForeverButton4.Click
        MoonLabel2.Text = "Updater"
        MaterialTabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub ForeverButton5_Click(sender As Object, e As EventArgs) Handles ForeverButton5.Click
        MoonLabel2.Text = "Reset"
        MaterialTabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub ForeverButton6_Click(sender As Object, e As EventArgs) Handles ForeverButton6.Click
        MoonLabel2.Text = "About"
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub ForeverButton8_Click(sender As Object, e As EventArgs) Handles ForeverButton8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ForeverButton7_Click(sender As Object, e As EventArgs) Handles ForeverButton7.Click
        Me.Close()
    End Sub
    Public Sub URLOpen(Url As String)

        Dim OpenURL As New ProcessStartInfo With {
        .UseShellExecute = True,
        .FileName = "explorer.exe",
        .Arguments = Url
    }

        Process.Start(OpenURL)

    End Sub

    Private Sub ForeverButton9_Click(sender As Object, e As EventArgs) Handles ForeverButton9.Click
        URLOpen("https://twitter.com/0xilis")
    End Sub

    Private Sub ForeverButton10_Click(sender As Object, e As EventArgs) Handles ForeverButton10.Click
        URLOpen("https://twitter.com/kittymeowder")
    End Sub

    Private Sub ForeverButton11_Click(sender As Object, e As EventArgs) Handles ForeverButton11.Click
        URLOpen("https://github.com/0xilis") ' mac (ew) user smh
    End Sub

    Private Sub ForeverButton12_Click(sender As Object, e As EventArgs) Handles ForeverButton12.Click
        URLOpen("https://www.github.com/Kat-Kipling") ' goated dev ily kat mwahh (platonically)
    End Sub

    Private Sub FoxLinkLabel1_Click(sender As Object, e As EventArgs) Handles FoxLinkLabel1.Click
        URLOpen(FoxLinkLabel1.Text)
    End Sub

    Private Sub FoxLinkLabel2_Click(sender As Object, e As EventArgs) Handles FoxLinkLabel2.Click
        URLOpen(FoxLinkLabel2.Text)
    End Sub

    Private Sub NightLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NightLinkLabel1.LinkClicked
        URLOpen("https://ko-fi.com/ayukovt") ' the pupy :3
    End Sub

    Private Sub FoxButton5_Click(sender As Object, e As EventArgs) Handles FoxButton5.Click
        alert.Show()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.UpLastChecked = "" Then
            MoonLabel25.Text = "null"
        Else
            MoonLabel25.Text = My.Settings.UpLastChecked
        End If
        If My.Settings.FirstSetupNeeded = "true" Then
            MaterialTabControl1.SelectedTab = TabPage7
            ForeverButton1.Hide()
            ForeverButton2.Hide()
            ForeverButton3.Hide()
            ForeverButton4.Hide()
            ForeverButton5.Hide()
            ForeverButton6.Hide()
        Else
            MaterialTabControl1.SelectedTab = TabPage1
        End If
        If My.Settings.AutoUpdate = "True" Then
            ParrotCheckBox2.Checked = True
            ParrotCheckBox1.Checked = True
        End If
        If My.Settings.AutoUpCheck = "True" Then
            ParrotCheckBox1.Checked = True
        End If
        ForeverTextBox1.Text = My.Settings.Username
        ForeverTextBox2.Text = My.Settings.AudioPath
    End Sub

    Private Sub FoxButton1_Click(sender As Object, e As EventArgs) Handles FoxButton1.Click
        If ForeverTextBox1.Text = "" Then
            Debug.WriteLine("textbox is empty msgbox")
            MessageBox.Show("Please enter something in the text box first.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.Username = ForeverTextBox1.Text
            My.Settings.Save()
            Debug.WriteLine("name = " & ForeverTextBox1.Text)
        End If
        If fourchanTerms.Any(Function(term) InStr(ForeverTextBox1.Text, term, vbTextCompare) > 0) Then
            Debug.WriteLine("4chan term msgbox")
            MessageBox.Show("4chan term detected. please get off 4chan and go outside im begging you", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.Username = ForeverTextBox1.Text
            My.Settings.Save()
            Debug.WriteLine("name = " & ForeverTextBox1.Text)
        End If
    End Sub

    Private Sub FoxButton2_Click(sender As Object, e As EventArgs) Handles FoxButton2.Click
        If Not String.IsNullOrEmpty(ForeverTextBox2.Text) Then
            If Path.GetExtension(ForeverTextBox2.Text).ToLower() = ".wav" Then
                If System.IO.File.Exists(ForeverTextBox2.Text) Then
                    My.Settings.AudioPath = ForeverTextBox2.Text
                    My.Settings.Save()
                    Debug.WriteLine("audiodir = " & ForeverTextBox2.Text)
                    MaterialTabControl1.SelectedTab = TabPage5
                Else
                    MessageBox.Show("The selected audio file does not exist. Please choose a valid file.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid file type. Please select a valid .wav audio file.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please select an audio file first.", "HRTime", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub FoxButton4_Click(sender As Object, e As EventArgs) Handles FoxButton4.Click
        Dim resetConfirmation As DialogResult = MessageBox.Show("Are you sure you want to reset user settings?", "HRTime",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resetConfirmation = Windows.Forms.DialogResult.Yes Then
            My.Settings.Username = Nothing
            My.Settings.NextDoseDate = Nothing
            My.Settings.INTERVAL_TYPE = Nothing
            My.Settings.INTERVAL_VALUE = Nothing
            My.Settings.AudioPath = Nothing
            My.Settings.AutoUpdate = Nothing
            My.Settings.FirstSetupNeeded = "true"
            My.Settings.Save()
            Application.Restart()
        End If
    End Sub

    Private Sub FoxButton3_Click(sender As Object, e As EventArgs) Handles FoxButton3.Click
        AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml")
        My.Settings.UpLastChecked = DateTime.Now
        My.Settings.Save()
        MoonLabel25.Text = My.Settings.UpLastChecked
    End Sub

    Private Sub ParrotCheckBox1_Click(sender As Object, e As EventArgs) Handles ParrotCheckBox1.Click
        If ParrotCheckBox1.Checked = False Then ' its reversed bc the checkbox state changes *after* the click event btw
            My.Settings.AutoUpCheck = "True"
            My.Settings.Save()
        Else
            My.Settings.AutoUpCheck = "False"
            My.Settings.Save()
        End If
    End Sub

    Private Sub ParrotCheckBox2_Click(sender As Object, e As EventArgs) Handles ParrotCheckBox2.Click
        If ParrotCheckBox2.Checked = False Then ' same goes here
            ParrotCheckBox1.Checked = True
            My.Settings.AutoUpdate = "True"
            My.Settings.AutoUpCheck = "True"
            My.Settings.Save()
        Else
            My.Settings.AutoUpdate = "False"
            My.Settings.Save()
        End If
    End Sub

    Dim fourchanTerms As List(Of String) = New List(Of String) From { ' copied from firstsetup bc apparently i cant just reference it in a different .vb file
    "passoid", "gigahon", "ogrehon", "ogre", "boymoder",
    "manmoder", "tranny", "gorillamoder", "brickhon", "boomerhon",
    "bitterhon", "heighthon", "honmoder", "innerhon", "outerhon",
    "rapehon", "reddithon", "ribcagehon", "shadowhon", "shoulderhon",
    "sneedhon", "twinkhon", "iwnbam", "gayden", "poonbro",
    "pooner", "tunapoon", "gigapoon", "manlet", "tranner",
    "troon", "transmaxxing", "youngshit", "midshit", "oldshit",
    "agp", "husstuss", "boyremove", "trannerexia", "luckshit",
    "malefail", "mog", "mogging", "mogs", "repper", "hsts"
    }

    Private Sub FoxButton6_Click(sender As Object, e As EventArgs) Handles FoxButton6.Click
        OpenFileDialog1.Filter = "wav files|*.wav"
        OpenFileDialog1.Title = "Select the reminder audio file"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Debug.WriteLine("filedialog opened")
            ForeverTextBox2.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub
End Class