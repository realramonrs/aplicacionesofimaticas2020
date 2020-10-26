Module Ejercicio7
    Sub Main()
        'Zona declaración de variables
        Dim n1, n2 As Double
        Dim suma, raiz As Double

        Console.WriteLine("Introduzca la primera nota:")
        n1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca la segunda nota:")
        n2 = Convert.ToDouble(Console.ReadLine())

        'Sumamos n1 y n2
        suma = n1 + n2

        'Evaluamos si la suma es > 0 para poder calcular la raiz

        If suma > 0 Then
            raiz = Math.Sqrt(suma)
            Console.WriteLine("La raiz es : " & raiz)
        Else
            Console.WriteLine("No se puede calcular la raiz")

        End If
    End Sub
End Module
