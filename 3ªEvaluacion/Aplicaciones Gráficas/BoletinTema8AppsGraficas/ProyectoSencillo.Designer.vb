<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProyectoSencillo
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
        Me.btnGuardarCancion = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtAnho = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.lblAnho = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConfirmarCambios = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscarTitulo = New System.Windows.Forms.TextBox()
        Me.txtBuscarAutor = New System.Windows.Forms.TextBox()
        Me.txtBuscarAnho = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscarCancion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEliminarCancion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardarCancion
        '
        Me.btnGuardarCancion.Location = New System.Drawing.Point(54, 139)
        Me.btnGuardarCancion.Name = "btnGuardarCancion"
        Me.btnGuardarCancion.Size = New System.Drawing.Size(161, 23)
        Me.btnGuardarCancion.TabIndex = 0
        Me.btnGuardarCancion.Text = "Guardar provisionalmente"
        Me.btnGuardarCancion.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(115, 12)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 1
        '
        'txtGrupo
        '
        Me.txtGrupo.Location = New System.Drawing.Point(115, 55)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(100, 20)
        Me.txtGrupo.TabIndex = 1
        '
        'txtAnho
        '
        Me.txtAnho.Location = New System.Drawing.Point(115, 102)
        Me.txtAnho.Name = "txtAnho"
        Me.txtAnho.Size = New System.Drawing.Size(100, 20)
        Me.txtAnho.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Titulo:"
        '
        'lblGrupo
        '
        Me.lblGrupo.AutoSize = True
        Me.lblGrupo.Location = New System.Drawing.Point(38, 58)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(66, 13)
        Me.lblGrupo.TabIndex = 2
        Me.lblGrupo.Text = "Grupo/Autor"
        '
        'lblAnho
        '
        Me.lblAnho.AutoSize = True
        Me.lblAnho.Location = New System.Drawing.Point(38, 105)
        Me.lblAnho.Name = "lblAnho"
        Me.lblAnho.Size = New System.Drawing.Size(29, 13)
        Me.lblAnho.TabIndex = 2
        Me.lblAnho.Text = "Año:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(315, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 160)
        Me.ListBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Canciones guardadas"
        '
        'txtConfirmarCambios
        '
        Me.txtConfirmarCambios.Location = New System.Drawing.Point(12, 415)
        Me.txtConfirmarCambios.Name = "txtConfirmarCambios"
        Me.txtConfirmarCambios.Size = New System.Drawing.Size(317, 23)
        Me.txtConfirmarCambios.TabIndex = 5
        Me.txtConfirmarCambios.Text = "Confirmar cambios"
        Me.txtConfirmarCambios.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarCancion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBuscarAnho)
        Me.GroupBox1.Controls.Add(Me.txtBuscarAutor)
        Me.GroupBox1.Controls.Add(Me.txtBuscarTitulo)
        Me.GroupBox1.Location = New System.Drawing.Point(567, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 246)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtBuscarTitulo
        '
        Me.txtBuscarTitulo.Location = New System.Drawing.Point(33, 58)
        Me.txtBuscarTitulo.Name = "txtBuscarTitulo"
        Me.txtBuscarTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarTitulo.TabIndex = 0
        '
        'txtBuscarAutor
        '
        Me.txtBuscarAutor.Location = New System.Drawing.Point(33, 109)
        Me.txtBuscarAutor.Name = "txtBuscarAutor"
        Me.txtBuscarAutor.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarAutor.TabIndex = 1
        '
        'txtBuscarAnho
        '
        Me.txtBuscarAnho.Location = New System.Drawing.Point(33, 161)
        Me.txtBuscarAnho.Name = "txtBuscarAnho"
        Me.txtBuscarAnho.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarAnho.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Introduce título:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Autor/Grupo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Año:"
        '
        'btnBuscarCancion
        '
        Me.btnBuscarCancion.Location = New System.Drawing.Point(33, 201)
        Me.btnBuscarCancion.Name = "btnBuscarCancion"
        Me.btnBuscarCancion.Size = New System.Drawing.Size(122, 23)
        Me.btnBuscarCancion.TabIndex = 6
        Me.btnBuscarCancion.Text = "Buscar canción:"
        Me.btnBuscarCancion.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtEliminarCancion)
        Me.GroupBox2.Location = New System.Drawing.Point(409, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 126)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "eliminar canciones"
        '
        'txtEliminarCancion
        '
        Me.txtEliminarCancion.Location = New System.Drawing.Point(55, 63)
        Me.txtEliminarCancion.Name = "txtEliminarCancion"
        Me.txtEliminarCancion.Size = New System.Drawing.Size(136, 20)
        Me.txtEliminarCancion.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Introduzca titulo canción"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(64, 98)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ProyectoSencillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtConfirmarCambios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblAnho)
        Me.Controls.Add(Me.lblGrupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnho)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnGuardarCancion)
        Me.Name = "ProyectoSencillo"
        Me.Text = "ProyectoSencillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarCancion As Button
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtGrupo As TextBox
    Friend WithEvents txtAnho As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGrupo As Label
    Friend WithEvents lblAnho As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmarCambios As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscarCancion As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBuscarAnho As TextBox
    Friend WithEvents txtBuscarAutor As TextBox
    Friend WithEvents txtBuscarTitulo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEliminarCancion As TextBox
End Class
