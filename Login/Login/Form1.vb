Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim server_credential As String = "server=localhost;user id=root;password=;database=studentsrecord"

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_signIn.Click
        Dim username As String = txt_uname.Text
        Dim password As String = txt_pass.Text


        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim query As String = "SELECT COUNT(*) FROM admin_tbl WHERE Username = @username AND Password = @password"
        Using connection As New MySqlConnection(server_credential)
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Try
                    connection.Open()
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If result > 0 Then
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.Hide()
                        Dim form2 As New Form2()
                        form2.Show()
                    Else
                        MessageBox.Show("Incorrect username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub



    Private Sub txt_uname_Enter(sender As Object, e As EventArgs) Handles txt_uname.Enter
        Dim username As String = txt_uname.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            txt_uname.Text = ""
            txt_uname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_uname_Leave(sender As Object, e As EventArgs) Handles txt_uname.Leave
        Dim username As String = txt_uname.Text
        If username.Trim() = "" Then
            txt_uname.Text = "username"
            txt_uname.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txt_pass_Enter(sender As Object, e As EventArgs) Handles txt_pass.Enter
        Dim pass As String = txt_pass.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            txt_pass.Text = ""
            txt_pass.ForeColor = Color.Black
            txt_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt_pass_Leave(sender As Object, e As EventArgs) Handles txt_pass.Leave
        Dim pass As String = txt_pass.Text
        If pass.Trim() = "" Then
            txt_pass.Text = "password"
            txt_pass.ForeColor = Color.LightGray
            txt_pass.UseSystemPasswordChar = False
        End If
    End Sub
End Class