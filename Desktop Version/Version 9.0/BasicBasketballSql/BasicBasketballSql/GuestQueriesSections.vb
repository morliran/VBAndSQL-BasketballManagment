Imports System.Reflection
Imports System.IO
Public Class GuestQueriesSections
    Private Sec As GuestSectionQuerysControl = New GuestSectionQuerysControl()
    Private Str1 As String = "#", Str2 As String = "#", Str3 As String = "#", Str4 As String = "#", FillColor As String = "", SectionChosen As String = ""
    Private allLines As List(Of String) = New List(Of String), BtnClickCnt As Integer = 0, CheckBoxClickCnt As Integer = 0, BtnTag As Integer = 0
    Private LineStringBuild As New System.Text.StringBuilder, SpaceStringBuild As New System.Text.StringBuilder
#Region "פונקציות של הפורם"
    Private Sub GuestQueriesSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cntChars As Integer = 0
        TB_Temp.Font = New Font(TB_Temp.Font.FontFamily.Name, 6)
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
        Accessibility.SetDesignToAllForms(Me)
    End Sub
    Private Sub GuestQueriesSections_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Me.Dispose()
        GuestMain.Show()
    End Sub
    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        GuestMain.DesignDataGrid(DataGridView1)
    End Sub
#End Region
#Region "פונקציות עזר"
    Private Sub AddButtons()
        Dim checker As Integer, MaxWith As Integer = 0, m_Rnd As New Random, btn As Button = Nothing
        Dim Alphabet() As String = {}, arrayBtn As New List(Of Button)
        If File.Exists("GuestColors.txt") = False Then
            Using fs As FileStream = File.Create("GuestColors.txt")
            End Using
        Else
            Using reader As StreamReader = New StreamReader("GuestColors.txt")
                checker = ReadData()
                If checker <> 0 Then 'קריאה של כל הצבעים שנמצאים בקובץ הטקסט
                    Do While Not reader.EndOfStream
                        allLines.Add(reader.ReadLine())
                    Loop
                End If
            End Using
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
                'הוספת הכפתורים לעמודות לפי הטאג שלהם
                If (.Tag <= 4) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(1, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col1.Controls.Add(arrayBtn(i))
                ElseIf (.Tag >= 5) AndAlso (.Tag <= 8) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(2, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col2.Controls.Add(arrayBtn(i))
                ElseIf (.Tag >= 9) AndAlso (.Tag <= 12) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(3, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col3.Controls.Add(arrayBtn(i))
                ElseIf (.Tag >= 13) AndAlso (.Tag <= 16) Then
                    If checker <> 0 Then
                        FillColor = ReadLine(4, allLines)
                        .ForeColor = ColorTranslator.FromHtml(FillColor)
                    End If
                    FLP_Col4.Controls.Add(arrayBtn(i))
                End If
                Select Case Lbl_Check.Text
                    Case "1/3"
                        Alphabet = {"Players Have Height > 2.07", "Players Have Height <= 1.81", "Players Have Height = 2.01", _
                           "Players Height != 1.93, 1.98, 2.08" & vbNewLine & "Position != C, PF, SF", "Players Born In 29/12/1992", "Away Team Code >= 165 <= 185", _
                           "Jersey Number == 4", "Home Code >= 100 <= 120", "Players Have" & vbNewLine & "Jersey Number 1 Or 2", _
                           "Players With Roution Code > 1 < 5", "Players Have Grade Drill > 84", "Drill Name Between 300 To 500", _
                           "All Games With Game Code <= 10", "Games For 110 As Home Team", "All Games In Hakirya Ashdod"}
                        arrayBtn(i).Text = Alphabet(i)
                        SectionChosen = "Basic"
                    Case "2/3"
                        Alphabet = {"All Maccabi-FOX-Tel-Aviv Players", "Total Players In Hapoel Beer Sheva", "Total PG In Hapoel Holon", _
                           "Height Avgerage In Ashdod", "Height Sum In Jersualem", "Gilboa Glil First 12 Players", _
                           "Total SF In The League", "Max Jersey Number In The League", "Min Roution Code In The League", _
                           "Height Sum For All C", "Height Average For All SG", "Total Games In 20:00", _
                           "Max And Min Height In The League", "Players With Grade <= 55", "Max And Min Grade In The League"}
                        arrayBtn(i).Text = Alphabet(i)
                        SectionChosen = "Teams"
                    Case "3/3"
                        Alphabet = {"Total Players In Each Team", "Height Sum In Each Team", "Average Height In Each Team", "Total Players In Each Position", "Max Height In Each Team", _
                            "Min Height In Each Team", "Grade Sum In Each Drill", "Max Grade In Each Drill", "Min Grade In Each Drill", "Total Games In Each Hour", _
                            "Average Grade In Each Drill", "Max Height > 2.06", "Total Games In Each Location", "Total Players With" & vbNewLine & "Same Jerseynumber", _
                            "Total Games As Home Team" & vbNewLine & "For Each Team"}
                        arrayBtn(i).Text = Alphabet(i)
                        SectionChosen = "Others"
                End Select
                arrayBtn(i).AutoSize = True
                AddHandler arrayBtn(i).Click, AddressOf Me.ClickButton 'הוספת איוונט של לחיצה על כל כפתור ברשימה
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
        BtnTag = Integer.Parse(btn.Tag)
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
        If RTB_Colors.Text.Equals("") Then
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
        Panel_Move.Location = New Point(l.Location.X, l.Height + 5)
        Select Case l.Text
            Case "Basic info"
                Lbl_Check.Text = "1/3"
            Case "Teams info"
                Lbl_Check.Text = "2/3"
            Case "Others info"
                Lbl_Check.Text = "3/3"
        End Select
        BtnTag = 0
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
        btn.ForeColor = ColorTranslator.FromHtml("#2BA5FF")
        btn.BackColor = ColorTranslator.FromHtml("#E8ECFC")
        btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Bold)
    End Sub
    Private Sub TheFLPMenu_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ColorsDesign.MouseLeave, Btn_Save.MouseLeave, Btn_Help.MouseLeave
        Dim btn As Button = sender
        btn.ForeColor = Color.Black
        btn.BackColor = FLP_Menu.BackColor
        btn.Font = New Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular)
    End Sub
#End Region
#Region "איוונטים בעת לחיצות על הכפתורים או התמונה של בחירת הצבע"
    Private Sub Btn_ColorsDesign_Click(sender As Object, e As EventArgs) Handles Btn_ColorsDesign.Click
        ResetCheckBoxes()
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
        For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
            chb.Enabled = False
        Next
        Using file As StreamWriter = New StreamWriter("GuestColors.txt", False) 'ברגע שיש false בכל פעם שהמשתמש ילחץ על לשמור את העיצוב מה שהיה מקודם בטקסט יעלם
            file.WriteLine(Str1)
            file.WriteLine(Str2)
            file.WriteLine(Str3)
            file.WriteLine(Str4)
        End Using
        MsgBox("Your new design is being saved succesfully")
        Btn_ColorsDesign.PerformClick()
        Btn_Refresh.PerformClick()
    End Sub
    Private Sub Btn_Help_Click(sender As Object, e As EventArgs) Handles Btn_Help.Click
        HelpForm.SetFormTag(2)
        HelpForm.SetSelectedNode("Node_GuestQ")
        HelpForm.Show()
    End Sub
    Private Sub LeagueInfo(sender As Object, e As EventArgs) Handles Btn_LeaguePlayers.Click, Btn_LeagueTeams.Click, Btn_LeagueGames.Click
        Dim btn As Button = sender, Str As String = ""
        Str = btn.Text.Substring(btn.Text.IndexOf(" ") + 1)
        Str = Str.Substring(0, 1).ToUpper() & Str.Substring(1).ToLower()
        Lbl_WhatQuery.Text = "All " & Str & " In The League"
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
        Lbl_WhatQuery.Text = ""
        Lbl_TableName.Text = "Click on the buttons to see the results"
        ResetCheckBoxes()
    End Sub
#End Region
#Region "תוצאות שמתקבלות בעת לחיצה על אחד מהכפתורים בפאנל של הכפתורים"
    Private Sub Lbl_WhatQuery_TextChanged(sender As Object, e As EventArgs) Handles Lbl_WhatQuery.TextChanged
        DataGridView1.Visible = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily.Name, DataGridView1.ColumnHeadersDefaultCellStyle.Font.Size, FontStyle.Bold)
        Lbl_TableName.Text = Lbl_WhatQuery.Text
        DataGridView1.Columns.Clear()
        If Not Lbl_WhatQuery.Text.Equals("All Players In The League") AndAlso
            Not Lbl_WhatQuery.Text.Equals("All Teams In The League") AndAlso
            Not Lbl_WhatQuery.Text.Equals("All Games In The League") AndAlso
            Not Lbl_WhatQuery.Text.Equals("Click on the buttons to see the results") Then
            DataGridView1.DataSource = Sec.QuerySections(SectionChosen, BtnTag)
        Else
            If Lbl_WhatQuery.Text.Equals("All Players In The League") Then
                DataGridView1.DataSource = Sec.QuerySections("League", 1)
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ElseIf Lbl_WhatQuery.Text.Equals("All Teams In The League") Then
                DataGridView1.DataSource = Sec.QuerySections("League", 2)
                DataGridView1.CurrentCell = Nothing
                DataGridView1.Rows(0).Visible = False
            ElseIf Lbl_WhatQuery.Text.Equals("All Games In The League") Then
                DataGridView1.DataSource = Sec.QuerySections("League", 3)
            End If
        End If
        GuestMain.DesignDataGrid(DataGridView1)
        DataGridView1.DefaultCellStyle.Font = New Font(DataGridView1.DefaultCellStyle.Font.FontFamily.Name, DataGridView1.DefaultCellStyle.Font.Size, FontStyle.Bold)
    End Sub
