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
        Me.Btn_guardar_cliente1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.txtprecio_des = New System.Windows.Forms.TextBox()
        Me.Txt_subtota = New System.Windows.Forms.TextBox()
        Me.txtClienteNombre = New System.Windows.Forms.ComboBox()
        Me.txtLibroNombre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ficha_de_venta = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Descuento
        '
        Me.Descuento.AutoSize = True
        Me.Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descuento.Location = New System.Drawing.Point(84, 373)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(92, 17)
        Me.Descuento.TabIndex = 76
        Me.Descuento.Text = "Descuento%:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(84, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 17)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Precio de venta:"
        '
        'txtVentaPrecio
        '
        Me.txtVentaPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaPrecio.Location = New System.Drawing.Point(286, 261)
        Me.txtVentaPrecio.Name = "txtVentaPrecio"
        Me.txtVentaPrecio.Size = New System.Drawing.Size(119, 23)
        Me.txtVentaPrecio.TabIndex = 71
        '
        'txtVentaCantidad
        '
        Me.txtVentaCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentaCantidad.Location = New System.Drawing.Point(286, 199)
        Me.txtVentaCantidad.Name = "txtVentaCantidad"
        Me.txtVentaCantidad.Size = New System.Drawing.Size(119, 23)
        Me.txtVentaCantidad.TabIndex = 70
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(84, 432)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Precio_Des:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(84, 499)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 17)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Subtota:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(84, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "buscar libro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Buscar cliente"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(896, 644)
        Me.ListBox1.TabIndex = 54
        '
        'Btn_guardar_cliente1
        '
        Me.Btn_guardar_cliente1.BackColor = System.Drawing.Color.Transparent
        Me.Btn_guardar_cliente1.BackgroundImage = CType(resources.GetObject("Btn_guardar_cliente1.BackgroundImage"), System.Drawing.Image)
        Me.Btn_guardar_cliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_guardar_cliente1.FlatAppearance.BorderSize = 0
        Me.Btn_guardar_cliente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_guardar_cliente1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardar_cliente1.Location = New System.Drawing.Point(82, 588)
        Me.Btn_guardar_cliente1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_guardar_cliente1.Name = "Btn_guardar_cliente1"
        Me.Btn_guardar_cliente1.Size = New System.Drawing.Size(304, 51)
        Me.Btn_guardar_cliente1.TabIndex = 77
        Me.Btn_guardar_cliente1.Text = "crear venta"
        Me.Btn_guardar_cliente1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(535, 588)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(304, 51)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Location = New System.Drawing.Point(286, 374)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.Size = New System.Drawing.Size(119, 26)
        Me.TxtDescuento.TabIndex = 79
        '
        'txtprecio_des
        '
        Me.txtprecio_des.Location = New System.Drawing.Point(286, 434)
        Me.txtprecio_des.Name = "txtprecio_des"
        Me.txtprecio_des.ReadOnly = True
        Me.txtprecio_des.Size = New System.Drawing.Size(119, 26)
        Me.txtprecio_des.TabIndex = 80
        '
        'Txt_subtota
        '
        Me.Txt_subtota.Location = New System.Drawing.Point(286, 486)
        Me.Txt_subtota.Name = "Txt_subtota"
        Me.Txt_subtota.ReadOnly = True
        Me.Txt_subtota.Size = New System.Drawing.Size(119, 26)
        Me.Txt_subtota.TabIndex = 81
        '
        'txtClienteNombre
        '
        Me.txtClienteNombre.FormattingEnabled = True
        Me.txtClienteNombre.Location = New System.Drawing.Point(286, 84)
        Me.txtClienteNombre.Name = "txtClienteNombre"
        Me.txtClienteNombre.Size = New System.Drawing.Size(388, 28)
        Me.txtClienteNombre.TabIndex = 82
        '
        'txtLibroNombre
        '
        Me.txtLibroNombre.FormattingEnabled = True
        Me.txtLibroNombre.Location = New System.Drawing.Point(286, 140)
        Me.txtLibroNombre.Name = "txtLibroNombre"
        Me.txtLibroNombre.Size = New System.Drawing.Size(379, 28)
        Me.txtLibroNombre.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "ficha de venta:"
        '
        'ficha_de_venta
        '
        Me.ficha_de_venta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ficha_de_venta.Location = New System.Drawing.Point(286, 312)
        Me.ficha_de_venta.Name = "ficha_de_venta"
        Me.ficha_de_venta.Size = New System.Drawing.Size(200, 26)
        Me.ficha_de_venta.TabIndex = 87
        '
        'Nueva_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 695)
        Me.Controls.Add(Me.ficha_de_venta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLibroNombre)
        Me.Controls.Add(Me.txtClienteNombre)
        Me.Controls.Add(Me.Txt_subtota)
        Me.Controls.Add(Me.txtprecio_des)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_guardar_cliente1)
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
        Me.Name = "Nueva_Venta"
        Me.Text = "Nueva_Venta"
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
    Friend WithEvents Btn_guardar_cliente1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents txtprecio_des As TextBox
    Friend WithEvents Txt_subtota As TextBox
    Friend WithEvents txtClienteNombre As ComboBox
    Friend WithEvents txtLibroNombre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ficha_de_venta As DateTimePicker
End Class
