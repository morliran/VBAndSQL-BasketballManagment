<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestQueriesSections
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
        Me.pnlButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.RTB_Colors = New System.Windows.Forms.RichTextBox()
        Me.Label_Info = New System.Windows.Forms.Label()
        Me.GB_Checks = New System.Windows.Forms.GroupBox()
        Me.CB_3 = New System.Windows.Forms.CheckBox()
        Me.CB_2 = New System.Windows.Forms.CheckBox()
        Me.CB_4 = New System.Windows.Forms.CheckBox()
        Me.CB_1 = New System.Windows.Forms.CheckBox()
        Me.Btn_Example = New System.Windows.Forms.Button()
        Me.CB_FillAll = New System.Windows.Forms.CheckBox()
        Me.Lbl_Check = New System.Windows.Forms.Label()
        Me.Btn_PageMove = New System.Windows.Forms.Button()
        Me.Btn_Refresh = New System.Windows.Forms.Button()
        Me.Lbl_PageNum = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Pic_ColorPic = New System.Windows.Forms.PictureBox()
        Me.Pic_SaveDesign = New System.Windows.Forms.PictureBox()
        Me.Btn_LeaguePlayers = New System.Windows.Forms.Button()
        Me.Btn_LeagueGames = New System.Windows.Forms.Button()
        Me.Btn_LeagueTeams = New System.Windows.Forms.Button()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.GB_Checks.SuspendLayout()
        CType(Me.Pic_ColorPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_SaveDesign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlButtons.Location = New System.Drawing.Point(15, 242)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(1739, 259)
        Me.pnlButtons.TabIndex = 3
        '
        'RTB_Colors
        '
        Me.RTB_Colors.Enabled = False
        Me.RTB_Colors.Location = New System.Drawing.Point(1021, 8)
        Me.RTB_Colors.Name = "RTB_Colors"
        Me.RTB_Colors.Size = New System.Drawing.Size(149, 135)
        Me.RTB_Colors.TabIndex = 8
        Me.RTB_Colors.Text = ""
        '
        'Label_Info
        '
        Me.Label_Info.AutoSize = True
        Me.Label_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label_Info.Location = New System.Drawing.Point(1, 47)
        Me.Label_Info.Name = "Label_Info"
        Me.Label_Info.Size = New System.Drawing.Size(279, 25)
        Me.Label_Info.TabIndex = 14
        Me.Label_Info.Text = "Click on the icon to select color"
        '
        'GB_Checks
        '
        Me.GB_Checks.Controls.Add(Me.CB_3)
        Me.GB_Checks.Controls.Add(Me.CB_2)
        Me.GB_Checks.Controls.Add(Me.CB_4)
        Me.GB_Checks.Controls.Add(Me.CB_1)
        Me.GB_Checks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.GB_Checks.Location = New System.Drawing.Point(115, 110)
        Me.GB_Checks.Name = "GB_Checks"
        Me.GB_Checks.Size = New System.Drawing.Size(426, 68)
        Me.GB_Checks.TabIndex = 15
        Me.GB_Checks.TabStop = False
        Me.GB_Checks.Text = "Save this color for col"
        '
        'CB_3
        '
        Me.CB_3.AutoSize = True
        Me.CB_3.Location = New System.Drawing.Point(207, 29)
        Me.CB_3.Name = "CB_3"
        Me.CB_3.Size = New System.Drawing.Size(80, 29)
        Me.CB_3.TabIndex = 5
        Me.CB_3.Text = "Col 3"
        Me.CB_3.UseVisualStyleBackColor = True
        '
        'CB_2
        '
        Me.CB_2.AutoSize = True
        Me.CB_2.Location = New System.Drawing.Point(103, 29)
        Me.CB_2.Name = "CB_2"
        Me.CB_2.Size = New System.Drawing.Size(80, 29)
        Me.CB_2.TabIndex = 4
        Me.CB_2.Text = "Col 2"
        Me.CB_2.UseVisualStyleBackColor = True
        '
        'CB_4
        '
        Me.CB_4.AutoSize = True
        Me.CB_4.Location = New System.Drawing.Point(315, 29)
        Me.CB_4.Name = "CB_4"
        Me.CB_4.Size = New System.Drawing.Size(80, 29)
        Me.CB_4.TabIndex = 2
        Me.CB_4.Text = "Col 4"
        Me.CB_4.UseVisualStyleBackColor = True
        '
        'CB_1
        '
        Me.CB_1.AutoSize = True
        Me.CB_1.Location = New System.Drawing.Point(6, 29)
        Me.CB_1.Name = "CB_1"
        Me.CB_1.Size = New System.Drawing.Size(80, 29)
        Me.CB_1.TabIndex = 0
        Me.CB_1.Text = "Col 1"
        Me.CB_1.UseVisualStyleBackColor = True
        '
        'Btn_Example
        '
        Me.Btn_Example.FlatAppearance.BorderSize = 3
        Me.Btn_Example.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Example.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_Example.Location = New System.Drawing.Point(209, 184)
        Me.Btn_Example.Name = "Btn_Example"
        Me.Btn_Example.Size = New System.Drawing.Size(183, 43)
        Me.Btn_Example.TabIndex = 16
        Me.Btn_Example.Text = "Example"
        Me.Btn_Example.UseVisualStyleBackColor = True
        '
        'CB_FillAll
        '
        Me.CB_FillAll.AutoSize = True
        Me.CB_FillAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_FillAll.Location = New System.Drawing.Point(420, 46)
        Me.CB_FillAll.Name = "CB_FillAll"
        Me.CB_FillAll.Size = New System.Drawing.Size(281, 29)
        Me.CB_FillAll.TabIndex = 17
        Me.CB_FillAll.Text = "Fill all columns with this color"
        Me.CB_FillAll.UseVisualStyleBackColor = True
        '
        'Lbl_Check
        '
        Me.Lbl_Check.AutoSize = True
        Me.Lbl_Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Check.Location = New System.Drawing.Point(612, 13)
        Me.Lbl_Check.Name = "Lbl_Check"
        Me.Lbl_Check.Size = New System.Drawing.Size(40, 25)
        Me.Lbl_Check.TabIndex = 18
        Me.Lbl_Check.Text = "1/3"
        '
        'Btn_PageMove
        '
        Me.Btn_PageMove.FlatAppearance.BorderSize = 3
        Me.Btn_PageMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PageMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_PageMove.Location = New System.Drawing.Point(760, 8)
        Me.Btn_PageMove.Name = "Btn_PageMove"
        Me.Btn_PageMove.Size = New System.Drawing.Size(153, 45)
        Me.Btn_PageMove.TabIndex = 19
        Me.Btn_PageMove.Text = "Next page"
        Me.Btn_PageMove.UseVisualStyleBackColor = True
        '
        'Btn_Refresh
        '
        Me.Btn_Refresh.Location = New System.Drawing.Point(237, 184)
        Me.Btn_Refresh.Name = "Btn_Refresh"
        Me.Btn_Refresh.Size = New System.Drawing.Size(137, 42)
        Me.Btn_Refresh.TabIndex = 20
        Me.Btn_Refresh.Text = "Restart"
        Me.Btn_Refresh.UseVisualStyleBackColor = True
        '
        'Lbl_PageNum
        '
        Me.Lbl_PageNum.AutoSize = True
        Me.Lbl_PageNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_PageNum.Location = New System.Drawing.Point(456, 13)
        Me.Lbl_PageNum.Name = "Lbl_PageNum"
        Me.Lbl_PageNum.Size = New System.Drawing.Size(135, 25)
        Me.Lbl_PageNum.TabIndex = 21
        Me.Lbl_PageNum.Text = "Page number:"
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        Me.ColorDialog1.FullOpen = True
        '
        'Pic_ColorPic
        '
        Me.Pic_ColorPic.BackColor = System.Drawing.Color.Transparent
        Me.Pic_ColorPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_ColorPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_ColorPic.Image = Global.BasicBasketballSql.My.Resources.Resources.colorpicker
        Me.Pic_ColorPic.Location = New System.Drawing.Point(307, 32)
        Me.Pic_ColorPic.Name = "Pic_ColorPic"
        Me.Pic_ColorPic.Size = New System.Drawing.Size(67, 63)
        Me.Pic_ColorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_ColorPic.TabIndex = 23
        Me.Pic_ColorPic.TabStop = False
        '
        'Pic_SaveDesign
        '
        Me.Pic_SaveDesign.BackColor = System.Drawing.Color.Transparent
        Me.Pic_SaveDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_SaveDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_SaveDesign.Image = Global.BasicBasketballSql.My.Resources.Resources.saveicon
        Me.Pic_SaveDesign.Location = New System.Drawing.Point(760, 75)
        Me.Pic_SaveDesign.Name = "Pic_SaveDesign"
        Me.Pic_SaveDesign.Size = New System.Drawing.Size(84, 68)
        Me.Pic_SaveDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_SaveDesign.TabIndex = 24
        Me.Pic_SaveDesign.TabStop = False
        Me.Pic_SaveDesign.Visible = False
        '
        'Btn_LeaguePlayers
        '
        Me.Btn_LeaguePlayers.FlatAppearance.BorderSize = 3
        Me.Btn_LeaguePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LeaguePlayers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_LeaguePlayers.Location = New System.Drawing.Point(1222, 8)
        Me.Btn_LeaguePlayers.Name = "Btn_LeaguePlayers"
        Me.Btn_LeaguePlayers.Size = New System.Drawing.Size(140, 81)
        Me.Btn_LeaguePlayers.TabIndex = 27
        Me.Btn_LeaguePlayers.Text = "League players"
        Me.Btn_LeaguePlayers.UseVisualStyleBackColor = True
        '
        'Btn_LeagueGames
        '
        Me.Btn_LeagueGames.FlatAppearance.BorderSize = 3
        Me.Btn_LeagueGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LeagueGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_LeagueGames.Location = New System.Drawing.Point(1558, 8)
        Me.Btn_LeagueGames.Name = "Btn_LeagueGames"
        Me.Btn_LeagueGames.Size = New System.Drawing.Size(140, 81)
        Me.Btn_LeagueGames.TabIndex = 26
        Me.Btn_LeagueGames.Text = "League games"
        Me.Btn_LeagueGames.UseVisualStyleBackColor = True
        '
        'Btn_LeagueTeams
        '
        Me.Btn_LeagueTeams.FlatAppearance.BorderSize = 3
        Me.Btn_LeagueTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LeagueTeams.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_LeagueTeams.Location = New System.Drawing.Point(1394, 8)
        Me.Btn_LeagueTeams.Name = "Btn_LeagueTeams"
        Me.Btn_LeagueTeams.Size = New System.Drawing.Size(140, 81)
        Me.Btn_LeagueTeams.TabIndex = 25
        Me.Btn_LeagueTeams.Text = "League teams"
        Me.Btn_LeagueTeams.UseVisualStyleBackColor = True
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(760, 168)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(84, 68)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 28
        Me.Pic_Help.TabStop = False
        '
        'GuestQueriesSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1793, 526)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.Btn_LeaguePlayers)
        Me.Controls.Add(Me.Btn_LeagueGames)
        Me.Controls.Add(Me.Btn_LeagueTeams)
        Me.Controls.Add(Me.Pic_SaveDesign)
        Me.Controls.Add(Me.Pic_ColorPic)
        Me.Controls.Add(Me.Lbl_PageNum)
        Me.Controls.Add(Me.Btn_PageMove)
        Me.Controls.Add(Me.Lbl_Check)
        Me.Controls.Add(Me.CB_FillAll)
        Me.Controls.Add(Me.GB_Checks)
        Me.Controls.Add(Me.Label_Info)
        Me.Controls.Add(Me.RTB_Colors)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.Btn_Example)
        Me.Controls.Add(Me.Btn_Refresh)
        Me.Name = "GuestQueriesSections"
        Me.Text = "GuestQueriesSections"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GB_Checks.ResumeLayout(False)
        Me.GB_Checks.PerformLayout()
        CType(Me.Pic_ColorPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_SaveDesign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RTB_Colors As System.Windows.Forms.RichTextBox
    Friend WithEvents Label_Info As System.Windows.Forms.Label
    Friend WithEvents GB_Checks As System.Windows.Forms.GroupBox
    Friend WithEvents CB_3 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_2 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_4 As System.Windows.Forms.CheckBox
    Friend WithEvents CB_1 As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Example As System.Windows.Forms.Button
    Friend WithEvents CB_FillAll As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Check As System.Windows.Forms.Label
    Friend WithEvents Btn_PageMove As System.Windows.Forms.Button
    Friend WithEvents Btn_Refresh As System.Windows.Forms.Button
    Friend WithEvents Lbl_PageNum As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Pic_ColorPic As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_SaveDesign As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_LeaguePlayers As System.Windows.Forms.Button
    Friend WithEvents Btn_LeagueGames As System.Windows.Forms.Button
    Friend WithEvents Btn_LeagueTeams As System.Windows.Forms.Button
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
