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
        btn_insert = New Button()
        dtv_books = New DataGridView()
        btn_update = New Button()
        btn_delete = New Button()
        txt_ID = New TextBox()
        txt_title = New TextBox()
        txt_quantity = New TextBox()
        txt_genre = New TextBox()
        txt_price = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(dtv_books, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_insert
        ' 
        btn_insert.BackColor = Color.BurlyWood
        btn_insert.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_insert.Location = New Point(251, 256)
        btn_insert.Name = "btn_insert"
        btn_insert.Size = New Size(75, 40)
        btn_insert.TabIndex = 2
        btn_insert.Text = "Insert"
        btn_insert.UseVisualStyleBackColor = False
        ' 
        ' dtv_books
        ' 
        dtv_books.AllowUserToResizeColumns = False
        dtv_books.AllowUserToResizeRows = False
        dtv_books.BackgroundColor = Color.Tan
        dtv_books.BorderStyle = BorderStyle.Fixed3D
        dtv_books.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        dtv_books.Location = New Point(28, 12)
        dtv_books.Name = "dtv_books"
        dtv_books.Size = New Size(541, 183)
        dtv_books.TabIndex = 3
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.BurlyWood
        btn_update.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_update.Location = New Point(128, 256)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(75, 40)
        btn_update.TabIndex = 4
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.BurlyWood
        btn_delete.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_delete.Location = New Point(371, 256)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(75, 40)
        btn_delete.TabIndex = 5
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' txt_ID
        ' 
        txt_ID.Location = New Point(512, 275)
        txt_ID.Name = "txt_ID"
        txt_ID.Size = New Size(12, 23)
        txt_ID.TabIndex = 6
        txt_ID.Visible = False
        ' 
        ' txt_title
        ' 
        txt_title.Location = New Point(28, 201)
        txt_title.Name = "txt_title"
        txt_title.Size = New Size(266, 23)
        txt_title.TabIndex = 7
        ' 
        ' txt_quantity
        ' 
        txt_quantity.Location = New Point(405, 201)
        txt_quantity.Name = "txt_quantity"
        txt_quantity.Size = New Size(77, 23)
        txt_quantity.TabIndex = 8
        ' 
        ' txt_genre
        ' 
        txt_genre.Location = New Point(299, 201)
        txt_genre.Name = "txt_genre"
        txt_genre.Size = New Size(100, 23)
        txt_genre.TabIndex = 9
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(488, 201)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(81, 23)
        txt_price.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(421, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 25)
        Label3.TabIndex = 13
        Label3.Text = "Qty"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(497, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 25)
        Label4.TabIndex = 14
        Label4.Text = "Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(311, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 25)
        Label2.TabIndex = 15
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Elephant", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(134, 224)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 25)
        Label1.TabIndex = 16
        Label1.Text = "Title"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(590, 307)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txt_price)
        Controls.Add(txt_genre)
        Controls.Add(txt_quantity)
        Controls.Add(txt_title)
        Controls.Add(txt_ID)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(dtv_books)
        Controls.Add(btn_insert)
        Name = "Form1"
        Text = "Form1"
        CType(dtv_books, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxBooks As ListBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents dtv_books As DataGridView
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
