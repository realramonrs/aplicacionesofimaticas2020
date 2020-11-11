Imports System.Net.NetworkInformation

Module Module1

    Sub Main()
        Dim opcion As Integer
        Dim continuar As Char
        Do

            Console.WriteLine("Escoja una opción: ")
            Console.WriteLine("5. Calificar una nota como Suspenso , aprobado...")
            Console.WriteLine("6. Modificar número múltiplo de 4 o de 5 ")
            Console.WriteLine("7. Comprobar estado del agua. ")
            Console.WriteLine("8. Menú operaciones matemáticas.")
            Console.WriteLine("12. Select case con indicador. ")
            Console.WriteLine("16. Ordenar 3 valores")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 5
                    Dim nota As Single
                    Console.WriteLine("Introduzca una nota.")
                    nota = Convert.ToInt32(Console.ReadLine())

                    If nota < 0 Or nota > 10 Then
                        Console.WriteLine("Error en la nota")
                    ElseIf nota < 5 Then
                        Console.WriteLine("Suspenso")
                    ElseIf nota < 6.5 Then
                        Console.WriteLine("Aprobado")
                    ElseIf nota < 8.5 Then
                        Console.WriteLine("Notable.")
                    Else
                        Console.WriteLine("Sobresaliente")
                    End If

                Case 6
                    Dim numero, copia As Integer
                    Console.WriteLine("Introduzca el valor: ")
                    numero = Convert.ToInt32(Console.ReadLine())

                    copia = numero

                    If numero Mod 4 = 0 Then
                        numero += 25
                    ElseIf numero Mod 5 = 0 Then
                        numero += 50
                    Else
                        numero += 100
                    End If
                    Console.WriteLine("El valor era : " & copia & " y ahora es: " & numero)

                Case 7
                    Dim temp As Single
                    Console.WriteLine("Introduzca temperatura del agua:")
                    temp = Convert.ToSingle(Console.ReadLine())

                    If temp <= 0 Then
                        Console.WriteLine("SÓLIDO.")
                    ElseIf temp < 100 Then
                        Console.WriteLine("LÍQUIDO.")
                    ElseIf temp < 1000000 Then
                        Console.WriteLine("VAPOR.")
                    Else
                        Console.WriteLine("PLASMA.")
                    End If

                Case 8
                    Dim num1, num2, resultado As Integer
                    Dim apartado As Integer
                    Console.WriteLine("Intro numero 1: ")
                    num1 = Convert.ToInt32(Console.ReadLine)

                    Console.WriteLine("Intro numero 2: ")
                    num2 = Convert.ToInt32(Console.ReadLine)

                    Console.WriteLine("Escoja una opción:")
                    Console.WriteLine("1. Suma")
                    Console.WriteLine("2. Resta")
                    Console.WriteLine("3. Multiplicación")
                    Console.WriteLine("4. División.")

                    apartado = Convert.ToInt32(Console.ReadLine())

                    Select Case apartado
                        Case 1
                            resultado = num1 + num2
                        Case 2
                            resultado = num1 - num2
                        Case 3
                            resultado = num1 * num2
                        Case 4
                            If num2 <> 0 Then
                                resultado = num1 / num2
                            Else
                                Console.WriteLine("No se puede calcular la division")
                            End If
                    End Select


                Case 9
                    Dim pago, litros As Double

                    Console.WriteLine("Introduzca los litros:")
                    litros = Convert.ToDouble(Console.ReadLine())

                    If litros < 50 Then
                        pago = 0
                    ElseIf litros < 200 Then
                        pago = (litros - 50) * 10
                    Else
                        pago = (litros - 200) * 20 + 1500
                    End If

                    If pago < 150 Then
                        pago = 150
                    End If


                    Console.WriteLine("Tiene que pagar: " & pago & " euros.")
                    Console.ReadLine()

                Case 10
                    Dim p1, p2, p3, precioFinal As Double
                    Dim suma As Double

                    p1 = 600
                    p2 = 450
                    p3 = 200

                    suma = p1 + p2 + p3

                    If suma < 500 Then
                        precioFinal = suma
                    ElseIf suma < 1000 Then
                        ' precioFinal = suma - 0.03 * suma
                        precioFinal = suma * (1 - 0.03)

                    ElseIf suma < 2000 Then
                        precioFinal = suma - 0.05 * suma
                    ElseIf suma < 3000 Then
                        precioFinal = suma - 0.07 * suma
                    Else
                        precioFinal = suma - 0.1 * suma
                    End If

                    Console.WriteLine("Precio inicial : " & suma & " euros")
                    Console.WriteLine("Precio final : " & precioFinal & " euros")

                Case 12
                    Dim indicador As Integer
                    Console.WriteLine("Introduce valor de variable indicador:")
                    indicador = Convert.ToInt32(Console.ReadLine())

                    Select Case indicador
                        Case 1

                            Console.WriteLine("Calor")
                        Case 2
                            Console.WriteLine("Templado")
                        Case 3
                            Console.WriteLine("Frío")
                        Case 4
                            Console.WriteLine("Fuera de rango")
                        Case Else
                            Console.WriteLine("Error en la lectura del indicador.")
                    End Select

                Case 13
                    Dim color As Char
                    Console.WriteLine("Escoja un color:")
                    color = Convert.ToChar(Console.ReadLine())

                    Select Case color
                        Case "r"c, "R"c
                            'Case "R"c
                            Console.WriteLine("Rojo")
                        Case Else
                            Console.WriteLine("NEGRO")

                    End Select
                    Console.ReadLine()
                Case 14
                    Dim a, b, c As Integer
                    Dim sol1, sol2 As Double
                    Dim solucion As Boolean = True

                    Console.WriteLine("Programa que resuelve ecuaciones de 2º grado")
                    Console.WriteLine("ax2 + bx + c = 0")
                    Console.WriteLine("Introduzca término a:")
                    a = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduzca término b:")
                    b = Convert.ToInt32(Console.ReadLine())
                    Console.WriteLine("Introduzca término c:")
                    c = Convert.ToInt32(Console.ReadLine())

                    'Vamos evaluando los diferentes casos
                    'a = 0
                    If a = 0 Then
                        sol1 = -c / b
                        sol2 = sol1
                        ' b = 0
                    ElseIf b = 0 Then
                        Dim radicando As Integer = -c / a
                        If radicando > 0 Then
                            sol1 = Math.Sqrt(radicando)
                            sol2 = -Math.Sqrt(radicando)
                        Else
                            solucion = False
                            ' Console.WriteLine("No tiene solución real.")
                        End If
                        ' c = 0
                    ElseIf c = 0 Then
                        sol1 = 0
                        sol2 = -b / a
                        'a , b y c distintos de cero
                    Else
                        Dim radicando As Double = b * b - 4 * a * c
                        'Comprobar que radicando es > 0

                        If radicando < 0 Then
                            solucion = False
                        Else
                            sol1 = (-b + Math.Sqrt(radicando)) / 2 * a
                            sol2 = (-b - Math.Sqrt(radicando)) / 2 * a
                        End If
                    End If

                    If solucion Then
                        Console.WriteLine("Sol1 : " & sol1)
                        Console.WriteLine("Sol2 : " & sol2)
                    Else
                        Console.WriteLine("No tiene solución")
                    End If

                Case 15
                    Dim anho As Integer

                    If anho Mod 4 = 0 And anho Mod 100 = 0 And anho Mod 400 = 0 Then
                        Console.WriteLine("Bisiesto")
                    ElseIf anho Mod 4 = 0 And anho Mod 100 <> 0 Then
                        Console.WriteLine("Bisiesto")
                    Else
                        Console.WriteLine("No es bisiesto.")
                    End If
                Case 16
                    Dim n1, n2, n3 As Integer
                    Console.WriteLine("Intro valor de n1:")
                    n1 = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("Intro valor de n2:")
                    n2 = Convert.ToInt32(Console.ReadLine)
                    Console.WriteLine("Intro valor de n3:")
                    n3 = Convert.ToInt32(Console.ReadLine)

                    If n1 < n2 Then
                        If n1 < n3 Then
                            If n2 < n3 Then
                                Console.WriteLine(n1 & " " & n2 & " " & n3)
                            Else
                                Console.WriteLine(n1 & " " & n3 & " " & n2)
                            End If
                        Else
                            'n3 es el más pequeño
                            Console.WriteLine(n3 & " " & n1 & " " & n2)
                        End If

                    ElseIf n2 < n3 Then
                        'n2 es el más pequeño
                        'me falta comprobar si n3 < n1
                        If n3 < n1 Then
                            Console.WriteLine(n2 & " " & n3 & " " & n1)
                        Else
                            Console.WriteLine(n2 & " " & n1 & " " & n3)
                        End If
                    Else
                        'n3 es el más pequeño
                        'n2 es el del medio
                        Console.WriteLine(n3 & " " & n2 & " " & n1)

                    End If
                    Console.WriteLine()
                    Console.WriteLine("Ordenados con segundo método")
                    If n1 < n2 And n1 < n3 Then
                        If n2 < n3 Then
                            Console.WriteLine(n1 & " " & n2 & " " & n3)
                        Else
                            Console.WriteLine(n1 & " " & n3 & " " & n2)
                        End If
                    ElseIf n2 < n1 And n2 < n3 Then
                        If n1 < n3 Then
                            Console.WriteLine(n2 & " " & n1 & " " & n3)
                        Else
                            Console.WriteLine(n2 & " " & n3 & " " & n1)
                        End If
                    Else
                        If n1 < n2 Then
                            Console.WriteLine(n3 & " " & n1 & " " & n2)
                        Else
                            Console.WriteLine(n3 & " " & n2 & " " & n1)
                        End If


                    End If






                Case Else
                    Console.WriteLine("La opción introducida es errónea.")
            End Select

            Console.WriteLine("Desea repetir el programa s/n?")
            continuar = Convert.ToChar(Console.ReadLine())
        Loop While continuar = "s"c

        Exit Sub 'Para salir del programa
        Console.ReadLine()
    End Sub

End Module
