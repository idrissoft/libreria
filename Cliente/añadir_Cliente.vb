Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class añadir_Cliente

    Inherits Form
    Private ComboBox_Servidor As ComboBox
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Hide()
    End Sub

    Private miconexion As New connexion

    Public Sub agregar_clientes()
        Try
            Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miconexion.CrearConexion(serverName)

            Dim command As New SqlCommand("INSERT INTO Cliente(nombre, telefono, direccion, informacion) 
                                      VALUES (@nombre, @telefono, @direccion, @informacion)", con)

            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@telefono", TextBox2.Text)
            command.Parameters.AddWithValue("@direccion", TextBox3.Text)
            command.Parameters.AddWithValue("@informacion", TextBox4.Text)

            con.Open()
            command.ExecuteNonQuery()

            MessageBox.Show("El cliente se ha agregado correctamente.")

            con.Close()

            Dim fr_clientes As New Clientes()
            fr_clientes.Show()

            Clientes.mostrarClientes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_guardar_cliente1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_cliente1.Click
        agregar_clientes()
    End Sub

    Private Sub añadir_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub modificar_cliente(ID_cliente As Integer)
        Try
            Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
            Dim con As SqlConnection = miconexion.CrearConexion(serverName)

            Dim command As New SqlCommand("UPDATE Cliente SET nombre = @nombre, telefono = @telefono, direccion = @direccion, informacion = @informacion WHERE ID_cliente = @ID_cliente", con)
            command.Parameters.AddWithValue("@ID_cliente", ID_cliente)
            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@telefono", TextBox2.Text)
            command.Parameters.AddWithValue("@direccion", TextBox3.Text)
            command.Parameters.AddWithValue("@informacion", TextBox4.Text)

            con.Open()
            command.ExecuteNonQuery()

            MessageBox.Show("El cliente se ha modificado correctamente.")

            Dim fr_clientes As New Clientes
            fr_clientes.Show()

            Close()

            Clientes.mostrarClientes()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles guardar_cambios.Click
        Dim dgvClientes As DataGridView = Clientes.ObtenerDataGridViewClientes()
        Dim ID_cliente As Integer = dgvClientes.CurrentRow.Cells("ID_cliente").Value
        modificar_cliente(ID_cliente)
    End Sub
End Class
