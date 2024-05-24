Imports MySql.Data.MySqlClient
Public Class Form1
    Dim mySQLConnection As MySqlConnection
    Dim mySQLCommand As MySqlCommand
    Dim string_query As String

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim server_credential As String = "server=localhost;user id=root;password=;database=user_db;"
        mySQLConnection = New MySqlConnection(server_credential)

        Try
            mySQLConnection.Open()
            string_query = "SELECT * FROM user_tbl WHERE username=@username AND password=@password"
            mySQLCommand = New MySqlCommand(string_query, mySQLConnection)
            mySQLCommand.Parameters.AddWithValue("@username", "admin")
            mySQLCommand.Parameters.AddWithValue("@password", "1234")

            Dim result As Object = mySQLCommand.ExecuteScalar()

            If result IsNot Nothing Then
                MsgBox("Welcome to LOGIN ACTIVITY!")
            Else
                MsgBox("Invalid Username or Password!")
            End If

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            If mySQLConnection.State = ConnectionState.Open Then
                mySQLConnection.Close()
            End If
        End Try
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Me.Hide()
        Registration.Show()
    End Sub
End Class
