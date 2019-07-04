Public Class RequirementList
    Private Sub RequirementList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientManagementDataSet6.Requirement' table. You can move, or remove it, as needed.
        Me.RequirementTableAdapter.Fill(Me.ClientManagementDataSet6.Requirement)

    End Sub
End Class