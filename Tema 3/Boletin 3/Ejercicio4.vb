Module Ejercicio4
    Sub Main()
        Dim a, b, c, d, menor As Integer

        a = 9
        b = 2
        c = 1
        d = 6

        If a > b Then
            menor = b
        Else
            menor = a
        End If

        If menor > c Then
            menor = c
        End If

        If menor > d Then
            menor = d
        End If
        Console.ReadLine()

    End Sub
End Module
