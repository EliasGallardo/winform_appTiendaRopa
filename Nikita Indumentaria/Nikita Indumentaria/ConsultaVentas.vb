
Public Class FrmConsultaVentas

    Dim objEMP As New Empleados
    Dim objVP As New VentasProductos
    Public VENTA As Integer

    Private Sub FrmConsultaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objEMP.llenarempleados(CbEmpleados)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        GRILLA.Rows.Clear()

        VENTA = objVP.listar(GRILLA, CbEmpleados.SelectedIndex, DateTimePicker1.Text)

    End Sub

End Class