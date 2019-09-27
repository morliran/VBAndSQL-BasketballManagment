Public Class GamesVisionAlgo
    Private Algo As AlgoCalc = New AlgoCalc()
#Region "פונקציות של הפורם"
    Private Sub GamesVisionAlgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series.Clear()
        Chart1.Series.Add(GamesVisionsMyTeamVsOthers.CB_HTname.Text)
        Chart1.Series.Add(GamesVisionsMyTeamVsOthers.CB_ATname.Text)
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        For Count1 As Integer = 0 To GamesVisionsMyTeamVsOthers.DataGridView1.Rows.Count - 1
            Chart1.Series(1).Points.AddXY(GamesVisionsMyTeamVsOthers.DataGridView1.Item(2, Count1).Value, GamesVisionsMyTeamVsOthers.DataGridView1.Item(1, Count1).Value)
            Chart1.Series(1).Points(Count1).Color = Color.DeepSkyBlue
        Next
        SetPropertyAwayChart()
        For Count As Integer = 0 To GamesVisionsMyTeamVsOthers.DataGridView2.Rows.Count - 1
            Chart1.Series(0).Points.AddXY(GamesVisionsMyTeamVsOthers.DataGridView2.Item(2, Count).Value, GamesVisionsMyTeamVsOthers.DataGridView2.Item(1, Count).Value)
            Chart1.Series(0).Points(Count).Color = Color.Red
        Next
        SetPropertyHomeChart()
        SetGroupBoxesVsOthers()
    End Sub
    Private Sub GamesVisionAlgo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        GamesVisionsMyTeamVsOthers.Show()
    End Sub
#End Region
#Region "פונקציות עזר"
    Private Sub SetGroupBoxesVsOthers()
        GB_ATC.Text = GamesVisionsMyTeamVsOthers.CB_ATname.Text
        GB_HTC.Text = GamesVisionsMyTeamVsOthers.CB_HTname.Text
        'קבוצת חוץ'
        Lbl_Anum.Text = GamesVisionsMyTeamVsOthers.DataGridView1.RowCount 'כמה שחקנים בקבוצה
        Lbl_Anum2.Text = GamesVisionsMyTeamVsOthers.Lbl_P.Text 'כמה מתוכם שיחקו
        Lbl_Anum3.Text = GamesVisionsMyTeamVsOthers.Lbl_NP.Text 'כמה מתוכם לא שיחקו
        Lbl_YesAbove100.Text = GamesVisionsMyTeamVsOthers.Lbl_A100.Text 'לכמה מתוכם יש מעל ל-100 נק' במצטבר
        Lbl_YesAbove0.Text = GamesVisionsMyTeamVsOthers.Lbl_A0.Text 'לכמה אין מעל ל-100 נק' במצטבר
        Lbl_YesAbove50.Text = GamesVisionsMyTeamVsOthers.Lbl_DA50.Text
        Lbl_DYesAbove0.Text = GamesVisionsMyTeamVsOthers.Lbl_DA0.Text

        Lbl_NotAbove100.Text = Lbl_YesAbove0.Text
        Lbl_NotAbove0.Text = Lbl_YesAbove100.Text
        Lbl_NotAbove50.Text = Lbl_DYesAbove0.Text
        Lbl_DNotAbove0.Text = Lbl_YesAbove50.Text
        'קבוצת בית'
        Lbl_Hnum.Text = GamesVisionsMyTeamVsOthers.DataGridView2.RowCount 'כמה שחקנים בקבוצה
        Lbl_Hnum2.Text = GamesVisionsMyTeamVsOthers.Lbl_P2.Text 'כמה מתוכם שיחקו
        Lbl_Hnum3.Text = GamesVisionsMyTeamVsOthers.Lbl_NP2.Text 'כמה מתוכם לא שיחקו
        Lbl_HYesAbove100.Text = GamesVisionsMyTeamVsOthers.Lbl_H100.Text 'לכמה מתוכם יש מעל ל-100 נק' במצטבר
        Lbl_HYesAbove0.Text = GamesVisionsMyTeamVsOthers.Lbl_H0.Text 'לכמה אין מעל ל-100 נק' במצטבר
        Lbl_DHYesAbove50.Text = GamesVisionsMyTeamVsOthers.Lbl_DH50.Text
        Lbl_DHYesAbove0.Text = GamesVisionsMyTeamVsOthers.Lbl_DH0.Text

        Lbl_HNotAbove100.Text = Lbl_HYesAbove0.Text
        Lbl_HNotAbove0.Text = Lbl_HYesAbove100.Text
        Lbl_DHNotAbove50.Text = Lbl_DHYesAbove0.Text
        Lbl_DHNotAbove0.Text = Lbl_DHYesAbove50.Text

        Lbl_Res.Text = Algo.HowWillWin()
    End Sub
    Private Sub SetPropertyHomeChart()
        Chart1.Series(0).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(0).BorderWidth = 5
        Chart1.Series(0).IsValueShownAsLabel = True
        Chart1.Series(0).Font = New System.Drawing.Font("Century Gothic", 11, System.Drawing.FontStyle.Bold)
        Chart1.Series(0).Color = Color.Red
        Chart1.Series(0).MarkerColor = Color.Black
        Chart1.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        Chart1.Series(0).MarkerSize = 10
    End Sub
    Private Sub SetPropertyAwayChart()
        Chart1.Series(1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(1).BorderWidth = 5
        Chart1.Series(1).IsValueShownAsLabel = True
        Chart1.Series(1).Font = New System.Drawing.Font("Century Gothic", 11, System.Drawing.FontStyle.Bold)
        Chart1.Series(1).Color = Color.DeepSkyBlue
        Chart1.Series(1).MarkerColor = Color.Black
        Chart1.Series(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        Chart1.Series(1).MarkerSize = 10
    End Sub
#End Region
End Class