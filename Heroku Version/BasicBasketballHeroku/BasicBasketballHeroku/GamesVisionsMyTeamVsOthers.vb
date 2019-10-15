﻿Imports System.Windows.Forms.DataVisualization.Charting
Public Class GamesVisionsMyTeamVsOthers
    Private Mat As DataView = New DataView(), Mat2 As DataView = New DataView()
    Private notPlayed As Integer = 0, yesPlayed As Integer = 0, OffUntill100 As Integer = 0, OffAbove100 As Integer = 0, intHeight As Integer
    Private DefUntill50 As Integer = 0, DefAbove50 As Integer = 0, SumAteam As Integer = 0, SumHTeam As Integer = 0, cntApperance As Integer = 0
    Private ArrCodes() As String = New String() {}, ArrH() As String = New String() {}, ArrA() As String = New String() {}, notManagerHc As String = "", notManagerAc As String = ""
#Region "פונקציות של הפורם"
    Private Sub GamesVisionsMyTeamVsOthers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManagersMain.GetDBHelper.FillBoxes(CB_ATname, "Get all teams names")
        ManagersMain.GetDBHelper.FillBoxes(CB_HTname, "Get all teams names")
        CB_ATname.Items.Remove("Free-Agents") 'Make sure not including players that dont have team
        CB_HTname.Items.Remove("Free-Agents")
        Accessibility.SetDesignToAllForms(Me)
        ClassCheckManager.SetSubFormsColors(Me)
    End Sub
    Private Sub Panel_Left_Resize(sender As Object, e As EventArgs) Handles Panel_Left.Resize
        FLP_Buttons.Location = New Point((Panel_Left.Width - FLP_Buttons.Width) / 2, (Panel_Left.Height - FLP_Buttons.Height) / 2)
    End Sub
    Private Sub GamesVisionsMyTeamVsOthers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        If Not Lbl_CheckBack.Text.Equals("Guest main") Then
            ManagersMain.Show()
        Else
            GuestMain.Show()
        End If
    End Sub
    Private Sub SetChart(ByVal ChartName As Chart, ByVal SeriesNum As Integer, ByVal DGV As DataGridView)
        ChartName.Series(SeriesNum).Points.Clear()
        For Count As Integer = 0 To DGV.Rows.Count - 1
            ChartName.Series(SeriesNum).Points.AddXY(DGV.Item(1, Count).Value, DGV.Item(2, Count).Value)
        Next
        ManagersMain.DesignDataGrid(DGV)
    End Sub
    Private Sub CheckHomeAwaySuccess(ByVal Combo As ComboBox, ByVal HostCode As String, ByVal VistorCode As String)
        Dim SuccesWinAway As Integer = 0, SuccessWinHome As Integer = 0, HomeGames As Integer = 0, AwayGames As Integer = 0
        Dim dtA As New DataTable, TeamHCode As String = "", TeamACode As String = "", code As Integer = 0, points As Integer = 0, secPoints As Integer = 0
        'בדיקת כמות ניצחונות חוץ אל מול ניצחונות בבית
        ArrCodes = {"", ""}
        Mat = ManagersMain.GetDBHelper.GetDataView("MatchResults", ArrCodes)
        If Mat.Count <> 0 Then
            dtA = Mat.ToTable()
            For i As Integer = 0 To dtA.Rows.Count - 1
                If dtA.Rows(i).Item("TeamsNames").Equals(Combo.Text) Then
                    code = Integer.Parse(dtA.Rows(i).Item("TheCode").ToString())
                    points = Integer.Parse(dtA.Rows(i).Item("TotalPoints").ToString())
                    TeamHCode = dtA.Rows(i).Item("HostersCode").ToString()
                    For j As Integer = 0 To dtA.Rows.Count - 1
                        If j <> i Then
                            If Integer.Parse(dtA.Rows(j).Item("TheCode").ToString()) = code Then
                                secPoints = Integer.Parse(dtA.Rows(j).Item("TotalPoints").ToString())
                                TeamACode = dtA.Rows(j).Item("VisitorsCode").ToString()
                                If TeamHCode.Equals(HostCode) Then
                                    HomeGames = HomeGames + 1
                                    If points > secPoints Then
                                        SuccessWinHome = SuccessWinHome + 1
                                    End If
                                ElseIf TeamACode.Equals(VistorCode) Then
                                    AwayGames = AwayGames + 1
                                    If secPoints > points Then
                                        SuccesWinAway = SuccesWinAway + 1
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If
            Next
            Select Case Combo.Name
                Case "CB_ATname"
                    If HomeGames <> 0 Then
                        GamesVisionAlgo.Lbl_AWinHome.Text = Double.Parse(SuccessWinHome / HomeGames).ToString()
                    Else
                        GamesVisionAlgo.Lbl_AWinHome.Text = "0"
                    End If
                    If AwayGames <> 0 Then
                        GamesVisionAlgo.Lbl_AWinAway.Text = Double.Parse(SuccesWinAway / AwayGames).ToString()
                    Else
                        GamesVisionAlgo.Lbl_AWinAway.Text = "0"
                    End If
                Case "CB_HTname"
                    If HomeGames <> 0 Then
                        GamesVisionAlgo.Lbl_BWinHome.Text = Double.Parse(SuccessWinHome / HomeGames).ToString()
                    Else
                        GamesVisionAlgo.Lbl_BWinHome.Text = "0"
                    End If
                    If AwayGames <> 0 Then
                        GamesVisionAlgo.Lbl_BWinAway.Text = Double.Parse(SuccesWinAway / AwayGames).ToString()
                    Else
                        GamesVisionAlgo.Lbl_BWinAway.Text = "0"
                    End If
            End Select
        End If
    End Sub
    Private Sub CheckPlayersParameters(ByVal DGV As DataGridView, ByVal Combo As ComboBox, ByVal ChartName As Chart)
        intHeight = 0
        yesPlayed = 0
        notPlayed = 0
        OffUntill100 = 0
        OffAbove100 = 0
        DefUntill50 = 0
        DefAbove50 = 0
        ArrCodes = {Combo.Text, ""}
        DGV.DataSource = ManagersMain.GetDBHelper.GetDataView("Vis", ArrCodes)
        For Each rowheight As DataGridViewRow In DGV.Rows ' משנה את גודל הdatagrid בהתאם לגודל הטבלה שהוחזרה מהdatabase '
            intHeight += rowheight.Height
        Next
        DGV.Height = intHeight + 23
        SetChart(ChartName, 0, DGV)
        For Each row As DataGridViewRow In DGV.Rows
            If row.Cells.Item("Offense").Value = 0 AndAlso row.Cells.Item("Defence").Value = 0 Then
                notPlayed = notPlayed + 1
            Else
                yesPlayed = yesPlayed + 1
            End If
        Next
        For Each row As DataGridViewRow In DGV.Rows
            If row.Cells.Item("Offense").Value < 100 Then
                OffUntill100 = OffUntill100 + 1
            ElseIf row.Cells.Item("Offense").Value >= 100 Then
                OffAbove100 = OffAbove100 + 1
            End If
        Next
        For Each row As DataGridViewRow In DGV.Rows
            If row.Cells.Item("Defence").Value < 50 Then
                DefUntill50 = DefUntill50 + 1
            Else
                DefAbove50 = DefAbove50 + 1
            End If
        Next
    End Sub
