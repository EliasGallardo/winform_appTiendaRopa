Imports System.Data.OleDb 'libreria


Public Class Clientes
    'Objetos para manipular la tabla

    Dim CONECTOR As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Indumentaria.accdb") 'creo la cadena de conexion
    Dim COMANDO As New OleDbCommand ' objeto comando
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO) 'actualiza desde la grilla en la tabla
    Dim TABLA As New DataTable 'tabla de datos 
    Dim DR As OleDb.OleDbDataReader 'obtenber datos de una tabla

    ' se carga la tabla en memoria
    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Clientes"

        'depurador de errores
        Try
            ADAPTADOR.Fill(TABLA)
        Catch ex As Exception
            MessageBox.Show("NO ESTA LA BASE DE DATOS", "ERROR")
            Exit Sub
        End Try


        Dim VECTOR(1) As DataColumn
        VECTOR(0) = TABLA.Columns("IdCliente")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Sub exportar()

        Dim SFD As New SaveFileDialog
        SFD.Filter = "txt|*.txt" 'filtro para fichero

        Dim resultadoSFD As String
        SFD.ShowDialog() 'aqui obtengo la ruta y el nombre del fichero
        resultadoSFD = SFD.FileName

        CONECTOR.Open()
        DR = COMANDO.ExecuteReader
        DR.Read()

        If DR.HasRows Then
            If resultadoSFD = "" Then 'CONTROLO QUE resultadoSFD tenga "valor", si no tiene nada que salga del sub

                Exit Sub

            Else


                Dim SW As New IO.StreamWriter(resultadoSFD)

                Do While DR.Read
                    SW.WriteLine(DR("IdCliente"))
                    SW.WriteLine(DR("Nombre"))
                    SW.WriteLine(DR("Domicilio"))
                    SW.WriteLine(DR("Telefono"))
                    SW.Flush() 'fuerzo la escritura
                Loop
                SW.Close()
                'FileClose(1)


            End If

        End If



        CONECTOR.Close()




        MsgBox("DATOS EXPORTADOS")

    End Sub


    Public Sub Grabar(ByVal FRM As NuevoCliente)

        'recorro la tabla
        Dim FILA As DataRow = TABLA.NewRow

        FILA("IdCliente") = 0
        FILA("Nombre") = FRM.TxtNombre.Text
        FILA("Domicilio") = FRM.TxtDomicilio.Text
        FILA("Telefono") = FRM.TxtTelefono.Text

        TABLA.Rows.Add(FILA)
        actualziar()

    End Sub

    'esto es para actualziar los datos llamando al update metodo de tableAdapter
    Public Sub actualziar()
        Dim MGO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub

    Public Function buscar(ByVal id As Integer) As DataRow

        'en esta funcion retono la busqueda
        Dim FILA As DataRow = TABLA.Rows.Find(id)
        Return FILA

    End Function


    Public Sub llenarclientes(COMBO As ComboBox)
        COMBO.DisplayMember = "Nombre" 'propiedad DisplayMember para que me muestre solamente la columna de nombre
        COMBO.DataSource = TABLA  'el registo
    End Sub


    Public Sub listarEmpleados(ByVal GRILLA As DataGridView, COMBO As Integer)
        GRILLA.Rows.Clear()
        Dim C As Integer = GRILLA.Rows.Count - 1

        COMBO = COMBO + 1

        For Each FILA As DataRow In TABLA.Rows 'recorro la tabla

            If FILA("IdCliente") = COMBO Then 'compruebo los datos de la tabla con el combox 
                GRILLA.Rows(C).Cells(0).Value = FILA("IdCliente")
                GRILLA.Rows(C).Cells(1).Value = FILA("Domicilio")
                GRILLA.Rows(C).Cells(2).Value = FILA("Telefono")
            End If

        Next


    End Sub


End Class
