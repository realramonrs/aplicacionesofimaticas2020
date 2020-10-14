Option Strict On
Module Module1

    Sub Main()
        Dim x As Integer = 8
        Dim resultado As Decimal = Convert.ToDecimal(x / 4)
        Dim caracter As Char = Convert.ToChar("w")
        Dim caracter2 As Char = " "c

        Dim n As Byte = Convert.ToByte(x)

        'Programa que resuelve ec de 2º grado

        'ax2 +bx + c = 0

        Dim a, b, c As Integer
        Dim xy As Double
        a = 1
        b = 2
        c = 4

        'xy = Math.sqrt(c3 -b2)/(a5 + c9)

        xy = Math.Sqrt(c ^ 3 - b ^ 2) / (Math.Pow(a, 5) + Math.Pow(c, 9))
        xy = 0.1234456
        Dim xy4 As Double = Math.Round(xy)
        Console.WriteLine(Math.Round(xy, 4))
        Console.ReadLine()





























    End Sub

End Module
