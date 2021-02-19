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
End Module
