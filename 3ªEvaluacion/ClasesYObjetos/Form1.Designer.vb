<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNotaMedia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddAlumno = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnVerAlumnosGuardados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(127, 71)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(127, 121)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtNotaMedia
        '
        Me.txtNotaMedia.Location = New System.Drawing.Point(127, 177)
        Me.txtNotaMedia.Name = "txtNotaMedia"
        Me.txtNotaMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtNotaMedia.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nota media"
        '
        'btnAddAlumno
        '
        Me.btnAddAlumno.Location = New System.Drawing.Point(74, 248)
        Me.btnAddAlumno.Name = "btnAddAlumno"
        Me.btnAddAlumno.Size = New System.Drawing.Size(153, 40)
        Me.btnAddAlumno.TabIndex = 6
        Me.btnAddAlumno.Text = "Añadir alumno"
        Me.btnAddAlumno.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(319, 61)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 134)
        Me.ListBox1.TabIndex = 7
        '
        'btnVerAlumnosGuardados
        '
        Me.btnVerAlumnosGuardados.Location = New System.Drawing.Point(319, 245)
        Me.btnVerAlumnosGuardados.Name = "btnVerAlumnosGuardados"
        Me.btnVerAlumnosGuardados.Size = New System.Drawing.Size(127, 43)
        Me.btnVerAlumnosGuardados.TabIndex = 8
        Me.btnVerAlumnosGuardados.Text = "Ver alumnos guardados"
        Me.btnVerAlumnosGuardados.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVerAlumnosGuardados)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnAddAlumno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNotaMedia)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDNI)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNotaMedia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddAlumno As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnVerAlumnosGuardados As Button
End Class
