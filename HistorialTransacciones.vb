Imports System.Data.SqlClient

Public Class HistorialTransacciones
    Private miconexion As New connexion
    Private Sub HistorialTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHistorialTransacciones()
    End Sub

    Public Sub CargarHistorialTransacciones()
        Using con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            Using command As New SqlCommand("SELECT * FROM HistorialTransacciones", con)
                Dim adapter As New SqlDataAdapter(command)

                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridView_HistorialTransacciones.DataSource = table
            End Using
        End Using
    End Sub
    Public Sub crear_HistorialTransacciones()

    End Sub
End Class
