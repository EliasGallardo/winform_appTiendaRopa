

Public Class FrmCalcularVentas
    Dim a, b As Graphics ' dibujar los objetos
    Dim bmp As Bitmap 'objeto para trabajr con img mediante datos pixeles

    Dim objVP As New VentasProductos

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        objVP.CalcularVenta(Me)

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click


        a = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, a)
        b = Graphics.FromImage(bmp)
        b.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.ShowDialog()

    End Sub


    Private Sub PrintPreviewDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub
End Class
