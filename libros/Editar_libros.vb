Imports System.Data.SqlClient

Public Class Editar_libros
    Private miConexion As New connexion()
    Private librosForm As Libros ' 
    Private ComboBox_Servidor As ComboBox
    Public DataGridView_libros As New DataGridView()
    Public Sub New(librosForm As Libros)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Guarda la referencia a la forma Libros
        Me.librosForm = librosForm
    End Sub
    Private Function MostrarLibros() As DataTable
        ' Aquí vendría el código que obtiene los libros desde tu base de datos
        ' Este es un ejemplo genérico
        Dim dt As New DataTable()
        Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
            con.Open()
            Using cmd As New SqlCommand("SELECT * FROM libros", con)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Sub editar_libros(idLibro As Integer)
        Try
            Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miConexion.CrearConexion(serverName)
            Dim consulta As String = "UPDATE libros SET nombre = @nombre, autor = @autor, precio = @precio, ficha = @ficha, description = @description, stock_total = @stock_total WHERE idlibro = @idlibro"

            ' Creación del comando y asignación de parámetros
            Dim comando As New SqlCommand(consulta, con)
            comando.Parameters.AddWithValue("@idlibro", idLibro)
            comando.Parameters.AddWithValue("@nombre", TextBox1.Text)
            comando.Parameters.AddWithValue("@autor", TextBox2.Text)
            comando.Parameters.AddWithValue("@precio", TextBox3.Text)
            comando.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)
            comando.Parameters.AddWithValue("@description", TextBox4.Text)
            comando.Parameters.AddWithValue("@stock_total", TextBox7.Text)
            con.Open()
            comando.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Libro actualizado correctamente.")
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
        Dim libros As DataTable = MostrarLibros()

        ' Actualiza el DataGridView en el formulario de Libros
        DataGridView_libros.DataSource = libros
        Me.Hide()
    End Sub

    Private Sub Btn_guardar_libro1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_libro1.Click
        Dim idlibro As Integer = TextBox5.Text
        editar_libros(idlibro)
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Dim libros As New Libros
        libros.Show()
        Me.Hide()
    End Sub
End Class