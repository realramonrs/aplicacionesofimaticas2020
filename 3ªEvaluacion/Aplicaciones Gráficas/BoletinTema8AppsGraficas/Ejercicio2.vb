Public Class Ejercicio2
    Private Sub Ejercicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocar el foco en txtDia
        Me.ActiveControl = txtDia

        'Centrar el groupbox

    End Sub

    Private Sub btnConvertirFecha_Click(sender As Object, e As EventArgs) Handles btnConvertirFecha.Click
        Dim diaOk As Boolean = False
        Dim mesOk As Boolean = False
        If txtDia.Text = "" Then
            MessageBox.Show("Debe de introducir el día")
            txtDia.Focus()
            txtDia.SelectAll()
        ElseIf Convert.ToInt32(txtDia.Text) < 1 Or Convert.ToInt32(txtDia.Text) > 31 Then
            MessageBox.Show("El día tiene que ser un valor entre 1 y 31")
            txtDia.Focus()
            txtDia.SelectAll()
        Else
            diaOk = True
        End If

        If txtMes.Text = "" Then
            MessageBox.Show("Debe de introducir el mes")
        ElseIf Convert.ToInt32(txtMes.Text) < 1 Or Convert.ToInt32(txtMes.Text) > 12 Then
            MessageBox.Show("El mes debe de ser un valor entre 1 y 12")
        ElseIf Convert.ToInt32(txtMes.Text) = 2 And Convert.ToInt32(txtDia.Text) > 29 Then
            MessageBox.Show("Febrero no debe de tener más de 29 días")
        Else
            mesOk = True

        End If

        'si todo está ok
        If diaOk And mesOk Then
            Dim dia As String = txtDia.Text
            Dim mes As String = txtMes.Text
            Dim anho As String = txtAnho.Text

            Dim fecha As String = ""

            Select Case mes
                Case "1"
                    fecha = dia + " de Enero de " + anho
                Case "2"
                    fecha = dia + " de Febrero de " + anho
                Case "3"
                    fecha = dia + " de Marzo de " + anho
                Case "4"
                    fecha = dia + " de Abril de " + anho
                Case "5"
                    fecha = dia + " de Mayo de " + anho
            End Select

            'Volcar la fecha al label lblResultado
            lblResultado.Text = fecha
        End If


    End Sub

    Private Sub Ejercicio2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Ejercicio2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Limpiar las cajas de texto
        txtAnho.Text = ""
        txtDia.Text = ""
        txtMes.Text = ""
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpiar las cajas de texto
        txtAnho.Text = ""
        txtDia.Text = ""
        txtMes.Text = ""
        Me.ActiveControl = txtDia
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Salir de la aplicacion
        ' Application.Exit()

        'Cerrar el formulario
        Me.Close()
    End Sub
End Class