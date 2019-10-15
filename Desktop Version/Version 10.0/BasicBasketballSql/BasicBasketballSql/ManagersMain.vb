Imports System.IO
Public Class ManagersMain
    Private Merror As MerrorControl = New MerrorControl()
    Private myHelper As MyDBControler = New MyDBControler()
    Private DatesCheck As CheckingGameDates = New CheckingGameDates()
    Private RowSize As Integer = 10, CntTotalPlayers As Integer = 0, CntMaxRoutionCode As Integer = 0, CntFileLines As Integer = 0, RowFontName As String = "", RowFontStyle As FontStyle = FontStyle.Regular, RowFontC As String = "", OddRowColor As String = "", EvenRowColor As String = ""
    Private ArrCodes() As String = New String() {}, itemcoll(30) As String, TableName As String = "", TeamColors As Boolean = False
    Private allLines As List(Of String) = New List(Of String), TextFilesPath As String = Application.StartupPath & "/TeamTable", theDate As String = ""
#Region "פונקציות על הפורם ושלו"
    Private Sub ManagersMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Directory.Exists(TextFilesPath) = False Then 'אם התיקייה לא נמצאת
            Directory.CreateDirectory(TextFilesPath) 'יצירת התיקייה
        End If
        ReadFileValues()
        Btn_UpBirth.PerformClick() 'בדיקה של ימי הולדת קרובים
        Panel_Birthday.Visible = False 'להראות למשתמש את טבלת ימי הולדת הקרובים לאחר הבדיקה
        SetTeamPlayersTable()
        DatesCheck.CheckGameDate()
        Accessibility.SetDesignToAllForms(Me)
    End Sub
    Private Sub ManagersMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Btn_LogOut.PerformClick()
    End Sub
    Private Sub CloseOperation()
        Me.Hide()
        Me.Dispose()
    End Sub
    Private Sub Panel_Grid_Resize(sender As Object, e As EventArgs) Handles Panel_Grid.Resize
        DataGridView1.Location = New Point((Panel_Grid.Width - DataGridView1.Width) / 2, (Panel_Grid.Height - DataGridView1.Height) / 2)
        For Each p As Panel In Panel_Grid.Controls.OfType(Of Panel)() 'Center all the panels that inside Panel_Grid
            p.Location = New Point((Panel_Grid.Width - p.Width) / 2, (Panel_Grid.Height - p.Height) / 2)
        Next
    End Sub
    Public Function GetDBHelper() As MyDBControler
        Return myHelper
    End Function
    Public Function GetMyError() As MerrorControl
        Return Merror
    End Function
    Public Function GetTeamColorFlag() As Boolean
        Return TeamColors
    End Function
    Public Function GetCntFileLines() As Integer
        Return CntFileLines
    End Function
    Public Function GetAllLines() As List(Of String)
        Return allLines
    End Function
#End Region
#Region "יישום אנימציה של תזוזת התפריט ופתיחתו"
    Private Sub ThePanel_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Players.MouseEnter, Btn_Roution.MouseEnter, Btn_Drills.MouseEnter, Btn_Games.MouseEnter, Btn_Others.MouseEnter, Btn_Design.MouseEnter, Btn_Help.MouseEnter, Btn_LogOut.MouseEnter
        Dim btn As Button = sender
        btn.BackColor = btn.ForeColor
        btn.ForeColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold)
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Lbl_AddingStats.Visible = False
        Panel_MovePanel.Visible = True
        FLP_Move.AutoSize = False
        FLP_Move.Width = 8
        FLP_Move.Height = btn.Height
        FLP_Move.Top = btn.Top
        If Not TableName.Equals("Players") Then
            SetTeamPlayersTable()
        End If
        Select Case btn.Name
            Case "Btn_Players"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Players")
                Timer_Menu.Start()
            Case "Btn_Roution"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Roution")
                Timer_Menu.Start()
            Case "Btn_Drills"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Drills")
                Timer_Menu.Start()
            Case "Btn_Games"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Games")
                If CheckingGameDates.Found = True Then
                    Lbl_AddingStats.Visible = True
                End If
                Timer_Menu.Start()
            Case "Btn_Others"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Others")
                Timer_Menu.Start()
            Case "Btn_Design"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Design")
                Timer_Menu.Start()
            Case "Btn_Help"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Help")
            Case "Btn_LogOut"
                Merror.AllowRootControls(Of Label)(FLP_Move, "Logout")
        End Select
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Timer_Menu_Tick(sender As Object, e As EventArgs) Handles Timer_Menu.Tick
        FLP_Move.Width = FLP_Move.Width + 20
        If FLP_Move.Width > Btn_Players.Width * 2 Then
            FLP_Move.AutoSize = True
            Timer_Menu.Stop()
        End If
    End Sub
    Private Sub ThePanel_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Players.MouseLeave, Btn_Roution.MouseLeave, Btn_Drills.MouseLeave, Btn_Games.MouseLeave, Btn_Others.MouseLeave, Btn_Design.MouseLeave, Btn_Help.MouseLeave, Btn_LogOut.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = btn.BackColor
        btn.BackColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular)
        Timer_Menu.Stop() 'If the user choose to leave button and the menu is not open to his full width and height
    End Sub
