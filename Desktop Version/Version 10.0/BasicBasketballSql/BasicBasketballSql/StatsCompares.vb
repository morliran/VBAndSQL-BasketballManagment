Imports System.Windows.Forms.DataVisualization.Charting 'To allow the option to work with charts on form
Public Class StatsCompares
    Private Dtable As DataTable, Ds As DataSet, Temptable As DataTable, TempDs As DataSet
    Private LabelHeadText() As String = New String() {"Points", "Assists", "Rebounds", "Steels", "Blocks"}
#Region "אופציות על הפורם"
    Private Sub StatsCompares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManagersMain.GetMyError().SetPanelControlsEvents(Panel_Controls, Me)
        FillPlayersCodeBox()
        Lbl_TeamName.Text = "Compare stats for " & ClassCheckManager.GetManagerTeamName() & " Players"
        ManagersMain.GetDBHelper.FillBoxes(CB_Playercode, ClassCheckManager.GetHomeC(), 2, CB_POneNames)
        ManagersMain.GetDBHelper.FillBoxes(CB_Playercode2, ClassCheckManager.GetHomeC(), 2, CB_PTwoNames)
        Accessibility.SetDesignToAllForms(Me)
        ClassCheckManager.SetSubFormsColors(Me)
        TLP_Buttons.BackColor = ManagersMain.FLP_Move.BackColor
        Btn_PersonalPlayerOne.ForeColor = Panel_Top.BackColor
        Btn_PersonalPlayerTwo.ForeColor = Panel_Top.BackColor
        Tb_TempFocus.Font = New Font(Tb_TempFocus.Font.FontFamily, 6)
        Tb_TempFocus.Focus()
    End Sub
    Private Sub StatsCompares_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        ManagersMain.SetTeamPlayersTable()
        ManagersMain.Show()
    End Sub
#End Region
#Region "אירוע בעת לחיצה על התמונה שיש בפורם"
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_StatsP")
        HelpForm.Show()
    End Sub
#End Region
#Region "מילוי תיבות הComboBox"
    Private Sub FillPlayersCodeBox()
        Ds = New DataSet("ds")
        Dtable = ManagersMain.GetDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Playercode, CB_Playercode2, ClassCheckManager.GetHomeC(), True)
    End Sub
    Private Sub FillGameTypesBox(ByVal BoxNumber As Integer)
        Ds = New DataSet("ds")
        TempDs = New DataSet("tempds")
        If BoxNumber = 1 Then
            Dtable = ManagersMain.GetDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Gametype, Nothing, ClassCheckManager.GetManagerTeamName(), False)
            Temptable = ManagersMain.GetDBHelper.FillDataTableAndBoxs(Temptable, TempDs, CB_Temp, Nothing, CB_Playercode.Text)
            If CB_Gametype.Items.Count <> CB_Temp.Items.Count Then 'If the player doesn't played in some game I'll delete this gametype from the gametype box option 
                ManagersMain.GetMyError.DeleteDuplicateItems(CB_Gametype, CB_Temp)
                FillPersonalPlayedGames(CB_Gametype, CB_UntillGameTOne)
            Else
                CB_Gametype.Items.Clear() 'If the player doesn't played in all gametypes
                CB_UntillGameTOne.Items.Clear()
            End If
        ElseIf BoxNumber = 2 Then
            Dtable = ManagersMain.GetDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Gametype2, Nothing, ClassCheckManager.GetManagerTeamName(), False)
            Temptable = ManagersMain.GetDBHelper.FillDataTableAndBoxs(Temptable, TempDs, CB_Temp2, Nothing, CB_Playercode2.Text)
            If CB_Gametype2.Items.Count <> CB_Temp2.Items.Count Then 'if the player doesn't played in some game i'll delete this gametype from the gametype box option 
                ManagersMain.GetMyError.DeleteDuplicateItems(CB_Gametype2, CB_Temp2)
                FillPersonalPlayedGames(CB_Gametype2, CB_UntillGameTTwo)
            Else
                CB_Gametype2.Items.Clear() 'if the player doesn't played in all gametypes
                CB_UntillGameTTwo.Items.Clear()
            End If
        End If
    End Sub
    Private Sub FillPersonalPlayedGames(ByVal MainCombo As ComboBox, ByVal TempCombo As ComboBox)
        TempCombo.Items.Clear()
        For i As Integer = 0 To MainCombo.Items.Count - 1
            TempCombo.Items.Add(MainCombo.Items(i))
        Next
    End Sub
