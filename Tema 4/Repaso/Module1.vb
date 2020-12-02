Option Strict On
Module Module1

    Sub Main()
        'Apasionante mundo de las variables
        Dim numero As Byte = 0
        Dim nNegativo As SByte = -3  '-128 a 127
        Dim n2 As Short = 0
        Dim n3 As Integer = 0
        Dim n4 As Long = 0

        Dim n5 As Single
        Dim n6 As Double
        Dim n7 As Decimal

        Dim c As Char = "e"c
        Dim caracteres As String = "En un lugar de la Mancha"

        Dim condicion As Boolean = False

        n2 = 350
        n2 = -3

        'Operadores --> +,-*,/, Mod
        Dim x, y, resultado As Byte

        x = 40
        y = 50
        resultado = Convert.ToByte(x / y)

        Dim x2 As Integer
        Dim resultado2 As Short = Convert.ToInt16(x2 + 100)

        'Leer algo por teclado Console.ReadLine() --> String
        Dim edad As Integer
        Console.WriteLine("Introduzca la edad:")
        edad = Convert.ToInt32(Console.ReadLine())


        'Funcíones Librería Math
        Dim numeroRaiz As Double = Math.Sqrt(23)

        Dim numeroRaiz2 As Integer = Convert.ToInt32(Math.Sqrt(9))

        Dim numeroEntero As Integer = Convert.ToInt32(Math.Ceiling(Math.Sqrt(11)))

        'Redondear a un numero de decimales

        Dim numerocon2Decimales As Double = Math.Round(Math.Sqrt(11), 2)


        'Maravilloso mundo de las sentencias de selección

        'Operadores relacionales y lógicos
        '< , > <= , >= , <> , = 
        'AND, OR , 

        Dim c1 As Boolean = 4 < 8
        Dim par As Boolean = 10 Mod 2 = 0


        Dim numeroPrueba As Integer = 12


        If numeroPrueba > 10 Then
            Console.WriteLine("Mayor de 10")
        Else
            Console.WriteLine("Menor de 10")
        End If

        'raiz(a2 - c4)
        Dim a, c2 As Integer
        Dim raiz, radicando As Double
        a = 2
        c2 = 9
        raiz = Math.Sqrt(a ^ 2 - c2 ^ 4)
        'a2 - c4 > 0
        radicando = a ^ 2 - Math.Pow(c2, 4)
        If radicando > 0 Then
            raiz = Math.Sqrt(radicando)
        Else

        End If

        'Clasificar un número como negativo, menor que 10, menor que 100 , o mayor

        Dim valor As Integer

        If valor < 0 Then
            Console.WriteLine("Negativo")
        ElseIf valor > 0 And valor < 10 Then

        End If

        'Espeluznante mundo de los bucles

        Dim i As Integer = 1

        While i <= 20
            Console.Write(i & " ")
            i += 1
        End While
        Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("***** Bucle For ********")

        Dim j As Integer = 10
        For j = 10 To 100 Step 5
            Console.Write(j & " ")
        Next
        Console.ReadLine()




































        'if true Then

        ' haz esto
        'else

        'haz esto otro
        'End If





































    End Sub

End Module
