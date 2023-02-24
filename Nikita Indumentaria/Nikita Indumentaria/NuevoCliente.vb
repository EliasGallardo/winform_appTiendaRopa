Public Class NuevoCliente
    Dim objCLI As New Clientes

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        objCLI.Grabar(Me)
        MessageBox.Show("CLIENTE GUARDADO CON EXITO", "CORRECTO")


            TxtNombre.Clear()
            TxtDomicilio.Clear()
            TxtTelefono.Clear()
            TxtNombre.Focus()


    End Sub

    'VALIDACION PARA HABLITAR EL BOTON "AGREGAR"


    Private Sub TxtIdCliente_TextChanged(sender As Object, e As EventArgs)
        'corroboro que exista datos dentro de la caja de texto para habilitar el boton 

        If TxtNombre.Text = "" Or TxtDomicilio.Text = "" Or TxtTelefono.Text = "" Then

            BtnAgregar.Enabled = False

        Else

            BtnAgregar.Enabled = True
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        'corroboro que exista datos dentro de la caja de texto para habilitar el boton  

        If TxtNombre.Text = "" Or TxtDomicilio.Text = "" Or TxtTelefono.Text = "" Then

            BtnAgregar.Enabled = False

        Else

            BtnAgregar.Enabled = True
        End If
    End Sub

    Private Sub TxtDomicilio_TextChanged(sender As Object, e As EventArgs) Handles TxtDomicilio.TextChanged
        'corroboro que exista datos dentro de la caja de texto para habilitar el boton 

        If TxtNombre.Text = "" Or TxtDomicilio.Text = "" Or TxtTelefono.Text = "" Then

            BtnAgregar.Enabled = False

        Else

            BtnAgregar.Enabled = True
        End If
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        'corroboro que exista datos dentro de la caja de texto para habilitar el boton 

        If TxtNombre.Text = "" Or TxtDomicilio.Text = "" Or TxtTelefono.Text = "" Then

            BtnAgregar.Enabled = False

        Else

            BtnAgregar.Enabled = True
        End If
    End Sub




    'SOLO NUMEROS O LETRAS


    Private Sub TxtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        'solo numeros

        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Then

        Else
            e.KeyChar = ""
        End If
    End Sub

    ' EVENTO KeyPress cuando el usuario presiona una tecla 
    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        'solo letras

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'solo numeros

        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Then

        Else
            e.KeyChar = ""
        End If
    End Sub

End Class