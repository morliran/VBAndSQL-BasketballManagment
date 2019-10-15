Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms.DataVisualization.Charting
Public Class MyDBControler
    Private myCon As Connection = New Connection()
#Region "פונקציה אשר משמשת להתחברות מערכת"
    Public Sub GetDBLogin(ByVal val As Integer, Optional ByVal Name As String = "", Optional ByVal Details() As String = Nothing) 'Name -> בשביל הוספת קבוצה
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Cmd.Parameters.AddWithValue("p_val", val)
                If val = 2 Then 'המס' 2 מייצג התחברות למערכת
                    Cmd.Parameters.AddWithValue("p_code", Trim(MainView.Tb_UserName.Text))
                    Cmd.Parameters.AddWithValue("p_code2", Trim(MainView.Tb_Password.Text))
                ElseIf val = 1 Then
                    If Details IsNot Nothing Then
                        Cmd.Parameters.AddWithValue("p_code", Trim(Details(0)))
                        Cmd.Parameters.AddWithValue("p_code2", Trim(Details(1)))
                    End If
                End If
                Cmd.Parameters.AddWithValue("p_code3", Name)
                Cmd.CommandText = "spLogin"
                Cmd.CommandType = CommandType.StoredProcedure
                Using Rder As MySqlDataReader = Cmd.ExecuteReader()
                    If Rder.HasRows Then
                        Rder.Read()
                    End If
                    If Rder.HasRows = False Then
                        If val = 2 Then
                            MainView.Lbl_Conecting.Visible = False
                            MsgBox("Incorrent username or password try again...", MsgBoxStyle.Critical, "Login denied")
                            MainView.Tb_UserName.Clear()
                            MainView.Tb_Password.Clear()
                            MainView.Tb_UserName.Focus()
                        End If
                    Else
                        If Rder.GetString(0).Equals("ADMIN") Then
                            MainView.Hide()
                            AdminsMain.Show()
                        Else
                            ManagersMain.Lbl_ManagerCheck.Text = Rder.GetString(0)
                            ClassCheckManager.SetManagerName(Rder.GetString(0))
                            ClassCheckManager.SetManagerTeam(Rder.GetString(2))
                            ClassCheckManager.SetManagerPic(Rder.GetString(2).Replace("-", "")) 'התאמת שם התמונה לשם הקבוצה
                            MainView.Hide()
                            ManagersMain.Show()
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub
#End Region
#Region "פונקציה שמחזירה מחרוזת ומשמשת לקבלת נתון מתוך עמודה מסויימת"
    Public Function GetColumn(ByVal ColName As String, ByVal SearchBy As String, Optional ByVal FrmName As String = "") As String
        Dim RecordVal As String = "NULL"
        Using CN2 As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN2.Open()
            Using Cmd2 As MySqlCommand = New MySqlCommand()
                Cmd2.Connection = CN2
                Cmd2.Parameters.Add("p_res", MySqlDbType.LongText).Direction = ParameterDirection.Output
                Cmd2.Parameters.AddWithValue("p_code", SearchBy)
                Cmd2.CommandText = "spGet" + ColName
                Cmd2.CommandType = CommandType.StoredProcedure
                Cmd2.ExecuteNonQuery()
                RecordVal = Cmd2.Parameters(0).Value.ToString()
                If FrmName.Equals("Admins") Then 'כאן אני מאפשר למנהל/ת ליגה להוסיף נתונים לכל קבוצה ע"י שימוש ביוזר של מנהל הקבוצה שנבחרה
                    ClassCheckManager.SetManagerTeam(SearchBy)
                End If
            End Using
        End Using
        Return RecordVal
    End Function
#End Region
#Region "פונקציה שמחזירה מס' שלם אשר מייצג את הכמות הנדרשת, לדוגמא קבלת המס' המקסימאלי של קוד רוטציה בקבוצה מסויימת"
    Public Function GetCountResults(ByVal CountSearchType As String, Optional ByVal ValuesToSearchWith() As String = Nothing) As Integer
        Dim RecordCount As Int32 = 0
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Cmd.Parameters.Add("p_res", MySqlDbType.Int32).Direction = ParameterDirection.Output
                Cmd.Parameters.AddWithValue("p_info", CountSearchType)
                If ValuesToSearchWith IsNot Nothing Then
                    Cmd.Parameters.AddWithValue("p_val1", ValuesToSearchWith(0))
                    Cmd.Parameters.AddWithValue("p_val2", ValuesToSearchWith(1))
                Else
                    Cmd.Parameters.AddWithValue("p_val1", "")
                    Cmd.Parameters.AddWithValue("p_val2", "")
                End If
                Cmd.CommandText = "spGetCounts"
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.ExecuteScalar()
                RecordCount = Convert.ToInt32(Cmd.Parameters("p_res").Value)
            End Using
        End Using
        Return RecordCount
    End Function
