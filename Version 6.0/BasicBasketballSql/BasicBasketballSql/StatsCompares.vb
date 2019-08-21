Public Class StatsCompares
    Private Dtable As DataTable, Ds As DataSet
    Private LabelHeadText() As String = New String() {"Points", "Assists", "Rebounds", "Steels", "Blocks"}
    Private Merror As MerrorControl = New MerrorControl()
#Region "אופציות על הפורם"
    Private Sub StatsCompares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.setPanelControlsEvents(Panel_Controls, Me)
        FillPlayersCodeBox()
        FillGameTypesBox()
        Me.Lbl_TeamName.Text = "Compare stats for " & ManagersMain.getManager.CheckTeam() & " Players"
    End Sub
    Private Sub StatsCompares_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
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
        Dtable = ManagersMain.getDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Playercode, CB_Playercode2, ManagersMain.getManager.GetHomeCode())
    End Sub
    Private Sub FillGameTypesBox()
        Ds = New DataSet("ds")
        Dtable = ManagersMain.getDBHelper.FillDataTableAndBoxs(Dtable, Ds, CB_Gametype, CB_Gametype2, ManagersMain.getManager.CheckTeam())
    End Sub
#End Region
#Region "אירועים בעת שינוי ערך אחת מן תיבות הבחירה של קודי השחקנים"
    Private Sub CB_Playercode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Playercode.SelectedIndexChanged
        Chart1.Series.Clear()
        Chart1.Series.Add("Players stats1")
        Chart1.Titles.Clear()
        ManagersMain.getDBHelper.ComboBoxSelectChange(Me, CB_Playercode, 3)
    End Sub
    Private Sub CB_Playercode2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Playercode2.SelectedIndexChanged
        Chart2.Series.Clear()
        Chart2.Series.Add("Players stats2")
        Chart2.Titles.Clear()
        ManagersMain.getDBHelper.ComboBoxSelectChange(Me, CB_Playercode2, 3)
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
        'מראה את הערכים בגרף שנוצר
        Name.Series(SeriesName).IsValueShownAsLabel = True
        Name.Series(SeriesName).Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold)
        Name.Series(SeriesName).LabelForeColor = Color.White
    End Sub
#End Region
#Region "שינוי מס' מחזור"
    Private Sub CB_Gametype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Gametype.SelectedIndexChanged
        'ניקוי הגרף למקרים שרוצים לעשות מספר השוואות
        Chart1.Series.Clear()
        Chart1.Series.Add("Players stats1")
        Chart1.Titles.Clear()
        Chart1.ChartAreas("ChartArea1").Visible = True
        Dim LabelText() As Label = New Label() {Lbl_Pointsnum, Lbl_Assistsnum, Lbl_Reboundsnum, Lbl_Steelsnum, Lbl_Blocksnum}
        Dim ArrCodes() As String = New String() {CB_Gametype.Text, CB_Playercode.Text}
        ManagersMain.getDBHelper.FillChartLabels(Chart1, "Players stats1", LabelText, LabelHeadText, Dtable, ArrCodes)
        SetTheColorsAndFont(Chart1, "Players stats1")
        If Lbl_Pointsnum.Text = "0" AndAlso Lbl_Assistsnum.Text = "0" AndAlso Lbl_Reboundsnum.Text = "0" AndAlso Lbl_Steelsnum.Text = "0" AndAlso Lbl_Blocksnum.Text = "0" Then
            Chart1.ChartAreas("ChartArea1").BackColor = Color.White
            Lbl_EmptyVal.Visible = True
        Else
            Lbl_EmptyVal.Visible = False
            Chart1.ChartAreas("ChartArea1").BackColor = Color.Black
        End If
        Chart1.ChartAreas("ChartArea1").BorderColor = Color.White
        Chart1.Series("Players stats1").BorderColor = Color.White
        Chart1.Series("Players stats1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Chart1.Series("Players stats1")("PieLabelStyle") = "Outside"
    End Sub
    Private Sub CB_Gametype2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Gametype2.SelectedIndexChanged
        'ניקוי הגרף למקרים שרוצים לעשות מספר השוואות
        Chart2.Series.Clear()
        Chart2.Series.Add("Players stats2")
        Chart2.Titles.Clear()
        Chart2.ChartAreas("ChartArea2").Visible = True
        Dim LabelText2() As Label = New Label() {Lbl_Pointsnum2, Lbl_Assistsnum2, Lbl_Reboundsnum2, Lbl_Steelsnum2, Lbl_Blocksnum2}
        Dim ArrCodes2() As String = New String() {CB_Gametype2.Text, CB_Playercode2.Text}
        ManagersMain.getDBHelper.FillChartLabels(Chart2, "Players stats2", LabelText2, LabelHeadText, Dtable, ArrCodes2)
        SetTheColorsAndFont(Chart2, "Players stats2")
        If Lbl_Pointsnum2.Text = "0" AndAlso Lbl_Assistsnum2.Text = "0" AndAlso Lbl_Reboundsnum2.Text = "0" AndAlso Lbl_Steelsnum2.Text = "0" AndAlso Lbl_Blocksnum2.Text = "0" Then
            Chart2.ChartAreas("ChartArea2").BackColor = Color.White
            Lbl_EmptyVal2.Visible = True
        Else
            Lbl_EmptyVal2.Visible = False
            Chart2.ChartAreas("ChartArea2").BackColor = Color.Black
        End If
        Chart2.ChartAreas("ChartArea2").BorderColor = Color.White
        Chart2.Series("Players stats2").BorderColor = Color.White
        Chart2.Series("Players stats2").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Chart2.Series("Players stats2")("PieLabelStyle") = "Outside"
    End Sub
#End Region
#Region "אזור העיצוב של הגרפים"
    Private Sub CB_ChartTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ChartTypes.SelectedIndexChanged
        Chart1.Series("Players stats1").ChartType = [Enum].Parse(GetType(System.Windows.Forms.DataVisualization.Charting.SeriesChartType), CB_ChartTypes.SelectedItem.ToString())
        Chart2.Series("Players stats2").ChartType = [Enum].Parse(GetType(System.Windows.Forms.DataVisualization.Charting.SeriesChartType), CB_ChartTypes.SelectedItem.ToString())
    End Sub
    Private Sub CB_ValuesPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ValuesPosition.SelectedIndexChanged
        Chart1.Series("Players stats1")("PieLabelStyle") = CB_ValuesPosition.Text
        Chart2.Series("Players stats2")("PieLabelStyle") = CB_ValuesPosition.Text
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
    Private Sub CB_ValuesPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_ValuesPosition.KeyPress
        Merror.isUnvailed(e, CB_ValuesPosition)
    End Sub
#End Region
End Class