#End Region
#Region "אירועים בעת שינוי ערך אחת מן תיבות הבחירה של קודי השחקנים"
    Private Sub ResetChart(ByVal ChartName As Chart, ByVal SeriesName As String, ByVal AreaName As String)
        ChartName.Series.Clear()
        ChartName.Series.Add(SeriesName)
        ChartName.Titles.Clear()
        ChartName.ChartAreas(AreaName).Visible = False
    End Sub
    Private Sub ComboCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Playercode.SelectedIndexChanged, CB_Playercode2.SelectedIndexChanged
        Dim cmb As ComboBox = sender, index As Integer = 0
        Select Case cmb.Name
            Case "CB_Playercode"
                ResetChart(Chart1, "Players stats1", "ChartArea1")
                index = 1
            Case "CB_Playercode2"
                ResetChart(Chart2, "Players stats2", "ChartArea2")
                index = 2
        End Select
        If index <> 0 Then
            FillGameTypesBox(index)
        End If
    End Sub
    Private Sub ComboNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_POneNames.SelectedIndexChanged, CB_PTwoNames.SelectedIndexChanged
        Dim cmb As ComboBox = sender, index As Integer = 0
        index = cmb.SelectedIndex
        Select Case cmb.Name
            Case "CB_POneNames"
                CB_Playercode.SelectedItem = CB_Playercode.Items(index).ToString()
                FillGameTypesBox(1)
            Case "CB_PTwoNames"
                CB_Playercode2.SelectedItem = CB_Playercode2.Items(index).ToString()
                FillGameTypesBox(2)
        End Select
    End Sub
#End Region
#Region "פונקציות למילוי החלקים של הגרפים"
    Public Sub SetTheColorsAndFont(ByVal Name As Chart, ByVal SeriesName As String)
        Dim m_Rnd As New Random
        Name.Series(SeriesName).Points(0).Color = Color.FromArgb(255, m_Rnd.Next(0, 256), m_Rnd.Next(0, 256), m_Rnd.Next(0, 256))
        Name.Series(SeriesName).Points(1).Color = Color.Orange
        Name.Series(SeriesName).Points(2).Color = Color.DeepSkyBlue
        Name.Series(SeriesName).Points(3).Color = Color.AntiqueWhite
        Name.Series(SeriesName).Points(4).Color = Color.FromArgb(255, m_Rnd.Next(0, 256), m_Rnd.Next(0, 256), m_Rnd.Next(0, 256))
        Name.Series(SeriesName).IsValueShownAsLabel = True 'Show the values of the charts
        Name.Series(SeriesName).Font = New System.Drawing.Font("Century Gothic", 14, System.Drawing.FontStyle.Bold)
    End Sub
#End Region
#Region "שינוי מס' מחזור"
    Private Sub CB_Gametype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Gametype.SelectedIndexChanged
        Dim LabelText() As Label = New Label() {Lbl_Pointsnum, Lbl_Assistsnum, Lbl_Reboundsnum, Lbl_Steelsnum, Lbl_Blocksnum}
        Dim ArrCodes() As String = New String() {CB_Gametype.Text, CB_Playercode.Text, 1}
        DataGridView1.Visible = False
        Chart3.Visible = False
        Chart1.Visible = True
        Chart1.Series.Clear() 'Clear the charts if the user want to make another compares
        Chart1.Series.Add("Players stats1")
        Chart1.Titles.Clear()
        Chart1.ChartAreas("ChartArea1").Visible = True
        ManagersMain.GetDBHelper.FillChartLabels(Chart1, "Players stats1", LabelText, LabelHeadText, Dtable, ArrCodes)
        SetTheColorsAndFont(Chart1, "Players stats1")
        Chart1.ChartAreas("ChartArea1").BackColor = TLP_Charts.BackColor
        Chart1.Series("Players stats1").BorderColor = Color.Black
        Chart1.Series("Players stats1").LabelForeColor = Color.Black
        Chart1.Legends("Legend1").Enabled = True 'Show the category table to explain each color in the chart
        Chart1.Series("Players stats1").ChartType = SeriesChartType.Pie
        Chart1.Series("Players stats1")("PieLabelStyle") = "Outside"
        Panel_UntillOne.Visible = True
    End Sub
    Private Sub CB_Gametype2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Gametype2.SelectedIndexChanged
        Dim LabelText2() As Label = New Label() {Lbl_Pointsnum2, Lbl_Assistsnum2, Lbl_Reboundsnum2, Lbl_Steelsnum2, Lbl_Blocksnum2}
        Dim ArrCodes2() As String = New String() {CB_Gametype2.Text, CB_Playercode2.Text, 1}
        DataGridView2.Visible = False
        Chart4.Visible = False
        Chart2.Visible = True
        Chart2.Series.Clear() 'Clear the charts if the user want to make another compares
        Chart2.Series.Add("Players stats2")
        Chart2.Titles.Clear()
        Chart2.ChartAreas("ChartArea2").Visible = True
        ManagersMain.GetDBHelper.FillChartLabels(Chart2, "Players stats2", LabelText2, LabelHeadText, Dtable, ArrCodes2)
        SetTheColorsAndFont(Chart2, "Players stats2")
        Chart2.ChartAreas("ChartArea2").BackColor = TLP_Charts.BackColor
        Chart2.Series("Players stats2").BorderColor = Color.Black
        Chart2.Series("Players stats2").LabelForeColor = Color.Black
        Chart2.Legends("Legend1").Enabled = True 'Show the category table to explain each color in the chart
        Chart2.Series("Players stats2").ChartType = SeriesChartType.Pie
        Chart2.Series("Players stats2")("PieLabelStyle") = "Outside"
        Panel_UntillTwo.Visible = True
    End Sub
