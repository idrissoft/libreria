<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CrearNuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClienteNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClienteID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Descuento = New System.Windows.Forms.Label()
        Me.txtVentaDescuento = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Eliminar_venta = New System.Windows.Forms.Button()
        Me.Btn_editar_venta = New System.Windows.Forms.Button()
        Me.DataGridView_Venta = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtVentaSubtotal = New System.Windows.Forms.TextBox()
        Me.txtVentaPrecio = New System.Windows.Forms.TextBox()
        Me.txtVentaCantidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLibroNombre = New System.Windows.Forms.TextBox()
        Me.txtLibroID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtClientedireccion = New System.Windows.Forms.TextBox()
        Me.txtClienteTelefono = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView_Venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevaVentaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 4)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(152, 26)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CrearNuevaVentaToolStripMenuItem
        '
        Me.CrearNuevaVentaToolStripMenuItem.Name = "CrearNuevaVentaToolStripMenuItem"
        Me.CrearNuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.CrearNuevaVentaToolStripMenuItem.Text = "Crear Nueva Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Libros"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(3, 188)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(1463, 100)
        Me.ListBox2.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 32767)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1476, 0)
        Me.Panel4.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1421, 402)
        Me.DataGridView1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "informacion de cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre Completo:"
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteNombre.Location = New System.Drawing.Point(349, 119)
        Me.txtClienteNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(345, 26)
        Me.txtClienteNombre.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ID del Cliente:"
        '
        'txtClienteID
        '
        Me.txtClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteID.Location = New System.Drawing.Point(349, 63)
        Me.txtClienteID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.Size = New System.Drawing.Size(345, 26)
        Me.txtClienteID.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(723, 26124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 29)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ID del Cliente:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1032, 26124)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(279, 34)
        Me.TextBox2.TabIndex = 27
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(877, 26124)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(279, 34)
        Me.TextBox3.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Descuento)
        Me.Panel2.Controls.Add(Me.txtVentaDescuento)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtVentaSubtotal)
        Me.Panel2.Controls.Add(Me.txtVentaPrecio)
        Me.Panel2.Controls.Add(Me.txtVentaCantidad)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtLibroNombre)
        Me.Panel2.Controls.Add(Me.txtLibroID)
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtClientedireccion)
        Me.Panel2.Controls.Add(Me.txtClienteTelefono)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtClienteID)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtClienteNombre)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1476, 52428)
        Me.Panel2.TabIndex = 5
        '
        'Descuento
        '
        Me.Descuento.AutoSize = True
        Me.Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(1151, 214)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(90, 20)
        Me.Descuento.TabIndex = 53
        Me.Descuento.Text = "Descuento"
        '
        'txtVentaDescuento
        '
        Me.txtVentaDescuento.Location = New System.Drawing.Point(1155, 241)
        Me.txtVentaDescuento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVentaDescuento.Name = "txtVentaDescuento"
        Me.txtVentaDescuento.Size = New System.Drawing.Size(89, 22)
        Me.txtVentaDescuento.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Eliminar_venta)
        Me.Panel3.Controls.Add(Me.Btn_editar_venta)
        Me.Panel3.Controls.Add(Me.DataGridView_Venta)
        Me.Panel3.Location = New System.Drawing.Point(0, 294)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1468, 452)
        Me.Panel3.TabIndex = 51
        '
        'Eliminar_venta
        '
        Me.Eliminar_venta.BackColor = System.Drawing.Color.Transparent
        Me.Eliminar_venta.BackgroundImage = CType(resources.GetObject("Eliminar_venta.BackgroundImage"), System.Drawing.Image)
        Me.Eliminar_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_venta.FlatAppearance.BorderSize = 0
        Me.Eliminar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar_venta.Location = New System.Drawing.Point(319, 404)
        Me.Eliminar_venta.Margin = New System.Windows.Forms.Padding(4)
        Me.Eliminar_venta.Name = "Eliminar_venta"
        Me.Eliminar_venta.Size = New System.Drawing.Size(196, 43)
        Me.Eliminar_venta.TabIndex = 6
        Me.Eliminar_venta.Text = "Eliminar"
        Me.Eliminar_venta.UseVisualStyleBackColor = False
        '
        'Btn_editar_venta
        '
        Me.Btn_editar_venta.BackColor = System.Drawing.Color.Transparent
        Me.Btn_editar_venta.BackgroundImage = CType(resources.GetObject("Btn_editar_venta.BackgroundImage"), System.Drawing.Image)
        Me.Btn_editar_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_editar_venta.FlatAppearance.BorderSize = 0
        Me.Btn_editar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_editar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_editar_venta.Location = New System.Drawing.Point(29, 404)
        Me.Btn_editar_venta.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_editar_venta.Name = "Btn_editar_venta"
        Me.Btn_editar_venta.Size = New System.Drawing.Size(196, 43)
        Me.Btn_editar_venta.TabIndex = 5
        Me.Btn_editar_venta.Text = "Editar "
        Me.Btn_editar_venta.UseVisualStyleBackColor = False
        '
        'DataGridView_Venta
        '
        Me.DataGridView_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Venta.Location = New System.Drawing.Point(3, 2)
        Me.DataGridView_Venta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView_Venta.Name = "DataGridView_Venta"
        Me.DataGridView_Venta.RowHeadersWidth = 62
        Me.DataGridView_Venta.RowTemplate.Height = 28
        Me.DataGridView_Venta.Size = New System.Drawing.Size(1476, 395)
        Me.DataGridView_Venta.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1307, 214)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Precio Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(956, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 20)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Precio por unidad:"
        '
        'txtVentaSubtotal
        '
        Me.txtVentaSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaSubtotal.Location = New System.Drawing.Point(1300, 239)
        Me.txtVentaSubtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVentaSubtotal.Name = "txtVentaSubtotal"
        Me.txtVentaSubtotal.Size = New System.Drawing.Size(133, 26)
        Me.txtVentaSubtotal.TabIndex = 48
        '
        'txtVentaPrecio
        '
        Me.txtVentaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaPrecio.Location = New System.Drawing.Point(960, 239)
        Me.txtVentaPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVentaPrecio.Name = "txtVentaPrecio"
        Me.txtVentaPrecio.Size = New System.Drawing.Size(133, 26)
        Me.txtVentaPrecio.TabIndex = 47
        '
        'txtVentaCantidad
        '
        Me.txtVentaCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaCantidad.Location = New System.Drawing.Point(693, 239)
        Me.txtVentaCantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtVentaCantidad.Name = "txtVentaCantidad"
        Me.txtVentaCantidad.Size = New System.Drawing.Size(235, 26)
        Me.txtVentaCantidad.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(868, 26124)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 20)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Nombre Completo:"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(875, 26124)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(287, 34)
        Me.TextBox9.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(703, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 20)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "cant:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(137, 214)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 20)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "ID del libro:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(360, 214)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 20)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Nombre del libro:"
        '
        'txtLibroNombre
        '
        Me.txtLibroNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibroNombre.Location = New System.Drawing.Point(364, 239)
        Me.txtLibroNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLibroNombre.Name = "txtLibroNombre"
        Me.txtLibroNombre.Size = New System.Drawing.Size(305, 26)
        Me.txtLibroNombre.TabIndex = 40
        '
        'txtLibroID
        '
        Me.txtLibroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibroID.Location = New System.Drawing.Point(71, 239)
        Me.txtLibroID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLibroID.Name = "txtLibroID"
        Me.txtLibroID.Size = New System.Drawing.Size(275, 26)
        Me.txtLibroID.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(851, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 20)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "direccion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(753, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Números de Teléfono:"
        '
        'txtClientedireccion
        '
        Me.txtClientedireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientedireccion.Location = New System.Drawing.Point(960, 119)
        Me.txtClientedireccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClientedireccion.Multiline = True
        Me.txtClientedireccion.Name = "txtClientedireccion"
        Me.txtClientedireccion.Size = New System.Drawing.Size(309, 45)
        Me.txtClientedireccion.TabIndex = 34
        '
        'txtClienteTelefono
        '
        Me.txtClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteTelefono.Location = New System.Drawing.Point(960, 63)
        Me.txtClienteTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtClienteTelefono.Multiline = True
        Me.txtClienteTelefono.Name = "txtClienteTelefono"
        Me.txtClienteTelefono.Size = New System.Drawing.Size(309, 32)
        Me.txtClienteTelefono.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(1089, 26124)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(279, 34)
        Me.TextBox4.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(665, 26124)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 29)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "número de teléfono:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1089, 26124)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(279, 34)
        Me.TextBox6.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(665, 26124)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 29)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "dirección:"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 919)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView_Venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClienteNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtClienteID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtClientedireccion As TextBox
    Friend WithEvents txtClienteTelefono As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLibroNombre As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLibroID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtVentaSubtotal As TextBox
    Friend WithEvents txtVentaPrecio As TextBox
    Friend WithEvents txtVentaCantidad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView_Venta As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents txtVentaDescuento As TextBox
    Friend WithEvents Descuento As Label
    Friend WithEvents CrearNuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_editar_venta As Button
    Friend WithEvents Eliminar_venta As Button
End Class
