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
        btn_browse = New Button()
        btn_update = New Button()
        btn_search = New Button()
        btn_remove = New Button()
        dgv_records = New DataGridView()
        btn_new = New Button()
        txt_age = New TextBox()
        txt_gender = New TextBox()
        txt_lname = New TextBox()
        txt_fname = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txt_search = New TextBox()
        CType(dgv_records, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_browse
        ' 
        btn_browse.BackColor = Color.DarkKhaki
        btn_browse.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_browse.Location = New Point(956, 104)
        btn_browse.Name = "btn_browse"
        btn_browse.Size = New Size(85, 35)
        btn_browse.TabIndex = 41
        btn_browse.Text = "BROWSE"
        btn_browse.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.DarkKhaki
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_update.Location = New Point(293, 386)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(86, 35)
        btn_update.TabIndex = 40
        btn_update.Text = "UPDATE"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_search
        ' 
        btn_search.BackColor = Color.DarkKhaki
        btn_search.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_search.Location = New Point(511, 103)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(86, 35)
        btn_search.TabIndex = 39
        btn_search.Text = "SEARCH"
        btn_search.UseVisualStyleBackColor = False
        ' 
        ' btn_remove
        ' 
        btn_remove.BackColor = Color.DarkKhaki
        btn_remove.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_remove.Location = New Point(401, 386)
        btn_remove.Name = "btn_remove"
        btn_remove.Size = New Size(85, 35)
        btn_remove.TabIndex = 38
        btn_remove.Text = "REMOVE"
        btn_remove.UseVisualStyleBackColor = False
        ' 
        ' dgv_records
        ' 
        dgv_records.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_records.Location = New Point(511, 145)
        dgv_records.Name = "dgv_records"
        dgv_records.Size = New Size(536, 276)
        dgv_records.TabIndex = 37
        ' 
        ' btn_new
        ' 
        btn_new.BackColor = Color.DarkKhaki
        btn_new.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_new.Location = New Point(187, 386)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(86, 35)
        btn_new.TabIndex = 36
        btn_new.Text = "NEW"
        btn_new.UseVisualStyleBackColor = False
        ' 
        ' txt_age
        ' 
        txt_age.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_age.Location = New Point(187, 328)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(299, 43)
        txt_age.TabIndex = 34
        ' 
        ' txt_gender
        ' 
        txt_gender.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_gender.Location = New Point(187, 271)
        txt_gender.Name = "txt_gender"
        txt_gender.Size = New Size(299, 43)
        txt_gender.TabIndex = 33
        ' 
        ' txt_lname
        ' 
        txt_lname.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_lname.Location = New Point(187, 209)
        txt_lname.Name = "txt_lname"
        txt_lname.Size = New Size(299, 43)
        txt_lname.TabIndex = 32
        ' 
        ' txt_fname
        ' 
        txt_fname.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_fname.Location = New Point(187, 149)
        txt_fname.Name = "txt_fname"
        txt_fname.Size = New Size(299, 43)
        txt_fname.TabIndex = 31
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(19, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 37)
        Label6.TabIndex = 30
        Label6.Text = "LASTNAME:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(51, 271)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 37)
        Label5.TabIndex = 29
        Label5.Text = "GENDER:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(102, 331)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 37)
        Label4.TabIndex = 28
        Label4.Text = "AGE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(17, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 37)
        Label2.TabIndex = 26
        Label2.Text = "FIRSTNAME:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(102, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(865, 86)
        Label1.TabIndex = 25
        Label1.Text = "STUDENTS RECORD SYSTEM"
        ' 
        ' txt_search
        ' 
        txt_search.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_search.Location = New Point(604, 105)
        txt_search.Multiline = True
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(293, 33)
        txt_search.TabIndex = 42
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(1073, 444)
        Controls.Add(txt_search)
        Controls.Add(btn_browse)
        Controls.Add(btn_update)
        Controls.Add(btn_search)
        Controls.Add(btn_remove)
        Controls.Add(dgv_records)
        Controls.Add(btn_new)
        Controls.Add(txt_age)
        Controls.Add(txt_gender)
        Controls.Add(txt_lname)
        Controls.Add(txt_fname)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(dgv_records, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_browse As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents dgv_records As DataGridView
    Friend WithEvents btn_new As Button
    Friend WithEvents txt_age As TextBox
    Friend WithEvents txt_gender As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
End Class
