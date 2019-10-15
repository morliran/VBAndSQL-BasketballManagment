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
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת קבוצה")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון קבוצה")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול קבוצות", New System.Windows.Forms.TreeNode() {TreeNode46, TreeNode47})
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת שחקן לקבוצה")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון שחקן קיים")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מחיקת שחקן")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול שחקנים", New System.Windows.Forms.TreeNode() {TreeNode49, TreeNode50, TreeNode51})
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת משחק")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון משחק קיים")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת סטטיסטיקת משחק")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול משחקים", New System.Windows.Forms.TreeNode() {TreeNode53, TreeNode54, TreeNode55})
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מובילי הליגה")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("שינויים שנעשו בליגה")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול הליגה", New System.Windows.Forms.TreeNode() {TreeNode57, TreeNode58})
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מנהלי ליגה", New System.Windows.Forms.TreeNode() {TreeNode48, TreeNode52, TreeNode56, TreeNode59})
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת שחקן לקבוצה")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון שחקן קיים")
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("גילאי השחקנים")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ימי הולדת קרובים")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("השוואת סטטיסטיקות")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("שחקנים", New System.Windows.Forms.TreeNode() {TreeNode61, TreeNode62, TreeNode63, TreeNode64, TreeNode65})
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל קודי הרוטציה")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון רוטציה")
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("רוטציות", New System.Windows.Forms.TreeNode() {TreeNode67, TreeNode68})
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מעקב אחר תרגיל")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ציוני תרגילים לשחקנים")
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("תרגילים", New System.Windows.Forms.TreeNode() {TreeNode70, TreeNode71})
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקי הקבוצה שלי")
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקי הבית שלי")
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקי החוץ שלי")
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת סטיסטיקת משחק")
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("חיזוי תוצאת משחק")
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקים", New System.Windows.Forms.TreeNode() {TreeNode73, TreeNode74, TreeNode75, TreeNode76, TreeNode77})
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל שחקני הליגה")
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל קבוצות הליגה")
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל משחקי הליגה")
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מובילי הליגה")
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מעקב אחר שחקנים")
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מידע אחר", New System.Windows.Forms.TreeNode() {TreeNode79, TreeNode80, TreeNode81, TreeNode82, TreeNode83})
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מנהלי קבוצות", New System.Windows.Forms.TreeNode() {TreeNode66, TreeNode69, TreeNode72, TreeNode78, TreeNode84})
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("שאילתות אורחים")
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מובילי הליגה")
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("חיפוש מידע")
        Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("אורחים", New System.Windows.Forms.TreeNode() {TreeNode86, TreeNode87, TreeNode88})
        Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("תפריט עזר", New System.Windows.Forms.TreeNode() {TreeNode60, TreeNode85, TreeNode89})
        Me.TreeV_HelpEng = New System.Windows.Forms.TreeView()
        Me.RTB_TempEng = New System.Windows.Forms.RichTextBox()
        Me.Tb_SearchEng = New System.Windows.Forms.TextBox()
        Me.Tb_SearchHeb = New System.Windows.Forms.TextBox()
        Me.TreeV_HelpHeb = New System.Windows.Forms.TreeView()
        Me.RTB_TempHeb = New System.Windows.Forms.RichTextBox()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.Panel_Right.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeV_HelpEng
        '
        Me.TreeV_HelpEng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeV_HelpEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TreeV_HelpEng.Location = New System.Drawing.Point(12, 66)
        Me.TreeV_HelpEng.Name = "TreeV_HelpEng"
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
        TreeNode12.Name = "Node_AdminLeagueL"
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
        Me.TreeV_HelpEng.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode45})
        Me.TreeV_HelpEng.Size = New System.Drawing.Size(462, 379)
        Me.TreeV_HelpEng.TabIndex = 0
        '
        'RTB_TempEng
        '
        Me.RTB_TempEng.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_TempEng.Font = New System.Drawing.Font("Narkisim", 16.0!)
        Me.RTB_TempEng.Location = New System.Drawing.Point(0, 43)
        Me.RTB_TempEng.Name = "RTB_TempEng"
        Me.RTB_TempEng.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_TempEng.Size = New System.Drawing.Size(697, 667)
        Me.RTB_TempEng.TabIndex = 2
        Me.RTB_TempEng.Text = ""
        '
        'Tb_SearchEng
        '
        Me.Tb_SearchEng.AutoCompleteCustomSource.AddRange(New String() {"Manage teams", "Manage players", "Manage games", "Manage league", "Players", "Roution", "Drills", "Games", "Game stats", "Compare stats", "Vision", "Tracking players", "Others", "Guest queries", "League leaders", "Build query", "Search information"})
        Me.Tb_SearchEng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tb_SearchEng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Tb_SearchEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_SearchEng.Location = New System.Drawing.Point(12, 12)
        Me.Tb_SearchEng.Name = "Tb_SearchEng"
        Me.Tb_SearchEng.Size = New System.Drawing.Size(462, 30)
        Me.Tb_SearchEng.TabIndex = 1
        Me.Tb_SearchEng.Tag = "2"
        Me.Tb_SearchEng.Text = "Search..."
        '
        'Tb_SearchHeb
        '
        Me.Tb_SearchHeb.AutoCompleteCustomSource.AddRange(New String() {"ניהול קבוצות", "ניהול שחקנים", "ניהול משחקים", "ניהול ליגה", "שחקנים", "רוטציות", "תרגילים", "משחקים", "סטטיסטיקות משחק", "השוואת סטטיסטיקות", "חיזוי", "מעקב שחקנים", "אחר", "מובילי הליגה", "חיפוש מידע"})
        Me.Tb_SearchHeb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tb_SearchHeb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Tb_SearchHeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_SearchHeb.Location = New System.Drawing.Point(236, 12)
        Me.Tb_SearchHeb.Name = "Tb_SearchHeb"
        Me.Tb_SearchHeb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tb_SearchHeb.Size = New System.Drawing.Size(462, 30)
        Me.Tb_SearchHeb.TabIndex = 4
        Me.Tb_SearchHeb.Tag = "2"
        Me.Tb_SearchHeb.Text = "חפש..."
        Me.Tb_SearchHeb.Visible = False
        '
        'TreeV_HelpHeb
        '
        Me.TreeV_HelpHeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeV_HelpHeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TreeV_HelpHeb.Location = New System.Drawing.Point(946, 66)
        Me.TreeV_HelpHeb.Name = "TreeV_HelpHeb"
        TreeNode46.Name = "Node_AddTeam"
        TreeNode46.Text = "הוספת קבוצה"
        TreeNode47.Name = "Node_UpdateTeam"
        TreeNode47.Text = "עדכון קבוצה"
        TreeNode48.Name = "Node_AdminTeams"
        TreeNode48.Text = "ניהול קבוצות"
        TreeNode49.Name = "Node_AdmAddP"
        TreeNode49.Text = "הוספת שחקן לקבוצה"
        TreeNode50.Name = "Node_AdmUpdateP"
        TreeNode50.Text = "עדכון שחקן קיים"
        TreeNode51.Name = "Node_AdmDeleteP"
        TreeNode51.Text = "מחיקת שחקן"
        TreeNode52.Name = "Node_AdminPlayers"
        TreeNode52.Text = "ניהול שחקנים"
        TreeNode53.Name = "Node_AddGame"
        TreeNode53.Text = "הוספת משחק"
        TreeNode54.Name = "Node_UpdateGame"
        TreeNode54.Text = "עדכון משחק קיים"
        TreeNode55.Name = "Node_AdminAddStats"
        TreeNode55.Text = "הוספת סטטיסטיקת משחק"
        TreeNode56.Name = "Node_AdminGames"
        TreeNode56.Text = "ניהול משחקים"
        TreeNode57.Name = "Node_AdminLeagueL"
        TreeNode57.Text = "מובילי הליגה"
        TreeNode58.Name = "Node_LeagueChange"
        TreeNode58.Text = "שינויים שנעשו בליגה"
        TreeNode59.Name = "Node_AdminLeague"
        TreeNode59.Text = "ניהול הליגה"
        TreeNode60.Name = "Node_Admin"
        TreeNode60.Text = "מנהלי ליגה"
        TreeNode61.Name = "Node_AddP"
        TreeNode61.Text = "הוספת שחקן לקבוצה"
        TreeNode62.Name = "Node_UpdateP"
        TreeNode62.Text = "עדכון שחקן קיים"
        TreeNode63.Name = "Node_Age"
        TreeNode63.Text = "גילאי השחקנים"
        TreeNode64.Name = "Node_UpcomeBirth"
        TreeNode64.Text = "ימי הולדת קרובים"
        TreeNode65.Name = "Node_StatsP"
        TreeNode65.Text = "השוואת סטטיסטיקות"
        TreeNode66.Name = "Node_Players"
        TreeNode66.Text = "שחקנים"
        TreeNode67.Name = "Node_RoutionCode"
        TreeNode67.Text = "כל קודי הרוטציה"
        TreeNode68.Name = "Node_UpdateR"
        TreeNode68.Text = "עדכון רוטציה"
        TreeNode69.Name = "Node_Roution"
        TreeNode69.Text = "רוטציות"
        TreeNode70.Name = "Node_WatchD"
        TreeNode70.Text = "מעקב אחר תרגיל"
        TreeNode71.Name = "Node_GradeD"
        TreeNode71.Text = "ציוני תרגילים לשחקנים"
        TreeNode72.Name = "Node_Drill"
        TreeNode72.Text = "תרגילים"
        TreeNode73.Name = "Node_MyTeamG"
        TreeNode73.Text = "משחקי הקבוצה שלי"
        TreeNode74.Name = "Node_HomeG"
        TreeNode74.Text = "משחקי הבית שלי"
        TreeNode75.Name = "Node_AwayG"
        TreeNode75.Text = "משחקי החוץ שלי"
        TreeNode76.Name = "Node_PGStats"
        TreeNode76.Text = "הוספת סטיסטיקת משחק"
        TreeNode77.Name = "Node_VisionG"
        TreeNode77.Text = "חיזוי תוצאת משחק"
        TreeNode78.Name = "Node_Games"
        TreeNode78.Text = "משחקים"
        TreeNode79.Name = "Node_LeagueP"
        TreeNode79.Text = "כל שחקני הליגה"
        TreeNode80.Name = "Node_LeagueT"
        TreeNode80.Text = "כל קבוצות הליגה"
        TreeNode81.Name = "Node_LeagueG"
        TreeNode81.Text = "כל משחקי הליגה"
        TreeNode82.Name = "Node_LeagueL"
        TreeNode82.Text = "מובילי הליגה"
        TreeNode83.Name = "Node_TrackP"
        TreeNode83.Text = "מעקב אחר שחקנים"
        TreeNode84.Name = "Node_Others"
        TreeNode84.Text = "מידע אחר"
        TreeNode85.Name = "Node_Manager"
        TreeNode85.Text = "מנהלי קבוצות"
        TreeNode86.Name = "Node_GuestQ"
        TreeNode86.Text = "שאילתות אורחים"
        TreeNode87.Name = "Node_GuestLeagueL"
        TreeNode87.Text = "מובילי הליגה"
        TreeNode88.Name = "Node_BuildQuery"
        TreeNode88.Text = "חיפוש מידע"
        TreeNode89.Name = "Node_Guest"
        TreeNode89.Text = "אורחים"
        TreeNode90.Name = "Node_Help"
        TreeNode90.Text = "תפריט עזר"
        Me.TreeV_HelpHeb.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode90})
        Me.TreeV_HelpHeb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TreeV_HelpHeb.RightToLeftLayout = True
        Me.TreeV_HelpHeb.Size = New System.Drawing.Size(462, 379)
        Me.TreeV_HelpHeb.TabIndex = 3
        Me.TreeV_HelpHeb.Visible = False
        '
        'RTB_TempHeb
        '
        Me.RTB_TempHeb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_TempHeb.Font = New System.Drawing.Font("Narkisim", 16.0!)
        Me.RTB_TempHeb.Location = New System.Drawing.Point(8, 45)
        Me.RTB_TempHeb.Name = "RTB_TempHeb"
        Me.RTB_TempHeb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RTB_TempHeb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RTB_TempHeb.Size = New System.Drawing.Size(697, 667)
        Me.RTB_TempHeb.TabIndex = 5
        Me.RTB_TempHeb.Text = ""
        Me.RTB_TempHeb.Visible = False
        '
        'Panel_Right
        '
        Me.Panel_Right.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Right.Controls.Add(Me.Tb_SearchHeb)
        Me.Panel_Right.Controls.Add(Me.RTB_TempEng)
        Me.Panel_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Right.Location = New System.Drawing.Point(710, 0)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(710, 724)
        Me.Panel_Right.TabIndex = 6
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(710, 724)
        Me.Panel_Left.TabIndex = 7
        '
        'HelpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1420, 724)
        Me.Controls.Add(Me.TreeV_HelpHeb)
        Me.Controls.Add(Me.Tb_SearchEng)
        Me.Controls.Add(Me.TreeV_HelpEng)
        Me.Controls.Add(Me.RTB_TempHeb)
        Me.Controls.Add(Me.Panel_Right)
        Me.Controls.Add(Me.Panel_Left)
        Me.Name = "HelpForm"
        Me.Text = "HelpForm"
        Me.Panel_Right.ResumeLayout(False)
        Me.Panel_Right.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeV_HelpEng As System.Windows.Forms.TreeView
    Friend WithEvents RTB_TempEng As System.Windows.Forms.RichTextBox
    Friend WithEvents Tb_SearchEng As System.Windows.Forms.TextBox
    Friend WithEvents Tb_SearchHeb As System.Windows.Forms.TextBox
    Friend WithEvents TreeV_HelpHeb As System.Windows.Forms.TreeView
    Friend WithEvents RTB_TempHeb As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel_Right As System.Windows.Forms.Panel
    Friend WithEvents Panel_Left As System.Windows.Forms.Panel
End Class
