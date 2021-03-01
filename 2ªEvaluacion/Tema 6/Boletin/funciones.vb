Option Strict On
Imports System.IO
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

    'Función ejercicio 7
    Function validarCodigo(ByRef codigo As String) As Boolean
        If Not Char.IsLetter(codigo(0)) Or Not Char.IsLetter(codigo(1)) Or Not Char.IsDigit(codigo(2)) Or Not Char.IsDigit(codigo(3)) Then
            Return False
        Else
            Return True
        End If
    End Function

    'Funciones Ficheros : Ejercicios 11 y 13 
    Function leerFichero(ByRef ruta As String, ByRef nombre As String) As String
        Dim rutaConNombre As String = ruta + "\" + nombre
        'Construimos el lector con los argumentos de la función
        Dim lector As StreamReader
        Try
            lector = New StreamReader(rutaConNombre)
            Dim contenido As String = lector.ReadToEnd()
            Return contenido
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Sub escribirFichero(ByRef ruta As String, ByRef nombre As String, ByRef texto As String)

        Dim rutaConNombre As String = ruta + "\" + nombre
        'Construimos el escritor con los argumentos de la función
        Dim escritor As StreamWriter = New StreamWriter(rutaConNombre, True)
        escritor.WriteLine(texto)
        escritor.Close()
    End Sub

End Module
