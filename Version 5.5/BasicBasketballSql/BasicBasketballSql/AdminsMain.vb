Public Class AdminsMain
    Private myHelper As MyDBControler = New MyDBControler() 'Use Non-Shared Function, so to access I must declare connection class varible.
    Private Cerrors As MerrorControl = New MerrorControl()
    Private ArrControls() As Control = New Control() {}
    Private ChekerVal As String, ArrCodes() As String = New String() {}
#Region "פוקנציות שפועלות על הפורם עצמו"
    Private Sub AdminsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set all panels in the center of the form and give them some opacity
        For Each p As Panel In Me.Controls.OfType(Of Panel)()
            p.Location = New Point((Me.Width - p.Width) \ 2, (Me.Height - p.Height) \ 2)
            p.BackColor = Color.FromArgb(75, Color.DarkGray)
        Next
    End Sub
    Private Sub AdminsMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Private Sub CloseOperation()
        Me.Dispose()
        Me.Hide()
    End Sub
    Public Function getDBHelper() As MyDBControler
        Return myHelper
    End Function
#End Region
#Region "פונקציות עזר"
    Private Sub TakeManageInformation(ByVal str As String)
        If str = "Players" Then
            Panel_ManageTeams.Visible = False
            Panel_Games.Visible = False
            Panel_PAndT.Visible = True
            Me.FillTeamsNamesBox(CB_TeamsName)
            Cerrors.setPanelControlsEvents(Panel_PAndT, Me)
        ElseIf str = "Games" Then
            Panel_PAndT.Visible = False
            Panel_ManageTeams.Visible = False
            Panel_Games.Visible = True
            Me.FillGameCodesBox()
            Cerrors.setPanelControlsEvents(Panel_Games, Me)
        ElseIf str = "TeamsAdd" Or str = "TeamsUpdate" Then
            Panel_PAndT.Visible = False
            Panel_Games.Visible = False
            Panel_ManageTeams.Visible = True
            Cerrors.setSplitChar(" ")
            Cerrors.setPanelControlsEvents(Panel_ManageTeams, Me)
        End If
    End Sub
    Private Function StartManaging() As Boolean
        If CB_TeamsName.Text <> "League teams names" Then
            setTeamShortCut(CB_TeamsName.Text)
            Return True
        Else
            MessageBox.Show("Please select league team", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function
    Private Function CheckVailed(ByVal val As Integer) As Boolean
        If val = 1 Then
            If CB_GameCode.Text = "Game code" Or Tb_HostersCval.Text = "Home code" Or Tb_VisitorsCval.Text = "Away code" Or MTB_TimeVal.Text = "" Or MTB_GameDate.Text = "" Then
                MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            Else
                Return False
            End If
        ElseIf val = 2 Then
            If Tb_TeamN.Text = "Team name" Or Tb_ArenaDetail.Text = "Arena name" Or Tb_UserChoice.Text = "User name" Or Tb_PassUVal.Text = "User password" Then
                MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function
#End Region
#Region "אירועים שיופעלו בעת לחיצה על אופציה שבסרגל הבחירה"
    Private Sub AddPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPlayerToolStripMenuItem.Click
        Me.TakeManageInformation("Players")
        Lbl_WhatManage.Text = "AddP"
        ArrControls = {Lbl_PTeamGcode, Lbl_PTGameDate, Lbl_PTGameT, MTB_PGameDval, MTB_PTGameTval, Tb_TGameCval}
        Cerrors.setControlsVisibilty(ArrControls, False)
    End Sub
    Private Sub UpdatePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePlayerToolStripMenuItem.Click
        Me.TakeManageInformation("Players")
        Lbl_WhatManage.Text = "UpdateP"
        ArrControls = {Lbl_PTeamGcode, Lbl_PTGameDate, Lbl_PTGameT, MTB_PGameDval, MTB_PTGameTval, Tb_TGameCval}
        Cerrors.setControlsVisibilty(ArrControls, False)
    End Sub
    Private Sub DeletePlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePlayerToolStripMenuItem.Click
        Me.TakeManageInformation("Players")
        Lbl_WhatManage.Text = "DeleteP"
        ArrControls = {Lbl_PTeamGcode, Lbl_PTGameDate, Lbl_PTGameT, MTB_PGameDval, MTB_PTGameTval, Tb_TGameCval}
        Cerrors.setControlsVisibilty(ArrControls, False)
    End Sub
    Private Sub AddGameStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGameStatsToolStripMenuItem.Click
        Me.TakeManageInformation("Players")
        Lbl_WhatManage.Text = "AddPlayerStats"
        ArrControls = {Lbl_PTeamGcode, Lbl_PTGameDate, Lbl_PTGameT, MTB_PGameDval, MTB_PTGameTval, Tb_TGameCval}
        Cerrors.setControlsVisibilty(ArrControls, True)
    End Sub
    Private Sub AddGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGameToolStripMenuItem.Click
        Me.Tb_HostersCval.Text = "Home code"
        Me.Tb_VisitorsCval.Text = "Away code"
        Me.Tb_Locationval.Text = "Arena name"
        Me.MTB_TimeVal.Text = ""
        Me.MTB_GameDate.Text = Date.Now().ToString("dd\/MM\/yyyy")
        Me.TakeManageInformation("Games")
        Me.Lbl_PgameName.Text = "Add games"
        Me.Pic_PicGames.Image = My.Resources.saveicon
        Me.Pic_PicGames.Tag = "Save"
        Me.CB_GameCode.Text = CB_GameCode.Items.Item(CB_GameCode.Items.Count - 1).ToString() + 1
        ChekerVal = myHelper.getCountResults("CountGamesInMaxGameType").ToString()
        Tb_GameTypeval.Text = myHelper.getCountResults("CountMaxGameType").ToString()
        If ChekerVal = "6" Then 'If there is 6 game in the max game type, increase gametype
            Tb_GameTypeval.Text = Tb_GameTypeval.Text + 1
        End If
        Me.CB_GameCode.Enabled = False
        Me.Pb_Switch.Visible = False
        Me.Pic_PicGames.Focus()
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_AddGame")
    End Sub
    Private Sub UpdateGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateGameToolStripMenuItem.Click
        Me.CB_GameCode.Text = "Game code"
        Me.Tb_GameTypeval.Text = "Game type"
        Me.Tb_HostersCval.Text = "Home code"
        Me.Tb_VisitorsCval.Text = "Away code"
        Me.Tb_Locationval.Text = "Arena name"
        Me.MTB_TimeVal.Text = ""
        Me.MTB_GameDate.Text = ""
        Me.TakeManageInformation("Games")
        Me.Lbl_PgameName.Text = "Update games"
        Me.Pic_PicGames.Image = My.Resources.update
        Me.Pic_PicGames.Tag = "Update"
        Me.CB_GameCode.Enabled = True
        Me.Pb_Switch.Visible = True
        Me.Pb_Switch.Focus()
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_UpdateGame")
    End Sub
    Private Sub LeagueLeadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeagueLeadersToolStripMenuItem.Click
        CloseOperation()
        LeagueLeaders.Lbl_FormBack.Text = "Admins main"
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_AdmLeagueL")
        LeagueLeaders.Show()
    End Sub
    Private Sub AddTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTeamToolStripMenuItem.Click
        Me.Tb_HcodeVal.Text = (myHelper.getCountResults("CountMaxHomeCode") + 10).ToString()
        Me.Tb_AcodeVal.Text = (myHelper.getCountResults("CountMaxAwayCode") + 10).ToString()
        Me.Tb_ArenaDetail.Text = "Arena name"
        Me.TakeManageInformation("TeamsAdd")
        ArrControls = {CB_TeamUpdate, Pic_Clear, CHB_TeamNChange}
        Cerrors.setControlsVisibilty(ArrControls, False)
        Me.Pic_ManageTeamsPic.Image = My.Resources.saveicon
        Me.Pic_ManageTeamsPic.Tag = "Save"
        ArrControls = {Tb_UserChoice, Tb_PassUVal, Lbl_UserInfo, Tb_TeamN, LB_UserOptions}
        Cerrors.setControlsVisibilty(ArrControls, True)
        Me.Pic_ManageTeamsPic.Focus()
        Me.LB_UserOptions.Items.Clear()
        FillTeamsNamesBox(CB_TeamUpdate)
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_AddTeam")
    End Sub
    Private Sub UpdateTeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateTeamToolStripMenuItem.Click
        Me.CB_TeamUpdate.Text = "League teams names"
        Me.Tb_ArenaDetail.Text = "Arena name"
        Me.TakeManageInformation("TeamsUpdate")
        ArrControls = {CB_TeamUpdate, Pic_Clear, CHB_TeamNChange}
        Cerrors.setControlsVisibilty(ArrControls, True)
        Me.Pic_ManageTeamsPic.Image = My.Resources.update
        Me.Pic_ManageTeamsPic.Tag = "Update"
        ArrControls = {Tb_UserChoice, Tb_PassUVal, Lbl_UserInfo, Tb_TeamN, LB_UserOptions}
        Cerrors.setControlsVisibilty(ArrControls, False)
        Me.Pic_ManageTeamsPic.Focus()
        FillTeamsNamesBox(CB_TeamUpdate)
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_UpdateTeam")
    End Sub
    Private Sub PlayersChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayersChangesToolStripMenuItem.Click
        CloseOperation()
        AdminsManage.Lbl_TableName.Text = "Players changes"
        AdminsManage.Show()
    End Sub
    Private Sub StatsChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsChangesToolStripMenuItem.Click
        CloseOperation()
        AdminsManage.Lbl_TableName.Text = "Stats changes"
        AdminsManage.Show()
    End Sub
    Private Sub GamesChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GamesChangesToolStripMenuItem.Click
        CloseOperation()
        AdminsManage.Lbl_TableName.Text = "Games changes"
        AdminsManage.Show()
    End Sub
    Private Sub HelpMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpMeToolStripMenuItem.Click
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_Admin")
        HelpForm.Show()
    End Sub
#End Region
#Region "לחיצות על התמונות שיש בפאנלים"
    Private Sub Pb_Switch_Click(sender As Object, e As EventArgs) Handles Pb_Switch.Click
        Dim temp As String = Tb_VisitorsCval.Text - 5
        Tb_VisitorsCval.Text = Tb_HostersCval.Text + 5
        Tb_HostersCval.Text = temp
        Tb_Locationval.Text = myHelper.getColumn("Arena", Tb_HostersCval.Text)
    End Sub
    Private Sub Pic_PicGames_Click(sender As Object, e As EventArgs) Handles Pic_PicGames.Click
        If Pic_PicGames.Tag = "Update" Then
            If CheckVailed(1) Then
                Exit Sub
            End If
            ArrCodes = {CB_GameCode.Text, MTB_TimeVal.Text, Tb_Locationval.Text, Tb_GameTypeval.Text, Tb_HostersCval.Text, Tb_VisitorsCval.Text, MTB_GameDate.Text}
            myHelper.UpdatedTwoTables(Me, ArrCodes, "Games")
            MessageBox.Show("Successfully Updated", "Game details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FillGameCodesBox()
            CB_GameCode.Enabled = True
        ElseIf Pic_PicGames.Tag = "Save" Then
            If CheckVailed(1) Then
                Exit Sub
            End If
            myHelper.InsertToTwoTables(Me, "AddGames")
            MessageBox.Show("Successfully added", "Game details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Pic_Confirm_Click(sender As Object, e As EventArgs) Handles Pic_Confirm.Click
        If StartManaging() = True Then
            HelpForm.SetFormTag(0)
            Select Case Lbl_WhatManage.Text
                Case "AddP"
                    HelpForm.SetSelectedNode("Node_AdmAddP")
                    AddPlayersForm.Lbl_FormBack.Text = "Admins main"
                    AddPlayersForm.Show()
                Case "UpdateP"
                    HelpForm.SetSelectedNode("Node_AdmUpdateP")
                    UpdatePlayersForm.Lbl_FormBack.Text = "Admins main"
                    UpdatePlayersForm.Show()
                Case "DeleteP"
                    PlayersDeleteForm.Show()
                Case "AddPlayerStats"
                    If Trim(Tb_TGameCval.Text) <> "" AndAlso Trim(MTB_PGameDval.Text) <> "" AndAlso Trim(MTB_PTGameTval.Text) <> "" Then
                        HelpForm.SetSelectedNode("Node_AdminAddStats")
                        PlayersMatchStatistics.Lbl_FormBack.Text = "Admins main"
                        PlayersMatchStatistics.TB_GamesCodes.Text = Tb_TGameCval.Text
                        PlayersMatchStatistics.Tb_GamesTypes.Text = MTB_PTGameTval.Text
                        PlayersMatchStatistics.Tb_GamesDate.Text = MTB_PGameDval.Text
                        PlayersMatchStatistics.Show()
                    Else
                        MessageBox.Show("One of your field is empty")
                        Exit Sub
                    End If
            End Select
            CloseOperation()
        End If
    End Sub
    Private Sub Pic_Logout_Click(sender As Object, e As EventArgs) Handles Pic_Logout.Click
        CloseOperation()
        LoginForm.ReturnToMe()
    End Sub
    Private Sub Pic_ManageTeamsPic_Click(sender As Object, e As EventArgs) Handles Pic_ManageTeamsPic.Click
        If Pic_ManageTeamsPic.Tag = "Update" Then
            If Tb_ArenaDetail.Text = "" Or Tb_ArenaDetail.Text = "Arena name" Then
                MsgBox("Unvailed arena name")
                Exit Sub
            End If
            If CHB_TeamNChange.Checked = True AndAlso Tb_TeamN.Text = "Team name" Or Tb_TeamN.Text = "" Then
                MsgBox("Unvailed team name")
                Exit Sub
            End If
            Dim NameCheck As String = myHelper.getColumn("TeamName", Tb_TeamN.Text) 'אם יש קבוצה כזו עם אותו שם
            If NameCheck.Length <> 0 Then
                MsgBox("There is already team with that name, please input other name")
                Exit Sub
            End If
            If CHB_TeamNChange.Checked = True Then
                ArrCodes = {Tb_TeamN.Text, Tb_AcodeVal.Text, Tb_HcodeVal.Text, Tb_ArenaDetail.Text}
            Else
                ArrCodes = {CB_TeamUpdate.Text, Tb_AcodeVal.Text, Tb_HcodeVal.Text, Tb_ArenaDetail.Text}
            End If
            myHelper.UpdatedTwoTables(Me, ArrCodes, "Teams")
            MessageBox.Show("Successfully Updated", "Team details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FillTeamsNamesBox(CB_TeamUpdate)
            CHB_TeamNChange.CheckState = CheckState.Unchecked
        ElseIf Pic_ManageTeamsPic.Tag = "Save" Then
            If CheckVailed(2) Then
                Exit Sub
            End If
            Dim NameCheck As String = myHelper.getColumn("TeamName", Tb_TeamN.Text) 'אם יש קבוצה כזו עם אותו שם
            If NameCheck.Length <> 0 Then
                MessageBox.Show("There is already team with that name, please input other name")
                Exit Sub
            End If
            Dim UserD() As String = {Tb_UserChoice.Text, Tb_PassUVal.Text}
            myHelper.getDBLogin(1, Tb_TeamN.Text, UserD)
            myHelper.InsertToTwoTables(Me, "AddTeams")
            MessageBox.Show("Successfully added", "Team details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Pic_Clear_Click(sender As Object, e As EventArgs) Handles Pic_Clear.Click
        CB_TeamUpdate.Text = "League teams names"
        Tb_ArenaDetail.Text = "Arena name"
        Tb_HcodeVal.Text = "Home code"
        Tb_AcodeVal.Text = "Away code"
        CB_TeamUpdate.Enabled = True
    End Sub
#End Region
#Region "פונקציות למילוי תיבות הבחירה או רשימות הבחירה"
    Public Sub FillTeamsNamesBox(cmb As ComboBox)
        myHelper.FillBoxes(cmb, "Get all teams names")
    End Sub
    Public Sub FillGameCodesBox()
        myHelper.FillBoxes(CB_GameCode, "Get all games codes")
    End Sub
    Public Sub UsersSubString(ByVal s As String, ByVal n As Integer)
        Dim i As Integer, len As Integer, Str2 As String, CheckUser As String
        For i = 0 To n
            For len = 0 To n - i
                Str2 = s.Substring(i, len)
                If Str2.Length = 3 AndAlso Not Str2.Contains("-") Then
                    LB_UserOptions.Items.Add(Str2.ToUpper())
                End If
            Next
        Next
        For i = 0 To CB_TeamUpdate.Items.Count - 1
            CheckUser = myHelper.getColumn("MyName", CB_TeamUpdate.Items.Item(i).ToString()) 'If there is already exsiting username
            If CheckUser IsNot Nothing Then
                LB_UserOptions.Items.Remove(CheckUser)
            End If
        Next
    End Sub
#End Region
#Region "פונקציה לקבלת קיצור שמות הקבוצות לשימוש בפורומים של ניהול קבוצות או שחקנים"
    Public Sub setTeamShortCut(ByVal code As String)
        LoginForm.setManagerName(myHelper.getColumn("MyName", code, "Admins"))
    End Sub
#End Region
#Region "איוונטים על אובייקטים שנמצאים בפאנלים"
    Private Sub CB_GameCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_GameCode.SelectedIndexChanged
        myHelper.ComboBoxSelectChange(Me, CB_GameCode, 1)
        CB_GameCode.Enabled = False
    End Sub
    Private Sub Tb_HostersCval_Leave(sender As Object, e As EventArgs) Handles Tb_HostersCval.Leave
        Tb_Locationval.Text = myHelper.getColumn("Arena", Tb_HostersCval.Text)
    End Sub
    Private Sub Tb_TeamN_Leave(sender As Object, e As EventArgs) Handles Tb_TeamN.Leave
        Dim index As Integer, cnt As Integer = 0
        Dim Fchar As Char, SecChar As Char, LChar As Char, FirstLetters As String = ""
        If Tb_TeamN.Text <> "Team name" AndAlso Tb_TeamN.Text <> "" AndAlso Tb_TeamN.Text <> " " Then 'כדי שהפונקציה לא תעבוד על ברירת המחדל של תיבת הטקסט או על טקסט ריק
            Tb_TeamN.Text = Tb_TeamN.Text.Replace(" ", "-")
            Tb_TeamN.Text = Tb_TeamN.Text.Substring(0, 1).ToUpper() + Tb_TeamN.Text.Substring(1).ToLower()
            For index = 0 To Tb_TeamN.Text.Length - 1
                If Tb_TeamN.Text.Chars(index) = "-" AndAlso Char.IsLetter((Tb_TeamN.Text.Chars(index + 1))) Then
                    cnt = cnt + 1
                    Tb_TeamN.Text = Tb_TeamN.Text.Replace(Tb_TeamN.Text.Chars(index + 1), Char.ToUpper(Tb_TeamN.Text.Chars(index + 1)))
                    If cnt = 1 AndAlso Char.IsLetter((Tb_TeamN.Text.Chars(index + 1))) Then
                        Fchar = Tb_TeamN.Text.Substring(0, 1)
                        SecChar = Tb_TeamN.Text.Chars(index + 1)
                    End If
                    If cnt = 2 AndAlso Char.IsLetter((Tb_TeamN.Text.Chars(index + 1))) Then
                        LChar = Tb_TeamN.Text.Chars(index + 1)
                        FirstLetters = Fchar & "" & SecChar & "" & LChar
                        FirstLetters.ToUpper()
                    End If
                End If
            Next
            LB_UserOptions.Items.Clear()
            If FirstLetters.Length = 3 Then
                LB_UserOptions.Items.Add(FirstLetters)
            End If
            UsersSubString(Tb_TeamN.Text, Tb_TeamN.Text.Length)
        End If
    End Sub
    Private Sub CB_TeamUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_TeamUpdate.SelectedIndexChanged
        myHelper.ComboBoxSelectChange(Me, CB_TeamUpdate, 2)
        CB_TeamUpdate.Enabled = False
    End Sub
    Private Sub CHB_TeamNChange_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_TeamNChange.CheckedChanged
        If CHB_TeamNChange.Checked = True Then
            Tb_TeamN.Text = CB_TeamUpdate.Text
            Tb_TeamN.Visible = True
            CB_TeamUpdate.Enabled = True
            CB_TeamUpdate.Visible = False
            CB_TeamUpdate.Text = "League teams names"
        Else
            Tb_TeamN.Text = "Team name"
            Tb_TeamN.Visible = False
            CB_TeamUpdate.Visible = True
            CB_TeamUpdate.Enabled = True
        End If
    End Sub
    Private Sub LB_UserOptions_MouseClick(sender As Object, e As MouseEventArgs) Handles LB_UserOptions.MouseClick
        Dim index As Integer = LB_UserOptions.SelectedIndex
        Tb_UserChoice.Text = LB_UserOptions.Items(index)
    End Sub
    Private Sub Pic_ManageTHelp_Click(sender As Object, e As EventArgs) Handles Pic_ManageTHelp.Click
        HelpForm.Show()
    End Sub
    Private Sub Pic_GameHelp_Click(sender As Object, e As EventArgs) Handles Pic_GameHelp.Click
        HelpForm.Show()
    End Sub
#End Region
End Class