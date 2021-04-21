Public Class Ejercicio6
    Private Sub btnConvertirFahrenheit_Click(sender As Object, e As EventArgs) Handles btnConvertirFahrenheit.Click
        'Obtener los grados centígrados
        If txtCentigrados.Text <> "" Then
            Try
                Dim gradosCentigrados As Double = Convert.ToDouble(txtCentigrados.Text)
                Dim gradosFahrenheit As Double = (5 / 9) * gradosCentigrados + 32
                txtFahrenheit.Text = gradosFahrenheit.ToString()
            Catch ex As Exception
                MessageBox.Show("No se pudo realizar la operación.")
            End Try

        Else
            MessageBox.Show("Introduzca por favor los grados")
            'Sitúo el foco en la caja de texto
            txtCentigrados.Focus()

        End If

    End Sub



    Private Sub conversion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCentigrados.KeyPress, txtFahrenheit.KeyPress, txtKelvin.KeyPress

        'Detectar que tecla está siendo pulsada
        Dim tecla As Char = e.KeyChar

        If tecla = Convert.ToChar(Keys.Enter) Then
            'Detectar que caja de texto ha lanzado el evento
            Dim caja As TextBox = CType(sender, TextBox)

            If caja Is txtCentigrados Then
                btnConvertirFahrenheit.PerformClick()

            ElseIf caja Is txtFahrenheit Then
                btnConvertirACentigrados.PerformClick()

            Else
                btnConvertirAKelvin.PerformClick()

            End If
        End If




    End Sub

    'Private Sub txtFahrenheit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFahrenheit.KeyPress

    '    'Detectar la tecla que está siendo pulsada
    '    Dim tecla As Char = e.KeyChar

    '    If tecla = Convert.ToChar(Keys.Enter) Then

    '    End If
    'End Sub

    'Private Sub txtKelvin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKelvin.KeyPress
    '    'Detectar la tecla que está siendo pulsada
    '    Dim tecla As Char = e.KeyChar

    '    If tecla = Convert.ToChar(Keys.Enter) Then

    '    End If
    'End Sub

    Private Sub btnConvertirACentigrados_Click(sender As Object, e As EventArgs) Handles btnConvertirACentigrados.Click

    End Sub

    Private Sub btnConvertirAKelvin_Click(sender As Object, e As EventArgs) Handles btnConvertirAKelvin.Click

    End Sub
End Class