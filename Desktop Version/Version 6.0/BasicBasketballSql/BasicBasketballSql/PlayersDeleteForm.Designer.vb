<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayersDeleteForm
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
        Me.Panel_PlayerDel = New System.Windows.Forms.Panel()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.Pic_Delete = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Tb_Teamname = New System.Windows.Forms.TextBox()
        Me.Tb_Pname = New System.Windows.Forms.TextBox()
        Me.Tb_Pcode = New System.Windows.Forms.TextBox()
        Me.Btn_AutoClick = New System.Windows.Forms.Button()
        Me.TimerAutoClick = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_PlayerDel.SuspendLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_PlayerDel
        '
        Me.Panel_PlayerDel.BackColor = System.Drawing.Color.Transparent
        Me.Panel_PlayerDel.Controls.Add(Me.Pic_Help)
        Me.Panel_PlayerDel.Controls.Add(Me.Pic_Delete)
        Me.Panel_PlayerDel.Controls.Add(Me.DataGridView1)
        Me.Panel_PlayerDel.Controls.Add(Me.Tb_Teamname)
        Me.Panel_PlayerDel.Controls.Add(Me.Tb_Pname)
        Me.Panel_PlayerDel.Controls.Add(Me.Tb_Pcode)
        Me.Panel_PlayerDel.Controls.Add(Me.Btn_AutoClick)
        Me.Panel_PlayerDel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_PlayerDel.Location = New System.Drawing.Point(11, 4)
        Me.Panel_PlayerDel.Name = "Panel_PlayerDel"
        Me.Panel_PlayerDel.Size = New System.Drawing.Size(1455, 763)
        Me.Panel_PlayerDel.TabIndex = 0
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(833, 14)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 33
        Me.Pic_Help.TabStop = False
        '
        'Pic_Delete
        '
        Me.Pic_Delete.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Delete.Image = Global.BasicBasketballSql.My.Resources.Resources.delete
        Me.Pic_Delete.Location = New System.Drawing.Point(833, 91)
        Me.Pic_Delete.Name = "Pic_Delete"
        Me.Pic_Delete.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Delete.TabIndex = 32
        Me.Pic_Delete.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 188)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1427, 561)
        Me.DataGridView1.TabIndex = 31
        '
        'Tb_Teamname
        '
        Me.Tb_Teamname.Enabled = False
        Me.Tb_Teamname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Teamname.Location = New System.Drawing.Point(395, 14)
        Me.Tb_Teamname.Name = "Tb_Teamname"
        Me.Tb_Teamname.Size = New System.Drawing.Size(325, 30)
        Me.Tb_Teamname.TabIndex = 30
        Me.Tb_Teamname.Text = "Team name"
        '
        'Tb_Pname
        '
        Me.Tb_Pname.Enabled = False
        Me.Tb_Pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Pname.Location = New System.Drawing.Point(395, 122)
        Me.Tb_Pname.Name = "Tb_Pname"
        Me.Tb_Pname.Size = New System.Drawing.Size(325, 30)
        Me.Tb_Pname.TabIndex = 29
        Me.Tb_Pname.Text = "Player name"
        '
        'Tb_Pcode
        '
        Me.Tb_Pcode.Enabled = False
        Me.Tb_Pcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Pcode.Location = New System.Drawing.Point(395, 70)
        Me.Tb_Pcode.Name = "Tb_Pcode"
        Me.Tb_Pcode.Size = New System.Drawing.Size(325, 30)
        Me.Tb_Pcode.TabIndex = 28
        Me.Tb_Pcode.Text = "Player code"
        '
        'Btn_AutoClick
        '
        Me.Btn_AutoClick.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AutoClick.Location = New System.Drawing.Point(219, 331)
        Me.Btn_AutoClick.Name = "Btn_AutoClick"
        Me.Btn_AutoClick.Size = New System.Drawing.Size(100, 28)
        Me.Btn_AutoClick.TabIndex = 27
        Me.Btn_AutoClick.UseVisualStyleBackColor = False
        '
        'TimerAutoClick
        '
        Me.TimerAutoClick.Interval = 1000
        '
        'PlayersDeleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.BasicBasketballSql.My.Resources.Resources.AdminsBackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1283, 734)
        Me.Controls.Add(Me.Panel_PlayerDel)
        Me.DoubleBuffered = True
        Me.Name = "PlayersDeleteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlayersDeleteForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_PlayerDel.ResumeLayout(False)
        Me.Panel_PlayerDel.PerformLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_PlayerDel As System.Windows.Forms.Panel
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Delete As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Tb_Teamname As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Pname As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Pcode As System.Windows.Forms.TextBox
    Friend WithEvents Btn_AutoClick As System.Windows.Forms.Button
    Friend WithEvents TimerAutoClick As System.Windows.Forms.Timer
End Class
