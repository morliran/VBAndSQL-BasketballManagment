Public Class ManagersMain
    Private Manager As ClassCheckManager = New ClassCheckManager()
    Private myHelper As MyDBControler = New MyDBControler()
    Private DatesCheck As CheckingGameDates = New CheckingGameDates()
    Private RowSize As Integer = 10, RowFontName As String = "", RowFontStyle As FontStyle = FontStyle.Regular, RowFontC As String = "", OddRowColor As String = "", EvenRowColor As String = ""
    Private ArrCodes() As String = New String() {}, TableName As String = ""
#Region "פונקציות על הפורם ושלו"
    Private Sub ManagersMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PlayersUpcomingBirthday.Show()
        PlayersUpcomingBirthday.Hide()
        DatesCheck.CheckGameDate()
    End Sub
    Private Sub ManagersMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Private Sub CloseOperation()
        Me.Hide()
        Me.Dispose()
    End Sub
    Public Function getManager() As ClassCheckManager
        Return Manager
    End Function
    Public Function getDBHelper() As MyDBControler
        Return myHelper
    End Function
#End Region
#Region "יישום אנימציה של תזוזת התפריט ופתיחתו"
    Private Sub ThePanel_MouseHover(sender As Object, e As EventArgs) Handles Btn_Players.MouseHover, Btn_Roution.MouseHover, Btn_Drills.MouseHover, Btn_Games.MouseHover, Btn_Others.MouseHover, Btn_Design.MouseHover, Btn_Help.MouseHover, Btn_LogOut.MouseHover
        Dim btn As Button = sender
        btn.BackColor = ColorTranslator.FromHtml("#3742FA")
        Panel_DesignTool.Visible = False
        Lbl_AddingStats.Visible = False
        FLP_Move.Visible = True
        FLP_Move.AutoSize = False
        FLP_Move.Width = 8
        FLP_Move.Height = btn.Height
        FLP_Move.Top = btn.Top
        If TableName <> "Players" Then
            ArrCodes = {"HisHomeTeamCode", "=", Manager.GetHomeCode(), "", "", ""}
            TableName = "Players"
            Lbl_TableName.Text = Manager.CheckTeam() & " Players"
            DataGridView1.DataSource = myHelper.getDataView("Players", ArrCodes, 4)
        End If
        Select Case btn.Name
            Case "Btn_Players"
                AllowMenuItems("Players")
                Timer_Menu.Start()
            Case "Btn_Roution"
                AllowMenuItems("Roution")
                Timer_Menu.Start()
            Case "Btn_Drills"
                AllowMenuItems("Drills")
                Timer_Menu.Start()
            Case "Btn_Games"
                AllowMenuItems("Games")
                If DatesCheck.GetGameFound() = True Then
                    Lbl_AddingStats.Visible = True
                End If
                Timer_Menu.Start()
            Case "Btn_Others"
                AllowMenuItems("Others")
                Timer_Menu.Start()
            Case "Btn_Design"
                AllowMenuItems("Design")
                Panel_DesignTool.Visible = True
                Panel_DesignTool.Height = Btn_Design.Height
                Panel_DesignTool.Width = Btn_Design.Width
                Panel_DesignTool.Top = FLP_Move.Top
            Case "Btn_Help"
                AllowMenuItems("Help")
            Case "Btn_LogOut"
                AllowMenuItems("Logout")
        End Select
        DesignDataGrid(DataGridView1)
        DataGridView1.Location = New Point((Panel_Grid.Width - DataGridView1.Width) / 2, (Panel_Grid.Height - DataGridView1.Height) / 2)
    End Sub
    Private Sub Timer_Menu_Tick(sender As Object, e As EventArgs) Handles Timer_Menu.Tick
        FLP_Move.Width = FLP_Move.Width + 20
        If FLP_Move.Width > Btn_Players.Width * 2 Then
            FLP_Move.AutoSize = True
            Timer_Menu.Stop()
        End If
    End Sub
