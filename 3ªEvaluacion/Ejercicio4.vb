Option Strict On
Imports System.IO
Module Ejercicio4
    Sub Main()
        'Simulación lista ejercicio 1
        Dim lista As List(Of Integer) = New List(Of Integer)(10)
        Dim generator As Random = New Random()

        For i As Integer = 10 To 19 Step 1
            lista.Add(generator.Next(1, 51))
        Next

        Console.WriteLine("Lista original : ")
        'Mostrar la lista creada
        For Each numero As Integer In lista
            Console.Write(numero & " ")
        Next
        Console.WriteLine()

        'Empezamos aquí el ejercicio 2:
        Dim lista2 As List(Of Integer) = New List(Of Integer)(lista)


        For i As Integer = 0 To 4 Step 1
            lista2.Add(generator.Next(100, 201))
        Next

        'Mostrar la lista 2

        For Each elemento As Integer In lista2
            Console.Write(elemento & " ")
        Next
        Console.WriteLine()











        Console.ReadLine()
    End Sub
End Module
