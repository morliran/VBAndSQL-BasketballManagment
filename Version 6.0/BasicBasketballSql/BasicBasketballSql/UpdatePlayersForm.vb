Public Class UpdatePlayersForm
    Private Merror As MerrorControl = New MerrorControl()
#Region "אופציות על הפורם"
    Private Sub UpdatePlayersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.setGroupBoxControlsEvents(GB_UpdatePlayers, Me)
        Merror.setSplitChar("-")
        GB_UpdatePlayers.Location = New Point((Me.Width - GB_UpdatePlayers.Width) \ 2, (Me.Height - GB_UpdatePlayers.Height) \ 2)
        GB_UpdatePlayers.BackColor = Color.FromArgb(75, Color.DarkGray)
        Me.BackgroundImage = ManagersMain.Pic_Menu.Image
        FillPlayersCodeBox()
        Lbl_UpdateP.Text = "Update Player From " & ManagersMain.getManager.CheckTeam() & " Team"
        Me.Tb_HTC.Text = ManagersMain.getManager.GetHomeCode()
        Me.TB_ATC.Text = ManagersMain.getManager.GetAwayCode()
    End Sub
    Private Sub UpdatePlayersForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        If Lbl_FormBack.Text = "Admins main" Then
            AdminsMain.Show()
        Else
            ManagersMain.Show()
        End If
    End Sub
    Private Sub UpdatePlayersForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        GB_UpdatePlayers.Location = New Point((Me.Width - GB_UpdatePlayers.Width) \ 2, (Me.Height - GB_UpdatePlayers.Height) \ 2)
    End Sub
#End Region
#Region "פונקציית מילוי קודים של שחקנים בתיבת הבחירה"
    Private Sub FillPlayersCodeBox()
        ManagersMain.getDBHelper.FillBoxes(CB_PlayerCode, ManagersMain.getManager.GetHomeCode(), 1)
    End Sub
#End Region
#Region "אירועים על הכפתורים והתיבת בחירה שיש בפורם בדיקה של הנתונים שעודכנו לאחר לחיצה על אייקון העדכון"
    Private Sub Pic_Update_Click(sender As Object, e As EventArgs) Handles Pic_Update.Click
        If CB_PlayerCode.Text = "Player code" Or CB_PlayerCode.Text = "" Then
            MessageBox.Show("Please select player code", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim ArrCodes() As String = New String() {Trim(CB_PlayerCode.Text), Trim(Tb_PID.Text), Trim(Tb_FN.Text), Trim(Tb_LN.Text), Trim(Tb_JN.Text), Trim(CB_Position.Text), Trim(CB_SPosition.Text), Trim(MB_Height.Text), Trim(MB_DOB.Text), Trim(Tb_HTC.Text), Trim(TB_ATC.Text)}
        ManagersMain.getDBHelper.UpdateTable(Me, ArrCodes)
        MessageBox.Show("Successfully Updated", "Player details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Pic_Update.Enabled = False
        FillPlayersCodeBox()
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.Show()
    End Sub
    Private Sub CB_PlayerCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PlayerCode.SelectedIndexChanged
        Pic_Update.Enabled = True
        ManagersMain.getDBHelper.ComboBoxSelectChange(Me, CB_PlayerCode, 3)
    End Sub
    Private Sub Btn_SamePos_Click(sender As Object, e As EventArgs) Handles Btn_SamePos.Click
        Me.CB_SPosition.Text = ""
        Me.CB_SPosition.Text = "None"
        Me.CB_SPosition.Enabled = False
    End Sub
    Private Sub CB_SPosition_Leave(sender As Object, e As EventArgs) Handles CB_SPosition.Leave
        If Me.CB_SPosition.Text = Me.CB_Position.Text Then
            Me.CB_SPosition.Text = "None"
            Me.CB_SPosition.Enabled = False
        End If
    End Sub
    Private Sub CB_PlayerCode_TextChanged(sender As Object, e As EventArgs) Handles CB_PlayerCode.TextChanged
        If CB_PlayerCode.Text <> "Player code" AndAlso CB_PlayerCode.Text <> "" Then
            Me.CB_PlayerCode.Enabled = False
        End If
    End Sub
    Private Sub Btn_ChoiceAgain_Click(sender As Object, e As EventArgs) Handles Btn_ChoiceAgain.Click
        Me.CB_PlayerCode.Text = ""
        Me.CB_PlayerCode.Enabled = True
    End Sub
#End Region
End Class