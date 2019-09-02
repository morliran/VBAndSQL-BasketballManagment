Imports System.Reflection
NotInheritable Class Accessibility 'Allowing using this class by his name only, like using Math
    'Public Shared Property Varible name As Varible type help me with less code lines because this varbile gets automatically Get and Set methods
    Public Shared Property Language As String = "Hebrew"
    Public Shared Property FontName As String = ""
    Public Shared Property FontSize As Integer = 1
    Public Shared Property AllForms As Boolean = False
    Private Sub New() 'Avoid allowing inheritable
    End Sub
    Public Shared Sub SetTheDesign(ByVal c As Control.ControlCollection) 'Sent controls collection inside form or panel etc... to apply for all of them the same accessibility design
        For Each control As Control In c
            If control.HasChildren Then 'If the control has another control inside, call again to the function
                SetTheDesign(control.Controls)
            Else
                If FontSize = 1 AndAlso FontName = "" Then
                    control.Font = New Font(control.Font.FontFamily.Name, control.Font.Size, control.Font.Style)
                Else
                    control.Font = New Font(FontName, FontSize, control.Font.Style)
                End If
            End If
        Next
    End Sub
    Public Shared Sub SetDesignToAllForms(ByVal frm As Form)
        If AllForms = True Then
            SetTheDesign(frm.Controls)
        End If
    End Sub
End Class
