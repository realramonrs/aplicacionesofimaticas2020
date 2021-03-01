Option Strict On
Module Module1

    Sub Main()
        'Obtener el número de caracteres dígitos de un string
        Dim cadena As String = "Hola 3456 me gusta programar 10"
        Dim contador As Integer = 0
        For i As Integer = 0 To cadena.Length - 1 Step 1
            If Char.IsDigit(cadena(i)) Then
                contador += 1
            End If
        Next
        'Obtener cuantas palabras de un String contienen el caracter *
        Dim frase As String = "pep*gmail nada *hotmail"
        Dim caracter As Char = "*"c
        Dim palabras() As String = frase.Split(" "c)
        Dim contador2 As Integer = 0
        For Each p As String In palabras
            If p.Contains("*") Then
                contador2 += 1
            End If
        Next
        'Obtener la posición del primer caracter espacio en un String
        Dim pos As Integer = frase.IndexOf(" "c)
        Console.WriteLine("Posicion primer espacio: " & pos)

        'A partir de un String con la estructura: codigo?Direccion?Precio*superficie
        'Obtener el precio y la superficie
        'Por ejemplo: 1234?Calle Salceda 34?90000*220


        Dim cadena2 As String = "1234?Calle Salceda 34?90000*220"
        Dim posInterrogacion As Integer = cadena2.LastIndexOf("?")
        Dim posAsterisco As Integer = cadena2.IndexOf("*")
        Dim caracteres As Integer = posAsterisco - posInterrogacion - 1

        Dim precio As String = cadena2.Substring(posInterrogacion + 1, posAsterisco - posInterrogacion - 1)
        Console.WriteLine(precio)
        Console.ReadLine()


    End Sub

End Module
