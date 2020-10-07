Option Strict On
Module Module1

    Sub Main()
        'Librería Math--> Contiene funciones matemáticas
        '1. Función pow(base,exponente)
        Dim base As Short = 10
        Dim exponente As Byte = 5
        'Quiero calcular 10 elevado a 5
        Dim resultado As Integer = Convert.ToInt32(Math.Pow(base, exponente))
        Dim resultado2 As Integer = Convert.ToInt32(base ^ exponente)

        Console.WriteLine(base & " elvado a " & exponente & " = " & resultado)
        Console.WriteLine(base & " elvado a " & exponente & " = " & resultado2)

        '2. Math.sqrt(numero)--> Devuelve la raíz cuadrada
        Dim numero As Integer = 3
        Dim raiz As Double = Math.Sqrt(numero)

        Console.WriteLine("Raiz de " & numero & " = " & raiz)

        '3.Funciones de redondeo:
        'Math.floor(valor)--> Devuelve el entero inferior más cercano
        Dim raizFloor As Integer = Convert.ToInt32(Math.Floor(raiz))
        Console.WriteLine(raiz & " con Math.floor = " & raizFloor)

        'Math.ceil(valor)--> Devuelve el entero superior más cercano
        Dim raizCeil As Integer = Convert.ToInt32(Math.Ceiling(raiz))
        Console.WriteLine(raiz & " con Math.ceiling = " & raizCeil)

        'Math.round(valor)-->Devuelve el entero más cercano
        Dim raizRound As Integer = Convert.ToInt32(Math.Round(raiz))
        Console.WriteLine(raiz & " con Math.round = " & raizRound)

        'Math.round(valor,numeroDecimales)--> Ajusta el valor al número de decimales indicado
        Dim raiz2Decimales As Double = Math.Round(raiz, 2)
        Console.WriteLine(raiz & " con 2 decimales = " & raiz2Decimales)

        'Si quisiera modificar la variable original:
        raiz = Math.Round(raiz, 2)
        Console.WriteLine("Raiz con 2 decimales: " & raiz)

        Console.ReadLine()







    End Sub

End Module
