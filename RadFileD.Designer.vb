<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadFileD
    Inherits Telerik.WinControls.UI.RadForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadFileD))
        Me.ExplorerControl1 = New Telerik.WinControls.FileDialogs.ExplorerControl()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExplorerControl1
        '
        Me.ExplorerControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ExplorerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExplorerControl1.Location = New System.Drawing.Point(0, 0)
        Me.ExplorerControl1.Name = "ExplorerControl1"
        Me.ExplorerControl1.ShowHiddenFiles = True
        Me.ExplorerControl1.Size = New System.Drawing.Size(849, 485)
        Me.ExplorerControl1.TabIndex = 0
        Me.ExplorerControl1.ThemeName = "Material"
        '
        'RadFileD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 485)
        Me.Controls.Add(Me.ExplorerControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RadFileD"
        Me.Opacity = 0.9R
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Directory"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExplorerControl1 As Telerik.WinControls.FileDialogs.ExplorerControl
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
End Class
