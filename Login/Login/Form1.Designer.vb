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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        btn_signIn = New Button()
        txt_uname = New TextBox()
        txt_pass = New TextBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 39.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(118, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 71)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' btn_signIn
        ' 
        btn_signIn.BackColor = Color.DarkKhaki
        btn_signIn.Cursor = Cursors.Hand
        btn_signIn.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_signIn.Location = New Point(148, 274)
        btn_signIn.Name = "btn_signIn"
        btn_signIn.Size = New Size(124, 48)
        btn_signIn.TabIndex = 2
        btn_signIn.Text = "SIGN IN"
        btn_signIn.UseVisualStyleBackColor = False
        ' 
        ' txt_uname
        ' 
        txt_uname.BorderStyle = BorderStyle.None
        txt_uname.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_uname.ForeColor = Color.LightGray
        txt_uname.Location = New Point(78, 137)
        txt_uname.Multiline = True
        txt_uname.Name = "txt_uname"
        txt_uname.Size = New Size(317, 35)
        txt_uname.TabIndex = 3
        txt_uname.Text = "username"
        ' 
        ' txt_pass
        ' 
        txt_pass.BorderStyle = BorderStyle.None
        txt_pass.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_pass.ForeColor = Color.LightGray
        txt_pass.Location = New Point(78, 210)
        txt_pass.Multiline = True
        txt_pass.Name = "txt_pass"
        txt_pass.Size = New Size(317, 35)
        txt_pass.TabIndex = 4
        txt_pass.Text = "password"
        txt_pass.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(36, 137)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(36, 210)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(42, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(430, 362)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(txt_pass)
        Controls.Add(txt_uname)
        Controls.Add(btn_signIn)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_signIn As Button
    Friend WithEvents txt_uname As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
