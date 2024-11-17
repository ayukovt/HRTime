Imports Microsoft.Win32

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Minimized
        Me.Opacity = 0
        Dim firstSetupNeeded = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\HRTime\", "firstsetup", Nothing)
        If firstSetupNeeded = "false" Then
            Debug.WriteLine("firstsetupneeded = " & firstSetupNeeded)
            Debug.WriteLine("running handler tasks..")
            MsgBox("kiss ur sister")
        Else
            If firstSetupNeeded Is Nothing Or Registry.CurrentUser.OpenSubKey("HRTime") Is Nothing Or firstSetupNeeded = "true" Then
                Debug.WriteLine("firstsetupneeded = " & firstSetupNeeded)
                Debug.WriteLine("running firstsetup..")
                My.Computer.Registry.CurrentUser.CreateSubKey("HRTime")
                Registry.SetValue("HKEY_CURRENT_USER\HRTime", "firstsetup", "true")
                firstsetup.Show()
            End If
        End If
    End Sub
End Class
