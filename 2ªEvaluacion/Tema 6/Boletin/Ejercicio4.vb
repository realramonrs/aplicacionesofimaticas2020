Option Strict On
Module Ejercicio4
    Sub main()
        Dim email As String
        Console.WriteLine("Introduzca dirección de correo:")
        email = Console.ReadLine()

        'Comprobar si contiene el caracter @

        'If email.IndexOf("@") < 0 Then
        '    Console.WriteLine("No tiene caracter @")
        'Else
        '    Console.WriteLine("Tiene @")
        'End If


        'Con funcion

        If validarEmail(email) Then
            Console.WriteLine("Tiene un @")
        Else
            Console.WriteLine("No tiene un @")
        End If

        Console.WriteLine("Validación de @ con función Sub")
        'Con Sub
        validarEmail2(email)

        Console.ReadLine()
    End Sub
End Module
