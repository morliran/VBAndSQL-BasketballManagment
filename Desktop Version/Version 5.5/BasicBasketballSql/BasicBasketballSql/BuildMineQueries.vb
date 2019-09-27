Public Class BuildMineQueries
    Private CntrlV() As Control = New Control() {}
    Private CntrlUnV() As Control = New Control() {}
    Private CntrlUnE() As Control = New Control() {}
#Region "אופציות של הפורם"
    Private Sub BuildMineQueries_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        GuestMain.Show()
    End Sub
    Private Sub FormTimer()
        TimerAutoClick.Start()
        TimerAutoClick.Interval = 1000
        TimerAutoClick.Stop()
    End Sub
    Private Sub setControlsVisAndEna(ByVal ContVisible() As Control, ByVal ContHide() As Control, ByVal ContUnEnabled() As Control)
        If ContVisible IsNot Nothing Then
            For Each Cntrl In ContVisible
                Cntrl.Visible = True
            Next
        End If
        If ContHide IsNot Nothing Then
            For Each Cntrl In ContHide
                Cntrl.Visible = False
            Next
        End If
        If ContUnEnabled IsNot Nothing Then
            For Each Cntrl In ContUnEnabled
                Cntrl.Enabled = False
            Next
        End If
    End Sub
    Private Sub ResetControls()
        For Each Control In Me.Controls
            If TypeOf Control Is ComboBox AndAlso Not Control.Name.Equals("CB_FillBySPosition") AndAlso Not Control.Name.Equals("CB_Rule3") Then
                Control.Enabled = True
                Control.Text = ""
                Control.Visible = True
            ElseIf TypeOf Control Is ComboBox AndAlso Control.Name.Equals("CB_FillBySPosition") Or Control.Name.Equals("CB_Rule3") Then
                Control.Enabled = True
                Control.Text = ""
                Control.Visible = False
            ElseIf TypeOf Control Is CheckBox Then
                Control.Enabled = True
                Control.Checked = False
            End If
        Next Control
    End Sub
#End Region
#Region "פעולות שקורות בעת לחיצה על התמונות"
    Private Sub Btn_AutoClick_Click(sender As Object, e As EventArgs) Handles Btn_AutoClick.Click
        Dim ArrCode() As String = New String() {CB_Rule.Text, Lbl_Check.Text, CB_Rule2.Text, CB_Rule3.Text, Lbl_Check2.Text}
        If Chb_Jn.Checked Then
            DataGridView2.DataSource = GuestMain.getHelper.getDataView("Jerseynum", ArrCode)
        ElseIf Chb_Height.Checked Then
            DataGridView2.DataSource = GuestMain.getHelper.getDataView("Height", ArrCode)
        ElseIf Chb_Pos.Checked Then
            DataGridView2.DataSource = GuestMain.getHelper.getDataView("Position", ArrCode)
        ElseIf Chb_SecondPos.Checked Then
            DataGridView2.DataSource = GuestMain.getHelper.getDataView("SecondPosition", ArrCode)
        ElseIf Chb_DOB.Checked Then
            DataGridView2.DataSource = GuestMain.getHelper.getDataView("DOB", ArrCode)
            FormTimer()
        End If
        If Chb_FAndSpos.Checked Then
            If Lbl_Check.Text = Lbl_Check2.Text Then
                CB_FillBySPosition.Text = "None"
                Lbl_Check2.Text = "None"
            End If
            DataGridView2.DataSource = GuestMain.getHelper.getDataView("BothPosition", ArrCode)
            FormTimer()
        End If
    End Sub
    Private Sub Pic_Start_Click(sender As Object, e As EventArgs) Handles Pic_Start.Click
        If CB_FillByJn.Visible = True Then
            Lbl_Check.Text = CB_FillByJn.Text
        ElseIf CB_FillByHeight.Visible = True Then
            Lbl_Check.Text = CB_FillByHeight.Text
        ElseIf CB_FillByPosition.Visible = True Then
            Lbl_Check.Text = CB_FillByPosition.Text
        ElseIf CB_FillBySecondPos.Visible = True Then
            Lbl_Check.Text = CB_FillBySecondPos.Text
        ElseIf CB_FillByDOB.Visible = True Then
            Lbl_Check.Text = CB_FillByDOB.Text
        End If
        If CB_FillBySPosition.Visible = True Then
            Lbl_Check2.Text = CB_FillBySPosition.Text
        End If
        Btn_AutoClick.PerformClick()
    End Sub
    Private Sub Pic_Reset_Click(sender As Object, e As EventArgs) Handles Pic_Reset.Click
        ResetControls()
        Tb_Col.Text = ""
        Tb_Col2.Text = ""
        Tb_Col2.Visible = False
        Lbl_Check2.Visible = False
        Lbl_And.Visible = False
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_BuildQuery")
        HelpForm.Show()
    End Sub
