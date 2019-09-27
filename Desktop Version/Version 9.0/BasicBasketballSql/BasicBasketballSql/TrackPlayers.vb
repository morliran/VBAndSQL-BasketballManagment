﻿Imports System.IO
Imports Microsoft.Office.Interop 'בשביל לשמור את הטבלה כקובץ אקסל
Public Class TrackPlayers
    Private Merror As MerrorControl = New MerrorControl()
    Private ControlsArr() As Control = New Control() {}, Cnt As Integer = 1, FirstParamHeight = 0, LastParamHeight = 0, FlagGameType As Boolean = False
#Region "פונקציות על הפורם"
    Private Sub TrackPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.SetPanelControlsEvents(Panel_Parameters, Me)
        ManagersMain.GetDBHelper.FillBoxes(CB_Gametype, "Get all game types")
        Lbl_TrackWelcome.Text &= ClassCheckManager.GetManagerTeamName()
        Lbl_TrackWelcome.Location = New Point((Panel_Top.Width - Lbl_TrackWelcome.Width) / 2, (Panel_Top.Height - Lbl_TrackWelcome.Height) / 2)
        FirstParamHeight = Panel_Parameters.Height
        LastParamHeight = FirstParamHeight * 5 ' 5 -> The number of parameters
        Accessibility.SetDesignToAllForms(Me)
        ClassCheckManager.SetSubFormsColors(Me)
    End Sub
    Private Sub TrackPlayers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        ManagersMain.SetTeamPlayersTable()
        ManagersMain.Show()
    End Sub
    Private Sub Panel_Grid_Resize(sender As Object, e As EventArgs) Handles Panel_Grid.Resize
        DataGridView1.Location = New Point((Panel_Grid.Width - DataGridView1.Width) / 2, (Panel_Grid.Height - DataGridView1.Height) / 2)
    End Sub
    Private Sub CB_UntillGameType_CheckedChanged(sender As Object, e As EventArgs) Handles CB_UntillGameType.CheckedChanged
        CB_GameOper.Visible = Not CB_GameOper.Visible
        CB_Gametype.Visible = Not CB_Gametype.Visible
        CB_GameOper.Text = "Operant"
        CB_Gametype.Text = "Game type"
        FlagGameType = Not FlagGameType
    End Sub
#End Region
#Region "פונקציות עזר"
    Private Function GetCnt() As Integer
        If Cnt > 5 Then
            Cnt = 5
        ElseIf Cnt < 1 Then
            Cnt = 1
        End If
        Return Cnt
    End Function
    Private Function TextCheck() As Integer
        For Each ctrl As Control In Panel_Parameters.Controls
            If ctrl.Visible = True AndAlso (ctrl.Text.Equals("Category") Or ctrl.Text.Equals("Search") Or ctrl.Text.Equals("Operant") Or ctrl.Text.Equals("Game type")) Then
                Return 0
            End If
        Next
        Return 1
    End Function
    Private Function GetData(ByVal code As String) As DataView
        Dim t() As String = New String() {}
        If code.Equals("1") Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString()}
        ElseIf code.Equals("2") Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString()}
        ElseIf code.Equals("3") Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString(), _
                 Lbl_OpP3.Text, Lbl_NameP3.Text, CB_PSign3.Text, NumUpD_P3.Value.ToString()}
        ElseIf code.Equals("4") Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString(), _
                 Lbl_OpP3.Text, Lbl_NameP3.Text, CB_PSign3.Text, NumUpD_P3.Value.ToString(), _
                 Lbl_OpP4.Text, Lbl_NameP4.Text, CB_PSign4.Text, NumUpD_P4.Value.ToString()}
        ElseIf code.Equals("5") Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString(), _
                 Lbl_OpP3.Text, Lbl_NameP3.Text, CB_PSign3.Text, NumUpD_P3.Value.ToString(), _
                 Lbl_OpP4.Text, Lbl_NameP4.Text, CB_PSign4.Text, NumUpD_P4.Value.ToString(), _
                 Lbl_OpP5.Text, Lbl_NameP5.Text, CB_PSign5.Text, NumUpD_P5.Value.ToString()}
        End If
        Return ManagersMain.GetDBHelper.GetTrackProc(t, FlagGameType)
    End Function
    Private Sub GetNames()
        Dim Search() As String = New String() {CB_FuncP1.Text, CB_FuncP2.Text, CB_FuncP3.Text, CB_FuncP4.Text, CB_FuncP5.Text}
        Dim Str() As String = New String() {CB_P1.Text, CB_P2.Text, CB_P3.Text, CB_P4.Text, CB_P5.Text}
        For i As Integer = 0 To Search.Length - 1
            If Search(i).Contains("Sum") Then
                Search(i) = "Total"
            ElseIf Search(i).Contains("Avg") Then
                Search(i) = "Average"
            End If
        Next
        For j As Integer = 0 To Str.Length - 1
            Str(j) = Str(j).Replace("[", "")
            Str(j) = Str(j).Replace("]", "")
        Next
        Lbl_NameP1.Text = Search(0) + Str(0)
        Lbl_NameP2.Text = Search(1) + Str(1)
        Lbl_NameP3.Text = Search(2) + Str(2)
        Lbl_NameP4.Text = Search(3) + Str(3)
        Lbl_NameP5.Text = Search(4) + Str(4)
    End Sub
