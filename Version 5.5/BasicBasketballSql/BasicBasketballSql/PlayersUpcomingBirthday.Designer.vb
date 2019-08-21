<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayersUpcomingBirthday
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
        Me.LV_PlayersBirthdayView = New System.Windows.Forms.ListView()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LV_PlayersBirthdayView
        '
        Me.LV_PlayersBirthdayView.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LV_PlayersBirthdayView.GridLines = True
        Me.LV_PlayersBirthdayView.Location = New System.Drawing.Point(27, 22)
        Me.LV_PlayersBirthdayView.Name = "LV_PlayersBirthdayView"
        Me.LV_PlayersBirthdayView.Size = New System.Drawing.Size(667, 403)
        Me.LV_PlayersBirthdayView.TabIndex = 0
        Me.LV_PlayersBirthdayView.TileSize = New System.Drawing.Size(1, 1)
        Me.LV_PlayersBirthdayView.UseCompatibleStateImageBehavior = False
        Me.LV_PlayersBirthdayView.View = System.Windows.Forms.View.Details
        '
        'Pic_Help
        '
        Me.Pic_Help.BackColor = System.Drawing.Color.Transparent
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(758, 79)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 31
        Me.Pic_Help.TabStop = False
        '
        'PlayersUpcomingBirthday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(889, 463)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.LV_PlayersBirthdayView)
        Me.Name = "PlayersUpcomingBirthday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PlayersUpcomingBirthday"
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LV_PlayersBirthdayView As System.Windows.Forms.ListView
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
