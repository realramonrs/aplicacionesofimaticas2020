Public Class Alumno

    Public dni As String
    Public nombre As String

    Public notaMedia As Double

    Public Overrides Function ToString() As String
        Return dni + "*" + nombre + "*" + notaMedia.ToString
    End Function
End Class
