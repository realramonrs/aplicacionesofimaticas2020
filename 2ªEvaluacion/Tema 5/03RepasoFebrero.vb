Option Strict On

Module Module1

    Sub Main()
        'Dime la posición en la que se encuentra el primer numero impar de un x
        Dim x() As Integer = {4, 6, 0, 2, 0, 1, 8, 7, 5}
        Dim aleatorio As Random = New Random()

        Dim posicion As Integer = -1

        For i As Integer = 0 To x.Length - 1 Step 1
            If x(i) Mod 2 <> 0 Then
                posicion = i
                Console.WriteLine(x(i) & "Está en la posición :" & i)
                Exit For
            End If
        Next

        If posicion = -1 Then
            Console.WriteLine("No hay números impares")
        Else
            Console.WriteLine("El primer número impar está en la posición . " & posicion)
        End If

        'Posiciones en las que hay un cero
        Dim encontrado As Boolean = False
        Console.WriteLine("Posiciones en las que hay un cero: ")
        For i As Integer = 0 To x.Length - 1 Step 1
            If x(i) = 0 Then
                Console.Write(i & " ")
                encontrado = True
            End If
        Next
        If Not encontrado Then
            Console.WriteLine("No hay ceros en el array")
        End If

        Dim matriz(99) As String
        matriz(0) = "PEdro"
        matriz(1) = "Juan"

        'Algoritmo que cuenta cuantos Strings hay guardados en la matriz
        Dim contador As Integer = 0
        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) IsNot Nothing Then
                contador += 1
            End If
        Next

        'Mostrar por pantalla los valores del Array

        Console.WriteLine()
        For Each pepe As String In matriz
            If Not pepe Is Nothing Then
                Console.WriteLine(pepe)
            End If

        Next

        'Comparar dos arrays
        Dim x1() As Integer = {4, 6}
        Dim x2() As Integer = {4, 6}

        Dim iguales As Boolean = True

        For i As Integer = 0 To x1.Length - 1 Step 1
            If Not x1(i) = x2(i) Then
                iguales = False
                Exit For
            End If
        Next
        If iguales = True Then
            Console.WriteLine("Son iguales")
        Else
            Console.WriteLine("No son iguales")
        End If


        'Calcular la suma de un array
        Dim suma As Integer = 0
        For Each valor As Integer In x
            suma = suma + valor
        Next



        Console.ReadLine()
    End Sub

End Module
