Public Class Ejercicio2
    Public asignatura As String

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        asignatura = ListBox1.SelectedItem.ToString()

        Ejercicio2InfoAsignaturas.ShowDialog()
    End Sub

    Private Sub rdbGMIPrimero_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGMIPrimero.CheckedChanged

    End Sub
End Class