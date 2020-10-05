Module Ejercicio6

    Sub Main()
        'Calcular suma , resta y multiplicación
        Dim num1, num2, suma, resta, multiplicacion As Integer
        Dim division As Single

        'Inicializar num1, num2
        num1 = 3
        num2 = 9

        suma = num1 + num2
        resta = num1 - num2
        multiplicacion = num1 * num2
        division = Convert.ToSingle(num1 / num2)

        'Salida del programa:
        Console.WriteLine("La suma es : " & suma)
        Console.WriteLine("La resta es : " & resta)
        Console.WriteLine("La multiplicacion es : " & multiplicacion)
        Console.WriteLine("La division es : " & division)

        Console.ReadLine()








    End Sub

End Module
