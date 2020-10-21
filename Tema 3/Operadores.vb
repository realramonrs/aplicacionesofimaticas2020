Option Strict On
Module Module1

    Sub Main()
        Dim x As Integer = 8
        Dim y As Integer = 4


        'Operadores relacionales ---> Establecer condiciones

        Dim condicion1 As Boolean = x < y
        Dim condicion2 As Boolean = x <> y
        Dim condicion3 As Boolean = x = y

        Dim condicion4 As Boolean = x + 10 <> y

        Dim condicion5 As Boolean = condicion1 And condicion2

        Dim condicion6 As Boolean = condicion1 Or condicion2

        Dim condicion7 As Boolean = Not condicion6

    End Sub

End Module
