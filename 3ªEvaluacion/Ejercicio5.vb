Option Strict On
Imports System.IO
Module Ejercicio5
    Sub Main()
        Dim lista As List(Of Integer) = New List(Of Integer)(20)
        Dim generator As Random = New Random()

        For i As Integer = 0 To 19 Step 1
            lista.Add(generator.Next(1, 26))
        Next


        'Vuelco a un HashSet
        Dim conjunto As HashSet(Of Integer) = New HashSet(Of Integer)(lista)

        For Each valor As Integer In conjunto
            Console.Write(valor & " ")
        Next
        'Mostrar lista de números generadors
        For Each numero As Integer In lista
            Console.Write(numero & " ")
        Next
        Console.WriteLine()
        'Obtener la posición del primer valor 2
        Dim posicion2 As Integer = lista.IndexOf(2)

        If posicion2 < 0 Then
            Console.WriteLine("No hay número 2 en la lista")
        Else
            Console.WriteLine("El primer 2 está en la posición: " & posicion2)
        End If

        lista.Add(2)
        lista.Add(2)
        'Buscar todos los 2 de la lista
        Dim encontrado As Boolean = False
        For i As Integer = 0 To lista.Count - 1 Step 1
            If lista(i) = 2 Then
                Console.WriteLine("Posicion: " & i)
                encontrado = True
            End If
        Next

        If Not encontrado Then
            Console.WriteLine("No hay número 2 en la lista.")

        End If

        Dim suma As Integer = 0
        Dim media As Double = 0
        Dim porcentaje As Double = 0

        For Each numero As Integer In lista
            suma = suma + numero
        Next

        media = suma / lista.Count

        Dim contador As Integer

        For Each numero As Integer In lista
            If numero > 20 Then
                contador += 1
            End If
        Next

        porcentaje = (contador / lista.Count) * 100


        Console.ReadLine()
    End Sub
End Module
