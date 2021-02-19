Module Ejercicio3
    Sub Main()
        Dim frase As String
        Console.WriteLine("Introduce una frase:")
        frase = Console.ReadLine()

        Dim inicio As String
        Console.WriteLine("Indica el string por el que deben empezar las palabras que quieres buscar")
        inicio = Console.ReadLine()

        buscarPalabrasqueEmpiecenPor(frase, inicio)


        'Dim palabras() As String = frase.Split(" "c)

        'For Each p As String In palabras
        '    If p.StartsWith("b") Or p.StartsWith("B") Then
        '        Console.WriteLine(p)
        '    End If
        'Next

        Dim david As Integer = 0
        sumaSub10(david)
        david = sumarfunction10(david)

        Console.WriteLine("David = " & david)
        Console.ReadLine()
    End Sub
End Module
