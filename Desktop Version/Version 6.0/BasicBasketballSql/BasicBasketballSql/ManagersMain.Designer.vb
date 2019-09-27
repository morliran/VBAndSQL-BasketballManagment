<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagersMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Btn_LogOut = New System.Windows.Forms.Button()
        Me.Btn_Design = New System.Windows.Forms.Button()
        Me.Timer_Menu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Display = New System.Windows.Forms.Panel()
        Me.Panel_MovePanel = New System.Windows.Forms.Panel()
        Me.CHB_WhiteOrDark = New System.Windows.Forms.CheckBox()
        Me.FLP_Move = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbl_PlayersAdd = New System.Windows.Forms.Label()
        Me.Lbl_PlayersUpdate = New System.Windows.Forms.Label()
        Me.Lbl_PlayersAge = New System.Windows.Forms.Label()
        Me.Lbl_PlayersBirth = New System.Windows.Forms.Label()
        Me.Lbl_PlayersStats = New System.Windows.Forms.Label()
        Me.Lbl_RoutionC = New System.Windows.Forms.Label()
        Me.Lbl_RoutionUpdate = New System.Windows.Forms.Label()
        Me.Lbl_DrillsWatch = New System.Windows.Forms.Label()
        Me.Lbl_DrillsGrade = New System.Windows.Forms.Label()
        Me.Lbl_GamesMyTeam = New System.Windows.Forms.Label()
        Me.Lbl_GamesH = New System.Windows.Forms.Label()
        Me.Lbl_GamesA = New System.Windows.Forms.Label()
        Me.Lbl_AddingStats = New System.Windows.Forms.Label()
        Me.Lbl_GamesV = New System.Windows.Forms.Label()
        Me.Lbl_OthersS = New System.Windows.Forms.Label()
        Me.Lbl_OthersP = New System.Windows.Forms.Label()
        Me.Lbl_OthersT = New System.Windows.Forms.Label()
        Me.Lbl_OthersG = New System.Windows.Forms.Label()
        Me.Lbl_OthersLeagueLead = New System.Windows.Forms.Label()
        Me.Lbl_OthersTracking = New System.Windows.Forms.Label()
        Me.Panel_DesignTool = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartDesignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RowColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OddRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvenRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RowFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontPropertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_WhatManage = New System.Windows.Forms.Label()
        Me.Btn_Help = New System.Windows.Forms.Button()
        Me.Btn_Others = New System.Windows.Forms.Button()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Btn_Games = New System.Windows.Forms.Button()
        Me.Btn_Drills = New System.Windows.Forms.Button()
        Me.Btn_Roution = New System.Windows.Forms.Button()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Pic_Menu = New System.Windows.Forms.PictureBox()
        Me.Btn_Players = New System.Windows.Forms.Button()
        Me.Panel_Grid = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Lbl_CheckGameDate = New System.Windows.Forms.Label()
        Me.Lbl_TableName = New System.Windows.Forms.Label()
        Me.Lbl_ManagerCheck = New System.Windows.Forms.Label()
        Me.Panel_Display.SuspendLayout()
        Me.Panel_MovePanel.SuspendLayout()
        Me.FLP_Move.SuspendLayout()
        Me.Panel_DesignTool.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        Me.Panel_Top.SuspendLayout()
        CType(Me.Pic_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Grid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_LogOut
        '
        Me.Btn_LogOut.FlatAppearance.BorderSize = 0
        Me.Btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LogOut.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_LogOut.ForeColor = System.Drawing.Color.White
        Me.Btn_LogOut.Location = New System.Drawing.Point(4, 733)
        Me.Btn_LogOut.Name = "Btn_LogOut"
        Me.Btn_LogOut.Size = New System.Drawing.Size(159, 75)
        Me.Btn_LogOut.TabIndex = 8
        Me.Btn_LogOut.Text = "Log out"
        Me.Btn_LogOut.UseVisualStyleBackColor = True
        '
        'Btn_Design
        '
        Me.Btn_Design.FlatAppearance.BorderSize = 0
        Me.Btn_Design.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Design.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Design.ForeColor = System.Drawing.Color.White
        Me.Btn_Design.Location = New System.Drawing.Point(12, 553)
        Me.Btn_Design.Name = "Btn_Design"
        Me.Btn_Design.Size = New System.Drawing.Size(159, 75)
        Me.Btn_Design.TabIndex = 6
        Me.Btn_Design.Text = "Design Table"
        Me.Btn_Design.UseVisualStyleBackColor = True
        '
        'Timer_Menu
        '
        Me.Timer_Menu.Interval = 10
        '
        'Panel_Display
        '
        Me.Panel_Display.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel_Display.Controls.Add(Me.Panel_Grid)
        Me.Panel_Display.Controls.Add(Me.Panel_MovePanel)
        Me.Panel_Display.Controls.Add(Me.Lbl_WhatManage)
        Me.Panel_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Display.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Panel_Display.Location = New System.Drawing.Point(163, 0)
        Me.Panel_Display.Name = "Panel_Display"
        Me.Panel_Display.Size = New System.Drawing.Size(1761, 1055)
        Me.Panel_Display.TabIndex = 8
        '
        'Panel_MovePanel
        '
        Me.Panel_MovePanel.Controls.Add(Me.CHB_WhiteOrDark)
        Me.Panel_MovePanel.Controls.Add(Me.FLP_Move)
        Me.Panel_MovePanel.Controls.Add(Me.Panel_DesignTool)
        Me.Panel_MovePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_MovePanel.Location = New System.Drawing.Point(0, 0)
        Me.Panel_MovePanel.Name = "Panel_MovePanel"
        Me.Panel_MovePanel.Size = New System.Drawing.Size(313, 1055)
        Me.Panel_MovePanel.TabIndex = 31
        '
        'CHB_WhiteOrDark
        '
        Me.CHB_WhiteOrDark.AutoSize = True
        Me.CHB_WhiteOrDark.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_WhiteOrDark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CHB_WhiteOrDark.Location = New System.Drawing.Point(16, 3)
        Me.CHB_WhiteOrDark.Name = "CHB_WhiteOrDark"
        Me.CHB_WhiteOrDark.Size = New System.Drawing.Size(184, 37)
        Me.CHB_WhiteOrDark.TabIndex = 40
        Me.CHB_WhiteOrDark.Text = "Dark Mode"
        Me.CHB_WhiteOrDark.UseVisualStyleBackColor = True
        '
        'FLP_Move
        '
        Me.FLP_Move.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FLP_Move.Controls.Add(Me.Lbl_PlayersAdd)
        Me.FLP_Move.Controls.Add(Me.Lbl_PlayersUpdate)
        Me.FLP_Move.Controls.Add(Me.Lbl_PlayersAge)
        Me.FLP_Move.Controls.Add(Me.Lbl_PlayersBirth)
        Me.FLP_Move.Controls.Add(Me.Lbl_PlayersStats)
        Me.FLP_Move.Controls.Add(Me.Lbl_RoutionC)
        Me.FLP_Move.Controls.Add(Me.Lbl_RoutionUpdate)
        Me.FLP_Move.Controls.Add(Me.Lbl_DrillsWatch)
        Me.FLP_Move.Controls.Add(Me.Lbl_DrillsGrade)
        Me.FLP_Move.Controls.Add(Me.Lbl_GamesMyTeam)
        Me.FLP_Move.Controls.Add(Me.Lbl_GamesH)
        Me.FLP_Move.Controls.Add(Me.Lbl_GamesA)
        Me.FLP_Move.Controls.Add(Me.Lbl_AddingStats)
        Me.FLP_Move.Controls.Add(Me.Lbl_GamesV)
        Me.FLP_Move.Controls.Add(Me.Lbl_OthersS)
        Me.FLP_Move.Controls.Add(Me.Lbl_OthersP)
        Me.FLP_Move.Controls.Add(Me.Lbl_OthersT)
        Me.FLP_Move.Controls.Add(Me.Lbl_OthersG)
        Me.FLP_Move.Controls.Add(Me.Lbl_OthersLeagueLead)
        Me.FLP_Move.Controls.Add(Me.Lbl_OthersTracking)
        Me.FLP_Move.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Move.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.FLP_Move.Location = New System.Drawing.Point(0, 0)
        Me.FLP_Move.Name = "FLP_Move"
        Me.FLP_Move.Size = New System.Drawing.Size(8, 100)
        Me.FLP_Move.TabIndex = 9
        Me.FLP_Move.Visible = False
        '
        'Lbl_PlayersAdd
        '
        Me.Lbl_PlayersAdd.AutoSize = True
        Me.Lbl_PlayersAdd.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PlayersAdd.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_PlayersAdd.Name = "Lbl_PlayersAdd"
        Me.Lbl_PlayersAdd.Size = New System.Drawing.Size(34, 297)
        Me.Lbl_PlayersAdd.TabIndex = 14
        Me.Lbl_PlayersAdd.Text = "Add players"
        Me.Lbl_PlayersAdd.Visible = False
        '
        'Lbl_PlayersUpdate
        '
        Me.Lbl_PlayersUpdate.AutoSize = True
        Me.Lbl_PlayersUpdate.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PlayersUpdate.Location = New System.Drawing.Point(43, 0)
        Me.Lbl_PlayersUpdate.Name = "Lbl_PlayersUpdate"
        Me.Lbl_PlayersUpdate.Size = New System.Drawing.Size(215, 33)
        Me.Lbl_PlayersUpdate.TabIndex = 15
        Me.Lbl_PlayersUpdate.Text = "Update players"
        Me.Lbl_PlayersUpdate.Visible = False
        '
        'Lbl_PlayersAge
        '
        Me.Lbl_PlayersAge.AutoSize = True
        Me.Lbl_PlayersAge.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PlayersAge.Location = New System.Drawing.Point(43, 33)
        Me.Lbl_PlayersAge.Name = "Lbl_PlayersAge"
        Me.Lbl_PlayersAge.Size = New System.Drawing.Size(168, 33)
        Me.Lbl_PlayersAge.TabIndex = 12
        Me.Lbl_PlayersAge.Text = "Players Age"
        Me.Lbl_PlayersAge.Visible = False
        '
        'Lbl_PlayersBirth
        '
        Me.Lbl_PlayersBirth.AutoSize = True
        Me.Lbl_PlayersBirth.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PlayersBirth.Location = New System.Drawing.Point(43, 66)
        Me.Lbl_PlayersBirth.Name = "Lbl_PlayersBirth"
        Me.Lbl_PlayersBirth.Size = New System.Drawing.Size(281, 33)
        Me.Lbl_PlayersBirth.TabIndex = 13
        Me.Lbl_PlayersBirth.Text = "Upcoming Brithday's"
        Me.Lbl_PlayersBirth.Visible = False
        '
        'Lbl_PlayersStats
        '
        Me.Lbl_PlayersStats.AutoSize = True
        Me.Lbl_PlayersStats.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PlayersStats.Location = New System.Drawing.Point(330, 0)
        Me.Lbl_PlayersStats.Name = "Lbl_PlayersStats"
        Me.Lbl_PlayersStats.Size = New System.Drawing.Size(211, 33)
        Me.Lbl_PlayersStats.TabIndex = 16
        Me.Lbl_PlayersStats.Text = "Compare Stats"
        Me.Lbl_PlayersStats.Visible = False
        '
        'Lbl_RoutionC
        '
        Me.Lbl_RoutionC.AutoSize = True
        Me.Lbl_RoutionC.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoutionC.Location = New System.Drawing.Point(330, 33)
        Me.Lbl_RoutionC.Name = "Lbl_RoutionC"
        Me.Lbl_RoutionC.Size = New System.Drawing.Size(246, 33)
        Me.Lbl_RoutionC.TabIndex = 17
        Me.Lbl_RoutionC.Text = "My Roution Code"
        Me.Lbl_RoutionC.Visible = False
        '
        'Lbl_RoutionUpdate
        '
        Me.Lbl_RoutionUpdate.AutoSize = True
        Me.Lbl_RoutionUpdate.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RoutionUpdate.Location = New System.Drawing.Point(330, 66)
        Me.Lbl_RoutionUpdate.Name = "Lbl_RoutionUpdate"
        Me.Lbl_RoutionUpdate.Size = New System.Drawing.Size(222, 33)
        Me.Lbl_RoutionUpdate.TabIndex = 18
        Me.Lbl_RoutionUpdate.Text = "Update Roution"
        Me.Lbl_RoutionUpdate.Visible = False
        '
        'Lbl_DrillsWatch
        '
        Me.Lbl_DrillsWatch.AutoSize = True
        Me.Lbl_DrillsWatch.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DrillsWatch.Location = New System.Drawing.Point(582, 0)
        Me.Lbl_DrillsWatch.Name = "Lbl_DrillsWatch"
        Me.Lbl_DrillsWatch.Size = New System.Drawing.Size(154, 33)
        Me.Lbl_DrillsWatch.TabIndex = 19
        Me.Lbl_DrillsWatch.Text = "Drill Watch"
        Me.Lbl_DrillsWatch.Visible = False
        '
        'Lbl_DrillsGrade
        '
        Me.Lbl_DrillsGrade.AutoSize = True
        Me.Lbl_DrillsGrade.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DrillsGrade.Location = New System.Drawing.Point(582, 33)
        Me.Lbl_DrillsGrade.Name = "Lbl_DrillsGrade"
        Me.Lbl_DrillsGrade.Size = New System.Drawing.Size(165, 33)
        Me.Lbl_DrillsGrade.TabIndex = 21
        Me.Lbl_DrillsGrade.Text = "Drills Grade"
        Me.Lbl_DrillsGrade.Visible = False
        '
        'Lbl_GamesMyTeam
        '
        Me.Lbl_GamesMyTeam.AutoSize = True
        Me.Lbl_GamesMyTeam.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GamesMyTeam.Location = New System.Drawing.Point(582, 66)
        Me.Lbl_GamesMyTeam.Name = "Lbl_GamesMyTeam"
        Me.Lbl_GamesMyTeam.Size = New System.Drawing.Size(276, 33)
        Me.Lbl_GamesMyTeam.TabIndex = 22
        Me.Lbl_GamesMyTeam.Text = "All My Team Games"
        Me.Lbl_GamesMyTeam.Visible = False
        '
        'Lbl_GamesH
        '
        Me.Lbl_GamesH.AutoSize = True
        Me.Lbl_GamesH.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GamesH.Location = New System.Drawing.Point(864, 0)
        Me.Lbl_GamesH.Name = "Lbl_GamesH"
        Me.Lbl_GamesH.Size = New System.Drawing.Size(273, 33)
        Me.Lbl_GamesH.TabIndex = 23
        Me.Lbl_GamesH.Text = "All My Home Game"
        Me.Lbl_GamesH.Visible = False
        '
        'Lbl_GamesA
        '
        Me.Lbl_GamesA.AutoSize = True
        Me.Lbl_GamesA.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GamesA.Location = New System.Drawing.Point(864, 33)
        Me.Lbl_GamesA.Name = "Lbl_GamesA"
        Me.Lbl_GamesA.Size = New System.Drawing.Size(279, 33)
        Me.Lbl_GamesA.TabIndex = 24
        Me.Lbl_GamesA.Text = "All My Away Games"
        Me.Lbl_GamesA.Visible = False
        '
        'Lbl_AddingStats
        '
        Me.Lbl_AddingStats.AutoSize = True
        Me.Lbl_AddingStats.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AddingStats.Location = New System.Drawing.Point(864, 66)
        Me.Lbl_AddingStats.Name = "Lbl_AddingStats"
        Me.Lbl_AddingStats.Size = New System.Drawing.Size(331, 33)
        Me.Lbl_AddingStats.TabIndex = 25
        Me.Lbl_AddingStats.Text = "Add Players Game Stats"
        Me.Lbl_AddingStats.Visible = False
        '
        'Lbl_GamesV
        '
        Me.Lbl_GamesV.AutoSize = True
        Me.Lbl_GamesV.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_GamesV.Location = New System.Drawing.Point(1201, 0)
        Me.Lbl_GamesV.Name = "Lbl_GamesV"
        Me.Lbl_GamesV.Size = New System.Drawing.Size(193, 33)
        Me.Lbl_GamesV.TabIndex = 26
        Me.Lbl_GamesV.Text = "Games Vision"
        Me.Lbl_GamesV.Visible = False
        '
        'Lbl_OthersS
        '
        Me.Lbl_OthersS.AutoSize = True
        Me.Lbl_OthersS.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OthersS.Location = New System.Drawing.Point(1201, 33)
        Me.Lbl_OthersS.Name = "Lbl_OthersS"
        Me.Lbl_OthersS.Size = New System.Drawing.Size(161, 33)
        Me.Lbl_OthersS.TabIndex = 27
        Me.Lbl_OthersS.Text = "All My Stats"
        Me.Lbl_OthersS.Visible = False
        '
        'Lbl_OthersP
        '
        Me.Lbl_OthersP.AutoSize = True
        Me.Lbl_OthersP.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OthersP.Location = New System.Drawing.Point(1201, 66)
        Me.Lbl_OthersP.Name = "Lbl_OthersP"
        Me.Lbl_OthersP.Size = New System.Drawing.Size(251, 33)
        Me.Lbl_OthersP.TabIndex = 28
        Me.Lbl_OthersP.Text = "All League Players"
        Me.Lbl_OthersP.Visible = False
        '
        'Lbl_OthersT
        '
        Me.Lbl_OthersT.AutoSize = True
        Me.Lbl_OthersT.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OthersT.Location = New System.Drawing.Point(1458, 0)
        Me.Lbl_OthersT.Name = "Lbl_OthersT"
        Me.Lbl_OthersT.Size = New System.Drawing.Size(243, 33)
        Me.Lbl_OthersT.TabIndex = 29
        Me.Lbl_OthersT.Text = "All League Teams"
        Me.Lbl_OthersT.Visible = False
        '
        'Lbl_OthersG
        '
        Me.Lbl_OthersG.AutoSize = True
        Me.Lbl_OthersG.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OthersG.Location = New System.Drawing.Point(1458, 33)
        Me.Lbl_OthersG.Name = "Lbl_OthersG"
        Me.Lbl_OthersG.Size = New System.Drawing.Size(256, 33)
        Me.Lbl_OthersG.TabIndex = 30
        Me.Lbl_OthersG.Text = "All League Games"
        Me.Lbl_OthersG.Visible = False
        '
        'Lbl_OthersLeagueLead
        '
        Me.Lbl_OthersLeagueLead.AutoSize = True
        Me.Lbl_OthersLeagueLead.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OthersLeagueLead.Location = New System.Drawing.Point(1458, 66)
        Me.Lbl_OthersLeagueLead.Name = "Lbl_OthersLeagueLead"
        Me.Lbl_OthersLeagueLead.Size = New System.Drawing.Size(219, 33)
        Me.Lbl_OthersLeagueLead.TabIndex = 20
        Me.Lbl_OthersLeagueLead.Text = "&League leaders"
        Me.Lbl_OthersLeagueLead.Visible = False
        '
        'Lbl_OthersTracking
        '
        Me.Lbl_OthersTracking.AutoSize = True
        Me.Lbl_OthersTracking.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OthersTracking.Location = New System.Drawing.Point(1720, 0)
        Me.Lbl_OthersTracking.Name = "Lbl_OthersTracking"
        Me.Lbl_OthersTracking.Size = New System.Drawing.Size(221, 33)
        Me.Lbl_OthersTracking.TabIndex = 31
        Me.Lbl_OthersTracking.Text = "Tracking Players"
        Me.Lbl_OthersTracking.Visible = False
        '
        'Panel_DesignTool
        '
        Me.Panel_DesignTool.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel_DesignTool.Controls.Add(Me.MenuStrip1)
        Me.Panel_DesignTool.Location = New System.Drawing.Point(8, 46)
        Me.Panel_DesignTool.Name = "Panel_DesignTool"
        Me.Panel_DesignTool.Size = New System.Drawing.Size(303, 123)
        Me.Panel_DesignTool.TabIndex = 39
        Me.Panel_DesignTool.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartDesignToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(201, 38)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartDesignToolStripMenuItem
        '
        Me.StartDesignToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RowColorToolStripMenuItem1, Me.RowFontToolStripMenuItem, Me.RefreshTableToolStripMenuItem})
        Me.StartDesignToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.StartDesignToolStripMenuItem.Name = "StartDesignToolStripMenuItem"
        Me.StartDesignToolStripMenuItem.Size = New System.Drawing.Size(193, 34)
        Me.StartDesignToolStripMenuItem.Text = "Start to design"
        '
        'RowColorToolStripMenuItem1
        '
        Me.RowColorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OddRowToolStripMenuItem, Me.EvenRowToolStripMenuItem})
        Me.RowColorToolStripMenuItem1.Name = "RowColorToolStripMenuItem1"
        Me.RowColorToolStripMenuItem1.Size = New System.Drawing.Size(245, 34)
        Me.RowColorToolStripMenuItem1.Text = "Row Color"
        '
        'OddRowToolStripMenuItem
        '
        Me.OddRowToolStripMenuItem.Name = "OddRowToolStripMenuItem"
        Me.OddRowToolStripMenuItem.Size = New System.Drawing.Size(203, 34)
        Me.OddRowToolStripMenuItem.Text = "Odd Row"
        '
        'EvenRowToolStripMenuItem
        '
        Me.EvenRowToolStripMenuItem.Name = "EvenRowToolStripMenuItem"
        Me.EvenRowToolStripMenuItem.Size = New System.Drawing.Size(203, 34)
        Me.EvenRowToolStripMenuItem.Text = "Even Row"
        '
        'RowFontToolStripMenuItem
        '
        Me.RowFontToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontPropertyToolStripMenuItem, Me.FontColorToolStripMenuItem})
        Me.RowFontToolStripMenuItem.Name = "RowFontToolStripMenuItem"
        Me.RowFontToolStripMenuItem.Size = New System.Drawing.Size(245, 34)
        Me.RowFontToolStripMenuItem.Text = "Row Font"
        '
        'FontPropertyToolStripMenuItem
        '
        Me.FontPropertyToolStripMenuItem.Name = "FontPropertyToolStripMenuItem"
        Me.FontPropertyToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.FontPropertyToolStripMenuItem.Text = "Font Property"
        '
        'FontColorToolStripMenuItem
        '
        Me.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        Me.FontColorToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.FontColorToolStripMenuItem.Text = "Font Color"
        '
        'RefreshTableToolStripMenuItem
        '
        Me.RefreshTableToolStripMenuItem.BackColor = System.Drawing.Color.Gold
        Me.RefreshTableToolStripMenuItem.Name = "RefreshTableToolStripMenuItem"
        Me.RefreshTableToolStripMenuItem.Size = New System.Drawing.Size(245, 34)
        Me.RefreshTableToolStripMenuItem.Text = "Refresh Table"
        '
        'Lbl_WhatManage
        '
        Me.Lbl_WhatManage.AutoSize = True
        Me.Lbl_WhatManage.ForeColor = System.Drawing.Color.White
        Me.Lbl_WhatManage.Location = New System.Drawing.Point(12, 7)
        Me.Lbl_WhatManage.Name = "Lbl_WhatManage"
        Me.Lbl_WhatManage.Size = New System.Drawing.Size(140, 23)
        Me.Lbl_WhatManage.TabIndex = 30
        Me.Lbl_WhatManage.Text = "With manage"
        Me.Lbl_WhatManage.Visible = False
        '
        'Btn_Help
        '
        Me.Btn_Help.FlatAppearance.BorderSize = 0
        Me.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Help.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Help.ForeColor = System.Drawing.Color.White
        Me.Btn_Help.Location = New System.Drawing.Point(4, 643)
        Me.Btn_Help.Name = "Btn_Help"
        Me.Btn_Help.Size = New System.Drawing.Size(159, 75)
        Me.Btn_Help.TabIndex = 7
        Me.Btn_Help.Text = "Help"
        Me.Btn_Help.UseVisualStyleBackColor = True
        '
        'Btn_Others
        '
        Me.Btn_Others.FlatAppearance.BorderSize = 0
        Me.Btn_Others.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Others.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Others.ForeColor = System.Drawing.Color.White
        Me.Btn_Others.Location = New System.Drawing.Point(6, 463)
        Me.Btn_Others.Name = "Btn_Others"
        Me.Btn_Others.Size = New System.Drawing.Size(165, 75)
        Me.Btn_Others.TabIndex = 5
        Me.Btn_Others.Text = "Others"
        Me.Btn_Others.UseVisualStyleBackColor = True
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Panel_Left.Controls.Add(Me.Btn_LogOut)
        Me.Panel_Left.Controls.Add(Me.Btn_Help)
        Me.Panel_Left.Controls.Add(Me.Btn_Design)
        Me.Panel_Left.Controls.Add(Me.Btn_Others)
        Me.Panel_Left.Controls.Add(Me.Btn_Games)
        Me.Panel_Left.Controls.Add(Me.Btn_Drills)
        Me.Panel_Left.Controls.Add(Me.Btn_Roution)
        Me.Panel_Left.Controls.Add(Me.Panel_Top)
        Me.Panel_Left.Controls.Add(Me.Btn_Players)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(163, 1055)
        Me.Panel_Left.TabIndex = 7
        '
        'Btn_Games
        '
        Me.Btn_Games.FlatAppearance.BorderSize = 0
        Me.Btn_Games.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Games.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Games.ForeColor = System.Drawing.Color.White
        Me.Btn_Games.Location = New System.Drawing.Point(12, 373)
        Me.Btn_Games.Name = "Btn_Games"
        Me.Btn_Games.Size = New System.Drawing.Size(159, 75)
        Me.Btn_Games.TabIndex = 4
        Me.Btn_Games.Text = "Games"
        Me.Btn_Games.UseVisualStyleBackColor = True
        '
        'Btn_Drills
        '
        Me.Btn_Drills.FlatAppearance.BorderSize = 0
        Me.Btn_Drills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Drills.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Drills.ForeColor = System.Drawing.Color.White
        Me.Btn_Drills.Location = New System.Drawing.Point(17, 283)
        Me.Btn_Drills.Name = "Btn_Drills"
        Me.Btn_Drills.Size = New System.Drawing.Size(154, 75)
        Me.Btn_Drills.TabIndex = 3
        Me.Btn_Drills.Text = "Drills"
        Me.Btn_Drills.UseVisualStyleBackColor = True
        '
        'Btn_Roution
        '
        Me.Btn_Roution.FlatAppearance.BorderSize = 0
        Me.Btn_Roution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Roution.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Roution.ForeColor = System.Drawing.Color.White
        Me.Btn_Roution.Location = New System.Drawing.Point(17, 193)
        Me.Btn_Roution.Name = "Btn_Roution"
        Me.Btn_Roution.Size = New System.Drawing.Size(154, 75)
        Me.Btn_Roution.TabIndex = 2
        Me.Btn_Roution.Text = "Roution"
        Me.Btn_Roution.UseVisualStyleBackColor = True
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Pic_Menu)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(163, 100)
        Me.Panel_Top.TabIndex = 1
        '
        'Pic_Menu
        '
        Me.Pic_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pic_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Menu.Name = "Pic_Menu"
        Me.Pic_Menu.Size = New System.Drawing.Size(163, 100)
        Me.Pic_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Menu.TabIndex = 24
        Me.Pic_Menu.TabStop = False
        '
        'Btn_Players
        '
        Me.Btn_Players.FlatAppearance.BorderSize = 0
        Me.Btn_Players.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Players.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Players.ForeColor = System.Drawing.Color.White
        Me.Btn_Players.Location = New System.Drawing.Point(12, 103)
        Me.Btn_Players.Name = "Btn_Players"
        Me.Btn_Players.Size = New System.Drawing.Size(159, 75)
        Me.Btn_Players.TabIndex = 0
        Me.Btn_Players.Text = "Players"
        Me.Btn_Players.UseVisualStyleBackColor = True
        '
        'Panel_Grid
        '
        Me.Panel_Grid.Controls.Add(Me.DataGridView1)
        Me.Panel_Grid.Controls.Add(Me.Lbl_CheckGameDate)
        Me.Panel_Grid.Controls.Add(Me.Lbl_TableName)
        Me.Panel_Grid.Controls.Add(Me.Lbl_ManagerCheck)
        Me.Panel_Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Grid.Location = New System.Drawing.Point(313, 0)
        Me.Panel_Grid.Name = "Panel_Grid"
        Me.Panel_Grid.Size = New System.Drawing.Size(1448, 1055)
        Me.Panel_Grid.TabIndex = 32
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(23, 103)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1016, 530)
        Me.DataGridView1.TabIndex = 40
        '
        'Lbl_CheckGameDate
        '
        Me.Lbl_CheckGameDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_CheckGameDate.AutoSize = True
        Me.Lbl_CheckGameDate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CheckGameDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CheckGameDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Lbl_CheckGameDate.Location = New System.Drawing.Point(435, 66)
        Me.Lbl_CheckGameDate.Name = "Lbl_CheckGameDate"
        Me.Lbl_CheckGameDate.Size = New System.Drawing.Size(124, 23)
        Me.Lbl_CheckGameDate.TabIndex = 43
        Me.Lbl_CheckGameDate.Text = "Game Date"
        Me.Lbl_CheckGameDate.Visible = False
        '
        'Lbl_TableName
        '
        Me.Lbl_TableName.AutoSize = True
        Me.Lbl_TableName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TableName.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Lbl_TableName.Location = New System.Drawing.Point(433, 6)
        Me.Lbl_TableName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_TableName.Name = "Lbl_TableName"
        Me.Lbl_TableName.Size = New System.Drawing.Size(173, 32)
        Me.Lbl_TableName.TabIndex = 42
        Me.Lbl_TableName.Text = "Table Name"
        '
        'Lbl_ManagerCheck
        '
        Me.Lbl_ManagerCheck.AutoSize = True
        Me.Lbl_ManagerCheck.Location = New System.Drawing.Point(1101, 9)
        Me.Lbl_ManagerCheck.Name = "Lbl_ManagerCheck"
        Me.Lbl_ManagerCheck.Size = New System.Drawing.Size(169, 23)
        Me.Lbl_ManagerCheck.TabIndex = 41
        Me.Lbl_ManagerCheck.Text = "Manager Check"
        Me.Lbl_ManagerCheck.Visible = False
        '
        'ManagersMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel_Display)
        Me.Controls.Add(Me.Panel_Left)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "ManagersMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Managers Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Display.ResumeLayout(False)
        Me.Panel_Display.PerformLayout()
        Me.Panel_MovePanel.ResumeLayout(False)
        Me.Panel_MovePanel.PerformLayout()
        Me.FLP_Move.ResumeLayout(False)
        Me.FLP_Move.PerformLayout()
        Me.Panel_DesignTool.ResumeLayout(False)
        Me.Panel_DesignTool.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_Left.ResumeLayout(False)
        Me.Panel_Top.ResumeLayout(False)
        CType(Me.Pic_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Grid.ResumeLayout(False)
        Me.Panel_Grid.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Btn_LogOut As System.Windows.Forms.Button
    Friend WithEvents Btn_Design As System.Windows.Forms.Button
    Friend WithEvents Timer_Menu As System.Windows.Forms.Timer
    Friend WithEvents Panel_Display As System.Windows.Forms.Panel
    Friend WithEvents Panel_MovePanel As System.Windows.Forms.Panel
    Friend WithEvents CHB_WhiteOrDark As System.Windows.Forms.CheckBox
    Friend WithEvents Panel_DesignTool As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StartDesignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RowColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OddRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvenRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RowFontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontPropertyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lbl_WhatManage As System.Windows.Forms.Label
    Friend WithEvents Btn_Help As System.Windows.Forms.Button
    Friend WithEvents Btn_Others As System.Windows.Forms.Button
    Friend WithEvents Lbl_GamesMyTeam As System.Windows.Forms.Label
    Friend WithEvents FLP_Move As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Lbl_PlayersAdd As System.Windows.Forms.Label
    Friend WithEvents Lbl_PlayersUpdate As System.Windows.Forms.Label
    Friend WithEvents Lbl_PlayersAge As System.Windows.Forms.Label
    Friend WithEvents Lbl_PlayersBirth As System.Windows.Forms.Label
    Friend WithEvents Lbl_PlayersStats As System.Windows.Forms.Label
    Friend WithEvents Lbl_RoutionC As System.Windows.Forms.Label
    Friend WithEvents Lbl_RoutionUpdate As System.Windows.Forms.Label
    Friend WithEvents Lbl_DrillsWatch As System.Windows.Forms.Label
    Friend WithEvents Lbl_DrillsGrade As System.Windows.Forms.Label
    Friend WithEvents Lbl_GamesH As System.Windows.Forms.Label
    Friend WithEvents Lbl_GamesA As System.Windows.Forms.Label
    Friend WithEvents Lbl_AddingStats As System.Windows.Forms.Label
    Friend WithEvents Lbl_GamesV As System.Windows.Forms.Label
    Friend WithEvents Lbl_OthersS As System.Windows.Forms.Label
    Friend WithEvents Lbl_OthersP As System.Windows.Forms.Label
    Friend WithEvents Lbl_OthersT As System.Windows.Forms.Label
    Friend WithEvents Lbl_OthersG As System.Windows.Forms.Label
    Friend WithEvents Lbl_OthersLeagueLead As System.Windows.Forms.Label
    Friend WithEvents Lbl_OthersTracking As System.Windows.Forms.Label
    Friend WithEvents Panel_Left As System.Windows.Forms.Panel
    Friend WithEvents Btn_Games As System.Windows.Forms.Button
    Friend WithEvents Btn_Drills As System.Windows.Forms.Button
    Friend WithEvents Btn_Roution As System.Windows.Forms.Button
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Btn_Players As System.Windows.Forms.Button
    Friend WithEvents Pic_Menu As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Grid As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_CheckGameDate As System.Windows.Forms.Label
    Friend WithEvents Lbl_TableName As System.Windows.Forms.Label
    Friend WithEvents Lbl_ManagerCheck As System.Windows.Forms.Label
End Class
