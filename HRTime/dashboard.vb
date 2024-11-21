Public Class dashboard

    Private Sub dashboard_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form1.NotifyIcon1.Visible = True
        Form1.NotifyIcon1.BalloonTipText = "Minimized to system tray."
        Form1.NotifyIcon1.ShowBalloonTip(500)
    End Sub
End Class