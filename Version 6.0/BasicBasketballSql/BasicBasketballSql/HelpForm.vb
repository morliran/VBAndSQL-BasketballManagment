Imports System.IO
Public Class HelpForm
    Private TextFilesPath As String = Application.StartupPath & "/HelpText" & "/" & Accessibility.Language
    Private FormTag As Integer
#Region "פונקציות של הפורם"
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As TreeNode, nChild As TreeNode
        RTB_Temp.Font = New Font(Accessibility.FontName, Accessibility.FontSize, Accessibility.FontStyle)
        If FormTag <> 0 Then
            For i As Integer = Tb_Search.AutoCompleteCustomSource.Count - 1 To 0 Step -1 'Move backforward, avoid -1 index in the first item in the list
                If Tb_Search.AutoCompleteCustomSource(i).StartsWith("Manage") Then
                    Tb_Search.AutoCompleteCustomSource.RemoveAt(i)
                End If
            Next
        End If
        For Each n In TreeV_Help.Nodes 'Removing the unnecessary leafs for admins, managers and guests, Tag 0 = admins, Tag 1 = managers, Tag 2 = guests
            If n.Nodes.Count > 0 Then
                For Each nChild In n.Nodes
                    If FormTag = 0 Then
                        If nChild.Text = "Manager main" Or nChild.Text = "Guest main" AndAlso nChild.Nodes.Count > 0 Then
                            nChild.Nodes.Clear()
                        End If
                    End If
                    If FormTag = 1 Then
                        If nChild.Text = "Admin main" AndAlso nChild.Nodes.Count > 0 Then
                            nChild.Nodes.Clear()
                        End If
                    ElseIf FormTag = 2 Then
                        If nChild.Text = "Admin main" Or nChild.Text = "Manager main" AndAlso nChild.Nodes.Count > 0 Then
                            nChild.Nodes.Clear()
                        End If
                    End If
                Next
            End If
            If FormTag = 0 Or FormTag = 1 Or FormTag = 2 Then
                If FormTag = 1 Or FormTag = 2 Then
                    n.Nodes.RemoveByKey("Node_Admin")
                End If
                If FormTag = 0 Or FormTag = 1 Then
                    Tb_Search.AutoCompleteCustomSource.Remove("Guest queries")
                    Tb_Search.AutoCompleteCustomSource.Remove("League leaders")
                    Tb_Search.AutoCompleteCustomSource.Remove("Build query")
                    Tb_Search.AutoCompleteCustomSource.Remove("Search information")
                    n.Nodes.RemoveByKey("Node_Guest")
                End If
                If FormTag = 0 Or FormTag = 2 Then
                    Tb_Search.AutoCompleteCustomSource.Remove("Players")
                    Tb_Search.AutoCompleteCustomSource.Remove("Roution")
                    Tb_Search.AutoCompleteCustomSource.Remove("Drills")
                    Tb_Search.AutoCompleteCustomSource.Remove("Games")
                    Tb_Search.AutoCompleteCustomSource.Remove("Others")
                    Tb_Search.AutoCompleteCustomSource.Remove("Game stats")
                    Tb_Search.AutoCompleteCustomSource.Remove("Compare stats")
                    Tb_Search.AutoCompleteCustomSource.Remove("Vision")
                    Tb_Search.AutoCompleteCustomSource.Remove("Tracking players")
                    n.Nodes.RemoveByKey("Node_Manager")
                End If
            End If
        Next
    End Sub
    Private Sub HelpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Me.Hide()
    End Sub
    Public Sub SetFormTag(ByVal formtag As Integer)
        Me.FormTag = formtag
    End Sub
    Public Sub SetSelectedNode(ByVal nodename As String)
        TreeV_Help.SelectedNode = TreeV_Help.Nodes.Find(nodename, True)(0) '0 - מציין את השורש הראשון בעץ
        TreeV_Help.SelectedNode.Expand()
    End Sub
    Private Sub ReadData(ByVal fileName As String)
        If Accessibility.Language.Equals("Hebrew") Then
            RTB_Temp.RightToLeft = Windows.Forms.RightToLeft.Yes
            RTB_Temp.Text = File.ReadAllText(TextFilesPath & "/" & fileName & ".txt", System.Text.Encoding.GetEncoding(1255)) 'Hebrew encoding code is 1255
        Else
            RTB_Temp.Text = File.ReadAllText(TextFilesPath & "/" & fileName & ".txt")
        End If
        RTB_Temp.ForeColor = Accessibility.FontColor
    End Sub
