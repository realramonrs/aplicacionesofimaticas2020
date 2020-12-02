Option Strict On
Module Contador
    Sub Main()
        Dim aleatorio As Random = New Random()
        Dim contadorNegativos As Integer = 0
        'Genere 1000 números aleatorios entre -200 y 500
        'Cuente cuantos son negativos

        For i As Integer = 1 To 1000 Step 1
            Dim numeroGenerado As Integer = aleatorio.Next(-200, 501)

            'Preguntar si numeroGenerado es < 0
            If numeroGenerado < 0 Then
                'contadorNegativos += 1
                contadorNegativos = contadorNegativos + 1
            End If
        Next

        Console.ReadLine()






    End Sub
End Module
