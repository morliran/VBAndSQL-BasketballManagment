Public NotInheritable Class Accessibility 'Allowing using this class by his name only, like using Math
    'Public Shared Property Varible name As Varible type help me with less code lines because this varbile gets automatically Get and Set methods
    Public Shared Property Language As String = "Hebrew"
    Public Shared Property FontName As String = ""
    Public Shared Property FontSize As Integer = 1
    Public Shared Property AllForms As Boolean = False
    Private Sub New() 'Avoid allowing inheritable
    End Sub
    Public Shared Sub SetTheDesign(ByVal myCollection As Control.ControlCollection) 'Send controls collection inside form or panel etc... to apply for all of them the same accessibility design
        For Each control As Control In myCollection
            If control.HasChildren Then 'If the control has another control inside, call again to the function
                SetTheDesign(control.Controls)
            Else
                If FontSize = 1 AndAlso FontName.Equals("") Then
                    control.Font = New Font(control.Font.FontFamily.Name, control.Font.Size, control.Font.Style)
                Else
                    control.Font = New Font(FontName, FontSize, control.Font.Style)
                End If
            End If
        Next
    End Sub
    Public Shared Sub SetDesignToAllForms(ByVal Frm As Form)
        If AllForms = True Then
            SetTheDesign(Frm.Controls)
        End If
    End Sub
    Public Shared Sub SetDataGridDesign(ByVal DGV As DataGridView, ByVal UserType As Integer)
        Dim FirstC As String = "", SecondC As String = "", colName As String = "", i As Integer, j As Integer
        DGV.Visible = True
        DGV.EnableHeadersVisualStyles = False 'כדי לאפשר את שינוי העיצוב של כותרות העמודות
        DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
        DGV.ColumnHeadersDefaultCellStyle.Font = New Font(DGV.ColumnHeadersDefaultCellStyle.Font.FontFamily.Name, DGV.ColumnHeadersDefaultCellStyle.Font.Size, FontStyle.Bold)
        DGV.DefaultCellStyle.Font = New Font(DGV.DefaultCellStyle.Font.FontFamily.Name, DGV.DefaultCellStyle.Font.Size, FontStyle.Bold)
        For i = 0 To DGV.Columns.Count - 1
            If DGV.Columns(i).Name.Contains("Height") Then
                colName = DGV.Columns(i).Name
                DGV.Columns(colName).DefaultCellStyle.Format = "N2" 'הצגת עמודת גובה בפורמט 0.00
            End If
        Next
        If UserType = 1 Then 'משתמש שמוגדר/ת כמנהל/ת ליגה
            DGV.Columns(0).Visible = False 'הסתרת העמודה של הקידום האינדקס האוטומטי בטבלאות המעקב
        End If
        If UserType = 1 Or UserType = 3 Then 'משתמש שמוגדר/ת כמנהל/ת ליגה או אורח/ת
            For i = 0 To DGV.RowCount - 1
                For j = 0 To DGV.ColumnCount - 1
                    If j = 0 Or j = DGV.ColumnCount - 1 Then
                        DGV.Columns(j).DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#2BA5FF")
                    End If
                Next
                If i Mod 2 = 1 Then
                    DGV.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E6F3FF")
                Else
                    DGV.Rows(i).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
                End If
                If UserType = 3 Then 'אורח/ת
                    DGV.Rows(i).DefaultCellStyle.SelectionBackColor = DGV.Rows(i).DefaultCellStyle.BackColor
                End If
                DGV.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Black
            Next
        ElseIf UserType = 2 Then 'משתמש שמוגדר כמנהל/ת קבוצה
            If ManagersMain.GetTeamColorFlag() = False Then
                DGV.EnableHeadersVisualStyles = True
                For i = 0 To DGV.RowCount - 1
                    If (i + 1) Mod 2 = 1 Then
                        DGV.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#42EADD")
                        DGV.Rows(i).DefaultCellStyle.SelectionBackColor = DGV.Rows(i).DefaultCellStyle.BackColor
                        DGV.Rows(i).DefaultCellStyle.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                    Else
                        DGV.Rows(i).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
                        DGV.Rows(i).DefaultCellStyle.SelectionBackColor = DGV.Rows(i).DefaultCellStyle.BackColor
                    End If
                    DGV.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Black
                Next
            Else
                If ManagersMain.GetCntFileLines() = 2 Then
                    FirstC = ManagersMain.ReadLine(1, ManagersMain.GetAllLines())
                    SecondC = ManagersMain.ReadLine(2, ManagersMain.GetAllLines())
                    For i = 0 To DGV.RowCount - 1
                        If i Mod 2 = 1 Then
                            DGV.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml(FirstC)
                            If Color.Black.ToArgb().Equals(ColorTranslator.FromHtml(FirstC).ToArgb()) Then
                                DGV.Rows(i).DefaultCellStyle.ForeColor = Color.White
                            End If
                        Else
                            If Color.White.ToArgb().Equals(ColorTranslator.FromHtml(SecondC).ToArgb()) Then
                                DGV.Rows(i).DefaultCellStyle.BackColor = ColorTranslator.FromHtml(SecondC)
                                DGV.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                            Else
                                DGV.Rows(i).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
                                DGV.Rows(i).DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(SecondC)
                            End If
                        End If
                        DGV.Rows(i).DefaultCellStyle.SelectionBackColor = DGV.Rows(i).DefaultCellStyle.BackColor
                        DGV.Rows(i).DefaultCellStyle.SelectionForeColor = Color.Black
                    Next
                End If
            End If
        End If
        DGV.CurrentCell = Nothing 'כדי שהתא הראשון בטבלה לא יסומן וכדי שיהיה אפשר להסתיר עמודות או שורות למקרה הצורך
    End Sub
End Class
