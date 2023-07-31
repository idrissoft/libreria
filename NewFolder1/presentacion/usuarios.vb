
Imports System.Data.SqlClient
Public Class usuarios
    Dim miconexion As New connexion
    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_usuarios()
    End Sub

    Private Sub mostrar_usuarios()
        Dim servidor As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Dim con As SqlConnection = miconexion.CrearConexion(servidor)
        Dim da As New SqlDataAdapter("select * from usuarios", con)
        Dim dt As New DataTable()
        con.Open()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

End Class