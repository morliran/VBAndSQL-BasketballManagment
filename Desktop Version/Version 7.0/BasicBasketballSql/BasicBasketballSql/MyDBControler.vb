Imports System.Data.SqlClient
Imports System.Data
Public Class MyDBControler
    Private C As Connection = New Connection()
    Private Ds As DataSet, Dtable As DataTable
    Private Rder As SqlDataReader = Nothing
    Private CN As SqlConnection = New SqlConnection(C.GetStringConnection())
    Private Cmd As SqlCommand = C.GetCommand()
#Region "שחרור כל המשאבים שנדרשו לקבלת הנתונים ממסד הנתונים"
    Private Sub CloseResources()
        If CN.State = ConnectionState.Open Then
            CN.Close()
        ElseIf Cmd.Parameters.Count <> 0 Then
            Cmd.Parameters.Clear()
        ElseIf Cmd IsNot Nothing Then
            Cmd.Dispose()
        ElseIf C.GetAdapter.SelectCommand.Parameters.Count <> 0 Then
            C.GetAdapter.SelectCommand.Parameters.Clear()
        ElseIf C.GetAdapter.SelectCommand IsNot Nothing Then
            C.GetAdapter.SelectCommand.Dispose()
        ElseIf C.GetAdapter IsNot Nothing Then
            C.GetAdapter.Dispose()
        End If
    End Sub
#End Region
#Region "פונקציה אשר משמשת להתחברות מערכת"
    Public Sub getDBLogin(ByVal val As Integer, Optional ByVal Name As String = "", Optional ByVal Details() As String = Nothing) 'Name is for add new team
        Dim PicName As String, i As Integer
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Cmd.Parameters.AddWithValue("@val", val)
            If val = 2 Then 'ערך 2 מציין התחברות למערכת
                Cmd.Parameters.AddWithValue("@code", Trim(LoginForm.Tb_UserName.Text))
                Cmd.Parameters.AddWithValue("@code2", Trim(LoginForm.Tb_Password.Text))
            End If
            Cmd.Parameters.AddWithValue("@code3", Name)
            Cmd.CommandText = "spLogin"
            Cmd.CommandType = CommandType.StoredProcedure
            Rder = Cmd.ExecuteReader()
            If Rder.HasRows Then
                Rder.Read()
            End If
            If Rder.HasRows = False Then
                MsgBox("Incorrent username or password try again...", MsgBoxStyle.Critical, "Login denied")
                LoginForm.Tb_UserName.Clear()
                LoginForm.Tb_Password.Clear()
                LoginForm.Tb_UserName.Focus()
            Else
                LoginForm.ProgressBar1.Visible = True
                LoginForm.ProgressBar1.Maximum = 5000
                LoginForm.ProgressBar1.Minimum = 0
                LoginForm.ProgressBar1.Value = 5
                LoginForm.ProgressBar1.Step = 1
                For i = 0 To 5000
                    LoginForm.ProgressBar1.PerformStep()
                Next
                If Rder.GetString(0) = "ADMIN" Then
                    LoginForm.Hide()
                    AdminsMain.Show()
                Else
                    ManagersMain.Lbl_ManagerCheck.Text = Rder.GetString(0)
                    LoginForm.setManagerName(Rder.GetString(0))
                    LoginForm.setManagerTeam(Rder.GetString(2))
                    PicName = Rder.GetString(2).Replace("-", "") 'התאמת שם הקבוצה לשם של התמונה
                    ManagersMain.Pic_Menu.Image = My.Resources.ResourceManager.GetObject(PicName)
                    LoginForm.Hide()
                    ManagersMain.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Rder.Close()
            CloseResources()
        End Try
    End Sub
