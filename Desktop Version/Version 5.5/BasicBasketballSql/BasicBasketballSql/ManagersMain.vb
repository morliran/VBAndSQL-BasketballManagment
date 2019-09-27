Public Class ManagersMain
    Private Manager As ClassCheckManager = New ClassCheckManager()
    Private myHelper As MyDBControler = New MyDBControler()
    Private DatesCheck As CheckingGameDates = New CheckingGameDates()
    Private intHeight As Integer
#Region "פונקציות על הפורם ושלו"
    Private Sub ManagersMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlayersUpcomingBirthday.Show()
        PlayersUpcomingBirthday.Hide()
        DatesCheck.CheckGameDate()
        Btn_AutoClick.PerformClick()
        StartTimer()
        For Each rowheight As DataGridViewRow In DataGridView1.Rows ' משנה את גודל הdatagrid בהתאם לגודל הטבלה שהוחזרה מהdatabase '
            intHeight += rowheight.Height
        Next
        DataGridView1.Height = intHeight + 23
    End Sub
    Private Sub ManagersMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Public Function getManager() As ClassCheckManager
        Return Manager
    End Function
    Public Function getDBHelper() As MyDBControler
        Return myHelper
    End Function
#End Region
#Region "פונקציות עזר"
    Private Sub StartTimer()
        TimerAutoClick.Start()
        TimerAutoClick.Interval = 1000
        TimerAutoClick.Stop()
    End Sub
    Private Function GetData(ByVal code As String) As DataView
        Dim Arr() As String = New String() {"HisHomeTeamCode", "=", code, "", "", ""}
        Return myHelper.getDataView("Players", Arr, 2)
    End Function
#End Region
#Region "אירועים בעת לחיצה על אובייקטים בפורם"
    Private Sub Btn_AutoClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AutoClick.Click
        Lbl_TableName.Text = Manager.CheckTeam() + " Players"
        DataGridView1.DataSource = GetData(Manager.GetHomeCode())
        Me.StartTimer()
    End Sub
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        Me.Hide()
        Me.Show()
        Btn_AutoClick.PerformClick() 'מציג את הטבלה המתאימה לאחר שינויים שבוצעו בה'
    End Sub
    Private Sub Pic_Logout_Click(sender As Object, e As EventArgs) Handles Pic_Logout.Click
        Me.Hide()
        Me.Dispose()
        LoginForm.ReturnToMe()
    End Sub
#End Region
#Region "פעולות בעת לחיצה על אחת מהאופציות בסרגל האפשרויות"
    Private Sub AddPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPlayerToolStripMenuItem.Click
        Me.Hide()
        AddPlayersForm.Show()
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_AddP")
        AddPlayersForm.Tb_PlayerCode.Focus()
    End Sub
    Private Sub UpdatePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePlayerToolStripMenuItem.Click
        Me.Hide()
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_UpdateP")
        UpdatePlayersForm.Show()
    End Sub
    Private Sub AllLeaguePlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllLeaguePlayersToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All Players In The League"
        HelpForm.SetSelectedNode("Node_LeagueP")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub AllLeagueTeamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllLeagueTeamsToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All Teams In The League"
        HelpForm.SetSelectedNode("Node_LeagueT")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub AllLeagueGamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllLeagueGamesToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All Games In The League"
        HelpForm.SetSelectedNode("Node_LeagueG")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub AllGamesForMyTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllGamesForMyTeamToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All My Team Games In The League"
        HelpForm.SetSelectedNode("Node_MyTeamG")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub AllGamesAsHomeTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllGamesAsHomeTeamToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All My Team Games As Home Team In The League"
        HelpForm.SetSelectedNode("Node_HomeG")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub AllGamesAsAwayTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllGamesAsAwayTeamToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All My Team Games As Away Team In The League"
        HelpForm.SetSelectedNode("Node_AwayG")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub UpcomingBrithdaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpcomingBrithdaysToolStripMenuItem.Click
        PlayersUpcomingBirthday.Show()
    End Sub
    Private Sub PlayersAgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersAgeToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All My Team Players Age"
        HelpForm.SetSelectedNode("Node_Age")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub AllTeamStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllTeamStatsToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All My Players Stats"
        HelpForm.SetSelectedNode("Node_StatsP")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub PlayersDrillsGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersDrillsGradesToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All My Players Grade Drills"
        HelpForm.SetSelectedNode("Node_GradeD")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub MyRoutionCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyRoutionCodeToolStripMenuItem.Click
        Me.Hide()
        ManagerOthersQuerys.Lbl_Query.Text = "All My Players Roution Codes"
        HelpForm.SetSelectedNode("Node_RoutionCode")
        ManagerOthersQuerys.Show()
    End Sub
    Private Sub UpdateRoutionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRoutionToolStripMenuItem.Click
        Me.Hide()
        PlayersRoutionForm.Show()
    End Sub
    Private Sub AddPlayersGameStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPlayersGameStatsToolStripMenuItem.Click
        Dim n As String = MsgBox("Notice!: If you select yes the system will not allow you closing the window that will open" + vbNewLine + "Until you finish to insert all your players stats" + vbNewLine + "Are you sure you want to open the new window?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            Me.Hide()
            HelpForm.SetFormTag(1)
            HelpForm.SetSelectedNode("Node_PGStats")
            PlayersMatchStatistics.Show()
        End If
    End Sub
    Private Sub CompareStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompareStatsToolStripMenuItem.Click
        Me.Hide()
        StatsCompares.Show()
    End Sub
    Private Sub GamesVisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GamesVisionToolStripMenuItem.Click
        Me.Hide()
        GamesVisionsMyTeamVsOthers.Show()
    End Sub
    Private Sub WatchDrillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatchDrillsToolStripMenuItem.Click
        Me.Hide()
        DrillWatch.Show()
    End Sub
    Private Sub LeagueLeadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeagueLeadersToolStripMenuItem.Click
        Me.Hide()
        LeagueLeaders.Lbl_FormBack.Text = "Managers main"
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_LeagueL")
        LeagueLeaders.Show()
    End Sub
    Private Sub TrackPlayersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrackPlayersToolStripMenuItem.Click
        Me.Hide()
        TrackPlayers.Show()
    End Sub
    Private Sub HelpMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpMeToolStripMenuItem.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_Manager")
        HelpForm.Show()
    End Sub
#End Region
End Class