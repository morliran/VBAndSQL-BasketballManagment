Imports System.IO
Public Class DrillWatch
    Private Merror As MerrorControl = New MerrorControl()
    Private itemcoll(30) As String, TextFilesPath As String = Application.StartupPath & "/" & ManagersMain.getManager.CheckTeam()
    Private TheDrillName As String = "Rebounding"
    Private Success As Integer = 1, Fail As Integer = 1
#Region "אופיציות של הפורם ופונקציות עזר"
    Private Sub DrillWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.setPanelControlsEvents(Panel_DW, Me)
        ManagersMain.getDBHelper.FillBoxes(CB_PlayerCode, ManagersMain.getManager.GetHomeCode(), 1)
        Panel_DW.Location = New Point((Me.Width - Panel_DW.Width) / 2, (Me.Height - Panel_DW.Height) / 2)
        LV_Pname = ManagersMain.getDBHelper.FillListView(Me, LV_Pname, itemcoll, ManagersMain.getManager.GetHomeCode())
    End Sub
    Private Sub DrillWatch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        ManagersMain.Show()
    End Sub
    Private Sub DrillWatch_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel_DW.Location = New Point((Me.Width - Panel_DW.Width) / 2, (Me.Height - Panel_DW.Height) / 2)
    End Sub
    Private Sub CreateTeamPlayersFiles(ByVal Drillname As String)
        Dim PlayerName As String = String.Empty
        For i As Integer = 0 To LV_Pname.Items.Count - 1
            PlayerName = LV_Pname.Items.Item(i).Text.Substring(LV_Pname.Items.Item(i).Text.IndexOf("-") + 2)
            If Not File.Exists(TextFilesPath & "/" & Drillname & "/" & PlayerName & ".txt") Then 'יצירת קובץ טקסט לכל שחקן בקבוצה בתיקייה של התרגיל הנוכחי
                File.Create(TextFilesPath & "/" & Drillname & "/" & PlayerName & ".txt").Dispose() 'Dispose - בשביל לשחרר את כל התהליכים שהשתמשו ליצירת הקובץ על מנת לאפשר התחלת שימוש בו לאחר יצירתו
            End If
        Next
    End Sub
    Private Sub WriteFileValues(ByVal SuccessValue As String)
        Dim FWriter As StreamWriter
        Dim CntFileLines As Integer = File.ReadAllLines(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt").Length
        If CntFileLines = 4 Then
            FWriter = My.Computer.FileSystem.OpenTextFileWriter(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt", False) 'ברגע שיש false בכל פעם שהמשתמש ילחץ על לשמור את הערך מה שהיה מקודם בטקסט יעלם
        Else
            FWriter = My.Computer.FileSystem.OpenTextFileWriter(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt", True)
        End If
        FWriter.WriteLine(SuccessValue)
        FWriter.Close()
        FWriter.Dispose()
        MsgBox("Your new record is being saved succesfully")
    End Sub
    Private Function CheckComplete() As Boolean
        If Val(Tb_SuccessVal.Text) + Val(Tb_TempFailVal.Text) >= NMB_DrillGoal.Value Then
            Tb_TempFailVal.Visible = False
            Tb_FailVal.Visible = True
            Tb_FailVal.Text = Val(NMB_DrillGoal.Value - Val(Tb_SuccessVal.Text))
            Btn_Success.Enabled = False
            Btn_Miss.Enabled = False
            Pic_Save.Visible = True
            Lbl_Made.Text = FormatPercent(Double.Parse(Tb_SuccessVal.Text / NMB_DrillGoal.Value)) 'FormatPercent - פונקציה שיש בתוך שפת Visual basic שמעבירה את הפרמטר לייצוג באחוזים
            Lbl_Miss.Text = FormatPercent(Double.Parse((NMB_DrillGoal.Value - Val(Tb_SuccessVal.Text)) / NMB_DrillGoal.Value))
            Return True
        Else
            Pic_Save.Visible = False
            Return False
        End If
    End Function
    Private Function CheckRequirments() As Boolean
        If CB_PlayerCode.Text = "Choice player code" Or CB_DrillTypesName.Text = "Drill category" Or CB_Drillsname.Text = "Drill options" Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#Region "איוונטים על האובייקטים של הפורם"
    Private Sub CB_PlayerCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PlayerCode.SelectedIndexChanged
        ManagersMain.getDBHelper.ComboBoxSelectChange(Me, CB_PlayerCode, 3)
        CB_PlayerCode.Enabled = False
    End Sub
    Private Sub CB_DrillTypesName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_DrillTypesName.SelectedIndexChanged
        CB_Drillsname.Items.Clear()
        CB_Drillsname.Text = "Drill options"
        If CB_DrillTypesName.Text = "Offense" Then
            CB_Drillsname.Items.Add("3PT")
            CB_Drillsname.Items.Add("Middle shot")
            CB_Drillsname.Items.Add("Close shot")
            CB_Drillsname.Items.Add("Free-Throws")
            CB_Drillsname.Items.Add("Offensive rebound")
        ElseIf CB_DrillTypesName.Text = "Defense" Then
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
        If Not Directory.Exists(ManagersMain.getManager.CheckTeam() & "/" & TheDrillName) Then 'יצירת תיקיית התרגיל בתוך התיקייה של הקבוצה
            Directory.CreateDirectory(ManagersMain.getManager.CheckTeam() & "/" & TheDrillName)
        End If
        CreateTeamPlayersFiles(TheDrillName)
    End Sub
#End Region
#Region "פעולות בעת לחיצה על כפתורים או תמונות שיש בפורם"
    Private Sub Btn_Success_Click(sender As Object, e As EventArgs) Handles Btn_Success.Click
        If CheckRequirments() = False Then
            MessageBox.Show("You have empty boxes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf NMB_DrillGoal.Value = "0" Then
            MessageBox.Show("Please insert value inside drill goal", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NMB_DrillGoal.Focus()
            Exit Sub
        End If
        Chart1.Series("Success").MarkerStyle = DataVisualization.Charting.MarkerStyle.None
        If Tb_TempFailVal.Text = "0" Then
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
        ElseIf NMB_DrillGoal.Value = "0" Then
            MessageBox.Show("Please insert value inside drill goal", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NMB_DrillGoal.Focus()
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
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_WatchD")
        HelpForm.Show()
    End Sub
    Private Sub Pic_Save_Click(sender As Object, e As EventArgs) Handles Pic_Save.Click
        WriteFileValues(Tb_SuccessVal.Text)
        Dim reader As StreamReader = New StreamReader(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt")
        Dim ArrCodes() As String = New String() {Lbl_Code.Text, Lbl_DrillCode.Text}
        Dim Sum As Integer = 0, TheGrade As Integer = ManagersMain.getDBHelper.getCountResults("CountPlayerGrade", ArrCodes)
        Dim CntFileLines As Integer = File.ReadAllLines(TextFilesPath & "/" & TheDrillName & "/" & Lbl_Name.Text & ".txt").Length
        If CntFileLines = 4 Then
            Do While Not reader.EndOfStream
                Sum += Integer.Parse(reader.ReadLine())
            Loop
            If Sum > TheGrade Then
                ArrCodes = {Lbl_Code.Text, Lbl_DrillCode.Text, Sum.ToString()}
                ManagersMain.getDBHelper.UpdateTable(Me, ArrCodes)
            End If
        End If
        reader.Close()
        Pic_Reset_Click(Me.Pic_Reset, EventArgs.Empty)
    End Sub
    Private Sub Pic_Reset_Click(sender As Object, e As EventArgs) Handles Pic_Reset.Click
        NMB_DrillGoal.Value = 0
        Tb_TempFailVal.Text = "0"
        Tb_SuccessVal.Text = "0"
        Lbl_Made.Text = "Made"
        Lbl_Miss.Text = "Miss"
        Btn_Miss.Enabled = True
        Btn_Success.Enabled = True
        CB_PlayerCode.Enabled = True
        Pic_Save.Visible = False
        Tb_FailVal.Visible = False
        Tb_TempFailVal.Visible = True
        Success = 1
        Fail = 1
        Chart1.Series("Success").Points.Clear()
        Chart1.Series("Failed").Points.Clear()
    End Sub
#End Region
End Class