#End Region
#Region "אירועים של לחיצה על אחד מן הכפתורים שיש בפורם"
    Private Sub Btn_AddParameters_Click(sender As Object, e As EventArgs) Handles Btn_AddParameters.Click
        Cnt = Cnt + 1
        Select Case GetCnt()
            Case 2
                ControlsArr = {Lbl_P2, CB_P2, CB_PSign2, NumUpD_P2, CB_FuncP2}
                Merror.SetControlsVisibilty(ControlsArr, True)
            Case 3
                ControlsArr = {Lbl_P3, CB_P3, CB_PSign3, NumUpD_P3, CB_FuncP3}
                Merror.SetControlsVisibilty(ControlsArr, True)
            Case 4
                ControlsArr = {Lbl_P4, CB_P4, CB_PSign4, NumUpD_P4, CB_FuncP4}
                Merror.SetControlsVisibilty(ControlsArr, True)
            Case 5
                ControlsArr = {Lbl_P5, CB_P5, CB_PSign5, NumUpD_P5, CB_FuncP5}
                Merror.SetControlsVisibilty(ControlsArr, True)
        End Select
        If Panel_Parameters.Height <> LastParamHeight Then
            Panel_Parameters.Height += FirstParamHeight
        End If
    End Sub
    Private Sub Btn_RemoveParameters_Click(sender As Object, e As EventArgs) Handles Btn_RemoveParameters.Click
        Cnt = Cnt - 1
        Select Case GetCnt()
            Case 1
                ControlsArr = {Lbl_P2, CB_P2, CB_PSign2, NumUpD_P2, CB_FuncP2}
                Merror.SetControlsVisibilty(ControlsArr, False)
            Case 2
                ControlsArr = {Lbl_P3, CB_P3, CB_PSign3, NumUpD_P3, CB_FuncP3}
                Merror.SetControlsVisibilty(ControlsArr, False)
            Case 3
                ControlsArr = {Lbl_P4, CB_P4, CB_PSign4, NumUpD_P4, CB_FuncP4}
                Merror.SetControlsVisibilty(ControlsArr, False)
            Case 4
                ControlsArr = {Lbl_P5, CB_P5, CB_PSign5, NumUpD_P5, CB_FuncP5}
                Merror.SetControlsVisibilty(ControlsArr, False)
        End Select
        If Panel_Parameters.Height <> FirstParamHeight Then
            Panel_Parameters.Height -= FirstParamHeight
        End If
    End Sub
    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        Dim check As Integer = TextCheck(), res As Integer = GetCnt()
        Lbl_OpP1.Text = CB_FuncP1.Text & "(" & CB_P1.Text & ")"
        Lbl_OpP2.Text = CB_FuncP2.Text & "(" & CB_P2.Text & ")"
        Lbl_OpP3.Text = CB_FuncP3.Text & "(" & CB_P3.Text & ")"
        Lbl_OpP4.Text = CB_FuncP4.Text & "(" & CB_P4.Text & ")"
        Lbl_OpP5.Text = CB_FuncP5.Text & "(" & CB_P5.Text & ")"
        GetNames()
        If check = 0 Then
            MessageBox.Show("You have empty boxs", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            DataGridView1.DataSource = GetData(res.ToString())
            Lbl_TableRes.Visible = True
            Lbl_TableRes.Text &= DataGridView1.RowCount & " players that match to your tracking"
            Btn_Start.Enabled = False
            Btn_AnotherTrack.Enabled = True
            Btn_ExportExcel.Enabled = True
            ManagersMain.DesignDataGrid(DataGridView1)
        End If
    End Sub
    Private Sub Btn_AnotherTrack_Click(sender As Object, e As EventArgs) Handles Btn_AnotherTrack.Click
        If DataGridView1.RowCount >= 0 Then
            DataGridView1.Columns.Clear()
            Btn_AnotherTrack.Enabled = False
            Btn_ExportExcel.Enabled = False
            Btn_Start.Enabled = True
            Lbl_TableRes.Visible = False
            Lbl_TableRes.Text = "There are "
        End If
    End Sub
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_TrackP")
        HelpForm.Show()
    End Sub
    Private Sub Btn_ExportExcel_Click(sender As Object, e As EventArgs) Handles Btn_ExportExcel.Click
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add()
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim i As Integer, j As Integer, k As Integer
        Try
            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)
                For k = 0 To DataGridView1.ColumnCount - 1 'שמירת כל כותרות העמודות
                    xlWorkSheet.Cells(1, k + 1) = DataGridView1.Columns(k).HeaderText
                Next
                For i = 0 To DataGridView1.RowCount - 1 'שמירת הערכים של כל עמודה בשורה המתאימה
                    For j = 0 To DataGridView1.ColumnCount - 1
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next j
                Next i
                xlWorkSheet.Rows.Font.Name = "Arial"
                xlWorkSheet.Columns.EntireColumn.AutoFit() 'התאמת תוכן העמודות באקסל לתוכן של הטקסט
                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally 'שחרור כל המשאבים שהשתמשתי לצורך הוצאת הטבלה לקובץ אקסל
            xlWorkBook.Close()
            xlApp.Quit()
            xlApp = Nothing
            xlWorkBook = Nothing
            xlWorkSheet = Nothing
        End Try
    End Sub
#End Region
#Region "איוונטים של הכפתורים בתפריט"
    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs) Handles Btn_AddParameters.MouseEnter, Btn_RemoveParameters.MouseEnter, Btn_Start.MouseEnter, Btn_AnotherTrack.MouseEnter, Btn_Help.MouseEnter, Btn_ExportExcel.MouseEnter
        Dim btn As Button = sender
        btn.BackColor = btn.ForeColor
        btn.ForeColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles Btn_AddParameters.MouseLeave, Btn_RemoveParameters.MouseLeave, Btn_Start.MouseLeave, Btn_AnotherTrack.MouseLeave, Btn_Help.MouseLeave, Btn_ExportExcel.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = btn.BackColor
        btn.BackColor = Panel_Left.BackColor
        btn.Font = New Font(btn.Font.FontFamily.Name, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
End Class