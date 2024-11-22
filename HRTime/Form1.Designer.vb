<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        NotifyIcon1 = New NotifyIcon(components)
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "HRTime"
        NotifyIcon1.Visible = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 225)
        Name = "Form1"
        ShowInTaskbar = False
        Text = "handler (important thing dont close it pls)"
        ResumeLayout(False)
    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
End Class
