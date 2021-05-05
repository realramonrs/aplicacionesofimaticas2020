<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExplicacionEventoControl
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
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnNaranja = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAzul
        '
        Me.btnAzul.Location = New System.Drawing.Point(128, 129)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(94, 44)
        Me.btnAzul.TabIndex = 0
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(262, 131)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(90, 41)
        Me.btnRojo.TabIndex = 1
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'btnVerde
        '
        Me.btnVerde.Location = New System.Drawing.Point(384, 132)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(95, 40)
        Me.btnVerde.TabIndex = 2
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = True
        '
        'btnAmarillo
        '
        Me.btnAmarillo.Location = New System.Drawing.Point(128, 210)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(94, 35)
        Me.btnAmarillo.TabIndex = 3
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = True
        '
        'btnNaranja
        '
        Me.btnNaranja.Location = New System.Drawing.Point(262, 210)
        Me.btnNaranja.Name = "btnNaranja"
        Me.btnNaranja.Size = New System.Drawing.Size(90, 35)
        Me.btnNaranja.TabIndex = 4
        Me.btnNaranja.Text = "Naranja"
        Me.btnNaranja.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'ExplicacionEventoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNaranja)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnRojo)
        Me.Controls.Add(Me.btnAzul)
        Me.Name = "ExplicacionEventoControl"
        Me.Text = "ExplicacionEventoControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAzul As Button
    Friend WithEvents btnRojo As Button
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnAmarillo As Button
    Friend WithEvents btnNaranja As Button
    Friend WithEvents Label1 As Label
End Class