#End Region
#Region "אירועים בעת לחיצה על אובייקטים בפורם"
    Private Sub ThePanel_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Players.MouseLeave, Btn_Roution.MouseLeave, Btn_Drills.MouseLeave, Btn_Games.MouseLeave, Btn_Others.MouseLeave, Btn_Design.MouseLeave, Btn_Help.MouseLeave, Btn_LogOut.MouseLeave
        Dim btn As Button = sender
        btn.BackColor = ColorTranslator.FromHtml("#040404")
    End Sub
    Private Sub LabelsMouseEnters(sender As Object, e As EventArgs) Handles Lbl_PlayersAge.MouseEnter, Lbl_PlayersBirth.MouseEnter, Lbl_PlayersAdd.MouseEnter, Lbl_PlayersUpdate.MouseEnter, Lbl_PlayersStats.MouseEnter, Lbl_RoutionC.MouseEnter, Lbl_RoutionUpdate.MouseEnter, Lbl_DrillsWatch.MouseEnter, Lbl_DrillsGrade.MouseEnter, Lbl_GamesMyTeam.MouseEnter, Lbl_GamesH.MouseEnter, Lbl_GamesA.MouseEnter, Lbl_GamesV.MouseEnter, Lbl_OthersLeagueLead.MouseEnter, Lbl_OthersP.MouseEnter, Lbl_OthersT.MouseEnter, Lbl_OthersG.MouseEnter, Lbl_OthersS.MouseEnter, Lbl_OthersTracking.MouseEnter
        Dim label As Label = sender
        label.BackColor = ColorTranslator.FromHtml("#3742FA")
    End Sub
    Private Sub LabelsMouseLeave(sender As Object, e As EventArgs) Handles Lbl_PlayersAge.MouseLeave, Lbl_PlayersBirth.MouseLeave, Lbl_PlayersAdd.MouseLeave, Lbl_PlayersUpdate.MouseLeave, Lbl_PlayersStats.MouseLeave, Lbl_RoutionC.MouseLeave, Lbl_RoutionUpdate.MouseLeave, Lbl_DrillsWatch.MouseLeave, Lbl_DrillsGrade.MouseLeave, Lbl_GamesMyTeam.MouseLeave, Lbl_GamesH.MouseLeave, Lbl_GamesA.MouseLeave, Lbl_GamesV.MouseLeave, Lbl_OthersLeagueLead.MouseLeave, Lbl_OthersP.MouseLeave, Lbl_OthersT.MouseLeave, Lbl_OthersG.MouseLeave, Lbl_OthersS.MouseLeave, Lbl_OthersTracking.MouseLeave
        Dim label As Label = sender
        label.BackColor = ColorTranslator.FromHtml("#FBDE44")
    End Sub
    Private Sub CHB_WhiteOrDark_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_WhiteOrDark.CheckedChanged
        If CHB_WhiteOrDark.CheckState = CheckState.Checked Then
            Me.BackColor = ColorTranslator.FromHtml("#040404")
            Lbl_TableName.ForeColor = ColorTranslator.FromHtml("#F1F2F6")
        Else
            Me.BackColor = ColorTranslator.FromHtml("#F1F2F6")
            Lbl_TableName.ForeColor = ColorTranslator.FromHtml("#040404")
        End If
        Panel_Display.BackColor = Me.BackColor
        DataGridView1.BackgroundColor = Panel_Display.BackColor
        CHB_WhiteOrDark.ForeColor = Lbl_TableName.ForeColor
    End Sub
#End Region
#Region "פונקציות עזר"
    Private Sub AllowMenuItems(ByVal LabelNameAllowed As String)
        For Each l As Label In FLP_Move.Controls.OfType(Of Label)()
            If l.Name.Contains(LabelNameAllowed) Then
                l.Visible = True
            Else
                l.Visible = False
            End If
        Next
    End Sub
    Public Sub DesignDataGrid(ByVal DGV As DataGridView)
        For i As Integer = 0 To DGV.RowCount - 1
            If (i + 1) Mod 2 = 1 Then
                DGV.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#42EADD")
                DGV.Rows(i).DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#42EADD")
            End If
            DGV.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Black
        Next
    End Sub
