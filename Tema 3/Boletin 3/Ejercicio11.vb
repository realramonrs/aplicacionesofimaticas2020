Module Ejercicio11
    Sub Main()
        Dim numero As Integer

        Console.WriteLine("introduzca un valor: ")
        numero = Convert.ToInt32(Console.ReadLine())

        If numero Mod 2 = 0 Or numero Mod 3 = 0 Then
            Console.WriteLine("Ojo , el número es múltiplo de o de 3")

        End If

        Console.ReadLine()
    End Sub
End Module
