Public Class PlayersMatchStatistics
    Private Merror As MerrorControl = New MerrorControl()
    Private isClosed As Boolean = False 'Flag to check if the manager finish insert stats to all his players
#Region "פונקציות על הפורם"
    Private Sub PlayersMatchStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CountPlayers As Integer = 0, ArrCheck() As String = New String() {TB_GamesCodes.Text, ManagersMain.getManager.CheckTeam()}
        Merror.setPanelControlsEvents(Panel_StatsControlers, Me)
        ManagersMain.FillPlayersNamesBox(CB_PlayerMatchCode, CB_PMatchNames)
        Panel_StatsData.BackColor = Color.FromArgb(50, ColorTranslator.FromHtml("#74B9FF"))
        Lbl_CheckTotal.Text = CB_PlayerMatchCode.Items.Count
        Lbl_AddPStats.Text = "Add Player Stats That Belong To " & ManagersMain.getManager.CheckTeam()
        Tb_TeamsNames.Text = ManagersMain.getManager.CheckTeam()
        Tb_Temp.Focus()
        CountPlayers = ManagersMain.getDBHelper.getCountResults("CountPlayersInGame", ArrCheck)
        If CountPlayers = Integer.Parse(Lbl_CheckTotal.Text) Then 'Prevent the option to add or update player stats after finish insert him
            If Not Lbl_FormBack.Text.Equals("Admins main") Then
                Lbl_CheckTotal.Text = "0"
                isClosed = True
                For Each p As Panel In Me.Controls.OfType(Of Panel)()
                    p.Visible = False
                Next
            End If
        End If
    End Sub
    Private Sub PlayersMatchStatistics_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosed Then
            e.Cancel = False
            If Lbl_CheckTotal.Text.Equals("0") Then
                If Not Lbl_FormBack.Text.Equals("Admins main") Then
                    ManagersMain.Lbl_CheckGameDate.Text = "You finished insert your players data from today game"
                    ManagersMain.Lbl_CheckGameDate.ForeColor = Color.Green
                    ManagersMain.Lbl_AddingStats.Visible = False
                    Me.Dispose()
                    Me.Hide()
                    ManagersMain.SetTeamPlayersTable()
                    ManagersMain.Show()
                Else
                    Me.Dispose()
                    Me.Hide()
                    AdminsMain.Show()
                End If
            End If
        Else
            MessageBox.Show("Please Finish Insert All Your Players Game Stats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
    Private Sub Panel_Display_Resize(sender As Object, e As EventArgs) Handles Panel_Display.Resize
        Panel_StatsData.Location = New Point((Panel_Display.Width - Panel_StatsData.Width) / 2, (Panel_Display.Height - Panel_StatsData.Height) / 2)
    End Sub
    Private Sub Panel_Welcome_Resize(sender As Object, e As EventArgs) Handles Panel_Welcome.Resize
        Lbl_AddPStats.Location = New Point((Panel_Welcome.Width - Lbl_AddPStats.Width) / 2, (Panel_Welcome.Height - Lbl_AddPStats.Height) / 2)
    End Sub
#End Region
#Region "אירועים בעת לחיצה על אחד מהכפתורים"
    Private Sub SetTextOfTextBoxData(ByVal StringToSet As String)
        For Each t As TextBox In Panel_StatsControlers.Controls.OfType(Of TextBox)()
            t.Text = StringToSet
        Next
    End Sub
    Private Sub Btn_AllZero_Click(sender As Object, e As EventArgs) Handles Btn_AllZero.Click
        SetTextOfTextBoxData("0")
    End Sub
    Private Sub Btn_PMatchSave_Click(sender As Object, e As EventArgs) Handles Btn_PMatchSave.Click
        Dim index As Integer
        If CB_PMatchNames.Text.Equals("Player name") Or CB_PMatchNames.Text.Equals("") Then
            MessageBox.Show("Please select player name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CB_PMatchNames.Focus()
            Exit Sub
        End If
        If Tb_Points.Text.Equals("") Then
            Tb_Points.Text = "0"
        End If
        If Tb_Assist.Text.Equals("") Then
            Tb_Assist.Text = "0"
        End If
        If Tb_Rebound.Text.Equals("") Then
            Tb_Rebound.Text = "0"
        End If
        If Tb_Steel.Text.Equals("") Then
            Tb_Steel.Text = "0"
        End If
        If Tb_Block.Text.Equals("") Then
            Tb_Block.Text = "0"
        End If
        Tb_ValToSQL.Text = "('" + Trim(CB_PlayerMatchCode.Text) + "'" + ", '" + Trim(TB_GamesCodes.Text) + "'" + ", '" + Trim(Tb_GamesTypes.Text) + "'" + ", '" + Trim(Tb_GamesDate.Text) + "'" + ", " + Trim(Tb_Points.Text) + ", " + Trim(Tb_Assist.Text) + ", " + Trim(Tb_Rebound.Text) + ", " + Trim(Tb_Steel.Text) + ", " + Trim(Tb_Block.Text) + ", '" + Trim(Tb_TeamsNames.Text) + "')"
        ManagersMain.getDBHelper.InsertToTable(Me)
        MessageBox.Show("Successfully added player stats", "Add player stats", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Btn_PMatchSave.Enabled = False
        index = CB_PMatchNames.SelectedIndex
        Lb_CodeBox.Items.Add(CB_PlayerMatchCode.Items(index))
        CB_PlayerMatchCode.Items.RemoveAt(index)
        Lb_NameBox.Items.Add(CB_PMatchNames.Items(index))
        CB_PMatchNames.Items.RemoveAt(index)
        Lbl_CheckTotal.Text = CB_PlayerMatchCode.Items.Count
        CB_PMatchNames.Text = "Player name"
        SetTextOfTextBoxData("")
        If Lbl_CheckTotal.Text.Equals("0") Then
            isClosed = True
        Else
            isClosed = False
        End If
    End Sub
    Private Sub Btn_PMatchUpdate_Click(sender As Object, e As EventArgs) Handles Btn_PMatchUpdate.Click
        Dim index As Integer, ArrCodes() As String = New String() {}
        If CB_PMatchNames.Text.Equals("Player name") Or CB_PMatchNames.Text.Equals("") Then
            MessageBox.Show("Please select player name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CB_PMatchNames.Focus()
            Exit Sub
        End If
        If Tb_Points.Text.Equals("") Then
            Tb_Points.Text = "0"
        End If
        If Tb_Assist.Text.Equals("") Then
            Tb_Assist.Text = "0"
        End If
        If Tb_Rebound.Text.Equals("") Then
            Tb_Rebound.Text = "0"
        End If
        If Tb_Steel.Text.Equals("") Then
            Tb_Steel.Text = "0"
        End If
        If Tb_Block.Text.Equals("") Then
            Tb_Block.Text = "0"
        End If
        Tb_ValToSQL.Text = "('" + Trim(CB_PlayerMatchCode.Text) + "'" + ", '" + Trim(TB_GamesCodes.Text) + "'" + ", '" + Trim(Tb_GamesTypes.Text) + "'" + ", '" + Trim(Tb_GamesDate.Text) + "'" + ", " + Trim(Tb_Points.Text) + ", " + Trim(Tb_Assist.Text) + ", " + Trim(Tb_Rebound.Text) + ", " + Trim(Tb_Steel.Text) + ", " + Trim(Tb_Block.Text) + ", '" + Trim(Tb_TeamsNames.Text) + "')"
        ArrCodes = {Trim(CB_PlayerMatchCode.Text), Trim(TB_GamesCodes.Text), Trim(Tb_GamesTypes.Text), Trim(Tb_GamesDate.Text), Trim(Tb_TeamsNames.Text), Trim(Tb_Points.Text), Trim(Tb_Assist.Text), Trim(Tb_Rebound.Text), Trim(Tb_Steel.Text), Trim(Tb_Block.Text)}
        ManagersMain.getDBHelper.UpdateTable(Me, ArrCodes)
        MessageBox.Show("Successfully updated players stats", "Player details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Btn_PMatchUpdate.Enabled = False
        CB_PMatchNames.Enabled = True
        index = CB_PMatchNames.SelectedIndex
        Lb_CodeBox.Items.Add(CB_PlayerMatchCode.Items(index))
        CB_PlayerMatchCode.Items.RemoveAt(index)
        Lb_NameBox.Items.Add(CB_PMatchNames.Items(index))
        CB_PMatchNames.Items.RemoveAt(index)
        Lbl_CheckTotal.Text = CB_PlayerMatchCode.Items.Count
        CB_PMatchNames.Text = "Player name"
        SetTextOfTextBoxData("")
        CB_PlayerMatchCode.Focus()
    End Sub
    Private Sub Btn_PMatchHelp_Click(sender As Object, e As EventArgs) Handles Btn_PMatchHelp.Click
        HelpForm.Show()
    End Sub
    Private Sub Buttons_MouseEnter(sender As Object, e As EventArgs) Handles Btn_PMatchSave.MouseEnter, Btn_PMatchUpdate.MouseEnter, Btn_AllZero.MouseEnter, Btn_PMatchHelp.MouseEnter
        Dim btn As Button = sender
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub Btn_PMatchSave_MouseLeave(sender As Object, e As EventArgs) Handles Btn_PMatchSave.MouseLeave, Btn_PMatchUpdate.MouseLeave, Btn_AllZero.MouseLeave, Btn_PMatchHelp.MouseLeave
        Dim btn As Button = sender
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
#Region "אירועים בעת לחיצה על תיבת השחקנים ורשימת השחקנים שנשמרו"
    Private Sub CB_PlayerMatchCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PlayerMatchCode.SelectedIndexChanged
        Btn_PMatchSave.Enabled = True
        ManagersMain.getDBHelper.ComboBoxSelectChange(Me, CB_PlayerMatchCode, 3)
    End Sub
    Private Sub CB_PMatchNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PMatchNames.SelectedIndexChanged
        Dim index As Integer = CB_PMatchNames.SelectedIndex
        CB_PlayerMatchCode.SelectedIndex = index
        Btn_PMatchSave.Enabled = True
    End Sub
    Private Sub Lb_NameBox_MouseClick(sender As Object, e As MouseEventArgs) Handles Lb_NameBox.MouseClick
        Dim index As Integer = Lb_NameBox.SelectedIndex
        CB_PlayerMatchCode.Items.Add(Lb_CodeBox.Items(index))
        CB_PlayerMatchCode.Text = Lb_CodeBox.Items(index)
        Lb_CodeBox.Items.RemoveAt(index)
        CB_PMatchNames.Items.Add(Lb_NameBox.Items(index))
        CB_PMatchNames.Text = Lb_NameBox.Items(index)
        Lb_NameBox.Items.RemoveAt(index)
        CB_PMatchNames.Enabled = False
        Btn_PMatchSave.Enabled = False
        Btn_PMatchUpdate.Enabled = True
    End Sub
#End Region
End Class