<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstartpage
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbllogin = New System.Windows.Forms.Label
        Me.lblhighscores = New System.Windows.Forms.Label
        Me.lblhowtoplay = New System.Windows.Forms.Label
        Me.lblplay = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(29, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Space Invaders"
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbllogin.Location = New System.Drawing.Point(128, 130)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(89, 31)
        Me.lbllogin.TabIndex = 1
        Me.lbllogin.Text = "Log In"
        '
        'lblhighscores
        '
        Me.lblhighscores.AutoSize = True
        Me.lblhighscores.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhighscores.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblhighscores.Location = New System.Drawing.Point(95, 172)
        Me.lblhighscores.Name = "lblhighscores"
        Me.lblhighscores.Size = New System.Drawing.Size(162, 31)
        Me.lblhighscores.TabIndex = 2
        Me.lblhighscores.Text = "High Scores"
        '
        'lblhowtoplay
        '
        Me.lblhowtoplay.AutoSize = True
        Me.lblhowtoplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhowtoplay.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblhowtoplay.Location = New System.Drawing.Point(89, 216)
        Me.lblhowtoplay.Name = "lblhowtoplay"
        Me.lblhowtoplay.Size = New System.Drawing.Size(168, 31)
        Me.lblhowtoplay.TabIndex = 3
        Me.lblhowtoplay.Text = "How To Play"
        '
        'lblplay
        '
        Me.lblplay.AutoSize = True
        Me.lblplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplay.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblplay.Location = New System.Drawing.Point(95, 261)
        Me.lblplay.Name = "lblplay"
        Me.lblplay.Size = New System.Drawing.Size(147, 31)
        Me.lblplay.TabIndex = 4
        Me.lblplay.Text = "Play Game"
        '
        'frmstartpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(350, 380)
        Me.Controls.Add(Me.lblplay)
        Me.Controls.Add(Me.lblhowtoplay)
        Me.Controls.Add(Me.lblhighscores)
        Me.Controls.Add(Me.lbllogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmstartpage"
        Me.Text = "Space Invaders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbllogin As System.Windows.Forms.Label
    Friend WithEvents lblhighscores As System.Windows.Forms.Label
    Friend WithEvents lblhowtoplay As System.Windows.Forms.Label
    Friend WithEvents lblplay As System.Windows.Forms.Label

End Class
