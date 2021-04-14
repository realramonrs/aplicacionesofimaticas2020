Public Class FormConListaAfichero

    Dim listaUsuarios As List(Of String) = New List(Of String)()

    Private Sub btnGuardarRegistro_Click(sender As Object, e As EventArgs) Handles btnGuardarRegistro.Click
        Dim usuario As String = txtUsuario.Text
        Dim password As String = txtPassword.Text

        Dim registro As String = usuario + "*" + password
        'Volcarlo a la lista
        listaUsuarios.Add(registro)
    End Sub

    Private Sub btnBuscarusuario_Click(sender As Object, e As EventArgs) Handles btnBuscarusuario.Click
        Dim usuario As String = txtUsuario.Text
        Dim password As String = txtPassword.Text

        'Buscar al usuario y comprobar que el password es correcto
        'Registros --> usuario*password

        For Each registro As String In listaUsuarios
            'Buscar al usuario
            Dim trozos() As String = registro.Split("*"c)
            If trozos(0) = usuario Then
                If trozos(1) = password Then
                    MessageBox.Show("Usuario es correcto")
                Else
                    MessageBox.Show("Password Incorrecto")
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub btnContarusuarios_Click(sender As Object, e As EventArgs) Handles btnContarusuarios.Click
        'Vuelca todos los registros al listbox

        For Each registro As String In listaUsuarios
            ListBox1.Items.Add(registro)

        Next
    End Sub
End Class