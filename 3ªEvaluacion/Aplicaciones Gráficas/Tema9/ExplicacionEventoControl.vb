Public Class ExplicacionEventoControl

    Private Sub clickBotones(sender As Object, e As EventArgs) Handles btnAmarillo.Click, btnAzul.Click, btnNaranja.Click, btnRojo.Click, btnVerde.Click
        'Obtener botón que generó el evento
        Label1.Visible = True
        Dim boton As Button = CType(sender, Button)

        Label1.Text = boton.Text


        If boton Is btnAmarillo Then
            Me.BackColor = Color.Yellow
        ElseIf boton Is btnAzul Then
            Me.BackColor = Color.Blue
        ElseIf boton Is btnNaranja Then
            Me.BackColor = Color.Orange
        ElseIf boton Is btnRojo Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Green

        End If



    End Sub

End Class