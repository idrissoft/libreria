<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entrada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnConfiguracione = New FontAwesome.Sharp.IconButton()
        Me.btnReportes = New FontAwesome.Sharp.IconButton()
        Me.btnUL = New FontAwesome.Sharp.IconButton()
        Me.Panel_usuarios = New System.Windows.Forms.Panel()
        Me.eliminar_usuario = New System.Windows.Forms.Button()
        Me.editar_usuario = New System.Windows.Forms.Button()
        Me.add_usuario = New System.Windows.Forms.Button()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.Panel_movimientos = New System.Windows.Forms.Panel()
        Me.btnMovimientos = New FontAwesome.Sharp.IconButton()
        Me.Panel_clientes = New System.Windows.Forms.Panel()
        Me.eliminar_cliente = New System.Windows.Forms.Button()
        Me.editar_cliente = New System.Windows.Forms.Button()
        Me.add_cliente = New System.Windows.Forms.Button()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnAyuda = New FontAwesome.Sharp.IconButton()
        Me.Panel_ventas = New System.Windows.Forms.Panel()
        Me.eliminar_venta = New System.Windows.Forms.Button()
        Me.editar_venta = New System.Windows.Forms.Button()
        Me.add_venta = New System.Windows.Forms.Button()
        Me.btnVentas = New FontAwesome.Sharp.IconButton()
        Me.Panel_libros = New System.Windows.Forms.Panel()
        Me.add_img_libro = New System.Windows.Forms.Button()
        Me.eliminar_libro = New System.Windows.Forms.Button()
        Me.editar_libro = New System.Windows.Forms.Button()
        Me.añadir_libro = New System.Windows.Forms.Button()
        Me.btnlibros = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.Panel_usuarios.SuspendLayout()
        Me.Panel_clientes.SuspendLayout()
        Me.Panel_ventas.SuspendLayout()
        Me.Panel_libros.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelMenu.Controls.Add(Me.btnConfiguracione)
        Me.PanelMenu.Controls.Add(Me.btnReportes)
        Me.PanelMenu.Controls.Add(Me.btnUL)
        Me.PanelMenu.Controls.Add(Me.Panel_usuarios)
        Me.PanelMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelMenu.Controls.Add(Me.Panel_movimientos)
        Me.PanelMenu.Controls.Add(Me.btnMovimientos)
        Me.PanelMenu.Controls.Add(Me.Panel_clientes)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.btnAyuda)
        Me.PanelMenu.Controls.Add(Me.Panel_ventas)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.Panel_libros)
        Me.PanelMenu.Controls.Add(Me.btnlibros)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(293, 1428)
        Me.PanelMenu.TabIndex = 0
        '
        'btnConfiguracione
        '
        Me.btnConfiguracione.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConfiguracione.FlatAppearance.BorderSize = 0
        Me.btnConfiguracione.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracione.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnConfiguracione.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracione.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnConfiguracione.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.btnConfiguracione.IconColor = System.Drawing.Color.White
        Me.btnConfiguracione.IconSize = 32
        Me.btnConfiguracione.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguracione.Location = New System.Drawing.Point(0, 1278)
        Me.btnConfiguracione.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfiguracione.Name = "btnConfiguracione"
        Me.btnConfiguracione.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnConfiguracione.Rotation = 0R
        Me.btnConfiguracione.Size = New System.Drawing.Size(293, 74)
        Me.btnConfiguracione.TabIndex = 17
        Me.btnConfiguracione.Text = "Configuraciones"
        Me.btnConfiguracione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguracione.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfiguracione.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnReportes.IconChar = FontAwesome.Sharp.IconChar.Copy
        Me.btnReportes.IconColor = System.Drawing.Color.White
        Me.btnReportes.IconSize = 32
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 1204)
        Me.btnReportes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnReportes.Rotation = 0R
        Me.btnReportes.Size = New System.Drawing.Size(293, 74)
        Me.btnReportes.TabIndex = 17
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnUL
        '
        Me.btnUL.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUL.FlatAppearance.BorderSize = 0
        Me.btnUL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUL.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUL.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUL.IconChar = FontAwesome.Sharp.IconChar.Underline
        Me.btnUL.IconColor = System.Drawing.Color.White
        Me.btnUL.IconSize = 32
        Me.btnUL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUL.Location = New System.Drawing.Point(0, 1130)
        Me.btnUL.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUL.Name = "btnUL"
        Me.btnUL.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnUL.Rotation = 0R
        Me.btnUL.Size = New System.Drawing.Size(293, 74)
        Me.btnUL.TabIndex = 17
        Me.btnUL.Text = "Unidades Logísticas"
        Me.btnUL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUL.UseVisualStyleBackColor = True
        '
        'Panel_usuarios
        '
        Me.Panel_usuarios.Controls.Add(Me.eliminar_usuario)
        Me.Panel_usuarios.Controls.Add(Me.editar_usuario)
        Me.Panel_usuarios.Controls.Add(Me.add_usuario)
        Me.Panel_usuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_usuarios.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel_usuarios.Location = New System.Drawing.Point(0, 988)
        Me.Panel_usuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_usuarios.Name = "Panel_usuarios"
        Me.Panel_usuarios.Size = New System.Drawing.Size(293, 142)
        Me.Panel_usuarios.TabIndex = 17
        Me.Panel_usuarios.Visible = False
        '
        'eliminar_usuario
        '
        Me.eliminar_usuario.BackColor = System.Drawing.Color.Navy
        Me.eliminar_usuario.FlatAppearance.BorderSize = 0
        Me.eliminar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar_usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.eliminar_usuario.Location = New System.Drawing.Point(81, 90)
        Me.eliminar_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.eliminar_usuario.Name = "eliminar_usuario"
        Me.eliminar_usuario.Size = New System.Drawing.Size(205, 33)
        Me.eliminar_usuario.TabIndex = 9
        Me.eliminar_usuario.Text = "Eliminar Usuario"
        Me.eliminar_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar_usuario.UseVisualStyleBackColor = False
        '
        'editar_usuario
        '
        Me.editar_usuario.BackColor = System.Drawing.Color.Navy
        Me.editar_usuario.FlatAppearance.BorderSize = 0
        Me.editar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editar_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editar_usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.editar_usuario.Location = New System.Drawing.Point(81, 49)
        Me.editar_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.editar_usuario.Name = "editar_usuario"
        Me.editar_usuario.Size = New System.Drawing.Size(208, 33)
        Me.editar_usuario.TabIndex = 1
        Me.editar_usuario.Text = "Editar Usuario"
        Me.editar_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editar_usuario.UseVisualStyleBackColor = False
        '
        'add_usuario
        '
        Me.add_usuario.BackColor = System.Drawing.Color.Navy
        Me.add_usuario.FlatAppearance.BorderSize = 0
        Me.add_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_usuario.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.add_usuario.Location = New System.Drawing.Point(81, 4)
        Me.add_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.add_usuario.Name = "add_usuario"
        Me.add_usuario.Size = New System.Drawing.Size(208, 38)
        Me.add_usuario.TabIndex = 0
        Me.add_usuario.Text = "crear Nuevo Usuario"
        Me.add_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add_usuario.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnUsuarios.IconColor = System.Drawing.Color.White
        Me.btnUsuarios.IconSize = 32
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 914)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnUsuarios.Rotation = 0R
        Me.btnUsuarios.Size = New System.Drawing.Size(293, 74)
        Me.btnUsuarios.TabIndex = 16
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'Panel_movimientos
        '
        Me.Panel_movimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_movimientos.Location = New System.Drawing.Point(0, 900)
        Me.Panel_movimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_movimientos.Name = "Panel_movimientos"
        Me.Panel_movimientos.Size = New System.Drawing.Size(293, 14)
        Me.Panel_movimientos.TabIndex = 16
        Me.Panel_movimientos.Visible = False
        '
        'btnMovimientos
        '
        Me.btnMovimientos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMovimientos.FlatAppearance.BorderSize = 0
        Me.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMovimientos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovimientos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMovimientos.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnMovimientos.IconColor = System.Drawing.Color.White
        Me.btnMovimientos.IconSize = 32
        Me.btnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovimientos.Location = New System.Drawing.Point(0, 826)
        Me.btnMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnMovimientos.Rotation = 0R
        Me.btnMovimientos.Size = New System.Drawing.Size(293, 74)
        Me.btnMovimientos.TabIndex = 18
        Me.btnMovimientos.Text = "Movimientos"
        Me.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMovimientos.UseVisualStyleBackColor = True
        '
        'Panel_clientes
        '
        Me.Panel_clientes.Controls.Add(Me.eliminar_cliente)
        Me.Panel_clientes.Controls.Add(Me.editar_cliente)
        Me.Panel_clientes.Controls.Add(Me.add_cliente)
        Me.Panel_clientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_clientes.Location = New System.Drawing.Point(0, 687)
        Me.Panel_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_clientes.Name = "Panel_clientes"
        Me.Panel_clientes.Size = New System.Drawing.Size(293, 139)
        Me.Panel_clientes.TabIndex = 15
        Me.Panel_clientes.Visible = False
        '
        'eliminar_cliente
        '
        Me.eliminar_cliente.BackColor = System.Drawing.Color.Navy
        Me.eliminar_cliente.FlatAppearance.BorderSize = 0
        Me.eliminar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar_cliente.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.eliminar_cliente.Location = New System.Drawing.Point(81, 95)
        Me.eliminar_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.eliminar_cliente.Name = "eliminar_cliente"
        Me.eliminar_cliente.Size = New System.Drawing.Size(205, 33)
        Me.eliminar_cliente.TabIndex = 6
        Me.eliminar_cliente.Text = "Eliminar Cliente"
        Me.eliminar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar_cliente.UseVisualStyleBackColor = False
        '
        'editar_cliente
        '
        Me.editar_cliente.BackColor = System.Drawing.Color.Navy
        Me.editar_cliente.FlatAppearance.BorderSize = 0
        Me.editar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editar_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editar_cliente.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.editar_cliente.Location = New System.Drawing.Point(81, 54)
        Me.editar_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.editar_cliente.Name = "editar_cliente"
        Me.editar_cliente.Size = New System.Drawing.Size(208, 33)
        Me.editar_cliente.TabIndex = 5
        Me.editar_cliente.Text = "Editar Cliente"
        Me.editar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editar_cliente.UseVisualStyleBackColor = False
        '
        'add_cliente
        '
        Me.add_cliente.BackColor = System.Drawing.Color.Navy
        Me.add_cliente.FlatAppearance.BorderSize = 0
        Me.add_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_cliente.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.add_cliente.Location = New System.Drawing.Point(81, 9)
        Me.add_cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.add_cliente.Name = "add_cliente"
        Me.add_cliente.Size = New System.Drawing.Size(208, 38)
        Me.add_cliente.TabIndex = 4
        Me.add_cliente.Text = "Nuevo cliente"
        Me.add_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add_cliente.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Handshake
        Me.btnClientes.IconColor = System.Drawing.Color.White
        Me.btnClientes.IconSize = 32
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 621)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnClientes.Rotation = 0R
        Me.btnClientes.Size = New System.Drawing.Size(293, 66)
        Me.btnClientes.TabIndex = 12
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnAyuda
        '
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnAyuda.IconColor = System.Drawing.Color.White
        Me.btnAyuda.IconSize = 32
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.Location = New System.Drawing.Point(0, 1367)
        Me.btnAyuda.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnAyuda.Rotation = 0R
        Me.btnAyuda.Size = New System.Drawing.Size(293, 74)
        Me.btnAyuda.TabIndex = 17
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'Panel_ventas
        '
        Me.Panel_ventas.Controls.Add(Me.eliminar_venta)
        Me.Panel_ventas.Controls.Add(Me.editar_venta)
        Me.Panel_ventas.Controls.Add(Me.add_venta)
        Me.Panel_ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ventas.Location = New System.Drawing.Point(0, 487)
        Me.Panel_ventas.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_ventas.Name = "Panel_ventas"
        Me.Panel_ventas.Size = New System.Drawing.Size(293, 134)
        Me.Panel_ventas.TabIndex = 11
        Me.Panel_ventas.Visible = False
        '
        'eliminar_venta
        '
        Me.eliminar_venta.BackColor = System.Drawing.Color.Navy
        Me.eliminar_venta.FlatAppearance.BorderSize = 0
        Me.eliminar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar_venta.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.eliminar_venta.Location = New System.Drawing.Point(81, 90)
        Me.eliminar_venta.Margin = New System.Windows.Forms.Padding(4)
        Me.eliminar_venta.Name = "eliminar_venta"
        Me.eliminar_venta.Size = New System.Drawing.Size(205, 33)
        Me.eliminar_venta.TabIndex = 3
        Me.eliminar_venta.Text = "Eliminar venta"
        Me.eliminar_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar_venta.UseVisualStyleBackColor = False
        '
        'editar_venta
        '
        Me.editar_venta.BackColor = System.Drawing.Color.Navy
        Me.editar_venta.FlatAppearance.BorderSize = 0
        Me.editar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editar_venta.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.editar_venta.Location = New System.Drawing.Point(81, 49)
        Me.editar_venta.Margin = New System.Windows.Forms.Padding(4)
        Me.editar_venta.Name = "editar_venta"
        Me.editar_venta.Size = New System.Drawing.Size(208, 33)
        Me.editar_venta.TabIndex = 1
        Me.editar_venta.Text = "Editar venta"
        Me.editar_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editar_venta.UseVisualStyleBackColor = False
        '
        'add_venta
        '
        Me.add_venta.BackColor = System.Drawing.Color.Navy
        Me.add_venta.FlatAppearance.BorderSize = 0
        Me.add_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_venta.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.add_venta.Location = New System.Drawing.Point(81, 4)
        Me.add_venta.Margin = New System.Windows.Forms.Padding(4)
        Me.add_venta.Name = "add_venta"
        Me.add_venta.Size = New System.Drawing.Size(208, 38)
        Me.add_venta.TabIndex = 0
        Me.add_venta.Text = "Nueva venta"
        Me.add_venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add_venta.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnVentas.IconChar = FontAwesome.Sharp.IconChar.EuroSign
        Me.btnVentas.IconColor = System.Drawing.Color.White
        Me.btnVentas.IconSize = 32
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 413)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnVentas.Rotation = 0R
        Me.btnVentas.Size = New System.Drawing.Size(293, 74)
        Me.btnVentas.TabIndex = 10
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'Panel_libros
        '
        Me.Panel_libros.Controls.Add(Me.add_img_libro)
        Me.Panel_libros.Controls.Add(Me.eliminar_libro)
        Me.Panel_libros.Controls.Add(Me.editar_libro)
        Me.Panel_libros.Controls.Add(Me.añadir_libro)
        Me.Panel_libros.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_libros.Location = New System.Drawing.Point(0, 239)
        Me.Panel_libros.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel_libros.Name = "Panel_libros"
        Me.Panel_libros.Size = New System.Drawing.Size(293, 174)
        Me.Panel_libros.TabIndex = 2
        Me.Panel_libros.Visible = False
        '
        'add_img_libro
        '
        Me.add_img_libro.BackColor = System.Drawing.Color.Navy
        Me.add_img_libro.FlatAppearance.BorderSize = 0
        Me.add_img_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_img_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_img_libro.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.add_img_libro.Location = New System.Drawing.Point(81, 130)
        Me.add_img_libro.Margin = New System.Windows.Forms.Padding(4)
        Me.add_img_libro.Name = "add_img_libro"
        Me.add_img_libro.Size = New System.Drawing.Size(208, 33)
        Me.add_img_libro.TabIndex = 3
        Me.add_img_libro.Text = "Agregar image"
        Me.add_img_libro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add_img_libro.UseVisualStyleBackColor = False
        '
        'eliminar_libro
        '
        Me.eliminar_libro.BackColor = System.Drawing.Color.Navy
        Me.eliminar_libro.FlatAppearance.BorderSize = 0
        Me.eliminar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar_libro.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.eliminar_libro.Location = New System.Drawing.Point(81, 90)
        Me.eliminar_libro.Margin = New System.Windows.Forms.Padding(4)
        Me.eliminar_libro.Name = "eliminar_libro"
        Me.eliminar_libro.Size = New System.Drawing.Size(208, 33)
        Me.eliminar_libro.TabIndex = 2
        Me.eliminar_libro.Text = "Eliminar"
        Me.eliminar_libro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.eliminar_libro.UseVisualStyleBackColor = False
        '
        'editar_libro
        '
        Me.editar_libro.BackColor = System.Drawing.Color.Navy
        Me.editar_libro.FlatAppearance.BorderSize = 0
        Me.editar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editar_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editar_libro.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.editar_libro.Location = New System.Drawing.Point(79, 49)
        Me.editar_libro.Margin = New System.Windows.Forms.Padding(4)
        Me.editar_libro.Name = "editar_libro"
        Me.editar_libro.Size = New System.Drawing.Size(208, 33)
        Me.editar_libro.TabIndex = 1
        Me.editar_libro.Text = "Editar libro"
        Me.editar_libro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editar_libro.UseVisualStyleBackColor = False
        '
        'añadir_libro
        '
        Me.añadir_libro.BackColor = System.Drawing.Color.Navy
        Me.añadir_libro.FlatAppearance.BorderSize = 0
        Me.añadir_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.añadir_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.añadir_libro.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.añadir_libro.Location = New System.Drawing.Point(81, 4)
        Me.añadir_libro.Margin = New System.Windows.Forms.Padding(4)
        Me.añadir_libro.Name = "añadir_libro"
        Me.añadir_libro.Size = New System.Drawing.Size(208, 38)
        Me.añadir_libro.TabIndex = 0
        Me.añadir_libro.Text = "Añadir"
        Me.añadir_libro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.añadir_libro.UseVisualStyleBackColor = False
        '
        'btnlibros
        '
        Me.btnlibros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlibros.FlatAppearance.BorderSize = 0
        Me.btnlibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlibros.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnlibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlibros.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnlibros.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnlibros.IconColor = System.Drawing.Color.White
        Me.btnlibros.IconSize = 32
        Me.btnlibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlibros.Location = New System.Drawing.Point(0, 149)
        Me.btnlibros.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlibros.Name = "btnlibros"
        Me.btnlibros.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.btnlibros.Rotation = 0R
        Me.btnlibros.Size = New System.Drawing.Size(293, 90)
        Me.btnlibros.TabIndex = 1
        Me.btnlibros.Text = "Libros"
        Me.btnlibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlibros.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(293, 149)
        Me.PanelLogo.TabIndex = 0
        '
        'imgHome
        '
        Me.imgHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(0, 0)
        Me.imgHome.Margin = New System.Windows.Forms.Padding(4)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(293, 153)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(293, 0)
        Me.PanelTitleBar.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1520, 92)
        Me.PanelTitleBar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1295, 15)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(53, 34)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.Image = CType(resources.GetObject("btnMaximize.Image"), System.Drawing.Image)
        Me.btnMaximize.Location = New System.Drawing.Point(1356, 15)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(40, 34)
        Me.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1404, 15)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 34)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFormTitle.Location = New System.Drawing.Point(69, 33)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(59, 20)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home "
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.MidnightBlue
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.University
        Me.IconCurrentForm.IconColor = System.Drawing.Color.LightSteelBlue
        Me.IconCurrentForm.IconSize = 50
        Me.IconCurrentForm.Location = New System.Drawing.Point(4, 15)
        Me.IconCurrentForm.Margin = New System.Windows.Forms.Padding(4)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(57, 50)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelDesktop.Controls.Add(Me.Panel9)
        Me.PanelDesktop.Controls.Add(Me.Panel8)
        Me.PanelDesktop.Controls.Add(Me.Panel6)
        Me.PanelDesktop.Controls.Add(Me.Panel4)
        Me.PanelDesktop.Controls.Add(Me.Panel1)
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(293, 92)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1520, 1336)
        Me.PanelDesktop.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Controls.Add(Me.PictureBox6)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(1281, 54)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(239, 297)
        Me.Panel9.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(103, 267)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "55"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(41, 124)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(157, 127)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(239, 92)
        Me.Panel10.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(76, 42)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 25)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Usuarios"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.PictureBox5)
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Location = New System.Drawing.Point(1003, 54)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(239, 297)
        Me.Panel8.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(103, 267)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "366"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(41, 124)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(157, 127)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(239, 92)
        Me.Panel7.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(76, 42)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Productos"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Location = New System.Drawing.Point(693, 54)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(239, 297)
        Me.Panel6.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(103, 267)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "23"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(41, 124)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(157, 127)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(239, 92)
        Me.Panel5.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(55, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Proveedores"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Location = New System.Drawing.Point(377, 54)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(239, 297)
        Me.Panel4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(103, 267)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "82"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(41, 124)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(157, 127)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(239, 92)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(76, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Empleados"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(60, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 297)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(103, 267)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "721"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(41, 124)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(157, 127)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 92)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(76, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(520, 494)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1813, 1428)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel_usuarios.ResumeLayout(False)
        Me.Panel_clientes.ResumeLayout(False)
        Me.Panel_ventas.ResumeLayout(False)
        Me.Panel_libros.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnlibros As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnMaximize As PictureBox
    Friend WithEvents btnExit As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAyuda As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_libros As Panel
    Friend WithEvents Panel_ventas As Panel
    Friend WithEvents editar_venta As Button
    Friend WithEvents add_venta As Button
    Friend WithEvents Panel_usuarios As Panel
    Friend WithEvents editar_usuario As Button
    Friend WithEvents add_usuario As Button
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_movimientos As Panel
    Friend WithEvents btnMovimientos As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_clientes As Panel
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnConfiguracione As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUL As FontAwesome.Sharp.IconButton
    Friend WithEvents editar_libro As Button
    Friend WithEvents añadir_libro As Button
    Friend WithEvents eliminar_libro As Button
    Friend WithEvents add_img_libro As Button
    Friend WithEvents eliminar_cliente As Button
    Friend WithEvents editar_cliente As Button
    Friend WithEvents add_cliente As Button
    Friend WithEvents eliminar_venta As Button
    Friend WithEvents eliminar_usuario As Button
End Class
