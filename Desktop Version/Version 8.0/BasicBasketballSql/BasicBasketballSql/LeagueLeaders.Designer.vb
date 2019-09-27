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
        Me.Panel_Display = New System.Windows.Forms.Panel()
        Me.Lbl_ALead = New System.Windows.Forms.Label()
        Me.Lbl_BLead = New System.Windows.Forms.Label()
        Me.LV_LeagueBLead = New System.Windows.Forms.ListView()
        Me.Lbl_SLead = New System.Windows.Forms.Label()
        Me.LV_LeagueSLead = New System.Windows.Forms.ListView()
        Me.Lbl_RLead = New System.Windows.Forms.Label()
        Me.LV_LeagueRLead = New System.Windows.Forms.ListView()
        Me.LV_LeagueALead = New System.Windows.Forms.ListView()
        Me.Lbl_PLead = New System.Windows.Forms.Label()
        Me.LV_LeaguePLead = New System.Windows.Forms.ListView()
        Me.Lbl_FormBack = New System.Windows.Forms.Label()
        Me.Lbl_Welcome = New System.Windows.Forms.Label()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.FLP_Menu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_GetLeaders = New System.Windows.Forms.Button()
        Me.Btn_Help = New System.Windows.Forms.Button()
        Me.Panel_Right = New System.Windows.Forms.Panel()
        Me.Panel_Lead.SuspendLayout()
        Me.Panel_Display.SuspendLayout()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        Me.FLP_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Lead
        '
        Me.Panel_Lead.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Lead.Controls.Add(Me.Panel_Display)
        Me.Panel_Lead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Lead.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Lead.Name = "Panel_Lead"
        Me.Panel_Lead.Size = New System.Drawing.Size(1903, 1055)
        Me.Panel_Lead.TabIndex = 0
        '
        'Panel_Display
        '
        Me.Panel_Display.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Display.Controls.Add(Me.Lbl_ALead)
        Me.Panel_Display.Controls.Add(Me.Lbl_BLead)
        Me.Panel_Display.Controls.Add(Me.LV_LeagueBLead)
        Me.Panel_Display.Controls.Add(Me.Lbl_SLead)
        Me.Panel_Display.Controls.Add(Me.LV_LeagueSLead)
        Me.Panel_Display.Controls.Add(Me.Lbl_RLead)
        Me.Panel_Display.Controls.Add(Me.LV_LeagueRLead)
        Me.Panel_Display.Controls.Add(Me.LV_LeagueALead)
        Me.Panel_Display.Controls.Add(Me.Lbl_PLead)
        Me.Panel_Display.Controls.Add(Me.LV_LeaguePLead)
        Me.Panel_Display.Location = New System.Drawing.Point(216, 69)
        Me.Panel_Display.Name = "Panel_Display"
        Me.Panel_Display.Size = New System.Drawing.Size(1480, 974)
        Me.Panel_Display.TabIndex = 0
        '
        'Lbl_ALead
        '
        Me.Lbl_ALead.AutoSize = True
        Me.Lbl_ALead.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ALead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_ALead.ForeColor = System.Drawing.Color.Black
        Me.Lbl_ALead.Location = New System.Drawing.Point(502, 54)
        Me.Lbl_ALead.Name = "Lbl_ALead"
        Me.Lbl_ALead.Size = New System.Drawing.Size(285, 29)
        Me.Lbl_ALead.TabIndex = 49
        Me.Lbl_ALead.Text = "Assits Per Game Leaders"
        '
        'Lbl_BLead
        '
        Me.Lbl_BLead.AutoSize = True
        Me.Lbl_BLead.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_BLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_BLead.ForeColor = System.Drawing.Color.Black
        Me.Lbl_BLead.Location = New System.Drawing.Point(502, 509)
        Me.Lbl_BLead.Name = "Lbl_BLead"
        Me.Lbl_BLead.Size = New System.Drawing.Size(294, 29)
        Me.Lbl_BLead.TabIndex = 55
        Me.Lbl_BLead.Text = "Blocks Per Game Leaders"
        '
        'LV_LeagueBLead
        '
        Me.LV_LeagueBLead.Enabled = False
        Me.LV_LeagueBLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueBLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueBLead.Location = New System.Drawing.Point(507, 541)
        Me.LV_LeagueBLead.Name = "LV_LeagueBLead"
        Me.LV_LeagueBLead.Scrollable = False
        Me.LV_LeagueBLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueBLead.TabIndex = 54
        Me.LV_LeagueBLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueBLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueBLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_SLead
        '
        Me.Lbl_SLead.AutoSize = True
        Me.Lbl_SLead.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_SLead.ForeColor = System.Drawing.Color.Black
        Me.Lbl_SLead.Location = New System.Drawing.Point(19, 509)
        Me.Lbl_SLead.Name = "Lbl_SLead"
        Me.Lbl_SLead.Size = New System.Drawing.Size(290, 29)
        Me.Lbl_SLead.TabIndex = 53
        Me.Lbl_SLead.Text = "Steels Per Game Leaders"
        '
        'LV_LeagueSLead
        '
        Me.LV_LeagueSLead.Enabled = False
        Me.LV_LeagueSLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueSLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueSLead.Location = New System.Drawing.Point(24, 541)
        Me.LV_LeagueSLead.Name = "LV_LeagueSLead"
        Me.LV_LeagueSLead.Scrollable = False
        Me.LV_LeagueSLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueSLead.TabIndex = 52
        Me.LV_LeagueSLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueSLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueSLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_RLead
        '
        Me.Lbl_RLead.AutoSize = True
        Me.Lbl_RLead.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_RLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_RLead.ForeColor = System.Drawing.Color.Black
        Me.Lbl_RLead.Location = New System.Drawing.Point(981, 54)
        Me.Lbl_RLead.Name = "Lbl_RLead"
        Me.Lbl_RLead.Size = New System.Drawing.Size(333, 29)
        Me.Lbl_RLead.TabIndex = 51
        Me.Lbl_RLead.Text = "Rebounds Per Game Leaders"
        '
        'LV_LeagueRLead
        '
        Me.LV_LeagueRLead.Enabled = False
        Me.LV_LeagueRLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueRLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueRLead.Location = New System.Drawing.Point(986, 86)
        Me.LV_LeagueRLead.Name = "LV_LeagueRLead"
        Me.LV_LeagueRLead.Scrollable = False
        Me.LV_LeagueRLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueRLead.TabIndex = 50
        Me.LV_LeagueRLead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueRLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueRLead.View = System.Windows.Forms.View.Details
        '
        'LV_LeagueALead
        '
        Me.LV_LeagueALead.Enabled = False
        Me.LV_LeagueALead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeagueALead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeagueALead.Location = New System.Drawing.Point(507, 86)
        Me.LV_LeagueALead.Name = "LV_LeagueALead"
        Me.LV_LeagueALead.Scrollable = False
        Me.LV_LeagueALead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeagueALead.TabIndex = 48
        Me.LV_LeagueALead.TileSize = New System.Drawing.Size(215, 15)
        Me.LV_LeagueALead.UseCompatibleStateImageBehavior = False
        Me.LV_LeagueALead.View = System.Windows.Forms.View.Details
        '
        'Lbl_PLead
        '
        Me.Lbl_PLead.AutoSize = True
        Me.Lbl_PLead.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_PLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_PLead.ForeColor = System.Drawing.Color.Black
        Me.Lbl_PLead.Location = New System.Drawing.Point(19, 54)
        Me.Lbl_PLead.Name = "Lbl_PLead"
        Me.Lbl_PLead.Size = New System.Drawing.Size(289, 29)
        Me.Lbl_PLead.TabIndex = 47
        Me.Lbl_PLead.Text = "Points Per Game Leaders"
        '
        'LV_LeaguePLead
        '
        Me.LV_LeaguePLead.Enabled = False
        Me.LV_LeaguePLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.LV_LeaguePLead.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.LV_LeaguePLead.Location = New System.Drawing.Point(24, 86)
        Me.LV_LeaguePLead.Name = "LV_LeaguePLead"
        Me.LV_LeaguePLead.Scrollable = False
        Me.LV_LeaguePLead.Size = New System.Drawing.Size(460, 400)
        Me.LV_LeaguePLead.TabIndex = 46
        Me.LV_LeaguePLead.TileSize = New System.Drawing.Size(215, 215)
        Me.LV_LeaguePLead.UseCompatibleStateImageBehavior = False
        Me.LV_LeaguePLead.View = System.Windows.Forms.View.Details
        '
        'Lbl_FormBack
        '
        Me.Lbl_FormBack.AutoSize = True
        Me.Lbl_FormBack.ForeColor = System.Drawing.Color.White
        Me.Lbl_FormBack.Location = New System.Drawing.Point(92, 17)
        Me.Lbl_FormBack.Name = "Lbl_FormBack"
        Me.Lbl_FormBack.Size = New System.Drawing.Size(67, 17)
        Me.Lbl_FormBack.TabIndex = 43
        Me.Lbl_FormBack.Text = "Back to..."
        Me.Lbl_FormBack.Visible = False
        '
        'Lbl_Welcome
        '
        Me.Lbl_Welcome.AutoSize = True
        Me.Lbl_Welcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_Welcome.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Welcome.Location = New System.Drawing.Point(598, 9)
        Me.Lbl_Welcome.Name = "Lbl_Welcome"
        Me.Lbl_Welcome.Size = New System.Drawing.Size(329, 31)
        Me.Lbl_Welcome.TabIndex = 34
        Me.Lbl_Welcome.Text = "Players League Leaders"
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel_Top.Controls.Add(Me.Lbl_Welcome)
        Me.Panel_Top.Controls.Add(Me.Lbl_FormBack)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1903, 63)
        Me.Panel_Top.TabIndex = 1
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel_Left.Controls.Add(Me.FLP_Menu)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Location = New System.Drawing.Point(0, 63)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(210, 992)
        Me.Panel_Left.TabIndex = 3
        '
        'FLP_Menu
        '
        Me.FLP_Menu.Controls.Add(Me.Btn_GetLeaders)
        Me.FLP_Menu.Controls.Add(Me.Btn_Help)
        Me.FLP_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Menu.Location = New System.Drawing.Point(12, 283)
        Me.FLP_Menu.Name = "FLP_Menu"
        Me.FLP_Menu.Size = New System.Drawing.Size(178, 220)
        Me.FLP_Menu.TabIndex = 0
        '
        'Btn_GetLeaders
        '
        Me.Btn_GetLeaders.FlatAppearance.BorderSize = 0
        Me.Btn_GetLeaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_GetLeaders.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_GetLeaders.ForeColor = System.Drawing.Color.Black
        Me.Btn_GetLeaders.Location = New System.Drawing.Point(3, 3)
        Me.Btn_GetLeaders.Name = "Btn_GetLeaders"
        Me.Btn_GetLeaders.Size = New System.Drawing.Size(170, 131)
        Me.Btn_GetLeaders.TabIndex = 1
        Me.Btn_GetLeaders.Text = "Show me teams leaders"
        Me.Btn_GetLeaders.UseVisualStyleBackColor = True
        '
        'Btn_Help
        '
        Me.Btn_Help.FlatAppearance.BorderSize = 0
        Me.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Help.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Btn_Help.ForeColor = System.Drawing.Color.Black
        Me.Btn_Help.Location = New System.Drawing.Point(3, 140)
        Me.Btn_Help.Name = "Btn_Help"
        Me.Btn_Help.Size = New System.Drawing.Size(170, 66)
        Me.Btn_Help.TabIndex = 2
        Me.Btn_Help.Text = "Help"
        Me.Btn_Help.UseVisualStyleBackColor = True
        '
        'Panel_Right
        '
        Me.Panel_Right.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel_Right.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel_Right.Location = New System.Drawing.Point(1693, 63)
        Me.Panel_Right.Name = "Panel_Right"
        Me.Panel_Right.Size = New System.Drawing.Size(210, 992)
        Me.Panel_Right.TabIndex = 2
        '
        'LeagueLeaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1903, 1055)
        Me.Controls.Add(Me.Panel_Left)
        Me.Controls.Add(Me.Panel_Right)
        Me.Controls.Add(Me.Panel_Top)
        Me.Controls.Add(Me.Panel_Lead)
        Me.Name = "LeagueLeaders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LeagueLeaders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Lead.ResumeLayout(False)
        Me.Panel_Display.ResumeLayout(False)
        Me.Panel_Display.PerformLayout()
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.Panel_Left.ResumeLayout(False)
        Me.FLP_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Lead As System.Windows.Forms.Panel
    Friend WithEvents Lbl_FormBack As System.Windows.Forms.Label
    Friend WithEvents Lbl_Welcome As System.Windows.Forms.Label
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Panel_Left As System.Windows.Forms.Panel
    Friend WithEvents Panel_Display As System.Windows.Forms.Panel
    Friend WithEvents Lbl_ALead As System.Windows.Forms.Label
    Friend WithEvents Lbl_BLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueBLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_SLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueSLead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_RLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeagueRLead As System.Windows.Forms.ListView
    Friend WithEvents LV_LeagueALead As System.Windows.Forms.ListView
    Friend WithEvents Lbl_PLead As System.Windows.Forms.Label
    Friend WithEvents LV_LeaguePLead As System.Windows.Forms.ListView
    Friend WithEvents FLP_Menu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_GetLeaders As System.Windows.Forms.Button
    Friend WithEvents Btn_Help As System.Windows.Forms.Button
    Friend WithEvents Panel_Right As System.Windows.Forms.Panel
End Class
