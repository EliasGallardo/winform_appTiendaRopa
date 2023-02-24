<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbEmpleados = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GRILLA = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empleados"
        '
        'CbEmpleados
        '
        Me.CbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmpleados.FormattingEnabled = True
        Me.CbEmpleados.Location = New System.Drawing.Point(35, 44)
        Me.CbEmpleados.Name = "CbEmpleados"
        Me.CbEmpleados.Size = New System.Drawing.Size(121, 21)
        Me.CbEmpleados.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(192, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(194, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'GRILLA
        '
        Me.GRILLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRILLA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.GRILLA.Location = New System.Drawing.Point(35, 125)
        Me.GRILLA.Name = "GRILLA"
        Me.GRILLA.Size = New System.Drawing.Size(351, 147)
        Me.GRILLA.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Total de ventas"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(311, 70)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(422, 296)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GRILLA)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CbEmpleados)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmConsultaVentas"
        Me.Text = "Consulta de Ventas"
        CType(Me.GRILLA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbEmpleados As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GRILLA As DataGridView
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
