Imports ReaLTaiizor.Controls

Public Class alert
    Private Sub alert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetBounds(Screen.GetWorkingArea(Me).Width - Me.Width, Screen.GetWorkingArea(Me).Height - Me.Height, Me.Width, Me.Height)
        My.Computer.Audio.Play(My.Settings.AudioPath)
    End Sub
    Private Sub alert_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        My.Computer.Audio.Stop()
    End Sub

    Private Sub FoxButton2_Click(sender As Object, e As EventArgs) Handles FoxButton2.Click
        If My.Settings.INTERVAL_TYPE = "day" Then
            My.Settings.NextDoseDate = DateTime.Now.AddDays(My.Settings.INTERVAL_VALUE)
        ElseIf My.Settings.INTERVAL_TYPE = "week" Then
            My.Settings.NextDoseDate = DateTime.Now.AddDays(My.Settings.INTERVAL_VALUE * 7)
        ElseIf My.Settings.INTERVAL_TYPE = "month" Then
            My.Settings.NextDoseDate = DateTime.Now.AddMonths(My.Settings.INTERVAL_VALUE)
        End If
        My.Settings.Save()
        If cuteNamesHehe.Any(Function(term) term = My.Settings.Username) Then
            MessageBox.Show(My.Settings.Username & "! Keep it up <3", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Good job, " & My.Settings.Username & "! Keep it up <3", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Form1.NotifyIcon1.BalloonTipText = "Your next HRT reminder will run on: " & My.Settings.NextDoseDate
        Form1.NotifyIcon1.ShowBalloonTip(500)
        Me.Close()
    End Sub

    Dim cuteNamesHehe As List(Of String) = New List(Of String) From {
    "good girl", "good boy", "good enby", "good puppy", "good kitty",
    "good bunny", "good bun", "good rat", "good dog", "good cat", "good mouse",
    "good mousie", "good poss", "good posombe", "good possum"
    }
End Class