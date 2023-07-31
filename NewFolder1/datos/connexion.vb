Imports System.Data.SqlClient

Public Class connexion
    Protected con As New SqlConnection

    Public Function CrearConexion(serverName As String) As SqlConnection

        Dim connectionString As String = "server=" & serverName & "; database=libreria; integrated security=true"
        Return New SqlConnection(connectionString)
    End Function



    Protected Function conectado()
            Try
            con = New SqlConnection("connectionString")
            con.Open()
            Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Protected Function desconectado()
            Try
            If con.State = ConnectionState.Open Then
                con.Close()

                Return True
            Else
                Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function


End Class
