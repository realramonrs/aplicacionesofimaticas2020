Imports System.IO
Public Class ProyectoSencillo
    Dim canciones As List(Of String) = New List(Of String)()
    Dim ruta As String = Directory.GetCurrentDirectory() + "\cancionesBuenas.txt"
    Private Sub ProyectoSencillo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Volcar info a la lista
        MessageBox.Show("Hola")
        If File.Exists(ruta) Then
            Dim lector As StreamReader = New StreamReader(ruta)

            While Not lector.EndOfStream
                canciones.Add(lector.ReadLine())
            End While
            lector.Close()
        End If

        'Volcar las canciones al listbox
        For Each cancion As String In canciones
            ListBox1.Items.Add(cancion.Split("*"c)(0))

        Next





    End Sub

    Private Sub btnGuardarCancion_Click(sender As Object, e As EventArgs) Handles btnGuardarCancion.Click
        'recoge valores de las cajas de texto
        Dim titulo As String = txtTitulo.Text
        Dim grupo As String = txtGrupo.Text
        Dim anho As String = txtAnho.Text
        Dim tituloOk, grupoOk, anhoOk, registroOk As Boolean

        'Validar
        If titulo = "" Then
            tituloOk = False
            txtTitulo.BackColor = Color.CadetBlue
            txtTitulo.Focus()
        ElseIf grupo = "" Then
            grupoOk = False
            txtGrupo.BackColor = Color.CadetBlue
            txtTitulo.BackColor = Color.White
            txtGrupo.Focus()
        ElseIf anho = "" Then
            anhoOk = False
            txtAnho.BackColor = Color.CadetBlue
            txtTitulo.BackColor = Color.White
            txtAnho.Focus()
        Else
            'añadir la canción a la lista
            Dim registro As String = titulo + "*" + grupo + "*" + anho
            canciones.Add(registro)
            MessageBox.Show("Canción registrada provisionalmente!")
            actualizarInfoListBox()

            ''Añadir al fichero
            'Dim escritor As StreamWriter = New StreamWriter(ruta, True)
            'escritor.WriteLine(registro)
            'escritor.Close()
        End If
    End Sub

    Private Sub txtConfirmarCambios_Click(sender As Object, e As EventArgs) Handles txtConfirmarCambios.Click
        Dim escritor As StreamWriter = New StreamWriter(ruta, False)

        For Each cancion As String In canciones
            escritor.WriteLine(cancion)
        Next
        escritor.Close()
    End Sub

    Private Sub btnBuscarCancion_Click(sender As Object, e As EventArgs) Handles btnBuscarCancion.Click
        'Recoger titulo canción
        Dim titulo As String = txtBuscarTitulo.Text
        Dim encontrado As Boolean = False
        If titulo = "" Then
            MessageBox.Show("Debe introducir un título")
            txtBuscarTitulo.Focus()
        Else
            'Busco titulo en la lista

            For Each cancion As String In canciones
                Dim trozos() As String = cancion.Split("*"c)

                If trozos(0) = titulo Then
                    txtBuscarAutor.Text = trozos(1)
                    txtBuscarAnho.Text = trozos(2)
                    encontrado = True
                End If
            Next

            If Not encontrado Then
                MessageBox.Show("Canción no registrada en bbdd")
            End If
        End If
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim titulo As String = txtEliminarCancion.Text

        If titulo = "" Then

        Else
            'Buscar canción en la lista y elimnarla
            For Each cancion As String In canciones
                Dim trozos() As String = cancion.Split("*"c)
                If trozos(0) = titulo Then
                    'Eliminar cancion
                    canciones.Remove(cancion)
                    actualizarInfoListBox()
                    Exit For
                End If
            Next
        End If
    End Sub


    Private Sub actualizarInfoListBox()
        ListBox1.Items.Clear()

        For Each cancion As String In canciones
            ListBox1.Items.Add(cancion.Split("*"c)(0))
        Next
    End Sub
End Class