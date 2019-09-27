Public Class AddPlayersForm
    Private Merror As MerrorControl = New MerrorControl()
    Private ArrCodes() As String = New String() {ManagersMain.getManager.CheckTeam(), ""}
    Private itemcoll(30) As String
#Region "אופציות על הפורם"
    Private Sub AddPlayersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.setGroupBoxControlsEvents(GB_PlayerD, Me)
        Merror.setSplitChar("-")
        Tb_RoutionCVal.Text = ManagersMain.getDBHelper.getCountResults("CountMaxRoutionCode", ArrCodes) + 1
        Lbl_ManTeam.Text = ManagersMain.getManager.CheckTeam()
        Lbl_EmptyDateCheck.Text = MB_DOB.Text
        Lbl_EmptyHeight.Text = MB_Height.Text
        Panel_Buttons.BackColor = Color.FromArgb(75, Color.DarkGray)
        Lbl_AddP.Text = "Add Player To " & Lbl_ManTeam.Text & " Team"
        Lbl_MUser.Text = ManagersMain.getManager.CheckManager()
        Me.Tb_HTC.Text = ManagersMain.getManager.GetHomeCode()
        Me.TB_ATC.Text = ManagersMain.getManager.GetAwayCode()
        Me.BackgroundImage = ManagersMain.BackgroundImage
        Call FillPlayersCodes(Me.Tb_HTC.Text)
    End Sub
    Private Sub AddPlayersForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        If Lbl_FormBack.Text = "Admins main" Then
            AdminsMain.Show()
        Else
            ManagersMain.Show()
        End If
    End Sub
