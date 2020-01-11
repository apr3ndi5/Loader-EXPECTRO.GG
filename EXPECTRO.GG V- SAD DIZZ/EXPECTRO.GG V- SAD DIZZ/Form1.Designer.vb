<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DoomThemeEdited1 = New EXPECTRO.GG_V__SAD_DIZZ.DoomThemeEdited()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pass = New EXPECTRO.GG_V__SAD_DIZZ.GameBoosterTextBoxRound()
        Me.user = New EXPECTRO.GG_V__SAD_DIZZ.GameBoosterTextBoxRound()
        Me.GameBoosterButton1 = New EXPECTRO.GG_V__SAD_DIZZ.GameBoosterButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.DoomThemeEdited1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DoomThemeEdited1
        '
        Me.DoomThemeEdited1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.DoomThemeEdited1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.DoomThemeEdited1.Controls.Add(Me.Label3)
        Me.DoomThemeEdited1.Controls.Add(Me.PictureBox1)
        Me.DoomThemeEdited1.Controls.Add(Me.Label1)
        Me.DoomThemeEdited1.Controls.Add(Me.pass)
        Me.DoomThemeEdited1.Controls.Add(Me.user)
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
        Me.DoomThemeEdited1.Size = New System.Drawing.Size(264, 287)
        Me.DoomThemeEdited1.SmartBounds = True
        Me.DoomThemeEdited1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.DoomThemeEdited1.TabIndex = 0
        Me.DoomThemeEdited1.Text = "EXPECTRO.GG"
        Me.DoomThemeEdited1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DoomThemeEdited1.Transparent = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(107, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Coded BY: S A D  D I Z Z"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.EXPECTRO.GG_V__SAD_DIZZ.My.Resources.Resources._6
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 119)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 8
        '
        'pass
        '
        Me.pass.Colors = New EXPECTRO.GG_V__SAD_DIZZ.Bloom(-1) {}
        Me.pass.Customization = ""
        Me.pass.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.pass.Image = Nothing
        Me.pass.Location = New System.Drawing.Point(12, 199)
        Me.pass.MaxLength = 32767
        Me.pass.Multiline = False
        Me.pass.Name = "pass"
        Me.pass.NoRounding = False
        Me.pass.ReadOnly = False
        Me.pass.Size = New System.Drawing.Size(240, 24)
        Me.pass.TabIndex = 6
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.pass.Transparent = False
        Me.pass.UseSystemPasswordChar = False
        '
        'user
        '
        Me.user.Colors = New EXPECTRO.GG_V__SAD_DIZZ.Bloom(-1) {}
        Me.user.Customization = ""
        Me.user.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.user.Image = Nothing
        Me.user.Location = New System.Drawing.Point(12, 165)
        Me.user.MaxLength = 32767
        Me.user.Multiline = False
        Me.user.Name = "user"
        Me.user.NoRounding = False
        Me.user.ReadOnly = False
        Me.user.Size = New System.Drawing.Size(240, 24)
        Me.user.TabIndex = 5
        Me.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.user.Transparent = False
        Me.user.UseSystemPasswordChar = False
        '
        'GameBoosterButton1
        '
        Me.GameBoosterButton1.Colors = New EXPECTRO.GG_V__SAD_DIZZ.Bloom(-1) {}
        Me.GameBoosterButton1.Customization = ""
        Me.GameBoosterButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GameBoosterButton1.Image = Nothing
        Me.GameBoosterButton1.Location = New System.Drawing.Point(78, 233)
        Me.GameBoosterButton1.Name = "GameBoosterButton1"
        Me.GameBoosterButton1.NoRounding = False
        Me.GameBoosterButton1.Size = New System.Drawing.Size(100, 38)
        Me.GameBoosterButton1.TabIndex = 4
        Me.GameBoosterButton1.Text = "LOGIN"
        Me.GameBoosterButton1.Transparent = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 287)
        Me.Controls.Add(Me.DoomThemeEdited1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXPECTRO.GG"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DoomThemeEdited1.ResumeLayout(False)
        Me.DoomThemeEdited1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DoomThemeEdited1 As EXPECTRO.GG_V__SAD_DIZZ.DoomThemeEdited
    Friend WithEvents pass As EXPECTRO.GG_V__SAD_DIZZ.GameBoosterTextBoxRound
    Friend WithEvents user As EXPECTRO.GG_V__SAD_DIZZ.GameBoosterTextBoxRound
    Friend WithEvents GameBoosterButton1 As EXPECTRO.GG_V__SAD_DIZZ.GameBoosterButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
