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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnBuscarFoto = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.grpSexo = New System.Windows.Forms.GroupBox()
        Me.rbtMujer = New System.Windows.Forms.RadioButton()
        Me.rbtHombre = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboDireccion = New System.Windows.Forms.ComboBox()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSexo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha nacimiento:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(112, 28)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(123, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(112, 57)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(123, 20)
        Me.txtPassword.TabIndex = 4
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNacimiento.Location = New System.Drawing.Point(112, 86)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(123, 20)
        Me.dtpNacimiento.TabIndex = 5
        '
        'pbFoto
        '
        Me.pbFoto.Location = New System.Drawing.Point(291, 12)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(100, 100)
        Me.pbFoto.TabIndex = 6
        Me.pbFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnBuscarFoto
        '
        Me.btnBuscarFoto.Location = New System.Drawing.Point(291, 118)
        Me.btnBuscarFoto.Name = "btnBuscarFoto"
        Me.btnBuscarFoto.Size = New System.Drawing.Size(100, 23)
        Me.btnBuscarFoto.TabIndex = 7
        Me.btnBuscarFoto.Text = "Buscar foto"
        Me.btnBuscarFoto.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(112, 212)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 8
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(216, 212)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'grpSexo
        '
        Me.grpSexo.Controls.Add(Me.rbtMujer)
        Me.grpSexo.Controls.Add(Me.rbtHombre)
        Me.grpSexo.Location = New System.Drawing.Point(15, 118)
        Me.grpSexo.Name = "grpSexo"
        Me.grpSexo.Size = New System.Drawing.Size(220, 50)
        Me.grpSexo.TabIndex = 10
        Me.grpSexo.TabStop = False
        Me.grpSexo.Text = "Sexo:"
        '
        'rbtMujer
        '
        Me.rbtMujer.AutoSize = True
        Me.rbtMujer.Location = New System.Drawing.Point(121, 21)
        Me.rbtMujer.Name = "rbtMujer"
        Me.rbtMujer.Size = New System.Drawing.Size(51, 17)
        Me.rbtMujer.TabIndex = 1
        Me.rbtMujer.Text = "Mujer"
        Me.rbtMujer.UseVisualStyleBackColor = True
        '
        'rbtHombre
        '
        Me.rbtHombre.AutoSize = True
        Me.rbtHombre.Checked = True
        Me.rbtHombre.Location = New System.Drawing.Point(29, 21)
        Me.rbtHombre.Name = "rbtHombre"
        Me.rbtHombre.Size = New System.Drawing.Size(62, 17)
        Me.rbtHombre.TabIndex = 0
        Me.rbtHombre.TabStop = True
        Me.rbtHombre.Text = "Hombre"
        Me.rbtHombre.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(53, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(87, 20)
        Me.txtEmail.TabIndex = 12
        '
        'cboDireccion
        '
        Me.cboDireccion.FormattingEnabled = True
        Me.cboDireccion.Items.AddRange(New Object() {"@gmail.com", "@hotmail.com", "@outlook.com", "@yahoo.es"})
        Me.cboDireccion.Location = New System.Drawing.Point(146, 177)
        Me.cboDireccion.Name = "cboDireccion"
        Me.cboDireccion.Size = New System.Drawing.Size(89, 21)
        Me.cboDireccion.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 250)
        Me.Controls.Add(Me.cboDireccion)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpSexo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnBuscarFoto)
        Me.Controls.Add(Me.pbFoto)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Ingresar usuario"
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSexo.ResumeLayout(False)
        Me.grpSexo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnBuscarFoto As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents grpSexo As GroupBox
    Friend WithEvents rbtMujer As RadioButton
    Friend WithEvents rbtHombre As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cboDireccion As ComboBox
End Class
