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
        Me.btnAyuda = New FontAwesome.Sharp.IconButton()
        Me.btnConfiguracione = New FontAwesome.Sharp.IconButton()
        Me.btnReportes = New FontAwesome.Sharp.IconButton()
        Me.btnUL = New FontAwesome.Sharp.IconButton()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.btnMovimientos = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnVentas = New FontAwesome.Sharp.IconButton()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.PanelMenu.Controls.Add(Me.btnAyuda)
        Me.PanelMenu.Controls.Add(Me.btnConfiguracione)
        Me.PanelMenu.Controls.Add(Me.btnReportes)
        Me.PanelMenu.Controls.Add(Me.btnUL)
        Me.PanelMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelMenu.Controls.Add(Me.btnMovimientos)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnlibros)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 693)
        Me.PanelMenu.TabIndex = 0
        '
        'btnAyuda
        '
        Me.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAyuda.FlatAppearance.BorderSize = 0
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnAyuda.IconColor = System.Drawing.Color.White
        Me.btnAyuda.IconSize = 32
        Me.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.Location = New System.Drawing.Point(0, 614)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnAyuda.Rotation = 0R
        Me.btnAyuda.Size = New System.Drawing.Size(220, 60)
        Me.btnAyuda.TabIndex = 9
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAyuda.UseVisualStyleBackColor = True
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
        Me.btnConfiguracione.Location = New System.Drawing.Point(0, 554)
        Me.btnConfiguracione.Name = "btnConfiguracione"
        Me.btnConfiguracione.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnConfiguracione.Rotation = 0R
        Me.btnConfiguracione.Size = New System.Drawing.Size(220, 60)
        Me.btnConfiguracione.TabIndex = 8
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
        Me.btnReportes.Location = New System.Drawing.Point(0, 494)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnReportes.Rotation = 0R
        Me.btnReportes.Size = New System.Drawing.Size(220, 60)
        Me.btnReportes.TabIndex = 7
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
        Me.btnUL.Location = New System.Drawing.Point(0, 434)
        Me.btnUL.Name = "btnUL"
        Me.btnUL.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUL.Rotation = 0R
        Me.btnUL.Size = New System.Drawing.Size(220, 60)
        Me.btnUL.TabIndex = 6
        Me.btnUL.Text = "Unidades Logísticas"
        Me.btnUL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUL.UseVisualStyleBackColor = True
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
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 374)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUsuarios.Rotation = 0R
        Me.btnUsuarios.Size = New System.Drawing.Size(220, 60)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = True
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
        Me.btnMovimientos.Location = New System.Drawing.Point(0, 314)
        Me.btnMovimientos.Name = "btnMovimientos"
        Me.btnMovimientos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMovimientos.Rotation = 0R
        Me.btnMovimientos.Size = New System.Drawing.Size(220, 60)
        Me.btnMovimientos.TabIndex = 4
        Me.btnMovimientos.Text = "Movimientos"
        Me.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMovimientos.UseVisualStyleBackColor = True
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
        Me.btnClientes.Location = New System.Drawing.Point(0, 254)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnClientes.Rotation = 0R
        Me.btnClientes.Size = New System.Drawing.Size(220, 60)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
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
        Me.btnVentas.Location = New System.Drawing.Point(0, 194)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnVentas.Rotation = 0R
        Me.btnVentas.Size = New System.Drawing.Size(220, 60)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVentas.UseVisualStyleBackColor = True
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
        Me.btnlibros.Location = New System.Drawing.Point(0, 134)
        Me.btnlibros.Name = "btnlibros"
        Me.btnlibros.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnlibros.Rotation = 0R
        Me.btnlibros.Size = New System.Drawing.Size(220, 60)
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
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 134)
        Me.PanelLogo.TabIndex = 0
        '
        'imgHome
        '
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(3, 3)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(211, 124)
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
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(626, 75)
        Me.PanelTitleBar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(509, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 28)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.TabStop = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.Image = CType(resources.GetObject("btnMaximize.Image"), System.Drawing.Image)
        Me.btnMaximize.Location = New System.Drawing.Point(555, 12)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(30, 28)
        Me.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(591, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(32, 28)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFormTitle.Location = New System.Drawing.Point(52, 27)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(49, 17)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home "
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.MidnightBlue
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.University
        Me.IconCurrentForm.IconColor = System.Drawing.Color.LightSteelBlue
        Me.IconCurrentForm.IconSize = 41
        Me.IconCurrentForm.Location = New System.Drawing.Point(3, 12)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(43, 41)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(626, 618)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(224, 266)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 693)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnlibros As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnAyuda As FontAwesome.Sharp.IconButton
    Friend WithEvents btnConfiguracione As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUL As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMovimientos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnMaximize As PictureBox
    Friend WithEvents btnExit As PictureBox
End Class
