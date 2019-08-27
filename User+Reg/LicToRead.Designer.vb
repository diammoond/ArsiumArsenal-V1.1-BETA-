<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ARSD
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ARSD))
        Me.BunifuCircleProgress1 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.BunifuCircleProgress2 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuTransition1 = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCircleProgress1
        '
        Me.BunifuCircleProgress1.Animated = True
        Me.BunifuCircleProgress1.AnimationInterval = 2
        Me.BunifuCircleProgress1.AnimationSpeed = 1
        Me.BunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress1.CircleMargin = 10
        Me.BunifuCircleProgress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCircleProgress1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCircleProgress1.IsPercentage = True
        Me.BunifuCircleProgress1.LineProgressThickness = 8
        Me.BunifuCircleProgress1.LineThickness = 5
        Me.BunifuCircleProgress1.Location = New System.Drawing.Point(12, 116)
        Me.BunifuCircleProgress1.Name = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuCircleProgress1.ProgressColor = System.Drawing.Color.Black
        Me.BunifuCircleProgress1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress1.Size = New System.Drawing.Size(227, 227)
        Me.BunifuCircleProgress1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.BunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SubScriptMargin = New System.Windows.Forms.Padding(5, -35, 0, 0)
        Me.BunifuCircleProgress1.SubScriptText = ""
        Me.BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SuperScriptMargin = New System.Windows.Forms.Padding(5, 50, 0, 0)
        Me.BunifuCircleProgress1.SuperScriptText = "%"
        Me.BunifuCircleProgress1.TabIndex = 16
        Me.BunifuCircleProgress1.Text = "20"
        Me.BunifuCircleProgress1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.BunifuCircleProgress1.Value = 20
        '
        'Timer1
        '
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = False
        Me.BunifuTransition1.SetDecoration(Me.RadLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.RadLabel1.ForeColor = System.Drawing.Color.White
        Me.RadLabel1.Location = New System.Drawing.Point(245, 84)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(705, 297)
        Me.RadLabel1.TabIndex = 17
        Me.RadLabel1.Text = resources.GetString("RadLabel1.Text")
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadLabel1.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel2
        '
        Me.RadLabel2.AutoSize = False
        Me.BunifuTransition1.SetDecoration(Me.RadLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.RadLabel2.ForeColor = System.Drawing.Color.White
        Me.RadLabel2.Location = New System.Drawing.Point(396, 415)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(56, 27)
        Me.RadLabel2.TabIndex = 18
        Me.RadLabel2.Text = "<html><p><span style=""font-size: 14pt; font-family: sylfaen"">Timer</span></p><p><" &
    "/p></html>"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadLabel2.ThemeName = "VisualStudio2012Dark"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'RadCheckBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.RadCheckBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.RadCheckBox1.Enabled = False
        Me.RadCheckBox1.Location = New System.Drawing.Point(446, 415)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(246, 27)
        Me.RadCheckBox1.TabIndex = 0
        Me.RadCheckBox1.Text = "<html><span style=""font-size: 14pt; font-family: sylfaen"">I've read license and I" &
    " agree !</span></html>"
        Me.RadCheckBox1.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel3
        '
        Me.RadLabel3.AutoSize = False
        Me.BunifuTransition1.SetDecoration(Me.RadLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.RadLabel3.ForeColor = System.Drawing.Color.White
        Me.RadLabel3.Location = New System.Drawing.Point(855, 460)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(121, 27)
        Me.RadLabel3.TabIndex = 19
        Me.RadLabel3.Text = "<html><span style=""font-size: 10pt; font-family: sylfaen"">Author : Arsium</span><" &
    "/html>"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadLabel3.ThemeName = "VisualStudio2012Dark"
        '
        'RadLabel4
        '
        Me.RadLabel4.AutoSize = False
        Me.BunifuTransition1.SetDecoration(Me.RadLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.RadLabel4.ForeColor = System.Drawing.Color.White
        Me.RadLabel4.Location = New System.Drawing.Point(12, 460)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(179, 27)
        Me.RadLabel4.TabIndex = 20
        Me.RadLabel4.Text = "<html><span style=""font-size: 10pt; font-family: sylfaen"">Version : 1.1 BETA [FRE" &
    "E]</span></html>"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.RadLabel4.ThemeName = "VisualStudio2012Dark"
        '
        'BunifuCircleProgress2
        '
        Me.BunifuCircleProgress2.Animated = True
        Me.BunifuCircleProgress2.AnimationInterval = 2
        Me.BunifuCircleProgress2.AnimationSpeed = 1
        Me.BunifuCircleProgress2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress2.CircleMargin = 10
        Me.BunifuCircleProgress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCircleProgress2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCircleProgress2.IsPercentage = True
        Me.BunifuCircleProgress2.LineProgressThickness = 8
        Me.BunifuCircleProgress2.LineThickness = 5
        Me.BunifuCircleProgress2.Location = New System.Drawing.Point(41, 144)
        Me.BunifuCircleProgress2.Name = "BunifuCircleProgress2"
        Me.BunifuCircleProgress2.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuCircleProgress2.ProgressColor = System.Drawing.Color.Black
        Me.BunifuCircleProgress2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress2.Size = New System.Drawing.Size(165, 165)
        Me.BunifuCircleProgress2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.BunifuCircleProgress2.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress2.SubScriptMargin = New System.Windows.Forms.Padding(5, -35, 0, 0)
        Me.BunifuCircleProgress2.SubScriptText = ""
        Me.BunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress2.SuperScriptMargin = New System.Windows.Forms.Padding(5, 50, 0, 0)
        Me.BunifuCircleProgress2.SuperScriptText = "%"
        Me.BunifuCircleProgress2.TabIndex = 21
        Me.BunifuCircleProgress2.Text = "20"
        Me.BunifuCircleProgress2.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.BunifuCircleProgress2.Value = 20
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.BorderRadius = 50
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(73, 178)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 22
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Leaf
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 1.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'ARSD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(988, 499)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.BunifuCircleProgress2)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadCheckBox1)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.BunifuCircleProgress1)
        Me.BunifuTransition1.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ARSD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arsium Arsenal "
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCircleProgress1 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BunifuCircleProgress2 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuTransition1 As Bunifu.UI.WinForms.BunifuTransition
End Class
