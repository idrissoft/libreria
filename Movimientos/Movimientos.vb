Imports System.Data.SqlClient

Public Class Movimientos
    Public Property ServerName As String

    Dim miconexion As New connexion

    Sub mostrar_Movimientos()
        ' La conexión se crea aquí ahora
        Dim con As SqlConnection = miconexion.CrearConexion(ServerName)

        ' Abre la conexión
        con.Open()

        ' Crea un nuevo SqlDataAdapter
        Dim da As New SqlDataAdapter("SELECT * FROM Movimientos", con)

        ' Crea un nuevo DataTable
        Dim dt As New DataTable()

        ' Llena el DataTable con los datos del SqlDataAdapter
        da.Fill(dt)

        ' Ajusta el DataGridView para que muestre los datos del DataTable
        DataGridView_Movimientos.DataSource = dt

        ' Cierra la conexión
        con.Close()
    End Sub

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_Movimientos()
    End Sub
End Class
