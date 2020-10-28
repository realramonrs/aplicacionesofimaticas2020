Module Ejercicio6
    Sub Main()
        Dim n1, n2, n3, media As Double

        'Solicitar las 3 notas al usuario
        Console.WriteLine("Introduzca la primera nota:")
        n1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca la segunda nota:")
        n2 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca la tercera nota:")
        n3 = Convert.ToDouble(Console.ReadLine())

        'Calculamos la media

        media = (n1 + n2 + n3) / 3

        'Evaluamos si está aprobado o no

        If media >= 5 Then
            Console.WriteLine("El alumno está aprobado")
        Else
            Console.WriteLine("El alumno está suspenso")
        End If

        'Mantenemos la consola abierta hasta que el usuario pulse enter
        Console.ReadLine()

    End Sub
End Module
