<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRegistration))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ClassScheduleViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentRegistrationDataSet = New AutomatedSS.StudentRegistrationDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnX = New System.Windows.Forms.Button()
        Me.studentAction = New System.Windows.Forms.Label()
        Me.rvStudentRegistration = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClassScheduleViewTableAdapter = New AutomatedSS.StudentRegistrationDataSetTableAdapters.ClassScheduleViewTableAdapter()
        CType(Me.ClassScheduleViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRegistrationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClassScheduleViewBindingSource
        '
        Me.ClassScheduleViewBindingSource.DataMember = "ClassScheduleView"
        Me.ClassScheduleViewBindingSource.DataSource = Me.StudentRegistrationDataSet
        '
        'StudentRegistrationDataSet
        '
        Me.StudentRegistrationDataSet.DataSetName = "StudentRegistrationDataSet"
        Me.StudentRegistrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.btnX)
        Me.Panel1.Controls.Add(Me.studentAction)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 49)
        Me.Panel1.TabIndex = 49
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
        Me.studentAction.Font = New System.Drawing.Font("Helvetica", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentAction.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.studentAction.Location = New System.Drawing.Point(15, 15)
        Me.studentAction.Name = "studentAction"
        Me.studentAction.Size = New System.Drawing.Size(223, 20)
        Me.studentAction.TabIndex = 0
        Me.studentAction.Text = "Student Registration Report"
        '
        'rvStudentRegistration
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClassScheduleViewBindingSource
        Me.rvStudentRegistration.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvStudentRegistration.LocalReport.ReportEmbeddedResource = "AutomatedSS.StudentRegistrationReport.rdlc"
        Me.rvStudentRegistration.Location = New System.Drawing.Point(12, 67)
        Me.rvStudentRegistration.Name = "rvStudentRegistration"
        Me.rvStudentRegistration.Size = New System.Drawing.Size(883, 641)
        Me.rvStudentRegistration.TabIndex = 50
        '
        'ClassScheduleViewTableAdapter
        '
        Me.ClassScheduleViewTableAdapter.ClearBeforeFill = True
        '
        'StudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(907, 720)
        Me.Controls.Add(Me.rvStudentRegistration)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentRegistration"
        CType(Me.ClassScheduleViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRegistrationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnX As Button
    Friend WithEvents studentAction As Label
    Friend WithEvents rvStudentRegistration As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClassScheduleViewBindingSource As BindingSource
    Friend WithEvents StudentRegistrationDataSet As StudentRegistrationDataSet
    Friend WithEvents ClassScheduleViewTableAdapter As StudentRegistrationDataSetTableAdapters.ClassScheduleViewTableAdapter
End Class
