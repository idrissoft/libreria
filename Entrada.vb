Public Class Entrada
    Private Sub Btnlibros_Click(sender As Object, e As EventArgs) Handles Btnlibros.Click
        Dim libros As New Libros()
        libros.Show()
        Hide()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Dim cliente As New Clientes()
        Clientes.Show()
        Hide()
    End Sub

    Private Sub BtnCompra_Click(sender As Object, e As EventArgs) Handles BtnCompra.Click
        Dim venta As New Venta()
        venta.Show()
        Me.Hide()
    End Sub
End Class
