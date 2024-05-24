<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        txt_fname = New TextBox()
        txt_uname = New TextBox()
        txt_password = New TextBox()
        btn_register = New Button()
        txt_repass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txt_fname
        ' 
        txt_fname.Location = New Point(51, 35)
        txt_fname.Name = "txt_fname"
        txt_fname.Size = New Size(164, 23)
        txt_fname.TabIndex = 0
        ' 
        ' txt_uname
        ' 
        txt_uname.Location = New Point(51, 79)
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(164, 23)
        txt_uname.TabIndex = 1
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(51, 123)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(164, 23)
        txt_password.TabIndex = 2
        ' 
        ' btn_register
        ' 
        btn_register.BackColor = Color.PeachPuff
        btn_register.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_register.Location = New Point(51, 196)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(85, 31)
        btn_register.TabIndex = 3
        btn_register.Text = "Register"
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' txt_repass
        ' 
        txt_repass.Location = New Point(51, 167)
        txt_repass.Name = "txt_repass"
        txt_repass.Size = New Size(164, 23)
        txt_repass.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 5
        Label1.Text = "Full Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 6
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 8
        Label4.Text = "Re-type Password"
        ' 
        ' Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(261, 249)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_repass)
        Controls.Add(btn_register)
        Controls.Add(txt_password)
        Controls.Add(txt_uname)
        Controls.Add(txt_fname)
        Name = "Registration"
        Text = "Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_register As Button
    Friend WithEvents txt_repass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