#End Region
#Region "פונקציה אשר ממלאה את תיבות הבחירה הדורשות מידע ממסד הנתונים"
    Public Sub FillBoxes(ByVal Combo As ComboBox, ByVal Searchval As String, Optional ByVal QueryCode As Integer = 0, Optional ByVal Combo2 As ComboBox = Nothing, Optional ByVal Searchval2 As String = "")
        Dim Drow As DataRow, Ds As New DataSet, Dtable As New DataTable
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using DataTableAdapter As MySqlDataAdapter = New MySqlDataAdapter()
                DataTableAdapter.SelectCommand = New MySqlCommand()
                DataTableAdapter.SelectCommand.Connection = CN
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val", Searchval)
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val2", Searchval2)
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_num", QueryCode)
                DataTableAdapter.SelectCommand.CommandText = "spQueryFillCombo"
                DataTableAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                DataTableAdapter.Fill(Ds)
                Dtable = Ds.Tables(0)
                Combo.Items.Clear()
                If Combo2 IsNot Nothing Then
                    Combo2.Items.Clear()
                End If
                For Each Drow In Dtable.Rows
                    If QueryCode = 2 Or QueryCode = 3 Then
                        Combo2.Items.Add(Drow(1).ToString())
                    End If
                    Combo.Items.Add(Drow(0).ToString())
                Next
            End Using
        End Using
    End Sub
#End Region
#Region "פונקציה אשר ממלאה את נתוני תיבות טקסט, תיבות מס' וכו'... באמצעות הערך שיש בתיבת הבחירה מוך מסד הנתונים"
    Public Sub ComboBoxSelectChange(ByVal frm As Form, ByVal Combo As ComboBox, ByVal ConditionCode As Integer)
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Cmd.CommandText = "spGetSelected"
                Cmd.Parameters.AddWithValue("p_num", ConditionCode)
                Cmd.Parameters.AddWithValue("p_find", Trim(Combo.Text))
                If frm.Name.Equals("AdminsMain") AndAlso ConditionCode = 9 Then
                    Cmd.Parameters.AddWithValue("p_find2", Trim(GetColumn("HomeTeamCode", AdminsMain.CB_TeamsName.Text)))
                Else
                    Cmd.Parameters.AddWithValue("p_find2", "")
                End If
                Cmd.CommandType = CommandType.StoredProcedure
                Using Rder As MySqlDataReader = Cmd.ExecuteReader()
                    If Rder.Read Then
                        Select Case frm.Name
                            Case "AdminsMain"
                                If ConditionCode = 1 Then
                                    AdminsMain.Tb_Gametypeval.Text = GetColumn("GameType", Rder.GetString(0))
                                    AdminsMain.MTB_TimeVal.Text = Trim(Rder.GetString(1))
                                    AdminsMain.Tb_Locationval.Text = Trim(Rder.GetString(2))
                                    AdminsMain.MTB_GameDate.Text = Trim(Rder.GetString(4))
                                    AdminsMain.Tb_HostersCval.Text = Trim(Rder.GetString(6))
                                    AdminsMain.Tb_VisitorsCval.Text = Trim(Rder.GetString(7))
                                ElseIf ConditionCode = 2 Then
                                    AdminsMain.Tb_HcodeVal.Text = Trim(Rder.GetString(0))
                                    AdminsMain.Tb_AcodeVal.Text = Trim(Rder.GetString(2))
                                    AdminsMain.Tb_ArenaDetail.Text = Trim(Rder.GetString(3))
                                ElseIf ConditionCode = 9 Then
                                    AdminsMain.Tb_TGameCval.Text = Trim(Rder.GetString(0))
                                    AdminsMain.Tb_GameDate.Text = Trim(Rder.GetString(1))
                                End If
                            Case "PlayersMatchStatistics"
                                PlayersMatchStatistics.Tb_PID.Text = Trim(Rder.GetString(1))
                                PlayersMatchStatistics.Tb_FN.Text = Trim(Rder.GetString(2))
                                PlayersMatchStatistics.Tb_LN.Text = Trim(Rder.GetString(3))
                            Case "ManagersMain"
                                ManagersMain.Tb_UPID.Text = Trim(Rder.GetString(1))
                                ManagersMain.Tb_UFN.Text = Trim(Rder.GetString(2))
                                ManagersMain.Tb_ULN.Text = Trim(Rder.GetString(3))
                                ManagersMain.Tb_UJN.Text = Trim(Rder.GetString(4))
                                ManagersMain.CB_UPosition.Text = Trim(Rder.GetString(5))
                                ManagersMain.CB_USPosition.Text = Trim(Rder.GetString(6))
                                ManagersMain.MB_UHeight.Text = Trim(Rder.GetDouble(7))
                                ManagersMain.MB_UDOB.Text = Trim(Rder.GetString(8))
                                ManagersMain.Tb_UHTC.Text = Trim(Rder.GetString(9))
                                ManagersMain.TB_UATC.Text = Trim(Rder.GetString(10))
                            Case "DrillWatch"
                                DrillWatch.Lbl_Code.Text = Trim(Rder.GetString(0))
                                DrillWatch.Lbl_Name.Text = Trim(Rder.GetString(2)) & " " & Trim(Rder.GetString(3))
                        End Select
                    End If
                End Using
            End Using
        End Using
    End Sub
