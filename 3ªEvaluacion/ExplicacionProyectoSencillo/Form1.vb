Imports System.IO
Public Class Form1
    Dim coches As List(Of String) = New List(Of String)()
    Dim ruta As String = Directory.GetCurrentDirectory() + "\coches.txt"
    Private Sub btnGuardarCoche_Click(sender As Object, e As EventArgs) Handles btnGuardarCoche.Click
        Dim matricula As String = txtMatricula.Text
        Dim modelo As String = txtModelo.Text

        Dim registro As String = matricula + "*" + modelo
        coches.Add(registro)

        actualizarListBox()
        'Volcar al fichero 
        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        escritor.WriteLine(registro)
        escritor.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(ruta) Then

            Dim lector As StreamReader = New StreamReader(ruta)

            While Not lector.EndOfStream
                coches.Add(lector.ReadLine())
            End While

            lector.Close()
        End If
        actualizarListBox()
    End Sub


    Private Sub actualizarListBox()
        ListBox1.Items.Clear()

        For Each coche As String In coches
            ListBox1.Items.Add(coche)
        Next
    End Sub

    Private Sub btnBuscarMatricula_Click(sender As Object, e As EventArgs) Handles btnBuscarMatricula.Click
        Dim matricula As String = txtBuscarMatricula.Text
        Dim encontrado As Boolean = False
        For Each coche As String In coches
            Dim trozos() As String = coche.Split("*"c)
            If trozos(0) = matricula Then
                MessageBox.Show(coche)
                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            MessageBox.Show("Coche no registrado")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fecha As String = DateTimePicker1.Value.ToShortDateString()
        MessageBox.Show(fecha)
    End Sub
End Class
