Public Class firstsetup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialTabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MetroTextBox1.Text = "" Then
            MessageBox.Show("Please enter something in the text box first.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MaterialTabControl1.SelectedTab = TabPage3
        End If
        ' rewrite later to check if the specific keyword *exists* in the textbox instead of checking if the text is exactly the keyword itself
        If LCase(MetroTextBox1.Text) = "passoid" Or LCase(MetroTextBox1.Text) = "hon" Or LCase(MetroTextBox1.Text) = "gigahon" Or LCase(MetroTextBox1.Text) = "ogrehon" Or LCase(MetroTextBox1.Text) = "ogre" Or LCase(MetroTextBox1.Text) = "boymoder" Or LCase(MetroTextBox1.Text) = "iwnbaw" Or LCase(MetroTextBox1.Text) = "ywnbaw" Or LCase(MetroTextBox1.Text) = "ngmi" Or LCase(MetroTextBox1.Text) = "hsts" Then
            MessageBox.Show("please get off 4chan. for your own good.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            MaterialTabControl1.SelectedTab = TabPage3
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DungeonNumeric1.Value = 0 Then
            MessageBox.Show("Invalid amount.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MaterialTabControl1.SelectedTab = TabPage4
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' needs fixing
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "wav files (*.wav)|*.wav"
    End Sub

    ' find a way to copy the location of the file to the textbox after selecting it

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' add a check for the right file extension and if the path is valid then proceed to tabpage5
        MaterialTabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' add a registry key (or idk some other way of doing this) smth like "autoupdate = true"
        ' oh btw the buttons are bugged at least for me and the right color isnt applied idk ill try fixing it later
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' same applies here but instead of "true" make it "false"
        MaterialTabControl1.SelectedTab = TabPage6
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class