#End Region
#Region "פונקציה שמחזירה ערך בוליאני אשר בודק האם קיים הערך שנמצא בתיבת הטקסט בתוך מסד הנתונים"
    Public Function TextBoxChangedText(ByVal Textb As TextBox, Optional ByVal SelectCode As Integer = 0) As Boolean
        Dim Flag As Boolean = False
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Cmd.Parameters.AddWithValue("p_num", SelectCode)
                Cmd.Parameters.AddWithValue("p_find", Trim(Textb.Text))
                Cmd.Parameters.AddWithValue("p_find2", "")
                Cmd.CommandText = "spGetSelected"
                Cmd.CommandType = CommandType.StoredProcedure
                Using Rder As MySqlDataReader = Cmd.ExecuteReader()
                    If Rder.Read Then
                        MessageBox.Show("Playercode Already Exists", "Save value error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Textb.Focus()
                        Flag = False
                    Else
                        Flag = True
                    End If
                End Using
            End Using
        End Using
        Return Flag
    End Function
#End Region
#Region "פונקציה אשר מחזירה טבלה מתוך מסד הנתונים וממלאה אותה ואת תיבות הבחירה"
    Public Function FillDataTableAndBoxs(ByVal MyTable As DataTable, ByVal MyDs As DataSet, ByVal Combo As ComboBox, _
                                         ByVal Combo2 As ComboBox, ByVal SearchBy As String, Optional ByVal TwoBoxes As Boolean = False) As DataTable
        Dim Drow As DataRow
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using DataTableAdapter As MySqlDataAdapter = New MySqlDataAdapter()
                DataTableAdapter.SelectCommand = New MySqlCommand()
                DataTableAdapter.SelectCommand.Connection = CN
                DataTableAdapter.SelectCommand.CommandText = "spGetSelected"
                If (Combo.Name = "CB_Playercode" AndAlso Combo2.Name = "CB_Playercode2") AndAlso TwoBoxes = True Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_num", 4)
                ElseIf (Combo.Name = "CB_Gametype" Or Combo.Name = "CB_Gametype2") AndAlso TwoBoxes = False Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_num", 5)
                ElseIf (Combo.Name = "CB_Temp" Or Combo.Name = "CB_Temp2") AndAlso TwoBoxes = False Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_num", 8)
                End If
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_find", SearchBy)
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_find2", "")
                DataTableAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                DataTableAdapter.Fill(MyDs)
                MyTable = MyDs.Tables(0)
                Combo.Items.Clear()
                If TwoBoxes = True Then
                    Combo2.Items.Clear()
                End If
                For Each Drow In MyTable.Rows
                    Combo.Items.Add(Drow(0).ToString())
                    If TwoBoxes = True Then
                        Combo2.Items.Add(Drow(0).ToString())
                    End If
                Next
            End Using
        End Using
        Return MyTable
    End Function
#End Region
#Region "פונקציה שממלאה את הגרפים שנמצאים בפורם של ההשוואות הסטטיסטיות בין השחקנים"
    Public Sub FillChartLabels(ByVal ChartName As Chart, ByVal SeriesName As String, _
                     ByVal LabelArray() As Label, ByVal LabelsName() As String, ByVal MyTable As DataTable, ByVal ValuesToSearchBy() As String)
        Dim i As Integer
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using DataTableAdapter As MySqlDataAdapter = New MySqlDataAdapter()
                DataTableAdapter.SelectCommand = New MySqlCommand()
                DataTableAdapter.SelectCommand.Connection = CN
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_Gametypecode", ValuesToSearchBy(0))
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_Playercode", ValuesToSearchBy(1))
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val", ValuesToSearchBy(2))
                DataTableAdapter.SelectCommand.CommandText = "spCompareStats"
                DataTableAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                DataTableAdapter.Fill(MyTable)
                If LabelArray IsNot Nothing Then
                    For i = 0 To MyTable.Rows.Count - 1 'קבלת הערכים מהטבלה והצבתם בגרף
                        LabelArray(0).Text = (MyTable.Rows(i)(LabelsName(0)).ToString())
                        LabelArray(1).Text = (MyTable.Rows(i)(LabelsName(1)).ToString())
                        LabelArray(2).Text = (MyTable.Rows(i)(LabelsName(2)).ToString())
                        LabelArray(3).Text = (MyTable.Rows(i)(LabelsName(3)).ToString())
                        LabelArray(4).Text = (MyTable.Rows(i)(LabelsName(4)).ToString())
                    Next
                End If
            End Using
        End Using
        If LabelArray IsNot Nothing Then
            ChartName.Series(SeriesName).Points.AddXY(LabelsName(0), LabelArray(0).Text)
            ChartName.Series(SeriesName).Points.AddXY(LabelsName(1), LabelArray(1).Text)
            ChartName.Series(SeriesName).Points.AddXY(LabelsName(2), LabelArray(2).Text)
            ChartName.Series(SeriesName).Points.AddXY(LabelsName(3), LabelArray(3).Text)
            ChartName.Series(SeriesName).Points.AddXY(LabelsName(4), LabelArray(4).Text)
        End If
    End Sub
#End Region
#Region "פונקציה שמחזירה רשימה אשר מכילה ערכים מסוימיים מתוך מסד הנתונים"
    Public Function FillListView(ByVal frm As Form, ByVal myListView As ListView, ByVal itemcoll() As String, _
                                 ByVal WhatToFill As String, Optional ByVal TableNum As Integer = 0) As ListView
        Dim SampleSource As New DataSet, lvi As ListViewItem, i As Integer, j As Integer
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using DataTableAdapter As MySqlDataAdapter = New MySqlDataAdapter()
                DataTableAdapter.SelectCommand = New MySqlCommand()
                DataTableAdapter.SelectCommand.Connection = CN
                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_find", WhatToFill)
                Select Case frm.Name
                    Case "LeagueLeaders"
                        DataTableAdapter.SelectCommand.CommandText = "spGetLeaders"
                    Case "ManagersMain", "DrillWatch"
                        DataTableAdapter.SelectCommand.CommandText = "spGetSelected"
                        DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_find2", "")
                        If frm.Name.Equals("ManagersMain") Then
                            If TableNum = 1 Then
                                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_num", 4)
                            ElseIf TableNum = 2 Then
                                DataTableAdapter.SelectCommand.CommandText = "spUpcomingBirthday"
                            End If
                        ElseIf frm.Name.Equals("DrillWatch") Then
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_num", 7)
                        End If
                End Select
                DataTableAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                DataTableAdapter.Fill(SampleSource)
                For i = 0 To SampleSource.Tables(0).Columns.Count - 1 'הוספת כותרות העמודות ל-ListView
                    myListView.Columns.Add(SampleSource.Tables(0).Columns(i).ColumnName.ToString())
                Next
                For i = 0 To SampleSource.Tables(0).Rows.Count - 1 'הוספת הערכים של הטבלה אל ה-ListView
                    For j = 0 To SampleSource.Tables(0).Columns.Count - 1
                        itemcoll(j) = SampleSource.Tables(0).Rows(i)(j).ToString()
                    Next
                    lvi = New ListViewItem(itemcoll)
                    myListView.Items.Add(lvi)
                Next
            End Using
        End Using
        If frm.Name.Equals("LeagueLeaders") Then
            For i = 0 To myListView.Items.Count - 1
                myListView.Items(i).Text = (i + 1) & ". " & myListView.Items(i).Text
            Next
        End If
        For Each column As ColumnHeader In myListView.Columns 'התאמת אורך העמודות לערכים שלהן
            column.Width = -1
        Next
        Return myListView
    End Function
#End Region
#Region "פונקציה שמחזירה מס' נתונים מתוך מסד הנתונים"
    Public Function GetDataView(ByVal WhatToFill As String, ByVal ValuesToSearchBy() As String, Optional ByVal code As Integer = 0, _
                                Optional ByVal code2 As Integer = 0, Optional ByVal code3 As Integer = 0) As DataView
        Dim TableView As New DataView, SampleSource As New DataSet
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using DataTableAdapter As MySqlDataAdapter = New MySqlDataAdapter()
                DataTableAdapter.SelectCommand = New MySqlCommand()
                DataTableAdapter.SelectCommand.Connection = CN
                If WhatToFill.Equals("Track") = False Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_info", WhatToFill)
                End If
                If code <> 0 Or code2 <> 0 Or code3 <> 0 Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val1", ValuesToSearchBy(0))
                End If
                If code = 0 AndAlso code2 = 0 AndAlso code3 = 0 Then
                    Select Case WhatToFill
                        Case "Jerseynum", "Height", "Position", "SecondPosition", "Dateofbirth", _
                            "LeagueGames", "MyTeamGames", "AwayOrHomeGames", "Ages", "Pgrades", "Vis", "SubsCode"
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val1", ValuesToSearchBy(0))
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val2", ValuesToSearchBy(1))
                            If WhatToFill.Equals("Jerseynum") Or WhatToFill.Equals("Height") Or WhatToFill.Equals("Dateofbirth") Or
                                WhatToFill.Equals("Position") Or WhatToFill.Equals("SecondPosition") Then
                                DataTableAdapter.SelectCommand.CommandText = "spBuildDynamic"
                            ElseIf WhatToFill.Equals("LeagueGames") Or WhatToFill.Equals("MyTeamGames") Or WhatToFill.Equals("AwayOrHomeGames") Or
                                WhatToFill.Equals("Ages") Or WhatToFill.Equals("Pgrades") Or WhatToFill.Equals("Vis") Or WhatToFill.Equals("SubsCode") Then
                                DataTableAdapter.SelectCommand.CommandText = "spGetOthersMQuery"
                            End If
                        Case "CheckDate"
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val1", ValuesToSearchBy(0))
                            DataTableAdapter.SelectCommand.CommandText = "spCheckGameInDate"
                        Case "CheckPrevRes", "MatchResults"
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val1", ValuesToSearchBy(0))
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val2", ValuesToSearchBy(1))
                            DataTableAdapter.SelectCommand.CommandText = "spGetPrevMatchRes"
                        Case "Track"
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_cm1", ValuesToSearchBy(0))
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_cm2", ValuesToSearchBy(1))
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_cm3", ValuesToSearchBy(2))
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val", ValuesToSearchBy(3))
                            DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_lengthP", TrackPlayers.GetCnt())
                            DataTableAdapter.SelectCommand.CommandText = "spTrackPlayers"
                            ParamFive(ValuesToSearchBy, DataTableAdapter)
                            If TrackPlayers.GetFlagGameType() = True Then
                                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_cm16", TrackPlayers.CB_GameOper.Text)
                                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val6", TrackPlayers.CB_Gametype.Text)
                            Else
                                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_cm16", "")
                                DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val6", "")
                            End If
                    End Select
                ElseIf code <> 0 AndAlso code2 = 0 AndAlso code3 = 0 Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_op1", ValuesToSearchBy(1))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_search1", ValuesToSearchBy(2))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_typeOp", ValuesToSearchBy(3))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_op2", ValuesToSearchBy(4))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_search2", ValuesToSearchBy(5))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_code", code)
                    DataTableAdapter.SelectCommand.CommandText = "spGetAllTablesDataDynamic"
                ElseIf code2 <> 0 AndAlso code3 = 0 AndAlso code = 0 Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val2", ValuesToSearchBy(1))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_explain", ValuesToSearchBy(2))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_explain2", ValuesToSearchBy(3))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_search", ValuesToSearchBy(4))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_search2", ValuesToSearchBy(5))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_code", code2)
                    DataTableAdapter.SelectCommand.CommandText = "spWhereMinMaxSumAvgCountFormatTablesDynamic"
                ElseIf code3 <> 0 AndAlso code2 = 0 AndAlso code = 0 Then
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_val2", ValuesToSearchBy(1))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_explain", ValuesToSearchBy(2))
                    DataTableAdapter.SelectCommand.Parameters.AddWithValue("p_code", code3)
                    DataTableAdapter.SelectCommand.CommandText = "spGroupByMinMaxSumAvgCountFormatTablesDynamic"
                End If
                DataTableAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                DataTableAdapter.Fill(SampleSource)
                TableView = SampleSource.Tables(0).DefaultView
            End Using
        End Using
        Return TableView
    End Function
