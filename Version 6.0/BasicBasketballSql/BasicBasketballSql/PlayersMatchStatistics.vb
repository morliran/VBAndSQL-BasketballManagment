Public Class PlayersMatchStatistics
    Private Merror As MerrorControl = New MerrorControl()
#Region "פונקציות על הפורם"
    Private Sub PlayersMatchStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.setGroupBoxControlsEvents(GB_APS, Me)
        ManagersMain.getDBHelper.FillBoxes(CB_PlayerCode, ManagersMain.getManager.GetHomeCode(), 1) 'מילוי תיבת הקודים של שחקני הקבוצה
        GB_APS.Location = New Point((Me.Width - GB_APS.Width) \ 2, (Me.Height - GB_APS.Height) \ 2)
        GB_APS.BackColor = Color.FromArgb(75, Color.DarkGray)
        Lbl_CheckTotal.Text = CB_PlayerCode.Items.Count
        Lbl_AddPStats.Text = "Add Player Stats That Belong To " & ManagersMain.getManager.CheckTeam()
        Tb_TeamsNames.Text = ManagersMain.getManager.CheckTeam()
    End Sub
    Private Sub PlayersMatchStatistics_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Lbl_CheckTotal.Text <> "0" Then
            MessageBox.Show("Please Finish Insert All Your Players", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
        If Lbl_CheckTotal.Text = "0" Then
            If Lbl_FormBack.Text <> "Admins main" Then
                ManagersMain.Lbl_CheckGameDate.Text = "You finished insert your players data from today game"
                ManagersMain.Lbl_CheckGameDate.ForeColor = Color.Green
                ManagersMain.Lbl_AddingStats.Visible = False
                Me.Dispose()
                Me.Hide()
                ManagersMain.Show()
            Else
                Me.Dispose()
                Me.Hide()
                AdminsMain.Show()
            End If
        End If
    End Sub
#End Region
#Region "אירוע בעת לחיצה על הכפתור All Zero"
    Private Sub Btn_Default_Click(sender As Object, e As EventArgs) Handles Btn_Default.Click
        Tb_Points.Text = "0"
        Tb_Assist.Text = "0"
        Tb_Rebound.Text = "0"
        Tb_Steel.Text = "0"
        Tb_Block.Text = "0"
    End Sub
#End Region
#Region "אירועים בעת לחיצה על אחת מן התמונות"
    Private Sub Pic_Save_Click(sender As Object, e As EventArgs) Handles Pic_Save.Click
        If CB_PlayerCode.Text = "" Then
            MessageBox.Show("Please select player code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CB_PlayerCode.Focus()
            Exit Sub
        ElseIf Len(Tb_Points.Text) > 3 Then
            MessageBox.Show("Please enter points number below or equal to 3", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tb_Points.Focus()
            Exit Sub
        ElseIf Tb_Points.Text = "" Then
            Tb_Points.Text = "0"
        ElseIf Len(Tb_Assist.Text) > 2 Then
            MessageBox.Show("Please enter assists number below or equal to 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tb_Assist.Focus()
            Exit Sub
        ElseIf Tb_Assist.Text = "" Then
            Tb_Assist.Text = "0"
        ElseIf Len(Tb_Rebound.Text) > 2 Then
            MessageBox.Show("Please enter rebounds number below or equal to 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tb_Rebound.Focus()
            Exit Sub
        ElseIf Tb_Rebound.Text = "" Then
            Tb_Rebound.Text = "0"
        ElseIf Len(Tb_Steel.Text) > 2 Then
            MessageBox.Show("Please enter steels number below or equal to 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tb_Steel.Focus()
            Exit Sub
        ElseIf Tb_Steel.Text = "" Then
            Tb_Steel.Text = "0"
        ElseIf Len(Tb_Block.Text) > 2 Then
            MessageBox.Show("Please enter blocks number below or equal to 2", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tb_Block.Focus()
            Exit Sub
        ElseIf Tb_Block.Text = "" Then
            Tb_Block.Text = "0"
        End If
        TextBox1.Text = "('" + Trim(CB_PlayerCode.Text) + "'" + ", '" + Trim(TB_GamesCodes.Text) + "'" + ", '" + Trim(Tb_GamesTypes.Text) + "'" + ", '" + Trim(Tb_GamesDate.Text) + "'" + ", " + Trim(Tb_Points.Text) + ", " + Trim(Tb_Assist.Text) + ", " + Trim(Tb_Rebound.Text) + ", " + Trim(Tb_Steel.Text) + ", " + Trim(Tb_Block.Text) + ", '" + Trim(Tb_TeamsNames.Text) + "')"
        ManagersMain.getDBHelper.InsertToTable(Me)
        MessageBox.Show("Successfully added player stats", "Add player stats", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Pic_Save.Enabled = False
        Dim index As Integer = CB_PlayerCode.SelectedIndex
        Lb_TempBox.Items.Add(CB_PlayerCode.Items(index))
        CB_PlayerCode.Items.RemoveAt(index)
        Lbl_CheckTotal.Text = CB_PlayerCode.Items.Count
        Tb_Assist.Text = ""
        Tb_Block.Text = ""
        Tb_FN.Text = ""
        Tb_LN.Text = ""
        Tb_Points.Text = ""
        Tb_PID.Text = ""
        Tb_Steel.Text = ""
        Tb_Rebound.Text = ""
        If Lbl_CheckTotal.Text = "0" Then
            Me.ControlBox = True
        End If
    End Sub
    Private Sub Pic_Update_Click(sender As Object, e As EventArgs) Handles Pic_Update.Click
        TextBox1.Text = "('" + Trim(CB_PlayerCode.Text) + "'" + ", '" + Trim(TB_GamesCodes.Text) + "'" + ", '" + Trim(Tb_GamesTypes.Text) + "'" + ", '" + Trim(Tb_GamesDate.Text) + "'" + ", " + Trim(Tb_Points.Text) + ", " + Trim(Tb_Assist.Text) + ", " + Trim(Tb_Rebound.Text) + ", " + Trim(Tb_Steel.Text) + ", " + Trim(Tb_Block.Text) + ", '" + Trim(Tb_TeamsNames.Text) + "')"
        Dim ArrCodes() As String = New String() {Trim(CB_PlayerCode.Text), Trim(TB_GamesCodes.Text), Trim(Tb_GamesTypes.Text), Trim(Tb_GamesDate.Text), Trim(Tb_TeamsNames.Text), Trim(Tb_Points.Text), Trim(Tb_Assist.Text), Trim(Tb_Rebound.Text), Trim(Tb_Steel.Text), Trim(Tb_Block.Text)}
        ManagersMain.getDBHelper.UpdateTable(Me, ArrCodes)
        MessageBox.Show("Successfully updated players stats", "Player details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Pic_Update.Enabled = False
        CB_PlayerCode.Enabled = True
        Dim index As Integer = CB_PlayerCode.SelectedIndex
        Lb_TempBox.Items.Add(CB_PlayerCode.Items(index))
        CB_PlayerCode.Items.RemoveAt(index)
        Lbl_CheckTotal.Text = CB_PlayerCode.Items.Count
        CB_PlayerCode.Text = ""
        Tb_Assist.Text = ""
        Tb_Block.Text = ""
        Tb_FN.Text = ""
        Tb_LN.Text = ""
        Tb_Points.Text = ""
        Tb_PID.Text = ""
        Tb_Steel.Text = ""
        Tb_Rebound.Text = ""
        CB_PlayerCode.Focus()
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.Show()
    End Sub
#End Region
#Region "אירועים בעת לחיצה על תיבת הקודים ורשימת הקודים שנשמרו"
    Private Sub CB_PlayerCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PlayerCode.SelectedIndexChanged
        Pic_Save.Enabled = True
        ManagersMain.getDBHelper.ComboBoxSelectChange(Me, CB_PlayerCode, 3)
    End Sub
    Private Sub Lb_TempBox_MouseClick(sender As Object, e As MouseEventArgs) Handles Lb_TempBox.MouseClick
        Dim index As Integer = Lb_TempBox.SelectedIndex
        CB_PlayerCode.Items.Add(Lb_TempBox.Items(index))
        CB_PlayerCode.Text = Lb_TempBox.Items(index)
        Lb_TempBox.Items.RemoveAt(index)
        CB_PlayerCode.Enabled = False
        Pic_Save.Enabled = False
        Pic_Update.Enabled = True
    End Sub
#End Region
End Class