#End Region
#Region "אירועים על תיבת הבחירה של קבוצת החוץ והבית"
    Private Sub CB_ATname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ATname.SelectedIndexChanged
        Dim checker As String = ""
        CheckPlayersParameters(DataGridView1, CB_ATname, Chart1)
        Lbl_AwayExpX.Visible = True
        Lbl_AwayExpY.Visible = True
        Lbl_P.Text = yesPlayed.ToString()
        Lbl_NP.Text = notPlayed.ToString()
        Lbl_A0.Text = OffUntill100.ToString()
        Lbl_A100.Text = OffAbove100.ToString()
        Lbl_DA0.Text = DefUntill50.ToString()
        Lbl_DA50.Text = DefAbove50.ToString()
        If Not Lbl_CheckBack.Text.Equals("Guest main") Then
            checker = ClassCheckManager.GetManagerTeamName()
            If Not CB_ATname.Text.Equals(checker) Then
                CB_HTname.Text = checker
                notManagerAc = ManagersMain.GetDBHelper.GetColumn("AwayTeamCode", CB_ATname.Text)
                notManagerHc = ManagersMain.GetDBHelper.GetColumn("HomeTeamCode", CB_ATname.Text)
                ArrA = {ClassCheckManager.GetHomeC(), notManagerAc}
                ArrH = {notManagerHc, ClassCheckManager.GetAwayC()}
                CheckHomeAwaySuccess(CB_HTname, ClassCheckManager.GetHomeC(), ClassCheckManager.GetAwayC())
                CheckHomeAwaySuccess(CB_ATname, notManagerHc, notManagerAc)
            End If
        End If
    End Sub
    Private Sub CB_HTname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_HTname.SelectedIndexChanged
        Dim checker As String = ""
        CheckPlayersParameters(DataGridView2, CB_HTname, Chart2)
        Lbl_HomeExpX.Visible = True
        Lbl_HomeExpY.Visible = True
        Lbl_P2.Text = yesPlayed.ToString()
        Lbl_NP2.Text = notPlayed.ToString()
        Lbl_H0.Text = OffUntill100.ToString()
        Lbl_H100.Text = OffAbove100.ToString()
        Lbl_DH0.Text = DefUntill50.ToString()
        Lbl_DH50.Text = DefAbove50.ToString()
        If Not Lbl_CheckBack.Text.Equals("Guest main") Then
            checker = ClassCheckManager.GetManagerTeamName()
            If Not CB_HTname.Text.Equals(checker) Then
                CB_ATname.Text = checker
                notManagerAc = ManagersMain.GetDBHelper.GetColumn("AwayTeamCode", CB_HTname.Text)
                notManagerHc = ManagersMain.GetDBHelper.GetColumn("HomeTeamCode", CB_HTname.Text)
                ArrH = {notManagerHc, ClassCheckManager.GetAwayC()}
                ArrA = {ClassCheckManager.GetHomeC(), notManagerAc}
                CheckHomeAwaySuccess(CB_ATname, ClassCheckManager.GetHomeC(), ClassCheckManager.GetAwayC())
                CheckHomeAwaySuccess(CB_HTname, notManagerHc, notManagerAc)
            End If
        End If
    End Sub
