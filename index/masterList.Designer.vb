<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class masterList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(masterList))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnX = New System.Windows.Forms.Button()
        Me.studentAction = New System.Windows.Forms.Label()
        Me.rvMasterList = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.masterListDataSet = New AutomatedSS.masterListDataSet()
        Me.ClassRegistrationViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassRegistrationViewTableAdapter = New AutomatedSS.masterListDataSetTableAdapters.ClassRegistrationViewTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.masterListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassRegistrationViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.btnX)
        Me.Panel1.Controls.Add(Me.studentAction)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 49)
        Me.Panel1.TabIndex = 50
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.Transparent
        Me.btnX.BackgroundImage = CType(resources.GetObject("btnX.BackgroundImage"), System.Drawing.Image)
        Me.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Location = New System.Drawing.Point(849, 14)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(23, 24)
        Me.btnX.TabIndex = 1
        Me.btnX.UseVisualStyleBackColor = False
        '
        'studentAction
        '
        Me.studentAction.AutoSize = True
        Me.studentAction.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentAction.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.studentAction.Location = New System.Drawing.Point(15, 15)
        Me.studentAction.Name = "studentAction"
        Me.studentAction.Size = New System.Drawing.Size(141, 19)
        Me.studentAction.TabIndex = 0
        Me.studentAction.Text = "Master List Report"
        '
        'rvMasterList
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClassRegistrationViewBindingSource
        Me.rvMasterList.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvMasterList.LocalReport.ReportEmbeddedResource = "AutomatedSS.masterListReport.rdlc"
        Me.rvMasterList.Location = New System.Drawing.Point(12, 67)
        Me.rvMasterList.Name = "rvMasterList"
        Me.rvMasterList.Size = New System.Drawing.Size(882, 641)
        Me.rvMasterList.TabIndex = 51
        '
        'masterListDataSet
        '
        Me.masterListDataSet.DataSetName = "masterListDataSet"
        Me.masterListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassRegistrationViewBindingSource
        '
        Me.ClassRegistrationViewBindingSource.DataMember = "ClassRegistrationView"
        Me.ClassRegistrationViewBindingSource.DataSource = Me.masterListDataSet
        '
        'ClassRegistrationViewTableAdapter
        '
        Me.ClassRegistrationViewTableAdapter.ClearBeforeFill = True
        '
        'masterList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(907, 720)
        Me.Controls.Add(Me.rvMasterList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "masterList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "masterList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.masterListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassRegistrationViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnX As Button
    Friend WithEvents studentAction As Label
    Friend WithEvents rvMasterList As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClassRegistrationViewBindingSource As BindingSource
    Friend WithEvents masterListDataSet As masterListDataSet
    Friend WithEvents ClassRegistrationViewTableAdapter As masterListDataSetTableAdapters.ClassRegistrationViewTableAdapter
End Class
