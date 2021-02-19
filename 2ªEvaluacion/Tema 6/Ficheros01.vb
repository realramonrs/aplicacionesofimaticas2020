Option Strict On
Imports System.IO
Module Ejemplo2
    Sub Main()
        Dim ruta As String = Directory.GetCurrentDirectory()
        ruta += "\datos2.txt"

        Console.WriteLine("Introduce nombre cancion")
        Dim cancion As String = Console.ReadLine()
        Console.WriteLine("Introduce nombre grupo: ")
        Dim cantante As String = Console.ReadLine()
        Console.WriteLine("Introduce año de la canción")
        Dim anho As Integer = Convert.ToInt32(Console.ReadLine())

        Dim registro As String = cancion + "*" + cantante + "*" + anho.ToString()

        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        escritor.WriteLine(registro)

        escritor.Close()

        'Listado de canciones guardadas
        Console.WriteLine("Introduce nombre del grupo:")
        Dim grupo As String = Console.ReadLine()

        Dim lector As StreamReader = New StreamReader(ruta)

        While Not lector.EndOfStream
            Dim registro2 As String = lector.ReadLine()
            Console.WriteLine(registro2)
        End While

        Console.ReadLine()
    End Sub
End Module
