Option Strict On
Imports System.IO
Module Module1

    Sub Main()
        Dim ruta As String = Directory.GetCurrentDirectory()
        ruta += "\datos.txt"
        Console.WriteLine("Directorio de trabajo: ")
        Console.WriteLine(ruta)
        'Escribir datos en un fichero
        Dim escritor As StreamWriter = New StreamWriter(ruta, True)
        escritor.WriteLine("Información para guardar en el fichero")
        escritor.Close()

        'Recuperar información de un fichero:
        Dim lector As StreamReader = New StreamReader(ruta)

        'Leerlo todo de un golpe y guardarlo en un String
        Dim contenido As String = lector.ReadToEnd()
        lector.Close()

        Console.WriteLine("Contenido del fichero: ")
        Console.WriteLine(contenido)






        Console.ReadLine()
    End Sub

End Module
