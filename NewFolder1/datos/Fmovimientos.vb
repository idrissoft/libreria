Imports System.Data.SqlClient

Public Class Fmovimientos
    Inherits connexion
    Public Function mostrar_Movimientos()
        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Dim da As New SqlDataAdapter("SELECT * FROM Movimientos", con)
        Dim dt As New DataTable()
        conectado()
        da.Fill(dt)
        Return dt
        desconectado()
    End Function
End Class
