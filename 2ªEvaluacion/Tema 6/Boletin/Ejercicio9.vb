Module Ejercicio9
    Sub Main()
        Dim cadea1 As String = "Pedro Jimenez*14Julio1990?2500"
        Dim cadea2 As String = "Mar*9000!06Agosto1998"

        'Para obtener el salario en el primer String extraemos los caracteres a partir del ?
        Dim posicionInterrogante As Integer = cadea1.IndexOf("?"c)
        Dim salario1 As String = cadea1.Substring(posicionInterrogante + 1)
        'Comprobamos
        Console.WriteLine("Salario de Pedro Jiménez: " & salario1)
        'Misma estrategia para el salario 2 pero con los caracteres * y !
        Dim posicionAsterisco As Integer = cadea2.IndexOf("*"c)
        Dim posicionExclamacion As Integer = cadea2.IndexOf("!"c)
        Console.WriteLine("Pos exclamacion " & posicionExclamacion)
        Console.WriteLine("Pos asterisco " & posicionAsterisco)
        Dim numeroCaracteres As Integer = posicionExclamacion - posicionAsterisco - 1
        Console.WriteLine("Caracteres entre ! y *" & numeroCaracteres)
        Dim salario2 As String = cadea2.Substring(posicionAsterisco + 1, numeroCaracteres)
        'El segundo argumento de la función Substring es el número de caracteres que quiero extraer
        'Comprobamos
        Console.WriteLine("Salario de Maria Benitez: " & salario2)
        'Una vez que extraigo correctamente los salarios los paso a Integer
        Dim salario1Numero As Integer = Convert.ToInt32(salario1)
        ' Dim salario2Numero As Integer = Convert.ToInt32(salario2)

        'Comprobamos si son superiores a 1000 o no
        If salario1Numero > 1000 Then
            Console.WriteLine("Es superior a 1000")
        Else
            Console.WriteLine("Es inferior a 1000")
        End If

        Console.ReadLine()
    End Sub
End Module
