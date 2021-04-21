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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAnho = New System.Windows.Forms.TextBox()
        Me.btnConvertirFecha = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduce datos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(30, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Día"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(30, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Año"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(40, 43)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(37, 13)
        Me.lblResultado.TabIndex = 0
        Me.lblResultado.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResultado)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(95, 64)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDia.TabIndex = 0
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(95, 116)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 1
        '
        'txtAnho
        '
        Me.txtAnho.Location = New System.Drawing.Point(95, 165)
        Me.txtAnho.Name = "txtAnho"
        Me.txtAnho.Size = New System.Drawing.Size(100, 20)
        Me.txtAnho.TabIndex = 2
        '
        'btnConvertirFecha
        '
        Me.btnConvertirFecha.Location = New System.Drawing.Point(205, 61)
        Me.btnConvertirFecha.Name = "btnConvertirFecha"
        Me.btnConvertirFecha.Size = New System.Drawing.Size(95, 32)
        Me.btnConvertirFecha.TabIndex = 3
        Me.btnConvertirFecha.Text = "Convertir"
        Me.btnConvertirFecha.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(205, 116)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(95, 32)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(205, 168)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 32)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnConvertirFecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtAnho)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txtMes)
        Me.GroupBox2.Controls.Add(Me.txtDia)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 353)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Ejercicio2
        '
        Me.AcceptButton = Me.btnConvertirFecha
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Ejercicio2"
        Me.Text = "Ejercicio2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDia As TextBox
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtAnho As TextBox
    Friend WithEvents btnConvertirFecha As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
