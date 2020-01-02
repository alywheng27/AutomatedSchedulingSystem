<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class classSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(classSchedule))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteClass = New System.Windows.Forms.Button()
        Me.btnUpdateClass = New System.Windows.Forms.Button()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.lvClass = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbSemester = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbAcademicYear = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 28)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Class Schedule"
        '
        'btnDeleteClass
        '
        Me.btnDeleteClass.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteClass.FlatAppearance.BorderSize = 0
        Me.btnDeleteClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteClass.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteClass.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDeleteClass.Image = CType(resources.GetObject("btnDeleteClass.Image"), System.Drawing.Image)
        Me.btnDeleteClass.Location = New System.Drawing.Point(450, 12)
        Me.btnDeleteClass.Name = "btnDeleteClass"
        Me.btnDeleteClass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeleteClass.Size = New System.Drawing.Size(103, 98)
        Me.btnDeleteClass.TabIndex = 22
        Me.btnDeleteClass.Text = "Delete Class"
        Me.btnDeleteClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeleteClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteClass.UseVisualStyleBackColor = False
        '
        'btnUpdateClass
        '
        Me.btnUpdateClass.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdateClass.FlatAppearance.BorderSize = 0
        Me.btnUpdateClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateClass.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateClass.ForeColor = System.Drawing.SystemColors.Window
        Me.btnUpdateClass.Image = CType(resources.GetObject("btnUpdateClass.Image"), System.Drawing.Image)
        Me.btnUpdateClass.Location = New System.Drawing.Point(341, 12)
        Me.btnUpdateClass.Name = "btnUpdateClass"
        Me.btnUpdateClass.Size = New System.Drawing.Size(103, 98)
        Me.btnUpdateClass.TabIndex = 21
        Me.btnUpdateClass.Text = "Update Class"
        Me.btnUpdateClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdateClass.UseVisualStyleBackColor = False
        '
        'btnAddClass
        '
        Me.btnAddClass.BackColor = System.Drawing.Color.Transparent
        Me.btnAddClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddClass.FlatAppearance.BorderSize = 0
        Me.btnAddClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddClass.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddClass.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddClass.Image = CType(resources.GetObject("btnAddClass.Image"), System.Drawing.Image)
        Me.btnAddClass.Location = New System.Drawing.Point(232, 12)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(103, 98)
        Me.btnAddClass.TabIndex = 20
        Me.btnAddClass.Text = "Add Class"
        Me.btnAddClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddClass.UseVisualStyleBackColor = False
        '
        'lvClass
        '
        Me.lvClass.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvClass.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvClass.ForeColor = System.Drawing.Color.Black
        Me.lvClass.FullRowSelect = True
        Me.lvClass.GridLines = True
        Me.lvClass.Location = New System.Drawing.Point(12, 116)
        Me.lvClass.Name = "lvClass"
        Me.lvClass.Size = New System.Drawing.Size(1020, 534)
        Me.lvClass.TabIndex = 24
        Me.lvClass.UseCompatibleStateImageBehavior = False
        Me.lvClass.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject"
        Me.ColumnHeader1.Width = 175
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Day"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Time"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Room"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Section"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Instructor"
        Me.ColumnHeader10.Width = 182
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Semester"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "A.Y."
        Me.ColumnHeader12.Width = 100
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.Location = New System.Drawing.Point(886, 64)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(146, 31)
        Me.btnSearch.TabIndex = 78
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.cbSemester)
        Me.Panel2.Location = New System.Drawing.Point(734, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 31)
        Me.Panel2.TabIndex = 20
        '
        'cbSemester
        '
        Me.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSemester.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbSemester.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Location = New System.Drawing.Point(0, 4)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(143, 23)
        Me.cbSemester.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(672, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Semeter"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(734, 28)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(146, 31)
        Me.Panel6.TabIndex = 18
        '
        'cbAcademicYear
        '
        Me.cbAcademicYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAcademicYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbAcademicYear.Font = New System.Drawing.Font("Helvetica", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAcademicYear.FormattingEnabled = True
        Me.cbAcademicYear.Location = New System.Drawing.Point(737, 32)
        Me.cbAcademicYear.Name = "cbAcademicYear"
        Me.cbAcademicYear.Size = New System.Drawing.Size(140, 23)
        Me.cbAcademicYear.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(634, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Academic Year"
        '
        'classSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 669)
        Me.Controls.Add(Me.cbAcademicYear)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteClass)
        Me.Controls.Add(Me.btnUpdateClass)
        Me.Controls.Add(Me.btnAddClass)
        Me.Controls.Add(Me.lvClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(225, 47)
        Me.Name = "classSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "classSchedule"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteClass As Button
    Friend WithEvents btnUpdateClass As Button
    Friend WithEvents btnAddClass As Button
    Friend WithEvents lvClass As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbAcademicYear As ComboBox
    Friend WithEvents Label5 As Label
End Class
