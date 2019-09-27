Imports System.IO
Public Class HelpForm
    Private TextFilesPath As String = Application.StartupPath & "/HelpText" & "/" & Accessibility.Language, FormTag As Integer
#Region "פונקציות של הפורם"
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TreeP As TreeView, n As TreeNode, nChild As TreeNode
        Accessibility.SetDesignToAllForms(Me)
        If Accessibility.Language.Equals("Hebrew") Then
            Tb_SearchHeb.Visible = True
            TreeV_HelpHeb.Visible = True
            RTB_TempHeb.Visible = True
            TreeV_HelpEng.Visible = False
            Tb_SearchEng.Visible = False
            RTB_TempEng.Visible = False
            Panel_Right.BackColor = Me.BackColor
            Panel_Left.BackColor = Color.LightSkyBlue
            RTB_TempHeb.BackColor = Panel_Left.BackColor
        Else
            Tb_SearchHeb.Visible = False
            TreeV_HelpHeb.Visible = False
            RTB_TempHeb.Visible = False
            TreeV_HelpEng.Visible = True
            Tb_SearchEng.Visible = True
            RTB_TempEng.Visible = True
            Panel_Right.BackColor = Color.LightSkyBlue
            Panel_Left.BackColor = Me.BackColor
            RTB_TempEng.BackColor = Panel_Right.BackColor
        End If
        If FormTag <> 0 Then
            For i As Integer = Tb_SearchEng.AutoCompleteCustomSource.Count - 1 To 0 Step -1 'Move backforward, avoid -1 index in the first item in the list
                If Tb_SearchEng.AutoCompleteCustomSource(i).StartsWith("Manage") Then
                    Tb_SearchEng.AutoCompleteCustomSource.RemoveAt(i)
                End If
            Next
            For i As Integer = Tb_SearchHeb.AutoCompleteCustomSource.Count - 1 To 0 Step -1
                If Tb_SearchHeb.AutoCompleteCustomSource(i).StartsWith("ניהול") Then
                    Tb_SearchHeb.AutoCompleteCustomSource.RemoveAt(i)
                End If
            Next
        End If
        For Each TreeP In Me.Controls.OfType(Of TreeView)() 'Get all treeview controls inside the form
            For Each n In TreeP.Nodes 'Removing the unnecessary leafs for admins, managers and guests, Tag 0 = admins, Tag 1 = managers, Tag 2 = guests
                If n.Nodes.Count > 0 Then
                    For Each nChild In n.Nodes
                        If FormTag = 0 Then
                            If nChild.Name.Equals("Node_Admin") Then
                                If Accessibility.Language.Equals("Hebrew") Then
                                    nChild.Text = "עזרה"
                                Else
                                    nChild.Text = "Help"
                                End If
                            End If
                            If nChild.Name.Equals("Node_Manager") Or nChild.Name.Equals("Node_Guest") AndAlso nChild.Nodes.Count > 0 Then
                                nChild.Nodes.Clear()
                            End If
                        End If
                        If FormTag = 1 Then
                            If nChild.Name.Equals("Node_Manager") Then
                                If Accessibility.Language.Equals("Hebrew") Then
                                    nChild.Text = "עזרה"
                                Else
                                    nChild.Text = "Help"
                                End If
                            End If
                            If nChild.Name.Equals("Node_Admin") AndAlso nChild.Nodes.Count > 0 Then
                                nChild.Nodes.Clear()
                            End If
                        ElseIf FormTag = 2 Then
                            If nChild.Name.Equals("Node_Guest") Then
                                If Accessibility.Language.Equals("Hebrew") Then
                                    nChild.Text = "עזרה"
                                Else
                                    nChild.Text = "Help"
                                End If
                            End If
                            If nChild.Name.Equals("Node_Admin") Or nChild.Name.Equals("Node_Manager") AndAlso nChild.Nodes.Count > 0 Then
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
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Guest queries")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("League leaders")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Build query")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Search information")
                        'Hebrew
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("מובילי הליגה")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("חיפוש מידע")
                        n.Nodes.RemoveByKey("Node_Guest")
                    End If
                    If FormTag = 0 Or FormTag = 2 Then
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Players")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Roution")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Drills")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Games")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Others")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Game stats")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Compare stats")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Vision")
                        Tb_SearchEng.AutoCompleteCustomSource.Remove("Tracking players")
                        'Hebrew
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("שחקנים")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("רוטציות")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("תרגילים")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("משחקים")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("אחר")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("סטטיסטיקות משחק")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("השוואת סטטיסטיקות")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("חיזוי")
                        Tb_SearchHeb.AutoCompleteCustomSource.Remove("מעקב שחקנים")
                        n.Nodes.RemoveByKey("Node_Manager")
                    End If
                End If
            Next
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
        If Accessibility.Language.Equals("Hebrew") Then
            TreeV_HelpHeb.SelectedNode = TreeV_HelpHeb.Nodes.Find(nodename, True)(0)
            TreeV_HelpHeb.SelectedNode.Expand()
        Else
            TreeV_HelpEng.SelectedNode = TreeV_HelpEng.Nodes.Find(nodename, True)(0) '0 - The first node in the tree that called Help menu
            TreeV_HelpEng.SelectedNode.Expand()
        End If
    End Sub
    Private Sub ReadData(ByVal fileName As String)
        If Accessibility.Language.Equals("Hebrew") Then
            RTB_TempHeb.Text = File.ReadAllText(TextFilesPath & "/" & fileName & ".txt", System.Text.Encoding.GetEncoding(1255)) 'Hebrew encoding code is 1255
        Else
            RTB_TempEng.Text = File.ReadAllText(TextFilesPath & "/" & fileName & ".txt")
        End If
    End Sub
