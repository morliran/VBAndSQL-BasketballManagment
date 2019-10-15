Public Class GuestMain
    Private myHelper As MyDBControler = New MyDBControler()
    Private BtnQueryClickCnt As Integer = 0, BtnSearchClickCnt As Integer = 0
    Private SpaceStringBuild As New System.Text.StringBuilder, ButtonText As String = "", ArrCode() As String = New String() {}
#Region "פונקציות של הפורם"
    Private Sub GuestMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cntChars As Integer = 0
        Accessibility.SetDesignToAllForms(Me)
        CB_Temp.Focus()
        For i As Integer = 0 To Lbl_Welcome.Text.Length - 1
            If Char.IsLetter(Lbl_Welcome.Text(i)) Then
                cntChars += 1
            End If
        Next
        While cntChars <> 0
            SpaceStringBuild.Append(" ")
            cntChars -= 1
        End While
        Btn_QueryInfo.Text &= SpaceStringBuild.ToString() & "▼"
        Btn_SearchPlayer.Text &= SpaceStringBuild.ToString() & "▼"
        LeagueLeaders.HoverForeColor = ColorTranslator.FromHtml("#2BA5FF")
        LeagueLeaders.HoverBackColor = ColorTranslator.FromHtml("#E8ECFC")
        LeagueLeaders.LeaveForeColor = Color.Black
    End Sub
    Private Sub GuestMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseMe()
        MainView.ReturnToMe()
    End Sub
    Private Sub CloseMe()
        Me.Hide()
        Me.Dispose()
    End Sub
    Private Sub AddItemsToComboBox(ByVal ComBox As ComboBox)
        ComBox.Items.Clear()
        For i As Integer = 0 To CB_Temp.Items.Count - 1
            ComBox.Items.Add(CB_Temp.Items(i))
        Next
    End Sub
    Private Sub ClearSearchCombo()
        Cmb_OpSearch.Items.Clear()
        Cmb_SearchBy.Items.Clear()
        CB_Temp.Items.Clear()
        Cmb_OpSearch.Text = "Choose operator"
        Cmb_SearchBy.Text = "Search by value"
    End Sub
    Public Sub DesignDataGrid(ByVal DGV As DataGridView)
        Accessibility.SetDataGridDesign(DGV, 3)
    End Sub
    Public Function GetHelper() As MyDBControler
        Return Me.myHelper
    End Function
    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        DesignDataGrid(DataGridView1)
    End Sub
