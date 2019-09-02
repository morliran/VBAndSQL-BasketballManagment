Imports System.Data.SqlClient
Imports System.Data
Public Class Connection
    Private builder As SqlConnectionStringBuilder = New SqlConnectionStringBuilder("Data Source=.\SQLSERVER;Initial Catalog = BasketBallManagmentProj;Integrated Security=SSPI; User ID = sa; Password = wizsoft")
    Private Connection As String = builder.ConnectionString()
    Private Con As SqlConnection = New SqlConnection(Connection)
    Private SampleCommand As New SqlCommand()
    Private SampleDataAdapter = New SqlDataAdapter()
    Private Rder As SqlDataReader = Nothing
    Public Function GetConnection() As SqlConnection
        Return Con
    End Function
    Public Function GetCommand() As SqlCommand
        Return SampleCommand
    End Function
    Public Function GetAdapter() As SqlDataAdapter
        Return SampleDataAdapter
    End Function
    Public Function GetStringConnection() As String
        Return Connection
    End Function
    Public Function GetReader() As SqlDataReader
        Return Rder
    End Function
End Class
