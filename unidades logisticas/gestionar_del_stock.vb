﻿Imports System.Data.SqlClient
Imports System.IO
Public Class unidades_logisticas
    Private miConexion As New connexion()
    Private libros As New Libros()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim libros As New Libros
        libros.Show()
        Me.Hide()
    End Sub

    Private Sub unidades_logisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.DataSource = libros.MostrarLibros()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView2.CurrentCell.RowIndex
        Dim idLibro As Integer = Convert.ToInt32(DataGridView2.Rows(rowindex).Cells("idLibro").Value)

        ' Obtener las unidades logísticas del libro seleccionado
        Dim dtUL As DataTable = libros.MostrarUnidadesLogisticas(idLibro)

        ' Mostrar las unidades logísticas en un DataGridView
        DataGridView_UL.DataSource = dtUL
    End Sub

    Private Sub DataGridView_UL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_UL.CellClick
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView_UL.CurrentCell.RowIndex

        ' Obtener los valores de las columnas correspondientes
        Dim idLibro As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("idlibro").Value)
        Dim idUL As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("idUL").Value)
        Dim tipoUL As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("tipoUL").Value)
        Dim stock As Integer = Convert.ToInt32(DataGridView_UL.Rows(rowindex).Cells("stock").Value)

        '' Mostrar los datos del libro en los cuadros de texto correspondientes
        TextBox13.Text = idLibro.ToString()
        TextBox6.Text = idUL.ToString()
        TextBox9.Text = tipoUL.ToString()
        TextBox8.Text = stock.ToString()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim selectedRow As DataGridViewRow
        ' Obtener el número de fila seleccionada
        Dim rowindex As Integer = DataGridView2.CurrentCell.RowIndex
        selectedRow = DataGridView2.Rows(rowindex)
        Dim idLibro As Integer = Convert.ToInt32(selectedRow.Cells("idLibro").Value)

        Dim UL As New agregarUL(idLibro)
        UL.Show()
    End Sub
End Class