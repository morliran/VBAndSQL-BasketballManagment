Public Class GuestSectionQuerysControl
    Private myHelper As MyDBControler = New MyDBControler(), ArrCodes() As String = New String() {}
#Region "דף מס' 1"
    Public Function QueryAbove207() As DataView
        ArrCodes = {">", "2.07"}
        Return myHelper.getDataView("Height", ArrCodes)
    End Function
    Public Function QueryLowerOrEqual181() As DataView
        ArrCodes = {"<=", "1.81"}
        Return myHelper.getDataView("Height", ArrCodes)
    End Function
    Public Function QueryEqual201() As DataView
        ArrCodes = {"=", "2.01"}
        Return myHelper.getDataView("Height", ArrCodes)
    End Function
    Public Function QueryNot6Types() As DataView
        ArrCodes = {"", "", "", "", "", ""}
        Return myHelper.getDataView("Not type of 6", ArrCodes, 1)
    End Function
    Public Function QueryBornIn29121992() As DataView
        ArrCodes = {"=", "29/12/1992"}
        Return myHelper.getDataView("DOB", ArrCodes)
    End Function
    Public Function QueryAwayCode165To185() As DataView
        ArrCodes = {"AwayTeamCode", "", "165", "", "", "185"}
        Return myHelper.getDataView("AwayTeam", ArrCodes, 5)
    End Function
    Public Function QueryJerseynumber4() As DataView
        ArrCodes = {"=", "4"}
        Return myHelper.getDataView("Jerseynum", ArrCodes)
    End Function
    Public Function QueryHomeCode100To120() As DataView
        ArrCodes = {"HomeTeamCode", "", "100", "", "", "120"}
        Return myHelper.getDataView("HomeTeam", ArrCodes, 5)
    End Function
    Public Function QueryJersey1Or2() As DataView
        ArrCodes = {"Jerseynum", "=", "1", "Or", "=", "2"}
        Return myHelper.getDataView("Players", ArrCodes, 3)
    End Function
    Public Function QueryRoutionBig1Low5() As DataView
        ArrCodes = {"", "", "", "", "", ""}
        Return myHelper.getDataView("Roution code", ArrCodes, 4)
    End Function
    Public Function QueryGradeAbove84() As DataView
        ArrCodes = {"Gradeofthedrill", ">", "84", "", "", ""}
        Return myHelper.getDataView("DrillForPlayers", ArrCodes, 2)
    End Function
    Public Function QueryDrill300To500() As DataView
        ArrCodes = {"Drillcode", ">", "300", "And", "<", "500"}
        Return myHelper.getDataView("Drill", ArrCodes, 3)
    End Function
    Public Function QueryGameLOrE10() As DataView
        ArrCodes = {"", "", "", "", "", ""}
        Return myHelper.getDataView("Game below", ArrCodes, 6)
    End Function
    Public Function QueryHomeGamesFor110() As DataView
        ArrCodes = {"HostersCode", "=", "110", "", "", ""}
        Return myHelper.getDataView("TeamsInTheGame", ArrCodes, 2)
    End Function
    Public Function QueryHakiryaGames() As DataView
        ArrCodes = {"Location", "=", "Hakirya Ashdod", "", "", ""}
        Return myHelper.getDataView("Game", ArrCodes, 2)
    End Function
#End Region
#Region "דף מס' 2"
    Public Function QueryMacPlayers() As DataView
        ArrCodes = {"", "", "", "", "Maccabi-Fox-Tel-Aviv", ""}
        Return myHelper.getDataView("TeamPlayersRoution", ArrCodes, 0, 10)
    End Function
    Public Function QueryTotalPlayersOfHbs() As DataView
        ArrCodes = {"Playerid", "HisHomeTeamCode", "HapoelBeerShevaPlayerInTheTeam", "", "100", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 7)
    End Function
    Public Function QueryTotalPgInHolon() As DataView
        ArrCodes = {"Position", "HisHomeTeamCode", "PGInHolonTeam", "", "PG", "140"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 3)
    End Function
    Public Function QueryHighAvgAshdod() As DataView
        ArrCodes = {"Height", "HisAwayTeamCode", "HeightAverageInAshdodTeam", "", "125", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 2)
    End Function
    Public Function QueryHighSumJerusalem() As DataView
        ArrCodes = {"Height", "HisAwayTeamCode", "HeightSumInJerusalemTeam", "", "155", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 1)
    End Function
    Public Function QueryTop12GilboaPlayers() As DataView
        ArrCodes = {"", "", "", "", "210", ""}
        Return myHelper.getDataView("Top 12", ArrCodes, 0, 12)
    End Function
    Public Function QueryTotalSfPosition() As DataView
        ArrCodes = {"Position", "", "SmallForwardsInTheLeague", "", "SF", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 4)
    End Function
    Public Function QueryMaxJerNum() As DataView
        ArrCodes = {"JerseyNum", "", "MaxJerseyNumInTheLeague", "", "", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 5)
    End Function
    Public Function QueryMinRouC() As DataView
        ArrCodes = {"RoutionCode", "", "MinRoutionCodeInTheLeague", "", "", ""}
        Return myHelper.getDataView("SubPlayers", ArrCodes, 0, 6)
    End Function
    Public Function QueryHeightSumForC() As DataView
        ArrCodes = {"Height", "Position", "SumHeightOfAllCentersInTheLeague", "", "C", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 1)
    End Function
    Public Function QueryHeightAvgForSG() As DataView
        ArrCodes = {"Height", "Position", "AverageHeightOfAllShootingGuardsInTheLeague", "", "SG", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 2)
    End Function
    Public Function QueryTotalGameIn2000() As DataView
        ArrCodes = {"Timeofthegame", "", "TotalGames", "", "20:00", ""}
        Return myHelper.getDataView("Game", ArrCodes, 0, 4)
    End Function
    Public Function QueryMaxMinH() As DataView
        ArrCodes = {"Height", "", "MaxHeightInTheLeage", "MinHeightInTheLeague", "", ""}
        Return myHelper.getDataView("Players", ArrCodes, 0, 8)
    End Function
    Public Function QueryGBelowE55Players() As DataView
        ArrCodes = {"", "", "", "", "55", ""}
        Return myHelper.getDataView("DrillBelow", ArrCodes, 0, 11)
    End Function
    Public Function QueryMaxMinGrade() As DataView
        ArrCodes = {"Gradeofthedrill", "", "MaxGradeDrill", "MinGradeDrill", "", ""}
        Return myHelper.getDataView("DrillForPlayers", ArrCodes, 0, 8)
    End Function
