Public Class GamesVisionAlgo
    Private Algo As AlgoCalc = New AlgoCalc()
#Region "פונקציות של הפורם"
    Private Sub GamesVisionAlgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart1.Series.Clear()
        Chart1.Series.Add(GamesVisionsMyTeamVsOthers.CB_HTname.Text)
        Chart1.Series.Add(GamesVisionsMyTeamVsOthers.CB_ATname.Text)
        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        DataGridViewToChart(1, GamesVisionsMyTeamVsOthers.DataGridView1, Color.DeepSkyBlue)
        DataGridViewToChart(0, GamesVisionsMyTeamVsOthers.DataGridView2, Color.Red)
        Accessibility.SetDesignToAllForms(Me)
        ClassCheckManager.SetSubFormsColors(Me)
        GB_ATC.ForeColor = Lbl_CountA.ForeColor
        GB_HTC.ForeColor = Lbl_CountH.ForeColor
    End Sub
    Private Sub GamesVisionAlgo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        GamesVisionsMyTeamVsOthers.Show()
    End Sub
#End Region
#Region "פונקציות עזר"
    Public Sub DataGridViewToChart(ByVal SeriesNumber As Integer, ByVal DGV As DataGridView, ByVal PointsColor As Color)
        For Count As Integer = 0 To DGV.Rows.Count - 1
            Chart1.Series(SeriesNumber).Points.AddXY(DGV.Item(2, Count).Value, DGV.Item(1, Count).Value)
            Chart1.Series(SeriesNumber).Points(Count).Color = PointsColor
        Next
        Chart1.Series(SeriesNumber).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Chart1.Series(SeriesNumber).BorderWidth = 5
        Chart1.Series(SeriesNumber).IsValueShownAsLabel = True
        Chart1.Series(SeriesNumber).Font = New System.Drawing.Font("Century Gothic", 11, System.Drawing.FontStyle.Bold)
        Chart1.Series(SeriesNumber).Color = PointsColor
        Chart1.Series(SeriesNumber).MarkerColor = Color.Black
        Chart1.Series(SeriesNumber).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
        Chart1.Series(SeriesNumber).MarkerSize = 10
    End Sub
    Public Sub SetGroupBoxesVsOthers()
        GB_ATC.Text = "Away team: " & GamesVisionsMyTeamVsOthers.CB_ATname.Text
        GB_HTC.Text = "Home team: " & GamesVisionsMyTeamVsOthers.CB_HTname.Text
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
#End Region
#Region "AlgoCalc class"
    Private Class AlgoCalc
        Private BothResultsWins As Double = 0, AwayTeamWin As Double = 0, HomeTeamWin As Double = 0
        Private AwayWinProbabilty As Double = 0, HomeWinProbabilty As Double = 0
        'To make win vision between two teams, in this class I will implement the Naive Bayes statistic algorithm
        Public Function HowWillWin() As String
            If GamesVisionAlgo.Lbl_YesAbove50.Text.Equals("0") Then 'Avoid multipy by 0
                AwayTeamWin = Double.Parse(GamesVisionAlgo.Lbl_Anum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove0.Text) *
                1.0 * Double.Parse(GamesVisionAlgo.Lbl_DYesAbove0.Text)
            Else
                AwayTeamWin = Double.Parse(GamesVisionAlgo.Lbl_Anum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove0.Text) *
                Double.Parse(GamesVisionAlgo.Lbl_YesAbove50.Text) * Double.Parse(GamesVisionAlgo.Lbl_DYesAbove0.Text)
            End If
            If Not GamesVisionAlgo.Lbl_PrevAMatch.Text.Equals("0") Then 'Add prev match results only if this teams saw each other previous
                AwayTeamWin = AwayTeamWin * Double.Parse(GamesVisionAlgo.Lbl_PrevAMatch.Text / GamesVisionAlgo.Lbl_TotalSeen.Text)
            End If
            If Not GamesVisionAlgo.Lbl_AWinAway.Text.Equals("0") Then 'מניעת הכפלה ב-0 והתחשבות באחוז ניצחון כקבוצת חוץ
                AwayTeamWin = AwayTeamWin * Double.Parse(GamesVisionAlgo.Lbl_AWinAway.Text)
            End If
            If GamesVisionAlgo.Lbl_DHYesAbove50.Text.Equals("0") Then 'Avoid multipy by 0
                HomeTeamWin = Double.Parse(GamesVisionAlgo.Lbl_Hnum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove0.Text) *
                   1.0 * Double.Parse(GamesVisionAlgo.Lbl_DHYesAbove0.Text)
            Else
                HomeTeamWin = Double.Parse(GamesVisionAlgo.Lbl_Hnum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove0.Text) *
                 Double.Parse(GamesVisionAlgo.Lbl_DHYesAbove50.Text) * Double.Parse(GamesVisionAlgo.Lbl_DHYesAbove0.Text)
            End If
            If Not GamesVisionAlgo.Lbl_PrevHMatch.Text.Equals("0") Then 'Add prev match results only if this teams saw each other previous
                HomeTeamWin = HomeTeamWin * Double.Parse(GamesVisionAlgo.Lbl_PrevHMatch.Text / GamesVisionAlgo.Lbl_TotalSeen.Text)
            End If
            If Not GamesVisionAlgo.Lbl_BWinHome.Text.Equals("0") Then 'מניעת הכפלה ב-0 והתחשבות באחוז ניצחון כקבוצת בית
                HomeTeamWin = HomeTeamWin * Double.Parse(GamesVisionAlgo.Lbl_BWinHome.Text)
            End If
            BothResultsWins = AwayTeamWin + HomeTeamWin
            AwayWinProbabilty = AwayTeamWin / BothResultsWins
            HomeWinProbabilty = HomeTeamWin / BothResultsWins
            If AwayWinProbabilty > HomeWinProbabilty Then
                GamesVisionAlgo.Lbl_Res2.Text = FormatPercent(HomeWinProbabilty).ToString()
                Return GamesVisionAlgo.GB_ATC.Text.Substring(GamesVisionAlgo.GB_ATC.Text.IndexOf(":") + 2) & " With " & FormatPercent(AwayWinProbabilty).ToString() & " probabilty will win"
            ElseIf HomeWinProbabilty > AwayWinProbabilty Then
                GamesVisionAlgo.Lbl_Res2.Text = FormatPercent(AwayWinProbabilty).ToString()
                Return GamesVisionAlgo.GB_HTC.Text.Substring(GamesVisionAlgo.GB_HTC.Text.IndexOf(":") + 2) & " With " & FormatPercent(HomeWinProbabilty).ToString() & " probabilty will win"
            End If
            Return "Both team have same proabilty to win"
        End Function
    End Class
#End Region
End Class