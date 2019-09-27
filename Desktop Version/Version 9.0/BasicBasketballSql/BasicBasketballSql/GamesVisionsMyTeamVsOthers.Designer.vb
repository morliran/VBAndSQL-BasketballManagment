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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Lbl_DA50 = New System.Windows.Forms.Label()
        Me.Lbl_DA0 = New System.Windows.Forms.Label()
        Me.Lbl_Per = New System.Windows.Forms.Label()
        Me.Lbl_A100 = New System.Windows.Forms.Label()
        Me.Lbl_A0 = New System.Windows.Forms.Label()
        Me.Lbl_NP = New System.Windows.Forms.Label()
        Me.Lbl_P = New System.Windows.Forms.Label()
        Me.CB_ATname = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Lbl_DH50 = New System.Windows.Forms.Label()
        Me.Lbl_DH0 = New System.Windows.Forms.Label()
        Me.Lbl_H100 = New System.Windows.Forms.Label()
        Me.Lbl_H0 = New System.Windows.Forms.Label()
        Me.Lbl_NP2 = New System.Windows.Forms.Label()
        Me.Lbl_P2 = New System.Windows.Forms.Label()
        Me.CB_HTname = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Btn_NaiveBayes = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Message = New System.Windows.Forms.Label()
        Me.Lbl_CheckBack = New System.Windows.Forms.Label()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Panel_Buttom = New System.Windows.Forms.Panel()
        Me.Panel_Left = New System.Windows.Forms.Panel()
        Me.FLP_Buttons = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Help = New System.Windows.Forms.Button()
        Me.FLP_Grids = New System.Windows.Forms.FlowLayoutPanel()
        Me.FLP_Away = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel_Split = New System.Windows.Forms.Panel()
        Me.FLP_Home = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Top.SuspendLayout()
        Me.Panel_Buttom.SuspendLayout()
        Me.Panel_Left.SuspendLayout()
        Me.FLP_Buttons.SuspendLayout()
        Me.FLP_Grids.SuspendLayout()
        Me.FLP_Away.SuspendLayout()
        Me.FLP_Home.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 272)
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
        Me.Chart1.Size = New System.Drawing.Size(790, 373)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'Lbl_DA50
        '
        Me.Lbl_DA50.AutoSize = True
        Me.Lbl_DA50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_DA50.ForeColor = System.Drawing.Color.White
        Me.Lbl_DA50.Location = New System.Drawing.Point(441, 9)
        Me.Lbl_DA50.Name = "Lbl_DA50"
        Me.Lbl_DA50.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_DA50.TabIndex = 12
        Me.Lbl_DA50.Text = "Above50"
        Me.Lbl_DA50.Visible = False
        '
        'Lbl_DA0
        '
        Me.Lbl_DA0.AutoSize = True
        Me.Lbl_DA0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_DA0.ForeColor = System.Drawing.Color.White
        Me.Lbl_DA0.Location = New System.Drawing.Point(379, 9)
        Me.Lbl_DA0.Name = "Lbl_DA0"
        Me.Lbl_DA0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_DA0.TabIndex = 11
        Me.Lbl_DA0.Text = "Above0"
        Me.Lbl_DA0.Visible = False
        '
        'Lbl_Per
        '
        Me.Lbl_Per.AutoSize = True
        Me.Lbl_Per.Font = New System.Drawing.Font("Narkisim", 16.0!)
        Me.Lbl_Per.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Per.Location = New System.Drawing.Point(1205, 46)
        Me.Lbl_Per.Name = "Lbl_Per"
        Me.Lbl_Per.Size = New System.Drawing.Size(49, 27)
        Me.Lbl_Per.TabIndex = 10
        Me.Lbl_Per.Text = "0 %"
        Me.Lbl_Per.Visible = False
        '
        'Lbl_A100
        '
        Me.Lbl_A100.AutoSize = True
        Me.Lbl_A100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_A100.ForeColor = System.Drawing.Color.White
        Me.Lbl_A100.Location = New System.Drawing.Point(301, 9)
        Me.Lbl_A100.Name = "Lbl_A100"
        Me.Lbl_A100.Size = New System.Drawing.Size(72, 17)
        Me.Lbl_A100.TabIndex = 9
        Me.Lbl_A100.Text = "Above100"
        Me.Lbl_A100.Visible = False
        '
        'Lbl_A0
        '
        Me.Lbl_A0.AutoSize = True
        Me.Lbl_A0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_A0.ForeColor = System.Drawing.Color.White
        Me.Lbl_A0.Location = New System.Drawing.Point(239, 9)
        Me.Lbl_A0.Name = "Lbl_A0"
        Me.Lbl_A0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_A0.TabIndex = 8
        Me.Lbl_A0.Text = "Above0"
        Me.Lbl_A0.Visible = False
        '
        'Lbl_NP
        '
        Me.Lbl_NP.AutoSize = True
        Me.Lbl_NP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_NP.ForeColor = System.Drawing.Color.White
        Me.Lbl_NP.Location = New System.Drawing.Point(149, 9)
        Me.Lbl_NP.Name = "Lbl_NP"
        Me.Lbl_NP.Size = New System.Drawing.Size(76, 17)
        Me.Lbl_NP.TabIndex = 5
        Me.Lbl_NP.Text = "Not played"
        Me.Lbl_NP.Visible = False
        '
        'Lbl_P
        '
        Me.Lbl_P.AutoSize = True
        Me.Lbl_P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_P.ForeColor = System.Drawing.Color.White
        Me.Lbl_P.Location = New System.Drawing.Point(92, 9)
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
        Me.CB_ATname.Location = New System.Drawing.Point(3, 3)
        Me.CB_ATname.Name = "CB_ATname"
        Me.CB_ATname.Size = New System.Drawing.Size(417, 33)
        Me.CB_ATname.TabIndex = 2
        Me.CB_ATname.Tag = ""
        Me.CB_ATname.Text = "Away team"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Narkisim", 13.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Narkisim", 13.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(827, 224)
        Me.DataGridView1.TabIndex = 4
        '
        'Chart2
        '
        ChartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.BackColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(3, 272)
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
        Me.Chart2.Size = New System.Drawing.Size(790, 373)
        Me.Chart2.TabIndex = 7
        Me.Chart2.Text = "Chart2"
        '
        'Lbl_DH50
        '
        Me.Lbl_DH50.AutoSize = True
        Me.Lbl_DH50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_DH50.ForeColor = System.Drawing.Color.White
        Me.Lbl_DH50.Location = New System.Drawing.Point(912, 9)
        Me.Lbl_DH50.Name = "Lbl_DH50"
        Me.Lbl_DH50.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_DH50.TabIndex = 15
        Me.Lbl_DH50.Text = "Above50"
        Me.Lbl_DH50.Visible = False
        '
        'Lbl_DH0
        '
        Me.Lbl_DH0.AutoSize = True
        Me.Lbl_DH0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_DH0.ForeColor = System.Drawing.Color.White
        Me.Lbl_DH0.Location = New System.Drawing.Point(850, 9)
        Me.Lbl_DH0.Name = "Lbl_DH0"
        Me.Lbl_DH0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_DH0.TabIndex = 14
        Me.Lbl_DH0.Text = "Above0"
        Me.Lbl_DH0.Visible = False
        '
        'Lbl_H100
        '
        Me.Lbl_H100.AutoSize = True
        Me.Lbl_H100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_H100.ForeColor = System.Drawing.Color.White
        Me.Lbl_H100.Location = New System.Drawing.Point(772, 9)
        Me.Lbl_H100.Name = "Lbl_H100"
        Me.Lbl_H100.Size = New System.Drawing.Size(72, 17)
        Me.Lbl_H100.TabIndex = 13
        Me.Lbl_H100.Text = "Above100"
        Me.Lbl_H100.Visible = False
        '
        'Lbl_H0
        '
        Me.Lbl_H0.AutoSize = True
        Me.Lbl_H0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_H0.ForeColor = System.Drawing.Color.White
        Me.Lbl_H0.Location = New System.Drawing.Point(706, 9)
        Me.Lbl_H0.Name = "Lbl_H0"
        Me.Lbl_H0.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_H0.TabIndex = 12
        Me.Lbl_H0.Text = "Above0"
        Me.Lbl_H0.Visible = False
        '
        'Lbl_NP2
        '
        Me.Lbl_NP2.AutoSize = True
        Me.Lbl_NP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_NP2.ForeColor = System.Drawing.Color.White
        Me.Lbl_NP2.Location = New System.Drawing.Point(624, 9)
        Me.Lbl_NP2.Name = "Lbl_NP2"
        Me.Lbl_NP2.Size = New System.Drawing.Size(76, 17)
        Me.Lbl_NP2.TabIndex = 11
        Me.Lbl_NP2.Text = "Not played"
        Me.Lbl_NP2.Visible = False
        '
        'Lbl_P2
        '
        Me.Lbl_P2.AutoSize = True
        Me.Lbl_P2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_P2.ForeColor = System.Drawing.Color.White
        Me.Lbl_P2.Location = New System.Drawing.Point(558, 9)
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
        Me.CB_HTname.Location = New System.Drawing.Point(3, 3)
        Me.CB_HTname.Name = "CB_HTname"
        Me.CB_HTname.Size = New System.Drawing.Size(417, 33)
        Me.CB_HTname.TabIndex = 3
        Me.CB_HTname.Tag = ""
        Me.CB_HTname.Text = "Home team"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Narkisim", 13.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Narkisim", 13.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Location = New System.Drawing.Point(3, 42)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(827, 224)
        Me.DataGridView2.TabIndex = 5
        '
        'Btn_NaiveBayes
        '
        Me.Btn_NaiveBayes.FlatAppearance.BorderSize = 0
        Me.Btn_NaiveBayes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_NaiveBayes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Btn_NaiveBayes.Location = New System.Drawing.Point(3, 3)
        Me.Btn_NaiveBayes.Name = "Btn_NaiveBayes"
        Me.Btn_NaiveBayes.Size = New System.Drawing.Size(147, 84)
        Me.Btn_NaiveBayes.TabIndex = 0
        Me.Btn_NaiveBayes.Text = "Start Vision"
        Me.Btn_NaiveBayes.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(726, 48)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(455, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'Lbl_Message
        '
        Me.Lbl_Message.AutoSize = True
        Me.Lbl_Message.Font = New System.Drawing.Font("Narkisim", 16.0!)
        Me.Lbl_Message.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Message.Location = New System.Drawing.Point(848, 17)
        Me.Lbl_Message.Name = "Lbl_Message"
        Me.Lbl_Message.Size = New System.Drawing.Size(177, 27)
        Me.Lbl_Message.TabIndex = 8
        Me.Lbl_Message.Text = "Collect the data"
        Me.Lbl_Message.Visible = False
        '
        'Lbl_CheckBack
        '
        Me.Lbl_CheckBack.AutoSize = True
        Me.Lbl_CheckBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_CheckBack.ForeColor = System.Drawing.Color.White
        Me.Lbl_CheckBack.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_CheckBack.Name = "Lbl_CheckBack"
        Me.Lbl_CheckBack.Size = New System.Drawing.Size(74, 17)
        Me.Lbl_CheckBack.TabIndex = 26
        Me.Lbl_CheckBack.Text = "Form back"
        Me.Lbl_CheckBack.Visible = False
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Top.Controls.Add(Me.Lbl_CheckBack)
        Me.Panel_Top.Controls.Add(Me.Lbl_DH50)
        Me.Panel_Top.Controls.Add(Me.Lbl_P)
        Me.Panel_Top.Controls.Add(Me.Lbl_DH0)
        Me.Panel_Top.Controls.Add(Me.Lbl_DA50)
        Me.Panel_Top.Controls.Add(Me.Lbl_H100)
        Me.Panel_Top.Controls.Add(Me.Lbl_NP)
        Me.Panel_Top.Controls.Add(Me.Lbl_H0)
        Me.Panel_Top.Controls.Add(Me.Lbl_DA0)
        Me.Panel_Top.Controls.Add(Me.Lbl_NP2)
        Me.Panel_Top.Controls.Add(Me.Lbl_A0)
        Me.Panel_Top.Controls.Add(Me.Lbl_P2)
        Me.Panel_Top.Controls.Add(Me.Lbl_A100)
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(1882, 35)
        Me.Panel_Top.TabIndex = 26
        '
        'Panel_Buttom
        '
        Me.Panel_Buttom.BackColor = System.Drawing.Color.White
        Me.Panel_Buttom.Controls.Add(Me.ProgressBar1)
        Me.Panel_Buttom.Controls.Add(Me.Lbl_Per)
        Me.Panel_Buttom.Controls.Add(Me.Lbl_Message)
        Me.Panel_Buttom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Buttom.Location = New System.Drawing.Point(162, 973)
        Me.Panel_Buttom.Name = "Panel_Buttom"
        Me.Panel_Buttom.Size = New System.Drawing.Size(1720, 78)
        Me.Panel_Buttom.TabIndex = 27
        '
        'Panel_Left
        '
        Me.Panel_Left.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_Left.Controls.Add(Me.FLP_Buttons)
        Me.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Left.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Panel_Left.ForeColor = System.Drawing.Color.Transparent
        Me.Panel_Left.Location = New System.Drawing.Point(0, 35)
        Me.Panel_Left.Name = "Panel_Left"
        Me.Panel_Left.Size = New System.Drawing.Size(162, 1016)
        Me.Panel_Left.TabIndex = 28
        '
        'FLP_Buttons
        '
        Me.FLP_Buttons.Controls.Add(Me.Btn_NaiveBayes)
        Me.FLP_Buttons.Controls.Add(Me.Btn_Help)
        Me.FLP_Buttons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Buttons.Location = New System.Drawing.Point(3, 78)
        Me.FLP_Buttons.Name = "FLP_Buttons"
        Me.FLP_Buttons.Size = New System.Drawing.Size(153, 191)
        Me.FLP_Buttons.TabIndex = 4
        '
        'Btn_Help
        '
        Me.Btn_Help.FlatAppearance.BorderSize = 0
        Me.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Help.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Help.Location = New System.Drawing.Point(3, 93)
        Me.Btn_Help.Name = "Btn_Help"
        Me.Btn_Help.Size = New System.Drawing.Size(147, 84)
        Me.Btn_Help.TabIndex = 1
        Me.Btn_Help.Text = "Help"
        Me.Btn_Help.UseVisualStyleBackColor = True
        '
        'FLP_Grids
        '
        Me.FLP_Grids.BackColor = System.Drawing.Color.White
        Me.FLP_Grids.Controls.Add(Me.FLP_Away)
        Me.FLP_Grids.Controls.Add(Me.Panel_Split)
        Me.FLP_Grids.Controls.Add(Me.FLP_Home)
        Me.FLP_Grids.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP_Grids.Font = New System.Drawing.Font("Narkisim", 13.0!)
        Me.FLP_Grids.Location = New System.Drawing.Point(162, 35)
        Me.FLP_Grids.Name = "FLP_Grids"
        Me.FLP_Grids.Size = New System.Drawing.Size(1720, 938)
        Me.FLP_Grids.TabIndex = 29
        '
        'FLP_Away
        '
        Me.FLP_Away.BackColor = System.Drawing.Color.Transparent
        Me.FLP_Away.Controls.Add(Me.CB_ATname)
        Me.FLP_Away.Controls.Add(Me.DataGridView1)
        Me.FLP_Away.Controls.Add(Me.Chart1)
        Me.FLP_Away.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Away.Location = New System.Drawing.Point(3, 3)
        Me.FLP_Away.Name = "FLP_Away"
        Me.FLP_Away.Size = New System.Drawing.Size(843, 929)
        Me.FLP_Away.TabIndex = 0
        '
        'Panel_Split
        '
        Me.Panel_Split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Split.Location = New System.Drawing.Point(852, 3)
        Me.Panel_Split.Name = "Panel_Split"
        Me.Panel_Split.Size = New System.Drawing.Size(1, 929)
        Me.Panel_Split.TabIndex = 6
        '
        'FLP_Home
        '
        Me.FLP_Home.BackColor = System.Drawing.Color.Transparent
        Me.FLP_Home.Controls.Add(Me.CB_HTname)
        Me.FLP_Home.Controls.Add(Me.DataGridView2)
        Me.FLP_Home.Controls.Add(Me.Chart2)
        Me.FLP_Home.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FLP_Home.Location = New System.Drawing.Point(859, 3)
        Me.FLP_Home.Name = "FLP_Home"
        Me.FLP_Home.Size = New System.Drawing.Size(843, 929)
        Me.FLP_Home.TabIndex = 1
        '
        'GamesVisionsMyTeamVsOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1882, 1051)
        Me.Controls.Add(Me.FLP_Grids)
        Me.Controls.Add(Me.Panel_Buttom)
        Me.Controls.Add(Me.Panel_Left)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "GamesVisionsMyTeamVsOthers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GamesVisionsMyTeamVsOthers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Top.ResumeLayout(False)
        Me.Panel_Top.PerformLayout()
        Me.Panel_Buttom.ResumeLayout(False)
        Me.Panel_Buttom.PerformLayout()
        Me.Panel_Left.ResumeLayout(False)
        Me.FLP_Buttons.ResumeLayout(False)
        Me.FLP_Grids.ResumeLayout(False)
        Me.FLP_Away.ResumeLayout(False)
        Me.FLP_Home.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
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
    Friend WithEvents Lbl_CheckBack As System.Windows.Forms.Label
    Friend WithEvents Panel_Top As System.Windows.Forms.Panel
    Friend WithEvents Panel_Buttom As System.Windows.Forms.Panel
    Friend WithEvents Panel_Left As System.Windows.Forms.Panel
    Friend WithEvents FLP_Grids As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FLP_Away As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FLP_Home As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel_Split As System.Windows.Forms.Panel
    Friend WithEvents FLP_Buttons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Btn_Help As System.Windows.Forms.Button
End Class
