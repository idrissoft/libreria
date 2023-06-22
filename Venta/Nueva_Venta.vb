Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Nueva_Venta
    Private miConexion As New connexion()
    Dim con As SqlConnection = miConexion.CrearConexion()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Nueva_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarLibros()
    End Sub

    Private Sub CargarClientes()

        con.Open()

        ' Consulta SQL para obtener todos los nombres de clientes
        Dim query As String = "SELECT nombre FROM Cliente"
        Dim cmd As New SqlCommand(query, con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        ' Limpiar el ComboBox antes de agregar los resultados
        txtClienteNombre.Items.Clear()

        While reader.Read()
            ' Agregar los nombres de clientes al ComboBox
            txtClienteNombre.Items.Add(reader("nombre").ToString())
        End While

        reader.Close()
        con.Close()
    End Sub

    Private Sub CargarLibros()
        Try

            con.Open()

            ' Consulta SQL para obtener todos los nombres de libros
            Dim query As String = "SELECT nombre FROM libros"
            Dim cmd As New SqlCommand(query, con)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Limpiar el ComboBox antes de agregar los resultados
            txtLibroNombre.Items.Clear()

            While reader.Read()
                ' Agregar los nombres de libros al ComboBox
                txtLibroNombre.Items.Add(reader("nombre").ToString())
            End While

            reader.Close()
            con.Close()
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function agregar_venta()

        Try

            Dim con As SqlConnection = miConexion.CrearConexion()

            Dim command As New SqlCommand("INSERT INTO venta(ID_cliente,idlibro,Cantidad, Precio_venta, Descuento,Precio_Des,Subtota) 
    VALUES (@ID_cliente,@idlibro,@Cantidad, @Precio_venta, @Descuento,@Precio_Des,@stock,@precio, @Subtota)", con)
            'command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@Nombre", txtClienteNombre.Text)
            command.Parameters.AddWithValue("@nombre", txtLibroNombre.Text)
            command.Parameters.AddWithValue("@Precio_Des", txtClienteNombre.Text)
            command.Parameters.AddWithValue("@Subtota", txtLibroNombre.Text)
            command.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
            command.Parameters.AddWithValue("@Precio_venta", txtVentaPrecio.Text)
            command.Parameters.AddWithValue("@Descuento", TxtDescuento.Text)
            'command.Parameters.AddWithValue("@Precio_Des", txtprecio_des.Text)
            'command.Parameters.AddWithValue("@Subtota", Txt_subtota.Text)
            ' Ejecución de la consulta SQL
            con.Open()
            command.ExecuteNonQuery()

            ' Mensaje de confirmación
            MessageBox.Show("el nueva venta  se ha creado correctamente.")

            ' Cerrar el formulario secundario después de guardar los cambios
            Close()
            Dim fr_libro As New Libros
            fr_libro.Show()

            ' Actualización de los datos mostrados en el formulario principal
            Libros.MostrarLibros()


        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub Btn_guardar_cliente1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_cliente1.Click
        Try
            Dim con As SqlConnection = miConexion.CrearConexion()

            ' Obtener el ID del cliente seleccionado
            Dim clienteQuery As String = "SELECT ID_cliente FROM Cliente WHERE nombre = @Nombre"
            Dim clienteCmd As New SqlCommand(clienteQuery, con)
            clienteCmd.Parameters.AddWithValue("@Nombre", txtClienteNombre.Text)

            con.Open()
            Dim ID_cliente As Integer = Convert.ToInt32(clienteCmd.ExecuteScalar())

            ' Obtener el ID del libro seleccionado
            Dim libroQuery As String = "SELECT idlibro FROM libros WHERE nombre = @nombre"
            Dim libroCmd As New SqlCommand(libroQuery, con)
            libroCmd.Parameters.AddWithValue("@nombre", txtLibroNombre.Text)

            Dim idlibro As Integer = Convert.ToInt32(libroCmd.ExecuteScalar())

            Dim command As New SqlCommand("INSERT INTO venta(ID_cliente, idlibro, Cantidad, Precio_venta, Descuento, Precio_Des, Subtota) 
            VALUES (@ID_cliente, @idlibro, @Cantidad, @Precio_venta, @Descuento, @Precio_Des, @Subtota)", con)

            command.Parameters.AddWithValue("@ID_cliente", ID_cliente)
            command.Parameters.AddWithValue("@idlibro", idlibro)
            command.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
            command.Parameters.AddWithValue("@Precio_venta", txtVentaPrecio.Text)
            command.Parameters.AddWithValue("@Descuento", TxtDescuento.Text)
            command.Parameters.AddWithValue("@Precio_Des", txtprecio_des.Text)
            command.Parameters.AddWithValue("@Subtota", Txt_subtota.Text)

            command.ExecuteNonQuery()

            MessageBox.Show("La nueva venta se ha creado correctamente.")
            Close()

            ' Actualizar los datos mostrados en el formulario principal
            Venta.mostrar_venta()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class

