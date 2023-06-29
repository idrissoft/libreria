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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriaLTransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView_Venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(501, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 22)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Venta"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.CrearNuevaVentaToolStripMenuItem, Me.HistoriaLTransaccionesToolStripMenuItem, Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(427, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(51, 22)
        Me.LibrosToolStripMenuItem.Text = "Libros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CrearNuevaVentaToolStripMenuItem
        '
        Me.CrearNuevaVentaToolStripMenuItem.Name = "CrearNuevaVentaToolStripMenuItem"
        Me.CrearNuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CrearNuevaVentaToolStripMenuItem.Text = "Crear Nueva Venta"
        '
        'HistoriaLTransaccionesToolStripMenuItem
        '
        Me.HistoriaLTransaccionesToolStripMenuItem.Name = "HistoriaLTransaccionesToolStripMenuItem"
        Me.HistoriaLTransaccionesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HistoriaLTransaccionesToolStripMenuItem.Text = "Historia l Transacciones"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Libros"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(2, 153)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(1098, 82)
        Me.ListBox2.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 32767)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1107, 0)
        Me.Panel4.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 327)
        Me.DataGridView1.TabIndex = 9
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 43)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1100, 95)
        Me.ListBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "informacion de cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nombre Completo:"
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteNombre.Location = New System.Drawing.Point(262, 97)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(260, 23)
        Me.txtClienteNombre.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ID del Cliente:"
        '
        'txtClienteID
        '
        Me.txtClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteID.Location = New System.Drawing.Point(262, 51)
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.Size = New System.Drawing.Size(260, 23)
        Me.txtClienteID.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(542, 21226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 24)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ID del Cliente:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(774, 21226)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(210, 29)
        Me.TextBox2.TabIndex = 27
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(658, 21226)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(210, 29)
        Me.TextBox3.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Descuento)
        Me.Panel2.Controls.Add(Me.txtVentaDescuento)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
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
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1107, 42598)
        Me.Panel2.TabIndex = 5
        '
        'Descuento
        '
        Me.Descuento.AutoSize = True
        Me.Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(863, 174)
        Me.Descuento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(76, 17)
        Me.Descuento.TabIndex = 53
        Me.Descuento.Text = "Descuento"
        '
        'txtVentaDescuento
        '
        Me.txtVentaDescuento.Location = New System.Drawing.Point(866, 196)
        Me.txtVentaDescuento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVentaDescuento.Name = "txtVentaDescuento"
        Me.txtVentaDescuento.Size = New System.Drawing.Size(68, 20)
        Me.txtVentaDescuento.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView_Venta)
        Me.Panel3.Location = New System.Drawing.Point(0, 238)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1101, 273)
        Me.Panel3.TabIndex = 51
        '
        'DataGridView_Venta
        '
        Me.DataGridView_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Venta.Location = New System.Drawing.Point(-3, 2)
        Me.DataGridView_Venta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView_Venta.Name = "DataGridView_Venta"
        Me.DataGridView_Venta.RowHeadersWidth = 62
        Me.DataGridView_Venta.RowTemplate.Height = 28
        Me.DataGridView_Venta.Size = New System.Drawing.Size(1107, 273)
        Me.DataGridView_Venta.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(980, 174)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 17)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Precio Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(717, 174)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 17)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Precio por unidad:"
        '
        'txtVentaSubtotal
        '
        Me.txtVentaSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaSubtotal.Location = New System.Drawing.Point(975, 194)
        Me.txtVentaSubtotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVentaSubtotal.Name = "txtVentaSubtotal"
        Me.txtVentaSubtotal.Size = New System.Drawing.Size(101, 23)
        Me.txtVentaSubtotal.TabIndex = 48
        '
        'txtVentaPrecio
        '
        Me.txtVentaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaPrecio.Location = New System.Drawing.Point(720, 194)
        Me.txtVentaPrecio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVentaPrecio.Name = "txtVentaPrecio"
        Me.txtVentaPrecio.Size = New System.Drawing.Size(101, 23)
        Me.txtVentaPrecio.TabIndex = 47
        '
        'txtVentaCantidad
        '
        Me.txtVentaCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaCantidad.Location = New System.Drawing.Point(520, 194)
        Me.txtVentaCantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVentaCantidad.Name = "txtVentaCantidad"
        Me.txtVentaCantidad.Size = New System.Drawing.Size(177, 23)
        Me.txtVentaCantidad.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(651, 21226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Nombre Completo:"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(656, 21226)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(216, 29)
        Me.TextBox9.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(527, 174)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 17)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "cant:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(103, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 17)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "ID del libro:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(270, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Nombre del libro:"
        '
        'txtLibroNombre
        '
        Me.txtLibroNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibroNombre.Location = New System.Drawing.Point(273, 194)
        Me.txtLibroNombre.Name = "txtLibroNombre"
        Me.txtLibroNombre.Size = New System.Drawing.Size(230, 23)
        Me.txtLibroNombre.TabIndex = 40
        '
        'txtLibroID
        '
        Me.txtLibroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibroID.Location = New System.Drawing.Point(53, 194)
        Me.txtLibroID.Name = "txtLibroID"
        Me.txtLibroID.Size = New System.Drawing.Size(207, 23)
        Me.txtLibroID.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(638, 100)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "direccion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(565, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 17)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Números de Teléfono:"
        '
        'txtClientedireccion
        '
        Me.txtClientedireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientedireccion.Location = New System.Drawing.Point(720, 97)
        Me.txtClientedireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtClientedireccion.Multiline = True
        Me.txtClientedireccion.Name = "txtClientedireccion"
        Me.txtClientedireccion.Size = New System.Drawing.Size(233, 37)
        Me.txtClientedireccion.TabIndex = 34
        '
        'txtClienteTelefono
        '
        Me.txtClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteTelefono.Location = New System.Drawing.Point(720, 51)
        Me.txtClienteTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtClienteTelefono.Multiline = True
        Me.txtClienteTelefono.Name = "txtClienteTelefono"
        Me.txtClienteTelefono.Size = New System.Drawing.Size(233, 27)
        Me.txtClienteTelefono.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(817, 21226)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(210, 29)
        Me.TextBox4.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(499, 21226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 24)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "número de teléfono:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(817, 21226)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(210, 29)
        Me.TextBox6.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(499, 21226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 24)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "dirección:"
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 615)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Venta"
        Me.Text = "Venta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListBox1 As ListBox
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
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtVentaDescuento As TextBox
    Friend WithEvents Descuento As Label
    Friend WithEvents CrearNuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriaLTransaccionesToolStripMenuItem As ToolStripMenuItem
End Class
