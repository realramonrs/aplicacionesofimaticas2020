Option Strict On
Module Module1

    Sub Main()
        'Programa que lee un número y me dice cuántas digitos tiene , hasta un máximo de 6 digitos

        Dim numero As Integer
        Dim digitos As Byte
        Dim digitosOk As Boolean = True
        Console.WriteLine("Introduce un número: ")
        numero = Convert.ToInt32(Console.ReadLine())
        digitos = 0
        If numero < 10 And numero > -10 Then
            digitos = 1
            ' Console.WriteLine(numero & " tiene " & digitos & " digitos")
        ElseIf numero < 100 And numero > -100 Then
            digitos = 2
            '  Console.WriteLine(numero & " tiene " & digitos & " digitos")
        ElseIf numero < 1000 And numero > -1000 Then
            digitos = 3
            ' Console.WriteLine(numero & " tiene " & digitos & " digitos")
        ElseIf numero < 10000 And numero > -10000 Then
            digitos = 4
            '  Console.WriteLine(numero & " tiene " & digitos & " digitos")
        ElseIf numero < 100000 And numero > -100000 Then
            digitos = 5
            ' Console.WriteLine(numero & " tiene " & digitos & " digitos")
        ElseIf numero < 1000000 And numero > -100000 Then
            digitos = 6
            'Console.WriteLine(numero & " tiene " & digitos & " digitos")
        Else
            Console.WriteLine("No se ha podido calcular el número de digitos")
            digitosOk = False
        End If
        'If digitos <> 0 Then
        '    Console.WriteLine(numero & " tiene " & digitos & " digitos")
        'End If

        'Segunda opción para detectar si ha entrado en el else
        If digitosOk = True Then
            Console.WriteLine(numero & " tiene " & digitos & " digitos")
        End If

        Console.ReadLine()
    End Sub

End Module
