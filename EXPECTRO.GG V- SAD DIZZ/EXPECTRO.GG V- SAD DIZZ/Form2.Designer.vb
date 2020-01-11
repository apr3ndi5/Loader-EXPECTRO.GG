<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DoomThemeEdited1 = New EXPECTRO.GG_V__SAD_DIZZ.DoomThemeEdited()
        Me.GameBoosterButton1 = New EXPECTRO.GG_V__SAD_DIZZ.GameBoosterButton()
        Me.DoomThemeEdited1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DoomThemeEdited1
        '
        Me.DoomThemeEdited1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.DoomThemeEdited1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.DoomThemeEdited1.Controls.Add(Me.GameBoosterButton1)
        Me.DoomThemeEdited1.Customization = "AAD//yEhIf8WFhb/"
        Me.DoomThemeEdited1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DoomThemeEdited1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DoomThemeEdited1.Image = Nothing
        Me.DoomThemeEdited1.Location = New System.Drawing.Point(0, 0)
        Me.DoomThemeEdited1.Movable = True
        Me.DoomThemeEdited1.Name = "DoomThemeEdited1"
        Me.DoomThemeEdited1.NoRounding = False
        Me.DoomThemeEdited1.Sizable = True
        Me.DoomThemeEdited1.Size = New System.Drawing.Size(241, 121)
        Me.DoomThemeEdited1.SmartBounds = True
        Me.DoomThemeEdited1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.DoomThemeEdited1.TabIndex = 0
        Me.DoomThemeEdited1.Text = "EXPECTRO.GG"
        Me.DoomThemeEdited1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DoomThemeEdited1.Transparent = False
        '
        'GameBoosterButton1
        '
        Me.GameBoosterButton1.Colors = New EXPECTRO.GG_V__SAD_DIZZ.Bloom(-1) {}
        Me.GameBoosterButton1.Customization = ""
        Me.GameBoosterButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GameBoosterButton1.Image = Nothing
        Me.GameBoosterButton1.Location = New System.Drawing.Point(47, 52)
        Me.GameBoosterButton1.Name = "GameBoosterButton1"
        Me.GameBoosterButton1.NoRounding = False
        Me.GameBoosterButton1.Size = New System.Drawing.Size(145, 48)
        Me.GameBoosterButton1.TabIndex = 0
        Me.GameBoosterButton1.Text = "INJECT"
        Me.GameBoosterButton1.Transparent = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 121)
        Me.Controls.Add(Me.DoomThemeEdited1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXPECTRO.GG"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DoomThemeEdited1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DoomThemeEdited1 As EXPECTRO.GG_V__SAD_DIZZ.DoomThemeEdited
    Friend WithEvents GameBoosterButton1 As EXPECTRO.GG_V__SAD_DIZZ.GameBoosterButton
End Class
