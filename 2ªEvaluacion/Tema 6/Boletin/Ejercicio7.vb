Module Ejercicio7
    Sub Main()
        'Validar formato AA99
        Dim codigo As String
        Console.WriteLine("Introduzca el código:")
        codigo = Console.ReadLine()


        'If Not Char.IsLetter(codigo(0)) Or Not Char.IsLetter(codigo(1)) Or Not Char.IsDigit(codigo(2)) Or Not Char.IsDigit(codigo(3)) Then
        '    Console.WriteLine("Código erróneo")
        'Else
        '    Console.WriteLine("Código coorecto")
        'End If

        If validarCodigo(codigo) Then
            Console.WriteLine("Código erróneo")
        Else
            Console.WriteLine("Código correcto")
        End If
        Console.ReadLine()
    End Sub
End Module
