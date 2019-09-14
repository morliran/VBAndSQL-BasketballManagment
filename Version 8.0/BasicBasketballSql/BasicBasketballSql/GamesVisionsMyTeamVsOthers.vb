Public Class GamesVisionsMyTeamVsOthers
    Private intHeight As Integer
    Private notPlayed As Integer = 0, yesPlayed As Integer = 0, O0Above As Integer = 0, O100Above As Integer = 0
    Private DO0Above As Integer = 0, DO50Above As Integer = 0, SumAteam As Integer = 0, SumHTeam As Integer = 0, cntApperance As Integer = 0
    Private Merror As MerrorControl = New MerrorControl()
    Private Mat As DataView = New DataView(), Mat2 As DataView = New DataView()
    Private ArrCodes() As String = New String() {}, ArrH() As String = New String() {}, ArrA() As String = New String() {}
    Private notManagerHc As String = "", notManagerAc As String = ""
#Region "פונקציות של הפורם"
    Private Sub GamesVisionsMyTeamVsOthers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ManagersMain.getDBHelper.FillBoxes(CB_ATname, "Get all teams names")
        ManagersMain.getDBHelper.FillBoxes(CB_HTname, "Get all teams names")
        CB_ATname.Items.Remove("Free-Agents") 'Make sure not including players that dont have team
        CB_HTname.Items.Remove("Free-Agents")
        Accessibility.SetDesignToAllForms(Me)
    End Sub
    Private Sub Panel_Left_Resize(sender As Object, e As EventArgs) Handles Panel_Left.Resize
        FLP_Buttons.Location = New Point((Panel_Left.Width - FLP_Buttons.Width) / 2, (Panel_Left.Height - FLP_Buttons.Height) / 2)
    End Sub
    Private Sub GamesVisionsMyTeamVsOthers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        If Lbl_CheckBack.Text <> "Guest main" Then
            ManagersMain.Show()
        Else
            GuestMain.Show()
        End If
    End Sub
    Private Sub AwayChart()
        Chart1.Series(0).Points.Clear()
        For Count As Integer = 0 To DataGridView1.Rows.Count - 1
            Chart1.Series(0).Points.AddXY(DataGridView1.Item(1, Count).Value, DataGridView1.Item(2, Count).Value)
        Next
        ManagersMain.DesignDataGrid(DataGridView1)
    End Sub
    Private Sub HomeChart()
        Chart2.Series(0).Points.Clear()
        For Count As Integer = 0 To DataGridView2.Rows.Count - 1
            Chart2.Series(0).Points.AddXY(DataGridView2.Item(1, Count).Value, DataGridView2.Item(2, Count).Value)
        Next
        ManagersMain.DesignDataGrid(DataGridView2)
    End Sub
#End Region
#Region "אירועים על תיבת הבחירה של קבוצת החוץ"
    Private Sub CB_ATname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ATname.SelectedIndexChanged
        Dim checker As String = ""
        intHeight = 0
        yesPlayed = 0
        notPlayed = 0
        O0Above = 0
        O100Above = 0
        DO0Above = 0
        DO50Above = 0
        ArrCodes = {CB_ATname.Text, ""}
        DataGridView1.DataSource = ManagersMain.getDBHelper.getDataView("Vis", ArrCodes)
        For Each rowheight As DataGridViewRow In DataGridView1.Rows ' משנה את גודל הdatagrid בהתאם לגודל הטבלה שהוחזרה מהdatabase '
            intHeight += rowheight.Height
        Next
        DataGridView1.Height = intHeight + 23
        AwayChart()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells.Item("Offense").Value = 0 AndAlso row.Cells.Item("Defence").Value = 0 Then
                notPlayed = notPlayed + 1
            Else
                yesPlayed = yesPlayed + 1
            End If
        Next
        Lbl_P.Text = yesPlayed.ToString()
        Lbl_NP.Text = notPlayed.ToString()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells.Item("Offense").Value >= 0 AndAlso row.Cells.Item("Offense").Value < 100 Then
                O0Above = O0Above + 1
            ElseIf row.Cells.Item("Offense").Value >= 100 Then
                O100Above = O100Above + 1
            End If
        Next
        Lbl_A0.Text = O0Above.ToString()
        Lbl_A100.Text = O100Above.ToString()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells.Item("Defence").Value >= 0 AndAlso row.Cells.Item("Defence").Value < 50 Then
                DO0Above = DO0Above + 1
            ElseIf row.Cells.Item("Defence").Value >= 50 Then
                DO50Above = DO50Above + 1
            End If
        Next
        Lbl_DA0.Text = DO0Above.ToString()
        Lbl_DA50.Text = DO50Above.ToString()
        If Lbl_CheckBack.Text <> "Guest main" Then
            checker = ManagersMain.getManager.CheckTeam()
            If CB_ATname.Text <> checker Then
                CB_HTname.Text = checker
                notManagerAc = ManagersMain.getDBHelper.getColumn("AwayTeamCode", CB_ATname.Text)
                notManagerHc = ManagersMain.getDBHelper.getColumn("HomeTeamCode", CB_ATname.Text)
                ArrA = {ManagersMain.getManager.GetHomeCode, notManagerAc}
                ArrH = {notManagerHc, ManagersMain.getManager.GetAwayCode}
            End If
        End If
    End Sub
    Private Sub CB_ATname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_ATname.KeyPress
        Merror.isUnvailed(e, CB_ATname)
    End Sub
