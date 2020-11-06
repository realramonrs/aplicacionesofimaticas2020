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
