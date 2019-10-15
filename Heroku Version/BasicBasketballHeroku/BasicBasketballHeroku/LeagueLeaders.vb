Public Class LeagueLeaders
    Private myHelper As MyDBControler = New MyDBControler(), itemcoll(30) As String
    Public Shared Property HoverForeColor As Color = Color.White
    Public Shared Property HoverBackColor As Color = Color.Navy
    Public Shared Property LeaveForeColor As Color = Color.Black
#Region "איוונטים של הפורם"
    Private Sub LeagueLeaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetHoversColors()
        Accessibility.SetDesignToAllForms(Me)
        FLP_Menu.Location = New Point((Panel_Left.Width - FLP_Menu.Width) / 2, (Panel_Left.Height - FLP_Menu.Height) / 2)
        Lbl_Welcome.Location = New Point((Panel_Top.Width - Lbl_Welcome.Width) / 2, (Panel_Top.Height - Lbl_Welcome.Height) / 2)
        FillListLeaders(LV_LeaguePLead, "PlayersP")
        FillListLeaders(LV_LeagueALead, "PlayersA")
        FillListLeaders(LV_LeagueRLead, "PlayersR")
        FillListLeaders(LV_LeagueSLead, "PlayersS")
        FillListLeaders(LV_LeagueBLead, "PlayersB")
    End Sub
    Private Sub LeagueLeaders_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        If Lbl_FormBack.Text.Equals("Managers main") Then
            ManagersMain.Show()
        ElseIf Lbl_FormBack.Text.Equals("Admins main") Then
            AdminsMain.Show()
        Else
            GuestMain.Show()
        End If
    End Sub
    Private Sub Panel_Lead_Resize(sender As Object, e As EventArgs) Handles Panel_Lead.Resize
        Panel_Display.Location = New Point((Panel_Lead.Width - Panel_Display.Width) / 2, (Panel_Lead.Height - Panel_Display.Height) / 2)
    End Sub
    Private Sub SetHoversColors()
        If Lbl_FormBack.Text.Equals("Managers main") Then
            Panel_Top.BackColor = HoverForeColor
            Panel_Left.BackColor = HoverForeColor
            Panel_Lead.BackColor = Color.White
            Lbl_Welcome.ForeColor = LeaveForeColor
            Btn_GetLeaders.ForeColor = LeaveForeColor
            Btn_Help.ForeColor = LeaveForeColor
            For Each l As Label In Panel_Display.Controls.OfType(Of Label)()
                l.ForeColor = LeaveForeColor
            Next
        ElseIf Lbl_FormBack.Text.Equals("Admins main") Then
            LeaveForeColor = Color.Black
            HoverForeColor = Color.DeepSkyBlue
            HoverBackColor = AdminsMain.Panel_Left.BackColor
            Panel_Top.BackColor = AdminsMain.Panel_Display.BackColor
            Panel_Lead.BackColor = AdminsMain.Panel_Display.BackColor
            Panel_Left.BackColor = HoverBackColor
            Panel_UpL.BackColor = Panel_Left.BackColor
            Lbl_Welcome.ForeColor = Color.Black
            Btn_GetLeaders.ForeColor = LeaveForeColor
            Btn_Help.ForeColor = LeaveForeColor
            For Each l As Label In Panel_Display.Controls.OfType(Of Label)()
                l.ForeColor = Color.Black
            Next
        Else
            Panel_Top.BackColor = GuestMain.Panel_Top.BackColor
            Panel_Left.BackColor = GuestMain.FLP_Menu.BackColor
            Panel_Lead.BackColor = GuestMain.Panel_Display.BackColor
            Lbl_Welcome.ForeColor = Color.Black
            Btn_GetLeaders.ForeColor = Color.Black
            Btn_Help.ForeColor = Color.Black
            For Each l As Label In Panel_Display.Controls.OfType(Of Label)()
                l.ForeColor = Color.Black
            Next
        End If
    End Sub
#End Region
#Region "פונקציה למילוי הרשימות של המובילים בכל קטגוריה"
    Private Function FillListLeaders(ByVal MyList As ListView, ByVal Choice As String) As ListView
        MyList.Items.Clear()
        Return myHelper.FillListView(Me, MyList, itemcoll, Choice)
    End Function
#End Region
#Region "אירועים בעת לחיצה על הכפתורים"
    Private Sub Btn_GetLeaders_Click(sender As Object, e As EventArgs) Handles Btn_GetLeaders.Click
        If Btn_GetLeaders.Text.Equals("Show me teams leaders") Then
            FillListLeaders(LV_LeaguePLead, "TeamsP")
            FillListLeaders(LV_LeagueALead, "TeamsA")
            FillListLeaders(LV_LeagueRLead, "TeamsR")
            FillListLeaders(LV_LeagueSLead, "TeamsS")
            FillListLeaders(LV_LeagueBLead, "TeamsB")
            Btn_GetLeaders.Text = "Show me players leaders"
            Lbl_Welcome.Text = "Teams League Leaders"
        ElseIf Btn_GetLeaders.Text.Equals("Show me players leaders") Then
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
        btn.BackColor = HoverBackColor
        btn.ForeColor = HoverForeColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles Btn_GetLeaders.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.BackColor = Panel_Left.BackColor
        btn.ForeColor = LeaveForeColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
End Class