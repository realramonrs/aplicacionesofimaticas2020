Module Ejercicio4
    Sub Main()
        Dim radio, longitud, area, volumen As Double
        Const PI As Double = 3.14151628

        'Solicitar radio por teclado
        Console.WriteLine("Introduzca el valor del radio:")
        radio = Convert.ToDouble(Console.ReadLine())

        longitud = 2 * PI * radio
        area = PI * radio * radio
        volumen = (4 / 3) * PI * radio ^ 3

        'Generar la salida del programa
        Console.WriteLine("El area es: " & area)
        Console.WriteLine("La longitud es: " & longitud)
        Console.WriteLine("El volumen es: " & volumen)

        Console.ReadLine()
    End Sub
End Module
