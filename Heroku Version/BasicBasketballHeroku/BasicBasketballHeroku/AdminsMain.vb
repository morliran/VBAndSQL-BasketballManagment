Public Class AdminsMain
    Private myHelper As MyDBControler = New MyDBControler() 'Use Non-Shared Function, so to access I must declare connection class varible.
    Private Cerrors As MerrorControl = New MerrorControl()
    Private ArrControls() As Control = New Control() {}, ChekerVal As String, ArrCodes() As String = New String() {}, AwayCflag As Boolean = False, HomeCflag As Boolean = False
#Region "פוקנציות שפועלות על הפורם עצמו"
    Private Sub AdminsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterAllDispPanels()
        Accessibility.SetDesignToAllForms(Me)
        TB_PTemp.Font = New Font(TB_PTemp.Font.FontFamily.Name, 6)
        TB_MTeamTemp.Font = New Font(TB_MTeamTemp.Font.FontFamily.Name, 6)
        TB_GaTemp.Font = New Font(TB_GaTemp.Font.FontFamily.Name, 6)
    End Sub
    Private Sub AdminsMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Btn_LogOut.PerformClick()
    End Sub
    Private Sub Panel_Display_Resize(sender As Object, e As EventArgs) Handles Panel_Display.Resize
        CenterAllDispPanels()
    End Sub
    Private Sub ThePanel_MouseHover(sender As Object, e As EventArgs) Handles Btn_MangeT.MouseHover, Btn_MangeP.MouseHover, Btn_MangeG.MouseHover, Btn_MangeL.MouseHover, Btn_Help.MouseHover, Btn_LogOut.MouseHover
        Dim btn As Button = sender
        btn.ForeColor = Color.DeepSkyBlue
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
        Panel_Display.Visible = False
        FLP_Move.Visible = True
        FLP_Move.AutoSize = False
        FLP_Move.Width = 8
        FLP_Move.Height = btn.Height
        FLP_Move.Top = btn.Top
        Select Case btn.Name
            Case "Btn_MangeT"
                Cerrors.AllowRootControls(Of Label)(FLP_Move, "Teams")
                Timer_Menu.Start()
            Case "Btn_MangeP"
                Cerrors.AllowRootControls(Of Label)(FLP_Move, "Players")
                Timer_Menu.Start()
            Case "Btn_MangeG"
                Cerrors.AllowRootControls(Of Label)(FLP_Move, "Games")
                Timer_Menu.Start()
            Case "Btn_MangeL"
                Cerrors.AllowRootControls(Of Label)(FLP_Move, "League")
                Timer_Menu.Start()
            Case "Btn_Help"
                Cerrors.AllowRootControls(Of Label)(FLP_Move, "Help")
            Case "Btn_LogOut"
                Cerrors.AllowRootControls(Of Label)(FLP_Move, "Logout")
        End Select
    End Sub
    Private Sub ThePanel_MouseLeave(sender As Object, e As EventArgs) Handles Btn_MangeT.MouseLeave, Btn_MangeP.MouseLeave, Btn_MangeL.MouseLeave, Btn_MangeG.MouseLeave, Btn_LogOut.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = Color.Black
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
    Private Sub LabelsMouseEnters(sender As Object, e As EventArgs) Handles Lbl_TeamsAdd.MouseEnter, Lbl_TeamsUpdate.MouseEnter, Lbl_PlayersAdd.MouseEnter, Lbl_PlayersUpdate.MouseEnter, Lbl_PlayersDelete.MouseEnter, Lbl_GamesAdd.MouseEnter, Lbl_GamesUpdate.MouseEnter, Lbl_GamesAddStats.MouseEnter, Lbl_LeagueLead.MouseEnter, Lbl_LeaguePChanges.MouseEnter, Lbl_LeagueSChanges.MouseEnter, Lbl_LeagueGChanges.MouseEnter
        Dim label As Label = sender
        label.ForeColor = Color.DeepSkyBlue
        label.Font = New Font(label.Font.FontFamily.Name, label.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub LabelsMouseLeave(sender As Object, e As EventArgs) Handles Lbl_TeamsAdd.MouseLeave, Lbl_TeamsUpdate.MouseLeave, Lbl_PlayersAdd.MouseLeave, Lbl_PlayersUpdate.MouseLeave, Lbl_PlayersDelete.MouseLeave, Lbl_GamesAdd.MouseLeave, Lbl_GamesUpdate.MouseLeave, Lbl_GamesAddStats.MouseLeave, Lbl_LeagueLead.MouseLeave, Lbl_LeaguePChanges.MouseLeave, Lbl_LeagueSChanges.MouseLeave, Lbl_LeagueGChanges.MouseLeave
        Dim label As Label = sender
        label.ForeColor = Color.Black
        label.Font = New Font(label.Font.FontFamily.Name, label.Font.Size, FontStyle.Regular)
    End Sub
    Private Sub Timer_Menu_Tick(sender As Object, e As EventArgs) Handles Timer_Menu.Tick
        FLP_Move.Width = FLP_Move.Width + 20
        If FLP_Move.Width > Btn_MangeT.Width * 2 Then
            FLP_Move.AutoSize = True
            Timer_Menu.Stop()
        End If
    End Sub
    Private Sub CloseOperation()
        Me.Dispose()
        Me.Hide()
    End Sub
#End Region
#Region "פונקציות עזר"
    ''' <summary>
    ''' Set all panels in the center of the form
    ''' </summary>
    Private Sub CenterAllDispPanels()
        For Each p As Panel In Panel_Display.Controls.OfType(Of Panel)()
            p.Location = New Point((Panel_Display.Width - p.Width) \ 2, (Panel_Display.Height - p.Height) \ 2)
        Next
    End Sub
    ''' <summary>
    ''' This sub open the panel that the league manager will going to work inside him
    ''' </summary>>
    Private Sub TakeManageInformation(ByVal WhatManage As String)
        Panel_Display.Visible = True
        FLP_Move.Visible = False
        FLP_Move.AutoSize = False
        If WhatManage.Equals("Players") Then
            Cerrors.AllowRootControls(Of Panel)(Panel_Display, Panel_PAndT.Name)
            FillPanelBoxs(CB_TeamsName)
            Cerrors.SetPanelControlsEvents(Panel_PAndT, Me)
            TB_PTemp.Focus()
        ElseIf WhatManage.Equals("Games") Then
            Cerrors.AllowRootControls(Of Panel)(Panel_Display, Panel_Games.Name)
            FillPanelBoxs(CB_GameCode)
            Cerrors.SetPanelControlsEvents(Panel_Games, Me)
            TB_GaTemp.Focus()
        ElseIf WhatManage.Equals("TeamsAdd") Or WhatManage.Equals("TeamsUpdate") Then
            Cerrors.AllowRootControls(Of Panel)(Panel_Display, Panel_ManageTeams.Name)
            Cerrors.SetSplitChar(" ")
            Cerrors.SetPanelControlsEvents(Panel_ManageTeams, Me)
            TB_MTeamTemp.Focus()
        ElseIf WhatManage.Equals("AdminManage") Then
            Cerrors.AllowRootControls(Of Panel)(Panel_Display, Panel_AdminManage.Name)
        End If
    End Sub
    ''' <summary>
    ''' This function make sure that the league manager will work only on the team that he/she selected
    ''' </summary>
    Private Function StartManaging() As Boolean
        If Not CB_TeamsName.Text.Equals("League teams names") Then
            Panel_ButtomMove.Visible = True
            SetTeamShortCut(CB_TeamsName.Text)
            Return True
        Else
            MessageBox.Show("Please select league team", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function
    ''' <summary>
    ''' This function check for empty values on some controllers that inside some panel
    ''' </summary>
    Private Function CheckVailed(ByVal PanelNumber As Integer) As Boolean
        If PanelNumber = 1 Then
            If CB_GameCode.Text.Equals("Game code") Or Tb_HostersCval.Text.Equals("Home code") Or Tb_VisitorsCval.Text.Equals("Away code") Or MTB_TimeVal.MaskCompleted = False Or MTB_GameDate.MaskCompleted = False Or AwayCflag = False Or HomeCflag = False Then
                MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            Else
                Return False
            End If
        ElseIf PanelNumber = 2 Then
            If Tb_TeamN.Text.Equals("Team name") Or Tb_ArenaDetail.Text.Equals("Arena name") Or Tb_UserChoice.Text.Equals("User name") Or Tb_PassUVal.Text.Equals("User password") Then
                MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function
    Private Sub SetDeleteDataView(ByVal TeamHomecode As String)
        Dim Arr() As String = New String() {"HisHomeTeamCode", "=", TeamHomecode, "", "", ""}, intHeight As Integer
        DataGridView2.Columns.Clear()
        DataGridView2.DataSource = myHelper.GetDataView("Players", Arr, 2)
        DataGridView2.Columns(10).Visible = False
        DataGridView2.Columns(9).Visible = False
        For Each rowheight As DataGridViewRow In DataGridView2.Rows 'שינוי גודל הטבלה כך שתתאים לטבלה המוחזרת מהבסיס נתונים
            intHeight += rowheight.Height
        Next
        DataGridView2.Height = intHeight + 23
        DesignDataGrid(DataGridView2)
    End Sub
    Public Sub DesignDataGrid(ByVal DGV As DataGridView)
        Accessibility.SetDataGridDesign(DGV, 1)
    End Sub
#End Region
#Region "אירועים שיופעלו בעת לחיצה על אופציה שבסרגל הבחירה"
    Private Sub Lbl_TeamsAdd_Click(sender As Object, e As EventArgs) Handles Lbl_TeamsAdd.Click
        Tb_HcodeVal.Text = (myHelper.GetCountResults("CountMaxHomeCode") + 10).ToString()
        Tb_AcodeVal.Text = (myHelper.GetCountResults("CountMaxAwayCode") + 10).ToString()
        Tb_ArenaDetail.Text = "Arena name"
        TakeManageInformation("TeamsAdd")
        ArrControls = {CB_TeamUpdate, Pic_Clear, CHB_TeamNChange}
        Cerrors.SetControlsVisibilty(ArrControls, False)
        Pic_ManageTeamsPic.Image = My.Resources.saveicon
        Pic_ManageTeamsPic.Tag = "Save"
        ArrControls = {Tb_UserChoice, Tb_PassUVal, Lbl_UserInfo, Tb_TeamN, LB_UserOptions}
        Cerrors.SetControlsVisibilty(ArrControls, True)
        Pic_ManageTeamsPic.Focus()
        LB_UserOptions.Items.Clear()
        FillPanelBoxs(CB_TeamUpdate)
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_AddTeam")
    End Sub
    Private Sub Lbl_TeamsUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_TeamsUpdate.Click
        CB_TeamUpdate.Text = "League teams names"
        Tb_ArenaDetail.Text = "Arena name"
        Tb_HcodeVal.Text = "Home code"
        Tb_AcodeVal.Text = "Away code"
        TakeManageInformation("TeamsUpdate")
        ArrControls = {CB_TeamUpdate, Pic_Clear, CHB_TeamNChange}
        Cerrors.SetControlsVisibilty(ArrControls, True)
        Pic_ManageTeamsPic.Image = My.Resources.update
        Pic_ManageTeamsPic.Tag = "Update"
        ArrControls = {Tb_UserChoice, Tb_PassUVal, Lbl_UserInfo, Tb_TeamN, LB_UserOptions}
        Cerrors.SetControlsVisibilty(ArrControls, False)
        Pic_ManageTeamsPic.Focus()
        FillPanelBoxs(CB_TeamUpdate)
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_UpdateTeam")
    End Sub
    Private Sub Lbl_PlayersAdd_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersAdd.Click
        TakeManageInformation("Players")
        Lbl_WhatManage.Text = "AddP"
        ArrControls = {Tb_GameDate, Tb_TGameCval, CB_Gametype, Btn_ChooseAgain}
        Cerrors.SetControlsVisibilty(ArrControls, False)
    End Sub
    Private Sub Lbl_PlayersUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersUpdate.Click
        TakeManageInformation("Players")
        Lbl_WhatManage.Text = "UpdateP"
        ArrControls = {Tb_GameDate, Tb_TGameCval, CB_Gametype, Btn_ChooseAgain}
        Cerrors.SetControlsVisibilty(ArrControls, False)
    End Sub
    Private Sub Lbl_PlayersDelete_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersDelete.Click
        TakeManageInformation("Players")
        Lbl_WhatManage.Text = "DeleteP"
        ArrControls = {Tb_GameDate, Tb_TGameCval, CB_Gametype, Btn_ChooseAgain, Panel_ButtomMove}
        Cerrors.SetControlsVisibilty(ArrControls, False)
    End Sub
    Private Sub Lbl_GamesAdd_Click(sender As Object, e As EventArgs) Handles Lbl_GamesAdd.Click
        Tb_HostersCval.Text = "Home code"
        Tb_VisitorsCval.Text = "Away code"
        Tb_Locationval.Text = "Arena name"
        myHelper.FillBoxes(CB_HomeC, "Get all home codes")
        myHelper.FillBoxes(CB_AwayC, "Get all away codes")
        MTB_TimeVal.Clear()
        MTB_GameDate.Text = Date.Now().ToString("dd\/MM\/yyyy")
        TakeManageInformation("Games")
        Lbl_PgameName.Text = "Add games"
        Pic_PicGames.Image = My.Resources.saveicon
        Pic_PicGames.Tag = "Save"
        CB_GameCode.Text = CB_GameCode.Items.Item(CB_GameCode.Items.Count - 1).ToString() + 1
        ChekerVal = myHelper.GetCountResults("CountGamesInMaxGameType").ToString()
        Tb_Gametypeval.Text = myHelper.GetCountResults("CountMaxGameType").ToString()
        If ChekerVal.Equals("6") Then 'אם יש כבר 6 משחקים במחזור המקסימאלי, אעלה את ערך המחזור ב-1
            Tb_Gametypeval.Text = Tb_Gametypeval.Text + 1
        End If
        CB_GameCode.Enabled = False
        Pb_Switch.Visible = False
        Btn_GaAgain.Visible = False
        Pic_PicGames.Focus()
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_AddGame")
    End Sub
    Private Sub Lbl_GamesUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_GamesUpdate.Click
        CB_GameCode.Text = "Game code"
        Tb_Gametypeval.Text = "Game type"
        Tb_HostersCval.Text = "Home code"
        Tb_VisitorsCval.Text = "Away code"
        myHelper.FillBoxes(CB_HomeC, "Get all home codes")
        myHelper.FillBoxes(CB_AwayC, "Get all away codes")
        MTB_TimeVal.Clear()
        MTB_GameDate.Clear()
        TakeManageInformation("Games")
        Tb_Locationval.Text = "Arena name"
        Lbl_PgameName.Text = "Update games"
        Pic_PicGames.Image = My.Resources.update
        Pic_PicGames.Tag = "Update"
        CB_GameCode.Enabled = True
        Pb_Switch.Visible = True
        Btn_GaAgain.Visible = True
        Pb_Switch.Focus()
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_UpdateGame")
    End Sub
    Private Sub Lbl_GamesAddStats_Click(sender As Object, e As EventArgs) Handles Lbl_GamesAddStats.Click
        TakeManageInformation("Players")
        Lbl_WhatManage.Text = "AddPlayerStats"
        Tb_GameDate.Text = "Game date"
        Tb_TGameCval.Text = "Game code"
        CB_Gametype.Enabled = True
        ArrControls = {Tb_GameDate, Tb_TGameCval, CB_Gametype, Btn_ChooseAgain}
        Cerrors.SetControlsVisibilty(ArrControls, True)
        Panel_ButtomMove.Visible = False
    End Sub
    Private Sub Lbl_LeagueLead_Click(sender As Object, e As EventArgs) Handles Lbl_LeagueLead.Click
        CloseOperation()
        LeagueLeaders.Lbl_FormBack.Text = "Admins main"
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_AdminLeagueL")
        LeagueLeaders.Show()
    End Sub
    Private Sub Lbl_LeaguePChanges_Click(sender As Object, e As EventArgs) Handles Lbl_LeaguePChanges.Click
        TakeManageInformation("AdminManage")
        ArrCodes = {"", "", "", "", "", ""}
        DataGridView1.DataSource = myHelper.GetDataView("tb_PlayersAuidit", ArrCodes, 7)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_LeagueSChanges_Click(sender As Object, e As EventArgs) Handles Lbl_LeagueSChanges.Click
        TakeManageInformation("AdminManage")
        ArrCodes = {"", "", "", "", "", ""}
        DataGridView1.DataSource = myHelper.GetDataView("tb_StatsAuidit", ArrCodes, 7)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_LeagueGChanges_Click(sender As Object, e As EventArgs) Handles Lbl_LeagueGChanges.Click
        TakeManageInformation("AdminManage")
        ArrCodes = {"", "", "", "", "", ""}
        DataGridView1.DataSource = myHelper.GetDataView("tb_GameAuidit", ArrCodes, 7)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_Admin")
        HelpForm.Show()
    End Sub
    Private Sub Btn_LogOut_Click(sender As Object, e As EventArgs) Handles Btn_LogOut.Click
        CloseOperation()
        MainView.ReturnToMe()
    End Sub
#End Region
#Region "לחיצות על התמונות או הכפתורים שיש בפאנלים"
    Private Sub Pb_Switch_Click(sender As Object, e As EventArgs) Handles Pb_Switch.Click
        Dim temp As String = Tb_VisitorsCval.Text - 5
        Tb_VisitorsCval.Text = Tb_HostersCval.Text + 5
        Tb_HostersCval.Text = temp
        Tb_Locationval.Text = myHelper.GetColumn("Arena", Tb_HostersCval.Text)
    End Sub
    Private Sub Pic_PicGames_Click(sender As Object, e As EventArgs) Handles Pic_PicGames.Click
        If Pic_PicGames.Tag = "Update" Then
            If CheckVailed(1) Then
                Exit Sub
            End If
            ArrCodes = {CB_GameCode.Text, MTB_TimeVal.Text, Tb_Locationval.Text, Tb_Gametypeval.Text, Tb_HostersCval.Text, Tb_VisitorsCval.Text, MTB_GameDate.Text}
            myHelper.UpdatedTwoTables(Me, ArrCodes, "Games")
            MessageBox.Show("Successfully Updated", "Game details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FillPanelBoxs(CB_GameCode)
            CB_GameCode.Enabled = True
        ElseIf Pic_PicGames.Tag = "Save" Then
            If CheckVailed(1) Then
                Exit Sub
            End If
            If Tb_HostersCval.Text = Tb_VisitorsCval.Text - 5 Or Tb_VisitorsCval.Text = Tb_HostersCval.Text + 5 Then
                MessageBox.Show("Cant add the same team", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    ManagersMain.Lbl_BackTo.Text = "Admins main"
                    ManagersMain.Show()
                    ManagersMain.Btn_AdAdd.PerformClick()
                    CloseOperation()
                Case "UpdateP"
                    HelpForm.SetSelectedNode("Node_AdmUpdateP")
                    ManagersMain.Lbl_BackTo.Text = "Admins main"
                    ManagersMain.Show()
                    ManagersMain.Btn_AdUpdate.PerformClick()
                    CloseOperation()
                Case "DeleteP"
                    HelpForm.SetSelectedNode("Node_AdmDeleteP")
                    Panel_PlayerDel.Visible = True
                    Panel_PAndT.Visible = False
                    Lbl_PDeleteTeamName.Text = "Click on some row to select player to delete from " & ClassCheckManager.GetManagerTeamName() & vbNewLine & "And then click on the delete button"
                    SetDeleteDataView(ClassCheckManager.GetHomeC())
                Case "AddPlayerStats"
                    If Not CB_Gametype.Text.Equals("Game type") AndAlso Not CB_TeamsName.Text.Equals("League teams names") AndAlso
                        Not Tb_TGameCval.Text.Equals("Game code") AndAlso Not Tb_GameDate.Text.Equals("Game date") Then
                        HelpForm.SetSelectedNode("Node_AdminAddStats")
                        PlayersMatchStatistics.Lbl_FormBack.Text = "Admins main"
                        PlayersMatchStatistics.TB_GamesCodes.Text = Tb_TGameCval.Text
                        PlayersMatchStatistics.Tb_GamesTypes.Text = CB_Gametype.Text
                        PlayersMatchStatistics.Tb_GamesDate.Text = Tb_GameDate.Text
                        PlayersMatchStatistics.Show()
                        CloseOperation()
                    Else
                        MessageBox.Show("One of your field is empty")
                        Exit Sub
                    End If
            End Select
        End If
    End Sub
    Private Sub Pic_ManageTeamsPic_Click(sender As Object, e As EventArgs) Handles Pic_ManageTeamsPic.Click
        Dim NameCheck As String = myHelper.GetColumn("TeamName", Tb_TeamN.Text) 'אם יש כבר קבוצה עם שם כזה במערכת
        If NameCheck.Length <> 0 Then
            MsgBox("There is already team with that name, please input other name")
            Exit Sub
        End If
        If Pic_ManageTeamsPic.Tag = "Update" Then
            If String.IsNullOrEmpty(Tb_ArenaDetail.Text) Or Tb_ArenaDetail.Text.Trim.Length <> 0 Or Tb_ArenaDetail.Text.Equals("Arena name") Then
                MsgBox("Unvailed arena name")
                Exit Sub
            End If
            If CHB_TeamNChange.Checked = True AndAlso (Tb_TeamN.Text.Equals("Team name") Or String.IsNullOrEmpty(Tb_TeamN.Text) Or Tb_TeamN.Text.Trim.Length <> 0) Then
                MsgBox("Unvailed team name")
                Exit Sub
            End If
            If CHB_TeamNChange.Checked = True Then
                ArrCodes = {Tb_TeamN.Text, Tb_AcodeVal.Text, Tb_HcodeVal.Text, Tb_ArenaDetail.Text}
            Else
                ArrCodes = {CB_TeamUpdate.Text, Tb_AcodeVal.Text, Tb_HcodeVal.Text, Tb_ArenaDetail.Text}
            End If
            myHelper.UpdatedTwoTables(Me, ArrCodes, "Teams")
            MessageBox.Show("Successfully Updated", "Team details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FillPanelBoxs(CB_TeamUpdate)
            CHB_TeamNChange.CheckState = CheckState.Unchecked
        ElseIf Pic_ManageTeamsPic.Tag = "Save" Then
            If CheckVailed(2) Then
                Exit Sub
            End If
            Dim UserD() As String = {Tb_UserChoice.Text, Tb_PassUVal.Text}
            myHelper.GetDBLogin(1, Tb_TeamN.Text, UserD)
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
    Private Sub SelectAgain_Click(sender As Object, e As EventArgs) Handles Btn_GaAgain.Click, Btn_ChooseAgain.Click
        Dim btn As Button = sender
        Select Case btn.Name
            Case "Btn_GaAgain"
                CB_GameCode.Enabled = True
            Case "Btn_ChooseAgain"
                CB_Gametype.Enabled = True
                Tb_TGameCval.Text = "Game code"
                Tb_GameDate.Text = "Game date"
        End Select
    End Sub
    Private Sub Btn_PanelDelete_Click(sender As Object, e As EventArgs) Handles Btn_PanelDelete.Click
        Dim n As String = MsgBox("Are you sure that you want to remove " & Tb_PDeletename.Text & " from the league?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            myHelper.DeleteFromTable(Me, Tb_PDeletecode.Text)
            SetDeleteDataView(ClassCheckManager.GetHomeC())
        End If
    End Sub
    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Btn_GaAgain.MouseEnter, Btn_PanelDelete.MouseEnter, Btn_DHelp.MouseEnter
        Dim btn As Button = sender
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
        btn.BackColor = ColorTranslator.FromHtml("#DDDDDD")
    End Sub
    Private Sub Buttons_MouseLeave(sender As Object, e As EventArgs) Handles Btn_GaAgain.MouseLeave, Btn_PanelDelete.MouseLeave, Btn_DHelp.MouseLeave
        Dim btn As Button = sender
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
        btn.BackColor = Color.WhiteSmoke
    End Sub
#End Region
#Region "פונקציות למילוי תיבות הבחירה או רשימות הבחירה"
    Public Sub FillPanelBoxs(ByVal cmb As ComboBox)
        If cmb.Name.Equals("CB_GameCode") = True Then
            myHelper.FillBoxes(CB_GameCode, "Get all games codes")
        Else
            myHelper.FillBoxes(cmb, "Get all teams names")
        End If
    End Sub
    Public Sub UsersSubString(ByVal OriginalStr As String, ByVal OriginalStrLen As Integer)
        Dim i As Integer, len As Integer, Str2 As String, CheckUser As String
        For i = 0 To OriginalStrLen
            For len = 0 To OriginalStrLen - i
                Str2 = OriginalStr.Substring(i, len)
                If Str2.Length = 3 AndAlso Not Str2.Contains("-") Then
                    LB_UserOptions.Items.Add(Str2.ToUpper())
                End If
            Next
        Next
        For i = 0 To CB_TeamUpdate.Items.Count - 1
            CheckUser = myHelper.GetColumn("MyName", CB_TeamUpdate.Items.Item(i).ToString()) 'אם יש כבר משתמש כזה במערכת
            If CheckUser IsNot Nothing Then
                LB_UserOptions.Items.Remove(CheckUser) 'אמחק אותו מהרשימה כדי שלא יהיו שני משתמשים עם אותו יוזר
            End If
        Next
    End Sub
#End Region
#Region "פונקציה לקבלת קיצור שמות הקבוצות לשימוש בפורומים של ניהול קבוצות או שחקנים"
    Public Sub SetTeamShortCut(ByVal Teamname As String)
        ClassCheckManager.SetManagerName(myHelper.GetColumn("MyName", Teamname, "Admins"))
        ClassCheckManager.SetManagerPic(ClassCheckManager.GetManagerTeamName().Replace("-", "")) 'Matching team name to her picture name
    End Sub
#End Region
#Region "איוונטים על אובייקטים שנמצאים בפאנלים"
    Private Sub Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_GameCode.SelectedIndexChanged, CB_TeamUpdate.SelectedIndexChanged, CB_Gametype.SelectedIndexChanged
        Dim cmb As ComboBox = sender, FillVal As Integer = 0
        Select Case cmb.Name
            Case "CB_GameCode"
                FillVal = 1
            Case "CB_TeamUpdate"
                FillVal = 2
            Case "CB_Gametype"
                FillVal = 9
        End Select
        myHelper.ComboBoxSelectChange(Me, cmb, FillVal)
        cmb.Enabled = False
    End Sub
    Private Sub Tb_HostersCval_Leave(sender As Object, e As EventArgs) Handles Tb_HostersCval.Leave
        For Each item As String In CB_HomeC.Items
            If Not item.Equals(Tb_HostersCval.Text) Then
                HomeCflag = False
            Else
                HomeCflag = True
                Exit For
            End If
        Next
        If HomeCflag = True Then
            Tb_Locationval.Text = myHelper.GetColumn("Arena", Tb_HostersCval.Text)
        Else
            MsgBox("Please insert existing home team code")
        End If
    End Sub
    Private Sub Tb_VisitorsCval_Leave(sender As Object, e As EventArgs) Handles Tb_VisitorsCval.Leave
        For Each item As String In CB_AwayC.Items
            If Not item.Equals(Tb_VisitorsCval.Text) Then
                AwayCflag = False
            Else
                AwayCflag = True
                Exit For
            End If
        Next
        If AwayCflag = False Then
            MsgBox("Please insert existing away team code")
        End If
    End Sub
    Private Sub Tb_TeamN_Leave(sender As Object, e As EventArgs) Handles Tb_TeamN.Leave
        Dim index As Integer, SecCharindex As Integer, cnt As Integer = 1, FirstLetters As String = "", Str() As Char = New Char() {}
        If Not Tb_TeamN.Text.Equals("Team name") AndAlso Not String.IsNullOrEmpty(Tb_TeamN.Text) AndAlso Tb_TeamN.Text.Trim.Length <> 0 Then 'מניעת האפשרות שהפונקציה תעבוד על ערך ברירת המחדל של תיבת הטקסט ועל רווחים
            Tb_TeamN.Text = Trim(Tb_TeamN.Text) 'מחיקת רווחים מההתחלה ומהסוף
            Tb_TeamN.Text = Tb_TeamN.Text.Replace(" ", "-") 'החלפת סימן הרווח בסימן -
            Tb_TeamN.Text = Tb_TeamN.Text.Substring(0, 1).ToUpper() & Tb_TeamN.Text.Substring(1).ToLower() 'אות ראשונה תהפוך לאות גודלה וכל השאר לקטנות
            Str = Tb_TeamN.Text.ToCharArray() 'הפיכת המחרוזת למערך תווים למעבר על כל האותיות של המחרוזת
            Tb_TeamN.Text = "" 'בשביל הצבת הטקסט החדש
            For index = 0 To Str.Length - 1
                If cnt = 1 AndAlso Str(index) = "-" AndAlso Char.IsLetter(Str(index + 1)) Then 'מציאת התו השני לאחר הסימן -
                    cnt = cnt + 1
                    Str(index + 1) = Char.ToUpper(Str(index + 1))
                    SecCharindex = index + 1 'שמירת האינדקס של התו לשימוש לאחר מכן
                End If
                If cnt = 2 AndAlso Str(index) = "-" AndAlso Char.IsLetter(Str(index + 1)) Then 'מציאת התו השלישי לאחר הסימן -
                    Str(index + 1) = Char.ToUpper(Str(index + 1))
                    FirstLetters = Str(0) & Str(SecCharindex) & Str(index + 1) 'קבלת האות הראשונה והאותיות הראשונות לאחר הסימן -
                End If
                Tb_TeamN.Text &= Str(index) 'הצבה של התווים החדשים בתיבת הטקסט
            Next
            LB_UserOptions.Items.Clear() 'ניקוי כל ערכי רשימת היוזרים המוצעים למנהל
            If FirstLetters.Length = 3 Then
                LB_UserOptions.Items.Add(FirstLetters)
            End If
            UsersSubString(Tb_TeamN.Text, Tb_TeamN.Text.Length)
        End If
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
    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Pic_ManageTHelp.Click, Pic_GameHelp.Click, Btn_DHelp.Click
        HelpForm.Show()
    End Sub
    Private Sub CB_TeamsName_TextChanged(sender As Object, e As EventArgs) Handles CB_TeamsName.TextChanged
        If Lbl_WhatManage.Text.Equals("AddPlayerStats") Then
            Dim Dtable As New DataTable, Ds As DataSet = New DataSet("ds")
            If Not CB_TeamsName.Text.Equals("League teams names") AndAlso Not CB_TeamsName.Text.Equals("") Then
                Dtable = myHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Gametype, Nothing, CB_TeamsName.Text, False)
            End If
        End If
    End Sub
    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        Dim i As Integer = DataGridView2.CurrentRow.Index
        Tb_PDeletecode.Text = DataGridView2.Item(0, i).Value
        Tb_PDeletename.Text = DataGridView2.Item(2, i).Value + " " + DataGridView2.Item(3, i).Value
    End Sub
#End Region
End Class