#End Region
#Region "פונקציה שמחזירה מחרוזת ומשמשת לקבלת נתון מתוך עמודה מסויימת"
    Public Function getColumn(ByVal ColName As String, ByVal Str As String, Optional ByVal FrmName As String = "") As String 'This function return one column result as string
        Dim RecordVal As String = "NULL"
        Dim CN2 As SqlConnection = New SqlConnection(C.GetStringConnection())
        Dim Cmd2 As SqlCommand = C.GetCommand()
        Try
            CN2.Open()
            Cmd2 = New SqlCommand()
            Cmd2.Connection = CN2
            Cmd2.Parameters.AddWithValue("res", SqlDbType.VarChar)
            Cmd2.Parameters.AddWithValue("@code", Str)
            Cmd2.CommandText = "spGet" + ColName
            Cmd2.CommandType = CommandType.StoredProcedure
            RecordVal = Convert.ToString(Cmd2.ExecuteScalar())
            If FrmName = "Admins" Then 'כאן אני בעצם מאפשר למנהל הליגה להכניס נתונים לקבוצה מסויימת ע"י כך שאני משתמש בשם המשתמש של מנהל הקבוצה
                LoginForm.setManagerTeam(Str)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally 'שחרור המשאבים גם במקרה שיש שגיאה
            Cmd2.Parameters.Clear()
            Cmd2.Dispose()
            CN2.Close()
        End Try
        Return RecordVal
    End Function
