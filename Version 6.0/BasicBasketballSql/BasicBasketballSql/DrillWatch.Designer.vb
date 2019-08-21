<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrillWatch
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel_DW = New System.Windows.Forms.Panel()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.Pic_Save = New System.Windows.Forms.PictureBox()
        Me.Pic_Reset = New System.Windows.Forms.PictureBox()
        Me.Tb_TempFailVal = New System.Windows.Forms.TextBox()
        Me.Lbl_DrillCode = New System.Windows.Forms.Label()
        Me.NMB_DrillGoal = New System.Windows.Forms.NumericUpDown()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CB_PlayerCode = New System.Windows.Forms.ComboBox()
        Me.Lbl_Miss = New System.Windows.Forms.Label()
        Me.Lbl_Made = New System.Windows.Forms.Label()
        Me.CB_DrillTypesName = New System.Windows.Forms.ComboBox()
        Me.Lbl_DrillType = New System.Windows.Forms.Label()
        Me.Lbl_DrillChoice = New System.Windows.Forms.Label()
        Me.LV_Pname = New System.Windows.Forms.ListView()
        Me.Tb_SuccessVal = New System.Windows.Forms.TextBox()
        Me.Btn_Miss = New System.Windows.Forms.Button()
        Me.Btn_Success = New System.Windows.Forms.Button()
        Me.Tb_FailVal = New System.Windows.Forms.TextBox()
        Me.CB_Drillsname = New System.Windows.Forms.ComboBox()
        Me.GB_PlayerDetails = New System.Windows.Forms.GroupBox()
        Me.Lbl_Name = New System.Windows.Forms.Label()
        Me.Lbl_Code = New System.Windows.Forms.Label()
        Me.Lbl_CodeNum = New System.Windows.Forms.Label()
        Me.Lbl_Pname = New System.Windows.Forms.Label()
        Me.Lbl_Goal = New System.Windows.Forms.Label()
        Me.Panel_DW.SuspendLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Reset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NMB_DrillGoal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_PlayerDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_DW
        '
        Me.Panel_DW.BackColor = System.Drawing.Color.Transparent
        Me.Panel_DW.Controls.Add(Me.Pic_Help)
        Me.Panel_DW.Controls.Add(Me.Pic_Save)
        Me.Panel_DW.Controls.Add(Me.Pic_Reset)
        Me.Panel_DW.Controls.Add(Me.Tb_TempFailVal)
        Me.Panel_DW.Controls.Add(Me.Lbl_DrillCode)
        Me.Panel_DW.Controls.Add(Me.NMB_DrillGoal)
        Me.Panel_DW.Controls.Add(Me.Chart1)
        Me.Panel_DW.Controls.Add(Me.CB_PlayerCode)
        Me.Panel_DW.Controls.Add(Me.Lbl_Miss)
        Me.Panel_DW.Controls.Add(Me.Lbl_Made)
        Me.Panel_DW.Controls.Add(Me.CB_DrillTypesName)
        Me.Panel_DW.Controls.Add(Me.Lbl_DrillType)
        Me.Panel_DW.Controls.Add(Me.Lbl_DrillChoice)
        Me.Panel_DW.Controls.Add(Me.LV_Pname)
        Me.Panel_DW.Controls.Add(Me.Tb_SuccessVal)
        Me.Panel_DW.Controls.Add(Me.Btn_Miss)
        Me.Panel_DW.Controls.Add(Me.Btn_Success)
        Me.Panel_DW.Controls.Add(Me.Tb_FailVal)
        Me.Panel_DW.Controls.Add(Me.CB_Drillsname)
        Me.Panel_DW.Controls.Add(Me.GB_PlayerDetails)
        Me.Panel_DW.Controls.Add(Me.Lbl_Goal)
        Me.Panel_DW.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_DW.Location = New System.Drawing.Point(13, 2)
        Me.Panel_DW.Name = "Panel_DW"
        Me.Panel_DW.Size = New System.Drawing.Size(1150, 634)
        Me.Panel_DW.TabIndex = 0
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(1020, 437)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(112, 83)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 53
        Me.Pic_Help.TabStop = False
        Me.Pic_Help.Visible = False
        '
        'Pic_Save
        '
        Me.Pic_Save.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Save.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Save.Image = Global.BasicBasketballSql.My.Resources.Resources.saveicon
        Me.Pic_Save.Location = New System.Drawing.Point(1020, 310)
        Me.Pic_Save.Name = "Pic_Save"
        Me.Pic_Save.Size = New System.Drawing.Size(112, 83)
        Me.Pic_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Save.TabIndex = 50
        Me.Pic_Save.TabStop = False
        Me.Pic_Save.Visible = False
        '
        'Pic_Reset
        '
        Me.Pic_Reset.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Reset.Image = Global.BasicBasketballSql.My.Resources.Resources.reset
        Me.Pic_Reset.Location = New System.Drawing.Point(1020, 191)
        Me.Pic_Reset.Name = "Pic_Reset"
        Me.Pic_Reset.Size = New System.Drawing.Size(112, 83)
        Me.Pic_Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Reset.TabIndex = 52
        Me.Pic_Reset.TabStop = False
        '
        'Tb_TempFailVal
        '
        Me.Tb_TempFailVal.Enabled = False
        Me.Tb_TempFailVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_TempFailVal.Location = New System.Drawing.Point(712, 497)
        Me.Tb_TempFailVal.Name = "Tb_TempFailVal"
        Me.Tb_TempFailVal.Size = New System.Drawing.Size(75, 30)
        Me.Tb_TempFailVal.TabIndex = 51
        Me.Tb_TempFailVal.Text = "0"
        Me.Tb_TempFailVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_DrillCode
        '
        Me.Lbl_DrillCode.AutoSize = True
        Me.Lbl_DrillCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DrillCode.Location = New System.Drawing.Point(97, 4)
        Me.Lbl_DrillCode.Name = "Lbl_DrillCode"
        Me.Lbl_DrillCode.Size = New System.Drawing.Size(103, 23)
        Me.Lbl_DrillCode.TabIndex = 49
        Me.Lbl_DrillCode.Text = "Drill code"
        Me.Lbl_DrillCode.Visible = False
        '
        'NMB_DrillGoal
        '
        Me.NMB_DrillGoal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NMB_DrillGoal.Location = New System.Drawing.Point(809, 101)
        Me.NMB_DrillGoal.Name = "NMB_DrillGoal"
        Me.NMB_DrillGoal.Size = New System.Drawing.Size(242, 32)
        Me.NMB_DrillGoal.TabIndex = 48
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(284, 170)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 6
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Green
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Green
        Series1.MarkerSize = 16
        Series1.Name = "Success"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.MarkerColor = System.Drawing.Color.Red
        Series2.MarkerSize = 16
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross
        Series2.Name = "Failed"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(687, 319)
        Me.Chart1.TabIndex = 47
        Me.Chart1.Text = "Chart1"
        '
        'CB_PlayerCode
        '
        Me.CB_PlayerCode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PlayerCode.FormattingEnabled = True
        Me.CB_PlayerCode.Location = New System.Drawing.Point(9, 30)
        Me.CB_PlayerCode.Name = "CB_PlayerCode"
        Me.CB_PlayerCode.Size = New System.Drawing.Size(248, 31)
        Me.CB_PlayerCode.TabIndex = 46
        Me.CB_PlayerCode.Tag = "0"
        Me.CB_PlayerCode.Text = "Choice player code"
        '
        'Lbl_Miss
        '
        Me.Lbl_Miss.AutoSize = True
        Me.Lbl_Miss.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Miss.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Miss.Location = New System.Drawing.Point(804, 500)
        Me.Lbl_Miss.Name = "Lbl_Miss"
        Me.Lbl_Miss.Size = New System.Drawing.Size(57, 25)
        Me.Lbl_Miss.TabIndex = 45
        Me.Lbl_Miss.Text = "Miss"
        '
        'Lbl_Made
        '
        Me.Lbl_Made.AutoSize = True
        Me.Lbl_Made.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Made.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Made.Location = New System.Drawing.Point(537, 500)
        Me.Lbl_Made.Name = "Lbl_Made"
        Me.Lbl_Made.Size = New System.Drawing.Size(79, 25)
        Me.Lbl_Made.TabIndex = 44
        Me.Lbl_Made.Text = "Made"
        '
        'CB_DrillTypesName
        '
        Me.CB_DrillTypesName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_DrillTypesName.FormattingEnabled = True
        Me.CB_DrillTypesName.Items.AddRange(New Object() {"Offense", "Defense", "Others"})
        Me.CB_DrillTypesName.Location = New System.Drawing.Point(809, 7)
        Me.CB_DrillTypesName.Name = "CB_DrillTypesName"
        Me.CB_DrillTypesName.Size = New System.Drawing.Size(242, 31)
        Me.CB_DrillTypesName.TabIndex = 43
        Me.CB_DrillTypesName.Tag = "0"
        Me.CB_DrillTypesName.Text = "Drill category"
        '
        'Lbl_DrillType
        '
        Me.Lbl_DrillType.AutoSize = True
        Me.Lbl_DrillType.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DrillType.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.Lbl_DrillType.Location = New System.Drawing.Point(659, 10)
        Me.Lbl_DrillType.Name = "Lbl_DrillType"
        Me.Lbl_DrillType.Size = New System.Drawing.Size(113, 25)
        Me.Lbl_DrillType.TabIndex = 42
        Me.Lbl_DrillType.Text = "Drill type:"
        '
        'Lbl_DrillChoice
        '
        Me.Lbl_DrillChoice.AutoSize = True
        Me.Lbl_DrillChoice.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DrillChoice.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.Lbl_DrillChoice.Location = New System.Drawing.Point(659, 56)
        Me.Lbl_DrillChoice.Name = "Lbl_DrillChoice"
        Me.Lbl_DrillChoice.Size = New System.Drawing.Size(139, 25)
        Me.Lbl_DrillChoice.TabIndex = 40
        Me.Lbl_DrillChoice.Text = "Choice drill:"
        '
        'LV_Pname
        '
        Me.LV_Pname.Enabled = False
        Me.LV_Pname.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_Pname.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_Pname.Location = New System.Drawing.Point(9, 118)
        Me.LV_Pname.Name = "LV_Pname"
        Me.LV_Pname.Scrollable = False
        Me.LV_Pname.Size = New System.Drawing.Size(248, 371)
        Me.LV_Pname.TabIndex = 39
        Me.LV_Pname.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_Pname.UseCompatibleStateImageBehavior = False
        Me.LV_Pname.View = System.Windows.Forms.View.Tile
        '
        'Tb_SuccessVal
        '
        Me.Tb_SuccessVal.Enabled = False
        Me.Tb_SuccessVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_SuccessVal.Location = New System.Drawing.Point(443, 495)
        Me.Tb_SuccessVal.Name = "Tb_SuccessVal"
        Me.Tb_SuccessVal.Size = New System.Drawing.Size(75, 30)
        Me.Tb_SuccessVal.TabIndex = 37
        Me.Tb_SuccessVal.Text = "0"
        Me.Tb_SuccessVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Miss
        '
        Me.Btn_Miss.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Btn_Miss.Location = New System.Drawing.Point(712, 556)
        Me.Btn_Miss.Name = "Btn_Miss"
        Me.Btn_Miss.Size = New System.Drawing.Size(112, 65)
        Me.Btn_Miss.TabIndex = 36
        Me.Btn_Miss.Text = "Miss"
        Me.Btn_Miss.UseVisualStyleBackColor = True
        '
        'Btn_Success
        '
        Me.Btn_Success.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Btn_Success.Location = New System.Drawing.Point(443, 556)
        Me.Btn_Success.Name = "Btn_Success"
        Me.Btn_Success.Size = New System.Drawing.Size(123, 65)
        Me.Btn_Success.TabIndex = 35
        Me.Btn_Success.Text = "Success"
        Me.Btn_Success.UseVisualStyleBackColor = True
        '
        'Tb_FailVal
        '
        Me.Tb_FailVal.Enabled = False
        Me.Tb_FailVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_FailVal.Location = New System.Drawing.Point(712, 497)
        Me.Tb_FailVal.Name = "Tb_FailVal"
        Me.Tb_FailVal.Size = New System.Drawing.Size(75, 30)
        Me.Tb_FailVal.TabIndex = 38
        Me.Tb_FailVal.Text = "0"
        Me.Tb_FailVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tb_FailVal.Visible = False
        '
        'CB_Drillsname
        '
        Me.CB_Drillsname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Drillsname.FormattingEnabled = True
        Me.CB_Drillsname.Location = New System.Drawing.Point(809, 50)
        Me.CB_Drillsname.Name = "CB_Drillsname"
        Me.CB_Drillsname.Size = New System.Drawing.Size(242, 31)
        Me.CB_Drillsname.TabIndex = 41
        Me.CB_Drillsname.Tag = "0"
        Me.CB_Drillsname.Text = "Drill options"
        '
        'GB_PlayerDetails
        '
        Me.GB_PlayerDetails.BackColor = System.Drawing.Color.Transparent
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_Name)
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_Code)
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_CodeNum)
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_Pname)
        Me.GB_PlayerDetails.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.GB_PlayerDetails.Location = New System.Drawing.Point(284, 48)
        Me.GB_PlayerDetails.Name = "GB_PlayerDetails"
        Me.GB_PlayerDetails.Size = New System.Drawing.Size(369, 116)
        Me.GB_PlayerDetails.TabIndex = 34
        Me.GB_PlayerDetails.TabStop = False
        Me.GB_PlayerDetails.Text = "Player details"
        '
        'Lbl_Name
        '
        Me.Lbl_Name.AutoSize = True
        Me.Lbl_Name.Location = New System.Drawing.Point(126, 79)
        Me.Lbl_Name.Name = "Lbl_Name"
        Me.Lbl_Name.Size = New System.Drawing.Size(30, 25)
        Me.Lbl_Name.TabIndex = 5
        Me.Lbl_Name.Text = "..."
        '
        'Lbl_Code
        '
        Me.Lbl_Code.AutoSize = True
        Me.Lbl_Code.Location = New System.Drawing.Point(126, 37)
        Me.Lbl_Code.Name = "Lbl_Code"
        Me.Lbl_Code.Size = New System.Drawing.Size(30, 25)
        Me.Lbl_Code.TabIndex = 3
        Me.Lbl_Code.Text = "..."
        '
        'Lbl_CodeNum
        '
        Me.Lbl_CodeNum.AutoSize = True
        Me.Lbl_CodeNum.Location = New System.Drawing.Point(6, 37)
        Me.Lbl_CodeNum.Name = "Lbl_CodeNum"
        Me.Lbl_CodeNum.Size = New System.Drawing.Size(79, 25)
        Me.Lbl_CodeNum.TabIndex = 2
        Me.Lbl_CodeNum.Text = "Code:"
        '
        'Lbl_Pname
        '
        Me.Lbl_Pname.AutoSize = True
        Me.Lbl_Pname.Location = New System.Drawing.Point(6, 79)
        Me.Lbl_Pname.Name = "Lbl_Pname"
        Me.Lbl_Pname.Size = New System.Drawing.Size(85, 25)
        Me.Lbl_Pname.TabIndex = 0
        Me.Lbl_Pname.Text = "Name:"
        '
        'Lbl_Goal
        '
        Me.Lbl_Goal.AutoSize = True
        Me.Lbl_Goal.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Goal.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.Lbl_Goal.Location = New System.Drawing.Point(659, 104)
        Me.Lbl_Goal.Name = "Lbl_Goal"
        Me.Lbl_Goal.Size = New System.Drawing.Size(113, 25)
        Me.Lbl_Goal.TabIndex = 33
        Me.Lbl_Goal.Text = "Drill goal:"
        '
        'DrillWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 647)
        Me.Controls.Add(Me.Panel_DW)
        Me.Name = "DrillWatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DrillWatch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_DW.ResumeLayout(False)
        Me.Panel_DW.PerformLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Reset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NMB_DrillGoal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_PlayerDetails.ResumeLayout(False)
        Me.GB_PlayerDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_DW As System.Windows.Forms.Panel
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Save As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Reset As System.Windows.Forms.PictureBox
    Friend WithEvents Tb_TempFailVal As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_DrillCode As System.Windows.Forms.Label
    Friend WithEvents NMB_DrillGoal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CB_PlayerCode As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Miss As System.Windows.Forms.Label
    Friend WithEvents Lbl_Made As System.Windows.Forms.Label
    Friend WithEvents CB_DrillTypesName As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_DrillType As System.Windows.Forms.Label
    Friend WithEvents Lbl_DrillChoice As System.Windows.Forms.Label
    Friend WithEvents LV_Pname As System.Windows.Forms.ListView
    Friend WithEvents Tb_SuccessVal As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Miss As System.Windows.Forms.Button
    Friend WithEvents Btn_Success As System.Windows.Forms.Button
    Friend WithEvents Tb_FailVal As System.Windows.Forms.TextBox
    Friend WithEvents CB_Drillsname As System.Windows.Forms.ComboBox
    Friend WithEvents GB_PlayerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_Code As System.Windows.Forms.Label
    Friend WithEvents Lbl_CodeNum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Pname As System.Windows.Forms.Label
    Friend WithEvents Lbl_Goal As System.Windows.Forms.Label
End Class