#End Region
#Region "לחיצה על פריט מתוך הרשימה של מידע על פורם מסויים במערכת"
    Private Sub TreeV_Help_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeV_Help.AfterSelect
        Select Case e.Node.Name
            Case "Node_AddTeam", "Node_UpdateTeam", "Node_AdminTeams"
                ReadData("AdminTeams")
            Case "Node_AdmAddP", "Node_AdmUpdateP", "Node_AdmDeleteP", "Node_AdminPlayers"
                ReadData("AdminPlayers")
            Case "Node_AddP", "Node_UpdateP"
                ReadData("AddUpdateP")
            Case "Node_AddGame", "Node_UpdateGame", "Node_AdminGames"
                ReadData("AdminGames")
            Case "Node_AdminAddStats", "Node_PGStats"
                ReadData("AddGameStats")
            Case "Node_AdminLeagueL", "Node_AdminLeague", "Node_LeagueChange"
                ReadData("AdminLeague")
            Case "Node_LeagueL", "Node_GuestLeagueL"
                ReadData("Leaders")
            Case "Node_Age", "Node_UpcomeBirth"
                ReadData("Birthday")
            Case "Node_StatsP"
                ReadData("Stats")
            Case "Node_RoutionCode", "Node_UpdateR"
                ReadData("Roution")
            Case "Node_WatchD", "Node_GradeD"
                ReadData("Drills")
            Case "Node_MyTeamG", "Node_HomeG", "Node_AwayG", "Node_LeagueP", "Node_LeagueT", "Node_LeagueG"
                ReadData("OtherManageDetails")
            Case "Node_VisionG"
                ReadData("Vision")
            Case "Node_TrackP"
                ReadData("Tracking")
            Case "Node_GuestQ", "Node_BuildQuery"
                ReadData("GuestDetails")
        End Select
    End Sub
#End Region
#Region "אירועים בעת לחיצות על האובייקטים שיש בפורם"
    Private Sub Tb_Search_TextChanged(sender As Object, e As EventArgs) Handles Tb_Search.TextChanged
        If FormTag = 0 Then
            Select Case Tb_Search.Text
                Case "Manage teams"
                    ReadData("AdminTeams")
                Case "Manage players"
                    ReadData("AdminPlayers")
                Case "Manage games"
                    ReadData("AdminGames")
                Case "Manage league"
                    ReadData("AdminLeague")
            End Select
        ElseIf FormTag = 1 Then
            Select Case Tb_Search.Text
                Case "Players"
                    ReadData("AddUpdateP")
                Case "Roution"
                    ReadData("Roution")
                Case "Drills"
                    ReadData("Drills")
                Case "Games", "Others"
                    ReadData("OtherManageDetails")
                Case "Game stats"
                    ReadData("AddGameStats")
                Case "Compare stats"
                    ReadData("Stats")
                Case "Vision"
                    ReadData("Vision")
                Case "Tracking players"
                    ReadData("Tracking")
            End Select
        ElseIf FormTag = 2 Then
            Select Case Tb_Search.Text
                Case "Guest queries", "Build query", "Search information"
                    ReadData("GuestDetails")
                Case "League leaders"
                    ReadData("Leaders")
            End Select
        End If
    End Sub
    Private Sub RTB_Temp_MouseClick(sender As Object, e As MouseEventArgs) Handles RTB_Temp.MouseClick
        TreeV_Help.Focus()
    End Sub
#End Region
End Class