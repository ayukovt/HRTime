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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialTabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MetroTextBox1.Text = "" Then
            Debug.WriteLine("textbox is empty msgbox")
            MessageBox.Show("Please enter something in the text box first.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.Username = MetroTextBox1.Text
            My.Settings.Save()
            Debug.WriteLine("name = " & MetroTextBox1.Text)
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
        If fourchanTerms.Any(Function(term) InStr(MetroTextBox1.Text, term, vbTextCompare) > 0) Then
            Debug.WriteLine("4chan term msgbox")
            MessageBox.Show("4chan term detected. please get off 4chan and go outside im begging you", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Settings.Username = MetroTextBox1.Text
            My.Settings.Save()
            Debug.WriteLine("name = " & MetroTextBox1.Text)
            MaterialTabControl1.SelectedTab = TabPage3
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
                MessageBox.Show("Idk what the fuck happened lol")
            End If
            My.Settings.Save()
            MaterialTabControl1.SelectedTab = TabPage4
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "wav files|*.wav"
        OpenFileDialog1.Title = "Select the reminder audio file"
        OpenFileDialog1.ShowDialog()
        Debug.WriteLine("filedialog opened")
        DungeonRichTextBox1.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' add a check for the right file extension and if the path is valid then proceed to tabpage5
        My.Settings.AudioPath = DungeonRichTextBox1.Text
        My.Settings.Save()
        Debug.WriteLine("audiodir = " & DungeonRichTextBox1.Text)
        MaterialTabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' the buttons are bugged at least for me and the right color isnt applied idk ill try fixing it later
        My.Settings.AutoUpdate = "true"
        My.Settings.Save()
        Debug.WriteLine("autoupdate = true")
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Settings.AutoUpdate = "false"
        My.Settings.Save()
        Debug.WriteLine("autoupdate = false")
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Settings.FirstSetupNeeded = "false"
        My.Settings.Save()
        Debug.WriteLine("firstsetup complete")
        Me.Close()
    End Sub
End Class