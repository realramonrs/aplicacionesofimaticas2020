Module ArrayFunctions
    Dim aleatorio As Random = New Random()
    Sub llenarMatriz(ByRef x() As Integer)

        For i As Integer = 0 To x.Length - 1 Step 1
            x(i) = aleatorio.Next(1, 20)
        Next
    End Sub

    Sub mostrarMatriz(ByRef x() As Integer)
        For Each valor As Integer In x
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub

    Function sumarMatriz(ByRef x() As Integer) As Integer
        Dim suma As Integer = 0
        For Each valor As Integer In x
            suma += valor
        Next
        Return suma
    End Function

    Function buscarValor(ByRef x() As Integer, ByVal valor As Integer) As Integer
        Dim posicion As Integer = -1
        For i As Integer = 0 To x.Length - 1 Step 1
            If valor = x(i) Then
                posicion = i
                Exit For
            End If
        Next
        Return posicion
    End Function
End Module
