Module StringFunctions

    Function contarVocales(ByRef x As String) As Integer
        'Contar vocales
        Dim contador As Integer = 0
        For i As Integer = 0 To x.Length - 1 Step 1
            If x(i) = "a"c Or x(i) = "e"c Or x(i) = "i"c Or x(i) = "o"c Or x(i) = "u"c Then
                contador += 1
            End If
        Next
        Return contador
    End Function
End Module
