Option Strict On
Module Module1

    Sub Main()
        'Programa que detecta el primer divisor distinto de 1 de un número 
        Dim m As Integer = 132

        For j As Integer = 2 To m - 1 Step 1
            If m Mod j = 0 Then
                Console.WriteLine("Divisor detectado: " & j)
                Exit For
            End If

        Next

        Console.ReadLine()

    End Sub

End Module
