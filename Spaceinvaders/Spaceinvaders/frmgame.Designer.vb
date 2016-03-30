<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgame
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgame))
        Me.PictureBox19 = New System.Windows.Forms.PictureBox
        Me.PictureBox17 = New System.Windows.Forms.PictureBox
        Me.PictureBox18 = New System.Windows.Forms.PictureBox
        Me.PictureBox16 = New System.Windows.Forms.PictureBox
        Me.PictureBox20 = New System.Windows.Forms.PictureBox
        Me.PictureBox21 = New System.Windows.Forms.PictureBox
        Me.label1 = New System.Windows.Forms.Label
        Me.Lblscore = New System.Windows.Forms.Label
        Me.lbllife = New System.Windows.Forms.Label
        Me.lblll = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Picstart = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.picbullet = New System.Windows.Forms.PictureBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.timerbullets = New System.Windows.Forms.Timer(Me.components)
        Me.Timerwait = New System.Windows.Forms.Timer(Me.components)
        Me.picboxback = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picstart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.Spaceinvaders.My.Resources.Resources.cannon
        Me.PictureBox19.Location = New System.Drawing.Point(248, 674)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(70, 39)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox19.TabIndex = 19
        Me.PictureBox19.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Location = New System.Drawing.Point(248, 589)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(70, 39)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 18
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.Location = New System.Drawing.Point(443, 589)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(70, 39)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 17
        Me.PictureBox18.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Location = New System.Drawing.Point(51, 589)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(70, 39)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 15
        Me.PictureBox16.TabStop = False
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox20.Location = New System.Drawing.Point(0, 49)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(574, 8)
        Me.PictureBox20.TabIndex = 21
        Me.PictureBox20.TabStop = False
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox21.Location = New System.Drawing.Point(324, 0)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(11, 57)
        Me.PictureBox21.TabIndex = 24
        Me.PictureBox21.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.label1.Location = New System.Drawing.Point(346, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Score"
        '
        'Lblscore
        '
        Me.Lblscore.AutoSize = True
        Me.Lblscore.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lblscore.Location = New System.Drawing.Point(387, 22)
        Me.Lblscore.Name = "Lblscore"
        Me.Lblscore.Size = New System.Drawing.Size(19, 13)
        Me.Lblscore.TabIndex = 26
        Me.Lblscore.Text = "...."
        '
        'lbllife
        '
        Me.lbllife.AutoSize = True
        Me.lbllife.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbllife.Location = New System.Drawing.Point(464, 22)
        Me.lbllife.Name = "lbllife"
        Me.lbllife.Size = New System.Drawing.Size(19, 13)
        Me.lbllife.TabIndex = 28
        Me.lbllife.Text = "...."
        '
        'lblll
        '
        Me.lblll.AutoSize = True
        Me.lblll.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblll.Location = New System.Drawing.Point(423, 22)
        Me.lblll.Name = "lblll"
        Me.lblll.Size = New System.Drawing.Size(32, 13)
        Me.lblll.TabIndex = 27
        Me.lblll.Text = "Lives"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbltime.Location = New System.Drawing.Point(548, 22)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(19, 13)
        Me.lbltime.TabIndex = 30
        Me.lbltime.Text = "...."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(507, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Time"
        '
        'Timer1
        '
        '
        'Picstart
        '
        Me.Picstart.BackColor = System.Drawing.Color.Lime
        Me.Picstart.Location = New System.Drawing.Point(8, 10)
        Me.Picstart.Name = "Picstart"
        Me.Picstart.Size = New System.Drawing.Size(72, 24)
        Me.Picstart.TabIndex = 31
        Me.Picstart.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkBlue
        Me.PictureBox1.Location = New System.Drawing.Point(86, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 24)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "invader3.bmp")
        Me.ImageList1.Images.SetKeyName(1, "invader1.bmp")
        Me.ImageList1.Images.SetKeyName(2, "invader2.bmp")
        '
        'picbullet
        '
        Me.picbullet.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picbullet.Location = New System.Drawing.Point(278, 674)
        Me.picbullet.Name = "picbullet"
        Me.picbullet.Size = New System.Drawing.Size(10, 10)
        Me.picbullet.TabIndex = 33
        Me.picbullet.TabStop = False
        Me.picbullet.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 50
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "defence5.bmp")
        Me.ImageList2.Images.SetKeyName(1, "defence.bmp")
        Me.ImageList2.Images.SetKeyName(2, "defence2.bmp")
        Me.ImageList2.Images.SetKeyName(3, "defence3.bmp")
        Me.ImageList2.Images.SetKeyName(4, "defence4.bmp")
        '
        'timerbullets
        '
        '
        'Timerwait
        '
        '
        'picboxback
        '
        Me.picboxback.BackColor = System.Drawing.Color.Orange
        Me.picboxback.Location = New System.Drawing.Point(164, 10)
        Me.picboxback.Name = "picboxback"
        Me.picboxback.Size = New System.Drawing.Size(72, 24)
        Me.picboxback.TabIndex = 34
        Me.picboxback.TabStop = False
        '
        'frmgame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(572, 727)
        Me.Controls.Add(Me.picboxback)
        Me.Controls.Add(Me.picbullet)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Picstart)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbllife)
        Me.Controls.Add(Me.lblll)
        Me.Controls.Add(Me.Lblscore)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox16)
        Me.Name = "frmgame"
        Me.Text = "Space Invaders"
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picstart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Lblscore As System.Windows.Forms.Label
    Friend WithEvents lbllife As System.Windows.Forms.Label
    Friend WithEvents lblll As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Picstart As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents picbullet As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents timerbullets As System.Windows.Forms.Timer
    Friend WithEvents Timerwait As System.Windows.Forms.Timer
    Friend WithEvents picboxback As System.Windows.Forms.PictureBox
End Class
