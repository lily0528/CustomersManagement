Imports System.Data.OleDb
Imports System.Data

Public Class Login
    Dim connection As New OleDbConnection(My.Settings.ClientManagementConnectionString)
    Dim attempt As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Invalid UserName or Password!")
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New OleDbCommand("select count(*) from UserInfor where username=? and password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUserName.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                connection.Close()
                Main.Show()
                Me.Hide()
            ElseIf (attempt = 2) Then
                MsgBox("Maxinum number of attempts(5), program will be close!", MsgBoxStyle.Critical, "Error")
                Close()
            Else
                MsgBox("UserName or Passwor incorrect, please re-enter!")
                attempt += 1
                txtUserName.Clear()
                txtPassword.Clear()
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.Close()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub
End Class
