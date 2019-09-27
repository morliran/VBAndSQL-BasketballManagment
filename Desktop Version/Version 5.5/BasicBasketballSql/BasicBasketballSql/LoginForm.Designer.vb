<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_SystemTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Guest = New System.Windows.Forms.Button()
        Me.Btn_RestTb = New System.Windows.Forms.Button()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Lbl_Pass = New System.Windows.Forms.Label()
        Me.Tb_UserName = New System.Windows.Forms.TextBox()
        Me.Lbl_Username = New System.Windows.Forms.Label()
        Me.Lbl_LoginInfo = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_SystemTitle
        '
        Me.Lbl_SystemTitle.AutoSize = True
        Me.Lbl_SystemTitle.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SystemTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SystemTitle.ForeColor = System.Drawing.Color.White
        Me.Lbl_SystemTitle.Location = New System.Drawing.Point(151, 35)
        Me.Lbl_SystemTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_SystemTitle.Name = "Lbl_SystemTitle"
        Me.Lbl_SystemTitle.Size = New System.Drawing.Size(418, 42)
        Me.Lbl_SystemTitle.TabIndex = 0
        Me.Lbl_SystemTitle.Text = "Basketball Managment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Btn_Guest)
        Me.Panel1.Controls.Add(Me.Btn_RestTb)
        Me.Panel1.Controls.Add(Me.Btn_Login)
        Me.Panel1.Controls.Add(Me.Tb_Password)
        Me.Panel1.Controls.Add(Me.Lbl_Pass)
        Me.Panel1.Controls.Add(Me.Tb_UserName)
        Me.Panel1.Controls.Add(Me.Lbl_Username)
        Me.Panel1.Controls.Add(Me.Lbl_LoginInfo)
        Me.Panel1.Location = New System.Drawing.Point(104, 121)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 464)
        Me.Panel1.TabIndex = 1
        '
        'Btn_Guest
        '
        Me.Btn_Guest.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guest.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Guest.Location = New System.Drawing.Point(171, 326)
        Me.Btn_Guest.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Guest.Name = "Btn_Guest"
        Me.Btn_Guest.Size = New System.Drawing.Size(234, 58)
        Me.Btn_Guest.TabIndex = 6
        Me.Btn_Guest.Text = "Login As Guest"
        Me.Btn_Guest.UseVisualStyleBackColor = True
        '
        'Btn_RestTb
        '
        Me.Btn_RestTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RestTb.ForeColor = System.Drawing.Color.Blue
        Me.Btn_RestTb.Location = New System.Drawing.Point(313, 247)
        Me.Btn_RestTb.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_RestTb.Name = "Btn_RestTb"
        Me.Btn_RestTb.Size = New System.Drawing.Size(102, 43)
        Me.Btn_RestTb.TabIndex = 5
        Me.Btn_RestTb.Text = "Reset"
        Me.Btn_RestTb.UseVisualStyleBackColor = True
        '
        'Btn_Login
        '
        Me.Btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.ForeColor = System.Drawing.Color.Blue
        Me.Btn_Login.Location = New System.Drawing.Point(155, 247)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(102, 43)
        Me.Btn_Login.TabIndex = 5
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Tb_Password
        '
        Me.Tb_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Password.Location = New System.Drawing.Point(155, 182)
        Me.Tb_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.Size = New System.Drawing.Size(260, 34)
        Me.Tb_Password.TabIndex = 4
        Me.Tb_Password.UseSystemPasswordChar = True
        '
        'Lbl_Pass
        '
        Me.Lbl_Pass.AutoSize = True
        Me.Lbl_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pass.ForeColor = System.Drawing.Color.White
        Me.Lbl_Pass.Location = New System.Drawing.Point(209, 153)
        Me.Lbl_Pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pass.Name = "Lbl_Pass"
        Me.Lbl_Pass.Size = New System.Drawing.Size(106, 25)
        Me.Lbl_Pass.TabIndex = 3
        Me.Lbl_Pass.Text = "Password"
        '
        'Tb_UserName
        '
        Me.Tb_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_UserName.Location = New System.Drawing.Point(155, 115)
        Me.Tb_UserName.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_UserName.Name = "Tb_UserName"
        Me.Tb_UserName.Size = New System.Drawing.Size(260, 34)
        Me.Tb_UserName.TabIndex = 2
        '
        'Lbl_Username
        '
        Me.Lbl_Username.AutoSize = True
        Me.Lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Username.ForeColor = System.Drawing.Color.White
        Me.Lbl_Username.Location = New System.Drawing.Point(209, 86)
        Me.Lbl_Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Username.Name = "Lbl_Username"
        Me.Lbl_Username.Size = New System.Drawing.Size(113, 25)
        Me.Lbl_Username.TabIndex = 1
        Me.Lbl_Username.Text = "UserName"
        '
        'Lbl_LoginInfo
        '
        Me.Lbl_LoginInfo.AutoSize = True
        Me.Lbl_LoginInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LoginInfo.ForeColor = System.Drawing.Color.White
        Me.Lbl_LoginInfo.Location = New System.Drawing.Point(207, 15)
        Me.Lbl_LoginInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LoginInfo.Name = "Lbl_LoginInfo"
        Me.Lbl_LoginInfo.Size = New System.Drawing.Size(106, 39)
        Me.Lbl_LoginInfo.TabIndex = 0
        Me.Lbl_LoginInfo.Text = "Login"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Lime
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(104, 592)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(565, 28)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BasicBasketballSql.My.Resources.Resources.LoginBackGround
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(747, 650)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_SystemTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_SystemTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_RestTb As System.Windows.Forms.Button
    Friend WithEvents Btn_Login As System.Windows.Forms.Button
    Friend WithEvents Tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pass As System.Windows.Forms.Label
    Friend WithEvents Tb_UserName As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Username As System.Windows.Forms.Label
    Friend WithEvents Lbl_LoginInfo As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Btn_Guest As System.Windows.Forms.Button

End Class
