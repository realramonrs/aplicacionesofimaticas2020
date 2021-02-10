Option Strict On
Module Module1


    Sub suma2(ByRef numero As Integer)
        numero += 2
    End Sub
    Sub Main()
        Dim x(99) As Integer
        llenarMatriz(x)
        mostrarMatriz(x)

        Dim suma As Integer = sumarMatriz(x)

        'Buscar la posicion de un valor en una matriz
        Dim valor As Integer = 4
        Dim pos As Integer = buscarValor(x, valor)

        Dim cadena As String = "Me gusta programar"

        Dim vocales As Integer = contarVocales(cadena)

        'Entender diferencia entre ByVal y Byref

        Dim n As Integer = 10
        suma2(n)
        Console.WriteLine("n = " & n)
        Console.ReadLine()

    End Sub

End Module
