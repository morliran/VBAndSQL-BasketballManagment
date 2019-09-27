Public Class GuestQueries
    Private Sec As GuestSectionQuerysControl = New GuestSectionQuerysControl()
#Region "פונקציות של הפורם"
    Private Sub GuestQueries_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        GuestQueriesSections.Show()
    End Sub
    Private Sub GuestQueries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_AutoClick.PerformClick()
        TimerAutoClick.Start()
        TimerAutoClick.Stop()
    End Sub
    Private Sub ChangeSection(ByVal Str As String)
        Me.Hide()
        Me.Dispose() ' מנקה את כל הנתונים שהיו במסך על מנת לאפשר שימוש בשאילתה חדשה '
        GuestQueriesSections.Lbl_Check.Text = Str
        GuestQueriesSections.Show()
    End Sub
#End Region
#Region "אירועים בעת לחיצה על הכפתורים"
    Private Sub Btn_BackToQuerys_Click(sender As Object, e As EventArgs)
        If Lbl_Section.Text = "1" Then
            ChangeSection("1/3")
        ElseIf Lbl_Section.Text = "2" Then
            ChangeSection("2/3")
        ElseIf Lbl_Section.Text = "3" Then
            ChangeSection("3/3")
        End If
    End Sub
    Private Sub Btn_AutoClick_Click(sender As Object, e As EventArgs) Handles Btn_AutoClick.Click
        If Me.Lbl_WhatQuery.Text = "Height > 2.07" Then
            Lbl_TableName.Text = "All Players That Have Height > 2.07"
            DataGridView1.DataSource = Sec.QueryAbove207()
        ElseIf Me.Lbl_WhatQuery.Text = "Height <= 1.81" Then
            Lbl_TableName.Text = "All Players That Have Height <= 1.81"
            DataGridView1.DataSource = Sec.QueryLowerOrEqual181()
        ElseIf Me.Lbl_WhatQuery.Text = "Height == 2.01" Then
            Lbl_TableName.Text = "All Players That Have Height = 2.01"
            DataGridView1.DataSource = Sec.QueryEqual201()
        ElseIf Me.Lbl_WhatQuery.Text = "Height != 1.93, 1.98, 2.08 && Position != C, PF, SF" Then
            Lbl_TableName.Text = "All Players That Don't Have Height Equal To = 1.93, 1.98, 2.08" & vbNewLine & "And There Main Position Is'nt C, PF, SF"
            DataGridView1.DataSource = Sec.QueryNot6Types()
        ElseIf Me.Lbl_WhatQuery.Text = "Born In 29/12/1992" Then
            Lbl_TableName.Text = "All Players That Have Was Born In 29/12/1992"
            DataGridView1.DataSource = Sec.QueryBornIn29121992()
        ElseIf Me.Lbl_WhatQuery.Text = "Away Code >= 165 <= 185" Then
            Lbl_TableName.Text = "All Teams That Have Away Team Code Between 165 To 185"
            DataGridView1.DataSource = Sec.QueryAwayCode165To185()
        ElseIf Me.Lbl_WhatQuery.Text = "Jersey Num == 4" Then
            Lbl_TableName.Text = "Jersey Number Equal To 4"
            DataGridView1.DataSource = Sec.QueryJerseynumber4()
        ElseIf Me.Lbl_WhatQuery.Text = "Home Code >= 100 <= 120" Then
            Lbl_TableName.Text = "All Teams That Have Home Team Code Between 100 To 120"
            DataGridView1.DataSource = Sec.QueryHomeCode100To120()
        ElseIf Me.Lbl_WhatQuery.Text = "Jersey Num 1 Or 2" Then
            Lbl_TableName.Text = "All Players That Have Jersey Number 1 Or 2"
            DataGridView1.DataSource = Sec.QueryJersey1Or2()
        ElseIf Me.Lbl_WhatQuery.Text = "Roution Code > 1 && Roution Code < 5" Then
            Lbl_TableName.Text = "All Players That Have Roution Code > 1 And Roution Code < 5"
            DataGridView1.DataSource = Sec.QueryRoutionBig1Low5()
        ElseIf Me.Lbl_WhatQuery.Text = "Drill Grade > 84" Then
            Lbl_TableName.Text = "All Players That Have Grade Drill Above 84"
            DataGridView1.DataSource = Sec.QueryGradeAbove84()
        ElseIf Me.Lbl_WhatQuery.Text = "Drill >= 300 <= 500" Then
            Lbl_TableName.Text = "Drill Name Between 300 To 500"
            DataGridView1.DataSource = Sec.QueryDrill300To500()
        ElseIf Me.Lbl_WhatQuery.Text = "Game Code <= 10" Then
            Lbl_TableName.Text = "All The Games That Have Game Code Lower Or Equal To 10"
            DataGridView1.DataSource = Sec.QueryGameLOrE10()
        ElseIf Me.Lbl_WhatQuery.Text = "Games For 110 As Home Team" Then
            Lbl_TableName.Text = "All Home Games For Team That Have Home Code 110"
            DataGridView1.DataSource = Sec.QueryHomeGamesFor110()
        ElseIf Me.Lbl_WhatQuery.Text = "Ashdod Arena Games" Then
            Lbl_TableName.Text = "All Games In Hakirya Ashdod"
            DataGridView1.DataSource = Sec.QueryHakiryaGames()
        End If
        ' Querys Section 2 '
        If Me.Lbl_WhatQuery.Text = "Maccabi-FOX-Tel-Aviv Players" Then
            Lbl_TableName.Text = "All Maccabi-Fox-Tel-Aviv Players"
            DataGridView1.DataSource = Sec.QueryMacPlayers()
        ElseIf Me.Lbl_WhatQuery.Text = "Players In Hapoel Beer Sheva" Then
            Lbl_TableName.Text = "Total Players Of Hapoel Beer Sheva-Bnei Shimon"
            DataGridView1.DataSource = Sec.QueryTotalPlayersOfHbs()
        ElseIf Me.Lbl_WhatQuery.Text = "Total PG In Hapoel Holon" Then
            Lbl_TableName.Text = "Total Point Guards In Hapoel-Holon"
            DataGridView1.DataSource = Sec.QueryTotalPgInHolon()
        ElseIf Me.Lbl_WhatQuery.Text = "Height Avg In Ashdod" Then
            Lbl_TableName.Text = "Height Average In Ashdod Team"
            DataGridView1.DataSource = Sec.QueryHighAvgAshdod()
        ElseIf Me.Lbl_WhatQuery.Text = "Height Sum In Jersualem" Then
            Lbl_TableName.Text = "Height Sum In Jersualem"
            DataGridView1.DataSource = Sec.QueryHighSumJerusalem()
        ElseIf Me.Lbl_WhatQuery.Text = "12 Players From Gilboa" Then
            Lbl_TableName.Text = "Gilboa Glil First 12 Players"
            DataGridView1.DataSource = Sec.QueryTop12GilboaPlayers()
        ElseIf Me.Lbl_WhatQuery.Text = "Total SF In The League" Then
            Lbl_TableName.Text = "Total Small Forwards In The League"
            DataGridView1.DataSource = Sec.QueryTotalSfPosition()
        ElseIf Me.Lbl_WhatQuery.Text = "Max Jersey Num" Then
            Lbl_TableName.Text = "Max Jersey Number In The League"
            DataGridView1.DataSource = Sec.QueryMaxJerNum()
        ElseIf Me.Lbl_WhatQuery.Text = "Min Roution Code" Then
            Lbl_TableName.Text = "Min Roution Code In The League"
            DataGridView1.DataSource = Sec.QueryMinRouC()
        ElseIf Me.Lbl_WhatQuery.Text = "Height Sum For C" Then
            Lbl_TableName.Text = "Sum Height For All Center In The League"
            DataGridView1.DataSource = Sec.QueryHeightSumForC()
        ElseIf Me.Lbl_WhatQuery.Text = "Height Average For All SG" Then
            Lbl_TableName.Text = "Avg Height For All Shooting-Guards"
            DataGridView1.DataSource = Sec.QueryHeightAvgForSG()
        ElseIf Me.Lbl_WhatQuery.Text = "Games In 20:00" Then
            Lbl_TableName.Text = "Total Games In 20:00 Hour"
            DataGridView1.DataSource = Sec.QueryTotalGameIn2000()
        ElseIf Me.Lbl_WhatQuery.Text = "Max Height && Min Height" Then
            Lbl_TableName.Text = "Max And Min Height In The League"
            DataGridView1.DataSource = Sec.QueryMaxMinH()
        ElseIf Me.Lbl_WhatQuery.Text = "Players With Grade <= 55" Then
            Lbl_TableName.Text = "Players With Grade Equal Or Lower From 55"
            DataGridView1.DataSource = Sec.QueryGBelowE55Players()
        ElseIf Me.Lbl_WhatQuery.Text = "Max Grade && Min Grade" Then
            Lbl_TableName.Text = "Max And Min Grade In The League"
            DataGridView1.DataSource = Sec.QueryMaxMinGrade()
        End If
        'Querys Section 3'
        If Me.Lbl_WhatQuery.Text = "Cnt Players In Each Team" Then
            Lbl_TableName.Text = "Total Players In Each Team"
            DataGridView1.DataSource = Sec.QueryPInEachTeam()
        ElseIf Me.Lbl_WhatQuery.Text = "Sum Height In Each Team" Then
            Lbl_TableName.Text = "Height Sum In Each Team"
            DataGridView1.DataSource = Sec.QueryHeightSumInTeams()
        ElseIf Me.Lbl_WhatQuery.Text = "Avg Height In Each Team" Then
            Lbl_TableName.Text = "Average Height In Each Team"
            DataGridView1.DataSource = Sec.QueryAvgHeightInTeams()
        ElseIf Me.Lbl_WhatQuery.Text = "Cnt Players In Each Position" Then
            Lbl_TableName.Text = "Total Players In Each Position"
            DataGridView1.DataSource = Sec.QueryAPInEachPos()
        ElseIf Me.Lbl_WhatQuery.Text = "Players With Same JerseyNum" Then
            Lbl_TableName.Text = "Total Players Have Same JerseyNum"
            DataGridView1.DataSource = Sec.QuerySameJersery()
        ElseIf Me.Lbl_WhatQuery.Text = "Max Height In Each Team" Then
            Lbl_TableName.Text = "Max Height In Each Team"
            DataGridView1.DataSource = Sec.QueryMHeightInEachTeam()
        ElseIf Me.Lbl_WhatQuery.Text = "Min Height In Each Team" Then
            Lbl_TableName.Text = "Min Height In Each Team"
            DataGridView1.DataSource = Sec.QueryMinHeightInEachTeam()
        ElseIf Me.Lbl_WhatQuery.Text = "Sum Grade In Each Drill" Then
            Lbl_TableName.Text = "Sum Grades For Each Drills"
            DataGridView1.DataSource = Sec.QuerySumOfGrades()
        ElseIf Me.Lbl_WhatQuery.Text = "Max Grade In Each Drill" Then
            Lbl_TableName.Text = "Max Grade For Each Drills"
            DataGridView1.DataSource = Sec.QueryMaxOfEachGrade()
        ElseIf Me.Lbl_WhatQuery.Text = "Min Grade In Each Drill" Then
            Lbl_TableName.Text = "Min Grade For Each Drills"
            DataGridView1.DataSource = Sec.QueryMinOfEachGrade()
        ElseIf Me.Lbl_WhatQuery.Text = "Cnt Games In Each Hour" Then
            Lbl_TableName.Text = "Total Games In Each Hour"
            DataGridView1.DataSource = Sec.QueryTGamesInEachHour()
        ElseIf Me.Lbl_WhatQuery.Text = "Avg Grade In Each Drills" Then
            Lbl_TableName.Text = "Average In Each Drill"
            DataGridView1.DataSource = Sec.QueryAvgInEachGrade()
        ElseIf Me.Lbl_WhatQuery.Text = "Max Height > 2.06" Then
            Lbl_TableName.Text = "Players That Have Max Height Above 2.06"
            DataGridView1.DataSource = Sec.QueryMaxHeightPlayersAbove206()
        ElseIf Me.Lbl_WhatQuery.Text = "Cnt Games In Each Location" Then
            Lbl_TableName.Text = "Total Games In Each Location"
            DataGridView1.DataSource = Sec.QueryGamesInEachLoc()
        ElseIf Me.Lbl_WhatQuery.Text = "Cnt Games As Home Team For Each Team" Then
            Lbl_TableName.Text = "Total Games As Home Team For Each Team"
            DataGridView1.DataSource = Sec.QueryTotalGamesAsHomeTeam()
        End If
        'Query section 4'
        Dim ArrCodes() As String = New String() {"", "", "", "", "", ""}
        If Lbl_WhatQuery.Text = "All Players In The League" Then
            DataGridView1.DataSource = GuestMain.getHelper().getDataView("Players", ArrCodes, 7)
            Lbl_TableName.Text = Lbl_WhatQuery.Text
        ElseIf Lbl_WhatQuery.Text = "All Teams In The League" Then
            DataGridView1.DataSource = GuestMain.getHelper().getDataView("HomeTeam", ArrCodes, 7)
            Lbl_TableName.Text = Lbl_WhatQuery.Text
        ElseIf Lbl_WhatQuery.Text = "All Games In The League" Then
            ArrCodes = {"", ""}
            DataGridView1.DataSource = GuestMain.getHelper().getDataView("LeagueGames", ArrCodes)
            Lbl_TableName.Text = Lbl_WhatQuery.Text
        End If
    End Sub
#End Region
End Class