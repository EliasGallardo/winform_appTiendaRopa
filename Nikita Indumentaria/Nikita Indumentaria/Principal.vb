Public Class FrmPrincipal
    Dim objCLI As New Clientes


    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        NuevoCliente.Show()
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        objCLI.exportar()
    End Sub

    Private Sub BtnCarga_Click(sender As Object, e As EventArgs) Handles BtnCarga.Click
        FrmCargaVentas.Show()
    End Sub

    Private Sub BtnConsultas_Click(sender As Object, e As EventArgs) Handles BtnConsultas.Click
        FrmConsultaVentas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCalcularVentas.Show()
    End Sub

    Private Sub BtnBuscar_Cliente_Click(sender As Object, e As EventArgs) Handles BtnBuscar_Cliente.Click
        FrmBuscarCliente.Show()
    End Sub

End Class