<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeagueLeaders
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
        Me.Panel_Lead = New System.Windows.Forms.Panel()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.Btn_GetLeaders = New System.Windows.Forms.Button()
        Me.Lbl_FormBack = New System.Windows.Forms.Label()
        Me.Lbl_BLead = New System.Windows.Forms.Label()
        Me.LV_LeagueBLead = New System.Windows.Forms.ListView()
        Me.Lbl_SLead = New System.Windows.Forms.Label()
        Me.LV_LeagueSLead = New System.Windows.Forms.ListView()
        Me.Lbl_RLead = New System.Windows.Forms.Label()
        Me.LV_LeagueRLead = New System.Windows.Forms.ListView()
        Me.Lbl_ALead = New System.Windows.Forms.Label()
        Me.LV_LeagueALead = New System.Windows.Forms.ListView()
        Me.Lbl_LL = New System.Windows.Forms.Label()
        Me.Lbl_PLead = New System.Windows.Forms.Label()
        Me.LV_LeaguePLead = New System.Windows.Forms.ListView()
        Me.Panel_Lead.SuspendLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Lead
        '
        Me.Panel_Lead.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Lead.Controls.Add(Me.Pic_Help)
        Me.Panel_Lead.Controls.Add(Me.Btn_GetLeaders)
        Me.Panel_Lead.Controls.Add(Me.Lbl_FormBack)
        Me.Panel_Lead.Controls.Add(Me.Lbl_BLead)
        Me.Panel_Lead.Controls.Add(Me.LV_LeagueBLead)
        Me.Panel_Lead.Controls.Add(Me.Lbl_SLead)
        Me.Panel_Lead.Controls.Add(Me.LV_LeagueSLead)
        Me.Panel_Lead.Controls.Add(Me.Lbl_RLead)
        Me.Panel_Lead.Controls.Add(Me.LV_LeagueRLead)
        Me.Panel_Lead.Controls.Add(Me.Lbl_ALead)
        Me.Panel_Lead.Controls.Add(Me.LV_LeagueALead)
        Me.Panel_Lead.Controls.Add(Me.Lbl_LL)
        Me.Panel_Lead.Controls.Add(Me.Lbl_PLead)
        Me.Panel_Lead.Controls.Add(Me.LV_LeaguePLead)
        Me.Panel_Lead.Location = New System.Drawing.Point(12, 5)
        Me.Panel_Lead.Name = "Panel_Lead"
        Me.Panel_Lead.Size = New System.Drawing.Size(1476, 937)
        Me.Panel_Lead.TabIndex = 0
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(1209, 523)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 45
        Me.Pic_Help.TabStop = False
        '
        'Btn_GetLeaders
        '
        Me.Btn_GetLeaders.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Btn_GetLeaders.Location = New System.Drawing.Point(1134, 612)
        Me.Btn_GetLeaders.Name = "Btn_GetLeaders"
        Me.Btn_GetLeaders.Size = New System.Drawing.Size(313, 50)
        Me.Btn_GetLeaders.TabIndex = 44
        Me.Btn_GetLeaders.Text = "Show me teams leaders"
        Me.Btn_GetLeaders.UseVisualStyleBackColor = True
        '
        'Lbl_FormBack
        '
        Me.Lbl_FormBack.AutoSize = True
        Me.Lbl_FormBack.Location = New System.Drawing.Point(26, 12)
        Me.Lbl_FormBack.Name = "Lbl_FormBack"
        Me.Lbl_FormBack.Size = New System.Drawing.Size(67, 17)
        Me.Lbl_FormBack.TabIndex = 43
        Me.Lbl_FormBack.Text = "Back to..."
        Me.Lbl_FormBack.Visible = False
        '
        'Lbl_BLead
        '
        Me.Lbl_BLead.AutoSize = True
        Me.Lbl_BLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_BLead.Location = New System.Drawing.Point(507, 491)
        Me.Lbl_BLead.Name = "Lbl_BLead"
        Me.Lbl_BLead.Size = New System.Drawing.Size(179, 29)
        Me.Lbl_BLead.TabIndex = 42
        Me.Lbl_BLead.Text = "Blocks Leaders"
        '
        'LV_LeagueBLead
        '
        Me.LV_LeagueBLead.Enabled = False
        Me.LV_LeagueBLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueBLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueBLead.Location = New System.Drawing.Point(512, 523)
        Me.LV_LeagueBLead.Name = "LV_LeagueBLead"
        Me.LV_LeagueBLead.Scrollable = False
        Me.LV_LeagueBLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueBLead.TabIndex = 41
        Me.LV_LeagueBLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueBLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueBLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_SLead
        '
        Me.Lbl_SLead.AutoSize = True
        Me.Lbl_SLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_SLead.Location = New System.Drawing.Point(24, 491)
        Me.Lbl_SLead.Name = "Lbl_SLead"
        Me.Lbl_SLead.Size = New System.Drawing.Size(175, 29)
        Me.Lbl_SLead.TabIndex = 40
        Me.Lbl_SLead.Text = "Steels Leaders"
        '
        'LV_LeagueSLead
        '
        Me.LV_LeagueSLead.Enabled = False
        Me.LV_LeagueSLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueSLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueSLead.Location = New System.Drawing.Point(29, 523)
        Me.LV_LeagueSLead.Name = "LV_LeagueSLead"
        Me.LV_LeagueSLead.Scrollable = False
        Me.LV_LeagueSLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueSLead.TabIndex = 39
        Me.LV_LeagueSLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueSLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueSLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_RLead
        '
        Me.Lbl_RLead.AutoSize = True
        Me.Lbl_RLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_RLead.Location = New System.Drawing.Point(986, 42)
        Me.Lbl_RLead.Name = "Lbl_RLead"
        Me.Lbl_RLead.Size = New System.Drawing.Size(218, 29)
        Me.Lbl_RLead.TabIndex = 38
        Me.Lbl_RLead.Text = "Rebounds Leaders"
        '
        'LV_LeagueRLead
        '
        Me.LV_LeagueRLead.Enabled = False
        Me.LV_LeagueRLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueRLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueRLead.Location = New System.Drawing.Point(991, 74)
        Me.LV_LeagueRLead.Name = "LV_LeagueRLead"
        Me.LV_LeagueRLead.Scrollable = False
        Me.LV_LeagueRLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueRLead.TabIndex = 37
        Me.LV_LeagueRLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueRLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueRLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_ALead
        '
        Me.Lbl_ALead.AutoSize = True
        Me.Lbl_ALead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_ALead.Location = New System.Drawing.Point(507, 42)
        Me.Lbl_ALead.Name = "Lbl_ALead"
        Me.Lbl_ALead.Size = New System.Drawing.Size(170, 29)
        Me.Lbl_ALead.TabIndex = 36
        Me.Lbl_ALead.Text = "Assits Leaders"
        '
        'LV_LeagueALead
        '
        Me.LV_LeagueALead.Enabled = False
        Me.LV_LeagueALead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueALead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueALead.Location = New System.Drawing.Point(512, 74)
        Me.LV_LeagueALead.Name = "LV_LeagueALead"
        Me.LV_LeagueALead.Scrollable = False
        Me.LV_LeagueALead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueALead.TabIndex = 35
        Me.LV_LeagueALead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueALead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueALead.View = System.Windows.Forms.View.Details
        '
        'Lbl_LL
        '
        Me.Lbl_LL.AutoSize = True
        Me.Lbl_LL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_LL.Location = New System.Drawing.Point(532, 4)
        Me.Lbl_LL.Name = "Lbl_LL"
        Me.Lbl_LL.Size = New System.Drawing.Size(296, 29)
        Me.Lbl_LL.TabIndex = 34
        Me.Lbl_LL.Text = "Players League Leaders"
        '
        'Lbl_PLead
        '
        Me.Lbl_PLead.AutoSize = True
        Me.Lbl_PLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_PLead.Location = New System.Drawing.Point(24, 42)
        Me.Lbl_PLead.Name = "Lbl_PLead"
        Me.Lbl_PLead.Size = New System.Drawing.Size(174, 29)
        Me.Lbl_PLead.TabIndex = 33
        Me.Lbl_PLead.Text = "Points Leaders"
        '
        'LV_LeaguePLead
        '
        Me.LV_LeaguePLead.Enabled = False
        Me.LV_LeaguePLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeaguePLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeaguePLead.Location = New System.Drawing.Point(29, 74)
        Me.LV_LeaguePLead.Name = "LV_LeaguePLead"
        Me.LV_LeaguePLead.Scrollable = False
        Me.LV_LeaguePLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeaguePLead.TabIndex = 32
        Me.LV_LeaguePLead.TileSize = New System.Drawing.Size(215, 215)
        Me.LV_LeaguePLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeaguePLead.View = System.Windows.Forms.View.Details
        '
        'LeagueLeaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1500, 954)
        Me.Controls.Add(Me.Panel_Lead)
        Me.Name = "LeagueLeaders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LeagueLeaders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Lead.ResumeLayout(False)
        Me.Panel_Lead.PerformLayout()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Lead As System.Windows.Forms.Panel
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_GetLeaders As System.Windows.Forms.Button
    Friend WithEvents Lbl_FormBack As System.Windows.Forms.Label
    Friend WithEvents Lbl_BLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueBLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_SLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueSLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_RLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueRLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_ALead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueALead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_LL As System.Windows.Forms.Label
    Friend WithEvents Lbl_PLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeaguePLead As System.Windows.Forms.ListView
End Class