#End Region
#Region "דף מס' 3"
    Public Function QueryPInEachTeam() As DataView
        ArrCodes = {"PlayerCode", "HisHomeTeamCode", "PlayersInTeam"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 0, 5)
    End Function
    Public Function QueryHeightSumInTeams() As DataView
        ArrCodes = {"Height", "HisHomeTeamCode", "SumOfHeightInTeam"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 0, 6)
    End Function
    Public Function QueryAvgHeightInTeams() As DataView
        ArrCodes = {"Height", "HisHomeTeamCode", "AverageOfHeightInTeam"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 0, 7)
    End Function
    Public Function QueryAPInEachPos() As DataView
        ArrCodes = {"Playerid", "Position", "PlayersInPosition"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 0, 5)
    End Function
    Public Function QueryMHeightInEachTeam() As DataView
        ArrCodes = {"Height", "HisAwayTeamCode", "ManOfHeightInTeam"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 0, 1)
    End Function
    Public Function QueryMinHeightInEachTeam() As DataView
        ArrCodes = {"Height", "HisAwayTeamCode", "MinOfHeightInTeam"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 0, 2)
    End Function
    Public Function QuerySumOfGrades() As DataView
        ArrCodes = {"Gradeofthedrill", "TheDrillCode", "SumOfGradeDrill"}
        Return myHelper.getDataView("DrillForPlayers", ArrCodes, 0, 0, 3)
    End Function
    Public Function QueryMaxOfEachGrade() As DataView
        ArrCodes = {"Gradeofthedrill", "TheDrillCode", "ManGradeOfDrill"}
        Return myHelper.getDataView("DrillForPlayers", ArrCodes, 0, 0, 1)
    End Function
    Public Function QueryMinOfEachGrade() As DataView
        ArrCodes = {"Gradeofthedrill", "TheDrillCode", "MinGradeOfDrill"}
        Return myHelper.getDataView("DrillForPlayers", ArrCodes, 0, 0, 2)
    End Function
    Public Function QueryTGamesInEachHour() As DataView
        ArrCodes = {"Gamecode", "Timeofthegame", "TotalGames"}
        Return myHelper.getDataView("Game", ArrCodes, 0, 0, 5)
    End Function
    Public Function QueryAvgInEachGrade() As DataView
        ArrCodes = {"Gradeofthedrill", "TheDrillCode", "AverageInEachDrill"}
        Return myHelper.getDataView("DrillForPlayers", ArrCodes, 0, 0, 7)
    End Function
    Public Function QueryMaxHeightPlayersAbove206() As DataView
        ArrCodes = {"2.06", "", ""}
        Return myHelper.getDataView("Max height above", ArrCodes, 0, 0, 8)
    End Function
    Public Function QueryGamesInEachLoc() As DataView
        ArrCodes = {"Gamecode", "Location", "TotalGamesInThisLocation"}
        Return myHelper.getDataView("Game", ArrCodes, 0, 0, 5)
    End Function
    Public Function QuerySameJersery() As DataView
        ArrCodes = {"Playercode", "Jerseynum", "TotalPlayersWithSameJerseyNum"}
        Return myHelper.getDataView("Players", ArrCodes, 0, 0, 5)
    End Function
    Public Function QueryTotalGamesAsHomeTeam() As DataView
        ArrCodes = {"TheGamecode", "HostersCode", "TotalGamesHasHomeTeam"}
        Return myHelper.getDataView("TeamsInTheGame", ArrCodes, 0, 0, 5)
    End Function
#End Region
End Class
