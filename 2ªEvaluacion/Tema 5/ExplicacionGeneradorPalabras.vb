Option Strict On
Module ExplicacionGeneradorPalabras
    Sub Main()

        Dim letra As Char = "ñ"c
        Dim codigoLetra As Integer = Convert.ToInt32(letra)
        Dim letraZ As Char = "z"c

        Console.WriteLine("Código Ascii de a: " & codigoLetra)
        Console.WriteLine("Código Ascii de a: " & Convert.ToInt32(letraZ))

        Dim cadena As String = "hola"

        For i As Integer = 0 To cadena.Length - 1 Step 1
            Console.WriteLine(cadena(i) & " : " & Convert.ToInt32(cadena(i)))
        Next
        Console.WriteLine("Abecedario: ")
        For i As Integer = 97 To 122 Step 1
            Console.Write(Convert.ToChar(i) & " ")
        Next






        Console.ReadLine()
    End Sub
End Module
