Imports System.Data.SqlClient

Public Class añadire_libro
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Dim libros As New Libros()
        libros.Show()
        Me.Close()
    End Sub

    Private miconexion As New connexion

    Public Sub modificar_libro(idlibro As Integer)
        Try
            If idlibro <= 0 Then
                MessageBox.Show("El ID del libro no es válido.")
                Return
            End If

            Dim con As SqlConnection = miconexion.CrearConexion()
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

    Public Sub agregar_libro()
        Try
            Dim con As SqlConnection = miconexion.CrearConexion()

            ' Insertar nuevo libro
            Dim command As New SqlCommand("INSERT INTO libros(nombre, autor,precio,ficha ,description) OUTPUT INSERTED.idlibro VALUES (@nombre, @autor,@precio,@ficha ,@description)", con)
            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@autor", TextBox2.Text)
            command.Parameters.AddWithValue("@precio", TextBox3.Text)
            command.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)
            command.Parameters.AddWithValue("@description", TextBox4.Text)
            con.Open()
            ' Ejecutar la consulta y obtener el idlibro del libro recién insertado
            Dim idlibro As Integer = command.ExecuteScalar()
            con.Close()

            ' Insertar en UnidadesLogisticas con el idlibro obtenido
            command = New SqlCommand("INSERT INTO UnidadesLogisticas(idlibro, tipoUL,unidades_por_UL, stock) VALUES (@idlibro, @tipoUL,@unidades_por_UL, @stock)", con)
            command.Parameters.AddWithValue("@idlibro", idlibro)
            command.Parameters.AddWithValue("@tipoUL", ComboBox_unidad_logistica.SelectedItem)
            command.Parameters.AddWithValue("@unidades_por_UL", TxtUporUL.Text)
            command.Parameters.AddWithValue("@stock", TextBox7.Text)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
            ' Actualización del stock total
            command = New SqlCommand("EXEC ActualizarStockTotal @idLibro", con)
            command.Parameters.AddWithValue("@idLibro", idlibro)
            con.Open()
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("El libro se ha agregado correctamente.")
            Dim fr_libro As New Libros()
            fr_libro.Show()
            Me.Close()
            fr_libro.MostrarLibros()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub insertar_MV_LIBROS()
        '    Try
        '        Dim con As SqlConnection = miconexion.CrearConexion()
        '        Dim hay = TextBox7.Text + 
        '        ' Insertar en Movimientos
        '        Dim command = New SqlCommand("INSERT INTO Movimientos(FechaMovimiento, idlibro, TipoMovimiento, Habia, Cantidad, hay) VALUES (GETDATE(), @idlibro, 'Entrada', 0, @Cantidad, @hay)", con)
        '        command.Parameters.AddWithValue("@idlibro", idlibro)
        '        command.Parameters.AddWithValue("@Cantidad", TextBox7.Text)
        '        command.Parameters.AddWithValue("@hay", hay)
        '        con.Open()
        '        command.ExecuteNonQuery()
        '        con.Close()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
    End Sub
    Private Sub Btn_guardar_libro1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_libro1.Click
        agregar_libro()
        insertar_MV_LIBROS()
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
