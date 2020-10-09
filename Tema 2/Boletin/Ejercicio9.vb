Module Ejercicio9
    Sub main()
        'Intercambiar el valor de dos variables
        Dim x, y As Integer
        'Inicializarlas
        x = 9
        y = 1

        'Intercambiarlas
        Dim auxiliar As Integer = x 'auxiliar vale 9
        x = y  'x vale 1 , y vale 1
        y = auxiliar ' y vale 9
        Console.WriteLine("x = " & x)
        Console.WriteLine("y = " & y)
        Console.ReadLine()



    End Sub
End Module
