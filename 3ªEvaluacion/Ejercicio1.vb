Imports System.IO
Module Ejercicio1
    Sub Main()
        Dim lista1 As List(Of Integer) = New List(Of Integer)(10)
        Console.WriteLine("Capacidad inicial: " & lista1.Capacity)
        Console.WriteLine("Elementos guardados: " & lista1.Count)

        Dim aleatorio As Random = New Random()

        For i As Integer = 0 To 19 Step 1
            lista1.Add(aleatorio.Next(1, 51))
        Next

        'Visualizar por consola la lista generada
        Console.WriteLine("Valores almacenados: ")
        For Each n As Integer In lista1
            Console.Write(n & " ")
        Next
        Console.WriteLine()
        Console.WriteLine("Nueva capacidad: " & lista1.Capacity)
        Console.WriteLine("Cantidad de datos guardados: " & lista1.Count)

        'e) Obtener posición de un determinado valor
        Dim valor As Integer
        Console.WriteLine("Introduzca un valor: ")
        valor = Convert.ToInt32(Console.ReadLine())
        Dim posicion As Integer = lista1.IndexOf(valor)

        If posicion > -1 Then
            Console.WriteLine(valor & " está en la posición : " & posicion)
        Else
            Console.WriteLine("No está en la lista")
        End If

        'f) Comprobar si está un valor o no está
        Dim valor2 As Integer = 34

        If lista1.Contains(valor2) Then
            Console.WriteLine(valor2 & "Está en la lista")
        Else
            Console.WriteLine("No está en la lista")
        End If

        'G) Eliminar un determinado valor:
        Dim valorAEliminar As Integer
        Console.WriteLine("Introduzca el valor a eliminar")
        valorAEliminar = Convert.ToInt32(Console.ReadLine())

        lista1.Remove(valorAEliminar)

        'h) Realizar una copia e otra lista
        Dim copia As List(Of Integer) = New List(Of Integer)(lista1)

        'i) Ordenar la lista original
        lista1.Sort()

        'j)Volcar los valores a un fichero
        Dim ruta As String = Directory.GetCurrentDirectory() + "\datos.txt"

        Dim escritor As StreamWriter = New StreamWriter(ruta)

        For Each numero As Integer In lista1
            escritor.WriteLine(numero.ToString())
        Next

        escritor.Close()












        Console.ReadLine()
    End Sub
End Module