#End Region
#Region "אירועים בעת לחיצה על אובייקטים בפורם"
    Private Sub LabelsMouseEnters(sender As Object, e As EventArgs) Handles Lbl_PlayersAge.MouseEnter, Lbl_PlayersBirth.MouseEnter, Lbl_PlayersAdd.MouseEnter, Lbl_PlayersUpdate.MouseEnter, Lbl_PlayersStats.MouseEnter, Lbl_RoutionC.MouseEnter, Lbl_RoutionUpdate.MouseEnter, Lbl_DrillsWatch.MouseEnter, Lbl_DrillsGrade.MouseEnter, Lbl_GamesMyTeam.MouseEnter, Lbl_GamesH.MouseEnter, Lbl_GamesA.MouseEnter, Lbl_AddingStats.MouseEnter, Lbl_GamesV.MouseEnter, Lbl_OthersLeagueLead.MouseEnter, Lbl_OthersP.MouseEnter, Lbl_OthersT.MouseEnter, Lbl_OthersG.MouseEnter, Lbl_OthersS.MouseEnter, Lbl_OthersTracking.MouseEnter, Lbl_DesignStart.MouseEnter, Lbl_DesignTeamColors.MouseEnter, Lbl_DesignDefault.MouseEnter, Lbl_DesignDarkLightMode.MouseEnter, Lbl_DesignUpdateTeamColors.MouseEnter
        Dim label As Label = sender
        label.Font = New Font(label.Font.FontFamily, label.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub LabelsMouseLeave(sender As Object, e As EventArgs) Handles Lbl_PlayersAge.MouseLeave, Lbl_PlayersBirth.MouseLeave, Lbl_PlayersAdd.MouseLeave, Lbl_PlayersUpdate.MouseLeave, Lbl_PlayersStats.MouseLeave, Lbl_RoutionC.MouseLeave, Lbl_RoutionUpdate.MouseLeave, Lbl_DrillsWatch.MouseLeave, Lbl_DrillsGrade.MouseLeave, Lbl_GamesMyTeam.MouseLeave, Lbl_GamesH.MouseLeave, Lbl_GamesA.MouseLeave, Lbl_AddingStats.MouseLeave, Lbl_GamesV.MouseLeave, Lbl_OthersLeagueLead.MouseLeave, Lbl_OthersP.MouseLeave, Lbl_OthersT.MouseLeave, Lbl_OthersG.MouseLeave, Lbl_OthersS.MouseLeave, Lbl_OthersTracking.MouseLeave, Lbl_DesignStart.MouseLeave, Lbl_DesignTeamColors.MouseLeave, Lbl_DesignDefault.MouseLeave, Lbl_DesignDarkLightMode.MouseLeave, Lbl_DesignUpdateTeamColors.MouseLeave
        Dim label As Label = sender
        label.Font = New Font(label.Font.FontFamily, label.Font.Size, FontStyle.Regular)
    End Sub
#End Region
#Region "פונקציות עזר"
    Public Sub SetTeamPlayersTable()
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        ArrCodes = {"HisHomeTeamCode", "=", ClassCheckManager.GetHomeC(), "", "", ""}
        TableName = "Players"
        Lbl_TableName.Text = ClassCheckManager.GetManagerTeamName() & " Players"
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = myHelper.GetDataView("Players", ArrCodes, 4)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub FillListViews(ByVal myList As ListView, ByVal strCode As String)
        Dim ListNum As Integer = 0
        myList.Items.Clear() 'ניקוי כל ערכי העמודות של הטבלה
        myList.Columns.Clear() 'ניקוי כל כותרות העמודות
        If myList.Name.Equals("LV_PlayersCodeView") Then
            ListNum = 1
        ElseIf myList.Name.Equals("LV_PlayersBirthdayView") Then
            ListNum = 2
        End If
        myHelper.FillListView(Me, myList, itemcoll, strCode, ListNum)
    End Sub
    Private Sub ClearPanelText()
        CB_PNames.Text = "Player name"
        CB_PNames.Enabled = True
        Tb_UFN.Text = "First name"
        Tb_ULN.Text = "Last name"
        Tb_UJN.Text = "Jersey number"
        CB_UPosition.Text = "Main position"
        CB_USPosition.Text = "Second position"
        CB_USPosition.Enabled = True
        MB_UHeight.Clear()
        MB_UDOB.Clear()
    End Sub
    Public Sub DesignDataGrid(ByVal DGV As DataGridView)
        ClearPanelText()
        Accessibility.SetDataGridDesign(DGV, 2)
    End Sub
    Public Sub FillPlayersNamesBox(ByVal ComboCodes As ComboBox, ByVal ComboNames As ComboBox)
        myHelper.FillBoxes(ComboCodes, ClassCheckManager.GetHomeC(), 2, ComboNames)
    End Sub
    Private Sub DataGridViewSorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted, DataGridView2.Sorted
        Dim MyDataGrid As DataGridView = sender
        DesignDataGrid(MyDataGrid)
    End Sub
#End Region
#Region "פעולות בעת לחיצה על אחד מן הכפתורים בחלון התפריט"
#Region "Players button options"
    Private Sub Lbl_PlayersAdd_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersAdd.Click
        DataGridView1.Visible = False
        Panel_MovePanel.Visible = False
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_Add.Name)
        Merror.SetPanelControlsEvents(Panel_Add, Me)
        Merror.SetSplitChar("-")
        TableName = "Add"
        Lbl_TableName.Text = "Add Player To " & ClassCheckManager.GetManagerTeamName()
        Tb_AHTC.Text = ClassCheckManager.GetHomeC()
        TB_AATC.Text = ClassCheckManager.GetAwayC()
        Lbl_ManTeam.Text = ClassCheckManager.GetManagerTeamName()
        ArrCodes = {ClassCheckManager.GetHomeC(), ""}
        CntTotalPlayers = myHelper.GetCountResults("CountTeamPlayers", ArrCodes)
        FillListViews(LV_PlayersCodeView, Tb_AHTC.Text)
        If CntTotalPlayers <> 0 Then
            ArrCodes = {ClassCheckManager.GetManagerTeamName(), ""}
            Tb_RoutionCVal.Text = myHelper.GetCountResults("CountMaxRoutionCode", ArrCodes) + 1
        Else
            Tb_RoutionCVal.Text = "1"
        End If
        Lbl_EmptyDateCheck.Text = MB_ADOB.Text
        Lbl_EmptyHeight.Text = MB_AHeight.Text
        Tb_PlayerCode.Focus()
    End Sub
    Private Sub Lbl_PlayersUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersUpdate.Click
        DataGridView1.Visible = False
        Panel_MovePanel.Visible = False
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_Update.Name)
        Merror.SetPanelControlsEvents(Panel_Update, Me)
        Merror.SetSplitChar("-")
        FillPlayersNamesBox(CB_UPlayerCode, CB_PNames)
        TableName = "Update"
        Lbl_TableName.Text = "Update Player From " & ClassCheckManager.GetManagerTeamName()
        Tb_UHTC.Text = ClassCheckManager.GetHomeC()
        TB_UATC.Text = ClassCheckManager.GetAwayC()
    End Sub
    Private Sub Lbl_PlayersAge_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersAge.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {ClassCheckManager.GetHomeC(), ""}
        TableName = "Ages"
        Lbl_TableName.Text = "My " & Lbl_PlayersAge.Text
        DataGridView1.DataSource = myHelper.GetDataView("Ages", ArrCodes)
        DesignDataGrid(DataGridView1)
        HelpForm.SetSelectedNode("Node_Age")
    End Sub
    Private Sub Lbl_PlayersBirth_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersBirth.Click
        DataGridView1.Visible = False
        Panel_MovePanel.Visible = False
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_Birthday.Name)
        TableName = "Birthday"
        Lbl_TableName.Text = ClassCheckManager.GetManagerTeamName() & " Players " & Lbl_PlayersBirth.Text
        FillListViews(LV_PlayersBirthdayView, ClassCheckManager.GetHomeC())
        LV_PlayersBirthdayView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent) 'Fill automatically the size of the columns to there values
        LV_PlayersBirthdayView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        If LV_PlayersBirthdayView.Items.Count <= 0 Then 'If the listview is empty, it means that there is not player that have soon birthday
            MessageBox.Show("None of your players will have soon birthday" & vbNewLine & "check in other day", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Total players in your team that have soon birthday = " & LV_PlayersBirthdayView.Items.Count.ToString(), "Birthday checker", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Lbl_PlayersStats_Click(sender As Object, e As EventArgs) Handles Lbl_PlayersStats.Click
        Me.Hide()
        StatsCompares.Show()
    End Sub
    Private Sub BtnLabelClicks_Click(sender As Object, e As EventArgs) Handles Btn_AdUpdate.Click, Btn_AdAdd.Click, Btn_UpBirth.Click
        Dim btn As Button = sender
        Select Case btn.Name
            Case "Btn_AdUpdate"
                Lbl_PlayersUpdate_Click(Lbl_PlayersUpdate, EventArgs.Empty)
            Case "Btn_AdAdd"
                Lbl_PlayersAdd_Click(Lbl_PlayersAdd, EventArgs.Empty)
            Case "Btn_UpBirth"
                Lbl_PlayersBirth_Click(Lbl_PlayersBirth, EventArgs.Empty)
        End Select
    End Sub
#End Region
#Region "Roution button options"
    Private Sub Lbl_RoutionC_Click(sender As Object, e As EventArgs) Handles Lbl_RoutionC.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        TableName = "SubsCode"
        Lbl_TableName.Text = Lbl_RoutionC.Text
        GetRoutionTable(DataGridView1)
    End Sub
    Private Sub Lbl_RoutionUpdate_Click(sender As Object, e As EventArgs) Handles Lbl_RoutionUpdate.Click
        DataGridView1.Visible = False
        Panel_MovePanel.Visible = False
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_Roution.Name)
        Merror.SetPanelControlsEvents(Panel_Roution, Me)
        TableName = "Update Roution For "
        ArrCodes = {ClassCheckManager.GetManagerTeamName(), ""}
        Lbl_TableName.Text = TableName & ClassCheckManager.GetManagerTeamName() & " Players"
        CntMaxRoutionCode = myHelper.GetCountResults("CountMaxRoutionCode", ArrCodes)
        GetRoutionTable(DataGridView2)
        Tb_TempRoution.Focus()
    End Sub
    Private Sub GetRoutionTable(ByVal DataGridRoution As DataGridView)
        ArrCodes = {ClassCheckManager.GetManagerTeamName(), ""}
        DataGridRoution.DataSource = myHelper.GetDataView("SubsCode", ArrCodes)
        DataGridRoution.Columns(0).Visible = False
        DesignDataGrid(DataGridRoution)
    End Sub