#End Region
#Region "פונקציות המשמשות לאיתור שחקנים בפורם של חיפוש שחקנים לקבוצה"
    Private Sub ParamTwo(ByVal ValuesToSearchBy() As String, ByVal MyAdapter As MySqlDataAdapter)
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm4", ValuesToSearchBy(4))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm5", ValuesToSearchBy(5))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm6", ValuesToSearchBy(6))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_val2", ValuesToSearchBy(7))
    End Sub
    Private Sub ParamThree(ByVal ValuesToSearchBy() As String, ByVal MyAdapter As MySqlDataAdapter)
        ParamTwo(ValuesToSearchBy, MyAdapter)
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm7", ValuesToSearchBy(8))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm8", ValuesToSearchBy(9))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm9", ValuesToSearchBy(10))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_val3", ValuesToSearchBy(11))
    End Sub
    Private Sub ParamFour(ByVal ValuesToSearchBy() As String, ByVal MyAdapter As MySqlDataAdapter)
        ParamThree(ValuesToSearchBy, MyAdapter)
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm10", ValuesToSearchBy(12))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm11", ValuesToSearchBy(13))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm12", ValuesToSearchBy(14))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_val4", ValuesToSearchBy(15))
    End Sub
    Private Sub ParamFive(ByVal ValuesToSearchBy() As String, ByVal MyAdapter As MySqlDataAdapter)
        ParamFour(ValuesToSearchBy, MyAdapter)
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm13", ValuesToSearchBy(16))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm14", ValuesToSearchBy(17))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_cm15", ValuesToSearchBy(18))
        MyAdapter.SelectCommand.Parameters.AddWithValue("p_val5", ValuesToSearchBy(19))
    End Sub
