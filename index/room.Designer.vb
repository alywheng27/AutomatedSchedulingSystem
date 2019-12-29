<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(room))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDeleteRoom = New System.Windows.Forms.Button()
        Me.btnUpdateRoom = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.lvRoom = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(51, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Room"
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDeleteRoom.FlatAppearance.BorderSize = 0
        Me.btnDeleteRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteRoom.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRoom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteRoom.Image = CType(resources.GetObject("btnDeleteRoom.Image"), System.Drawing.Image)
        Me.btnDeleteRoom.Location = New System.Drawing.Point(408, 12)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeleteRoom.Size = New System.Drawing.Size(103, 98)
        Me.btnDeleteRoom.TabIndex = 17
        Me.btnDeleteRoom.Text = "Delete Room"
        Me.btnDeleteRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeleteRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDeleteRoom.UseVisualStyleBackColor = False
        '
        'btnUpdateRoom
        '
        Me.btnUpdateRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnUpdateRoom.FlatAppearance.BorderSize = 0
        Me.btnUpdateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateRoom.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRoom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateRoom.Image = CType(resources.GetObject("btnUpdateRoom.Image"), System.Drawing.Image)
        Me.btnUpdateRoom.Location = New System.Drawing.Point(299, 12)
        Me.btnUpdateRoom.Name = "btnUpdateRoom"
        Me.btnUpdateRoom.Size = New System.Drawing.Size(103, 98)
        Me.btnUpdateRoom.TabIndex = 16
        Me.btnUpdateRoom.Text = "Update Room"
        Me.btnUpdateRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdateRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUpdateRoom.UseVisualStyleBackColor = False
        '
        'btnAddRoom
        '
        Me.btnAddRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnAddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddRoom.FlatAppearance.BorderSize = 0
        Me.btnAddRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRoom.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddRoom.Image = CType(resources.GetObject("btnAddRoom.Image"), System.Drawing.Image)
        Me.btnAddRoom.Location = New System.Drawing.Point(190, 12)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(103, 98)
        Me.btnAddRoom.TabIndex = 15
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnAddRoom.UseVisualStyleBackColor = False
        '
        'lvRoom
        '
        Me.lvRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvRoom.Font = New System.Drawing.Font("Helvetica", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRoom.ForeColor = System.Drawing.Color.Black
        Me.lvRoom.FullRowSelect = True
        Me.lvRoom.GridLines = True
        Me.lvRoom.Location = New System.Drawing.Point(12, 116)
        Me.lvRoom.Name = "lvRoom"
        Me.lvRoom.Size = New System.Drawing.Size(1020, 534)
        Me.lvRoom.TabIndex = 19
        Me.lvRoom.UseCompatibleStateImageBehavior = False
        Me.lvRoom.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room"
        Me.ColumnHeader1.Width = 175
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Department"
        Me.ColumnHeader2.Width = 647
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
        'room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 669)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeleteRoom)
        Me.Controls.Add(Me.btnUpdateRoom)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.lvRoom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(225, 47)
        Me.Name = "room"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "room"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents btnUpdateRoom As Button
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents lvRoom As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
End Class
