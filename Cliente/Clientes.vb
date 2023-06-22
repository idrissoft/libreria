﻿Imports System.Data.SqlClient

Public Class Clientes
    Public Property ID_Cliente As String
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Direccion As String
    Public Property Informacion As String
    Public Function ObtenerDataGridViewClientes() As DataGridView
        Return DataGridView_clientes
    End Function
    Dim miconexion As New connexion
    Private Sub Btn_anadir_clientes_Click(sender As Object, e As EventArgs) Handles Btn_anadir_clientes.Click
        Dim añadir_cliente As New añadir_Cliente
        añadir_cliente.Show()
        Hide()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarClientes()
    End Sub
    Public Function mostrarClientes() As DataTable
        Dim dt As New DataTable()
        Dim con As SqlConnection = miconexion.CrearConexion()
        Dim cmd As New SqlCommand("mostrar_cliente", con)
        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        Using da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView_clientes.DataSource = dt
        End Using
        Return dt
    End Function
    Public Function eliminar_clientes()
        Try
            Using selectedRow As DataGridViewRow = DataGridView_clientes.SelectedRows(0)
                Dim id_cliente As Integer = Convert.ToInt32(selectedRow.Cells("id_cliente").Value)
                Dim con As SqlConnection = miconexion.CrearConexion()

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
    End Function
    Private Sub Btn_eliminar_clientes_Click(sender As Object, e As EventArgs) Handles Btn_eliminar_clientes.Click
        eliminar_clientes()
    End Sub
    Sub buscar()

        Dim dt As New DataTable()
        Dim con As SqlConnection = miconexion.CrearConexion()
        Dim da As New SqlDataAdapter("buscar_clientes", con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@letra", ComboBox1.Text)
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
                Dim con As SqlConnection = miconexion.CrearConexion()

                ' Consulta SQL para obtener los datos de la tabla filtrados por un parámetro
                Dim query As String = "SELECT nombre, telefono, direccion, informacion from cliente WHERE ID_cliente = @ID_cliente"

                ' Creación del comando y asignación de parámetros
                Dim command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@ID_cliente", ID_cliente)

                ' Lectura de los datos de la fila seleccionada
                con.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Asignación de los valores a los TextBox correspondientes
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
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        buscar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Editar()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Dim entrada As New Entrada()
        entrada.Show()
        Hide()
    End Sub
End Class