Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Minimized
        Me.Opacity = 0
        If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("firstsetup") Is Nothing Then
            firstsetup.Show()
        Else
            MsgBox(":3")
        End If
    End Sub
End Class
