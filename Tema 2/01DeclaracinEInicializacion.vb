Module Module1

    Sub Main()
        'DECLARACIÓN DE VARIABLES SIN INICIALIZAR
        'Las variables numéricas sin inicializar , cogen por defecto el valor cero
        Dim edad As Byte
        Dim sueldo As Short
        Dim numeroLoteria As Integer
        Dim notaAcceso As Single
        Dim temperatura As Double

        Dim letraDNI As Char
        Dim email As String

        'Comprobación valores 
        Console.WriteLine(edad)

        'Modificar valor de una variable
        edad = 17
        temperatura = 24.45

        'Incrementar el valor de una variable:
        temperatura = temperatura + 2

        edad = edad + 1

        'Declarar e inicializar variables
        Dim numero1 As Integer = 4
        Dim numero2 As Integer = 9
        Dim caracter As Char = "e"c
        Dim dni As String = "12357949W"
        Dim condicion As Boolean = True

        'Reglas para los nombres de las variables:
        '1. Representativo de la utilidad que se le va a dar.
        '2. No pueden contener espacios.
        '3. No pueden empezar por dígitos.
        '4. No pueden tener caracteres especiales salvo el guión bajo.
        '5. No pueden ser palabras reservadas para el lenguaje.







        Console.ReadLine()



    End Sub

End Module
