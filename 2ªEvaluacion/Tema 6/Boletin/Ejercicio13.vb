Option Strict On
Imports System.IO
Module Ejercicio13
    Sub Main()

        Dim ruta As String = Directory.GetCurrentDirectory()
        Dim nombreFichero As String = ruta + "\ejercicio13.txt"

        'nombre*edad

        Console.WriteLine("Introduzca el nombre:")
        Dim nombre As String = Console.ReadLine()
        Console.WriteLine("Introduzca la edad: ")
        Dim edad As Integer = Convert.ToInt32(Console.ReadLine())

        Dim registro As String = nombre + "*" + edad.ToString()

        Dim escritor As StreamWriter = New StreamWriter(nombreFichero, True)
        escritor.WriteLine(registro)
        escritor.Close()

        'Recuperar todos los registros y guardarlos en una matriz de strings
        Dim registros(99) As String
        Dim lector As StreamReader = New StreamReader(nombreFichero)
        Dim posicion As Integer = 0
        While Not lector.EndOfStream
            registros(posicion) = lector.ReadLine()
            posicion += 1
        End While
        lector.Close()
        Console.WriteLine()
        Console.WriteLine("Registros guardados en la matriz")
        'Mostrar registros de la matriz:
        For Each reg As String In registros
            If reg IsNot Nothing Then
                Console.WriteLine(reg)
            Else
                Exit For
            End If

        Next

        'Supongamos que la matriz se modifica
        registros(0) = "Saul*90"

        'Actualizar el fichero: Debemos volcar todos los registros de la matriz al fichero
        Dim escritorReset As StreamWriter = New StreamWriter(nombreFichero, False)

        'Recorrer el array e ir escribiendo cada posición del array en el fichero

        For Each pepe As String In registros
            If Not pepe Is Nothing Then
                escritorReset.WriteLine(pepe)
            End If

        Next

        escritorReset.Close()







        Console.ReadLine()
    End Sub
End Module
