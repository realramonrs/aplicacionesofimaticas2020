Option Strict On
Imports System.IO
Module Ejercicio11
    Sub Main()
        Dim ruta As String = Directory.GetCurrentDirectory()
        Dim nombreFichero As String = "ejemplo.txt"

        Dim contenido As String = leerFichero(ruta, nombreFichero)
        If contenido = "" Then
            Console.WriteLine("Error en el acceso al fichero")
        Else
            Console.WriteLine(contenido)
        End If

        Console.ReadLine()
    End Sub
End Module
