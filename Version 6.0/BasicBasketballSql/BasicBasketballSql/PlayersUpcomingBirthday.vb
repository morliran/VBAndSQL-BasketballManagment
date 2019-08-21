Public Class PlayersUpcomingBirthday
    Private itemcoll(30) As String
#Region " טעינת הפורם, סגירתו ולחיצה על תמונת העזרה "
    Private Sub PlayersUpcomingBirthday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FillPlayersBirthday(ManagersMain.getManager.GetHomeCode())
        LV_PlayersBirthdayView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent) 'התאמה אוטומטית של גודל העמודות בהתאם לתוכן שנכנס אליהן
        LV_PlayersBirthdayView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
    Private Sub PlayersUpcomingBirthday_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_UpcomeBirth")
        HelpForm.Show()
    End Sub
#End Region
#Region "פונקציה למציאת השחקנים בקבוצה של כל מנהל שיש להם יומהולדת בשבוע הקרוב"
    Private Function FillPlayersBirthday(strCode As String) As ListView
        LV_PlayersBirthdayView.Items.Clear()
        Me.LV_PlayersBirthdayView = ManagersMain.getDBHelper.FillListView(Me, LV_PlayersBirthdayView, itemcoll, strCode)
        If LV_PlayersBirthdayView.Items.Count <= 0 Then 'אם אין שחקן בקבוצה שיש לו יומהולדת בקרוב יציג את ההודעה
            MessageBox.Show("None of your players will have soon birthday" + vbNewLine + "check in other day", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Total players in your team that have soon birthday = " + LV_PlayersBirthdayView.Items.Count.ToString(), "Birthday checker", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return LV_PlayersBirthdayView
    End Function
#End Region
End Class