Public Class AdminsManage
    Private Sub AdminsManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ArrCodes() As String = New String() {"", "", "", "", "", ""}
        Select Case Lbl_TableName.Text
            Case "Players changes"
                DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("tb_PlayersAuidit", ArrCodes, 7)
            Case "Stats changes"
                DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("tb_StatsAuidit", ArrCodes, 7)
            Case "Games changes"
                DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("tb_GameAuidit", ArrCodes, 7)
        End Select
    End Sub
    Private Sub AdminsManage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        AdminsMain.Show()
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_LeagueChange")
        HelpForm.Show()
    End Sub
End Class