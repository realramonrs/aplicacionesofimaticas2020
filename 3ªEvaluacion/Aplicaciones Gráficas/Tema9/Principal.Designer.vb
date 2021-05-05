<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BoletínToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetectarControlQueLanzaEventoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosDeTecladoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoletínToolStripMenuItem, Me.ExplicacionesToolStripMenuItem, Me.CalculadoraToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BoletínToolStripMenuItem
        '
        Me.BoletínToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio1ToolStripMenuItem, Me.Ejercicio2ToolStripMenuItem})
        Me.BoletínToolStripMenuItem.Name = "BoletínToolStripMenuItem"
        Me.BoletínToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.BoletínToolStripMenuItem.Text = "Boletín"
        '
        'ExplicacionesToolStripMenuItem
        '
        Me.ExplicacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetectarControlQueLanzaEventoToolStripMenuItem, Me.EventosDeTecladoToolStripMenuItem, Me.GeneralToolStripMenuItem})
        Me.ExplicacionesToolStripMenuItem.Name = "ExplicacionesToolStripMenuItem"
        Me.ExplicacionesToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ExplicacionesToolStripMenuItem.Text = "Explicaciones"
        '
        'DetectarControlQueLanzaEventoToolStripMenuItem
        '
        Me.DetectarControlQueLanzaEventoToolStripMenuItem.Name = "DetectarControlQueLanzaEventoToolStripMenuItem"
        Me.DetectarControlQueLanzaEventoToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.DetectarControlQueLanzaEventoToolStripMenuItem.Text = "Detectar control que lanza evento"
        '
        'EventosDeTecladoToolStripMenuItem
        '
        Me.EventosDeTecladoToolStripMenuItem.Name = "EventosDeTecladoToolStripMenuItem"
        Me.EventosDeTecladoToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.EventosDeTecladoToolStripMenuItem.Text = "Eventos de teclado"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'Ejercicio1ToolStripMenuItem
        '
        Me.Ejercicio1ToolStripMenuItem.Name = "Ejercicio1ToolStripMenuItem"
        Me.Ejercicio1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio1ToolStripMenuItem.Text = "Ejercicio 1"
        '
        'Ejercicio2ToolStripMenuItem
        '
        Me.Ejercicio2ToolStripMenuItem.Name = "Ejercicio2ToolStripMenuItem"
        Me.Ejercicio2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Ejercicio2ToolStripMenuItem.Text = "Ejercicio 2"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BoletínToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExplicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetectarControlQueLanzaEventoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosDeTecladoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio2ToolStripMenuItem As ToolStripMenuItem
End Class
