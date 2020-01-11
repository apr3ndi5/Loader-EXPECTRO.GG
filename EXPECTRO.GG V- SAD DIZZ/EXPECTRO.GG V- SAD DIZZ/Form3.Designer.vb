<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.injectlbl = New EXPECTRO.GG_V__SAD_DIZZ.DoomThemeEdited()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'injectlbl
        '
        Me.injectlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.injectlbl.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.injectlbl.Customization = "AAD//yEhIf8WFhb/"
        Me.injectlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.injectlbl.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.injectlbl.Image = Nothing
        Me.injectlbl.Location = New System.Drawing.Point(0, 0)
        Me.injectlbl.Movable = True
        Me.injectlbl.Name = "injectlbl"
        Me.injectlbl.NoRounding = False
        Me.injectlbl.Sizable = True
        Me.injectlbl.Size = New System.Drawing.Size(324, 147)
        Me.injectlbl.SmartBounds = True
        Me.injectlbl.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.injectlbl.TabIndex = 0
        Me.injectlbl.Text = "Expectro"
        Me.injectlbl.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.injectlbl.Transparent = False
        '
        'Timer1
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 147)
        Me.Controls.Add(Me.injectlbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXPECTRO.GG"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents injectlbl As EXPECTRO.GG_V__SAD_DIZZ.DoomThemeEdited
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
