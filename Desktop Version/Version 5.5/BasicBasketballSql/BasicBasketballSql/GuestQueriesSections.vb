Imports System.Reflection
Imports System.IO
Public Class GuestQueriesSections
    Private Cnt As Integer = 0
    Private Str1 As String = "#", Str2 As String = "#", Str3 As String = "#", Str4 As String = "#", FillColor As String = ""
    Private allLines As List(Of String) = New List(Of String)
#Region "פונקציות של הפורם"
    Private Sub GuestQueriesSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddButtons()
    End Sub
    Private Sub GuestQueriesSections_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        GuestMain.Show()
    End Sub
#End Region
#Region "פונקציות עזר"
    Private Sub AddButtons()
        If File.Exists("GuestColors.txt") = False Then
            File.Create("GuestColors.txt").Dispose() 'Dispose - בשביל לשחרר את כל התהליכים שהשתמשו ליצירת הקובץ על מנת לאפשר התחלת שימוש בו לאחר יצירתו
        End If
        Dim reader As New System.IO.StreamReader("GuestColors.txt")
        Dim xPos As Integer = 0, yPos As Integer = 0, checker As Integer = ReadData()
        Dim m_Rnd As New Random
        Dim btnArray(15) As Button 'הצרה על מערך של כפתורים
        If checker <> 0 Then 'קריאה לתוך רשימה את כל הצבעים שיש בקובץ
            Do While Not reader.EndOfStream
                allLines.Add(reader.ReadLine())
            Loop
            reader.Close()
        End If
        For i As Integer = 0 To 14
            btnArray(i) = New Button
            With (btnArray(i))
                .Tag = i + 1
                If checker = 0 Then
                    .ForeColor = Color.FromArgb(255, m_Rnd.Next(0, 256), m_Rnd.Next(0, 256), m_Rnd.Next(0, 256))
                Else
                    If (.Tag <= 4) Then
                        FillColor = ReadLine(1, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    ElseIf (.Tag >= 5) AndAlso ((.Tag <= 8)) Then
                        FillColor = ReadLine(2, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    ElseIf (.Tag >= 9) AndAlso ((.Tag <= 12)) Then
                        FillColor = ReadLine(3, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    ElseIf (.Tag >= 13) AndAlso ((.Tag <= 16)) Then
                        FillColor = ReadLine(4, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                End If
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 3
                .TextAlign = ContentAlignment.MiddleCenter
                .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                'מיקום הכפתורים:
                .Left = xPos
                .Top = yPos
                pnlButtons.Controls.Add(btnArray(i)) 'הוספת הכפתורים לפאנל שיציב אותם בתוכו
                xPos = xPos + .Width 'המיקום השמאלי של הכפתור הבא
                Select Case Lbl_Check.Text 'שמות הכפתורים בהתאם לעמוד שהמשתמש יעבור אליו
                    Case "1/3"
                        Dim Alphabet() As String = {"Height > 2.07", "Height <= 1.81", "Height == 2.01", _
                           "Height != 1.93, 1.98, 2.08 && Position != C, PF, SF", "Born In 29/12/1992", "Away Code >= 165 <= 185", _
                           "Jersey Num == 4", "Home Code >= 100 <= 120", "Jersey Num 1 Or 2", _
                           "Roution Code > 1 && Roution Code < 5", "Drill Grade > 84", "Drill >= 300 <= 500", _
                           "Game Code <= 10", "Games For 110 As Home Team", "Ashdod Arena Games"}
                        btnArray(i).Text = Alphabet(i)
                    Case "2/3"
                        Dim Alphabet() As String = {"Maccabi-FOX-Tel-Aviv Players", "Players In Hapoel Beer Sheva", "Total PG In Hapoel Holon", _
                           "Height Avg In Ashdod", "Height Sum In Jersualem", "12 Players From Gilboa", _
                           "Total SF In The League", "Max Jersey Num", "Min Roution Code", _
                           "Height Sum For C", "Height Average For All SG", "Games In 20:00", _
                           "Max Height && Min Height", "Players With Grade <= 55", "Max Grade && Min Grade"}
                        btnArray(i).Text = Alphabet(i)
                    Case "3/3"
                        Dim Alphabet() As String = {"Cnt Players In Each Team", "Max Height In Each Team", "Cnt Games In Each Hour", _
                           "Sum Height In Each Team", "Min Height In Each Team", "Avg Grade In Each Drills", _
                           "Avg Height In Each Team", "Sum Grade In Each Drill", "Max Height > 2.06", _
                           "Cnt Players In Each Position", "Max Grade In Each Drill", "Cnt Games In Each Location", _
                           "Players With Same JerseyNum", "Min Grade In Each Drill", "Cnt Games As Home Team For Each Team"}
                        btnArray(i).Text = Alphabet(i)
                End Select
                btnArray(i).AutoSize = True
                AddHandler btnArray(i).Click, AddressOf Me.ClickButton 'הוספת איוונט של לחיצה על כל כפתור במערך
            End With
        Next
    End Sub
    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = sender
        Me.Hide()
        GuestQueries.Lbl_Section.Text = Lbl_Check.Text.Substring(0, 1)
        GuestQueries.Lbl_WhatQuery.Text = btn.Text
        GuestQueries.Show()
    End Sub
    Private Sub CheckCnt()
        If Cnt = 4 Then
            Pic_SaveDesign.Visible = True
        Else
            Pic_SaveDesign.Visible = False
        End If
    End Sub
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function
    Private Function ReadData() As Integer
        RTB_Colors.Text = My.Computer.FileSystem.ReadAllText("GuestColors.txt")
        If RTB_Colors.Text = "" Then
            Return 0
        End If
        Return 1
    End Function
#End Region
#Region "אירועים בעת לחיצה על אחת מן התמונות שיש בפורם"
    Private Sub Pic_SaveDesign_Click(sender As Object, e As EventArgs) Handles Pic_SaveDesign.Click
        CB_1.Enabled = False
        CB_2.Enabled = False
        CB_3.Enabled = False
        CB_4.Enabled = False
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("GuestColors.txt", False) 'ברגע שיש false בכל פעם שהמשתמש ילחץ על לשמור את העיצוב מה שהיה מקודם בטקסט יעלם
        file.WriteLine(Str1)
        file.WriteLine(Str2)
        file.WriteLine(Str3)
        file.WriteLine(Str4)
        file.Close()
        file.Dispose()
        MsgBox("Your new design is being saved succesfully")
        Btn_Refresh.PerformClick()
    End Sub
    Private Sub Pic_ColorPic_Click(sender As Object, e As EventArgs) Handles Pic_ColorPic.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Btn_Example.ForeColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Pic_Help_Click(sender As Object, e As EventArgs) Handles Pic_Help.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_GuestQ")
        HelpForm.Show()
    End Sub
#End Region
#Region "אירועים בעת לחיצה על הכפתורים שיש בפורם"
    Private Sub Btn_PageMove_Click(sender As Object, e As EventArgs) Handles Btn_PageMove.Click
        If Lbl_Check.Text = "1/3" Then
            Lbl_Check.Text = "2/3"
        ElseIf Lbl_Check.Text = "2/3" Then
            Lbl_Check.Text = "3/3"
            Btn_PageMove.Text = "First page"
        ElseIf Lbl_Check.Text = "3/3" Then
            Btn_PageMove.Text = "Next page"
            Lbl_Check.Text = "1/3"
        End If
        Btn_Refresh.PerformClick()
    End Sub
    Private Sub Btn_LeaguePlayers_Click(sender As Object, e As EventArgs) Handles Btn_LeaguePlayers.Click
        Me.Hide()
        GuestQueries.Lbl_WhatQuery.Text = "All Players In The League"
        GuestQueries.Show()
    End Sub
    Private Sub Btn_LeagueTeams_Click(sender As Object, e As EventArgs) Handles Btn_LeagueTeams.Click
        Me.Hide()
        GuestQueries.Lbl_WhatQuery.Text = "All Teams In The League"
        GuestQueries.Show()
    End Sub
    Private Sub Btn_LeagueGames_Click(sender As Object, e As EventArgs) Handles Btn_LeagueGames.Click
        Me.Hide()
        GuestQueries.Lbl_WhatQuery.Text = "All Games In The League"
        GuestQueries.Show()
    End Sub
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        Me.Refresh()
        allLines.Clear()
        pnlButtons.Controls.Clear()
        AddButtons()
    End Sub
#End Region
#Region "איוונטים על התיבות סימון"
    Private Sub CB_1_CheckedChanged(sender As Object, e As EventArgs) Handles CB_1.CheckedChanged
        If CB_1.Checked = True Then
            Str1 = Str1 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            Cnt += 1
        Else
            Cnt -= 1
            Str1 = "#"
        End If
        CheckCnt()
    End Sub
    Private Sub CB_2_CheckedChanged(sender As Object, e As EventArgs) Handles CB_2.CheckedChanged
        If CB_2.Checked = True Then
            Str2 = Str2 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            Cnt += 1
        Else
            Cnt -= 1
            Str2 = "#"
        End If
        CheckCnt()
    End Sub
    Private Sub CB_3_CheckedChanged(sender As Object, e As EventArgs) Handles CB_3.CheckedChanged
        If CB_3.Checked = True Then
            Str3 = Str3 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            Cnt += 1
        Else
            Cnt -= 1
            Str3 = "#"
        End If
        CheckCnt()
    End Sub
    Private Sub CB_4_CheckedChanged(sender As Object, e As EventArgs) Handles CB_4.CheckedChanged
        If CB_4.Checked = True Then
            Str4 = Str4 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            Cnt += 1
        Else
            Cnt -= 1
            Str4 = "#"
        End If
        CheckCnt()
    End Sub
    Private Sub CB_FillAll_CheckedChanged(sender As Object, e As EventArgs) Handles CB_FillAll.CheckedChanged
        If CB_FillAll.Checked = True Then
            Str1 = Str1 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            Str2 = Str2 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            Str3 = Str3 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            Str4 = Str4 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            CB_1.Checked = True
            CB_2.Checked = True
            CB_3.Checked = True
            CB_4.Checked = True
        Else
            Str1 = "#"
            Str2 = "#"
            Str3 = "#"
            Str4 = "#"
            CB_1.Checked = False
            CB_2.Checked = False
            CB_3.Checked = False
            CB_4.Checked = False
        End If
        CheckCnt()
    End Sub
#End Region
End Class