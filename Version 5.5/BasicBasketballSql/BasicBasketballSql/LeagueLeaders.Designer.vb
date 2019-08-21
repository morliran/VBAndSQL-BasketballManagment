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
        Me.LV_LeaguePLead = New System.Windows.Forms.ListView()
        Me.Lbl_PLead = New System.Windows.Forms.Label()
        Me.Lbl_LL = New System.Windows.Forms.Label()
        Me.Lbl_ALead = New System.Windows.Forms.Label()
        Me.LV_LeagueALead = New System.Windows.Forms.ListView()
        Me.Lbl_RLead = New System.Windows.Forms.Label()
        Me.LV_LeagueRLead = New System.Windows.Forms.ListView()
        Me.Lbl_SLead = New System.Windows.Forms.Label()
        Me.LV_LeagueSLead = New System.Windows.Forms.ListView()
        Me.Lbl_BLead = New System.Windows.Forms.Label()
        Me.LV_LeagueBLead = New System.Windows.Forms.ListView()
        Me.Lbl_FormBack = New System.Windows.Forms.Label()
        Me.Btn_GetLeaders = New System.Windows.Forms.Button()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV_LeaguePLead
        '
        Me.LV_LeaguePLead.Enabled = False
        Me.LV_LeaguePLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeaguePLead.Location = New System.Drawing.Point(24, 75)
        Me.LV_LeaguePLead.Name = "LV_LeaguePLead"
        Me.LV_LeaguePLead.Scrollable = False
        Me.LV_LeaguePLead.Size = New System.Drawing.Size(307, 270)
        Me.LV_LeaguePLead.TabIndex = 0
        Me.LV_LeaguePLead.TileSize = New System.Drawing.Size(215, 215)
        Me.LV_LeaguePLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeaguePLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_PLead
        '
        Me.Lbl_PLead.AutoSize = True
        Me.Lbl_PLead.Location = New System.Drawing.Point(21, 55)
        Me.Lbl_PLead.Name = "Lbl_PLead"
        Me.Lbl_PLead.Size = New System.Drawing.Size(103, 17)
        Me.Lbl_PLead.TabIndex = 1
        Me.Lbl_PLead.Text = "Points Leaders"
        '
        'Lbl_LL
        '
        Me.Lbl_LL.AutoSize = True
        Me.Lbl_LL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_LL.Location = New System.Drawing.Point(444, 9)
        Me.Lbl_LL.Name = "Lbl_LL"
        Me.Lbl_LL.Size = New System.Drawing.Size(296, 29)
        Me.Lbl_LL.TabIndex = 2
        Me.Lbl_LL.Text = "Players League Leaders"
        '
        'Lbl_ALead
        '
        Me.Lbl_ALead.AutoSize = True
        Me.Lbl_ALead.Location = New System.Drawing.Point(446, 55)
        Me.Lbl_ALead.Name = "Lbl_ALead"
        Me.Lbl_ALead.Size = New System.Drawing.Size(101, 17)
        Me.Lbl_ALead.TabIndex = 4
        Me.Lbl_ALead.Text = "Assits Leaders"
        '
        'LV_LeagueALead
        '
        Me.LV_LeagueALead.Enabled = False
        Me.LV_LeagueALead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueALead.Location = New System.Drawing.Point(449, 75)
        Me.LV_LeagueALead.Name = "LV_LeagueALead"
        Me.LV_LeagueALead.Scrollable = False
        Me.LV_LeagueALead.Size = New System.Drawing.Size(307, 270)
        Me.LV_LeagueALead.TabIndex = 3
        Me.LV_LeagueALead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueALead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueALead.View = System.Windows.Forms.View.Details
        '
        'Lbl_RLead
        '
        Me.Lbl_RLead.AutoSize = True
        Me.Lbl_RLead.Location = New System.Drawing.Point(891, 55)
        Me.Lbl_RLead.Name = "Lbl_RLead"
        Me.Lbl_RLead.Size = New System.Drawing.Size(129, 17)
        Me.Lbl_RLead.TabIndex = 6
        Me.Lbl_RLead.Text = "Rebounds Leaders"
        '
        'LV_LeagueRLead
        '
        Me.LV_LeagueRLead.Enabled = False
        Me.LV_LeagueRLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueRLead.Location = New System.Drawing.Point(894, 75)
        Me.LV_LeagueRLead.Name = "LV_LeagueRLead"
        Me.LV_LeagueRLead.Scrollable = False
        Me.LV_LeagueRLead.Size = New System.Drawing.Size(316, 270)
        Me.LV_LeagueRLead.TabIndex = 5
        Me.LV_LeagueRLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueRLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueRLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_SLead
        '
        Me.Lbl_SLead.AutoSize = True
        Me.Lbl_SLead.Location = New System.Drawing.Point(31, 407)
        Me.Lbl_SLead.Name = "Lbl_SLead"
        Me.Lbl_SLead.Size = New System.Drawing.Size(103, 17)
        Me.Lbl_SLead.TabIndex = 8
        Me.Lbl_SLead.Text = "Steels Leaders"
        '
        'LV_LeagueSLead
        '
        Me.LV_LeagueSLead.Enabled = False
        Me.LV_LeagueSLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueSLead.Location = New System.Drawing.Point(34, 427)
        Me.LV_LeagueSLead.Name = "LV_LeagueSLead"
        Me.LV_LeagueSLead.Scrollable = False
        Me.LV_LeagueSLead.Size = New System.Drawing.Size(297, 283)
        Me.LV_LeagueSLead.TabIndex = 7
        Me.LV_LeagueSLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueSLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueSLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_BLead
        '
        Me.Lbl_BLead.AutoSize = True
        Me.Lbl_BLead.Location = New System.Drawing.Point(446, 407)
        Me.Lbl_BLead.Name = "Lbl_BLead"
        Me.Lbl_BLead.Size = New System.Drawing.Size(105, 17)
        Me.Lbl_BLead.TabIndex = 10
        Me.Lbl_BLead.Text = "Blocks Leaders"
        '
        'LV_LeagueBLead
        '
        Me.LV_LeagueBLead.Enabled = False
        Me.LV_LeagueBLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueBLead.Location = New System.Drawing.Point(449, 427)
        Me.LV_LeagueBLead.Name = "LV_LeagueBLead"
        Me.LV_LeagueBLead.Scrollable = False
        Me.LV_LeagueBLead.Size = New System.Drawing.Size(307, 283)
        Me.LV_LeagueBLead.TabIndex = 9
        Me.LV_LeagueBLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueBLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueBLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_FormBack
        '
        Me.Lbl_FormBack.AutoSize = True
        Me.Lbl_FormBack.Location = New System.Drawing.Point(31, 13)
        Me.Lbl_FormBack.Name = "Lbl_FormBack"
        Me.Lbl_FormBack.Size = New System.Drawing.Size(67, 17)
        Me.Lbl_FormBack.TabIndex = 11
        Me.Lbl_FormBack.Text = "Back to..."
        Me.Lbl_FormBack.Visible = False
        '
        'Btn_GetLeaders
        '
        Me.Btn_GetLeaders.Location = New System.Drawing.Point(923, 506)
        Me.Btn_GetLeaders.Name = "Btn_GetLeaders"
        Me.Btn_GetLeaders.Size = New System.Drawing.Size(210, 50)
        Me.Btn_GetLeaders.TabIndex = 12
        Me.Btn_GetLeaders.Text = "Show me teams leaders"
        Me.Btn_GetLeaders.UseVisualStyleBackColor = True
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(979, 407)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 31
        Me.Pic_Help.TabStop = False
        '
        'LeagueLeaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1373, 813)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.Btn_GetLeaders)
        Me.Controls.Add(Me.Lbl_FormBack)
        Me.Controls.Add(Me.Lbl_BLead)
        Me.Controls.Add(Me.LV_LeagueBLead)
        Me.Controls.Add(Me.Lbl_SLead)
        Me.Controls.Add(Me.LV_LeagueSLead)
        Me.Controls.Add(Me.Lbl_RLead)
        Me.Controls.Add(Me.LV_LeagueRLead)
        Me.Controls.Add(Me.Lbl_ALead)
        Me.Controls.Add(Me.LV_LeagueALead)
        Me.Controls.Add(Me.Lbl_LL)
        Me.Controls.Add(Me.Lbl_PLead)
        Me.Controls.Add(Me.LV_LeaguePLead)
        Me.Name = "LeagueLeaders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LeagueLeaders"
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV_LeaguePLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_PLead As System.Windows.Forms.Label
    Friend WithEvents Lbl_LL As System.Windows.Forms.Label
    Friend WithEvents Lbl_ALead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueALead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_RLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueRLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_SLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueSLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_BLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueBLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_FormBack As System.Windows.Forms.Label
    Friend WithEvents Btn_GetLeaders As System.Windows.Forms.Button
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
