Imports System.IO
Public Class Form1
    Public ruta As String = Directory.GetCurrentDirectory() + "\alumnos.txt"
    Public alumnos As List(Of Alumno) = New List(Of Alumno)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(ruta) Then
            Dim lector As StreamReader = New StreamReader(ruta)
            While Not lector.EndOfStream
                'Crear un alumno y añadirlo a la lista
                Dim a1 As Alumno = New Alumno()
                Dim registro As String = lector.ReadLine()
                a1.dni = registro.Split("*"c)(0)
                a1.nombre = registro.Split("*"c)(1)
                a1.notaMedia = Convert.ToDouble(registro.Split("*"c)(2))

                alumnos.Add(a1)
            End While
            lector.Close()
        End If
    End Sub

    Private Sub btnAddAlumno_Click(sender As Object, e As EventArgs) Handles btnAddAlumno.Click
        'Crear alumno con los datos introducidos por el usuario 
        Dim a1 As Alumno = New Alumno()
        ' Dim a2 As New Alumno

        a1.dni = txtDNI.Text
        a1.nombre = txtNombre.Text
        a1.notaMedia = Convert.ToDouble(txtNotaMedia.Text)

        alumnos.Add(a1)

        'Lo añado al fichero
        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        escritor.WriteLine(a1.ToString())
        escritor.Close()

    End Sub

    Private Sub btnVerAlumnosGuardados_Click(sender As Object, e As EventArgs) Handles btnVerAlumnosGuardados.Click
        ListBox1.Items.Clear()

        'Recorrer la lista y volcar los dnis

        For Each a As Alumno In alumnos
            ListBox1.Items.Add(a.dni)
        Next



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim dni As String = ListBox1.SelectedItem.ToString

        For Each a As Alumno In alumnos
            If a.dni = dni Then
                MessageBox.Show(a.nombre + " " + a.notaMedia.ToString())
                Exit For
            End If
        Next
    End Sub
End Class
