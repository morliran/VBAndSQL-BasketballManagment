Public Class CheckingGameDates
    Private Mat As DataView = New DataView()
    Private myHelper As MyDBControler = New MyDBControler()
    Private ArrDate() As String = New String() {Date.Now().ToString("dd\/MM\/yyyy")}
    Private Found As Boolean = False
    Public Sub SetPropritesLblCheckGameDate()
        ManagersMain.Lbl_CheckGameDate.Visible = True
        Found = True
        ManagersMain.Lbl_CheckGameDate.Text = ArrDate(0) + " - Your Team Have Game Today"
        ManagersMain.Lbl_CheckGameDate.ForeColor = Color.Red
    End Sub
    Public Sub CheckGameDate()
        Mat = myHelper.getDataView("CheckDate", ArrDate)
        For Each rowView As DataRowView In Mat
            Dim row As DataRow = rowView.Row
            If row.Item("HostersCode").ToString() = ManagersMain.getManager.GetHomeCode() Or row.Item("VisitorsCode").ToString() = ManagersMain.getManager.GetAwayCode() Then
                PlayersMatchStatistics.TB_GamesCodes.Text = row.Item("Gamecode").ToString()
                PlayersMatchStatistics.Tb_GamesTypes.Text = row.Item("Gametypenumber").ToString()
                PlayersMatchStatistics.Tb_GamesDate.Text = ArrDate(0)
                SetPropritesLblCheckGameDate()
            End If
        Next
    End Sub
    Public Function GetGameFound() As Boolean
        Return Me.Found
    End Function
End Class
