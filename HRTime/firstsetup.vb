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
        If MetroTextBox1.Text = "passoid" Then
            MessageBox.Show("please get off 4chan. for your own good.", "HRTime",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            MaterialTabControl1.SelectedTab = TabPage3
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MaterialTabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
    End Sub
End Class