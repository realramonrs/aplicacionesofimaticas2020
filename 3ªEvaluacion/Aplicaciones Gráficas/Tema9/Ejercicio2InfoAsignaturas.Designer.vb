<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio2InfoAsignaturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProfesor = New System.Windows.Forms.Label()
        Me.lblAsignatura = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblProfesor
        '
        Me.lblProfesor.AutoSize = True
        Me.lblProfesor.Location = New System.Drawing.Point(84, 58)
        Me.lblProfesor.Name = "lblProfesor"
        Me.lblProfesor.Size = New System.Drawing.Size(49, 13)
        Me.lblProfesor.TabIndex = 0
        Me.lblProfesor.Text = "Profesor:"
        '
        'lblAsignatura
        '
        Me.lblAsignatura.AutoSize = True
        Me.lblAsignatura.Location = New System.Drawing.Point(84, 122)
        Me.lblAsignatura.Name = "lblAsignatura"
        Me.lblAsignatura.Size = New System.Drawing.Size(63, 13)
        Me.lblAsignatura.TabIndex = 1
        Me.lblAsignatura.Text = "Asignatura: "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(99, 190)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(423, 159)
        Me.txtDescripcion.TabIndex = 2
        '
        'Ejercicio2InfoAsignaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblAsignatura)
        Me.Controls.Add(Me.lblProfesor)
        Me.Name = "Ejercicio2InfoAsignaturas"
        Me.Text = "Ejercicio2InfoAsignaturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProfesor As Label
    Friend WithEvents lblAsignatura As Label
    Friend WithEvents txtDescripcion As TextBox
End Class
