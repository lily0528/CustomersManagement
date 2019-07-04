Imports System.Data.OleDb
Public Class CustomersList
    Private Sub CustomersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientManagementDataSet5.ClientInformation' table. You can move, or remove it, as needed.
        Me.ClientInformationTableAdapter.Fill(Me.ClientManagementDataSet5.ClientInformation)

    End Sub
End Class