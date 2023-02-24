<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCarga = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnConsultas = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnBuscar_Cliente = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(782, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIKITA INDUMENTARIA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.BtnCarga)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnConsultas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 161)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VENTAS"
        '
        'BtnCarga
        '
        Me.BtnCarga.BackColor = System.Drawing.Color.Silver
        Me.BtnCarga.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.BtnCarga.Image = Global.Nikita_Indumentaria.My.Resources.Resources.Venta
        Me.BtnCarga.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCarga.Location = New System.Drawing.Point(42, 37)
        Me.BtnCarga.Name = "BtnCarga"
        Me.BtnCarga.Size = New System.Drawing.Size(153, 95)
        Me.BtnCarga.TabIndex = 7
        Me.BtnCarga.Text = "Cargas"
        Me.BtnCarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCarga.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Button1.Image = Global.Nikita_Indumentaria.My.Resources.Resources.grafico_de_barras
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(431, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 95)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calcular Ventas"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnConsultas
        '
        Me.BtnConsultas.BackColor = System.Drawing.Color.Silver
        Me.BtnConsultas.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.BtnConsultas.Image = Global.Nikita_Indumentaria.My.Resources.Resources.ventas
        Me.BtnConsultas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultas.Location = New System.Drawing.Point(229, 37)
        Me.BtnConsultas.Name = "BtnConsultas"
        Me.BtnConsultas.Size = New System.Drawing.Size(155, 95)
        Me.BtnConsultas.TabIndex = 7
        Me.BtnConsultas.Text = "Consultas"
        Me.BtnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultas.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Controls.Add(Me.BtnGrabar)
        Me.GroupBox2.Controls.Add(Me.BtnBuscar_Cliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(445, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 210)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLIENTES"
        '
        'BtnGrabar
        '
        Me.BtnGrabar.BackColor = System.Drawing.Color.Silver
        Me.BtnGrabar.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.BtnGrabar.Image = Global.Nikita_Indumentaria.My.Resources.Resources.agregar_usuario
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGrabar.Location = New System.Drawing.Point(36, 57)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(139, 91)
        Me.BtnGrabar.TabIndex = 2
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = False
        '
        'BtnBuscar_Cliente
        '
        Me.BtnBuscar_Cliente.BackColor = System.Drawing.Color.Silver
        Me.BtnBuscar_Cliente.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.BtnBuscar_Cliente.Image = Global.Nikita_Indumentaria.My.Resources.Resources.buscar
        Me.BtnBuscar_Cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscar_Cliente.Location = New System.Drawing.Point(190, 57)
        Me.BtnBuscar_Cliente.Name = "BtnBuscar_Cliente"
        Me.BtnBuscar_Cliente.Size = New System.Drawing.Size(139, 91)
        Me.BtnBuscar_Cliente.TabIndex = 2
        Me.BtnBuscar_Cliente.Text = "Buscar"
        Me.BtnBuscar_Cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscar_Cliente.UseVisualStyleBackColor = False
        '
        'BtnExportar
        '
        Me.BtnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnExportar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnExportar.Image = Global.Nikita_Indumentaria.My.Resources.Resources.exportar
        Me.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExportar.Location = New System.Drawing.Point(633, 363)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(141, 98)
        Me.BtnExportar.TabIndex = 7
        Me.BtnExportar.Text = "Exportar Datos"
        Me.BtnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExportar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.Nikita_Indumentaria.My.Resources.Resources.imgPrincipal
        Me.PictureBox1.Location = New System.Drawing.Point(23, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 522)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana Principal"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents BtnCarga As Button
    Friend WithEvents BtnConsultas As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnBuscar_Cliente As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
