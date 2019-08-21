<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuildMineQueries
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
        Me.Chb_Jn = New System.Windows.Forms.CheckBox()
        Me.Chb_Height = New System.Windows.Forms.CheckBox()
        Me.Chb_DOB = New System.Windows.Forms.CheckBox()
        Me.Chb_Pos = New System.Windows.Forms.CheckBox()
        Me.Chb_SecondPos = New System.Windows.Forms.CheckBox()
        Me.Lbl_Check = New System.Windows.Forms.Label()
        Me.CB_Rule = New System.Windows.Forms.ComboBox()
        Me.Lbl_StartCommand = New System.Windows.Forms.Label()
        Me.Tb_Col = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TimerAutoClick = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_AutoClick = New System.Windows.Forms.Button()
        Me.CB_FillByJn = New System.Windows.Forms.ComboBox()
        Me.CB_FillByHeight = New System.Windows.Forms.ComboBox()
        Me.CB_FillByPosition = New System.Windows.Forms.ComboBox()
        Me.CB_FillBySPosition = New System.Windows.Forms.ComboBox()
        Me.Chb_FAndSpos = New System.Windows.Forms.CheckBox()
        Me.Lbl_And = New System.Windows.Forms.Label()
        Me.CB_Rule3 = New System.Windows.Forms.ComboBox()
        Me.Tb_Col2 = New System.Windows.Forms.TextBox()
        Me.Lbl_Check2 = New System.Windows.Forms.Label()
        Me.CB_FillBySecondPos = New System.Windows.Forms.ComboBox()
        Me.CB_Rule2 = New System.Windows.Forms.ComboBox()
        Me.CB_FillByDOB = New System.Windows.Forms.ComboBox()
        Me.Pic_Start = New System.Windows.Forms.PictureBox()
        Me.Pic_Reset = New System.Windows.Forms.PictureBox()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Reset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chb_Jn
        '
        Me.Chb_Jn.AutoSize = True
        Me.Chb_Jn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Chb_Jn.Location = New System.Drawing.Point(20, 24)
        Me.Chb_Jn.Name = "Chb_Jn"
        Me.Chb_Jn.Size = New System.Drawing.Size(164, 29)
        Me.Chb_Jn.TabIndex = 0
        Me.Chb_Jn.Text = "Jersey number"
        Me.Chb_Jn.UseVisualStyleBackColor = True
        '
        'Chb_Height
        '
        Me.Chb_Height.AutoSize = True
        Me.Chb_Height.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Chb_Height.Location = New System.Drawing.Point(520, 24)
        Me.Chb_Height.Name = "Chb_Height"
        Me.Chb_Height.Size = New System.Drawing.Size(90, 29)
        Me.Chb_Height.TabIndex = 1
        Me.Chb_Height.Text = "Height"
        Me.Chb_Height.UseVisualStyleBackColor = True
        '
        'Chb_DOB
        '
        Me.Chb_DOB.AutoSize = True
        Me.Chb_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Chb_DOB.Location = New System.Drawing.Point(631, 24)
        Me.Chb_DOB.Name = "Chb_DOB"
        Me.Chb_DOB.Size = New System.Drawing.Size(138, 29)
        Me.Chb_DOB.TabIndex = 2
        Me.Chb_DOB.Text = "Date of birth"
        Me.Chb_DOB.UseVisualStyleBackColor = True
        '
        'Chb_Pos
        '
        Me.Chb_Pos.AutoSize = True
        Me.Chb_Pos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Chb_Pos.Location = New System.Drawing.Point(205, 24)
        Me.Chb_Pos.Name = "Chb_Pos"
        Me.Chb_Pos.Size = New System.Drawing.Size(103, 29)
        Me.Chb_Pos.TabIndex = 4
        Me.Chb_Pos.Text = "Position"
        Me.Chb_Pos.UseVisualStyleBackColor = True
        '
        'Chb_SecondPos
        '
        Me.Chb_SecondPos.AutoSize = True
        Me.Chb_SecondPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Chb_SecondPos.Location = New System.Drawing.Point(329, 24)
        Me.Chb_SecondPos.Name = "Chb_SecondPos"
        Me.Chb_SecondPos.Size = New System.Drawing.Size(170, 29)
        Me.Chb_SecondPos.TabIndex = 5
        Me.Chb_SecondPos.Text = "Second postion"
        Me.Chb_SecondPos.UseVisualStyleBackColor = True
        '
        'Lbl_Check
        '
        Me.Lbl_Check.AutoSize = True
        Me.Lbl_Check.Location = New System.Drawing.Point(1213, 45)
        Me.Lbl_Check.Name = "Lbl_Check"
        Me.Lbl_Check.Size = New System.Drawing.Size(35, 17)
        Me.Lbl_Check.TabIndex = 6
        Me.Lbl_Check.Text = "Text"
        Me.Lbl_Check.Visible = False
        '
        'CB_Rule
        '
        Me.CB_Rule.FormattingEnabled = True
        Me.CB_Rule.Items.AddRange(New Object() {"=", "<>", ">", "<", ">=", "<="})
        Me.CB_Rule.Location = New System.Drawing.Point(434, 70)
        Me.CB_Rule.Name = "CB_Rule"
        Me.CB_Rule.Size = New System.Drawing.Size(57, 24)
        Me.CB_Rule.TabIndex = 7
        '
        'Lbl_StartCommand
        '
        Me.Lbl_StartCommand.AutoSize = True
        Me.Lbl_StartCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_StartCommand.Location = New System.Drawing.Point(16, 72)
        Me.Lbl_StartCommand.Name = "Lbl_StartCommand"
        Me.Lbl_StartCommand.Size = New System.Drawing.Size(236, 20)
        Me.Lbl_StartCommand.TabIndex = 8
        Me.Lbl_StartCommand.Text = "Select * From [Players] Where"
        '
        'Tb_Col
        '
        Me.Tb_Col.Enabled = False
        Me.Tb_Col.Location = New System.Drawing.Point(295, 70)
        Me.Tb_Col.Name = "Tb_Col"
        Me.Tb_Col.Size = New System.Drawing.Size(116, 22)
        Me.Tb_Col.TabIndex = 9
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 131)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1463, 593)
        Me.DataGridView2.TabIndex = 10
        '
        'Btn_AutoClick
        '
        Me.Btn_AutoClick.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AutoClick.Location = New System.Drawing.Point(123, 317)
        Me.Btn_AutoClick.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_AutoClick.Name = "Btn_AutoClick"
        Me.Btn_AutoClick.Size = New System.Drawing.Size(100, 28)
        Me.Btn_AutoClick.TabIndex = 11
        Me.Btn_AutoClick.UseVisualStyleBackColor = False
        '
        'CB_FillByJn
        '
        Me.CB_FillByJn.FormattingEnabled = True
        Me.CB_FillByJn.Location = New System.Drawing.Point(508, 69)
        Me.CB_FillByJn.Name = "CB_FillByJn"
        Me.CB_FillByJn.Size = New System.Drawing.Size(63, 24)
        Me.CB_FillByJn.TabIndex = 12
        '
        'CB_FillByHeight
        '
        Me.CB_FillByHeight.FormattingEnabled = True
        Me.CB_FillByHeight.Location = New System.Drawing.Point(508, 69)
        Me.CB_FillByHeight.Name = "CB_FillByHeight"
        Me.CB_FillByHeight.Size = New System.Drawing.Size(63, 24)
        Me.CB_FillByHeight.TabIndex = 13
        '
        'CB_FillByPosition
        '
        Me.CB_FillByPosition.FormattingEnabled = True
        Me.CB_FillByPosition.Location = New System.Drawing.Point(508, 69)
        Me.CB_FillByPosition.Name = "CB_FillByPosition"
        Me.CB_FillByPosition.Size = New System.Drawing.Size(63, 24)
        Me.CB_FillByPosition.TabIndex = 14
        '
        'CB_FillBySPosition
        '
        Me.CB_FillBySPosition.FormattingEnabled = True
        Me.CB_FillBySPosition.Location = New System.Drawing.Point(991, 68)
        Me.CB_FillBySPosition.Name = "CB_FillBySPosition"
        Me.CB_FillBySPosition.Size = New System.Drawing.Size(147, 24)
        Me.CB_FillBySPosition.TabIndex = 16
        Me.CB_FillBySPosition.Visible = False
        '
        'Chb_FAndSpos
        '
        Me.Chb_FAndSpos.AutoSize = True
        Me.Chb_FAndSpos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Chb_FAndSpos.Location = New System.Drawing.Point(790, 24)
        Me.Chb_FAndSpos.Name = "Chb_FAndSpos"
        Me.Chb_FAndSpos.Size = New System.Drawing.Size(230, 29)
        Me.Chb_FAndSpos.TabIndex = 17
        Me.Chb_FAndSpos.Text = "FpositionAndSposition"
        Me.Chb_FAndSpos.UseVisualStyleBackColor = True
        '
        'Lbl_And
        '
        Me.Lbl_And.AutoSize = True
        Me.Lbl_And.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_And.Location = New System.Drawing.Point(608, 68)
        Me.Lbl_And.Name = "Lbl_And"
        Me.Lbl_And.Size = New System.Drawing.Size(48, 25)
        Me.Lbl_And.TabIndex = 18
        Me.Lbl_And.Text = "And"
        Me.Lbl_And.Visible = False
        '
        'CB_Rule3
        '
        Me.CB_Rule3.FormattingEnabled = True
        Me.CB_Rule3.Items.AddRange(New Object() {"=", "<>"})
        Me.CB_Rule3.Location = New System.Drawing.Point(890, 68)
        Me.CB_Rule3.Name = "CB_Rule3"
        Me.CB_Rule3.Size = New System.Drawing.Size(84, 24)
        Me.CB_Rule3.TabIndex = 19
        Me.CB_Rule3.Visible = False
        '
        'Tb_Col2
        '
        Me.Tb_Col2.Enabled = False
        Me.Tb_Col2.Location = New System.Drawing.Point(742, 70)
        Me.Tb_Col2.Name = "Tb_Col2"
        Me.Tb_Col2.Size = New System.Drawing.Size(128, 22)
        Me.Tb_Col2.TabIndex = 20
        Me.Tb_Col2.Visible = False
        '
        'Lbl_Check2
        '
        Me.Lbl_Check2.AutoSize = True
        Me.Lbl_Check2.Location = New System.Drawing.Point(1269, 44)
        Me.Lbl_Check2.Name = "Lbl_Check2"
        Me.Lbl_Check2.Size = New System.Drawing.Size(43, 17)
        Me.Lbl_Check2.TabIndex = 21
        Me.Lbl_Check2.Text = "Text2"
        Me.Lbl_Check2.Visible = False
        '
        'CB_FillBySecondPos
        '
        Me.CB_FillBySecondPos.FormattingEnabled = True
        Me.CB_FillBySecondPos.Location = New System.Drawing.Point(508, 69)
        Me.CB_FillBySecondPos.Name = "CB_FillBySecondPos"
        Me.CB_FillBySecondPos.Size = New System.Drawing.Size(63, 24)
        Me.CB_FillBySecondPos.TabIndex = 22
        '
        'CB_Rule2
        '
        Me.CB_Rule2.FormattingEnabled = True
        Me.CB_Rule2.Items.AddRange(New Object() {"=", "<>"})
        Me.CB_Rule2.Location = New System.Drawing.Point(434, 70)
        Me.CB_Rule2.Name = "CB_Rule2"
        Me.CB_Rule2.Size = New System.Drawing.Size(57, 24)
        Me.CB_Rule2.TabIndex = 23
        '
        'CB_FillByDOB
        '
        Me.CB_FillByDOB.FormattingEnabled = True
        Me.CB_FillByDOB.Location = New System.Drawing.Point(601, 68)
        Me.CB_FillByDOB.Name = "CB_FillByDOB"
        Me.CB_FillByDOB.Size = New System.Drawing.Size(124, 24)
        Me.CB_FillByDOB.TabIndex = 24
        '
        'Pic_Start
        '
        Me.Pic_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Start.Image = Global.BasicBasketballSql.My.Resources.Resources.start
        Me.Pic_Start.Location = New System.Drawing.Point(1211, 65)
        Me.Pic_Start.Name = "Pic_Start"
        Me.Pic_Start.Size = New System.Drawing.Size(112, 59)
        Me.Pic_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Start.TabIndex = 33
        Me.Pic_Start.TabStop = False
        '
        'Pic_Reset
        '
        Me.Pic_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Reset.Image = Global.BasicBasketballSql.My.Resources.Resources.reset
        Me.Pic_Reset.Location = New System.Drawing.Point(1211, 3)
        Me.Pic_Reset.Name = "Pic_Reset"
        Me.Pic_Reset.Size = New System.Drawing.Size(112, 59)
        Me.Pic_Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Reset.TabIndex = 32
        Me.Pic_Reset.TabStop = False
        '
        'Pic_Help
        '
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(1350, 3)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(112, 59)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 34
        Me.Pic_Help.TabStop = False
        '
        'BuildMineQueries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 730)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.Pic_Start)
        Me.Controls.Add(Me.Pic_Reset)
        Me.Controls.Add(Me.CB_FillByDOB)
        Me.Controls.Add(Me.CB_Rule2)
        Me.Controls.Add(Me.CB_FillBySecondPos)
        Me.Controls.Add(Me.Tb_Col2)
        Me.Controls.Add(Me.CB_Rule3)
        Me.Controls.Add(Me.Lbl_And)
        Me.Controls.Add(Me.Chb_FAndSpos)
        Me.Controls.Add(Me.CB_FillBySPosition)
        Me.Controls.Add(Me.CB_FillByPosition)
        Me.Controls.Add(Me.CB_FillByHeight)
        Me.Controls.Add(Me.CB_FillByJn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Tb_Col)
        Me.Controls.Add(Me.Lbl_StartCommand)
        Me.Controls.Add(Me.CB_Rule)
        Me.Controls.Add(Me.Lbl_Check)
        Me.Controls.Add(Me.Chb_SecondPos)
        Me.Controls.Add(Me.Chb_Pos)
        Me.Controls.Add(Me.Chb_DOB)
        Me.Controls.Add(Me.Chb_Height)
        Me.Controls.Add(Me.Chb_Jn)
        Me.Controls.Add(Me.Btn_AutoClick)
        Me.Controls.Add(Me.Lbl_Check2)
        Me.Name = "BuildMineQueries"
        Me.Text = "BuildMineQueries"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Reset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chb_Jn As System.Windows.Forms.CheckBox
    Friend WithEvents Chb_Height As System.Windows.Forms.CheckBox
    Friend WithEvents Chb_DOB As System.Windows.Forms.CheckBox
    Friend WithEvents Chb_Pos As System.Windows.Forms.CheckBox
    Friend WithEvents Chb_SecondPos As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Check As System.Windows.Forms.Label
    Friend WithEvents CB_Rule As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_StartCommand As System.Windows.Forms.Label
    Friend WithEvents Tb_Col As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TimerAutoClick As System.Windows.Forms.Timer
    Friend WithEvents Btn_AutoClick As System.Windows.Forms.Button
    Friend WithEvents CB_FillByJn As System.Windows.Forms.ComboBox
    Friend WithEvents CB_FillByHeight As System.Windows.Forms.ComboBox
    Friend WithEvents CB_FillByPosition As System.Windows.Forms.ComboBox
    Friend WithEvents CB_FillBySPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Chb_FAndSpos As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_And As System.Windows.Forms.Label
    Friend WithEvents CB_Rule3 As System.Windows.Forms.ComboBox
    Friend WithEvents Tb_Col2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Check2 As System.Windows.Forms.Label
    Friend WithEvents CB_FillBySecondPos As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Rule2 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_FillByDOB As System.Windows.Forms.ComboBox
    Friend WithEvents Pic_Reset As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Start As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
