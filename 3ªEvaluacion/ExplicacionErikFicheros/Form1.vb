Imports System.IO
Public Class Form1
    Public ordenadores As List(Of Ordenador) = New List(Of Ordenador)()
    Public ruta As String = Directory.GetCurrentDirectory() + "\ordenadores.txt"
    Private Sub btnGuardarOIrdenador_Click(sender As Object, e As EventArgs) Handles btnGuardarOIrdenador.Click
        Dim ordenata As Ordenador = New Ordenador()
        ordenata.codigo = txtCodigo.Text
        ordenata.marca = txtMarca.Text
        ordenata.precio = Convert.ToDouble(txtPrecio.Text)

        'Escribir en un fichero
        '1. Crear StreamWriter
        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        escritor.WriteLine(ordenata.ToString())
        escritor.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Leer del fichero y volcarlo al listbox
        If File.Exists(ruta) Then
            Dim lector As StreamReader = New StreamReader(ruta)

            While Not lector.EndOfStream
                Dim registro As String = lector.ReadLine()
                Dim ordenador As Ordenador = New Ordenador()
                ordenador.codigo = registro.Split("*")(0)
                ordenador.marca = registro.Split("*")(1)
                ordenador.precio = registro.Split("*")(2)
                ordenadores.Add(ordenador)
            End While
            lector.Close()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For Each o As Ordenador In ordenadores
            If o.precio > 200 Then
                ListBox1.Items.Add(o.codigo)
            End If
        Next
    End Sub
End Class
