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
        txt_uname = New TextBox()
        txt_password = New TextBox()
        btn_login = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btn_register = New Button()
        SuspendLayout()
        ' 
        ' txt_uname
        ' 
        txt_uname.Location = New Point(83, 46)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(200, 23)
        txt_uname.TabIndex = 1
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(83, 102)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(200, 23)
        txt_password.TabIndex = 3
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.Peru
        btn_login.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(83, 131)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(81, 35)
        btn_login.TabIndex = 4
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(83, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 8
        Label2.Text = "Password"
        ' 
        ' btn_register
        ' 
        btn_register.BackColor = Color.Peru
        btn_register.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_register.Location = New Point(170, 131)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(113, 35)
        btn_register.TabIndex = 9
        btn_register.Text = "Register"
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaShell
        ClientSize = New Size(358, 194)
        Controls.Add(btn_register)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(txt_uname)
        Name = "Form1"
        Text = "Login"
        TransparencyKey = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_register As Button

End Class
