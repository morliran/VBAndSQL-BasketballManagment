Public Class ClassCheckManager
#Region "בדיקת איזה מנהל קבוצה מחובר"
    Public Function CheckManager() As String
        Return LoginForm.getManagerName()
    End Function
#End Region
#Region "בדיקה קבוצת שיוך"
    Public Function CheckTeam() As String
        Return LoginForm.getManagerTeamName()
    End Function
#End Region
#Region "החזרת קוד בית וחוץ של הקבוצה"
    Public Function GetHomeCode() As String
        Return LoginForm.getHomeCode()
    End Function
    Public Function GetAwayCode() As String
        Return LoginForm.getAwayCode()
    End Function
#End Region
End Class
