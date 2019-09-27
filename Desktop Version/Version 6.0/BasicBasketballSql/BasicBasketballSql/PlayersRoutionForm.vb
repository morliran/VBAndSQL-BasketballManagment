Public Class PlayersRoutionForm
    Private myCheckError As MerrorControl = New MerrorControl()
    Private ArrCodes() As String = New String() {ManagersMain.getManager.CheckTeam(), ""}
    Private cnt As Integer = 0
#Region "פונקציות על הפורם"
    Private Sub PlayersRoutionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCheckError.setWantsTime(False)
        Me.BackgroundImage = ManagersMain.Pic_Menu.Image
        Panel_Roution.Location = New Point((Me.Width - Panel_Roution.Width) / 2, (Me.Height - Panel_Roution.Height) / 2)
        Panel_Roution.BackColor = Color.FromArgb(75, Color.DarkGray)
        Tb_Teamname.Text = ManagersMain.getManager.CheckTeam()
        cnt = ManagersMain.getDBHelper.getCountResults("CountMaxRoutionCode", ArrCodes)
        myCheckError.setFormControlsEvent(Me)
        Btn_AutoClick.PerformClick()
    End Sub
    Private Sub PlayersRoutionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        ManagersMain.Show()
    End Sub
    Private Sub PlayersRoutionForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel_Roution.Location = New Point((Me.Width - Panel_Roution.Width) / 2, (Me.Height - Panel_Roution.Height) / 2)
    End Sub
    Private Sub Btn_AutoClick_Click(sender As Object, e As EventArgs) Handles Btn_AutoClick.Click
        DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("SubsCode", ArrCodes)
        TimerAutoClick.Start()
        TimerAutoClick.Stop()
        Dim intHeight As Integer = 0
        For Each rowheight As DataGridViewRow In DataGridView1.Rows ' משנה את גודל הdatagrid בהתאם לגודל הטבלה שהוחזרה מהdatabase '
            intHeight += 23
        Next
        DataGridView1.Height = intHeight + 23
        ManagersMain.DesignDataGrid(DataGridView1)
    End Sub
#End Region
#Region "אירוע בעת לחיצה על שורה בטבלת הנתונים"
    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Tb_Pcode.Text = DataGridView1.Item(0, i).Value
        Tb_Pname.Text = DataGridView1.Item(1, i).Value
        Tb_Proutioncode.Text = DataGridView1.Item(2, i).Value
        Lbl_PrevCode.Text = DataGridView1.Item(2, i).Value
    End Sub
#End Region
#Region "אירועים בעת לחיצה על אחת מן התמונות"
    Private Sub Pic_UpdateRoution_Click(sender As Object, e As EventArgs) Handles Pic_UpdateRoution.Click
        ArrCodes = {Tb_Pcode.Text, Tb_Proutioncode.Text, Lbl_PrevCode.Text, Tb_Teamname.Text}
        If Integer.Parse(Tb_Proutioncode.Text) > cnt Then
            MessageBox.Show("Roution code cannot been above the maximum roution code in your team " & cnt, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        ManagersMain.getDBHelper.UpdateTable(Me, ArrCodes)
        MsgBox("Roution code succesfully update")
        ArrCodes = {ManagersMain.getManager.CheckTeam(), ""}
        Btn_AutoClick.PerformClick()
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_UpdateR")
        HelpForm.Show()
    End Sub
#End Region
End Class