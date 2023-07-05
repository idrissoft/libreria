Imports System.Data.SqlClient

Public Class Editar_libros
    Private miConexion As New connexion()
    Private librosForm As Libros ' 
    Public Sub New(librosForm As Libros)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Guarda la referencia a la forma Libros
        Me.librosForm = librosForm
    End Sub
    Private Sub Btn_guardar_libro1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_libro1.Click
        Try
            ' Conexión a SQL Server
            Dim con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            ' Consulta SQL para actualizar los datos de la tabla filtrados por un parámetro
            Dim query As String = "UPDATE libros SET nombre = @nombre, autor = @autor, precio = @precio, ficha = @ficha, description = @description, stock_Total = @stock_total WHERE idlibro = @idlibro"

            ' Creación del comando y asignación de parámetros
            Dim command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@idlibro", TextBox5.Text)
            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@autor", TextBox2.Text)
            command.Parameters.AddWithValue("@precio", TextBox3.Text)
            command.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)
            command.Parameters.AddWithValue("@description", TextBox4.Text)
            command.Parameters.AddWithValue("@stock_total", TextBox7.Text)

            ' Ejecutar la consulta
            command.ExecuteNonQuery()

            con.Close()

            MessageBox.Show("Libro actualizado correctamente.")
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
        Dim libros As DataTable = librosForm.MostrarLibros()

        ' Actualiza el DataGridView en la forma Libros
        librosForm.DataGridView_libros.DataSource = libros
        Me.Hide()
    End Sub

End Class