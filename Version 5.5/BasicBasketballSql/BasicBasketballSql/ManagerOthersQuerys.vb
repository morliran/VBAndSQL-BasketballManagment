Public Class ManagerOthersQuerys
    Private Hcode As String = ManagersMain.getManager.GetHomeCode(), Acode As String = ManagersMain.getManager.GetAwayCode()
#Region "אופציות על הפורם"
    Private Sub ManagerOthersQuerys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_TeamsName.Text = ManagersMain.getManager.CheckTeam()
        Btn_AutoClick.PerformClick()
    End Sub
    Private Sub ManagerOthersQuerys_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        ManagersMain.Show()
    End Sub
#End Region
#Region "כפתור הפעלת הפונקציות של הפורם"
    Private Sub Btn_AutoClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AutoClick.Click
        Dim ArrCodes() As String = New String() {"", "", "", "", "", ""}
        If Lbl_Query.Text = "All Players In The League" Then
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("Players", ArrCodes, 7)
        ElseIf Lbl_Query.Text = "All Teams In The League" Then
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("HomeTeam", ArrCodes, 7)
        ElseIf Lbl_Query.Text = "All Games In The League" Then
            ArrCodes = {"", ""}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("LeagueGames", ArrCodes)
        ElseIf Lbl_Query.Text = "All My Team Games In The League" Then
            ArrCodes = {Hcode, Acode}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("MyTeamGames", ArrCodes)
        ElseIf Lbl_Query.Text = "All My Team Games As Home Team In The League" Then
            ArrCodes = {Hcode, ""}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("AwayOrHomeGames", ArrCodes)
        ElseIf Lbl_Query.Text = "All My Team Games As Away Team In The League" Then
            ArrCodes = {"", Acode}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("AwayOrHomeGames", ArrCodes)
        ElseIf Lbl_Query.Text = "All My Team Players Age" Then
            ArrCodes = {Hcode, ""}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("Ages", ArrCodes)
        ElseIf Lbl_Query.Text = "All My Players Roution Codes" Then
            ArrCodes = {ManagersMain.getManager.CheckTeam(), ""}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("SubsCode", ArrCodes)
        ElseIf Lbl_Query.Text = "All My Players Stats" Then
            ArrCodes = {"TeamsNames", "=", ManagersMain.getManager.CheckTeam(), "", "", ""}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("PlayersGamesStats", ArrCodes, 2)
        ElseIf Lbl_Query.Text = "All My Players Grade Drills" Then
            ArrCodes = {Hcode, ""}
            DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("Pgrades", ArrCodes)
        End If
        Lbl_TableName.Text = Lbl_Query.Text
        TimerAutoClick.Start()
        TimerAutoClick.Stop()
    End Sub
#End Region
#Region "פתיחת חלון העזרה"
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.Show()
    End Sub
#End Region
End Class