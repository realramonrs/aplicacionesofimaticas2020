Option Strict On
Imports System.IO
Module Module1

    Sub Main()

        Dim opcion As Integer
        Dim listaPeliculas As List(Of String) = New List(Of String)()
        Dim ruta As String = Directory.GetCurrentDirectory() + "\pelis.txt"

        'Volcar datos del fichero a la lista
        If File.Exists(ruta) Then
            Dim lector As StreamReader = New StreamReader(ruta)

            While Not lector.EndOfStream
                listaPeliculas.Add(lector.ReadLine())
            End While

            lector.Close()
        End If

        Do


            Console.WriteLine("Escoja la opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion

                Case 1
                    'Mostrar peliculas
                    For Each peli As String In listaPeliculas
                        Console.WriteLine(peli)
                    Next
                Case 2
                    'Buscar una peli con contains
                    Dim peliBuscada As String
                    Console.WriteLine("Intro peli que desea buscar:")
                    peliBuscada = Console.ReadLine

                    Dim posicion As Integer = listaPeliculas.IndexOf(peliBuscada)
                    If listaPeliculas.Contains(peliBuscada) Then
                        Console.WriteLine("La peli está en la lista , posicion: " & posicion)
                    Else
                        Console.WriteLine("La peli no está en la lista")
                    End If

                Case 3
                    'Añadir elementos -->add
                    Console.WriteLine("Introduzca una peli:")
                    Dim peli As String = Console.ReadLine()
                    listaPeliculas.Add(peli)

                    'Añadir peli al fichero
                    Dim escritor As StreamWriter = New StreamWriter(ruta, True)
                    escritor.WriteLine(peli)
                    escritor.Close()

                Case 4
                    'Eliminar peli
                    Console.WriteLine("Intro peli que desea eliminar: ")
                    Dim peli As String = Console.ReadLine()

                    listaPeliculas.Remove(peli)
                Case 5
                    'Volcar lista a fichero
                    'False para sobreescribir el fichero
                    Dim escritor As StreamWriter = New StreamWriter(ruta, False)

                    For Each p As String In listaPeliculas
                        escritor.WriteLine(p)
                    Next
                    escritor.Close()
            End Select

        Loop While opcion < 9

        Console.ReadLine()

    End Sub

End Module
