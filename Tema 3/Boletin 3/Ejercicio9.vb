Module Ejercicio9
    Sub Main()
        Dim n1, n2, menor, mayor As Integer
        Dim potencia As Long 'Declaramos tipo Long porque las potencias pueden dispararse muy rápido a valores muy altos

        'Solicitar los dos números al usuario
        Console.WriteLine("Introduzca el primer número:")
        n1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca el segundo número:")
        n2 = Convert.ToInt32(Console.ReadLine())

        'Comprobamos cuál es el más pequeño y calculamos la potencia

        If n1 < n2 Then
            potencia = Convert.ToInt32(Math.Pow(n2, n1))
            ' Console.WriteLine(n2 & " elevado a " & n1 & " = " & potencia)
            menor = n1
            mayor = n2
        Else
            potencia = Convert.ToInt32(Math.Pow(n1, n2))
            '  Console.WriteLine(n1 & " elevado a " & n2 & " = " & potencia)
            menor = n2
            mayor = n1
        End If
        Console.WriteLine(mayor & " elevado a " & menor & " = " & potencia)

        Console.ReadLine()
    End Sub
End Module
