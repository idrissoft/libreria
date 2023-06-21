Imports System.Data.SqlClient

Public Class Nueva_Venta
    Private miConexion As New connexion()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Nueva_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarLibros()
    End Sub

    Private Sub CargarClientes()
        Dim conn As SqlConnection = miConexion.CrearConexion()
        conn.Open()

        ' Consulta SQL para obtener todos los nombres de clientes
        Dim query As String = "SELECT nombre FROM Cliente"
        Dim cmd As New SqlCommand(query, conn)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        ' Limpiar el ComboBox antes de agregar los resultados
        txtClienteNombre.Items.Clear()

        While reader.Read()
            ' Agregar los nombres de clientes al ComboBox
            txtClienteNombre.Items.Add(reader("nombre").ToString())
        End While

        reader.Close()
        conn.Close()
    End Sub

    Private Sub CargarLibros()
        Try
            Dim conn As SqlConnection = miConexion.CrearConexion()
            conn.Open()

            ' Consulta SQL para obtener todos los nombres de libros
            Dim query As String = "SELECT nombre FROM libros"
            Dim cmd As New SqlCommand(query, conn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Limpiar el ComboBox antes de agregar los resultados
            txtLibroNombre.Items.Clear()

            While reader.Read()
                ' Agregar los nombres de libros al ComboBox
                txtLibroNombre.Items.Add(reader("nombre").ToString())
            End While

            reader.Close()
            conn.Close()
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    public sub a()
        End sub
End Class