#End Region
#Region "פונקציה להכנסת נתונים שנמצאים בפורם מסויים אל טבלה שאליה הוא מתייחס"
    Public Sub InsertToTable(ByVal frm As Form)
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Select Case frm.Name
                    Case "PlayersMatchStatistics"
                        Cmd.Parameters.AddWithValue("@p_d1", Trim(PlayersMatchStatistics.CB_PlayerMatchCode.Text))
                        Cmd.Parameters.AddWithValue("@p_d2", Trim(PlayersMatchStatistics.TB_GamesCodes.Text))
                        Cmd.Parameters.AddWithValue("@p_d3", Trim(PlayersMatchStatistics.Tb_GamesTypes.Text))
                        Cmd.Parameters.AddWithValue("@p_d4", Trim(PlayersMatchStatistics.Tb_GamesDate.Text))
                        Cmd.Parameters.AddWithValue("@p_d5", Trim(PlayersMatchStatistics.Tb_Points.Text))
                        Cmd.Parameters.AddWithValue("@p_d6", Trim(PlayersMatchStatistics.Tb_Assist.Text))
                        Cmd.Parameters.AddWithValue("@p_d7", Trim(PlayersMatchStatistics.Tb_Rebound.Text))
                        Cmd.Parameters.AddWithValue("@p_d8", Trim(PlayersMatchStatistics.Tb_Steel.Text))
                        Cmd.Parameters.AddWithValue("@p_d9", Trim(PlayersMatchStatistics.Tb_Block.Text))
                        Cmd.Parameters.AddWithValue("@p_d10", Trim(PlayersMatchStatistics.Tb_TeamsNames.Text))
                        Cmd.CommandText = "spInsertStats"
                    Case "ManagersMain"
                        Cmd.Parameters.AddWithValue("@p_d1", Trim(ManagersMain.Tb_PlayerCode.Text))
                        Cmd.Parameters.AddWithValue("@p_d2", Trim(ManagersMain.Tb_APID.Text))
                        Cmd.Parameters.AddWithValue("@p_d3", Trim(ManagersMain.Tb_AFN.Text))
                        Cmd.Parameters.AddWithValue("@p_d4", Trim(ManagersMain.Tb_ALN.Text))
                        Cmd.Parameters.AddWithValue("@p_d5", Trim(ManagersMain.Tb_AJN.Text))
                        Cmd.Parameters.AddWithValue("@p_d6", Trim(ManagersMain.CB_APosition.Text))
                        Cmd.Parameters.AddWithValue("@p_d7", Trim(ManagersMain.CB_ASPosition.Text))
                        Cmd.Parameters.AddWithValue("@p_d8", Trim(ManagersMain.MB_AHeight.Text))
                        Cmd.Parameters.AddWithValue("@p_d9", Trim(ManagersMain.GetTheDate()))
                        Cmd.Parameters.AddWithValue("@p_d10", Trim(ManagersMain.Tb_AHTC.Text))
                        Cmd.Parameters.AddWithValue("@p_d11", Trim(ManagersMain.TB_AATC.Text))
                        Cmd.Parameters.AddWithValue("@p_d12", Trim(ManagersMain.Tb_RoutionCVal.Text))
                        Cmd.Parameters.AddWithValue("@p_d13", Trim(ManagersMain.Lbl_ManTeam.Text))
                        Cmd.CommandText = "spInsertPlayers"
                End Select
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.ExecuteReader()
            End Using
        End Using
    End Sub