#End Region
#Region "פונקציה שמחזירה מס' שלם אשר מייצג את הכמות הנדרשת, לדוגמא קבלת המס' המקסימאלי של קוד רוטציה בקבוצה מסויימת"
    Public Function getCountResults(ByVal CountSearchType As String, Optional ByVal arr() As String = Nothing) As Integer
        Dim RecordCount As Int32 = 0
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Cmd.Parameters.AddWithValue("res", SqlDbType.Int)
            Cmd.Parameters.AddWithValue("info", CountSearchType)
            If arr IsNot Nothing Then
                Cmd.Parameters.AddWithValue("val1", arr(0))
                Cmd.Parameters.AddWithValue("val2", arr(1))
            End If
            Cmd.CommandText = "spGetCounts"
            Cmd.CommandType = CommandType.StoredProcedure
            RecordCount = Convert.ToInt32(Cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            CloseResources()
        End Try
        Return RecordCount
    End Function
#End Region
#Region "פונקציה אשר ממלאה את תיבות הבחירה הדורשות מידע ממסד הנתונים"
    Public Sub FillBoxes(ByVal Combo As ComboBox, ByVal Searchval As String, Optional ByVal QueryCode As Integer = 0, Optional ByVal Combo2 As ComboBox = Nothing)
        Try
            Dim Drow As DataRow
            CN.Open()
            C.GetAdapter.SelectCommand = New SqlCommand()
            C.GetAdapter.SelectCommand.Connection = CN
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("val", Searchval)
            If QueryCode <> 0 Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("num", QueryCode)
            End If
            C.GetAdapter.SelectCommand.CommandText = "spQueryFillCombo"
            C.GetAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            Ds = New DataSet("ds")
            C.GetAdapter.Fill(Ds)
            Dtable = Ds.Tables(0)
            Combo.Items.Clear()
            If Combo2 IsNot Nothing Then
                Combo2.Items.Clear()
            End If
            For Each Drow In Dtable.Rows
                If QueryCode = 2 Then
                    Combo2.Items.Add(Drow(1).ToString())
                End If
                Combo.Items.Add(Drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseResources()
        End Try
    End Sub
#End Region
#Region "פונקציה אשר ממלאה את נתוני תיבות טקסט, תיבות מס' וכו'... באמצעות הערך שיש בתיבת הבחירה מוך מסד הנתונים"
    Public Sub ComboBoxSelectChange(frm As Form, ByVal Combo As ComboBox, ByVal val As Integer)
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Cmd.CommandText = "spGetSelected"
            Cmd.Parameters.AddWithValue("num", val)
            Cmd.Parameters.AddWithValue("find", Trim(Combo.Text))
            Cmd.CommandType = CommandType.StoredProcedure
            Rder = Cmd.ExecuteReader()
            If Rder.Read Then
                Select Case frm.Name
                    Case "AdminsMain"
                        If val = 1 Then
                            AdminsMain.Tb_Gametypeval.Text = getColumn("GameType", Rder.GetString(0))
                            AdminsMain.MTB_TimeVal.Text = Trim(Rder.GetString(1))
                            AdminsMain.Tb_Locationval.Text = Trim(Rder.GetString(2))
                            AdminsMain.MTB_GameDate.Text = Trim(Rder.GetString(4))
                            AdminsMain.Tb_HostersCval.Text = Trim(Rder.GetString(6))
                            AdminsMain.Tb_VisitorsCval.Text = Trim(Rder.GetString(7))
                        ElseIf val = 2 Then
                            AdminsMain.Tb_HcodeVal.Text = Trim(Rder.GetString(0))
                            AdminsMain.Tb_AcodeVal.Text = Trim(Rder.GetString(2))
                            AdminsMain.Tb_ArenaDetail.Text = Trim(Rder.GetString(3))
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
                        ManagersMain.MB_UDOB.Text = Trim(Rder.GetDateTime(8)) 'כדי לקבל את התאריך שמופיע במסד הנתונים'
                        ManagersMain.Tb_UHTC.Text = Trim(Rder.GetString(9))
                        ManagersMain.TB_UATC.Text = Trim(Rder.GetString(10))
                    Case "DrillWatch"
                        DrillWatch.Lbl_Code.Text = Trim(Rder.GetString(0))
                        DrillWatch.Lbl_Name.Text = Trim(Rder.GetString(2)) & " " & Trim(Rder.GetString(3))
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Rder.Close()
            CloseResources()
        End Try
    End Sub
#End Region
#Region "פונקציה שמחזירה ערך בוליאני אשר בודק האם קיים הערך שנמצא בתיבת הטקסט בתוך מסד הנתונים"
    Public Function TextBoxChangedText(frm As Form, ByVal Textb As TextBox) As Boolean
        Dim Flag As Boolean = False
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Select Case frm.Name
                Case "ManagersMain"
                    Cmd.CommandText = "spGetSelected"
                    Cmd.Parameters.AddWithValue("num", 3)
            End Select
            Cmd.Parameters.AddWithValue("find", Trim(Textb.Text))
            Cmd.CommandType = CommandType.StoredProcedure
            Rder = Cmd.ExecuteReader()
            If Rder.Read Then
                MessageBox.Show("Playercode Already Exists", "Save value error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Textb.Text = ""
                Rder.Close()
                CloseResources()
                Return False
            End If
            Flag = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Rder.Close()
            CloseResources()
        End Try
        Return Flag
    End Function
#End Region
#Region "פונקציה אשר מחזירה טבלה מתוך מסד הנתונים וממלאה אותה ואת תיבות הבחירה"
    Public Function FillDataTableAndBoxs(ByVal MyTable As DataTable, ByVal MyDs As DataSet, ByVal Combo As ComboBox, _
                                         ByVal Combo2 As ComboBox, ByVal Str As String, Optional ByVal TwoBoxes As Boolean = False) As DataTable
        Try
            Dim Drow As DataRow
            CN.Open()
            C.GetAdapter.SelectCommand = New SqlCommand()
            C.GetAdapter.SelectCommand.Connection = CN
            C.GetAdapter.SelectCommand.CommandText = "spGetSelected"
            If (Combo.Name = "CB_Playercode" AndAlso Combo2.Name = "CB_Playercode2") AndAlso TwoBoxes = True Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("num", 4)
            ElseIf (Combo.Name = "CB_Gametype" Or Combo.Name = "CB_Gametype2") AndAlso TwoBoxes = False Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("num", 5)
            ElseIf (Combo.Name = "CB_Temp" Or Combo.Name = "CB_Temp2") AndAlso TwoBoxes = False Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("num", 8)
            End If
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("find", Str)
            C.GetAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            C.GetAdapter.Fill(MyDs)
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseResources()
        End Try
        Return MyTable
    End Function
#End Region
#Region "פונקציה שממלאה את הגרפים שנמצאים בפורם של ההשוואות הסטטיסטיות בין השחקנים"
    Public Sub FillChartLabels(ByVal ChartName As System.Windows.Forms.DataVisualization.Charting.Chart, ByVal SeriesName As String, _
                     ByVal LabelArray() As Label, ByVal LabelsName() As String, ByVal MyTable As DataTable, ByVal arr() As String)
        Dim i As Integer
        Try
            CN.Open()
            C.GetAdapter.SelectCommand = New SqlCommand()
            C.GetAdapter.SelectCommand.Connection = CN
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("Gametypecode", arr(0))
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("Playercode", arr(1))
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("val", arr(2))
            C.GetAdapter.SelectCommand.CommandText = "spCompareStats"
            C.GetAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            C.GetAdapter.Fill(MyTable)
            If LabelArray IsNot Nothing Then
                For i = 0 To MyTable.Rows.Count - 1
                    'קליטת הערכים מתוך הטבלה ובהתאם לנתונים הגרף מתאים את עצמו
                    LabelArray(0).Text = (MyTable.Rows(i)(LabelsName(0)).ToString())
                    LabelArray(1).Text = (MyTable.Rows(i)(LabelsName(1)).ToString())
                    LabelArray(2).Text = (MyTable.Rows(i)(LabelsName(2)).ToString())
                    LabelArray(3).Text = (MyTable.Rows(i)(LabelsName(3)).ToString())
                    LabelArray(4).Text = (MyTable.Rows(i)(LabelsName(4)).ToString())
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
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
                                 ByVal Choice As String, Optional ByVal TableNum As Integer = 0) As ListView
        Dim SampleSource As New DataSet
        Dim i As Integer, j As Integer
        Try
            CN.Open()
            C.GetAdapter.SelectCommand = New SqlCommand()
            C.GetAdapter.SelectCommand.Connection = CN
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("find", Choice)
            Select Case frm.Name
                Case "LeagueLeaders"
                    C.GetAdapter.SelectCommand.CommandText = "spGetLeaders"
                Case "ManagersMain", "DrillWatch"
                    C.GetAdapter.SelectCommand.CommandText = "spGetSelected"
                    If frm.Name.Equals("ManagersMain") Then
                        If TableNum = 1 Then
                            C.GetAdapter.SelectCommand.Parameters.AddWithValue("num", 4)
                        ElseIf TableNum = 2 Then
                            C.GetAdapter.SelectCommand.CommandText = "spUpcomingBirthday"
                        End If
                    ElseIf frm.Name.Equals("DrillWatch") Then
                        C.GetAdapter.SelectCommand.Parameters.AddWithValue("num", 7)
                    End If
            End Select
            C.GetAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            C.GetAdapter.Fill(SampleSource)
            For i = 0 To SampleSource.Tables(0).Columns.Count - 1 'הוספת העמודות אל ה Listview
                myListView.Columns.Add(SampleSource.Tables(0).Columns(i).ColumnName.ToString())
            Next
            For i = 0 To SampleSource.Tables(0).Rows.Count - 1 'הוספת האיברים אל ה Listview
                For j = 0 To SampleSource.Tables(0).Columns.Count - 1
                    itemcoll(j) = SampleSource.Tables(0).Rows(i)(j).ToString()
                Next
                Dim lvi As New ListViewItem(itemcoll)
                myListView.Items.Add(lvi)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
        If frm.Name.Equals("LeagueLeaders") Then
            For i = 0 To myListView.Items.Count - 1
                myListView.Items(i).Text = (i + 1) & ". " & myListView.Items(i).Text
            Next
        End If
        For Each column As ColumnHeader In myListView.Columns
            column.Width = -1
        Next
        Return myListView
    End Function
#End Region
#Region "פונקציה שמחזירה מס' נתונים מתוך מסד הנתונים"
    Public Function getDataView(ByVal Str As String, ByVal arr() As String, Optional ByVal code As Integer = 0, _
                                Optional ByVal code2 As Integer = 0, Optional ByVal code3 As Integer = 0) As DataView
        Dim TableView As New DataView
        Dim SampleSource As New DataSet
        Try
            CN.Open()
            C.GetAdapter.SelectCommand = New SqlCommand()
            C.GetAdapter.SelectCommand.Connection = CN
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("info", Str)
            If code <> 0 Or code2 <> 0 Or code3 <> 0 Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("val1", arr(0))
            End If
            If code = 0 AndAlso code2 = 0 AndAlso code3 = 0 Then
                Select Case Str
                    Case "Jerseynum", "Height", "Position", "SecondPosition", "DOB", "LeagueGames", "MyTeamGames", "AwayOrHomeGames", "Ages", "Pgrades", "Vis", "SubsCode"
                        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val1", arr(0))
                        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val2", arr(1))
                        If Str = "Jerseynum" Or Str = "Height" Then
                            C.GetAdapter.SelectCommand.CommandText = "spBuildJerseyAndHeightDynamic"
                        ElseIf Str = "Position" Or Str = "SecondPosition" Then
                            C.GetAdapter.SelectCommand.CommandText = "spBuildPosAndSecondPosDynamic"
                        ElseIf Str = "DOB" Then
                            C.GetAdapter.SelectCommand.CommandText = "spBuildDOBDynamic"
                        ElseIf Str = "LeagueGames" Or Str = "MyTeamGames" Or Str = "AwayOrHomeGames" Or Str = "Ages" Or Str = "Pgrades" Or Str = "Vis" Or Str = "SubsCode" Then
                            C.GetAdapter.SelectCommand.CommandText = "spGetOthersMQuery"
                        End If
                    Case "CheckDate"
                        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val1", arr(0))
                        C.GetAdapter.SelectCommand.CommandText = "spCheckGameInDate"
                    Case "CheckPrevRes"
                        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val1", arr(0))
                        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val2", arr(1))
                        C.GetAdapter.SelectCommand.CommandText = "spGetPrevMatchRes"
                End Select
            ElseIf code <> 0 AndAlso code2 = 0 AndAlso code3 = 0 Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("op1", arr(1))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("search1", arr(2))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("typeOp", arr(3))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("op2", arr(4))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("search2", arr(5))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("code", code)
                C.GetAdapter.SelectCommand.CommandText = "spGetAllTablesDataDynamic"
            ElseIf code2 <> 0 AndAlso code3 = 0 AndAlso code = 0 Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("val2", arr(1))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("explain", arr(2))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("explain2", arr(3))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("search", arr(4))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("search2", arr(5))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("code", code2)
                C.GetAdapter.SelectCommand.CommandText = "spWhereMinMaxSumAvgCountFormatTablesDynamic"
            ElseIf code3 <> 0 AndAlso code2 = 0 AndAlso code = 0 Then
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("val2", arr(1))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("explain", arr(2))
                C.GetAdapter.SelectCommand.Parameters.AddWithValue("code", code3)
                C.GetAdapter.SelectCommand.CommandText = "spGroupByMinMaxSumAvgCountFormatTablesDynamic"
            End If
            C.GetAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            C.GetAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
        Return TableView
    End Function
#End Region
#Region "פונקציות המשמשות לאיתור שחקנים בפורום של חיפוש שחקנים לקבוצה"
    Private Sub ParamTwo(ByVal arr() As String)
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm4", arr(4))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm5", arr(5))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm6", arr(6))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val2", arr(7))
    End Sub
    Private Sub ParamThree(ByVal arr() As String)
        ParamTwo(arr)
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm7", arr(8))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm8", arr(9))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm9", arr(10))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val3", arr(11))
    End Sub
    Private Sub ParamFour(ByVal arr() As String)
        ParamThree(arr)
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm10", arr(12))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm11", arr(13))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm12", arr(14))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val4", arr(15))
    End Sub
    Private Sub ParamFive(ByVal arr() As String)
        ParamFour(arr)
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm13", arr(16))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm14", arr(17))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm15", arr(18))
        C.GetAdapter.SelectCommand.Parameters.AddWithValue("val5", arr(19))
    End Sub
    Public Function getTrackProc(ByVal arr() As String) As DataView
        Dim TableView As New DataView
        Dim SampleSource As New DataSet
        Try
            CN.Open()
            C.GetAdapter.SelectCommand = New SqlCommand()
            C.GetAdapter.SelectCommand.Connection = CN
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm1", arr(0))
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm2", arr(1))
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("cm3", arr(2))
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("val", arr(3))
            If arr.Length = 8 Then
                ParamTwo(arr)
            ElseIf arr.Length = 12 Then
                ParamThree(arr)
            ElseIf arr.Length = 16 Then
                ParamFour(arr)
            ElseIf arr.Length = 20 Then
                ParamFive(arr)
            End If
            C.GetAdapter.SelectCommand.Parameters.AddWithValue("lengthP", arr.Length * 0.25) 'For optimize running I prefer to multipy by 0.25 instead of divide by 4
            C.GetAdapter.SelectCommand.CommandText = "spTrackPlayers"
            C.GetAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            C.GetAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
        Return TableView
    End Function
