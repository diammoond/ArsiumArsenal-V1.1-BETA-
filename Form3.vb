Imports System.Net.Mail

Public Class SendEm
    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = True
            Smtp_Server.Credentials = New Net.NetworkCredential(RadTextBox1.Text, RadTextBox2.Text)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"




            e_mail = New MailMessage()

            e_mail.From = New MailAddress(RadTextBox1.Text, RadTextBox3.Text)
            e_mail.To.Add("mehdi81101@gmail.com")
            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            e_mail.Body = BunifuCustomTextbox1.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)

        End Try
    End Sub

    Private Sub SendEm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadTextBox2.UseSystemPasswordChar = True
    End Sub
End Class