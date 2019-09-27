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
        Me.Lbl_TableName = New System.Windows.Forms.Label()
        Me.Btn_AutoClick = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TimerAutoClick = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_ManagerCheck = New System.Windows.Forms.Label()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.PlayersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatePlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayersAgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpcomingBrithdaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayersStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllTeamStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompareStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoutionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyRoutionCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRoutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WatchDrillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayersDrillsGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllGamesForMyTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllGamesAsHomeTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllGamesAsAwayTeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPlayersGameStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesVisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllLeaguePlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllLeagueTeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllLeagueGamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeagueLeadersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackPlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Lbl_CheckGameDate = New System.Windows.Forms.Label()
        Me.Pic_Logout = New System.Windows.Forms.PictureBox()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Pic_Logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_TableName
        '
        Me.Lbl_TableName.AutoSize = True
        Me.Lbl_TableName.BackColor = System.Drawing.Color.White
        Me.Lbl_TableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TableName.Location = New System.Drawing.Point(8, 45)
        Me.Lbl_TableName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_TableName.Name = "Lbl_TableName"
        Me.Lbl_TableName.Size = New System.Drawing.Size(140, 26)
        Me.Lbl_TableName.TabIndex = 7
        Me.Lbl_TableName.Text = "Table Name"
        '
        'Btn_AutoClick
        '
        Me.Btn_AutoClick.BackColor = System.Drawing.Color.Transparent
        Me.Btn_AutoClick.Location = New System.Drawing.Point(151, 224)
        Me.Btn_AutoClick.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_AutoClick.Name = "Btn_AutoClick"
        Me.Btn_AutoClick.Size = New System.Drawing.Size(100, 28)
        Me.Btn_AutoClick.TabIndex = 8
        Me.Btn_AutoClick.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 116)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1427, 561)
        Me.DataGridView1.TabIndex = 9
        '
        'Lbl_ManagerCheck
        '
        Me.Lbl_ManagerCheck.AutoSize = True
        Me.Lbl_ManagerCheck.Location = New System.Drawing.Point(724, 47)
        Me.Lbl_ManagerCheck.Name = "Lbl_ManagerCheck"
        Me.Lbl_ManagerCheck.Size = New System.Drawing.Size(107, 17)
        Me.Lbl_ManagerCheck.TabIndex = 10
        Me.Lbl_ManagerCheck.Text = "Manager Check"
        Me.Lbl_ManagerCheck.Visible = False
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.Location = New System.Drawing.Point(525, 42)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(164, 26)
        Me.Btn_Refresh.TabIndex = 12
        Me.Btn_Refresh.Text = "Refresh"
        Me.Btn_Refresh.UseVisualStyleBackColor = True
        '
        'PlayersToolStripMenuItem1
        '
        Me.PlayersToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPlayerToolStripMenuItem, Me.UpdatePlayerToolStripMenuItem, Me.PlayersAgeToolStripMenuItem, Me.UpcomingBrithdaysToolStripMenuItem, Me.PlayersStatsToolStripMenuItem})
        Me.PlayersToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PlayersToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlayersToolStripMenuItem1.Name = "PlayersToolStripMenuItem1"
        Me.PlayersToolStripMenuItem1.Size = New System.Drawing.Size(85, 32)
        Me.PlayersToolStripMenuItem1.Text = "Players"
        Me.PlayersToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AddPlayerToolStripMenuItem
        '
        Me.AddPlayerToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.add
        Me.AddPlayerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddPlayerToolStripMenuItem.Name = "AddPlayerToolStripMenuItem"
        Me.AddPlayerToolStripMenuItem.Size = New System.Drawing.Size(301, 56)
        Me.AddPlayerToolStripMenuItem.Text = "&Add Player"
        '
        'UpdatePlayerToolStripMenuItem
        '
        Me.UpdatePlayerToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.update
        Me.UpdatePlayerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdatePlayerToolStripMenuItem.Name = "UpdatePlayerToolStripMenuItem"
        Me.UpdatePlayerToolStripMenuItem.Size = New System.Drawing.Size(301, 56)
        Me.UpdatePlayerToolStripMenuItem.Text = "&Update Player"
        '
        'PlayersAgeToolStripMenuItem
        '
        Me.PlayersAgeToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.age
        Me.PlayersAgeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlayersAgeToolStripMenuItem.Name = "PlayersAgeToolStripMenuItem"
        Me.PlayersAgeToolStripMenuItem.Size = New System.Drawing.Size(301, 56)
        Me.PlayersAgeToolStripMenuItem.Text = "&Players Age"
        '
        'UpcomingBrithdaysToolStripMenuItem
        '
        Me.UpcomingBrithdaysToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.upcomingbirthday
        Me.UpcomingBrithdaysToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpcomingBrithdaysToolStripMenuItem.Name = "UpcomingBrithdaysToolStripMenuItem"
        Me.UpcomingBrithdaysToolStripMenuItem.Size = New System.Drawing.Size(301, 56)
        Me.UpcomingBrithdaysToolStripMenuItem.Text = "&Upcoming Brithday's"
        '
        'PlayersStatsToolStripMenuItem
        '
        Me.PlayersStatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllTeamStatsToolStripMenuItem, Me.CompareStatsToolStripMenuItem})
        Me.PlayersStatsToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.playerstats
        Me.PlayersStatsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlayersStatsToolStripMenuItem.Name = "PlayersStatsToolStripMenuItem"
        Me.PlayersStatsToolStripMenuItem.Size = New System.Drawing.Size(301, 56)
        Me.PlayersStatsToolStripMenuItem.Text = "&Players Stats"
        '
        'AllTeamStatsToolStripMenuItem
        '
        Me.AllTeamStatsToolStripMenuItem.Name = "AllTeamStatsToolStripMenuItem"
        Me.AllTeamStatsToolStripMenuItem.Size = New System.Drawing.Size(211, 32)
        Me.AllTeamStatsToolStripMenuItem.Text = "&All Team Stats"
        '
        'CompareStatsToolStripMenuItem
        '
        Me.CompareStatsToolStripMenuItem.Name = "CompareStatsToolStripMenuItem"
        Me.CompareStatsToolStripMenuItem.Size = New System.Drawing.Size(211, 32)
        Me.CompareStatsToolStripMenuItem.Text = "&Compare Stats"
        '
        'RoutionToolStripMenuItem1
        '
        Me.RoutionToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyRoutionCodeToolStripMenuItem, Me.UpdateRoutionToolStripMenuItem})
        Me.RoutionToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoutionToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RoutionToolStripMenuItem1.Name = "RoutionToolStripMenuItem1"
        Me.RoutionToolStripMenuItem1.Size = New System.Drawing.Size(93, 32)
        Me.RoutionToolStripMenuItem1.Text = "Roution"
        Me.RoutionToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MyRoutionCodeToolStripMenuItem
        '
        Me.MyRoutionCodeToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.roution
        Me.MyRoutionCodeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MyRoutionCodeToolStripMenuItem.Name = "MyRoutionCodeToolStripMenuItem"
        Me.MyRoutionCodeToolStripMenuItem.Size = New System.Drawing.Size(271, 56)
        Me.MyRoutionCodeToolStripMenuItem.Text = "&My Roution Code"
        '
        'UpdateRoutionToolStripMenuItem
        '
        Me.UpdateRoutionToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.update
        Me.UpdateRoutionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateRoutionToolStripMenuItem.Name = "UpdateRoutionToolStripMenuItem"
        Me.UpdateRoutionToolStripMenuItem.Size = New System.Drawing.Size(271, 56)
        Me.UpdateRoutionToolStripMenuItem.Text = "&Update Roution"
        '
        'DrillsToolStripMenuItem
        '
        Me.DrillsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WatchDrillsToolStripMenuItem, Me.PlayersDrillsGradesToolStripMenuItem})
        Me.DrillsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrillsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DrillsToolStripMenuItem.Name = "DrillsToolStripMenuItem"
        Me.DrillsToolStripMenuItem.Size = New System.Drawing.Size(68, 32)
        Me.DrillsToolStripMenuItem.Text = "Drills"
        Me.DrillsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'WatchDrillsToolStripMenuItem
        '
        Me.WatchDrillsToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.binoculars
        Me.WatchDrillsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WatchDrillsToolStripMenuItem.Name = "WatchDrillsToolStripMenuItem"
        Me.WatchDrillsToolStripMenuItem.Size = New System.Drawing.Size(290, 56)
        Me.WatchDrillsToolStripMenuItem.Text = "&Watch drills"
        '
        'PlayersDrillsGradesToolStripMenuItem
        '
        Me.PlayersDrillsGradesToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.grade
        Me.PlayersDrillsGradesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlayersDrillsGradesToolStripMenuItem.Name = "PlayersDrillsGradesToolStripMenuItem"
        Me.PlayersDrillsGradesToolStripMenuItem.Size = New System.Drawing.Size(290, 56)
        Me.PlayersDrillsGradesToolStripMenuItem.Text = "&Players drills grades"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllGamesForMyTeamToolStripMenuItem, Me.AllGamesAsHomeTeamToolStripMenuItem, Me.AllGamesAsAwayTeamToolStripMenuItem, Me.AddPlayersGameStatsToolStripMenuItem, Me.GamesVisionToolStripMenuItem})
        Me.GamesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(83, 32)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'AllGamesForMyTeamToolStripMenuItem
        '
        Me.AllGamesForMyTeamToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.leaguegame
        Me.AllGamesForMyTeamToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllGamesForMyTeamToolStripMenuItem.Name = "AllGamesForMyTeamToolStripMenuItem"
        Me.AllGamesForMyTeamToolStripMenuItem.Size = New System.Drawing.Size(324, 56)
        Me.AllGamesForMyTeamToolStripMenuItem.Text = "&AllGamesForMyTeam"
        '
        'AllGamesAsHomeTeamToolStripMenuItem
        '
        Me.AllGamesAsHomeTeamToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.home
        Me.AllGamesAsHomeTeamToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllGamesAsHomeTeamToolStripMenuItem.Name = "AllGamesAsHomeTeamToolStripMenuItem"
        Me.AllGamesAsHomeTeamToolStripMenuItem.Size = New System.Drawing.Size(324, 56)
        Me.AllGamesAsHomeTeamToolStripMenuItem.Text = "&AllGamesAsHomeTeam"
        '
        'AllGamesAsAwayTeamToolStripMenuItem
        '
        Me.AllGamesAsAwayTeamToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.away
        Me.AllGamesAsAwayTeamToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllGamesAsAwayTeamToolStripMenuItem.Name = "AllGamesAsAwayTeamToolStripMenuItem"
        Me.AllGamesAsAwayTeamToolStripMenuItem.Size = New System.Drawing.Size(324, 56)
        Me.AllGamesAsAwayTeamToolStripMenuItem.Text = "&AllGamesAsAwayTeam"
        '
        'AddPlayersGameStatsToolStripMenuItem
        '
        Me.AddPlayersGameStatsToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.addstats
        Me.AddPlayersGameStatsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddPlayersGameStatsToolStripMenuItem.Name = "AddPlayersGameStatsToolStripMenuItem"
        Me.AddPlayersGameStatsToolStripMenuItem.Size = New System.Drawing.Size(324, 56)
        Me.AddPlayersGameStatsToolStripMenuItem.Text = "&Add Players Game Stats"
        Me.AddPlayersGameStatsToolStripMenuItem.Visible = False
        '
        'GamesVisionToolStripMenuItem
        '
        Me.GamesVisionToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.vision
        Me.GamesVisionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GamesVisionToolStripMenuItem.Name = "GamesVisionToolStripMenuItem"
        Me.GamesVisionToolStripMenuItem.Size = New System.Drawing.Size(324, 56)
        Me.GamesVisionToolStripMenuItem.Text = "&Games Vision"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllLeaguePlayersToolStripMenuItem, Me.AllLeagueTeamsToolStripMenuItem, Me.AllLeagueGamesToolStripMenuItem, Me.LeagueLeadersToolStripMenuItem, Me.TrackPlayersToolStripMenuItem})
        Me.OrderToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.OrderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(82, 32)
        Me.OrderToolStripMenuItem.Text = "Others"
        Me.OrderToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AllLeaguePlayersToolStripMenuItem
        '
        Me.AllLeaguePlayersToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.myteam
        Me.AllLeaguePlayersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllLeaguePlayersToolStripMenuItem.Name = "AllLeaguePlayersToolStripMenuItem"
        Me.AllLeaguePlayersToolStripMenuItem.Size = New System.Drawing.Size(274, 56)
        Me.AllLeaguePlayersToolStripMenuItem.Text = "&All League Players"
        '
        'AllLeagueTeamsToolStripMenuItem
        '
        Me.AllLeagueTeamsToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.leagueteam
        Me.AllLeagueTeamsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllLeagueTeamsToolStripMenuItem.Name = "AllLeagueTeamsToolStripMenuItem"
        Me.AllLeagueTeamsToolStripMenuItem.Size = New System.Drawing.Size(274, 56)
        Me.AllLeagueTeamsToolStripMenuItem.Text = "&All League Teams"
        '
        'AllLeagueGamesToolStripMenuItem
        '
        Me.AllLeagueGamesToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.leaguegame
        Me.AllLeagueGamesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AllLeagueGamesToolStripMenuItem.Name = "AllLeagueGamesToolStripMenuItem"
        Me.AllLeagueGamesToolStripMenuItem.Size = New System.Drawing.Size(274, 56)
        Me.AllLeagueGamesToolStripMenuItem.Text = "&All League Games"
        '
        'LeagueLeadersToolStripMenuItem
        '
        Me.LeagueLeadersToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.rank
        Me.LeagueLeadersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LeagueLeadersToolStripMenuItem.Name = "LeagueLeadersToolStripMenuItem"
        Me.LeagueLeadersToolStripMenuItem.Size = New System.Drawing.Size(274, 56)
        Me.LeagueLeadersToolStripMenuItem.Text = "&League Leaders"
        '
        'TrackPlayersToolStripMenuItem
        '
        Me.TrackPlayersToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.track
        Me.TrackPlayersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TrackPlayersToolStripMenuItem.Name = "TrackPlayersToolStripMenuItem"
        Me.TrackPlayersToolStripMenuItem.Size = New System.Drawing.Size(274, 56)
        Me.TrackPlayersToolStripMenuItem.Text = "&Tracking Players"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayersToolStripMenuItem1, Me.RoutionToolStripMenuItem1, Me.DrillsToolStripMenuItem, Me.GamesToolStripMenuItem, Me.OrderToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1442, 36)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Lbl_CheckGameDate
        '
        Me.Lbl_CheckGameDate.AutoSize = True
        Me.Lbl_CheckGameDate.BackColor = System.Drawing.Color.Silver
        Me.Lbl_CheckGameDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_CheckGameDate.Location = New System.Drawing.Point(800, 9)
        Me.Lbl_CheckGameDate.Name = "Lbl_CheckGameDate"
        Me.Lbl_CheckGameDate.Size = New System.Drawing.Size(104, 20)
        Me.Lbl_CheckGameDate.TabIndex = 13
        Me.Lbl_CheckGameDate.Text = "Game Date"
        Me.Lbl_CheckGameDate.Visible = False
        '
        'Pic_Logout
        '
        Me.Pic_Logout.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Logout.Image = Global.BasicBasketballSql.My.Resources.Resources.logout
        Me.Pic_Logout.Location = New System.Drawing.Point(1199, 39)
        Me.Pic_Logout.Name = "Pic_Logout"
        Me.Pic_Logout.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Logout.TabIndex = 21
        Me.Pic_Logout.TabStop = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpMeToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HelpMeToolStripMenuItem
        '
        Me.HelpMeToolStripMenuItem.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.HelpMeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpMeToolStripMenuItem.Name = "HelpMeToolStripMenuItem"
        Me.HelpMeToolStripMenuItem.Size = New System.Drawing.Size(191, 56)
        Me.HelpMeToolStripMenuItem.Text = "&Help me"
        '
        'ManagersMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1442, 749)
        Me.Controls.Add(Me.Pic_Logout)
        Me.Controls.Add(Me.Lbl_CheckGameDate)
        Me.Controls.Add(Me.Btn_Refresh)
        Me.Controls.Add(Me.Lbl_ManagerCheck)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_AutoClick)
        Me.Controls.Add(Me.Lbl_TableName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ManagersMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Managers Main Menu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Pic_Logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_TableName As System.Windows.Forms.Label
    Friend WithEvents Btn_AutoClick As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TimerAutoClick As System.Windows.Forms.Timer
    Friend WithEvents Lbl_ManagerCheck As System.Windows.Forms.Label
    Friend WithEvents Btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents PlayersToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatePlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpcomingBrithdaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoutionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrillsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllGamesForMyTeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllGamesAsHomeTeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllGamesAsAwayTeamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllLeaguePlayersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllLeagueTeamsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllLeagueGamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlayersAgeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPlayersGameStatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Lbl_CheckGameDate As System.Windows.Forms.Label
    Friend WithEvents PlayersStatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllTeamStatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompareStatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GamesVisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WatchDrillsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayersDrillsGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeagueLeadersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrackPlayersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyRoutionCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRoutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pic_Logout As System.Windows.Forms.PictureBox
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
