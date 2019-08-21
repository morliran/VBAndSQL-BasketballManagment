Public Class LoginForm
    Private myHelper As MyDBControler = New MyDBControler()
    Private myError As MerrorControl = New MerrorControl()
    Private ManagerName As String = "", TeamName As String = "", HomeC As String = "", AwayC As String = "", itemcoll(30) As String
#Region "אופציות על הפורם"
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_Temp.Focus() 'Prevent type on user textbox while login panel is hidding
        Timer_Progress.Start()
    End Sub
    Private Sub LoginForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Panel_LSide.Top = (Me.ClientSize.Height / 2) - (Panel_LSide.Height / 2)
        Panel_LSide.Left = (Me.ClientSize.Width / 2) - (Panel_LSide.Width / 2)
    End Sub
    Public Sub ReturnToMe()
        Me.Show()
        Me.setManagerName("")
        Tb_UserName.Text = ""
        Tb_Password.Text = ""
        Lbl_LeadExplain.Text = ""
        Panel_Side.Width = 0
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        Timer_Progress.Start()
    End Sub
#End Region
#Region "פונקציית למילוי הרשימות של המובילים בכל קטוגוריה"
    Private Function FillListLeaders(ByVal MyList As ListView, ByVal Choice As String) As ListView
        MyList.Items.Clear()
        Return myHelper.FillListView(Me, MyList, itemcoll, Choice)
    End Function
