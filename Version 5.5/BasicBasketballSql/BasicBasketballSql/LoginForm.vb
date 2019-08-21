Imports System.Data
Public Class LoginForm
    Private myHelper As MyDBControler = New MyDBControler()
    Private myError As MerrorControl = New MerrorControl()
    Private ManagerName As String = "", TeamName As String = "", HomeC As String = "", AwayC As String = ""
#Region "אופציות על הפורם"
    Private Sub LoginForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Public Sub ReturnToMe()
        Me.Show()
        Me.setManagerName("")
        Me.Tb_UserName.Text = ""
        Me.Tb_Password.Text = ""
        Me.Tb_UserName.Focus() 'הסמן יופיע בתיבה של הuser name '
        Me.ProgressBar1.Visible = False
    End Sub
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
        myHelper.getDBLogin(2)
    End Sub
    Private Sub Btn_RestTb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RestTb.Click
        Tb_UserName.Text = ""
        Tb_Password.Text = ""
        Tb_UserName.Focus()
    End Sub
    Private Sub Btn_Guest_Click(sender As Object, e As EventArgs) Handles Btn_Guest.Click
        Me.Hide()
        GuestMain.Show()
    End Sub
    Private Sub Tb_UserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_UserName.KeyPress
        myError.isUpperLetter(e, Tb_UserName)
    End Sub
    Private Sub Tb_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb_Password.KeyPress
        myError.isDigitVal(e, Tb_Password)
    End Sub
#End Region
#Region "Getters And Setters"
    Public Sub setManagerName(ByVal name As String)
        Me.ManagerName = name
    End Sub
    Public Function getManagerName() As String
        Return ManagerName
    End Function
    Public Sub setManagerTeam(ByVal Tname As String)
        Me.TeamName = Tname
        Me.HomeC = myHelper.getColumn("HomeTeamCode", getManagerTeamName())
        Me.AwayC = myHelper.getColumn("AwayTeamCode", getManagerTeamName())
    End Sub
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
