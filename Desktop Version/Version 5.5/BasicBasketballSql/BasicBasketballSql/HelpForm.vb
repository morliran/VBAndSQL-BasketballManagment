Public Class HelpForm
    Private FormTag As Integer
#Region "פונקציות של הפורם"
    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'מחיקת הסברים על דברים שלא מתאימים למשתמש המחובר טאג 1 מייצג מנהלי קבוצות וטאג 2 אורחים'
        Dim n As TreeNode, nChild As TreeNode
        If FormTag = 1 Or FormTag = 2 Then
            For Each n In TreeV_Help.Nodes
                If n.Nodes.Count > 0 Then
                    For Each nChild In n.Nodes
                        If FormTag = 1 Then
                            If nChild.Text = "Admin main" AndAlso nChild.Nodes.Count > 0 Then
                                nChild.Nodes.Clear()
                            End If
                        Else
                            If nChild.Text = "Admin main" Or nChild.Text = "Manager main" AndAlso nChild.Nodes.Count > 0 Then
                                nChild.Nodes.Clear()
                            End If
                        End If
                    Next
                End If
                n.Nodes.RemoveByKey("Node_Admin")
                If FormTag = 2 Then
                    n.Nodes.RemoveByKey("Node_Manager")
                End If
            Next
        End If
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
    Private Sub SetRichFront(ByVal rich As RichTextBox)
        rich.SelectAll()
        rich.SelectionColor = Color.Black
        rich.BringToFront()
    End Sub
#End Region
#Region "לחיצה על פריט מתוך הרשימה של מידע על פורם מסויים במערכת"
    Private Sub TreeV_Help_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeV_Help.AfterSelect
        Select Case e.Node.Name
            Case "Node_AddTeam", "Node_UpdateTeam"
                SetRichFront(RTB_TeamAUDetails)
            Case "Node_AddP", "Node_UpdateP", "Node_AdmAddP", "Node_AdmUpdateP"
                SetRichFront(RTB_PlayerAUDetails)
            Case "Node_AdmDeleteP"
                SetRichFront(RTB_PlayerDeleteD)
            Case "Node_AddGame", "Node_UpdateGame"
                SetRichFront(RTB_GameAUDetails)
            Case "Node_AdminAddStats", "Node_PGStats"
                SetRichFront(RTB_AddStatsDetails)
            Case "Node_LeagueL", "Node_AdmLeagueL", "Node_GuestLeagueL"
                SetRichFront(RTB_LeadersDetails)
            Case "Node_LeagueChange"
                SetRichFront(RTB_LeagueChangeDetails)
            Case "Node_Age", "Node_UpcomeBirth"
                SetRichFront(RTB_AgeBirthDetails)
            Case "Node_StatsP"
                SetRichFront(RTB_PlayerStatsDetails)
            Case "Node_RoutionCode", "Node_UpdateR"
                SetRichFront(RTB_RoutionDetails)
            Case "Node_WatchD", "Node_GradeD"
                SetRichFront(RTB_DrillsDetails)
            Case "Node_MyTeamG", "Node_HomeG", "Node_AwayG", "Node_LeagueP", "Node_LeagueT", "Node_LeagueG"
                SetRichFront(RTB_OtherManaDetails)
            Case "Node_VisionG"
                SetRichFront(RTB_VisionDetails)
            Case "Node_TrackP"
                SetRichFront(RTB_TrackDetails)
            Case "Node_GuestQ", "Node_BuildQuery"
                SetRichFront(RTB_QuestODetails)
        End Select
    End Sub
#End Region
End Class