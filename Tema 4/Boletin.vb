Option Strict On
Module Module1

    Sub Main()
        'Declaro variable para almacenar el ejercicio seleccionado
        Dim ejercicio As Integer
        Dim continuar As Char

        'Bucle do while que controla la interacción de usuario con menú
        Do
            Console.WriteLine("Escoja el ejercicio del boletín:")
            Console.WriteLine("7. Muestra tabla multiplicar ")
            Console.WriteLine("8. Mostrar cuadrado y cubo de 5 primeros valores a partir de n")
            Console.WriteLine("9. Mostrar numero y raiz de número")
            Console.WriteLine("13. Número perfecto")
            Console.WriteLine("15. Factorial")
            Console.WriteLine("18. Primo")
            ejercicio = Convert.ToInt32(Console.ReadLine())

            'Evaluar el valor de la variable ejercicio
            Select Case ejercicio
                Case 7
                    Dim valor As Integer
                    Console.WriteLine("Introduzca número para tabla multiplicar")
                    valor = Convert.ToInt32(Console.ReadLine())

                    'Necesito bucle cuya variable de control tome los valores
                    'del 1 --> 10
                    For i As Integer = 1 To 10 Step 1
                        Console.WriteLine(valor & " x " & i & " = " & valor * i)
                    Next

                    ' Dim j As Integer = 1

                    'While j <= 10

                    '    j = j + 1
                    'End While

                Case 8
                    Dim n As Integer
                    Console.WriteLine("Introduzca un valor")
                    n = Convert.ToInt32(Console.ReadLine())
                    'necesito un bucle cuya variable de control tome los valores
                    'desde n --> n + 5

                    Dim j As Integer = n
                    Dim limite As Integer = n + 5
                    While j <= limite
                        Console.WriteLine(j & "  " & Math.Pow(j, 2) & "  " & Math.Pow(j, 3))
                        j += 1
                    End While
                Case 9
                    Dim contador As Integer = 3
                    For j As Double = 16 To 1 Step -2.5
                        If contador Mod 2 = 0 Then
                            Console.WriteLine(j & " Raiz(j)= " & Math.Round(Math.Sqrt(j), 2))
                        Else
                            Console.WriteLine(j & "   Raiz(j)= " & Math.Round(Math.Sqrt(j), 2))
                        End If

                        contador += 1
                    Next

                Case 10
                    Dim m As Integer
                    Dim contador As Integer = 0 ' Para evitar vicio en caso de iteración
                    Console.WriteLine("Número de intentos consumidos : " & contador)
                    Do
                        Console.WriteLine("Introduzca valor para m:")
                        m = Convert.ToInt32(Console.ReadLine())

                        If m < 0 Then
                            contador += 1
                            If contador = 1 Then
                                Console.WriteLine("Te quedan 2 intentos")
                            ElseIf contador = 2 Then
                                Console.WriteLine("Te queda 1 intento")
                            ElseIf contador = 3 Then
                                Console.WriteLine("La pifiaste tío")
                            End If
                        End If
                    Loop While m < 0 And contador < 3

                    If contador = 3 Then
                        Console.WriteLine("Consumiste todos tus intentos")
                    Else
                        'Calcular la suma
                        Dim suma As Integer = 0 'Para evitar vicio en caso de volver a iterar

                        For i As Integer = 1 To m Step 1
                            suma = suma + i
                        Next
                        Console.WriteLine("La suma es : " & suma)


                    End If
                Case 13
                    Dim numero As Integer
                    Dim sumaDivisores As Integer = 0

                    Do
                        Try
                            Console.WriteLine("Introduzca número:")
                            numero = Convert.ToInt32(Console.ReadLine())
                        Catch ex As Exception
                            Console.WriteLine("No se ha podido leer el número")
                            numero = -1
                        End Try

                    Loop While numero < 0
                    For i As Integer = 1 To Convert.ToInt32(numero / 2) Step 1
                        If numero Mod i = 0 Then
                            sumaDivisores += i
                        End If
                    Next

                    If sumaDivisores = numero Then
                        Console.WriteLine(numero & " es perfecto")
                    Else
                        Console.WriteLine("No es perfecto")
                    End If





                Case 15
                    Dim n As Integer
                    Dim fact As Integer = 1
                    Console.WriteLine("Introduzca valor:")
                    n = Convert.ToInt32(Console.ReadLine())

                    For i As Integer = n To 1 Step -1
                        fact = fact * i
                        Console.WriteLine("El factorial es: " & fact)
                    Next

                Case 18
                    Dim valor As Decimal
                    Dim contador As Integer = 0
                    Console.WriteLine("Introduzca valor:")
                    valor = Convert.ToInt64(Console.ReadLine())


                    For i As Decimal = 2 To valor / 2 Step 1
                        If valor Mod i = 0 Then
                            contador += 1
                            Exit For
                        End If
                    Next

                    If contador = 0 Then
                        Console.WriteLine("Primo")
                    Else
                        Console.WriteLine("No es primo")
                    End If

                Case 21


                    Dim j As Integer = 1

                    While j <= 10
                        Console.WriteLine()
                        Console.WriteLine("Tabla del " & j)
                        Console.WriteLine()
                        For i As Integer = 1 To 10 Step 1
                            Console.WriteLine(j & " x " & i & " = " & j * i)
                        Next
                        j += 1
                    End While

                Case 22
                    'Apartado a)
                    Dim x As Integer = 7
                    For j As Integer = 7 To 1 Step -1
                        For i As Integer = 1 To j Step 1
                            Console.Write("* ")
                        Next
                        Console.WriteLine()
                        x -= 1
                    Next
                    Console.WriteLine()
                    'Apartado b)
                    Dim y As Integer = 7
                    For j As Integer = 1 To 7 Step 1
                        For i As Integer = 1 To j Step 1
                            Console.Write("* ")
                        Next
                        Console.WriteLine()
                        y += 1
                    Next
                    Console.WriteLine()
                    'Apartado d)
                    For j As Integer = 7 To 1 Step -1
                        For i As Integer = 1 To j Step 1
                            Console.Write(i & " ")
                        Next
                        Console.WriteLine()
                        y += 1
                    Next

                Case 23

                    Dim numero23 As Integer
                    Dim sumaDivisores23 As Integer = 0
                    Dim limiteSuperior As Integer

                    Console.WriteLine("Introduzca número:")
                    limiteSuperior = Convert.ToInt32(Console.ReadLine())

                    'Bucle que vaya desde 6 hasta limiteSuperior
                    Dim j As Integer = 6
                    While j <= limiteSuperior

                        sumaDivisores23 = 0
                        For i As Integer = 1 To Convert.ToInt32(j / 2) Step 1
                            If j Mod i = 0 Then
                                sumaDivisores23 += i
                            End If
                        Next

                        If sumaDivisores23 = j Then
                            Console.WriteLine(j & " es perfecto")
                        Else
                            '  Console.WriteLine("No es perfecto")
                        End If


                        j += 1

                    End While

                Case 24
                    Dim limite As Integer = 250
                    Dim i As Integer = 2
                    Dim contador As Integer = 0


                    While i < limite

                        If limite Mod i = 0 Then
                            contador += 1
                            Exit While
                        End If


                    End While

                    If contador = 1 Then

                    End If

                Case 26
                    Dim numero As Integer
                    Dim nivel As Integer
                    Dim aleatorio As Random = New Random()
                    Dim intentos As Integer = 0

                    'Preguntar el nivel
                    Console.WriteLine("Que nivel desa jugar?")
                    Console.WriteLine("1 --> 3 Intentos numero generado 1 - 15")
                    Console.WriteLine("2 --> 5 Intentos numero generado 1 - 30")
                    Console.WriteLine("3 --> 7 Intentos numero generado 1 - 50")
                    nivel = Convert.ToInt32(Console.ReadLine())

                    Select Case nivel
                        Case 1
                            numero = aleatorio.Next(1, 16)
                            Dim respuesta As Integer = 0
                            Do
                                Console.WriteLine("Introduzca numero:")
                                respuesta = Convert.ToInt32(Console.ReadLine())
                                intentos += 1
                                If respuesta = numero Then
                                    Console.WriteLine("Has acertado!!!")
                                    Console.WriteLine("Número generado : " & numero)
                                    Exit Do
                                Else

                                    Console.WriteLine("Has fallado!")

                                    Console.WriteLine("Te quedan : " & 3 - intentos)
                                    If respuesta < numero Then
                                        Console.WriteLine("El número es mayor")
                                    Else
                                        Console.WriteLine("El número es menor.")
                                    End If
                                End If
                            Loop While intentos < 3
                            If intentos > 3 Then
                                Console.WriteLine("Se acabaron tus opciones")
                                Console.WriteLine("El número era : " & numero)
                            End If
                        Case 2
                        Case 3

                    End Select


                Case Else
                    Console.WriteLine("Opción errónea.")
            End Select

            Console.WriteLine("Desea volver a jugar? s/n")
            continuar = Convert.ToChar(Console.ReadLine())


        Loop While continuar = "s"c


        Console.ReadLine()





    End Sub

End Module
