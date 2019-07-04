Imports System.Data.OleDb
Public Class Main
    Dim connection As OleDbConnection
    Dim data As OleDbDataAdapter
    Dim dataset As New DataSet


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CustomerCreate.Show()
        CustomerCreate.MdiParent = Me
    End Sub

    Private Sub CreateToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        VisitCreate.Show()
    End Sub

    Private Sub CreateToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        CustomerCreate.Show()
        CustomerCreate.MdiParent = Me
    End Sub

    Private Sub ShowToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        CustomersList.Show()
        CustomersList.MdiParent = Me
    End Sub

    Private Sub ShowToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem1.Click
        RequirementList.Show()
        RequirementList.MdiParent = Me
    End Sub

    Private Sub EditToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim i As Integer
        Try
            i = CustomersList.DataGridView1.CurrentRow.Index
            CustomerCreate.Show()
            CustomerCreate.MdiParent = Me

            If CustomersList.DataGridView1.Item(5, i).Value = True Then
                CustomerCreate.RadioButton1.Checked = True
                CustomerCreate.RadioButton2.Checked = False
            Else
                CustomerCreate.RadioButton1.Checked = False
                CustomerCreate.RadioButton2.Checked = True
            End If

            CustomerCreate.Id.Text = CustomersList.DataGridView1.Item(0, i).Value
            CustomerCreate.FirstName.Text = CustomersList.DataGridView1.Item(1, i).Value
            CustomerCreate.LastName.Text = CustomersList.DataGridView1.Item(2, i).Value
            CustomerCreate.NickName.Text = CustomersList.DataGridView1.Item(3, i).Value
            CustomerCreate.DateTimePicker1.Value = CustomersList.DataGridView1.Item(4, i).Value

            CustomerCreate.EmailAddress.Text = CustomersList.DataGridView1.Item(6, i).Value
            CustomerCreate.Phone.Text = CustomersList.DataGridView1.Item(7, i).Value
            CustomerCreate.Address.Text = CustomersList.DataGridView1.Item(8, i).Value
            CustomerCreate.Company.Text = CustomersList.DataGridView1.Item(9, i).Value
            CustomerCreate.Position.Text = CustomersList.DataGridView1.Item(10, i).Value
            CustomerCreate.Habit.Text = CustomersList.DataGridView1.Item(11, i).Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CreateToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem1.Click
        RequirementCreate.Show()
        RequirementCreate.MdiParent = Me
    End Sub

    Private Sub EditToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Dim i As Integer
        Try
            i = RequirementList.DataGridView1.CurrentRow.Index
            RequirementCreate.Show()
            RequirementCreate.MdiParent = Me

            RequirementCreate.Id.Text = RequirementList.DataGridView1.Item(0, i).Value
            RequirementCreate.Title.Text = RequirementList.DataGridView1.Item(1, i).Value
            RequirementCreate.Description.Text = RequirementList.DataGridView1.Item(2, i).Value

            RequirementCreate.CreatedDate.Text = RequirementList.DataGridView1.Item(3, i).Value
            RequirementCreate.PickBy_ComboBox2.SelectedValue = RequirementList.DataGridView1.Item(4, i).Value
            RequirementCreate.Customer_ComboBox1.SelectedValue = RequirementList.DataGridView1.Item(5, i).Value

            RequirementCreate.Others.Text = RequirementList.DataGridView1.Item(6, i).Value

        Catch ex As Exception
            MsgBox(ex.Message)
            'todo
        End Try
    End Sub
End Class