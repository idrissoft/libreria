Imports System.Data.SqlClient

Public Class Movimientos
    Public Property ServerName As String

    Dim miconexion As New connexion

    Sub mostrar_Movimientos()

        Dim con As SqlConnection = miconexion.CrearConexion(ServerName)
        con.Open()
        Dim da As New SqlDataAdapter("SELECT * FROM Movimientos", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView_Movimientos.DataSource = dt
        con.Close()
    End Sub

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Movimientos()
    End Sub
End Class
