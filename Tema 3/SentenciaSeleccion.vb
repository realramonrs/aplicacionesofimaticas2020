Module SentenciaSeleccion

    Sub Main()
        'Sentencias selección simple --> If Else

        'HAcer un programa que solicite la edad al usuario y si es mayor de edad mande un mensaje
        ' de que puede pasar. y si no un mensaje de que no puede pasar.

        Dim edad As Byte
        Dim mistake As Boolean = False
        Do


            Try
                mistake = False
                Console.WriteLine("Introduzca su edad: ")
                edad = Convert.ToByte(Console.ReadLine())

                Dim menorEdad As Boolean = edad < 18

                If menorEdad Then
                    Console.WriteLine("Menor de edad, no puede pasar!!")
                Else
                    Console.WriteLine("Mayor de edad!")
                End If

                If menorEdad = True Then
                    Console.WriteLine("Menor de edad, no puede pasar!!")
                Else
                    Console.WriteLine("Mayor de edad!")
                End If

                If edad < 18 Then
                    Console.WriteLine("Menor de edad, no puede pasar!!")
                Else
                    Console.WriteLine("Mayor de edad!")

                End If

                Console.WriteLine("Se acabó el if")
            Catch ex As Exception
                mistake = True
                Console.WriteLine("Eres de click nervioso y pusiste mal la edad")
            End Try

        Loop While mistake = True




        Console.ReadLine()



    End Sub
End Module
