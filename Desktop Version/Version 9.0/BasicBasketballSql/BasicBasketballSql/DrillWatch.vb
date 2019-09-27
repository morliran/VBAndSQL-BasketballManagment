Imports System.IO
Public Class DrillWatch
    Private Merror As MerrorControl = New MerrorControl()
    Private itemcoll(30) As String, TextFilesPath As String = Application.StartupPath & "/" & ClassCheckManager.GetManagerTeamName()
    Private TheDrillName As String = "Rebounding", Success As Integer = 1, Fail As Integer = 1
#Region "אופיציות של הפורם ופונקציות עזר"
    Private Sub DrillWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.SetPanelControlsEvents(Panel_Top, Me)
        ManagersMain.FillPlayersNamesBox(CB_PlayerCode, CB_PlayersName)
        LV_Pname = ManagersMain.GetDBHelper.FillListView(Me, LV_Pname, itemcoll, ClassCheckManager.GetHomeC())
        CB_PlayerCode.Font = New Font(CB_PlayerCode.Font.FontFamily.Name, 6)
        Accessibility.SetDesignToAllForms(Me)
        ClassCheckManager.SetSubFormsColors(Me)
    End Sub
    Private Sub DrillWatch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        ManagersMain.Show()
    End Sub
    Private Sub Panel_Left_Resize(sender As Object, e As EventArgs) Handles Panel_Left.Resize
        FLP_Menu.Location = New Point((Panel_Left.Width - FLP_Menu.Width) / 2, (Panel_Left.Height - FLP_Menu.Height) / 2)
    End Sub
    Private Sub CreateTeamPlayersFiles(ByVal Drillname As String)
        Dim PlayerName As String = String.Empty
        For i As Integer = 0 To LV_Pname.Items.Count - 1
            PlayerName = LV_Pname.Items.Item(i).Text.Substring(LV_Pname.Items.Item(i).Text.IndexOf("-") + 2)
            If Not File.Exists(TextFilesPath & "/" & Drillname & "/" & PlayerName & ".txt") Then 'יצירת קובץ טקסט לכל שחקן בקבוצה בתיקייה של התרגיל הנוכחי
                Using fs As FileStream = File.Create(TextFilesPath & "/" & Drillname & "/" & PlayerName & ".txt")
                End Using
            End If
        Next
    End Sub
    Private Sub WriteFileValues(ByVal SuccessValue As String)
        Dim CntFileLines As Integer = File.ReadAllLines(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt").Length
        If CntFileLines = 4 Then
            Using FWriter As StreamWriter = New StreamWriter(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt", False) 'ברגע שיש false בכל פעם שהמשתמש ילחץ על לשמור את הערך מה שהיה מקודם בטקסט יעלם
                FWriter.WriteLine(SuccessValue)
            End Using
        Else
            Using FWriter As StreamWriter = New StreamWriter(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt", True)
                FWriter.WriteLine(SuccessValue)
            End Using
        End If
        MsgBox("Your new record is being saved succesfully")
    End Sub
    Private Function CheckComplete() As Boolean
        If Val(Tb_SuccessVal.Text) + Val(Tb_TempFailVal.Text) >= Val(Tb_TriesVal.Text) Then
            Tb_TempFailVal.Visible = False
            Tb_FailVal.Visible = True
            Tb_FailVal.Text = Val(Tb_TriesVal.Text - Val(Tb_SuccessVal.Text))
            Btn_Success.Enabled = False
            Btn_Miss.Enabled = False
            Btn_Save.Visible = True
            Lbl_Made.Text = FormatPercent(Double.Parse(Tb_SuccessVal.Text / Tb_TriesVal.Text)) 'FormatPercent - פונקציה שיש בתוך שפת Visual basic שמעבירה את הפרמטר לייצוג באחוזים
            Lbl_Miss.Text = FormatPercent(Double.Parse((Tb_TriesVal.Text - Val(Tb_SuccessVal.Text)) / Tb_TriesVal.Text))
            Return True
        Else
            Btn_Save.Visible = False
            Return False
        End If
    End Function
    Private Function CheckRequirments() As Boolean
        Dim ArrControl() As Control = New Control() {Tb_TriesVal, CB_DrillTypesName, CB_Drillsname}
        If CB_PlayersName.Text.Equals("Player name") Or CB_DrillTypesName.Text.Equals("Drill category") Or CB_Drillsname.Text.Equals("Drill options") Or Tb_TriesVal.Text.Equals("How many attempts?") Or Tb_TriesVal.Text.Trim.Length = 0 Or String.IsNullOrEmpty(Tb_TriesVal.Text) Then
            Return False
        Else
            Merror.SetControlEnabling(ArrControl, False)
            Return True
        End If
    End Function
#End Region
#Region "איוונטים על האובייקטים של הפורם"
    Private Sub CB_PlayerCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PlayerCode.SelectedIndexChanged
        ManagersMain.GetDBHelper.ComboBoxSelectChange(Me, CB_PlayerCode, 3)
        CB_PlayerCode.Enabled = False
    End Sub
    Private Sub CB_PlayersName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PlayersName.SelectedIndexChanged
        Dim index As Integer = CB_PlayersName.SelectedIndex
        CB_PlayerCode.SelectedIndex = index
    End Sub
    Private Sub CB_DrillTypesName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_DrillTypesName.SelectedIndexChanged
        CB_Drillsname.Items.Clear()
        CB_Drillsname.Text = "Drill options"
        If CB_DrillTypesName.Text.Equals("Offense") Then
            CB_Drillsname.Items.Add("3PT")
            CB_Drillsname.Items.Add("Middle shot")
            CB_Drillsname.Items.Add("Close shot")
            CB_Drillsname.Items.Add("Free-Throws")
            CB_Drillsname.Items.Add("Offensive rebound")
        ElseIf CB_DrillTypesName.Text.Equals("Defense") Then
            CB_Drillsname.Items.Add("Steels")
            CB_Drillsname.Items.Add("Blocks")
            CB_Drillsname.Items.Add("Defensive rebound")
        Else
            CB_Drillsname.Items.Add("Assists")
        End If
    End Sub
    Private Sub CB_Drillsname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Drillsname.SelectedIndexChanged
        If CB_DrillTypesName.Text.Equals("Offense") Then
            If CB_Drillsname.Text.Equals("Offensive rebound") Then
                Lbl_DrillCode.Text = "500"
            Else
                TheDrillName = "Shooting"
                Lbl_DrillCode.Text = "300"
            End If
        ElseIf CB_DrillTypesName.Text.Equals("Defense") Then
            If CB_Drillsname.Text.Equals("Defensive rebound") Then
                Lbl_DrillCode.Text = "500"
            Else
                TheDrillName = "Defense"
                Lbl_DrillCode.Text = "400"
            End If
        Else
            TheDrillName = "Passing"
            Lbl_DrillCode.Text = "600"
        End If
        If Not Directory.Exists(ClassCheckManager.GetManagerTeamName() & "/" & TheDrillName) Then 'יצירת תיקיית התרגיל בתוך התיקייה של הקבוצה
            Directory.CreateDirectory(ClassCheckManager.GetManagerTeamName() & "/" & TheDrillName)
        End If
        CreateTeamPlayersFiles(TheDrillName)
    End Sub
#End Region
#Region "פעולות בעת לחיצה על כפתורים או תמונות שיש בפורם"
    Private Sub Btn_Success_Click(sender As Object, e As EventArgs) Handles Btn_Success.Click
        If CheckRequirments() = False Then
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Chart1.Series("Success").MarkerStyle = DataVisualization.Charting.MarkerStyle.None
        If Tb_TempFailVal.Text.Equals("0") Then
            Chart1.Series("Success").Points.AddXY(Success, Success)
        Else
            Chart1.Series("Success").Points.AddXY(Success, Fail)
            Tb_TempFailVal.Text = Fail
        End If
        Tb_SuccessVal.Text = Success
        Success += 1
        Fail += 1
        If CheckComplete() = True Then
            Exit Sub
        End If
    End Sub
    Private Sub Btn_Miss_Click(sender As Object, e As EventArgs) Handles Btn_Miss.Click
        If CheckRequirments() = False Then
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Chart1.Series("Failed").Points.AddXY(Success - 1, Fail)
        Chart1.Series("Success").MarkerStyle = DataVisualization.Charting.MarkerStyle.Star6
        Chart1.Series("Success").Points.AddXY(Success - 1, Fail)
        Tb_TempFailVal.Text = Fail
        Fail += 1
        If CheckComplete() = True Then
            Exit Sub
        End If
    End Sub
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_WatchD")
        HelpForm.Show()
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        WriteFileValues(Tb_SuccessVal.Text)
        Dim ArrCodes() As String = New String() {Lbl_Code.Text, Lbl_DrillCode.Text}
        Dim Sum As Integer = 0, NewGrade As Integer = 0, TheGrade As Integer = ManagersMain.GetDBHelper.GetCountResults("CountPlayerGrade", ArrCodes)
        Dim CntFileLines As Integer = File.ReadAllLines(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt").Length
        Using reader As StreamReader = New StreamReader(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt")
            If CntFileLines = 4 Then
                Do While Not reader.EndOfStream
                    Sum += Integer.Parse(reader.ReadLine())
                Loop
                If Sum > TheGrade Then
                    NewGrade = TheGrade + 1
                    ArrCodes = {Lbl_Code.Text, Lbl_DrillCode.Text, NewGrade.ToString()}
                    ManagersMain.GetDBHelper.UpdateTable(Me, ArrCodes)
                    MsgBox("Drill grade succesfully updated")
                End If
            End If
        End Using
        Btn_Reset.PerformClick()
    End Sub
    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        Dim ControlArr() As Control = New Control() {Btn_Miss, Btn_Success, CB_PlayerCode, Tb_TriesVal, CB_DrillTypesName, CB_Drillsname}
        Tb_TempFailVal.Text = "0"
        Tb_SuccessVal.Text = "0"
        Tb_TriesVal.Text = "How many attempts?"
        Lbl_Made.Text = "Made"
        Lbl_Miss.Text = "Miss"
        Merror.SetControlEnabling(ControlArr, True)
        Btn_Save.Visible = False
        Tb_FailVal.Visible = False
        Tb_TempFailVal.Visible = True
        Success = 1
        Fail = 1
        Chart1.Series("Success").Points.Clear()
        Chart1.Series("Failed").Points.Clear()
    End Sub
    Private Sub MenuButtons_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Save.MouseEnter, Btn_Reset.MouseEnter, Btn_Help.MouseEnter
        Dim btn As Button = sender
        btn.BackColor = btn.ForeColor
        btn.ForeColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub MenuButtons_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Save.MouseLeave, Btn_Reset.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = btn.BackColor
        btn.BackColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
End Class