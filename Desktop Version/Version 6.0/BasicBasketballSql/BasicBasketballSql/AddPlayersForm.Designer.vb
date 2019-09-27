<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPlayersForm
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
        Me.GB_PlayerD = New System.Windows.Forms.GroupBox()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.Tb_RoutionCVal = New System.Windows.Forms.TextBox()
        Me.Pic_Save = New System.Windows.Forms.PictureBox()
        Me.Lbl_RoutionC = New System.Windows.Forms.Label()
        Me.Pic_New = New System.Windows.Forms.PictureBox()
        Me.Lbl_InvaliedCodes = New System.Windows.Forms.Label()
        Me.LV_PlayersCodeView = New System.Windows.Forms.ListView()
        Me.Lbl_ChangeSPosInfo = New System.Windows.Forms.Label()
        Me.MB_Height = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_AddP = New System.Windows.Forms.Label()
        Me.Tb_PID = New System.Windows.Forms.TextBox()
        Me.Lbl_PID = New System.Windows.Forms.Label()
        Me.Tb_PlayerCode = New System.Windows.Forms.TextBox()
        Me.Lbl_PlayerCode = New System.Windows.Forms.Label()
        Me.Tb_FN = New System.Windows.Forms.TextBox()
        Me.TB_ATC = New System.Windows.Forms.TextBox()
        Me.Lbl_ATC = New System.Windows.Forms.Label()
        Me.Lbl_Height = New System.Windows.Forms.Label()
        Me.Tb_HTC = New System.Windows.Forms.TextBox()
        Me.Lbl_HTC = New System.Windows.Forms.Label()
        Me.CB_SPosition = New System.Windows.Forms.ComboBox()
        Me.Lbl_SPosition = New System.Windows.Forms.Label()
        Me.Btn_SamePos = New System.Windows.Forms.Button()
        Me.CB_Position = New System.Windows.Forms.ComboBox()
        Me.Lbl_Position = New System.Windows.Forms.Label()
        Me.MB_DOB = New System.Windows.Forms.MaskedTextBox()
        Me.Tb_JN = New System.Windows.Forms.TextBox()
        Me.Tb_LN = New System.Windows.Forms.TextBox()
        Me.Lbl_DOB = New System.Windows.Forms.Label()
        Me.Lbl_JN = New System.Windows.Forms.Label()
        Me.Lbl_LN = New System.Windows.Forms.Label()
        Me.Lbl_FN = New System.Windows.Forms.Label()
        Me.Lbl_EmptyDateCheck = New System.Windows.Forms.Label()
        Me.Lbl_CheckDateOfBirthLen = New System.Windows.Forms.Label()
        Me.Lbl_EmptyHeight = New System.Windows.Forms.Label()
        Me.Lbl_FormBack = New System.Windows.Forms.Label()
        Me.Lbl_MUser = New System.Windows.Forms.Label()
        Me.Lbl_ManTeam = New System.Windows.Forms.Label()
        Me.GB_PlayerD.SuspendLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_New, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_PlayerD
        '
        Me.GB_PlayerD.BackColor = System.Drawing.Color.Transparent
        Me.GB_PlayerD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GB_PlayerD.Controls.Add(Me.Pic_Help)
        Me.GB_PlayerD.Controls.Add(Me.Tb_RoutionCVal)
        Me.GB_PlayerD.Controls.Add(Me.Pic_Save)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_RoutionC)
        Me.GB_PlayerD.Controls.Add(Me.Pic_New)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_InvaliedCodes)
        Me.GB_PlayerD.Controls.Add(Me.LV_PlayersCodeView)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_ChangeSPosInfo)
        Me.GB_PlayerD.Controls.Add(Me.MB_Height)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_AddP)
        Me.GB_PlayerD.Controls.Add(Me.Tb_PID)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_PID)
        Me.GB_PlayerD.Controls.Add(Me.Tb_PlayerCode)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_PlayerCode)
        Me.GB_PlayerD.Controls.Add(Me.Tb_FN)
        Me.GB_PlayerD.Controls.Add(Me.TB_ATC)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_ATC)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_Height)
        Me.GB_PlayerD.Controls.Add(Me.Tb_HTC)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_HTC)
        Me.GB_PlayerD.Controls.Add(Me.CB_SPosition)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_SPosition)
        Me.GB_PlayerD.Controls.Add(Me.Btn_SamePos)
        Me.GB_PlayerD.Controls.Add(Me.CB_Position)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_Position)
        Me.GB_PlayerD.Controls.Add(Me.MB_DOB)
        Me.GB_PlayerD.Controls.Add(Me.Tb_JN)
        Me.GB_PlayerD.Controls.Add(Me.Tb_LN)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_DOB)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_JN)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_LN)
        Me.GB_PlayerD.Controls.Add(Me.Lbl_FN)
        Me.GB_PlayerD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PlayerD.Location = New System.Drawing.Point(5, 61)
        Me.GB_PlayerD.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_PlayerD.Name = "GB_PlayerD"
        Me.GB_PlayerD.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_PlayerD.Size = New System.Drawing.Size(1279, 811)
        Me.GB_PlayerD.TabIndex = 1
        Me.GB_PlayerD.TabStop = False
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(1147, 368)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(112, 83)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 26
        Me.Pic_Help.TabStop = False
        '
        'Tb_RoutionCVal
        '
        Me.Tb_RoutionCVal.Enabled = False
        Me.Tb_RoutionCVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_RoutionCVal.Location = New System.Drawing.Point(233, 630)
        Me.Tb_RoutionCVal.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_RoutionCVal.Name = "Tb_RoutionCVal"
        Me.Tb_RoutionCVal.Size = New System.Drawing.Size(243, 34)
        Me.Tb_RoutionCVal.TabIndex = 34
        '
        'Pic_Save
        '
        Me.Pic_Save.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Save.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Save.Image = Global.BasicBasketballSql.My.Resources.Resources.saveicon
        Me.Pic_Save.Location = New System.Drawing.Point(1147, 246)
        Me.Pic_Save.Name = "Pic_Save"
        Me.Pic_Save.Size = New System.Drawing.Size(112, 83)
        Me.Pic_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Save.TabIndex = 25
        Me.Pic_Save.TabStop = False
        '
        'Lbl_RoutionC
        '
        Me.Lbl_RoutionC.AutoSize = True
        Me.Lbl_RoutionC.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RoutionC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_RoutionC.Location = New System.Drawing.Point(13, 627)
        Me.Lbl_RoutionC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_RoutionC.Name = "Lbl_RoutionC"
        Me.Lbl_RoutionC.Size = New System.Drawing.Size(161, 29)
        Me.Lbl_RoutionC.TabIndex = 33
        Me.Lbl_RoutionC.Text = "Roution Code"
        '
        'Pic_New
        '
        Me.Pic_New.BackColor = System.Drawing.Color.Transparent
        Me.Pic_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_New.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_New.Image = Global.BasicBasketballSql.My.Resources.Resources._new
        Me.Pic_New.Location = New System.Drawing.Point(1147, 124)
        Me.Pic_New.Name = "Pic_New"
        Me.Pic_New.Size = New System.Drawing.Size(112, 83)
        Me.Pic_New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_New.TabIndex = 24
        Me.Pic_New.TabStop = False
        '
        'Lbl_InvaliedCodes
        '
        Me.Lbl_InvaliedCodes.AutoSize = True
        Me.Lbl_InvaliedCodes.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_InvaliedCodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_InvaliedCodes.Location = New System.Drawing.Point(548, 74)
        Me.Lbl_InvaliedCodes.Name = "Lbl_InvaliedCodes"
        Me.Lbl_InvaliedCodes.Size = New System.Drawing.Size(350, 29)
        Me.Lbl_InvaliedCodes.TabIndex = 32
        Me.Lbl_InvaliedCodes.Text = "Player codes already in team ->"
        '
        'LV_PlayersCodeView
        '
        Me.LV_PlayersCodeView.Enabled = False
        Me.LV_PlayersCodeView.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_PlayersCodeView.GridLines = True
        Me.LV_PlayersCodeView.Location = New System.Drawing.Point(946, 74)
        Me.LV_PlayersCodeView.Name = "LV_PlayersCodeView"
        Me.LV_PlayersCodeView.Size = New System.Drawing.Size(145, 503)
        Me.LV_PlayersCodeView.TabIndex = 31
        Me.LV_PlayersCodeView.UseCompatibleStateImageBehavior = False
        Me.LV_PlayersCodeView.View = System.Windows.Forms.View.List
        '
        'Lbl_ChangeSPosInfo
        '
        Me.Lbl_ChangeSPosInfo.AutoSize = True
        Me.Lbl_ChangeSPosInfo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ChangeSPosInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_ChangeSPosInfo.Location = New System.Drawing.Point(525, 176)
        Me.Lbl_ChangeSPosInfo.Name = "Lbl_ChangeSPosInfo"
        Me.Lbl_ChangeSPosInfo.Size = New System.Drawing.Size(373, 58)
        Me.Lbl_ChangeSPosInfo.TabIndex = 30
        Me.Lbl_ChangeSPosInfo.Text = "To choice again second position, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "select again main position"
        '
        'MB_Height
        '
        Me.MB_Height.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.MB_Height.Location = New System.Drawing.Point(233, 507)
        Me.MB_Height.Mask = "0.00"
        Me.MB_Height.Name = "MB_Height"
        Me.MB_Height.Size = New System.Drawing.Size(243, 34)
        Me.MB_Height.TabIndex = 7
        '
        'Lbl_AddP
        '
        Me.Lbl_AddP.AutoSize = True
        Me.Lbl_AddP.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_AddP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AddP.Location = New System.Drawing.Point(8, 18)
        Me.Lbl_AddP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_AddP.Name = "Lbl_AddP"
        Me.Lbl_AddP.Size = New System.Drawing.Size(140, 29)
        Me.Lbl_AddP.TabIndex = 51
        Me.Lbl_AddP.Text = "Add Player"
        '
        'Tb_PID
        '
        Me.Tb_PID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_PID.Location = New System.Drawing.Point(233, 124)
        Me.Tb_PID.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_PID.Name = "Tb_PID"
        Me.Tb_PID.Size = New System.Drawing.Size(243, 34)
        Me.Tb_PID.TabIndex = 1
        Me.Tb_PID.Tag = "1"
        Me.Tb_PID.Text = "Player ID"
        '
        'Lbl_PID
        '
        Me.Lbl_PID.AutoSize = True
        Me.Lbl_PID.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_PID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_PID.Location = New System.Drawing.Point(13, 125)
        Me.Lbl_PID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_PID.Name = "Lbl_PID"
        Me.Lbl_PID.Size = New System.Drawing.Size(110, 29)
        Me.Lbl_PID.TabIndex = 27
        Me.Lbl_PID.Text = "Player ID"
        '
        'Tb_PlayerCode
        '
        Me.Tb_PlayerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_PlayerCode.Location = New System.Drawing.Point(233, 56)
        Me.Tb_PlayerCode.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_PlayerCode.Name = "Tb_PlayerCode"
        Me.Tb_PlayerCode.Size = New System.Drawing.Size(243, 34)
        Me.Tb_PlayerCode.TabIndex = 0
        Me.Tb_PlayerCode.Tag = "1"
        Me.Tb_PlayerCode.Text = "Player code"
        '
        'Lbl_PlayerCode
        '
        Me.Lbl_PlayerCode.AutoSize = True
        Me.Lbl_PlayerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_PlayerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_PlayerCode.Location = New System.Drawing.Point(13, 61)
        Me.Lbl_PlayerCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_PlayerCode.Name = "Lbl_PlayerCode"
        Me.Lbl_PlayerCode.Size = New System.Drawing.Size(146, 29)
        Me.Lbl_PlayerCode.TabIndex = 25
        Me.Lbl_PlayerCode.Text = "Player Code"
        '
        'Tb_FN
        '
        Me.Tb_FN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_FN.Location = New System.Drawing.Point(233, 187)
        Me.Tb_FN.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_FN.Name = "Tb_FN"
        Me.Tb_FN.Size = New System.Drawing.Size(243, 34)
        Me.Tb_FN.TabIndex = 2
        Me.Tb_FN.Tag = "2"
        Me.Tb_FN.Text = "First name"
        '
        'TB_ATC
        '
        Me.TB_ATC.Enabled = False
        Me.TB_ATC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.TB_ATC.Location = New System.Drawing.Point(233, 749)
        Me.TB_ATC.Margin = New System.Windows.Forms.Padding(4)
        Me.TB_ATC.Name = "TB_ATC"
        Me.TB_ATC.Size = New System.Drawing.Size(243, 34)
        Me.TB_ATC.TabIndex = 10
        '
        'Lbl_ATC
        '
        Me.Lbl_ATC.AutoSize = True
        Me.Lbl_ATC.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ATC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_ATC.Location = New System.Drawing.Point(13, 751)
        Me.Lbl_ATC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_ATC.Name = "Lbl_ATC"
        Me.Lbl_ATC.Size = New System.Drawing.Size(204, 29)
        Me.Lbl_ATC.TabIndex = 22
        Me.Lbl_ATC.Text = "Away Team Code"
        '
        'Lbl_Height
        '
        Me.Lbl_Height.AutoSize = True
        Me.Lbl_Height.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Height.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Height.Location = New System.Drawing.Point(13, 503)
        Me.Lbl_Height.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Height.Name = "Lbl_Height"
        Me.Lbl_Height.Size = New System.Drawing.Size(83, 29)
        Me.Lbl_Height.TabIndex = 20
        Me.Lbl_Height.Text = "Height"
        '
        'Tb_HTC
        '
        Me.Tb_HTC.Enabled = False
        Me.Tb_HTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_HTC.Location = New System.Drawing.Point(233, 695)
        Me.Tb_HTC.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_HTC.Name = "Tb_HTC"
        Me.Tb_HTC.Size = New System.Drawing.Size(243, 34)
        Me.Tb_HTC.TabIndex = 9
        '
        'Lbl_HTC
        '
        Me.Lbl_HTC.AutoSize = True
        Me.Lbl_HTC.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_HTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_HTC.Location = New System.Drawing.Point(13, 689)
        Me.Lbl_HTC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_HTC.Name = "Lbl_HTC"
        Me.Lbl_HTC.Size = New System.Drawing.Size(212, 29)
        Me.Lbl_HTC.TabIndex = 18
        Me.Lbl_HTC.Text = "Home Team Code"
        '
        'CB_SPosition
        '
        Me.CB_SPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_SPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_SPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_SPosition.FormattingEnabled = True
        Me.CB_SPosition.Items.AddRange(New Object() {"PG", "SG", "SF", "PF", "C"})
        Me.CB_SPosition.Location = New System.Drawing.Point(233, 439)
        Me.CB_SPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_SPosition.Name = "CB_SPosition"
        Me.CB_SPosition.Size = New System.Drawing.Size(243, 37)
        Me.CB_SPosition.TabIndex = 6
        Me.CB_SPosition.Text = "Second position"
        '
        'Lbl_SPosition
        '
        Me.Lbl_SPosition.AutoSize = True
        Me.Lbl_SPosition.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_SPosition.Location = New System.Drawing.Point(13, 441)
        Me.Lbl_SPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_SPosition.Name = "Lbl_SPosition"
        Me.Lbl_SPosition.Size = New System.Drawing.Size(189, 29)
        Me.Lbl_SPosition.TabIndex = 16
        Me.Lbl_SPosition.Text = "Second Position"
        '
        'Btn_SamePos
        '
        Me.Btn_SamePos.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_SamePos.FlatAppearance.BorderSize = 4
        Me.Btn_SamePos.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_SamePos.Location = New System.Drawing.Point(546, 405)
        Me.Btn_SamePos.Name = "Btn_SamePos"
        Me.Btn_SamePos.Size = New System.Drawing.Size(236, 46)
        Me.Btn_SamePos.TabIndex = 11
        Me.Btn_SamePos.Text = "Same Position"
        Me.Btn_SamePos.UseVisualStyleBackColor = True
        '
        'CB_Position
        '
        Me.CB_Position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_Position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Position.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_Position.FormattingEnabled = True
        Me.CB_Position.Items.AddRange(New Object() {"PG", "SG", "SF", "PF", "C"})
        Me.CB_Position.Location = New System.Drawing.Point(233, 376)
        Me.CB_Position.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Position.Name = "CB_Position"
        Me.CB_Position.Size = New System.Drawing.Size(243, 37)
        Me.CB_Position.TabIndex = 5
        Me.CB_Position.Text = "Main position"
        '
        'Lbl_Position
        '
        Me.Lbl_Position.AutoSize = True
        Me.Lbl_Position.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Position.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Position.Location = New System.Drawing.Point(13, 379)
        Me.Lbl_Position.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Position.Name = "Lbl_Position"
        Me.Lbl_Position.Size = New System.Drawing.Size(100, 29)
        Me.Lbl_Position.TabIndex = 13
        Me.Lbl_Position.Text = "Position"
        '
        'MB_DOB
        '
        Me.MB_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.MB_DOB.Location = New System.Drawing.Point(233, 569)
        Me.MB_DOB.Margin = New System.Windows.Forms.Padding(4)
        Me.MB_DOB.Mask = "00/00/0000"
        Me.MB_DOB.Name = "MB_DOB"
        Me.MB_DOB.Size = New System.Drawing.Size(243, 34)
        Me.MB_DOB.TabIndex = 8
        Me.MB_DOB.ValidatingType = GetType(Date)
        '
        'Tb_JN
        '
        Me.Tb_JN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_JN.Location = New System.Drawing.Point(233, 312)
        Me.Tb_JN.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_JN.Name = "Tb_JN"
        Me.Tb_JN.Size = New System.Drawing.Size(243, 34)
        Me.Tb_JN.TabIndex = 4
        Me.Tb_JN.Tag = "1"
        Me.Tb_JN.Text = "Jersey number"
        '
        'Tb_LN
        '
        Me.Tb_LN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Tb_LN.Location = New System.Drawing.Point(233, 250)
        Me.Tb_LN.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_LN.Name = "Tb_LN"
        Me.Tb_LN.Size = New System.Drawing.Size(243, 34)
        Me.Tb_LN.TabIndex = 3
        Me.Tb_LN.Tag = "2"
        Me.Tb_LN.Text = "Last name"
        '
        'Lbl_DOB
        '
        Me.Lbl_DOB.AutoSize = True
        Me.Lbl_DOB.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_DOB.Location = New System.Drawing.Point(13, 565)
        Me.Lbl_DOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_DOB.Name = "Lbl_DOB"
        Me.Lbl_DOB.Size = New System.Drawing.Size(149, 29)
        Me.Lbl_DOB.TabIndex = 12
        Me.Lbl_DOB.Text = "Date Of Birth"
        '
        'Lbl_JN
        '
        Me.Lbl_JN.AutoSize = True
        Me.Lbl_JN.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_JN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_JN.Location = New System.Drawing.Point(13, 317)
        Me.Lbl_JN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_JN.Name = "Lbl_JN"
        Me.Lbl_JN.Size = New System.Drawing.Size(141, 29)
        Me.Lbl_JN.TabIndex = 11
        Me.Lbl_JN.Text = "Jersey Num"
        '
        'Lbl_LN
        '
        Me.Lbl_LN.AutoSize = True
        Me.Lbl_LN.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_LN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_LN.Location = New System.Drawing.Point(13, 253)
        Me.Lbl_LN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LN.Name = "Lbl_LN"
        Me.Lbl_LN.Size = New System.Drawing.Size(128, 29)
        Me.Lbl_LN.TabIndex = 10
        Me.Lbl_LN.Text = "Last Name"
        '
        'Lbl_FN
        '
        Me.Lbl_FN.AutoSize = True
        Me.Lbl_FN.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_FN.Location = New System.Drawing.Point(13, 189)
        Me.Lbl_FN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_FN.Name = "Lbl_FN"
        Me.Lbl_FN.Size = New System.Drawing.Size(131, 29)
        Me.Lbl_FN.TabIndex = 9
        Me.Lbl_FN.Text = "First Name"
        '
        'Lbl_EmptyDateCheck
        '
        Me.Lbl_EmptyDateCheck.AutoSize = True
        Me.Lbl_EmptyDateCheck.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_EmptyDateCheck.ForeColor = System.Drawing.Color.Black
        Me.Lbl_EmptyDateCheck.Location = New System.Drawing.Point(666, 9)
        Me.Lbl_EmptyDateCheck.Name = "Lbl_EmptyDateCheck"
        Me.Lbl_EmptyDateCheck.Size = New System.Drawing.Size(121, 17)
        Me.Lbl_EmptyDateCheck.TabIndex = 52
        Me.Lbl_EmptyDateCheck.Text = "Check empty date"
        Me.Lbl_EmptyDateCheck.Visible = False
        '
        'Lbl_CheckDateOfBirthLen
        '
        Me.Lbl_CheckDateOfBirthLen.AutoSize = True
        Me.Lbl_CheckDateOfBirthLen.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CheckDateOfBirthLen.ForeColor = System.Drawing.Color.Black
        Me.Lbl_CheckDateOfBirthLen.Location = New System.Drawing.Point(666, 40)
        Me.Lbl_CheckDateOfBirthLen.Name = "Lbl_CheckDateOfBirthLen"
        Me.Lbl_CheckDateOfBirthLen.Size = New System.Drawing.Size(150, 17)
        Me.Lbl_CheckDateOfBirthLen.TabIndex = 54
        Me.Lbl_CheckDateOfBirthLen.Text = "Check date of birth len"
        Me.Lbl_CheckDateOfBirthLen.Visible = False
        '
        'Lbl_EmptyHeight
        '
        Me.Lbl_EmptyHeight.AutoSize = True
        Me.Lbl_EmptyHeight.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_EmptyHeight.ForeColor = System.Drawing.Color.Black
        Me.Lbl_EmptyHeight.Location = New System.Drawing.Point(487, 9)
        Me.Lbl_EmptyHeight.Name = "Lbl_EmptyHeight"
        Me.Lbl_EmptyHeight.Size = New System.Drawing.Size(132, 17)
        Me.Lbl_EmptyHeight.TabIndex = 55
        Me.Lbl_EmptyHeight.Text = "Check empty height"
        Me.Lbl_EmptyHeight.Visible = False
        '
        'Lbl_FormBack
        '
        Me.Lbl_FormBack.AutoSize = True
        Me.Lbl_FormBack.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FormBack.ForeColor = System.Drawing.Color.Black
        Me.Lbl_FormBack.Location = New System.Drawing.Point(490, 40)
        Me.Lbl_FormBack.Name = "Lbl_FormBack"
        Me.Lbl_FormBack.Size = New System.Drawing.Size(67, 17)
        Me.Lbl_FormBack.TabIndex = 56
        Me.Lbl_FormBack.Text = "Back to..."
        Me.Lbl_FormBack.Visible = False
        '
        'Lbl_MUser
        '
        Me.Lbl_MUser.AutoSize = True
        Me.Lbl_MUser.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_MUser.ForeColor = System.Drawing.Color.Black
        Me.Lbl_MUser.Location = New System.Drawing.Point(363, 9)
        Me.Lbl_MUser.Name = "Lbl_MUser"
        Me.Lbl_MUser.Size = New System.Drawing.Size(98, 17)
        Me.Lbl_MUser.TabIndex = 57
        Me.Lbl_MUser.Text = "Manager User"
        Me.Lbl_MUser.Visible = False
        '
        'Lbl_ManTeam
        '
        Me.Lbl_ManTeam.AutoSize = True
        Me.Lbl_ManTeam.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ManTeam.ForeColor = System.Drawing.Color.Black
        Me.Lbl_ManTeam.Location = New System.Drawing.Point(366, 37)
        Me.Lbl_ManTeam.Name = "Lbl_ManTeam"
        Me.Lbl_ManTeam.Size = New System.Drawing.Size(104, 17)
        Me.Lbl_ManTeam.TabIndex = 58
        Me.Lbl_ManTeam.Text = "Manager Team"
        Me.Lbl_ManTeam.Visible = False
        '
        'AddPlayersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1297, 885)
        Me.Controls.Add(Me.Lbl_ManTeam)
        Me.Controls.Add(Me.Lbl_MUser)
        Me.Controls.Add(Me.Lbl_FormBack)
        Me.Controls.Add(Me.Lbl_EmptyHeight)
        Me.Controls.Add(Me.Lbl_CheckDateOfBirthLen)
        Me.Controls.Add(Me.Lbl_EmptyDateCheck)
        Me.Controls.Add(Me.GB_PlayerD)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddPlayersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPlayersForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GB_PlayerD.ResumeLayout(False)
        Me.GB_PlayerD.PerformLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_New, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_PlayerD As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_JN As System.Windows.Forms.TextBox
    Friend WithEvents Tb_LN As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_DOB As System.Windows.Forms.Label
    Friend WithEvents MB_DOB As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lbl_AddP As System.Windows.Forms.Label
    Friend WithEvents CB_SPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_SamePos As System.Windows.Forms.Button
    Friend WithEvents CB_Position As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Height As System.Windows.Forms.Label
    Friend WithEvents Tb_HTC As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_HTC As System.Windows.Forms.Label
    Friend WithEvents TB_ATC As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_ATC As System.Windows.Forms.Label
    Friend WithEvents Tb_FN As System.Windows.Forms.TextBox
    Friend WithEvents Tb_PID As System.Windows.Forms.TextBox
    Friend WithEvents Tb_PlayerCode As System.Windows.Forms.TextBox
    Friend WithEvents MB_Height As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lbl_ChangeSPosInfo As System.Windows.Forms.Label
    Friend WithEvents Lbl_EmptyDateCheck As System.Windows.Forms.Label
    Friend WithEvents Lbl_CheckDateOfBirthLen As System.Windows.Forms.Label
    Friend WithEvents Lbl_EmptyHeight As System.Windows.Forms.Label
    Friend WithEvents LV_PlayersCodeView As System.Windows.Forms.ListView
    Friend WithEvents Lbl_InvaliedCodes As System.Windows.Forms.Label
    Friend WithEvents Lbl_FormBack As System.Windows.Forms.Label
    Friend WithEvents Lbl_MUser As System.Windows.Forms.Label
    Friend WithEvents Lbl_PID As System.Windows.Forms.Label
    Friend WithEvents Lbl_PlayerCode As System.Windows.Forms.Label
    Friend WithEvents Lbl_SPosition As System.Windows.Forms.Label
    Friend WithEvents Lbl_Position As System.Windows.Forms.Label
    Friend WithEvents Lbl_JN As System.Windows.Forms.Label
    Friend WithEvents Lbl_LN As System.Windows.Forms.Label
    Friend WithEvents Lbl_FN As System.Windows.Forms.Label
    Friend WithEvents Tb_RoutionCVal As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_RoutionC As System.Windows.Forms.Label
    Friend WithEvents Lbl_ManTeam As System.Windows.Forms.Label
    Friend WithEvents Pic_New As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Save As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class