#End Region
#Region "פונקציה להכנסת נתונים לשתי טבלאות שאליהם הפורם מתייחס"
    Public Sub InsertToTwoTables(ByVal frm As Form, ByVal Queryname As String)
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Select Case frm.Name
                    Case "AdminsMain"
                        Select Case Queryname
                            Case "AddGames"
                                Cmd.Parameters.AddWithValue("@p_d1", Trim(AdminsMain.CB_GameCode.Text))
                                Cmd.Parameters.AddWithValue("@p_d2", Trim(AdminsMain.MTB_TimeVal.Text))
                                Cmd.Parameters.AddWithValue("@p_d3", Trim(AdminsMain.Tb_Locationval.Text))
                                Cmd.Parameters.AddWithValue("@p_d4", Trim(AdminsMain.Tb_Gametypeval.Text))
                                Cmd.Parameters.AddWithValue("@p_d5", Trim(AdminsMain.Tb_HostersCval.Text))
                                Cmd.Parameters.AddWithValue("@p_d6", Trim(AdminsMain.Tb_VisitorsCval.Text))
                                Cmd.Parameters.AddWithValue("@p_d7", Trim(AdminsMain.MTB_GameDate.Text))
                                Cmd.CommandText = "spInsertGameDetails"
                            Case "AddTeams"
                                Cmd.Parameters.AddWithValue("@p_aC", Trim(AdminsMain.Tb_AcodeVal.Text))
                                Cmd.Parameters.AddWithValue("@p_hC", Trim(AdminsMain.Tb_HcodeVal.Text))
                                Cmd.Parameters.AddWithValue("@p_tN", Trim(AdminsMain.Tb_TeamN.Text))
                                Cmd.Parameters.AddWithValue("@p_a", Trim(AdminsMain.Tb_ArenaDetail.Text))
                                Cmd.CommandText = "spInsertTeam"
                        End Select
                End Select
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.ExecuteReader()
            End Using
        End Using
    End Sub
