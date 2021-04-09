Option Strict On
Imports System.IO
Module Ejercicio6
    Sub Main()
        Dim lista As List(Of String) = New List(Of String)()
        Dim completadas As List(Of String) = New List(Of String)()
        'Volcar registros a la lista
        Dim ruta As String = Directory.GetCurrentDirectory() + "\tareas.txt"
        Dim ruta2 As String = Directory.GetCurrentDirectory() + "\completadas.txt"
        If File.Exists(ruta) Then
            Dim lector As StreamReader = New StreamReader(ruta)

            While Not lector.EndOfStream
                lista.Add(lector.ReadLine())
            End While
            lector.Close()
        End If

        If File.Exists(ruta2) Then
            Dim lector As StreamReader = New StreamReader(ruta2)

            While Not lector.EndOfStream
                completadas.Add(lector.ReadLine())
            End While
            lector.Close()
        End If

        Dim opcion As Integer
        Do

            'Obtener fecha actual
            '  Dim hoy As Date = Date.Now






            Console.WriteLine("Escoja la opción: ")
            Console.WriteLine("1. Añadir tarea")
            Console.WriteLine("2. Completar tarea.")
            Console.WriteLine("4. Mostrar tareas pendientes.")
            Console.WriteLine("9. Guardar cambios.")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    Console.WriteLine("1. Introducir tarea")
                    Console.WriteLine("Título:")
                    Dim titulo As String = Console.ReadLine()

                    Console.WriteLine("Prioridad: 1 - 10 (Muy prioritario")
                    Dim prioridad As Integer = Convert.ToInt32(Console.ReadLine())

                    Dim dia, mes, anho As Integer
                    Console.WriteLine("Dia : ")
                    dia = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Mes: ")
                    mes = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Año : ")
                    anho = Convert.ToInt32(Console.ReadLine())

                    Dim fechaVencimiento As Date = New Date(anho, mes, dia)
                    Dim registro As String = titulo + "*" + prioridad.ToString + "*" + fechaVencimiento.ToShortDateString()
                    'Guardar el registro
                    lista.Add(registro)
                Case 2
                    'Buscar la tarea que quiero completar
                    Dim nombre As String
                    Console.WriteLine("Introduzca nombre tarea a elimnar.")
                    nombre = Console.ReadLine()

                    For i As Integer = 0 To lista.Count - 1 Step 1
                        If lista(i).Contains(nombre) Then
                            'Pasar la tarea a completadas
                            completadas.Add(lista(i))
                            lista.RemoveAt(i)
                            Exit For
                        End If
                    Next

                Case 4
                    'Mostrar tareas
                    For Each tarea As String In lista
                        Console.WriteLine(tarea)
                    Next
                Case 5
                    'Mostrar tareas completadas
                    For Each tarea As String In completadas
                        Console.WriteLine(tarea)
                    Next

                Case 6
                    'Mostrar fechas que vencen hoy
                    Dim hoy As String = Date.Today.ToShortDateString

                    For Each tarea As String In lista
                        'Obtener fecha de vencimiento
                        'titulo*prioridad*fecha
                        Dim trozos() As String = tarea.Split("*"c)
                        Dim fechaVenci As String = trozos(2)

                        If fechaVenci = hoy Then
                            Console.WriteLine(tarea)
                        End If

                    Next





                Case 9
                    Dim escritor As StreamWriter = New StreamWriter(ruta, False)

                    For Each tarea As String In lista
                        escritor.WriteLine(tarea)
                    Next
                    escritor.Close()

                    Dim escritor2 As StreamWriter = New StreamWriter(ruta2, False)

                    For Each tarea As String In completadas
                        escritor2.WriteLine(tarea)
                    Next
                    escritor2.Close()

            End Select

        Loop While opcion < 10
        Console.ReadLine()
    End Sub
End Module
