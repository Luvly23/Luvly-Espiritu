<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_login = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_rgstr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_login
        '
        Me.txt_login.AutoSize = True
        Me.txt_login.Font = New System.Drawing.Font("Wide Latin", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(49, 9)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(192, 43)
        Me.txt_login.TabIndex = 0
        Me.txt_login.Text = "Login"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(90, 80)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(142, 20)
        Me.txt_username.TabIndex = 2
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(90, 135)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(142, 20)
        Me.txt_pass.TabIndex = 3
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(153, 184)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(118, 30)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "Login"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_password_30
        Me.Label3.Location = New System.Drawing.Point(45, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 48)
        Me.Label3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_user_24
        Me.Label2.Location = New System.Drawing.Point(45, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 53)
        Me.Label2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = Global.WindowsApplication2.My.Resources.Resources.icons8_human_32
        Me.Label1.Location = New System.Drawing.Point(14, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'btn_rgstr
        '
        Me.btn_rgstr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_rgstr.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rgstr.Location = New System.Drawing.Point(26, 184)
        Me.btn_rgstr.Name = "btn_rgstr"
        Me.btn_rgstr.Size = New System.Drawing.Size(102, 30)
        Me.btn_rgstr.TabIndex = 7
        Me.btn_rgstr.Text = "Register"
        Me.btn_rgstr.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(283, 236)
        Me.Controls.Add(Me.btn_rgstr)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_login)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_login As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_rgstr As Button
End Class