#End Region
#Region "פונקציה לעדכון נתונים בטבלה שאליה הפורם מתייחס"
    Public Sub UpdateTable(ByVal frm As Form, ByVal ValuesToUpdate() As String, Optional ByVal TableNum As Integer = 0)
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Cmd.Parameters.AddWithValue("p_pcode", ValuesToUpdate(0))
                Select Case frm.Name
                    Case "PlayersMatchStatistics"
                        Cmd.Parameters.AddWithValue("p_gcode", ValuesToUpdate(1))
                        Cmd.Parameters.AddWithValue("p_gtcode", ValuesToUpdate(2))
                        Cmd.Parameters.AddWithValue("p_dcode", ValuesToUpdate(3))
                        Cmd.Parameters.AddWithValue("p_tname", ValuesToUpdate(4))
                        Cmd.Parameters.AddWithValue("p_p", ValuesToUpdate(5))
                        Cmd.Parameters.AddWithValue("p_a", ValuesToUpdate(6))
                        Cmd.Parameters.AddWithValue("p_r", ValuesToUpdate(7))
                        Cmd.Parameters.AddWithValue("p_s", ValuesToUpdate(8))
                        Cmd.Parameters.AddWithValue("p_b", ValuesToUpdate(9))
                        Cmd.CommandText = "spUpdatePlayerStats"
                    Case "ManagersMain"
                        If TableNum = 1 Then
                            Cmd.Parameters.AddWithValue("p_pidcode", ValuesToUpdate(1))
                            Cmd.Parameters.AddWithValue("p_firstN", ValuesToUpdate(2))
                            Cmd.Parameters.AddWithValue("p_lastN", ValuesToUpdate(3))
                            Cmd.Parameters.AddWithValue("p_jer", ValuesToUpdate(4))
                            Cmd.Parameters.AddWithValue("p_pos", ValuesToUpdate(5))
                            Cmd.Parameters.AddWithValue("p_spos", ValuesToUpdate(6))
                            Cmd.Parameters.AddWithValue("p_h", ValuesToUpdate(7))
                            Cmd.Parameters.AddWithValue("p_birth", ValuesToUpdate(8))
                            Cmd.Parameters.AddWithValue("p_hisHome", ValuesToUpdate(9))
                            Cmd.Parameters.AddWithValue("p_hisAway", ValuesToUpdate(10))
                            Cmd.CommandText = "spUpdatePlayers"
                        ElseIf TableNum = 2 Then
                            Cmd.Parameters.AddWithValue("p_val1", ValuesToUpdate(1))
                            Cmd.Parameters.AddWithValue("p_val2", ValuesToUpdate(2))
                            Cmd.Parameters.AddWithValue("p_teamn", ValuesToUpdate(3))
                            Cmd.CommandText = "spUpdatePlayerRoution"
                        End If
                    Case "DrillWatch"
                        Cmd.Parameters.AddWithValue("p_dcode", ValuesToUpdate(1))
                        Cmd.Parameters.AddWithValue("p_grade", ValuesToUpdate(2))
                        Cmd.CommandText = "spUpdatePlayersGrades"
                End Select
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.ExecuteReader()
            End Using
        End Using
    End Sub
