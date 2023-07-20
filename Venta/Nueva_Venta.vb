Imports System.Data.SqlClient

Public Class Nueva_Venta
    Private miConexion As New connexion()
    Private ComboBox_Servidor As ComboBox
    Friend WithEvents BtnAddVenta As Button
    Public Property ServerName As String
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
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
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
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
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
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
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
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
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
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
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
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
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

                    Dim tipoUL As Integer = ComboBox1.SelectedItem
                    Dim cantidad As Integer
                    Dim precio As Integer

                    If Not Integer.TryParse(txtVentaCantidad.Text, cantidad) Then
                        MessageBox.Show("Por favor, introduzca una cantidad válida.")
                        Return
                    End If

                    If Not Integer.TryParse(txtVentaPrecio.Text, precio) Then
                        MessageBox.Show("Por favor, introduzca un precio válido.")
                        Return
                    End If

                    Dim Precio_Des_total As Integer
                    Dim descuento As Integer

                    If Integer.TryParse(TxtDescuento.Text, descuento) Then
                        If descuento > 0 Then
                            Precio_Des_total = descuento * cantidad
                        Else
                            Precio_Des_total = descuento
                        End If
                    Else
                        MessageBox.Show("Por favor, introduzca un descuento válido.")
                        Return
                    End If
                    Dim subtotal As Integer = 0
                    If tipoUL = 1 Then
                        cantidad = cantidad * unidades_por_UL
                        subtotal = cantidad * precio - Precio_Des_total
                    Else
                        subtotal = cantidad * precio - Precio_Des_total
                    End If

                    Dim ventaQuery As String = "INSERT INTO venta (ID_Cliente, idlibro, Cantidad,Precio_venta,Precio_Des_total, ficha_de_venta, Subtotal, Descuento) VALUES (@ID_Cliente, @idlibro, @Cantidad,@Precio_venta,@Precio_Des_total, @ficha_de_venta, @Subtotal, @Descuento)"
                    Dim ventaCmd As New SqlCommand(ventaQuery, con)
                    ventaCmd.Parameters.AddWithValue("@ID_Cliente", ID_cliente)
                    ventaCmd.Parameters.AddWithValue("@idlibro", idlibro)
                    ventaCmd.Parameters.AddWithValue("@Cantidad", cantidad)
                    ventaCmd.Parameters.AddWithValue("@Precio_venta", precio)
                    ventaCmd.Parameters.AddWithValue("@Precio_Des_total", Precio_Des_total)
                    ventaCmd.Parameters.AddWithValue("@ficha_de_venta", ficha_de_venta.Value) ' DateTimePicker value
                    ventaCmd.Parameters.AddWithValue("@Subtotal", subtotal)
                    ventaCmd.Parameters.AddWithValue("@Descuento", Convert.ToInt32(TxtDescuento.Text))

                    ventaCmd.ExecuteNonQuery()

                    Dim updateStockQuery As String = "UPDATE libros SET stock_Total = stock_Total - @Cantidad WHERE idlibro = @idlibro"
                    Dim updateStockCmd As New SqlCommand(updateStockQuery, con)
                    updateStockCmd.Parameters.AddWithValue("@Cantidad", cantidad)
                    updateStockCmd.Parameters.AddWithValue("@idlibro", idlibro)
                    updateStockCmd.ExecuteNonQuery()

                    Dim updateULStockQuery As String = "UPDATE UnidadesLogisticas SET stock = stock - @Cantidad WHERE idLibro = @idLibro AND tipoUL = @tipoUL"
                    Dim updateULStockCmd As New SqlCommand(updateULStockQuery, con)
                    updateULStockCmd.Parameters.AddWithValue("@idLibro", idlibro)
                    updateULStockCmd.Parameters.AddWithValue("@tipoUL", tipoUL)
                    updateULStockCmd.Parameters.AddWithValue("@Cantidad", cantidad)
                    updateULStockCmd.ExecuteNonQuery()

                    Dim command As New SqlCommand("EXEC ActualizarStockTotal @idLibro", con)
                    command.Parameters.AddWithValue("@idLibro", idlibro)
                    command.ExecuteNonQuery()

                    Me.Close()
                    MessageBox.Show("Venta agregada correctamente.")
                Else
                    MessageBox.Show("No se encontró el libro seleccionado.")
                End If
            Else
                MessageBox.Show("No se encontró el cliente seleccionado.")
            End If
        End Using
    End Sub



    Private Sub editar_venta_Click(sender As Object, e As EventArgs) Handles editar_venta.Click
        Dim ID_cliente As Integer
        Dim idlibro As Integer
        Dim UL As String ' Asume que UL es una cadena, cambia el tipo de datos según tu necesidad
        Dim Cantidad As Integer
        Dim Precio_venta As Integer
        Dim Precio_Des_por_unidad As Integer
        Dim Subtotal As Integer
        Dim idVenta As Integer

        ' Editar una venta existente en la base de datos
        Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
        Using con As SqlConnection = miConexion.CrearConexion(serverName)
            con.Open()

            Dim ventaQuery As String = "UPDATE venta SET ID_Cliente = @ID_Cliente, idlibro = @idlibro, UL = @UL, Cantidad = @Cantidad, Precio_venta = @Precio_venta, Precio_Des_por_unidad = @Precio_Des_por_unidad, ficha_de_venta = @ficha_de_venta, Subtotal = @Subtotal, Descuento = @Descuento WHERE idVenta = @idVenta"
            Dim ventaCmd As New SqlCommand(ventaQuery, con)
            ventaCmd.Parameters.AddWithValue("@ID_Cliente", ID_cliente)
            ventaCmd.Parameters.AddWithValue("@idlibro", idlibro)
            ventaCmd.Parameters.AddWithValue("@UL", UL)
            ventaCmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            ventaCmd.Parameters.AddWithValue("@Precio_venta", Precio_venta)
            ventaCmd.Parameters.AddWithValue("@Precio_Des_por_unidad", Precio_Des_por_unidad)
            ventaCmd.Parameters.AddWithValue("@ficha_de_venta", ficha_de_venta.Value)
            ventaCmd.Parameters.AddWithValue("@Subtotal", Subtotal)
            ventaCmd.Parameters.AddWithValue("@Descuento", Descuento)
            ventaCmd.Parameters.AddWithValue("@idVenta", idVenta) ' Asegurate de tener este idVenta correctamente

            ventaCmd.ExecuteNonQuery()

            Dim updateStockQuery As String = "UPDATE libros SET stock_Total = stock_Total - @Cantidad WHERE idlibro = @idlibro"
            Dim updateStockCmd As New SqlCommand(updateStockQuery, con)
            updateStockCmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            updateStockCmd.Parameters.AddWithValue("@idlibro", idlibro)
            updateStockCmd.ExecuteNonQuery()

            Dim updateULStockQuery As String = "UPDATE UnidadesLogisticas SET stock = stock - @Cantidad WHERE idLibro = @idLibro AND tipoUL = @tipoUL"
            Dim updateULStockCmd As New SqlCommand(updateULStockQuery, con)
            updateULStockCmd.Parameters.AddWithValue("@idLibro", idlibro)
            updateULStockCmd.Parameters.AddWithValue("@tipoUL", UL)
            updateULStockCmd.Parameters.AddWithValue("@Cantidad", Cantidad)
            updateULStockCmd.ExecuteNonQuery()

            Dim command As New SqlCommand("EXEC ActualizarStockTotal @idLibro", con)
            command.Parameters.AddWithValue("@idLibro", idlibro)
            command.ExecuteNonQuery()

            MessageBox.Show("Venta actualizada correctamente.")
        End Using
    End Sub

    Private Sub Btn_guardar_venta_Click(sender As Object, e As EventArgs) Handles Btn_guardar_venta.Click
        agregar_venta()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
    End Sub
End Class
