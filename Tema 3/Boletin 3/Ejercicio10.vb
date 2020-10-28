Module Ejercicio10
    Sub Main()
        Dim temperatura, presion As Double
        Dim presionOk, temperaturaOk As Boolean
        Console.WriteLine("Introduce temperatura del núcleo:")
        temperatura = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduce presion del núcleo:")
        presion = Convert.ToDouble(Console.ReadLine())

        presionOk = False
        temperaturaOk = False
        'Evaluamos si la presion > 2
        If presion > 2 Then
            Console.WriteLine("Abrir válvula de seguridad")
        Else
            presionOk = True
        End If

        'Evaluamos si la temperatura > 500k

        If temperatura > 500 Then
            Console.WriteLine("Reducir la temperatura del núcleo")
        Else
            temperaturaOk = True
        End If

        If presionOk And temperaturaOk Then
            Console.WriteLine("Todo en orden")
        End If


        'Mantenemos consola abierta
        Console.ReadLine()

    End Sub
End Module
