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
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.GB_APS = New System.Windows.Forms.GroupBox()
        Me.Pic_Update = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Pic_Save = New System.Windows.Forms.PictureBox()
        Me.Tb_Points = New System.Windows.Forms.TextBox()
        Me.Btn_Default = New System.Windows.Forms.Button()
        Me.Lbl_TotalPlayersLeft = New System.Windows.Forms.Label()
        Me.Lb_TempBox = New System.Windows.Forms.ListBox()
        Me.Lbl_CheckTotal = New System.Windows.Forms.Label()
        Me.Tb_GamesTypes = New System.Windows.Forms.TextBox()
        Me.Lbl_GamesTypes = New System.Windows.Forms.Label()
        Me.Tb_TeamsNames = New System.Windows.Forms.TextBox()
        Me.Lbl_TeamsNames = New System.Windows.Forms.Label()
        Me.Tb_GamesDate = New System.Windows.Forms.TextBox()
        Me.Lbl_GamesDate = New System.Windows.Forms.Label()
        Me.TB_GamesCodes = New System.Windows.Forms.TextBox()
        Me.Lbl_GamesCodes = New System.Windows.Forms.Label()
        Me.Tb_Assist = New System.Windows.Forms.TextBox()
        Me.Tb_Rebound = New System.Windows.Forms.TextBox()
        Me.Tb_Steel = New System.Windows.Forms.TextBox()
        Me.Tb_Block = New System.Windows.Forms.TextBox()
        Me.Lbl_Rebound = New System.Windows.Forms.Label()
        Me.Lbl_Steel = New System.Windows.Forms.Label()
        Me.Lbl_Block = New System.Windows.Forms.Label()
        Me.Lbl_Assist = New System.Windows.Forms.Label()
        Me.CB_PlayerCode = New System.Windows.Forms.ComboBox()
        Me.Lbl_PlayerCode = New System.Windows.Forms.Label()
        Me.Tb_PID = New System.Windows.Forms.TextBox()
        Me.Lbl_PID = New System.Windows.Forms.Label()
        Me.Tb_FN = New System.Windows.Forms.TextBox()
        Me.Tb_LN = New System.Windows.Forms.TextBox()
        Me.Lbl_Points = New System.Windows.Forms.Label()
        Me.Lbl_LN = New System.Windows.Forms.Label()
        Me.Lbl_FN = New System.Windows.Forms.Label()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_APS.SuspendLayout()
        CType(Me.Pic_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_AddPStats
        '
        Me.Lbl_AddPStats.AutoSize = True
        Me.Lbl_AddPStats.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_AddPStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AddPStats.Location = New System.Drawing.Point(18, 19)
        Me.Lbl_AddPStats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_AddPStats.Name = "Lbl_AddPStats"
        Me.Lbl_AddPStats.Size = New System.Drawing.Size(218, 29)
        Me.Lbl_AddPStats.TabIndex = 63
        Me.Lbl_AddPStats.Text = "Add Players Stats"
        '
        'Lbl_FormBack
        '
        Me.Lbl_FormBack.AutoSize = True
        Me.Lbl_FormBack.Location = New System.Drawing.Point(291, 29)
        Me.Lbl_FormBack.Name = "Lbl_FormBack"
        Me.Lbl_FormBack.Size = New System.Drawing.Size(67, 17)
        Me.Lbl_FormBack.TabIndex = 64
        Me.Lbl_FormBack.Text = "Back to..."
        Me.Lbl_FormBack.Visible = False
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(674, 300)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 65
        Me.Pic_Help.TabStop = False
        '
        'GB_APS
        '
        Me.GB_APS.BackColor = System.Drawing.SystemColors.Control
        Me.GB_APS.Controls.Add(Me.Pic_Update)
        Me.GB_APS.Controls.Add(Me.TextBox1)
        Me.GB_APS.Controls.Add(Me.Pic_Help)
        Me.GB_APS.Controls.Add(Me.Pic_Save)
        Me.GB_APS.Controls.Add(Me.Tb_Points)
        Me.GB_APS.Controls.Add(Me.Btn_Default)
        Me.GB_APS.Controls.Add(Me.Lbl_TotalPlayersLeft)
        Me.GB_APS.Controls.Add(Me.Lb_TempBox)
        Me.GB_APS.Controls.Add(Me.Lbl_CheckTotal)
        Me.GB_APS.Controls.Add(Me.Tb_GamesTypes)
        Me.GB_APS.Controls.Add(Me.Lbl_GamesTypes)
        Me.GB_APS.Controls.Add(Me.Tb_TeamsNames)
        Me.GB_APS.Controls.Add(Me.Lbl_TeamsNames)
        Me.GB_APS.Controls.Add(Me.Tb_GamesDate)
        Me.GB_APS.Controls.Add(Me.Lbl_GamesDate)
        Me.GB_APS.Controls.Add(Me.TB_GamesCodes)
        Me.GB_APS.Controls.Add(Me.Lbl_GamesCodes)
        Me.GB_APS.Controls.Add(Me.Tb_Assist)
        Me.GB_APS.Controls.Add(Me.Tb_Rebound)
        Me.GB_APS.Controls.Add(Me.Tb_Steel)
        Me.GB_APS.Controls.Add(Me.Tb_Block)
        Me.GB_APS.Controls.Add(Me.Lbl_Rebound)
        Me.GB_APS.Controls.Add(Me.Lbl_Steel)
        Me.GB_APS.Controls.Add(Me.Lbl_Block)
        Me.GB_APS.Controls.Add(Me.Lbl_Assist)
        Me.GB_APS.Controls.Add(Me.CB_PlayerCode)
        Me.GB_APS.Controls.Add(Me.Lbl_PlayerCode)
        Me.GB_APS.Controls.Add(Me.Tb_PID)
        Me.GB_APS.Controls.Add(Me.Lbl_PID)
        Me.GB_APS.Controls.Add(Me.Tb_FN)
        Me.GB_APS.Controls.Add(Me.Tb_LN)
        Me.GB_APS.Controls.Add(Me.Lbl_Points)
        Me.GB_APS.Controls.Add(Me.Lbl_LN)
        Me.GB_APS.Controls.Add(Me.Lbl_FN)
        Me.GB_APS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_APS.Location = New System.Drawing.Point(13, 77)
        Me.GB_APS.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_APS.Name = "GB_APS"
        Me.GB_APS.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_APS.Size = New System.Drawing.Size(1019, 582)
        Me.GB_APS.TabIndex = 62
        Me.GB_APS.TabStop = False
        '
        'Pic_Update
        '
        Me.Pic_Update.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Update.Enabled = False
        Me.Pic_Update.Image = Global.BasicBasketballSql.My.Resources.Resources.update
        Me.Pic_Update.Location = New System.Drawing.Point(500, 345)
        Me.Pic_Update.Name = "Pic_Update"
        Me.Pic_Update.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Update.TabIndex = 58
        Me.Pic_Update.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(10, 501)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(966, 30)
        Me.TextBox1.TabIndex = 59
        '
        'Pic_Save
        '
        Me.Pic_Save.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Save.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Save.Enabled = False
        Me.Pic_Save.Image = Global.BasicBasketballSql.My.Resources.Resources.saveicon
        Me.Pic_Save.Location = New System.Drawing.Point(500, 245)
        Me.Pic_Save.Name = "Pic_Save"
        Me.Pic_Save.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Save.TabIndex = 57
        Me.Pic_Save.TabStop = False
        '
        'Tb_Points
        '
        Me.Tb_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Points.Location = New System.Drawing.Point(174, 209)
        Me.Tb_Points.Name = "Tb_Points"
        Me.Tb_Points.Size = New System.Drawing.Size(68, 34)
        Me.Tb_Points.TabIndex = 1
        Me.Tb_Points.Tag = "1"
        '
        'Btn_Default
        '
        Me.Btn_Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Default.Location = New System.Drawing.Point(500, 436)
        Me.Btn_Default.Name = "Btn_Default"
        Me.Btn_Default.Size = New System.Drawing.Size(161, 49)
        Me.Btn_Default.TabIndex = 57
        Me.Btn_Default.Text = "All Zero"
        Me.Btn_Default.UseVisualStyleBackColor = True
        '
        'Lbl_TotalPlayersLeft
        '
        Me.Lbl_TotalPlayersLeft.AutoSize = True
        Me.Lbl_TotalPlayersLeft.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TotalPlayersLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalPlayersLeft.Location = New System.Drawing.Point(495, 201)
        Me.Lbl_TotalPlayersLeft.Name = "Lbl_TotalPlayersLeft"
        Me.Lbl_TotalPlayersLeft.Size = New System.Drawing.Size(205, 29)
        Me.Lbl_TotalPlayersLeft.TabIndex = 54
        Me.Lbl_TotalPlayersLeft.Text = "Total Players Left:"
        '
        'Lb_TempBox
        '
        Me.Lb_TempBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TempBox.FormattingEnabled = True
        Me.Lb_TempBox.ItemHeight = 20
        Me.Lb_TempBox.Location = New System.Drawing.Point(306, 213)
        Me.Lb_TempBox.Name = "Lb_TempBox"
        Me.Lb_TempBox.Size = New System.Drawing.Size(143, 204)
        Me.Lb_TempBox.TabIndex = 53
        '
        'Lbl_CheckTotal
        '
        Me.Lbl_CheckTotal.AutoSize = True
        Me.Lbl_CheckTotal.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CheckTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CheckTotal.Location = New System.Drawing.Point(749, 201)
        Me.Lbl_CheckTotal.Name = "Lbl_CheckTotal"
        Me.Lbl_CheckTotal.Size = New System.Drawing.Size(49, 29)
        Me.Lbl_CheckTotal.TabIndex = 45
        Me.Lbl_CheckTotal.Text = "Cnt"
        '
        'Tb_GamesTypes
        '
        Me.Tb_GamesTypes.Enabled = False
        Me.Tb_GamesTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_GamesTypes.Location = New System.Drawing.Point(674, 26)
        Me.Tb_GamesTypes.Name = "Tb_GamesTypes"
        Me.Tb_GamesTypes.Size = New System.Drawing.Size(324, 34)
        Me.Tb_GamesTypes.TabIndex = 44
        '
        'Lbl_GamesTypes
        '
        Me.Lbl_GamesTypes.AutoSize = True
        Me.Lbl_GamesTypes.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GamesTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GamesTypes.Location = New System.Drawing.Point(495, 31)
        Me.Lbl_GamesTypes.Name = "Lbl_GamesTypes"
        Me.Lbl_GamesTypes.Size = New System.Drawing.Size(139, 29)
        Me.Lbl_GamesTypes.TabIndex = 43
        Me.Lbl_GamesTypes.Text = "Game Type"
        '
        'Tb_TeamsNames
        '
        Me.Tb_TeamsNames.Enabled = False
        Me.Tb_TeamsNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_TeamsNames.Location = New System.Drawing.Point(674, 151)
        Me.Tb_TeamsNames.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_TeamsNames.Name = "Tb_TeamsNames"
        Me.Tb_TeamsNames.Size = New System.Drawing.Size(324, 34)
        Me.Tb_TeamsNames.TabIndex = 42
        '
        'Lbl_TeamsNames
        '
        Me.Lbl_TeamsNames.AutoSize = True
        Me.Lbl_TeamsNames.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TeamsNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TeamsNames.Location = New System.Drawing.Point(495, 157)
        Me.Lbl_TeamsNames.Name = "Lbl_TeamsNames"
        Me.Lbl_TeamsNames.Size = New System.Drawing.Size(147, 29)
        Me.Lbl_TeamsNames.TabIndex = 41
        Me.Lbl_TeamsNames.Text = "Team Name"
        '
        'Tb_GamesDate
        '
        Me.Tb_GamesDate.Enabled = False
        Me.Tb_GamesDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_GamesDate.Location = New System.Drawing.Point(674, 111)
        Me.Tb_GamesDate.Name = "Tb_GamesDate"
        Me.Tb_GamesDate.Size = New System.Drawing.Size(324, 34)
        Me.Tb_GamesDate.TabIndex = 40
        '
        'Lbl_GamesDate
        '
        Me.Lbl_GamesDate.AutoSize = True
        Me.Lbl_GamesDate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GamesDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GamesDate.Location = New System.Drawing.Point(495, 115)
        Me.Lbl_GamesDate.Name = "Lbl_GamesDate"
        Me.Lbl_GamesDate.Size = New System.Drawing.Size(134, 29)
        Me.Lbl_GamesDate.TabIndex = 39
        Me.Lbl_GamesDate.Text = "Game Date"
        '
        'TB_GamesCodes
        '
        Me.TB_GamesCodes.Enabled = False
        Me.TB_GamesCodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_GamesCodes.Location = New System.Drawing.Point(674, 70)
        Me.TB_GamesCodes.Name = "TB_GamesCodes"
        Me.TB_GamesCodes.Size = New System.Drawing.Size(324, 34)
        Me.TB_GamesCodes.TabIndex = 38
        '
        'Lbl_GamesCodes
        '
        Me.Lbl_GamesCodes.AutoSize = True
        Me.Lbl_GamesCodes.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_GamesCodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GamesCodes.Location = New System.Drawing.Point(495, 73)
        Me.Lbl_GamesCodes.Name = "Lbl_GamesCodes"
        Me.Lbl_GamesCodes.Size = New System.Drawing.Size(143, 29)
        Me.Lbl_GamesCodes.TabIndex = 37
        Me.Lbl_GamesCodes.Text = "Game Code"
        '
        'Tb_Assist
        '
        Me.Tb_Assist.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Assist.Location = New System.Drawing.Point(174, 254)
        Me.Tb_Assist.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Assist.Name = "Tb_Assist"
        Me.Tb_Assist.Size = New System.Drawing.Size(68, 34)
        Me.Tb_Assist.TabIndex = 2
        Me.Tb_Assist.Tag = "1"
        '
        'Tb_Rebound
        '
        Me.Tb_Rebound.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Rebound.Location = New System.Drawing.Point(174, 300)
        Me.Tb_Rebound.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Rebound.Name = "Tb_Rebound"
        Me.Tb_Rebound.Size = New System.Drawing.Size(68, 34)
        Me.Tb_Rebound.TabIndex = 3
        Me.Tb_Rebound.Tag = "1"
        '
        'Tb_Steel
        '
        Me.Tb_Steel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Steel.Location = New System.Drawing.Point(174, 346)
        Me.Tb_Steel.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Steel.Name = "Tb_Steel"
        Me.Tb_Steel.Size = New System.Drawing.Size(68, 34)
        Me.Tb_Steel.TabIndex = 4
        Me.Tb_Steel.Tag = "1"
        '
        'Tb_Block
        '
        Me.Tb_Block.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Block.Location = New System.Drawing.Point(174, 394)
        Me.Tb_Block.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Block.Name = "Tb_Block"
        Me.Tb_Block.Size = New System.Drawing.Size(68, 34)
        Me.Tb_Block.TabIndex = 5
        Me.Tb_Block.Tag = "1"
        '
        'Lbl_Rebound
        '
        Me.Lbl_Rebound.AutoSize = True
        Me.Lbl_Rebound.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Rebound.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Rebound.Location = New System.Drawing.Point(8, 305)
        Me.Lbl_Rebound.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Rebound.Name = "Lbl_Rebound"
        Me.Lbl_Rebound.Size = New System.Drawing.Size(124, 29)
        Me.Lbl_Rebound.TabIndex = 31
        Me.Lbl_Rebound.Text = "Rebounds"
        '
        'Lbl_Steel
        '
        Me.Lbl_Steel.AutoSize = True
        Me.Lbl_Steel.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Steel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Steel.Location = New System.Drawing.Point(8, 351)
        Me.Lbl_Steel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Steel.Name = "Lbl_Steel"
        Me.Lbl_Steel.Size = New System.Drawing.Size(81, 29)
        Me.Lbl_Steel.TabIndex = 30
        Me.Lbl_Steel.Text = "Steels"
        '
        'Lbl_Block
        '
        Me.Lbl_Block.AutoSize = True
        Me.Lbl_Block.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Block.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Block.Location = New System.Drawing.Point(8, 397)
        Me.Lbl_Block.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Block.Name = "Lbl_Block"
        Me.Lbl_Block.Size = New System.Drawing.Size(85, 29)
        Me.Lbl_Block.TabIndex = 29
        Me.Lbl_Block.Text = "Blocks"
        '
        'Lbl_Assist
        '
        Me.Lbl_Assist.AutoSize = True
        Me.Lbl_Assist.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Assist.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Assist.Location = New System.Drawing.Point(8, 259)
        Me.Lbl_Assist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Assist.Name = "Lbl_Assist"
        Me.Lbl_Assist.Size = New System.Drawing.Size(88, 29)
        Me.Lbl_Assist.TabIndex = 28
        Me.Lbl_Assist.Text = "Assists"
        '
        'CB_PlayerCode
        '
        Me.CB_PlayerCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_PlayerCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_PlayerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PlayerCode.FormattingEnabled = True
        Me.CB_PlayerCode.Location = New System.Drawing.Point(174, 29)
        Me.CB_PlayerCode.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_PlayerCode.Name = "CB_PlayerCode"
        Me.CB_PlayerCode.Size = New System.Drawing.Size(275, 37)
        Me.CB_PlayerCode.TabIndex = 0
        Me.CB_PlayerCode.Tag = "0"
        '
        'Lbl_PlayerCode
        '
        Me.Lbl_PlayerCode.AutoSize = True
        Me.Lbl_PlayerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_PlayerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PlayerCode.Location = New System.Drawing.Point(8, 29)
        Me.Lbl_PlayerCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_PlayerCode.Name = "Lbl_PlayerCode"
        Me.Lbl_PlayerCode.Size = New System.Drawing.Size(146, 29)
        Me.Lbl_PlayerCode.TabIndex = 25
        Me.Lbl_PlayerCode.Text = "Player Code"
        '
        'Tb_PID
        '
        Me.Tb_PID.Enabled = False
        Me.Tb_PID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_PID.Location = New System.Drawing.Point(174, 77)
        Me.Tb_PID.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_PID.Name = "Tb_PID"
        Me.Tb_PID.Size = New System.Drawing.Size(275, 34)
        Me.Tb_PID.TabIndex = 1
        '
        'Lbl_PID
        '
        Me.Lbl_PID.AutoSize = True
        Me.Lbl_PID.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_PID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PID.Location = New System.Drawing.Point(8, 75)
        Me.Lbl_PID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_PID.Name = "Lbl_PID"
        Me.Lbl_PID.Size = New System.Drawing.Size(110, 29)
        Me.Lbl_PID.TabIndex = 27
        Me.Lbl_PID.Text = "Player ID"
        '
        'Tb_FN
        '
        Me.Tb_FN.Enabled = False
        Me.Tb_FN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_FN.Location = New System.Drawing.Point(174, 119)
        Me.Tb_FN.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_FN.Name = "Tb_FN"
        Me.Tb_FN.Size = New System.Drawing.Size(275, 34)
        Me.Tb_FN.TabIndex = 2
        '
        'Tb_LN
        '
        Me.Tb_LN.Enabled = False
        Me.Tb_LN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_LN.Location = New System.Drawing.Point(174, 164)
        Me.Tb_LN.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_LN.Name = "Tb_LN"
        Me.Tb_LN.Size = New System.Drawing.Size(275, 34)
        Me.Tb_LN.TabIndex = 3
        '
        'Lbl_Points
        '
        Me.Lbl_Points.AutoSize = True
        Me.Lbl_Points.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Points.Location = New System.Drawing.Point(8, 213)
        Me.Lbl_Points.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Points.Name = "Lbl_Points"
        Me.Lbl_Points.Size = New System.Drawing.Size(80, 29)
        Me.Lbl_Points.TabIndex = 11
        Me.Lbl_Points.Text = "Points"
        '
        'Lbl_LN
        '
        Me.Lbl_LN.AutoSize = True
        Me.Lbl_LN.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_LN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LN.Location = New System.Drawing.Point(8, 167)
        Me.Lbl_LN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LN.Name = "Lbl_LN"
        Me.Lbl_LN.Size = New System.Drawing.Size(128, 29)
        Me.Lbl_LN.TabIndex = 10
        Me.Lbl_LN.Text = "Last Name"
        '
        'Lbl_FN
        '
        Me.Lbl_FN.AutoSize = True
        Me.Lbl_FN.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FN.Location = New System.Drawing.Point(8, 121)
        Me.Lbl_FN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_FN.Name = "Lbl_FN"
        Me.Lbl_FN.Size = New System.Drawing.Size(131, 29)
        Me.Lbl_FN.TabIndex = 9
        Me.Lbl_FN.Text = "First Name"
        '
        'PlayersMatchStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1045, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_AddPStats)
        Me.Controls.Add(Me.Lbl_FormBack)
        Me.Controls.Add(Me.GB_APS)
        Me.Name = "PlayersMatchStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlayersMatchStatistics"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_APS.ResumeLayout(False)
        Me.GB_APS.PerformLayout()
        CType(Me.Pic_Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_AddPStats As System.Windows.Forms.Label
    Friend WithEvents Lbl_FormBack As System.Windows.Forms.Label
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
    Friend WithEvents GB_APS As System.Windows.Forms.GroupBox
    Friend WithEvents Pic_Update As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Pic_Save As System.Windows.Forms.PictureBox
    Friend WithEvents Tb_Points As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Default As System.Windows.Forms.Button
    Friend WithEvents Lbl_TotalPlayersLeft As System.Windows.Forms.Label
    Friend WithEvents Lb_TempBox As System.Windows.Forms.ListBox
    Friend WithEvents Lbl_CheckTotal As System.Windows.Forms.Label
    Friend WithEvents Tb_GamesTypes As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_GamesTypes As System.Windows.Forms.Label
    Friend WithEvents Tb_TeamsNames As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_TeamsNames As System.Windows.Forms.Label
    Friend WithEvents Tb_GamesDate As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_GamesDate As System.Windows.Forms.Label
    Friend WithEvents TB_GamesCodes As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_GamesCodes As System.Windows.Forms.Label
    Friend WithEvents Tb_Assist As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Rebound As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Steel As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Block As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Rebound As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steel As System.Windows.Forms.Label
    Friend WithEvents Lbl_Block As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assist As System.Windows.Forms.Label
    Friend WithEvents CB_PlayerCode As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_PlayerCode As System.Windows.Forms.Label
    Friend WithEvents Tb_PID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_PID As System.Windows.Forms.Label
    Friend WithEvents Tb_FN As System.Windows.Forms.TextBox
    Friend WithEvents Tb_LN As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Points As System.Windows.Forms.Label
    Friend WithEvents Lbl_LN As System.Windows.Forms.Label
    Friend WithEvents Lbl_FN As System.Windows.Forms.Label
End Class
