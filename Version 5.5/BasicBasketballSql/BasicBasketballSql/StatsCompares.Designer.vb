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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.CB_Playercode = New System.Windows.Forms.ComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CB_Playercode2 = New System.Windows.Forms.ComboBox()
        Me.Lbl_TeamName = New System.Windows.Forms.Label()
        Me.CB_Gametype = New System.Windows.Forms.ComboBox()
        Me.CB_Gametype2 = New System.Windows.Forms.ComboBox()
        Me.Tb_Playername = New System.Windows.Forms.TextBox()
        Me.Tb_Playername2 = New System.Windows.Forms.TextBox()
        Me.Lbl_Blocksnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Steelsnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Reboundsnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Blocks2 = New System.Windows.Forms.Label()
        Me.Lbl_Steels2 = New System.Windows.Forms.Label()
        Me.Lbl_Rebounds2 = New System.Windows.Forms.Label()
        Me.Lbl_Assistsnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Assists2 = New System.Windows.Forms.Label()
        Me.Lbl_Points2 = New System.Windows.Forms.Label()
        Me.Lbl_Pointsnum2 = New System.Windows.Forms.Label()
        Me.CB_ChartTypes = New System.Windows.Forms.ComboBox()
        Me.Lbl_3D = New System.Windows.Forms.Label()
        Me.RB_Yes = New System.Windows.Forms.RadioButton()
        Me.RB_No = New System.Windows.Forms.RadioButton()
        Me.CB_ValuesPosition = New System.Windows.Forms.ComboBox()
        Me.GB_Design = New System.Windows.Forms.GroupBox()
        Me.Lbl_Pointsnum = New System.Windows.Forms.Label()
        Me.Lbl_Points = New System.Windows.Forms.Label()
        Me.Lbl_Assists = New System.Windows.Forms.Label()
        Me.Lbl_Assistsnum = New System.Windows.Forms.Label()
        Me.Lbl_Rebounds = New System.Windows.Forms.Label()
        Me.Lbl_Steels = New System.Windows.Forms.Label()
        Me.Lbl_Blocks = New System.Windows.Forms.Label()
        Me.Lbl_Reboundsnum = New System.Windows.Forms.Label()
        Me.Lbl_Steelsnum = New System.Windows.Forms.Label()
        Me.Lbl_Blocksnum = New System.Windows.Forms.Label()
        Me.GB_Player1Stats = New System.Windows.Forms.GroupBox()
        Me.GB_Player2Stats = New System.Windows.Forms.GroupBox()
        Me.Lbl_EmptyVal = New System.Windows.Forms.Label()
        Me.Lbl_EmptyVal2 = New System.Windows.Forms.Label()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Design.SuspendLayout()
        Me.GB_Player1Stats.SuspendLayout()
        Me.GB_Player2Stats.SuspendLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_Playercode
        '
        Me.CB_Playercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Playercode.FormattingEnabled = True
        Me.CB_Playercode.Location = New System.Drawing.Point(12, 38)
        Me.CB_Playercode.Name = "CB_Playercode"
        Me.CB_Playercode.Size = New System.Drawing.Size(262, 33)
        Me.CB_Playercode.TabIndex = 1
        Me.CB_Playercode.Tag = "0"
        Me.CB_Playercode.Text = "Player code"
        '
        'Chart1
        '
        Me.Chart1.BorderlineColor = System.Drawing.Color.Empty
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Visible = False
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 246)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "Players stats1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(564, 446)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Name = "ChartArea2"
        ChartArea2.Visible = False
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(705, 246)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea2"
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Legend = "Legend1"
        Series2.Name = "Players stats2"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(564, 446)
        Me.Chart2.TabIndex = 5
        Me.Chart2.Text = "Chart2"
        '
        'CB_Playercode2
        '
        Me.CB_Playercode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Playercode2.FormattingEnabled = True
        Me.CB_Playercode2.Location = New System.Drawing.Point(861, 43)
        Me.CB_Playercode2.Name = "CB_Playercode2"
        Me.CB_Playercode2.Size = New System.Drawing.Size(262, 33)
        Me.CB_Playercode2.TabIndex = 6
        Me.CB_Playercode2.Tag = "0"
        Me.CB_Playercode2.Text = "Player code"
        '
        'Lbl_TeamName
        '
        Me.Lbl_TeamName.AutoSize = True
        Me.Lbl_TeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_TeamName.Location = New System.Drawing.Point(538, 3)
        Me.Lbl_TeamName.Name = "Lbl_TeamName"
        Me.Lbl_TeamName.Size = New System.Drawing.Size(126, 25)
        Me.Lbl_TeamName.TabIndex = 9
        Me.Lbl_TeamName.Text = "Team name"
        '
        'CB_Gametype
        '
        Me.CB_Gametype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Gametype.FormattingEnabled = True
        Me.CB_Gametype.Location = New System.Drawing.Point(12, 97)
        Me.CB_Gametype.Name = "CB_Gametype"
        Me.CB_Gametype.Size = New System.Drawing.Size(262, 33)
        Me.CB_Gametype.TabIndex = 10
        Me.CB_Gametype.Tag = "0"
        Me.CB_Gametype.Text = "Game type"
        '
        'CB_Gametype2
        '
        Me.CB_Gametype2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Gametype2.FormattingEnabled = True
        Me.CB_Gametype2.Location = New System.Drawing.Point(861, 99)
        Me.CB_Gametype2.Name = "CB_Gametype2"
        Me.CB_Gametype2.Size = New System.Drawing.Size(262, 33)
        Me.CB_Gametype2.TabIndex = 11
        Me.CB_Gametype2.Tag = "0"
        Me.CB_Gametype2.Text = "Game type"
        '
        'Tb_Playername
        '
        Me.Tb_Playername.Enabled = False
        Me.Tb_Playername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Playername.Location = New System.Drawing.Point(12, 152)
        Me.Tb_Playername.Name = "Tb_Playername"
        Me.Tb_Playername.Size = New System.Drawing.Size(262, 30)
        Me.Tb_Playername.TabIndex = 15
        Me.Tb_Playername.Text = "Player name"
        '
        'Tb_Playername2
        '
        Me.Tb_Playername2.Enabled = False
        Me.Tb_Playername2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_Playername2.Location = New System.Drawing.Point(860, 152)
        Me.Tb_Playername2.Name = "Tb_Playername2"
        Me.Tb_Playername2.Size = New System.Drawing.Size(262, 30)
        Me.Tb_Playername2.TabIndex = 16
        Me.Tb_Playername2.Text = "Player name"
        '
        'Lbl_Blocksnum2
        '
        Me.Lbl_Blocksnum2.AutoSize = True
        Me.Lbl_Blocksnum2.Location = New System.Drawing.Point(106, 135)
        Me.Lbl_Blocksnum2.Name = "Lbl_Blocksnum2"
        Me.Lbl_Blocksnum2.Size = New System.Drawing.Size(92, 20)
        Me.Lbl_Blocksnum2.TabIndex = 26
        Me.Lbl_Blocksnum2.Text = "Blocksnum"
        '
        'Lbl_Steelsnum2
        '
        Me.Lbl_Steelsnum2.AutoSize = True
        Me.Lbl_Steelsnum2.Location = New System.Drawing.Point(106, 107)
        Me.Lbl_Steelsnum2.Name = "Lbl_Steelsnum2"
        Me.Lbl_Steelsnum2.Size = New System.Drawing.Size(88, 20)
        Me.Lbl_Steelsnum2.TabIndex = 25
        Me.Lbl_Steelsnum2.Text = "Steelsnum"
        '
        'Lbl_Reboundsnum2
        '
        Me.Lbl_Reboundsnum2.AutoSize = True
        Me.Lbl_Reboundsnum2.Location = New System.Drawing.Point(106, 79)
        Me.Lbl_Reboundsnum2.Name = "Lbl_Reboundsnum2"
        Me.Lbl_Reboundsnum2.Size = New System.Drawing.Size(116, 20)
        Me.Lbl_Reboundsnum2.TabIndex = 24
        Me.Lbl_Reboundsnum2.Text = "Reboundsnum"
        '
        'Lbl_Blocks2
        '
        Me.Lbl_Blocks2.AutoSize = True
        Me.Lbl_Blocks2.Location = New System.Drawing.Point(6, 135)
        Me.Lbl_Blocks2.Name = "Lbl_Blocks2"
        Me.Lbl_Blocks2.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_Blocks2.TabIndex = 23
        Me.Lbl_Blocks2.Text = "Blocks:"
        '
        'Lbl_Steels2
        '
        Me.Lbl_Steels2.AutoSize = True
        Me.Lbl_Steels2.Location = New System.Drawing.Point(6, 107)
        Me.Lbl_Steels2.Name = "Lbl_Steels2"
        Me.Lbl_Steels2.Size = New System.Drawing.Size(61, 20)
        Me.Lbl_Steels2.TabIndex = 22
        Me.Lbl_Steels2.Text = "Steels:"
        '
        'Lbl_Rebounds2
        '
        Me.Lbl_Rebounds2.AutoSize = True
        Me.Lbl_Rebounds2.Location = New System.Drawing.Point(6, 79)
        Me.Lbl_Rebounds2.Name = "Lbl_Rebounds2"
        Me.Lbl_Rebounds2.Size = New System.Drawing.Size(89, 20)
        Me.Lbl_Rebounds2.TabIndex = 21
        Me.Lbl_Rebounds2.Text = "Rebounds:"
        '
        'Lbl_Assistsnum2
        '
        Me.Lbl_Assistsnum2.AutoSize = True
        Me.Lbl_Assistsnum2.Location = New System.Drawing.Point(106, 50)
        Me.Lbl_Assistsnum2.Name = "Lbl_Assistsnum2"
        Me.Lbl_Assistsnum2.Size = New System.Drawing.Size(97, 20)
        Me.Lbl_Assistsnum2.TabIndex = 20
        Me.Lbl_Assistsnum2.Text = "Assistsnum"
        '
        'Lbl_Assists2
        '
        Me.Lbl_Assists2.AutoSize = True
        Me.Lbl_Assists2.Location = New System.Drawing.Point(6, 50)
        Me.Lbl_Assists2.Name = "Lbl_Assists2"
        Me.Lbl_Assists2.Size = New System.Drawing.Size(70, 20)
        Me.Lbl_Assists2.TabIndex = 19
        Me.Lbl_Assists2.Text = "Assists:"
        '
        'Lbl_Points2
        '
        Me.Lbl_Points2.AutoSize = True
        Me.Lbl_Points2.Location = New System.Drawing.Point(6, 19)
        Me.Lbl_Points2.Name = "Lbl_Points2"
        Me.Lbl_Points2.Size = New System.Drawing.Size(61, 20)
        Me.Lbl_Points2.TabIndex = 18
        Me.Lbl_Points2.Text = "Points:"
        '
        'Lbl_Pointsnum2
        '
        Me.Lbl_Pointsnum2.AutoSize = True
        Me.Lbl_Pointsnum2.Location = New System.Drawing.Point(106, 20)
        Me.Lbl_Pointsnum2.Name = "Lbl_Pointsnum2"
        Me.Lbl_Pointsnum2.Size = New System.Drawing.Size(88, 20)
        Me.Lbl_Pointsnum2.TabIndex = 17
        Me.Lbl_Pointsnum2.Text = "Pointsnum"
        '
        'CB_ChartTypes
        '
        Me.CB_ChartTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_ChartTypes.FormattingEnabled = True
        Me.CB_ChartTypes.Items.AddRange(New Object() {"Bar ", "Column", "Pie", "Doughnut"})
        Me.CB_ChartTypes.Location = New System.Drawing.Point(12, 26)
        Me.CB_ChartTypes.Name = "CB_ChartTypes"
        Me.CB_ChartTypes.Size = New System.Drawing.Size(197, 28)
        Me.CB_ChartTypes.TabIndex = 28
        Me.CB_ChartTypes.Tag = "0"
        Me.CB_ChartTypes.Text = "Change chart type"
        '
        'Lbl_3D
        '
        Me.Lbl_3D.AutoSize = True
        Me.Lbl_3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_3D.Location = New System.Drawing.Point(16, 123)
        Me.Lbl_3D.Name = "Lbl_3D"
        Me.Lbl_3D.Size = New System.Drawing.Size(40, 20)
        Me.Lbl_3D.TabIndex = 29
        Me.Lbl_3D.Text = "3D?"
        '
        'RB_Yes
        '
        Me.RB_Yes.AutoSize = True
        Me.RB_Yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RB_Yes.Location = New System.Drawing.Point(70, 121)
        Me.RB_Yes.Name = "RB_Yes"
        Me.RB_Yes.Size = New System.Drawing.Size(58, 24)
        Me.RB_Yes.TabIndex = 30
        Me.RB_Yes.TabStop = True
        Me.RB_Yes.Text = "Yes"
        Me.RB_Yes.UseVisualStyleBackColor = True
        '
        'RB_No
        '
        Me.RB_No.AutoSize = True
        Me.RB_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RB_No.Location = New System.Drawing.Point(151, 121)
        Me.RB_No.Name = "RB_No"
        Me.RB_No.Size = New System.Drawing.Size(51, 24)
        Me.RB_No.TabIndex = 31
        Me.RB_No.TabStop = True
        Me.RB_No.Text = "No"
        Me.RB_No.UseVisualStyleBackColor = True
        '
        'CB_ValuesPosition
        '
        Me.CB_ValuesPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_ValuesPosition.FormattingEnabled = True
        Me.CB_ValuesPosition.Items.AddRange(New Object() {"Inside", "Outside", "Disabled"})
        Me.CB_ValuesPosition.Location = New System.Drawing.Point(12, 79)
        Me.CB_ValuesPosition.Name = "CB_ValuesPosition"
        Me.CB_ValuesPosition.Size = New System.Drawing.Size(197, 28)
        Me.CB_ValuesPosition.TabIndex = 32
        Me.CB_ValuesPosition.Tag = "0"
        Me.CB_ValuesPosition.Text = "Set value position"
        '
        'GB_Design
        '
        Me.GB_Design.Controls.Add(Me.CB_ValuesPosition)
        Me.GB_Design.Controls.Add(Me.RB_No)
        Me.GB_Design.Controls.Add(Me.RB_Yes)
        Me.GB_Design.Controls.Add(Me.Lbl_3D)
        Me.GB_Design.Controls.Add(Me.CB_ChartTypes)
        Me.GB_Design.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Design.Location = New System.Drawing.Point(604, 31)
        Me.GB_Design.Name = "GB_Design"
        Me.GB_Design.Size = New System.Drawing.Size(215, 163)
        Me.GB_Design.TabIndex = 33
        Me.GB_Design.TabStop = False
        Me.GB_Design.Text = "Design box"
        '
        'Lbl_Pointsnum
        '
        Me.Lbl_Pointsnum.AutoSize = True
        Me.Lbl_Pointsnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Pointsnum.Location = New System.Drawing.Point(108, 20)
        Me.Lbl_Pointsnum.Name = "Lbl_Pointsnum"
        Me.Lbl_Pointsnum.Size = New System.Drawing.Size(88, 20)
        Me.Lbl_Pointsnum.TabIndex = 17
        Me.Lbl_Pointsnum.Text = "Pointsnum"
        '
        'Lbl_Points
        '
        Me.Lbl_Points.AutoSize = True
        Me.Lbl_Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Points.Location = New System.Drawing.Point(2, 19)
        Me.Lbl_Points.Name = "Lbl_Points"
        Me.Lbl_Points.Size = New System.Drawing.Size(61, 20)
        Me.Lbl_Points.TabIndex = 18
        Me.Lbl_Points.Text = "Points:"
        '
        'Lbl_Assists
        '
        Me.Lbl_Assists.AutoSize = True
        Me.Lbl_Assists.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Assists.Location = New System.Drawing.Point(2, 50)
        Me.Lbl_Assists.Name = "Lbl_Assists"
        Me.Lbl_Assists.Size = New System.Drawing.Size(70, 20)
        Me.Lbl_Assists.TabIndex = 19
        Me.Lbl_Assists.Text = "Assists:"
        '
        'Lbl_Assistsnum
        '
        Me.Lbl_Assistsnum.AutoSize = True
        Me.Lbl_Assistsnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Assistsnum.Location = New System.Drawing.Point(108, 50)
        Me.Lbl_Assistsnum.Name = "Lbl_Assistsnum"
        Me.Lbl_Assistsnum.Size = New System.Drawing.Size(97, 20)
        Me.Lbl_Assistsnum.TabIndex = 20
        Me.Lbl_Assistsnum.Text = "Assistsnum"
        '
        'Lbl_Rebounds
        '
        Me.Lbl_Rebounds.AutoSize = True
        Me.Lbl_Rebounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Rebounds.Location = New System.Drawing.Point(2, 79)
        Me.Lbl_Rebounds.Name = "Lbl_Rebounds"
        Me.Lbl_Rebounds.Size = New System.Drawing.Size(89, 20)
        Me.Lbl_Rebounds.TabIndex = 21
        Me.Lbl_Rebounds.Text = "Rebounds:"
        '
        'Lbl_Steels
        '
        Me.Lbl_Steels.AutoSize = True
        Me.Lbl_Steels.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Steels.Location = New System.Drawing.Point(2, 111)
        Me.Lbl_Steels.Name = "Lbl_Steels"
        Me.Lbl_Steels.Size = New System.Drawing.Size(61, 20)
        Me.Lbl_Steels.TabIndex = 22
        Me.Lbl_Steels.Text = "Steels:"
        '
        'Lbl_Blocks
        '
        Me.Lbl_Blocks.AutoSize = True
        Me.Lbl_Blocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Blocks.Location = New System.Drawing.Point(2, 135)
        Me.Lbl_Blocks.Name = "Lbl_Blocks"
        Me.Lbl_Blocks.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_Blocks.TabIndex = 23
        Me.Lbl_Blocks.Text = "Blocks:"
        '
        'Lbl_Reboundsnum
        '
        Me.Lbl_Reboundsnum.AutoSize = True
        Me.Lbl_Reboundsnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Reboundsnum.Location = New System.Drawing.Point(108, 79)
        Me.Lbl_Reboundsnum.Name = "Lbl_Reboundsnum"
        Me.Lbl_Reboundsnum.Size = New System.Drawing.Size(116, 20)
        Me.Lbl_Reboundsnum.TabIndex = 24
        Me.Lbl_Reboundsnum.Text = "Reboundsnum"
        '
        'Lbl_Steelsnum
        '
        Me.Lbl_Steelsnum.AutoSize = True
        Me.Lbl_Steelsnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Steelsnum.Location = New System.Drawing.Point(108, 111)
        Me.Lbl_Steelsnum.Name = "Lbl_Steelsnum"
        Me.Lbl_Steelsnum.Size = New System.Drawing.Size(88, 20)
        Me.Lbl_Steelsnum.TabIndex = 25
        Me.Lbl_Steelsnum.Text = "Steelsnum"
        '
        'Lbl_Blocksnum
        '
        Me.Lbl_Blocksnum.AutoSize = True
        Me.Lbl_Blocksnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Blocksnum.Location = New System.Drawing.Point(108, 135)
        Me.Lbl_Blocksnum.Name = "Lbl_Blocksnum"
        Me.Lbl_Blocksnum.Size = New System.Drawing.Size(92, 20)
        Me.Lbl_Blocksnum.TabIndex = 26
        Me.Lbl_Blocksnum.Text = "Blocksnum"
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
        Me.GB_Player1Stats.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Player1Stats.Location = New System.Drawing.Point(280, 31)
        Me.GB_Player1Stats.Name = "GB_Player1Stats"
        Me.GB_Player1Stats.Size = New System.Drawing.Size(305, 163)
        Me.GB_Player1Stats.TabIndex = 34
        Me.GB_Player1Stats.TabStop = False
        Me.GB_Player1Stats.Text = "Player 1 Stats"
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
        Me.GB_Player2Stats.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Player2Stats.Location = New System.Drawing.Point(1153, 31)
        Me.GB_Player2Stats.Name = "GB_Player2Stats"
        Me.GB_Player2Stats.Size = New System.Drawing.Size(305, 163)
        Me.GB_Player2Stats.TabIndex = 35
        Me.GB_Player2Stats.TabStop = False
        Me.GB_Player2Stats.Text = "Player 2 Stats"
        '
        'Lbl_EmptyVal
        '
        Me.Lbl_EmptyVal.AutoSize = True
        Me.Lbl_EmptyVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_EmptyVal.Location = New System.Drawing.Point(50, 438)
        Me.Lbl_EmptyVal.Name = "Lbl_EmptyVal"
        Me.Lbl_EmptyVal.Size = New System.Drawing.Size(410, 25)
        Me.Lbl_EmptyVal.TabIndex = 36
        Me.Lbl_EmptyVal.Text = "This player doesn't play in this game type"
        Me.Lbl_EmptyVal.Visible = False
        '
        'Lbl_EmptyVal2
        '
        Me.Lbl_EmptyVal2.AutoSize = True
        Me.Lbl_EmptyVal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_EmptyVal2.Location = New System.Drawing.Point(767, 438)
        Me.Lbl_EmptyVal2.Name = "Lbl_EmptyVal2"
        Me.Lbl_EmptyVal2.Size = New System.Drawing.Size(410, 25)
        Me.Lbl_EmptyVal2.TabIndex = 37
        Me.Lbl_EmptyVal2.Text = "This player doesn't play in this game type"
        Me.Lbl_EmptyVal2.Visible = False
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(604, 200)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 38
        Me.Pic_Help.TabStop = False
        '
        'StatsCompares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1504, 877)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.Lbl_EmptyVal2)
        Me.Controls.Add(Me.Lbl_EmptyVal)
        Me.Controls.Add(Me.GB_Player2Stats)
        Me.Controls.Add(Me.GB_Player1Stats)
        Me.Controls.Add(Me.GB_Design)
        Me.Controls.Add(Me.Tb_Playername2)
        Me.Controls.Add(Me.Tb_Playername)
        Me.Controls.Add(Me.CB_Gametype2)
        Me.Controls.Add(Me.CB_Gametype)
        Me.Controls.Add(Me.Lbl_TeamName)
        Me.Controls.Add(Me.CB_Playercode2)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.CB_Playercode)
        Me.Name = "StatsCompares"
        Me.Text = "StatsCompares"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Design.ResumeLayout(False)
        Me.GB_Design.PerformLayout()
        Me.GB_Player1Stats.ResumeLayout(False)
        Me.GB_Player1Stats.PerformLayout()
        Me.GB_Player2Stats.ResumeLayout(False)
        Me.GB_Player2Stats.PerformLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_Playercode As System.Windows.Forms.ComboBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents CB_Playercode2 As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_TeamName As System.Windows.Forms.Label
    Friend WithEvents CB_Gametype As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Gametype2 As System.Windows.Forms.ComboBox
    Friend WithEvents Tb_Playername As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Playername2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Blocksnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steelsnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Reboundsnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blocks2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steels2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Rebounds2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assistsnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assists2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Points2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Pointsnum2 As System.Windows.Forms.Label
    Friend WithEvents CB_ChartTypes As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_3D As System.Windows.Forms.Label
    Friend WithEvents RB_Yes As System.Windows.Forms.RadioButton
    Friend WithEvents RB_No As System.Windows.Forms.RadioButton
    Friend WithEvents CB_ValuesPosition As System.Windows.Forms.ComboBox
    Friend WithEvents GB_Design As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Pointsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Points As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assists As System.Windows.Forms.Label
    Friend WithEvents Lbl_Assistsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Rebounds As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steels As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blocks As System.Windows.Forms.Label
    Friend WithEvents Lbl_Reboundsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Steelsnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Blocksnum As System.Windows.Forms.Label
    Friend WithEvents GB_Player1Stats As System.Windows.Forms.GroupBox
    Friend WithEvents GB_Player2Stats As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_EmptyVal As System.Windows.Forms.Label
    Friend WithEvents Lbl_EmptyVal2 As System.Windows.Forms.Label
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
