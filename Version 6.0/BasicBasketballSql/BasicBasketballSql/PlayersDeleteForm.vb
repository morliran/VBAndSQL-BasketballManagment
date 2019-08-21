Public Class PlayersDeleteForm
    Private myCheckError As MerrorControl = New MerrorControl()
    Private Manager As ClassCheckManager = New ClassCheckManager()
    Private intHeight As Integer
#Region "פונקציות של הפורם"
    Private Sub PlayersDeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCheckError.setWantsTime(False)
        Tb_Teamname.Text = ManagersMain.getManager.CheckTeam()
        myCheckError.setFormControlsEvent(Me)
        Panel_PlayerDel.Location = New Point((Me.Width - Panel_PlayerDel.Width) \ 2, (Me.Height - Panel_PlayerDel.Height) \ 2)
        Panel_PlayerDel.BackColor = Color.FromArgb(75, Color.DarkGray)
        Btn_AutoClick.PerformClick()
        For Each rowheight As DataGridViewRow In DataGridView1.Rows ' משנה את גודל הdatagrid בהתאם לגודל הטבלה שהוחזרה מהdatabase '
            intHeight += rowheight.Height
        Next
        DataGridView1.Height = intHeight + 23
    End Sub
    Private Sub PlayersDeleteForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        AdminsMain.Show()
    End Sub
    Private Sub PlayersDeleteForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel_PlayerDel.Location = New Point((Me.Width - Panel_PlayerDel.Width) \ 2, (Me.Height - Panel_PlayerDel.Height) \ 2)
    End Sub
    Private Function GetData(ByVal code As String) As DataView
        Dim Arr() As String = New String() {"HisHomeTeamCode", "=", code, "", "", ""}
        Return AdminsMain.getDBHelper.getDataView("Players", Arr, 2)
    End Function
#End Region
#Region "אירועים בעת לחיצה על אחת מן התמונות"
    Private Sub Btn_AutoClick_Click(sender As Object, e As EventArgs) Handles Btn_AutoClick.Click
        DataGridView1.DataSource = GetData(Manager.GetHomeCode())
        TimerAutoClick.Start()
        TimerAutoClick.Stop()
    End Sub
    Private Sub Pic_Delete_Click(sender As Object, e As EventArgs) Handles Pic_Delete.Click
        Dim n As String = MsgBox("Are you sure that you want remove this player from the league?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            AdminsMain.getDBHelper.DeleteFromTable(Me, Tb_Pcode.Text)
            Btn_AutoClick.PerformClick()
        End If
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(0)
        HelpForm.SetSelectedNode("Node_AdmDeleteP")
        HelpForm.Show()
    End Sub
#End Region
#Region "אירוע בעת לחיצה על שורה בטבלת הנתונים"
    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Tb_Pcode.Text = DataGridView1.Item(0, i).Value
        Tb_Pname.Text = DataGridView1.Item(2, i).Value + " " + DataGridView1.Item(3, i).Value
    End Sub
#End Region
End Class