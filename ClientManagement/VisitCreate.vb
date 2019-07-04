Imports System.Data.OleDb
Public Class VisitCreate
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim connection As OleDbConnection = New OleDbConnection
    Dim IfCheck As Boolean
    Private MenuStrip1 As Object

    Private Sub VistCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item As ToolStripItem In Main.MainMenuStrip.Items
            MenuStrip1.Items.Add(item)
        Next
        'VisitCreate.Controls.Add(MenuStrip1)
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        dataFile = "D:\Lily\Projects\ClientManagement\ClientManagement\ClientManagement.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        connection.Open()

        Dim cmClient As New OleDbCommand("select ID, FirstName from ClientInformation", connection)
        Dim drClient As OleDbDataReader = cmClient.ExecuteReader
        While drClient.Read
            Customer_ComboBox1.Items.Add(drClient("FirstName").ToString)
        End While
        drClient.Close()

        Dim cmUser As New OleDbCommand("select UserName from UserInfor", connection)
        Dim drUser As OleDbDataReader = cmUser.ExecuteReader
        While drUser.Read
            PickBy_ComboBox2.Items.Add(drUser("UserName").ToString)
        End While
        drUser.Close()
        connection.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Title.Text = "" Or Description.Text = "" Or Customer_ComboBox1.SelectedItem = "" Or PickBy_ComboBox2.SelectedItem = "" Then
            MsgBox("Please fill those details!")
        End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim str As String

        If Id.Text = "" Then
            CreatedDate.Text = DateTime.Now
            str = "insert into VisitedRecord([Title],[Description],[ClientName],[PickedBy],[VisitedDate],[CreatedDate],[IfValid]) values(?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, connection)

            cmd.Parameters.Add(New OleDbParameter("Title", Title.Text))
            cmd.Parameters.Add(New OleDbParameter("Description", Description.Text))
            cmd.Parameters.Add(New OleDbParameter("ClientName", Customer_ComboBox1.SelectedItem))
            cmd.Parameters.Add(New OleDbParameter("PickedBy", PickBy_ComboBox2.SelectedItem))
            cmd.Parameters.Add(New OleDbParameter("VisitedDate", DateTimePicker1.Value.ToString()))
            cmd.Parameters.Add(New OleDbParameter("CreatedDate", DateTime.Now))
            cmd.Parameters.Add(New OleDbParameter("IfValid", IfCheck))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            str = "UPDATE VisitedRecord SET Title = '" & Title.Text & "', Description = '" & Description.Text & "', ClientName ='" & Customer_ComboBox1.SelectedItem & "' , PickedBy ='" & PickBy_ComboBox2.SelectedItem & "' ,UpdatedDate ='" & DateTime.Now & "'  where id=" & Id.Text & ""

            Dim cmd As OleDbCommand = New OleDbCommand(str, connection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        Title.Clear()
        Description.Clear()
        Customer_ComboBox1.SelectedValue = "Please Choose"
        PickBy_ComboBox2.SelectedValue = "Please Choose"
        connection.Close()
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
End Class