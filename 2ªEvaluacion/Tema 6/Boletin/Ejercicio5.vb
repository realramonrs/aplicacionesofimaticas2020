Option Strict On
Module Ejercicio5
    Sub Main()
        Dim frase As String
        Console.WriteLine("Introduce una frase y te digo cuantas palabras contiene aba")
        frase = Console.ReadLine()
        Console.WriteLine("Indique lo que quiere buscar:")
        Dim subCadena As String = Console.ReadLine()

        'Dim palabras() As String = frase.Split(" "c)
        'Dim contadorAbas As Integer


        'For Each p As String In palabras
        '    If p.Contains("aba") Then
        '        contadorAbas += 1
        '    End If
        'Next

        Dim contadorCoincidencias As Integer = contarPalabras(frase, subCadena)


        Console.WriteLine("Hay " & contadorCoincidencias & " palabras con " & subCadena)
        Console.ReadLine()
    End Sub
End Module
