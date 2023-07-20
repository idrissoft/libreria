Imports System.Data.SqlClient

Imports System.Windows.Forms

Public Class Clientes
    Public Property ID_Cliente As String
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Direccion As String
    Public Property Informacion As String
    'Private ComboBox_Servidor As ComboBox
    Public Property ServerName As String
    Public Function ObtenerDataGridViewClientes() As DataGridView
        Return DataGridView_clientes
    End Function
    Dim miconexion As New connexion


    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarClientes()
    End Sub
    Public Function mostrarClientes() As DataTable
        Dim dt As New DataTable()

        Dim con As SqlConnection = miconexion.CrearConexion(serverName)
        Dim cmd As New SqlCommand("mostrar_cliente", con)
        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        Using da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView_clientes.DataSource = dt
        End Using
        Return dt
    End Function
    Public Sub eliminar_clientes()
        Try
            Using selectedRow As DataGridViewRow = DataGridView_clientes.SelectedRows(0)
                Dim id_cliente As Integer = Convert.ToInt32(selectedRow.Cells("id_cliente").Value)
                'Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
                Dim con As SqlConnection = miconexion.CrearConexion(serverName)

                Dim delete As New SqlCommand("DELETE FROM cliente WHERE id_cliente = @id_cliente", con)
                delete.Parameters.AddWithValue("@id_cliente", id_cliente)

                con.Open()
                delete.ExecuteNonQuery()

                con.Close()
                mostrarClientes()
            End Using
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscar()


        Dim dt As New DataTable()
        'Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
        Dim con As SqlConnection = miconexion.CrearConexion(serverName)
        Dim da As New SqlDataAdapter("buscar_clientes", con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@letra", TextBox1.Text)
        da.Fill(dt)
        DataGridView_clientes.DataSource = dt
    End Sub


    Sub Editar()
        Try
            Dim a As New añadir_Cliente()
            a.Show()
            ' Conexión a SQL Server
            Using selectedRow As DataGridViewRow = DataGridView_clientes.SelectedRows(0)
                Dim ID_cliente As Integer = Convert.ToInt32(selectedRow.Cells("ID_cliente").Value)
                'Dim serverName As String = ComboBox_Servidor.SelectedItem.ToString()
                Dim con As SqlConnection = miconexion.CrearConexion(ServerName)

                Dim query As String = "SELECT nombre, telefono, direccion, informacion from cliente WHERE ID_cliente = @ID_cliente"

                Dim command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@ID_cliente", ID_cliente)
                con.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    a.TextBox1.Text = reader("nombre").ToString()
                    a.TextBox2.Text = reader("telefono").ToString()
                    a.TextBox3.Text = reader("direccion").ToString()
                    a.TextBox3.Text = reader("informacion").ToString()
                End If

                reader.Close()
                con.Close()
            End Using
        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Editar()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs)
        'Dim entrada As New Entrada()
        'entrada.Show()
        Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        buscar()
    End Sub
End Class