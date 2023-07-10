Imports System.Data.SqlClient

Public Class connexion

    Public Function CrearConexion(serverName As String) As SqlConnection
        Dim connectionString As String = "server=" & serverName & "; database=libreria; integrated security=true"
        Return New SqlConnection(connectionString)
    End Function
End Class