#End Region
#Region "פעולות בעת לחיצה על אחד מן הכפתורים בחלון התפריט"
#Region "Players button options"
    Private Sub Lbl_PlayersAdd_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersAdd.Click
        Me.Hide()
        AddPlayersForm.Show()
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_AddP")
        AddPlayersForm.Tb_PlayerCode.Focus()
    End Sub
    Private Sub Lbl_PlayersUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersUpdate.Click
        Me.Hide()
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_UpdateP")
        UpdatePlayersForm.Show()
    End Sub
    Private Sub Lbl_PlayersAge_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersAge.Click
        ArrCodes = {Manager.GetHomeCode(), ""}
        TableName = "Ages"
        Lbl_TableName.Text = Lbl_PlayersAge.Text
        DataGridView1.DataSource = myHelper.getDataView("Ages", ArrCodes)
        DesignDataGrid(DataGridView1)
        HelpForm.SetSelectedNode("Node_Age")
    End Sub
    Private Sub Lbl_PlayersBirth_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersBirth.Click
        PlayersUpcomingBirthday.Show()
    End Sub
    Private Sub Lbl_PlayersStats_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersStats.Click
        Me.Hide()
        StatsCompares.Show()
    End Sub
#End Region
#Region "Roution button options"
    Private Sub Lbl_RoutionC_Click(sender As Object, e As EventArgs) Handles Lbl_RoutionC.Click
        ArrCodes = {Manager.CheckTeam(), ""}
        TableName = "SubsCode"
        Lbl_TableName.Text = Lbl_RoutionC.Text
        DataGridView1.DataSource = myHelper.getDataView("SubsCode", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_RoutionUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_RoutionUpdate.Click
        Me.Hide()
        PlayersRoutionForm.Show()
    End Sub
#End Region
#Region "Drill button options"
    Private Sub Lbl_DrillsWatch_Click(sender As Object, e As EventArgs) Handles Lbl_DrillsWatch.Click
        Me.Hide()
        DrillWatch.Show()
    End Sub
    Private Sub Lbl_DrillsGrade_Click(sender As Object, e As EventArgs) Handles Lbl_DrillsGrade.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {Manager.GetHomeCode(), ""}
        TableName = "Pgrades"
        Lbl_TableName.Text = Lbl_DrillsGrade.Text
        DataGridView1.DataSource = myHelper.getDataView("Pgrades", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
#End Region
#Region "Games button options"
    Private Sub Lbl_GamesMyTeam_Click(sender As Object, e As EventArgs) Handles Lbl_GamesMyTeam.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {Manager.GetHomeCode(), Manager.GetAwayCode()}
        TableName = "MyTeamGames"
        Lbl_TableName.Text = Lbl_GamesMyTeam.Text
        DataGridView1.DataSource = myHelper.getDataView("MyTeamGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_GamesH_Click(sender As Object, e As EventArgs) Handles Lbl_GamesH.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {Manager.GetHomeCode(), ""}
        TableName = "AwayOrHomeGames"
        Lbl_TableName.Text = Lbl_GamesH.Text
        DataGridView1.DataSource = myHelper.getDataView("AwayOrHomeGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_GamesA_Click(sender As Object, e As EventArgs) Handles Lbl_GamesA.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {"", Manager.GetAwayCode()}
        TableName = "AwayOrHomeGames"
        Lbl_TableName.Text = Lbl_GamesA.Text
        DataGridView1.DataSource = myHelper.getDataView("AwayOrHomeGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_GamesV_Click(sender As Object, e As EventArgs) Handles Lbl_GamesV.Click
        Me.Hide()
        GamesVisionsMyTeamVsOthers.Show()
    End Sub
    Private Sub Lbl_AddingStats_Click(sender As Object, e As EventArgs) Handles Lbl_AddingStats.Click
        Dim n As String = MsgBox("Notice!: If you select yes the system will not allow you closing the window that will open" + vbNewLine + "Until you finish to insert all your players stats" + vbNewLine + "Are you sure you want to open the new window?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            Me.Hide()
            HelpForm.SetFormTag(1)
            HelpForm.SetSelectedNode("Node_PGStats")
            PlayersMatchStatistics.Show()
        End If
    End Sub
#End Region
#Region "Others button options"
    Private Sub Lbl_OthersP_Click(sender As Object, e As EventArgs) Handles Lbl_OthersP.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {"", "", "", "", "", ""}
        TableName = "PlayersAll"
        Lbl_TableName.Text = Lbl_OthersP.Text
        DataGridView1.DataSource = myHelper.getDataView("Players", ArrCodes, 7)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersT_Click(sender As Object, e As EventArgs) Handles Lbl_OthersT.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {"", "", "", "", "", ""}
        TableName = "HomeTeam"
        Lbl_TableName.Text = Lbl_OthersT.Text
        DataGridView1.DataSource = myHelper.getDataView("HomeTeam", ArrCodes, 7)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersG_Click(sender As Object, e As EventArgs) Handles Lbl_OthersG.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {"", ""}
        TableName = "LeagueGames"
        Lbl_TableName.Text = Lbl_OthersG.Text
        DataGridView1.DataSource = myHelper.getDataView("LeagueGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersLeagueLead_Click(sender As Object, e As EventArgs) Handles Lbl_OthersLeagueLead.Click
        CloseOperation()
        LeagueLeaders.Lbl_FormBack.Text = "Managers main"
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_LeagueL")
        LeagueLeaders.Show()
    End Sub
    Private Sub Lbl_OthersS_Click(sender As Object, e As EventArgs) Handles Lbl_OthersS.Click
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        ArrCodes = {"TeamsNames", "=", Manager.CheckTeam(), "", "", ""}
        TableName = "PlayersGamesStats"
        Lbl_TableName.Text = Lbl_OthersS.Text
        DataGridView1.DataSource = myHelper.getDataView("PlayersGamesStats", ArrCodes, 2)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersTracking_Click(sender As Object, e As EventArgs) Handles Lbl_OthersTracking.Click
        Me.Hide()
        TrackPlayers.Show()
    End Sub
#End Region
#Region "Design button options"
    Private Sub OddRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OddRowToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OddRowColor = ColorTranslator.ToHtml(ColorDialog1.Color)
        End If
    End Sub
    Private Sub EvenRowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvenRowToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            EvenRowColor = ColorTranslator.ToHtml(ColorDialog1.Color)
        End If
    End Sub
    Private Sub FontPropertyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontPropertyToolStripMenuItem.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RowFontName = FontDialog1.Font.Name
            RowSize = FontDialog1.Font.Size
            RowFontStyle = FontDialog1.Font.Style
        End If
    End Sub
    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RowFontC = ColorTranslator.ToHtml(ColorDialog1.Color)
        End If
    End Sub
    Private Sub RefreshTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshTableToolStripMenuItem.Click
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If (i + 1) Mod 2 = 1 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml(OddRowColor)
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml(EvenRowColor)
            End If
            DataGridView1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Highlight)
            DataGridView1.Rows(i).DefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.HighlightText)
            DataGridView1.Rows(i).DefaultCellStyle.Font = New Font(RowFontName, RowSize, RowFontStyle)
            DataGridView1.Rows(i).DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(RowFontC)
        Next
    End Sub
#End Region
#Region "Help and Logout buttons events"
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_Manager")
        HelpForm.Show()
    End Sub
    Private Sub Btn_LogOut_Click(sender As Object, e As EventArgs) Handles Btn_LogOut.Click
        CloseOperation()
        LoginForm.ReturnToMe()
    End Sub
#End Region
#End Region
End Class