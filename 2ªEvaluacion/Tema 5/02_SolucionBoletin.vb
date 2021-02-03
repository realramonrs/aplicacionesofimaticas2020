Option Strict On
Module Module1

    'Función que muestra un array por consola
    Sub escribirArray(ByRef x() As Integer)
        For Each valor As Integer In x
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    'Función que calcula la media de los elementos de una matriz

    Function calcularMediaArray(ByRef x() As Integer) As Double
        Dim suma As Integer = 0
        Dim media As Double = 0

        For Each valor As Integer In x
            suma += valor
        Next

        media = suma / x.Length

        Return media
    End Function




    Sub Main()
        Dim ejercicio As Integer
        Dim continuar As Char
        Do
            Console.WriteLine("Introduzca el ejercicio: ")
            ejercicio = Convert.ToInt32(Console.ReadLine())

            Select Case ejercicio
                Case 1
                    Dim n As Integer
                    Console.WriteLine("Intro número de elementos: ")
                    n = Convert.ToInt32(Console.ReadLine())

                    'Declaro array con capacidad para n valores
                    Dim x1(n - 1) As Integer
                    'Lo llenamos con valores aleatorios
                    Dim generador As Random = New Random()
                    For i As Integer = 0 To x1.Length - 1 Step 1
                        x1(i) = generador.Next(0, 11)
                    Next

                    'Mostrar la matriz
                    escribirArray(x1)
                    Console.WriteLine()
                    'a.)Calcular la media.
                    'Para calcular la media , debemos sumar primero los elementos
                    Dim suma As Integer = 0
                    Dim media As Double = 0

                    media = calcularMediaArray(x1)
                    Console.WriteLine("La nota media es: " & media)
                    'b) Porcentaje de valores por encima de la media
                    Dim contador As Integer = 0
                    Dim porcentaje As Double = 0

                    For Each valor As Integer In x1
                        If valor > media Then
                            contador += 1
                        End If
                    Next

                    porcentaje = (contador / x1.Length) * 100

                    Console.WriteLine("Hay un : " & porcentaje & "% de valores por encima de la media")

                    If media < 0 Or media > 10 Then
                        Console.WriteLine("Error en la nota")
                    ElseIf media < 5 Then
                    ElseIf media < 7 Then
                    ElseIf media < 9 Then
                    Else


                    End If

                Case 2
                    Dim x2(9) As Integer
                    Dim generador2 As Random = New Random()
                    Dim suma As Integer = 0
                    Dim media As Double = 0
                    For i As Integer = 0 To x2.Length - 1 Step 1
                        x2(i) = generador2.Next(1, 21)
                    Next

                    Console.WriteLine("Array ejercicio 2: ")
                    escribirArray(x2)

                    'Calcular la media
                    media = calcularMediaArray(x2)
                    'Si no se usa función , incrustar código situado dentro de la función sin el return

                    Console.WriteLine("La media es: " & media)
                    Dim sumaDesviaciones As Double = 0
                    Dim desviacionMedia As Double = 0
                    For Each valor As Integer In x2
                        Dim desviacion As Double = Math.Abs(valor - media)
                        sumaDesviaciones += desviacion
                        Console.WriteLine(valor & " desviación = " & desviacion)

                    Next

                    desviacionMedia = sumaDesviaciones / x2.Length
                    Console.WriteLine("La desviación media es: " & desviacionMedia)


                Case 3
                    Dim x3(4) As Integer
                    Dim y3(4) As Integer
                    Console.WriteLine("Introduzca valores del primer array:")

                    For i As Integer = 0 To x3.Length - 1 Step 1
                        Console.WriteLine("Valor : " & i)
                        x3(i) = Convert.ToInt32(Console.ReadLine())
                    Next

                    For i As Integer = 0 To y3.Length - 1 Step 1
                        y3(i) = x3(i) + 10
                    Next

                    escribirArray(x3)
                    Console.WriteLine("Segundo array:")
                    escribirArray(y3)

                Case 4
                    Console.WriteLine("Es tan fácil que no lo hago. Cualquier duda me preguntais")
                Case 5
                    Dim x5() As Integer = {-3, -5, 0, 8, 4, -1}
                    Dim posicion As Integer = -1
                    Dim encontrado As Boolean = False
                    Console.WriteLine("Array de trabajo ej 5: ")
                    escribirArray(x5)
                    For i As Integer = 0 To x5.Length - 1 Step 1
                        If x5(i) < 0 Then
                            posicion = i
                            encontrado = True
                            Exit For
                        End If
                    Next

                    If posicion < 0 Then
                        Console.WriteLine("No se ha encontrado números negativos")
                    Else
                        Console.WriteLine("El primer número negativo : " & x5(posicion) & " y esta en la posición: " & posicion)
                    End If


                Case 6
                    Dim x6() As Integer = {4, 9, 8, 7, 4, 1, 2}
                    Console.WriteLine("Array de trabajo del ejercicio 6:")
                    escribirArray(x6)
                    Dim valor As Integer
                    Console.WriteLine("Dime que valor quieres buscar: ")
                    valor = Convert.ToInt32(Console.ReadLine())
                    Dim encontrado As Boolean = False
                    Dim contador As Integer = 0
                    For i As Integer = 0 To x6.Length - 1 Step 1
                        If x6(i) = valor Then
                            Console.Write(i & " ")
                            contador += 1

                        End If
                    Next

                    If contador = 0 Then

                        Console.WriteLine("No encontrado.")
                    End If

                    Console.WriteLine()

                Case 7
                    Dim nombres(99) As String
                    Dim apartado As Char
                    Dim c As Char
                    Do


                        Console.WriteLine("Escoja un apartado")
                        apartado = Convert.ToChar(Console.ReadLine())
                        'Apartado a

                        Select Case apartado
                            Case "a"c
                                Dim nombre As String = Nothing
                                Console.WriteLine("Intro nombre: ")
                                nombre = Console.ReadLine()

                                For i As Integer = 0 To nombres.Length - 1 Step 1
                                    If nombres(i) Is Nothing Then
                                        nombres(i) = nombre
                                        Exit For
                                    End If
                                Next

                            Case "b"c
                                For Each n As String In nombres
                                    If Not n Is Nothing Then
                                        Console.Write(n & " ")
                                    Else
                                        Exit For
                                    End If

                                Next

                            Case "c"c
                                Dim cuentaNombres As Integer = 0
                                For Each nombre As String In nombres
                                    If Not nombre Is Nothing Then
                                        cuentaNombres += 1

                                    Else
                                        Exit For
                                    End If
                                Next

                            Case "d"c
                                Dim cuentaEspacios As Integer = 0

                                For Each nombre As String In nombres
                                    If nombre Is Nothing Then
                                        cuentaEspacios += 1
                                    End If
                                Next

                                Console.WriteLine("Hay " & cuentaEspacios & " espacios")

                            Case "e"c

                            Case "f"c

                                Dim nombreAEliminar As String

                                Console.WriteLine("Introduzca el nombre que desea eliminar: ")
                                nombreAEliminar = Console.ReadLine()

                                For i As Integer = 0 To nombres.Length - 1 Step 1
                                    If nombres(i) = nombreAEliminar Then
                                        nombres(i) = Nothing
                                        'Reordenar la matriz
                                        Exit For
                                    End If
                                    Dim aux As String
                                    If nombres(i) Is Nothing Then
                                        aux = nombres(i)
                                        nombres(i) = nombres(i + 1)
                                        nombres(i + 1) = aux
                                    End If
                                Next
                        End Select
                        Console.WriteLine("Desea continuar: ")
                                c = Convert.ToChar(Console.ReadLine())
                        Loop While c = "s"c











                Case 8
                Case 9
                Case 10
                Case Else


            End Select

            Console.WriteLine("Desea continuar? s/n")
            continuar = Convert.ToChar(Console.ReadLine())
        Loop While continuar = "s"c


    End Sub

End Module
