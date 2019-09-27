<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamesVisionsMyTeamVsOthers
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GB_AwayT = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Lbl_DA50 = New System.Windows.Forms.Label()
        Me.Lbl_DA0 = New System.Windows.Forms.Label()
        Me.Lbl_Per = New System.Windows.Forms.Label()
        Me.Lbl_A100 = New System.Windows.Forms.Label()
        Me.Lbl_A0 = New System.Windows.Forms.Label()
        Me.Lbl_NP = New System.Windows.Forms.Label()
        Me.Lbl_P = New System.Windows.Forms.Label()
        Me.CB_ATname = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GB_HomeT = New System.Windows.Forms.GroupBox()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Lbl_DH50 = New System.Windows.Forms.Label()
        Me.Lbl_DH0 = New System.Windows.Forms.Label()
        Me.Lbl_H100 = New System.Windows.Forms.Label()
        Me.Lbl_H0 = New System.Windows.Forms.Label()
        Me.Lbl_NP2 = New System.Windows.Forms.Label()
        Me.Lbl_P2 = New System.Windows.Forms.Label()
        Me.CB_HTname = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Lbl_VS = New System.Windows.Forms.Label()
        Me.Btn_NaiveBayes = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Message = New System.Windows.Forms.Label()
        Me.Pic_Help = New System.Windows.Forms.PictureBox()
        Me.GB_AwayT.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_HomeT.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_AwayT
        '
        Me.GB_AwayT.Controls.Add(Me.Chart1)
        Me.GB_AwayT.Controls.Add(Me.Lbl_DA50)
        Me.GB_AwayT.Controls.Add(Me.Lbl_DA0)
        Me.GB_AwayT.Controls.Add(Me.Lbl_Per)
        Me.GB_AwayT.Controls.Add(Me.Lbl_A100)
        Me.GB_AwayT.Controls.Add(Me.Lbl_A0)
        Me.GB_AwayT.Controls.Add(Me.Lbl_NP)
        Me.GB_AwayT.Controls.Add(Me.Lbl_P)
        Me.GB_AwayT.Controls.Add(Me.CB_ATname)
        Me.GB_AwayT.Controls.Add(Me.DataGridView2)
        Me.GB_AwayT.Location = New System.Drawing.Point(2, 3)
        Me.GB_AwayT.Name = "GB_AwayT"
        Me.GB_AwayT.Size = New System.Drawing.Size(940, 1001)
        Me.GB_AwayT.TabIndex = 0
        Me.GB_AwayT.TabStop = False
        Me.GB_AwayT.Text = "Away Team"
        '
        'Chart1
        '
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(44, 531)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 5
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.MarkerColor = System.Drawing.Color.Black
        Series1.MarkerSize = 10
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Empty
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(657, 425)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'Lbl_DA50
        '
        Me.Lbl_DA50.AutoSize = True
        Me.Lbl_DA50.Location = New System.Drawing.Point(526, 503)
        Me.Lbl_DA50.Name = "Lbl_DA50"
        Me.Lbl_DA50.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_DA50.TabIndex = 12
        Me.Lbl_DA50.Text = "Above50"
        Me.Lbl_DA50.Visible = False
        '
        'Lbl_DA0
        '
        Me.Lbl_DA0.AutoSize = True
        Me.Lbl_DA0.Location = New System.Drawing.Point(416, 501)
        Me.Lbl_DA0.Name = "Lbl_DA0"
        Me.Lbl_DA0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_DA0.TabIndex = 11
        Me.Lbl_DA0.Text = "Above0"
        Me.Lbl_DA0.Visible = False
        '
        'Lbl_Per
        '
        Me.Lbl_Per.AutoSize = True
        Me.Lbl_Per.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Per.Location = New System.Drawing.Point(790, 778)
        Me.Lbl_Per.Name = "Lbl_Per"
        Me.Lbl_Per.Size = New System.Drawing.Size(37, 23)
        Me.Lbl_Per.TabIndex = 10
        Me.Lbl_Per.Text = "0 %"
        Me.Lbl_Per.Visible = False
        '
        'Lbl_A100
        '
        Me.Lbl_A100.AutoSize = True
        Me.Lbl_A100.Location = New System.Drawing.Point(526, 465)
        Me.Lbl_A100.Name = "Lbl_A100"
        Me.Lbl_A100.Size = New System.Drawing.Size(72, 17)
        Me.Lbl_A100.TabIndex = 9
        Me.Lbl_A100.Text = "Above100"
        Me.Lbl_A100.Visible = False
        '
        'Lbl_A0
        '
        Me.Lbl_A0.AutoSize = True
        Me.Lbl_A0.Location = New System.Drawing.Point(416, 465)
        Me.Lbl_A0.Name = "Lbl_A0"
        Me.Lbl_A0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_A0.TabIndex = 8
        Me.Lbl_A0.Text = "Above0"
        Me.Lbl_A0.Visible = False
        '
        'Lbl_NP
        '
        Me.Lbl_NP.AutoSize = True
        Me.Lbl_NP.Location = New System.Drawing.Point(289, 462)
        Me.Lbl_NP.Name = "Lbl_NP"
        Me.Lbl_NP.Size = New System.Drawing.Size(76, 17)
        Me.Lbl_NP.TabIndex = 5
        Me.Lbl_NP.Text = "Not played"
        Me.Lbl_NP.Visible = False
        '
        'Lbl_P
        '
        Me.Lbl_P.AutoSize = True
        Me.Lbl_P.Location = New System.Drawing.Point(52, 462)
        Me.Lbl_P.Name = "Lbl_P"
        Me.Lbl_P.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_P.TabIndex = 4
        Me.Lbl_P.Text = "Played"
        Me.Lbl_P.Visible = False
        '
        'CB_ATname
        '
        Me.CB_ATname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_ATname.FormattingEnabled = True
        Me.CB_ATname.Location = New System.Drawing.Point(194, 11)
        Me.CB_ATname.Name = "CB_ATname"
        Me.CB_ATname.Size = New System.Drawing.Size(417, 33)
        Me.CB_ATname.TabIndex = 3
        Me.CB_ATname.Tag = ""
        Me.CB_ATname.Text = "Away team"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 55)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(790, 371)
        Me.DataGridView2.TabIndex = 2
        '
        'GB_HomeT
        '
        Me.GB_HomeT.Controls.Add(Me.Chart2)
        Me.GB_HomeT.Controls.Add(Me.Lbl_DH50)
        Me.GB_HomeT.Controls.Add(Me.Lbl_DH0)
        Me.GB_HomeT.Controls.Add(Me.Lbl_H100)
        Me.GB_HomeT.Controls.Add(Me.Lbl_H0)
        Me.GB_HomeT.Controls.Add(Me.Lbl_NP2)
        Me.GB_HomeT.Controls.Add(Me.Lbl_P2)
        Me.GB_HomeT.Controls.Add(Me.CB_HTname)
        Me.GB_HomeT.Controls.Add(Me.DataGridView1)
        Me.GB_HomeT.Location = New System.Drawing.Point(1029, 3)
        Me.GB_HomeT.Name = "GB_HomeT"
        Me.GB_HomeT.Size = New System.Drawing.Size(872, 1001)
        Me.GB_HomeT.TabIndex = 1
        Me.GB_HomeT.TabStop = False
        Me.GB_HomeT.Text = "Home Team"
        '
        'Chart2
        '
        ChartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(45, 531)
        Me.Chart2.Name = "Chart2"
        Series2.BorderWidth = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.IsXValueIndexed = True
        Series2.Legend = "Legend1"
        Series2.MarkerColor = System.Drawing.Color.Black
        Series2.MarkerSize = 10
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series2.Name = "Series2"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series2.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Empty
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(657, 425)
        Me.Chart2.TabIndex = 6
        Me.Chart2.Text = "Chart2"
        '
        'Lbl_DH50
        '
        Me.Lbl_DH50.AutoSize = True
        Me.Lbl_DH50.Location = New System.Drawing.Point(534, 491)
        Me.Lbl_DH50.Name = "Lbl_DH50"
        Me.Lbl_DH50.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_DH50.TabIndex = 15
        Me.Lbl_DH50.Text = "Above50"
        Me.Lbl_DH50.Visible = False
        '
        'Lbl_DH0
        '
        Me.Lbl_DH0.AutoSize = True
        Me.Lbl_DH0.Location = New System.Drawing.Point(434, 491)
        Me.Lbl_DH0.Name = "Lbl_DH0"
        Me.Lbl_DH0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_DH0.TabIndex = 14
        Me.Lbl_DH0.Text = "Above0"
        Me.Lbl_DH0.Visible = False
        '
        'Lbl_H100
        '
        Me.Lbl_H100.AutoSize = True
        Me.Lbl_H100.Location = New System.Drawing.Point(534, 459)
        Me.Lbl_H100.Name = "Lbl_H100"
        Me.Lbl_H100.Size = New System.Drawing.Size(72, 17)
        Me.Lbl_H100.TabIndex = 13
        Me.Lbl_H100.Text = "Above100"
        Me.Lbl_H100.Visible = False
        '
        'Lbl_H0
        '
        Me.Lbl_H0.AutoSize = True
        Me.Lbl_H0.Location = New System.Drawing.Point(434, 459)
        Me.Lbl_H0.Name = "Lbl_H0"
        Me.Lbl_H0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_H0.TabIndex = 12
        Me.Lbl_H0.Text = "Above0"
        Me.Lbl_H0.Visible = False
        '
        'Lbl_NP2
        '
        Me.Lbl_NP2.AutoSize = True
        Me.Lbl_NP2.Location = New System.Drawing.Point(317, 459)
        Me.Lbl_NP2.Name = "Lbl_NP2"
        Me.Lbl_NP2.Size = New System.Drawing.Size(76, 17)
        Me.Lbl_NP2.TabIndex = 11
        Me.Lbl_NP2.Text = "Not played"
        Me.Lbl_NP2.Visible = False
        '
        'Lbl_P2
        '
        Me.Lbl_P2.AutoSize = True
        Me.Lbl_P2.Location = New System.Drawing.Point(42, 459)
        Me.Lbl_P2.Name = "Lbl_P2"
        Me.Lbl_P2.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_P2.TabIndex = 10
        Me.Lbl_P2.Text = "Played"
        Me.Lbl_P2.Visible = False
        '
        'CB_HTname
        '
        Me.CB_HTname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.CB_HTname.FormattingEnabled = True
        Me.CB_HTname.Location = New System.Drawing.Point(219, 11)
        Me.CB_HTname.Name = "CB_HTname"
        Me.CB_HTname.Size = New System.Drawing.Size(417, 33)
        Me.CB_HTname.TabIndex = 4
        Me.CB_HTname.Tag = ""
        Me.CB_HTname.Text = "Home team"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(790, 371)
        Me.DataGridView1.TabIndex = 3
        '
        'Lbl_VS
        '
        Me.Lbl_VS.AutoSize = True
        Me.Lbl_VS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Lbl_VS.Location = New System.Drawing.Point(964, 494)
        Me.Lbl_VS.Name = "Lbl_VS"
        Me.Lbl_VS.Size = New System.Drawing.Size(46, 29)
        Me.Lbl_VS.TabIndex = 2
        Me.Lbl_VS.Text = "VS"
        '
        'Btn_NaiveBayes
        '
        Me.Btn_NaiveBayes.Location = New System.Drawing.Point(948, 534)
        Me.Btn_NaiveBayes.Name = "Btn_NaiveBayes"
        Me.Btn_NaiveBayes.Size = New System.Drawing.Size(75, 84)
        Me.Btn_NaiveBayes.TabIndex = 3
        Me.Btn_NaiveBayes.Text = "Start Vision"
        Me.Btn_NaiveBayes.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(795, 752)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(273, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 10
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'Lbl_Message
        '
        Me.Lbl_Message.AutoSize = True
        Me.Lbl_Message.Font = New System.Drawing.Font("Arial", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Message.Location = New System.Drawing.Point(881, 727)
        Me.Lbl_Message.Name = "Lbl_Message"
        Me.Lbl_Message.Size = New System.Drawing.Size(127, 19)
        Me.Lbl_Message.TabIndex = 11
        Me.Lbl_Message.Text = "Collect the data"
        Me.Lbl_Message.Visible = False
        '
        'Pic_Help
        '
        Me.Pic_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Help.Image = Global.BasicBasketballSql.My.Resources.Resources.help
        Me.Pic_Help.Location = New System.Drawing.Point(948, 286)
        Me.Pic_Help.Name = "Pic_Help"
        Me.Pic_Help.Size = New System.Drawing.Size(68, 61)
        Me.Pic_Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Help.TabIndex = 25
        Me.Pic_Help.TabStop = False
        '
        'GamesVisionsMyTeamVsOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1920, 1051)
        Me.Controls.Add(Me.Pic_Help)
        Me.Controls.Add(Me.Lbl_Message)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Btn_NaiveBayes)
        Me.Controls.Add(Me.Lbl_VS)
        Me.Controls.Add(Me.GB_HomeT)
        Me.Controls.Add(Me.GB_AwayT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "GamesVisionsMyTeamVsOthers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GamesVisionsMyTeamVsOthers"
        Me.GB_AwayT.ResumeLayout(False)
        Me.GB_AwayT.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_HomeT.ResumeLayout(False)
        Me.GB_HomeT.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Help, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_AwayT As System.Windows.Forms.GroupBox
    Friend WithEvents GB_HomeT As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_VS As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CB_ATname As System.Windows.Forms.ComboBox
    Friend WithEvents CB_HTname As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_NaiveBayes As System.Windows.Forms.Button
    Friend WithEvents Lbl_P As System.Windows.Forms.Label
    Friend WithEvents Lbl_NP As System.Windows.Forms.Label
    Friend WithEvents Lbl_P2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_NP2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_A100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_A0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_H100 As System.Windows.Forms.Label
    Friend WithEvents Lbl_H0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Per As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbl_Message As System.Windows.Forms.Label
    Friend WithEvents Lbl_DA50 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DA0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DH0 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DH50 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Pic_Help As System.Windows.Forms.PictureBox
End Class
