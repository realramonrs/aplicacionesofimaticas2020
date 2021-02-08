Option Strict On
Module Module1

    Sub Main()
        Dim cadena As String
        cadena = Nothing
        cadena = "El Deportivo perdió contra el Corujo, hasta donde puede caer?"

        'Obtener el número de caracteres
        Dim caracteres As Integer = cadena.Length

        'Recorrer como un array
        For i As Integer = 0 To cadena.Length - 1 Step 1
            If cadena(i) = "a"c Then

            End If
        Next
        'No puedo modificar directamente los caracteres una vez inicializado
        ' cadena(0) = "w"c

        'Modificar un String
        cadena = "El Euribor sigue muy bajo"

        'Funciones :
        'indexOf(char c)--< Posición de la primera aparición de ese caracter en el String
        Dim pos As Integer = cadena.IndexOf("c"c)
        If pos = -1 Then
            Console.WriteLine("No se encuentra el caracter indicado en la frase")
        End If

        'indexOfAny(char x())--> Devolvía la posición de la primera aparición de cualquiera de esos caracteres
        Dim vocales() As Char = {"a"c, "e"c, "i"c, "o"c, "u"c, "A"c, "E"c, "I"c}
        Dim posPrimeraVocal As Integer = cadena.IndexOfAny(vocales)

        If posPrimeraVocal > -1 Then
            Console.WriteLine(cadena(posPrimeraVocal) & " está en la posicion: " & posPrimeraVocal)
        Else
            Console.WriteLine("No hay vocales en el String indicado")
        End If

        'lastIndexOf
        'lastIndexOfAny

        'contains(String s)-->Devuelve true si el String s está en la cadena
        Dim encontrado As Boolean = cadena.Contains("ser")

        'replace(char c1,char c2)-->Genera un nuevo String sustituyendo c1 por c2
        Dim nuevaCadena As String = cadena.Replace("u"c, "e"c)
        cadena.Replace("e"c, "i"c)
        Console.WriteLine(cadena)

        'toupperCase y toLowerCase
        Dim cadenaMinusculas As String = "hola caracola"
        Dim cadenaMayusculas As String = cadenaMinusculas.ToUpper()

        Dim cadenaMinusculas2 As String = cadenaMayusculas.ToLower()

        'toCharArray()--> Vuelca todos los caracteres de un String a un array de char
        Dim caracteres3() As Char = cadenaMayusculas.ToCharArray()

        caracteres3(4) = "e"c


        'Concatenar Strings
        Dim asignaturas As String = "Sistemas Operativos"
        asignaturas += " Montaje"
        asignaturas += " Redes"
        asignaturas += " Aplicaciones Ofimáticas"
        asignaturas += " FOL"

        'substring(int indice)--> Genera un String formado por los caracteres desde el índice hasta el final
        Dim correo As String = "pepe@gmail.es"
        Dim dominio As String = correo.Substring(correo.IndexOf("@"))
        Console.WriteLine("El dominio de " & correo & " es: " & dominio)

        Dim dominio2 As String = correo.Substring(5, 5)
        Console.WriteLine("El dominio es: " & dominio2)

        'split(char c)--> Trocea el string en función de ese caracter, devuel un array de Strings con las diferentes partes
        Dim frase As String = "Me encanta programar, en cualquier lenguaje"
        'Cuántas palabras tiene este String , 
        Dim palabras() As String = frase.Split(" "c, ","c)
        Dim numeroDePalabras As Integer = palabras.Length
        Dim contador As Integer = 0
        For Each p As String In palabras
            If p.StartsWith("e"c) Then
                contador += 1
            End If
        Next


        'Funciones para comprobar tipo caracter
        'Pertenecen a la clase Char

        Dim caracter As Char = "5"c

        If Char.IsLetter(caracter) Then
            Console.WriteLine("Es una letra")
        End If
        If Char.IsDigit(caracter) Then
            Console.WriteLine("Es un dígito")
        End If






        Console.ReadLine()












    End Sub

End Module
