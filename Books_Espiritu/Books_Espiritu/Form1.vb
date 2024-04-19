



Imports MySql.Data.MySqlClient

Public Class Form1

    Dim mySqlCon As String = "server=127.0.0.1;user=root;database=DBBOOKS;password="
    Dim mySqlConnection As New MySqlConnection(mySqlCon)
    Dim dataAdapter As New MySqlDataAdapter()
    Dim dataSet As New DataSet()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            mySqlConnection.Open()
            LoadData()
            dtv_books.DataSource = dataSet.Tables(0)

            AddHandler dtv_books.SelectionChanged, AddressOf dtv_books_SelectionChanged

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If mySqlConnection.State = ConnectionState.Open Then
                mySqlConnection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadData()

        Dim query As String = "SELECT  ID, Title, Genre, Quantity, Price FROM book_tbl"
        Dim command As New MySqlCommand(query, mySqlConnection)

        dataAdapter.SelectCommand = command
        dataSet.Clear()
        dataAdapter.Fill(dataSet)

    End Sub

    Private Sub dtv_books_SelectionChanged(sender As Object, e As EventArgs)

        If dtv_books.SelectedRows.Count > 0 Then


            Dim selectedRow As DataGridViewRow = dtv_books.SelectedRows(0)


            txt_title.Text = dtv_books.CurrentRow.Cells(1).Value
            txt_genre.Text = dtv_books.CurrentRow.Cells(2).Value
            txt_quantity.Text = dtv_books.CurrentRow.Cells(3).Value
            txt_price.Text = dtv_books.CurrentRow.Cells(4).Value
        End If
    End Sub

    Private Function ExecuteCommand(ByVal query As String) As Boolean
        Try
            mySqlConnection.Open()
            Dim command As New MySqlCommand(query, mySqlConnection)
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        Finally
            If mySqlConnection.State = ConnectionState.Open Then
                mySqlConnection.Close()
            End If
        End Try
    End Function

    Private Sub ClearTextBoxes()
        txt_title.Clear()
        txt_genre.Clear()
        txt_quantity.Clear()
        txt_price.Clear()
    End Sub
    Private Sub InsertRecord(ByVal title As String, ByVal genre As String, ByVal quantity As Integer, ByVal price As Decimal)
        Dim query As String = "INSERT INTO book_tbl (Title, Genre, Quantity, Price) VALUES ('" & title & "', '" & genre & "', " & quantity & ", " & price & ")"
        ExecuteCommand(query)
        dataSet.Clear()
        LoadData()
        ClearTextBoxes()
    End Sub

    Private Sub UpdateRecord(ByVal id As Integer, ByVal title As String, ByVal genre As String, ByVal quantity As Integer, ByVal price As Decimal)
        Dim query As String = "UPDATE book_tbl SET Title = '" & title & "', Genre = '" & genre & "', Quantity = " & quantity & ", Price = " & price & " WHERE ID = " & id
        ExecuteCommand(query)
        dataSet.Clear()
        LoadData()
        ClearTextBoxes()
    End Sub


    Private Sub DeleteRecord(ByVal id As Integer)
        Dim query As String = "DELETE FROM book_tbl WHERE ID = " & id
        ExecuteCommand(query)
        dataSet.Clear()
        LoadData()
        ClearTextBoxes()
    End Sub



    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        InsertRecord(txt_title.Text, txt_genre.Text, Convert.ToInt32(txt_quantity.Text), Convert.ToDecimal(txt_price.Text))
    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If dtv_books.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dtv_books.CurrentRow.Cells(0).Value)
            UpdateRecord(id, txt_title.Text, txt_genre.Text, Convert.ToInt32(txt_quantity.Text), Convert.ToDecimal(txt_price.Text))
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dtv_books.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(dtv_books.CurrentRow.Cells(0).Value)
            DeleteRecord(id)
        End If
    End Sub

End Class