#End Region
#Region "אירועים בעת לחיצה על הכפתורים"
    Private Sub Btn_NaiveBayes_Click(sender As Object, e As EventArgs) Handles Btn_NaiveBayes.Click
        Dim CHomeCode As String = "", CHomeACode As String = "", CAwayCode As String = "", CAwayHCode As String = ""
        If CB_ATname.Text.Trim.Length = 0 Or CB_HTname.Text.Trim.Length = 0 Then
            MessageBox.Show("You have empty boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CB_ATname.Text.Equals("Away team") Or CB_HTname.Text.Equals("Home team") Then
            MessageBox.Show("You have empty boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CB_ATname.Text.Equals(CB_HTname.Text) Then
            MessageBox.Show("Can't make vision on the same team", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ProgressBar1.Visible = True
        Lbl_Message.Visible = True
        Lbl_Per.Visible = True
        If Lbl_CheckBack.Text.Equals("Guest main") Then
            CHomeCode = GuestMain.GetHelper.GetColumn("HomeTeamCode", CB_HTname.Text) 'קוד בית של הקבוצה המארחת
            CHomeACode = GuestMain.GetHelper.GetColumn("AwayTeamCode", CB_HTname.Text) 'קוד חוץ של הקבוצה המארחת
            CAwayCode = GuestMain.GetHelper.GetColumn("AwayTeamCode", CB_ATname.Text) 'קוד חוץ של הקבוצה האורחת
            CAwayHCode = GuestMain.GetHelper.GetColumn("HomeTeamCode", CB_ATname.Text) 'קוד בית של הקבוצה האורחת
            ArrA = {CHomeCode, CAwayCode}
            ArrH = {CAwayHCode, CHomeACode}
            CheckHomeAwaySuccess(CB_ATname, CAwayHCode, CAwayCode)
            CheckHomeAwaySuccess(CB_HTname, CHomeCode, CHomeACode)
        End If
        Mat = ManagersMain.GetDBHelper.GetDataView("CheckPrevRes", ArrA)
        Mat2 = ManagersMain.GetDBHelper.GetDataView("CheckPrevRes", ArrH)
        If Mat.Count = 0 AndAlso Mat2.Count = 0 Then 'Both team doesn't saw each other yet in the league
            GamesVisionAlgo.Lbl_PrevAMatch.Text = "0"
            GamesVisionAlgo.Lbl_PrevHMatch.Text = "0"
        ElseIf Mat.Count <> 0 AndAlso Mat2.Count = 0 Then 'The team saw each other only in the away team arena
            GamesVisionAlgo.Lbl_PrevHMatch.Text = "0"
        ElseIf Mat.Count = 0 AndAlso Mat2.Count <> 0 Then 'The team saw each other only in the home team arena
            GamesVisionAlgo.Lbl_PrevAMatch.Text = "0"
        End If
        If Mat.Count <> 0 Or Mat2.Count <> 0 Then 'The team saw each other in each arena
            cntApperance = ManagersMain.GetDBHelper.GetCountResults("CountTotalAppearanceEachOther", ArrA)
            If Mat.Count <> 0 Then
                For Each rowView As DataRowView In Mat
                    Dim row As DataRow = rowView.Row
                    If row.Item("TeamsNames").ToString().Equals(CB_ATname.Text) Then
                        SumAteam = SumAteam + Integer.Parse(row.Item("TeamPoints").ToString())
                    Else
                        SumHTeam = SumHTeam + Integer.Parse(row.Item("TeamPoints").ToString())
                    End If
                Next
            End If
            If Mat2.Count <> 0 Then
                For Each rowView As DataRowView In Mat2
                    Dim row As DataRow = rowView.Row
                    If row.Item("TeamsNames").ToString().Equals(CB_HTname.Text) Then
                        SumHTeam = SumHTeam + Integer.Parse(row.Item("TeamPoints").ToString())
                    Else
                        SumAteam = SumAteam + Integer.Parse(row.Item("TeamPoints").ToString())
                    End If
                Next
            End If
            GamesVisionAlgo.Lbl_PrevAMatch.Text = SumAteam.ToString()
            GamesVisionAlgo.Lbl_PrevHMatch.Text = SumHTeam.ToString()
            GamesVisionAlgo.Lbl_TotalSeen.Text = cntApperance.ToString()
        End If
        Timer1.Start()
    End Sub
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_VisionG")
        HelpForm.Show()
    End Sub
#End Region
#Region "הפעלת טיימר החישוב"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ArrC() As Control = New Control() {CB_ATname, CB_HTname, Btn_NaiveBayes, Btn_Help}
        ManagersMain.GetMyError().SetControlEnabling(ArrC, False)
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 20 Then
            Lbl_Message.Text = "Arrange the data..."
        ElseIf ProgressBar1.Value = 40 Then
            Lbl_Message.Text = "Making chart..."
        ElseIf ProgressBar1.Value = 60 Then
            Lbl_Message.Text = "Making calculation..."
        ElseIf ProgressBar1.Value = 80 Then
            Lbl_Message.Text = "Arrange the results..."
            GamesVisionAlgo.SetGroupBoxesVsOthers()
        ElseIf ProgressBar1.Value = 100 Then
            GamesVisionAlgo.Show()
            GamesVisionAlgo.Lbl_CheckBack.Text = "My team vs others"
            ProgressBar1.Value = 0
            Lbl_Message.Text = "Collect the data"
            ManagersMain.GetMyError().SetControlEnabling(ArrC, True)
            ArrC = {ProgressBar1, Lbl_Message, Lbl_Per}
            ManagersMain.GetMyError().SetControlsVisibilty(ArrC, False)
            Timer1.Stop()
        End If
        Lbl_Per.Text = ProgressBar1.Value & (" %")
    End Sub
#End Region
#Region "איוונטים על הפאנל של הכפתורים"
    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs) Handles Btn_NaiveBayes.MouseEnter, Btn_Help.MouseEnter
        Dim btn As Button = sender
        btn.BackColor = btn.ForeColor
        btn.ForeColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles Btn_NaiveBayes.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = btn.BackColor
        btn.BackColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
    Private Sub Combo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_HTname.KeyPress, CB_ATname.KeyPress
        Dim cmb As ComboBox = sender
        ManagersMain.GetMyError.isUnvailed(e, cmb)
    End Sub
#End Region
End Class