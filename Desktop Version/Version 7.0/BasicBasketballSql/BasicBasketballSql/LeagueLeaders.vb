Public Class LeagueLeaders
    Private myHelper As MyDBControler = New MyDBControler()
    Private itemcoll(30) As String
#Region "איוונטים של הפורם"
    Private Sub LeagueLeaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Accessibility.SetDesignToAllForms(Me)
        FLP_Menu.Location = New Point((Panel_Left.Width - FLP_Menu.Width) / 2, (Panel_Left.Height - FLP_Menu.Height) / 2)
        Lbl_Welcome.Location = New Point((Panel_Top.Width - Lbl_Welcome.Width) / 2, (Panel_Top.Height - Lbl_Welcome.Height) / 2)
        Panel_Display.BackColor = Color.FromArgb(50, Color.LightSkyBlue)
        FillListLeaders(LV_LeaguePLead, "PlayersP")
        FillListLeaders(LV_LeagueALead, "PlayersA")
        FillListLeaders(LV_LeagueRLead, "PlayersR")
        FillListLeaders(LV_LeagueSLead, "PlayersS")
        FillListLeaders(LV_LeagueBLead, "PlayersB")
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
    Private Sub Panel_Lead_Resize(sender As Object, e As EventArgs) Handles Panel_Lead.Resize
        Panel_Display.Location = New Point((Panel_Lead.Width - Panel_Display.Width) / 2, (Panel_Lead.Height - Panel_Display.Height) / 2)
    End Sub
#End Region
#Region "פונקציית למילוי הרשימות של המובילים בכל קטוגוריה"
    Private Function FillListLeaders(ByVal MyList As ListView, ByVal Choice As String) As ListView
        MyList.Items.Clear()
        Return myHelper.FillListView(Me, MyList, itemcoll, Choice)
    End Function
#End Region
#Region "אירועים בעת לחיצה על הכפתורים"
    Private Sub Btn_GetLeaders_Click(sender As Object, e As EventArgs) Handles Btn_GetLeaders.Click
        If Btn_GetLeaders.Text = "Show me teams leaders" Then
            FillListLeaders(LV_LeaguePLead, "TeamsP")
            FillListLeaders(LV_LeagueALead, "TeamsA")
            FillListLeaders(LV_LeagueRLead, "TeamsR")
            FillListLeaders(LV_LeagueSLead, "TeamsS")
            FillListLeaders(LV_LeagueBLead, "TeamsB")
            Btn_GetLeaders.Text = "Show me players leaders"
            Lbl_Welcome.Text = "Teams League Leaders"
        ElseIf Btn_GetLeaders.Text = "Show me players leaders" Then
            FillListLeaders(LV_LeaguePLead, "PlayersP")
            FillListLeaders(LV_LeagueALead, "PlayersA")
            FillListLeaders(LV_LeagueRLead, "PlayersR")
            FillListLeaders(LV_LeagueSLead, "PlayersS")
            FillListLeaders(LV_LeagueBLead, "PlayersB")
            Btn_GetLeaders.Text = "Show me teams leaders"
            Lbl_Welcome.Text = "Players League Leaders"
        End If
    End Sub
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.Show()
    End Sub
    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs) Handles Btn_GetLeaders.MouseEnter, Btn_Help.MouseEnter
        Dim btn As Button = sender
        btn.BackColor = Color.Navy
        btn.ForeColor = Color.White
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles Btn_GetLeaders.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.BackColor = Panel_Left.BackColor
        btn.ForeColor = Color.Black
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
End Class