Imports System.Data.SqlClient
Imports System.IO
Public Class unidades_logisticas
    Private miConexion As New connexion()
    Private libros As New Libros()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim libros As New Libros
        libros.Show()
        Me.Hide()
    End Sub

    Private Sub unidades_logisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.DataSource = libros.MostrarLibros()

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView2.CurrentCell.RowIndex
        Dim idLibro As Integer = Convert.ToInt32(DataGridView2.Rows(rowindex).Cells("idLibro").Value)

        ' Obtener las unidades logísticas del libro seleccionado
        Dim dtUL As DataTable = libros.MostrarUnidadesLogisticas(idLibro)



        ' Mostrar las unidades logísticas en un DataGridView
        DataGridView_UL.DataSource = dtUL
    End Sub

    Private Sub DataGridView_UL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_UL.CellClick
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView_UL.CurrentCell.RowIndex

        ' Obtener los valores de las columnas correspondientes
        Dim idLibro As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("idlibro").Value)
        Dim idUL As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("idUL").Value)
        Dim tipoUL As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("tipoUL").Value)
        Dim unidades_por_UL As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("unidades_por_UL").Value)
        Dim stock As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("stock").Value)

        '' Mostrar los datos del libro en los cuadros de texto correspondientes
        TextBox13.Text = idLibro.ToString()
        TextBox6.Text = idUL.ToString()
        TextBox14.Text = tipoUL.ToString()
        TextBox9.Text = unidades_por_UL.ToString()
        TextBox8.Text = stock.ToString()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim selectedRow As DataGridViewRow
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView2.CurrentCell.RowIndex
        selectedRow = DataGridView2.Rows(rowindex)
        Dim idLibro As Integer = Convert.ToInt32(selectedRow.Cells("idLibro").Value)

        Dim UL As New agregarUL(idLibro)
        UL.Show()
    End Sub

    Private Sub desmontar_Click(sender As Object, e As EventArgs) Handles desmontar.Click
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView_UL.CurrentCell.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView_UL.Rows(rowindex)

        Try
            Dim con As SqlConnection = miConexion.CrearConexion()

            Dim stock As Integer = Convert.ToInt32(TextBox8.Text)
            Dim unidades_por_UL As Integer = Convert.ToInt32(TextBox9.Text)
            Dim idUL As Integer = Convert.ToInt32(TextBox6.Text)
            Dim idLibro As Integer = Convert.ToInt32(TextBox13.Text)

            Dim commandUpdate As New SqlCommand("UPDATE UnidadesLogisticas SET stock = stock - @stock WHERE idLibro = @idLibro AND tipoUL = 1 AND unidades_por_UL = @unidades_por_UL", con)

            commandUpdate.Parameters.AddWithValue("@unidades_por_UL", unidades_por_UL)
            commandUpdate.Parameters.AddWithValue("@stock", stock)
            commandUpdate.Parameters.AddWithValue("@idLibro", idLibro)

            con.Open()
            commandUpdate.ExecuteNonQuery()
            con.Close()

            ' Obtener el idUL para la unidad logística tipo 0 del libro en cuestión
            Dim commandSelect As New SqlCommand("SELECT idUL FROM UnidadesLogisticas WHERE idLibro = @idLibro AND tipoUL = 0", con)

            commandSelect.Parameters.AddWithValue("@idLibro", idLibro)

            con.Open()
            Dim idUL0 As Integer = Convert.ToInt32(commandSelect.ExecuteScalar())
            con.Close()

            ' Usar este idUL para actualizar el stock de la unidad logística tipo 0
            Dim commandUpdate1 As New SqlCommand("UPDATE UnidadesLogisticas SET stock = stock + (@stock * @unidades_por_UL) WHERE idUL = @idUL0", con)

            commandUpdate1.Parameters.AddWithValue("@unidades_por_UL", unidades_por_UL)
            commandUpdate1.Parameters.AddWithValue("@stock", stock)
            commandUpdate1.Parameters.AddWithValue("@idUL0", idUL0)

            con.Open()
            commandUpdate1.ExecuteNonQuery()
            con.Close()

            MessageBox.Show(" se ha agregado correctamente.")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub montar_Click(sender As Object, e As EventArgs) Handles montar.Click
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView_UL.CurrentCell.RowIndex
        Dim selectedRow As DataGridViewRow = DataGridView_UL.Rows(rowindex)

        Try
            Dim con As SqlConnection = miConexion.CrearConexion()

            Dim stock As Integer = Convert.ToInt32(TextBox8.Text)
            Dim idUL As Integer = Convert.ToInt32(TextBox6.Text)
            Dim idLibro As Integer = Convert.ToInt32(TextBox13.Text)
            Dim uunidades_por_ULnidad As Integer = Convert.ToInt32(TextBox9.Text)
            ' Obtener unidades_por_UL para UnidadLogistica de tipo 1
            Dim commandSelect As New SqlCommand("SELECT unidades_por_UL FROM UnidadesLogisticas WHERE idLibro = @idLibro AND tipoUL = 1", con)
            commandSelect.Parameters.AddWithValue("@idLibro", idLibro)

            con.Open()
            Dim unidades_por_UL As Integer = Convert.ToInt32(commandSelect.ExecuteScalar())
            con.Close()

            ' Restar unidades del stock de UnidadLogistica de tipo 0
            Dim commandUpdate As New SqlCommand("UPDATE UnidadesLogisticas SET stock = -@stock+stock WHERE idLibro = @idLibro AND tipoUL = 0", con)
            commandUpdate.Parameters.AddWithValue("@unidades_por_UL", unidades_por_UL)
            commandUpdate.Parameters.AddWithValue("@stock", stock)
            commandUpdate.Parameters.AddWithValue("@idLibro", idLibro)

            con.Open()
            commandUpdate.ExecuteNonQuery()
            con.Close()

            ' Agregar esas unidades al stock de UnidadLogistica de tipo 1
            Dim commandUpdate1 As New SqlCommand("UPDATE UnidadesLogisticas SET stock = stock + @stock/unidades_por_UL WHERE idLibro = @idLibro AND tipoUL = 1", con)
            commandUpdate1.Parameters.AddWithValue("@stock", stock)
            commandUpdate1.Parameters.AddWithValue("@idLibro", idLibro)

            con.Open()
            commandUpdate1.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Las unidades han sido montadas correctamente.")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
