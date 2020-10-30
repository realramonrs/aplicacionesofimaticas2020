Option Strict On

Module Module1

    Sub Main()


        'Select Case --> Se utiliza mayormente cuando queremos evaluar valores concretos de una variable
        'Se suele usar mucho para código que ofrece varias opciones para el usuario.
        Dim ejercicio As Integer

        Do
            Console.ForegroundColor = ConsoleColor.White

            Console.WriteLine("Escoja el ejercicio que desea ejecutar.")
            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("5. Programa que muestra calificación a partir de la nota.")
            Console.WriteLine()
            Console.WriteLine("6. Programa que suma 25 a números múltiplos de 4.")
            Console.WriteLine()
            Console.WriteLine("7. Programa que indica estado del agua a partir de temperatura.")
            Console.WriteLine()
            Console.WriteLine("-1. Salir.")
            Console.ForegroundColor = ConsoleColor.White
            ejercicio = Convert.ToInt32(Console.ReadLine())

            Select Case ejercicio
                Case 5
                    'Programa el código del ejercicio 5
                    Console.WriteLine("Diseñar un programa que lea una calificación en una variable real y decida qué nota tiene")
                Case 6
                    Console.WriteLine("Escribir un programa que lea un número y si ese número es múltiplo de 4, entonces le suma 25, sino si es múltiplo de 5 le suma 50 y en otro caso le suma 100. Debe mostrar el valor inicial y final del número introducido")
                Case 7
                    Console.WriteLine("Escribir un programa (y realizar el DFD) que evalúe el valor de una variable decimal llamada temp , y escriba uno de los siguientes mensajes dependiendo de su valor:	
                                    HIELO: Si el valor de temp es menor que cero.
                                    AGUA: Si el valor de temp se encuentra entre cero y 100.
                                    VAPOR: Si el valor de temp es superior a 100.")
                Case -1
                    Console.WriteLine("Ha decidido salir del programa")
                Case Else
                    Console.WriteLine("Ha escogido una opción errónea.")

            End Select
            'Console.WriteLine("Pulsa Enter para volver a jugar.")
            'Console.ReadLine()
            'Console.Clear()
        Loop While ejercicio <> -1

        'Dim opcion As Char

        'Console.WriteLine("a. Continuar ejecutando.")
        'Console.WriteLine("b. Salir del programa")

        'opcion = Convert.ToChar(Console.ReadLine())


        'Select Case opcion
        '    Case "a"c
        '    Case "A"c
        '        Console.WriteLine("Ha escogido continuar ejecutando.")
        '    Case "b"c
        '        Console.WriteLine("Ha escogido salir de programa")
        '    Case Else
        '        Console.WriteLine("Opción no válida.")
        'End Select

        Console.ReadLine()

    End Sub

End Module
