<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamesVisionAlgo
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
        Me.Lbl_CheckBack = New System.Windows.Forms.Label()
        Me.GB_ATC = New System.Windows.Forms.GroupBox()
        Me.Lbl_Anum3 = New System.Windows.Forms.Label()
        Me.Lbl_Anum2 = New System.Windows.Forms.Label()
        Me.Lbl_Anum = New System.Windows.Forms.Label()
        Me.Lbl_DontPlayed = New System.Windows.Forms.Label()
        Me.Lbl_CountA = New System.Windows.Forms.Label()
        Me.Lbl_Played = New System.Windows.Forms.Label()
        Me.GB_HTC = New System.Windows.Forms.GroupBox()
        Me.Lbl_Hnum3 = New System.Windows.Forms.Label()
        Me.Lbl_Hnum2 = New System.Windows.Forms.Label()
        Me.Lbl_Hnum = New System.Windows.Forms.Label()
        Me.Lbl_DontPlayed2 = New System.Windows.Forms.Label()
        Me.Lbl_Played2 = New System.Windows.Forms.Label()
        Me.Lbl_CountH = New System.Windows.Forms.Label()
        Me.Lbl_NotAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_No0 = New System.Windows.Forms.Label()
        Me.Lbl_YesAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_Above0 = New System.Windows.Forms.Label()
        Me.Lbl_NotAbove100 = New System.Windows.Forms.Label()
        Me.Lbl_YesAbove100 = New System.Windows.Forms.Label()
        Me.Lbl_No100 = New System.Windows.Forms.Label()
        Me.Lbl_Above100 = New System.Windows.Forms.Label()
        Me.Lbl_AZero = New System.Windows.Forms.Label()
        Me.Lbl_A100 = New System.Windows.Forms.Label()
        Me.Lbl_H100 = New System.Windows.Forms.Label()
        Me.Lbl_HZero = New System.Windows.Forms.Label()
        Me.Lbl_HNotAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_HNo0 = New System.Windows.Forms.Label()
        Me.Lbl_HYesAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_HAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_HNotAbove100 = New System.Windows.Forms.Label()
        Me.Lbl_HYesAbove100 = New System.Windows.Forms.Label()
        Me.Lbl_HNo100 = New System.Windows.Forms.Label()
        Me.Lbl_HAbove100 = New System.Windows.Forms.Label()
        Me.Lbl_2AZero = New System.Windows.Forms.Label()
        Me.Lbl_2A50 = New System.Windows.Forms.Label()
        Me.Lbl_2HZero = New System.Windows.Forms.Label()
        Me.Lbl_2H50 = New System.Windows.Forms.Label()
        Me.Lbl_DNotAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_DNo0 = New System.Windows.Forms.Label()
        Me.Lbl_DYesAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_DAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_NotAbove50 = New System.Windows.Forms.Label()
        Me.Lbl_YesAbove50 = New System.Windows.Forms.Label()
        Me.Lbl_No50 = New System.Windows.Forms.Label()
        Me.Lbl_Above50 = New System.Windows.Forms.Label()
        Me.Lbl_DHNotAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_HDNo0 = New System.Windows.Forms.Label()
        Me.Lbl_DHYesAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_DHAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_DHNotAbove50 = New System.Windows.Forms.Label()
        Me.Lbl_DHYesAbove50 = New System.Windows.Forms.Label()
        Me.Lbl_HDNo50 = New System.Windows.Forms.Label()
        Me.Lbl_HAbove50 = New System.Windows.Forms.Label()
        Me.Lbl_Res = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Lbl_PrevAMatch = New System.Windows.Forms.Label()
        Me.Lbl_PrevHMatch = New System.Windows.Forms.Label()
        Me.Lbl_TotalSeen = New System.Windows.Forms.Label()
        Me.Lbl_Res2 = New System.Windows.Forms.Label()
        Me.TLP_Top = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_UnSeenLbl = New System.Windows.Forms.Panel()
        Me.TLP_Boxes = New System.Windows.Forms.TableLayoutPanel()
        Me.TLP_Results = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel_Display = New System.Windows.Forms.Panel()
        Me.Panel_Chart = New System.Windows.Forms.Panel()
        Me.Panel_AwayOffense = New System.Windows.Forms.Panel()
        Me.Panel_AwayDefence = New System.Windows.Forms.Panel()
        Me.Panel_HomeOffense = New System.Windows.Forms.Panel()
        Me.Panel_HomeDefence = New System.Windows.Forms.Panel()
        Me.GB_ATC.SuspendLayout()
        Me.GB_HTC.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP_Top.SuspendLayout()
        Me.Panel_UnSeenLbl.SuspendLayout()
        Me.TLP_Boxes.SuspendLayout()
        Me.TLP_Results.SuspendLayout()
        Me.Panel_Display.SuspendLayout()
        Me.Panel_Chart.SuspendLayout()
        Me.Panel_AwayOffense.SuspendLayout()
        Me.Panel_AwayDefence.SuspendLayout()
        Me.Panel_HomeOffense.SuspendLayout()
        Me.Panel_HomeDefence.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_CheckBack
        '
        Me.Lbl_CheckBack.AutoSize = True
        Me.Lbl_CheckBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_CheckBack.Location = New System.Drawing.Point(14, 18)
        Me.Lbl_CheckBack.Name = "Lbl_CheckBack"
        Me.Lbl_CheckBack.Size = New System.Drawing.Size(74, 17)
        Me.Lbl_CheckBack.TabIndex = 7
        Me.Lbl_CheckBack.Text = "Form back"
        Me.Lbl_CheckBack.Visible = False
        '
        'GB_ATC
        '
        Me.GB_ATC.BackColor = System.Drawing.Color.Transparent
        Me.GB_ATC.Controls.Add(Me.Lbl_Anum3)
        Me.GB_ATC.Controls.Add(Me.Lbl_Anum2)
        Me.GB_ATC.Controls.Add(Me.Lbl_Anum)
        Me.GB_ATC.Controls.Add(Me.Lbl_DontPlayed)
        Me.GB_ATC.Controls.Add(Me.Lbl_CountA)
        Me.GB_ATC.Controls.Add(Me.Lbl_Played)
        Me.GB_ATC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_ATC.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.GB_ATC.ForeColor = System.Drawing.Color.White
        Me.GB_ATC.Location = New System.Drawing.Point(3, 3)
        Me.GB_ATC.Name = "GB_ATC"
        Me.GB_ATC.Size = New System.Drawing.Size(704, 58)
        Me.GB_ATC.TabIndex = 9
        Me.GB_ATC.TabStop = False
        Me.GB_ATC.Text = "Away Team"
        '
        'Lbl_Anum3
        '
        Me.Lbl_Anum3.AutoSize = True
        Me.Lbl_Anum3.Location = New System.Drawing.Point(610, 28)
        Me.Lbl_Anum3.Name = "Lbl_Anum3"
        Me.Lbl_Anum3.Size = New System.Drawing.Size(75, 25)
        Me.Lbl_Anum3.TabIndex = 36
        Me.Lbl_Anum3.Text = "Num3"
        '
        'Lbl_Anum2
        '
        Me.Lbl_Anum2.AutoSize = True
        Me.Lbl_Anum2.Location = New System.Drawing.Point(357, 28)
        Me.Lbl_Anum2.Name = "Lbl_Anum2"
        Me.Lbl_Anum2.Size = New System.Drawing.Size(75, 25)
        Me.Lbl_Anum2.TabIndex = 35
        Me.Lbl_Anum2.Text = "Num2"
        '
        'Lbl_Anum
        '
        Me.Lbl_Anum.AutoSize = True
        Me.Lbl_Anum.Location = New System.Drawing.Point(169, 28)
        Me.Lbl_Anum.Name = "Lbl_Anum"
        Me.Lbl_Anum.Size = New System.Drawing.Size(63, 25)
        Me.Lbl_Anum.TabIndex = 34
        Me.Lbl_Anum.Text = "Num"
        '
        'Lbl_DontPlayed
        '
        Me.Lbl_DontPlayed.AutoSize = True
        Me.Lbl_DontPlayed.Location = New System.Drawing.Point(438, 28)
        Me.Lbl_DontPlayed.Name = "Lbl_DontPlayed"
        Me.Lbl_DontPlayed.Size = New System.Drawing.Size(175, 25)
        Me.Lbl_DontPlayed.TabIndex = 33
        Me.Lbl_DontPlayed.Text = "Didnt Played = "
        '
        'Lbl_CountA
        '
        Me.Lbl_CountA.AutoSize = True
        Me.Lbl_CountA.Location = New System.Drawing.Point(6, 28)
        Me.Lbl_CountA.Name = "Lbl_CountA"
        Me.Lbl_CountA.Size = New System.Drawing.Size(155, 25)
        Me.Lbl_CountA.TabIndex = 11
        Me.Lbl_CountA.Text = "Total Players:"
        '
        'Lbl_Played
        '
        Me.Lbl_Played.AutoSize = True
        Me.Lbl_Played.Location = New System.Drawing.Point(238, 28)
        Me.Lbl_Played.Name = "Lbl_Played"
        Me.Lbl_Played.Size = New System.Drawing.Size(113, 25)
        Me.Lbl_Played.TabIndex = 32
        Me.Lbl_Played.Text = "Played = "
        '
        'GB_HTC
        '
        Me.GB_HTC.BackColor = System.Drawing.Color.Transparent
        Me.GB_HTC.Controls.Add(Me.Lbl_Hnum3)
        Me.GB_HTC.Controls.Add(Me.Lbl_Hnum2)
        Me.GB_HTC.Controls.Add(Me.Lbl_Hnum)
        Me.GB_HTC.Controls.Add(Me.Lbl_DontPlayed2)
        Me.GB_HTC.Controls.Add(Me.Lbl_Played2)
        Me.GB_HTC.Controls.Add(Me.Lbl_CountH)
        Me.GB_HTC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB_HTC.Font = New System.Drawing.Font("Century Gothic", 13.0!)
        Me.GB_HTC.ForeColor = System.Drawing.Color.White
        Me.GB_HTC.Location = New System.Drawing.Point(1068, 3)
        Me.GB_HTC.Name = "GB_HTC"
        Me.GB_HTC.Size = New System.Drawing.Size(706, 58)
        Me.GB_HTC.TabIndex = 10
        Me.GB_HTC.TabStop = False
        Me.GB_HTC.Text = "Home Team"
        '
        'Lbl_Hnum3
        '
        Me.Lbl_Hnum3.AutoSize = True
        Me.Lbl_Hnum3.Location = New System.Drawing.Point(625, 28)
        Me.Lbl_Hnum3.Name = "Lbl_Hnum3"
        Me.Lbl_Hnum3.Size = New System.Drawing.Size(75, 25)
        Me.Lbl_Hnum3.TabIndex = 37
        Me.Lbl_Hnum3.Text = "Num3"
        '
        'Lbl_Hnum2
        '
        Me.Lbl_Hnum2.AutoSize = True
        Me.Lbl_Hnum2.Location = New System.Drawing.Point(349, 28)
        Me.Lbl_Hnum2.Name = "Lbl_Hnum2"
        Me.Lbl_Hnum2.Size = New System.Drawing.Size(75, 25)
        Me.Lbl_Hnum2.TabIndex = 37
        Me.Lbl_Hnum2.Text = "Num2"
        '
        'Lbl_Hnum
        '
        Me.Lbl_Hnum.AutoSize = True
        Me.Lbl_Hnum.Location = New System.Drawing.Point(175, 28)
        Me.Lbl_Hnum.Name = "Lbl_Hnum"
        Me.Lbl_Hnum.Size = New System.Drawing.Size(63, 25)
        Me.Lbl_Hnum.TabIndex = 35
        Me.Lbl_Hnum.Text = "Num"
        '
        'Lbl_DontPlayed2
        '
        Me.Lbl_DontPlayed2.AutoSize = True
        Me.Lbl_DontPlayed2.Location = New System.Drawing.Point(444, 28)
        Me.Lbl_DontPlayed2.Name = "Lbl_DontPlayed2"
        Me.Lbl_DontPlayed2.Size = New System.Drawing.Size(175, 25)
        Me.Lbl_DontPlayed2.TabIndex = 34
        Me.Lbl_DontPlayed2.Text = "Didnt Played = "
        '
        'Lbl_Played2
        '
        Me.Lbl_Played2.AutoSize = True
        Me.Lbl_Played2.Location = New System.Drawing.Point(244, 28)
        Me.Lbl_Played2.Name = "Lbl_Played2"
        Me.Lbl_Played2.Size = New System.Drawing.Size(113, 25)
        Me.Lbl_Played2.TabIndex = 33
        Me.Lbl_Played2.Text = "Played = "
        '
        'Lbl_CountH
        '
        Me.Lbl_CountH.AutoSize = True
        Me.Lbl_CountH.Location = New System.Drawing.Point(6, 28)
        Me.Lbl_CountH.Name = "Lbl_CountH"
        Me.Lbl_CountH.Size = New System.Drawing.Size(174, 25)
        Me.Lbl_CountH.TabIndex = 12
        Me.Lbl_CountH.Text = "Total Players = "
        '
        'Lbl_NotAbove0
        '
        Me.Lbl_NotAbove0.AutoSize = True
        Me.Lbl_NotAbove0.Location = New System.Drawing.Point(706, 60)
        Me.Lbl_NotAbove0.Name = "Lbl_NotAbove0"
        Me.Lbl_NotAbove0.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_NotAbove0.TabIndex = 7
        Me.Lbl_NotAbove0.Text = "NPnum"
        Me.Lbl_NotAbove0.Visible = False
        '
        'Lbl_No0
        '
        Me.Lbl_No0.AutoSize = True
        Me.Lbl_No0.Location = New System.Drawing.Point(580, 60)
        Me.Lbl_No0.Name = "Lbl_No0"
        Me.Lbl_No0.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_No0.TabIndex = 6
        Me.Lbl_No0.Text = "P(No):"
        Me.Lbl_No0.Visible = False
        '
        'Lbl_YesAbove0
        '
        Me.Lbl_YesAbove0.AutoSize = True
        Me.Lbl_YesAbove0.Location = New System.Drawing.Point(484, 60)
        Me.Lbl_YesAbove0.Name = "Lbl_YesAbove0"
        Me.Lbl_YesAbove0.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_YesAbove0.TabIndex = 5
        Me.Lbl_YesAbove0.Text = "Pnum"
        '
        'Lbl_Above0
        '
        Me.Lbl_Above0.AutoSize = True
        Me.Lbl_Above0.Location = New System.Drawing.Point(9, 60)
        Me.Lbl_Above0.Name = "Lbl_Above0"
        Me.Lbl_Above0.Size = New System.Drawing.Size(452, 30)
        Me.Lbl_Above0.TabIndex = 4
        Me.Lbl_Above0.Text = "Away offense stats between 0 to 100:"
        '
        'Lbl_NotAbove100
        '
        Me.Lbl_NotAbove100.AutoSize = True
        Me.Lbl_NotAbove100.Location = New System.Drawing.Point(706, 17)
        Me.Lbl_NotAbove100.Name = "Lbl_NotAbove100"
        Me.Lbl_NotAbove100.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_NotAbove100.TabIndex = 3
        Me.Lbl_NotAbove100.Text = "NPnum"
        Me.Lbl_NotAbove100.Visible = False
        '
        'Lbl_YesAbove100
        '
        Me.Lbl_YesAbove100.AutoSize = True
        Me.Lbl_YesAbove100.Location = New System.Drawing.Point(484, 17)
        Me.Lbl_YesAbove100.Name = "Lbl_YesAbove100"
        Me.Lbl_YesAbove100.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_YesAbove100.TabIndex = 2
        Me.Lbl_YesAbove100.Text = "Pnum"
        '
        'Lbl_No100
        '
        Me.Lbl_No100.AutoSize = True
        Me.Lbl_No100.Location = New System.Drawing.Point(580, 17)
        Me.Lbl_No100.Name = "Lbl_No100"
        Me.Lbl_No100.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_No100.TabIndex = 1
        Me.Lbl_No100.Text = "P(No):"
        Me.Lbl_No100.Visible = False
        '
        'Lbl_Above100
        '
        Me.Lbl_Above100.AutoSize = True
        Me.Lbl_Above100.Location = New System.Drawing.Point(9, 17)
        Me.Lbl_Above100.Name = "Lbl_Above100"
        Me.Lbl_Above100.Size = New System.Drawing.Size(373, 30)
        Me.Lbl_Above100.TabIndex = 0
        Me.Lbl_Above100.Text = "Away offense stats above 100:"
        '
        'Lbl_AZero
        '
        Me.Lbl_AZero.AutoSize = True
        Me.Lbl_AZero.Location = New System.Drawing.Point(711, 373)
        Me.Lbl_AZero.Name = "Lbl_AZero"
        Me.Lbl_AZero.Size = New System.Drawing.Size(24, 17)
        Me.Lbl_AZero.TabIndex = 34
        Me.Lbl_AZero.Text = "0+"
        Me.Lbl_AZero.Visible = False
        '
        'Lbl_A100
        '
        Me.Lbl_A100.AutoSize = True
        Me.Lbl_A100.Location = New System.Drawing.Point(711, 408)
        Me.Lbl_A100.Name = "Lbl_A100"
        Me.Lbl_A100.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_A100.TabIndex = 35
        Me.Lbl_A100.Text = "100+"
        Me.Lbl_A100.Visible = False
        '
        'Lbl_H100
        '
        Me.Lbl_H100.AutoSize = True
        Me.Lbl_H100.Location = New System.Drawing.Point(812, 408)
        Me.Lbl_H100.Name = "Lbl_H100"
        Me.Lbl_H100.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_H100.TabIndex = 36
        Me.Lbl_H100.Text = "100+"
        Me.Lbl_H100.Visible = False
        '
        'Lbl_HZero
        '
        Me.Lbl_HZero.AutoSize = True
        Me.Lbl_HZero.Location = New System.Drawing.Point(812, 373)
        Me.Lbl_HZero.Name = "Lbl_HZero"
        Me.Lbl_HZero.Size = New System.Drawing.Size(24, 17)
        Me.Lbl_HZero.TabIndex = 37
        Me.Lbl_HZero.Text = "0+"
        Me.Lbl_HZero.Visible = False
        '
        'Lbl_HNotAbove0
        '
        Me.Lbl_HNotAbove0.AutoSize = True
        Me.Lbl_HNotAbove0.Location = New System.Drawing.Point(690, 60)
        Me.Lbl_HNotAbove0.Name = "Lbl_HNotAbove0"
        Me.Lbl_HNotAbove0.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_HNotAbove0.TabIndex = 7
        Me.Lbl_HNotAbove0.Text = "NPnum"
        Me.Lbl_HNotAbove0.Visible = False
        '
        'Lbl_HNo0
        '
        Me.Lbl_HNo0.AutoSize = True
        Me.Lbl_HNo0.Location = New System.Drawing.Point(588, 60)
        Me.Lbl_HNo0.Name = "Lbl_HNo0"
        Me.Lbl_HNo0.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_HNo0.TabIndex = 6
        Me.Lbl_HNo0.Text = "P(No):"
        Me.Lbl_HNo0.Visible = False
        '
        'Lbl_HYesAbove0
        '
        Me.Lbl_HYesAbove0.AutoSize = True
        Me.Lbl_HYesAbove0.Location = New System.Drawing.Point(487, 60)
        Me.Lbl_HYesAbove0.Name = "Lbl_HYesAbove0"
        Me.Lbl_HYesAbove0.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_HYesAbove0.TabIndex = 5
        Me.Lbl_HYesAbove0.Text = "Pnum"
        '
        'Lbl_HAbove0
        '
        Me.Lbl_HAbove0.AutoSize = True
        Me.Lbl_HAbove0.Location = New System.Drawing.Point(7, 60)
        Me.Lbl_HAbove0.Name = "Lbl_HAbove0"
        Me.Lbl_HAbove0.Size = New System.Drawing.Size(458, 30)
        Me.Lbl_HAbove0.TabIndex = 4
        Me.Lbl_HAbove0.Text = "Home offense stats between 0 to 100:"
        '
        'Lbl_HNotAbove100
        '
        Me.Lbl_HNotAbove100.AutoSize = True
        Me.Lbl_HNotAbove100.Location = New System.Drawing.Point(691, 17)
        Me.Lbl_HNotAbove100.Name = "Lbl_HNotAbove100"
        Me.Lbl_HNotAbove100.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_HNotAbove100.TabIndex = 3
        Me.Lbl_HNotAbove100.Text = "NPnum"
        Me.Lbl_HNotAbove100.Visible = False
        '
        'Lbl_HYesAbove100
        '
        Me.Lbl_HYesAbove100.AutoSize = True
        Me.Lbl_HYesAbove100.Location = New System.Drawing.Point(487, 17)
        Me.Lbl_HYesAbove100.Name = "Lbl_HYesAbove100"
        Me.Lbl_HYesAbove100.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_HYesAbove100.TabIndex = 2
        Me.Lbl_HYesAbove100.Text = "Pnum"
        '
        'Lbl_HNo100
        '
        Me.Lbl_HNo100.AutoSize = True
        Me.Lbl_HNo100.Location = New System.Drawing.Point(588, 17)
        Me.Lbl_HNo100.Name = "Lbl_HNo100"
        Me.Lbl_HNo100.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_HNo100.TabIndex = 1
        Me.Lbl_HNo100.Text = "P(No):"
        Me.Lbl_HNo100.Visible = False
        '
        'Lbl_HAbove100
        '
        Me.Lbl_HAbove100.AutoSize = True
        Me.Lbl_HAbove100.Location = New System.Drawing.Point(7, 17)
        Me.Lbl_HAbove100.Name = "Lbl_HAbove100"
        Me.Lbl_HAbove100.Size = New System.Drawing.Size(379, 30)
        Me.Lbl_HAbove100.TabIndex = 0
        Me.Lbl_HAbove100.Text = "Home offense stats above 100:"
        '
        'Lbl_2AZero
        '
        Me.Lbl_2AZero.AutoSize = True
        Me.Lbl_2AZero.Location = New System.Drawing.Point(711, 441)
        Me.Lbl_2AZero.Name = "Lbl_2AZero"
        Me.Lbl_2AZero.Size = New System.Drawing.Size(24, 17)
        Me.Lbl_2AZero.TabIndex = 39
        Me.Lbl_2AZero.Text = "0+"
        Me.Lbl_2AZero.Visible = False
        '
        'Lbl_2A50
        '
        Me.Lbl_2A50.AutoSize = True
        Me.Lbl_2A50.Location = New System.Drawing.Point(711, 473)
        Me.Lbl_2A50.Name = "Lbl_2A50"
        Me.Lbl_2A50.Size = New System.Drawing.Size(32, 17)
        Me.Lbl_2A50.TabIndex = 40
        Me.Lbl_2A50.Text = "50+"
        Me.Lbl_2A50.Visible = False
        '
        'Lbl_2HZero
        '
        Me.Lbl_2HZero.AutoSize = True
        Me.Lbl_2HZero.Location = New System.Drawing.Point(820, 441)
        Me.Lbl_2HZero.Name = "Lbl_2HZero"
        Me.Lbl_2HZero.Size = New System.Drawing.Size(24, 17)
        Me.Lbl_2HZero.TabIndex = 41
        Me.Lbl_2HZero.Text = "0+"
        Me.Lbl_2HZero.Visible = False
        '
        'Lbl_2H50
        '
        Me.Lbl_2H50.AutoSize = True
        Me.Lbl_2H50.Location = New System.Drawing.Point(812, 473)
        Me.Lbl_2H50.Name = "Lbl_2H50"
        Me.Lbl_2H50.Size = New System.Drawing.Size(32, 17)
        Me.Lbl_2H50.TabIndex = 42
        Me.Lbl_2H50.Text = "50+"
        Me.Lbl_2H50.Visible = False
        '
        'Lbl_DNotAbove0
        '
        Me.Lbl_DNotAbove0.AutoSize = True
        Me.Lbl_DNotAbove0.Location = New System.Drawing.Point(705, 59)
        Me.Lbl_DNotAbove0.Name = "Lbl_DNotAbove0"
        Me.Lbl_DNotAbove0.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_DNotAbove0.TabIndex = 7
        Me.Lbl_DNotAbove0.Text = "NPnum"
        Me.Lbl_DNotAbove0.Visible = False
        '
        'Lbl_DNo0
        '
        Me.Lbl_DNo0.AutoSize = True
        Me.Lbl_DNo0.Location = New System.Drawing.Point(580, 59)
        Me.Lbl_DNo0.Name = "Lbl_DNo0"
        Me.Lbl_DNo0.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_DNo0.TabIndex = 6
        Me.Lbl_DNo0.Text = "P(No):"
        Me.Lbl_DNo0.Visible = False
        '
        'Lbl_DYesAbove0
        '
        Me.Lbl_DYesAbove0.AutoSize = True
        Me.Lbl_DYesAbove0.Location = New System.Drawing.Point(484, 59)
        Me.Lbl_DYesAbove0.Name = "Lbl_DYesAbove0"
        Me.Lbl_DYesAbove0.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_DYesAbove0.TabIndex = 5
        Me.Lbl_DYesAbove0.Text = "Pnum"
        '
        'Lbl_DAbove0
        '
        Me.Lbl_DAbove0.AutoSize = True
        Me.Lbl_DAbove0.Location = New System.Drawing.Point(9, 59)
        Me.Lbl_DAbove0.Name = "Lbl_DAbove0"
        Me.Lbl_DAbove0.Size = New System.Drawing.Size(453, 30)
        Me.Lbl_DAbove0.TabIndex = 4
        Me.Lbl_DAbove0.Text = "Away defence stats between 0 to 50:"
        '
        'Lbl_NotAbove50
        '
        Me.Lbl_NotAbove50.AutoSize = True
        Me.Lbl_NotAbove50.Location = New System.Drawing.Point(706, 16)
        Me.Lbl_NotAbove50.Name = "Lbl_NotAbove50"
        Me.Lbl_NotAbove50.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_NotAbove50.TabIndex = 3
        Me.Lbl_NotAbove50.Text = "NPnum"
        Me.Lbl_NotAbove50.Visible = False
        '
        'Lbl_YesAbove50
        '
        Me.Lbl_YesAbove50.AutoSize = True
        Me.Lbl_YesAbove50.Location = New System.Drawing.Point(484, 16)
        Me.Lbl_YesAbove50.Name = "Lbl_YesAbove50"
        Me.Lbl_YesAbove50.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_YesAbove50.TabIndex = 2
        Me.Lbl_YesAbove50.Text = "Pnum"
        '
        'Lbl_No50
        '
        Me.Lbl_No50.AutoSize = True
        Me.Lbl_No50.Location = New System.Drawing.Point(580, 16)
        Me.Lbl_No50.Name = "Lbl_No50"
        Me.Lbl_No50.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_No50.TabIndex = 1
        Me.Lbl_No50.Text = "P(No):"
        Me.Lbl_No50.Visible = False
        '
        'Lbl_Above50
        '
        Me.Lbl_Above50.AutoSize = True
        Me.Lbl_Above50.Location = New System.Drawing.Point(9, 16)
        Me.Lbl_Above50.Name = "Lbl_Above50"
        Me.Lbl_Above50.Size = New System.Drawing.Size(374, 30)
        Me.Lbl_Above50.TabIndex = 0
        Me.Lbl_Above50.Text = "Away defence stats above 50:"
        '
        'Lbl_DHNotAbove0
        '
        Me.Lbl_DHNotAbove0.AutoSize = True
        Me.Lbl_DHNotAbove0.Location = New System.Drawing.Point(703, 59)
        Me.Lbl_DHNotAbove0.Name = "Lbl_DHNotAbove0"
        Me.Lbl_DHNotAbove0.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_DHNotAbove0.TabIndex = 7
        Me.Lbl_DHNotAbove0.Text = "NPnum"
        Me.Lbl_DHNotAbove0.Visible = False
        '
        'Lbl_HDNo0
        '
        Me.Lbl_HDNo0.AutoSize = True
        Me.Lbl_HDNo0.Location = New System.Drawing.Point(589, 59)
        Me.Lbl_HDNo0.Name = "Lbl_HDNo0"
        Me.Lbl_HDNo0.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_HDNo0.TabIndex = 6
        Me.Lbl_HDNo0.Text = "P(No):"
        Me.Lbl_HDNo0.Visible = False
        '
        'Lbl_DHYesAbove0
        '
        Me.Lbl_DHYesAbove0.AutoSize = True
        Me.Lbl_DHYesAbove0.Location = New System.Drawing.Point(487, 59)
        Me.Lbl_DHYesAbove0.Name = "Lbl_DHYesAbove0"
        Me.Lbl_DHYesAbove0.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_DHYesAbove0.TabIndex = 5
        Me.Lbl_DHYesAbove0.Text = "Pnum"
        '
        'Lbl_DHAbove0
        '
        Me.Lbl_DHAbove0.AutoSize = True
        Me.Lbl_DHAbove0.Location = New System.Drawing.Point(7, 59)
        Me.Lbl_DHAbove0.Name = "Lbl_DHAbove0"
        Me.Lbl_DHAbove0.Size = New System.Drawing.Size(459, 30)
        Me.Lbl_DHAbove0.TabIndex = 4
        Me.Lbl_DHAbove0.Text = "Home defence stats between 0 to 50:"
        '
        'Lbl_DHNotAbove50
        '
        Me.Lbl_DHNotAbove50.AutoSize = True
        Me.Lbl_DHNotAbove50.Location = New System.Drawing.Point(704, 16)
        Me.Lbl_DHNotAbove50.Name = "Lbl_DHNotAbove50"
        Me.Lbl_DHNotAbove50.Size = New System.Drawing.Size(99, 30)
        Me.Lbl_DHNotAbove50.TabIndex = 3
        Me.Lbl_DHNotAbove50.Text = "NPnum"
        Me.Lbl_DHNotAbove50.Visible = False
        '
        'Lbl_DHYesAbove50
        '
        Me.Lbl_DHYesAbove50.AutoSize = True
        Me.Lbl_DHYesAbove50.Location = New System.Drawing.Point(487, 16)
        Me.Lbl_DHYesAbove50.Name = "Lbl_DHYesAbove50"
        Me.Lbl_DHYesAbove50.Size = New System.Drawing.Size(81, 30)
        Me.Lbl_DHYesAbove50.TabIndex = 2
        Me.Lbl_DHYesAbove50.Text = "Pnum"
        '
        'Lbl_HDNo50
        '
        Me.Lbl_HDNo50.AutoSize = True
        Me.Lbl_HDNo50.Location = New System.Drawing.Point(589, 16)
        Me.Lbl_HDNo50.Name = "Lbl_HDNo50"
        Me.Lbl_HDNo50.Size = New System.Drawing.Size(85, 30)
        Me.Lbl_HDNo50.TabIndex = 1
        Me.Lbl_HDNo50.Text = "P(No):"
        Me.Lbl_HDNo50.Visible = False
        '
        'Lbl_HAbove50
        '
        Me.Lbl_HAbove50.AutoSize = True
        Me.Lbl_HAbove50.Location = New System.Drawing.Point(7, 16)
        Me.Lbl_HAbove50.Name = "Lbl_HAbove50"
        Me.Lbl_HAbove50.Size = New System.Drawing.Size(380, 30)
        Me.Lbl_HAbove50.TabIndex = 0
        Me.Lbl_HAbove50.Text = "Home defence stats above 50:"
        '
        'Lbl_Res
        '
        Me.Lbl_Res.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Res.AutoSize = True
        Me.Lbl_Res.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Lbl_Res.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Res.Location = New System.Drawing.Point(843, 8)
        Me.Lbl_Res.Name = "Lbl_Res"
        Me.Lbl_Res.Size = New System.Drawing.Size(91, 33)
        Me.Lbl_Res.TabIndex = 50
        Me.Lbl_Res.Text = "Result"
        '
        'Chart1
        '
        ChartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.BackColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.BackColor = System.Drawing.Color.White
        Legend2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series3.BorderWidth = 5
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.MarkerColor = System.Drawing.Color.Black
        Series3.MarkerSize = 10
        Series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series3.Name = "Home team"
        Series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series3.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Empty
        Series4.BorderWidth = 5
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.Legend = "Legend1"
        Series4.MarkerColor = System.Drawing.Color.Black
        Series4.MarkerSize = 10
        Series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series4.Name = "Away team"
        Series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(1777, 377)
        Me.Chart1.TabIndex = 51
        Me.Chart1.Text = "Chart3"
        '
        'Lbl_PrevAMatch
        '
        Me.Lbl_PrevAMatch.AutoSize = True
        Me.Lbl_PrevAMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_PrevAMatch.Location = New System.Drawing.Point(94, 18)
        Me.Lbl_PrevAMatch.Name = "Lbl_PrevAMatch"
        Me.Lbl_PrevAMatch.Size = New System.Drawing.Size(140, 17)
        Me.Lbl_PrevAMatch.TabIndex = 52
        Me.Lbl_PrevAMatch.Text = "Prev Away match res"
        Me.Lbl_PrevAMatch.Visible = False
        '
        'Lbl_PrevHMatch
        '
        Me.Lbl_PrevHMatch.AutoSize = True
        Me.Lbl_PrevHMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_PrevHMatch.Location = New System.Drawing.Point(357, 18)
        Me.Lbl_PrevHMatch.Name = "Lbl_PrevHMatch"
        Me.Lbl_PrevHMatch.Size = New System.Drawing.Size(142, 17)
        Me.Lbl_PrevHMatch.TabIndex = 53
        Me.Lbl_PrevHMatch.Text = "Prev home match res"
        Me.Lbl_PrevHMatch.Visible = False
        '
        'Lbl_TotalSeen
        '
        Me.Lbl_TotalSeen.AutoSize = True
        Me.Lbl_TotalSeen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_TotalSeen.Location = New System.Drawing.Point(240, 18)
        Me.Lbl_TotalSeen.Name = "Lbl_TotalSeen"
        Me.Lbl_TotalSeen.Size = New System.Drawing.Size(101, 17)
        Me.Lbl_TotalSeen.TabIndex = 54
        Me.Lbl_TotalSeen.Text = "Cnt apperance"
        Me.Lbl_TotalSeen.Visible = False
        '
        'Lbl_Res2
        '
        Me.Lbl_Res2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Res2.AutoSize = True
        Me.Lbl_Res2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Lbl_Res2.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Res2.Location = New System.Drawing.Point(803, 58)
        Me.Lbl_Res2.Name = "Lbl_Res2"
        Me.Lbl_Res2.Size = New System.Drawing.Size(170, 33)
        Me.Lbl_Res2.TabIndex = 55
        Me.Lbl_Res2.Text = "Lower result"
        Me.Lbl_Res2.Visible = False
        '
        'TLP_Top
        '
        Me.TLP_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TLP_Top.ColumnCount = 3
        Me.TLP_Top.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TLP_Top.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLP_Top.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TLP_Top.Controls.Add(Me.GB_ATC, 0, 0)
        Me.TLP_Top.Controls.Add(Me.Panel_UnSeenLbl, 1, 0)
        Me.TLP_Top.Controls.Add(Me.GB_HTC, 2, 0)
        Me.TLP_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLP_Top.Location = New System.Drawing.Point(0, 0)
        Me.TLP_Top.Name = "TLP_Top"
        Me.TLP_Top.RowCount = 1
        Me.TLP_Top.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_Top.Size = New System.Drawing.Size(1777, 64)
        Me.TLP_Top.TabIndex = 56
        '
        'Panel_UnSeenLbl
        '
        Me.Panel_UnSeenLbl.BackColor = System.Drawing.Color.Transparent
        Me.Panel_UnSeenLbl.Controls.Add(Me.Lbl_CheckBack)
        Me.Panel_UnSeenLbl.Controls.Add(Me.Lbl_PrevAMatch)
        Me.Panel_UnSeenLbl.Controls.Add(Me.Lbl_PrevHMatch)
        Me.Panel_UnSeenLbl.Controls.Add(Me.Lbl_TotalSeen)
        Me.Panel_UnSeenLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_UnSeenLbl.ForeColor = System.Drawing.Color.White
        Me.Panel_UnSeenLbl.Location = New System.Drawing.Point(713, 3)
        Me.Panel_UnSeenLbl.Name = "Panel_UnSeenLbl"
        Me.Panel_UnSeenLbl.Size = New System.Drawing.Size(349, 58)
        Me.Panel_UnSeenLbl.TabIndex = 10
        '
        'TLP_Boxes
        '
        Me.TLP_Boxes.BackColor = System.Drawing.Color.White
        Me.TLP_Boxes.ColumnCount = 2
        Me.TLP_Boxes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Boxes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Boxes.Controls.Add(Me.Panel_AwayDefence, 0, 1)
        Me.TLP_Boxes.Controls.Add(Me.Panel_HomeDefence, 1, 1)
        Me.TLP_Boxes.Controls.Add(Me.Panel_HomeOffense, 1, 0)
        Me.TLP_Boxes.Controls.Add(Me.Panel_AwayOffense, 0, 0)
        Me.TLP_Boxes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP_Boxes.Location = New System.Drawing.Point(0, 377)
        Me.TLP_Boxes.Name = "TLP_Boxes"
        Me.TLP_Boxes.RowCount = 2
        Me.TLP_Boxes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Boxes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Boxes.Size = New System.Drawing.Size(1777, 193)
        Me.TLP_Boxes.TabIndex = 58
        '
        'TLP_Results
        '
        Me.TLP_Results.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TLP_Results.ColumnCount = 1
        Me.TLP_Results.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Results.Controls.Add(Me.Lbl_Res2, 0, 1)
        Me.TLP_Results.Controls.Add(Me.Lbl_Res, 0, 0)
        Me.TLP_Results.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLP_Results.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.TLP_Results.Location = New System.Drawing.Point(0, 634)
        Me.TLP_Results.Name = "TLP_Results"
        Me.TLP_Results.RowCount = 2
        Me.TLP_Results.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Results.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLP_Results.Size = New System.Drawing.Size(1777, 100)
        Me.TLP_Results.TabIndex = 59
        '
        'Panel_Display
        '
        Me.Panel_Display.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel_Display.Controls.Add(Me.Panel_Chart)
        Me.Panel_Display.Controls.Add(Me.TLP_Boxes)
        Me.Panel_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Display.Location = New System.Drawing.Point(0, 64)
        Me.Panel_Display.Name = "Panel_Display"
        Me.Panel_Display.Size = New System.Drawing.Size(1777, 570)
        Me.Panel_Display.TabIndex = 60
        '
        'Panel_Chart
        '
        Me.Panel_Chart.BackColor = System.Drawing.Color.White
        Me.Panel_Chart.Controls.Add(Me.Chart1)
        Me.Panel_Chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Chart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Chart.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Chart.Name = "Panel_Chart"
        Me.Panel_Chart.Size = New System.Drawing.Size(1777, 377)
        Me.Panel_Chart.TabIndex = 59
        '
        'Panel_AwayOffense
        '
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_NotAbove0)
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_Above100)
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_No0)
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_No100)
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_YesAbove0)
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_YesAbove100)
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_Above0)
        Me.Panel_AwayOffense.Controls.Add(Me.Lbl_NotAbove100)
        Me.Panel_AwayOffense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_AwayOffense.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Panel_AwayOffense.Location = New System.Drawing.Point(3, 3)
        Me.Panel_AwayOffense.Name = "Panel_AwayOffense"
        Me.Panel_AwayOffense.Size = New System.Drawing.Size(882, 90)
        Me.Panel_AwayOffense.TabIndex = 45
        '
        'Panel_AwayDefence
        '
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_DNotAbove0)
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_Above50)
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_DNo0)
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_No50)
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_DYesAbove0)
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_YesAbove50)
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_DAbove0)
        Me.Panel_AwayDefence.Controls.Add(Me.Lbl_NotAbove50)
        Me.Panel_AwayDefence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_AwayDefence.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_AwayDefence.Location = New System.Drawing.Point(3, 99)
        Me.Panel_AwayDefence.Name = "Panel_AwayDefence"
        Me.Panel_AwayDefence.Size = New System.Drawing.Size(882, 91)
        Me.Panel_AwayDefence.TabIndex = 52
        '
        'Panel_HomeOffense
        '
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HNotAbove0)
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HAbove100)
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HNo0)
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HNo100)
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HYesAbove0)
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HYesAbove100)
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HAbove0)
        Me.Panel_HomeOffense.Controls.Add(Me.Lbl_HNotAbove100)
        Me.Panel_HomeOffense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_HomeOffense.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Panel_HomeOffense.Location = New System.Drawing.Point(891, 3)
        Me.Panel_HomeOffense.Name = "Panel_HomeOffense"
        Me.Panel_HomeOffense.Size = New System.Drawing.Size(883, 90)
        Me.Panel_HomeOffense.TabIndex = 52
        '
        'Panel_HomeDefence
        '
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_DHNotAbove0)
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_HAbove50)
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_HDNo0)
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_HDNo50)
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_DHYesAbove0)
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_DHYesAbove50)
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_DHAbove0)
        Me.Panel_HomeDefence.Controls.Add(Me.Lbl_DHNotAbove50)
        Me.Panel_HomeDefence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_HomeDefence.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Panel_HomeDefence.Location = New System.Drawing.Point(891, 99)
        Me.Panel_HomeDefence.Name = "Panel_HomeDefence"
        Me.Panel_HomeDefence.Size = New System.Drawing.Size(883, 91)
        Me.Panel_HomeDefence.TabIndex = 52
        '
        'GamesVisionAlgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1777, 734)
        Me.Controls.Add(Me.Panel_Display)
        Me.Controls.Add(Me.TLP_Results)
        Me.Controls.Add(Me.TLP_Top)
        Me.Controls.Add(Me.Lbl_2H50)
        Me.Controls.Add(Me.Lbl_2HZero)
        Me.Controls.Add(Me.Lbl_2A50)
        Me.Controls.Add(Me.Lbl_2AZero)
        Me.Controls.Add(Me.Lbl_HZero)
        Me.Controls.Add(Me.Lbl_H100)
        Me.Controls.Add(Me.Lbl_A100)
        Me.Controls.Add(Me.Lbl_AZero)
        Me.Name = "GamesVisionAlgo"
        Me.Text = "GamesVisionAlgo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GB_ATC.ResumeLayout(False)
        Me.GB_ATC.PerformLayout()
        Me.GB_HTC.ResumeLayout(False)
        Me.GB_HTC.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP_Top.ResumeLayout(False)
        Me.Panel_UnSeenLbl.ResumeLayout(False)
        Me.Panel_UnSeenLbl.PerformLayout()
        Me.TLP_Boxes.ResumeLayout(False)
        Me.TLP_Results.ResumeLayout(False)
        Me.TLP_Results.PerformLayout()
        Me.Panel_Display.ResumeLayout(False)
        Me.Panel_Chart.ResumeLayout(False)
        Me.Panel_AwayOffense.ResumeLayout(False)
        Me.Panel_AwayOffense.PerformLayout()
        Me.Panel_AwayDefence.ResumeLayout(False)
        Me.Panel_AwayDefence.PerformLayout()
        Me.Panel_HomeOffense.ResumeLayout(False)
        Me.Panel_HomeOffense.PerformLayout()
        Me.Panel_HomeDefence.ResumeLayout(False)
        Me.Panel_HomeDefence.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_CheckBack As System.Windows.Forms.Label
    Friend WithEvents GB_ATC As System.Windows.Forms.GroupBox
    Friend WithEvents GB_HTC As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_CountA As System.Windows.Forms.Label
    Friend WithEvents Lbl_CountH As System.Windows.Forms.Label
    Friend WithEvents Lbl_Played As System.Windows.Forms.Label
    Friend WithEvents Lbl_DontPlayed As System.Windows.Forms.Label
    Friend WithEvents Lbl_DontPlayed2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Played2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Anum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hnum As System.Windows.Forms.Label
    Friend WithEvents Lbl_Anum3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Anum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hnum3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hnum2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_NotAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_No0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_YesAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Above0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_NotAbove100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_YesAbove100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_No100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Above100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_AZero As System.Windows.Forms.Label
    Friend WithEvents Lbl_A100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_H100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HZero As System.Windows.Forms.Label
    Friend WithEvents Lbl_HNotAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HNo0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HYesAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HNotAbove100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HYesAbove100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HNo100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HAbove100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_2AZero As System.Windows.Forms.Label
    Friend WithEvents Lbl_2A50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_2HZero As System.Windows.Forms.Label
    Friend WithEvents Lbl_2H50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DNotAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DNo0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DYesAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_NotAbove50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_YesAbove50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_No50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Above50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DHNotAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HDNo0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DHYesAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DHAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DHNotAbove50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DHYesAbove50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HDNo50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_HAbove50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Res As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Lbl_PrevAMatch As System.Windows.Forms.Label
    Friend WithEvents Lbl_PrevHMatch As System.Windows.Forms.Label
    Friend WithEvents Lbl_TotalSeen As System.Windows.Forms.Label
    Friend WithEvents Lbl_Res2 As System.Windows.Forms.Label
    Friend WithEvents TLP_Top As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_UnSeenLbl As System.Windows.Forms.Panel
    Friend WithEvents TLP_Boxes As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TLP_Results As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel_Display As System.Windows.Forms.Panel
    Friend WithEvents Panel_Chart As System.Windows.Forms.Panel
    Friend WithEvents Panel_AwayOffense As System.Windows.Forms.Panel
    Friend WithEvents Panel_AwayDefence As System.Windows.Forms.Panel
    Friend WithEvents Panel_HomeDefence As System.Windows.Forms.Panel
    Friend WithEvents Panel_HomeOffense As System.Windows.Forms.Panel
End Class
