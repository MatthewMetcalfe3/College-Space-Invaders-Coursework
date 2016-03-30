<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogon
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnlogon = New System.Windows.Forms.Button
        Me.Btnregister = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(69, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(69, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtname
        '
        Me.txtname.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtname.Location = New System.Drawing.Point(125, 93)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 2
        Me.txtname.Text = "matt"
        '
        'txtpass
        '
        Me.txtpass.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtpass.Location = New System.Drawing.Point(125, 136)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(100, 20)
        Me.txtpass.TabIndex = 3
        Me.txtpass.Text = "pass"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(0, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 46)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Space Invaders"
        '
        'btnlogon
        '
        Me.btnlogon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogon.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnlogon.Location = New System.Drawing.Point(49, 187)
        Me.btnlogon.Name = "btnlogon"
        Me.btnlogon.Size = New System.Drawing.Size(75, 23)
        Me.btnlogon.TabIndex = 5
        Me.btnlogon.Text = "Enter"
        Me.btnlogon.UseVisualStyleBackColor = True
        '
        'Btnregister
        '
        Me.Btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnregister.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btnregister.Location = New System.Drawing.Point(150, 187)
        Me.Btnregister.Name = "Btnregister"
        Me.Btnregister.Size = New System.Drawing.Size(75, 23)
        Me.Btnregister.TabIndex = 6
        Me.Btnregister.Text = "Register"
        Me.Btnregister.UseVisualStyleBackColor = True
        '
        'Frmlogon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(298, 266)
        Me.Controls.Add(Me.Btnregister)
        Me.Controls.Add(Me.btnlogon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmlogon"
        Me.Text = "Space Invaders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnlogon As System.Windows.Forms.Button
    Friend WithEvents Btnregister As System.Windows.Forms.Button
End Class
