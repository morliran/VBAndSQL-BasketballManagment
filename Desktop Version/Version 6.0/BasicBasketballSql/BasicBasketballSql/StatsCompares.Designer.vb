<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatsCompares
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GB_Design = New System.Windows.Forms.GroupBox()
        Me.CB_ValuesPosition = New System.Windows.Forms.ComboBox()
        Me.RB_No = New System.Windows.Forms.RadioButton()
        Me.RB_Yes = New System.Windows.Forms.RadioButton()
        Me.Lbl_3D = New System.Windows.Forms.Label()
        Me.CB_ChartTypes = New System.Windows.Forms.ComboBox()
        Me.Lbl_EmptyVal = New System.Windows.Forms.Label()
        Me.GB_Player2Stats = New System.Windows.Forms.GroupBox()
        Me.Lbl_Pointsnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Blocksnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Points2 = New System.Windows.Forms.Label()
        Me.Lbl_Assists2 = New System.Windows.Forms.Label()
        Me.Lbl_Steelsnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Assistsnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Rebounds2 = New System.Windows.Forms.Label()
        Me.Lbl_Reboundsnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Steels2 = New System.Windows.Forms.Label()
        Me.Lbl_Blocks2 = New System.Windows.Forms.Label()
        Me.GB_Player1Stats = New System.Windows.Forms.GroupBox()
        Me.Lbl_Pointsnum = New System.Windows.Forms.Label()
        Me.Lbl_Blocksnum = New System.Windows.Forms.Label()
        Me.Lbl_Points = New System.Windows.Forms.Label()
        Me.Lbl_Assists = New System.Windows.Forms.Label()
        Me.Lbl_Steelsnum = New System.Windows.Forms.Label()
        Me.Lbl_Blocks = New System.Windows.Forms.Label()
        Me.Lbl_Assistsnum = New System.Windows.Forms.Label()
        Me.Lbl_Rebounds = New System.Windows.Forms.Label()
        Me.Lbl_Reboundsnum = New System.Windows.Forms.Label()
        Me.Lbl_Steels = New System.Windows.Forms.Label()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.Tb_Playername2 = New System.Windows.Forms.TextBox()
        Me.Tb_Playername = New System.Windows.Forms.TextBox()
        Me.CB_Gametype2 = New System.Windows.Forms.ComboBox()
        Me.CB_Gametype = New System.Windows.Forms.ComboBox()
        Me.Lbl_TeamName = New System.Windows.Forms.Label()
        Me.CB_Playercode2 = New System.Windows.Forms.ComboBox()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CB_Playercode = New System.Windows.Forms.ComboBox()
        Me.Lbl_EmptyVal2 = New System.Windows.Forms.Label()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Panel_Controls = New System.Windows.Forms.Panel()
        Me.TLP_Charts = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Chart2 = New System.Windows.Forms.Panel()
        Me.Panel_Chart1 = New System.Windows.Forms.Panel()
        Me.GB_Design.SuspendLayout()
        Me.GB_Player2Stats.SuspendLayout()
        Me.GB_Player1Stats.SuspendLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_Controls.SuspendLayout()
        Me.TLP_Charts.SuspendLayout()
        Me.Panel_Chart2.SuspendLayout()
        Me.Panel_Chart1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_Design
        '
        Me.GB_Design.Controls.Add(Me.CB_ValuesPosition)
        Me.GB_Design.Controls.Add(Me.RB_No)
        Me.GB_Design.Controls.Add(Me.RB_Yes)
        Me.GB_Design.Controls.Add(Me.Lbl_3D)
        Me.GB_Design.Controls.Add(Me.CB_ChartTypes)
        Me.GB_Design.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Design.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GB_Design.Location = New System.Drawing.Point(875, 1)
        Me.GB_Design.Name = "GB_Design"
        Me.GB_Design.Size = New System.Drawing.Size(265, 177)
        Me.GB_Design.TabIndex = 48
        Me.GB_Design.TabStop = False
        Me.GB_Design.Text = "Design box"
        '
        'CB_ValuesPosition
        '
        Me.CB_ValuesPosition.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ValuesPosition.FormattingEnabled = True
        Me.CB_ValuesPosition.Items.AddRange(New Object() {"Inside", "Outside", "Disabled"})
        Me.CB_ValuesPosition.Location = New System.Drawing.Point(12, 79)
        Me.CB_ValuesPosition.Name = "CB_ValuesPosition"
        Me.CB_ValuesPosition.Size = New System.Drawing.Size(247, 31)
        Me.CB_ValuesPosition.TabIndex = 32
        Me.CB_ValuesPosition.Tag = ""
        Me.CB_ValuesPosition.Text = "Set value position"
        '
        'RB_No
        '
        Me.RB_No.AutoSize = True
        Me.RB_No.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_No.Location = New System.Drawing.Point(143, 132)
        Me.RB_No.Name = "RB_No"
        Me.RB_No.Size = New System.Drawing.Size(59, 27)
        Me.RB_No.TabIndex = 31
        Me.RB_No.TabStop = True
        Me.RB_No.Text = "No"
        Me.RB_No.UseVisualStyleBackColor = True
        '
        'RB_Yes
        '
        Me.RB_Yes.AutoSize = True
        Me.RB_Yes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Yes.Location = New System.Drawing.Point(62, 132)
        Me.RB_Yes.Name = "RB_Yes"
        Me.RB_Yes.Size = New System.Drawing.Size(65, 27)
        Me.RB_Yes.TabIndex = 30
        Me.RB_Yes.TabStop = True
        Me.RB_Yes.Text = "Yes"
        Me.RB_Yes.UseVisualStyleBackColor = True
        '
        'Lbl_3D
        '
        Me.Lbl_3D.AutoSize = True
        Me.Lbl_3D.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_3D.Location = New System.Drawing.Point(8, 134)
        Me.Lbl_3D.Name = "Lbl_3D"
        Me.Lbl_3D.Size = New System.Drawing.Size(48, 23)
        Me.Lbl_3D.TabIndex = 29
        Me.Lbl_3D.Text = "3D?"
        '
        'CB_ChartTypes
        '
        Me.CB_ChartTypes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ChartTypes.FormattingEnabled = True
        Me.CB_ChartTypes.Items.AddRange(New Object() {"Bar ", "Column", "Pie", "Doughnut"})
        Me.CB_ChartTypes.Location = New System.Drawing.Point(12, 31)
        Me.CB_ChartTypes.Name = "CB_ChartTypes"
        Me.CB_ChartTypes.Size = New System.Drawing.Size(247, 31)
        Me.CB_ChartTypes.TabIndex = 28
        Me.CB_ChartTypes.Tag = ""
        Me.CB_ChartTypes.Text = "Change chart type"
        '
        'Lbl_EmptyVal
        '
        Me.Lbl_EmptyVal.AutoSize = True
        Me.Lbl_EmptyVal.BackColor = System.Drawing.Color.White
        Me.Lbl_EmptyVal.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EmptyVal.Location = New System.Drawing.Point(164, 171)
        Me.Lbl_EmptyVal.Name = "Lbl_EmptyVal"
        Me.Lbl_EmptyVal.Size = New System.Drawing.Size(492, 28)
        Me.Lbl_EmptyVal.TabIndex = 51
        Me.Lbl_EmptyVal.Text = "This player doesn't play in this game type"
        Me.Lbl_EmptyVal.Visible = False
        '
        'GB_Player2Stats
        '
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Pointsnum2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Blocksnum2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Points2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Assists2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Steelsnum2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Assistsnum2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Rebounds2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Reboundsnum2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Steels2)
        Me.GB_Player2Stats.Controls.Add(Me.Lbl_Blocks2)
        Me.GB_Player2Stats.Enabled = False
        Me.GB_Player2Stats.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Player2Stats.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GB_Player2Stats.Location = New System.Drawing.Point(1606, 1)
        Me.GB_Player2Stats.Name = "GB_Player2Stats"
        Me.GB_Player2Stats.Size = New System.Drawing.Size(305, 173)
        Me.GB_Player2Stats.TabIndex = 50
        Me.GB_Player2Stats.TabStop = False
        Me.GB_Player2Stats.Text = "Player 2 Stats"
        '
        'Lbl_Pointsnum2
        '
        Me.Lbl_Pointsnum2.AutoSize = True
        Me.Lbl_Pointsnum2.Location = New System.Drawing.Point(139, 25)
        Me.Lbl_Pointsnum2.Name = "Lbl_Pointsnum2"
        Me.Lbl_Pointsnum2.Size = New System.Drawing.Size(108, 23)
        Me.Lbl_Pointsnum2.TabIndex = 17
        Me.Lbl_Pointsnum2.Text = "Pointsnum"
        '
        'Lbl_Blocksnum2
        '
        Me.Lbl_Blocksnum2.AutoSize = True
        Me.Lbl_Blocksnum2.Location = New System.Drawing.Point(139, 140)
        Me.Lbl_Blocksnum2.Name = "Lbl_Blocksnum2"
        Me.Lbl_Blocksnum2.Size = New System.Drawing.Size(113, 23)
        Me.Lbl_Blocksnum2.TabIndex = 26
        Me.Lbl_Blocksnum2.Text = "Blocksnum"
        '
        'Lbl_Points2
        '
        Me.Lbl_Points2.AutoSize = True
        Me.Lbl_Points2.Location = New System.Drawing.Point(6, 25)
        Me.Lbl_Points2.Name = "Lbl_Points2"
        Me.Lbl_Points2.Size = New System.Drawing.Size(70, 23)
        Me.Lbl_Points2.TabIndex = 18
        Me.Lbl_Points2.Text = "Points:"
        '
        'Lbl_Assists2
        '
        Me.Lbl_Assists2.AutoSize = True
        Me.Lbl_Assists2.Location = New System.Drawing.Point(6, 56)
        Me.Lbl_Assists2.Name = "Lbl_Assists2"
        Me.Lbl_Assists2.Size = New System.Drawing.Size(72, 23)
        Me.Lbl_Assists2.TabIndex = 19
        Me.Lbl_Assists2.Text = "Assists:"
        '
        'Lbl_Steelsnum2
        '
        Me.Lbl_Steelsnum2.AutoSize = True
        Me.Lbl_Steelsnum2.Location = New System.Drawing.Point(139, 112)
        Me.Lbl_Steelsnum2.Name = "Lbl_Steelsnum2"
        Me.Lbl_Steelsnum2.Size = New System.Drawing.Size(109, 23)
        Me.Lbl_Steelsnum2.TabIndex = 25
        Me.Lbl_Steelsnum2.Text = "Steelsnum"
        '
        'Lbl_Assistsnum2
        '
        Me.Lbl_Assistsnum2.AutoSize = True
        Me.Lbl_Assistsnum2.Location = New System.Drawing.Point(139, 55)
        Me.Lbl_Assistsnum2.Name = "Lbl_Assistsnum2"
        Me.Lbl_Assistsnum2.Size = New System.Drawing.Size(110, 23)
        Me.Lbl_Assistsnum2.TabIndex = 20
        Me.Lbl_Assistsnum2.Text = "Assistsnum"
        '
        'Lbl_Rebounds2
        '
        Me.Lbl_Rebounds2.AutoSize = True
        Me.Lbl_Rebounds2.Location = New System.Drawing.Point(6, 85)
        Me.Lbl_Rebounds2.Name = "Lbl_Rebounds2"
        Me.Lbl_Rebounds2.Size = New System.Drawing.Size(113, 23)
        Me.Lbl_Rebounds2.TabIndex = 21
        Me.Lbl_Rebounds2.Text = "Rebounds:"
        '
        'Lbl_Reboundsnum2
        '
        Me.Lbl_Reboundsnum2.AutoSize = True
        Me.Lbl_Reboundsnum2.Location = New System.Drawing.Point(139, 84)
        Me.Lbl_Reboundsnum2.Name = "Lbl_Reboundsnum2"
        Me.Lbl_Reboundsnum2.Size = New System.Drawing.Size(151, 23)
        Me.Lbl_Reboundsnum2.TabIndex = 24
        Me.Lbl_Reboundsnum2.Text = "Reboundsnum"
        '
        'Lbl_Steels2
        '
        Me.Lbl_Steels2.AutoSize = True
        Me.Lbl_Steels2.Location = New System.Drawing.Point(6, 113)
        Me.Lbl_Steels2.Name = "Lbl_Steels2"
        Me.Lbl_Steels2.Size = New System.Drawing.Size(71, 23)
        Me.Lbl_Steels2.TabIndex = 22
        Me.Lbl_Steels2.Text = "Steels:"
        '
        'Lbl_Blocks2
        '
        Me.Lbl_Blocks2.AutoSize = True
        Me.Lbl_Blocks2.Location = New System.Drawing.Point(6, 141)
        Me.Lbl_Blocks2.Name = "Lbl_Blocks2"
        Me.Lbl_Blocks2.Size = New System.Drawing.Size(75, 23)
        Me.Lbl_Blocks2.TabIndex = 23
        Me.Lbl_Blocks2.Text = "Blocks:"
        '
        'GB_Player1Stats
        '
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Pointsnum)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Blocksnum)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Points)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Assists)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Steelsnum)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Blocks)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Assistsnum)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Rebounds)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Reboundsnum)
        Me.GB_Player1Stats.Controls.Add(Me.Lbl_Steels)
        Me.GB_Player1Stats.Enabled = False
        Me.GB_Player1Stats.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_Player1Stats.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GB_Player1Stats.Location = New System.Drawing.Point(332, 1)
        Me.GB_Player1Stats.Name = "GB_Player1Stats"
        Me.GB_Player1Stats.Size = New System.Drawing.Size(305, 182)
        Me.GB_Player1Stats.TabIndex = 49
        Me.GB_Player1Stats.TabStop = False
        Me.GB_Player1Stats.Text = "Player 1 Stats"
        '
        'Lbl_Pointsnum
        '
        Me.Lbl_Pointsnum.AutoSize = True
        Me.Lbl_Pointsnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pointsnum.Location = New System.Drawing.Point(135, 28)
        Me.Lbl_Pointsnum.Name = "Lbl_Pointsnum"
        Me.Lbl_Pointsnum.Size = New System.Drawing.Size(108, 23)
        Me.Lbl_Pointsnum.TabIndex = 17
        Me.Lbl_Pointsnum.Text = "Pointsnum"
        '
        'Lbl_Blocksnum
        '
        Me.Lbl_Blocksnum.AutoSize = True
        Me.Lbl_Blocksnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Blocksnum.Location = New System.Drawing.Point(135, 143)
        Me.Lbl_Blocksnum.Name = "Lbl_Blocksnum"
        Me.Lbl_Blocksnum.Size = New System.Drawing.Size(113, 23)
        Me.Lbl_Blocksnum.TabIndex = 26
        Me.Lbl_Blocksnum.Text = "Blocksnum"
        '
        'Lbl_Points
        '
        Me.Lbl_Points.AutoSize = True
        Me.Lbl_Points.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Points.Location = New System.Drawing.Point(6, 28)
        Me.Lbl_Points.Name = "Lbl_Points"
        Me.Lbl_Points.Size = New System.Drawing.Size(70, 23)
        Me.Lbl_Points.TabIndex = 18
        Me.Lbl_Points.Text = "Points:"
        '
        'Lbl_Assists
        '
        Me.Lbl_Assists.AutoSize = True
        Me.Lbl_Assists.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Assists.Location = New System.Drawing.Point(6, 59)
        Me.Lbl_Assists.Name = "Lbl_Assists"
        Me.Lbl_Assists.Size = New System.Drawing.Size(72, 23)
        Me.Lbl_Assists.TabIndex = 19
        Me.Lbl_Assists.Text = "Assists:"
        '
        'Lbl_Steelsnum
        '
        Me.Lbl_Steelsnum.AutoSize = True
        Me.Lbl_Steelsnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Steelsnum.Location = New System.Drawing.Point(135, 119)
        Me.Lbl_Steelsnum.Name = "Lbl_Steelsnum"
        Me.Lbl_Steelsnum.Size = New System.Drawing.Size(109, 23)
        Me.Lbl_Steelsnum.TabIndex = 25
        Me.Lbl_Steelsnum.Text = "Steelsnum"
        '
        'Lbl_Blocks
        '
        Me.Lbl_Blocks.AutoSize = True
        Me.Lbl_Blocks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Blocks.Location = New System.Drawing.Point(6, 144)
        Me.Lbl_Blocks.Name = "Lbl_Blocks"
        Me.Lbl_Blocks.Size = New System.Drawing.Size(75, 23)
        Me.Lbl_Blocks.TabIndex = 23
        Me.Lbl_Blocks.Text = "Blocks:"
        '
        'Lbl_Assistsnum
        '
        Me.Lbl_Assistsnum.AutoSize = True
        Me.Lbl_Assistsnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Assistsnum.Location = New System.Drawing.Point(135, 58)
        Me.Lbl_Assistsnum.Name = "Lbl_Assistsnum"
        Me.Lbl_Assistsnum.Size = New System.Drawing.Size(110, 23)
        Me.Lbl_Assistsnum.TabIndex = 20
        Me.Lbl_Assistsnum.Text = "Assistsnum"
        '
        'Lbl_Rebounds
        '
        Me.Lbl_Rebounds.AutoSize = True
        Me.Lbl_Rebounds.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Rebounds.Location = New System.Drawing.Point(6, 88)
        Me.Lbl_Rebounds.Name = "Lbl_Rebounds"
        Me.Lbl_Rebounds.Size = New System.Drawing.Size(113, 23)
        Me.Lbl_Rebounds.TabIndex = 21
        Me.Lbl_Rebounds.Text = "Rebounds:"
        '
        'Lbl_Reboundsnum
        '
        Me.Lbl_Reboundsnum.AutoSize = True
        Me.Lbl_Reboundsnum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Reboundsnum.Location = New System.Drawing.Point(135, 87)
        Me.Lbl_Reboundsnum.Name = "Lbl_Reboundsnum"
        Me.Lbl_Reboundsnum.Size = New System.Drawing.Size(151, 23)
        Me.Lbl_Reboundsnum.TabIndex = 24
        Me.Lbl_Reboundsnum.Text = "Reboundsnum"
        '
        'Lbl_Steels
        '
        Me.Lbl_Steels.AutoSize = True
        Me.Lbl_Steels.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Steels.Location = New System.Drawing.Point(6, 120)
        Me.Lbl_Steels.Name = "Lbl_Steels"
        Me.Lbl_Steels.Size = New System.Drawing.Size(71, 23)
        Me.Lbl_Steels.TabIndex = 22
        Me.Lbl_Steels.Text = "Steels:"
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(1822, 5)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 53
        Me.Pic_Help.TabStop = False
        '
        'Tb_Playername2
        '
        Me.Tb_Playername2.Enabled = False
        Me.Tb_Playername2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Playername2.Location = New System.Drawing.Point(1306, 124)
        Me.Tb_Playername2.Name = "Tb_Playername2"
        Me.Tb_Playername2.Size = New System.Drawing.Size(262, 30)
        Me.Tb_Playername2.TabIndex = 47
        Me.Tb_Playername2.Text = "Player name"
        '
        'Tb_Playername
        '
        Me.Tb_Playername.Enabled = False
        Me.Tb_Playername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Playername.Location = New System.Drawing.Point(32, 124)
        Me.Tb_Playername.Name = "Tb_Playername"
        Me.Tb_Playername.Size = New System.Drawing.Size(262, 30)
        Me.Tb_Playername.TabIndex = 46
        Me.Tb_Playername.Text = "Player name"
        '
        'CB_Gametype2
        '
        Me.CB_Gametype2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Gametype2.FormattingEnabled = True
        Me.CB_Gametype2.Location = New System.Drawing.Point(1307, 69)
        Me.CB_Gametype2.Name = "CB_Gametype2"
        Me.CB_Gametype2.Size = New System.Drawing.Size(262, 33)
        Me.CB_Gametype2.TabIndex = 45
        Me.CB_Gametype2.Tag = "0"
        Me.CB_Gametype2.Text = "Game type"
        '
        'CB_Gametype
        '
        Me.CB_Gametype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Gametype.FormattingEnabled = True
        Me.CB_Gametype.Location = New System.Drawing.Point(32, 69)
        Me.CB_Gametype.Name = "CB_Gametype"
        Me.CB_Gametype.Size = New System.Drawing.Size(262, 33)
        Me.CB_Gametype.TabIndex = 44
        Me.CB_Gametype.Tag = "0"
        Me.CB_Gametype.Text = "Game type"
        '
        'Lbl_TeamName
        '
        Me.Lbl_TeamName.AutoSize = True
        Me.Lbl_TeamName.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TeamName.ForeColor = System.Drawing.Color.White
        Me.Lbl_TeamName.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_TeamName.Name = "Lbl_TeamName"
        Me.Lbl_TeamName.Size = New System.Drawing.Size(177, 34)
        Me.Lbl_TeamName.TabIndex = 43
        Me.Lbl_TeamName.Text = "Team name"
        '
        'CB_Playercode2
        '
        Me.CB_Playercode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Playercode2.FormattingEnabled = True
        Me.CB_Playercode2.Location = New System.Drawing.Point(1307, 10)
        Me.CB_Playercode2.Name = "CB_Playercode2"
        Me.CB_Playercode2.Size = New System.Drawing.Size(262, 33)
        Me.CB_Playercode2.TabIndex = 42
        Me.CB_Playercode2.Tag = "0"
        Me.CB_Playercode2.Text = "Player code"
        '
        'Chart2
        '
        ChartArea3.Area3DStyle.Enable3D = True
        ChartArea3.Name = "ChartArea2"
        ChartArea3.Visible = False
        Me.Chart2.ChartAreas.Add(ChartArea3)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend3)
        Me.Chart2.Location = New System.Drawing.Point(0, 0)
        Me.Chart2.Name = "Chart2"
        Series3.ChartArea = "ChartArea2"
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.Legend = "Legend1"
        Series3.Name = "Players stats2"
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Size = New System.Drawing.Size(956, 613)
        Me.Chart2.TabIndex = 41
        Me.Chart2.Text = "Chart2"
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.Empty
        ChartArea4.Area3DStyle.Enable3D = True
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea4.Name = "ChartArea1"
        ChartArea4.Visible = False
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.Legend = "Legend1"
        Series4.Name = "Players stats1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(956, 613)
        Me.Chart1.TabIndex = 40
        Me.Chart1.Text = "Chart1"
        '
        'CB_Playercode
        '
        Me.CB_Playercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Playercode.FormattingEnabled = True
        Me.CB_Playercode.Location = New System.Drawing.Point(32, 10)
        Me.CB_Playercode.Name = "CB_Playercode"
        Me.CB_Playercode.Size = New System.Drawing.Size(262, 33)
        Me.CB_Playercode.TabIndex = 39
        Me.CB_Playercode.Tag = "0"
        Me.CB_Playercode.Text = "Player code"
        '
        'Lbl_EmptyVal2
        '
        Me.Lbl_EmptyVal2.AutoSize = True
        Me.Lbl_EmptyVal2.BackColor = System.Drawing.Color.White
        Me.Lbl_EmptyVal2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EmptyVal2.Location = New System.Drawing.Point(237, 171)
        Me.Lbl_EmptyVal2.Name = "Lbl_EmptyVal2"
        Me.Lbl_EmptyVal2.Size = New System.Drawing.Size(492, 28)
        Me.Lbl_EmptyVal2.TabIndex = 52
        Me.Lbl_EmptyVal2.Text = "This player doesn't play in this game type"
        Me.Lbl_EmptyVal2.Visible = False
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Lbl_TeamName)
        Me.Panel_Top.Controls.Add(Me.Pic_Help)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1924, 72)
        Me.Panel_Top.TabIndex = 1
        '
        'Panel_Controls
        '
        Me.Panel_Controls.BackColor = System.Drawing.Color.White
        Me.Panel_Controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Controls.Controls.Add(Me.GB_Design)
        Me.Panel_Controls.Controls.Add(Me.GB_Player2Stats)
        Me.Panel_Controls.Controls.Add(Me.GB_Player1Stats)
        Me.Panel_Controls.Controls.Add(Me.Tb_Playername2)
        Me.Panel_Controls.Controls.Add(Me.CB_Playercode)
        Me.Panel_Controls.Controls.Add(Me.CB_Gametype2)
        Me.Panel_Controls.Controls.Add(Me.CB_Gametype)
        Me.Panel_Controls.Controls.Add(Me.CB_Playercode2)
        Me.Panel_Controls.Controls.Add(Me.Tb_Playername)
        Me.Panel_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Controls.Location = New System.Drawing.Point(0, 72)
        Me.Panel_Controls.Name = "Panel_Controls"
        Me.Panel_Controls.Size = New System.Drawing.Size(1924, 186)
        Me.Panel_Controls.TabIndex = 2
        '
        'TLP_Charts
        '
        Me.TLP_Charts.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TLP_Charts.ColumnCount = 2
        Me.TLP_Charts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Charts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Charts.Controls.Add(Me.Panel_Chart2, 1, 0)
        Me.TLP_Charts.Controls.Add(Me.Panel_Chart1, 0, 0)
        Me.TLP_Charts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP_Charts.Location = New System.Drawing.Point(0, 258)
        Me.TLP_Charts.Name = "TLP_Charts"
        Me.TLP_Charts.RowCount = 1
        Me.TLP_Charts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Charts.Size = New System.Drawing.Size(1924, 619)
        Me.TLP_Charts.TabIndex = 53
        '
        'Panel_Chart2
        '
        Me.Panel_Chart2.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Chart2.Controls.Add(Me.Lbl_EmptyVal2)
        Me.Panel_Chart2.Controls.Add(Me.Chart2)
        Me.Panel_Chart2.Location = New System.Drawing.Point(965, 3)
        Me.Panel_Chart2.Name = "Panel_Chart2"
        Me.Panel_Chart2.Size = New System.Drawing.Size(956, 613)
        Me.Panel_Chart2.TabIndex = 55
        '
        'Panel_Chart1
        '
        Me.Panel_Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Chart1.Controls.Add(Me.Lbl_EmptyVal)
        Me.Panel_Chart1.Controls.Add(Me.Chart1)
        Me.Panel_Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Chart1.Name = "Panel_Chart1"
        Me.Panel_Chart1.Size = New System.Drawing.Size(956, 613)
        Me.Panel_Chart1.TabIndex = 54
        '
        'StatsCompares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 877)
        Me.Controls.Add(Me.TLP_Charts)
        Me.Controls.Add(Me.Panel_Controls)
        Me.Controls.Add(Me.Panel_Top)
        Me.Name = "StatsCompares"
        Me.Text = "StatsCompares"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GB_Design.ResumeLayout(False)
        Me.GB_Design.PerformLayout()
        Me.GB_Player2Stats.ResumeLayout(False)
        Me.GB_Player2Stats.PerformLayout()
        Me.GB_Player1Stats.ResumeLayout(False)
        Me.GB_Player1Stats.PerformLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.Panel_Controls.ResumeLayout(False)
        Me.Panel_Controls.PerformLayout()
        Me.TLP_Charts.ResumeLayout(False)
        Me.Panel_Chart2.ResumeLayout(False)
        Me.Panel_Chart2.PerformLayout()
        Me.Panel_Chart1.ResumeLayout(False)
        Me.Panel_Chart1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_Design As System.Windows.Forms.GroupBox
    Friend WithEvents CB_ValuesPosition As System.Windows.Forms.ComboBox
    Friend WithEvents RB_No As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Yes As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_3D As System.Windows.Forms.Label
    Friend WithEvents CB_ChartTypes As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_EmptyVal As System.Windows.Forms.Label
    Friend WithEvents GB_Player2Stats As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Pointsnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blocksnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Points2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assists2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steelsnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assistsnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Rebounds2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Reboundsnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steels2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blocks2 As System.Windows.Forms.Label
    Friend WithEvents GB_Player1Stats As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Pointsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blocksnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Points As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assists As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steelsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blocks As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assistsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Rebounds As System.Windows.Forms.Label
    Friend WithEvents Lbl_Reboundsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steels As System.Windows.Forms.Label
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
    Friend WithEvents Tb_Playername2 As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Playername As System.Windows.Forms.TextBox
    Friend WithEvents CB_Gametype2 As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Gametype As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_TeamName As System.Windows.Forms.Label
    Friend WithEvents CB_Playercode2 As System.Windows.Forms.ComboBox
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CB_Playercode As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_EmptyVal2 As System.Windows.Forms.Label
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Panel_Controls As System.Windows.Forms.Panel
    Friend WithEvents TLP_Charts As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_Chart1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_Chart2 As System.Windows.Forms.Panel
End Class
