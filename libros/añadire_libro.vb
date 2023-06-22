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
            Dim command As New SqlCommand("UPDATE libros SET nombre = @nombre, autor = @autor, cantidad = @cantidad, stock = @stock, ficha = @ficha, description = @description WHERE idlibro = @idlibro", con)
            command.Parameters.AddWithValue("@idlibro", idlibro)
            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@autor", TextBox2.Text)
            command.Parameters.AddWithValue("@description", TextBox4.Text)
            command.Parameters.AddWithValue("@cantidad", TextBox6.Text)
            command.Parameters.AddWithValue("@stock", TextBox7.Text)
            command.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)

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
            Dim command As New SqlCommand("INSERT INTO libros(nombre, autor, ficha, cantidad, stock, precio, description) VALUES (@nombre, @autor, @ficha, @cantidad, @stock, @precio, @description)", con)

            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@autor", TextBox2.Text)
            command.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)
            command.Parameters.AddWithValue("@cantidad", TextBox6.Text)
            command.Parameters.AddWithValue("@stock", TextBox7.Text)
            command.Parameters.AddWithValue("@precio", TextBox3.Text)
            command.Parameters.AddWithValue("@description", TextBox4.Text)

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

    Private Sub Btn_guardar_libro1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_libro1.Click
        agregar_libro()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
