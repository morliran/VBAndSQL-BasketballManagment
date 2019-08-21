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
        Me.Lbl_Guest = New System.Windows.Forms.Label()
        Me.Btn_QueryBuild = New System.Windows.Forms.Button()
        Me.Btn_LeagueLeaders = New System.Windows.Forms.Button()
        Me.Btn_GuestQ = New System.Windows.Forms.Button()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_Guest
        '
        Me.Lbl_Guest.AutoSize = True
        Me.Lbl_Guest.Location = New System.Drawing.Point(12, 5)
        Me.Lbl_Guest.Name = "Lbl_Guest"
        Me.Lbl_Guest.Size = New System.Drawing.Size(46, 17)
        Me.Lbl_Guest.TabIndex = 13
        Me.Lbl_Guest.Text = "Guest"
        Me.Lbl_Guest.Visible = False
        '
        'Btn_QueryBuild
        '
        Me.Btn_QueryBuild.Location = New System.Drawing.Point(211, 214)
        Me.Btn_QueryBuild.Name = "Btn_QueryBuild"
        Me.Btn_QueryBuild.Size = New System.Drawing.Size(140, 81)
        Me.Btn_QueryBuild.TabIndex = 18
        Me.Btn_QueryBuild.Text = "Build My Own Query"
        Me.Btn_QueryBuild.UseVisualStyleBackColor = True
        '
        'Btn_LeagueLeaders
        '
        Me.Btn_LeagueLeaders.Location = New System.Drawing.Point(364, 80)
        Me.Btn_LeagueLeaders.Name = "Btn_LeagueLeaders"
        Me.Btn_LeagueLeaders.Size = New System.Drawing.Size(140, 81)
        Me.Btn_LeagueLeaders.TabIndex = 19
        Me.Btn_LeagueLeaders.Text = "League leaders"
        Me.Btn_LeagueLeaders.UseVisualStyleBackColor = True
        '
        'Btn_GuestQ
        '
        Me.Btn_GuestQ.Location = New System.Drawing.Point(39, 78)
        Me.Btn_GuestQ.Name = "Btn_GuestQ"
        Me.Btn_GuestQ.Size = New System.Drawing.Size(140, 85)
        Me.Btn_GuestQ.TabIndex = 20
        Me.Btn_GuestQ.Text = "Guest Queries"
        Me.Btn_GuestQ.UseVisualStyleBackColor = True
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(492, 5)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 21
        Me.Pic_Help.TabStop = False
        '
        'GuestMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 325)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.Btn_GuestQ)
        Me.Controls.Add(Me.Btn_LeagueLeaders)
        Me.Controls.Add(Me.Btn_QueryBuild)
        Me.Controls.Add(Me.Lbl_Guest)
        Me.Name = "GuestMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Querys Menu"
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Guest As System.Windows.Forms.Label
    Friend WithEvents Btn_QueryBuild As System.Windows.Forms.Button
    Friend WithEvents Btn_LeagueLeaders As System.Windows.Forms.Button
    Friend WithEvents Btn_GuestQ As System.Windows.Forms.Button
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
