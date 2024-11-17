Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Minimized
        Me.Opacity = 0
        Dim firstSetup = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HRTime\", "firstsetup", Nothing)
        If firstSetup = "false" Then
            MsgBox("kiss ur sister")
        Else
            If firstSetup Is Nothing Or Registry.CurrentUser.OpenSubKey("HRTime") Is Nothing Or firstSetup = "true" Then
                My.Computer.Registry.CurrentUser.CreateSubKey("HRTime")
                Registry.SetValue("HKEY_CURRENT_USER\HRTime", "firstsetup", "true")
                firstSetup.Show()
            End If
        End If
    End Sub
End Class
