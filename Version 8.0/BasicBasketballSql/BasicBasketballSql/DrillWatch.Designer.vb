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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TLP_Buttom = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_MadeControls = New System.Windows.Forms.Panel()
        Me.Lbl_Made = New System.Windows.Forms.Label()
        Me.Tb_SuccessVal = New System.Windows.Forms.TextBox()
        Me.Panel_MissControls = New System.Windows.Forms.Panel()
        Me.Lbl_Miss = New System.Windows.Forms.Label()
        Me.Tb_FailVal = New System.Windows.Forms.TextBox()
        Me.Tb_TempFailVal = New System.Windows.Forms.TextBox()
        Me.Btn_Success = New System.Windows.Forms.Button()
        Me.Btn_Miss = New System.Windows.Forms.Button()
        Me.Tb_TriesVal = New System.Windows.Forms.TextBox()
        Me.CB_PlayerCode = New System.Windows.Forms.ComboBox()
        Me.CB_DrillTypesName = New System.Windows.Forms.ComboBox()
        Me.CB_Drillsname = New System.Windows.Forms.ComboBox()
        Me.Lbl_DrillCode = New System.Windows.Forms.Label()
        Me.LV_Pname = New System.Windows.Forms.ListView()
        Me.GB_PlayerDetails = New System.Windows.Forms.GroupBox()
        Me.Lbl_Name = New System.Windows.Forms.Label()
        Me.Lbl_Code = New System.Windows.Forms.Label()
        Me.Lbl_CodeNum = New System.Windows.Forms.Label()
        Me.Lbl_Pname = New System.Windows.Forms.Label()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.FLP_Menu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.Btn_Help = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel_DW = New System.Windows.Forms.Panel()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.CB_PlayersName = New System.Windows.Forms.ComboBox()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Panel_TopLeft = New System.Windows.Forms.Panel()
        Me.TLP_Buttom.SuspendLayout()
        Me.Panel_MadeControls.SuspendLayout()
        Me.Panel_MissControls.SuspendLayout()
        Me.GB_PlayerDetails.SuspendLayout()
        Me.Panel_Right.SuspendLayout()
        Me.FLP_Menu.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_DW.SuspendLayout()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP_Buttom
        '
        Me.TLP_Buttom.BackColor = System.Drawing.Color.Transparent
        Me.TLP_Buttom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLP_Buttom.ColumnCount = 2
        Me.TLP_Buttom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Buttom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Buttom.Controls.Add(Me.Panel_MadeControls, 0, 0)
        Me.TLP_Buttom.Controls.Add(Me.Panel_MissControls, 1, 0)
        Me.TLP_Buttom.Controls.Add(Me.Btn_Success, 0, 1)
        Me.TLP_Buttom.Controls.Add(Me.Btn_Miss, 1, 1)
        Me.TLP_Buttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP_Buttom.Location = New System.Drawing.Point(201, 592)
        Me.TLP_Buttom.Name = "TLP_Buttom"
        Me.TLP_Buttom.RowCount = 2
        Me.TLP_Buttom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Buttom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Buttom.Size = New System.Drawing.Size(1422, 111)
        Me.TLP_Buttom.TabIndex = 55
        '
        'Panel_MadeControls
        '
        Me.Panel_MadeControls.Controls.Add(Me.Lbl_Made)
        Me.Panel_MadeControls.Controls.Add(Me.Tb_SuccessVal)
        Me.Panel_MadeControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MadeControls.Location = New System.Drawing.Point(4, 4)
        Me.Panel_MadeControls.Name = "Panel_MadeControls"
        Me.Panel_MadeControls.Size = New System.Drawing.Size(703, 48)
        Me.Panel_MadeControls.TabIndex = 0
        '
        'Lbl_Made
        '
        Me.Lbl_Made.AutoSize = True
        Me.Lbl_Made.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Made.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_Made.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Made.Location = New System.Drawing.Point(334, 14)
        Me.Lbl_Made.Name = "Lbl_Made"
        Me.Lbl_Made.Size = New System.Drawing.Size(84, 30)
        Me.Lbl_Made.TabIndex = 44
        Me.Lbl_Made.Text = "Made"
        '
        'Tb_SuccessVal
        '
        Me.Tb_SuccessVal.Enabled = False
        Me.Tb_SuccessVal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_SuccessVal.Location = New System.Drawing.Point(242, 7)
        Me.Tb_SuccessVal.Name = "Tb_SuccessVal"
        Me.Tb_SuccessVal.Size = New System.Drawing.Size(75, 32)
        Me.Tb_SuccessVal.TabIndex = 37
        Me.Tb_SuccessVal.Text = "0"
        Me.Tb_SuccessVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_MissControls
        '
        Me.Panel_MissControls.Controls.Add(Me.Lbl_Miss)
        Me.Panel_MissControls.Controls.Add(Me.Tb_FailVal)
        Me.Panel_MissControls.Controls.Add(Me.Tb_TempFailVal)
        Me.Panel_MissControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MissControls.Location = New System.Drawing.Point(714, 4)
        Me.Panel_MissControls.Name = "Panel_MissControls"
        Me.Panel_MissControls.Size = New System.Drawing.Size(704, 48)
        Me.Panel_MissControls.TabIndex = 1
        '
        'Lbl_Miss
        '
        Me.Lbl_Miss.AutoSize = True
        Me.Lbl_Miss.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Miss.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_Miss.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Miss.Location = New System.Drawing.Point(282, 14)
        Me.Lbl_Miss.Name = "Lbl_Miss"
        Me.Lbl_Miss.Size = New System.Drawing.Size(62, 30)
        Me.Lbl_Miss.TabIndex = 45
        Me.Lbl_Miss.Text = "Miss"
        '
        'Tb_FailVal
        '
        Me.Tb_FailVal.Enabled = False
        Me.Tb_FailVal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_FailVal.Location = New System.Drawing.Point(190, 9)
        Me.Tb_FailVal.Name = "Tb_FailVal"
        Me.Tb_FailVal.Size = New System.Drawing.Size(75, 32)
        Me.Tb_FailVal.TabIndex = 38
        Me.Tb_FailVal.Text = "0"
        Me.Tb_FailVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tb_FailVal.Visible = False
        '
        'Tb_TempFailVal
        '
        Me.Tb_TempFailVal.Enabled = False
        Me.Tb_TempFailVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_TempFailVal.Location = New System.Drawing.Point(190, 9)
        Me.Tb_TempFailVal.Name = "Tb_TempFailVal"
        Me.Tb_TempFailVal.Size = New System.Drawing.Size(75, 30)
        Me.Tb_TempFailVal.TabIndex = 51
        Me.Tb_TempFailVal.Text = "0"
        Me.Tb_TempFailVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Success
        '
        Me.Btn_Success.BackColor = System.Drawing.Color.White
        Me.Btn_Success.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Success.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Btn_Success.FlatAppearance.BorderSize = 3
        Me.Btn_Success.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Success.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Success.ForeColor = System.Drawing.Color.Green
        Me.Btn_Success.Location = New System.Drawing.Point(4, 59)
        Me.Btn_Success.Name = "Btn_Success"
        Me.Btn_Success.Size = New System.Drawing.Size(703, 48)
        Me.Btn_Success.TabIndex = 35
        Me.Btn_Success.Text = "Success"
        Me.Btn_Success.UseVisualStyleBackColor = False
        '
        'Btn_Miss
        '
        Me.Btn_Miss.BackColor = System.Drawing.Color.White
        Me.Btn_Miss.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Miss.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Btn_Miss.FlatAppearance.BorderSize = 3
        Me.Btn_Miss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Miss.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Miss.ForeColor = System.Drawing.Color.Red
        Me.Btn_Miss.Location = New System.Drawing.Point(714, 59)
        Me.Btn_Miss.Name = "Btn_Miss"
        Me.Btn_Miss.Size = New System.Drawing.Size(704, 48)
        Me.Btn_Miss.TabIndex = 36
        Me.Btn_Miss.Text = "Miss"
        Me.Btn_Miss.UseVisualStyleBackColor = False
        '
        'Tb_TriesVal
        '
        Me.Tb_TriesVal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Tb_TriesVal.Location = New System.Drawing.Point(888, 6)
        Me.Tb_TriesVal.Name = "Tb_TriesVal"
        Me.Tb_TriesVal.Size = New System.Drawing.Size(261, 32)
        Me.Tb_TriesVal.TabIndex = 4
        Me.Tb_TriesVal.Tag = "1"
        Me.Tb_TriesVal.Text = "How many attempts?"
        '
        'CB_PlayerCode
        '
        Me.CB_PlayerCode.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CB_PlayerCode.FormattingEnabled = True
        Me.CB_PlayerCode.Location = New System.Drawing.Point(6, 6)
        Me.CB_PlayerCode.Name = "CB_PlayerCode"
        Me.CB_PlayerCode.Size = New System.Drawing.Size(261, 31)
        Me.CB_PlayerCode.TabIndex = 1
        Me.CB_PlayerCode.Tag = "0"
        Me.CB_PlayerCode.Text = "Choice player code"
        '
        'CB_DrillTypesName
        '
        Me.CB_DrillTypesName.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CB_DrillTypesName.FormattingEnabled = True
        Me.CB_DrillTypesName.Items.AddRange(New Object() {"Offense", "Defense", "Others"})
        Me.CB_DrillTypesName.Location = New System.Drawing.Point(300, 6)
        Me.CB_DrillTypesName.Name = "CB_DrillTypesName"
        Me.CB_DrillTypesName.Size = New System.Drawing.Size(261, 31)
        Me.CB_DrillTypesName.TabIndex = 2
        Me.CB_DrillTypesName.Tag = "0"
        Me.CB_DrillTypesName.Text = "Drill category"
        '
        'CB_Drillsname
        '
        Me.CB_Drillsname.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CB_Drillsname.FormattingEnabled = True
        Me.CB_Drillsname.Location = New System.Drawing.Point(594, 6)
        Me.CB_Drillsname.Name = "CB_Drillsname"
        Me.CB_Drillsname.Size = New System.Drawing.Size(261, 31)
        Me.CB_Drillsname.TabIndex = 3
        Me.CB_Drillsname.Tag = "0"
        Me.CB_Drillsname.Text = "Drill options"
        '
        'Lbl_DrillCode
        '
        Me.Lbl_DrillCode.AutoSize = True
        Me.Lbl_DrillCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DrillCode.Location = New System.Drawing.Point(175, 79)
        Me.Lbl_DrillCode.Name = "Lbl_DrillCode"
        Me.Lbl_DrillCode.Size = New System.Drawing.Size(114, 25)
        Me.Lbl_DrillCode.TabIndex = 49
        Me.Lbl_DrillCode.Text = "Drill code"
        Me.Lbl_DrillCode.Visible = False
        '
        'LV_Pname
        '
        Me.LV_Pname.Enabled = False
        Me.LV_Pname.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LV_Pname.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_Pname.Location = New System.Drawing.Point(11, 122)
        Me.LV_Pname.Name = "LV_Pname"
        Me.LV_Pname.Scrollable = False
        Me.LV_Pname.Size = New System.Drawing.Size(269, 428)
        Me.LV_Pname.TabIndex = 39
        Me.LV_Pname.TileSize = New System.Drawing.Size(215, 25)
        Me.LV_Pname.UseCompatibleStateImageBehavior = False
        Me.LV_Pname.View = System.Windows.Forms.View.Tile
        '
        'GB_PlayerDetails
        '
        Me.GB_PlayerDetails.BackColor = System.Drawing.Color.Transparent
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_Name)
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_Code)
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_CodeNum)
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_Pname)
        Me.GB_PlayerDetails.Controls.Add(Me.Lbl_DrillCode)
        Me.GB_PlayerDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.GB_PlayerDetails.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.GB_PlayerDetails.ForeColor = System.Drawing.Color.Black
        Me.GB_PlayerDetails.Location = New System.Drawing.Point(0, 0)
        Me.GB_PlayerDetails.Name = "GB_PlayerDetails"
        Me.GB_PlayerDetails.Size = New System.Drawing.Size(292, 116)
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
        'Panel_Right
        '
        Me.Panel_Right.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Panel_Right.Controls.Add(Me.GB_PlayerDetails)
        Me.Panel_Right.Controls.Add(Me.LV_Pname)
        Me.Panel_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Right.Location = New System.Drawing.Point(1623, 0)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(292, 703)
        Me.Panel_Right.TabIndex = 2
        Me.Panel_Right.Visible = False
        '
        'FLP_Menu
        '
        Me.FLP_Menu.BackColor = System.Drawing.Color.Transparent
        Me.FLP_Menu.Controls.Add(Me.Btn_Save)
        Me.FLP_Menu.Controls.Add(Me.Btn_Reset)
        Me.FLP_Menu.Controls.Add(Me.Btn_Help)
        Me.FLP_Menu.Location = New System.Drawing.Point(12, 213)
        Me.FLP_Menu.Name = "FLP_Menu"
        Me.FLP_Menu.Size = New System.Drawing.Size(163, 245)
        Me.FLP_Menu.TabIndex = 0
        '
        'Btn_Save
        '
        Me.Btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Save.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Save.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(159, 75)
        Me.Btn_Save.TabIndex = 5
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = False
        Me.Btn_Save.Visible = False
        '
        'Btn_Reset
        '
        Me.Btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Btn_Reset.FlatAppearance.BorderSize = 0
        Me.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Reset.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Reset.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Reset.Location = New System.Drawing.Point(3, 84)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(159, 75)
        Me.Btn_Reset.TabIndex = 6
        Me.Btn_Reset.Text = "Reset"
        Me.Btn_Reset.UseVisualStyleBackColor = False
        '
        'Btn_Help
        '
        Me.Btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Btn_Help.FlatAppearance.BorderSize = 0
        Me.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Help.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Help.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Help.Location = New System.Drawing.Point(3, 165)
        Me.Btn_Help.Name = "Btn_Help"
        Me.Btn_Help.Size = New System.Drawing.Size(159, 75)
        Me.Btn_Help.TabIndex = 7
        Me.Btn_Help.Text = "Help"
        Me.Btn_Help.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(201, 46)
        Me.Chart1.Name = "Chart1"
        Series3.BorderWidth = 6
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.Green
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.Legend = "Legend1"
        Series3.MarkerColor = System.Drawing.Color.Green
        Series3.MarkerSize = 16
        Series3.Name = "Success"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Legend = "Legend1"
        Series4.MarkerColor = System.Drawing.Color.Red
        Series4.MarkerSize = 16
        Series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross
        Series4.Name = "Failed"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(1422, 657)
        Me.Chart1.TabIndex = 47
        Me.Chart1.Text = "Chart1"
        '
        'Panel_DW
        '
        Me.Panel_DW.Controls.Add(Me.TLP_Buttom)
        Me.Panel_DW.Controls.Add(Me.Chart1)
        Me.Panel_DW.Controls.Add(Me.Panel_Top)
        Me.Panel_DW.Controls.Add(Me.Panel_Left)
        Me.Panel_DW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_DW.Location = New System.Drawing.Point(0, 0)
        Me.Panel_DW.Name = "Panel_DW"
        Me.Panel_DW.Size = New System.Drawing.Size(1623, 703)
        Me.Panel_DW.TabIndex = 3
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Tb_TriesVal)
        Me.Panel_Top.Controls.Add(Me.CB_PlayersName)
        Me.Panel_Top.Controls.Add(Me.CB_Drillsname)
        Me.Panel_Top.Controls.Add(Me.CB_DrillTypesName)
        Me.Panel_Top.Controls.Add(Me.CB_PlayerCode)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(201, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1422, 46)
        Me.Panel_Top.TabIndex = 56
        '
        'CB_PlayersName
        '
        Me.CB_PlayersName.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CB_PlayersName.FormattingEnabled = True
        Me.CB_PlayersName.Location = New System.Drawing.Point(7, 6)
        Me.CB_PlayersName.Name = "CB_PlayersName"
        Me.CB_PlayersName.Size = New System.Drawing.Size(261, 31)
        Me.CB_PlayersName.TabIndex = 5
        Me.CB_PlayersName.Tag = "0"
        Me.CB_PlayersName.Text = "Player name"
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Left.Controls.Add(Me.Panel_TopLeft)
        Me.Panel_Left.Controls.Add(Me.FLP_Menu)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(201, 703)
        Me.Panel_Left.TabIndex = 57
        '
        'Panel_TopLeft
        '
        Me.Panel_TopLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_TopLeft.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TopLeft.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TopLeft.Name = "Panel_TopLeft"
        Me.Panel_TopLeft.Size = New System.Drawing.Size(201, 46)
        Me.Panel_TopLeft.TabIndex = 1
        '
        'DrillWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1915, 703)
        Me.Controls.Add(Me.Panel_DW)
        Me.Controls.Add(Me.Panel_Right)
        Me.Name = "DrillWatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DrillWatch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TLP_Buttom.ResumeLayout(False)
        Me.Panel_MadeControls.ResumeLayout(False)
        Me.Panel_MadeControls.PerformLayout()
        Me.Panel_MissControls.ResumeLayout(False)
        Me.Panel_MissControls.PerformLayout()
        Me.GB_PlayerDetails.ResumeLayout(False)
        Me.GB_PlayerDetails.PerformLayout()
        Me.Panel_Right.ResumeLayout(False)
        Me.FLP_Menu.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_DW.ResumeLayout(False)
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.Panel_Left.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tb_TempFailVal As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_DrillCode As System.Windows.Forms.Label
    Friend WithEvents CB_PlayerCode As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Miss As System.Windows.Forms.Label
    Friend WithEvents Lbl_Made As System.Windows.Forms.Label
    Friend WithEvents CB_DrillTypesName As System.Windows.Forms.ComboBox
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
    Friend WithEvents Tb_TriesVal As System.Windows.Forms.TextBox
    Friend WithEvents TLP_Buttom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_MadeControls As System.Windows.Forms.Panel
    Friend WithEvents Panel_MissControls As System.Windows.Forms.Panel
    Friend WithEvents Panel_Right As System.Windows.Forms.Panel
    Friend WithEvents FLP_Menu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents Btn_Reset As System.Windows.Forms.Button
    Friend WithEvents Btn_Help As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel_DW As System.Windows.Forms.Panel
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents CB_PlayersName As System.Windows.Forms.ComboBox
    Friend WithEvents Panel_Left As System.Windows.Forms.Panel
    Friend WithEvents Panel_TopLeft As System.Windows.Forms.Panel
End Class