#End Region
#Region "אירועים של הכפתורים והאיוונטים של תיבות הטקסט"
    Private Sub Btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Login.Click
        If Len(Trim(Tb_UserName.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_UserName.Focus()
            Exit Sub
        End If
        If Len(Trim(Tb_Password.Text)) = 0 Then
            MessageBox.Show("Please enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tb_Password.Focus()
            Exit Sub
        End If
        Timer_Progress.Stop() 'Must you to stop the connection to the database
        myHelper.getDBLogin(2)
    End Sub
    Private Sub Btn_RestTb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RestTb.Click
        Tb_UserName.Text = ""
        Tb_Password.Text = ""
        Tb_UserName.Focus()
    End Sub
    Private Sub Btn_Guest_Click(sender As Object, e As EventArgs) Handles Btn_Guest.Click
        Timer_Progress.Stop() 'Must you to stop the connection to the database
        Me.Hide()
        GuestMain.Show()
    End Sub
    Private Sub Btn_SignIn_Click(sender As Object, e As EventArgs) Handles Btn_SignIn.Click
        If Panel_Side.Width = 0 Then
            Timer_In_Menu.Start()
        Else
            Timer_Out_Menu.Start()
        End If
    End Sub
    Private Sub Timer_In_Menu_Tick(sender As Object, e As EventArgs) Handles Timer_In_Menu.Tick
        Panel_Side.Width = Panel_Side.Width + 10
        If Panel_Side.Width > Panel_Top.Width / 3 Then
            Tb_UserName.Focus()
            Timer_In_Menu.Stop()
        End If
    End Sub
    Private Sub Timer_Out_Menu_Tick(sender As Object, e As EventArgs) Handles Timer_Out_Menu.Tick
        Panel_Side.Width = Panel_Side.Width - 10
        If Panel_Side.Width = 0 Then
            Tb_UserName.Clear()
            Tb_Password.Clear()
            Timer_Out_Menu.Stop()
        End If
    End Sub
    Private Sub Btn_Accessibility_Click(sender As Object, e As EventArgs) Handles Btn_Accessibility.Click
        If Panel_Access.Height = 0 Then
            Timer_Up.Start()
        Else
            Timer_Down.Start()
        End If
    End Sub
    Private Sub Timer_Up_Tick(sender As Object, e As EventArgs) Handles Timer_Up.Tick
        Panel_Access.Height = Panel_Access.Height + 10
        If Panel_Access.Height > Panel_LSide.Height / 4 Then
            Timer_Up.Stop()
        End If
    End Sub
    Private Sub Timer_Down_Tick(sender As Object, e As EventArgs) Handles Timer_Down.Tick
        Panel_Access.Height = Panel_Access.Height - 10
        If Panel_Access.Height = 0 Then
            Timer_Down.Stop()
        End If
    End Sub
    Private Sub Timer_Progress_Tick(sender As Object, e As EventArgs) Handles Timer_Progress.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 1 Then
            Call FillListLeaders(LV_League, "MainP")
            Lbl_LeadExplain.Text = "Points leaders"
        ElseIf ProgressBar2.Value = 20 Then
            Call FillListLeaders(LV_League, "MainA")
            Lbl_LeadExplain.Text = "Assits leaders"
        ElseIf ProgressBar2.Value = 40 Then
            Call FillListLeaders(LV_League, "MainR")
            Lbl_LeadExplain.Text = "Rebounds leaders"
        ElseIf ProgressBar2.Value = 60 Then
            Call FillListLeaders(LV_League, "MainS")
            Lbl_LeadExplain.Text = "Steels leaders"
        ElseIf ProgressBar2.Value = 80 Then
            Call FillListLeaders(LV_League, "MainB")
            Lbl_LeadExplain.Text = "Blocks leaders"
        ElseIf ProgressBar2.Value = 100 Then
            ProgressBar2.Value = 0
        End If
    End Sub
    Private Sub Btn_FontProp_Click(sender As Object, e As EventArgs) Handles Btn_FontProp.Click
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Accessibility.FontName = FontDialog1.Font.Name
            Accessibility.FontSize = FontDialog1.Font.Size
            Accessibility.FontStyle = FontDialog1.Font.Style
            Lbl_FontNExp.Text = Accessibility.FontName
            Lbl_FontSExp.Text = Accessibility.FontSize
            Lbl_FontStyExp.Text = Accessibility.FontStyle.ToString()
        End If
    End Sub
    Private Sub Btn_FontC_Click(sender As Object, e As EventArgs) Handles Btn_FontC.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Accessibility.FontColor = ColorDialog1.Color
            Lbl_FontCExp.Text = Accessibility.FontColor.Name
        End If
    End Sub
    Private Sub CB_HelpLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_HelpLang.SelectedIndexChanged
        If CB_HelpLang.Text.Equals("Hebrew") Or CB_HelpLang.Text.Equals("English") Then
            Accessibility.Language = CB_HelpLang.Text
            Lbl_LangExp.Text = Accessibility.Language
        End If
    End Sub
    Private Sub Btn_SaveAccess_Click(sender As Object, e As EventArgs) Handles Btn_SaveAccess.Click
        Accessibility.SetTheDesign(Me.Controls)
    End Sub
    Private Sub Tb_UserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_UserName.KeyPress
        myError.isUpperLetter(e, Tb_UserName)
    End Sub
    Private Sub Tb_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_Password.KeyPress
        myError.isDigitVal(e, Tb_Password)
    End Sub
    Private Sub CB_HelpLang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_HelpLang.KeyPress
        myError.isUnvailed(e, CB_HelpLang)
    End Sub
    Private Sub Tb_Temp_TextChanged(sender As Object, e As EventArgs) Handles Tb_Temp.TextChanged
        Tb_Temp.Clear()
    End Sub
    Private Sub LV_League_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles LV_League.DrawSubItem
        'Because DarwOwner is set to True I must recreate the properties of the text that would be inside the ListView
        Dim b As New SolidBrush(Color.FromArgb(235, 220, 178))
        Try
            e.Graphics.FillRectangle(b, e.Bounds) 'Draw the new background color
            e.Graphics.DrawString(e.SubItem.Text, LV_League.Font, Brushes.Black, e.Bounds) 'Drawing the text
        Finally
            b.Dispose()
        End Try
    End Sub
#End Region
#Region "Getters And Setters"
    Public Sub setManagerName(ByVal name As String)
        Me.ManagerName = name
    End Sub
    Public Sub setManagerTeam(ByVal Tname As String)
        Me.TeamName = Tname
        Me.HomeC = myHelper.getColumn("HomeTeamCode", getManagerTeamName())
        Me.AwayC = myHelper.getColumn("AwayTeamCode", getManagerTeamName())
    End Sub
    Public Function getManagerName() As String
        Return ManagerName
    End Function
    Public Function getManagerTeamName() As String
        Return TeamName
    End Function
    Public Function getHomeCode() As String
        Return HomeC
    End Function
    Public Function getAwayCode() As String
        Return AwayC
    End Function
#End Region
End Class
