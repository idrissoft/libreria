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
            ' Primero, verifica si ya existe un registro con el mismo tipoUL
            Dim commandCheck As New SqlCommand("SELECT COUNT(*) FROM UnidadesLogisticas WHERE idLibro = @idLibro AND tipoUL = @tipoUL", con)
            commandCheck.Parameters.AddWithValue("@idLibro", idLibro)
            commandCheck.Parameters.AddWithValue("@tipoUL", tipoUL)

            con.Open()

            Dim exist As Integer = commandCheck.ExecuteScalar()

            con.Close()

            If exist > 0 Then
                ' Si el registro existe, actualiza el stock
                Dim commandUpdate As New SqlCommand("UPDATE UnidadesLogisticas SET stock = stock + @stock WHERE idLibro = @idLibro AND tipoUL = @tipoUL,unidades_por_UL=@unidades_por_UL", con)
                commandUpdate.Parameters.AddWithValue("@idLibro", idLibro)
                commandUpdate.Parameters.AddWithValue("@tipoUL", tipoUL)
                commandUpdate.Parameters.AddWithValue("@unidades_por_ULL", unidades_por_UL)
                commandUpdate.Parameters.AddWithValue("@stock", stock)

                con.Open()
                commandUpdate.ExecuteNonQuery()
                con.Close()
            Else
                ' Si el registro no existe, inserta un nuevo registro
                Dim commandInsert As New SqlCommand("INSERT INTO UnidadesLogisticas(idLibro, tipoUL,unidades_por_ULL, stock) VALUES (@idLibro, @tipoUL,@unidades_por_ULL, @stock)", con)
                commandInsert.Parameters.AddWithValue("@idLibro", idLibro)
                commandInsert.Parameters.AddWithValue("@tipoUL", tipoUL)
                commandInsert.Parameters.AddWithValue("@unidades_por_ULL", unidades_por_UL)
                commandInsert.Parameters.AddWithValue("@stock", stock)

                con.Open()
                commandInsert.ExecuteNonQuery()
                con.Close()
            End If

            MessageBox.Show(" se ha agregado correctamente.")

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
