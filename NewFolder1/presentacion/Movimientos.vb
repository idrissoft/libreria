Imports System.Data.SqlClient

Public Class Movimientos

    Public Property ServerName As String
    Dim FV As New Fmovimientos()
    Dim miconexion As New connexion

    Sub mostrar_Movimientos()
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Dim con As SqlConnection = miconexion.CrearConexion(serverName)
        Dim da As New SqlDataAdapter("SELECT * FROM Movimientos", con)
        Dim dt As New DataTable()
        con.Open()
        da.Fill(dt)
        DataGridView_Movimientos.DataSource = dt
        con.Close()
    End Sub

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_Movimientos.DataSource = FV.mostrar_Movimientos()
    End Sub
End Class
