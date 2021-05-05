Public Class Form1

    Dim contador As Integer = 10
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Try

            txtIndiceSeleccionado.Text = ListBox1.SelectedIndex.ToString()
            txtValorSeleccionado.Text = ListBox1.SelectedItem.ToString()


            Select Case ListBox1.SelectedItem.ToString()
                Case "Sucky"
                    txtDescripcion.Text = "No se calla ni debajo del agua"
                Case "juan"
                    txtDescripcion.Text = "Tiene que mejorar mucho el lenguaje y le cuesta atender en clase"
                Case "Josema"
                    txtDescripcion.Text = "Es un genio del discord"
                Case "Mario"
                    txtDescripcion.Text = "Tiene mucha paciencia, no se como aguanta a Sucky"

            End Select

        Catch ex As NullReferenceException
            MessageBox.Show("No se puede obtener info del usuairo seleccionado")
        End Try
    End Sub

    Private Sub btnAnhadir_Click(sender As Object, e As EventArgs) Handles btnAnhadir.Click
        Dim nombre As String = txtAnhadir.Text

        ListBox1.Items.Add(nombre)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Obtener el elemento seleccionado
        ' Dim elemento As String = ListBox1.SelectedItem.ToString()

        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked Then
            'Volcar al picture la foto de iago aspas
            PictureBox1.Image = My.Resources.descarga

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked Then
            PictureBox1.Image = My.Resources.descarga__2_
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        'Obtener fecha seleccionada
        Dim fecha As Date = DateTimePicker1.Value
        Dim fechaentrega As Date = fecha.AddDays(3)
        txtFechaEscogida.Text = fecha.ToShortDateString
        txtFechaEntrega.Text = fechaentrega.ToShortDateString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If contador > 0 Then
            contador -= 1
            txtCuentaAtras.Text = contador.ToString
        Else
            txtCuentaAtras.Text = contador.ToString
            Timer1.Stop()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCuentaAtras.Text = contador.ToString
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub
End Class