#End Region
#Region "אירועים על תיבות הבחירה של קבוצת הבית"
    Private Sub CB_HTname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_HTname.SelectedIndexChanged
        Dim checker As String = ""
        intHeight = 0
        yesPlayed = 0
        notPlayed = 0
        O0Above = 0
        O100Above = 0
        DO0Above = 0
        DO50Above = 0
        ArrCodes = {CB_HTname.Text, ""}
        DataGridView2.DataSource = ManagersMain.getDBHelper.getDataView("Vis", ArrCodes)
        For Each rowheight As DataGridViewRow In DataGridView2.Rows ' משנה את גודל הdatagrid בהתאם לגודל הטבלה שהוחזרה מהdatabase '
            intHeight += rowheight.Height
        Next
        DataGridView2.Height = intHeight + 23
        HomeChart()
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells.Item("Offense").Value = 0 AndAlso row.Cells.Item("Defence").Value = 0 Then
                notPlayed = notPlayed + 1
            Else
                yesPlayed = yesPlayed + 1
            End If
        Next
        Lbl_P2.Text = yesPlayed.ToString()
        Lbl_NP2.Text = notPlayed.ToString()
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells.Item("Offense").Value < 100 Then
                O0Above = O0Above + 1
            ElseIf row.Cells.Item("Offense").Value >= 100 Then
                O100Above = O100Above + 1
            End If
        Next
        Lbl_H0.Text = O0Above.ToString()
        Lbl_H100.Text = O100Above.ToString()
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells.Item("Defence").Value < 50 Then
                DO0Above = DO0Above + 1
            Else
                DO50Above = DO50Above + 1
            End If
        Next
        Lbl_DH0.Text = DO0Above.ToString()
        Lbl_DH50.Text = DO50Above.ToString()
        If Lbl_CheckBack.Text <> "Guest main" Then
            checker = ManagersMain.getManager.CheckTeam()
            If CB_HTname.Text <> checker Then
                CB_ATname.Text = checker
                notManagerAc = ManagersMain.getDBHelper.getColumn("AwayTeamCode", CB_HTname.Text)
                notManagerHc = ManagersMain.getDBHelper.getColumn("HomeTeamCode", CB_HTname.Text)
                ArrH = {notManagerHc, ManagersMain.getManager.GetAwayCode}
                ArrA = {ManagersMain.getManager.GetHomeCode, notManagerAc}
            End If
        End If
    End Sub
    Private Sub CB_HTname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_HTname.KeyPress
        Merror.isUnvailed(e, CB_HTname)
    End Sub
