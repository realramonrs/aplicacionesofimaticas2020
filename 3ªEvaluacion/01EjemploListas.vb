Option Strict On

Module Module1

    Sub Main()

        'Declarar una lista: Tenemos dos opciones:
        Dim lista As List(Of String) = New List(Of String)()
        Dim lista2 As List(Of String) = New List(Of String)(9) 'Crea una lista con capacidad inicial para 10 Strings

        'En ambos casos cuando se quede sin espacio se redimensionará automáticamente

        'Añadir elementos a la lista: add --< Guardar un elemento en la primera posición vacía
        lista.Add("David Bastos")
        lista.Add("Mario Beltrán")
        lista.Add("Jose Manuel Álvarez")
        lista.Add("Daniel Otero")

        'Añadir elemento en una posición concreta insert: Hay que escoger siempre una posición que ya almacene algo
        lista.Insert(1, "Borja Dacosta")

        'En caso de que tengamos dudas se encierra el insert dentro de una setencia try catch
        Try
            lista.Insert(5, "Javier Pérez")
        Catch ex As Exception
            Console.WriteLine("La posición no existe!")
        End Try

        'Para conocer el número de elementos guardados: count (no tenemos .length)

        Dim numeroElementos As Integer = lista.Count
        Console.WriteLine("Cantidad de elementos guardados: " & numeroElementos)
        'Para conocer la capacidad:
        Dim capacidad As Integer = lista.Capacity
        Console.WriteLine("Capacidad de la lista: " & capacidad)
        'Ajustar la capacidad al número de elementos
        lista.TrimExcess()
        Console.WriteLine("Capacidad después de ajustar con TrimExcess: " & lista.Capacity)

        'Eliminar elementos de una lista-->Remove
        'Eliminar por índice
        lista.RemoveAt(0)
        'Eliminar por valor
        lista.Remove("David Bastos")
        'Si intentamos eliminar algún valor que no está en la lista
        lista.Remove("Zacarías")
        'No pasa nada , pero si le pasamos un índice erróneo saltará una excepción
        Try
            lista.RemoveAt(5)
        Catch ex As Exception
            Console.WriteLine("Not se pudo eliminar ese valor")
        End Try

        Console.WriteLine("Capacidad después de eliminar 4 valores: " & lista.Capacity)

        'También contienen métodos que permiten realizar búsquedas
        'indexOf(valor)--< Devuelve la posición que ocupa la primera aparición
        Dim posicion As Integer = lista.IndexOf("Javier Pérez")
        'contains
        Dim encontrado As Boolean = lista.Contains("Javier")

        'Crear una lista a partir de otra ya creada
        'Tenemos 2 opciones , una directamente en el constructor
        Dim copiaLista1 As List(Of String) = New List(Of String)(lista)
        'Otra a través del método AddRange--> En este caso añade los valores de la lista
        'a los que ya estén previamente en lista2
        lista2.AddRange(lista)

        Console.WriteLine()
        Console.WriteLine("Valores almacenados en copiaLista1: ")
        'Recorrer una lista con un for normal:
        For i As Integer = 0 To copiaLista1.Count - 1 Step 1
            Console.WriteLine(copiaLista1(i))
        Next

        'Recorrer con un Foreach 
        Console.WriteLine()
        Console.WriteLine("Valores con un For Each:")
        For Each valor As String In copiaLista1
            Console.WriteLine(valor)
        Next


        'Ordenar elementos dentro de una lista
        lista.Sort()







        Console.ReadLine()

    End Sub

End Module