#End Region
#Region "פונקציה להכנסת נתונים שנמצאים בפורם מסויים אל טבלה שאליה הוא מתייחס"
    Public Sub InsertToTable(ByVal frm As Form)
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Select Case frm.Name
                Case "PlayersMatchStatistics"
                    Cmd.Parameters.AddWithValue("@d1", Trim(PlayersMatchStatistics.CB_PlayerMatchCode.Text))
                    Cmd.Parameters.AddWithValue("@d2", Trim(PlayersMatchStatistics.TB_GamesCodes.Text))
                    Cmd.Parameters.AddWithValue("@d3", Trim(PlayersMatchStatistics.Tb_GamesTypes.Text))
                    Cmd.Parameters.AddWithValue("@d4", Trim(PlayersMatchStatistics.Tb_GamesDate.Text))
                    Cmd.Parameters.AddWithValue("@d5", Trim(PlayersMatchStatistics.Tb_Points.Text))
                    Cmd.Parameters.AddWithValue("@d6", Trim(PlayersMatchStatistics.Tb_Assist.Text))
                    Cmd.Parameters.AddWithValue("@d7", Trim(PlayersMatchStatistics.Tb_Rebound.Text))
                    Cmd.Parameters.AddWithValue("@d8", Trim(PlayersMatchStatistics.Tb_Steel.Text))
                    Cmd.Parameters.AddWithValue("@d9", Trim(PlayersMatchStatistics.Tb_Block.Text))
                    Cmd.Parameters.AddWithValue("@d10", Trim(PlayersMatchStatistics.Tb_TeamsNames.Text))
                    Cmd.CommandText = "spInsertStats"
                Case "ManagersMain"
                    Cmd.Parameters.AddWithValue("@d1", Trim(ManagersMain.Tb_PlayerCode.Text))
                    Cmd.Parameters.AddWithValue("@d2", Trim(ManagersMain.Tb_APID.Text))
                    Cmd.Parameters.AddWithValue("@d3", Trim(ManagersMain.Tb_AFN.Text))
                    Cmd.Parameters.AddWithValue("@d4", Trim(ManagersMain.Tb_ALN.Text))
                    Cmd.Parameters.AddWithValue("@d5", Trim(ManagersMain.Tb_AJN.Text))
                    Cmd.Parameters.AddWithValue("@d6", Trim(ManagersMain.CB_APosition.Text))
                    Cmd.Parameters.AddWithValue("@d7", Trim(ManagersMain.CB_ASPosition.Text))
                    Cmd.Parameters.AddWithValue("@d8", Trim(ManagersMain.MB_AHeight.Text))
                    Cmd.Parameters.Add(New SqlParameter("@d9", SqlDbType.Date, 10, "Dateofbirth")) 'Because I am saving this value as DATE in the database i have to declare this type
                    Cmd.Parameters("@d9").Value = Trim(ManagersMain.MB_ADOB.Text)
                    Cmd.Parameters.AddWithValue("@d10", Trim(ManagersMain.Tb_AHTC.Text))
                    Cmd.Parameters.AddWithValue("@d11", Trim(ManagersMain.TB_AATC.Text))
                    Cmd.Parameters.AddWithValue("@d12", Trim(ManagersMain.Tb_RoutionCVal.Text))
                    Cmd.Parameters.AddWithValue("@d13", Trim(ManagersMain.Lbl_ManTeam.Text))
                    Cmd.CommandText = "spInsertPlayers"
            End Select
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
    End Sub
