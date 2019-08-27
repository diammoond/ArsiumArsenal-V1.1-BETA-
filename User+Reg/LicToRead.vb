Public Class ARSD
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuCircleProgress1.AnimationInterval = 4
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.IsFirstTimeRun = True Then
            Timer1.Start()
            Timer2.Start()
            RadLabel2.Text = 15
            BunifuCircleProgress1.Text = ""
            BunifuCircleProgress2.Text = ""
        Else
            BunifuCircleProgress1.Text = ""
            BunifuCircleProgress2.Text = ""
            RadLabel2.Text = 0
            RadCheckBox1.Enabled = True
            RadCheckBox1.Text = "I've already read it !"


        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        If RadLabel2.Text > 0 Then
            RadLabel2.Text = RadLabel2.Text - 1
        Else
            Timer1.Stop()
        End If

        If RadLabel2.Text = 0 Then
            Timer1.Stop()
            RadLabel2.Text = 0
            My.Settings.IsFirstTimeRun = False
            RadCheckBox1.Enabled = True

        End If
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBox1.ToggleStateChanged
        If RadCheckBox1.Checked = True Then
            '   PORTARS.Show()
            UserFm.Show()
            Me.Hide()
            My.Settings.IsFirstTimeRun = False
        End If

    End Sub
End Class