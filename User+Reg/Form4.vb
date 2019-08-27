Imports System.Security.Cryptography
Imports System.Text

Public Class RegForm
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If RadTextBox1.Text.Length > 0 And RadTextBox2.Text.Length > 0 Then


            IO.File.WriteAllText("User", RadTextBox1.Text)
            IO.File.WriteAllText("PW", RadTextBox2.Text)

            MessageBox.Show("Done ! App will restart now !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(My.Computer.FileSystem.CurrentDirectory & "\Arsium Arsenal.exe")
            Application.ExitThread()
        End If
    End Sub

End Class