#End Region
#Region "פונקציה להכנסת נתונים לשתי טבלאות שאליהם הפורם מתייחס"
    Public Sub InsertToTwoTables(frm As Form, ByVal Str As String)
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Select Case frm.Name
                Case "AdminsMain"
                    Select Case Str
                        Case "AddGames"
                            Cmd.Parameters.AddWithValue("@d1", Trim(AdminsMain.CB_GameCode.Text))
                            Cmd.Parameters.AddWithValue("@d2", Trim(AdminsMain.MTB_TimeVal.Text))
                            Cmd.Parameters.AddWithValue("@d3", Trim(AdminsMain.Tb_Locationval.Text))
                            Cmd.Parameters.AddWithValue("@d4", Trim(AdminsMain.Tb_Gametypeval.Text))
                            Cmd.Parameters.AddWithValue("@d5", Trim(AdminsMain.Tb_HostersCval.Text))
                            Cmd.Parameters.AddWithValue("@d6", Trim(AdminsMain.Tb_VisitorsCval.Text))
                            Cmd.Parameters.AddWithValue("@d7", Trim(AdminsMain.MTB_GameDate.Text))
                            Cmd.CommandText = "spInsertGameDetails"
                        Case "AddTeams"
                            Cmd.Parameters.AddWithValue("@aC", Trim(AdminsMain.Tb_AcodeVal.Text))
                            Cmd.Parameters.AddWithValue("@hC", Trim(AdminsMain.Tb_HcodeVal.Text))
                            Cmd.Parameters.AddWithValue("@tN", Trim(AdminsMain.Tb_TeamN.Text))
                            Cmd.Parameters.AddWithValue("@a", Trim(AdminsMain.Tb_ArenaDetail.Text))
                            Cmd.CommandText = "spInsertTeam"
                    End Select
            End Select
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
    End Sub
