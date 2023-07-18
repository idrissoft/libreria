Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Entrada
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentchildform As Form

    ' Nuevas variables de instancia para formularios
    Private movimientosForm As Movimientos
    Private clientesForm As Clientes
    Private ventaForm As Venta
    Private unidades_logisticasform As unidades_logisticas
    Private librosform As New Libros

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

    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        ActivateButton(sender, RGBColors.color2)
        openchildform(ventaForm)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        ActivateButton(sender, RGBColors.color4)
        openchildform(clientesForm)
    End Sub

    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        ActivateButton(sender, RGBColors.color5)
        openchildform(movimientosForm) ' Muestra la instancia de Movimientos
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        ActivateButton(sender, RGBColors.color6)
        openchildform(nocreated)
    End Sub

    Private Sub btnUL_Click(sender As Object, e As EventArgs) Handles btnUL.Click
        ActivateButton(sender, RGBColors.color7)
        openchildform(unidades_logisticas)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        ActivateButton(sender, RGBColors.color8)
        openchildform(nocreated)
    End Sub

    Private Sub btnConfiguraciones_Click(sender As Object, e As EventArgs) Handles btnConfiguracione.Click
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
        lblFormTitle.Text = "home"

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


End Class
