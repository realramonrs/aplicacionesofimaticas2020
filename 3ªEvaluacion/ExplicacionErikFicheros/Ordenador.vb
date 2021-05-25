Public Class Ordenador
    Public codigo As String
    Public marca As String
    Public precio As Double

    Public Overrides Function ToString() As String
        Return codigo + "*" + marca + "*" + precio.ToString()
    End Function
End Class
