Module Ejercicio8
    Sub Main()
        Dim presion, temperatura, n, volumen As Double
        Const R As Double = 0.082

        'Solicitar datos
        Console.WriteLine("Introduzca la temperatura en Kelvin")
        temperatura = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca el volumen en litros")
        volumen = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca número de moles:")
        n = Convert.ToDouble(Console.ReadLine())

        'pv = nrt

        presion = (n * R * temperatura) / volumen

        'Mostrar por pantalla el resultado
        Console.WriteLine("Con un volumen de " & volumen & " litros 
            y a una temperatura de " & temperatura & " grados kelvin ," & n &
             " moles de un gas están a " & presion & " atmósferas")

        Console.ReadLine()









    End Sub
End Module
