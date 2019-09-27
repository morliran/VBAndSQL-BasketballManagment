Public Class GuestMain
    Private myHelper As MyDBControler = New MyDBControler()
    Private ArrCode() As String = New String() {}
#Region "פונקציות של הפורם"
    Private Sub GuestMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Location = New Point((SplitContainer1.Panel2.Width - DataGridView1.Width) \ 2, (SplitContainer1.Panel2.Height - DataGridView1.Height) \ 2)
    End Sub
    Private Sub GuestMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseMe()
        LoginForm.ReturnToMe()
    End Sub
    Private Sub CloseMe()
        Me.Hide()
        Me.Dispose()
    End Sub
    Private Sub SplitContainer1_Panel2_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Panel2.Resize
        DataGridView1.Location = New Point((SplitContainer1.Panel2.Width - DataGridView1.Width) \ 2, (SplitContainer1.Panel2.Height - DataGridView1.Height) \ 2)
    End Sub
    Private Sub AddItemsToToolComboBox(ByVal ToolBox As ToolStripComboBox)
        ToolBox.Items.Clear()
        For i As Integer = 0 To CB_Temp.Items.Count - 1
            ToolBox.Items.Add(CB_Temp.Items(i))
        Next
    End Sub
    Public Function getHelper() As MyDBControler
        Return Me.myHelper
    End Function
