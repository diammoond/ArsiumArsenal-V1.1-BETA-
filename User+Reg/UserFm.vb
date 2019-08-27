Imports System.Security.Cryptography

Public Class UserFm
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        RegForm.Show()
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click

        If RadTextBox1.Text = IO.File.ReadAllText("User") And RadTextBox2.Text = IO.File.ReadAllText("PW") Then
            Try
                PORTARS.Show()
                Me.Hide()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub UserFm_Load(sender As Object, e As EventArgs) Handles MyBase.Closing
        Application.ExitThread()
        'r
    End Sub
End Class