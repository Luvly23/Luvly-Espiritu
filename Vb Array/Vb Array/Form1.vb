Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim intnum() As Integer = {1, 3, 5, 7, 9}
        'Dim strArray() As String = {"Luvly", "Kyle", "Rushi"}
        ' For Each val As String In intnum
        'MsgBox(val.ToString())
        ' Next
        'MsgBox(strArray(0).ToString)
        ' MsgBox(strArray(1).ToString)
        ' MsgBox(strArray(2).ToString)

        ' strArray(0) = "Espiritu"
        ' MsgBox(strArray(0).ToString)

        Dim Colors() As String = {"Yellow", "Blue", "Black", "Red", "Orange"}
        'Array.Sort(Colors)
        Array.Reverse(Colors)
        For Each val As String In Colors
            MsgBox(val.ToString())
        Next

    End Sub
End Class
