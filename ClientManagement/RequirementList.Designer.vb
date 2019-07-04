<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequirementList
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientManagementDataSet6 = New ClientManagement.ClientManagementDataSet6()
        Me.RequirementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequirementTableAdapter = New ClientManagement.ClientManagementDataSet6TableAdapters.RequirementTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientInforemationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserInforIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientManagementDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequirementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.CreatedDateDataGridViewTextBoxColumn, Me.UpdatedDateDataGridViewTextBoxColumn, Me.ClientInforemationIDDataGridViewTextBoxColumn, Me.UserInforIDDataGridViewTextBoxColumn, Me.OthersDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RequirementBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(131, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(988, 463)
        Me.DataGridView1.TabIndex = 0
        '
        'ClientManagementDataSet6
        '
        Me.ClientManagementDataSet6.DataSetName = "ClientManagementDataSet6"
        Me.ClientManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequirementBindingSource
        '
        Me.RequirementBindingSource.DataMember = "Requirement"
        Me.RequirementBindingSource.DataSource = Me.ClientManagementDataSet6
        '
        'RequirementTableAdapter
        '
        Me.RequirementTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'CreatedDateDataGridViewTextBoxColumn
        '
        Me.CreatedDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate"
        Me.CreatedDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate"
        Me.CreatedDateDataGridViewTextBoxColumn.Name = "CreatedDateDataGridViewTextBoxColumn"
        '
        'UpdatedDateDataGridViewTextBoxColumn
        '
        Me.UpdatedDateDataGridViewTextBoxColumn.DataPropertyName = "UpdatedDate"
        Me.UpdatedDateDataGridViewTextBoxColumn.HeaderText = "UpdatedDate"
        Me.UpdatedDateDataGridViewTextBoxColumn.Name = "UpdatedDateDataGridViewTextBoxColumn"
        '
        'ClientInforemationIDDataGridViewTextBoxColumn
        '
        Me.ClientInforemationIDDataGridViewTextBoxColumn.DataPropertyName = "ClientInforemation_ID"
        Me.ClientInforemationIDDataGridViewTextBoxColumn.HeaderText = "ClientInforemation_ID"
        Me.ClientInforemationIDDataGridViewTextBoxColumn.Name = "ClientInforemationIDDataGridViewTextBoxColumn"
        '
        'UserInforIDDataGridViewTextBoxColumn
        '
        Me.UserInforIDDataGridViewTextBoxColumn.DataPropertyName = "UserInfor_ID"
        Me.UserInforIDDataGridViewTextBoxColumn.HeaderText = "UserInfor_ID"
        Me.UserInforIDDataGridViewTextBoxColumn.Name = "UserInforIDDataGridViewTextBoxColumn"
        '
        'OthersDataGridViewTextBoxColumn
        '
        Me.OthersDataGridViewTextBoxColumn.DataPropertyName = "Others"
        Me.OthersDataGridViewTextBoxColumn.HeaderText = "Others"
        Me.OthersDataGridViewTextBoxColumn.Name = "OthersDataGridViewTextBoxColumn"
        '
        'RequirementList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1257, 680)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "RequirementList"
        Me.Text = "RequirementList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientManagementDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequirementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClientManagementDataSet6 As ClientManagementDataSet6
    Friend WithEvents RequirementBindingSource As BindingSource
    Friend WithEvents RequirementTableAdapter As ClientManagementDataSet6TableAdapters.RequirementTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdatedDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientInforemationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserInforIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