#End Region
#Region "לחיצה על פריט מתוך הרשימה של מידע על פורם מסויים במערכת"
    Private Sub TreeVHelp_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeV_HelpEng.AfterSelect, TreeV_HelpHeb.AfterSelect
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
    Private Sub SearchText_TextChanged(sender As Object, e As EventArgs) Handles Tb_SearchEng.TextChanged, Tb_SearchHeb.TextChanged
        Dim Tb As TextBox = sender
        If FormTag = 0 Then
            Select Case Tb.Text
                Case "Manage teams", "ניהול קבוצות"
                    ReadData("AdminTeams")
                Case "Manage players", "ניהול שחקנים"
                    ReadData("AdminPlayers")
                Case "Manage games", "ניהול משחקים"
                    ReadData("AdminGames")
                Case "Manage league", "ניהול ליגה"
                    ReadData("AdminLeague")
            End Select
        ElseIf FormTag = 1 Then
            Select Case Tb.Text
                Case "Players", "שחקנים"
                    ReadData("AddUpdateP")
                Case "Roution", "רוטציות"
                    ReadData("Roution")
                Case "Drills", "תרגילים"
                    ReadData("Drills")
                Case "Games", "Others", "משחקים", "אחר"
                    ReadData("OtherManageDetails")
                Case "Game stats", "סטטיסטיקות משחק"
                    ReadData("AddGameStats")
                Case "Compare stats", "השוואת סטטיסטיקות"
                    ReadData("Stats")
                Case "Vision", "חיזוי"
                    ReadData("Vision")
                Case "Tracking players", "מעקב שחקנים"
                    ReadData("Tracking")
            End Select
        ElseIf FormTag = 2 Then
            Select Case Tb.Text
                Case "Guest queries", "Build query", "Search information", "חיפוש מידע"
                    ReadData("GuestDetails")
                Case "League leaders", "מובילי הליגה"
                    ReadData("Leaders")
            End Select
        End If
    End Sub
    Private Sub SearchEnter_Enter(sender As Object, e As EventArgs) Handles Tb_SearchEng.Enter, Tb_SearchHeb.Enter
        Dim Tb As TextBox = sender
        Tb.Text = ""
    End Sub
    Private Sub RichText_MouseClick(sender As Object, e As MouseEventArgs) Handles RTB_TempEng.MouseClick, RTB_TempHeb.MouseClick
        Dim rich As RichTextBox = sender
        Select Case rich.Name
            Case "RTB_TempEng"
                TreeV_HelpEng.Focus()
            Case "RTB_TempHeb"
                TreeV_HelpHeb.Focus()
        End Select
    End Sub
#End Region
End Class