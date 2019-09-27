<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayersRoutionForm
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
        Me.Panel_Roution = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_AutoClick = New System.Windows.Forms.Button()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.Pic_UpdateRoution = New System.Windows.Forms.PictureBox()
        Me.Lbl_PrevCode = New System.Windows.Forms.Label()
        Me.Tb_Teamname = New System.Windows.Forms.TextBox()
        Me.Tb_Proutioncode = New System.Windows.Forms.TextBox()
        Me.Tb_Pname = New System.Windows.Forms.TextBox()
        Me.Tb_Pcode = New System.Windows.Forms.TextBox()
        Me.TimerAutoClick = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Roution.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_UpdateRoution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Roution
        '
        Me.Panel_Roution.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Roution.Controls.Add(Me.DataGridView1)
        Me.Panel_Roution.Controls.Add(Me.Btn_AutoClick)
        Me.Panel_Roution.Controls.Add(Me.Pic_Help)
        Me.Panel_Roution.Controls.Add(Me.Pic_UpdateRoution)
        Me.Panel_Roution.Controls.Add(Me.Lbl_PrevCode)
        Me.Panel_Roution.Controls.Add(Me.Tb_Teamname)
        Me.Panel_Roution.Controls.Add(Me.Tb_Proutioncode)
        Me.Panel_Roution.Controls.Add(Me.Tb_Pname)
        Me.Panel_Roution.Controls.Add(Me.Tb_Pcode)
        Me.Panel_Roution.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Roution.Location = New System.Drawing.Point(13, 10)
        Me.Panel_Roution.Name = "Panel_Roution"
        Me.Panel_Roution.Size = New System.Drawing.Size(1069, 757)
        Me.Panel_Roution.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(193, 230)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(677, 483)
        Me.DataGridView1.TabIndex = 19
        '
        'Btn_AutoClick
        '
        Me.Btn_AutoClick.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AutoClick.Location = New System.Drawing.Point(215, 337)
        Me.Btn_AutoClick.Name = "Btn_AutoClick"
        Me.Btn_AutoClick.Size = New System.Drawing.Size(100, 28)
        Me.Btn_AutoClick.TabIndex = 20
        Me.Btn_AutoClick.UseVisualStyleBackColor = False
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(810, 20)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 27
        Me.Pic_Help.TabStop = False
        '
        'Pic_UpdateRoution
        '
        Me.Pic_UpdateRoution.BackColor = System.Drawing.Color.Transparent
        Me.Pic_UpdateRoution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_UpdateRoution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_UpdateRoution.Image = Global.BasicBasketballSql.My.Resources.Resources.update
        Me.Pic_UpdateRoution.Location = New System.Drawing.Point(810, 106)
        Me.Pic_UpdateRoution.Name = "Pic_UpdateRoution"
        Me.Pic_UpdateRoution.Size = New System.Drawing.Size(68, 61)
        Me.Pic_UpdateRoution.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_UpdateRoution.TabIndex = 26
        Me.Pic_UpdateRoution.TabStop = False
        '
        'Lbl_PrevCode
        '
        Me.Lbl_PrevCode.AutoSize = True
        Me.Lbl_PrevCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_PrevCode.Location = New System.Drawing.Point(154, 133)
        Me.Lbl_PrevCode.Name = "Lbl_PrevCode"
        Me.Lbl_PrevCode.Size = New System.Drawing.Size(100, 25)
        Me.Lbl_PrevCode.TabIndex = 25
        Me.Lbl_PrevCode.Text = "Prev code"
        Me.Lbl_PrevCode.Visible = False
        '
        'Tb_Teamname
        '
        Me.Tb_Teamname.Enabled = False
        Me.Tb_Teamname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Teamname.Location = New System.Drawing.Point(391, 20)
        Me.Tb_Teamname.Name = "Tb_Teamname"
        Me.Tb_Teamname.Size = New System.Drawing.Size(325, 30)
        Me.Tb_Teamname.TabIndex = 24
        Me.Tb_Teamname.Text = "Team name"
        '
        'Tb_Proutioncode
        '
        Me.Tb_Proutioncode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Proutioncode.Location = New System.Drawing.Point(391, 181)
        Me.Tb_Proutioncode.Name = "Tb_Proutioncode"
        Me.Tb_Proutioncode.Size = New System.Drawing.Size(325, 30)
        Me.Tb_Proutioncode.TabIndex = 23
        Me.Tb_Proutioncode.Tag = "1"
        Me.Tb_Proutioncode.Text = "Roution code"
        '
        'Tb_Pname
        '
        Me.Tb_Pname.Enabled = False
        Me.Tb_Pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Pname.Location = New System.Drawing.Point(391, 128)
        Me.Tb_Pname.Name = "Tb_Pname"
        Me.Tb_Pname.Size = New System.Drawing.Size(325, 30)
        Me.Tb_Pname.TabIndex = 22
        Me.Tb_Pname.Text = "Player name"
        '
        'Tb_Pcode
        '
        Me.Tb_Pcode.Enabled = False
        Me.Tb_Pcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Pcode.Location = New System.Drawing.Point(391, 76)
        Me.Tb_Pcode.Name = "Tb_Pcode"
        Me.Tb_Pcode.Size = New System.Drawing.Size(325, 30)
        Me.Tb_Pcode.TabIndex = 21
        Me.Tb_Pcode.Text = "Player code"
        '
        'TimerAutoClick
        '
        Me.TimerAutoClick.Interval = 1000
        '
        'PlayersRoutionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1088, 779)
        Me.Controls.Add(Me.Panel_Roution)
        Me.Name = "PlayersRoutionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlayersRoutionForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Roution.ResumeLayout(False)
        Me.Panel_Roution.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_UpdateRoution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Roution As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_AutoClick As System.Windows.Forms.Button
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_UpdateRoution As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_PrevCode As System.Windows.Forms.Label
    Friend WithEvents Tb_Teamname As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Proutioncode As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Pname As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Pcode As System.Windows.Forms.TextBox
    Friend WithEvents TimerAutoClick As System.Windows.Forms.Timer
End Class
