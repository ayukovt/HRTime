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
        URLOpen("https://github.com/0xilis")
    End Sub

    Private Sub ForeverButton12_Click(sender As Object, e As EventArgs) Handles ForeverButton12.Click
        URLOpen("https://www.github.com/Kat-Kipling")
    End Sub

    Private Sub FoxLinkLabel1_Click(sender As Object, e As EventArgs) Handles FoxLinkLabel1.Click
        URLOpen(FoxLinkLabel1.Text)
    End Sub

    Private Sub FoxLinkLabel2_Click(sender As Object, e As EventArgs) Handles FoxLinkLabel2.Click
        URLOpen(FoxLinkLabel2.Text)
    End Sub

    Private Sub NightLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles NightLinkLabel1.LinkClicked
        URLOpen("https://ko-fi.com/ayukovt")
    End Sub

    Private Sub FoxButton5_Click(sender As Object, e As EventArgs) Handles FoxButton5.Click
        alert.Show()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTextBox1.Text = My.Settings.Username
        MetroTextBox2.Text = My.Settings.AudioPath
    End Sub

    Private Sub FoxButton1_Click(sender As Object, e As EventArgs) Handles FoxButton1.Click
        My.Settings.Username = MetroTextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub FoxButton2_Click(sender As Object, e As EventArgs) Handles FoxButton2.Click
        My.Settings.AudioPath = MetroTextBox2.Text
        My.Settings.Save()
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
End Class