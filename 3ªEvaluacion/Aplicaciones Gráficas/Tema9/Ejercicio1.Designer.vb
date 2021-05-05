<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio1
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
        Me.chkImpresora = New System.Windows.Forms.CheckBox()
        Me.chkNotebook = New System.Windows.Forms.CheckBox()
        Me.chkPortatil = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalcularPrecioFinal = New System.Windows.Forms.Button()
        Me.txtPrecioFinal = New System.Windows.Forms.TextBox()
        Me.nudImpresota = New System.Windows.Forms.NumericUpDown()
        Me.nudNotebook = New System.Windows.Forms.NumericUpDown()
        Me.nudPortatil = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudImpresota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNotebook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPortatil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkImpresora
        '
        Me.chkImpresora.AutoSize = True
        Me.chkImpresora.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkImpresora.Location = New System.Drawing.Point(190, 91)
        Me.chkImpresora.Name = "chkImpresora"
        Me.chkImpresora.Size = New System.Drawing.Size(50, 17)
        Me.chkImpresora.TabIndex = 0
        Me.chkImpresora.Text = "100€"
        Me.chkImpresora.UseVisualStyleBackColor = True
        '
        'chkNotebook
        '
        Me.chkNotebook.AutoSize = True
        Me.chkNotebook.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNotebook.Location = New System.Drawing.Point(190, 150)
        Me.chkNotebook.Name = "chkNotebook"
        Me.chkNotebook.Size = New System.Drawing.Size(50, 17)
        Me.chkNotebook.TabIndex = 1
        Me.chkNotebook.Text = "150€"
        Me.chkNotebook.UseVisualStyleBackColor = True
        '
        'chkPortatil
        '
        Me.chkPortatil.AutoSize = True
        Me.chkPortatil.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPortatil.Location = New System.Drawing.Point(190, 205)
        Me.chkPortatil.Name = "chkPortatil"
        Me.chkPortatil.Size = New System.Drawing.Size(50, 17)
        Me.chkPortatil.TabIndex = 2
        Me.chkPortatil.Text = "250€"
        Me.chkPortatil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Impresora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Notebook"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Portátil"
        '
        'btnCalcularPrecioFinal
        '
        Me.btnCalcularPrecioFinal.Location = New System.Drawing.Point(104, 285)
        Me.btnCalcularPrecioFinal.Name = "btnCalcularPrecioFinal"
        Me.btnCalcularPrecioFinal.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcularPrecioFinal.TabIndex = 6
        Me.btnCalcularPrecioFinal.Text = "Calcular precio total"
        Me.btnCalcularPrecioFinal.UseVisualStyleBackColor = True
        '
        'txtPrecioFinal
        '
        Me.txtPrecioFinal.Location = New System.Drawing.Point(209, 287)
        Me.txtPrecioFinal.Name = "txtPrecioFinal"
        Me.txtPrecioFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioFinal.TabIndex = 7
        '
        'nudImpresota
        '
        Me.nudImpresota.Location = New System.Drawing.Point(262, 91)
        Me.nudImpresota.Name = "nudImpresota"
        Me.nudImpresota.Size = New System.Drawing.Size(47, 20)
        Me.nudImpresota.TabIndex = 8
        '
        'nudNotebook
        '
        Me.nudNotebook.Location = New System.Drawing.Point(262, 149)
        Me.nudNotebook.Name = "nudNotebook"
        Me.nudNotebook.Size = New System.Drawing.Size(47, 20)
        Me.nudNotebook.TabIndex = 8
        '
        'nudPortatil
        '
        Me.nudPortatil.Location = New System.Drawing.Point(262, 205)
        Me.nudPortatil.Name = "nudPortatil"
        Me.nudPortatil.Size = New System.Drawing.Size(47, 20)
        Me.nudPortatil.TabIndex = 8
        '
        'Ejercicio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nudPortatil)
        Me.Controls.Add(Me.nudNotebook)
        Me.Controls.Add(Me.nudImpresota)
        Me.Controls.Add(Me.txtPrecioFinal)
        Me.Controls.Add(Me.btnCalcularPrecioFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkPortatil)
        Me.Controls.Add(Me.chkNotebook)
        Me.Controls.Add(Me.chkImpresora)
        Me.Name = "Ejercicio1"
        Me.Text = "Ejercicio1"
        CType(Me.nudImpresota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNotebook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPortatil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkImpresora As CheckBox
    Friend WithEvents chkNotebook As CheckBox
    Friend WithEvents chkPortatil As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalcularPrecioFinal As Button
    Friend WithEvents txtPrecioFinal As TextBox
    Friend WithEvents nudImpresota As NumericUpDown
    Friend WithEvents nudNotebook As NumericUpDown
    Friend WithEvents nudPortatil As NumericUpDown
End Class
