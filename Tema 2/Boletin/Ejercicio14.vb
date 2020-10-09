Module Ejercicio14
    Sub Main()
        Dim precioInicial, porcentaje, cantidadRebajada, precioFinal As Double

        Console.WriteLine("Introduzca el precio inicial: ")
        precioInicial = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Introduzca porcentaje de descuento: ")
        porcentaje = Convert.ToInt32(Console.ReadLine())

        cantidadRebajada = precioInicial * (porcentaje / 100)
        precioFinal = precioInicial - cantidadRebajada

        Console.WriteLine("El precio final es de : " & precioFinal)
        Console.WriteLine("Se ahorra " & cantidadRebajada & " euros.")
        Console.ReadLine()

    End Sub
End Module
