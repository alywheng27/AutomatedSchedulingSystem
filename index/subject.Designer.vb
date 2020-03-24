<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subject))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteSubject = New System.Windows.Forms.Button()
        Me.btnUpdateSubject = New System.Windows.Forms.Button()
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.lvSubject = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Subject"
        '
        'btnDeleteSubject
        '
        Me.btnDeleteSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteSubject.FlatAppearance.BorderSize = 0
        Me.btnDeleteSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSubject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSubject.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteSubject.Image = CType(resources.GetObject("btnDeleteSubject.Image"), System.Drawing.Image)
        Me.btnDeleteSubject.Location = New System.Drawing.Point(408, 12)
        Me.btnDeleteSubject.Name = "btnDeleteSubject"
        Me.btnDeleteSubject.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeleteSubject.Size = New System.Drawing.Size(103, 98)
        Me.btnDeleteSubject.TabIndex = 12
        Me.btnDeleteSubject.Text = "Delete Subject"
        Me.btnDeleteSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeleteSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteSubject.UseVisualStyleBackColor = False
        '
        'btnUpdateSubject
        '
        Me.btnUpdateSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdateSubject.FlatAppearance.BorderSize = 0
        Me.btnUpdateSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSubject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSubject.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateSubject.Image = CType(resources.GetObject("btnUpdateSubject.Image"), System.Drawing.Image)
        Me.btnUpdateSubject.Location = New System.Drawing.Point(299, 12)
        Me.btnUpdateSubject.Name = "btnUpdateSubject"
        Me.btnUpdateSubject.Size = New System.Drawing.Size(103, 98)
        Me.btnUpdateSubject.TabIndex = 11
        Me.btnUpdateSubject.Text = "Update Subject"
        Me.btnUpdateSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdateSubject.UseVisualStyleBackColor = False
        '
        'btnAddSubject
        '
        Me.btnAddSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddSubject.FlatAppearance.BorderSize = 0
        Me.btnAddSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSubject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddSubject.Image = CType(resources.GetObject("btnAddSubject.Image"), System.Drawing.Image)
        Me.btnAddSubject.Location = New System.Drawing.Point(190, 12)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(103, 98)
        Me.btnAddSubject.TabIndex = 10
        Me.btnAddSubject.Text = "Add Subject"
        Me.btnAddSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddSubject.UseVisualStyleBackColor = False
        '
        'lvSubject
        '
        Me.lvSubject.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5})
        Me.lvSubject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSubject.ForeColor = System.Drawing.Color.Black
        Me.lvSubject.FullRowSelect = True
        Me.lvSubject.GridLines = True
        Me.lvSubject.Location = New System.Drawing.Point(12, 116)
        Me.lvSubject.Name = "lvSubject"
        Me.lvSubject.Size = New System.Drawing.Size(1020, 534)
        Me.lvSubject.TabIndex = 14
        Me.lvSubject.UseCompatibleStateImageBehavior = False
        Me.lvSubject.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Subject"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 347
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit"
        Me.ColumnHeader4.Width = 170
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Lecture Unit"
        Me.ColumnHeader3.Width = 170
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Lab Unit"
        Me.ColumnHeader5.Width = 170
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Location = New System.Drawing.Point(833, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(199, 31)
        Me.Panel1.TabIndex = 72
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(3, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(193, 15)
        Me.txtSearch.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(833, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Search"
        '
        'subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 669)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteSubject)
        Me.Controls.Add(Me.btnUpdateSubject)
        Me.Controls.Add(Me.btnAddSubject)
        Me.Controls.Add(Me.lvSubject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(225, 47)
        Me.Name = "subject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "subject"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteSubject As Button
    Friend WithEvents btnUpdateSubject As Button
    Friend WithEvents btnAddSubject As Button
    Friend WithEvents lvSubject As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
