Imports System.Reflection
Imports System.IO
Public Class GuestQueriesSections
    Private Sec As GuestSectionQuerysControl = New GuestSectionQuerysControl()
    Private Str1 As String = "#", Str2 As String = "#", Str3 As String = "#", Str4 As String = "#", FillColor As String = ""
    Private allLines As List(Of String) = New List(Of String)
    Private BtnClickCnt As Integer = 0, CheckBoxClickCnt As Integer = 0
    Private LineStringBuild As New System.Text.StringBuilder, SpaceStringBuild As New System.Text.StringBuilder
#Region "פונקציות של הפורם"
    Private Sub GuestQueriesSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cntChars As Integer = 0
        TB_Temp.Focus()
        AddButtons()
        For i As Integer = 0 To Lbl_FromWhereC.Text.Length - 1
            If Char.IsLetter(Lbl_FromWhereC.Text(i)) Then
                cntChars += 1
            End If
        Next
        While cntChars <> 0
            LineStringBuild.Append("_")
            SpaceStringBuild.Append(" ")
            cntChars -= 1
        End While
        Lbl_Lines.Text = LineStringBuild.ToString()
        Btn_ColorsDesign.Text &= SpaceStringBuild.ToString() & "▼"
    End Sub
    Private Sub GuestQueriesSections_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        GuestMain.Show()
    End Sub
