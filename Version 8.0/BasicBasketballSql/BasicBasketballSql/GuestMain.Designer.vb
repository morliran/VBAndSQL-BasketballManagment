<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_GameVis = New System.Windows.Forms.Button()
        Me.Btn_LeagueLead = New System.Windows.Forms.Button()
        Me.Btn_Help = New System.Windows.Forms.Button()
        Me.Cmb_OpSearch = New System.Windows.Forms.ComboBox()
        Me.Panel_Temp = New System.Windows.Forms.Panel()
        Me.Cmb_SearchBy = New System.Windows.Forms.ComboBox()
        Me.Btn_StartSearch = New System.Windows.Forms.Button()
        Me.Panel_Display = New System.Windows.Forms.Panel()
        Me.Btn_ByJersey = New System.Windows.Forms.Button()
        Me.FLP_SearchBy = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_ByHeight = New System.Windows.Forms.Button()
        Me.Btn_ByDOB = New System.Windows.Forms.Button()
        Me.Btn_ByPosition = New System.Windows.Forms.Button()
        Me.Btn_BySPosition = New System.Windows.Forms.Button()
        Me.FLP_SearchBox = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_HelpMe = New System.Windows.Forms.Button()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Lbl_Guest = New System.Windows.Forms.Label()
        Me.CB_Temp = New System.Windows.Forms.ComboBox()
        Me.Panel_TopLeft = New System.Windows.Forms.Panel()
        Me.Lbl_Welcome = New System.Windows.Forms.Label()
        Me.FLP_Menu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_QueryInfo = New System.Windows.Forms.Button()
        Me.FLP_Query = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_BasicInfo = New System.Windows.Forms.Button()
        Me.Btn_TeamsInfo = New System.Windows.Forms.Button()
        Me.Btn_OthersInfo = New System.Windows.Forms.Button()
        Me.Btn_SearchPlayer = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Display.SuspendLayout()
        Me.FLP_SearchBy.SuspendLayout()
        Me.FLP_SearchBox.SuspendLayout()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_TopLeft.SuspendLayout()
        Me.FLP_Menu.SuspendLayout()
        Me.FLP_Query.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(7, 87)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1257, 461)
        Me.DataGridView1.TabIndex = 31
        Me.DataGridView1.Visible = False
        '
        'Btn_GameVis
        '
        Me.Btn_GameVis.AutoSize = True
        Me.Btn_GameVis.FlatAppearance.BorderSize = 0
        Me.Btn_GameVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GameVis.ForeColor = System.Drawing.Color.Black
        Me.Btn_GameVis.Location = New System.Drawing.Point(3, 720)
        Me.Btn_GameVis.Name = "Btn_GameVis"
        Me.Btn_GameVis.Size = New System.Drawing.Size(205, 43)
        Me.Btn_GameVis.TabIndex = 16
        Me.Btn_GameVis.Text = "Game vision"
        Me.Btn_GameVis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_GameVis.UseVisualStyleBackColor = True
        '
        'Btn_LeagueLead
        '
        Me.Btn_LeagueLead.AutoSize = True
        Me.Btn_LeagueLead.FlatAppearance.BorderSize = 0
        Me.Btn_LeagueLead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LeagueLead.ForeColor = System.Drawing.Color.Black
        Me.Btn_LeagueLead.Location = New System.Drawing.Point(3, 769)
        Me.Btn_LeagueLead.Name = "Btn_LeagueLead"
        Me.Btn_LeagueLead.Size = New System.Drawing.Size(229, 43)
        Me.Btn_LeagueLead.TabIndex = 17
        Me.Btn_LeagueLead.Text = "League leaders"
        Me.Btn_LeagueLead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_LeagueLead.UseVisualStyleBackColor = True
        '
        'Btn_Help
        '
        Me.Btn_Help.AutoSize = True
        Me.Btn_Help.FlatAppearance.BorderSize = 0
        Me.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Help.ForeColor = System.Drawing.Color.Black
        Me.Btn_Help.Location = New System.Drawing.Point(3, 818)
        Me.Btn_Help.Name = "Btn_Help"
        Me.Btn_Help.Size = New System.Drawing.Size(229, 43)
        Me.Btn_Help.TabIndex = 18
        Me.Btn_Help.Text = "Help"
        Me.Btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Help.UseVisualStyleBackColor = True
        '
        'Cmb_OpSearch
        '
        Me.Cmb_OpSearch.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Cmb_OpSearch.FormattingEnabled = True
        Me.Cmb_OpSearch.Location = New System.Drawing.Point(3, 3)
        Me.Cmb_OpSearch.Name = "Cmb_OpSearch"
        Me.Cmb_OpSearch.Size = New System.Drawing.Size(270, 35)
        Me.Cmb_OpSearch.TabIndex = 0
        Me.Cmb_OpSearch.Text = "Choose operator"
        '
        'Panel_Temp
        '
        Me.Panel_Temp.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Temp.Location = New System.Drawing.Point(3, 44)
        Me.Panel_Temp.Name = "Panel_Temp"
        Me.Panel_Temp.Size = New System.Drawing.Size(270, 2)
        Me.Panel_Temp.TabIndex = 1
        Me.Panel_Temp.Visible = False
        '
        'Cmb_SearchBy
        '
        Me.Cmb_SearchBy.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Cmb_SearchBy.FormattingEnabled = True
        Me.Cmb_SearchBy.Location = New System.Drawing.Point(3, 52)
        Me.Cmb_SearchBy.Name = "Cmb_SearchBy"
        Me.Cmb_SearchBy.Size = New System.Drawing.Size(270, 35)
        Me.Cmb_SearchBy.TabIndex = 2
        Me.Cmb_SearchBy.Text = "Search by"
        '
        'Btn_StartSearch
        '
        Me.Btn_StartSearch.AutoSize = True
        Me.Btn_StartSearch.FlatAppearance.BorderSize = 3
        Me.Btn_StartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_StartSearch.ForeColor = System.Drawing.Color.Black
        Me.Btn_StartSearch.Location = New System.Drawing.Point(3, 93)
        Me.Btn_StartSearch.Name = "Btn_StartSearch"
        Me.Btn_StartSearch.Size = New System.Drawing.Size(259, 49)
        Me.Btn_StartSearch.TabIndex = 20
        Me.Btn_StartSearch.Text = "Start search"
        Me.Btn_StartSearch.UseVisualStyleBackColor = True
        '
        'Panel_Display
        '
        Me.Panel_Display.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Display.Controls.Add(Me.DataGridView1)
        Me.Panel_Display.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Display.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_Display.Location = New System.Drawing.Point(312, 44)
        Me.Panel_Display.Name = "Panel_Display"
        Me.Panel_Display.Size = New System.Drawing.Size(1334, 882)
        Me.Panel_Display.TabIndex = 14
        '
        'Btn_ByJersey
        '
        Me.Btn_ByJersey.AutoSize = True
        Me.Btn_ByJersey.FlatAppearance.BorderSize = 0
        Me.Btn_ByJersey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ByJersey.ForeColor = System.Drawing.Color.Black
        Me.Btn_ByJersey.Location = New System.Drawing.Point(3, 3)
        Me.Btn_ByJersey.Name = "Btn_ByJersey"
        Me.Btn_ByJersey.Size = New System.Drawing.Size(205, 43)
        Me.Btn_ByJersey.TabIndex = 15
        Me.Btn_ByJersey.Text = "By Jerseynum"
        Me.Btn_ByJersey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ByJersey.UseVisualStyleBackColor = True
        '
        'FLP_SearchBy
        '
        Me.FLP_SearchBy.Controls.Add(Me.Btn_ByJersey)
        Me.FLP_SearchBy.Controls.Add(Me.Btn_ByHeight)
        Me.FLP_SearchBy.Controls.Add(Me.Btn_ByDOB)
        Me.FLP_SearchBy.Controls.Add(Me.Btn_ByPosition)
        Me.FLP_SearchBy.Controls.Add(Me.Btn_BySPosition)
        Me.FLP_SearchBy.Controls.Add(Me.FLP_SearchBox)
        Me.FLP_SearchBy.Controls.Add(Me.Btn_HelpMe)
        Me.FLP_SearchBy.Location = New System.Drawing.Point(3, 256)
        Me.FLP_SearchBy.Name = "FLP_SearchBy"
        Me.FLP_SearchBy.Size = New System.Drawing.Size(293, 458)
        Me.FLP_SearchBy.TabIndex = 15
        Me.FLP_SearchBy.Visible = False
        '
        'Btn_ByHeight
        '
        Me.Btn_ByHeight.AutoSize = True
        Me.Btn_ByHeight.FlatAppearance.BorderSize = 0
        Me.Btn_ByHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ByHeight.ForeColor = System.Drawing.Color.Black
        Me.Btn_ByHeight.Location = New System.Drawing.Point(3, 52)
        Me.Btn_ByHeight.Name = "Btn_ByHeight"
        Me.Btn_ByHeight.Size = New System.Drawing.Size(205, 43)
        Me.Btn_ByHeight.TabIndex = 16
        Me.Btn_ByHeight.Text = "By Height"
        Me.Btn_ByHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ByHeight.UseVisualStyleBackColor = True
        '
        'Btn_ByDOB
        '
        Me.Btn_ByDOB.AutoSize = True
        Me.Btn_ByDOB.FlatAppearance.BorderSize = 0
        Me.Btn_ByDOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ByDOB.ForeColor = System.Drawing.Color.Black
        Me.Btn_ByDOB.Location = New System.Drawing.Point(3, 101)
        Me.Btn_ByDOB.Name = "Btn_ByDOB"
        Me.Btn_ByDOB.Size = New System.Drawing.Size(227, 43)
        Me.Btn_ByDOB.TabIndex = 17
        Me.Btn_ByDOB.Text = "By Date of birth"
        Me.Btn_ByDOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ByDOB.UseVisualStyleBackColor = True
        '
        'Btn_ByPosition
        '
        Me.Btn_ByPosition.AutoSize = True
        Me.Btn_ByPosition.FlatAppearance.BorderSize = 0
        Me.Btn_ByPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ByPosition.ForeColor = System.Drawing.Color.Black
        Me.Btn_ByPosition.Location = New System.Drawing.Point(3, 150)
        Me.Btn_ByPosition.Name = "Btn_ByPosition"
        Me.Btn_ByPosition.Size = New System.Drawing.Size(237, 43)
        Me.Btn_ByPosition.TabIndex = 18
        Me.Btn_ByPosition.Text = "By Main position"
        Me.Btn_ByPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ByPosition.UseVisualStyleBackColor = True
        '
        'Btn_BySPosition
        '
        Me.Btn_BySPosition.AutoSize = True
        Me.Btn_BySPosition.FlatAppearance.BorderSize = 0
        Me.Btn_BySPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BySPosition.ForeColor = System.Drawing.Color.Black
        Me.Btn_BySPosition.Location = New System.Drawing.Point(3, 199)
        Me.Btn_BySPosition.Name = "Btn_BySPosition"
        Me.Btn_BySPosition.Size = New System.Drawing.Size(273, 43)
        Me.Btn_BySPosition.TabIndex = 19
        Me.Btn_BySPosition.Text = "By Second position"
        Me.Btn_BySPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BySPosition.UseVisualStyleBackColor = True
        '
        'FLP_SearchBox
        '
        Me.FLP_SearchBox.Controls.Add(Me.Cmb_OpSearch)
        Me.FLP_SearchBox.Controls.Add(Me.Panel_Temp)
        Me.FLP_SearchBox.Controls.Add(Me.Cmb_SearchBy)
        Me.FLP_SearchBox.Controls.Add(Me.Btn_StartSearch)
        Me.FLP_SearchBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_SearchBox.Location = New System.Drawing.Point(3, 248)
        Me.FLP_SearchBox.Name = "FLP_SearchBox"
        Me.FLP_SearchBox.Size = New System.Drawing.Size(273, 150)
        Me.FLP_SearchBox.TabIndex = 20
        '
        'Btn_HelpMe
        '
        Me.Btn_HelpMe.AutoSize = True
        Me.Btn_HelpMe.FlatAppearance.BorderSize = 0
        Me.Btn_HelpMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_HelpMe.ForeColor = System.Drawing.Color.Black
        Me.Btn_HelpMe.Location = New System.Drawing.Point(3, 404)
        Me.Btn_HelpMe.Name = "Btn_HelpMe"
        Me.Btn_HelpMe.Size = New System.Drawing.Size(273, 43)
        Me.Btn_HelpMe.TabIndex = 21
        Me.Btn_HelpMe.Text = "Help me"
        Me.Btn_HelpMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_HelpMe.UseVisualStyleBackColor = True
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Lbl_Guest)
        Me.Panel_Top.Controls.Add(Me.CB_Temp)
        Me.Panel_Top.Controls.Add(Me.Panel_TopLeft)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1646, 44)
        Me.Panel_Top.TabIndex = 12
        '
        'Lbl_Guest
        '
        Me.Lbl_Guest.AutoSize = True
        Me.Lbl_Guest.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Lbl_Guest.Location = New System.Drawing.Point(466, 10)
        Me.Lbl_Guest.Name = "Lbl_Guest"
        Me.Lbl_Guest.Size = New System.Drawing.Size(49, 19)
        Me.Lbl_Guest.TabIndex = 33
        Me.Lbl_Guest.Text = "Guest"
        Me.Lbl_Guest.Visible = False
        '
        'CB_Temp
        '
        Me.CB_Temp.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.CB_Temp.FormattingEnabled = True
        Me.CB_Temp.Location = New System.Drawing.Point(327, 7)
        Me.CB_Temp.Name = "CB_Temp"
        Me.CB_Temp.Size = New System.Drawing.Size(121, 29)
        Me.CB_Temp.TabIndex = 32
        Me.CB_Temp.Visible = False
        '
        'Panel_TopLeft
        '
        Me.Panel_TopLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Panel_TopLeft.Controls.Add(Me.Lbl_Welcome)
        Me.Panel_TopLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_TopLeft.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TopLeft.Name = "Panel_TopLeft"
        Me.Panel_TopLeft.Size = New System.Drawing.Size(312, 44)
        Me.Panel_TopLeft.TabIndex = 0
        '
        'Lbl_Welcome
        '
        Me.Lbl_Welcome.AutoSize = True
        Me.Lbl_Welcome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Welcome.Location = New System.Drawing.Point(3, 10)
        Me.Lbl_Welcome.Name = "Lbl_Welcome"
        Me.Lbl_Welcome.Size = New System.Drawing.Size(162, 23)
        Me.Lbl_Welcome.TabIndex = 24
        Me.Lbl_Welcome.Text = "Welcome guest"
        Me.Lbl_Welcome.Visible = False
        '
        'FLP_Menu
        '
        Me.FLP_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FLP_Menu.Controls.Add(Me.Btn_QueryInfo)
        Me.FLP_Menu.Controls.Add(Me.FLP_Query)
        Me.FLP_Menu.Controls.Add(Me.Btn_SearchPlayer)
        Me.FLP_Menu.Controls.Add(Me.FLP_SearchBy)
        Me.FLP_Menu.Controls.Add(Me.Btn_GameVis)
        Me.FLP_Menu.Controls.Add(Me.Btn_LeagueLead)
        Me.FLP_Menu.Controls.Add(Me.Btn_Help)
        Me.FLP_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.FLP_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Menu.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.FLP_Menu.Location = New System.Drawing.Point(0, 44)
        Me.FLP_Menu.Name = "FLP_Menu"
        Me.FLP_Menu.Size = New System.Drawing.Size(312, 882)
        Me.FLP_Menu.TabIndex = 13
        '
        'Btn_QueryInfo
        '
        Me.Btn_QueryInfo.AutoSize = True
        Me.Btn_QueryInfo.FlatAppearance.BorderSize = 0
        Me.Btn_QueryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_QueryInfo.ForeColor = System.Drawing.Color.Black
        Me.Btn_QueryInfo.Location = New System.Drawing.Point(3, 3)
        Me.Btn_QueryInfo.Name = "Btn_QueryInfo"
        Me.Btn_QueryInfo.Size = New System.Drawing.Size(161, 43)
        Me.Btn_QueryInfo.TabIndex = 12
        Me.Btn_QueryInfo.Text = "Query info"
        Me.Btn_QueryInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_QueryInfo.UseVisualStyleBackColor = True
        '
        'FLP_Query
        '
        Me.FLP_Query.Controls.Add(Me.Btn_BasicInfo)
        Me.FLP_Query.Controls.Add(Me.Btn_TeamsInfo)
        Me.FLP_Query.Controls.Add(Me.Btn_OthersInfo)
        Me.FLP_Query.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Query.Location = New System.Drawing.Point(3, 52)
        Me.FLP_Query.Name = "FLP_Query"
        Me.FLP_Query.Size = New System.Drawing.Size(194, 149)
        Me.FLP_Query.TabIndex = 13
        Me.FLP_Query.Visible = False
        '
        'Btn_BasicInfo
        '
        Me.Btn_BasicInfo.AutoSize = True
        Me.Btn_BasicInfo.FlatAppearance.BorderSize = 0
        Me.Btn_BasicInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BasicInfo.ForeColor = System.Drawing.Color.Black
        Me.Btn_BasicInfo.Location = New System.Drawing.Point(3, 3)
        Me.Btn_BasicInfo.Name = "Btn_BasicInfo"
        Me.Btn_BasicInfo.Size = New System.Drawing.Size(161, 43)
        Me.Btn_BasicInfo.TabIndex = 13
        Me.Btn_BasicInfo.Text = "Basic info"
        Me.Btn_BasicInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BasicInfo.UseVisualStyleBackColor = True
        '
        'Btn_TeamsInfo
        '
        Me.Btn_TeamsInfo.AutoSize = True
        Me.Btn_TeamsInfo.FlatAppearance.BorderSize = 0
        Me.Btn_TeamsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_TeamsInfo.ForeColor = System.Drawing.Color.Black
        Me.Btn_TeamsInfo.Location = New System.Drawing.Point(3, 52)
        Me.Btn_TeamsInfo.Name = "Btn_TeamsInfo"
        Me.Btn_TeamsInfo.Size = New System.Drawing.Size(163, 43)
        Me.Btn_TeamsInfo.TabIndex = 14
        Me.Btn_TeamsInfo.Text = "Teams info"
        Me.Btn_TeamsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_TeamsInfo.UseVisualStyleBackColor = True
        '
        'Btn_OthersInfo
        '
        Me.Btn_OthersInfo.AutoSize = True
        Me.Btn_OthersInfo.FlatAppearance.BorderSize = 0
        Me.Btn_OthersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_OthersInfo.ForeColor = System.Drawing.Color.Black
        Me.Btn_OthersInfo.Location = New System.Drawing.Point(3, 101)
        Me.Btn_OthersInfo.Name = "Btn_OthersInfo"
        Me.Btn_OthersInfo.Size = New System.Drawing.Size(165, 43)
        Me.Btn_OthersInfo.TabIndex = 15
        Me.Btn_OthersInfo.Text = "Others info"
        Me.Btn_OthersInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_OthersInfo.UseVisualStyleBackColor = True
        '
        'Btn_SearchPlayer
        '
        Me.Btn_SearchPlayer.AutoSize = True
        Me.Btn_SearchPlayer.FlatAppearance.BorderSize = 0
        Me.Btn_SearchPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SearchPlayer.ForeColor = System.Drawing.Color.Black
        Me.Btn_SearchPlayer.Location = New System.Drawing.Point(3, 207)
        Me.Btn_SearchPlayer.Name = "Btn_SearchPlayer"
        Me.Btn_SearchPlayer.Size = New System.Drawing.Size(205, 43)
        Me.Btn_SearchPlayer.TabIndex = 14
        Me.Btn_SearchPlayer.Text = "Search player"
        Me.Btn_SearchPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_SearchPlayer.UseVisualStyleBackColor = True
        '
        'GuestMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1646, 926)
        Me.Controls.Add(Me.Panel_Display)
        Me.Controls.Add(Me.FLP_Menu)
        Me.Controls.Add(Me.Panel_Top)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GuestMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Display.ResumeLayout(False)
        Me.FLP_SearchBy.ResumeLayout(False)
        Me.FLP_SearchBy.PerformLayout()
        Me.FLP_SearchBox.ResumeLayout(False)
        Me.FLP_SearchBox.PerformLayout()
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.Panel_TopLeft.ResumeLayout(False)
        Me.Panel_TopLeft.PerformLayout()
        Me.FLP_Menu.ResumeLayout(False)
        Me.FLP_Menu.PerformLayout()
        Me.FLP_Query.ResumeLayout(False)
        Me.FLP_Query.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_GameVis As System.Windows.Forms.Button
    Friend WithEvents Btn_LeagueLead As System.Windows.Forms.Button
    Friend WithEvents Btn_Help As System.Windows.Forms.Button
    Friend WithEvents Cmb_OpSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Panel_Temp As System.Windows.Forms.Panel
    Friend WithEvents Cmb_SearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_StartSearch As System.Windows.Forms.Button
    Friend WithEvents Panel_Display As System.Windows.Forms.Panel
    Friend WithEvents Btn_ByJersey As System.Windows.Forms.Button
    Friend WithEvents FLP_SearchBy As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_ByHeight As System.Windows.Forms.Button
    Friend WithEvents Btn_ByDOB As System.Windows.Forms.Button
    Friend WithEvents Btn_ByPosition As System.Windows.Forms.Button
    Friend WithEvents Btn_BySPosition As System.Windows.Forms.Button
    Friend WithEvents FLP_SearchBox As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_HelpMe As System.Windows.Forms.Button
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Guest As System.Windows.Forms.Label
    Friend WithEvents CB_Temp As System.Windows.Forms.ComboBox
    Friend WithEvents Panel_TopLeft As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Welcome As System.Windows.Forms.Label
    Friend WithEvents FLP_Menu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_QueryInfo As System.Windows.Forms.Button
    Friend WithEvents FLP_Query As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_BasicInfo As System.Windows.Forms.Button
    Friend WithEvents Btn_TeamsInfo As System.Windows.Forms.Button
    Friend WithEvents Btn_OthersInfo As System.Windows.Forms.Button
    Friend WithEvents Btn_SearchPlayer As System.Windows.Forms.Button
End Class
