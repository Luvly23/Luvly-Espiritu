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
        Me.lbl_register = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_cpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_rgstr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_register
        '
        Me.lbl_register.Font = New System.Drawing.Font("Wide Latin", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_register.Location = New System.Drawing.Point(21, 9)
        Me.lbl_register.Name = "lbl_register"
        Me.lbl_register.Size = New System.Drawing.Size(252, 54)
        Me.lbl_register.TabIndex = 0
        Me.lbl_register.Text = "Register"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(122, 79)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(142, 20)
        Me.txt_username.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(122, 121)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(142, 20)
        Me.txt_email.TabIndex = 2
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(122, 169)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(142, 20)
        Me.txt_pass.TabIndex = 3
        '
        'txt_cpass
        '
        Me.txt_cpass.Location = New System.Drawing.Point(122, 211)
        Me.txt_cpass.Name = "txt_cpass"
        Me.txt_cpass.Size = New System.Drawing.Size(142, 20)
        Me.txt_cpass.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(257, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Account"
        '
        'Label5
        '
        Me.Label5.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_password_301
        Me.Label5.Location = New System.Drawing.Point(78, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 47)
        Me.Label5.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_password_301
        Me.Label4.Location = New System.Drawing.Point(79, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 38)
        Me.Label4.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_email_sign_24
        Me.Label3.Location = New System.Drawing.Point(89, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 50)
        Me.Label3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_user_241
        Me.Label2.Location = New System.Drawing.Point(89, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 55)
        Me.Label2.TabIndex = 6
        '
        'btn_rgstr
        '
        Me.btn_rgstr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_rgstr.Location = New System.Drawing.Point(213, 246)
        Me.btn_rgstr.Name = "btn_rgstr"
        Me.btn_rgstr.Size = New System.Drawing.Size(102, 34)
        Me.btn_rgstr.TabIndex = 10
        Me.btn_rgstr.Text = "Register"
        Me.btn_rgstr.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(327, 292)
        Me.Controls.Add(Me.btn_rgstr)
        Me.Controls.Add(Me.txt_cpass)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_register)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_register As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_cpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_rgstr As Button
End Class
