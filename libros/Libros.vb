Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class Libros
    Private miConexion As New connexion()
    Public Property ServerName As String

    Public Property idLibro As String
    Public Property Nombre As String

    Public Property Autor As String
    Public Property Ficha As String
    Public Property unidad_logistica As String
    Public Property Unidad_por_UL As String
    Public Property Cantidad As Integer
    Public Property Stock As Integer
    Public Property Description As String
    Public Property Precio As Integer
    Private ComboBox_Servidor As ComboBox
    Public Function ObtenerDataGridView_UnidadesLogisticas() As DataGridView
        Return DataGridView_UnidadesLogisticas
    End Function
    Public Function ObtenerDataGridViewLibros() As DataGridView
        Return DataGridView_libros
    End Function

    Private Sub Libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView_libros.DataSource = MostrarLibros()
    End Sub
    Private Sub Btn_volver_Click(sender As Object, e As EventArgs)
        ''Dim entrada As New Entrada
        'Entrada.Show()
        Hide()
    End Sub

    Public Function MostrarLibros() As DataTable

        Dim dt As New DataTable()
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Dim con As SqlConnection = miConexion.CrearConexion(serverName)
        Dim cmd As New SqlCommand("mostrar_libros", con)
        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        Using da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        End Using
        con.Close()

        Return dt
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_agregar_imagen.Click
        add_imagen()
        MostrarLibros()
    End Sub
    Sub add_imagen()
        Try
            ' Obtener la fila seleccionada en el DataGridView
            Using selectedRow As DataGridViewRow = DataGridView_libros.SelectedRows(0)

                ' Extraer el valor del ID de la fila seleccionada
                Dim idlibro As Integer = Convert.ToInt32(selectedRow.Cells("idlibro").Value)

                ' Crear un objeto OpenFileDialog para permitir al usuario seleccionar una imagen
                Dim openFileDialog1 As New OpenFileDialog()

                ' Establecer las propiedades del OpenFileDialog
                openFileDialog1.Filter = "Archivos de imagen (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif"
                openFileDialog1.Title = "Seleccionar imagen"

                ' Mostrar el cuadro de diálogo y comprobar si el usuario hizo clic en "OK"
                If openFileDialog1.ShowDialog() = DialogResult.OK Then
                    ' Cargar la imagen seleccionada en un objeto Image
                    Dim image As Image = Image.FromFile(openFileDialog1.FileName)

                    ' Mostrar la imagen en la celda correspondiente de la fila seleccionada en el DataGridView
                    PictureBox3.Image = image

                    ' Guardar la imagen en la base de datos

                    ' Establecer la conexión a la base de datos
                    Dim serverName As String = login.ComboBox_Servidor.SelectedItem.ToString()
                    Dim con As SqlConnection = miConexion.CrearConexion(serverName)
                    con.Open()

                    ' Convertir la imagen a un arreglo de bytes utilizando un objeto MemoryStream
                    Dim ms As New MemoryStream()
                    image.Save(ms, ImageFormat.Jpeg)
                    Dim imageData As Byte() = ms.ToArray()

                    ' Insertar los datos de la imagen en la base de datos utilizando un comando SQL UPDATE
                    Dim cmd As New SqlCommand("UPDATE libros SET imagenes=@imagenes WHERE idlibro=@idlibro", con)
                    cmd.Parameters.AddWithValue("@imagenes", imageData)
                    cmd.Parameters.AddWithValue("@idlibro", idlibro)
                    cmd.ExecuteNonQuery()

                    ' Cerrar la conexión a la base de datos
                    con.Close()
                End If
            End Using

        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error correspondiente
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DataGridView_libros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_libros.CellClick
        Try
            If e.RowIndex >= 0 Then
                ' Mover la definición de selectedRow aquí
                Dim selectedRow As DataGridViewRow

                ' Obtener la fila seleccionada en el DataGridView
                selectedRow = DataGridView_libros.Rows(e.RowIndex)

                ' Verificar si la celda "imagenes" no es nula antes de convertirla a Byte()
                If selectedRow.Cells("imagenes").Value IsNot DBNull.Value Then
                    ' Obtener los datos de la imagen desde la celda seleccionada
                    Dim imageData As Byte() = DirectCast(selectedRow.Cells("imagenes").Value, Byte())

                    ' Crear un objeto MemoryStream a partir de los datos de la imagen
                    Dim ms As New MemoryStream(imageData)

                    ' Cargar la imagen en un objeto Image
                    Dim image As Image = Image.FromStream(ms)

                    ' Mostrar la imagen en el PictureBox2
                    PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
                    PictureBox3.Image = image
                Else
                    ' La celda "imagenes" contiene un valor nulo
                    'MessageBox.Show("La imagen no está disponible.")
                End If

                Dim idLibro As Integer = Convert.ToInt32(selectedRow.Cells("idLibro").Value)

                ' Obtener las unidades logísticas del libro seleccionado
                Dim dtUL As DataTable = MostrarUnidadesLogisticas(idLibro)

                ' Mostrar las unidades logísticas en un DataGridView
                Dim dgw As DataGridView = ObtenerDataGridView_UnidadesLogisticas()
                dgw.DataSource = dtUL
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub editar_libros()
        Try
            Dim editarLibrosForm As New Editar_libros(Me)
            editarLibrosForm.Show()
            ' Conexión a SQL Server
            Using selectedRow As DataGridViewRow = DataGridView_libros.SelectedRows(0)
                Dim idlibro As Integer = Convert.ToInt32(selectedRow.Cells("idlibro").Value)
                'Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
                Dim con As SqlConnection = miConexion.CrearConexion(ServerName)
                ' Consulta SQL para obtener los datos de la tabla filtrados por un parámetro
                Dim query As String = "SELECT nombre, autor,precio,ficha,description, stock_Total  from libros WHERE idlibro = @idlibro"
                ' Creación del comando y asignación de parámetros
                Dim command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@idlibro", idlibro)
                ' Lectura de los datos de la fila seleccionada
                con.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Asignación de los valores a los TextBox correspondientes
                    editarLibrosForm.TextBox5.Text = Convert.ToString(idlibro)
                    editarLibrosForm.TextBox1.Text = reader("nombre").ToString()
                    editarLibrosForm.TextBox2.Text = reader("autor").ToString()
                    editarLibrosForm.TextBox7.Text = Convert.ToInt32(reader("stock_total"))
                    editarLibrosForm.TextBox3.Text = reader("precio").ToString()
                    editarLibrosForm.DateTimePicker1.Value = Date.Parse(reader("ficha").ToString())
                    editarLibrosForm.TextBox4.Text = reader("description").ToString()
                End If
                reader.Close()
                con.Close()
            End Using
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        editar_libros()
        'Me.Hide()
    End Sub
    Private Sub Btn_añadir_libro_Click(sender As Object, e As EventArgs) Handles Btn_añadir_libro.Click
        añadire_libro.Show()
        Me.Hide()
    End Sub

    Public Sub eliminar_libros()
        'Dim idlibro_eliminado As Integer
        Dim cantidad As Integer
        Using selectedRow As DataGridViewRow = DataGridView_libros.SelectedRows(0)
            Dim idlibro As Integer = Convert.ToInt32(selectedRow.Cells("idlibro").Value)
            Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miConexion.CrearConexion(serverName)
            ' Primero, obtener el valor de stock para el libro actual.
            'Dim cmd As New SqlCommand("SELECT stock FROM UnidadesLogisticas WHERE idlibro = @idlibro", con)
            'cmd.Parameters.AddWithValue("@idlibro", Me.idLibro)
            'con.Open()
            'Dim reader As SqlDataReader = cmd.ExecuteReader()
            'Dim stock As Integer = 0
            'If reader.Read() Then
            '    stock = reader.GetInt32(0)
            'End If
            'con.Close()
            Dim cmd As New SqlCommand("SELECT stock FROM UnidadesLogisticas WHERE idlibro = @idlibro", con)
            cmd.Parameters.AddWithValue("@idlibro", idlibro) ' Corregido de Me.idLibro a idlibro
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim stock As Integer = 0
            If reader.Read() Then
                stock = reader.GetInt32(0)
            End If
            con.Close()

            Dim habia As Integer = stock
            ' Elimina las referencias en UnidadesLogisticas y Venta si existen
            Dim result As DialogResult = MessageBox.Show("El libro puede tener referencias en UnidadesLogisticas y/o Venta. ¿Quieres eliminarlo de todos modos?", "Confirmar eliminación", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Dim counUL As New SqlCommand("DELETE FROM UnidadesLogisticas WHERE idlibro = @idlibro", con)
                counUL.Parameters.AddWithValue("@idlibro", idlibro)
                cantidad = stock

                Insertar_MV_eliminar_LIBROS(cantidad, idlibro, habia)
                con.Open()
                counUL.ExecuteScalar()
                con.Close()

                Dim counVenta As New SqlCommand("DELETE FROM Venta WHERE idlibro = @idlibro", con)
                counVenta.Parameters.AddWithValue("@idlibro", idlibro)
                con.Open()
                counVenta.ExecuteScalar()
                con.Close()
            End If

            '  Movimientos

            Dim command As New SqlCommand("update  Movimientos set idlibro=NULL WHERE idlibro = @idLibro", con)
            command.Parameters.AddWithValue("@idLibro", idlibro)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()



            ' Elimina el libro
            Dim delete As New SqlCommand("DELETE FROM libros WHERE idlibro = @idlibro", con)
        delete.Parameters.AddWithValue("@idlibro", idLibro)
        con.Open()
        delete.ExecuteNonQuery()
        con.Close()

        MostrarLibros()
        End Using
    End Sub

    Sub Insertar_MV_eliminar_LIBROS(cantidad As Integer, idLibro As Integer, habia As Integer)
        Try
            Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miConexion.CrearConexion(serverName)
            ' Calcular hay y habia
            Dim hay As Integer = 0
            ' Insertar en Movimientos
            Dim command = New SqlCommand("INSERT INTO Movimientos(FechaMovimiento,idLibro, idlibro_eliminado, TipoMovimiento, Habia,tipo, Cantidad, hay) VALUES (GETDATE(),@idlibro, @idlibro_eliminado, 'salida', @habia,'eliminar libro', @Cantidad, @hay)", con)
            command.Parameters.AddWithValue("@idlibro", idLibro)
            command.Parameters.AddWithValue("@idlibro_eliminado", idLibro)
            command.Parameters.AddWithValue("@habia", habia)
            command.Parameters.AddWithValue("@Cantidad", cantidad)
            command.Parameters.AddWithValue("@hay", hay)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Btn_eliminar_libro_Click(sender As Object, e As EventArgs) Handles Btn_eliminar_libro.Click
        eliminar_libros()
        MostrarLibros()
    End Sub
    Public Function MostrarUnidadesLogisticas(idLibro As Integer) As DataTable
        Dim dt As New DataTable()
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Dim con As SqlConnection = miConexion.CrearConexion(serverName)
        Dim cmd As New SqlCommand("SELECT * FROM UnidadesLogisticas WHERE idLibro = @idLibro ORDER BY tipoUL", con)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@idLibro", idLibro)
        con.Open()
        Using da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim gestionar_del_stock As New unidades_logisticas()
        gestionar_del_stock.Show()
        Me.Hide()
    End Sub
    Sub buscar()
        Dim dt As New DataTable()
        Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
        Dim con As SqlConnection = miConexion.CrearConexion(serverName)
        Dim da As New SqlDataAdapter("buscar_libros", con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@letra", TextBox1.Text)
        da.Fill(dt)
        DataGridView_libros.DataSource = dt
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        buscar()
    End Sub
End Class