#End Region
#Region "פונקציה לעדכון נתונים בטבלה שאליה הפורם מתייחס"
    Public Sub UpdateTable(ByVal frm As Form, ByVal arr() As String, Optional ByVal TableNum As Integer = 0)
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Cmd.Parameters.AddWithValue("pcode", arr(0))
            Select Case frm.Name
                Case "PlayersMatchStatistics"
                    Cmd.Parameters.AddWithValue("gcode", arr(1))
                    Cmd.Parameters.AddWithValue("gtcode", arr(2))
                    Cmd.Parameters.AddWithValue("dcode", arr(3))
                    Cmd.Parameters.AddWithValue("tname", arr(4))
                    Cmd.Parameters.AddWithValue("p", arr(5))
                    Cmd.Parameters.AddWithValue("a", arr(6))
                    Cmd.Parameters.AddWithValue("r", arr(7))
                    Cmd.Parameters.AddWithValue("s", arr(8))
                    Cmd.Parameters.AddWithValue("b", arr(9))
                    Cmd.CommandText = "spUpdatePlayerStats"
                Case "ManagersMain"
                    If TableNum = 1 Then
                        Cmd.Parameters.AddWithValue("@pidcode", arr(1))
                        Cmd.Parameters.AddWithValue("@firstN", arr(2))
                        Cmd.Parameters.AddWithValue("@lastN", arr(3))
                        Cmd.Parameters.AddWithValue("@jer", arr(4))
                        Cmd.Parameters.AddWithValue("@pos", arr(5))
                        Cmd.Parameters.AddWithValue("@spos", arr(6))
                        Cmd.Parameters.AddWithValue("@h", arr(7))
                        Cmd.Parameters.Add(New SqlParameter("@birth", SqlDbType.Date, 10, "Dateofbirth")) 'Because i am saving this value as DATE in the database i have to declare this type
                        Cmd.Parameters("@birth").Value = arr(8)
                        Cmd.Parameters.AddWithValue("@hisHome", arr(9))
                        Cmd.Parameters.AddWithValue("@hisAway", arr(10))
                        Cmd.CommandText = "spUpdatePlayers"
                    ElseIf TableNum = 2 Then
                        Cmd.Parameters.AddWithValue("val1", arr(1))
                        Cmd.Parameters.AddWithValue("val2", arr(2))
                        Cmd.Parameters.AddWithValue("teamn", arr(3))
                        Cmd.CommandText = "spUpdatePlayerRoution"
                    End If
                Case "DrillWatch"
                    Cmd.Parameters.AddWithValue("dcode", arr(1))
                    Cmd.Parameters.AddWithValue("grade", arr(2))
                    Cmd.CommandText = "spUpdatePlayersGrades"
            End Select
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
    End Sub
