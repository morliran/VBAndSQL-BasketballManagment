<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add teams")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update teams")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage teams", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add players")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update players")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delete players")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage players", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add games")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update games")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add game stats")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage games", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League leaders")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League changes")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage league", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Admin main", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode7, TreeNode11, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add player")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update player")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Player age")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Upcoming birthday")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Player stats")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Players", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Roution code")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update roution")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Roution", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Watch drill")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drill grades")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drills", New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My team games")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My home games")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My away games")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add player game stats")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game vision")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Games", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32})
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League players")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League teams")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League games")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League leaders")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tracking players")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Others", New System.Windows.Forms.TreeNode() {TreeNode34, TreeNode35, TreeNode36, TreeNode37, TreeNode38})
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manager main", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode24, TreeNode27, TreeNode33, TreeNode39})
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest queries")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League leaders")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Build query")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest main", New System.Windows.Forms.TreeNode() {TreeNode41, TreeNode42, TreeNode43})
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Help menu", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode40, TreeNode44})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.TreeV_Help = New System.Windows.Forms.TreeView()
        Me.RTB_TeamAUDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_PlayerAUDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_PlayerDeleteD = New System.Windows.Forms.RichTextBox()
        Me.RTB_AgeBirthDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_GameAUDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_AddStatsDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_LeadersDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_LeagueChangeDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_PlayerStatsDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_RoutionDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_OtherManaDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_DrillsDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_VisionDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_TrackDetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_QuestODetails = New System.Windows.Forms.RichTextBox()
        Me.RTB_Temp = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'TreeV_Help
        '
        Me.TreeV_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeV_Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TreeV_Help.Location = New System.Drawing.Point(12, 3)
        Me.TreeV_Help.Name = "TreeV_Help"
        TreeNode1.Name = "Node_AddTeam"
        TreeNode1.Text = "Add teams"
        TreeNode2.Name = "Node_UpdateTeam"
        TreeNode2.Text = "Update teams"
        TreeNode3.Name = "Node_AdminTeams"
        TreeNode3.Text = "Manage teams"
        TreeNode4.Name = "Node_AdmAddP"
        TreeNode4.Text = "Add players"
        TreeNode5.Name = "Node_AdmUpdateP"
        TreeNode5.Text = "Update players"
        TreeNode6.Name = "Node_AdmDeleteP"
        TreeNode6.Text = "Delete players"
        TreeNode7.Name = "Node_AdminPlayers"
        TreeNode7.Text = "Manage players"
        TreeNode8.Name = "Node_AddGame"
        TreeNode8.Text = "Add games"
        TreeNode9.Name = "Node_UpdateGame"
        TreeNode9.Text = "Update games"
        TreeNode10.Name = "Node_AdminAddStats"
        TreeNode10.Text = "Add game stats"
        TreeNode11.Name = "Node_AdminGames"
        TreeNode11.Text = "Manage games"
        TreeNode12.Name = "Node_AdmLeagueL"
        TreeNode12.Text = "League leaders"
        TreeNode13.Name = "Node_LeagueChange"
        TreeNode13.Text = "League changes"
        TreeNode14.Name = "Node_AdminLeague"
        TreeNode14.Text = "Manage league"
        TreeNode15.Name = "Node_Admin"
        TreeNode15.Text = "Admin main"
        TreeNode16.Name = "Node_AddP"
        TreeNode16.Text = "Add player"
        TreeNode17.Name = "Node_UpdateP"
        TreeNode17.Text = "Update player"
        TreeNode18.Name = "Node_Age"
        TreeNode18.Text = "Player age"
        TreeNode19.Name = "Node_UpcomeBirth"
        TreeNode19.Text = "Upcoming birthday"
        TreeNode20.Name = "Node_StatsP"
        TreeNode20.Text = "Player stats"
        TreeNode21.Name = "Node_Players"
        TreeNode21.Text = "Players"
        TreeNode22.Name = "Node_RoutionCode"
        TreeNode22.Text = "Roution code"
        TreeNode23.Name = "Node_UpdateR"
        TreeNode23.Text = "Update roution"
        TreeNode24.Name = "Node_Roution"
        TreeNode24.Text = "Roution"
        TreeNode25.Name = "Node_WatchD"
        TreeNode25.Text = "Watch drill"
        TreeNode26.Name = "Node_GradeD"
        TreeNode26.Text = "Drill grades"
        TreeNode27.Name = "Node_Drill"
        TreeNode27.Text = "Drills"
        TreeNode28.Name = "Node_MyTeamG"
        TreeNode28.Text = "My team games"
        TreeNode29.Name = "Node_HomeG"
        TreeNode29.Text = "My home games"
        TreeNode30.Name = "Node_AwayG"
        TreeNode30.Text = "My away games"
        TreeNode31.Name = "Node_PGStats"
        TreeNode31.Text = "Add player game stats"
        TreeNode32.Name = "Node_VisionG"
        TreeNode32.Text = "Game vision"
        TreeNode33.Name = "Node_Games"
        TreeNode33.Text = "Games"
        TreeNode34.Name = "Node_LeagueP"
        TreeNode34.Text = "League players"
        TreeNode35.Name = "Node_LeagueT"
        TreeNode35.Text = "League teams"
        TreeNode36.Name = "Node_LeagueG"
        TreeNode36.Text = "League games"
        TreeNode37.Name = "Node_LeagueL"
        TreeNode37.Text = "League leaders"
        TreeNode38.Name = "Node_TrackP"
        TreeNode38.Text = "Tracking players"
        TreeNode39.Name = "Node_Others"
        TreeNode39.Text = "Others"
        TreeNode40.Name = "Node_Manager"
        TreeNode40.Text = "Manager main"
        TreeNode41.Name = "Node_GuestQ"
        TreeNode41.Text = "Guest queries"
        TreeNode42.Name = "Node_GuestLeagueL"
        TreeNode42.Text = "League leaders"
        TreeNode43.Name = "Node_BuildQuery"
        TreeNode43.Text = "Build query"
        TreeNode44.Name = "Node_Guest"
        TreeNode44.Text = "Guest main"
        TreeNode45.Name = "Node_Help"
        TreeNode45.Text = "Help menu"
        Me.TreeV_Help.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode45})
        Me.TreeV_Help.Size = New System.Drawing.Size(462, 666)
        Me.TreeV_Help.TabIndex = 0
        '
        'RTB_TeamAUDetails
        '
        Me.RTB_TeamAUDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_TeamAUDetails.Enabled = False
        Me.RTB_TeamAUDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_TeamAUDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_TeamAUDetails.Name = "RTB_TeamAUDetails"
        Me.RTB_TeamAUDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_TeamAUDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_TeamAUDetails.TabIndex = 1
        Me.RTB_TeamAUDetails.Text = resources.GetString("RTB_TeamAUDetails.Text")
        '
        'RTB_PlayerAUDetails
        '
        Me.RTB_PlayerAUDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_PlayerAUDetails.Enabled = False
        Me.RTB_PlayerAUDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_PlayerAUDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_PlayerAUDetails.Name = "RTB_PlayerAUDetails"
        Me.RTB_PlayerAUDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_PlayerAUDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_PlayerAUDetails.TabIndex = 2
        Me.RTB_PlayerAUDetails.Text = resources.GetString("RTB_PlayerAUDetails.Text")
        '
        'RTB_PlayerDeleteD
        '
        Me.RTB_PlayerDeleteD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_PlayerDeleteD.Enabled = False
        Me.RTB_PlayerDeleteD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_PlayerDeleteD.Location = New System.Drawing.Point(593, 3)
        Me.RTB_PlayerDeleteD.Name = "RTB_PlayerDeleteD"
        Me.RTB_PlayerDeleteD.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_PlayerDeleteD.Size = New System.Drawing.Size(419, 666)
        Me.RTB_PlayerDeleteD.TabIndex = 3
        Me.RTB_PlayerDeleteD.Text = resources.GetString("RTB_PlayerDeleteD.Text")
        '
        'RTB_AgeBirthDetails
        '
        Me.RTB_AgeBirthDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_AgeBirthDetails.Enabled = False
        Me.RTB_AgeBirthDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_AgeBirthDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_AgeBirthDetails.Name = "RTB_AgeBirthDetails"
        Me.RTB_AgeBirthDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_AgeBirthDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_AgeBirthDetails.TabIndex = 4
        Me.RTB_AgeBirthDetails.Text = resources.GetString("RTB_AgeBirthDetails.Text")
        '
        'RTB_GameAUDetails
        '
        Me.RTB_GameAUDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_GameAUDetails.Enabled = False
        Me.RTB_GameAUDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_GameAUDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_GameAUDetails.Name = "RTB_GameAUDetails"
        Me.RTB_GameAUDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_GameAUDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_GameAUDetails.TabIndex = 5
        Me.RTB_GameAUDetails.Text = resources.GetString("RTB_GameAUDetails.Text")
        '
        'RTB_AddStatsDetails
        '
        Me.RTB_AddStatsDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_AddStatsDetails.Enabled = False
        Me.RTB_AddStatsDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_AddStatsDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_AddStatsDetails.Name = "RTB_AddStatsDetails"
        Me.RTB_AddStatsDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_AddStatsDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_AddStatsDetails.TabIndex = 6
        Me.RTB_AddStatsDetails.Text = resources.GetString("RTB_AddStatsDetails.Text")
        '
        'RTB_LeadersDetails
        '
        Me.RTB_LeadersDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_LeadersDetails.Enabled = False
        Me.RTB_LeadersDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_LeadersDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_LeadersDetails.Name = "RTB_LeadersDetails"
        Me.RTB_LeadersDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_LeadersDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_LeadersDetails.TabIndex = 7
        Me.RTB_LeadersDetails.Text = "If you click on this option you will see top 5 players and top 12 teams in each r" & _
    "anking category:" & Global.Microsoft.VisualBasic.ChrW(10) & "Points, Assists, Rebounds, Steels, Blocks." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RTB_LeagueChangeDetails
        '
        Me.RTB_LeagueChangeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_LeagueChangeDetails.Enabled = False
        Me.RTB_LeagueChangeDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_LeagueChangeDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_LeagueChangeDetails.Name = "RTB_LeagueChangeDetails"
        Me.RTB_LeagueChangeDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_LeagueChangeDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_LeagueChangeDetails.TabIndex = 8
        Me.RTB_LeagueChangeDetails.Text = "If you click on this option you will see all the managers changes to some databas" & _
    "e tables." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RTB_PlayerStatsDetails
        '
        Me.RTB_PlayerStatsDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_PlayerStatsDetails.Enabled = False
        Me.RTB_PlayerStatsDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_PlayerStatsDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_PlayerStatsDetails.Name = "RTB_PlayerStatsDetails"
        Me.RTB_PlayerStatsDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_PlayerStatsDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_PlayerStatsDetails.TabIndex = 9
        Me.RTB_PlayerStatsDetails.Text = "If you click on this option you can see all your player game stats." & Global.Microsoft.VisualBasic.ChrW(10) & "And also coma" & _
    "pre there stats with other team player or with them self."
        '
        'RTB_RoutionDetails
        '
        Me.RTB_RoutionDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_RoutionDetails.Enabled = False
        Me.RTB_RoutionDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_RoutionDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_RoutionDetails.Name = "RTB_RoutionDetails"
        Me.RTB_RoutionDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_RoutionDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_RoutionDetails.TabIndex = 10
        Me.RTB_RoutionDetails.Text = "If you click on this option you can see all your player roution code." & Global.Microsoft.VisualBasic.ChrW(10) & "And also up" & _
    "date them by change player roution code by other one."
        '
        'RTB_OtherManaDetails
        '
        Me.RTB_OtherManaDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_OtherManaDetails.Enabled = False
        Me.RTB_OtherManaDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_OtherManaDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_OtherManaDetails.Name = "RTB_OtherManaDetails"
        Me.RTB_OtherManaDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_OtherManaDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_OtherManaDetails.TabIndex = 11
        Me.RTB_OtherManaDetails.Text = resources.GetString("RTB_OtherManaDetails.Text")
        '
        'RTB_DrillsDetails
        '
        Me.RTB_DrillsDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_DrillsDetails.Enabled = False
        Me.RTB_DrillsDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_DrillsDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_DrillsDetails.Name = "RTB_DrillsDetails"
        Me.RTB_DrillsDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_DrillsDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_DrillsDetails.TabIndex = 12
        Me.RTB_DrillsDetails.Text = resources.GetString("RTB_DrillsDetails.Text")
        '
        'RTB_VisionDetails
        '
        Me.RTB_VisionDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_VisionDetails.Enabled = False
        Me.RTB_VisionDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_VisionDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_VisionDetails.Name = "RTB_VisionDetails"
        Me.RTB_VisionDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_VisionDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_VisionDetails.TabIndex = 13
        Me.RTB_VisionDetails.Text = resources.GetString("RTB_VisionDetails.Text")
        '
        'RTB_TrackDetails
        '
        Me.RTB_TrackDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_TrackDetails.Enabled = False
        Me.RTB_TrackDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_TrackDetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_TrackDetails.Name = "RTB_TrackDetails"
        Me.RTB_TrackDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_TrackDetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_TrackDetails.TabIndex = 14
        Me.RTB_TrackDetails.Text = resources.GetString("RTB_TrackDetails.Text")
        '
        'RTB_QuestODetails
        '
        Me.RTB_QuestODetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_QuestODetails.Enabled = False
        Me.RTB_QuestODetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_QuestODetails.Location = New System.Drawing.Point(593, 3)
        Me.RTB_QuestODetails.Name = "RTB_QuestODetails"
        Me.RTB_QuestODetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_QuestODetails.Size = New System.Drawing.Size(419, 666)
        Me.RTB_QuestODetails.TabIndex = 15
        Me.RTB_QuestODetails.Text = resources.GetString("RTB_QuestODetails.Text")
        '
        'RTB_Temp
        '
        Me.RTB_Temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RTB_Temp.Enabled = False
        Me.RTB_Temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.RTB_Temp.Location = New System.Drawing.Point(593, 3)
        Me.RTB_Temp.Name = "RTB_Temp"
        Me.RTB_Temp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_Temp.Size = New System.Drawing.Size(419, 666)
        Me.RTB_Temp.TabIndex = 16
        Me.RTB_Temp.Text = ""
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 681)
        Me.Controls.Add(Me.RTB_Temp)
        Me.Controls.Add(Me.RTB_QuestODetails)
        Me.Controls.Add(Me.RTB_TrackDetails)
        Me.Controls.Add(Me.RTB_VisionDetails)
        Me.Controls.Add(Me.RTB_DrillsDetails)
        Me.Controls.Add(Me.RTB_OtherManaDetails)
        Me.Controls.Add(Me.RTB_RoutionDetails)
        Me.Controls.Add(Me.RTB_PlayerStatsDetails)
        Me.Controls.Add(Me.RTB_LeagueChangeDetails)
        Me.Controls.Add(Me.RTB_LeadersDetails)
        Me.Controls.Add(Me.RTB_AddStatsDetails)
        Me.Controls.Add(Me.RTB_GameAUDetails)
        Me.Controls.Add(Me.RTB_AgeBirthDetails)
        Me.Controls.Add(Me.RTB_PlayerDeleteD)
        Me.Controls.Add(Me.RTB_PlayerAUDetails)
        Me.Controls.Add(Me.RTB_TeamAUDetails)
        Me.Controls.Add(Me.TreeV_Help)
        Me.Name = "HelpForm"
        Me.Text = "HelpForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeV_Help As System.Windows.Forms.TreeView
    Friend WithEvents RTB_TeamAUDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_PlayerAUDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_PlayerDeleteD As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_AgeBirthDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_GameAUDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_AddStatsDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_LeadersDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_LeagueChangeDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_PlayerStatsDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_RoutionDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_OtherManaDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_DrillsDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_VisionDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_TrackDetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_QuestODetails As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_Temp As System.Windows.Forms.RichTextBox
End Class
