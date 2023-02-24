Imports System.Data.OleDb

Public Class Productos
    Dim CONECTOR As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Indumentaria.accdb")
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable


    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Productos"

        Try
            ADAPTADOR.Fill(TABLA)
        Catch ex As Exception
            MessageBox.Show("NO ESTA LA BASE DE DATOS", "ERROR")
            Exit Sub
        End Try


        Dim VECTOR(1) As DataColumn
        VECTOR(0) = TABLA.Columns("IdProducto")
        TABLA.PrimaryKey = VECTOR

    End Sub


    Public Sub llenarproductos(COMBO As ComboBox)
        COMBO.DisplayMember = "NombreProducto"
        COMBO.DataSource = TABLA
    End Sub


    Public Sub listbox_Productos(FRM As FrmBuscarCliente)

        For Each FILA As DataRow In TABLA.Rows

            FrmBuscarCliente.ListBox2.Items.Add(FILA("NombreProducto"))


        Next

    End Sub

End Class

