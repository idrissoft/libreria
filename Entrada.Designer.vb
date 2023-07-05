<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.Btnlibros = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnCompra = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnlibros
        '
        Me.Btnlibros.BackColor = System.Drawing.Color.Transparent
        Me.Btnlibros.BackgroundImage = CType(resources.GetObject("Btnlibros.BackgroundImage"), System.Drawing.Image)
        Me.Btnlibros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnlibros.FlatAppearance.BorderSize = 0
        Me.Btnlibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlibros.Location = New System.Drawing.Point(12, 69)
        Me.Btnlibros.Name = "Btnlibros"
        Me.Btnlibros.Size = New System.Drawing.Size(146, 76)
        Me.Btnlibros.TabIndex = 0
        Me.Btnlibros.Text = "Libros"
        Me.Btnlibros.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Transparent
        Me.BtnClientes.BackgroundImage = CType(resources.GetObject("BtnClientes.BackgroundImage"), System.Drawing.Image)
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(397, 69)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(149, 76)
        Me.BtnClientes.TabIndex = 1
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnCompra
        '
        Me.BtnCompra.BackColor = System.Drawing.Color.Transparent
        Me.BtnCompra.BackgroundImage = CType(resources.GetObject("BtnCompra.BackgroundImage"), System.Drawing.Image)
        Me.BtnCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCompra.FlatAppearance.BorderSize = 0
        Me.BtnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompra.Location = New System.Drawing.Point(184, 135)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(181, 76)
        Me.BtnCompra.TabIndex = 2
        Me.BtnCompra.Text = "Venta"
        Me.BtnCompra.UseVisualStyleBackColor = False
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 257)
        Me.Controls.Add(Me.BtnCompra)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.Btnlibros)
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnlibros As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnCompra As Button
End Class
