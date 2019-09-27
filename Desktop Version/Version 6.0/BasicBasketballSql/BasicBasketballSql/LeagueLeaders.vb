Public Class LeagueLeaders
    Private myHelper As MyDBControler = New MyDBControler()
    Private itemcoll(30) As String
#Region "איוונטים של הפורם"
    Private Sub LeagueLeaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_Lead.Location = New Point((Me.Width - Panel_Lead.Width) / 2, (Me.Height - Panel_Lead.Height) / 2)
        Panel_Lead.BackColor = Color.FromArgb(75, Color.DarkGray)
        Call FillListLeaders(LV_LeaguePLead, "PlayersP")
        Call FillListLeaders(LV_LeagueALead, "PlayersA")
        Call FillListLeaders(LV_LeagueRLead, "PlayersR")
        Call FillListLeaders(LV_LeagueSLead, "PlayersS")
        Call FillListLeaders(LV_LeagueBLead, "PlayersB")
    End Sub
    Private Sub LeagueLeaders_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        If Lbl_FormBack.Text = "Managers main" Then
            ManagersMain.Show()
        ElseIf Lbl_FormBack.Text = "Admins main" Then
            AdminsMain.Show()
        Else
            GuestMain.Show()
        End If
    End Sub
    Private Sub LeagueLeaders_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel_Lead.Location = New Point((Me.Width - Panel_Lead.Width) / 2, (Me.Height - Panel_Lead.Height) / 2)
    End Sub
#End Region
#Region "פונקציית למילוי הרשימות של המובילים בכל קטוגוריה"
    Private Function FillListLeaders(ByVal MyList As ListView, ByVal Choice As String) As ListView
        MyList.Items.Clear()
        Return myHelper.FillListView(Me, MyList, itemcoll, Choice)
    End Function
#End Region
#Region "אירועים בעת לחיצה על הכפתור או התמונה"
    Private Sub Btn_GetLeaders_Click(sender As Object, e As EventArgs) Handles Btn_GetLeaders.Click
        If Btn_GetLeaders.Text = "Show me teams leaders" Then
            Call FillListLeaders(LV_LeaguePLead, "TeamsP")
            Call FillListLeaders(LV_LeagueALead, "TeamsA")
            Call FillListLeaders(LV_LeagueRLead, "TeamsR")
            Call FillListLeaders(LV_LeagueSLead, "TeamsS")
            Call FillListLeaders(LV_LeagueBLead, "TeamsB")
            Btn_GetLeaders.Text = "Show me players leaders"
            Lbl_LL.Text = "Teams League Leaders"
        ElseIf Btn_GetLeaders.Text = "Show me players leaders" Then
            Call FillListLeaders(LV_LeaguePLead, "PlayersP")
            Call FillListLeaders(LV_LeagueALead, "PlayersA")
            Call FillListLeaders(LV_LeagueRLead, "PlayersR")
            Call FillListLeaders(LV_LeagueSLead, "PlayersS")
            Call FillListLeaders(LV_LeagueBLead, "PlayersB")
            Btn_GetLeaders.Text = "Show me teams leaders"
            Lbl_LL.Text = "Players League Leaders"
        End If
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.Show()
    End Sub
#End Region
End Class