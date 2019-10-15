Public Class MainView
    Private myHelper As MyDBControler = New MyDBControler(), myError As MerrorControl = New MerrorControl()
#Region "אופציות על הפורם"
    Private Sub MainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_Temp.Font = New Font(Tb_Temp.Font.FontFamily.Name, 6)
        Tb_Temp.Focus() 'מניעת האפשרות לכתוב ישר בתיבה של היוזר
        For Each p As Panel In Me.Controls.OfType(Of Panel)()
            For Each c As Control In p.Controls
                If TypeOf c Is RichTextBox Or TypeOf c Is CircularPicture Then
                    c.Location = New Point((p.Width - c.Width) / 2, c.Location.Y)
                End If
            Next
        Next
    End Sub
    Private Sub MainView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Public Sub ReturnToMe()
        Me.Show()
        ClassCheckManager.SetManagerName("")
        Tb_UserName.Text = ""
        Tb_Password.Text = ""
        Panel_Access.Height = 0
        CHB_ApplayToAll.CheckState = CheckState.Unchecked
        Panel_Side.Width = 0
        Lbl_Conecting.Visible = False
    End Sub
    Public Function GetHelper() As MyDBControler
        Return myHelper
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
        Lbl_Conecting.Visible = True
        myHelper.GetDBLogin(2)
    End Sub
    Private Sub Btn_RestTb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RestTb.Click
        Tb_UserName.Text = ""
        Tb_Password.Text = ""
        Tb_UserName.Focus()
        Lbl_Conecting.Visible = False
    End Sub
    Private Sub Btn_Guest_Click(sender As Object, e As EventArgs) Handles Btn_Guest.Click
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
        Btn_SignIn.Enabled = False
        If Panel_Side.Width > Panel_Top.Width / 3 Then
            Tb_UserName.Focus()
            Timer_In_Menu.Stop()
            Btn_SignIn.Enabled = True
        End If
    End Sub
    Private Sub Timer_Out_Menu_Tick(sender As Object, e As EventArgs) Handles Timer_Out_Menu.Tick
        Panel_Side.Width = Panel_Side.Width - 10
        Btn_SignIn.Enabled = False
        If Panel_Side.Width = 0 Then
            Tb_UserName.Clear()
            Tb_Password.Clear()
            Timer_Out_Menu.Stop()
            Btn_SignIn.Enabled = True
        End If
    End Sub
    Private Sub Btn_Accessibility_Click(sender As Object, e As EventArgs) Handles Btn_Accessibility.Click
        Panel_Access.Visible = Not Panel_Access.Visible
    End Sub
    Private Sub Btn_FontProp_Click(sender As Object, e As EventArgs) Handles Btn_FontProp.Click
        If FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Accessibility.FontName = FontDialog1.Font.Name
            Accessibility.FontSize = FontDialog1.Font.Size
            Lbl_FontNExp.Text = Accessibility.FontName
            Lbl_FontSExp.Text = Accessibility.FontSize
        End If
    End Sub
    Private Sub CB_HelpLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_HelpLang.SelectedIndexChanged
        Accessibility.Language = CB_HelpLang.Text
        Lbl_LangExp.Text = Accessibility.Language
        MsgBox("Help language has been updated")
    End Sub
    Private Sub Btn_SaveAccess_Click(sender As Object, e As EventArgs) Handles Btn_SaveAccess.Click
        Accessibility.SetTheDesign(Me.Controls)
    End Sub
    Private Sub CHB_ApplayToAll_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_ApplayToAll.CheckedChanged
        If CHB_ApplayToAll.Checked = True Then
            Accessibility.AllForms = True
        Else
            Accessibility.AllForms = False
        End If
    End Sub
    Private Sub TextB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_UserName.KeyPress, Tb_Password.KeyPress
        Dim txt As TextBox = sender
        Select Case txt.Name
            Case "Tb_UserName"
                myError.isUpperLetter(e, Tb_UserName)
            Case "Tb_Password"
                myError.isDigitVal(e, Tb_Password)
        End Select
    End Sub
    Private Sub CB_HelpLang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_HelpLang.KeyPress
        myError.isUnvailed(e, CB_HelpLang)
    End Sub
    Private Sub Btn_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Guest.MouseEnter, Btn_SignIn.MouseEnter, Btn_Accessibility.MouseEnter, Btn_FontProp.MouseEnter, Btn_SaveAccess.MouseEnter, Btn_Login.MouseEnter, Btn_RestTb.MouseEnter
        Dim btn As Button = sender
        Dim c As Color = btn.BackColor
        btn.BackColor = btn.ForeColor
        btn.ForeColor = c
    End Sub
    Private Sub Btn_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Guest.MouseLeave, Btn_SignIn.MouseLeave, Btn_Accessibility.MouseLeave, Btn_FontProp.MouseLeave, Btn_SaveAccess.MouseLeave, Btn_Login.MouseLeave, Btn_RestTb.MouseLeave
        Dim btn As Button = sender
        Dim c As Color = btn.BackColor
        btn.BackColor = btn.ForeColor
        btn.ForeColor = c
    End Sub
#End Region
End Class