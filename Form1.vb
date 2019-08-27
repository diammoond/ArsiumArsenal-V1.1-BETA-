Imports System.Net.Mail
Imports System.Text

Public Class PORTARS


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '    Dim control As New FrmV
        '   ArsR()
    End Sub


    Private Sub RadMenuItem4_Click(sender As Object, e As EventArgs) Handles RadMenuItem4.Click
        If MessageBox.Show("Do you want to leave ?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.OK Then
            Application.ExitThread()
        Else

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        BunifuGradientPanel4.BringToFront()
        BunifuGradientPanel3.BringToFront()
        Label1.Visible = False
        '  Label1.Text = "IP:" & IpAddress()
        ARSD.Close()
        Timer1.Start()
        If My.Settings.Wallpaperf.Length > 0 Then
            BunifuGradientPanel2.BackgroundImage = Image.FromFile(My.Settings.Wallpaperf)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        '    ArsR()
    End Sub
    '  Public Sub ArsR()
    '  Dim control As New FrmMain
    '   control.TopMost = True
    '  control.TopLevel = False

    ' BunifuGradientPanel2.Controls.Add(control)
    '  control.Show()
    '  End Sub
    Public Sub LimeR()
        Dim control As New Intro
        control.TopMost = False
        control.TopLevel = False

        BunifuGradientPanel2.Controls.Add(control)
        control.Show()
    End Sub

    Private Sub RadMenuItem2_Click(sender As Object, e As EventArgs) Handles RadMenuItem2.Click
        ' ArsR()
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim red, blue, green, yellow As Integer
        red = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
        green = Int(Rnd() * 255)
        yellow = Int(Rnd() * 255)

        RadLabel1.ForeColor = Color.FromArgb(red, blue, green, yellow)
        BunifuCustomLabel1.ForeColor = Color.FromArgb(red, blue, green, yellow)
    End Sub

    Private Sub LeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveToolStripMenuItem.Click

        If MessageBox.Show("Do you want to leave ?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.OK Then
            Application.ExitThread()
        Else

        End If
    End Sub

    Private Sub RadMenuItem6_Click(sender As Object, e As EventArgs) Handles RadMenuItem6.Click
        LimeR()
    End Sub

    Private Sub LimeRatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimeRatToolStripMenuItem.Click
        LimeR()
    End Sub

    Private Sub ArsiumDownloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArsiumDownloaderToolStripMenuItem.Click
        '   ArsDowl()
    End Sub


    Private Sub RadMenuItem5_Click(sender As Object, e As EventArgs) Handles RadMenuItem5.Click
        '  ArsD3()
        '  ArsDowl()
    End Sub
    ' Public Sub ArsDowl()
    'Dim control As New Form1
    '  control.TopMost = True
    '    Control.TopLevel = False
    '  BunifuGradientPanel2.Controls.Add(control)
    '   control.Show()
    ' End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            RadTextBox1.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            BunifuGradientPanel2.BackgroundImage = Image.FromFile(RadTextBox1.Text)
            My.Settings.Wallpaperf = RadTextBox1.Text
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        My.Settings.Wallpaperf = ""
        MessageBox.Show("Wallpaper has been removed ! Restart for application !", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub BunifuCheckBox1_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox1.CheckedChanged
        If BunifuCheckBox1.Checked = True Then

            Me.RadPageView1.ThemeName = "VisualStudio2012Dark"
            BunifuLabel1.ForeColor = Color.White
        Else
            Me.RadPageView1.ThemeName = "Office2013Dark"
            BunifuLabel1.ForeColor = Color.Black

        End If
    End Sub
    Private Function IpAddress() As String
        Using wc As New Net.WebClient
            Return System.Text.Encoding.UTF8.GetString(wc.DownloadData("http://tools.feron.it/php/ip.php"))
        End Using
    End Function

    Private Sub DesktopFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesktopFolderToolStripMenuItem.Click
        Dim control As New RadFileD
        control.TopMost = True
        control.TopLevel = False
        control.ExplorerControl1.CurrentDirectoryPath = My.Computer.FileSystem.SpecialDirectories.Desktop
        BunifuGradientPanel2.Controls.Add(control)
        control.Show()


    End Sub



    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub NormalModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalModeToolStripMenuItem.Click
        Dim control As New RadFileD
        control.TopMost = True
        control.TopLevel = False
        control.ExplorerControl1.CurrentDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
        BunifuGradientPanel2.Controls.Add(control)
        control.Show()

    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        Dim control As New SendEm
        control.TopMost = True
        control.TopLevel = False

        BunifuGradientPanel2.Controls.Add(control)
        control.Show()
    End Sub


End Class
