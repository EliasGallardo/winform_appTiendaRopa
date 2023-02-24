Imports System.Data.OleDb

Public Class VentasProductos
    Dim CONECTOR As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Indumentaria.accdb")
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable
    Dim DR As OleDb.OleDbDataReader

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "VentasProductos"

        Try
            ADAPTADOR.Fill(TABLA)
        Catch ex As Exception
            MessageBox.Show("NO ESTA LA BASE DE DATOS", "ERROR")
            Exit Sub
        End Try


        Dim VECTOR(1) As DataColumn
        VECTOR(0) = TABLA.Columns("IdVentasProductos")
        VECTOR(1) = TABLA.Columns("IdProducto")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Sub grabar(FRM As FrmCargaVentas)
        Dim FILA As DataRow = TABLA.NewRow

        FILA("IdProducto") = FRM.CbProductos.SelectedIndex + 1
        FILA("IdCliente") = FRM.CbClientes.SelectedIndex + 1
        FILA("IdEmpleado") = FRM.CbEmpleados.SelectedIndex + 1
        FILA("FechaVenta") = FRM.DateTimePicker1.Text

        TABLA.Rows.Add(FILA)
        actualziar()

    End Sub

    Public Sub actualziar()
        Dim MGO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub

    Public Function listar(ByVal GRILLA As DataGridView, COMBO As Integer, FECHA As String)
        Dim VENTAS As Integer = 0
        Dim C As Integer = GRILLA.Rows.Count - 1

        COMBO = COMBO + 1

        For Each FILA As DataRow In TABLA.Rows

            If FILA("IdEmpleado") = COMBO And FILA("FechaVenta") = FECHA Then
                VENTAS = VENTAS + 1
            End If


        Next
        GRILLA.Rows(C).Cells(0).Value = VENTAS
        Return VENTAS
    End Function

    '*******************'

    Public Sub CalcularVenta(FRM)
        Dim TOTAL As Integer

        FrmCalcularVentas.Label1.Text = ""
        FrmCalcularVentas.Chart1.Series.Clear()
        FrmCalcularVentas.Chart1.Series.Add("Ventas por Fecha")
        Dim dias As Integer

        For Each FILA As DataRow In TABLA.Rows
            dias = DateAndTime.Day(FILA("FechaVenta"))

            '   For Each i As DataRow In FILA("FechaVenta")
            FrmCalcularVentas.Chart1.Series(0).Points.AddXY(dias, TOTAL)
                TOTAL = TOTAL + 1
            '  Next

        Next



        If TOTAL = 0 Then
            MessageBox.Show("NO HAY DATOS")
            FrmCalcularVentas.Chart1.Series.Clear()
            Exit Sub
        End If


        FrmCalcularVentas.Label1.Text = "Total Acumulado de Ventas es:   " & TOTAL

        FrmCalcularVentas.BtnImprimir.Enabled = True

    End Sub


    Public Sub Grabar_Venta(CLIENTE As Integer, PRODUCTOS As Integer, EMPLEADOS As Integer, FECHA As String)


        CLIENTE = CLIENTE + 1
        PRODUCTOS = PRODUCTOS + 1
        EMPLEADOS = EMPLEADOS + 1

        Dim FILA As DataRow = TABLA.NewRow

        FILA("IdVentasProductos") = 0
        FILA("IdProducto") = PRODUCTOS
        FILA("IdCliente") = CLIENTE
        FILA("IdEmpleado") = EMPLEADOS
        FILA("FechaVenta") = FECHA

        TABLA.Rows.Add(FILA)
        actualziar()

    End Sub



End Class
