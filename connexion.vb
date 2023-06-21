Imports System.Data.SqlClient

Public Class connexion
    Private connectionString As String = "server=DESKTOP-N0AAU33\SQLEXPRESS; database=libreria; integrated security=true"
    Public Function CrearConexion() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
