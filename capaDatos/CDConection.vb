Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class CDConection
    Dim conection As SqlConnection
    Public Function conectar() As SqlConnection
        conection = New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Return conection
    End Function
End Class
