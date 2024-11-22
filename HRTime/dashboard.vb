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
End Class