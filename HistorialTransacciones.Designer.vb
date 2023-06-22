<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialTransacciones
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
        Me.DataGridView_HistorialTransacciones = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView_HistorialTransacciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_HistorialTransacciones
        '
        Me.DataGridView_HistorialTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_HistorialTransacciones.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView_HistorialTransacciones.Name = "DataGridView_HistorialTransacciones"
        Me.DataGridView_HistorialTransacciones.Size = New System.Drawing.Size(799, 450)
        Me.DataGridView_HistorialTransacciones.TabIndex = 0
        '
        'HistorialTransacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView_HistorialTransacciones)
        Me.Name = "HistorialTransacciones"
        Me.Text = "HistorialTransacciones"
        CType(Me.DataGridView_HistorialTransacciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_HistorialTransacciones As DataGridView
End Class
