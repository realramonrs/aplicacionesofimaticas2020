<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCentigrados = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.btnConvertirFahrenheit = New System.Windows.Forms.Button()
        Me.btnConvertirACentigrados = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKelvin = New System.Windows.Forms.TextBox()
        Me.btnConvertirAKelvin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grados Centígrados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grados Fahrenheit:"
        '
        'txtCentigrados
        '
        Me.txtCentigrados.Location = New System.Drawing.Point(289, 190)
        Me.txtCentigrados.Name = "txtCentigrados"
        Me.txtCentigrados.Size = New System.Drawing.Size(157, 20)
        Me.txtCentigrados.TabIndex = 2
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(289, 241)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(157, 20)
        Me.txtFahrenheit.TabIndex = 2
        '
        'btnConvertirFahrenheit
        '
        Me.btnConvertirFahrenheit.Location = New System.Drawing.Point(490, 191)
        Me.btnConvertirFahrenheit.Name = "btnConvertirFahrenheit"
        Me.btnConvertirFahrenheit.Size = New System.Drawing.Size(130, 23)
        Me.btnConvertirFahrenheit.TabIndex = 3
        Me.btnConvertirFahrenheit.Text = "Pasar a Fahrenheit"
        Me.btnConvertirFahrenheit.UseVisualStyleBackColor = True
        '
        'btnConvertirACentigrados
        '
        Me.btnConvertirACentigrados.Location = New System.Drawing.Point(490, 234)
        Me.btnConvertirACentigrados.Name = "btnConvertirACentigrados"
        Me.btnConvertirACentigrados.Size = New System.Drawing.Size(130, 23)
        Me.btnConvertirACentigrados.TabIndex = 3
        Me.btnConvertirACentigrados.Text = "Pasar a centígrados"
        Me.btnConvertirACentigrados.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kelvin"
        '
        'txtKelvin
        '
        Me.txtKelvin.Location = New System.Drawing.Point(293, 290)
        Me.txtKelvin.Name = "txtKelvin"
        Me.txtKelvin.Size = New System.Drawing.Size(153, 20)
        Me.txtKelvin.TabIndex = 5
        '
        'btnConvertirAKelvin
        '
        Me.btnConvertirAKelvin.Location = New System.Drawing.Point(490, 293)
        Me.btnConvertirAKelvin.Name = "btnConvertirAKelvin"
        Me.btnConvertirAKelvin.Size = New System.Drawing.Size(130, 23)
        Me.btnConvertirAKelvin.TabIndex = 6
        Me.btnConvertirAKelvin.Text = "Pasar a Kelvin"
        Me.btnConvertirAKelvin.UseVisualStyleBackColor = True
        '
        'Ejercicio6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertirAKelvin)
        Me.Controls.Add(Me.txtKelvin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConvertirACentigrados)
        Me.Controls.Add(Me.btnConvertirFahrenheit)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCentigrados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio6"
        Me.Text = "Ejercicio6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCentigrados As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents btnConvertirFahrenheit As Button
    Friend WithEvents btnConvertirACentigrados As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKelvin As TextBox
    Friend WithEvents btnConvertirAKelvin As Button
End Class
