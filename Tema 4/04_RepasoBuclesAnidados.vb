Option Strict On
Module Module1

    Sub Main()
        'Algoritmo que genere 100 números aleatorios entre 1 y 20
        'Porcentaje de números pares
        Dim generador As Random = New Random()
        Dim contador As Integer = 0
        Dim porcentaje As Double = 0
        For i As Integer = 0 To 20 Step 1
            Dim numero As Integer = generador.Next(1, 10)
            If numero Mod 2 = 0 Then
                contador += 1
            End If
            'Mostrar solo aquellos valores que tengan 3 o más divisores
            Dim contadorDivisores As Integer = 2
            'Bucle desde 2 hasta n - 1
            For j As Integer = 2 To Convert.ToInt32(numero / 2) Step 1
                If numero Mod j = 0 Then
                    contadorDivisores += 1
                End If
            Next j
            If contadorDivisores >= 3 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(numero & " ")
            Else
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(numero & " ")
            End If

        Next i

        porcentaje = (contador / 50) * 100
        Console.WriteLine()
        Console.WriteLine("Hay un " & porcentaje & "% de números pares")
        Console.ReadLine()

    End Sub

End Module
