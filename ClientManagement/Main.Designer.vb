<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ClientInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientManagementDataSet1 = New ClientManagement.ClientManagementDataSet1()
        Me.ClientInformationTableAdapter = New ClientManagement.ClientManagementDataSet1TableAdapters.ClientInformationTableAdapter()
        Me.ClientManagementDataSet = New ClientManagement.ClientManagementDataSet()
        Me.ClientManagementDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequirementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientManagementDataSet2 = New ClientManagement.ClientManagementDataSet2()
        Me.RequirementTableAdapter = New ClientManagement.ClientManagementDataSet2TableAdapters.RequirementTableAdapter()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequirementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.ClientInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientManagementDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequirementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientManagementDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientInformationBindingSource
        '
        Me.ClientInformationBindingSource.DataMember = "ClientInformation"
        Me.ClientInformationBindingSource.DataSource = Me.ClientManagementDataSet1
        '
        'ClientManagementDataSet1
        '
        Me.ClientManagementDataSet1.DataSetName = "ClientManagementDataSet1"
        Me.ClientManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientInformationTableAdapter
        '
        Me.ClientInformationTableAdapter.ClearBeforeFill = True
        '
        'ClientManagementDataSet
        '
        Me.ClientManagementDataSet.DataSetName = "ClientManagementDataSet"
        Me.ClientManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientManagementDataSetBindingSource
        '
        Me.ClientManagementDataSetBindingSource.DataSource = Me.ClientManagementDataSet
        Me.ClientManagementDataSetBindingSource.Position = 0
        '
        'RequirementBindingSource
        '
        Me.RequirementBindingSource.DataMember = "Requirement"
        Me.RequirementBindingSource.DataSource = Me.ClientManagementDataSet2
        '
        'ClientManagementDataSet2
        '
        Me.ClientManagementDataSet2.DataSetName = "ClientManagementDataSet2"
        Me.ClientManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequirementTableAdapter
        '
        Me.RequirementTableAdapter.ClearBeforeFill = True
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem, Me.EditToolStripMenuItem, Me.ShowToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem.Text = "Create"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'RequirementToolStripMenuItem
        '
        Me.RequirementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.ShowToolStripMenuItem1})
        Me.RequirementToolStripMenuItem.Name = "RequirementToolStripMenuItem"
        Me.RequirementToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RequirementToolStripMenuItem.Text = "Requirement"
        '
        'CreateToolStripMenuItem1
        '
        Me.CreateToolStripMenuItem1.Name = "CreateToolStripMenuItem1"
        Me.CreateToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CreateToolStripMenuItem1.Text = "Create"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'ShowToolStripMenuItem1
        '
        Me.ShowToolStripMenuItem1.Name = "ShowToolStripMenuItem1"
        Me.ShowToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ShowToolStripMenuItem1.Text = "Show"
        '
        'VisitToolStripMenuItem
        '
        Me.VisitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem2, Me.EditToolStripMenuItem2, Me.ShowToolStripMenuItem2})
        Me.VisitToolStripMenuItem.Name = "VisitToolStripMenuItem"
        Me.VisitToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.VisitToolStripMenuItem.Text = "Visit"
        '
        'CreateToolStripMenuItem2
        '
        Me.CreateToolStripMenuItem2.Name = "CreateToolStripMenuItem2"
        Me.CreateToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem2.Text = "Create"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem2.Text = "Edit"
        '
        'ShowToolStripMenuItem2
        '
        Me.ShowToolStripMenuItem2.Name = "ShowToolStripMenuItem2"
        Me.ShowToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.ShowToolStripMenuItem2.Text = "Show"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportCustomersToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ExportCustomersToolStripMenuItem
        '
        Me.ExportCustomersToolStripMenuItem.Name = "ExportCustomersToolStripMenuItem"
        Me.ExportCustomersToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExportCustomersToolStripMenuItem.Text = "Export Customers"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.RequirementToolStripMenuItem, Me.VisitToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1187, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "Customers"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 619)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ClientInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientManagementDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientManagementDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequirementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientManagementDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientManagementDataSet1 As ClientManagementDataSet1
    Friend WithEvents ClientInformationBindingSource As BindingSource
    Friend WithEvents ClientInformationTableAdapter As ClientManagementDataSet1TableAdapters.ClientInformationTableAdapter
    Friend WithEvents ClientManagementDataSet As ClientManagementDataSet
    Friend WithEvents ClientManagementDataSetBindingSource As BindingSource
    Friend WithEvents ClientManagementDataSet2 As ClientManagementDataSet2
    Friend WithEvents RequirementBindingSource As BindingSource
    Friend WithEvents RequirementTableAdapter As ClientManagementDataSet2TableAdapters.RequirementTableAdapter
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequirementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VisitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
