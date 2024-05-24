Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_records.CellContentClick

    End Sub

    Private Sub dgv_records_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_records.CellClick

        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgv_records.Rows(e.RowIndex)
            txt_fname.Text = selectedRow.Cells("FIRSTNAME").Value.ToString()
            txt_lname.Text = selectedRow.Cells("LASTNAME").Value.ToString()
            txt_gender.Text = selectedRow.Cells("GENDER").Value.ToString()
            txt_age.Text = selectedRow.Cells("AGE").Value.ToString()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim server_credential = "server=localhost;user id=root;password=;database=studentsrecord"

        Using mySQLCon As New MySqlConnection(server_credential)
            Using mySQLCommand As New MySqlCommand
                With mySQLCommand
                    .Connection = mySQLCon
                    .CommandText = "INSERT INTO member (FIRSTNAME, LASTNAME, GENDER, AGE) VALUES (@FIRSTNAME, @LASTNAME, @GENDER, @AGE)"

                    .Parameters.AddWithValue("@FIRSTNAME", txt_fname.Text)
                    .Parameters.AddWithValue("@LASTNAME", txt_lname.Text)
                    .Parameters.AddWithValue("@GENDER", txt_gender.Text)
                    .Parameters.AddWithValue("@AGE", txt_age.Text)
                End With

                Try
                    mySQLCon.Open()
                    mySQLCommand.ExecuteNonQuery()
                    MessageBox.Show("New student added successfully!")

                    txt_fname.Text = ""
                    txt_lname.Text = ""
                    txt_gender.Text = ""
                    txt_age.Text = ""

                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    mySQLCon.Close()
                End Try
            End Using
        End Using


        btn_browse_Click(sender, e)
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim server_credential = "server=localhost;user id=root;password=;database=studentsrecord"

        Using mySQLConnection As New MySqlConnection(server_credential)
            Using mySQLCommands As New MySqlCommand
                Dim mySQLAdapter As New MySqlDataAdapter
                Dim mySQLTable As New DataTable

                Try
                    mySQLConnection.Open()
                    mySQLCommands.Connection = mySQLConnection
                    mySQLCommands.CommandText = "SELECT ID AS 'STUDENT ID', FIRSTNAME AS 'FIRSTNAME', LASTNAME AS 'LASTNAME', GENDER AS 'GENDER', AGE AS 'AGE' FROM member"
                    mySQLAdapter.SelectCommand = mySQLCommands
                    mySQLAdapter.Fill(mySQLTable)
                    dgv_records.DataSource = mySQLTable
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                Finally
                    mySQLConnection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If dgv_records.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgv_records.SelectedRows(0)
            Dim studentID As Integer = selectedRow.Cells("STUDENT ID").Value

            Dim server_credential = "server=localhost;user id=root;password=;database=studentsrecord"

            Using mySQLCon As New MySqlConnection(server_credential)
                Using mySQLCommand As New MySqlCommand
                    With mySQLCommand
                        .Connection = mySQLCon
                        .CommandText = "UPDATE member SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, GENDER = @GENDER, AGE = @AGE WHERE ID = @ID"
                        .Parameters.AddWithValue("@ID", studentID)
                        .Parameters.AddWithValue("@FIRSTNAME", txt_fname.Text)
                        .Parameters.AddWithValue("@LASTNAME", txt_lname.Text)
                        .Parameters.AddWithValue("@GENDER", txt_gender.Text)
                        .Parameters.AddWithValue("@AGE", txt_age.Text)
                    End With

                    Try
                        mySQLCon.Open()
                        mySQLCommand.ExecuteNonQuery()
                        MessageBox.Show("Student record updated successfully!")

                        txt_fname.Text = ""
                        txt_lname.Text = ""
                        txt_gender.Text = ""
                        txt_age.Text = ""


                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message)
                    Finally
                        mySQLCon.Close()
                    End Try
                End Using
            End Using


            btn_browse_Click(sender, e)
        Else
            MessageBox.Show("Please select a student record to update.")
        End If
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If dgv_records.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgv_records.SelectedRows(0)
            Dim studentID As Integer = selectedRow.Cells("STUDENT ID").Value

            Dim server_credential = "server=localhost;user id=root;password=;database=studentsrecord"

            Using mySQLCon As New MySqlConnection(server_credential)
                Using mySQLCommand As New MySqlCommand
                    With mySQLCommand
                        .Connection = mySQLCon
                        .CommandText = "DELETE FROM member WHERE ID = @ID"
                        .Parameters.AddWithValue("@ID", studentID)
                    End With

                    Try
                        mySQLCon.Open()
                        mySQLCommand.ExecuteNonQuery()
                        MessageBox.Show("Student record removed successfully!")

                        txt_fname.Text = ""
                        txt_lname.Text = ""
                        txt_gender.Text = ""
                        txt_age.Text = ""

                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message)
                    Finally
                        mySQLCon.Close()
                    End Try
                End Using
            End Using


            btn_browse_Click(sender, e)
        Else
            MessageBox.Show("Please select a student record to remove.")
        End If
    End Sub


    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim searchText As String = txt_search.Text.Trim().ToLower()

        If String.IsNullOrWhiteSpace(searchText) Then
            MessageBox.Show("Please enter a search term.")
            Return
        End If

        Dim server_credential = "server=localhost;user id=root;password=;database=studentsrecord"

        Using mySQLConnection As New MySqlConnection(server_credential)
            Using mySQLCommands As New MySqlCommand
                Dim mySQLAdapter As New MySqlDataAdapter
                Dim mySQLTable As New DataTable

                Try
                    mySQLConnection.Open()
                    mySQLCommands.Connection = mySQLConnection
                    ' Use LIKE operator to perform a case-insensitive search across multiple columns
                    mySQLCommands.CommandText = "SELECT ID AS 'STUDENT ID', FIRSTNAME AS 'FIRSTNAME', LASTNAME AS 'LASTNAME', GENDER AS 'GENDER', AGE AS 'AGE' FROM member " &
                                                "WHERE LOWER(ID) LIKE @searchText OR LOWER(FIRSTNAME) LIKE @searchText OR LOWER(LASTNAME) LIKE @searchText OR LOWER(GENDER) LIKE @searchText OR LOWER(AGE) LIKE @searchText"
                    mySQLCommands.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                    mySQLAdapter.SelectCommand = mySQLCommands
                    mySQLAdapter.Fill(mySQLTable)

                    If mySQLTable.Rows.Count > 0 Then
                        dgv_records.DataSource = mySQLTable
                    Else
                        MessageBox.Show("No matching records found.")
                        dgv_records.DataSource = Nothing
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                Finally
                    mySQLConnection.Close()
                End Try
            End Using
        End Using
    End Sub

End Class
