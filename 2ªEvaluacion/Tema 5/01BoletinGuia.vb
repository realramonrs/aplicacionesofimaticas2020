Option Strict On
Module Module1

    Sub Main()
        '1. declarar array {1,2,3,4,5,6,7,8,9}
        Dim x() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9}

        '2. crear array con capacidad para 20 valores de tipo Single
        Dim x2(19) As Single

        '3. crear array con capacidad para 10 valores de tipo Integer
        Dim x3(9) As Integer
        x3(0) = -4
        x3(2) = -1
        x3(5) = -3
        x3(9) = -2
        ' x3(10) = -3--< salta excepción ya que esa posición no existe.

        '4. declarar matriz con capacidad para 5 Strings y guardar 5 libros
        Dim x4(4) As String
        x4(0) = "Os megatoxos"
        x4(1) = "Momo"
        x4(2) = "El capital"
        x4(3) = "El maincraft"
        x4(4) = "Teo va a la granja"

        '5. declarar array de tipo short con capacidad para 4 valores
        Dim x5(3) As Short

        For i As Integer = 0 To 3 Step 1
            Console.WriteLine("Introduzca valor para ls posición :" & i)
            x5(i) = Convert.ToInt16(Console.ReadLine())
        Next
        Console.ReadLine()

        '6. Declarar array con capacidad para 50 valores de tipo double
        Dim x6(49) As Double
        'guardar en la última posición el valor -1
        x6(49) = -1

        '7.Crear un array con capacidad para n valores de tipo integer. 
        'Siendo n una variable cuyo valor debe de ser solicitado al usuario. 


        Dim n As Integer
        Console.WriteLine("Cuántos elementos quiere almacenar en el array?")
        n = Convert.ToInt32(Console.ReadLine())

        Dim x7(n - 1) As Integer

        'Darle valor a la primera y última posición.
        x7(0) = 9
        x7(n - 1) = 34

        '8. Crear un array con capacidad para 100 valores de tipo integer. 
        'A continuación darle valores aleatorios entre 0 y 10 a todas las posiciones.

        Dim x8(99) As Integer
        Dim generador As Random = New Random()
        x8(0) = 1
        For i As Integer = 0 To 99 Step 1
            x8(i) = generador.Next(0, 11)
        Next
        Console.WriteLine("Array ejercicio 8")
        'Mostrar el array
        For i As Integer = 0 To 99 Step 1
            Console.Write(x8(i) & " ")
        Next
        Console.WriteLine()


        '9. Llenar posiciones pares con valores 1,2,3,4
        ' x(0) = 1 , x(1) = 0, x(2) = 2, x(3) = 0, x(4) = 3

        Dim x9(99) As Integer
        Dim contador As Integer = 1
        For i As Integer = 0 To 99 Step 2
            x9(i) = contador
            contador += 1
        Next

        Console.WriteLine("Matriz ejercicio 9")
        For i As Integer = 0 To 99 Step 1
            Console.Write(x9(i) & " ")
        Next


        Console.ReadLine()






























    End Sub

End Module
