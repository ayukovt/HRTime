<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alert
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(alert))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        MoonLabel1 = New ReaLTaiizor.Controls.MoonLabel()
        FoxButton2 = New ReaLTaiizor.Controls.FoxButton()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(17), CByte(15), CByte(22))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(117, 117)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(117, 117)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' MoonLabel1
        ' 
        MoonLabel1.AutoSize = True
        MoonLabel1.BackColor = Color.Transparent
        MoonLabel1.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        MoonLabel1.ForeColor = Color.FromArgb(CByte(199), CByte(175), CByte(255))
        MoonLabel1.Location = New Point(136, 25)
        MoonLabel1.Name = "MoonLabel1"
        MoonLabel1.Size = New Size(254, 37)
        MoonLabel1.TabIndex = 1
        MoonLabel1.Text = "Time to take your HRT!"
        ' 
        ' FoxButton2
        ' 
        FoxButton2.BackColor = Color.Transparent
        FoxButton2.BaseColor = Color.FromArgb(CByte(42), CByte(32), CByte(59))
        FoxButton2.BorderColor = Color.FromArgb(CByte(42), CByte(32), CByte(59))
        FoxButton2.DisabledBaseColor = Color.FromArgb(CByte(42), CByte(32), CByte(59))
        FoxButton2.DisabledBorderColor = Color.FromArgb(CByte(42), CByte(32), CByte(59))
        FoxButton2.DisabledTextColor = Color.FromArgb(CByte(98), CByte(84), CByte(129))
        FoxButton2.DownColor = Color.FromArgb(CByte(52), CByte(42), CByte(69))
        FoxButton2.EnabledCalc = True
        FoxButton2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        FoxButton2.ForeColor = Color.FromArgb(CByte(98), CByte(84), CByte(129))
        FoxButton2.Location = New Point(144, 65)
        FoxButton2.Name = "FoxButton2"
        FoxButton2.OverColor = Color.FromArgb(CByte(62), CByte(47), CByte(87))
        FoxButton2.Size = New Size(92, 24)
        FoxButton2.TabIndex = 3
        FoxButton2.Text = "Okay"
        ' 
        ' alert
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(19), CByte(29))
        ClientSize = New Size(477, 117)
        Controls.Add(FoxButton2)
        Controls.Add(MoonLabel1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "alert"
        StartPosition = FormStartPosition.Manual
        Text = "alert"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MoonLabel1 As ReaLTaiizor.Controls.MoonLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FoxButton2 As ReaLTaiizor.Controls.FoxButton
End Class
