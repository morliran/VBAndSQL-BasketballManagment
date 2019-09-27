<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayersMatchStatistics
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
        Me.Lbl_AddPStats = New System.Windows.Forms.Label()
        Me.Lbl_FormBack = New System.Windows.Forms.Label()
        Me.Tb_ValToSQL = New System.Windows.Forms.TextBox()
        Me.Lbl_TotalPlayersLeft = New System.Windows.Forms.Label()
        Me.Lb_CodeBox = New System.Windows.Forms.ListBox()
        Me.Lbl_CheckTotal = New System.Windows.Forms.Label()
        Me.Tb_TeamsNames = New System.Windows.Forms.TextBox()
        Me.CB_PlayerMatchCode = New System.Windows.Forms.ComboBox()
        Me.Tb_PID = New System.Windows.Forms.TextBox()
        Me.Tb_FN = New System.Windows.Forms.TextBox()
        Me.Tb_LN = New System.Windows.Forms.TextBox()
        Me.FLP_Top = New System.Windows.Forms.FlowLayoutPanel()
        Me.FLP_DisplayLeft = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel_Display = New System.Windows.Forms.Panel()
        Me.Panel_StatsData = New System.Windows.Forms.Panel()
        Me.Panel_StatsControlers = New System.Windows.Forms.Panel()
        Me.CB_PMatchNames = New System.Windows.Forms.ComboBox()
        Me.Lbl_Rebound = New System.Windows.Forms.Label()
        Me.Lbl_Steel = New System.Windows.Forms.Label()
        Me.Tb_Assist = New System.Windows.Forms.TextBox()
        Me.Tb_Rebound = New System.Windows.Forms.TextBox()
        Me.Lbl_Block = New System.Windows.Forms.Label()
        Me.Lbl_Points = New System.Windows.Forms.Label()
        Me.Tb_Steel = New System.Windows.Forms.TextBox()
        Me.Tb_Points = New System.Windows.Forms.TextBox()
        Me.Tb_Block = New System.Windows.Forms.TextBox()
        Me.Lbl_Assist = New System.Windows.Forms.Label()
        Me.Lbl_LExplain = New System.Windows.Forms.Label()
        Me.TLP_GameData = New System.Windows.Forms.TableLayoutPanel()
        Me.Tb_GamesTypes = New System.Windows.Forms.TextBox()
        Me.TB_GamesCodes = New System.Windows.Forms.TextBox()
        Me.Lbl_GamesCodes = New System.Windows.Forms.Label()
        Me.Tb_GamesDate = New System.Windows.Forms.TextBox()
        Me.Lbl_GamesDate = New System.Windows.Forms.Label()
        Me.Lbl_GamesTypes = New System.Windows.Forms.Label()
        Me.TLP_Buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.Btn_AllZero = New System.Windows.Forms.Button()
        Me.Btn_PMatchSave = New System.Windows.Forms.Button()
        Me.Btn_PMatchUpdate = New System.Windows.Forms.Button()
        Me.Btn_PMatchHelp = New System.Windows.Forms.Button()
        Me.Lb_NameBox = New System.Windows.Forms.ListBox()
        Me.Panel_DisplayTop = New System.Windows.Forms.Panel()
        Me.Panel_Welcome = New System.Windows.Forms.Panel()
        Me.Panel_CenterButtom = New System.Windows.Forms.Panel()
        Me.Tb_Temp = New System.Windows.Forms.TextBox()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Panel_Center = New System.Windows.Forms.Panel()
        Me.Lbl_FinishInsert = New System.Windows.Forms.Label()
        Me.FLP_Top.SuspendLayout()
        Me.FLP_DisplayLeft.SuspendLayout()
        Me.Panel_Display.SuspendLayout()
        Me.Panel_StatsData.SuspendLayout()
        Me.Panel_StatsControlers.SuspendLayout()
        Me.TLP_GameData.SuspendLayout()
        Me.TLP_Buttons.SuspendLayout()
        Me.Panel_DisplayTop.SuspendLayout()
        Me.Panel_Welcome.SuspendLayout()
        Me.Panel_CenterButtom.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        Me.Panel_Center.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_AddPStats
        '
        Me.Lbl_AddPStats.AutoSize = True
        Me.Lbl_AddPStats.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_AddPStats.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_AddPStats.ForeColor = System.Drawing.Color.Black
        Me.Lbl_AddPStats.Location = New System.Drawing.Point(7, 5)
        Me.Lbl_AddPStats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_AddPStats.Name = "Lbl_AddPStats"
        Me.Lbl_AddPStats.Size = New System.Drawing.Size(212, 30)
        Me.Lbl_AddPStats.TabIndex = 0
        Me.Lbl_AddPStats.Text = "Add Players Stats"
        '
        'Lbl_FormBack
        '
        Me.Lbl_FormBack.AutoSize = True
        Me.Lbl_FormBack.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Lbl_FormBack.ForeColor = System.Drawing.Color.White
        Me.Lbl_FormBack.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_FormBack.Name = "Lbl_FormBack"
        Me.Lbl_FormBack.Size = New System.Drawing.Size(90, 21)
        Me.Lbl_FormBack.TabIndex = 69
        Me.Lbl_FormBack.Text = "Back to..."
        Me.Lbl_FormBack.Visible = False
        '
        'Tb_ValToSQL
        '
        Me.Tb_ValToSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tb_ValToSQL.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Tb_ValToSQL.Location = New System.Drawing.Point(0, 0)
        Me.Tb_ValToSQL.Name = "Tb_ValToSQL"
        Me.Tb_ValToSQL.Size = New System.Drawing.Size(1096, 32)
        Me.Tb_ValToSQL.TabIndex = 14
        '
        'Lbl_TotalPlayersLeft
        '
        Me.Lbl_TotalPlayersLeft.AutoSize = True
        Me.Lbl_TotalPlayersLeft.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TotalPlayersLeft.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_TotalPlayersLeft.ForeColor = System.Drawing.Color.Black
        Me.Lbl_TotalPlayersLeft.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_TotalPlayersLeft.Name = "Lbl_TotalPlayersLeft"
        Me.Lbl_TotalPlayersLeft.Size = New System.Drawing.Size(216, 30)
        Me.Lbl_TotalPlayersLeft.TabIndex = 11
        Me.Lbl_TotalPlayersLeft.Text = "Total Players Left:"
        '
        'Lb_CodeBox
        '
        Me.Lb_CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lb_CodeBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lb_CodeBox.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Lb_CodeBox.FormattingEnabled = True
        Me.Lb_CodeBox.ItemHeight = 23
        Me.Lb_CodeBox.Location = New System.Drawing.Point(0, 0)
        Me.Lb_CodeBox.Name = "Lb_CodeBox"
        Me.Lb_CodeBox.Size = New System.Drawing.Size(205, 276)
        Me.Lb_CodeBox.TabIndex = 68
        Me.Lb_CodeBox.Visible = False
        '
        'Lbl_CheckTotal
        '
        Me.Lbl_CheckTotal.AutoSize = True
        Me.Lbl_CheckTotal.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CheckTotal.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_CheckTotal.ForeColor = System.Drawing.Color.Black
        Me.Lbl_CheckTotal.Location = New System.Drawing.Point(225, 0)
        Me.Lbl_CheckTotal.Name = "Lbl_CheckTotal"
        Me.Lbl_CheckTotal.Size = New System.Drawing.Size(56, 30)
        Me.Lbl_CheckTotal.TabIndex = 12
        Me.Lbl_CheckTotal.Text = "Cnt"
        '
        'Tb_TeamsNames
        '
        Me.Tb_TeamsNames.Enabled = False
        Me.Tb_TeamsNames.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Tb_TeamsNames.Location = New System.Drawing.Point(688, 4)
        Me.Tb_TeamsNames.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_TeamsNames.Name = "Tb_TeamsNames"
        Me.Tb_TeamsNames.Size = New System.Drawing.Size(139, 28)
        Me.Tb_TeamsNames.TabIndex = 67
        Me.Tb_TeamsNames.Text = "Team name"
        Me.Tb_TeamsNames.Visible = False
        '
        'CB_PlayerMatchCode
        '
        Me.CB_PlayerMatchCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_PlayerMatchCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_PlayerMatchCode.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.CB_PlayerMatchCode.FormattingEnabled = True
        Me.CB_PlayerMatchCode.Location = New System.Drawing.Point(100, 4)
        Me.CB_PlayerMatchCode.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_PlayerMatchCode.Name = "CB_PlayerMatchCode"
        Me.CB_PlayerMatchCode.Size = New System.Drawing.Size(139, 29)
        Me.CB_PlayerMatchCode.TabIndex = 63
        Me.CB_PlayerMatchCode.Tag = "0"
        Me.CB_PlayerMatchCode.Text = "Player code"
        Me.CB_PlayerMatchCode.Visible = False
        '
        'Tb_PID
        '
        Me.Tb_PID.Enabled = False
        Me.Tb_PID.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Tb_PID.Location = New System.Drawing.Point(247, 4)
        Me.Tb_PID.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_PID.Name = "Tb_PID"
        Me.Tb_PID.Size = New System.Drawing.Size(139, 28)
        Me.Tb_PID.TabIndex = 64
        Me.Tb_PID.Text = "Player id"
        Me.Tb_PID.Visible = False
        '
        'Tb_FN
        '
        Me.Tb_FN.Enabled = False
        Me.Tb_FN.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Tb_FN.Location = New System.Drawing.Point(394, 4)
        Me.Tb_FN.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_FN.Name = "Tb_FN"
        Me.Tb_FN.Size = New System.Drawing.Size(139, 28)
        Me.Tb_FN.TabIndex = 65
        Me.Tb_FN.Text = "First name"
        Me.Tb_FN.Visible = False
        '
        'Tb_LN
        '
        Me.Tb_LN.Enabled = False
        Me.Tb_LN.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Tb_LN.Location = New System.Drawing.Point(541, 4)
        Me.Tb_LN.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_LN.Name = "Tb_LN"
        Me.Tb_LN.Size = New System.Drawing.Size(139, 28)
        Me.Tb_LN.TabIndex = 66
        Me.Tb_LN.Text = "Last name"
        Me.Tb_LN.Visible = False
        '
        'FLP_Top
        '
        Me.FLP_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.FLP_Top.Controls.Add(Me.Lbl_FormBack)
        Me.FLP_Top.Controls.Add(Me.CB_PlayerMatchCode)
        Me.FLP_Top.Controls.Add(Me.Tb_PID)
        Me.FLP_Top.Controls.Add(Me.Tb_FN)
        Me.FLP_Top.Controls.Add(Me.Tb_LN)
        Me.FLP_Top.Controls.Add(Me.Tb_TeamsNames)
        Me.FLP_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.FLP_Top.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.FLP_Top.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Top.Name = "FLP_Top"
        Me.FLP_Top.Size = New System.Drawing.Size(1301, 42)
        Me.FLP_Top.TabIndex = 65
        '
        'FLP_DisplayLeft
        '
        Me.FLP_DisplayLeft.BackColor = System.Drawing.Color.White
        Me.FLP_DisplayLeft.Controls.Add(Me.Lbl_TotalPlayersLeft)
        Me.FLP_DisplayLeft.Controls.Add(Me.Lbl_CheckTotal)
        Me.FLP_DisplayLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.FLP_DisplayLeft.Location = New System.Drawing.Point(808, 0)
        Me.FLP_DisplayLeft.Name = "FLP_DisplayLeft"
        Me.FLP_DisplayLeft.Size = New System.Drawing.Size(288, 75)
        Me.FLP_DisplayLeft.TabIndex = 0
        '
        'Panel_Display
        '
        Me.Panel_Display.BackColor = System.Drawing.Color.White
        Me.Panel_Display.Controls.Add(Me.Panel_StatsData)
        Me.Panel_Display.Controls.Add(Me.Panel_DisplayTop)
        Me.Panel_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Display.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Display.Name = "Panel_Display"
        Me.Panel_Display.Size = New System.Drawing.Size(1096, 699)
        Me.Panel_Display.TabIndex = 67
        '
        'Panel_StatsData
        '
        Me.Panel_StatsData.BackColor = System.Drawing.Color.Transparent
        Me.Panel_StatsData.Controls.Add(Me.Panel_StatsControlers)
        Me.Panel_StatsData.Controls.Add(Me.Lbl_LExplain)
        Me.Panel_StatsData.Controls.Add(Me.TLP_GameData)
        Me.Panel_StatsData.Controls.Add(Me.TLP_Buttons)
        Me.Panel_StatsData.Controls.Add(Me.Lb_NameBox)
        Me.Panel_StatsData.Location = New System.Drawing.Point(3, 109)
        Me.Panel_StatsData.Name = "Panel_StatsData"
        Me.Panel_StatsData.Size = New System.Drawing.Size(1093, 572)
        Me.Panel_StatsData.TabIndex = 2
        '
        'Panel_StatsControlers
        '
        Me.Panel_StatsControlers.Controls.Add(Me.CB_PMatchNames)
        Me.Panel_StatsControlers.Controls.Add(Me.Lbl_Rebound)
        Me.Panel_StatsControlers.Controls.Add(Me.Lbl_Steel)
        Me.Panel_StatsControlers.Controls.Add(Me.Tb_Assist)
        Me.Panel_StatsControlers.Controls.Add(Me.Tb_Rebound)
        Me.Panel_StatsControlers.Controls.Add(Me.Lbl_Block)
        Me.Panel_StatsControlers.Controls.Add(Me.Lbl_Points)
        Me.Panel_StatsControlers.Controls.Add(Me.Tb_Steel)
        Me.Panel_StatsControlers.Controls.Add(Me.Tb_Points)
        Me.Panel_StatsControlers.Controls.Add(Me.Tb_Block)
        Me.Panel_StatsControlers.Controls.Add(Me.Lbl_Assist)
        Me.Panel_StatsControlers.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_StatsControlers.Location = New System.Drawing.Point(0, 0)
        Me.Panel_StatsControlers.Name = "Panel_StatsControlers"
        Me.Panel_StatsControlers.Size = New System.Drawing.Size(381, 512)
        Me.Panel_StatsControlers.TabIndex = 69
        '
        'CB_PMatchNames
        '
        Me.CB_PMatchNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_PMatchNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_PMatchNames.Dock = System.Windows.Forms.DockStyle.Top
        Me.CB_PMatchNames.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.CB_PMatchNames.FormattingEnabled = True
        Me.CB_PMatchNames.Location = New System.Drawing.Point(0, 0)
        Me.CB_PMatchNames.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_PMatchNames.Name = "CB_PMatchNames"
        Me.CB_PMatchNames.Size = New System.Drawing.Size(381, 35)
        Me.CB_PMatchNames.TabIndex = 1
        Me.CB_PMatchNames.Tag = "0"
        Me.CB_PMatchNames.Text = "Player name"
        '
        'Lbl_Rebound
        '
        Me.Lbl_Rebound.AutoSize = True
        Me.Lbl_Rebound.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Rebound.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_Rebound.Location = New System.Drawing.Point(4, 165)
        Me.Lbl_Rebound.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Rebound.Name = "Lbl_Rebound"
        Me.Lbl_Rebound.Size = New System.Drawing.Size(132, 30)
        Me.Lbl_Rebound.TabIndex = 31
        Me.Lbl_Rebound.Text = "Rebounds"
        '
        'Lbl_Steel
        '
        Me.Lbl_Steel.AutoSize = True
        Me.Lbl_Steel.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Steel.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_Steel.Location = New System.Drawing.Point(4, 221)
        Me.Lbl_Steel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Steel.Name = "Lbl_Steel"
        Me.Lbl_Steel.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_Steel.TabIndex = 30
        Me.Lbl_Steel.Text = "Steels"
        '
        'Tb_Assist
        '
        Me.Tb_Assist.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tb_Assist.Location = New System.Drawing.Point(172, 107)
        Me.Tb_Assist.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Assist.MaxLength = 2
        Me.Tb_Assist.Name = "Tb_Assist"
        Me.Tb_Assist.Size = New System.Drawing.Size(198, 36)
        Me.Tb_Assist.TabIndex = 3
        Me.Tb_Assist.Tag = "1"
        '
        'Tb_Rebound
        '
        Me.Tb_Rebound.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tb_Rebound.Location = New System.Drawing.Point(172, 161)
        Me.Tb_Rebound.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Rebound.MaxLength = 2
        Me.Tb_Rebound.Name = "Tb_Rebound"
        Me.Tb_Rebound.Size = New System.Drawing.Size(198, 36)
        Me.Tb_Rebound.TabIndex = 4
        Me.Tb_Rebound.Tag = "1"
        '
        'Lbl_Block
        '
        Me.Lbl_Block.AutoSize = True
        Me.Lbl_Block.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Block.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_Block.Location = New System.Drawing.Point(4, 277)
        Me.Lbl_Block.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Block.Name = "Lbl_Block"
        Me.Lbl_Block.Size = New System.Drawing.Size(87, 30)
        Me.Lbl_Block.TabIndex = 29
        Me.Lbl_Block.Text = "Blocks"
        '
        'Lbl_Points
        '
        Me.Lbl_Points.AutoSize = True
        Me.Lbl_Points.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Points.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_Points.Location = New System.Drawing.Point(4, 53)
        Me.Lbl_Points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Points.Name = "Lbl_Points"
        Me.Lbl_Points.Size = New System.Drawing.Size(82, 30)
        Me.Lbl_Points.TabIndex = 11
        Me.Lbl_Points.Text = "Points"
        '
        'Tb_Steel
        '
        Me.Tb_Steel.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tb_Steel.Location = New System.Drawing.Point(172, 215)
        Me.Tb_Steel.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Steel.MaxLength = 2
        Me.Tb_Steel.Name = "Tb_Steel"
        Me.Tb_Steel.Size = New System.Drawing.Size(198, 36)
        Me.Tb_Steel.TabIndex = 5
        Me.Tb_Steel.Tag = "1"
        '
        'Tb_Points
        '
        Me.Tb_Points.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tb_Points.Location = New System.Drawing.Point(172, 53)
        Me.Tb_Points.MaxLength = 3
        Me.Tb_Points.Name = "Tb_Points"
        Me.Tb_Points.Size = New System.Drawing.Size(198, 36)
        Me.Tb_Points.TabIndex = 2
        Me.Tb_Points.Tag = "1"
        '
        'Tb_Block
        '
        Me.Tb_Block.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tb_Block.Location = New System.Drawing.Point(172, 269)
        Me.Tb_Block.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Block.MaxLength = 2
        Me.Tb_Block.Name = "Tb_Block"
        Me.Tb_Block.Size = New System.Drawing.Size(198, 36)
        Me.Tb_Block.TabIndex = 6
        Me.Tb_Block.Tag = "1"
        '
        'Lbl_Assist
        '
        Me.Lbl_Assist.AutoSize = True
        Me.Lbl_Assist.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Assist.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_Assist.Location = New System.Drawing.Point(4, 109)
        Me.Lbl_Assist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Assist.Name = "Lbl_Assist"
        Me.Lbl_Assist.Size = New System.Drawing.Size(84, 30)
        Me.Lbl_Assist.TabIndex = 28
        Me.Lbl_Assist.Text = "Assists"
        '
        'Lbl_LExplain
        '
        Me.Lbl_LExplain.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Lbl_LExplain.AutoSize = True
        Me.Lbl_LExplain.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_LExplain.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_LExplain.Location = New System.Drawing.Point(611, 137)
        Me.Lbl_LExplain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LExplain.Name = "Lbl_LExplain"
        Me.Lbl_LExplain.Size = New System.Drawing.Size(340, 120)
        Me.Lbl_LExplain.TabIndex = 68
        Me.Lbl_LExplain.Text = "Saved wrong valeus? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click on the list below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "With the players names" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To insert " & _
    "the correct values."
        '
        'TLP_GameData
        '
        Me.TLP_GameData.BackColor = System.Drawing.Color.Transparent
        Me.TLP_GameData.ColumnCount = 2
        Me.TLP_GameData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_GameData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_GameData.Controls.Add(Me.Tb_GamesTypes, 1, 0)
        Me.TLP_GameData.Controls.Add(Me.TB_GamesCodes, 1, 1)
        Me.TLP_GameData.Controls.Add(Me.Lbl_GamesCodes, 0, 1)
        Me.TLP_GameData.Controls.Add(Me.Tb_GamesDate, 1, 2)
        Me.TLP_GameData.Controls.Add(Me.Lbl_GamesDate, 0, 2)
        Me.TLP_GameData.Controls.Add(Me.Lbl_GamesTypes, 0, 0)
        Me.TLP_GameData.Location = New System.Drawing.Point(608, 0)
        Me.TLP_GameData.Name = "TLP_GameData"
        Me.TLP_GameData.RowCount = 3
        Me.TLP_GameData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_GameData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_GameData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLP_GameData.Size = New System.Drawing.Size(485, 134)
        Me.TLP_GameData.TabIndex = 67
        '
        'Tb_GamesTypes
        '
        Me.Tb_GamesTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tb_GamesTypes.Enabled = False
        Me.Tb_GamesTypes.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tb_GamesTypes.Location = New System.Drawing.Point(245, 3)
        Me.Tb_GamesTypes.Name = "Tb_GamesTypes"
        Me.Tb_GamesTypes.Size = New System.Drawing.Size(237, 36)
        Me.Tb_GamesTypes.TabIndex = 71
        Me.Tb_GamesTypes.Text = "Game type"
        '
        'TB_GamesCodes
        '
        Me.TB_GamesCodes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_GamesCodes.Enabled = False
        Me.TB_GamesCodes.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.TB_GamesCodes.Location = New System.Drawing.Point(245, 47)
        Me.TB_GamesCodes.Name = "TB_GamesCodes"
        Me.TB_GamesCodes.Size = New System.Drawing.Size(237, 36)
        Me.TB_GamesCodes.TabIndex = 73
        Me.TB_GamesCodes.Text = "Game code"
        '
        'Lbl_GamesCodes
        '
        Me.Lbl_GamesCodes.AutoSize = True
        Me.Lbl_GamesCodes.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GamesCodes.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_GamesCodes.Location = New System.Drawing.Point(3, 44)
        Me.Lbl_GamesCodes.Name = "Lbl_GamesCodes"
        Me.Lbl_GamesCodes.Size = New System.Drawing.Size(165, 30)
        Me.Lbl_GamesCodes.TabIndex = 72
        Me.Lbl_GamesCodes.Text = "Game Code"
        '
        'Tb_GamesDate
        '
        Me.Tb_GamesDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tb_GamesDate.Enabled = False
        Me.Tb_GamesDate.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Tb_GamesDate.Location = New System.Drawing.Point(245, 91)
        Me.Tb_GamesDate.Name = "Tb_GamesDate"
        Me.Tb_GamesDate.Size = New System.Drawing.Size(237, 36)
        Me.Tb_GamesDate.TabIndex = 75
        Me.Tb_GamesDate.Text = "Game date"
        '
        'Lbl_GamesDate
        '
        Me.Lbl_GamesDate.AutoSize = True
        Me.Lbl_GamesDate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GamesDate.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_GamesDate.Location = New System.Drawing.Point(3, 88)
        Me.Lbl_GamesDate.Name = "Lbl_GamesDate"
        Me.Lbl_GamesDate.Size = New System.Drawing.Size(155, 30)
        Me.Lbl_GamesDate.TabIndex = 74
        Me.Lbl_GamesDate.Text = "Game Date"
        '
        'Lbl_GamesTypes
        '
        Me.Lbl_GamesTypes.AutoSize = True
        Me.Lbl_GamesTypes.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GamesTypes.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Lbl_GamesTypes.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_GamesTypes.Name = "Lbl_GamesTypes"
        Me.Lbl_GamesTypes.Size = New System.Drawing.Size(153, 30)
        Me.Lbl_GamesTypes.TabIndex = 70
        Me.Lbl_GamesTypes.Text = "Game Type"
        '
        'TLP_Buttons
        '
        Me.TLP_Buttons.BackColor = System.Drawing.Color.White
        Me.TLP_Buttons.ColumnCount = 4
        Me.TLP_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP_Buttons.Controls.Add(Me.Btn_AllZero, 0, 0)
        Me.TLP_Buttons.Controls.Add(Me.Btn_PMatchSave, 0, 0)
        Me.TLP_Buttons.Controls.Add(Me.Btn_PMatchUpdate, 2, 0)
        Me.TLP_Buttons.Controls.Add(Me.Btn_PMatchHelp, 3, 0)
        Me.TLP_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP_Buttons.Location = New System.Drawing.Point(0, 512)
        Me.TLP_Buttons.Name = "TLP_Buttons"
        Me.TLP_Buttons.RowCount = 1
        Me.TLP_Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Buttons.Size = New System.Drawing.Size(1093, 60)
        Me.TLP_Buttons.TabIndex = 1
        '
        'Btn_AllZero
        '
        Me.Btn_AllZero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_AllZero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Btn_AllZero.FlatAppearance.BorderSize = 3
        Me.Btn_AllZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AllZero.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AllZero.ForeColor = System.Drawing.Color.Black
        Me.Btn_AllZero.Location = New System.Drawing.Point(276, 3)
        Me.Btn_AllZero.Name = "Btn_AllZero"
        Me.Btn_AllZero.Size = New System.Drawing.Size(267, 54)
        Me.Btn_AllZero.TabIndex = 8
        Me.Btn_AllZero.Text = "All Zero"
        Me.Btn_AllZero.UseVisualStyleBackColor = True
        '
        'Btn_PMatchSave
        '
        Me.Btn_PMatchSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_PMatchSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Btn_PMatchSave.FlatAppearance.BorderSize = 3
        Me.Btn_PMatchSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PMatchSave.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PMatchSave.ForeColor = System.Drawing.Color.Black
        Me.Btn_PMatchSave.Location = New System.Drawing.Point(3, 3)
        Me.Btn_PMatchSave.Name = "Btn_PMatchSave"
        Me.Btn_PMatchSave.Size = New System.Drawing.Size(267, 54)
        Me.Btn_PMatchSave.TabIndex = 7
        Me.Btn_PMatchSave.Text = "Save"
        Me.Btn_PMatchSave.UseVisualStyleBackColor = True
        '
        'Btn_PMatchUpdate
        '
        Me.Btn_PMatchUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_PMatchUpdate.Enabled = False
        Me.Btn_PMatchUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Btn_PMatchUpdate.FlatAppearance.BorderSize = 3
        Me.Btn_PMatchUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PMatchUpdate.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PMatchUpdate.ForeColor = System.Drawing.Color.Black
        Me.Btn_PMatchUpdate.Location = New System.Drawing.Point(549, 3)
        Me.Btn_PMatchUpdate.Name = "Btn_PMatchUpdate"
        Me.Btn_PMatchUpdate.Size = New System.Drawing.Size(267, 54)
        Me.Btn_PMatchUpdate.TabIndex = 9
        Me.Btn_PMatchUpdate.Text = "Update"
        Me.Btn_PMatchUpdate.UseVisualStyleBackColor = True
        '
        'Btn_PMatchHelp
        '
        Me.Btn_PMatchHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_PMatchHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Btn_PMatchHelp.FlatAppearance.BorderSize = 3
        Me.Btn_PMatchHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PMatchHelp.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_PMatchHelp.ForeColor = System.Drawing.Color.Black
        Me.Btn_PMatchHelp.Location = New System.Drawing.Point(822, 3)
        Me.Btn_PMatchHelp.Name = "Btn_PMatchHelp"
        Me.Btn_PMatchHelp.Size = New System.Drawing.Size(268, 54)
        Me.Btn_PMatchHelp.TabIndex = 10
        Me.Btn_PMatchHelp.Text = "Help"
        Me.Btn_PMatchHelp.UseVisualStyleBackColor = True
        '
        'Lb_NameBox
        '
        Me.Lb_NameBox.BackColor = System.Drawing.Color.White
        Me.Lb_NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lb_NameBox.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Lb_NameBox.FormattingEnabled = True
        Me.Lb_NameBox.ItemHeight = 23
        Me.Lb_NameBox.Location = New System.Drawing.Point(608, 273)
        Me.Lb_NameBox.Name = "Lb_NameBox"
        Me.Lb_NameBox.Size = New System.Drawing.Size(479, 230)
        Me.Lb_NameBox.TabIndex = 13
        '
        'Panel_DisplayTop
        '
        Me.Panel_DisplayTop.BackColor = System.Drawing.Color.White
        Me.Panel_DisplayTop.Controls.Add(Me.Panel_Welcome)
        Me.Panel_DisplayTop.Controls.Add(Me.FLP_DisplayLeft)
        Me.Panel_DisplayTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_DisplayTop.Location = New System.Drawing.Point(0, 0)
        Me.Panel_DisplayTop.Name = "Panel_DisplayTop"
        Me.Panel_DisplayTop.Size = New System.Drawing.Size(1096, 75)
        Me.Panel_DisplayTop.TabIndex = 0
        '
        'Panel_Welcome
        '
        Me.Panel_Welcome.Controls.Add(Me.Lbl_AddPStats)
        Me.Panel_Welcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Welcome.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Welcome.Name = "Panel_Welcome"
        Me.Panel_Welcome.Size = New System.Drawing.Size(808, 75)
        Me.Panel_Welcome.TabIndex = 1
        '
        'Panel_CenterButtom
        '
        Me.Panel_CenterButtom.BackColor = System.Drawing.Color.White
        Me.Panel_CenterButtom.Controls.Add(Me.Tb_ValToSQL)
        Me.Panel_CenterButtom.Controls.Add(Me.Tb_Temp)
        Me.Panel_CenterButtom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_CenterButtom.Location = New System.Drawing.Point(0, 699)
        Me.Panel_CenterButtom.Name = "Panel_CenterButtom"
        Me.Panel_CenterButtom.Size = New System.Drawing.Size(1096, 39)
        Me.Panel_CenterButtom.TabIndex = 1
        '
        'Tb_Temp
        '
        Me.Tb_Temp.Location = New System.Drawing.Point(172, 6)
        Me.Tb_Temp.Name = "Tb_Temp"
        Me.Tb_Temp.Size = New System.Drawing.Size(39, 22)
        Me.Tb_Temp.TabIndex = 70
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel_Left.Controls.Add(Me.Lb_CodeBox)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 42)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(205, 738)
        Me.Panel_Left.TabIndex = 68
        '
        'Panel_Center
        '
        Me.Panel_Center.Controls.Add(Me.Panel_Display)
        Me.Panel_Center.Controls.Add(Me.Panel_CenterButtom)
        Me.Panel_Center.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Center.Location = New System.Drawing.Point(205, 42)
        Me.Panel_Center.Name = "Panel_Center"
        Me.Panel_Center.Size = New System.Drawing.Size(1096, 738)
        Me.Panel_Center.TabIndex = 69
        '
        'Lbl_FinishInsert
        '
        Me.Lbl_FinishInsert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_FinishInsert.AutoSize = True
        Me.Lbl_FinishInsert.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FinishInsert.Font = New System.Drawing.Font("Century Gothic", 24.0!)
        Me.Lbl_FinishInsert.ForeColor = System.Drawing.Color.Black
        Me.Lbl_FinishInsert.Location = New System.Drawing.Point(352, 302)
        Me.Lbl_FinishInsert.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_FinishInsert.Name = "Lbl_FinishInsert"
        Me.Lbl_FinishInsert.Size = New System.Drawing.Size(784, 49)
        Me.Lbl_FinishInsert.TabIndex = 70
        Me.Lbl_FinishInsert.Text = "You finish insert your players game stats"
        '
        'PlayersMatchStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1301, 780)
        Me.Controls.Add(Me.Panel_Center)
        Me.Controls.Add(Me.Panel_Left)
        Me.Controls.Add(Me.FLP_Top)
        Me.Controls.Add(Me.Lbl_FinishInsert)
        Me.Name = "PlayersMatchStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlayersMatchStatistics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FLP_Top.ResumeLayout(False)
        Me.FLP_Top.PerformLayout()
        Me.FLP_DisplayLeft.ResumeLayout(False)
        Me.FLP_DisplayLeft.PerformLayout()
        Me.Panel_Display.ResumeLayout(False)
        Me.Panel_StatsData.ResumeLayout(False)
        Me.Panel_StatsData.PerformLayout()
        Me.Panel_StatsControlers.ResumeLayout(False)
        Me.Panel_StatsControlers.PerformLayout()
        Me.TLP_GameData.ResumeLayout(False)
        Me.TLP_GameData.PerformLayout()
        Me.TLP_Buttons.ResumeLayout(False)
        Me.Panel_DisplayTop.ResumeLayout(False)
        Me.Panel_Welcome.ResumeLayout(False)
        Me.Panel_Welcome.PerformLayout()
        Me.Panel_CenterButtom.ResumeLayout(False)
        Me.Panel_CenterButtom.PerformLayout()
        Me.Panel_Left.ResumeLayout(False)
        Me.Panel_Center.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_AddPStats As System.Windows.Forms.Label
    Friend WithEvents Lbl_FormBack As System.Windows.Forms.Label
    Friend WithEvents Tb_ValToSQL As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_TotalPlayersLeft As System.Windows.Forms.Label
    Friend WithEvents Lb_CodeBox As System.Windows.Forms.ListBox
    Friend WithEvents Lbl_CheckTotal As System.Windows.Forms.Label
    Friend WithEvents Tb_TeamsNames As System.Windows.Forms.TextBox
    Friend WithEvents CB_PlayerMatchCode As System.Windows.Forms.ComboBox
    Friend WithEvents Tb_PID As System.Windows.Forms.TextBox
    Friend WithEvents Tb_FN As System.Windows.Forms.TextBox
    Friend WithEvents Tb_LN As System.Windows.Forms.TextBox
    Friend WithEvents FLP_Top As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FLP_DisplayLeft As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel_Display As System.Windows.Forms.Panel
    Friend WithEvents Panel_DisplayTop As System.Windows.Forms.Panel
    Friend WithEvents TLP_Buttons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Btn_PMatchUpdate As System.Windows.Forms.Button
    Friend WithEvents Btn_AllZero As System.Windows.Forms.Button
    Friend WithEvents Btn_PMatchSave As System.Windows.Forms.Button
    Friend WithEvents Btn_PMatchHelp As System.Windows.Forms.Button
    Friend WithEvents Panel_CenterButtom As System.Windows.Forms.Panel
    Friend WithEvents Tb_Temp As System.Windows.Forms.TextBox
    Friend WithEvents Panel_Left As System.Windows.Forms.Panel
    Friend WithEvents Panel_Center As System.Windows.Forms.Panel
    Friend WithEvents Panel_StatsData As System.Windows.Forms.Panel
    Friend WithEvents TLP_GameData As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Tb_GamesTypes As System.Windows.Forms.TextBox
    Friend WithEvents TB_GamesCodes As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_GamesCodes As System.Windows.Forms.Label
    Friend WithEvents Tb_GamesDate As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_GamesDate As System.Windows.Forms.Label
    Friend WithEvents Lbl_GamesTypes As System.Windows.Forms.Label
    Friend WithEvents CB_PMatchNames As System.Windows.Forms.ComboBox
    Friend WithEvents Lb_NameBox As System.Windows.Forms.ListBox
    Friend WithEvents Lbl_Points As System.Windows.Forms.Label
    Friend WithEvents Tb_Points As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Assist As System.Windows.Forms.Label
    Friend WithEvents Tb_Block As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Steel As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Block As System.Windows.Forms.Label
    Friend WithEvents Tb_Rebound As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Assist As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Steel As System.Windows.Forms.Label
    Friend WithEvents Lbl_Rebound As System.Windows.Forms.Label
    Friend WithEvents Lbl_LExplain As System.Windows.Forms.Label
    Friend WithEvents Panel_Welcome As System.Windows.Forms.Panel
    Friend WithEvents Panel_StatsControlers As System.Windows.Forms.Panel
    Friend WithEvents Lbl_FinishInsert As System.Windows.Forms.Label
End Class
