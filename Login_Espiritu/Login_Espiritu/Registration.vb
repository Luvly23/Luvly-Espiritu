Imports MySql.Data.MySqlClient

Public Class Registration
    Dim mySQLConnection = New MySqlConnection
    Dim mySQLCommand = New MySqlCommand
    Dim mySQLAdapter = New MySqlDataAdapter

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If Not ValidatePasswords(txt_password.Text, txt_repass.Text) Then
            MsgBox("Passwords do not match. Please try again.")
            Return
        End If

        Dim server_credential As String = "server=localhost;user id=root;password=;database=user_db;"
        mySQLConnection = New MySqlConnection(server_credential)
        mySQLCommand = New MySqlCommand()

        Try
            mySQLCommand.Connection = mySQLConnection
            mySQLCommand.CommandText = "INSERT INTO newuser_tbl(`Full Name`, `Username`, `Password`, `Re-type Password`) VALUES(@fullname, @username, @password, @retypepassword)"
            mySQLCommand.Parameters.AddWithValue("@fullname", txt_fname.Text)
            mySQLCommand.Parameters.AddWithValue("@username", txt_uname.Text)
            mySQLCommand.Parameters.AddWithValue("@password", txt_password.Text)
            mySQLCommand.Parameters.AddWithValue("@retypepassword", txt_repass.Text)

            mySQLConnection.Open()

            Dim isAdded As Integer = mySQLCommand.ExecuteNonQuery()

            If isAdded > 0 Then
                MsgBox("User added successfully!")
                Me.Hide()
                Form1.Show()
            Else
                MsgBox("Failed to add user.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            mySQLConnection.Close()
        End Try
    End Sub

    Private Function ValidatePasswords(password As String, retypePassword As String) As Boolean
        Return password = retypePassword
    End Function
End Class