#End Region
#Region "איוונטים על האובייקטים שבפורם"
    Private Sub Chb_Jn_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Jn.CheckedChanged
        If Chb_Jn.Checked Then
            CntrlV = {CB_Rule}
            CntrlUnV = {CB_Rule2, CB_FillByHeight, CB_FillByDOB, CB_FillByPosition, CB_FillBySPosition, CB_FillBySecondPos}
            CntrlUnE = {Chb_DOB, Chb_Pos, Chb_SecondPos, Chb_Height, Chb_FAndSpos}
            setControlsVisAndEna(CntrlV, CntrlUnV, CntrlUnE)
            Tb_Col.Text = "[Jerseynum]"
            GuestMain.getHelper.FillBoxes(CB_FillByJn, "Get all jersey num")
        End If
    End Sub
    Private Sub Chb_Pos_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Pos.CheckedChanged
        If Chb_Pos.Checked Then
            CntrlUnV = {CB_Rule, CB_FillByJn, CB_FillByHeight, CB_FillByDOB, CB_FillBySPosition, CB_FillBySecondPos}
            CntrlUnE = {Chb_DOB, Chb_Jn, Chb_SecondPos, Chb_Height, Chb_FAndSpos}
            setControlsVisAndEna(Nothing, CntrlUnV, CntrlUnE)
            Tb_Col.Text = "[Position]"
            GuestMain.getHelper.FillBoxes(CB_FillByPosition, "Get all main position")
        End If
    End Sub
    Private Sub Chb_SecondPos_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_SecondPos.CheckedChanged
        If Chb_SecondPos.Checked Then
            CntrlUnV = {CB_Rule, CB_FillByJn, CB_FillByHeight, CB_FillByDOB, CB_FillByPosition}
            CntrlUnE = {Chb_DOB, Chb_Jn, Chb_Pos, Chb_Height, Chb_FAndSpos}
            setControlsVisAndEna(Nothing, CntrlUnV, CntrlUnE)
            Tb_Col.Text = "[SecondPosition]"
            GuestMain.getHelper.FillBoxes(CB_FillBySecondPos, "Get all second position")
        End If
    End Sub
    Private Sub Chb_Height_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Height.CheckedChanged
        If Chb_Height.Checked Then
            CntrlV = {CB_Rule}
            CntrlUnV = {CB_Rule2, CB_FillByJn, CB_FillByDOB, CB_FillByPosition, CB_FillBySPosition, CB_FillBySecondPos}
            CntrlUnE = {Chb_DOB, Chb_Pos, Chb_SecondPos, Chb_Jn, Chb_FAndSpos}
            setControlsVisAndEna(CntrlV, CntrlUnV, CntrlUnE)
            Tb_Col.Text = "[Height]"
            GuestMain.getHelper.FillBoxes(CB_FillByHeight, "Get all players height")
        End If
    End Sub
    Private Sub Chb_DOB_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_DOB.CheckedChanged
        If Chb_DOB.Checked Then
            CntrlUnV = {CB_Rule2, CB_FillByJn, CB_FillByHeight, CB_FillBySecondPos, CB_FillByPosition, CB_FillBySPosition}
            CntrlUnE = {Chb_SecondPos, Chb_Jn, Chb_Pos, Chb_Height, Chb_FAndSpos}
            setControlsVisAndEna(Nothing, CntrlUnV, CntrlUnE)
            Tb_Col.Text = "[Dateofbirth]"
            GuestMain.getHelper.FillBoxes(CB_FillByDOB, "Get all birthday")
        End If
    End Sub
    Private Sub Chb_FAndSpos_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_FAndSpos.CheckedChanged
        If Chb_FAndSpos.Checked Then
            Chb_Pos.Checked = True
            Chb_SecondPos.Checked = True
            CntrlV = {CB_Rule2, CB_Rule3, Lbl_And, Tb_Col2, CB_FillByPosition, CB_FillBySPosition}
            CntrlUnV = {CB_Rule, CB_FillByJn, CB_FillByDOB, CB_FillByHeight, CB_FillBySecondPos}
            CntrlUnE = {Chb_DOB, Chb_Height, Chb_Jn, Tb_Col2}
            setControlsVisAndEna(CntrlV, CntrlUnV, CntrlUnE)
            Tb_Col.Text = "[Position]"
            Tb_Col2.Text = "[SecondPosition]"
            GuestMain.getHelper.FillBoxes(CB_FillByPosition, "Get all main position")
            If Chb_SecondPos.Checked Then
                GuestMain.getHelper.FillBoxes(CB_FillBySPosition, "Get all second position")
            End If
        End If
    End Sub
    Private Sub CB_Rule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Rule.SelectedIndexChanged
        CB_Rule.Enabled = False
    End Sub
    Private Sub CB_Rule2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Rule2.SelectedIndexChanged
        CB_Rule2.Enabled = False
    End Sub
    Private Sub CB_Rule3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Rule3.SelectedIndexChanged
        CB_Rule3.Enabled = False
    End Sub
    Private Sub CB_Rule_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Rule.KeyPress
        e.Handled = True
        MessageBox.Show("Cant Insert Values Inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        CB_Rule.Text = ""
        CB_Rule.Focus()
    End Sub
    Private Sub CB_Rule2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Rule2.KeyPress
        e.Handled = True
        MessageBox.Show("Cant Insert Values Inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        CB_Rule2.Text = ""
        CB_Rule2.Focus()
    End Sub
    Private Sub CB_Rule3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Rule3.KeyPress
        e.Handled = True
        MessageBox.Show("Cant Insert Values Inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        CB_Rule3.Text = ""
        CB_Rule3.Focus()
    End Sub
#End Region
End Class