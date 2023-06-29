Imports System.Data.SqlClient

Public Class Nueva_Venta
    Private miConexion As New connexion()
    Friend WithEvents BtnAddVenta As Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Cerrar la venta actual y volver a la vista principal
        Me.Hide()
    End Sub

    Private Sub Nueva_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los nombres de los clientes y libros disponibles al iniciar el formulario
        CargarClientes()
        CargarLibros()
    End Sub

    Private Sub CargarClientes()
        ' Obtener los nombres de todos los clientes de la base de datos
        Using con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            Dim query As String = "SELECT nombre FROM Cliente"
            Dim cmd As New SqlCommand(query, con)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            txtClienteNombre.Items.Clear()

            While reader.Read()
                txtClienteNombre.Items.Add(reader("nombre").ToString())
            End While

            reader.Close()
        End Using
    End Sub

    Private Sub CargarLibros()
        ' Obtener los nombres de todos los libros de la base de datos
        Using con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            Dim query As String = "SELECT nombre FROM libros"
            Dim cmd As New SqlCommand(query, con)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            txtLibroNombre.Items.Clear()

            While reader.Read()
                txtLibroNombre.Items.Add(reader("nombre").ToString())
            End While

            reader.Close()

            ' Añadir un evento de cambio de selección al cuadro de lista de libros
            AddHandler txtLibroNombre.SelectedIndexChanged, AddressOf txtLibroNombre_SelectedIndexChanged
        End Using
    End Sub

    Private Sub carga_precio_libro()
        ' Obtener el precio del libro seleccionado y mostrarlo en el formulario
        Using con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            Dim libroQuery As String = "SELECT precio FROM libros WHERE nombre = @nombre"
            Dim libroCmd As New SqlCommand(libroQuery, con)
            libroCmd.Parameters.AddWithValue("@nombre", txtLibroNombre.Text)

            Dim result = libroCmd.ExecuteScalar()
            If result IsNot Nothing Then
                Dim precio As Decimal = Convert.ToDecimal(result)
                txtVentaPrecio.Text = precio.ToString()
            End If
        End Using
    End Sub

    Public Sub agregar_venta()
        ' Agregar una nueva venta a la base de datos
        Using con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            Dim clienteQuery As String = "SELECT ID_cliente FROM Cliente WHERE Nombre = @Nombre"
            Dim clienteCmd As New SqlCommand(clienteQuery, con)
            clienteCmd.Parameters.AddWithValue("@Nombre", txtClienteNombre.Text)

            Dim clienteResult = clienteCmd.ExecuteScalar()

            If clienteResult IsNot Nothing Then
                Dim ID_cliente As Integer = Convert.ToInt32(clienteResult)

                Dim libroQuery As String = "SELECT idlibro FROM libros WHERE nombre = @nombre"
                Dim libroCmd As New SqlCommand(libroQuery, con)
                libroCmd.Parameters.AddWithValue("@nombre", txtLibroNombre.Text)

                Dim libroResult = libroCmd.ExecuteScalar()

                If libroResult IsNot Nothing Then
                    Dim idlibro As Integer = Convert.ToInt32(libroResult)
                    Dim Precio_Des_por_unidad As Decimal = CDec(txtVentaPrecio.Text) - CDec(TxtDescuento.Text)
                    Dim subtotal As Decimal = CDec(txtVentaCantidad.Text) * Precio_Des_por_unidad
                    Dim IVA As Decimal = (subtotal * 16) / 100
                    Dim total As Decimal = subtotal + IVA

                    Dim ventaQuery As String = "INSERT INTO ventas (ID_Cliente, Fecha, Cantidad, ID_Libro, Subtotal, Descuento, IVA, Total) VALUES (@ID_Cliente, GETDATE(), @Cantidad, @ID_Libro, @Subtotal, @Descuento, @IVA, @Total)"
                    Dim ventaCmd As New SqlCommand(ventaQuery, con)
                    ventaCmd.Parameters.AddWithValue("@ID_Cliente", ID_cliente)
                    ventaCmd.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
                    ventaCmd.Parameters.AddWithValue("@ID_Libro", idlibro)
                    ventaCmd.Parameters.AddWithValue("@Subtotal", subtotal)
                    ventaCmd.Parameters.AddWithValue("@Descuento", TxtDescuento.Text)
                    ventaCmd.Parameters.AddWithValue("@IVA", IVA)
                    ventaCmd.Parameters.AddWithValue("@Total", total)

                    ventaCmd.ExecuteNonQuery()

                    ' Actualizar el stock del libro
                    Dim updateStockQuery As String = "UPDATE libros SET stock = stock - @Cantidad WHERE idlibro = @idlibro"
                    Dim updateStockCmd As New SqlCommand(updateStockQuery, con)
                    updateStockCmd.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
                    updateStockCmd.Parameters.AddWithValue("@idlibro", idlibro)
                    updateStockCmd.ExecuteNonQuery()

                    ' Mostrar un mensaje de éxito
                    MessageBox.Show("Venta agregada correctamente.")
                Else
                    MessageBox.Show("No se encontró el libro seleccionado.")
                End If
            Else
                MessageBox.Show("No se encontró el cliente seleccionado.")
            End If
        End Using
    End Sub

    Private Sub BtnAddVenta_Click(sender As Object, e As EventArgs) Handles BtnAddVenta.Click
        ' Añadir una nueva venta cuando se hace clic en el botón "Añadir venta"
        agregar_venta()
    End Sub

    Private Sub txtLibroNombre_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' Actualizar el precio del libro cuando se selecciona un nuevo libro
        carga_precio_libro()
    End Sub
End Class
