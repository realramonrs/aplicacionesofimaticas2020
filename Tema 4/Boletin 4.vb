Option Strict On
Module Module1

    Sub Main()
        Dim opcion As Integer
        Dim continuar As Char
        Do

            Console.WriteLine("Escoja una opción: ")
            Console.WriteLine("5. Calificar una nota como Suspenso , aprobado...")
            Console.WriteLine("6. Modificar número múltiplo de 4 o de 5 ")
            Console.WriteLine("7. Comprobar estado del agua. ")
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
                        Console.WriteLine("HIELO.")

                    ElseIf temp < 100 Then
                        Console.WriteLine("LÍQUIDO.")
                    ElseIf temp < 1000000 Then
                        Console.WriteLine("VAPOR.")
                    Else
                        Console.WriteLine("PLASMA.")
                    End If

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
