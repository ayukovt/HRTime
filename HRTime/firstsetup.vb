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
                Or InStr(MetroTextBox1.Text, "manmoder", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "tranny", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "gorillamoder", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "brickhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "boomerhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "bitterhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "heighthon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "honmoder", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "innerhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "outerhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "rapehon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "reddithon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "ribcagehon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "shadowhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "shoulderhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "sneedhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "twinkhon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "iwnbam", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "gayden", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "poonbro", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "pooner", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "tunapoon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "gigapoon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "manlet", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "tranner", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "troon", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "transmaxxing", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "youngshit", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "midshit", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "oldshit", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "agp", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "husstuss", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "boyremove", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "trannerexia", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "luckshit", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "malefail", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "mog", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "mogging", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "mogs", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "repper", vbTextCompare) _
                Or InStr(MetroTextBox1.Text, "hsts", vbTextCompare) Then
            Debug.WriteLine("4chan term msgbox")
            MessageBox.Show("4chan term detected. please get off 4chan and go outside im begging you", "HRTime",
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