Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions

Public Class CustomerCreate
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim connection As OleDbConnection = New OleDbConnection
    Dim IfCheck As Boolean



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FirstName.Text = "" Or LastName.Text = "" Or EmailAddress.Text = "" Or Address.Text = "" Or Phone.Text = "" Then
            MsgBox("Please fill those details!")
        End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Dim str As String
        If Id.Text = "" Then
            str = "insert into ClientInformation([FirstName],[LastName],[NickName],[BirthDay],[Gender],[Email],[Phone],[Address],[Company],[Position],[Habit]) values(?,?,?,?,?,?,?,?,?,?,?)"

            Dim cmd As OleDbCommand = New OleDbCommand(str, connection)

            cmd.Parameters.Add(New OleDbParameter("FirstName", FirstName.Text))
            cmd.Parameters.Add(New OleDbParameter("LastName", LastName.Text))
            cmd.Parameters.Add(New OleDbParameter("NickName", NickName.Text))
            cmd.Parameters.Add(New OleDbParameter("BirthDay", DateTimePicker1.Value))
            cmd.Parameters.Add(New OleDbParameter("Gender", IfCheck))
            cmd.Parameters.Add(New OleDbParameter("Email", EmailAddress.Text))
            cmd.Parameters.Add(New OleDbParameter("Phone", Phone.Text))
            cmd.Parameters.Add(New OleDbParameter("Address", Address.Text))
            cmd.Parameters.Add(New OleDbParameter("Company", Company.Text))
            cmd.Parameters.Add(New OleDbParameter("Position", Position.Text))
            cmd.Parameters.Add(New OleDbParameter("Habit", Habit.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            str = "UPDATE ClientInformation SET FirstName = '" & FirstName.Text & "', LastName = '" & LastName.Text & "', NickName ='" & NickName.Text & "' , BirthDay ='" & DateTimePicker1.Value & "' ,Email ='" & EmailAddress.Text & "' , Phone ='" & Phone.Text & "', Address ='" & Address.Text & "', Company ='" & Company.Text & "' where id=" & Id.Text & ""
            ', Position ='" & Position.Text & "', Habit='" & Habit.Text & "'
            Dim cmd As OleDbCommand = New OleDbCommand(str, connection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        Try
            connection.Close()
            FirstName.Clear()
            LastName.Clear()
            NickName.Clear()
            EmailAddress.Clear()
            Phone.Clear()
            Address.Clear()
            Company.Clear()
            Position.Clear()
            Habit.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        dataFile = "D:\Internship\ClientManagement\ClientManagement\ClientManagement.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        connection.Open()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            IfCheck = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            IfCheck = 0
        End If
    End Sub

    Private Sub DateTimePicker1_Leave(sender As Object, e As EventArgs) Handles DateTimePicker1.Leave
        Dim thisYear As Integer = DateTime.Now.Year
        Dim yourYear As Integer = DateTimePicker1.Value.Year
        If thisYear - yourYear < 18 Then
            MessageBox.Show("Age range must be 18 and above!")
        End If
    End Sub

    'Validate the Email Address
    Private Sub EmailAddress_Leave(sender As Object, e As EventArgs) Handles EmailAddress.Leave
        Dim Email As Boolean
        Email = Regex.IsMatch(EmailAddress.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", RegexOptions.IgnoreCase)
        If Not Email Then
            MsgBox("E-mail address is invalid!")
            EmailAddress.Clear()
            EmailAddress.Focus()
        End If
    End Sub

    'Validate the phone field
    Private Sub Phone_Leave(sender As Object, e As EventArgs) Handles Phone.Leave
        If Not IsPhoneNumberValid(Phone.Text) Then
            MessageBox.Show("Please Enter Phone Number!")
            Phone.Clear()
            Phone.Focus()
        End If
    End Sub

    Private Function IsPhoneNumberValid(ByVal Number As String) As Boolean
        Dim PhoneValid As Boolean
        Dim PhoneNumber As String = "^[1-9]\d{2}-[1-9]\d{2}-\d{4}$"
        Dim ChekPhone As New Regex(PhoneNumber)
        If Not String.IsNullOrEmpty(Number) Then

            PhoneValid = ChekPhone.IsMatch(Number)
        Else
            PhoneValid = False

        End If

        Return PhoneValid
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class