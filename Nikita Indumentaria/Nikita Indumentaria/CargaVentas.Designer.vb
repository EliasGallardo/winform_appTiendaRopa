<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaVentas
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
        Me.CbClientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbProductos = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CbClientes
        '
        Me.CbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbClientes.FormattingEnabled = True
        Me.CbClientes.Location = New System.Drawing.Point(33, 53)
        Me.CbClientes.Name = "CbClientes"
        Me.CbClientes.Size = New System.Drawing.Size(121, 21)
        Me.CbClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Empleados"
        '
        'CbEmpleados
        '
        Me.CbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmpleados.FormattingEnabled = True
        Me.CbEmpleados.Location = New System.Drawing.Point(198, 53)
        Me.CbEmpleados.Name = "CbEmpleados"
        Me.CbEmpleados.Size = New System.Drawing.Size(121, 21)
        Me.CbEmpleados.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Productos"
        '
        'CbProductos
        '
        Me.CbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProductos.FormattingEnabled = True
        Me.CbProductos.Location = New System.Drawing.Point(33, 153)
        Me.CbProductos.Name = "CbProductos"
        Me.CbProductos.Size = New System.Drawing.Size(120, 21)
        Me.CbProductos.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(198, 154)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(223, 207)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(96, 37)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'FrmCargaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(354, 270)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CbProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbEmpleados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbClientes)
        Me.MaximizeBox = False
        Me.Name = "FrmCargaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbClientes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbEmpleados As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbProductos As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Label4 As Label
End Class
