Public Class alert
    Private Sub alert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(Screen.GetWorkingArea(Me).Width - Me.Width, Screen.GetWorkingArea(Me).Height - Me.Height, Me.Width, Me.Height)
        My.Computer.Audio.Play(My.Settings.AudioPath)
    End Sub
    Private Sub alert_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub FoxButton2_Click(sender As Object, e As EventArgs) Handles FoxButton2.Click
        Me.Close()
    End Sub
End Class