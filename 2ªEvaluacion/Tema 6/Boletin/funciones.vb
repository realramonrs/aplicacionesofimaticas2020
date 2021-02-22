Option Strict On
Module funciones
    'Función que busca palabras que empiecen por un string

    Sub buscarPalabrasqueEmpiecenPor(ByRef s As String, ByRef caracteres As String)
        Dim palabras() As String = s.Split(" "c)

        For Each pal As String In palabras
            Dim palMinuscula As String = pal.ToLower()
            If palMinuscula.StartsWith(caracteres) Then
                Console.WriteLine(pal)
            End If
        Next

    End Sub

    Sub sumaSub10(ByRef x As Integer)
        x += 10
    End Sub

    Function sumarfunction10(ByVal n As Integer) As Integer
        Return n + 10
    End Function

    'Función ejercicio 4
    Function validarEmail(ByRef email As String) As Boolean
        If email.IndexOf("@") < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub validarEmail2(ByRef email As String)
        If email.IndexOf("@") < 0 Then
            Console.WriteLine("No tiene caracter @")
        Else
            Console.WriteLine("Tiene @")
        End If
    End Sub

    'Función ejercicio 5
    Function contarPalabras(ByRef cadena As String, ByRef subCadena As String) As Integer
        Dim palabras() As String = cadena.Split(" "c)
        Dim contador As Integer = 0
        For Each p As String In palabras
            If p.Contains(subCadena) Then
                contador += 1
            End If
        Next
        Return contador
    End Function

End Module
