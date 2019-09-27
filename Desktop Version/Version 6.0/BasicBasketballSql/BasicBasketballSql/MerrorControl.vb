Imports System.Reflection
Public Class MerrorControl
    Private Text As New List(Of TextBox), Combo As New List(Of ComboBox)
    Private TextStr As New List(Of String), TextCombo As New List(Of String)
    Private TheForm As Form = Nothing
    Private SplitChar As Char = ""
    Private Refresher As Timer = New Timer, TimerFlag As Boolean = True
#Region "טיימר רענון אוטומטי לפורם כל 5 דקות"
    Private Sub AutoRefreshTimer()
        If Me.TimerFlag = True Then
            Refresher.Interval = (300 * 1000) '5min = 300sec = 300,000ms
            Refresher.Start()
            AddHandler Refresher.Tick, AddressOf Me.RefreshTimer
        End If
    End Sub
    Private Sub RefreshTimer(sender As Object, e As EventArgs)
        getTheForm().Refresh()
    End Sub
#End Region
#Region "עוד בדיקות ואפשרויות שמחלקת השירות מציעה"
    ''' <summary>
    ''' This sub receive control arr and set all control arr items to the receive visible status
    ''' </summary>
    Public Sub setControlsVisibilty(ByVal control() As Control, ByVal VisibiltyStatus As Boolean)
        For i As Integer = 0 To control.Length - 1
            control(i).Visible = VisibiltyStatus
        Next
    End Sub
    ''' <summary>
    ''' This function check if the key press is digit value or back space control
    ''' </summary>
    Public Function isDigitVal(e As KeyPressEventArgs, Optional control As Control = Nothing) As Boolean
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
            Return True
        Else
            e.Handled = True
            MessageBox.Show("Characters are not allowed inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If control IsNot Nothing Then
                control.Text = ""
                control.Focus()
            End If
            Return False
        End If
    End Function
    ''' <summary>
    ''' This function check if the key press is letter or back space control or optional split char
    ''' </summary>
    Public Function isName(e As KeyPressEventArgs, Optional control As Control = Nothing, Optional SplitChar As Char = "") As Boolean
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = ControlChars.Back Or e.KeyChar = SplitChar Then
            e.Handled = False
            Return True
        Else
            e.Handled = True
            MessageBox.Show("Digits and Symbol except " & SplitChar & " and backspace are not allowed inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If control IsNot Nothing Then
                control.Focus()
            End If
            Return False
        End If
    End Function
    ''' <summary>
    ''' This function check if the key press is upper letter or back space control
    ''' </summary>
    Public Function isUpperLetter(e As KeyPressEventArgs, Optional control As Control = Nothing) As Boolean
        If Char.IsUpper(e.KeyChar) Or e.KeyChar = ControlChars.Back Then
            e.Handled = False
            Return True
        Else
            e.Handled = True
            MessageBox.Show("Digits, Lower chars and Symbols are not allowed inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If control IsNot Nothing Then
                control.Focus()
            End If
            Return False
        End If
    End Function
    ''' <summary>
    ''' This sub lock the option that the user can add char to this control
    ''' </summary>
    Public Sub isUnvailed(e As KeyPressEventArgs, Optional control As Control = Nothing)
        e.Handled = True
        MessageBox.Show("Cant insert value inside", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        If control IsNot Nothing Then
            control.Focus()
        End If
    End Sub
#End Region
#Region "הצבת איוונטים ובדיקתם על האובייקטים"
    Private Sub ClearLists()
        'Remove event handler from all lists items, and after that clearing all the items
        Dim i As Integer, j As Integer
        For i = 0 To Text.Count - 1
            RemoveHandler Text(i).Leave, AddressOf Me.CheckTextLostFocus
            RemoveHandler Text(i).Enter, AddressOf Me.CheckTextGotFocus
            RemoveHandler Text(i).KeyPress, AddressOf Me.CheckTbKey
        Next
        For j = 0 To Combo.Count - 1
            RemoveHandler Combo(j).LostFocus, AddressOf Me.CheckComboLostFocus
            RemoveHandler Combo(j).GotFocus, AddressOf Me.CheckComboGotFocus
            RemoveHandler Combo(j).KeyPress, AddressOf Me.CheckCmbKey
        Next
        Text.Clear()
        TextStr.Clear()
        TextCombo.Clear()
        Combo.Clear()
    End Sub
    Private Sub AddEvents()
        'Adding event handlers for all lists items, and default text value for the hint property
        Dim i As Integer, j As Integer
        For i = 0 To Text.Count - 1
            AddHandler Text(i).Leave, AddressOf Me.CheckTextLostFocus
            AddHandler Text(i).Enter, AddressOf Me.CheckTextGotFocus
            AddHandler Text(i).KeyPress, AddressOf Me.CheckTbKey
        Next
        For j = 0 To Combo.Count - 1
            AddHandler Combo(j).LostFocus, AddressOf Me.CheckComboLostFocus
            AddHandler Combo(j).GotFocus, AddressOf Me.CheckComboGotFocus
            AddHandler Combo(j).KeyPress, AddressOf Me.CheckCmbKey
        Next
    End Sub
    ''' <summary>
    ''' Use this sub if your form doesn't have some componets that can store controls inside them, send the save keyword Me
    ''' </summary>
    Public Sub setFormControlsEvent(ByVal frm As Form)
        ClearLists()
        TheForm = frm
        AutoRefreshTimer()
        For Each Control As Control In frm.Controls
            If TypeOf Control Is TextBox Then
                Text.Add(Control)
                TextStr.Add(Control.Text)
            ElseIf TypeOf Control Is ComboBox Then
                Combo.Add(Control)
                TextCombo.Add(Control.Text)
            End If
        Next Control
        AddEvents()
    End Sub
    ''' <summary>
    ''' Use this sub if your form have panel that store controls inside, send your panel name and save keyword Me
    ''' </summary>
    Public Sub setPanelControlsEvents(ByVal panel As Panel, ByVal frm As Form)
        ClearLists()
        TheForm = frm
        AutoRefreshTimer()
        For Each Control As Control In panel.Controls
            If TypeOf Control Is TextBox Then
                Text.Add(Control)
                TextStr.Add(Control.Text)
            ElseIf TypeOf Control Is ComboBox Then
                Combo.Add(Control)
                TextCombo.Add(Control.Text)
            End If
        Next Control
        AddEvents()
    End Sub
    ''' <summary>
    ''' Use this sub if your form have groupbox that store controls inside, send your groupbox name and save keyword Me
    ''' </summary>
    Public Sub setGroupBoxControlsEvents(ByVal groupbox As GroupBox, ByVal frm As Form)
        ClearLists()
        TheForm = frm
        AutoRefreshTimer()
        For Each Control As Control In groupbox.Controls
            If TypeOf Control Is TextBox Then
                Text.Add(Control)
                TextStr.Add(Control.Text)
            ElseIf TypeOf Control Is ComboBox Then
                Combo.Add(Control)
                TextCombo.Add(Control.Text)
            End If
        Next Control
        AddEvents()
    End Sub
    ''' <summary>
    ''' Sub that handles textboxes events, lock tag = 0, check digit tag = 1, check name tag = 2
    ''' </summary>
    Private Sub CheckTbKey(sender As Object, e As KeyPressEventArgs)
        Dim txtCheck As TextBox = sender, i As Integer
        For i = 0 To Text.Count - 1
            If txtCheck.Name = Text(i).Name Then
                Select Case Text(i).Tag
                    Case 0
                        isUnvailed(e, txtCheck)
                        txtCheck.Text = TextStr(i)
                        getTheForm.Refresh()
                    Case 1
                        If isDigitVal(e, txtCheck) = False Then
                            getTheForm.Refresh()
                        End If
                    Case 2
                        If isName(e, txtCheck, getSplitChar) = False Then
                            getTheForm.Refresh()
                        End If
                End Select
            End If
        Next
    End Sub
    ''' <summary>
    ''' Sub that handles comboboxes events, lock tag = 0, check digit tag = 1
    ''' </summary>
    Private Sub CheckCmbKey(sender As Object, e As KeyPressEventArgs)
        Dim cmbCheck As ComboBox = sender, i As Integer
        For i = 0 To Combo.Count - 1
            If cmbCheck.Name = Combo(i).Name Then
                Select Case Combo(i).Tag
                    Case 0
                        isUnvailed(e, cmbCheck)
                        cmbCheck.Text = TextCombo(i)
                        getTheForm.Refresh()
                    Case 1
                        If isDigitVal(e, cmbCheck) = False Then
                            getTheForm.Refresh()
                        End If
                End Select
            End If
        Next
    End Sub
#End Region
#Region "הוספת אפשרות של hint על אובייקטים בפורם"
    Private Sub CheckTextLostFocus(sender As Object, e As EventArgs)
        Dim valText As TextBox = sender, i As Integer
        For i = 0 To Text.Count - 1
            If valText.Name = Text(i).Name Then
                If Text(i).Text = "" Then
                    Text(i).Text = TextStr(i)
                End If
            End If
        Next
    End Sub
    Private Sub CheckTextGotFocus(sender As Object, e As EventArgs)
        Dim valText As TextBox = sender, i As Integer
        For i = 0 To Text.Count - 1
            If valText.Name = Text(i).Name Then
                If Text(i).Text = TextStr(i) Then
                    Text(i).Text = ""
                End If
            End If
        Next
    End Sub
    Private Sub CheckComboLostFocus(sender As Object, e As EventArgs)
        Dim valCombo As ComboBox = sender, i As Integer
        For i = 0 To Combo.Count - 1
            If valCombo.Name = Combo(i).Name Then
                If Combo(i).Text = "" Then
                    Combo(i).Text = TextCombo(i)
                End If
            End If
        Next
    End Sub
    Private Sub CheckComboGotFocus(sender As Object, e As EventArgs)
        Dim valCombo As ComboBox = sender, i As Integer
        For i = 0 To Combo.Count - 1
            If valCombo.Name = Combo(i).Name Then
                If Combo(i).Text = TextCombo(i) Then
                    Combo(i).Text = ""
                End If
            End If
        Next
    End Sub
#End Region
#Region "Getters and Setters"
    ''' <summary>
    ''' Set if you want 5 min auto refresher time, if you dont want send false
    ''' </summary>
    Public Sub setWantsTime(ByVal timerflag As Boolean)
        Me.TimerFlag = timerflag
    End Sub
    ''' <summary>
    ''' Set your form split char control allowed
    ''' </summary>
    Public Sub setSplitChar(ByVal splitchar As Char)
        Me.SplitChar = splitchar
    End Sub
    Public Function getSplitChar() As Char
        Return Me.SplitChar
    End Function
    Public Function getTheForm() As Form
        Return Me.TheForm
    End Function
#End Region
End Class
