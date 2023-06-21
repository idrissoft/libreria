<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.DataGridView_clientes = New System.Windows.Forms.DataGridView()
        Me.Btn_eliminar_clientes = New System.Windows.Forms.Button()
        Me.Btn_anadir_clientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_clientes
        '
        Me.DataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_clientes.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView_clientes.Name = "DataGridView_clientes"
        Me.DataGridView_clientes.RowHeadersWidth = 62
        Me.DataGridView_clientes.Size = New System.Drawing.Size(1189, 341)
        Me.DataGridView_clientes.TabIndex = 5
        '
        'Btn_eliminar_clientes
        '
        Me.Btn_eliminar_clientes.BackColor = System.Drawing.Color.Transparent
        Me.Btn_eliminar_clientes.BackgroundImage = CType(resources.GetObject("Btn_eliminar_clientes.BackgroundImage"), System.Drawing.Image)
        Me.Btn_eliminar_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_eliminar_clientes.FlatAppearance.BorderSize = 0
        Me.Btn_eliminar_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_eliminar_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_eliminar_clientes.Location = New System.Drawing.Point(41, 120)
        Me.Btn_eliminar_clientes.Name = "Btn_eliminar_clientes"
        Me.Btn_eliminar_clientes.Size = New System.Drawing.Size(86, 49)
        Me.Btn_eliminar_clientes.TabIndex = 4
        Me.Btn_eliminar_clientes.Text = "Eliminar"
        Me.Btn_eliminar_clientes.UseVisualStyleBackColor = False
        '
        'Btn_anadir_clientes
        '
        Me.Btn_anadir_clientes.BackColor = System.Drawing.Color.Transparent
        Me.Btn_anadir_clientes.BackgroundImage = CType(resources.GetObject("Btn_anadir_clientes.BackgroundImage"), System.Drawing.Image)
        Me.Btn_anadir_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_anadir_clientes.FlatAppearance.BorderSize = 0
        Me.Btn_anadir_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_anadir_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_anadir_clientes.Location = New System.Drawing.Point(41, 54)
        Me.Btn_anadir_clientes.Name = "Btn_anadir_clientes"
        Me.Btn_anadir_clientes.Size = New System.Drawing.Size(86, 49)
        Me.Btn_anadir_clientes.TabIndex = 1
        Me.Btn_anadir_clientes.Text = "Añadir"
        Me.Btn_anadir_clientes.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 539)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1319, 107)
        Me.Panel2.TabIndex = 4
        '
        'btn_volver
        '
        Me.btn_volver.BackColor = System.Drawing.Color.Transparent
        Me.btn_volver.BackgroundImage = CType(resources.GetObject("btn_volver.BackgroundImage"), System.Drawing.Image)
        Me.btn_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_volver.FlatAppearance.BorderSize = 0
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.Location = New System.Drawing.Point(37, 255)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(91, 49)
        Me.btn_volver.TabIndex = 2
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1319, 26)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(448, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clientes"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btn_volver)
        Me.Panel3.Controls.Add(Me.Btn_eliminar_clientes)
        Me.Panel3.Controls.Add(Me.Btn_anadir_clientes)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 513)
        Me.Panel3.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(36, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(127, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1192, 51)
        Me.Panel4.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(129, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(474, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView_clientes)
        Me.Panel5.Location = New System.Drawing.Point(127, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1192, 462)
        Me.Panel5.TabIndex = 8
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 646)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.DataGridView_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_clientes As DataGridView
    Friend WithEvents Btn_eliminar_clientes As Button
    Friend WithEvents Btn_anadir_clientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_volver As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
End Class