#End Region
#Region "פונקציה לעדכון נתונים בשתי טבלאות שאליהם הפורם מתייחס"
    Public Sub UpdatedTwoTables(ByVal frm As Form, ByVal ValuesToUpdate() As String, ByVal WhatToUpdate As String)
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Select Case frm.Name
                    Case "AdminsMain"
                        Select Case WhatToUpdate
                            Case "Games"
                                Cmd.Parameters.AddWithValue("p_code", ValuesToUpdate(0))
                                Cmd.Parameters.AddWithValue("p_theTime", ValuesToUpdate(1))
                                Cmd.Parameters.AddWithValue("p_theLoc", ValuesToUpdate(2))
                                Cmd.Parameters.AddWithValue("p_theType", ValuesToUpdate(3))
                                Cmd.Parameters.AddWithValue("p_hostC", ValuesToUpdate(4))
                                Cmd.Parameters.AddWithValue("p_visitC", ValuesToUpdate(5))
                                Cmd.Parameters.AddWithValue("p_theDate", ValuesToUpdate(6))
                                Cmd.CommandText = "spUpdateGameDetails"
                            Case "Teams"
                                Cmd.Parameters.AddWithValue("p_aC", ValuesToUpdate(1))
                                Cmd.Parameters.AddWithValue("p_hC", ValuesToUpdate(2))
                                Cmd.Parameters.AddWithValue("p_tN", ValuesToUpdate(0))
                                Cmd.Parameters.AddWithValue("p_a", ValuesToUpdate(3))
                                Cmd.CommandText = "spUpdateTeam"
                        End Select
                End Select
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.ExecuteReader()
            End Using
        End Using
    End Sub
#End Region
#Region "פונקציה למחיקת נתונים מטבלה שאליה הפורם מתייחס"
    Public Sub DeleteFromTable(ByVal frm As Form, ByVal DeleteKey As String)
        Using CN As MySqlConnection = New MySqlConnection(myCon.GetStringConnection())
            CN.Open()
            Using Cmd As MySqlCommand = New MySqlCommand()
                Cmd.Connection = CN
                Select Case frm.Name
                    Case "AdminsMain"
                        Cmd.Parameters.AddWithValue("p_code", DeleteKey)
                        Cmd.CommandText = "spDeletePlayer"
                End Select
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.ExecuteReader()
            End Using
        End Using
    End Sub
#End Region
#Region "Connection class"
    Private Class Connection
        Private builder As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder("Server=eu-cdbr-west-02.cleardb.net;User id=be32fff8fee904;Password=ffe3cd6c;Database=heroku_180799fcc7f54f4")
        Public Function GetStringConnection() As String
            Return Me.builder.ConnectionString()
        End Function
    End Class
#End Region
End Class
