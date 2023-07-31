Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp


Public Class Entrada

    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentchildform As Form
    Private currentPanel As Panel
    ' Nuevas variables de instancia para formularios
    Private movimientosForm As Movimientos
    Private clientesForm As Clientes
    Private ventaForm As Venta
    Private unidades_logisticasform As unidades_logisticas
    Private librosform As New Libros
    Private miConexion As New connexion()
    Public Property ServerName As String
    Public Property idLibro As String
    Public Property IconChar As Object

    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CenterToParent()

    End Sub
    Public Sub New(movimientos As Movimientos, clientes As Clientes, libros As Libros, venta As Venta, unidades_logisticas As unidades_logisticas)
        ' This call is required by the designer.
        InitializeComponent()

        ' Asignar los formularios a las variables de instancia
        Me.movimientosForm = movimientos
        Me.clientesForm = clientes
        Me.librosform = libros
        Me.ventaForm = venta
        Me.unidades_logisticasform = unidades_logisticas

        ' Add any initialization after the call to InitializeComponent().
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            disablebutton()
            'Button 
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'left border
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current form icon 
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customcolor
        End If
    End Sub
    Private Sub disablebutton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.MidnightBlue
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub Activatepanel()
        currentPanel.Show()
    End Sub
    Private Sub disablePanel()
        If currentPanel IsNot Nothing Then
            currentPanel.Visible = False
        End If
    End Sub
    Private Sub openchildform(childform As Form)
        'open only form
        'If currentchildform IsNot Nothing Then
        '    currentchildform.Close()
        'End If
        currentchildform = childform
        'end
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childform)
        PanelDesktop.Tag = childform
        childform.BringToFront()
        childform.Show()
        lblFormTitle.Text = childform.Text
    End Sub
    Private Sub btnlibros_Click(sender As Object, e As EventArgs) Handles btnlibros.Click
        ActivateButton(sender, RGBColors.color1)
        openchildform(librosform)
        disablePanel()
        currentPanel = Panel_libros
        Activatepanel()
        librosform.DataGridView_libros.DataSource = librosform.MostrarLibros()

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        ActivateButton(sender, RGBColors.color2)
        openchildform(ventaForm)
        disablePanel()
        currentPanel = Panel_ventas
        Activatepanel()
        ventaForm.DataGridView_Venta.DataSource = ventaForm.mostrar_venta()
    End Sub

    Private Sub btnClientes_Click_1(sender As Object, e As EventArgs) Handles btnClientes.Click
        ActivateButton(sender, RGBColors.color4)
        openchildform(clientesForm)
        disablePanel()
        currentPanel = Panel_clientes
        Activatepanel()
        clientesForm.mostrarClientes()
    End Sub

    Private Sub btnMovimientos_Click_1(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        ActivateButton(sender, RGBColors.color5)
        openchildform(movimientosForm)
        disablePanel()
        currentPanel = Panel_movimientos
        Activatepanel()
        movimientosForm.mostrar_Movimientos()
    End Sub

    Private Sub btnUsuarios_Click_1(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        ActivateButton(sender, RGBColors.color6)
        openchildform(usuarios)
        disablePanel()
        currentPanel = Panel_usuarios
        Activatepanel()
    End Sub

    Private Sub btnUL_Click_1(sender As Object, e As EventArgs) Handles btnUL.Click
        ActivateButton(sender, RGBColors.color7)
        openchildform(unidades_logisticas)
        disablePanel()
        'currentPanel = Panel_usuarios
        'Activatepanel()
    End Sub

    Private Sub btnReportes_Click_1(sender As Object, e As EventArgs) Handles btnReportes.Click
        ActivateButton(sender, RGBColors.color8)
        openchildform(nocreated)
    End Sub

    Private Sub btnConfiguracione_Click(sender As Object, e As EventArgs) Handles btnConfiguracione.Click
        ActivateButton(sender, RGBColors.color9)
        openchildform(nocreated)
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        ActivateButton(sender, RGBColors.color10)
        openchildform(nocreated)
    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        reset()
    End Sub
    Private Sub reset()
        disablebutton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"

    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Entrada_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub añadir_libro_Click(sender As Object, e As EventArgs) Handles añadir_libro.Click
        añadire_libro.Show()
        librosform.DataGridView_libros.DataSource = librosform.MostrarLibros()
    End Sub

    Private Sub editar_libro_Click(sender As Object, e As EventArgs) Handles editar_libro.Click
        librosform.editar_libros()
        librosform.DataGridView_libros.DataSource = librosform.MostrarLibros()
    End Sub

    Private Sub eliminar_libro_Click(sender As Object, e As EventArgs) Handles eliminar_libro.Click
        librosform.eliminar_libros()
        librosform.DataGridView_libros.DataSource = librosform.MostrarLibros()
    End Sub

    Private Sub add_img_libro_Click(sender As Object, e As EventArgs) Handles add_img_libro.Click
        librosform.add_imagen()
        librosform.DataGridView_libros.DataSource = librosform.MostrarLibros()
    End Sub

    Private Sub add_venta_Click(sender As Object, e As EventArgs) Handles add_venta.Click
        Dim nueva_venta As New Nueva_Venta()
        nueva_venta.Show()

    End Sub

    Private Sub editar_venta_Click(sender As Object, e As EventArgs) Handles editar_venta.Click
        ventaForm.editar_venta()
    End Sub

    Private Sub add_cliente_Click(sender As Object, e As EventArgs) Handles add_cliente.Click
        Dim añadir_cliente As New añadir_Cliente
        añadir_cliente.Show()
    End Sub

    Private Sub editar_cliente_Click(sender As Object, e As EventArgs) Handles editar_cliente.Click
        clientesForm.Editar()
    End Sub

    Private Sub eliminar_cliente_Click(sender As Object, e As EventArgs) Handles eliminar_cliente.Click
        clientesForm.eliminar_clientes()
    End Sub

    Private Sub eliminar_venta_Click(sender As Object, e As EventArgs) Handles eliminar_venta.Click
        Dim venta As New Venta
        venta.Eliminar__venta()
    End Sub

    Private Sub acualisar_stock_total(idlibro As String)

        Dim serverName As String = Login.ComboBox_Servidor.SelectedItem.ToString()
        Dim con As SqlConnection = miConexion.CrearConexion(serverName)
        'buscar unidades lugisticas tipo=o

        Dim cmd As New SqlCommand("SELECT stock FROM UnidadesLogisticas WHERE idlibro = @idlibro and tipoUL=0", con)
        cmd.Parameters.AddWithValue("@idlibro", idlibro)
        con.Open()
        Dim reader0 As SqlDataReader = cmd.ExecuteReader()
        Dim stock0 As Integer
        If reader0.Read() Then
            stock0 = reader0.GetInt32(0)
        End If
        con.Close()
        'buscar unidades lugisticas tipo=1
        Dim cmnd As New SqlCommand("SELECT stock FROM UnidadesLogisticas WHERE idlibro = @idlibro and tipoUL=1 ", con)
        cmnd.Parameters.AddWithValue("@idlibro", idlibro)
        con.Open()
        Dim reader As SqlDataReader = cmnd.ExecuteReader()
        Dim stock As Integer
        If reader.Read() Then
            stock = reader.GetInt32(0)
        End If
        con.Close()
        'buscar unidades por UL por tipoUL=1
        Dim comnd As New SqlCommand("SELECT unidades_por_UL FROM UnidadesLogisticas WHERE idlibro = @idlibro and tipoUL=1 ", con)
        comnd.Parameters.AddWithValue("@idlibro", idlibro)
        con.Open()
        Dim reader2 As SqlDataReader = comnd.ExecuteReader()
        Dim unidades_por_UL As Integer
        If reader2.Read() Then
            unidades_por_UL = reader2.GetInt32(0)
        End If
        con.Close()
        'acualisar_stock_total
        Dim stock_Total As String = stock * unidades_por_UL + stock0
        Dim comd As New SqlCommand("update libros set stock_Total=@stock_Total WHERE idlibro = @idlibro", con)
        comd.Parameters.AddWithValue("@idlibro", idlibro)
        comd.Parameters.AddWithValue("@stock_Total", stock_Total)
        con.Open()
        comd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class
