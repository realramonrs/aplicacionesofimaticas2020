Option Strict On
Module Module1

    Function contarCaracteres(ByRef pepe As String, ByVal car As Char) As Integer
        Dim contador As Integer = 0

        For i As Integer = 0 To pepe.Length - 1 Step 1
            If pepe(i) = car Then
                contador += 1
            End If
        Next
        Return contador
    End Function

    Sub Main()
        'Ejercicio 1:
        Dim cadena As String = "Me gusta mucho programar"
        Dim caracter As Char
        Console.WriteLine("Que caracter quieres buscar: ")
        caracter = Convert.ToChar(Console.ReadLine())

        Dim contador As Integer = contarCaracteres(cadena, caracter)

        'For i As Integer = 0 To cadena.Length - 1 Step 1
        '    If cadena(i) = caracter Then
        '        contador += 1
        '    End If
        'Next

        If contador = 0 Then
            Console.WriteLine("No está el caracter en el string")
        Else
            Console.WriteLine(caracter & " áparece " & contador & " veces.")
        End If


        Console.ReadLine()



    End Sub

End Module
