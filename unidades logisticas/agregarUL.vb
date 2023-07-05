Imports System.Data.SqlClient

Public Class agregarUL
    Private miconexion As New connexion
    Private idLibro As Integer

    Public Sub New(ByVal idLibro As Integer)
        InitializeComponent()
        Me.idLibro = idLibro
    End Sub

    Private Sub Btn_guardar_UL_Click(sender As Object, e As EventArgs) Handles Btn_guardar_UL.Click
        Try
            Dim con As SqlConnection = miconexion.CrearConexion()

            Dim tipoUL As Integer = ComboBox1.SelectedItem
            Dim stock As Integer = TextBox2.Text
            Dim unidades_por_UL As Integer = TextBox1.Text

            ' Chequeamos si existe una unidad logística con el mismo id de libro y tipo de unidad logística
            Dim commandCheck As New SqlCommand("SELECT COUNT(*) FROM UnidadesLogisticas WHERE idLibro = @idLibro AND tipoUL = @tipoUL", con)
            commandCheck.Parameters.AddWithValue("@idLibro", idLibro)
            commandCheck.Parameters.AddWithValue("@tipoUL", tipoUL)

            con.Open()

            Dim exist As Integer = commandCheck.ExecuteScalar()

            Console.WriteLine("Exist: " & exist)

            con.Close()

            If exist > 0 Then
                ' Si existe, incrementamos el stock
                Dim commandUpdate As New SqlCommand("UPDATE UnidadesLogisticas SET stock = stock + @stock WHERE idLibro = @idLibro AND tipoUL = @tipoUL", con)
                commandUpdate.Parameters.AddWithValue("@idLibro", idLibro)
                commandUpdate.Parameters.AddWithValue("@tipoUL", tipoUL)
                commandUpdate.Parameters.AddWithValue("@stock", stock)

                con.Open()

                commandUpdate.ExecuteNonQuery()

                Console.WriteLine("Stock actualizado.")

                con.Close()
            Else
                ' Si no existe, insertamos una nueva fila
                Dim commandInsert As New SqlCommand("INSERT INTO UnidadesLogisticas(idLibro, tipoUL, unidades_por_UL, stock) VALUES (@idLibro, @tipoUL, @unidades_por_UL, @stock)", con)
                commandInsert.Parameters.AddWithValue("@idLibro", idLibro)
                commandInsert.Parameters.AddWithValue("@tipoUL", tipoUL)
                commandInsert.Parameters.AddWithValue("@unidades_por_UL", unidades_por_UL)
                commandInsert.Parameters.AddWithValue("@stock", stock)

                con.Open()

                commandInsert.ExecuteNonQuery()

                Console.WriteLine("Nueva unidad logística insertada.")

                con.Close()
            End If

            ' Ahora actualizamos el stock total del libro en la tabla Libros
            Dim commandUpdateTotalStock As New SqlCommand("UPDATE Libros SET stock_Total = (SELECT SUM(stock) FROM UnidadesLogisticas WHERE idLibro = @idLibro) WHERE idLibro = @idLibro", con)
            commandUpdateTotalStock.Parameters.AddWithValue("@idLibro", idLibro)

            con.Open()

            commandUpdateTotalStock.ExecuteNonQuery()

            Console.WriteLine("Stock total actualizado.")

            con.Close()

            MessageBox.Show("Se ha agregado correctamente.")

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub agregarUL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add(0)
        ComboBox1.Items.Add(1)
    End Sub
End Class
