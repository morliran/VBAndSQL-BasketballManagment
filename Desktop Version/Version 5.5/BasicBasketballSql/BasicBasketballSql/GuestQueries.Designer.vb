<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestQueries
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
        Me.TimerAutoClick = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_WhatQuery = New System.Windows.Forms.Label()
        Me.Lbl_Section = New System.Windows.Forms.Label()
        Me.Btn_AutoClick = New System.Windows.Forms.Button()
        Me.Lbl_TableName = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 54)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1427, 561)
        Me.DataGridView1.TabIndex = 9
        '
        'TimerAutoClick
        '
        Me.TimerAutoClick.Interval = 1000
        '
        'Lbl_WhatQuery
        '
        Me.Lbl_WhatQuery.AutoSize = True
        Me.Lbl_WhatQuery.Location = New System.Drawing.Point(505, 9)
        Me.Lbl_WhatQuery.Name = "Lbl_WhatQuery"
        Me.Lbl_WhatQuery.Size = New System.Drawing.Size(188, 17)
        Me.Lbl_WhatQuery.TabIndex = 12
        Me.Lbl_WhatQuery.Text = "What Query Been Selected?"
        Me.Lbl_WhatQuery.Visible = False
        '
        'Lbl_Section
        '
        Me.Lbl_Section.AutoSize = True
        Me.Lbl_Section.Location = New System.Drawing.Point(753, 10)
        Me.Lbl_Section.Name = "Lbl_Section"
        Me.Lbl_Section.Size = New System.Drawing.Size(100, 17)
        Me.Lbl_Section.TabIndex = 13
        Me.Lbl_Section.Text = "What Section?"
        Me.Lbl_Section.Visible = False
        '
        'Btn_AutoClick
        '
        Me.Btn_AutoClick.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AutoClick.Location = New System.Drawing.Point(277, 242)
        Me.Btn_AutoClick.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_AutoClick.Name = "Btn_AutoClick"
        Me.Btn_AutoClick.Size = New System.Drawing.Size(100, 28)
        Me.Btn_AutoClick.TabIndex = 8
        Me.Btn_AutoClick.UseVisualStyleBackColor = False
        '
        'Lbl_TableName
        '
        Me.Lbl_TableName.AutoSize = True
        Me.Lbl_TableName.BackColor = System.Drawing.Color.White
        Me.Lbl_TableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TableName.Location = New System.Drawing.Point(13, 2)
        Me.Lbl_TableName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_TableName.Name = "Lbl_TableName"
        Me.Lbl_TableName.Size = New System.Drawing.Size(124, 24)
        Me.Lbl_TableName.TabIndex = 14
        Me.Lbl_TableName.Text = "Table Name"
        '
        'GuestQueries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1455, 697)
        Me.Controls.Add(Me.Lbl_TableName)
        Me.Controls.Add(Me.Lbl_Section)
        Me.Controls.Add(Me.Lbl_WhatQuery)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_AutoClick)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GuestQueries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Query Results"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TimerAutoClick As System.Windows.Forms.Timer
    Friend WithEvents Lbl_WhatQuery As System.Windows.Forms.Label
    Friend WithEvents Lbl_Section As System.Windows.Forms.Label
    Friend WithEvents Btn_AutoClick As System.Windows.Forms.Button
    Friend WithEvents Lbl_TableName As System.Windows.Forms.Label
End Class
