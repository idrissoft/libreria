﻿Imports System.Data.SqlClient

Public Class connexion
    Private connectionString As String = "server=MBWS093\SQLEXPRESS; database=libreria; integrated security=true"
    Public Function CrearConexion() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
