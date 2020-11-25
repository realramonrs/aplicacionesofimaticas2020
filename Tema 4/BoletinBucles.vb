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
                Case Else
                    Console.WriteLine("Opción errónea.")
            End Select

            Console.WriteLine("Desea volver a jugar? s/n")
            continuar = Convert.ToChar(Console.ReadLine())


        Loop While continuar = "s"c


        Console.ReadLine()





    End Sub

End Module
