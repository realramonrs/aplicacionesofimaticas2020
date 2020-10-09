Module Ejercicio10
    Sub Main()
        Dim horasTrabajadas, tasa, salarioBruto, salarioNeto As Double


        'Leer las horas trabajadas y la tasa
        Console.WriteLine("Introduzca las horas trabajadas: ")
        horasTrabajadas = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Introduzca la tasa: ")
        tasa = Convert.ToInt32(Console.ReadLine())

        salarioBruto = horasTrabajadas * tasa
        salarioNeto = salarioBruto - 0.21 * salarioBruto

        Console.WriteLine("Salario bruto: " & salarioBruto)
        Console.WriteLine("Salario neto: " & salarioNeto)

        Console.ReadLine()













    End Sub
End Module
