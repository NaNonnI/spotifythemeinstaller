<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sti
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sti))
        Me.panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.title = New System.Windows.Forms.Label()
        Me.closeb = New System.Windows.Forms.PictureBox()
        Me.installb = New System.Windows.Forms.Button()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.credit = New System.Windows.Forms.Label()
        Me.Colors = New System.Windows.Forms.Timer(Me.components)
        Me.baserb = New System.Windows.Forms.RadioButton()
        Me.darkrb = New System.Windows.Forms.RadioButton()
        Me.dracularb = New System.Windows.Forms.RadioButton()
        Me.gruvboxrb = New System.Windows.Forms.RadioButton()
        Me.horizonrb = New System.Windows.Forms.RadioButton()
        Me.norddarkrb = New System.Windows.Forms.RadioButton()
        Me.nordlightrb = New System.Windows.Forms.RadioButton()
        Me.purplerb = New System.Windows.Forms.RadioButton()
        Me.samourairb = New System.Windows.Forms.RadioButton()
        Me.whiterb = New System.Windows.Forms.RadioButton()
        Me.downgradecb = New System.Windows.Forms.CheckBox()
        Me.tc = New System.Windows.Forms.Label()
        Me.tctxt = New System.Windows.Forms.Label()
        Me.dl = New System.Windows.Forms.Label()
        Me.panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.LightGreen
        Me.panel.Controls.Add(Me.PictureBox1)
        Me.panel.Controls.Add(Me.logo)
        Me.panel.Controls.Add(Me.title)
        Me.panel.Controls.Add(Me.closeb)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(624, 29)
        Me.panel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Theme_Install.My.Resources.Resources.information
        Me.PictureBox1.Location = New System.Drawing.Point(569, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(3, 3)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(23, 23)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(32, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(144, 13)
        Me.title.TabIndex = 1
        Me.title.Text = "Spotify Theme Installer | Λko."
        '
        'closeb
        '
        Me.closeb.Image = CType(resources.GetObject("closeb.Image"), System.Drawing.Image)
        Me.closeb.Location = New System.Drawing.Point(598, 3)
        Me.closeb.Name = "closeb"
        Me.closeb.Size = New System.Drawing.Size(23, 23)
        Me.closeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeb.TabIndex = 0
        Me.closeb.TabStop = False
        '
        'installb
        '
        Me.installb.Location = New System.Drawing.Point(3, 35)
        Me.installb.Name = "installb"
        Me.installb.Size = New System.Drawing.Size(103, 21)
        Me.installb.TabIndex = 1
        Me.installb.Text = "Install !"
        Me.installb.UseVisualStyleBackColor = True
        '
        'progressBar
        '
        Me.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBar.Location = New System.Drawing.Point(0, 309)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(624, 23)
        Me.progressBar.TabIndex = 2
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtOutput.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.ForeColor = System.Drawing.Color.LightGreen
        Me.txtOutput.Location = New System.Drawing.Point(112, 62)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(500, 228)
        Me.txtOutput.TabIndex = 3
        Me.txtOutput.WordWrap = False
        '
        'txtCommand
        '
        Me.txtCommand.BackColor = System.Drawing.Color.DimGray
        Me.txtCommand.ForeColor = System.Drawing.SystemColors.Window
        Me.txtCommand.Location = New System.Drawing.Point(112, 36)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(500, 20)
        Me.txtCommand.TabIndex = 5
        Me.txtCommand.Text = "Waiting."
        Me.txtCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'credit
        '
        Me.credit.AutoSize = True
        Me.credit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.credit.Location = New System.Drawing.Point(264, 293)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(227, 13)
        Me.credit.TabIndex = 6
        Me.credit.Text = "This script is Powered by spicetify-cli | khanhas"
        '
        'Colors
        '
        Me.Colors.Interval = 500
        '
        'baserb
        '
        Me.baserb.AutoSize = True
        Me.baserb.ForeColor = System.Drawing.SystemColors.Control
        Me.baserb.Location = New System.Drawing.Point(12, 81)
        Me.baserb.Name = "baserb"
        Me.baserb.Size = New System.Drawing.Size(49, 17)
        Me.baserb.TabIndex = 7
        Me.baserb.TabStop = True
        Me.baserb.Text = "Base"
        Me.baserb.UseVisualStyleBackColor = True
        '
        'darkrb
        '
        Me.darkrb.AutoSize = True
        Me.darkrb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.darkrb.Location = New System.Drawing.Point(12, 104)
        Me.darkrb.Name = "darkrb"
        Me.darkrb.Size = New System.Drawing.Size(48, 17)
        Me.darkrb.TabIndex = 8
        Me.darkrb.TabStop = True
        Me.darkrb.Text = "Dark"
        Me.darkrb.UseVisualStyleBackColor = True
        '
        'dracularb
        '
        Me.dracularb.AutoSize = True
        Me.dracularb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.dracularb.Location = New System.Drawing.Point(12, 127)
        Me.dracularb.Name = "dracularb"
        Me.dracularb.Size = New System.Drawing.Size(62, 17)
        Me.dracularb.TabIndex = 9
        Me.dracularb.TabStop = True
        Me.dracularb.Text = "Dracula"
        Me.dracularb.UseVisualStyleBackColor = True
        '
        'gruvboxrb
        '
        Me.gruvboxrb.AutoSize = True
        Me.gruvboxrb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gruvboxrb.Location = New System.Drawing.Point(12, 150)
        Me.gruvboxrb.Name = "gruvboxrb"
        Me.gruvboxrb.Size = New System.Drawing.Size(65, 17)
        Me.gruvboxrb.TabIndex = 10
        Me.gruvboxrb.TabStop = True
        Me.gruvboxrb.Text = "Gruvbox"
        Me.gruvboxrb.UseVisualStyleBackColor = True
        '
        'horizonrb
        '
        Me.horizonrb.AutoSize = True
        Me.horizonrb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.horizonrb.Location = New System.Drawing.Point(12, 173)
        Me.horizonrb.Name = "horizonrb"
        Me.horizonrb.Size = New System.Drawing.Size(61, 17)
        Me.horizonrb.TabIndex = 11
        Me.horizonrb.TabStop = True
        Me.horizonrb.Text = "Horizon"
        Me.horizonrb.UseVisualStyleBackColor = True
        '
        'norddarkrb
        '
        Me.norddarkrb.AutoSize = True
        Me.norddarkrb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.norddarkrb.Location = New System.Drawing.Point(12, 196)
        Me.norddarkrb.Name = "norddarkrb"
        Me.norddarkrb.Size = New System.Drawing.Size(74, 17)
        Me.norddarkrb.TabIndex = 12
        Me.norddarkrb.TabStop = True
        Me.norddarkrb.Text = "Nord-Dark"
        Me.norddarkrb.UseVisualStyleBackColor = True
        '
        'nordlightrb
        '
        Me.nordlightrb.AutoSize = True
        Me.nordlightrb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.nordlightrb.Location = New System.Drawing.Point(12, 219)
        Me.nordlightrb.Name = "nordlightrb"
        Me.nordlightrb.Size = New System.Drawing.Size(74, 17)
        Me.nordlightrb.TabIndex = 13
        Me.nordlightrb.TabStop = True
        Me.nordlightrb.Text = "Nord-Light"
        Me.nordlightrb.UseVisualStyleBackColor = True
        '
        'purplerb
        '
        Me.purplerb.AutoSize = True
        Me.purplerb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.purplerb.Location = New System.Drawing.Point(12, 242)
        Me.purplerb.Name = "purplerb"
        Me.purplerb.Size = New System.Drawing.Size(55, 17)
        Me.purplerb.TabIndex = 14
        Me.purplerb.TabStop = True
        Me.purplerb.Text = "Purple"
        Me.purplerb.UseVisualStyleBackColor = True
        '
        'samourairb
        '
        Me.samourairb.AutoSize = True
        Me.samourairb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.samourairb.Location = New System.Drawing.Point(12, 265)
        Me.samourairb.Name = "samourairb"
        Me.samourairb.Size = New System.Drawing.Size(69, 17)
        Me.samourairb.TabIndex = 15
        Me.samourairb.TabStop = True
        Me.samourairb.Text = "Samourai"
        Me.samourairb.UseVisualStyleBackColor = True
        '
        'whiterb
        '
        Me.whiterb.AutoSize = True
        Me.whiterb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.whiterb.Location = New System.Drawing.Point(12, 288)
        Me.whiterb.Name = "whiterb"
        Me.whiterb.Size = New System.Drawing.Size(53, 17)
        Me.whiterb.TabIndex = 16
        Me.whiterb.TabStop = True
        Me.whiterb.Text = "White"
        Me.whiterb.UseVisualStyleBackColor = True
        '
        'downgradecb
        '
        Me.downgradecb.AutoSize = True
        Me.downgradecb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.downgradecb.Location = New System.Drawing.Point(12, 58)
        Me.downgradecb.Name = "downgradecb"
        Me.downgradecb.Size = New System.Drawing.Size(81, 17)
        Me.downgradecb.TabIndex = 17
        Me.downgradecb.Text = "Downgrade"
        Me.downgradecb.UseVisualStyleBackColor = True
        '
        'tc
        '
        Me.tc.AutoSize = True
        Me.tc.ForeColor = System.Drawing.SystemColors.Control
        Me.tc.Location = New System.Drawing.Point(195, 293)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(30, 13)
        Me.tc.TabIndex = 18
        Me.tc.Text = "base"
        '
        'tctxt
        '
        Me.tctxt.AutoSize = True
        Me.tctxt.ForeColor = System.Drawing.SystemColors.Control
        Me.tctxt.Location = New System.Drawing.Point(109, 293)
        Me.tctxt.Name = "tctxt"
        Me.tctxt.Size = New System.Drawing.Size(89, 13)
        Me.tctxt.TabIndex = 19
        Me.tctxt.Text = "Theme selected :"
        '
        'dl
        '
        Me.dl.AutoSize = True
        Me.dl.ForeColor = System.Drawing.SystemColors.Control
        Me.dl.Location = New System.Drawing.Point(527, 293)
        Me.dl.Name = "dl"
        Me.dl.Size = New System.Drawing.Size(85, 13)
        Me.dl.TabIndex = 20
        Me.dl.Text = "Downgrade : No"
        '
        'sti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 332)
        Me.Controls.Add(Me.dl)
        Me.Controls.Add(Me.tctxt)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.downgradecb)
        Me.Controls.Add(Me.whiterb)
        Me.Controls.Add(Me.samourairb)
        Me.Controls.Add(Me.purplerb)
        Me.Controls.Add(Me.nordlightrb)
        Me.Controls.Add(Me.norddarkrb)
        Me.Controls.Add(Me.horizonrb)
        Me.Controls.Add(Me.gruvboxrb)
        Me.Controls.Add(Me.dracularb)
        Me.Controls.Add(Me.darkrb)
        Me.Controls.Add(Me.baserb)
        Me.Controls.Add(Me.credit)
        Me.Controls.Add(Me.txtCommand)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.installb)
        Me.Controls.Add(Me.panel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spotify Theme Install - Ako."
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel As Panel
    Friend WithEvents closeb As PictureBox
    Friend WithEvents installb As Button
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents title As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents credit As Label
    Friend WithEvents Colors As Timer
    Friend WithEvents baserb As RadioButton
    Friend WithEvents darkrb As RadioButton
    Friend WithEvents dracularb As RadioButton
    Friend WithEvents gruvboxrb As RadioButton
    Friend WithEvents horizonrb As RadioButton
    Friend WithEvents norddarkrb As RadioButton
    Friend WithEvents nordlightrb As RadioButton
    Friend WithEvents purplerb As RadioButton
    Friend WithEvents samourairb As RadioButton
    Friend WithEvents whiterb As RadioButton
    Friend WithEvents downgradecb As CheckBox
    Friend WithEvents tc As Label
    Friend WithEvents tctxt As Label
    Friend WithEvents dl As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
