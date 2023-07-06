Imports System.Data.SqlClient

Public Class Venta
    Private miConexion As New connexion()
    Public Function mostrar_venta() As DataTable
        Dim dt As New DataTable()
        Dim con As SqlConnection = miConexion.CrearConexion()
        Dim cmd As New SqlCommand("mostrar_venta", con)

        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        Using da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        End Using

        con.Close()

        Return dt
    End Function

    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        Dim libros As New Libros()
        libros.Show()
        Me.Hide()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cliente As New Clientes()
        cliente.Show()
        Me.Hide()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Dim entrada As New Entrada()
        entrada.Show()
        Me.Hide()
    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView_Venta.DataSource = mostrar_venta()
    End Sub

    Private Sub DataGridView_Venta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Venta.CellClick
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView_Venta.CurrentCell.RowIndex

        ' Obtener los valores de las columnas correspondientes
        Dim idLibro As String = DataGridView_Venta.Rows(rowindex).Cells("ID de Libro").Value.ToString()
        Dim idCliente As String = DataGridView_Venta.Rows(rowindex).Cells("ID de cliente").Value.ToString()
        Dim cantidad As String = DataGridView_Venta.Rows(rowindex).Cells("cantidad").Value.ToString()
        Dim precioVenta As String = DataGridView_Venta.Rows(rowindex).Cells("Precio de Unidad").Value.ToString()
        Dim descuento As String = DataGridView_Venta.Rows(rowindex).Cells("Descuento ").Value.ToString()
        txtVentaSubtotal.Text = DataGridView_Venta.Rows(e.RowIndex).Cells("Precio Total").Value.ToString()
        ' Mostrar los datos del libro en los cuadros de texto correspondientes
        Dim libro As Libros = ObtenerLibro(idLibro)
        txtLibroID.Text = libro.idLibro
        txtLibroNombre.Text = libro.Nombre

        ' Mostrar otros datos de libro según tus propiedades

        ' Mostrar los datos del cliente en los cuadros de texto correspondientes
        Dim cliente As Clientes = ObtenerCliente(idCliente)
        txtClienteID.Text = cliente.ID_Cliente
        txtClienteNombre.Text = cliente.Nombre
        txtClienteTelefono.Text = cliente.Telefono
        txtClientedireccion.Text = cliente.Direccion

        ' Mostrar otros datos de cliente según tus propiedades

        ' Mostrar los datos de la venta en los cuadros de texto correspondientes
        txtVentaCantidad.Text = cantidad
        txtVentaPrecio.Text = precioVenta
        txtVentaDescuento.Text = descuento
        ' Verificar si los campos no están vacíos
        If Not String.IsNullOrEmpty(cantidad) And Not String.IsNullOrEmpty(precioVenta) And Not String.IsNullOrEmpty(descuento) Then
            ' Realizar la operación
            'txtVentaSubtotal.Text = (CDbl(cantidad) * CDbl(precioVenta) - CDbl(descuento)).ToString()
        End If

    End Sub

    Private Function ObtenerLibro(idLibro As String) As Libros
        Dim libro As New Libros()

        ' Conexión a la base de datos
        Dim conn As SqlConnection = miConexion.CrearConexion()
        conn.Open()

        ' Consulta SQL para obtener los datos del libro por su ID
        Dim query As String = "SELECT nombre, autor, ficha,  description, precio FROM Libros WHERE idlibro = @idLibro"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@idLibro", idLibro)

        ' Ejecutar la consulta y obtener los resultados
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            libro.idLibro = idLibro
            libro.Nombre = reader("nombre").ToString()

        End If

        ' Cerrar la conexión y el lector
        reader.Close()
        conn.Close()

        Return libro
    End Function

    Private Function ObtenerCliente(id_Cliente As String) As Clientes
        Dim cliente As New Clientes()

        ' Conexión a la base de datos
        Dim conn As SqlConnection = miConexion.CrearConexion()
        conn.Open()

        ' Consulta SQL para obtener los datos del cliente por su ID
        Dim query As String = "SELECT nombre, telefono, direccion, informacion FROM Cliente WHERE ID_cliente = @id_Cliente"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id_Cliente", id_Cliente)

        ' Ejecutar la consulta y obtener los resultados
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            cliente.ID_Cliente = id_Cliente
            cliente.Nombre = reader("nombre").ToString()
            cliente.Telefono = reader("telefono").ToString()
            cliente.Direccion = reader("direccion").ToString()
            cliente.Informacion = reader("informacion").ToString()
        End If

        ' Cerrar la conexión y el lector
        reader.Close()
            conn.Close()

            Return cliente
    End Function

    Private Sub CrearNuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearNuevaVentaToolStripMenuItem.Click
        Dim nueva_venta As New Nueva_Venta()
        nueva_venta.Show()
        Me.Hide()
    End Sub

    Private Sub HistoriaLTransaccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriaLTransaccionesToolStripMenuItem.Click
        Dim HistorialTransacciones As New HistorialTransacciones()
        HistorialTransacciones.Show()
    End Sub
    Private Sub Btn_editar_venta_Click(sender As Object, e As EventArgs) Handles Btn_editar_venta.Click
        ' Comprobar si hay una fila seleccionada
        If DataGridView_Venta.SelectedRows.Count > 0 Then
            Dim fila As DataGridViewRow = DataGridView_Venta.SelectedRows(0)

            ' Crear una nueva instancia de Nueva_Venta
            Dim nueva_venta As New Nueva_Venta()

            ' Obtener el ID del cliente de la fila seleccionada
            Dim idCliente As Integer = Convert.ToInt32(fila.Cells("ID de cliente").Value)

            ' Consultar la base de datos para obtener el nombre del cliente
            Using con As SqlConnection = miConexion.CrearConexion()
                con.Open()

                Dim clienteQuery As String = "SELECT Nombre FROM Cliente WHERE ID_cliente = @ID_cliente"
                Dim clienteCmd As New SqlCommand(clienteQuery, con)
                clienteCmd.Parameters.AddWithValue("@ID_cliente", idCliente)

                Dim clienteReader As SqlDataReader = clienteCmd.ExecuteReader()
                If clienteReader.Read() Then
                    nueva_venta.txtClienteNombre.Text = clienteReader("Nombre").ToString()
                End If
                clienteReader.Close()

                ' Obtener el ID del libro de la fila seleccionada
                Dim idLibro As Integer = Convert.ToInt32(fila.Cells("id de libro").Value)

                ' Consultar la base de datos para obtener el nombre del libro
                Dim libroQuery As String = "SELECT nombre FROM libros WHERE idlibro = @idlibro"
                Dim libroCmd As New SqlCommand(libroQuery, con)
                libroCmd.Parameters.AddWithValue("@idlibro", idLibro)

                Dim libroReader As SqlDataReader = libroCmd.ExecuteReader()
                If libroReader.Read() Then
                    nueva_venta.txtLibroNombre.Text = libroReader("nombre").ToString()
                End If
                libroReader.Close()
            End Using

            ' Continuar rellenando los demás campos como antes

            nueva_venta.ComboBox1.SelectedItem = "UL"


            ' Mostrar la ventana de Nueva_Venta
            nueva_venta.Show()
        Else
            MessageBox.Show("Por favor, selecciona una fila para editar.")
        End If
    End Sub

    Private Sub Eliminar_venta_Click(sender As Object, e As EventArgs) Handles Eliminar_venta.Click
        ' Comprobar si hay una fila seleccionada
        If DataGridView_Venta.SelectedRows.Count > 0 Then
            Dim fila As DataGridViewRow = DataGridView_Venta.SelectedRows(0)

            ' Obtener el ID de la venta de la fila seleccionada
            Dim idVenta As Integer = Convert.ToInt32(fila.Cells("id de Venta").Value)

            ' Preguntar al usuario si realmente desea eliminar la venta
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro que deseas eliminar la venta con ID " & idVenta & "?", "Confirmar eliminación", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Si el usuario confirma, eliminar la venta de la base de datos
                Using con As SqlConnection = miConexion.CrearConexion()
                    con.Open()

                    Dim deleteQuery As String = "DELETE FROM Venta WHERE id_venta = @id_venta"
                    Dim deleteCmd As New SqlCommand(deleteQuery, con)
                    deleteCmd.Parameters.AddWithValue("@id_venta", idVenta)

                    deleteCmd.ExecuteNonQuery()
                End Using

                ' Recargar el DataGridView para reflejar los cambios
                DataGridView_Venta.DataSource = mostrar_venta()
            End If
        Else
            MessageBox.Show("Por favor, selecciona una fila para eliminar.")
        End If
    End Sub

End Class