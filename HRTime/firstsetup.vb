Imports System.IO
Imports Microsoft.Win32

Public Class firstsetup

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub firstsetup_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub FoxButton1_Click(sender As Object, e As EventArgs) Handles FoxButton1.Click
        MaterialTabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub FoxButton2_Click(sender As Object, e As EventArgs) Handles FoxButton2.Click
        If ForeverTextBox1.Text = "" Then
            Debug.WriteLine("textbox is empty msgbox")
            MessageBox.Show("Please enter something in the text box first.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.Username = ForeverTextBox1.Text
            My.Settings.Save()
            Debug.WriteLine("name = " & ForeverTextBox1.Text)
            MaterialTabControl1.SelectedTab = TabPage3
        End If
        Dim fourchanTerms As List(Of String) = New List(Of String) From {
            "passoid", "hon", "gigahon", "ogrehon", "ogre", "boymoder",
            "manmoder", "tranny", "gorillamoder", "brickhon", "boomerhon",
            "bitterhon", "heighthon", "honmoder", "innerhon", "outerhon",
            "rapehon", "reddithon", "ribcagehon", "shadowhon", "shoulderhon",
            "sneedhon", "twinkhon", "iwnbam", "gayden", "poonbro",
            "pooner", "tunapoon", "gigapoon", "manlet", "tranner",
            "troon", "transmaxxing", "youngshit", "midshit", "oldshit",
            "agp", "husstuss", "boyremove", "trannerexia", "luckshit",
            "malefail", "mog", "mogging", "mogs", "repper", "hsts"
            }
        If fourchanTerms.Any(Function(term) InStr(ForeverTextBox1.Text, term, vbTextCompare) > 0) Then
            Debug.WriteLine("4chan term msgbox")
            MessageBox.Show("4chan term detected. please get off 4chan and go outside im begging you", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.Username = ForeverTextBox1.Text
            My.Settings.Save()
            Debug.WriteLine("name = " & ForeverTextBox1.Text)
            MaterialTabControl1.SelectedTab = TabPage3
        End If
    End Sub

    Private Sub FoxButton3_Click(sender As Object, e As EventArgs) Handles FoxButton3.Click
        If DungeonNumeric1.Value = 0 Then
            Debug.WriteLine("invald amount msgbox")
            MessageBox.Show("Invalid amount.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Logic for setting settings for schedule
            ' As mentioned in the handler section, this is probably shit
            ' Look into adding a Windows Task Scheduler entry for a job that runs based on the given interval and displays a form
            ' I could do this in C# but no idea for VB! //and this is why I wanna do a C# rewrite one day i just cant be bothered rn to learn -ayu
            If DungeonComboBox1.SelectedItem = "day(s)" Then
                My.Settings.NextDoseDate = DateTime.Now.AddDays(DungeonNumeric1.Value)
                My.Settings.INTERVAL_TYPE = "day"
                My.Settings.INTERVAL_VALUE = DungeonNumeric1.Value
            ElseIf DungeonComboBox1.SelectedItem = "weeks(s)" Then
                My.Settings.NextDoseDate = DateTime.Now.AddDays(DungeonNumeric1.Value * 7) ' + 7 from the given value as we're adding days, but this is for week. 1 * 7 = 7, 2 * 7 = 14 (2 weeks), 3 * 7 = 21 (3 weeks), etc
                My.Settings.INTERVAL_TYPE = "week"
                My.Settings.INTERVAL_VALUE = DungeonNumeric1.Value * 7
            ElseIf DungeonComboBox1.SelectedItem = "months(s)" Then
                My.Settings.NextDoseDate = DateTime.Now.AddMonths(DungeonNumeric1.Value)
                My.Settings.INTERVAL_TYPE = "month"
                My.Settings.INTERVAL_VALUE = DungeonNumeric1.Value
            Else
                MessageBox.Show("Idk what the fuck happened lol (an error has occoured, please tell exactly what you did and report it on GitHub issues so we can diagnose it)")
            End If
            My.Settings.Save()
            MaterialTabControl1.SelectedTab = TabPage4
        End If
    End Sub

    Private Sub FoxButton5_Click(sender As Object, e As EventArgs) Handles FoxButton5.Click
        OpenFileDialog1.Filter = "wav files|*.wav"
        OpenFileDialog1.Title = "Select the reminder audio file"
        ' We do DialogResult.OK to ensure it was confirmed by the user before saving so if for whatever reason the universe implodes upon itself and somehow the dialog box crashes (???) it won't save NULL and permanently crash HRTime
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Debug.WriteLine("filedialog opened")
            ForeverTextBox2.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    End Sub

    Private Sub FoxButton4_Click(sender As Object, e As EventArgs) Handles FoxButton4.Click
        ' I think with the check I added in FoxButton5, this is impossible to be NULL, but just in case...
        If Not String.IsNullOrEmpty(ForeverTextBox2.Text) Then

            ' The most important check: MAKE SURE IT IS A .WAV FILE.
            ' technically this can be improved if a user is dumb and renames a .mp3 file to .wav and doesn't actually convert it but honestly that's on them...

            If Path.GetExtension(ForeverTextBox2.Text).ToLower() = ".wav" Then

                ' If a user, for some reason, selects a file that doesn't exist. This seems impossible and like a useless check but this actually can help us for cases when we don't have read permission for a file, so it deserves to be here.

                If System.IO.File.Exists(ForeverTextBox2.Text) Then
                    My.Settings.AudioPath = ForeverTextBox2.Text
                    My.Settings.Save()
                    Debug.WriteLine("audiodir = " & ForeverTextBox2.Text)
                    MaterialTabControl1.SelectedTab = TabPage5
                Else
                    MessageBox.Show("The selected audio file does not exist. Please choose a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please select a valid .wav audio file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Please select an audio file first.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub FoxButton6_Click(sender As Object, e As EventArgs) Handles FoxButton6.Click
        My.Settings.AutoUpdate = "True"
        My.Settings.AutoUpCheck = "True"
        My.Settings.Save()
        Debug.WriteLine("autoupdate = true")
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub FoxButton7_Click(sender As Object, e As EventArgs) Handles FoxButton7.Click
        My.Settings.AutoUpdate = "False"
        My.Settings.Save()
        Debug.WriteLine("autoupdate = false")
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub FoxButton8_Click(sender As Object, e As EventArgs) Handles FoxButton8.Click
        My.Settings.FirstSetupNeeded = "false"
        My.Settings.Save()
        Debug.WriteLine("firstsetup complete")
        Me.Close()
    End Sub

    Private Sub ForeverButton8_Click(sender As Object, e As EventArgs) Handles ForeverButton8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ForeverButton7_Click(sender As Object, e As EventArgs) Handles ForeverButton7.Click
        Dim exitConfirmation As DialogResult = MessageBox.Show("Do you want to exit? Any unsaved settings will be lost.", "HRTime",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If exitConfirmation = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
