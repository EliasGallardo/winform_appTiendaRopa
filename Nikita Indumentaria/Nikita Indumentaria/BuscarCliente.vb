Public Class FrmBuscarCliente
    Dim objCLI As New Clientes
    Dim objVEN As New VentasProductos
    Dim objPRO As New Productos
    Dim objEMP As New Empleados

    Private Sub FrmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargo los combox

        objCLI.llenarclientes(CBClientes)

        objPRO.listbox_Productos(ListBox2.SelectedItem)
        objEMP.listbox_Empleados(ListBox3.SelectedItem)

        objCLI.listarEmpleados(GRILLA, CBClientes.SelectedIndex)

        'esto es para que siemrpe este selecconado el primero valor en el listbox
        ListBox2.SelectedIndex = 0
        ListBox3.SelectedIndex = 0
    End Sub

    Private Sub CBClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBClientes.SelectedIndexChanged
        objCLI.listarEmpleados(GRILLA, CBClientes.SelectedIndex)
    End Sub

    Private Sub BTCargar_Click(sender As Object, e As EventArgs) Handles BTCargar.Click
        objVEN.Grabar_Venta(CBClientes.SelectedIndex, ListBox2.SelectedIndex, ListBox3.SelectedIndex, Fecha.Text)
        MsgBox("Datos Guardados Correctamente")
    End Sub


End Class