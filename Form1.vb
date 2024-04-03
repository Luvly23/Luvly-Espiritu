Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Text.RegularExpressions

Public Class Form1



    Private Sub txt_fname_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_fname.KeyUp
        ErrorProvider1.SetError(txt_fname, String.Empty)
        If Not String.IsNullOrEmpty(txt_fname.Text.Trim) Then
            ErrorProvider2.SetError(txt_fname, "Valid")
        Else
            ErrorProvider2.SetError(txt_fname, String.Empty)
        End If

    End Sub

    Private Sub txt_mname_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_mname.KeyUp
        ErrorProvider1.SetError(txt_mname, String.Empty)
        If Not String.IsNullOrEmpty(txt_mname.Text.Trim) Then
            ErrorProvider2.SetError(txt_mname, "Valid")
        Else
            ErrorProvider2.SetError(txt_mname, String.Empty)
        End If
    End Sub

    Private Sub txt_lname_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_lname.KeyUp
        ErrorProvider1.SetError(txt_fname, String.Empty)
        If Not String.IsNullOrEmpty(txt_lname.Text.Trim) Then
            ErrorProvider2.SetError(txt_lname, "Valid")
        Else
            ErrorProvider2.SetError(txt_lname, String.Empty)
        End If
    End Sub

    Private Sub txt_address_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_address.KeyUp
        ErrorProvider1.SetError(txt_fname, String.Empty)
        If Not String.IsNullOrEmpty(txt_address.Text.Trim) Then
            ErrorProvider2.SetError(txt_address, "Valid")
        Else
            ErrorProvider2.SetError(txt_address, String.Empty)
        End If
    End Sub

    Private Sub txt_age_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_age.KeyPress

        e.Handled = True

    End Sub






    Private Sub txt_fname_Leave(sender As Object, e As EventArgs) Handles txt_fname.Leave
        Dim strNamePattern As String = "^[a-zA-Z\s]+$"
        Dim reName As New Regex(strNamePattern)

        If Not reName.IsMatch(txt_fname.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            txt_fname.Select()
        End If

    End Sub

    Private Sub txt_mname_Leave(sender As Object, e As EventArgs) Handles txt_mname.Leave
        Dim strNamePattern As String = "^[a-zA-Z\s]+$"
        Dim reName As New Regex(strNamePattern)

        If Not reName.IsMatch(txt_mname.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            txt_mname.Select()
        End If
    End Sub

    Private Sub txt_lname_Leave(sender As Object, e As EventArgs) Handles txt_lname.Leave
        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname)


        If Not reSurname.IsMatch(txt_lname.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")
            txt_lname.Focus()
            txt_lname.Clear()
        End If
    End Sub

    Private Sub txt_age_Leave(sender As Object, e As EventArgs) Handles txt_age.Leave
        Dim age As Integer
        If Integer.TryParse(txt_age.Text, age) Then
            If age < 0 Or age > 100 Then
                MessageBox.Show("Age must be a number between 0 and 100.")
                txt_age.Select()
            End If
        Else
            MessageBox.Show("Age must be a valid number.")
            txt_age.Select()
        End If
    End Sub


    Private Sub dtp_birthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_birthdate.ValueChanged
        Dim selectedDate As Date = dtp_birthdate.Value
        Dim currentDate As Date = Date.Today
        Dim age As Integer = currentDate.Year - selectedDate.Year
        If currentDate < selectedDate.AddYears(age) Then
            age -= 1
            txt_age.Text = age.ToString()

        End If

    End Sub


    Private Sub chk_noMiddleName_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Nomname.CheckedChanged
        txt_mname.Enabled = Not chk_Nomname.Checked
        If chk_Nomname.Checked Then
            txt_mname.Text = ""
        End If
    End Sub



    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        If ValidateForm() Then

            RegisterUser()
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Function ValidateForm() As Boolean

        If String.IsNullOrEmpty(txt_fname.Text) OrElse
    String.IsNullOrEmpty(txt_lname.Text) OrElse
    String.IsNullOrEmpty(txt_address.Text) OrElse
            String.IsNullOrEmpty(txt_age.Text) OrElse
            String.IsNullOrEmpty(txt_address.Text) Then

            Return False

        End If

        Dim age As Integer
        If Not Integer.TryParse(txt_age.Text, age) OrElse age <= 0 Then
            Return False
        End If

        Return True
    End Function


    Private Sub RegisterUser()
        Dim middleName As String = If(chk_NomName.Checked, "No middle name", txt_mname.Text)
        Dim userInfo As String = $"First Name: {txt_fname.Text}{Environment.NewLine}" &
     $"Middle Name: {txt_mname.Text}{Environment.NewLine}" &
     $"Last Name: {txt_lname.Text}{Environment.NewLine}" &
     $"Age: {txt_age.Text}{Environment.NewLine}" &
     $"Birthdate: {dtp_birthdate.Value.ToShortDateString()}{Environment.NewLine}" &
     $"Address: {txt_address.Text}{Environment.NewLine}"

        MessageBox.Show(userInfo, "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class
