<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.rdbGMIPrimero = New System.Windows.Forms.RadioButton()
        Me.rdbGMISegundo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Sistemas Operativos", "Aplicaciones Ofimáticas", "Redes Locales", "Montaje", "FOL"})
        Me.ListBox1.Location = New System.Drawing.Point(346, 153)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(142, 147)
        Me.ListBox1.TabIndex = 0
        '
        'rdbGMIPrimero
        '
        Me.rdbGMIPrimero.AutoSize = True
        Me.rdbGMIPrimero.Location = New System.Drawing.Point(209, 175)
        Me.rdbGMIPrimero.Name = "rdbGMIPrimero"
        Me.rdbGMIPrimero.Size = New System.Drawing.Size(58, 17)
        Me.rdbGMIPrimero.TabIndex = 1
        Me.rdbGMIPrimero.TabStop = True
        Me.rdbGMIPrimero.Text = "1º GMI"
        Me.rdbGMIPrimero.UseVisualStyleBackColor = True
        '
        'rdbGMISegundo
        '
        Me.rdbGMISegundo.AutoSize = True
        Me.rdbGMISegundo.Location = New System.Drawing.Point(209, 215)
        Me.rdbGMISegundo.Name = "rdbGMISegundo"
        Me.rdbGMISegundo.Size = New System.Drawing.Size(58, 17)
        Me.rdbGMISegundo.TabIndex = 2
        Me.rdbGMISegundo.TabStop = True
        Me.rdbGMISegundo.Text = "2º GMI"
        Me.rdbGMISegundo.UseVisualStyleBackColor = True
        '
        'Ejercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rdbGMISegundo)
        Me.Controls.Add(Me.rdbGMIPrimero)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Ejercicio2"
        Me.Text = "Ejercicio2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents rdbGMIPrimero As RadioButton
    Friend WithEvents rdbGMISegundo As RadioButton
End Class
