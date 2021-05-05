Option Strict On
Public Class ExplicacionEventosTeclado
    ' Dim tecla As Char = "w"
    Private Sub ExplicacionEventosTeclado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEjeX.Enabled = False
        txtEjeY.Enabled = False
    End Sub

    Private Sub ExplicacionEventosTeclado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ''Obtenía la tecla
        'Dim teclaPulsada As Char = e.KeyChar

        'If teclaPulsada = "A" Or teclaPulsada = "a" Then
        '    PictureBox1.Left -= 10
        'ElseIf teclaPulsada = "D" Or teclaPulsada = "d" Then
        '    PictureBox1.Left += 10
        'End If


    End Sub

    Private Sub ExplicacionEventosTeclado_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Left Then
            PictureBox1.Left -= 10
        ElseIf e.KeyCode = Keys.Right Then
            PictureBox1.Left += 10
        End If
    End Sub
    'Private Sub txtEjeX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEjeX.KeyPress

    '    'Obtenía la tecla
    '    Dim teclaPulsada As Char = e.KeyChar

    '    'Ver si fue la tecla Enter
    '    If teclaPulsada = Convert.ToChar(Keys.Enter) Then
    '        PictureBox1.Left += Convert.ToInt32(txtEjeX.Text)
    '    End If
    'End Sub

    'Private Sub txtEjeY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEjeY.KeyPress
    '    'Obtenía la tecla
    '    Dim teclaPulsada As Char = e.KeyChar

    '    'Ver si fue la tecla Enter
    '    If teclaPulsada = Convert.ToChar(Keys.Enter) Then
    '        PictureBox1.Top += Convert.ToInt32(txtEjeY.Text)
    '        PictureBox1.Left += Convert.ToInt32(txtEjeX.Text)
    '    End If
    'End Sub
End Class