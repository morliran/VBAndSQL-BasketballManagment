Public Class GuestSectionQuerysControl
    Private myHelper As MyDBControler = New MyDBControler(), ArrCodes() As String = New String() {}
    Public Function QuerySections(ByVal SectionName As String, ByVal QueryNumber As Integer) As DataView
        Dim QueryName As String = "", QueryCode As Integer = 0, TwoQueryCode As Integer = 0, ThirdQueryCode As Integer = 0
        If QueryNumber <> 0 Then
            Select Case SectionName
                Case "Basic"
                    Select Case QueryNumber
                        Case 1, 2, 3, 5, 7
                            If (QueryNumber <> 7 AndAlso QueryNumber <> 5) Then
                                QueryName = "Height"
                                If QueryNumber = 1 Then
                                    ArrCodes = {">", "2.07"}
                                ElseIf QueryNumber = 2 Then
                                    ArrCodes = {"<=", "1.81"}
                                ElseIf QueryNumber = 3 Then
                                    ArrCodes = {"=", "2.01"}
                                End If
                            ElseIf QueryNumber = 5 Then
                                QueryName = "DOB"
                                ArrCodes = {"=", "29/12/1992"}
                            ElseIf QueryNumber = 7 Then
                                QueryName = "Jerseynum"
                                ArrCodes = {"=", "4"}
                            End If
                        Case 4, 10, 13
                            ArrCodes = {"", "", "", "", "", ""}
                            If QueryNumber = 4 Then
                                QueryCode = 1
                                QueryName = "Not type of 6"
                            ElseIf QueryNumber = 10 Then
                                QueryCode = 4
                                QueryName = "Roution code"
                            ElseIf QueryNumber = 13 Then
                                QueryCode = 6
                                QueryName = "Game below"
                            End If
                        Case 6, 8
                            QueryCode = 5
                            If QueryNumber = 6 Then
                                ArrCodes = {"AwayTeamCode", "", "165", "", "", "185"}
                                QueryName = "AwayTeam"
                            ElseIf QueryNumber = 8 Then
                                ArrCodes = {"HomeTeamCode", "", "100", "", "", "120"}
                                QueryName = "HomeTeam"
                            End If
                        Case 9, 12
                            QueryCode = 3
                            If QueryNumber = 9 Then
                                ArrCodes = {"Jerseynum", "=", "1", "Or", "=", "2"}
                                QueryName = "Players"
                            ElseIf QueryNumber = 12 Then
                                ArrCodes = {"Drillcode", ">", "300", "And", "<", "500"}
                                QueryName = "Drill"
                            End If
                        Case 11, 14, 15
                            QueryCode = 2
                            If QueryNumber = 11 Then
                                ArrCodes = {"Gradeofthedrill", ">", "84", "", "", ""}
                                QueryName = "DrillForPlayers"
                            ElseIf QueryNumber = 14 Then
                                ArrCodes = {"HostersCode", "=", "110", "", "", ""}
                                QueryName = "TeamsInTheGame"
                            ElseIf QueryNumber = 15 Then
                                ArrCodes = {"Location", "=", "Hakirya Ashdod", "", "", ""}
                                QueryName = "Game"
                            End If
                    End Select
                Case "Teams"
                    Select Case QueryNumber
                        Case 1
                            TwoQueryCode = 10
                            ArrCodes = {"", "", "", "", "Maccabi-Fox-Tel-Aviv", ""}
                            QueryName = "TeamPlayersRoution"
                        Case 2, 3, 4, 5, 7, 8, 10, 11, 13
                            QueryName = "Players"
                            If QueryNumber = 2 Then
                                ArrCodes = {"Playerid", "HisHomeTeamCode", "HapoelBeerShevaPlayerInTheTeam", "", "100", ""}
                                TwoQueryCode = 7
                            ElseIf QueryNumber = 3 Then
                                ArrCodes = {"Position", "HisHomeTeamCode", "PGInHolonTeam", "", "PG", "140"}
                                TwoQueryCode = 3
                            ElseIf (QueryNumber = 4 Or QueryNumber = 11) Then
                                TwoQueryCode = 2
                                If QueryNumber = 4 Then
                                    ArrCodes = {"Height", "HisAwayTeamCode", "HeightAverageInAshdodTeam", "", "125", ""}
                                ElseIf QueryNumber = 11 Then
                                    ArrCodes = {"Height", "Position", "AverageHeightOfAllShootingGuardsInTheLeague", "", "SG", ""}
                                End If
                            ElseIf (QueryNumber = 5 Or QueryNumber = 10) Then
                                TwoQueryCode = 1
                                If QueryNumber = 5 Then
                                    ArrCodes = {"Height", "HisAwayTeamCode", "HeightSumInJerusalemTeam", "", "155", ""}
                                ElseIf QueryNumber = 10 Then
                                    ArrCodes = {"Height", "Position", "SumHeightOfAllCentersInTheLeague", "", "C", ""}
                                End If
                            ElseIf QueryNumber = 7 Then
                                ArrCodes = {"Position", "", "SmallForwardsInTheLeague", "", "SF", ""}
                                TwoQueryCode = 4
                            ElseIf QueryNumber = 8 Then
                                ArrCodes = {"JerseyNum", "", "MaxJerseyNumInTheLeague", "", "", ""}
                                TwoQueryCode = 5
                            ElseIf QueryNumber = 13 Then
                                ArrCodes = {"Height", "", "MaxHeightInTheLeage", "MinHeightInTheLeague", "", ""}
                                TwoQueryCode = 8
                            End If
                        Case 6
                            ArrCodes = {"", "", "", "", "210", ""}
                            QueryName = "Top 12"
                            TwoQueryCode = 12
                        Case 9
                            ArrCodes = {"RoutionCode", "", "MinRoutionCodeInTheLeague", "", "", ""}
                            QueryName = "SubPlayers"
                            TwoQueryCode = 6
                        Case 12
                            ArrCodes = {"Timeofthegame", "", "TotalGames", "", "20:00", ""}
                            QueryName = "Game"
                            TwoQueryCode = 4
                        Case 14
                            ArrCodes = {"", "", "", "", "55", ""}
                            QueryName = "DrillBelow"
                            TwoQueryCode = 11
                        Case 15
                            ArrCodes = {"Gradeofthedrill", "", "MaxGradeDrill", "MinGradeDrill", "", ""}
                            QueryName = "DrillForPlayers"
                            TwoQueryCode = 8
                    End Select
                Case "Others"
                    Select Case QueryNumber
                        Case 1, 2, 3, 4, 5, 6, 14
                            QueryName = "Players"
                            If (QueryNumber = 1 Or QueryNumber = 4 Or QueryNumber = 14) Then
                                ThirdQueryCode = 5
                                If QueryNumber = 1 Then
                                    ArrCodes = {"PlayerCode", "HisHomeTeamCode", "PlayersInEachTeam"}
                                ElseIf QueryNumber = 4 Then
                                    ArrCodes = {"Playerid", "Position", "PlayersInEachPosition"}
                                ElseIf QueryNumber = 14 Then
                                    ArrCodes = {"Playercode", "Jerseynum", "TotalPlayersWithSameJerseyNum"}
                                End If
                            ElseIf QueryNumber = 2 Then
                                ArrCodes = {"Height", "HisHomeTeamCode", "SumOfHeightInEachTeam"}
                                ThirdQueryCode = 6
                            ElseIf QueryNumber = 3 Then
                                ArrCodes = {"Height", "HisHomeTeamCode", "AverageOfHeightInEachTeam"}
                                ThirdQueryCode = 7
                            ElseIf QueryNumber = 5 Then
                                ArrCodes = {"Height", "HisHomeTeamCode", "MaxOfHeightInTeam"}
                                ThirdQueryCode = 1
                            ElseIf QueryNumber = 6 Then
                                ArrCodes = {"Height", "HisHomeTeamCode", "MinOfHeightInEachTeam"}
                                ThirdQueryCode = 2
                            End If
                        Case 7, 8, 9, 11
                            QueryName = "DrillForPlayers"
                            If QueryNumber = 7 Then
                                ArrCodes = {"Gradeofthedrill", "TheDrillCode", "SumOfGradeInEachDrill"}
                                ThirdQueryCode = 3
                            ElseIf QueryNumber = 8 Then
                                ArrCodes = {"Gradeofthedrill", "TheDrillCode", "MaxGradeInEachDrill"}
                                ThirdQueryCode = 1
                            ElseIf QueryNumber = 9 Then
                                ArrCodes = {"Gradeofthedrill", "TheDrillCode", "MinGradeInEachDrill"}
                                ThirdQueryCode = 2
                            ElseIf QueryNumber = 11 Then
                                ArrCodes = {"Gradeofthedrill", "TheDrillCode", "AverageGradeInEachDrill"}
                                ThirdQueryCode = 7
                            End If
                        Case 10, 13
                            QueryName = "Game"
                            ThirdQueryCode = 5
                            If QueryNumber = 10 Then
                                ArrCodes = {"Gamecode", "Timeofthegame", "TotalGamesInEachHour"}
                            ElseIf QueryNumber = 13 Then
                                ArrCodes = {"Gamecode", "Location", "TotalGamesInEachLocation"}
                            End If
                        Case 12
                            ArrCodes = {"2.06", "", ""}
                            QueryName = "Max height above"
                            ThirdQueryCode = 8
                        Case 15
                            ArrCodes = {"TheGamecode", "HostersCode", "TotalGamesHasHomeTeam"}
                            QueryName = "TeamsInTheGame"
                            ThirdQueryCode = 5
                    End Select
                Case "League"
                    Select Case QueryNumber
                        Case 1, 2
                            ArrCodes = {"", "", "", "", "", ""}
                            QueryCode = 7
                            If QueryNumber = 1 Then
                                QueryName = "Players"
                            ElseIf QueryNumber = 2 Then
                                QueryName = "HomeTeam"
                            End If
                        Case 3
                            ArrCodes = {"", ""}
                            QueryName = "LeagueGames"
                    End Select
            End Select
            Return myHelper.GetDataView(QueryName, ArrCodes, QueryCode, TwoQueryCode, ThirdQueryCode)
        End If
        Return Nothing
    End Function
End Class
