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
        Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add teams")
        Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update teams")
        Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage teams", New System.Windows.Forms.TreeNode() {TreeNode91, TreeNode92})
        Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add players")
        Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update players")
        Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delete players")
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage players", New System.Windows.Forms.TreeNode() {TreeNode94, TreeNode95, TreeNode96})
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add games")
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update games")
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add game stats")
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage games", New System.Windows.Forms.TreeNode() {TreeNode98, TreeNode99, TreeNode100})
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League leaders")
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League changes")
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage league", New System.Windows.Forms.TreeNode() {TreeNode102, TreeNode103})
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Admin main", New System.Windows.Forms.TreeNode() {TreeNode93, TreeNode97, TreeNode101, TreeNode104})
        Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add player")
        Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update player")
        Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Player age")
        Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Upcoming birthday")
        Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Player stats")
        Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Players", New System.Windows.Forms.TreeNode() {TreeNode106, TreeNode107, TreeNode108, TreeNode109, TreeNode110})
        Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Roution code")
        Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update roution")
        Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Roution", New System.Windows.Forms.TreeNode() {TreeNode112, TreeNode113})
        Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Watch drill")
        Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drill grades")
        Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drills", New System.Windows.Forms.TreeNode() {TreeNode115, TreeNode116})
        Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My team games")
        Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My home games")
        Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("My away games")
        Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add player game stats")
        Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Game vision")
        Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Games", New System.Windows.Forms.TreeNode() {TreeNode118, TreeNode119, TreeNode120, TreeNode121, TreeNode122})
        Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League players")
        Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League teams")
        Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League games")
        Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League leaders")
        Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tracking players")
        Dim TreeNode129 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Others", New System.Windows.Forms.TreeNode() {TreeNode124, TreeNode125, TreeNode126, TreeNode127, TreeNode128})
        Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manager main", New System.Windows.Forms.TreeNode() {TreeNode111, TreeNode114, TreeNode117, TreeNode123, TreeNode129})
        Dim TreeNode131 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest queries")
        Dim TreeNode132 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("League leaders")
        Dim TreeNode133 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Build query")
        Dim TreeNode134 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest main", New System.Windows.Forms.TreeNode() {TreeNode131, TreeNode132, TreeNode133})
        Dim TreeNode135 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Help menu", New System.Windows.Forms.TreeNode() {TreeNode105, TreeNode130, TreeNode134})
        Dim TreeNode136 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת קבוצה")
        Dim TreeNode137 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון קבוצה")
        Dim TreeNode138 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול קבוצות", New System.Windows.Forms.TreeNode() {TreeNode136, TreeNode137})
        Dim TreeNode139 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת שחקן לקבוצה")
        Dim TreeNode140 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון שחקן קיים")
        Dim TreeNode141 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מחיקת שחקן")
        Dim TreeNode142 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול שחקנים", New System.Windows.Forms.TreeNode() {TreeNode139, TreeNode140, TreeNode141})
        Dim TreeNode143 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת משחק")
        Dim TreeNode144 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון משחק קיים")
        Dim TreeNode145 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת סטטיסטיקת משחק")
        Dim TreeNode146 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול משחקים", New System.Windows.Forms.TreeNode() {TreeNode143, TreeNode144, TreeNode145})
        Dim TreeNode147 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מובילי הליגה")
        Dim TreeNode148 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("שינויים שנעשו בליגה")
        Dim TreeNode149 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ניהול הליגה", New System.Windows.Forms.TreeNode() {TreeNode147, TreeNode148})
        Dim TreeNode150 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מנהלי ליגה", New System.Windows.Forms.TreeNode() {TreeNode138, TreeNode142, TreeNode146, TreeNode149})
        Dim TreeNode151 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת שחקן לקבוצה")
        Dim TreeNode152 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון שחקן קיים")
        Dim TreeNode153 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("גילאי השחקנים")
        Dim TreeNode154 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ימי הולדת קרובים")
        Dim TreeNode155 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("השוואת סטטיסטיקות")
        Dim TreeNode156 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("שחקנים", New System.Windows.Forms.TreeNode() {TreeNode151, TreeNode152, TreeNode153, TreeNode154, TreeNode155})
        Dim TreeNode157 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל קודי הרוטציה")
        Dim TreeNode158 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("עדכון רוטציה")
        Dim TreeNode159 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("רוטציות", New System.Windows.Forms.TreeNode() {TreeNode157, TreeNode158})
        Dim TreeNode160 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מעקב אחר תרגיל")
        Dim TreeNode161 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ציוני תרגילים לשחקנים")
        Dim TreeNode162 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("תרגילים", New System.Windows.Forms.TreeNode() {TreeNode160, TreeNode161})
        Dim TreeNode163 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקי הקבוצה שלי")
        Dim TreeNode164 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקי הבית שלי")
        Dim TreeNode165 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקי החוץ שלי")
        Dim TreeNode166 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("הוספת סטיסטיקת משחק")
        Dim TreeNode167 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("חיזוי תוצאת משחק")
        Dim TreeNode168 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("משחקים", New System.Windows.Forms.TreeNode() {TreeNode163, TreeNode164, TreeNode165, TreeNode166, TreeNode167})
        Dim TreeNode169 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל שחקני הליגה")
        Dim TreeNode170 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל קבוצות הליגה")
        Dim TreeNode171 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("כל משחקי הליגה")
        Dim TreeNode172 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מובילי הליגה")
        Dim TreeNode173 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מעקב אחר שחקנים")
        Dim TreeNode174 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מידע אחר", New System.Windows.Forms.TreeNode() {TreeNode169, TreeNode170, TreeNode171, TreeNode172, TreeNode173})
        Dim TreeNode175 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מנהלי קבוצות", New System.Windows.Forms.TreeNode() {TreeNode156, TreeNode159, TreeNode162, TreeNode168, TreeNode174})
        Dim TreeNode176 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("שאילתות אורחים")
        Dim TreeNode177 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("מובילי הליגה")
        Dim TreeNode178 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("חיפוש מידע")
        Dim TreeNode179 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("אורחים", New System.Windows.Forms.TreeNode() {TreeNode176, TreeNode177, TreeNode178})
        Dim TreeNode180 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("תפריט עזר", New System.Windows.Forms.TreeNode() {TreeNode150, TreeNode175, TreeNode179})
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
        TreeNode91.Name = "Node_AddTeam"
        TreeNode91.Text = "Add teams"
        TreeNode92.Name = "Node_UpdateTeam"
        TreeNode92.Text = "Update teams"
        TreeNode93.Name = "Node_AdminTeams"
        TreeNode93.Text = "Manage teams"
        TreeNode94.Name = "Node_AdmAddP"
        TreeNode94.Text = "Add players"
        TreeNode95.Name = "Node_AdmUpdateP"
        TreeNode95.Text = "Update players"
        TreeNode96.Name = "Node_AdmDeleteP"
        TreeNode96.Text = "Delete players"
        TreeNode97.Name = "Node_AdminPlayers"
        TreeNode97.Text = "Manage players"
        TreeNode98.Name = "Node_AddGame"
        TreeNode98.Text = "Add games"
        TreeNode99.Name = "Node_UpdateGame"
        TreeNode99.Text = "Update games"
        TreeNode100.Name = "Node_AdminAddStats"
        TreeNode100.Text = "Add game stats"
        TreeNode101.Name = "Node_AdminGames"
        TreeNode101.Text = "Manage games"
        TreeNode102.Name = "Node_AdminLeagueL"
        TreeNode102.Text = "League leaders"
        TreeNode103.Name = "Node_LeagueChange"
        TreeNode103.Text = "League changes"
        TreeNode104.Name = "Node_AdminLeague"
        TreeNode104.Text = "Manage league"
        TreeNode105.Name = "Node_Admin"
        TreeNode105.Text = "Admin main"
        TreeNode106.Name = "Node_AddP"
        TreeNode106.Text = "Add player"
        TreeNode107.Name = "Node_UpdateP"
        TreeNode107.Text = "Update player"
        TreeNode108.Name = "Node_Age"
        TreeNode108.Text = "Player age"
        TreeNode109.Name = "Node_UpcomeBirth"
        TreeNode109.Text = "Upcoming birthday"
        TreeNode110.Name = "Node_StatsP"
        TreeNode110.Text = "Player stats"
        TreeNode111.Name = "Node_Players"
        TreeNode111.Text = "Players"
        TreeNode112.Name = "Node_RoutionCode"
        TreeNode112.Text = "Roution code"
        TreeNode113.Name = "Node_UpdateR"
        TreeNode113.Text = "Update roution"
        TreeNode114.Name = "Node_Roution"
        TreeNode114.Text = "Roution"
        TreeNode115.Name = "Node_WatchD"
        TreeNode115.Text = "Watch drill"
        TreeNode116.Name = "Node_GradeD"
        TreeNode116.Text = "Drill grades"
        TreeNode117.Name = "Node_Drill"
        TreeNode117.Text = "Drills"
        TreeNode118.Name = "Node_MyTeamG"
        TreeNode118.Text = "My team games"
        TreeNode119.Name = "Node_HomeG"
        TreeNode119.Text = "My home games"
        TreeNode120.Name = "Node_AwayG"
        TreeNode120.Text = "My away games"
        TreeNode121.Name = "Node_PGStats"
        TreeNode121.Text = "Add player game stats"
        TreeNode122.Name = "Node_VisionG"
        TreeNode122.Text = "Game vision"
        TreeNode123.Name = "Node_Games"
        TreeNode123.Text = "Games"
        TreeNode124.Name = "Node_LeagueP"
        TreeNode124.Text = "League players"
        TreeNode125.Name = "Node_LeagueT"
        TreeNode125.Text = "League teams"
        TreeNode126.Name = "Node_LeagueG"
        TreeNode126.Text = "League games"
        TreeNode127.Name = "Node_LeagueL"
        TreeNode127.Text = "League leaders"
        TreeNode128.Name = "Node_TrackP"
        TreeNode128.Text = "Tracking players"
        TreeNode129.Name = "Node_Others"
        TreeNode129.Text = "Others"
        TreeNode130.Name = "Node_Manager"
        TreeNode130.Text = "Manager main"
        TreeNode131.Name = "Node_GuestQ"
        TreeNode131.Text = "Guest queries"
        TreeNode132.Name = "Node_GuestLeagueL"
        TreeNode132.Text = "League leaders"
        TreeNode133.Name = "Node_BuildQuery"
        TreeNode133.Text = "Build query"
        TreeNode134.Name = "Node_Guest"
        TreeNode134.Text = "Guest main"
        TreeNode135.Name = "Node_Help"
        TreeNode135.Text = "Help menu"
        Me.TreeV_HelpEng.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode135})
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
        TreeNode136.Name = "Node_AddTeam"
        TreeNode136.Text = "הוספת קבוצה"
        TreeNode137.Name = "Node_UpdateTeam"
        TreeNode137.Text = "עדכון קבוצה"
        TreeNode138.Name = "Node_AdminTeams"
        TreeNode138.Text = "ניהול קבוצות"
        TreeNode139.Name = "Node_AdmAddP"
        TreeNode139.Text = "הוספת שחקן לקבוצה"
        TreeNode140.Name = "Node_AdmUpdateP"
        TreeNode140.Text = "עדכון שחקן קיים"
        TreeNode141.Name = "Node_AdmDeleteP"
        TreeNode141.Text = "מחיקת שחקן"
        TreeNode142.Name = "Node_AdminPlayers"
        TreeNode142.Text = "ניהול שחקנים"
        TreeNode143.Name = "Node_AddGame"
        TreeNode143.Text = "הוספת משחק"
        TreeNode144.Name = "Node_UpdateGame"
        TreeNode144.Text = "עדכון משחק קיים"
        TreeNode145.Name = "Node_AdminAddStats"
        TreeNode145.Text = "הוספת סטטיסטיקת משחק"
        TreeNode146.Name = "Node_AdminGames"
        TreeNode146.Text = "ניהול משחקים"
        TreeNode147.Name = "Node_AdminLeagueL"
        TreeNode147.Text = "מובילי הליגה"
        TreeNode148.Name = "Node_LeagueChange"
        TreeNode148.Text = "שינויים שנעשו בליגה"
        TreeNode149.Name = "Node_AdminLeague"
        TreeNode149.Text = "ניהול הליגה"
        TreeNode150.Name = "Node_Admin"
        TreeNode150.Text = "מנהלי ליגה"
        TreeNode151.Name = "Node_AddP"
        TreeNode151.Text = "הוספת שחקן לקבוצה"
        TreeNode152.Name = "Node_UpdateP"
        TreeNode152.Text = "עדכון שחקן קיים"
        TreeNode153.Name = "Node_Age"
        TreeNode153.Text = "גילאי השחקנים"
        TreeNode154.Name = "Node_UpcomeBirth"
        TreeNode154.Text = "ימי הולדת קרובים"
        TreeNode155.Name = "Node_StatsP"
        TreeNode155.Text = "השוואת סטטיסטיקות"
        TreeNode156.Name = "Node_Players"
        TreeNode156.Text = "שחקנים"
        TreeNode157.Name = "Node_RoutionCode"
        TreeNode157.Text = "כל קודי הרוטציה"
        TreeNode158.Name = "Node_UpdateR"
        TreeNode158.Text = "עדכון רוטציה"
        TreeNode159.Name = "Node_Roution"
        TreeNode159.Text = "רוטציות"
        TreeNode160.Name = "Node_WatchD"
        TreeNode160.Text = "מעקב אחר תרגיל"
        TreeNode161.Name = "Node_GradeD"
        TreeNode161.Text = "ציוני תרגילים לשחקנים"
        TreeNode162.Name = "Node_Drill"
        TreeNode162.Text = "תרגילים"
        TreeNode163.Name = "Node_MyTeamG"
        TreeNode163.Text = "משחקי הקבוצה שלי"
        TreeNode164.Name = "Node_HomeG"
        TreeNode164.Text = "משחקי הבית שלי"
        TreeNode165.Name = "Node_AwayG"
        TreeNode165.Text = "משחקי החוץ שלי"
        TreeNode166.Name = "Node_PGStats"
        TreeNode166.Text = "הוספת סטיסטיקת משחק"
        TreeNode167.Name = "Node_VisionG"
        TreeNode167.Text = "חיזוי תוצאת משחק"
        TreeNode168.Name = "Node_Games"
        TreeNode168.Text = "משחקים"
        TreeNode169.Name = "Node_LeagueP"
        TreeNode169.Text = "כל שחקני הליגה"
        TreeNode170.Name = "Node_LeagueT"
        TreeNode170.Text = "כל קבוצות הליגה"
        TreeNode171.Name = "Node_LeagueG"
        TreeNode171.Text = "כל משחקי הליגה"
        TreeNode172.Name = "Node_LeagueL"
        TreeNode172.Text = "מובילי הליגה"
        TreeNode173.Name = "Node_TrackP"
        TreeNode173.Text = "מעקב אחר שחקנים"
        TreeNode174.Name = "Node_Others"
        TreeNode174.Text = "מידע אחר"
        TreeNode175.Name = "Node_Manager"
        TreeNode175.Text = "מנהלי קבוצות"
        TreeNode176.Name = "Node_GuestQ"
        TreeNode176.Text = "שאילתות אורחים"
        TreeNode177.Name = "Node_GuestLeagueL"
        TreeNode177.Text = "מובילי הליגה"
        TreeNode178.Name = "Node_BuildQuery"
        TreeNode178.Text = "חיפוש מידע"
        TreeNode179.Name = "Node_Guest"
        TreeNode179.Text = "אורחים"
        TreeNode180.Name = "Node_Help"
        TreeNode180.Text = "תפריט עזר"
        Me.TreeV_HelpHeb.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode180})
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
