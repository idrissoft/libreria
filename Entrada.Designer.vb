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
        Me.Btnlibros.Location = New System.Drawing.Point(18, 106)
        Me.Btnlibros.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnlibros.Name = "Btnlibros"
        Me.Btnlibros.Size = New System.Drawing.Size(219, 117)
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
        Me.BtnClientes.Location = New System.Drawing.Point(596, 106)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(224, 117)
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
        Me.BtnCompra.Location = New System.Drawing.Point(276, 207)
        Me.BtnCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCompra.Name = "BtnCompra"
        Me.BtnCompra.Size = New System.Drawing.Size(272, 117)
        Me.BtnCompra.TabIndex = 2
        Me.BtnCompra.Text = "Venta"
        Me.BtnCompra.UseVisualStyleBackColor = False
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(837, 395)
        Me.Controls.Add(Me.BtnCompra)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.Btnlibros)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Entrada"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnlibros As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnCompra As Button
End Class
