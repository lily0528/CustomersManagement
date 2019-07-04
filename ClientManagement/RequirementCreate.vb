Imports System.Data.OleDb

Public Class RequirementCreate
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim connection As OleDbConnection = New OleDbConnection


    Private Sub RequirementCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        dataFile = "D:\Internship\ClientManagement\ClientManagement\ClientManagement.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        connection.Open()

        Dim cmClient As New OleDbCommand("select ID, FirstName from ClientInformation", connection)
        Dim drClient As OleDbDataReader = cmClient.ExecuteReader
        'While drClient.Read
        '    Customer_ComboBox1.ValueMember = drClient("ID")
        '    Customer_ComboBox1.DisplayMember = drClient("FirstName")
        '    Customer_ComboBox1.Items.Add(drClient("ID").ToString + " " + drClient("FirstName").ToString)
        'End While
        'drClient.Close()

        Dim comboSource As New Dictionary(Of String, String)()
        While drClient.Read

            comboSource.Add(drClient("ID").ToString, drClient("FirstName").ToString)
        End While
        Customer_ComboBox1.DataSource = New BindingSource(comboSource, Nothing)
        Customer_ComboBox1.DisplayMember = "Value"
        Customer_ComboBox1.ValueMember = "Key"
        drClient.Close()

        Dim cmUser As New OleDbCommand("select ID, UserName from UserInfor", connection)
        Dim drUser As OleDbDataReader = cmUser.ExecuteReader
        While drUser.Read
            PickBy_ComboBox2.Items.Add(drUser("ID").ToString)
        End While
        drUser.Close()
        connection.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Title.Text = "" Or Description.Text = "" Then
            MsgBox("Please fill those details!")
        End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim str As String
        Dim key As String = DirectCast(Customer_ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(Customer_ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value
        If Id.Text = "" Then
            CreatedDate.Text = DateTime.Now
            str = "insert into Requirement([Title],[Description],[ClientInforemation_ID],[UserInfor_ID],[CreatedDate],[Others]) values(?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, connection)

            cmd.Parameters.Add(New OleDbParameter("Title", Title.Text))
            cmd.Parameters.Add(New OleDbParameter("Description", Description.Text))
            'cmd.Parameters.Add(New OleDbParameter("ClientInforemation_ID", Customer_ComboBox1.SelectedItem))
            cmd.Parameters.Add(New OleDbParameter("ClientInforemation_ID", key))
            cmd.Parameters.Add(New OleDbParameter("UserInfor_ID", PickBy_ComboBox2.SelectedItem))
            cmd.Parameters.Add(New OleDbParameter("CreatedDate", DateTime.Now))
            cmd.Parameters.Add(New OleDbParameter("Others", Others.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Else
            str = "UPDATE Requirement SET Title = '" & Title.Text & "', Description = '" & Description.Text & "', ClientName ='" & Customer_ComboBox1.SelectedItem & "' , PickedBy ='" & PickBy_ComboBox2.SelectedItem & "' ,UpdatedDate ='" & DateTime.Now & "'  where id=" & Id.Text & ""

            Dim cmd As OleDbCommand = New OleDbCommand(str, connection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If
        Title.Clear()
        Description.Clear()
        Customer_ComboBox1.SelectedValue = "Please Choose"
        PickBy_ComboBox2.SelectedValue = "Please Choose"
        Others.Clear()
        connection.Close()
    End Sub
End Class