#End Region
#Region "אירועים בעת לחיצה על הכפתורים"
    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs) Handles Btn_QueryInfo.MouseEnter, Btn_BasicInfo.MouseEnter, Btn_TeamsInfo.MouseEnter, Btn_OthersInfo.MouseEnter, Btn_SearchPlayer.MouseEnter, Btn_ByJersey.MouseEnter, Btn_ByHeight.MouseEnter, Btn_ByDOB.MouseEnter, _
        Btn_ByPosition.MouseEnter, Btn_BySPosition.MouseEnter, Btn_StartSearch.MouseEnter, Btn_HelpMe.MouseEnter, Btn_GameVis.MouseEnter, Btn_LeagueLead.MouseEnter, Btn_Help.MouseEnter
        Dim btn As Button = sender
        btn.ForeColor = ColorTranslator.FromHtml("#2BA5FF")
        btn.BackColor = ColorTranslator.FromHtml("#E8ECFC")
        btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles Btn_QueryInfo.MouseLeave, Btn_BasicInfo.MouseLeave, Btn_TeamsInfo.MouseLeave, Btn_OthersInfo.MouseLeave, Btn_SearchPlayer.MouseLeave, Btn_ByJersey.MouseLeave, Btn_ByHeight.MouseLeave, Btn_ByDOB.MouseLeave, _
        Btn_ByPosition.MouseLeave, Btn_BySPosition.MouseLeave, Btn_StartSearch.MouseLeave, Btn_HelpMe.MouseLeave, Btn_GameVis.MouseLeave, Btn_LeagueLead.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = Color.Black
        btn.BackColor = FLP_Menu.BackColor
        btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular)
    End Sub
    Private Sub BtnPanelsOpen_Click(sender As Object, e As EventArgs) Handles Btn_QueryInfo.Click, Btn_SearchPlayer.Click
        Dim btn As Button = sender
        Select Case btn.Name
            Case "Btn_QueryInfo"
                If BtnQueryClickCnt Mod 2 = 0 Then
                    Btn_QueryInfo.Text = "Query info" & SpaceStringBuild.ToString() & "▲"
                    FLP_Query.Visible = True
                Else
                    Btn_QueryInfo.Text = "Query info" & SpaceStringBuild.ToString() & "▼"
                    FLP_Query.Visible = False
                End If
                BtnQueryClickCnt += 1
            Case "Btn_SearchPlayer"
                If BtnSearchClickCnt Mod 2 = 0 Then
                    Btn_SearchPlayer.Text = "Search player" & SpaceStringBuild.ToString() & "▲"
                    FLP_SearchBy.Visible = True
                Else
                    Btn_SearchPlayer.Text = "Search player" & SpaceStringBuild.ToString() & "▼"
                    ClearSearchCombo()
                    FLP_SearchBy.Visible = False
                    For Each b As Button In FLP_SearchBy.Controls.OfType(Of Button)()
                        b.Visible = True
                    Next
                End If
                BtnSearchClickCnt += 1
        End Select
    End Sub
    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles Btn_BasicInfo.Click, Btn_TeamsInfo.Click, Btn_OthersInfo.Click
        Dim btn As Button = sender
        Select Case btn.Name
            Case "Btn_BasicInfo"
                GuestQueriesSections.Lbl_Check.Text = "1/3"
            Case "Btn_TeamsInfo"
                GuestQueriesSections.Lbl_Check.Text = "2/3"
            Case "Btn_OthersInfo"
                GuestQueriesSections.Lbl_Check.Text = "3/3"
        End Select
        CloseMe()
        GuestQueriesSections.Show()
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles Btn_ByJersey.Click, Btn_ByHeight.Click, Btn_ByDOB.Click, Btn_ByPosition.Click, Btn_BySPosition.Click
        Dim btn As Button = sender, ArrOp() As String = New String() {"=", "<>", "<", ">", "<=", ">="}
        ClearSearchCombo()
        Cmb_OpSearch.Items.AddRange(ArrOp)
        For Each b As Button In FLP_SearchBy.Controls.OfType(Of Button)()
            If Not b.Name.Equals(btn.Name) AndAlso Not b.Name.Equals("Btn_HelpMe") Then
                b.Visible = False
            End If
        Next
        Cmb_SearchBy.Text = "Search " & btn.Text.ToLower()
        ButtonText = Cmb_SearchBy.Text
        Select Case btn.Name
            Case "Btn_ByPosition", "Btn_BySPosition"
                For i As Integer = Cmb_OpSearch.Items.Count - 1 To 2 Step -1
                    Cmb_OpSearch.Items.RemoveAt(i)
                Next
                If btn.Name.Equals("Btn_ByPosition") Then
                    myHelper.FillBoxes(CB_Temp, "Get all main position")
                Else
                    myHelper.FillBoxes(CB_Temp, "Get all second position")
                End If
            Case "Btn_ByJersey"
                myHelper.FillBoxes(CB_Temp, "Get all jersey num")
            Case "Btn_ByHeight"
                myHelper.FillBoxes(CB_Temp, "Get all players height")
            Case "Btn_ByDOB"
                myHelper.FillBoxes(CB_Temp, "Get all birthday")
        End Select
        AddItemsToComboBox(Cmb_SearchBy)
    End Sub
    Private Sub Btn_StartSearch_Click(sender As Object, e As EventArgs) Handles Btn_StartSearch.Click
        For Each b As Button In FLP_SearchBy.Controls.OfType(Of Button)()
            b.Visible = True
        Next
        If Not Cmb_OpSearch.Text.Equals("Choose operator") AndAlso Not Cmb_SearchBy.Text.Equals(ButtonText) AndAlso Not Cmb_SearchBy.Text.Equals("Search by value") Then
            ArrCode = {Cmb_OpSearch.Text, Cmb_SearchBy.Text}
            DataGridView1.Visible = True
            Select Case ButtonText
                Case "Search by jerseynum"
                    DataGridView1.DataSource = myHelper.GetDataView("Jerseynum", ArrCode)
                Case "Search by height"
                    DataGridView1.DataSource = myHelper.GetDataView("Height", ArrCode)
                Case "Search by date of birth"
                    DataGridView1.DataSource = myHelper.GetDataView("Dateofbirth", ArrCode)
                Case "Search by main position"
                    DataGridView1.DataSource = myHelper.GetDataView("Position", ArrCode)
                Case "Search by second position"
                    DataGridView1.DataSource = myHelper.GetDataView("SecondPosition", ArrCode)
            End Select
            DataGridView1.Columns("Height").DefaultCellStyle.Format = "N2"
            DesignDataGrid(DataGridView1)
        Else
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearSearchCombo()
        End If
    End Sub
    Private Sub Btn_HelpMe_Click(sender As Object, e As EventArgs) Handles Btn_HelpMe.Click, Btn_Help.Click
        Dim btn As Button = sender
        HelpForm.SetFormTag(2)
        Select Case btn.Name
            Case "Btn_HelpMe"
                HelpForm.SetSelectedNode("Node_BuildQuery")
            Case "Btn_Help"
                HelpForm.SetSelectedNode("Node_Guest")
        End Select
        HelpForm.Show()
    End Sub
    Private Sub Btn_GameVis_Click(sender As Object, e As EventArgs) Handles Btn_GameVis.Click
        GamesVisionsMyTeamVsOthers.Lbl_CheckBack.Text = "Guest main"
        CloseMe()
        GamesVisionsMyTeamVsOthers.Show()
    End Sub
    Private Sub Btn_LeagueLead_Click(sender As Object, e As EventArgs) Handles Btn_LeagueLead.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_GuestLeagueL")
        CloseMe()
        LeagueLeaders.Show()
    End Sub
#End Region
#Region "איוונטים על תיבות הבחירה בתפריט"
    Private Sub CmbSearchBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmb_OpSearch.KeyPress, Cmb_SearchBy.KeyPress
        e.Handled = True
        MessageBox.Show("Cant insert values inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region
End Class