Imports System.Windows.Forms.DataVisualization.Charting 'To allow the option to work with charts on form
Public Class StatsCompares
    Private Dtable As DataTable, Ds As DataSet, Temptable As DataTable, TempDs As DataSet
    Private LabelHeadText() As String = New String() {"Points", "Assists", "Rebounds", "Steels", "Blocks"}
    Private Merror As MerrorControl = New MerrorControl()
#Region "אופציות על הפורם"
    Private Sub StatsCompares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.setPanelControlsEvents(Panel_Controls, Me)
        FillPlayersCodeBox()
        Lbl_TeamName.Text = "Compare stats for " & ManagersMain.getManager.CheckTeam() & " Players"
        ManagersMain.getDBHelper.FillBoxes(CB_Playercode, ManagersMain.getManager.GetHomeCode(), 2, CB_POneNames)
        ManagersMain.getDBHelper.FillBoxes(CB_Playercode2, ManagersMain.getManager.GetHomeCode(), 2, CB_PTwoNames)
        Accessibility.SetDesignToAllForms(Me)
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
        Dtable = ManagersMain.getDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Playercode, CB_Playercode2, ManagersMain.getManager.GetHomeCode(), True)
    End Sub
    Private Sub FillGameTypesBox(ByVal BoxNumber As Integer)
        Ds = New DataSet("ds")
        TempDs = New DataSet("tempds")
        If BoxNumber = 1 Then
            Dtable = ManagersMain.getDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Gametype, Nothing, ManagersMain.getManager.CheckTeam(), False)
            Temptable = ManagersMain.getDBHelper.FillDataTableAndBoxs(Temptable, TempDs, CB_Temp, Nothing, CB_Playercode.Text)
            If CB_Gametype.Items.Count <> CB_Temp.Items.Count Then 'If the player doesn't played in some game I'll delete this gametype from the gametype box option 
                DeleteUnPlayedGames(CB_Gametype, CB_Temp)
                FillPersonalPlayedGames(CB_Gametype, CB_UntillGameTOne)
            Else
                CB_Gametype.Items.Clear() 'If the player doesn't played in all gametypes
                CB_UntillGameTOne.Items.Clear()
            End If
        ElseIf BoxNumber = 2 Then
            Dtable = ManagersMain.getDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Gametype2, Nothing, ManagersMain.getManager.CheckTeam(), False)
            Temptable = ManagersMain.getDBHelper.FillDataTableAndBoxs(Temptable, TempDs, CB_Temp2, Nothing, CB_Playercode2.Text)
            If CB_Gametype2.Items.Count <> CB_Temp2.Items.Count Then 'if the player doesn't played in some game i'll delete this gametype from the gametype box option 
                DeleteUnPlayedGames(CB_Gametype2, CB_Temp2)
                FillPersonalPlayedGames(CB_Gametype2, CB_UntillGameTTwo)
            Else
                CB_Gametype2.Items.Clear() 'if the player doesn't played in all gametypes
                CB_UntillGameTTwo.Items.Clear()
            End If
        End If
    End Sub
    Private Sub DeleteUnPlayedGames(ByVal MainCombo As ComboBox, ByVal TempCombo As ComboBox)
        Dim DontParticipateGames As New List(Of String), NewGameTypes As New List(Of String)
        For Each item As String In TempCombo.Items 'Adding the games types that the player doesn't participated to list
            DontParticipateGames.Add(item)
        Next
        For Each str As String In MainCombo.Items 'Check if the item inside the main comboBox is contains inside DontParticipateGames list
            If DontParticipateGames.Contains(str) = False Then 'If no add him to the newGameType List
                NewGameTypes.Add(str)
            End If
        Next
        MainCombo.Items.Clear() 'Making sure that the main comboBox items is clear
        MainCombo.Items.AddRange(NewGameTypes.ToArray()) 'Adding the new game type list to the main comboBox
    End Sub
    Private Sub FillPersonalPlayedGames(ByVal MainCombo As ComboBox, ByVal TempCombo As ComboBox)
        TempCombo.Items.Clear()
        For i As Integer = 0 To MainCombo.Items.Count - 1
            TempCombo.Items.Add(MainCombo.Items(i))
        Next
    End Sub