#End Region
#Region "פונקציות עזר"
    Private Sub AddButtons()
        Dim checker As Integer, MaxWith As Integer = 0, m_Rnd As New Random, btn As Button = Nothing
        Dim Alphabet() As String = {}, arrayBtn As New List(Of Button)
        If File.Exists("GuestColors.txt") = False Then
            File.Create("GuestColors.txt").Dispose() 'Dispose - בשביל לשחרר את כל התהליכים שהשתמשו ליצירת הקובץ על מנת לאפשר התחלת שימוש בו לאחר יצירתו
        Else
            Dim reader As New System.IO.StreamReader("GuestColors.txt")
            checker = ReadData()
            If checker <> 0 Then 'קריאה לתוך רשימה את כל הצבעים שיש בקובץ
                Do While Not reader.EndOfStream
                    allLines.Add(reader.ReadLine())
                Loop
            End If
            reader.Close()
        End If
        For i As Integer = 0 To 14
            btn = New Button
            arrayBtn.Add(btn)
            With (arrayBtn(i))
                .Tag = i + 1
                If checker = 0 Then
                    .ForeColor = Color.FromArgb(255, m_Rnd.Next(0, 256), m_Rnd.Next(0, 256), m_Rnd.Next(0, 256))
                    Lbl_FromWhereC.Text = "Randomize colors"
                Else
                    Lbl_FromWhereC.Text = "Colors from text file"
                End If
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 3
                .TextAlign = ContentAlignment.MiddleCenter
                .Font = New Font("Century Gothic", 12, FontStyle.Bold)
                'הוספת הכפתורים לפאנל שיציב אותם בתוכו
                If (.Tag <= 4) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(1, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col1.Controls.Add(arrayBtn(i))
                ElseIf (.Tag >= 5) AndAlso ((.Tag <= 8)) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(2, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col2.Controls.Add(arrayBtn(i))
                ElseIf (.Tag >= 9) AndAlso ((.Tag <= 12)) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(3, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col3.Controls.Add(arrayBtn(i))
                ElseIf (.Tag >= 13) AndAlso ((.Tag <= 16)) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(4, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col4.Controls.Add(arrayBtn(i))
                End If
                Select Case Lbl_Check.Text 'שמות הכפתורים בהתאם לעמוד שהמשתמש יעבור אליו
                    Case "1/3"
                        Alphabet = {"Height > 2.07", "Height <= 1.81", "Height == 2.01", _
                           "Height != 1.93, 1.98, 2.08" & vbNewLine & "Position != C, PF, SF", "Born In 29/12/1992", "Away Code >= 165 <= 185", _
                           "Jersey Num == 4", "Home Code >= 100 <= 120", "Jersey Num 1 Or 2", _
                           "Roution Code > 1" & vbNewLine & "And Roution Code < 5", "Drill Grade > 84", "Drill >= 300 <= 500", _
                           "Game Code <= 10", "Games For 110" & vbNewLine & "As Home Team", "Ashdod Arena Games"}
                        arrayBtn(i).Text = Alphabet(i)
                    Case "2/3"
                        Alphabet = {"Maccabi-FOX-Tel-Aviv Players", "Players In Hapoel Beer Sheva", "Total PG In Hapoel Holon", _
                           "Height Avg In Ashdod", "Height Sum In Jersualem", "12 Players From Gilboa", _
                           "Total SF In The League", "Max Jersey Num", "Min Roution Code", _
                           "Height Sum For C", "Height Average For All SG", "Games In 20:00", _
                           "Max Height && Min Height", "Players With Grade <= 55", "Max Grade && Min Grade"}
                        arrayBtn(i).Text = Alphabet(i)
                    Case "3/3"
                        Alphabet = {"Cnt Players In Each Team", "Max Height In Each Team", "Cnt Games In Each Hour", _
                           "Sum Height In Each Team", "Min Height In Each Team", "Avg Grade In Each Drills", _
                           "Avg Height In Each Team", "Sum Grade In Each Drill", "Max Height > 2.06", _
                           "Cnt Players In Each Position", "Max Grade In Each Drill", "Cnt Games In Each Location", _
                           "Cnt Players With" & vbNewLine & "Same Jerseynumber", "Min Grade In Each Drill", "Cnt Games As Home Team" & vbNewLine & "For Each Team"}
                        arrayBtn(i).Text = Alphabet(i)
                End Select
                arrayBtn(i).AutoSize = True
                AddHandler arrayBtn(i).Click, AddressOf Me.ClickButton 'הוספת איוונט של לחיצה על כל כפתור במערך
            End With
        Next
        For Each flp As FlowLayoutPanel In TLP_Buttons.Controls.OfType(Of FlowLayoutPanel)()
            MaxWith = 0
            For Each c As Control In flp.Controls
                If c.Width > MaxWith Then
                    MaxWith = c.Width
                End If
            Next
            For Each ctrl As Control In flp.Controls
                ctrl.Size = New Size(MaxWith, ctrl.Height)
            Next
        Next
    End Sub
    Public Sub ClickButton(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = sender
        Lbl_WhatQuery.Text = btn.Text
    End Sub
    Private Sub CheckCnt()
        If CheckBoxClickCnt = 4 Then
            Btn_Save.Visible = True
        Else
            Btn_Save.Visible = False
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
#Region "איוונטים על הפאנלים"
    Private Sub TheTopPanel_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_PageOne.MouseEnter, Lbl_PageTwo.MouseEnter, Lbl_PageThree.MouseEnter
        Dim l As Label = sender
        l.ForeColor = Panel_Move.BackColor
        Panel_Move.Visible = True
        Panel_Move.Width = l.Width
        Panel_Move.Location = New Point(l.Location.X, l.Height + 4)
        Select Case l.Text
            Case "Basic info"
                Lbl_Check.Text = "1/3"
            Case "Teams info"
                Lbl_Check.Text = "2/3"
            Case "Others info"
                Lbl_Check.Text = "3/3"
        End Select
        Btn_Refresh.PerformClick()
    End Sub
    Private Sub TheTopPanel_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_PageOne.MouseLeave, Lbl_PageTwo.MouseLeave, Lbl_PageThree.MouseLeave
        Dim l As Label = sender
        l.ForeColor = Color.Black
        Panel_Move.Visible = False
        Panel_Move.Width = 18
    End Sub
    Private Sub TheFLPMenu_MouseEnter(sender As Object, e As EventArgs) Handles Btn_ColorsDesign.MouseEnter, Btn_Save.MouseEnter, Btn_Help.MouseEnter
        Dim btn As Button = sender
        btn.BackColor = ColorTranslator.FromHtml("#5BC4FB")
    End Sub
    Private Sub TheFLPMenu_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ColorsDesign.MouseLeave, Btn_Save.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.BackColor = Color.FromArgb(77, 77, 77)
    End Sub
#End Region
#Region "איוונטים בעת לחיצות על הכפתורים או התמונה של בחירת הצבע"
    Private Sub Btn_ColorsDesign_Click(sender As Object, e As EventArgs) Handles Btn_ColorsDesign.Click
        For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
            If chb.Checked = True Then
                chb.Checked = False
            End If
        Next
        If BtnClickCnt Mod 2 = 0 Then
            Btn_ColorsDesign.Text = "Colors" & SpaceStringBuild.ToString() & "▲"
            Panel_ColorsMenu.Visible = True
        Else
            Btn_ColorsDesign.Text = "Colors" & SpaceStringBuild.ToString() & "▼"
            Panel_ColorsMenu.Visible = False
        End If
        BtnClickCnt += 1
    End Sub
    Private Sub Pic_ColorPic_Click(sender As Object, e As EventArgs) Handles Pic_ColorPic.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Btn_Example.ForeColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim file As System.IO.StreamWriter
        For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
            chb.Enabled = False
        Next
        file = My.Computer.FileSystem.OpenTextFileWriter("GuestColors.txt", False) 'ברגע שיש false בכל פעם שהמשתמש ילחץ על לשמור את העיצוב מה שהיה מקודם בטקסט יעלם
        file.WriteLine(Str1)
        file.WriteLine(Str2)
        file.WriteLine(Str3)
        file.WriteLine(Str4)
        file.Dispose()
        file.Close()
        MsgBox("Your new design is being saved succesfully")
        Btn_ColorsDesign.PerformClick()
        Btn_Refresh.PerformClick()
    End Sub
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_GuestQ")
        HelpForm.Show()
    End Sub
    Private Sub Btn_LeaguePlayers_Click(sender As Object, e As EventArgs) Handles Btn_LeaguePlayers.Click
        Lbl_WhatQuery.Text = "All Players In The League"
    End Sub
    Private Sub Btn_LeagueTeams_Click(sender As Object, e As EventArgs) Handles Btn_LeagueTeams.Click
        Lbl_WhatQuery.Text = "All Teams In The League"
    End Sub
    Private Sub Btn_LeagueGames_Click(sender As Object, e As EventArgs) Handles Btn_LeagueGames.Click
        Lbl_WhatQuery.Text = "All Games In The League"
    End Sub
    Private Sub Btn_Refresh_Click(sender As Object, e As EventArgs) Handles Btn_Refresh.Click
        Me.Refresh()
        allLines.Clear()
        For Each Flp As FlowLayoutPanel In TLP_Buttons.Controls.OfType(Of FlowLayoutPanel)()
            Flp.Controls.Clear()
            Select Case Flp.Name
                Case "FLP_Col1"
                    Flp.Controls.Add(Lbl_Column1)
                Case "FLP_Col2"
                    Flp.Controls.Add(Lbl_Column2)
                Case "FLP_Col3"
                    Flp.Controls.Add(Lbl_Column3)
                Case "FLP_Col4"
                    Flp.Controls.Add(Lbl_Column4)
            End Select
        Next
        AddButtons()
        DataGridView1.Columns.Clear()
        DataGridView1.Visible = False
        Lbl_TableName.Text = ""
    End Sub
#End Region
#Region "תוצאות שמתקבלות בעת לחיצה על אחד מהכפתורים בפאנל של הכפתורים"
    Private Sub Lbl_WhatQuery_TextChanged(sender As Object, e As EventArgs) Handles Lbl_WhatQuery.TextChanged
        DataGridView1.Visible = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If Lbl_WhatQuery.Text = "Height > 2.07" Then
            Lbl_TableName.Text = "All Players That Have Height > 2.07"
            DataGridView1.DataSource = Sec.QueryAbove207()
        ElseIf Lbl_WhatQuery.Text = "Height <= 1.81" Then
            Lbl_TableName.Text = "All Players That Have Height <= 1.81"
            DataGridView1.DataSource = Sec.QueryLowerOrEqual181()
        ElseIf Lbl_WhatQuery.Text = "Height == 2.01" Then
            Lbl_TableName.Text = "All Players That Have Height = 2.01"
            DataGridView1.DataSource = Sec.QueryEqual201()
        ElseIf Lbl_WhatQuery.Text = "Height != 1.93, 1.98, 2.08" & vbNewLine & "Position != C, PF, SF" Then
            Lbl_TableName.Text = "All Players That Don't Have Height Equal To = 1.93, 1.98, 2.08" & vbNewLine & "And There Main Position Is'nt C, PF, SF"
            DataGridView1.DataSource = Sec.QueryNot6Types()
        ElseIf Lbl_WhatQuery.Text = "Born In 29/12/1992" Then
            Lbl_TableName.Text = "All Players That Was Born In 29/12/1992"
            DataGridView1.DataSource = Sec.QueryBornIn29121992()
        ElseIf Lbl_WhatQuery.Text = "Away Code >= 165 <= 185" Then
            Lbl_TableName.Text = "All Teams That Have Away Team Code Between 165 To 185"
            DataGridView1.DataSource = Sec.QueryAwayCode165To185()
        ElseIf Lbl_WhatQuery.Text = "Jersey Num == 4" Then
            Lbl_TableName.Text = "Jersey Number Equal To 4"
            DataGridView1.DataSource = Sec.QueryJerseynumber4()
        ElseIf Lbl_WhatQuery.Text = "Home Code >= 100 <= 120" Then
            Lbl_TableName.Text = "All Teams That Have Home Team Code Between 100 To 120"
            DataGridView1.DataSource = Sec.QueryHomeCode100To120()
        ElseIf Lbl_WhatQuery.Text = "Jersey Num 1 Or 2" Then
            Lbl_TableName.Text = "All Players That Have Jersey Number 1 Or 2"
            DataGridView1.DataSource = Sec.QueryJersey1Or2()
        ElseIf Lbl_WhatQuery.Text = "Roution Code > 1" & vbNewLine & "And Roution Code < 5" Then
            Lbl_TableName.Text = "All Players That Have Roution Code > 1 And Roution Code < 5"
            DataGridView1.DataSource = Sec.QueryRoutionBig1Low5()
        ElseIf Lbl_WhatQuery.Text = "Drill Grade > 84" Then
            Lbl_TableName.Text = "All Players That Have Grade Drill Above 84"
            DataGridView1.DataSource = Sec.QueryGradeAbove84()
        ElseIf Lbl_WhatQuery.Text = "Drill >= 300 <= 500" Then
            Lbl_TableName.Text = "Drill Name Between 300 To 500"
            DataGridView1.DataSource = Sec.QueryDrill300To500()
        ElseIf Lbl_WhatQuery.Text = "Game Code <= 10" Then
            Lbl_TableName.Text = "All The Games That Have Game Code Lower Or Equal To 10"
            DataGridView1.DataSource = Sec.QueryGameLOrE10()
        ElseIf Lbl_WhatQuery.Text = "Games For 110" & vbNewLine & "As Home Team" Then
            Lbl_TableName.Text = "All Home Games For Team That Have Home Code 110"
            DataGridView1.DataSource = Sec.QueryHomeGamesFor110()
        ElseIf Lbl_WhatQuery.Text = "Ashdod Arena Games" Then
            Lbl_TableName.Text = "All Games In Hakirya Ashdod"
            DataGridView1.DataSource = Sec.QueryHakiryaGames()
        End If
        ' Querys Section 2 '
        If Lbl_WhatQuery.Text = "Maccabi-FOX-Tel-Aviv Players" Then
            Lbl_TableName.Text = "All Maccabi-Fox-Tel-Aviv Players"
            DataGridView1.DataSource = Sec.QueryMacPlayers()
        ElseIf Lbl_WhatQuery.Text = "Players In Hapoel Beer Sheva" Then
            Lbl_TableName.Text = "Total Players Of Hapoel Beer Sheva-Bnei Shimon"
            DataGridView1.DataSource = Sec.QueryTotalPlayersOfHbs()
        ElseIf Lbl_WhatQuery.Text = "Total PG In Hapoel Holon" Then
            Lbl_TableName.Text = "Total Point Guards In Hapoel-Holon"
            DataGridView1.DataSource = Sec.QueryTotalPgInHolon()
        ElseIf Lbl_WhatQuery.Text = "Height Avg In Ashdod" Then
            Lbl_TableName.Text = "Height Average In Ashdod Team"
            DataGridView1.DataSource = Sec.QueryHighAvgAshdod()
        ElseIf Lbl_WhatQuery.Text = "Height Sum In Jersualem" Then
            Lbl_TableName.Text = "Height Sum In Jersualem"
            DataGridView1.DataSource = Sec.QueryHighSumJerusalem()
        ElseIf Lbl_WhatQuery.Text = "12 Players From Gilboa" Then
            Lbl_TableName.Text = "Gilboa Glil First 12 Players"
            DataGridView1.DataSource = Sec.QueryTop12GilboaPlayers()
        ElseIf Lbl_WhatQuery.Text = "Total SF In The League" Then
            Lbl_TableName.Text = "Total Small Forwards In The League"
            DataGridView1.DataSource = Sec.QueryTotalSfPosition()
        ElseIf Lbl_WhatQuery.Text = "Max Jersey Num" Then
            Lbl_TableName.Text = "Max Jersey Number In The League"
            DataGridView1.DataSource = Sec.QueryMaxJerNum()
        ElseIf Lbl_WhatQuery.Text = "Min Roution Code" Then
            Lbl_TableName.Text = "Min Roution Code In The League"
            DataGridView1.DataSource = Sec.QueryMinRouC()
        ElseIf Lbl_WhatQuery.Text = "Height Sum For C" Then
            Lbl_TableName.Text = "Sum Height For All Center In The League"
            DataGridView1.DataSource = Sec.QueryHeightSumForC()
        ElseIf Lbl_WhatQuery.Text = "Height Average For All SG" Then
            Lbl_TableName.Text = "Avg Height For All Shooting-Guards"
            DataGridView1.DataSource = Sec.QueryHeightAvgForSG()
        ElseIf Lbl_WhatQuery.Text = "Games In 20:00" Then
            Lbl_TableName.Text = "Total Games In 20:00 Hour"
            DataGridView1.DataSource = Sec.QueryTotalGameIn2000()
        ElseIf Lbl_WhatQuery.Text = "Max Height && Min Height" Then
            Lbl_TableName.Text = "Max And Min Height In The League"
            DataGridView1.DataSource = Sec.QueryMaxMinH()
        ElseIf Lbl_WhatQuery.Text = "Players With Grade <= 55" Then
            Lbl_TableName.Text = "Players With Grade Equal Or Lower From 55"
            DataGridView1.DataSource = Sec.QueryGBelowE55Players()
        ElseIf Lbl_WhatQuery.Text = "Max Grade && Min Grade" Then
            Lbl_TableName.Text = "Max And Min Grade In The League"
            DataGridView1.DataSource = Sec.QueryMaxMinGrade()
        End If
        'Querys Section 3'
        If Lbl_WhatQuery.Text = "Cnt Players In Each Team" Then
            Lbl_TableName.Text = "Total Players In Each Team"
            DataGridView1.DataSource = Sec.QueryPInEachTeam()
        ElseIf Lbl_WhatQuery.Text = "Sum Height In Each Team" Then
            Lbl_TableName.Text = "Height Sum In Each Team"
            DataGridView1.DataSource = Sec.QueryHeightSumInTeams()
        ElseIf Lbl_WhatQuery.Text = "Avg Height In Each Team" Then
            Lbl_TableName.Text = "Average Height In Each Team"
            DataGridView1.DataSource = Sec.QueryAvgHeightInTeams()
        ElseIf Lbl_WhatQuery.Text = "Cnt Players In Each Position" Then
            Lbl_TableName.Text = "Total Players In Each Position"
            DataGridView1.DataSource = Sec.QueryAPInEachPos()
        ElseIf Lbl_WhatQuery.Text = "Cnt Players With" & vbNewLine & "Same Jerseynumber" Then
            Lbl_TableName.Text = "Total Players Have Same Jerseynumber"
            DataGridView1.DataSource = Sec.QuerySameJersery()
        ElseIf Lbl_WhatQuery.Text = "Max Height In Each Team" Then
            Lbl_TableName.Text = "Max Height In Each Team"
            DataGridView1.DataSource = Sec.QueryMHeightInEachTeam()
        ElseIf Lbl_WhatQuery.Text = "Min Height In Each Team" Then
            Lbl_TableName.Text = "Min Height In Each Team"
            DataGridView1.DataSource = Sec.QueryMinHeightInEachTeam()
        ElseIf Lbl_WhatQuery.Text = "Sum Grade In Each Drill" Then
            Lbl_TableName.Text = "Sum Grades For Each Drills"
            DataGridView1.DataSource = Sec.QuerySumOfGrades()
        ElseIf Lbl_WhatQuery.Text = "Max Grade In Each Drill" Then
            Lbl_TableName.Text = "Max Grade For Each Drills"
            DataGridView1.DataSource = Sec.QueryMaxOfEachGrade()
        ElseIf Lbl_WhatQuery.Text = "Min Grade In Each Drill" Then
            Lbl_TableName.Text = "Min Grade For Each Drills"
            DataGridView1.DataSource = Sec.QueryMinOfEachGrade()
        ElseIf Lbl_WhatQuery.Text = "Cnt Games In Each Hour" Then
            Lbl_TableName.Text = "Total Games In Each Hour"
            DataGridView1.DataSource = Sec.QueryTGamesInEachHour()
        ElseIf Lbl_WhatQuery.Text = "Avg Grade In Each Drills" Then
            Lbl_TableName.Text = "Average In Each Drill"
            DataGridView1.DataSource = Sec.QueryAvgInEachGrade()
        ElseIf Lbl_WhatQuery.Text = "Max Height > 2.06" Then
            Lbl_TableName.Text = "Players That Have Max Height Above 2.06"
            DataGridView1.DataSource = Sec.QueryMaxHeightPlayersAbove206()
        ElseIf Lbl_WhatQuery.Text = "Cnt Games In Each Location" Then
            Lbl_TableName.Text = "Total Games In Each Location"
            DataGridView1.DataSource = Sec.QueryGamesInEachLoc()
        ElseIf Lbl_WhatQuery.Text = "Cnt Games As Home Team" & vbNewLine & "For Each Team" Then
            Lbl_TableName.Text = "Total Games As Home Team For Each Team"
            DataGridView1.DataSource = Sec.QueryTotalGamesAsHomeTeam()
        End If
        'Query section 4'
        Dim ArrCodes() As String = New String() {"", "", "", "", "", ""}
        If Lbl_WhatQuery.Text = "All Players In The League" Then
            DataGridView1.DataSource = GuestMain.getHelper().getDataView("Players", ArrCodes, 7)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Lbl_TableName.Text = Lbl_WhatQuery.Text
        ElseIf Lbl_WhatQuery.Text = "All Teams In The League" Then
            DataGridView1.DataSource = GuestMain.getHelper().getDataView("HomeTeam", ArrCodes, 7)
            DataGridView1.CurrentCell = Nothing 'פה אני מוודא ששום תא לא יסומן על מנת לאפשר מחיקת שורה אחרת תצא הודעה שגיאה
            DataGridView1.Rows(0).Visible = False
            Lbl_TableName.Text = Lbl_WhatQuery.Text
        ElseIf Lbl_WhatQuery.Text = "All Games In The League" Then
            ArrCodes = {"", ""}
            DataGridView1.DataSource = GuestMain.getHelper().getDataView("LeagueGames", ArrCodes)
            Lbl_TableName.Text = Lbl_WhatQuery.Text
        End If
    End Sub
#End Region
#Region "איוונטים על התיבות סימון"
    Private Sub CB_1_CheckedChanged(sender As Object, e As EventArgs) Handles CB_1.CheckedChanged
        If CB_1.Checked = True Then
            Str1 = Str1 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            CheckBoxClickCnt += 1
        Else
            CheckBoxClickCnt -= 1
            Str1 = "#"
        End If
        CheckCnt()
    End Sub
    Private Sub CB_2_CheckedChanged(sender As Object, e As EventArgs) Handles CB_2.CheckedChanged
        If CB_2.Checked = True Then
            Str2 = Str2 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            CheckBoxClickCnt += 1
        Else
            CheckBoxClickCnt -= 1
            Str2 = "#"
        End If
        CheckCnt()
    End Sub
    Private Sub CB_3_CheckedChanged(sender As Object, e As EventArgs) Handles CB_3.CheckedChanged
        If CB_3.Checked = True Then
            Str3 = Str3 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            CheckBoxClickCnt += 1
        Else
            CheckBoxClickCnt -= 1
            Str3 = "#"
        End If
        CheckCnt()
    End Sub
    Private Sub CB_4_CheckedChanged(sender As Object, e As EventArgs) Handles CB_4.CheckedChanged
        If CB_4.Checked = True Then
            Str4 = Str4 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            CheckBoxClickCnt += 1
        Else
            CheckBoxClickCnt -= 1
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
            For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
                If chb.Checked = False Then
                    chb.Checked = True
                End If
            Next
        Else
            Str1 = "#"
            Str2 = "#"
            Str3 = "#"
            Str4 = "#"
            For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
                If chb.Checked = True Then
                    chb.Checked = False
                End If
            Next
        End If
        CheckCnt()
    End Sub
    Private Sub TB_Temp_TextChanged(sender As Object, e As EventArgs) Handles TB_Temp.TextChanged
        TB_Temp.Clear()
    End Sub
    Private Sub RTB_Colors_MouseClick(sender As Object, e As MouseEventArgs) Handles RTB_Colors.MouseClick
        TB_Temp.Focus()
    End Sub
#End Region
End Class