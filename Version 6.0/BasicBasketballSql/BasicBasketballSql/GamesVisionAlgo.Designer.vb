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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.GB_Offense = New System.Windows.Forms.GroupBox()
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
        Me.GB_Offense2 = New System.Windows.Forms.GroupBox()
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
        Me.GB_Defence = New System.Windows.Forms.GroupBox()
        Me.Lbl_DNotAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_DNo0 = New System.Windows.Forms.Label()
        Me.Lbl_DYesAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_DAbove0 = New System.Windows.Forms.Label()
        Me.Lbl_NotAbove50 = New System.Windows.Forms.Label()
        Me.Lbl_YesAbove50 = New System.Windows.Forms.Label()
        Me.Lbl_No50 = New System.Windows.Forms.Label()
        Me.Lbl_Above50 = New System.Windows.Forms.Label()
        Me.GB_Defence2 = New System.Windows.Forms.GroupBox()
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
        Me.GB_ATC.SuspendLayout()
        Me.GB_HTC.SuspendLayout()
        Me.GB_Offense.SuspendLayout()
        Me.GB_Offense2.SuspendLayout()
        Me.GB_Defence.SuspendLayout()
        Me.GB_Defence2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_CheckBack
        '
        Me.Lbl_CheckBack.AutoSize = True
        Me.Lbl_CheckBack.Location = New System.Drawing.Point(711, 9)
        Me.Lbl_CheckBack.Name = "Lbl_CheckBack"
        Me.Lbl_CheckBack.Size = New System.Drawing.Size(74, 17)
        Me.Lbl_CheckBack.TabIndex = 7
        Me.Lbl_CheckBack.Text = "Form back"
        Me.Lbl_CheckBack.Visible = False
        '
        'GB_ATC
        '
        Me.GB_ATC.Controls.Add(Me.Lbl_Anum3)
        Me.GB_ATC.Controls.Add(Me.Lbl_Anum2)
        Me.GB_ATC.Controls.Add(Me.Lbl_Anum)
        Me.GB_ATC.Controls.Add(Me.Lbl_DontPlayed)
        Me.GB_ATC.Controls.Add(Me.Lbl_CountA)
        Me.GB_ATC.Controls.Add(Me.Lbl_Played)
        Me.GB_ATC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_ATC.Location = New System.Drawing.Point(8, 7)
        Me.GB_ATC.Name = "GB_ATC"
        Me.GB_ATC.Size = New System.Drawing.Size(544, 57)
        Me.GB_ATC.TabIndex = 9
        Me.GB_ATC.TabStop = False
        Me.GB_ATC.Text = "Away Team"
        '
        'Lbl_Anum3
        '
        Me.Lbl_Anum3.AutoSize = True
        Me.Lbl_Anum3.Location = New System.Drawing.Point(467, 30)
        Me.Lbl_Anum3.Name = "Lbl_Anum3"
        Me.Lbl_Anum3.Size = New System.Drawing.Size(53, 20)
        Me.Lbl_Anum3.TabIndex = 36
        Me.Lbl_Anum3.Text = "Num3"
        '
        'Lbl_Anum2
        '
        Me.Lbl_Anum2.AutoSize = True
        Me.Lbl_Anum2.Location = New System.Drawing.Point(270, 30)
        Me.Lbl_Anum2.Name = "Lbl_Anum2"
        Me.Lbl_Anum2.Size = New System.Drawing.Size(53, 20)
        Me.Lbl_Anum2.TabIndex = 35
        Me.Lbl_Anum2.Text = "Num2"
        '
        'Lbl_Anum
        '
        Me.Lbl_Anum.AutoSize = True
        Me.Lbl_Anum.Location = New System.Drawing.Point(135, 30)
        Me.Lbl_Anum.Name = "Lbl_Anum"
        Me.Lbl_Anum.Size = New System.Drawing.Size(44, 20)
        Me.Lbl_Anum.TabIndex = 34
        Me.Lbl_Anum.Text = "Num"
        '
        'Lbl_DontPlayed
        '
        Me.Lbl_DontPlayed.AutoSize = True
        Me.Lbl_DontPlayed.Location = New System.Drawing.Point(329, 30)
        Me.Lbl_DontPlayed.Name = "Lbl_DontPlayed"
        Me.Lbl_DontPlayed.Size = New System.Drawing.Size(120, 20)
        Me.Lbl_DontPlayed.TabIndex = 33
        Me.Lbl_DontPlayed.Text = "Dont Played = "
        '
        'Lbl_CountA
        '
        Me.Lbl_CountA.AutoSize = True
        Me.Lbl_CountA.Location = New System.Drawing.Point(6, 30)
        Me.Lbl_CountA.Name = "Lbl_CountA"
        Me.Lbl_CountA.Size = New System.Drawing.Size(112, 20)
        Me.Lbl_CountA.TabIndex = 11
        Me.Lbl_CountA.Text = "Total Players:"
        '
        'Lbl_Played
        '
        Me.Lbl_Played.AutoSize = True
        Me.Lbl_Played.Location = New System.Drawing.Point(185, 30)
        Me.Lbl_Played.Name = "Lbl_Played"
        Me.Lbl_Played.Size = New System.Drawing.Size(79, 20)
        Me.Lbl_Played.TabIndex = 32
        Me.Lbl_Played.Text = "Played = "
        '
        'GB_HTC
        '
        Me.GB_HTC.Controls.Add(Me.Lbl_Hnum3)
        Me.GB_HTC.Controls.Add(Me.Lbl_Hnum2)
        Me.GB_HTC.Controls.Add(Me.Lbl_Hnum)
        Me.GB_HTC.Controls.Add(Me.Lbl_DontPlayed2)
        Me.GB_HTC.Controls.Add(Me.Lbl_Played2)
        Me.GB_HTC.Controls.Add(Me.Lbl_CountH)
        Me.GB_HTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_HTC.Location = New System.Drawing.Point(893, 12)
        Me.GB_HTC.Name = "GB_HTC"
        Me.GB_HTC.Size = New System.Drawing.Size(690, 52)
        Me.GB_HTC.TabIndex = 10
        Me.GB_HTC.TabStop = False
        Me.GB_HTC.Text = "Home Team"
        '
        'Lbl_Hnum3
        '
        Me.Lbl_Hnum3.AutoSize = True
        Me.Lbl_Hnum3.Location = New System.Drawing.Point(458, 29)
        Me.Lbl_Hnum3.Name = "Lbl_Hnum3"
        Me.Lbl_Hnum3.Size = New System.Drawing.Size(53, 20)
        Me.Lbl_Hnum3.TabIndex = 37
        Me.Lbl_Hnum3.Text = "Num3"
        '
        'Lbl_Hnum2
        '
        Me.Lbl_Hnum2.AutoSize = True
        Me.Lbl_Hnum2.Location = New System.Drawing.Point(273, 29)
        Me.Lbl_Hnum2.Name = "Lbl_Hnum2"
        Me.Lbl_Hnum2.Size = New System.Drawing.Size(53, 20)
        Me.Lbl_Hnum2.TabIndex = 37
        Me.Lbl_Hnum2.Text = "Num2"
        '
        'Lbl_Hnum
        '
        Me.Lbl_Hnum.AutoSize = True
        Me.Lbl_Hnum.Location = New System.Drawing.Point(139, 28)
        Me.Lbl_Hnum.Name = "Lbl_Hnum"
        Me.Lbl_Hnum.Size = New System.Drawing.Size(44, 20)
        Me.Lbl_Hnum.TabIndex = 35
        Me.Lbl_Hnum.Text = "Num"
        '
        'Lbl_DontPlayed2
        '
        Me.Lbl_DontPlayed2.AutoSize = True
        Me.Lbl_DontPlayed2.Location = New System.Drawing.Point(332, 29)
        Me.Lbl_DontPlayed2.Name = "Lbl_DontPlayed2"
        Me.Lbl_DontPlayed2.Size = New System.Drawing.Size(120, 20)
        Me.Lbl_DontPlayed2.TabIndex = 34
        Me.Lbl_DontPlayed2.Text = "Dont Played = "
        '
        'Lbl_Played2
        '
        Me.Lbl_Played2.AutoSize = True
        Me.Lbl_Played2.Location = New System.Drawing.Point(197, 29)
        Me.Lbl_Played2.Name = "Lbl_Played2"
        Me.Lbl_Played2.Size = New System.Drawing.Size(79, 20)
        Me.Lbl_Played2.TabIndex = 33
        Me.Lbl_Played2.Text = "Played = "
        '
        'Lbl_CountH
        '
        Me.Lbl_CountH.AutoSize = True
        Me.Lbl_CountH.Location = New System.Drawing.Point(6, 28)
        Me.Lbl_CountH.Name = "Lbl_CountH"
        Me.Lbl_CountH.Size = New System.Drawing.Size(127, 20)
        Me.Lbl_CountH.TabIndex = 12
        Me.Lbl_CountH.Text = "Total Players = "
        '
        'GB_Offense
        '
        Me.GB_Offense.Controls.Add(Me.Lbl_NotAbove0)
        Me.GB_Offense.Controls.Add(Me.Lbl_No0)
        Me.GB_Offense.Controls.Add(Me.Lbl_YesAbove0)
        Me.GB_Offense.Controls.Add(Me.Lbl_Above0)
        Me.GB_Offense.Controls.Add(Me.Lbl_NotAbove100)
        Me.GB_Offense.Controls.Add(Me.Lbl_YesAbove100)
        Me.GB_Offense.Controls.Add(Me.Lbl_No100)
        Me.GB_Offense.Controls.Add(Me.Lbl_Above100)
        Me.GB_Offense.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Offense.Location = New System.Drawing.Point(18, 555)
        Me.GB_Offense.Name = "GB_Offense"
        Me.GB_Offense.Size = New System.Drawing.Size(525, 104)
        Me.GB_Offense.TabIndex = 33
        Me.GB_Offense.TabStop = False
        Me.GB_Offense.Text = "Offense"
        '
        'Lbl_NotAbove0
        '
        Me.Lbl_NotAbove0.AutoSize = True
        Me.Lbl_NotAbove0.Location = New System.Drawing.Point(408, 70)
        Me.Lbl_NotAbove0.Name = "Lbl_NotAbove0"
        Me.Lbl_NotAbove0.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_NotAbove0.TabIndex = 7
        Me.Lbl_NotAbove0.Text = "NPnum"
        '
        'Lbl_No0
        '
        Me.Lbl_No0.AutoSize = True
        Me.Lbl_No0.Location = New System.Drawing.Point(319, 70)
        Me.Lbl_No0.Name = "Lbl_No0"
        Me.Lbl_No0.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_No0.TabIndex = 6
        Me.Lbl_No0.Text = "P(No)"
        '
        'Lbl_YesAbove0
        '
        Me.Lbl_YesAbove0.AutoSize = True
        Me.Lbl_YesAbove0.Location = New System.Drawing.Point(238, 70)
        Me.Lbl_YesAbove0.Name = "Lbl_YesAbove0"
        Me.Lbl_YesAbove0.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_YesAbove0.TabIndex = 5
        Me.Lbl_YesAbove0.Text = "Pnum"
        '
        'Lbl_Above0
        '
        Me.Lbl_Above0.AutoSize = True
        Me.Lbl_Above0.Location = New System.Drawing.Point(6, 70)
        Me.Lbl_Above0.Name = "Lbl_Above0"
        Me.Lbl_Above0.Size = New System.Drawing.Size(193, 24)
        Me.Lbl_Above0.TabIndex = 4
        Me.Lbl_Above0.Text = "P(0>= And < 100|Yes)"
        '
        'Lbl_NotAbove100
        '
        Me.Lbl_NotAbove100.AutoSize = True
        Me.Lbl_NotAbove100.Location = New System.Drawing.Point(408, 27)
        Me.Lbl_NotAbove100.Name = "Lbl_NotAbove100"
        Me.Lbl_NotAbove100.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_NotAbove100.TabIndex = 3
        Me.Lbl_NotAbove100.Text = "NPnum"
        '
        'Lbl_YesAbove100
        '
        Me.Lbl_YesAbove100.AutoSize = True
        Me.Lbl_YesAbove100.Location = New System.Drawing.Point(238, 24)
        Me.Lbl_YesAbove100.Name = "Lbl_YesAbove100"
        Me.Lbl_YesAbove100.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_YesAbove100.TabIndex = 2
        Me.Lbl_YesAbove100.Text = "Pnum"
        '
        'Lbl_No100
        '
        Me.Lbl_No100.AutoSize = True
        Me.Lbl_No100.Location = New System.Drawing.Point(319, 24)
        Me.Lbl_No100.Name = "Lbl_No100"
        Me.Lbl_No100.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_No100.TabIndex = 1
        Me.Lbl_No100.Text = "P(No)"
        '
        'Lbl_Above100
        '
        Me.Lbl_Above100.AutoSize = True
        Me.Lbl_Above100.Location = New System.Drawing.Point(6, 27)
        Me.Lbl_Above100.Name = "Lbl_Above100"
        Me.Lbl_Above100.Size = New System.Drawing.Size(122, 24)
        Me.Lbl_Above100.TabIndex = 0
        Me.Lbl_Above100.Text = "P(100>=|Yes)"
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
        'GB_Offense2
        '
        Me.GB_Offense2.Controls.Add(Me.Lbl_HNotAbove0)
        Me.GB_Offense2.Controls.Add(Me.Lbl_HNo0)
        Me.GB_Offense2.Controls.Add(Me.Lbl_HYesAbove0)
        Me.GB_Offense2.Controls.Add(Me.Lbl_HAbove0)
        Me.GB_Offense2.Controls.Add(Me.Lbl_HNotAbove100)
        Me.GB_Offense2.Controls.Add(Me.Lbl_HYesAbove100)
        Me.GB_Offense2.Controls.Add(Me.Lbl_HNo100)
        Me.GB_Offense2.Controls.Add(Me.Lbl_HAbove100)
        Me.GB_Offense2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Offense2.Location = New System.Drawing.Point(909, 555)
        Me.GB_Offense2.Name = "GB_Offense2"
        Me.GB_Offense2.Size = New System.Drawing.Size(617, 104)
        Me.GB_Offense2.TabIndex = 38
        Me.GB_Offense2.TabStop = False
        Me.GB_Offense2.Text = "Offense"
        '
        'Lbl_HNotAbove0
        '
        Me.Lbl_HNotAbove0.AutoSize = True
        Me.Lbl_HNotAbove0.Location = New System.Drawing.Point(474, 70)
        Me.Lbl_HNotAbove0.Name = "Lbl_HNotAbove0"
        Me.Lbl_HNotAbove0.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_HNotAbove0.TabIndex = 7
        Me.Lbl_HNotAbove0.Text = "NPnum"
        '
        'Lbl_HNo0
        '
        Me.Lbl_HNo0.AutoSize = True
        Me.Lbl_HNo0.Location = New System.Drawing.Point(363, 70)
        Me.Lbl_HNo0.Name = "Lbl_HNo0"
        Me.Lbl_HNo0.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_HNo0.TabIndex = 6
        Me.Lbl_HNo0.Text = "P(No)"
        '
        'Lbl_HYesAbove0
        '
        Me.Lbl_HYesAbove0.AutoSize = True
        Me.Lbl_HYesAbove0.Location = New System.Drawing.Point(257, 70)
        Me.Lbl_HYesAbove0.Name = "Lbl_HYesAbove0"
        Me.Lbl_HYesAbove0.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_HYesAbove0.TabIndex = 5
        Me.Lbl_HYesAbove0.Text = "Pnum"
        '
        'Lbl_HAbove0
        '
        Me.Lbl_HAbove0.AutoSize = True
        Me.Lbl_HAbove0.Location = New System.Drawing.Point(6, 70)
        Me.Lbl_HAbove0.Name = "Lbl_HAbove0"
        Me.Lbl_HAbove0.Size = New System.Drawing.Size(193, 24)
        Me.Lbl_HAbove0.TabIndex = 4
        Me.Lbl_HAbove0.Text = "P(0>= And < 100|Yes)"
        '
        'Lbl_HNotAbove100
        '
        Me.Lbl_HNotAbove100.AutoSize = True
        Me.Lbl_HNotAbove100.Location = New System.Drawing.Point(475, 27)
        Me.Lbl_HNotAbove100.Name = "Lbl_HNotAbove100"
        Me.Lbl_HNotAbove100.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_HNotAbove100.TabIndex = 3
        Me.Lbl_HNotAbove100.Text = "NPnum"
        '
        'Lbl_HYesAbove100
        '
        Me.Lbl_HYesAbove100.AutoSize = True
        Me.Lbl_HYesAbove100.Location = New System.Drawing.Point(257, 27)
        Me.Lbl_HYesAbove100.Name = "Lbl_HYesAbove100"
        Me.Lbl_HYesAbove100.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_HYesAbove100.TabIndex = 2
        Me.Lbl_HYesAbove100.Text = "Pnum"
        '
        'Lbl_HNo100
        '
        Me.Lbl_HNo100.AutoSize = True
        Me.Lbl_HNo100.Location = New System.Drawing.Point(363, 27)
        Me.Lbl_HNo100.Name = "Lbl_HNo100"
        Me.Lbl_HNo100.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_HNo100.TabIndex = 1
        Me.Lbl_HNo100.Text = "P(No)"
        '
        'Lbl_HAbove100
        '
        Me.Lbl_HAbove100.AutoSize = True
        Me.Lbl_HAbove100.Location = New System.Drawing.Point(6, 27)
        Me.Lbl_HAbove100.Name = "Lbl_HAbove100"
        Me.Lbl_HAbove100.Size = New System.Drawing.Size(122, 24)
        Me.Lbl_HAbove100.TabIndex = 0
        Me.Lbl_HAbove100.Text = "P(100>=|Yes)"
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
        'GB_Defence
        '
        Me.GB_Defence.Controls.Add(Me.Lbl_DNotAbove0)
        Me.GB_Defence.Controls.Add(Me.Lbl_DNo0)
        Me.GB_Defence.Controls.Add(Me.Lbl_DYesAbove0)
        Me.GB_Defence.Controls.Add(Me.Lbl_DAbove0)
        Me.GB_Defence.Controls.Add(Me.Lbl_NotAbove50)
        Me.GB_Defence.Controls.Add(Me.Lbl_YesAbove50)
        Me.GB_Defence.Controls.Add(Me.Lbl_No50)
        Me.GB_Defence.Controls.Add(Me.Lbl_Above50)
        Me.GB_Defence.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Defence.Location = New System.Drawing.Point(18, 665)
        Me.GB_Defence.Name = "GB_Defence"
        Me.GB_Defence.Size = New System.Drawing.Size(525, 104)
        Me.GB_Defence.TabIndex = 43
        Me.GB_Defence.TabStop = False
        Me.GB_Defence.Text = "Defence"
        '
        'Lbl_DNotAbove0
        '
        Me.Lbl_DNotAbove0.AutoSize = True
        Me.Lbl_DNotAbove0.Location = New System.Drawing.Point(407, 70)
        Me.Lbl_DNotAbove0.Name = "Lbl_DNotAbove0"
        Me.Lbl_DNotAbove0.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_DNotAbove0.TabIndex = 7
        Me.Lbl_DNotAbove0.Text = "NPnum"
        '
        'Lbl_DNo0
        '
        Me.Lbl_DNo0.AutoSize = True
        Me.Lbl_DNo0.Location = New System.Drawing.Point(315, 70)
        Me.Lbl_DNo0.Name = "Lbl_DNo0"
        Me.Lbl_DNo0.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_DNo0.TabIndex = 6
        Me.Lbl_DNo0.Text = "P(No)"
        '
        'Lbl_DYesAbove0
        '
        Me.Lbl_DYesAbove0.AutoSize = True
        Me.Lbl_DYesAbove0.Location = New System.Drawing.Point(238, 70)
        Me.Lbl_DYesAbove0.Name = "Lbl_DYesAbove0"
        Me.Lbl_DYesAbove0.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_DYesAbove0.TabIndex = 5
        Me.Lbl_DYesAbove0.Text = "Pnum"
        '
        'Lbl_DAbove0
        '
        Me.Lbl_DAbove0.AutoSize = True
        Me.Lbl_DAbove0.Location = New System.Drawing.Point(6, 70)
        Me.Lbl_DAbove0.Name = "Lbl_DAbove0"
        Me.Lbl_DAbove0.Size = New System.Drawing.Size(183, 24)
        Me.Lbl_DAbove0.TabIndex = 4
        Me.Lbl_DAbove0.Text = "P(0>= And < 50|Yes)"
        '
        'Lbl_NotAbove50
        '
        Me.Lbl_NotAbove50.AutoSize = True
        Me.Lbl_NotAbove50.Location = New System.Drawing.Point(408, 27)
        Me.Lbl_NotAbove50.Name = "Lbl_NotAbove50"
        Me.Lbl_NotAbove50.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_NotAbove50.TabIndex = 3
        Me.Lbl_NotAbove50.Text = "NPnum"
        '
        'Lbl_YesAbove50
        '
        Me.Lbl_YesAbove50.AutoSize = True
        Me.Lbl_YesAbove50.Location = New System.Drawing.Point(238, 24)
        Me.Lbl_YesAbove50.Name = "Lbl_YesAbove50"
        Me.Lbl_YesAbove50.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_YesAbove50.TabIndex = 2
        Me.Lbl_YesAbove50.Text = "Pnum"
        '
        'Lbl_No50
        '
        Me.Lbl_No50.AutoSize = True
        Me.Lbl_No50.Location = New System.Drawing.Point(315, 27)
        Me.Lbl_No50.Name = "Lbl_No50"
        Me.Lbl_No50.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_No50.TabIndex = 1
        Me.Lbl_No50.Text = "P(No)"
        '
        'Lbl_Above50
        '
        Me.Lbl_Above50.AutoSize = True
        Me.Lbl_Above50.Location = New System.Drawing.Point(6, 27)
        Me.Lbl_Above50.Name = "Lbl_Above50"
        Me.Lbl_Above50.Size = New System.Drawing.Size(112, 24)
        Me.Lbl_Above50.TabIndex = 0
        Me.Lbl_Above50.Text = "P(50>=|Yes)"
        '
        'GB_Defence2
        '
        Me.GB_Defence2.Controls.Add(Me.Lbl_DHNotAbove0)
        Me.GB_Defence2.Controls.Add(Me.Lbl_HDNo0)
        Me.GB_Defence2.Controls.Add(Me.Lbl_DHYesAbove0)
        Me.GB_Defence2.Controls.Add(Me.Lbl_DHAbove0)
        Me.GB_Defence2.Controls.Add(Me.Lbl_DHNotAbove50)
        Me.GB_Defence2.Controls.Add(Me.Lbl_DHYesAbove50)
        Me.GB_Defence2.Controls.Add(Me.Lbl_HDNo50)
        Me.GB_Defence2.Controls.Add(Me.Lbl_HAbove50)
        Me.GB_Defence2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Defence2.Location = New System.Drawing.Point(909, 662)
        Me.GB_Defence2.Name = "GB_Defence2"
        Me.GB_Defence2.Size = New System.Drawing.Size(617, 104)
        Me.GB_Defence2.TabIndex = 44
        Me.GB_Defence2.TabStop = False
        Me.GB_Defence2.Text = "Defence"
        '
        'Lbl_DHNotAbove0
        '
        Me.Lbl_DHNotAbove0.AutoSize = True
        Me.Lbl_DHNotAbove0.Location = New System.Drawing.Point(473, 73)
        Me.Lbl_DHNotAbove0.Name = "Lbl_DHNotAbove0"
        Me.Lbl_DHNotAbove0.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_DHNotAbove0.TabIndex = 7
        Me.Lbl_DHNotAbove0.Text = "NPnum"
        '
        'Lbl_HDNo0
        '
        Me.Lbl_HDNo0.AutoSize = True
        Me.Lbl_HDNo0.Location = New System.Drawing.Point(359, 70)
        Me.Lbl_HDNo0.Name = "Lbl_HDNo0"
        Me.Lbl_HDNo0.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_HDNo0.TabIndex = 6
        Me.Lbl_HDNo0.Text = "P(No)"
        '
        'Lbl_DHYesAbove0
        '
        Me.Lbl_DHYesAbove0.AutoSize = True
        Me.Lbl_DHYesAbove0.Location = New System.Drawing.Point(257, 70)
        Me.Lbl_DHYesAbove0.Name = "Lbl_DHYesAbove0"
        Me.Lbl_DHYesAbove0.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_DHYesAbove0.TabIndex = 5
        Me.Lbl_DHYesAbove0.Text = "Pnum"
        '
        'Lbl_DHAbove0
        '
        Me.Lbl_DHAbove0.AutoSize = True
        Me.Lbl_DHAbove0.Location = New System.Drawing.Point(6, 70)
        Me.Lbl_DHAbove0.Name = "Lbl_DHAbove0"
        Me.Lbl_DHAbove0.Size = New System.Drawing.Size(183, 24)
        Me.Lbl_DHAbove0.TabIndex = 4
        Me.Lbl_DHAbove0.Text = "P(0>= And < 50|Yes)"
        '
        'Lbl_DHNotAbove50
        '
        Me.Lbl_DHNotAbove50.AutoSize = True
        Me.Lbl_DHNotAbove50.Location = New System.Drawing.Point(474, 30)
        Me.Lbl_DHNotAbove50.Name = "Lbl_DHNotAbove50"
        Me.Lbl_DHNotAbove50.Size = New System.Drawing.Size(74, 24)
        Me.Lbl_DHNotAbove50.TabIndex = 3
        Me.Lbl_DHNotAbove50.Text = "NPnum"
        '
        'Lbl_DHYesAbove50
        '
        Me.Lbl_DHYesAbove50.AutoSize = True
        Me.Lbl_DHYesAbove50.Location = New System.Drawing.Point(257, 24)
        Me.Lbl_DHYesAbove50.Name = "Lbl_DHYesAbove50"
        Me.Lbl_DHYesAbove50.Size = New System.Drawing.Size(60, 24)
        Me.Lbl_DHYesAbove50.TabIndex = 2
        Me.Lbl_DHYesAbove50.Text = "Pnum"
        '
        'Lbl_HDNo50
        '
        Me.Lbl_HDNo50.AutoSize = True
        Me.Lbl_HDNo50.Location = New System.Drawing.Point(359, 30)
        Me.Lbl_HDNo50.Name = "Lbl_HDNo50"
        Me.Lbl_HDNo50.Size = New System.Drawing.Size(59, 24)
        Me.Lbl_HDNo50.TabIndex = 1
        Me.Lbl_HDNo50.Text = "P(No)"
        '
        'Lbl_HAbove50
        '
        Me.Lbl_HAbove50.AutoSize = True
        Me.Lbl_HAbove50.Location = New System.Drawing.Point(6, 27)
        Me.Lbl_HAbove50.Name = "Lbl_HAbove50"
        Me.Lbl_HAbove50.Size = New System.Drawing.Size(112, 24)
        Me.Lbl_HAbove50.TabIndex = 0
        Me.Lbl_HAbove50.Text = "P(50>=|Yes)"
        '
        'Lbl_Res
        '
        Me.Lbl_Res.AutoSize = True
        Me.Lbl_Res.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Res.Location = New System.Drawing.Point(575, 780)
        Me.Lbl_Res.Name = "Lbl_Res"
        Me.Lbl_Res.Size = New System.Drawing.Size(68, 22)
        Me.Lbl_Res.TabIndex = 50
        Me.Lbl_Res.Text = "Result"
        '
        'Chart1
        '
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(213, 70)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Black
        Series1.MarkerSize = 10
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Home team"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Empty
        Series2.BorderWidth = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.MarkerColor = System.Drawing.Color.Black
        Series2.MarkerSize = 10
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series2.Name = "Away team"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1076, 476)
        Me.Chart1.TabIndex = 51
        Me.Chart1.Text = "Chart3"
        '
        'Lbl_PrevAMatch
        '
        Me.Lbl_PrevAMatch.AutoSize = True
        Me.Lbl_PrevAMatch.Location = New System.Drawing.Point(8, 85)
        Me.Lbl_PrevAMatch.Name = "Lbl_PrevAMatch"
        Me.Lbl_PrevAMatch.Size = New System.Drawing.Size(140, 17)
        Me.Lbl_PrevAMatch.TabIndex = 52
        Me.Lbl_PrevAMatch.Text = "Prev Away match res"
        Me.Lbl_PrevAMatch.Visible = False
        '
        'Lbl_PrevHMatch
        '
        Me.Lbl_PrevHMatch.AutoSize = True
        Me.Lbl_PrevHMatch.Location = New System.Drawing.Point(1395, 85)
        Me.Lbl_PrevHMatch.Name = "Lbl_PrevHMatch"
        Me.Lbl_PrevHMatch.Size = New System.Drawing.Size(142, 17)
        Me.Lbl_PrevHMatch.TabIndex = 53
        Me.Lbl_PrevHMatch.Text = "Prev home match res"
        Me.Lbl_PrevHMatch.Visible = False
        '
        'Lbl_TotalSeen
        '
        Me.Lbl_TotalSeen.AutoSize = True
        Me.Lbl_TotalSeen.Location = New System.Drawing.Point(8, 146)
        Me.Lbl_TotalSeen.Name = "Lbl_TotalSeen"
        Me.Lbl_TotalSeen.Size = New System.Drawing.Size(101, 17)
        Me.Lbl_TotalSeen.TabIndex = 54
        Me.Lbl_TotalSeen.Text = "Cnt apperance"
        Me.Lbl_TotalSeen.Visible = False
        '
        'Lbl_Res2
        '
        Me.Lbl_Res2.AutoSize = True
        Me.Lbl_Res2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Res2.Location = New System.Drawing.Point(575, 811)
        Me.Lbl_Res2.Name = "Lbl_Res2"
        Me.Lbl_Res2.Size = New System.Drawing.Size(126, 22)
        Me.Lbl_Res2.TabIndex = 55
        Me.Lbl_Res2.Text = "Lower result"
        Me.Lbl_Res2.Visible = False
        '
        'GamesVisionAlgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1811, 842)
        Me.Controls.Add(Me.Lbl_Res2)
        Me.Controls.Add(Me.Lbl_TotalSeen)
        Me.Controls.Add(Me.Lbl_PrevHMatch)
        Me.Controls.Add(Me.Lbl_PrevAMatch)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Lbl_Res)
        Me.Controls.Add(Me.GB_Defence2)
        Me.Controls.Add(Me.GB_Defence)
        Me.Controls.Add(Me.Lbl_2H50)
        Me.Controls.Add(Me.Lbl_2HZero)
        Me.Controls.Add(Me.Lbl_2A50)
        Me.Controls.Add(Me.Lbl_2AZero)
        Me.Controls.Add(Me.GB_Offense2)
        Me.Controls.Add(Me.Lbl_HZero)
        Me.Controls.Add(Me.Lbl_H100)
        Me.Controls.Add(Me.Lbl_A100)
        Me.Controls.Add(Me.Lbl_AZero)
        Me.Controls.Add(Me.GB_Offense)
        Me.Controls.Add(Me.GB_HTC)
        Me.Controls.Add(Me.GB_ATC)
        Me.Controls.Add(Me.Lbl_CheckBack)
        Me.Name = "GamesVisionAlgo"
        Me.Text = "GamesVisionAlgo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GB_ATC.ResumeLayout(False)
        Me.GB_ATC.PerformLayout()
        Me.GB_HTC.ResumeLayout(False)
        Me.GB_HTC.PerformLayout()
        Me.GB_Offense.ResumeLayout(False)
        Me.GB_Offense.PerformLayout()
        Me.GB_Offense2.ResumeLayout(False)
        Me.GB_Offense2.PerformLayout()
        Me.GB_Defence.ResumeLayout(False)
        Me.GB_Defence.PerformLayout()
        Me.GB_Defence2.ResumeLayout(False)
        Me.GB_Defence2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GB_Offense As System.Windows.Forms.GroupBox
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
    Friend WithEvents GB_Offense2 As System.Windows.Forms.GroupBox
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
    Friend WithEvents GB_Defence As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_DNotAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DNo0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DYesAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DAbove0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_NotAbove50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_YesAbove50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_No50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Above50 As System.Windows.Forms.Label
    Friend WithEvents GB_Defence2 As System.Windows.Forms.GroupBox
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
End Class