#End Region
#Region "פונציה לעדכון נתונים בשתי טבלאות שאליהם הפורום מתייחס"
    Public Sub UpdatedTwoTables(frm As Form, ByVal arr() As String, ByVal Str As String)
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Select Case frm.Name
                Case "AdminsMain"
                    Select Case Str
                        Case "Games"
                            Cmd.Parameters.AddWithValue("code", arr(0))
                            Cmd.Parameters.AddWithValue("theTime", arr(1))
                            Cmd.Parameters.AddWithValue("theLoc", arr(2))
                            Cmd.Parameters.AddWithValue("theType", arr(3))
                            Cmd.Parameters.AddWithValue("hostC", arr(4))
                            Cmd.Parameters.AddWithValue("visitC", arr(5))
                            Cmd.Parameters.AddWithValue("theDate", arr(6))
                            Cmd.CommandText = "spUpdateGameDetails"
                        Case "Teams"
                            Cmd.Parameters.AddWithValue("aC", arr(1))
                            Cmd.Parameters.AddWithValue("hC", arr(2))
                            Cmd.Parameters.AddWithValue("tN", arr(0))
                            Cmd.Parameters.AddWithValue("a", arr(3))
                            Cmd.CommandText = "spUpdateTeam"
                    End Select
            End Select
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
    End Sub
#End Region
#Region "פונצקיה למחיקת נתונים מטבלה שאליה הפורם מתייחס"
    Public Sub DeleteFromTable(ByVal frm As Form, ByVal value As String)
        Try
            CN.Open()
            Cmd = New SqlCommand()
            Cmd.Connection = CN
            Select Case frm.Name
                Case "AdminsMain"
                    Cmd.Parameters.AddWithValue("code", value)
                    Cmd.CommandText = "spDeletePlayer"
            End Select
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseResources()
        End Try
    End Sub
#End Region
End Class
