<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DungeonLabel1 = New ReaLTaiizor.Controls.DungeonLabel()
        DungeonLabel2 = New ReaLTaiizor.Controls.DungeonLabel()
        DungeonLabel3 = New ReaLTaiizor.Controls.DungeonLabel()
        SuspendLayout()
        ' 
        ' DungeonLabel1
        ' 
        DungeonLabel1.AutoSize = True
        DungeonLabel1.BackColor = Color.Transparent
        DungeonLabel1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DungeonLabel1.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(77))
        DungeonLabel1.Location = New Point(297, 73)
        DungeonLabel1.Name = "DungeonLabel1"
        DungeonLabel1.Size = New Size(114, 20)
        DungeonLabel1.TabIndex = 0
        DungeonLabel1.Text = "DungeonLabel1"
        ' 
        ' DungeonLabel2
        ' 
        DungeonLabel2.AutoSize = True
        DungeonLabel2.BackColor = Color.Transparent
        DungeonLabel2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DungeonLabel2.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(77))
        DungeonLabel2.Location = New Point(297, 116)
        DungeonLabel2.Name = "DungeonLabel2"
        DungeonLabel2.Size = New Size(114, 20)
        DungeonLabel2.TabIndex = 1
        DungeonLabel2.Text = "DungeonLabel2"
        ' 
        ' DungeonLabel3
        ' 
        DungeonLabel3.AutoSize = True
        DungeonLabel3.BackColor = Color.Transparent
        DungeonLabel3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DungeonLabel3.ForeColor = Color.FromArgb(CByte(76), CByte(76), CByte(77))
        DungeonLabel3.Location = New Point(297, 159)
        DungeonLabel3.Name = "DungeonLabel3"
        DungeonLabel3.Size = New Size(114, 20)
        DungeonLabel3.TabIndex = 2
        DungeonLabel3.Text = "DungeonLabel3"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(812, 459)
        Controls.Add(DungeonLabel3)
        Controls.Add(DungeonLabel2)
        Controls.Add(DungeonLabel1)
        Name = "dashboard"
        Text = "dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DungeonLabel1 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel2 As ReaLTaiizor.Controls.DungeonLabel
    Friend WithEvents DungeonLabel3 As ReaLTaiizor.Controls.DungeonLabel
End Class