#End Region
#Region "אופציות למנהל על מנת לייעל את השימוש בפורם"
    Private Sub Btn_SamePos_Click(sender As Object, e As EventArgs) Handles Btn_SamePos.Click
        If CB_Position.Text = "Main position" Then
            MessageBox.Show("Please select main position", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Me.CB_SPosition.Text = "None"
            Me.CB_SPosition.Enabled = False
        End If
    End Sub
    'בדיקה האם תוכן תא של עמדה ראשית שווה לתוכן תא של עמדה משנית, אם כן התוכנית תציב בתא של עמדה משנית None'
    Private Sub CB_SPosition_Leave(sender As Object, e As EventArgs) Handles CB_SPosition.Leave
        If Me.CB_SPosition.Text = Me.CB_Position.Text Then
            Me.CB_SPosition.Text = "None"
            Me.CB_SPosition.Enabled = False
        End If
    End Sub
    'כאשר המנגר בוחר עמדה משנית לא תהיה לו אפשרות לבחור שוב, מצב זה מונע לחיצה בטעות על גלגלת ושינוי תוכן תא'
    Private Sub CB_SPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_SPosition.SelectedIndexChanged
        Me.CB_SPosition.Enabled = False
    End Sub
    'מחזיר את האפשרות לבחור מחדש עמדה משנית'
    Private Sub CB_Position_Enter(sender As Object, e As EventArgs) Handles CB_Position.Enter
        If Me.CB_SPosition.Enabled = False Then
            Me.CB_SPosition.Enabled = True
        End If
    End Sub
    Private Sub CB_Position_TextChanged(sender As Object, e As EventArgs) Handles CB_Position.TextChanged
        If CB_Position.Text = "None" Then
            MessageBox.Show("None can't be set inside main position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CB_Position.Text = "Main position"
            CB_Position.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub Pic_New_Click(sender As Object, e As EventArgs) Handles Pic_New.Click
        Tb_PlayerCode.Text = "Player code"
        Tb_PID.Text = "Player ID"
        Tb_FN.Text = "First name"
        Tb_LN.Text = "Last name"
        Tb_JN.Text = "Jersey number"
        CB_Position.Text = "Main position"
        CB_SPosition.Text = "Second position"
        MB_DOB.Text = ""
        MB_Height.Text = ""
        Pic_Save.Enabled = True
    End Sub
#End Region
#Region "אייקון שמירת ההוספה ובדיקה האם כל נתון עומד בכל תנאי שנבדק לאחר הלחיצה על הכפתור"
    Private Sub Pic_Save_Click(sender As Object, e As EventArgs) Handles Pic_Save.Click
        Dim Flag As Boolean = False
        Lbl_CheckDateOfBirthLen.Text = MB_DOB.Text
        If Len(Trim(Tb_PlayerCode.Text)) = 0 Or Tb_PlayerCode.Text = "Player code" Then
            MessageBox.Show("Please enter player code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_PlayerCode.Focus()
            Exit Sub
        ElseIf Len(Trim(Tb_PlayerCode.Text)) > 6 Then
            MessageBox.Show("Please enter player code lower than 6", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_PlayerCode.Focus()
            Exit Sub
        ElseIf Tb_PlayerCode.Text = Tb_PID.Text Then
            MessageBox.Show("Please enter player, the code cant be like player ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_PlayerCode.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_PID.Text)) = 0 Or Tb_PID.Text = "Player ID" Then
            MessageBox.Show("Please enter player ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_PID.Focus()
            Exit Sub
        ElseIf Len(Trim(Tb_PID.Text)) > 6 Then
            MessageBox.Show("Please enter player ID lower than 6", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_PID.Focus()
            Exit Sub
        ElseIf Tb_PID.Text = Tb_PlayerCode.Text Then
            MessageBox.Show("Please enter player ID the id cant be like Player Code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_PID.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_FN.Text)) = 0 Or Tb_FN.Text = "First name" Then
            MessageBox.Show("Please enter first name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_FN.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_LN.Text)) = 0 Or Tb_LN.Text = "Last name" Then
            MessageBox.Show("Please enter last name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_LN.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_JN.Text)) = 0 Or Tb_JN.Text = "Jersey number" Then
            MessageBox.Show("Please enter jersey number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_JN.Focus()
            Exit Sub
        ElseIf Len(Trim(Tb_JN.Text)) > 2 Then
            MessageBox.Show("Jersey number can be only have 2 digits or one", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_JN.Focus()
            Exit Sub
        End If
        If Len(Trim(CB_Position.Text)) = 0 Or CB_Position.Text = "Main position" Then
            MessageBox.Show("Please enter first position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CB_Position.Focus()
            Exit Sub
        ElseIf Len(Trim(CB_Position.Text)) > 2 Then
            MessageBox.Show("Please enter first position lower than 2", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CB_Position.Focus()
            Exit Sub
        End If
        If Len(Trim(CB_SPosition.Text)) = 0 Or CB_SPosition.Text = "Second position" Then
            MessageBox.Show("Please enter second position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CB_SPosition.Focus()
            Exit Sub
        End If
        If MB_Height.Text = Lbl_EmptyHeight.Text Then
            MessageBox.Show("Please enter height", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MB_Height.Focus()
            Exit Sub
        ElseIf Len(Trim(MB_Height.Text)) <> 4 Then
            MessageBox.Show("Please enter height", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MB_Height.Focus()
            Exit Sub
        End If
        If MB_DOB.Text = Lbl_EmptyDateCheck.Text Then
            MessageBox.Show("Please enter birthday", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MB_DOB.Focus()
            Exit Sub
        ElseIf Len(Lbl_CheckDateOfBirthLen.Text) <> 10 Then
            MessageBox.Show("Birthday has to be in format dd/mm/yyyy", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MB_DOB.Focus()
            Exit Sub
        End If
        Flag = ManagersMain.getDBHelper.TextBoxChangedText(Me, Tb_PlayerCode)
        If (Flag) Then
            ManagersMain.getDBHelper.InsertToTable(Me)
            MessageBox.Show("Successfully added", "Player", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tb_RoutionCVal.Text = ManagersMain.getDBHelper.getCountResults("CountMaxRoutionCode", ArrCodes) + 1
            Pic_Save.Enabled = False
        End If
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.Show()
    End Sub
#End Region
#Region "מילוי קודים של שחקנים על פי המחרוזת שהפונקציה מקבלת"
    Private Function FillPlayersCodes(strCode As String) As ListView
        LV_PlayersCodeView.Items.Clear()
        Return ManagersMain.getDBHelper.FillListView(Me, LV_PlayersCodeView, itemcoll, strCode)
    End Function
#End Region
End Class