#End Region
#Region "Drill button options"
    Private Sub Lbl_DrillsWatch_Click(sender As Object, e As EventArgs) Handles Lbl_DrillsWatch.Click
        Me.Hide()
        DrillWatch.Show()
    End Sub
    Private Sub Lbl_DrillsGrade_Click(sender As Object, e As EventArgs) Handles Lbl_DrillsGrade.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {ClassCheckManager.GetHomeC(), ""}
        TableName = "Pgrades"
        Lbl_TableName.Text = Lbl_DrillsGrade.Text
        DataGridView1.DataSource = myHelper.GetDataView("Pgrades", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
#End Region
#Region "Games button options"
    Private Sub Lbl_GamesMyTeam_Click(sender As Object, e As EventArgs) Handles Lbl_GamesMyTeam.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {ClassCheckManager.GetHomeC(), ClassCheckManager.GetAwayC()}
        TableName = "MyTeamGames"
        Lbl_TableName.Text = Lbl_GamesMyTeam.Text
        DataGridView1.DataSource = myHelper.GetDataView("MyTeamGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_GamesH_Click(sender As Object, e As EventArgs) Handles Lbl_GamesH.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {ClassCheckManager.GetHomeC(), ""}
        TableName = "AwayOrHomeGames"
        Lbl_TableName.Text = Lbl_GamesH.Text
        DataGridView1.DataSource = myHelper.GetDataView("AwayOrHomeGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_GamesA_Click(sender As Object, e As EventArgs) Handles Lbl_GamesA.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {"", ClassCheckManager.GetAwayC()}
        TableName = "AwayOrHomeGames"
        Lbl_TableName.Text = Lbl_GamesA.Text
        DataGridView1.DataSource = myHelper.GetDataView("AwayOrHomeGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_GamesV_Click(sender As Object, e As EventArgs) Handles Lbl_GamesV.Click
        Me.Hide()
        GamesVisionsMyTeamVsOthers.Show()
    End Sub
    Private Sub Lbl_AddingStats_Click(sender As Object, e As EventArgs) Handles Lbl_AddingStats.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Dim n As String = MsgBox("Notice!: If you select yes the system will not allow you closing the window that will open" & vbNewLine & "Until you finish to insert all your players stats" & vbNewLine & "Are you sure you want to open the new window?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            Me.Hide()
            HelpForm.SetFormTag(1)
            HelpForm.SetSelectedNode("Node_PGStats")
            PlayersMatchStatistics.Lbl_FormBack.Text = "Managers main"
            PlayersMatchStatistics.Show()
        End If
    End Sub
#End Region
#Region "Others button options"
    Private Sub Lbl_OthersP_Click(sender As Object, e As EventArgs) Handles Lbl_OthersP.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {"", "", "", "", "", ""}
        TableName = "PlayersAll"
        Lbl_TableName.Text = Lbl_OthersP.Text
        DataGridView1.DataSource = myHelper.GetDataView("Players", ArrCodes, 7)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersT_Click(sender As Object, e As EventArgs) Handles Lbl_OthersT.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {"", "", "", "", "", ""}
        TableName = "HomeTeam"
        Lbl_TableName.Text = Lbl_OthersT.Text
        DataGridView1.DataSource = myHelper.GetDataView("HomeTeam", ArrCodes, 7)
        DataGridView1.CurrentCell = Nothing 'פה אני מוודא ששום תא לא יסומן על מנת לאפשר מחיקת שורה אחרת תצא הודעה שגיאה
        DataGridView1.Rows(0).Visible = False
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersG_Click(sender As Object, e As EventArgs) Handles Lbl_OthersG.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {"", ""}
        TableName = "LeagueGames"
        Lbl_TableName.Text = Lbl_OthersG.Text
        DataGridView1.DataSource = myHelper.GetDataView("LeagueGames", ArrCodes)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersLeagueLead_Click(sender As Object, e As EventArgs) Handles Lbl_OthersLeagueLead.Click
        LeagueLeaders.Lbl_FormBack.Text = "Managers main"
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_LeagueL")
        LeagueLeaders.Show()
        CloseOperation()
    End Sub
    Private Sub Lbl_OthersS_Click(sender As Object, e As EventArgs) Handles Lbl_OthersS.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        ArrCodes = {"TeamsNames", "=", ClassCheckManager.GetManagerTeamName(), "", "", ""}
        TableName = "PlayersGamesStats"
        Lbl_TableName.Text = Lbl_OthersS.Text
        DataGridView1.DataSource = myHelper.GetDataView("PlayersGamesStats", ArrCodes, 2)
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_OthersTracking_Click(sender As Object, e As EventArgs) Handles Lbl_OthersTracking.Click
        Me.Hide()
        TrackPlayers.Show()
    End Sub
#End Region
#Region "Design button options"
    Private Sub Lbl_DesignStart_Click(sender As Object, e As EventArgs) Handles Lbl_DesignStart.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        Panel_DesignTable.Visible = True
        For Each l As Label In Panel_DesignTable.Controls.OfType(Of Label)()
            l.BackColor = Color.White
            l.ForeColor = Color.Black
            l.Font = New Font("Century Gothic", 18, FontStyle.Bold)
        Next
    End Sub
    Private Sub Btn_FirstColorChoose_Click(sender As Object, e As EventArgs) Handles Btn_FirstColorChoose.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OddRowColor = ColorTranslator.ToHtml(ColorDialog1.Color)
            Lbl_FirstCExample.BackColor = ColorTranslator.FromHtml(OddRowColor)
        End If
    End Sub
    Private Sub Btn_SecondColorChoose_Click(sender As Object, e As EventArgs) Handles Btn_SecondColorChoose.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            EvenRowColor = ColorTranslator.ToHtml(ColorDialog1.Color)
            Lbl_SecondCExample.BackColor = ColorTranslator.FromHtml(EvenRowColor)
        End If
    End Sub
    Private Sub Btn_RowFont_Click(sender As Object, e As EventArgs) Handles Btn_RowFont.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RowFontName = FontDialog1.Font.Name
            RowSize = FontDialog1.Font.Size
            RowFontStyle = FontDialog1.Font.Style
            Lbl_FirstCExample.Font = New Font(RowFontName, RowSize, RowFontStyle)
            Lbl_SecondCExample.Font = New Font(RowFontName, RowSize, RowFontStyle)
        End If
    End Sub
    Private Sub Btn_FontColor_Click(sender As Object, e As EventArgs) Handles Btn_FontColor.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RowFontC = ColorTranslator.ToHtml(ColorDialog1.Color)
            Lbl_FirstCExample.ForeColor = ColorTranslator.FromHtml(RowFontC)
            Lbl_SecondCExample.ForeColor = Lbl_FirstCExample.ForeColor
        End If
    End Sub
    Private Sub Btn_RefreshDesignTable_Click(sender As Object, e As EventArgs) Handles Btn_RefreshDesignTable.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If (i + 1) Mod 2 = 1 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml(OddRowColor)
            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml(EvenRowColor)
            End If
            DataGridView1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Highlight)
            DataGridView1.Rows(i).DefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.HighlightText)
            DataGridView1.Rows(i).DefaultCellStyle.Font = New Font(RowFontName, RowSize, RowFontStyle)
            DataGridView1.Rows(i).DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(RowFontC)
        Next
    End Sub
    Private Sub Lbl_DesignTeamColors_Click(sender As Object, e As EventArgs) Handles Lbl_DesignTeamColors.Click
        Dim n As String = ""
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        If CntFileLines = 2 Then
            TeamColors = True
            DesignDataGrid(DataGridView1)
        Else 'To give the manager the option to add his team color and set his form with them
            TeamColors = False
            n = MsgBox("The system can't find your team colors" & vbNewLine & "To you want to add them?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
            If n = vbYes Then
                SetTheTeamsColors()
            End If
        End If
    End Sub
    Private Sub Lbl_DesignDefault_Click(sender As Object, e As EventArgs) Handles Lbl_DesignDefault.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        TeamColors = False
        DesignDataGrid(DataGridView1)
    End Sub
    Private Sub Lbl_DesignDarkLightMode_Click(sender As Object, e As EventArgs) Handles Lbl_DesignDarkLightMode.Click
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        If Lbl_DesignDarkLightMode.Text.Equals("Dark background") Then
            Me.BackColor = Color.Black
            Lbl_DesignDarkLightMode.Text = "Light background"
        Else
            Me.BackColor = Color.White
            Lbl_DesignDarkLightMode.Text = "Dark background"
        End If
        Panel_Display.BackColor = Me.BackColor
        DataGridView1.BackgroundColor = Panel_Display.BackColor
    End Sub
    Private Sub Lbl_DesignUpdateTeamColors_Click(sender As Object, e As EventArgs) Handles Lbl_DesignUpdateTeamColors.Click
        Dim n As String = ""
        Merror.AllowRootControls(Of Panel)(Panel_Grid, Panel_TopGrid.Name)
        Panel_MovePanel.Visible = False
        n = MsgBox("Are you sure that you want to update your team table colors?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            TeamColors = False
            SetTheTeamsColors()
        Else
            TeamColors = True
            DesignDataGrid(DataGridView1)
        End If
    End Sub
#End Region
#Region "Help and Logout buttons events"
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_Manager")
        HelpForm.Show()
    End Sub
    Private Sub Btn_LogOut_Click(sender As Object, e As EventArgs) Handles Btn_LogOut.Click
        CloseOperation()
        If Not Lbl_BackTo.Text.Equals("Admins main") Then
            MainView.ReturnToMe()
        Else
            AdminsMain.Show()
        End If
    End Sub
#End Region
#End Region
#Region "איוונטים של הפאנל של העדכון, הוספת שחקן או עדכון קוד רוטציה"
    Private Sub BtnSamePos_Click(sender As Object, e As EventArgs) Handles Btn_PSamePos.Click, Btn_ASamePos.Click
        Dim btn As Button = sender
        Select Case btn.Name
            Case "Btn_PSamePos"
                CB_USPosition.Text = "None"
                CB_USPosition.Enabled = False
            Case "Btn_ASamePos"
                CB_ASPosition.Text = "None"
                CB_ASPosition.Enabled = False
        End Select
    End Sub
    Private Sub CBEnterPosition_Enter(sender As Object, e As EventArgs) Handles CB_UPosition.Enter, CB_APosition.Enter
        Dim cmb As ComboBox = sender
        Select Case cmb.Name
            Case "CB_UPosition"
                CB_USPosition.Enabled = True
            Case "CB_APosition"
                CB_ASPosition.Enabled = True
        End Select
    End Sub
    Private Sub ComboSelectPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ASPosition.SelectedIndexChanged, CB_USPosition.SelectedIndexChanged
        Dim cmb As ComboBox = sender
        Select Case cmb.Name
            Case "CB_USPosition"
                CB_USPosition.Enabled = False
            Case "CB_ASPosition"
                CB_ASPosition.Enabled = False
        End Select
    End Sub
    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles Btn_UHelp.Click, Btn_AddHelp.Click, Btn_RoutionHelp.Click, Btn_BirthHelp.Click
        Dim btn As Button = sender
        If Not Lbl_BackTo.Text.Equals("Admins main") Then
            HelpForm.SetFormTag(1)
            Select Case btn.Name
                Case "Btn_UpdateHelp"
                    HelpForm.SetSelectedNode("Node_UpdateP")
                Case "Btn_AddHelp"
                    HelpForm.SetSelectedNode("Node_AddP")
                Case "Btn_RoutionHelp"
                    HelpForm.SetSelectedNode("Node_UpdateR")
                Case "Btn_BirthHelp"
                    HelpForm.SetSelectedNode("Node_UpcomeBirth")
            End Select
        End If
        HelpForm.Show()
    End Sub
#Region "הוספת שחקן"
    Private Sub Btn_PNew_Click(sender As Object, e As EventArgs) Handles Btn_PNew.Click
        Tb_PlayerCode.Text = "Player code"
        Tb_APID.Text = "Player ID"
        Tb_AFN.Text = "First name"
        Tb_ALN.Text = "Last name"
        Tb_AJN.Text = "Jersey number"
        CB_APosition.Text = "Main position"
        CB_ASPosition.Text = "Second position"
        MB_ADOB.Clear()
        MB_AHeight.Clear()
        Btn_PSave.Enabled = True
        Lbl_PlayersAdd_Click(Lbl_PlayersAdd, EventArgs.Empty)
    End Sub
    Private Sub Btn_PSave_Click(sender As Object, e As EventArgs) Handles Btn_PSave.Click
        Dim Flag As Boolean = False
        Lbl_CheckDateOfBirthLen.Text = MB_ADOB.Text
        If Len(Trim(Tb_PlayerCode.Text)) = 0 Or Tb_PlayerCode.Text.Equals("Player code") Then
            MessageBox.Show("Please enter player code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_PlayerCode.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_APID.Text)) = 0 Or Tb_APID.Text.Equals("Player ID") Then
            MessageBox.Show("Please enter player ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_APID.Focus()
            Exit Sub
        ElseIf Tb_APID.Text.Equals(Tb_PlayerCode.Text) Then
            MessageBox.Show("Please enter player ID the id cant be like Player Code", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_APID.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_AFN.Text)) = 0 Or Tb_AFN.Text.Equals("First name") Then
            MessageBox.Show("Please enter first name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_AFN.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_ALN.Text)) = 0 Or Tb_ALN.Text.Equals("Last name") Then
            MessageBox.Show("Please enter last name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_ALN.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_AJN.Text)) = 0 Or Tb_AJN.Text.Equals("Jersey number") Then
            MessageBox.Show("Please enter jersey number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_AJN.Focus()
            Exit Sub
        End If
        If Len(Trim(CB_APosition.Text)) = 0 Or CB_APosition.Text.Equals("Main position") Then
            MessageBox.Show("Please enter first position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CB_APosition.Focus()
            Exit Sub
        End If
        If Len(Trim(CB_ASPosition.Text)) = 0 Or CB_ASPosition.Text.Equals("Second position") Then
            MessageBox.Show("Please enter second position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CB_ASPosition.Focus()
            Exit Sub
        End If
        If MB_AHeight.Text.Equals(Lbl_EmptyHeight.Text) Or MB_AHeight.MaskFull = False Then
            MessageBox.Show("Please enter height", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MB_AHeight.Focus()
            Exit Sub
        End If
        If MB_ADOB.Text.Equals(Lbl_EmptyDateCheck.Text) Or MB_ADOB.MaskFull = False Then
            MessageBox.Show("Please enter birthday", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MB_ADOB.Focus()
            Exit Sub
        ElseIf Len(Lbl_CheckDateOfBirthLen.Text) <> 10 Then
            MessageBox.Show("Birthday has to be in format dd/mm/yyyy", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MB_ADOB.Focus()
            Exit Sub
        End If
        If CB_ASPosition.Text.Equals(CB_APosition.Text) Then 'אם העמדה הראשית היא כמו העמדה המשנית
            CB_ASPosition.Text = "None"
        End If
        If MB_ADOB.MaskFull = True Then
            Try
                Dim dt As DateTime = Convert.ToDateTime(Trim(MB_ADOB.Text))
                theDate = dt.Day.ToString("D2") & "/" & dt.Month.ToString("D2") & "/" & dt.Year
            Catch ex As Exception
                MsgBox("Please input valied date")
                Exit Sub
            End Try
        End If
        Flag = myHelper.TextBoxChangedText(Tb_PlayerCode, 3)
        If (Flag) Then
            myHelper.InsertToTable(Me)
            MessageBox.Show("Successfully added", "Player", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ArrCodes = {ClassCheckManager.GetManagerTeamName(), ""}
            Tb_RoutionCVal.Text = myHelper.GetCountResults("CountMaxRoutionCode", ArrCodes) + 1
            Btn_PSave.Enabled = False
            FillListViews(LV_PlayersCodeView, Tb_AHTC.Text)
        End If
    End Sub
#End Region
#Region "עדכון שחקן"
    Private Sub Btn_PUpdate_Click(sender As Object, e As EventArgs) Handles Btn_PUpdate.Click
        Dim ArrCodes() As String = New String() {}
        If CB_PNames.Text.Equals("Player name") Or CB_PNames.Text.Equals("") Then
            MessageBox.Show("Please select player name", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Len(Trim(Tb_UFN.Text)) = 0 Or Tb_UFN.Text.Equals("First name") Then
            MessageBox.Show("Please enter first name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Tb_ULN.Text)) = 0 Or Tb_ULN.Text.Equals("Last name") Then
            MessageBox.Show("Please enter last name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Len(Trim(Tb_UJN.Text)) = 0 Or Tb_UJN.Text.Equals("Jersey number") Then
            MessageBox.Show("Please enter jersey number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CB_USPosition.Text.Equals(CB_UPosition.Text) Then 'אם העמדה הראשית היא כמו העמדה המשנית
            CB_USPosition.Text = "None"
        End If
        If MB_UHeight.MaskFull = False Then
            MessageBox.Show("Please enter height", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If MB_UDOB.MaskFull = False Then
            MessageBox.Show("Please enter date of birth", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If MB_UDOB.MaskFull = True Then
            Try
                Dim dt As DateTime = Convert.ToDateTime(Trim(MB_UDOB.Text))
                theDate = dt.Day.ToString("D2") & "/" & dt.Month.ToString("D2") & "/" & dt.Year
            Catch ex As Exception
                MsgBox("Please input valied date")
                Exit Sub
            End Try
        End If
        ArrCodes = {Trim(CB_UPlayerCode.Text), Trim(Tb_UPID.Text), Trim(Tb_UFN.Text), Trim(Tb_ULN.Text), Trim(Tb_UJN.Text), Trim(CB_UPosition.Text), Trim(CB_USPosition.Text), Trim(MB_UHeight.Text), Trim(MB_UDOB.Text), Trim(Tb_UHTC.Text), Trim(TB_UATC.Text)}
        myHelper.UpdateTable(Me, ArrCodes, 1)
        MessageBox.Show("Successfully Updated", "Player details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Btn_PUpdate.Enabled = False
        FillPlayersNamesBox(CB_UPlayerCode, CB_PNames)
    End Sub
    Private Sub CB_PNames_TextChanged(sender As Object, e As EventArgs) Handles CB_PNames.TextChanged
        If Not CB_PNames.Text.Equals("Player name") AndAlso CB_PNames.Text.Trim.Length <> 0 Then
            CB_PNames.Enabled = False
        End If
    End Sub
    Private Sub CB_PNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PNames.SelectedIndexChanged
        Dim index As Integer = CB_PNames.SelectedIndex
        CB_UPlayerCode.Text = CB_UPlayerCode.Items(index).ToString()
    End Sub
    Private Sub CB_UPlayerCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_UPlayerCode.SelectedIndexChanged
        Btn_PUpdate.Enabled = True
        myHelper.ComboBoxSelectChange(Me, CB_UPlayerCode, 3)
    End Sub
    Private Sub Btn_ChoiceAgain_Click(sender As Object, e As EventArgs) Handles Btn_ChoiceAgain.Click
        CB_PNames.Text = ""
        CB_PNames.Enabled = True
    End Sub
#End Region
#Region "עדכון קוד רוטציה"
    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        Dim i As Integer = DataGridView2.CurrentRow.Index
        Tb_PRoutioncode.Text = DataGridView2.Item(0, i).Value
        Tb_PRoutionname.Text = DataGridView2.Item(1, i).Value
        Tb_Routioncode.Text = DataGridView2.Item(2, i).Value
        Lbl_PrevRoutionCode.Text = DataGridView2.Item(2, i).Value
    End Sub
    Private Sub Btn_RoutionUpdate_Click(sender As Object, e As EventArgs) Handles Btn_RoutionUpdate.Click
        ArrCodes = {Tb_PRoutioncode.Text, Tb_Routioncode.Text, Lbl_PrevRoutionCode.Text, ClassCheckManager.GetManagerTeamName()}
        If Integer.Parse(Tb_Routioncode.Text) > CntMaxRoutionCode Then
            MessageBox.Show("Roution code cannot been above the maximum roution code in your team " & CntMaxRoutionCode, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        myHelper.UpdateTable(Me, ArrCodes, 2)
        MessageBox.Show("Roution code succesfully update", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Lbl_PrevRoutionCode.Text = ""
        Tb_Routioncode.Text = "Roution code"
        Tb_PRoutionname.Text = "Player name"
        Lbl_RoutionUpdate_Click(Lbl_RoutionUpdate, EventArgs.Empty)
    End Sub
#End Region
#End Region
#Region "קריאה וכתיבת לקובץ של העיצוב לפי צבעי הקבוצה"
    Private Sub WriteFileValues(ByVal FirstColor As String, ByVal SecondColor As String)
        Using FWriter As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(TextFilesPath & "/" & ClassCheckManager.GetManagerTeamName() & " Colors.txt", False)
            FWriter.WriteLine(FirstColor)
            FWriter.WriteLine(SecondColor)
        End Using
        MsgBox("Your team colors is being saved succesfully")
        allLines.Clear()
        ReadFileValues()
    End Sub
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function
    Private Sub ReadFileValues()
        Dim SubButtonsColor As Color = Color.Black
        If Not File.Exists(TextFilesPath & "/" & ClassCheckManager.GetManagerTeamName() & " Colors.txt") Then 'Create text file with the team name
            Using fs As FileStream = File.Create(TextFilesPath & "/" & ClassCheckManager.GetManagerTeamName() & " Colors.txt")
            End Using
        End If
        CntFileLines = File.ReadAllLines(TextFilesPath & "/" & ClassCheckManager.GetManagerTeamName() & " Colors.txt").Length
        If CntFileLines = 2 Then
            Using reader As New StreamReader(TextFilesPath & "/" & ClassCheckManager.GetManagerTeamName() & " Colors.txt")
                Do While Not reader.EndOfStream
                    allLines.Add(reader.ReadLine())
                Loop
            End Using
            TeamColors = True
            Pic_Menu.Image = My.Resources.ResourceManager.GetObject(ClassCheckManager.GetManagerPicName())
            Panel_Left.BackColor = ColorTranslator.FromHtml(ReadLine(1, allLines))
            FLP_Move.BackColor = ColorTranslator.FromHtml(ReadLine(2, allLines))
            ClassCheckManager.SetTeamColors(Panel_Left.BackColor, FLP_Move.BackColor)
            Panel_MoveTop.BackColor = Panel_Left.BackColor
            Panel_TopGrid.BackColor = Panel_Left.BackColor
            Panel_TopPic.BackColor = Panel_Left.BackColor
            Lbl_TableName.ForeColor = FLP_Move.BackColor
            LeagueLeaders.HoverForeColor = Panel_Left.BackColor
            LeagueLeaders.HoverBackColor = FLP_Move.BackColor
            LeagueLeaders.LeaveForeColor = FLP_Move.BackColor
            If Not Color.White.ToArgb().Equals(FLP_Move.BackColor.ToArgb()) Then 'בדיקה האם הצבע של פאנל התפריט הוא לבן או סוג של לבן
                SubButtonsColor = FLP_Move.BackColor
            Else
                SubButtonsColor = Panel_Left.BackColor
            End If
            For Each btn As Button In Panel_Left.Controls.OfType(Of Button)()
                btn.ForeColor = FLP_Move.BackColor
            Next
            For Each lbl As Label In FLP_Move.Controls.OfType(Of Label)()
                lbl.ForeColor = Panel_Left.BackColor
            Next
            For Each p As Panel In Panel_Grid.Controls.OfType(Of Panel)()
                For Each ctrl As Control In p.Controls
                    If TypeOf ctrl Is Panel Then
                        For Each b As Button In ctrl.Controls.OfType(Of Button)()
                            b.FlatAppearance.BorderColor = Panel_Left.BackColor
                            b.ForeColor = SubButtonsColor
                        Next
                    ElseIf TypeOf ctrl Is Button Then 'המרת הctrl לסוג Button
                        DirectCast(ctrl, Button).FlatAppearance.BorderColor = Panel_Left.BackColor
                        DirectCast(ctrl, Button).ForeColor = SubButtonsColor
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub SetTheTeamsColors()
        Dim TeamFirstC As String = "", TeamSecondC As String = "", Temp As String = "", cnt As Integer = 0
        While cnt <> 2
            If cnt = 0 Then
                MsgBox("Please choose your first color")
                If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    TeamFirstC = ColorTranslator.ToHtml(ColorDialog1.Color)
                    cnt += 1
                Else
                    cnt = 0
                End If
            End If
            If cnt = 1 Then
                MsgBox("Please choose your second color")
                If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    TeamSecondC = ColorTranslator.ToHtml(ColorDialog1.Color)
                    cnt += 1
                Else
                    cnt = 1
                End If
            End If
        End While
        If cnt = 2 Then
            If TeamFirstC.Equals(TeamSecondC) Then
                MessageBox.Show("Sorry, cannot saving same colors" & vbNewLine & "Here is the default color table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Lbl_DesignTeamColors_Click(Lbl_DesignTeamColors, EventArgs.Empty)
                Exit Sub
            End If
            If Color.White.ToArgb().Equals(ColorTranslator.FromHtml(TeamFirstC).ToArgb()) Then
                Temp = TeamFirstC
                TeamFirstC = TeamSecondC
                TeamSecondC = Temp
            End If
            For Each l As Label In FLP_Move.Controls.OfType(Of Label)() 'To make sure that all menu labels backcolor getting update
                l.BackColor = Color.Transparent
            Next
            For Each b As Button In Panel_Left.Controls.OfType(Of Button)() 'To make sure that all menu buttons backcolor getting update
                b.BackColor = Color.Transparent
            Next
            Panel_MovePanel.Visible = False
            WriteFileValues(TeamFirstC, TeamSecondC)
        End If
        DesignDataGrid(DataGridView1)
    End Sub
#End Region
End Class