#End Region
#Region "אירועים בעת לחיצה כל כפתור הפעלת האלגוריתם, או לחיצה על תמונת העזרה"
    Private Sub Btn_NaiveBayes_Click(sender As Object, e As EventArgs) Handles Btn_NaiveBayes.Click
        Dim CHomeCode As String = "", CHomeACode As String = "", CAwayCode As String = "", CAwayHCode As String = ""
        ProgressBar1.Visible = True
        Lbl_Message.Visible = True
        Lbl_Per.Visible = True
        If Lbl_CheckBack.Text = "Guest main" Then
            CHomeCode = GuestMain.getHelper.getColumn("HomeTeamCode", CB_HTname.Text) 'Home team code
            CHomeACode = GuestMain.getHelper.getColumn("AwayTeamCode", CB_HTname.Text) 'Home team away code
            CAwayCode = GuestMain.getHelper.getColumn("AwayTeamCode", CB_ATname.Text) 'Away team code
            CAwayHCode = GuestMain.getHelper.getColumn("HomeTeamCode", CB_ATname.Text) 'Away team home code
            ArrA = {CHomeCode, CAwayCode}
            ArrH = {CAwayHCode, CHomeACode}
        End If
        Mat = ManagersMain.getDBHelper.getDataView("CheckPrevRes", ArrA)
        Mat2 = ManagersMain.getDBHelper.getDataView("CheckPrevRes", ArrH)
        If Mat.Count = 0 AndAlso Mat2.Count = 0 Then 'Both team doesn't saw each other yet in the league
            GamesVisionAlgo.Lbl_PrevAMatch.Text = "0"
            GamesVisionAlgo.Lbl_PrevHMatch.Text = "0"
        ElseIf Mat.Count <> 0 AndAlso Mat2.Count = 0 Then 'The team saw each other only in the away team arena
            GamesVisionAlgo.Lbl_PrevHMatch.Text = "0"
        ElseIf Mat.Count = 0 AndAlso Mat2.Count <> 0 Then 'The team saw each other only in the home team arena
            GamesVisionAlgo.Lbl_PrevAMatch.Text = "0"
        End If
        If Mat.Count <> 0 AndAlso Mat2.Count <> 0 Then 'The team saw each other in each arena
            cntApperance = ManagersMain.getDBHelper.getCountResults("CountTotalAppearanceEachOther", ArrA)
            For Each rowView As DataRowView In Mat
                Dim row As DataRow = rowView.Row
                If row.Item("TeamsNames").ToString() = CB_ATname.Text Then
                    SumAteam = SumAteam + Integer.Parse(row.Item("TeamPoints").ToString())
                Else
                    SumHTeam = SumHTeam + Integer.Parse(row.Item("TeamPoints").ToString())
                End If
            Next
            For Each rowView As DataRowView In Mat2
                Dim row As DataRow = rowView.Row
                If row.Item("TeamsNames").ToString() = CB_HTname.Text Then
                    SumHTeam = SumHTeam + Integer.Parse(row.Item("TeamPoints").ToString())
                Else
                    SumAteam = SumAteam + Integer.Parse(row.Item("TeamPoints").ToString())
                End If
            Next
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
        CB_ATname.Enabled = False
        CB_HTname.Enabled = False
        Btn_NaiveBayes.Enabled = False
        Btn_Help.Enabled = False
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 20 Then
            Lbl_Message.Text = "Arrange the data..."
        ElseIf ProgressBar1.Value = 40 Then
            Lbl_Message.Text = "Making chart..."
        ElseIf ProgressBar1.Value = 60 Then
            Lbl_Message.Text = "Making calculation..."
        ElseIf ProgressBar1.Value = 80 Then
            Lbl_Message.Text = "Arrange the results..."
        ElseIf ProgressBar1.Value = 100 Then
            GamesVisionAlgo.Show()
            GamesVisionAlgo.Lbl_CheckBack.Text = "My team vs others"
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
            Lbl_Message.Text = "Collect the data"
            Lbl_Message.Visible = False
            Lbl_Per.Visible = False
            Timer1.Stop()
            CB_ATname.Enabled = True
            CB_HTname.Enabled = True
            Btn_NaiveBayes.Enabled = True
            Btn_Help.Enabled = True
        End If
        Lbl_Per.Text = ProgressBar1.Value & (" %")
    End Sub
#End Region
#Region "איוונטים על הפאנל של הכפתורים"
    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs) Handles Btn_NaiveBayes.MouseEnter, Btn_Help.MouseEnter
        Dim btn As Button = sender
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles Btn_NaiveBayes.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
End Class