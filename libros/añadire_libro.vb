Imports System.Data.SqlClient

Public Class añadire_libro
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Dim libros As New Libros()
        libros.Show()
        Me.Close()
    End Sub
    Private idlibro As Integer
    Private miconexion As New connexion
    Private ComboBox_Servidor As ComboBox
    Public Sub modificar_libro(idlibro As Integer)
        Try
            If idlibro <= 0 Then
                MessageBox.Show("El ID del libro no es válido.")
                Return
            End If


            Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miconexion.CrearConexion(serverName)
            Dim command As New SqlCommand("UPDATE libros SET nombre = @nombre, autor = @autor, ,precio = @precio, ficha = @ficha,  description = @description WHERE idlibro = @idlibro", con)
            command.Parameters.AddWithValue("@idlibro", idlibro)
            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@autor", TextBox2.Text)
            command.Parameters.AddWithValue("@precio", TextBox3.Text)
            command.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)
            command.Parameters.AddWithValue("@description", TextBox4.Text)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("El libro se ha modificado correctamente.")
            Dim fr_libro As New Libros
            fr_libro.Show()
            Me.Close()
            fr_libro.MostrarLibros()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub guardar_cambios1_Click(sender As Object, e As EventArgs) Handles guardar_cambios1.Click
        Dim dgvlibros As DataGridView = Libros.ObtenerDataGridViewLibros()
        Try
            Dim idlibro As Integer = Convert.ToInt32(dgvlibros.CurrentRow.Cells("idlibro").Value)
            modificar_libro(idlibro)
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private stockIngresado As Integer


    Sub agregar_libro()
        Try
            Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miconexion.CrearConexion(serverName)

            ' Insertar nuevo libro
            Dim command As New SqlCommand("INSERT INTO libros(nombre, autor, precio, ficha, description) OUTPUT INSERTED.idlibro VALUES (@nombre, @autor, @precio, @ficha, @description)", con)
            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@autor", TextBox2.Text)
            command.Parameters.AddWithValue("@precio", TextBox3.Text)
            command.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)
            command.Parameters.AddWithValue("@description", TextBox4.Text)
            con.Open()

            ' Ejecutar la consulta y obtener el idlibro del libro recién insertado
            Me.idlibro = command.ExecuteScalar()
            con.Close()

            ' Intentar convertir el contenido de TextBox7.Text a un número
            Dim cantidad As Integer
            If Not Integer.TryParse(TextBox7.Text, cantidad) Then
                MessageBox.Show("Por favor, ingrese un número válido en TextBox7.")
                Return
            End If

            ' Insertar en UnidadesLogisticas con el idlibro obtenido
            command = New SqlCommand("INSERT INTO UnidadesLogisticas(idlibro, tipoUL, unidades_por_UL, stock) VALUES (@idlibro, @tipoUL, @unidades_por_UL, @stock)", con)
            command.Parameters.AddWithValue("@idlibro", idlibro)
            command.Parameters.AddWithValue("@tipoUL", ComboBox_unidad_logistica.SelectedItem)
            command.Parameters.AddWithValue("@unidades_por_UL", TxtUporUL.Text)
            command.Parameters.AddWithValue("@stock", cantidad)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()

            ' Actualización del stock total
            command = New SqlCommand("EXEC ActualizarStockTotal @idLibro", con)
            command.Parameters.AddWithValue("@idLibro", idlibro)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()

            ' Insertar Movimientos
            Insertar_MV_LIBROS(cantidad)

            MessageBox.Show("El libro se ha agregado correctamente.")
            Dim fr_libro As New Libros()
            'fr_libro.Show()
            Me.Close()
            fr_libro.MostrarLibros()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Insertar_MV_LIBROS(cantidad As Integer)
        Try
            Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miconexion.CrearConexion(serverName)

            ' Primero, obtener el valor de stock para el libro actual.
            Dim command As New SqlCommand("SELECT stock FROM UnidadesLogisticas WHERE idlibro = @idlibro", con)
            command.Parameters.AddWithValue("@idlibro", Me.idlibro)
            con.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Dim stock As Integer = 0
            If reader.Read() Then
                stock = reader.GetInt32(0)
            End If
            con.Close()

            ' Calcular hay y habia
            Dim hay As Integer = cantidad + stock
            Dim habia As Integer = stock

            ' Insertar en Movimientos
            command = New SqlCommand("INSERT INTO Movimientos(FechaMovimiento, idlibro, TipoMovimiento, Habia, Cantidad, hay) VALUES (GETDATE(), @idlibro, 'Entrada', @habia, @Cantidad, @hay)", con)
            command.Parameters.AddWithValue("@idlibro", Me.idlibro)
            command.Parameters.AddWithValue("@habia", habia)
            command.Parameters.AddWithValue("@Cantidad", "+" & cantidad)
            command.Parameters.AddWithValue("@hay", hay)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Btn_guardar_libro1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_libro1.Click

        Dim cantidad As Integer
        If Not Integer.TryParse(TextBox7.Text, cantidad) Then
            MessageBox.Show("Por favor, ingrese un número válido en TextBox7.")
            Return
        End If
        agregar_libro()
        Insertar_MV_LIBROS(cantidad)
    End Sub

    Sub cargar_unidad_logistoca()
        ComboBox_unidad_logistica.Items.Clear()
        ComboBox_unidad_logistica.Items.Add(0)
        ComboBox_unidad_logistica.Items.Add(1)
    End Sub

    Private Sub añadire_libro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        cargar_unidad_logistoca()
    End Sub

    Private Sub ComboBox_unidad_logistica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_unidad_logistica.SelectedIndexChanged
        If ComboBox_unidad_logistica.SelectedItem.ToString() = "0" Then

            TxtUporUL.Text = "0"  ' TextBox8 es Unidad_por_UL
            TextBox7.Text = "0"  ' TextBox7 es stock
        ElseIf ComboBox_unidad_logistica.SelectedItem.ToString() = "1" Then
            ' Cuando la Unidad Logística es 1, entonces la Unidad_por_UL tiene el número de unidades dentro de la Unidad Logística
            TxtUporUL.Text = "1"
            TextBox7.Text = TxtUporUL.Text
        Else
            ' Manejo de otros valores
        End If
    End Sub

End Class
