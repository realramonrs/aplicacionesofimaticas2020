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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtIndiceSeleccionado = New System.Windows.Forms.TextBox()
        Me.txtValorSeleccionado = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Indice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAnhadir = New System.Windows.Forms.TextBox()
        Me.btnAnhadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaEscogida = New System.Windows.Forms.TextBox()
        Me.txtFechaEntrega = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCuentaAtras = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Sucky", "Josema", "Mario", "juan", "Alberto", "Zaca", "Daniel", "Yago"})
        Me.ListBox1.Location = New System.Drawing.Point(206, 66)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(121, 264)
        Me.ListBox1.TabIndex = 0
        '
        'txtIndiceSeleccionado
        '
        Me.txtIndiceSeleccionado.Location = New System.Drawing.Point(561, 66)
        Me.txtIndiceSeleccionado.Name = "txtIndiceSeleccionado"
        Me.txtIndiceSeleccionado.Size = New System.Drawing.Size(100, 20)
        Me.txtIndiceSeleccionado.TabIndex = 1
        '
        'txtValorSeleccionado
        '
        Me.txtValorSeleccionado.Location = New System.Drawing.Point(561, 131)
        Me.txtValorSeleccionado.Name = "txtValorSeleccionado"
        Me.txtValorSeleccionado.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSeleccionado.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(561, 208)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(214, 53)
        Me.txtDescripcion.TabIndex = 3
        '
        'Indice
        '
        Me.Indice.AutoSize = True
        Me.Indice.Location = New System.Drawing.Point(558, 48)
        Me.Indice.Name = "Indice"
        Me.Indice.Size = New System.Drawing.Size(36, 13)
        Me.Indice.TabIndex = 4
        Me.Indice.Text = "Indice"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(558, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(558, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Decripción del alumno"
        '
        'txtAnhadir
        '
        Me.txtAnhadir.Location = New System.Drawing.Point(54, 76)
        Me.txtAnhadir.Name = "txtAnhadir"
        Me.txtAnhadir.Size = New System.Drawing.Size(112, 20)
        Me.txtAnhadir.TabIndex = 6
        '
        'btnAnhadir
        '
        Me.btnAnhadir.Location = New System.Drawing.Point(54, 119)
        Me.btnAnhadir.Name = "btnAnhadir"
        Me.btnAnhadir.Size = New System.Drawing.Size(112, 32)
        Me.btnAnhadir.TabIndex = 7
        Me.btnAnhadir.Text = "Añadir"
        Me.btnAnhadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(54, 181)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 40)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(438, 305)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(438, 347)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(438, 392)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(625, 305)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Iago Aspas"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(625, 347)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Denis Suárez"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(37, 356)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'txtFechaEscogida
        '
        Me.txtFechaEscogida.Location = New System.Drawing.Point(37, 407)
        Me.txtFechaEscogida.Name = "txtFechaEscogida"
        Me.txtFechaEscogida.Size = New System.Drawing.Size(156, 20)
        Me.txtFechaEscogida.TabIndex = 16
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.Location = New System.Drawing.Point(275, 407)
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaEntrega.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Fecha Entrega"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtCuentaAtras
        '
        Me.txtCuentaAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaAtras.Location = New System.Drawing.Point(625, 386)
        Me.txtCuentaAtras.Multiline = True
        Me.txtCuentaAtras.Name = "txtCuentaAtras"
        Me.txtCuentaAtras.Size = New System.Drawing.Size(78, 52)
        Me.txtCuentaAtras.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(370, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Deschechear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCuentaAtras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaEntrega)
        Me.Controls.Add(Me.txtFechaEscogida)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAnhadir)
        Me.Controls.Add(Me.txtAnhadir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Indice)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtValorSeleccionado)
        Me.Controls.Add(Me.txtIndiceSeleccionado)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtIndiceSeleccionado As TextBox
    Friend WithEvents txtValorSeleccionado As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Indice As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAnhadir As TextBox
    Friend WithEvents btnAnhadir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtFechaEscogida As TextBox
    Friend WithEvents txtFechaEntrega As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtCuentaAtras As TextBox
    Friend WithEvents Button1 As Button
End Class