#End Region
#Region "אזור העיצוב של הגרפים"
    Private Sub CB_ChartTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ChartTypes.SelectedIndexChanged
        Chart1.Series("Players stats1").ChartType = [Enum].Parse(GetType(SeriesChartType), CB_ChartTypes.SelectedItem.ToString())
        Chart2.Series("Players stats2").ChartType = [Enum].Parse(GetType(SeriesChartType), CB_ChartTypes.SelectedItem.ToString())
    End Sub
    Private Sub CB_ValuesPos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ValuesPos.SelectedIndexChanged
        Chart1.Series("Players stats1")("PieLabelStyle") = CB_ValuesPos.Text
        Chart2.Series("Players stats2")("PieLabelStyle") = CB_ValuesPos.Text
    End Sub
    Private Sub RB_Yes_Click(sender As Object, e As EventArgs) Handles RB_Yes.Click
        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        Dim n As String = MsgBox("Want to see the other char in 3D?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            Chart2.ChartAreas("ChartArea2").Area3DStyle.Enable3D = True
        End If
    End Sub
    Private Sub RB_No_Click(sender As Object, e As EventArgs) Handles RB_No.Click
        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
        Chart2.ChartAreas("ChartArea2").Area3DStyle.Enable3D = False
    End Sub
    Private Sub Combo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_ValuesPos.KeyPress, CB_ChartTypes.KeyPress, CB_UntillGameTOne.KeyPress, CB_UntillGameTTwo.KeyPress, Cb_WhatToShowOne.KeyPress, Cb_WhatToShowTwo.KeyPress
        Dim cb As ComboBox = sender
        ManagersMain.GetMyError.isUnvailed(e, cb)
    End Sub
#End Region
#Region "אזור השוואה לפי כל המשחקים"
    Private Sub FillPersonalCharts(ByVal ChartName As Chart, ByVal ChartAreaName As String, ByVal ColToShow As String, ByVal DGV As DataGridView)
        Dim ArrCodes() As String = New String() {}, i As Integer = 0
        Dtable = New DataTable
        DGV.Columns.Clear()
        ChartName.Series.Clear()
        ChartName.Series.Add(ColToShow)
        ChartName.Titles.Clear()
        ChartName.ChartAreas(ChartAreaName).Visible = True
        If ChartName.Name.Equals("Chart3") Then
            ArrCodes = {CB_UntillGameTOne.Text, CB_Playercode.Text, 2}
        ElseIf ChartName.Name.Equals("Chart4") Then
            ArrCodes = {CB_UntillGameTTwo.Text, CB_Playercode2.Text, 2}
        End If
        ManagersMain.GetDBHelper.FillChartLabels(ChartName, "", Nothing, Nothing, Dtable, ArrCodes)
        DGV.DataSource = Dtable
        For i = 0 To DGV.Columns.Count - 1
            If DGV.Columns(i).Name.Equals("GamesTypes") Or DGV.Columns(i).Name.Equals(ColToShow) Then
                DGV.Columns(i).Visible = True
            Else
                DGV.Columns(i).Visible = False
            End If
        Next
        ManagersMain.DesignDataGrid(DGV)
        For i = 0 To Dtable.Rows.Count - 1
            ChartName.Series(ColToShow).Points.AddXY(Dtable.Rows(i)("GamesTypes").ToString(), Dtable.Rows(i)(ColToShow).ToString())
        Next
        ChartName.ChartAreas(ChartAreaName).BackColor = TLP_Charts.BackColor
        ChartName.Series(ColToShow).Points(0).Color = Color.DeepSkyBlue
        ChartName.Series(ColToShow).LabelForeColor = Color.Black
        ChartName.Series(ColToShow).ChartType = SeriesChartType.Line
        ChartName.Series(ColToShow).BorderWidth = 5
        ChartName.Series(ColToShow).MarkerColor = Color.Black
        ChartName.Series(ColToShow).MarkerStyle = MarkerStyle.Circle
        ChartName.Series(ColToShow).MarkerSize = 10
        ChartName.Legends("Legend1").Enabled = True 'Show the category table to explain each color in the chart
    End Sub
    Private Sub Btn_PersonalPlayerOne_Click(sender As Object, e As EventArgs) Handles Btn_PersonalPlayerOne.Click
        If Btn_PersonalPlayerOne.Text.Equals("Show personal comparing") Then
            If CB_UntillGameTOne.Text.Equals("Untill game type") Or CB_UntillGameTOne.Text.Equals("") Or Cb_WhatToShowOne.Text.Equals("Category to show") Or Cb_WhatToShowOne.Text.Equals("") Then
                MessageBox.Show("You have to select untill with game type to see personal comparing", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CB_UntillGameTOne.Focus()
                Exit Sub
            Else
                Chart1.Visible = False
                Chart3.Visible = True
                DataGridView1.Visible = True
                FillPersonalCharts(Chart3, Chart3.ChartAreas.Item(0).Name, Cb_WhatToShowOne.Text, DataGridView1)
                Btn_PersonalPlayerOne.Text = "Close personal comapre"
            End If
        Else
            Chart3.Visible = False
            DataGridView1.Visible = False
            Chart1.Visible = True
            Panel_UntillOne.Visible = False
            Btn_PersonalPlayerOne.Text = "Show personal comparing"
            CB_UntillGameTOne.Text = "Untill game type"
            Cb_WhatToShowOne.Text = "Category to show"
        End If
    End Sub
    Private Sub Btn_PersonalPlayerTwo_Click(sender As Object, e As EventArgs) Handles Btn_PersonalPlayerTwo.Click
        If Btn_PersonalPlayerTwo.Text.Equals("Show personal comparing") Then
            If CB_UntillGameTTwo.Text.Equals("Untill game type") Or CB_UntillGameTTwo.Text.Equals("") Or Cb_WhatToShowTwo.Text.Equals("Category to show") Or Cb_WhatToShowTwo.Text.Equals("") Then
                MessageBox.Show("You have to select untill with game type to see personal comparing", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CB_UntillGameTTwo.Focus()
                Exit Sub
            Else
                Chart2.Visible = False
                Chart4.Visible = True
                DataGridView2.Visible = True
                FillPersonalCharts(Chart4, Chart4.ChartAreas.Item(0).Name, Cb_WhatToShowTwo.Text, DataGridView2)
                Btn_PersonalPlayerTwo.Text = "Close personal comapre"
            End If
        Else
            Chart4.Visible = False
            DataGridView2.Visible = False
            Chart2.Visible = True
            Panel_UntillTwo.Visible = False
            Btn_PersonalPlayerTwo.Text = "Show personal comparing"
            CB_UntillGameTTwo.Text = "Untill game type"
            Cb_WhatToShowTwo.Text = "Category to show"
        End If
    End Sub
    Private Sub TLPButtons_MouseEnter(sender As Object, e As EventArgs) Handles Btn_PersonalPlayerOne.MouseEnter, Btn_PersonalPlayerTwo.MouseEnter
        Dim btn As Button = sender
        btn.BackColor = btn.ForeColor
        btn.ForeColor = TLP_Buttons.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub TLPButtons_MouseLeave(sender As Object, e As EventArgs) Handles Btn_PersonalPlayerOne.MouseLeave, Btn_PersonalPlayerTwo.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = btn.BackColor
        btn.BackColor = TLP_Buttons.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
End Class