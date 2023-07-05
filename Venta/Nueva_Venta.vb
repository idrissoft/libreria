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
    Private Sub LlenarDataGridView(con As SqlConnection, cmd As SqlCommand)
        Using da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        End Using
    End Sub
    Private Sub txtLibroNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtLibroNombre.SelectedIndexChanged
        ' Actualizar el precio del libro cuando se selecciona un nuevo libro
        carga_precio_libro()

        ' Obtener el idLibro del libro seleccionado
        Using con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            Dim idLibroQuery As String = "SELECT idLibro FROM libros WHERE nombre = @nombre"
            Dim idLibroCmd As New SqlCommand(idLibroQuery, con)
            idLibroCmd.Parameters.AddWithValue("@nombre", txtLibroNombre.Text)

            Dim result = idLibroCmd.ExecuteScalar()
            If result IsNot Nothing Then
                Dim idLibro As Integer = Convert.ToInt32(result)

                ' Obtener las unidades logisticas del libro seleccionado y llenar el DataGridView
                Dim ulQuery As String = "SELECT * FROM UnidadesLogisticas WHERE idLibro = @idLibro"
                Dim ulCmd As New SqlCommand(ulQuery, con)
                ulCmd.Parameters.AddWithValue("@idLibro", idLibro)

                LlenarDataGridView(con, ulCmd)

                ' Cargar las unidades logisticas en ComboBox1
                CargarUnidadesLogisticas(idLibro)
            End If
        End Using
    End Sub

    Private Sub CargarUnidadesLogisticas(idLibro As Integer)
        ' Obtener las unidades logísticas del libro seleccionado y llenar el ComboBox
        Using con As SqlConnection = miConexion.CrearConexion()
            con.Open()

            Dim ulQuery As String = "SELECT tipoUL FROM UnidadesLogisticas WHERE idLibro = @idLibro"
            Dim ulCmd As New SqlCommand(ulQuery, con)
            ulCmd.Parameters.AddWithValue("@idLibro", idLibro)

            Dim reader As SqlDataReader = ulCmd.ExecuteReader()
            ComboBox1.Items.Clear()

            While reader.Read()
                ComboBox1.Items.Add(reader("tipoUL").ToString())
            End While

            reader.Close()
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

                    ' Obtener el stock de la unidad logística correspondiente al libro y al tipo de unidad logística
                    Dim ulQuery As String = "SELECT * FROM UnidadesLogisticas WHERE idLibro = @idLibro AND tipoUL = @tipoUL"
                    Dim ulCmd As New SqlCommand(ulQuery, con)
                    ulCmd.Parameters.AddWithValue("@idLibro", idlibro)
                    ulCmd.Parameters.AddWithValue("@tipoUL", ComboBox1.SelectedItem)

                    Dim ulReader = ulCmd.ExecuteReader()
                    Dim unidades_por_UL As Integer = 0
                    If ulReader.Read() Then
                        unidades_por_UL = Convert.ToInt32(ulReader("unidades_por_UL"))
                    End If
                    ulReader.Close()

                    ' Actualizar el stock de la unidad logística según el tipoUL
                    Dim tipoUL As Integer = ComboBox1.SelectedItem
                    Dim cantidad As Integer = txtVentaCantidad.Text

                    Dim Precio_Des_por_unidad As Decimal = CDec(txtVentaPrecio.Text) - CDec(TxtDescuento.Text)
                    Dim subtotal As Decimal = 0
                    If tipoUL = 1 Then
                        cantidad = cantidad * unidades_por_UL
                        subtotal = cantidad * Precio_Des_por_unidad
                    Else
                        subtotal = cantidad * Precio_Des_por_unidad
                    End If

                    Dim ventaQuery As String = "INSERT INTO venta (ID_Cliente, idlibro, Cantidad, ficha_de_venta, Subtota, Descuento) VALUES (@ID_Cliente, @idlibro, @Cantidad, @ficha_de_venta, @Subtota, @Descuento)"
                    Dim ventaCmd As New SqlCommand(ventaQuery, con)
                    ventaCmd.Parameters.AddWithValue("@ID_Cliente", ID_cliente)
                    ventaCmd.Parameters.AddWithValue("@idlibro", idlibro)
                    ventaCmd.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
                    ventaCmd.Parameters.AddWithValue("@ficha_de_venta", ficha_de_venta.Value) ' DateTimePicker value
                    ventaCmd.Parameters.AddWithValue("@Subtota", subtotal)
                    ventaCmd.Parameters.AddWithValue("@Descuento", TxtDescuento.Text)

                    ventaCmd.ExecuteNonQuery()

                    ' Actualizar el stock del libro
                    Dim updateStockQuery As String = "UPDATE libros SET stock_Total = stock_Total - @Cantidad WHERE idlibro = @idlibro"
                    Dim updateStockCmd As New SqlCommand(updateStockQuery, con)
                    updateStockCmd.Parameters.AddWithValue("@Cantidad", txtVentaCantidad.Text)
                    updateStockCmd.Parameters.AddWithValue("@idlibro", idlibro)
                    updateStockCmd.ExecuteNonQuery()

                    Dim updateULStockQuery As String = "UPDATE UnidadesLogisticas SET stock = stock - @Cantidad WHERE idLibro = @idLibro AND tipoUL = @tipoUL"
                    Dim updateULStockCmd As New SqlCommand(updateULStockQuery, con)
                    updateULStockCmd.Parameters.AddWithValue("@idLibro", idlibro)
                    updateULStockCmd.Parameters.AddWithValue("@tipoUL", tipoUL)
                    updateULStockCmd.Parameters.AddWithValue("@Cantidad", cantidad)
                    updateULStockCmd.ExecuteNonQuery()

                    ' Actualización del stock total
                    Dim command As New SqlCommand("EXEC ActualizarStockTotal @idLibro", con)
                    command.Parameters.AddWithValue("@idLibro", idlibro)
                    command.ExecuteNonQuery()

                    Me.Close()
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





    Private Sub BtnAddVenta1_Click(sender As Object, e As EventArgs) Handles BtnAddVenta1.Click
        ' Añadir una nueva venta cuando se hace clic en el botón "Añadir venta"
        agregar_venta()
    End Sub
End Class
