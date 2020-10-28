Module Ejercicio12
    Sub Main()
        Dim precio, rebaja As Double

        Console.WriteLine("Introduzca el precio: ")
        precio = Convert.ToInt32(Console.ReadLine())

        If precio < 100 Then
            rebaja = precio * 0.1
            precio = precio - rebaja
        Else
            rebaja = precio * 0.15
            precio = precio - rebaja
        End If
        Console.WriteLine("El precio rebajado queda en : " & precio)
        Console.ReadLine()
    End Sub
End Module
