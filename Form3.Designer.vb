<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendEm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendEm))
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuButton6 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuCustomTextbox1 = New Bunifu.Framework.BunifuCustomTextbox()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuButton6
        '
        Me.BunifuButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton6.BackgroundImage = CType(resources.GetObject("BunifuButton6.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton6.ButtonText = "Send !"
        Me.BunifuButton6.ButtonTextMarginLeft = 0
        Me.BunifuButton6.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton6.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton6.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton6.ForeColor = System.Drawing.Color.White
        Me.BunifuButton6.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton6.IconPadding = 10
        Me.BunifuButton6.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton6.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton6.IdleBorderRadius = 1
        Me.BunifuButton6.IdleBorderThickness = 0
        Me.BunifuButton6.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton6.IdleIconLeftImage = Nothing
        Me.BunifuButton6.IdleIconRightImage = Nothing
        Me.BunifuButton6.Location = New System.Drawing.Point(12, 372)
        Me.BunifuButton6.Name = "BunifuButton6"
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties9.BorderRadius = 1
        StateProperties9.BorderThickness = 1
        StateProperties9.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties9.IconLeftImage = Nothing
        StateProperties9.IconRightImage = Nothing
        Me.BunifuButton6.onHoverState = StateProperties9
        Me.BunifuButton6.Size = New System.Drawing.Size(581, 24)
        Me.BunifuButton6.TabIndex = 3
        Me.BunifuButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(12, 180)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(565, 40)
        Me.BunifuLabel1.TabIndex = 6
        Me.BunifuLabel1.Text = "Message :"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.AutoSize = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(12, 47)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(264, 40)
        Me.BunifuLabel2.TabIndex = 7
        Me.BunifuLabel2.Text = "Email Adress:"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(317, 47)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(276, 40)
        Me.BunifuLabel3.TabIndex = 8
        Me.BunifuLabel3.Text = "Password :"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuLabel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 40)
        Me.Panel1.TabIndex = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.AutoSize = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.Location = New System.Drawing.Point(84, 3)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(424, 34)
        Me.BunifuLabel4.TabIndex = 11
        Me.BunifuLabel4.Text = "Send Email"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuCustomTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(12, 226)
        Me.BunifuCustomTextbox1.Multiline = True
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(581, 120)
        Me.BunifuCustomTextbox1.TabIndex = 11
        Me.BunifuCustomTextbox1.Text = "fdgdfg"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(12, 93)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(252, 20)
        Me.RadTextBox1.TabIndex = 14
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Location = New System.Drawing.Point(317, 93)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(252, 20)
        Me.RadTextBox2.TabIndex = 15
        '
        'RadTextBox3
        '
        Me.RadTextBox3.Location = New System.Drawing.Point(12, 165)
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.Size = New System.Drawing.Size(252, 20)
        Me.RadTextBox3.TabIndex = 16
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.AutoSize = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Microsoft Yi Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(12, 119)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(264, 40)
        Me.BunifuLabel5.TabIndex = 17
        Me.BunifuLabel5.Text = "Username :"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'SendEm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(606, 439)
        Me.Controls.Add(Me.BunifuLabel5)
        Me.Controls.Add(Me.RadTextBox3)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.BunifuCustomTextbox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuButton6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SendEm"
        Me.Text = "Send Email"
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuButton6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomTextbox1 As Bunifu.Framework.BunifuCustomTextbox
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
End Class
