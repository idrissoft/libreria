<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Libros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Libros))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_eliminar_libro = New System.Windows.Forms.Button()
        Me.Btn_volver = New System.Windows.Forms.Button()
        Me.Btn_añadir_libro = New System.Windows.Forms.Button()
        Me.DataGridView_libros = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Editar = New System.Windows.Forms.Button()
        Me.Btn_agregar_imagen = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DataGridView_UnidadesLogisticas = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_libros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView_UnidadesLogisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 29)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Libreria"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1057, 656)
        Me.Panel2.TabIndex = 1
        '
        'Btn_eliminar_libro
        '
        Me.Btn_eliminar_libro.BackColor = System.Drawing.Color.Transparent
        Me.Btn_eliminar_libro.BackgroundImage = CType(resources.GetObject("Btn_eliminar_libro.BackgroundImage"), System.Drawing.Image)
        Me.Btn_eliminar_libro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_eliminar_libro.FlatAppearance.BorderSize = 0
        Me.Btn_eliminar_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_eliminar_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_eliminar_libro.Location = New System.Drawing.Point(3, 76)
        Me.Btn_eliminar_libro.Name = "Btn_eliminar_libro"
        Me.Btn_eliminar_libro.Size = New System.Drawing.Size(81, 35)
        Me.Btn_eliminar_libro.TabIndex = 4
        Me.Btn_eliminar_libro.Text = "Eliminar"
        Me.Btn_eliminar_libro.UseVisualStyleBackColor = False
        '
        'Btn_volver
        '
        Me.Btn_volver.BackColor = System.Drawing.Color.Transparent
        Me.Btn_volver.BackgroundImage = CType(resources.GetObject("Btn_volver.BackgroundImage"), System.Drawing.Image)
        Me.Btn_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_volver.FlatAppearance.BorderSize = 0
        Me.Btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_volver.Location = New System.Drawing.Point(3, 273)
        Me.Btn_volver.Name = "Btn_volver"
        Me.Btn_volver.Size = New System.Drawing.Size(84, 33)
        Me.Btn_volver.TabIndex = 2
        Me.Btn_volver.Text = "Volver"
        Me.Btn_volver.UseVisualStyleBackColor = False
        '
        'Btn_añadir_libro
        '
        Me.Btn_añadir_libro.BackColor = System.Drawing.Color.Transparent
        Me.Btn_añadir_libro.BackgroundImage = CType(resources.GetObject("Btn_añadir_libro.BackgroundImage"), System.Drawing.Image)
        Me.Btn_añadir_libro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_añadir_libro.FlatAppearance.BorderSize = 0
        Me.Btn_añadir_libro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_añadir_libro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_añadir_libro.Location = New System.Drawing.Point(3, 37)
        Me.Btn_añadir_libro.Name = "Btn_añadir_libro"
        Me.Btn_añadir_libro.Size = New System.Drawing.Size(81, 33)
        Me.Btn_añadir_libro.TabIndex = 1
        Me.Btn_añadir_libro.Text = "Añadir"
        Me.Btn_añadir_libro.UseVisualStyleBackColor = False
        '
        'DataGridView_libros
        '
        Me.DataGridView_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_libros.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView_libros.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_libros.Name = "DataGridView_libros"
        Me.DataGridView_libros.RowHeadersWidth = 62
        Me.DataGridView_libros.Size = New System.Drawing.Size(967, 889)
        Me.DataGridView_libros.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Btn_Editar)
        Me.Panel3.Controls.Add(Me.Btn_agregar_imagen)
        Me.Panel3.Controls.Add(Me.Btn_volver)
        Me.Panel3.Controls.Add(Me.Btn_eliminar_libro)
        Me.Panel3.Controls.Add(Me.Btn_añadir_libro)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(90, 656)
        Me.Panel3.TabIndex = 3
        '
        'Btn_Editar
        '
        Me.Btn_Editar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Editar.BackgroundImage = CType(resources.GetObject("Btn_Editar.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Editar.FlatAppearance.BorderSize = 0
        Me.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Editar.Location = New System.Drawing.Point(3, 118)
        Me.Btn_Editar.Name = "Btn_Editar"
        Me.Btn_Editar.Size = New System.Drawing.Size(81, 35)
        Me.Btn_Editar.TabIndex = 6
        Me.Btn_Editar.Text = "Editar"
        Me.Btn_Editar.UseVisualStyleBackColor = False
        '
        'Btn_agregar_imagen
        '
        Me.Btn_agregar_imagen.BackColor = System.Drawing.Color.Transparent
        Me.Btn_agregar_imagen.BackgroundImage = CType(resources.GetObject("Btn_agregar_imagen.BackgroundImage"), System.Drawing.Image)
        Me.Btn_agregar_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_agregar_imagen.FlatAppearance.BorderSize = 0
        Me.Btn_agregar_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_agregar_imagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_agregar_imagen.Location = New System.Drawing.Point(3, 159)
        Me.Btn_agregar_imagen.Name = "Btn_agregar_imagen"
        Me.Btn_agregar_imagen.Size = New System.Drawing.Size(84, 51)
        Me.Btn_agregar_imagen.TabIndex = 5
        Me.Btn_agregar_imagen.Text = "agregar image"
        Me.Btn_agregar_imagen.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(90, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(967, 37)
        Me.Panel4.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(240, 10)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(474, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(206, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(230, -131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(172, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(264, -122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(474, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView_libros)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(90, 66)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(967, 619)
        Me.Panel5.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DataGridView_UnidadesLogisticas)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(90, 320)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(967, 365)
        Me.Panel6.TabIndex = 8
        '
        'DataGridView_UnidadesLogisticas
        '
        Me.DataGridView_UnidadesLogisticas.AllowUserToAddRows = False
        Me.DataGridView_UnidadesLogisticas.AllowUserToDeleteRows = False
        Me.DataGridView_UnidadesLogisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_UnidadesLogisticas.Location = New System.Drawing.Point(265, 8)
        Me.DataGridView_UnidadesLogisticas.Name = "DataGridView_UnidadesLogisticas"
        Me.DataGridView_UnidadesLogisticas.ReadOnly = True
        Me.DataGridView_UnidadesLogisticas.Size = New System.Drawing.Size(699, 281)
        Me.DataGridView_UnidadesLogisticas.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(262, 290)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 51)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "unidades logisticas"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 685)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Libros"
        Me.Text = "Libros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_libros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.DataGridView_UnidadesLogisticas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_eliminar_libro As Button
    Friend WithEvents Btn_volver As Button
    Friend WithEvents Btn_añadir_libro As Button
    Friend WithEvents DataGridView_libros As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_agregar_imagen As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Btn_Editar As Button
    Friend WithEvents DataGridView_UnidadesLogisticas As DataGridView
    Friend WithEvents Button2 As Button
End Class
