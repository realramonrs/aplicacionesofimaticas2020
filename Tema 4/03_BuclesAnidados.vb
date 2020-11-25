Option Strict On
Module Module1

    Sub Main()

        For j As Integer = 1 To 20 Step 1
            For i As Integer = 1 To 10 Step 1
                Console.Write(i & " ")
            Next i

            Console.WriteLine()
        Next j


        Console.ReadLine()
    End Sub

End Module
