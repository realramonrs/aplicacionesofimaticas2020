Module SentenciasSeleccion2
    Sub Main()

        'Programa que clasifica un número como mayor o menor que 100 y múltiplo de 7
        'numero > 100 y múltiplo de 7
        'numero que no cumple alguna de las condiciones anteriores

        Dim numero As Integer = 49

        Dim condicion As Boolean = numero > 100 And numero Mod 7 = 0

        'If condicion = True Then
        '    Console.WriteLine("Número múltiplo de 7 y superior a 100")
        'Else
        '    Console.WriteLine("El número o no es > 100 o no es múltiplo de 7")
        'End If


        If numero > 100 Then
            If numero Mod 7 = 0 Then
                Console.WriteLine("Número múltiplo de 7 y superior a 100")
            Else
                Console.WriteLine("Numero > 100 pero no es múltiplo de 7")
            End If
        Else
            If numero Mod 7 = 0 Then
                Console.WriteLine("Numero < 100 pero múltiplo de 7")
            Else
                Console.WriteLine("Numero < 100 y no es múltiplo de 7")
            End If
        End If

        Console.ReadLine()

        '
    End Sub
End Module
