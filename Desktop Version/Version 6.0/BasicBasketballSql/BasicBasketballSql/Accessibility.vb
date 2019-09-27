NotInheritable Class Accessibility 'Allowing using this class by his name only, like using Math
    'Public Shared Property Varible name As Varible type help me with less code lines because this varbile gets automatically Get and Set methods
    Public Shared Property Language As String = "English"
    Public Shared Property FontName As String = "Tahoma"
    Public Shared Property FontSize As Integer = 12
    Public Shared Property FontStyle As FontStyle = FontStyle.Regular
    Public Shared Property FontColor As Color = Color.Black
    Private Sub New() 'Avoid allowing inheritable
    End Sub
    Public Shared Sub SetTheDesign(ByVal c As Control.ControlCollection) 'Sent controls collection inside form or panel etc... to apply for all of them the same accessibility design
        For Each control As Control In c
            If control.HasChildren Then 'If the control has another control inside, call again to the function
                SetTheDesign(control.Controls)
            Else
                If Not TypeOf control Is TextBox Then
                    control.ForeColor = FontColor
                End If
                control.Font = New Font(FontName, FontSize, FontStyle)
            End If
        Next
    End Sub
End Class
