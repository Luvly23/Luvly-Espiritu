Public Class Form1
    Function msg() As String
        Return "Hello World"
    End Function

    Function mesg() As Integer
        Return 1000
    End Function


    Function add(ByVal numOne As Integer, ByVal numtwo As Integer) As Integer
        Dim total As Integer
        total = 10 + 20
        Return total
    End Function

    Function HelloUser(ByVal name As String) As String
        Return "Goodevening " + name + "!!!!!"


    End Function

    Function FACTORIAL(ByVal NUM As Integer) As Integer
        Dim Result As Integer
        If (NUM = 1) Then
            Return 1

        Else
            Return FACTORIAL(NUM - 1) * NUM
            Return Result
        End If

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(msg)
        ' MsgBox("number:" + msg.ToString())
        '  MsgBox(add(1, 1.ToString))
        '  MsgBox(HelloUser("Luvly"))
        MsgBox(FACTORIAL(2).ToString())
    End Sub
End Class
