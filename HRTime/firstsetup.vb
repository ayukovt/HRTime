Imports Microsoft.Win32

Public Class firstsetup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialTabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MetroTextBox1.Text = "" Then
            Debug.WriteLine("textbox is empty msgbox")
            MessageBox.Show("Please enter something in the text box first.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MaterialTabControl1.SelectedTab = TabPage3
        End If
        If InStr(MetroTextBox1.Text, "passoid", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "hon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "gigahon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "ogrehon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "ogre", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "boymoder", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "iwnbaw", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "ngmi", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "hsts", vbTextCompare) Then
            Debug.WriteLine("4chan keyword msgbox")
            MessageBox.Show("4chan keyword detected. please get off 4chan for your own good.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            MaterialTabControl1.SelectedTab = TabPage3
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DungeonNumeric1.Value = 0 Then
            Debug.WriteLine("invald amount msgbox")
            MessageBox.Show("Invalid amount.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MaterialTabControl1.SelectedTab = TabPage4
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' needs fixing
        OpenFileDialog1.ShowDialog()
        Debug.WriteLine("filedialog opened")
        OpenFileDialog1.Filter = "wav files (*.wav)|*.wav"
    End Sub

    ' find a way to copy the location of the file to the textbox after selecting it

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' add a check for the right file extension and if the path is valid then proceed to tabpage5
        Registry.SetValue("HKEY_CURRENT_USER\HRTime", "audiodir", DungeonRichTextBox1.Text)
        Debug.WriteLine("audiodir = " & DungeonRichTextBox1.Text)
        MaterialTabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' the buttons are bugged at least for me and the right color isnt applied idk ill try fixing it later
        Registry.SetValue("HKEY_CURRENT_USER\HRTime", "autoupdate", "true")
        Debug.WriteLine("autoupdate = true")
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Registry.SetValue("HKEY_CURRENT_USER\HRTime", "autoupdate", "false")
        Debug.WriteLine("autoupdate = false")
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Registry.SetValue("HKEY_CURRENT_USER\HRTime", "firstsetup", "false")
        Debug.WriteLine("firstsetup complete")
        Me.Close()
    End Sub
End Class