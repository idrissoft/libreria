Imports System.Configuration
Imports System.Data.SqlClient

Public Class añadir_Cliente
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Hide()
    End Sub
    Public Function agregar_clientes()
        Try

            Dim con As New SqlConnection("Server=DESKTOP-N0AAU33\SQLEXPRESS;Database=libreria;Integrated Security=True;")

            Dim command As New SqlCommand("INSERT INTO Cliente(nombre, telefono, direccion, informacion) 
    VALUES (@nombre, @telefono, @direccion, @informacion)", con)
            'command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@nombre", TextBox1.Text)
            command.Parameters.AddWithValue("@telefono", TextBox2.Text)
            command.Parameters.AddWithValue("@direccion", TextBox3.Text)
            command.Parameters.AddWithValue("@informacion", TextBox4.Text)
            ' Ejecución de la consulta SQL
            con.Open()
            command.ExecuteNonQuery()

            ' Mensaje de confirmación
            MessageBox.Show("el cliente se ha agregado correctamente.")

            ' Cerrar el formulario secundario después de guardar los cambios
            Close()
            Dim fr_clientes As New Clientes
            fr_clientes.Show()

            ' Actualización de los datos mostrados en el formulario principal
            Clientes.mostrarClientes()


        Catch ex As Exception
            ' Si ocurre un error, mostrar un cuadro de mensaje con el mensaje de error
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub Btn_guardar_cliente1_Click(sender As Object, e As EventArgs) Handles Btn_guardar_cliente1.Click
        agregar_clientes()
    End Sub

    Private Sub añadir_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function modificar_cliente(ID_cliente As Integer)

        Try
            Dim con As New SqlConnection("Server=DESKTOP-N0AAU33\SQLEXPRESS;Database=libreria;Integrated Security=True;")
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
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles guardar_cambios.Click
        Dim dgvClientes As DataGridView = Clientes.ObtenerDataGridViewClientes()
        Dim ID_cliente As Integer = dgvClientes.CurrentRow.Cells("ID_cliente").Value
        modificar_cliente(ID_cliente)
    End Sub
End Class