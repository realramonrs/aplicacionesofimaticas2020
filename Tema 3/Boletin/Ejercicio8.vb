Module Ejercicio8
    Sub Main()
        Dim password1, password2 As String
        Dim loginOk As Boolean

        Console.WriteLine("Introduzca su password:")
        password1 = Console.ReadLine()

        Console.WriteLine("Repita su password:")
        password2 = Console.ReadLine()

        'Almacenamos en la variable loginOk el resultado de comparar
        'ambas contraseñas para saber si el usuario se ha logueado bien o no

        loginOk = password1 = password2


        'Si loginOk es true informamos que se ha logueado de forma correcta
        If password1 = password2 Then
            Console.WriteLine("Contraseña correcta! Estás dentro.")
        Else
            Console.WriteLine("La contraseña es errónea.")
        End If

        'Mantenemos consola abierta hasta que pulse enter
        Console.ReadLine()

    End Sub
End Module
