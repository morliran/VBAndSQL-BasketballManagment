Imports System.IO
Imports Microsoft.Office.Interop 'בשביל לשמור את הטבלה כקובץ אקסל
Public Class TrackPlayers
    Private Merror As MerrorControl = New MerrorControl()
    Private ControlsArr() As Control = New Control() {}
    Private intHeight As Integer, Cnt As Integer = 1
#Region "פונקציות על הפורם"
    Private Sub TrackPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Merror.setWantsTime(False)
        Merror.setGroupBoxControlsEvents(GB_WToSearch, Me)
        Panel_SearchOp.BackColor = Color.FromArgb(100, Color.DarkGray)
        GB_WToSearch.BackColor = Color.FromArgb(100, Color.DarkGray)
        Me.BackgroundImage = ManagersMain.BackgroundImage
    End Sub
    Private Sub TrackPlayers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        ManagersMain.Show()
    End Sub
#End Region
#Region "אירועים של לחיצה על אחד מן הכפתורים שיש בפורם"
    Private Sub Btn_AddParameters_Click(sender As Object, e As EventArgs) Handles Btn_AddParameters.Click
        Cnt = Cnt + 1
        Select Case GetCnt()
            Case 2
                ControlsArr = {Lbl_P2, CB_P2, CB_PSign2, NumUpD_P2, CB_FuncP2}
                Merror.setControlsVisibilty(ControlsArr, True)
            Case 3
                ControlsArr = {Lbl_P3, CB_P3, CB_PSign3, NumUpD_P3, CB_FuncP3}
                Merror.setControlsVisibilty(ControlsArr, True)
            Case 4
                ControlsArr = {Lbl_P4, CB_P4, CB_PSign4, NumUpD_P4, CB_FuncP4}
                Merror.setControlsVisibilty(ControlsArr, True)
            Case 5
                ControlsArr = {Lbl_P5, CB_P5, CB_PSign5, NumUpD_P5, CB_FuncP5}
                Merror.setControlsVisibilty(ControlsArr, True)
        End Select
    End Sub
    Private Sub Btn_RemoveParameters_Click(sender As Object, e As EventArgs) Handles Btn_RemoveParameters.Click
        Cnt = Cnt - 1
        Select Case GetCnt()
            Case 1
                ControlsArr = {Lbl_P2, CB_P2, CB_PSign2, NumUpD_P2, CB_FuncP2}
                Merror.setControlsVisibilty(ControlsArr, False)
            Case 2
                ControlsArr = {Lbl_P3, CB_P3, CB_PSign3, NumUpD_P3, CB_FuncP3}
                Merror.setControlsVisibilty(ControlsArr, False)
            Case 3
                ControlsArr = {Lbl_P4, CB_P4, CB_PSign4, NumUpD_P4, CB_FuncP4}
                Merror.setControlsVisibilty(ControlsArr, False)
            Case 4
                ControlsArr = {Lbl_P5, CB_P5, CB_PSign5, NumUpD_P5, CB_FuncP5}
                Merror.setControlsVisibilty(ControlsArr, False)
        End Select
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
        For Each ctrl As Control In GB_WToSearch.Controls
            If ctrl.Visible = True AndAlso ctrl.Text = "" AndAlso Not TypeOf ctrl Is PictureBox Then
                Return 0
            End If
        Next
        Return 1
    End Function
    Private Function GetData(ByVal code As String) As DataView
        Dim SelectQry As String = "", t() As String = New String() {}
        If code = "1" Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString()}
        ElseIf code = "2" Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString()}
        ElseIf code = "3" Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString(), _
                 Lbl_OpP3.Text, Lbl_NameP3.Text, CB_PSign3.Text, NumUpD_P3.Value.ToString()}
        ElseIf code = "4" Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString(), _
                 Lbl_OpP3.Text, Lbl_NameP3.Text, CB_PSign3.Text, NumUpD_P3.Value.ToString(), _
                 Lbl_OpP4.Text, Lbl_NameP4.Text, CB_PSign4.Text, NumUpD_P4.Value.ToString()}
        ElseIf code = "5" Then
            t = {Lbl_OpP1.Text, Lbl_NameP1.Text, CB_PSign1.Text, NumUpD_P1.Value.ToString(), _
                 Lbl_OpP2.Text, Lbl_NameP2.Text, CB_PSign2.Text, NumUpD_P2.Value.ToString(), _
                 Lbl_OpP3.Text, Lbl_NameP3.Text, CB_PSign3.Text, NumUpD_P3.Value.ToString(), _
                 Lbl_OpP4.Text, Lbl_NameP4.Text, CB_PSign4.Text, NumUpD_P4.Value.ToString(), _
                 Lbl_OpP5.Text, Lbl_NameP5.Text, CB_PSign5.Text, NumUpD_P5.Value.ToString()}
        End If
        Return ManagersMain.getDBHelper.getTrackProc(t)
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
#Region "אירועים בעת לחיצה על אחת מן התמונות"
    Private Sub Pic_Start_Click(sender As Object, e As EventArgs) Handles Pic_Start.Click
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
            If res = 1 Then
                DataGridView1.DataSource = GetData("1")
            ElseIf res = 2 Then
                DataGridView1.DataSource = GetData("2")
            ElseIf res = 3 Then
                DataGridView1.DataSource = GetData("3")
            ElseIf res = 4 Then
                DataGridView1.DataSource = GetData("4")
            ElseIf res = 5 Then
                DataGridView1.DataSource = GetData("5")
            End If
        End If
        For Each rowheight As DataGridViewRow In DataGridView1.Rows ' משנה את גודל הdatagrid בהתאם לגודל הטבלה שהוחזרה מהdatabase '
            intHeight += rowheight.Height
        Next
        DataGridView1.Height = intHeight + 23
        If DataGridView1.RowCount >= 0 Then
            Pic_Start.Enabled = False
            CHB_AnotherTrack.Visible = True
        End If
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(1)
        HelpForm.SetSelectedNode("Node_TrackP")
        HelpForm.Show()
    End Sub
#End Region
#Region "אירוע בעת הלחיצה על תיבת הסימון לחיפוש נוסף"
    Private Sub CHB_AnotherTrack_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_AnotherTrack.CheckedChanged
        If DataGridView1.RowCount >= 0 Then
            DataGridView1.Columns.Clear()
            CHB_AnotherTrack.Checked = False
            CHB_AnotherTrack.Visible = False
            Pic_Start.Enabled = True
        End If
    End Sub
#End Region
#Region "אירוע בעת הלחיצה על התמונה של שמירת קובץ אקסל"
    Private Sub Pic_ExportExcel_Click(sender As Object, e As EventArgs) Handles Pic_ExportExcel.Click
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add()
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim i As Integer, j As Integer, k As Integer
        Try
            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)
                For i = 0 To DataGridView1.RowCount - 2
                    For j = 0 To DataGridView1.ColumnCount - 1
                        For k = 1 To DataGridView1.Columns.Count
                            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                        Next k
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
End Class