#End Region
#Region "איוונטים על התיבות סימון"
    Private Sub ResetCheckBoxes()
        For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
            chb.Checked = False
            chb.Enabled = True
        Next
    End Sub
    Private Sub CheckBoxCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CB_1.CheckedChanged, CB_2.CheckedChanged, CB_3.CheckedChanged, CB_4.CheckedChanged
        Dim MyCheck As CheckBox = sender
        If MyCheck.Checked = True Then
            CheckBoxClickCnt += 1
            Select Case MyCheck.Name
                Case "CB_1"
                    Str1 = Str1 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
                Case "CB_2"
                    Str2 = Str2 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
                Case "CB_3"
                    Str3 = Str3 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
                Case "CB_4"
                    Str4 = Str4 + Hex(Btn_Example.ForeColor.ToArgb()).Substring(2, 6)
            End Select
        Else
            CheckBoxClickCnt -= 1
            Select Case MyCheck.Name
                Case "CB_1"
                    Str1 = "#"
                Case "CB_2"
                    Str2 = "#"
                Case "CB_3"
                    Str3 = "#"
                Case "CB_4"
                    Str4 = "#"
            End Select
        End If
        CheckCnt()
    End Sub
    Private Sub CB_FillAll_CheckedChanged(sender As Object, e As EventArgs) Handles CB_FillAll.CheckedChanged
        If CB_FillAll.Checked = True Then
            For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
                chb.Checked = True
            Next
        Else
            For Each chb As CheckBox In Panel_ColorsMenu.Controls.OfType(Of CheckBox)()
                chb.Checked = False
            Next
        End If
        CheckCnt()
    End Sub
    Private Sub TB_Temp_TextChanged(sender As Object, e As EventArgs) Handles TB_Temp.TextChanged
        TB_Temp.Clear()
    End Sub
#End Region
End Class