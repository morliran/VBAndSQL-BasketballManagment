Public Class GuestMain
    Private GuestCon As Connection = New Connection()
    Private myHelper As MyDBControler = New MyDBControler()
#Region "פונקציות של הפורם"
    Private Sub GuestMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        LoginForm.ReturnToMe()
    End Sub
    Public Function getHelper() As MyDBControler
        Return Me.myHelper
    End Function
#End Region
#Region "אירועים בעת לחיצה על הכפתורים או תמונת העזרה"
    Private Sub Btn_GuestQ_Click(sender As Object, e As EventArgs) Handles Btn_GuestQ.Click
        Me.Hide()
        GuestQueriesSections.Show()
    End Sub
    Private Sub Btn_QueryBuild_Click(sender As Object, e As EventArgs) Handles Btn_QueryBuild.Click
        Me.Hide()
        BuildMineQueries.Show()
    End Sub
    Private Sub Btn_LeagueLeaders_Click(sender As Object, e As EventArgs) Handles Btn_LeagueLeaders.Click
        Me.Hide()
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_GuestLeagueL")
        LeagueLeaders.Show()
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_Guest")
        HelpForm.Show()
    End Sub
#End Region
End Class