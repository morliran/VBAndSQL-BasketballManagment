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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Lbl_Welcome = New System.Windows.Forms.Label()
        Me.Lbl_SystemVersion = New System.Windows.Forms.Label()
        Me.Panel_LSide = New System.Windows.Forms.Panel()
        Me.Panel_Buttom = New System.Windows.Forms.Panel()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Lbl_LeadExplain = New System.Windows.Forms.Label()
        Me.LV_League = New System.Windows.Forms.ListView()
        Me.Tb_Temp = New System.Windows.Forms.TextBox()
        Me.Panel_Side = New System.Windows.Forms.Panel()
        Me.Panel_Login = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Btn_RestTb = New System.Windows.Forms.Button()
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Lbl_Pass = New System.Windows.Forms.Label()
        Me.Tb_UserName = New System.Windows.Forms.TextBox()
        Me.Lbl_Username = New System.Windows.Forms.Label()
        Me.Lbl_LoginInfo = New System.Windows.Forms.Label()
        Me.Timer_Progress = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_In_Menu = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_SaveAccess = New System.Windows.Forms.Button()
        Me.Btn_FontC = New System.Windows.Forms.Button()
        Me.Timer_Up = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer_Out_Menu = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Down = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Access = New System.Windows.Forms.Label()
        Me.CB_HelpLang = New System.Windows.Forms.ComboBox()
        Me.Lbl_Lang = New System.Windows.Forms.Label()
        Me.Lbl_LangExp = New System.Windows.Forms.Label()
        Me.Btn_FontProp = New System.Windows.Forms.Button()
        Me.Lbl_FontN = New System.Windows.Forms.Label()
        Me.Lbl_FontNExp = New System.Windows.Forms.Label()
        Me.Lbl_FontS = New System.Windows.Forms.Label()
        Me.Lbl_FontSExp = New System.Windows.Forms.Label()
        Me.Lbl_FontSty = New System.Windows.Forms.Label()
        Me.Lbl_FontStyExp = New System.Windows.Forms.Label()
        Me.Panel_Access = New System.Windows.Forms.Panel()
        Me.Lbl_FontCExp = New System.Windows.Forms.Label()
        Me.Lbl_FontC = New System.Windows.Forms.Label()
        Me.Panel_User = New System.Windows.Forms.Panel()
        Me.CirPic_User = New BasicBasketballSql.CircularPicture()
        Me.RTB_Guest = New System.Windows.Forms.RichTextBox()
        Me.Btn_Guest = New System.Windows.Forms.Button()
        Me.Panel_Sign = New System.Windows.Forms.Panel()
        Me.CirPic_Log = New BasicBasketballSql.CircularPicture()
        Me.RTB_User = New System.Windows.Forms.RichTextBox()
        Me.Btn_SignIn = New System.Windows.Forms.Button()
        Me.Panel_MenuAccess = New System.Windows.Forms.Panel()
        Me.CircularPicture2 = New BasicBasketballSql.CircularPicture()
        Me.RTB_Access = New System.Windows.Forms.RichTextBox()
        Me.Btn_Accessibility = New System.Windows.Forms.Button()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_LSide.SuspendLayout()
        Me.Panel_Buttom.SuspendLayout()
        Me.Panel_Side.SuspendLayout()
        Me.Panel_Login.SuspendLayout()
        Me.Panel_Access.SuspendLayout()
        Me.Panel_User.SuspendLayout()
        CType(Me.CirPic_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Sign.SuspendLayout()
        CType(Me.CirPic_Log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MenuAccess.SuspendLayout()
        CType(Me.CircularPicture2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Button2)
        Me.Panel_Top.Controls.Add(Me.Lbl_Welcome)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1235, 100)
        Me.Panel_Top.TabIndex = 1
        '
        'Lbl_Welcome
        '
        Me.Lbl_Welcome.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl_Welcome.AutoSize = True
        Me.Lbl_Welcome.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Welcome.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Welcome.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Welcome.Location = New System.Drawing.Point(3, 35)
        Me.Lbl_Welcome.Name = "Lbl_Welcome"
        Me.Lbl_Welcome.Size = New System.Drawing.Size(326, 34)
        Me.Lbl_Welcome.TabIndex = 0
        Me.Lbl_Welcome.Text = "Basketball Managment"
        '
        'Lbl_SystemVersion
        '
        Me.Lbl_SystemVersion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Lbl_SystemVersion.AutoSize = True
        Me.Lbl_SystemVersion.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SystemVersion.ForeColor = System.Drawing.Color.Black
        Me.Lbl_SystemVersion.Location = New System.Drawing.Point(3, 79)
        Me.Lbl_SystemVersion.Name = "Lbl_SystemVersion"
        Me.Lbl_SystemVersion.Size = New System.Drawing.Size(172, 34)
        Me.Lbl_SystemVersion.TabIndex = 16
        Me.Lbl_SystemVersion.Text = "Version: 6.0"
        '
        'Panel_LSide
        '
        Me.Panel_LSide.BackColor = System.Drawing.Color.Transparent
        Me.Panel_LSide.Controls.Add(Me.Panel_Buttom)
        Me.Panel_LSide.Controls.Add(Me.LV_League)
        Me.Panel_LSide.Controls.Add(Me.Tb_Temp)
        Me.Panel_LSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_LSide.Location = New System.Drawing.Point(0, 100)
        Me.Panel_LSide.Name = "Panel_LSide"
        Me.Panel_LSide.Size = New System.Drawing.Size(370, 657)
        Me.Panel_LSide.TabIndex = 2
        '
        'Panel_Buttom
        '
        Me.Panel_Buttom.Controls.Add(Me.Lbl_SystemVersion)
        Me.Panel_Buttom.Controls.Add(Me.ProgressBar2)
        Me.Panel_Buttom.Controls.Add(Me.Lbl_LeadExplain)
        Me.Panel_Buttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Buttom.Location = New System.Drawing.Point(0, 522)
        Me.Panel_Buttom.Name = "Panel_Buttom"
        Me.Panel_Buttom.Size = New System.Drawing.Size(370, 135)
        Me.Panel_Buttom.TabIndex = 14
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(0, 39)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(367, 23)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 14
        '
        'Lbl_LeadExplain
        '
        Me.Lbl_LeadExplain.AutoSize = True
        Me.Lbl_LeadExplain.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LeadExplain.ForeColor = System.Drawing.Color.Black
        Me.Lbl_LeadExplain.Location = New System.Drawing.Point(3, 2)
        Me.Lbl_LeadExplain.Name = "Lbl_LeadExplain"
        Me.Lbl_LeadExplain.Size = New System.Drawing.Size(0, 34)
        Me.Lbl_LeadExplain.TabIndex = 15
        '
        'LV_League
        '
        Me.LV_League.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.LV_League.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LV_League.Enabled = False
        Me.LV_League.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_League.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_League.Location = New System.Drawing.Point(0, 0)
        Me.LV_League.Name = "LV_League"
        Me.LV_League.OwnerDraw = True
        Me.LV_League.Scrollable = False
        Me.LV_League.Size = New System.Drawing.Size(370, 657)
        Me.LV_League.TabIndex = 13
        Me.LV_League.TileSize = New System.Drawing.Size(215, 215)
        Me.LV_League.UseCompatibleStateImageBehavior = False
        Me.LV_League.View = System.Windows.Forms.View.Details
        '
        'Tb_Temp
        '
        Me.Tb_Temp.Location = New System.Drawing.Point(124, 108)
        Me.Tb_Temp.Name = "Tb_Temp"
        Me.Tb_Temp.Size = New System.Drawing.Size(100, 22)
        Me.Tb_Temp.TabIndex = 1
        '
        'Panel_Side
        '
        Me.Panel_Side.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Side.Controls.Add(Me.Panel_Login)
        Me.Panel_Side.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Side.Location = New System.Drawing.Point(1235, 100)
        Me.Panel_Side.Name = "Panel_Side"
        Me.Panel_Side.Size = New System.Drawing.Size(0, 657)
        Me.Panel_Side.TabIndex = 3
        '
        'Panel_Login
        '
        Me.Panel_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel_Login.Controls.Add(Me.Button1)
        Me.Panel_Login.Controls.Add(Me.ProgressBar1)
        Me.Panel_Login.Controls.Add(Me.Btn_RestTb)
        Me.Panel_Login.Controls.Add(Me.Btn_Login)
        Me.Panel_Login.Controls.Add(Me.Tb_Password)
        Me.Panel_Login.Controls.Add(Me.Lbl_Pass)
        Me.Panel_Login.Controls.Add(Me.Tb_UserName)
        Me.Panel_Login.Controls.Add(Me.Lbl_Username)
        Me.Panel_Login.Controls.Add(Me.Lbl_LoginInfo)
        Me.Panel_Login.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Login.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Login.Name = "Panel_Login"
        Me.Panel_Login.Size = New System.Drawing.Size(0, 417)
        Me.Panel_Login.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Lime
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 341)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(509, 28)
        Me.ProgressBar1.TabIndex = 10
        Me.ProgressBar1.Visible = False
        '
        'Btn_RestTb
        '
        Me.Btn_RestTb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_RestTb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Btn_RestTb.FlatAppearance.BorderSize = 3
        Me.Btn_RestTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_RestTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RestTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_RestTb.Location = New System.Drawing.Point(318, 269)
        Me.Btn_RestTb.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_RestTb.Name = "Btn_RestTb"
        Me.Btn_RestTb.Size = New System.Drawing.Size(102, 55)
        Me.Btn_RestTb.TabIndex = 14
        Me.Btn_RestTb.Text = "Reset"
        Me.Btn_RestTb.UseVisualStyleBackColor = False
        '
        'Btn_Login
        '
        Me.Btn_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Btn_Login.FlatAppearance.BorderSize = 3
        Me.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_Login.Location = New System.Drawing.Point(160, 269)
        Me.Btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(102, 55)
        Me.Btn_Login.TabIndex = 15
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = False
        '
        'Tb_Password
        '
        Me.Tb_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Password.ForeColor = System.Drawing.Color.Black
        Me.Tb_Password.Location = New System.Drawing.Point(160, 204)
        Me.Tb_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.Size = New System.Drawing.Size(260, 34)
        Me.Tb_Password.TabIndex = 13
        Me.Tb_Password.UseSystemPasswordChar = True
        '
        'Lbl_Pass
        '
        Me.Lbl_Pass.AutoSize = True
        Me.Lbl_Pass.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Pass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pass.ForeColor = System.Drawing.Color.White
        Me.Lbl_Pass.Location = New System.Drawing.Point(214, 175)
        Me.Lbl_Pass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Pass.Name = "Lbl_Pass"
        Me.Lbl_Pass.Size = New System.Drawing.Size(100, 23)
        Me.Lbl_Pass.TabIndex = 12
        Me.Lbl_Pass.Text = "Password"
        '
        'Tb_UserName
        '
        Me.Tb_UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_UserName.ForeColor = System.Drawing.Color.Black
        Me.Tb_UserName.Location = New System.Drawing.Point(160, 137)
        Me.Tb_UserName.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_UserName.Name = "Tb_UserName"
        Me.Tb_UserName.Size = New System.Drawing.Size(260, 34)
        Me.Tb_UserName.TabIndex = 11
        '
        'Lbl_Username
        '
        Me.Lbl_Username.AutoSize = True
        Me.Lbl_Username.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Username.ForeColor = System.Drawing.Color.White
        Me.Lbl_Username.Location = New System.Drawing.Point(214, 108)
        Me.Lbl_Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Username.Name = "Lbl_Username"
        Me.Lbl_Username.Size = New System.Drawing.Size(111, 23)
        Me.Lbl_Username.TabIndex = 9
        Me.Lbl_Username.Text = "UserName"
        '
        'Lbl_LoginInfo
        '
        Me.Lbl_LoginInfo.AutoSize = True
        Me.Lbl_LoginInfo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_LoginInfo.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LoginInfo.ForeColor = System.Drawing.Color.White
        Me.Lbl_LoginInfo.Location = New System.Drawing.Point(73, 40)
        Me.Lbl_LoginInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LoginInfo.Name = "Lbl_LoginInfo"
        Me.Lbl_LoginInfo.Size = New System.Drawing.Size(406, 34)
        Me.Lbl_LoginInfo.TabIndex = 8
        Me.Lbl_LoginInfo.Text = "Basketball Managment Login"
        '
        'Timer_Progress
        '
        '
        'Timer_In_Menu
        '
        Me.Timer_In_Menu.Interval = 5
        '
        'Btn_SaveAccess
        '
        Me.Btn_SaveAccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_SaveAccess.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_SaveAccess.FlatAppearance.BorderSize = 3
        Me.Btn_SaveAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SaveAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn_SaveAccess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_SaveAccess.Location = New System.Drawing.Point(567, 172)
        Me.Btn_SaveAccess.Name = "Btn_SaveAccess"
        Me.Btn_SaveAccess.Size = New System.Drawing.Size(293, 50)
        Me.Btn_SaveAccess.TabIndex = 6
        Me.Btn_SaveAccess.Text = "Save the new design"
        Me.Btn_SaveAccess.UseVisualStyleBackColor = False
        '
        'Btn_FontC
        '
        Me.Btn_FontC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_FontC.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_FontC.FlatAppearance.BorderSize = 3
        Me.Btn_FontC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_FontC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn_FontC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_FontC.Location = New System.Drawing.Point(576, 50)
        Me.Btn_FontC.Name = "Btn_FontC"
        Me.Btn_FontC.Size = New System.Drawing.Size(257, 50)
        Me.Btn_FontC.TabIndex = 4
        Me.Btn_FontC.Text = "Choose font color"
        Me.Btn_FontC.UseVisualStyleBackColor = False
        '
        'Timer_Up
        '
        Me.Timer_Up.Interval = 5
        '
        'Timer_Out_Menu
        '
        Me.Timer_Out_Menu.Interval = 5
        '
        'Timer_Down
        '
        Me.Timer_Down.Interval = 5
        '
        'Lbl_Access
        '
        Me.Lbl_Access.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Access.AutoSize = True
        Me.Lbl_Access.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Access.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Access.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Access.Location = New System.Drawing.Point(284, 11)
        Me.Lbl_Access.Name = "Lbl_Access"
        Me.Lbl_Access.Size = New System.Drawing.Size(269, 34)
        Me.Lbl_Access.TabIndex = 5
        Me.Lbl_Access.Text = "Accessibility Menu"
        '
        'CB_HelpLang
        '
        Me.CB_HelpLang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_HelpLang.FormattingEnabled = True
        Me.CB_HelpLang.Items.AddRange(New Object() {"English", "Hebrew"})
        Me.CB_HelpLang.Location = New System.Drawing.Point(5, 62)
        Me.CB_HelpLang.Name = "CB_HelpLang"
        Me.CB_HelpLang.Size = New System.Drawing.Size(241, 33)
        Me.CB_HelpLang.TabIndex = 3
        Me.CB_HelpLang.Text = "Choose help language"
        '
        'Lbl_Lang
        '
        Me.Lbl_Lang.AutoSize = True
        Me.Lbl_Lang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Lang.Location = New System.Drawing.Point(5, 108)
        Me.Lbl_Lang.Name = "Lbl_Lang"
        Me.Lbl_Lang.Size = New System.Drawing.Size(106, 25)
        Me.Lbl_Lang.TabIndex = 4
        Me.Lbl_Lang.Text = "Language:"
        '
        'Lbl_LangExp
        '
        Me.Lbl_LangExp.AutoSize = True
        Me.Lbl_LangExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_LangExp.Location = New System.Drawing.Point(132, 108)
        Me.Lbl_LangExp.Name = "Lbl_LangExp"
        Me.Lbl_LangExp.Size = New System.Drawing.Size(76, 25)
        Me.Lbl_LangExp.TabIndex = 5
        Me.Lbl_LangExp.Text = "English"
        '
        'Btn_FontProp
        '
        Me.Btn_FontProp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_FontProp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_FontProp.FlatAppearance.BorderSize = 3
        Me.Btn_FontProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_FontProp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Btn_FontProp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_FontProp.Location = New System.Drawing.Point(272, 50)
        Me.Btn_FontProp.Name = "Btn_FontProp"
        Me.Btn_FontProp.Size = New System.Drawing.Size(280, 50)
        Me.Btn_FontProp.TabIndex = 1
        Me.Btn_FontProp.Text = "Choose font property"
        Me.Btn_FontProp.UseVisualStyleBackColor = False
        '
        'Lbl_FontN
        '
        Me.Lbl_FontN.AutoSize = True
        Me.Lbl_FontN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontN.Location = New System.Drawing.Point(267, 110)
        Me.Lbl_FontN.Name = "Lbl_FontN"
        Me.Lbl_FontN.Size = New System.Drawing.Size(70, 25)
        Me.Lbl_FontN.TabIndex = 4
        Me.Lbl_FontN.Text = "Name:"
        '
        'Lbl_FontNExp
        '
        Me.Lbl_FontNExp.AutoSize = True
        Me.Lbl_FontNExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontNExp.Location = New System.Drawing.Point(364, 110)
        Me.Lbl_FontNExp.Name = "Lbl_FontNExp"
        Me.Lbl_FontNExp.Size = New System.Drawing.Size(27, 25)
        Me.Lbl_FontNExp.TabIndex = 5
        Me.Lbl_FontNExp.Text = "..."
        '
        'Lbl_FontS
        '
        Me.Lbl_FontS.AutoSize = True
        Me.Lbl_FontS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontS.Location = New System.Drawing.Point(267, 147)
        Me.Lbl_FontS.Name = "Lbl_FontS"
        Me.Lbl_FontS.Size = New System.Drawing.Size(57, 25)
        Me.Lbl_FontS.TabIndex = 6
        Me.Lbl_FontS.Text = "Size:"
        '
        'Lbl_FontSExp
        '
        Me.Lbl_FontSExp.AutoSize = True
        Me.Lbl_FontSExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontSExp.Location = New System.Drawing.Point(364, 145)
        Me.Lbl_FontSExp.Name = "Lbl_FontSExp"
        Me.Lbl_FontSExp.Size = New System.Drawing.Size(27, 25)
        Me.Lbl_FontSExp.TabIndex = 7
        Me.Lbl_FontSExp.Text = "..."
        '
        'Lbl_FontSty
        '
        Me.Lbl_FontSty.AutoSize = True
        Me.Lbl_FontSty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontSty.Location = New System.Drawing.Point(267, 187)
        Me.Lbl_FontSty.Name = "Lbl_FontSty"
        Me.Lbl_FontSty.Size = New System.Drawing.Size(62, 25)
        Me.Lbl_FontSty.TabIndex = 8
        Me.Lbl_FontSty.Text = "Style:"
        '
        'Lbl_FontStyExp
        '
        Me.Lbl_FontStyExp.AutoSize = True
        Me.Lbl_FontStyExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontStyExp.Location = New System.Drawing.Point(364, 187)
        Me.Lbl_FontStyExp.Name = "Lbl_FontStyExp"
        Me.Lbl_FontStyExp.Size = New System.Drawing.Size(27, 25)
        Me.Lbl_FontStyExp.TabIndex = 9
        Me.Lbl_FontStyExp.Text = "..."
        '
        'Panel_Access
        '
        Me.Panel_Access.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Access.Controls.Add(Me.Btn_SaveAccess)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontCExp)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontStyExp)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontSExp)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontC)
        Me.Panel_Access.Controls.Add(Me.Lbl_LangExp)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontSty)
        Me.Panel_Access.Controls.Add(Me.Btn_FontC)
        Me.Panel_Access.Controls.Add(Me.Lbl_Lang)
        Me.Panel_Access.Controls.Add(Me.Lbl_Access)
        Me.Panel_Access.Controls.Add(Me.CB_HelpLang)
        Me.Panel_Access.Controls.Add(Me.Btn_FontProp)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontS)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontN)
        Me.Panel_Access.Controls.Add(Me.Lbl_FontNExp)
        Me.Panel_Access.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Access.Location = New System.Drawing.Point(370, 757)
        Me.Panel_Access.Name = "Panel_Access"
        Me.Panel_Access.Size = New System.Drawing.Size(865, 0)
        Me.Panel_Access.TabIndex = 14
        '
        'Lbl_FontCExp
        '
        Me.Lbl_FontCExp.AutoSize = True
        Me.Lbl_FontCExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontCExp.Location = New System.Drawing.Point(663, 108)
        Me.Lbl_FontCExp.Name = "Lbl_FontCExp"
        Me.Lbl_FontCExp.Size = New System.Drawing.Size(27, 25)
        Me.Lbl_FontCExp.TabIndex = 5
        Me.Lbl_FontCExp.Text = "..."
        '
        'Lbl_FontC
        '
        Me.Lbl_FontC.AutoSize = True
        Me.Lbl_FontC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FontC.Location = New System.Drawing.Point(582, 108)
        Me.Lbl_FontC.Name = "Lbl_FontC"
        Me.Lbl_FontC.Size = New System.Drawing.Size(65, 25)
        Me.Lbl_FontC.TabIndex = 4
        Me.Lbl_FontC.Text = "Color:"
        '
        'Panel_User
        '
        Me.Panel_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Panel_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_User.Controls.Add(Me.CirPic_User)
        Me.Panel_User.Controls.Add(Me.RTB_Guest)
        Me.Panel_User.Controls.Add(Me.Btn_Guest)
        Me.Panel_User.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_User.Location = New System.Drawing.Point(370, 100)
        Me.Panel_User.Name = "Panel_User"
        Me.Panel_User.Size = New System.Drawing.Size(330, 657)
        Me.Panel_User.TabIndex = 15
        '
        'CirPic_User
        '
        Me.CirPic_User.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CirPic_User.Image = CType(resources.GetObject("CirPic_User.Image"), System.Drawing.Image)
        Me.CirPic_User.Location = New System.Drawing.Point(76, 20)
        Me.CirPic_User.Name = "CirPic_User"
        Me.CirPic_User.Size = New System.Drawing.Size(150, 150)
        Me.CirPic_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CirPic_User.TabIndex = 2
        Me.CirPic_User.TabStop = False
        '
        'RTB_Guest
        '
        Me.RTB_Guest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RTB_Guest.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.RTB_Guest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_Guest.Font = New System.Drawing.Font("Narkisim", 15.0!)
        Me.RTB_Guest.ForeColor = System.Drawing.Color.Black
        Me.RTB_Guest.Location = New System.Drawing.Point(20, 394)
        Me.RTB_Guest.Name = "RTB_Guest"
        Me.RTB_Guest.Size = New System.Drawing.Size(279, 163)
        Me.RTB_Guest.TabIndex = 1
        Me.RTB_Guest.Text = "Don't have a user?" & Global.Microsoft.VisualBasic.ChrW(10) & "Search for some information about the league?" & Global.Microsoft.VisualBasic.ChrW(10) & "Click on the but" & _
    "ton below."
        '
        'Btn_Guest
        '
        Me.Btn_Guest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_Guest.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_Guest.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Guest.FlatAppearance.BorderSize = 3
        Me.Btn_Guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guest.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_Guest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_Guest.Location = New System.Drawing.Point(0, 579)
        Me.Btn_Guest.Name = "Btn_Guest"
        Me.Btn_Guest.Size = New System.Drawing.Size(328, 76)
        Me.Btn_Guest.TabIndex = 0
        Me.Btn_Guest.Text = "Continue As Guest"
        Me.Btn_Guest.UseVisualStyleBackColor = False
        '
        'Panel_Sign
        '
        Me.Panel_Sign.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Panel_Sign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Sign.Controls.Add(Me.CirPic_Log)
        Me.Panel_Sign.Controls.Add(Me.RTB_User)
        Me.Panel_Sign.Controls.Add(Me.Btn_SignIn)
        Me.Panel_Sign.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Sign.Location = New System.Drawing.Point(700, 100)
        Me.Panel_Sign.Name = "Panel_Sign"
        Me.Panel_Sign.Size = New System.Drawing.Size(330, 657)
        Me.Panel_Sign.TabIndex = 16
        '
        'CirPic_Log
        '
        Me.CirPic_Log.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CirPic_Log.Image = CType(resources.GetObject("CirPic_Log.Image"), System.Drawing.Image)
        Me.CirPic_Log.Location = New System.Drawing.Point(73, 20)
        Me.CirPic_Log.Name = "CirPic_Log"
        Me.CirPic_Log.Size = New System.Drawing.Size(150, 150)
        Me.CirPic_Log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CirPic_Log.TabIndex = 3
        Me.CirPic_Log.TabStop = False
        '
        'RTB_User
        '
        Me.RTB_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RTB_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.RTB_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_User.Font = New System.Drawing.Font("Narkisim", 15.0!)
        Me.RTB_User.ForeColor = System.Drawing.Color.Black
        Me.RTB_User.Location = New System.Drawing.Point(21, 394)
        Me.RTB_User.Name = "RTB_User"
        Me.RTB_User.Size = New System.Drawing.Size(243, 136)
        Me.RTB_User.TabIndex = 2
        Me.RTB_User.Text = "Have a user?" & Global.Microsoft.VisualBasic.ChrW(10) & "Start managing your team" & Global.Microsoft.VisualBasic.ChrW(10) & "By click on the button below."
        '
        'Btn_SignIn
        '
        Me.Btn_SignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_SignIn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_SignIn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_SignIn.FlatAppearance.BorderSize = 3
        Me.Btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_SignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_SignIn.Location = New System.Drawing.Point(0, 579)
        Me.Btn_SignIn.Name = "Btn_SignIn"
        Me.Btn_SignIn.Size = New System.Drawing.Size(328, 76)
        Me.Btn_SignIn.TabIndex = 1
        Me.Btn_SignIn.Text = "Sign In"
        Me.Btn_SignIn.UseVisualStyleBackColor = False
        '
        'Panel_MenuAccess
        '
        Me.Panel_MenuAccess.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.Panel_MenuAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_MenuAccess.Controls.Add(Me.CircularPicture2)
        Me.Panel_MenuAccess.Controls.Add(Me.RTB_Access)
        Me.Panel_MenuAccess.Controls.Add(Me.Btn_Accessibility)
        Me.Panel_MenuAccess.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_MenuAccess.Location = New System.Drawing.Point(1030, 100)
        Me.Panel_MenuAccess.Name = "Panel_MenuAccess"
        Me.Panel_MenuAccess.Size = New System.Drawing.Size(330, 657)
        Me.Panel_MenuAccess.TabIndex = 17
        '
        'CircularPicture2
        '
        Me.CircularPicture2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CircularPicture2.Image = CType(resources.GetObject("CircularPicture2.Image"), System.Drawing.Image)
        Me.CircularPicture2.Location = New System.Drawing.Point(69, 20)
        Me.CircularPicture2.Name = "CircularPicture2"
        Me.CircularPicture2.Size = New System.Drawing.Size(150, 150)
        Me.CircularPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CircularPicture2.TabIndex = 3
        Me.CircularPicture2.TabStop = False
        '
        'RTB_Access
        '
        Me.RTB_Access.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RTB_Access.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.RTB_Access.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTB_Access.Font = New System.Drawing.Font("Narkisim", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_Access.ForeColor = System.Drawing.Color.Black
        Me.RTB_Access.Location = New System.Drawing.Point(8, 394)
        Me.RTB_Access.Name = "RTB_Access"
        Me.RTB_Access.Size = New System.Drawing.Size(243, 182)
        Me.RTB_Access.TabIndex = 3
        Me.RTB_Access.Text = "Click on the button below" & Global.Microsoft.VisualBasic.ChrW(10) & "to bring to accessibility menu" & Global.Microsoft.VisualBasic.ChrW(10) & "and change font property" & _
    " and help language."
        '
        'Btn_Accessibility
        '
        Me.Btn_Accessibility.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Btn_Accessibility.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Btn_Accessibility.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Accessibility.FlatAppearance.BorderSize = 3
        Me.Btn_Accessibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Accessibility.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_Accessibility.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Btn_Accessibility.Location = New System.Drawing.Point(0, 579)
        Me.Btn_Accessibility.Name = "Btn_Accessibility"
        Me.Btn_Accessibility.Size = New System.Drawing.Size(328, 76)
        Me.Btn_Accessibility.TabIndex = 1
        Me.Btn_Accessibility.Text = "Accessibility Menu"
        Me.Btn_Accessibility.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1235, 757)
        Me.Controls.Add(Me.Panel_MenuAccess)
        Me.Controls.Add(Me.Panel_Sign)
        Me.Controls.Add(Me.Panel_User)
        Me.Controls.Add(Me.Panel_Access)
        Me.Controls.Add(Me.Panel_Side)
        Me.Controls.Add(Me.Panel_LSide)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main view"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.Panel_LSide.ResumeLayout(False)
        Me.Panel_LSide.PerformLayout()
        Me.Panel_Buttom.ResumeLayout(False)
        Me.Panel_Buttom.PerformLayout()
        Me.Panel_Side.ResumeLayout(False)
        Me.Panel_Login.ResumeLayout(False)
        Me.Panel_Login.PerformLayout()
        Me.Panel_Access.ResumeLayout(False)
        Me.Panel_Access.PerformLayout()
        Me.Panel_User.ResumeLayout(False)
        CType(Me.CirPic_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Sign.ResumeLayout(False)
        CType(Me.CirPic_Log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MenuAccess.ResumeLayout(False)
        CType(Me.CircularPicture2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Welcome As System.Windows.Forms.Label
    Friend WithEvents Panel_LSide As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents LV_League As System.Windows.Forms.ListView
    Friend WithEvents Panel_Side As System.Windows.Forms.Panel
    Friend WithEvents Panel_Login As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Btn_RestTb As System.Windows.Forms.Button
    Friend WithEvents Btn_Login As System.Windows.Forms.Button
    Friend WithEvents Tb_Password As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pass As System.Windows.Forms.Label
    Friend WithEvents Tb_UserName As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Username As System.Windows.Forms.Label
    Friend WithEvents Lbl_LoginInfo As System.Windows.Forms.Label
    Friend WithEvents Timer_Progress As System.Windows.Forms.Timer
    Friend WithEvents Timer_In_Menu As System.Windows.Forms.Timer
    Friend WithEvents Lbl_LeadExplain As System.Windows.Forms.Label
    Friend WithEvents Panel_Buttom As System.Windows.Forms.Panel
    Friend WithEvents Lbl_SystemVersion As System.Windows.Forms.Label
    Friend WithEvents Timer_Up As System.Windows.Forms.Timer
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Btn_FontC As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Timer_Out_Menu As System.Windows.Forms.Timer
    Friend WithEvents Timer_Down As System.Windows.Forms.Timer
    Friend WithEvents Btn_SaveAccess As System.Windows.Forms.Button
    Friend WithEvents Lbl_Access As System.Windows.Forms.Label
    Friend WithEvents Lbl_LangExp As System.Windows.Forms.Label
    Friend WithEvents Lbl_Lang As System.Windows.Forms.Label
    Friend WithEvents CB_HelpLang As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_FontStyExp As System.Windows.Forms.Label
    Friend WithEvents Lbl_FontSty As System.Windows.Forms.Label
    Friend WithEvents Lbl_FontSExp As System.Windows.Forms.Label
    Friend WithEvents Lbl_FontS As System.Windows.Forms.Label
    Friend WithEvents Lbl_FontNExp As System.Windows.Forms.Label
    Friend WithEvents Lbl_FontN As System.Windows.Forms.Label
    Friend WithEvents Btn_FontProp As System.Windows.Forms.Button
    Friend WithEvents Panel_Access As System.Windows.Forms.Panel
    Friend WithEvents Lbl_FontCExp As System.Windows.Forms.Label
    Friend WithEvents Lbl_FontC As System.Windows.Forms.Label
    Friend WithEvents Panel_User As System.Windows.Forms.Panel
    Friend WithEvents Panel_Sign As System.Windows.Forms.Panel
    Friend WithEvents Panel_MenuAccess As System.Windows.Forms.Panel
    Friend WithEvents Btn_Guest As System.Windows.Forms.Button
    Friend WithEvents Btn_SignIn As System.Windows.Forms.Button
    Friend WithEvents Btn_Accessibility As System.Windows.Forms.Button
    Friend WithEvents RTB_Guest As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_User As System.Windows.Forms.RichTextBox
    Friend WithEvents RTB_Access As System.Windows.Forms.RichTextBox
    Friend WithEvents CircularPicture2 As BasicBasketballSql.CircularPicture
    Friend WithEvents CirPic_User As BasicBasketballSql.CircularPicture
    Friend WithEvents CirPic_Log As BasicBasketballSql.CircularPicture
    Friend WithEvents Tb_Temp As System.Windows.Forms.TextBox

End Class
