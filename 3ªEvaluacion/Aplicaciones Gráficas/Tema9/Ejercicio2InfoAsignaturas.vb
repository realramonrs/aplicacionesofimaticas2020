Public Class Ejercicio2InfoAsignaturas
    Private Sub Ejercicio2InfoAsignaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Obtener la asignatura que ha sido seleccionada
        lblAsignatura.Text = "Asignatura : "
        lblAsignatura.Text += Ejercicio2.asignatura
        lblProfesor.Text = "Profesor : "

        If Ejercicio2.asignatura = "Redes Locales" Then
            lblProfesor.Text += "Fran Rocha"

            txtDescripcion.Text = "En esta asignatura se aprenden los conceptos fundamentales sobre Configuración de redes locales.
 Se imparte el temario de Cisco correspondiente a los módulos CCNA 1 y 2.
 El alumno al finalizar la asignatura será capaz de configurar redes de pequeñas y medianas empresas."
        End If
    End Sub
End Class