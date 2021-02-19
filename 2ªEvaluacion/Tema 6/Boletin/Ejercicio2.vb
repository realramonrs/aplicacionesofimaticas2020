Option Strict On
Module Ejercicio2
    Sub Main()

        Dim dni As String
        Dim estructuraOk As Boolean = True
        Console.WriteLine("Introduzca el dni: ")
        dni = Console.ReadLine()


        If dni.Length <> 9 Then
            estructuraOk = False
            Console.WriteLine("No tiene la estructura correcta.")
        Else
            For i As Integer = 0 To dni.Length - 2 Step 1
                If Not Char.IsDigit(dni(i)) Then
                    estructuraOk = False
                    Console.WriteLine("Hay un caracter no numérico en las 8 primeras posicione")
                    Exit For
                End If
            Next

            'Validar si el último caracter es una letra
            If Not Char.IsLetter(dni(dni.Length - 1)) Then
                estructuraOk = False
                Console.WriteLine("El último caracter debe de ser una letra")
            End If

        End If

        If estructuraOk = True Then
            Dim letras() As Char = {"T"c, "R"c, "W"c, "A"c, "G"c, "M"c, "Y"c, "F"c, "P"c, "D"c, "X"c, "B"c, "N"c, "J"c, "Z"c, "S"c, "Q"c, "V"c, "H"c, "L"c, "C"c, "K"c, "E"c}
            'Obtener el número del dni
            Dim numeroDNI As String = dni.Substring(0, 8)
            Dim numeroDNIInteger As Integer = Convert.ToInt32(numeroDNI)

            Dim resto As Integer = numeroDNIInteger Mod 23

            dni = dni.ToUpper()

            If dni(dni.Length - 1) = letras(resto) Then
                Console.WriteLine("DNI correcto")
            Else
                Console.WriteLine("La letra de su dni es errónea")
            End If
        End If

        Console.ReadLine()
    End Sub
End Module