#End Region
#Region "אירועים בעת לחיצה על הכפתורים או תמונת העזרה"
    Private Sub Pic_Menu_Click(sender As Object, e As EventArgs) Handles Pic_Menu.Click
        Timer_Menu.Start()
        If Not SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = True
            Timer_Menu.Enabled = False
            Lbl_Menu.Text = "Open"
        End If
    End Sub
    Private Sub Timer_Menu_Tick(sender As Object, e As EventArgs) Handles Timer_Menu.Tick
        SplitContainer1.Panel1Collapsed = False
        Lbl_Menu.Text = "Close"
        Timer_Menu.Stop()
    End Sub
    Private Sub ConnditionInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnditionInfoToolStripMenuItem.Click
        GuestQueriesSections.Lbl_Check.Text = "1/3"
        CloseMe()
        GuestQueriesSections.Show()
    End Sub
    Private Sub TeamsInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeamsInfoToolStripMenuItem.Click
        GuestQueriesSections.Lbl_Check.Text = "2/3"
        CloseMe()
        GuestQueriesSections.Show()
    End Sub
    Private Sub OthersInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OthersInfoToolStripMenuItem.Click
        GuestQueriesSections.Lbl_Check.Text = "3/3"
        GuestQueriesSections.Btn_PageMove.Text = "First page"
        CloseMe()
        GuestQueriesSections.Show()
    End Sub
    Private Sub ShowCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCategoriesToolStripMenuItem.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_GuestLeagueL")
        CloseMe()
        LeagueLeaders.Show()
    End Sub
    Private Sub HelpMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpMeToolStripMenuItem.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_Guest")
        HelpForm.Show()
    End Sub
    Private Sub HelpMeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpMeToolStripMenuItem1.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_BuildQuery")
        HelpForm.Show()
    End Sub
    Private Sub ByJerseynumToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles ByJerseynumToolStripMenuItem.MouseHover
        Cmb_OpJer.Text = "Choose operator"
        Cmb_Jer.Text = "Choose jersey number"
        myHelper.FillBoxes(CB_Temp, "Get all jersey num")
        AddItemsToToolComboBox(Cmb_Jer)
    End Sub
    Private Sub StartSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartSearchToolStripMenuItem.Click
        If Cmb_OpJer.Text <> "Choose operator" AndAlso Cmb_Jer.Text <> "Choose jersey number" Then
            ArrCode = {Cmb_OpJer.Text, Cmb_Jer.Text}
            DataGridView1.DataSource = myHelper.getDataView("Jerseynum", ArrCode)
        Else
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ByHeightToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles ByHeightToolStripMenuItem.MouseHover
        Cmb_OpHeight.Text = "Choose operator"
        Cmb_Height.Text = "Choose height"
        myHelper.FillBoxes(CB_Temp, "Get all players height")
        AddItemsToToolComboBox(Cmb_Height)
    End Sub
    Private Sub StartSearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartSearchToolStripMenuItem1.Click
        If Cmb_OpHeight.Text <> "Choose operator" AndAlso Cmb_Height.Text <> "Choose height" Then
            ArrCode = {Cmb_OpHeight.Text, Cmb_Height.Text}
            DataGridView1.DataSource = myHelper.getDataView("Height", ArrCode)
        Else
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ByDateOfBirthToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles ByDateOfBirthToolStripMenuItem.MouseHover
        Cmb_OpDOB.Text = "Choose operator"
        Cmb_DOB.Text = "Choose date"
        myHelper.FillBoxes(CB_Temp, "Get all birthday")
        AddItemsToToolComboBox(Cmb_DOB)
    End Sub
    Private Sub StartSearchToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles StartSearchToolStripMenuItem2.Click
        If Cmb_OpDOB.Text <> "Choose operator" AndAlso Cmb_DOB.Text <> "Choose date" Then
            ArrCode = {Cmb_OpDOB.Text, Cmb_DOB.Text}
            DataGridView1.DataSource = myHelper.getDataView("DOB", ArrCode)
        Else
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ByMainPositionToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles ByMainPositionToolStripMenuItem.MouseHover
        Cmb_OpPos.Text = "Choose operator"
        Cmb_Pos.Text = "Choose position"
        myHelper.FillBoxes(CB_Temp, "Get all main position")
        AddItemsToToolComboBox(Cmb_Pos)
    End Sub
    Private Sub StartSearchToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles StartSearchToolStripMenuItem3.Click
        If Cmb_OpPos.Text <> "Choose operator" AndAlso Cmb_Pos.Text <> "Choose position" Then
            ArrCode = {Cmb_OpPos.Text, Cmb_Pos.Text}
            DataGridView1.DataSource = myHelper.getDataView("Position", ArrCode)
        Else
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BySecondPositionToolStripMenuItem_MouseHover(sender As Object, e As EventArgs) Handles BySecondPositionToolStripMenuItem.MouseHover
        Cmb_OpSPos.Text = "Choose operator"
        Cmb_SPos.Text = "Choose second position"
        myHelper.FillBoxes(CB_Temp, "Get all second position")
        AddItemsToToolComboBox(Cmb_SPos)
    End Sub
    Private Sub StartSearchToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles StartSearchToolStripMenuItem4.Click
        If Cmb_OpSPos.Text <> "Choose operator" AndAlso Cmb_SPos.Text <> "Choose second position" Then
            ArrCode = {Cmb_OpSPos.Text, Cmb_SPos.Text}
            DataGridView1.DataSource = myHelper.getDataView("SecondPosition", ArrCode)
        Else
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
#Region "איוונטים על תיבות הבחירה בתפריט"
    Private Sub Cmb_Operators_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_OpJer.KeyPress, Cmb_OpHeight.KeyPress, Cmb_OpDOB.KeyPress, Cmb_OpPos.KeyPress, Cmb_OpSPos.KeyPress
        e.Handled = True
        MessageBox.Show("Cant insert values inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        sender.Text = "Choose operator"
    End Sub
    Private Sub Cmb_Jer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_Jer.KeyPress
        e.Handled = True
        MessageBox.Show("Cant insert values inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Cmb_Jer.Text = "Choose jersey number"
    End Sub
    Private Sub Cmb_Height_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_Height.KeyPress
        e.Handled = True
        MessageBox.Show("Cant insert values inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Cmb_Height.Text = "Choose height"
    End Sub
    Private Sub Cmb_DOB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_DOB.KeyPress
        e.Handled = True
        MessageBox.Show("Cant insert values inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Cmb_DOB.Text = "Choose date"
    End Sub
    Private Sub Cmb_Pos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_Pos.KeyPress
        e.Handled = True
        MessageBox.Show("Cant insert values inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Cmb_Pos.Text = "Choose position"
    End Sub
    Private Sub Cmb_SPos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_SPos.KeyPress
        e.Handled = True
        MessageBox.Show("Cant insert values inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Cmb_SPos.Text = "Choose second position"
    End Sub
#End Region
End Class