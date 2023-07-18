Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class Login

    Public movimientosForm As New Movimientos
    Public clientesform As New Clientes
    Public librosform As New Libros
    Public ventaform As New Venta
    Public unidades_logisticasform As New unidades_logisticas
    Public Nueva_Ventaform As New Nueva_Venta
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_Servidor.Items.Add("DESKTOP-N0AAU33\SQLEXPRESS")
        ComboBox_Servidor.Items.Add("MBWS093\SQLEXPRESS")
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ComboBox_Servidor.SelectedIndex < 0 Then
            MessageBox.Show("Por favor, selecciona un servidor.")
            Return
        End If
        Dim servidor As String = ComboBox_Servidor.SelectedItem.ToString()
        Dim usuario As String = txtUser.Text
        Dim contraseña As String = txtPass.Text
        If AutenticarUsuario(usuario, contraseña, servidor) Then
            ' Autenticación exitosa
            ' Aquí puedes mostrar el formulario de entrada
            movimientosForm.ServerName = servidor
            clientesform.ServerName = servidor
            librosform.ServerName = servidor
            ventaform.ServerName = servidor
            unidades_logisticasform.ServerName = servidor
            Libros.ServerName = servidor
            Dim entradaForm As New Entrada(movimientosForm, clientesform, librosform, ventaform, unidades_logisticasform) ' Pasa la instancia de Movimientos al constructor de Entrada

            entradaForm.Show() ' Muestra el formulario Entrada
            Me.Hide() ' Esconde el formulario de Login
        Else
            ' Autenticación fallida
            MessageBox.Show("Usuario o contraseña incorrecta.")
        End If
    End Sub
    Private Sub exite_Click(sender As Object, e As EventArgs) Handles exite.Click
        Application.Exit()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub CustomizeComponents()
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 30)
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 30)
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

    Private Function AutenticarUsuario(usuario As String, contraseña As String, servidor As String) As Boolean
        Dim autenticado As Boolean = False
        Dim connString As String = "Data Source=" & servidor & ";Initial Catalog=libreria;Integrated Security=True;"
        Using conn As New SqlConnection(connString)
            conn.Open()
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM dbo.Usuarios WHERE Usuario = @user AND Contrasena = @pass", conn)
            cmd.Parameters.AddWithValue("@user", usuario)
            cmd.Parameters.AddWithValue("@pass", contraseña)
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                autenticado = True
            End If
            conn.Close()
        End Using
        Return autenticado
    End Function


End Class
