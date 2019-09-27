<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerOthersQuerys
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
        Me.Lbl_TableName = New System.Windows.Forms.Label()
        Me.Btn_AutoClick = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TimerAutoClick = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Query = New System.Windows.Forms.Label()
        Me.Lbl_TeamsName = New System.Windows.Forms.Label()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_TableName
        '
        Me.Lbl_TableName.AutoSize = True
        Me.Lbl_TableName.BackColor = System.Drawing.Color.White
        Me.Lbl_TableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TableName.Location = New System.Drawing.Point(8, 9)
        Me.Lbl_TableName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_TableName.Name = "Lbl_TableName"
        Me.Lbl_TableName.Size = New System.Drawing.Size(140, 26)
        Me.Lbl_TableName.TabIndex = 7
        Me.Lbl_TableName.Text = "Table Name"
        '
        'Btn_AutoClick
        '
        Me.Btn_AutoClick.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AutoClick.Location = New System.Drawing.Point(151, 224)
        Me.Btn_AutoClick.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_AutoClick.Name = "Btn_AutoClick"
        Me.Btn_AutoClick.Size = New System.Drawing.Size(100, 28)
        Me.Btn_AutoClick.TabIndex = 8
        Me.Btn_AutoClick.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 80)
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
        'Lbl_Query
        '
        Me.Lbl_Query.AutoSize = True
        Me.Lbl_Query.Location = New System.Drawing.Point(607, 23)
        Me.Lbl_Query.Name = "Lbl_Query"
        Me.Lbl_Query.Size = New System.Drawing.Size(86, 17)
        Me.Lbl_Query.TabIndex = 12
        Me.Lbl_Query.Text = "Query name"
        Me.Lbl_Query.Visible = False
        '
        'Lbl_TeamsName
        '
        Me.Lbl_TeamsName.AutoSize = True
        Me.Lbl_TeamsName.Location = New System.Drawing.Point(870, 24)
        Me.Lbl_TeamsName.Name = "Lbl_TeamsName"
        Me.Lbl_TeamsName.Size = New System.Drawing.Size(83, 17)
        Me.Lbl_TeamsName.TabIndex = 13
        Me.Lbl_TeamsName.Text = "Team name"
        Me.Lbl_TeamsName.Visible = False
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(1055, 9)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 27
        Me.Pic_Help.TabStop = False
        '
        'ManagerOthersQuerys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1442, 749)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.Lbl_TeamsName)
        Me.Controls.Add(Me.Lbl_Query)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_AutoClick)
        Me.Controls.Add(Me.Lbl_TableName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ManagerOthersQuerys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Managers Other Querys"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_TableName As System.Windows.Forms.Label
    Friend WithEvents Btn_AutoClick As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TimerAutoClick As System.Windows.Forms.Timer
    Friend WithEvents Lbl_Query As System.Windows.Forms.Label
    Friend WithEvents Lbl_TeamsName As System.Windows.Forms.Label
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
