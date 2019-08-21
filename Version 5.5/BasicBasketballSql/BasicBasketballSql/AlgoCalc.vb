Public Class AlgoCalc
    Private xyClass As Double = 0, xYes As Double = 0, xNo As Double = 0, yYes As Double = 0, yNo As Double = 0
    Private xProbabilty As Double = 0, yProbabilty As Double = 0
    'בקלאס זה אממש את האלגוריתם הסטטיסטי Naive Bayes על מנת לענות על שאלות מסויימות
    Public Function HowWillWin() As String
        If GamesVisionAlgo.Lbl_YesAbove50.Text = "0" Then 'Avoid multipy by 0
            xYes = Double.Parse(GamesVisionAlgo.Lbl_Anum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove0.Text) *
            1.0 * Double.Parse(GamesVisionAlgo.Lbl_DYesAbove0.Text)
        Else
            xYes = Double.Parse(GamesVisionAlgo.Lbl_Anum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_YesAbove0.Text) *
            Double.Parse(GamesVisionAlgo.Lbl_YesAbove50.Text) * Double.Parse(GamesVisionAlgo.Lbl_DYesAbove0.Text)
        End If
        If GamesVisionAlgo.Lbl_PrevAMatch.Text <> "0" Then 'Add prev match results only if this teams saw each other previous
            xYes = xYes * Double.Parse(GamesVisionAlgo.Lbl_PrevAMatch.Text / GamesVisionAlgo.Lbl_TotalSeen.Text)
        End If
        If GamesVisionAlgo.Lbl_DHYesAbove50.Text = "0" Then 'Avoid multipy by 0
            yYes = Double.Parse(GamesVisionAlgo.Lbl_Hnum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove0.Text) *
               1.0 * Double.Parse(GamesVisionAlgo.Lbl_DHYesAbove0.Text)
        Else
            yYes = Double.Parse(GamesVisionAlgo.Lbl_Hnum2.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove100.Text) * Double.Parse(GamesVisionAlgo.Lbl_HYesAbove0.Text) *
             Double.Parse(GamesVisionAlgo.Lbl_DHYesAbove50.Text) * Double.Parse(GamesVisionAlgo.Lbl_DHYesAbove0.Text)
        End If
        If GamesVisionAlgo.Lbl_PrevHMatch.Text <> "0" Then 'Add prev match results only if this teams saw each other previous
            yYes = yYes * Double.Parse(GamesVisionAlgo.Lbl_PrevHMatch.Text / GamesVisionAlgo.Lbl_TotalSeen.Text)
        End If
        xyClass = xYes + yYes
        xProbabilty = xYes / xyClass
        yProbabilty = yYes / xyClass
        If xProbabilty > yProbabilty Then
            GamesVisionAlgo.Lbl_Res2.Text = yProbabilty.ToString("0.000000")
            Return GamesVisionAlgo.GB_ATC.Text & " With " & xProbabilty.ToString("0.000000") & " probabilty will win"
        ElseIf yProbabilty > xProbabilty Then
            GamesVisionAlgo.Lbl_Res2.Text = xProbabilty.ToString("0.000000")
            Return GamesVisionAlgo.GB_HTC.Text & " With " & yProbabilty.ToString("0.000000") & " probabilty will win"
        End If
        Return "Both team have same proabilty to win"
    End Function
End Class
