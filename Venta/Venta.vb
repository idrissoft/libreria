Imports System.Data.SqlClient

Public Class Venta
    Private miConexion As New connexion()

    Public Function ObtenerDataGridView_Venta() As DataGridView
        Return DataGridView_Venta
    End Function

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
        ObtenerDataGridView_Venta().DataSource = mostrar_venta()
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
        txtVentaSubtotal.Text = (CDbl(cantidad) * CDbl(precioVenta) - CDbl(descuento)).ToString()
    End Sub

    Private Function ObtenerLibro(idLibro As String) As Libros
        Dim libro As New Libros()

        ' Conexión a la base de datos
        Dim conn As SqlConnection = miConexion.CrearConexion()
        conn.Open()

        ' Consulta SQL para obtener los datos del libro por su ID
        Dim query As String = "SELECT nombre, autor, ficha, cantidad, stock, description, precio FROM Libros WHERE idlibro = @idLibro"
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

    End Sub
End Class