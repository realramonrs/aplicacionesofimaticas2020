Option Strict On
Module Module1

    Sub Main()
        Dim frase As String = "Esto es una frase"
        'Array de variables de tipo Char

        Dim letra As Char = frase(0)

        'frase(0) = "e"c

        'Si yo quiero añadir texto a un String
        frase += " esto es texto a mayores"
        Dim contador As Integer = 0
        'Recorrer un String con un for
        For i As Integer = 0 To frase.Length - 1 Step 1
            If frase(i) = "a"c Then
                contador += 1
            End If
        Next

        frase = "abracadabra"
        'Estrategias para modificar un String
        frase = frase.Replace("a"c, "o"c)

        Console.WriteLine(frase)

        'Funciones útiles para trabajar con Strings

        frase = "Hala Celta"
        'indexOf--> Devuelve el índice de la primera aparición que ocupa un caracter en un String
        Dim posicion As Integer = frase.IndexOf("n"c)


        'lastIndexOf-->Última aparición de un caracter en un String
        Dim ultimaPosicion As Integer = frase.LastIndexOf("a"c)

        'indexOfany-->Devuelve el índice que ocupa la primera aparición de un conjunto de caracteres
        frase = "cuanto cuesta"
        Dim vocales() As Char = {"a"c, "e"c, "i"c, "o"c, "u"c}
        Dim pos As Integer = frase.IndexOfAny(vocales)
        Dim pos2 As Integer = frase.IndexOfAny(vocales, pos + 1)

        Console.WriteLine(pos2)

        'length--> Número de caracteres de un String
        Dim caracteres As Integer = frase.Length

        'startsWidth--> Devuelve true si el string comienza por los caracteres que recibe como argumento
        If frase.StartsWith("al") Then
            Console.WriteLine("Empieza por al")
        End If

        'endsWidth--< Devuelve true si el String acaba por los caracteres que recibe como argumento
        If frase.EndsWith("al") Then

        End If

        'contains--> Busca un substring en un string
        frase = "palabra"
        If frase.Contains("al") Then
            Console.WriteLine(frase & " contiene el substring al")
        End If

        'substring--> Devuelve un string a partir de las posiciones que recibe como argumento
        frase = "montecastelo"
        Dim subCadena1 As String = frase.Substring(3)
        Dim subCadena2 As String = frase.Substring(0, 3)
        Console.WriteLine(subCadena1)
        Console.WriteLine(subCadena2)

        Dim correo As String = "pepepepepepepe@ciclosmontecastelo.com"









        Console.ReadLine()

    End Sub

End Module
