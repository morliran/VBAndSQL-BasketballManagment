Public NotInheritable Class ClassCheckManager
    Private Shared ManagerName As String = "", ManagerPicName As String = "", TeamName As String = "", HomeC As String = "", AwayC As String = ""
    Private Shared TeamColorOne As Color = Nothing, TeamColorTwo As Color = Nothing
    Private Sub New() 'Avoid allowing inheritable
    End Sub
    Private Shared Sub SetControlForeColor(ByVal Thecontrol As Control, ByVal ThePanel As Panel)
        If Not Color.White.ToArgb().Equals(ThePanel.BackColor.ToArgb()) Then
            Thecontrol.ForeColor = TeamColorTwo
        Else
            Thecontrol.ForeColor = TeamColorOne
        End If
    End Sub
    Public Shared Sub SetSubFormsColors(ByVal frm As Form)
        If (TeamColorOne <> Nothing AndAlso TeamColorTwo <> Nothing) Then
            For Each p As Panel In frm.Controls.OfType(Of Panel)()
                If p.Name.Contains("Top") Or p.Name.Contains("Left") Then
                    p.BackColor = TeamColorOne
                    For Each ctrl As Control In p.Controls
                        If TypeOf ctrl Is Panel Or TypeOf ctrl Is GroupBox Then 'פאנל בתוך פאנל
                            For Each c As Control In ctrl.Controls
                                SetControlForeColor(c, p)
                            Next
                        ElseIf TypeOf ctrl Is ComboBox Or TypeOf ctrl Is TextBox Or TypeOf ctrl Is MaskedTextBox Then
                            If Not Color.White.ToArgb().Equals(p.BackColor.ToArgb()) Then
                                ctrl.ForeColor = TeamColorOne
                            Else
                                ctrl.ForeColor = TeamColorTwo
                            End If
                        Else
                            SetControlForeColor(ctrl, p)
                        End If
                    Next
                End If
            Next
        End If
    End Sub
#Region "Getters And Setters"
    Public Shared Sub SetManagerName(ByVal name As String)
        ManagerName = name
    End Sub
    Public Shared Sub SetManagerTeam(ByVal Tname As String)
        TeamName = Tname
        HomeC = MainView.GetHelper.GetColumn("HomeTeamCode", GetManagerTeamName())
        AwayC = MainView.GetHelper.GetColumn("AwayTeamCode", GetManagerTeamName())
    End Sub
    Public Shared Sub SetManagerPic(ByVal Picname As String)
        ManagerPicName = Picname
    End Sub
    Public Shared Sub SetTeamColors(ByVal C As Color, ByVal CTwo As Color)
        TeamColorOne = C
        TeamColorTwo = CTwo
    End Sub
    Public Shared Function GetManagerName() As String
        Return ManagerName
    End Function
    Public Shared Function GetManagerTeamName() As String
        Return TeamName
    End Function
    Public Shared Function GetManagerPicName() As String
        Return ManagerPicName
    End Function
    Public Shared Function GetHomeC() As String
        Return HomeC
    End Function
    Public Shared Function GetAwayC() As String
        Return AwayC
    End Function
#End Region
End Class
