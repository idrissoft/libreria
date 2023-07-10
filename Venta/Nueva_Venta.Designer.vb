<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_Venta))
        Me.Descuento = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtVentaPrecio = New System.Windows.Forms.TextBox()
        Me.txtVentaCantidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BtnAddVenta1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.txtprecio_des = New System.Windows.Forms.TextBox()
        Me.Txt_subtota = New System.Windows.Forms.TextBox()
        Me.txtClienteNombre = New System.Windows.Forms.ComboBox()
        Me.txtLibroNombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ficha_de_venta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.editar_venta = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Descuento
        '
        Me.Descuento.AutoSize = True
        Me.Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(168, 769)
        Me.Descuento.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(130, 25)
        Me.Descuento.TabIndex = 76
        Me.Descuento.Text = "Descuento%:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(168, 594)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 25)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Precio de venta:"
        '
        'txtVentaPrecio
        '
        Me.txtVentaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaPrecio.Location = New System.Drawing.Point(663, 599)
        Me.txtVentaPrecio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtVentaPrecio.Name = "txtVentaPrecio"
        Me.txtVentaPrecio.Size = New System.Drawing.Size(235, 30)
        Me.txtVentaPrecio.TabIndex = 71
        '
        'txtVentaCantidad
        '
        Me.txtVentaCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaCantidad.Location = New System.Drawing.Point(663, 487)
        Me.txtVentaCantidad.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtVentaCantidad.Name = "txtVentaCantidad"
        Me.txtVentaCantidad.Size = New System.Drawing.Size(235, 30)
        Me.txtVentaCantidad.TabIndex = 70
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(168, 868)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 25)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Precio_Des:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(168, 977)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 25)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Subtota:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(168, 482)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 25)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 25)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "buscar libro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Buscar cliente"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 52
        Me.ListBox1.Location = New System.Drawing.Point(15, 6)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1798, 1512)
        Me.ListBox1.TabIndex = 54
        '
        'BtnAddVenta1
        '
        Me.BtnAddVenta1.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddVenta1.BackgroundImage = CType(resources.GetObject("BtnAddVenta1.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddVenta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddVenta1.FlatAppearance.BorderSize = 0
        Me.BtnAddVenta1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddVenta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddVenta1.Location = New System.Drawing.Point(36, 1389)
        Me.BtnAddVenta1.Margin = New System.Windows.Forms.Padding(8)
        Me.BtnAddVenta1.Name = "BtnAddVenta1"
        Me.BtnAddVenta1.Size = New System.Drawing.Size(609, 122)
        Me.BtnAddVenta1.TabIndex = 77
        Me.BtnAddVenta1.Text = "crear venta"
        Me.BtnAddVenta1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1209, 1389)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(609, 122)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Location = New System.Drawing.Point(663, 789)
        Me.TxtDescuento.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(235, 57)
        Me.TxtDescuento.TabIndex = 79
        '
        'txtprecio_des
        '
        Me.txtprecio_des.Location = New System.Drawing.Point(663, 873)
        Me.txtprecio_des.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtprecio_des.Name = "txtprecio_des"
        Me.txtprecio_des.ReadOnly = True
        Me.txtprecio_des.Size = New System.Drawing.Size(235, 57)
        Me.txtprecio_des.TabIndex = 80
        '
        'Txt_subtota
        '
        Me.Txt_subtota.Location = New System.Drawing.Point(663, 982)
        Me.Txt_subtota.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Txt_subtota.Name = "Txt_subtota"
        Me.Txt_subtota.ReadOnly = True
        Me.Txt_subtota.Size = New System.Drawing.Size(235, 57)
        Me.Txt_subtota.TabIndex = 81
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.FormattingEnabled = True
        Me.txtClienteNombre.Location = New System.Drawing.Point(663, 145)
        Me.txtClienteNombre.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(772, 60)
        Me.txtClienteNombre.TabIndex = 82
        '
        'txtLibroNombre
        '
        Me.txtLibroNombre.FormattingEnabled = True
        Me.txtLibroNombre.Location = New System.Drawing.Point(663, 236)
        Me.txtLibroNombre.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtLibroNombre.Name = "txtLibroNombre"
        Me.txtLibroNombre.Size = New System.Drawing.Size(772, 60)
        Me.txtLibroNombre.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 683)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "ficha de venta:"
        '
        'ficha_de_venta
        '
        Me.ficha_de_venta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ficha_de_venta.Location = New System.Drawing.Point(663, 701)
        Me.ficha_de_venta.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ficha_de_venta.Name = "ficha_de_venta"
        Me.ficha_de_venta.Size = New System.Drawing.Size(397, 57)
        Me.ficha_de_venta.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 353)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 25)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "UL:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(663, 358)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(772, 60)
        Me.ComboBox1.TabIndex = 89
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(62, 1074)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(8)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(1754, 287)
        Me.DataGridView1.TabIndex = 90
        '
        'editar_venta
        '
        Me.editar_venta.BackColor = System.Drawing.Color.Transparent
        Me.editar_venta.BackgroundImage = CType(resources.GetObject("editar_venta.BackgroundImage"), System.Drawing.Image)
        Me.editar_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editar_venta.FlatAppearance.BorderSize = 0
        Me.editar_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editar_venta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editar_venta.Location = New System.Drawing.Point(663, 1389)
        Me.editar_venta.Margin = New System.Windows.Forms.Padding(8)
        Me.editar_venta.Name = "editar_venta"
        Me.editar_venta.Size = New System.Drawing.Size(576, 122)
        Me.editar_venta.TabIndex = 91
        Me.editar_venta.Text = "editar venta"
        Me.editar_venta.UseVisualStyleBackColor = False
        '
        'Nueva_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(27.0!, 52.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1923, 1061)
        Me.Controls.Add(Me.editar_venta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ficha_de_venta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLibroNombre)
        Me.Controls.Add(Me.txtClienteNombre)
        Me.Controls.Add(Me.Txt_subtota)
        Me.Controls.Add(Me.txtprecio_des)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAddVenta1)
        Me.Controls.Add(Me.Descuento)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtVentaPrecio)
        Me.Controls.Add(Me.txtVentaCantidad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Nueva_Venta"
        Me.Text = "Nueva_Venta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Descuento As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtVentaPrecio As TextBox
    Friend WithEvents txtVentaCantidad As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BtnAddVenta1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents txtprecio_des As TextBox
    Friend WithEvents Txt_subtota As TextBox
    Friend WithEvents txtClienteNombre As ComboBox
    Friend WithEvents txtLibroNombre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ficha_de_venta As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents editar_venta As Button
End Class
