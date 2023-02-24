Public Class FrmCargaVentas
    Dim objCLI As New Clientes
    Dim oBjEMP As New Empleados
    Dim objPRO As New Productos
    Dim objVP As New VentasProductos

    Private Sub FrmCargaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCLI.llenarclientes(CbClientes)
        oBjEMP.llenarempleados(CbEmpleados)
        objPRO.llenarproductos(CbProductos)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        objVP.grabar(Me)
        MessageBox.Show("DATOS GUARDADOS CON EXITO", "CORRECTO")

    End Sub
End Class