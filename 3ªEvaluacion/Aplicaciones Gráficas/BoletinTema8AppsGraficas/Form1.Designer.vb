<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BoletinTema8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio1NoSeDeQueVaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio2PasarFechaAStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio4PasarASegundosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoletinTema9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormConListaAFicheroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoletinTema8ToolStripMenuItem, Me.BoletinTema9ToolStripMenuItem, Me.ExplicacionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BoletinTema8ToolStripMenuItem
        '
        Me.BoletinTema8ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio1NoSeDeQueVaToolStripMenuItem, Me.Ejercicio2PasarFechaAStringToolStripMenuItem, Me.Ejercicio3ToolStripMenuItem, Me.Ejercicio4PasarASegundosToolStripMenuItem})
        Me.BoletinTema8ToolStripMenuItem.Name = "BoletinTema8ToolStripMenuItem"
        Me.BoletinTema8ToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.BoletinTema8ToolStripMenuItem.Text = "Boletin Tema 8"
        '
        'Ejercicio1NoSeDeQueVaToolStripMenuItem
        '
        Me.Ejercicio1NoSeDeQueVaToolStripMenuItem.Name = "Ejercicio1NoSeDeQueVaToolStripMenuItem"
        Me.Ejercicio1NoSeDeQueVaToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.Ejercicio1NoSeDeQueVaToolStripMenuItem.Text = "Ejercicio 1: No se de que va"
        '
        'Ejercicio2PasarFechaAStringToolStripMenuItem
        '
        Me.Ejercicio2PasarFechaAStringToolStripMenuItem.Name = "Ejercicio2PasarFechaAStringToolStripMenuItem"
        Me.Ejercicio2PasarFechaAStringToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.Ejercicio2PasarFechaAStringToolStripMenuItem.Text = "Ejercicio 2: Pasar fecha a String"
        '
        'Ejercicio3ToolStripMenuItem
        '
        Me.Ejercicio3ToolStripMenuItem.Name = "Ejercicio3ToolStripMenuItem"
        Me.Ejercicio3ToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.Ejercicio3ToolStripMenuItem.Text = "Ejercicio 3: "
        '
        'Ejercicio4PasarASegundosToolStripMenuItem
        '
        Me.Ejercicio4PasarASegundosToolStripMenuItem.Name = "Ejercicio4PasarASegundosToolStripMenuItem"
        Me.Ejercicio4PasarASegundosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.Ejercicio4PasarASegundosToolStripMenuItem.Text = "Ejercicio 4: Pasar a segundos"
        '
        'BoletinTema9ToolStripMenuItem
        '
        Me.BoletinTema9ToolStripMenuItem.Name = "BoletinTema9ToolStripMenuItem"
        Me.BoletinTema9ToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.BoletinTema9ToolStripMenuItem.Text = "Boletin Tema 9"
        '
        'ExplicacionesToolStripMenuItem
        '
        Me.ExplicacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormConListaAFicheroToolStripMenuItem, Me.ProyectoToolStripMenuItem})
        Me.ExplicacionesToolStripMenuItem.Name = "ExplicacionesToolStripMenuItem"
        Me.ExplicacionesToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ExplicacionesToolStripMenuItem.Text = "Explicaciones"
        '
        'FormConListaAFicheroToolStripMenuItem
        '
        Me.FormConListaAFicheroToolStripMenuItem.Name = "FormConListaAFicheroToolStripMenuItem"
        Me.FormConListaAFicheroToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.FormConListaAFicheroToolStripMenuItem.Text = "Form con lista a fichero"
        '
        'ProyectoToolStripMenuItem
        '
        Me.ProyectoToolStripMenuItem.Name = "ProyectoToolStripMenuItem"
        Me.ProyectoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ProyectoToolStripMenuItem.Text = "Proyecto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Ejercicios Boletin y Explicaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BoletinTema8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio1NoSeDeQueVaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio2PasarFechaAStringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejercicio4PasarASegundosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoletinTema9ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExplicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormConListaAFicheroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProyectoToolStripMenuItem As ToolStripMenuItem
End Class
