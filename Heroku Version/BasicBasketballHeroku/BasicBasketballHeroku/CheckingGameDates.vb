﻿Public Class CheckingGameDates
    Private Mat As DataView = New DataView()
    Private myHelper As MyDBControler = New MyDBControler()
    Private ArrDate() As String = New String() {Date.Now().ToString("dd\/MM\/yyyy")}
    Public Shared Property Found As Boolean = False
    Public Sub SetPropritesLblCheckGameDate()
        ManagersMain.Panel_CheckD.Visible = True
        Found = True
        ManagersMain.Lbl_CheckGameDate.Text = ArrDate(0) + " - Your Team Have Game Today"
        ManagersMain.Lbl_CheckGameDate.ForeColor = Color.Red
    End Sub
    Public Sub CheckGameDate()
        Dim row As DataRow = Nothing
        Mat = myHelper.GetDataView("CheckDate", ArrDate)
        For Each rowView As DataRowView In Mat
            row = rowView.Row
            If row.Item("HostersCode").ToString().Equals(ClassCheckManager.GetHomeC()) Or row.Item("VisitorsCode").ToString().Equals(ClassCheckManager.GetAwayC()) Then
                PlayersMatchStatistics.TB_GamesCodes.Text = row.Item("Gamecode").ToString()
                PlayersMatchStatistics.Tb_GamesTypes.Text = row.Item("Gametypenumber").ToString()
                PlayersMatchStatistics.Tb_GamesDate.Text = ArrDate(0)
                SetPropritesLblCheckGameDate()
            End If
        Next
    End Sub
End Class