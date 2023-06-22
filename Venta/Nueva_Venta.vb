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

            AddHandler txtLibroNombre.SelectedIndexChanged, AddressOf txtLibroNombre_SelectedIndexChanged
        End Using
    End Sub

    Private Sub carga_precio_libro()
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
                    Dim subtotal As Decimal = CDec(txtVentaCantidad.Text) * CDec(txtVentaPrecio.Text) - CDec(TxtDescuento.Text)

                    Dim command As New SqlCommand("INSERT INTO venta(ID_cliente, idlibro, Cantidad, Precio_venta, ficha_de_venta, Descuento,Precio_Des_por_unidad, Subtota) 
                                               VALUES (@ID_cliente, @idlibro, @Cantidad, @Precio_venta, @ficha_de_venta, @Descuento,@Precio_Des_por_unidad, @Subtota)", con)

                    Dim fechaVenta As DateTime = ficha_de_venta.Value

                    command.Parameters.AddWithValue("@ID_cliente", ID_cliente)
                    command.Parameters.AddWithValue("@idlibro", idlibro)
                    command.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
                    command.Parameters.AddWithValue("@Precio_venta", CDec(txtVentaPrecio.Text))
                    command.Parameters.AddWithValue("@ficha_de_venta", fechaVenta)
                    command.Parameters.AddWithValue("@Descuento", CDec(TxtDescuento.Text))
                    command.Parameters.AddWithValue("@Precio_Des_por_unidad", Precio_Des_por_unidad)
                    command.Parameters.AddWithValue("@Subtota", subtotal)

                    ' Cambiar el tipo de dato del parámetro Subtotal a SqlDbType.Money
                    command.Parameters("@Subtota").SqlDbType = SqlDbType.Money

                    command.ExecuteNonQuery()

                    Dim updateStockQuery As String = "UPDATE libros SET stock = stock - @Cantidad WHERE idlibro = @idlibro"
                    Dim updateStockCmd As New SqlCommand(updateStockQuery, con)
                    updateStockCmd.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
                    updateStockCmd.Parameters.AddWithValue("@idlibro", idlibro)
                    updateStockCmd.ExecuteNonQuery()

                    MessageBox.Show("La nueva venta se ha creado correctamente.")
                    Close()
                    Venta.mostrar_venta()
                Else
                    MessageBox.Show("No se encontró el libro seleccionado.")
                End If
            Else
                MessageBox.Show("No se encontró el cliente seleccionado.")
            End If
        End Using
    End Sub


    Private Sub Btn_guardar_cliente1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_cliente1.Click
        agregar_venta()
    End Sub

    Private Sub txtLibroNombre_SelectedIndexChanged(sender As Object, e As EventArgs)
        carga_precio_libro()
    End Sub
End Class
