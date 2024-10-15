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
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "wav files (*.wav)|*.wav"
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    End Sub
End Class