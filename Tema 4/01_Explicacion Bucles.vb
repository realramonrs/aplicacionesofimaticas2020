Option Strict On

Module Module1

    Sub Main()
        'Mostrar por pantalla los 100 primeros números pares
        Console.WriteLine("2 4 6 8 10 12 14 16 18 20 22 24 26 ...")

        'Variable que controla el bucle
        Dim i As Integer = 2

        While i <= 100
            Console.Write(i & " ")
            i += 2
        End While
        Console.WriteLine()
        Console.WriteLine("Impares hasta 200")

        Dim j As Integer = 1

        While j <= 200
            Console.Write(j & " ")
            j += 2
        End While

        'Programa que muestra todos los números entre 10 y 55
        Dim pepe As Integer = 10

        While pepe <= 55
            Console.Write(pepe & " ")

            pepe += 1
        End While







        'Mostrar por pantalla los números múltiplos de 3 y 7 que hay entre el número
        '1200 y un valor n introducido por el usuario.

        Console.WriteLine()
        Console.WriteLine(" Ejercicio multiplos de 3 y de 7")
        Dim machete As Integer = 1200
        Dim n As Integer = 1900

        While machete <= n
            If machete Mod 3 = 0 And machete Mod 7 = 0 Then
                Console.Write(machete & " ")
            End If

            machete += 1
        End While









        Console.ReadLine()



    End Sub

End Module
