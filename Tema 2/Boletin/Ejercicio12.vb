Module Ejercicio12
    Sub Main()
        Dim lado, perimetro, diagonal, area As Double

        Console.WriteLine("Introduzca el lado : ")
        lado = Convert.ToDouble(Console.ReadLine())

        perimetro = 4 * lado
        diagonal = lado * Math.Sqrt(2)
        area = Math.Pow(lado, 2)

        'diagonal = Math.Round(diagonal, 2)

        Console.WriteLine("Perímetro: " & perimetro)
        Console.WriteLine("Dialgonal : " & Math.Round(diagonal, 2))
        Console.WriteLine("Area: " & area)
        Console.ReadLine()


    End Sub
End Module
