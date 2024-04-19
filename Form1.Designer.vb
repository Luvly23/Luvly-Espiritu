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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txt_fname = New TextBox()
        txt_lname = New TextBox()
        txt_age = New TextBox()
        txt_address = New TextBox()
        btn_signup = New Button()
        txt_mname = New TextBox()
        dtp_birthdate = New DateTimePicker()
        lbl_fname = New Label()
        lbl_mname = New Label()
        lbl_lname = New Label()
        lbl_age = New Label()
        lbl_address = New Label()
        lbl_birthdate = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        chk_Nomname = New CheckBox()
        lbl_image = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_fname
        ' 
        txt_fname.Location = New Point(283, 62)
        txt_fname.Name = "txt_fname"
        txt_fname.Size = New Size(149, 23)
        txt_fname.TabIndex = 0
        ' 
        ' txt_lname
        ' 
        txt_lname.Location = New Point(283, 201)
        txt_lname.Name = "txt_lname"
        txt_lname.Size = New Size(149, 23)
        txt_lname.TabIndex = 1
        ' 
        ' txt_age
        ' 
        txt_age.Location = New Point(398, 254)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(34, 23)
        txt_age.TabIndex = 2
        ' 
        ' txt_address
        ' 
        txt_address.Location = New Point(284, 316)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(148, 23)
        txt_address.TabIndex = 3
        ' 
        ' btn_signup
        ' 
        btn_signup.BackColor = Color.Blue
        btn_signup.Font = New Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_signup.ForeColor = SystemColors.ControlLightLight
        btn_signup.Location = New Point(308, 353)
        btn_signup.Name = "btn_signup"
        btn_signup.Size = New Size(92, 60)
        btn_signup.TabIndex = 5
        btn_signup.Text = "Signup"
        btn_signup.UseVisualStyleBackColor = False
        ' 
        ' txt_mname
        ' 
        txt_mname.Location = New Point(283, 124)
        txt_mname.Name = "txt_mname"
        txt_mname.Size = New Size(149, 23)
        txt_mname.TabIndex = 6
        ' 
        ' dtp_birthdate
        ' 
        dtp_birthdate.CalendarMonthBackground = Color.Thistle
        dtp_birthdate.CalendarTrailingForeColor = Color.IndianRed
        dtp_birthdate.Format = DateTimePickerFormat.Short
        ErrorProvider2.SetIconAlignment(dtp_birthdate, ErrorIconAlignment.TopLeft)
        ErrorProvider1.SetIconAlignment(dtp_birthdate, ErrorIconAlignment.TopRight)
        dtp_birthdate.Location = New Point(283, 254)
        dtp_birthdate.Name = "dtp_birthdate"
        dtp_birthdate.Size = New Size(100, 23)
        dtp_birthdate.TabIndex = 7
        dtp_birthdate.Value = New Date(2024, 3, 29, 18, 34, 0, 0)
        ' 
        ' lbl_fname
        ' 
        lbl_fname.AutoSize = True
        lbl_fname.Location = New Point(283, 44)
        lbl_fname.Name = "lbl_fname"
        lbl_fname.Size = New Size(64, 15)
        lbl_fname.TabIndex = 8
        lbl_fname.Text = "First Name"
        ' 
        ' lbl_mname
        ' 
        lbl_mname.AutoSize = True
        lbl_mname.Location = New Point(283, 106)
        lbl_mname.Name = "lbl_mname"
        lbl_mname.Size = New Size(79, 15)
        lbl_mname.TabIndex = 9
        lbl_mname.Text = "Middle Name"
        ' 
        ' lbl_lname
        ' 
        lbl_lname.AutoSize = True
        lbl_lname.Location = New Point(284, 183)
        lbl_lname.Name = "lbl_lname"
        lbl_lname.Size = New Size(63, 15)
        lbl_lname.TabIndex = 10
        lbl_lname.Text = "Last Name"
        ' 
        ' lbl_age
        ' 
        lbl_age.AutoSize = True
        lbl_age.Location = New Point(398, 236)
        lbl_age.Name = "lbl_age"
        lbl_age.Size = New Size(28, 15)
        lbl_age.TabIndex = 11
        lbl_age.Text = "Age"
        ' 
        ' lbl_address
        ' 
        lbl_address.AutoSize = True
        lbl_address.Location = New Point(283, 298)
        lbl_address.Name = "lbl_address"
        lbl_address.Size = New Size(49, 15)
        lbl_address.TabIndex = 12
        lbl_address.Text = "Address"
        ' 
        ' lbl_birthdate
        ' 
        lbl_birthdate.AutoSize = True
        lbl_birthdate.Location = New Point(283, 236)
        lbl_birthdate.Name = "lbl_birthdate"
        lbl_birthdate.Size = New Size(59, 15)
        lbl_birthdate.TabIndex = 14
        lbl_birthdate.Text = "Birth Date"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ErrorProvider2.Icon = CType(resources.GetObject("ErrorProvider2.Icon"), Icon)
        ' 
        ' chk_Nomname
        ' 
        chk_Nomname.AutoSize = True
        chk_Nomname.Location = New Point(283, 150)
        chk_Nomname.Name = "chk_Nomname"
        chk_Nomname.Size = New Size(117, 19)
        chk_Nomname.TabIndex = 15
        chk_Nomname.Text = "No Middle Name"
        chk_Nomname.UseVisualStyleBackColor = True
        ' 
        ' lbl_image
        ' 
        lbl_image.BorderStyle = BorderStyle.Fixed3D
        lbl_image.Image = My.Resources.Resources.signup
        lbl_image.Location = New Point(3, 47)
        lbl_image.Name = "lbl_image"
        lbl_image.Size = New Size(264, 366)
        lbl_image.TabIndex = 16
        lbl_image.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Azure
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(429, 41)
        Panel1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(87, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 34)
        Label1.TabIndex = 0
        Label1.Text = "Registration Info"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(476, 420)
        Controls.Add(Panel1)
        Controls.Add(lbl_image)
        Controls.Add(chk_Nomname)
        Controls.Add(lbl_birthdate)
        Controls.Add(lbl_address)
        Controls.Add(lbl_age)
        Controls.Add(lbl_lname)
        Controls.Add(lbl_mname)
        Controls.Add(lbl_fname)
        Controls.Add(dtp_birthdate)
        Controls.Add(txt_mname)
        Controls.Add(btn_signup)
        Controls.Add(txt_address)
        Controls.Add(txt_age)
        Controls.Add(txt_lname)
        Controls.Add(txt_fname)
        Name = "Form1"
        Text = "Registration Form"
        WindowState = FormWindowState.Minimized
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_age As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents btn_signup As Button
    Friend WithEvents txt_mname As TextBox
    Friend WithEvents dtp_birthdate As DateTimePicker
    Friend WithEvents lbl_fname As Label
    Friend WithEvents lbl_mname As Label
    Friend WithEvents lbl_lname As Label
    Friend WithEvents lbl_age As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_birthdate As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents chk_Nomname As CheckBox
    Friend WithEvents lbl_image As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label

End Class
