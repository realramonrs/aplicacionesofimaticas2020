Public Class Principal
    Private Sub DetectarControlQueLanzaEventoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetectarControlQueLanzaEventoToolStripMenuItem.Click
        ExplicacionEventoControl.Show()
    End Sub

    Private Sub EventosDeTecladoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventosDeTecladoToolStripMenuItem.Click
        ExplicacionEventosTeclado.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralToolStripMenuItem.Click
        Form1.Show()

    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        Ejercicio1.Show()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        Ejercicio2.Show()
    End Sub
End Class