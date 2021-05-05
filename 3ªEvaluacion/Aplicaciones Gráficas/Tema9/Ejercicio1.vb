Public Class Ejercicio1
    Dim precioFinal As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcularPrecioFinal.Click
        precioFinal = 0
        'Verificando que cajas están seleccionadas
        If chkImpresora.Checked Then
            precioFinal += 100 * nudImpresota.Value
        End If

        If chkNotebook.Checked Then
            precioFinal += 150 * nudNotebook.Value

        End If

        If chkPortatil.Checked Then
            precioFinal += 250 * nudPortatil.Value
        End If

        txtPrecioFinal.Text = precioFinal.ToString()
    End Sub

    Private Sub chkImpresora_CheckedChanged(sender As Object, e As EventArgs) Handles chkImpresora.CheckedChanged
        If chkImpresora.Checked Then
            nudImpresota.Value = 1
        Else
            nudImpresota.Value = 0
        End If
    End Sub
End Class