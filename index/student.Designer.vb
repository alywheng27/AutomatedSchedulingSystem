<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(student))
        Me.lvStudent = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnUpdateStudent = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPrintCOR = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvStudent
        '
        Me.lvStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvStudent.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvStudent.ForeColor = System.Drawing.Color.Black
        Me.lvStudent.FullRowSelect = True
        Me.lvStudent.GridLines = True
        Me.lvStudent.Location = New System.Drawing.Point(12, 116)
        Me.lvStudent.Name = "lvStudent"
        Me.lvStudent.Size = New System.Drawing.Size(1020, 534)
        Me.lvStudent.TabIndex = 4
        Me.lvStudent.UseCompatibleStateImageBehavior = False
        Me.lvStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Student ID"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Course"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Year Level"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Gender"
        Me.ColumnHeader5.Width = 150
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddStudent.FlatAppearance.BorderSize = 0
        Me.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudent.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddStudent.Image = CType(resources.GetObject("btnAddStudent.Image"), System.Drawing.Image)
        Me.btnAddStudent.Location = New System.Drawing.Point(190, 12)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(103, 98)
        Me.btnAddStudent.TabIndex = 1
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdateStudent.FlatAppearance.BorderSize = 0
        Me.btnUpdateStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStudent.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStudent.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateStudent.Image = CType(resources.GetObject("btnUpdateStudent.Image"), System.Drawing.Image)
        Me.btnUpdateStudent.Location = New System.Drawing.Point(299, 12)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.Size = New System.Drawing.Size(103, 98)
        Me.btnUpdateStudent.TabIndex = 2
        Me.btnUpdateStudent.Text = "Update Student"
        Me.btnUpdateStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdateStudent.UseVisualStyleBackColor = False
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteStudent.FlatAppearance.BorderSize = 0
        Me.btnDeleteStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteStudent.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStudent.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteStudent.Image = CType(resources.GetObject("btnDeleteStudent.Image"), System.Drawing.Image)
        Me.btnDeleteStudent.Location = New System.Drawing.Point(408, 12)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeleteStudent.Size = New System.Drawing.Size(103, 98)
        Me.btnDeleteStudent.TabIndex = 3
        Me.btnDeleteStudent.Text = "Delete Student"
        Me.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteStudent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Student"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(833, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 31)
        Me.Panel1.TabIndex = 70
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(3, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(193, 16)
        Me.txtSearch.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("HelveticaNeue-Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(833, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Search"
        '
        'btnPrintCOR
        '
        Me.btnPrintCOR.BackColor = System.Drawing.Color.Transparent
        Me.btnPrintCOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrintCOR.FlatAppearance.BorderSize = 0
        Me.btnPrintCOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnPrintCOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintCOR.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCOR.ForeColor = System.Drawing.SystemColors.Window
        Me.btnPrintCOR.Image = CType(resources.GetObject("btnPrintCOR.Image"), System.Drawing.Image)
        Me.btnPrintCOR.Location = New System.Drawing.Point(565, 12)
        Me.btnPrintCOR.Name = "btnPrintCOR"
        Me.btnPrintCOR.Size = New System.Drawing.Size(103, 98)
        Me.btnPrintCOR.TabIndex = 71
        Me.btnPrintCOR.Text = "View COR"
        Me.btnPrintCOR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintCOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrintCOR.UseVisualStyleBackColor = False
        '
        'student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 669)
        Me.Controls.Add(Me.btnPrintCOR)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteStudent)
        Me.Controls.Add(Me.btnUpdateStudent)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lvStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(225, 47)
        Me.Name = "student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvStudent As ListView
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnUpdateStudent As Button
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPrintCOR As Button
End Class