#End Region
#Region "אירועים בעת שינוי ערך אחת מן תיבות הבחירה של קודי השחקנים"
    Private Sub CB_Playercode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Playercode.SelectedIndexChanged
        Chart1.Series.Clear()
        Chart1.Series.Add("Players stats1")
        Chart1.Titles.Clear()
        Chart1.ChartAreas("ChartArea1").Visible = False
        FillGameTypesBox(1)
    End Sub
    Private Sub CB_Playercode2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Playercode2.SelectedIndexChanged
        Chart2.Series.Clear()
        Chart2.Series.Add("Players stats2")
        Chart2.Titles.Clear()
        Chart2.ChartAreas("ChartArea2").Visible = False
        FillGameTypesBox(2)
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
    Public Sub SetTheColorsAndFont(ByVal Name As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal SeriesName As String)
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
        ManagersMain.getDBHelper.FillChartLabels(Chart1, "Players stats1", LabelText, LabelHeadText, Dtable, ArrCodes)
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
        ManagersMain.getDBHelper.FillChartLabels(Chart2, "Players stats2", LabelText2, LabelHeadText, Dtable, ArrCodes2)
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
    Private Sub CB_ChartTypes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_ChartTypes.KeyPress
        Merror.isUnvailed(e, CB_ChartTypes)
    End Sub
    Private Sub CB_ValuesPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_ValuesPos.KeyPress
        Merror.isUnvailed(e, CB_ValuesPos)
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
        ManagersMain.getDBHelper.FillChartLabels(ChartName, "", Nothing, Nothing, Dtable, ArrCodes)
        DGV.DataSource = Dtable
        For i = 0 To DGV.Columns.Count - 1
            If DGV.Columns(i).Name.Equals("GamesTypes") Or DGV.Columns(i).Name.Equals(ColToShow) Then
                DGV.Columns(i).Visible = True
            Else
                DGV.Columns(i).Visible = False
            End If
        Next
        DGV.CurrentCell = Nothing
        ManagersMain.DesignDataGrid(DGV)
        DGV.DefaultCellStyle.Font = New Font(DGV.DefaultCellStyle.Font.FontFamily.Name, DGV.DefaultCellStyle.Font.Size, FontStyle.Bold)
        For i = 0 To Dtable.Rows.Count - 1
            ChartName.Series(ColToShow).Points.AddXY(Dtable.Rows(i)("GamesTypes").ToString(), Dtable.Rows(i)(ColToShow).ToString())
        Next
        ChartName.ChartAreas(ChartAreaName).BackColor = TLP_Charts.BackColor
        ChartName.Series(ColToShow).Points(0).Color = Color.DeepSkyBlue
        ChartName.Series(ColToShow).LabelForeColor = Color.Black
        ChartName.Series(ColToShow).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        ChartName.Series(ColToShow).BorderWidth = 5
        ChartName.Series(ColToShow).MarkerColor = Color.Black
        ChartName.Series(ColToShow).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        ChartName.Series(ColToShow).MarkerSize = 10
        ChartName.Legends("Legend1").Enabled = True 'Show the category table to explain each color in the chart
    End Sub
    Private Sub ComboLock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_UntillGameTOne.KeyPress, CB_UntillGameTTwo.KeyPress, Cb_WhatToShowOne.KeyPress, Cb_WhatToShowTwo.KeyPress
        Dim cmb As ComboBox = sender
        Merror.isUnvailed(e, cmb)
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
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
        btn.BackColor = Color.White
        btn.ForeColor = TLP_Buttons.BackColor
    End Sub
    Private Sub TLPButtons_MouseLeave(sender As Object, e As EventArgs) Handles Btn_PersonalPlayerOne.MouseLeave, Btn_PersonalPlayerTwo.MouseLeave
        Dim btn As Button = sender
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
        btn.BackColor = TLP_Buttons.BackColor
        btn.ForeColor = Color.White
    End Sub
#End Region
End Class