<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(instructor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteInstructor = New System.Windows.Forms.Button()
        Me.btnUpdateInstructor = New System.Windows.Forms.Button()
        Me.btnAddInstructor = New System.Windows.Forms.Button()
        Me.lvInstructor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Instructor"
        '
        'btnDeleteInstructor
        '
        Me.btnDeleteInstructor.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteInstructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteInstructor.FlatAppearance.BorderSize = 0
        Me.btnDeleteInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDeleteInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteInstructor.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteInstructor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteInstructor.Image = CType(resources.GetObject("btnDeleteInstructor.Image"), System.Drawing.Image)
        Me.btnDeleteInstructor.Location = New System.Drawing.Point(408, 12)
        Me.btnDeleteInstructor.Name = "btnDeleteInstructor"
        Me.btnDeleteInstructor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeleteInstructor.Size = New System.Drawing.Size(103, 98)
        Me.btnDeleteInstructor.TabIndex = 7
        Me.btnDeleteInstructor.Text = "Delete Instructor"
        Me.btnDeleteInstructor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeleteInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteInstructor.UseVisualStyleBackColor = False
        '
        'btnUpdateInstructor
        '
        Me.btnUpdateInstructor.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateInstructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdateInstructor.FlatAppearance.BorderSize = 0
        Me.btnUpdateInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdateInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateInstructor.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateInstructor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateInstructor.Image = CType(resources.GetObject("btnUpdateInstructor.Image"), System.Drawing.Image)
        Me.btnUpdateInstructor.Location = New System.Drawing.Point(299, 12)
        Me.btnUpdateInstructor.Name = "btnUpdateInstructor"
        Me.btnUpdateInstructor.Size = New System.Drawing.Size(103, 98)
        Me.btnUpdateInstructor.TabIndex = 6
        Me.btnUpdateInstructor.Text = "Update Instructor"
        Me.btnUpdateInstructor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdateInstructor.UseVisualStyleBackColor = False
        '
        'btnAddInstructor
        '
        Me.btnAddInstructor.BackColor = System.Drawing.Color.Transparent
        Me.btnAddInstructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddInstructor.FlatAppearance.BorderSize = 0
        Me.btnAddInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddInstructor.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddInstructor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddInstructor.Image = CType(resources.GetObject("btnAddInstructor.Image"), System.Drawing.Image)
        Me.btnAddInstructor.Location = New System.Drawing.Point(190, 12)
        Me.btnAddInstructor.Name = "btnAddInstructor"
        Me.btnAddInstructor.Size = New System.Drawing.Size(103, 98)
        Me.btnAddInstructor.TabIndex = 5
        Me.btnAddInstructor.Text = "Add Instructor"
        Me.btnAddInstructor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddInstructor.UseVisualStyleBackColor = False
        '
        'lvInstructor
        '
        Me.lvInstructor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5})
        Me.lvInstructor.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInstructor.ForeColor = System.Drawing.Color.Black
        Me.lvInstructor.FullRowSelect = True
        Me.lvInstructor.GridLines = True
        Me.lvInstructor.Location = New System.Drawing.Point(12, 116)
        Me.lvInstructor.Name = "lvInstructor"
        Me.lvInstructor.Size = New System.Drawing.Size(1020, 534)
        Me.lvInstructor.TabIndex = 9
        Me.lvInstructor.UseCompatibleStateImageBehavior = False
        Me.lvInstructor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Instructor ID"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Department"
        Me.ColumnHeader3.Width = 312
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Gender"
        Me.ColumnHeader5.Width = 170
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(833, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 31)
        Me.Panel1.TabIndex = 74
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
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Search"
        '
        'instructor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 669)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteInstructor)
        Me.Controls.Add(Me.btnUpdateInstructor)
        Me.Controls.Add(Me.btnAddInstructor)
        Me.Controls.Add(Me.lvInstructor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(225, 47)
        Me.Name = "instructor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "instructor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteInstructor As Button
    Friend WithEvents btnUpdateInstructor As Button
    Friend WithEvents btnAddInstructor As Button
    Friend WithEvents lvInstructor As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
End Class
