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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pMenu = New System.Windows.Forms.Panel()
        Me.btnNomDia = New System.Windows.Forms.Button()
        Me.btnDiasMes = New System.Windows.Forms.Button()
        Me.btnSalario = New System.Windows.Forms.Button()
        Me.pPerfil = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.pControl = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.pMain = New System.Windows.Forms.Panel()
        Me.gbDiaMes = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDMLimpiar = New System.Windows.Forms.Button()
        Me.btnDMCalcular = New System.Windows.Forms.Button()
        Me.txtDMAnio = New System.Windows.Forms.TextBox()
        Me.txtDMNumMes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbSalario = New System.Windows.Forms.GroupBox()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.btnSLimpiar = New System.Windows.Forms.Button()
        Me.btnSCalcular = New System.Windows.Forms.Button()
        Me.nudSHijos = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbSAniosServicio = New System.Windows.Forms.GroupBox()
        Me.rbtnSASMas10 = New System.Windows.Forms.RadioButton()
        Me.rbtnSASEntre5y10 = New System.Windows.Forms.RadioButton()
        Me.rbtnSASMenos5 = New System.Windows.Forms.RadioButton()
        Me.gbSInscripto = New System.Windows.Forms.GroupBox()
        Me.rbtnSINo = New System.Windows.Forms.RadioButton()
        Me.rbtnSISi = New System.Windows.Forms.RadioButton()
        Me.gbSClaseTrabajador = New System.Windows.Forms.GroupBox()
        Me.rbtnSTProfesional = New System.Windows.Forms.RadioButton()
        Me.rbtnSTTecnico = New System.Windows.Forms.RadioButton()
        Me.rbtnSTAdministrativo = New System.Windows.Forms.RadioButton()
        Me.rbtnSTObrero = New System.Windows.Forms.RadioButton()
        Me.tmHora = New System.Windows.Forms.Timer(Me.components)
        Me.gbNomDia = New System.Windows.Forms.GroupBox()
        Me.gbNDDatos = New System.Windows.Forms.GroupBox()
        Me.gbNDSemana = New System.Windows.Forms.GroupBox()
        Me.btnNDDLimpiar = New System.Windows.Forms.Button()
        Me.btnNDDCalcular = New System.Windows.Forms.Button()
        Me.txtNDDNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNDNSemana = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbBienvenida = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pMenu.SuspendLayout()
        Me.pPerfil.SuspendLayout()
        Me.pControl.SuspendLayout()
        Me.pMain.SuspendLayout()
        Me.gbDiaMes.SuspendLayout()
        Me.gbSalario.SuspendLayout()
        CType(Me.nudSHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSAniosServicio.SuspendLayout()
        Me.gbSInscripto.SuspendLayout()
        Me.gbSClaseTrabajador.SuspendLayout()
        Me.gbNomDia.SuspendLayout()
        Me.gbNDDatos.SuspendLayout()
        Me.gbNDSemana.SuspendLayout()
        Me.gbBienvenida.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMenu
        '
        Me.pMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pMenu.Controls.Add(Me.btnNomDia)
        Me.pMenu.Controls.Add(Me.btnDiasMes)
        Me.pMenu.Controls.Add(Me.btnSalario)
        Me.pMenu.Controls.Add(Me.pPerfil)
        Me.pMenu.Location = New System.Drawing.Point(0, -1)
        Me.pMenu.Name = "pMenu"
        Me.pMenu.Size = New System.Drawing.Size(196, 565)
        Me.pMenu.TabIndex = 0
        '
        'btnNomDia
        '
        Me.btnNomDia.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNomDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNomDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNomDia.Image = CType(resources.GetObject("btnNomDia.Image"), System.Drawing.Image)
        Me.btnNomDia.Location = New System.Drawing.Point(0, 432)
        Me.btnNomDia.Name = "btnNomDia"
        Me.btnNomDia.Size = New System.Drawing.Size(196, 130)
        Me.btnNomDia.TabIndex = 6
        Me.btnNomDia.UseVisualStyleBackColor = True
        '
        'btnDiasMes
        '
        Me.btnDiasMes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDiasMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiasMes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDiasMes.Image = CType(resources.GetObject("btnDiasMes.Image"), System.Drawing.Image)
        Me.btnDiasMes.Location = New System.Drawing.Point(0, 302)
        Me.btnDiasMes.Name = "btnDiasMes"
        Me.btnDiasMes.Size = New System.Drawing.Size(196, 130)
        Me.btnDiasMes.TabIndex = 5
        Me.btnDiasMes.UseVisualStyleBackColor = True
        '
        'btnSalario
        '
        Me.btnSalario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalario.Image = CType(resources.GetObject("btnSalario.Image"), System.Drawing.Image)
        Me.btnSalario.Location = New System.Drawing.Point(0, 172)
        Me.btnSalario.Name = "btnSalario"
        Me.btnSalario.Size = New System.Drawing.Size(196, 130)
        Me.btnSalario.TabIndex = 4
        Me.btnSalario.UseVisualStyleBackColor = True
        '
        'pPerfil
        '
        Me.pPerfil.Controls.Add(Me.lblNombre)
        Me.pPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.pPerfil.Location = New System.Drawing.Point(0, 0)
        Me.pPerfil.Name = "pPerfil"
        Me.pPerfil.Size = New System.Drawing.Size(196, 172)
        Me.pPerfil.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(12, 17)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(172, 121)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "UI Design" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Es una interfaz de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "usuario cómoda " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para cualquier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "persona."
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pControl
        '
        Me.pControl.BackColor = System.Drawing.Color.White
        Me.pControl.Controls.Add(Me.btnSalir)
        Me.pControl.Controls.Add(Me.lblHora)
        Me.pControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pControl.Location = New System.Drawing.Point(0, 0)
        Me.pControl.Name = "pControl"
        Me.pControl.Size = New System.Drawing.Size(784, 61)
        Me.pControl.TabIndex = 1
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Bahnschrift Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Black
        Me.lblHora.Location = New System.Drawing.Point(202, 16)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(121, 29)
        Me.lblHora.TabIndex = 2
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pMain
        '
        Me.pMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pMain.Controls.Add(Me.gbBienvenida)
        Me.pMain.Controls.Add(Me.gbNomDia)
        Me.pMain.Controls.Add(Me.gbDiaMes)
        Me.pMain.Controls.Add(Me.gbSalario)
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 0)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(784, 561)
        Me.pMain.TabIndex = 2
        '
        'gbDiaMes
        '
        Me.gbDiaMes.Controls.Add(Me.Label4)
        Me.gbDiaMes.Controls.Add(Me.btnDMLimpiar)
        Me.gbDiaMes.Controls.Add(Me.btnDMCalcular)
        Me.gbDiaMes.Controls.Add(Me.txtDMAnio)
        Me.gbDiaMes.Controls.Add(Me.txtDMNumMes)
        Me.gbDiaMes.Controls.Add(Me.Label3)
        Me.gbDiaMes.Controls.Add(Me.Label2)
        Me.gbDiaMes.Location = New System.Drawing.Point(202, 78)
        Me.gbDiaMes.Name = "gbDiaMes"
        Me.gbDiaMes.Size = New System.Drawing.Size(570, 471)
        Me.gbDiaMes.TabIndex = 8
        Me.gbDiaMes.TabStop = False
        Me.gbDiaMes.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(139, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 48)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Escribe un mes y un año, para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "recibir el número de días." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDMLimpiar
        '
        Me.btnDMLimpiar.AutoSize = True
        Me.btnDMLimpiar.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDMLimpiar.Location = New System.Drawing.Point(300, 374)
        Me.btnDMLimpiar.Name = "btnDMLimpiar"
        Me.btnDMLimpiar.Size = New System.Drawing.Size(99, 36)
        Me.btnDMLimpiar.TabIndex = 8
        Me.btnDMLimpiar.Text = "Limpiar"
        Me.btnDMLimpiar.UseVisualStyleBackColor = True
        '
        'btnDMCalcular
        '
        Me.btnDMCalcular.AutoSize = True
        Me.btnDMCalcular.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDMCalcular.Location = New System.Drawing.Point(191, 374)
        Me.btnDMCalcular.Name = "btnDMCalcular"
        Me.btnDMCalcular.Size = New System.Drawing.Size(103, 36)
        Me.btnDMCalcular.TabIndex = 7
        Me.btnDMCalcular.Text = "Calcular"
        Me.btnDMCalcular.UseVisualStyleBackColor = True
        '
        'txtDMAnio
        '
        Me.txtDMAnio.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.txtDMAnio.Location = New System.Drawing.Point(282, 261)
        Me.txtDMAnio.Name = "txtDMAnio"
        Me.txtDMAnio.Size = New System.Drawing.Size(131, 31)
        Me.txtDMAnio.TabIndex = 3
        '
        'txtDMNumMes
        '
        Me.txtDMNumMes.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.txtDMNumMes.Location = New System.Drawing.Point(282, 214)
        Me.txtDMNumMes.Name = "txtDMNumMes"
        Me.txtDMNumMes.Size = New System.Drawing.Size(131, 31)
        Me.txtDMNumMes.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(158, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(158, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nº del Mes:"
        '
        'gbSalario
        '
        Me.gbSalario.BackColor = System.Drawing.Color.Transparent
        Me.gbSalario.Controls.Add(Me.lblTexto)
        Me.gbSalario.Controls.Add(Me.btnSLimpiar)
        Me.gbSalario.Controls.Add(Me.btnSCalcular)
        Me.gbSalario.Controls.Add(Me.nudSHijos)
        Me.gbSalario.Controls.Add(Me.Label1)
        Me.gbSalario.Controls.Add(Me.gbSAniosServicio)
        Me.gbSalario.Controls.Add(Me.gbSInscripto)
        Me.gbSalario.Controls.Add(Me.gbSClaseTrabajador)
        Me.gbSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbSalario.ForeColor = System.Drawing.Color.Black
        Me.gbSalario.Location = New System.Drawing.Point(202, 67)
        Me.gbSalario.Name = "gbSalario"
        Me.gbSalario.Size = New System.Drawing.Size(570, 482)
        Me.gbSalario.TabIndex = 3
        Me.gbSalario.TabStop = False
        Me.gbSalario.Visible = False
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!)
        Me.lblTexto.Location = New System.Drawing.Point(138, 33)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(280, 26)
        Me.lblTexto.TabIndex = 7
        Me.lblTexto.Text = "Ingrese los datos siguientes:"
        '
        'btnSLimpiar
        '
        Me.btnSLimpiar.AutoSize = True
        Me.btnSLimpiar.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSLimpiar.Location = New System.Drawing.Point(271, 364)
        Me.btnSLimpiar.Name = "btnSLimpiar"
        Me.btnSLimpiar.Size = New System.Drawing.Size(99, 36)
        Me.btnSLimpiar.TabIndex = 6
        Me.btnSLimpiar.Text = "Limpiar"
        Me.btnSLimpiar.UseVisualStyleBackColor = True
        '
        'btnSCalcular
        '
        Me.btnSCalcular.AutoSize = True
        Me.btnSCalcular.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSCalcular.Location = New System.Drawing.Point(162, 364)
        Me.btnSCalcular.Name = "btnSCalcular"
        Me.btnSCalcular.Size = New System.Drawing.Size(103, 36)
        Me.btnSCalcular.TabIndex = 5
        Me.btnSCalcular.Text = "Calcular"
        Me.btnSCalcular.UseVisualStyleBackColor = True
        '
        'nudSHijos
        '
        Me.nudSHijos.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.nudSHijos.Location = New System.Drawing.Point(300, 286)
        Me.nudSHijos.Name = "nudSHijos"
        Me.nudSHijos.Size = New System.Drawing.Size(85, 25)
        Me.nudSHijos.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(177, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número de hijos:"
        '
        'gbSAniosServicio
        '
        Me.gbSAniosServicio.Controls.Add(Me.rbtnSASMas10)
        Me.gbSAniosServicio.Controls.Add(Me.rbtnSASEntre5y10)
        Me.gbSAniosServicio.Controls.Add(Me.rbtnSASMenos5)
        Me.gbSAniosServicio.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.gbSAniosServicio.Location = New System.Drawing.Point(384, 100)
        Me.gbSAniosServicio.Name = "gbSAniosServicio"
        Me.gbSAniosServicio.Size = New System.Drawing.Size(158, 130)
        Me.gbSAniosServicio.TabIndex = 2
        Me.gbSAniosServicio.TabStop = False
        Me.gbSAniosServicio.Text = "Años de servicio"
        '
        'rbtnSASMas10
        '
        Me.rbtnSASMas10.AutoSize = True
        Me.rbtnSASMas10.Location = New System.Drawing.Point(6, 81)
        Me.rbtnSASMas10.Name = "rbtnSASMas10"
        Me.rbtnSASMas10.Size = New System.Drawing.Size(124, 22)
        Me.rbtnSASMas10.TabIndex = 2
        Me.rbtnSASMas10.Text = "Más de 10 años"
        Me.rbtnSASMas10.UseVisualStyleBackColor = True
        '
        'rbtnSASEntre5y10
        '
        Me.rbtnSASEntre5y10.AutoSize = True
        Me.rbtnSASEntre5y10.Location = New System.Drawing.Point(6, 57)
        Me.rbtnSASEntre5y10.Name = "rbtnSASEntre5y10"
        Me.rbtnSASEntre5y10.Size = New System.Drawing.Size(137, 22)
        Me.rbtnSASEntre5y10.TabIndex = 1
        Me.rbtnSASEntre5y10.Text = "Entre 5 y 10 años"
        Me.rbtnSASEntre5y10.UseVisualStyleBackColor = True
        '
        'rbtnSASMenos5
        '
        Me.rbtnSASMenos5.AutoSize = True
        Me.rbtnSASMenos5.Checked = True
        Me.rbtnSASMenos5.Location = New System.Drawing.Point(6, 34)
        Me.rbtnSASMenos5.Name = "rbtnSASMenos5"
        Me.rbtnSASMenos5.Size = New System.Drawing.Size(133, 22)
        Me.rbtnSASMenos5.TabIndex = 0
        Me.rbtnSASMenos5.TabStop = True
        Me.rbtnSASMenos5.Text = "Menos de 5 años"
        Me.rbtnSASMenos5.UseVisualStyleBackColor = True
        '
        'gbSInscripto
        '
        Me.gbSInscripto.Controls.Add(Me.rbtnSINo)
        Me.gbSInscripto.Controls.Add(Me.rbtnSISi)
        Me.gbSInscripto.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSInscripto.Location = New System.Drawing.Point(214, 100)
        Me.gbSInscripto.Name = "gbSInscripto"
        Me.gbSInscripto.Size = New System.Drawing.Size(164, 130)
        Me.gbSInscripto.TabIndex = 1
        Me.gbSInscripto.TabStop = False
        Me.gbSInscripto.Text = "¿Inscripto en su sindicato?"
        '
        'rbtnSINo
        '
        Me.rbtnSINo.AutoSize = True
        Me.rbtnSINo.Checked = True
        Me.rbtnSINo.ForeColor = System.Drawing.Color.Black
        Me.rbtnSINo.Location = New System.Drawing.Point(6, 80)
        Me.rbtnSINo.Name = "rbtnSINo"
        Me.rbtnSINo.Size = New System.Drawing.Size(45, 22)
        Me.rbtnSINo.TabIndex = 1
        Me.rbtnSINo.TabStop = True
        Me.rbtnSINo.Text = "No"
        Me.rbtnSINo.UseVisualStyleBackColor = True
        '
        'rbtnSISi
        '
        Me.rbtnSISi.AutoSize = True
        Me.rbtnSISi.ForeColor = System.Drawing.Color.Black
        Me.rbtnSISi.Location = New System.Drawing.Point(6, 53)
        Me.rbtnSISi.Name = "rbtnSISi"
        Me.rbtnSISi.Size = New System.Drawing.Size(36, 22)
        Me.rbtnSISi.TabIndex = 0
        Me.rbtnSISi.Text = "Si"
        Me.rbtnSISi.UseVisualStyleBackColor = True
        '
        'gbSClaseTrabajador
        '
        Me.gbSClaseTrabajador.Controls.Add(Me.rbtnSTProfesional)
        Me.gbSClaseTrabajador.Controls.Add(Me.rbtnSTTecnico)
        Me.gbSClaseTrabajador.Controls.Add(Me.rbtnSTAdministrativo)
        Me.gbSClaseTrabajador.Controls.Add(Me.rbtnSTObrero)
        Me.gbSClaseTrabajador.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSClaseTrabajador.Location = New System.Drawing.Point(24, 100)
        Me.gbSClaseTrabajador.Name = "gbSClaseTrabajador"
        Me.gbSClaseTrabajador.Size = New System.Drawing.Size(184, 130)
        Me.gbSClaseTrabajador.TabIndex = 0
        Me.gbSClaseTrabajador.TabStop = False
        Me.gbSClaseTrabajador.Text = "Clase trabajador"
        '
        'rbtnSTProfesional
        '
        Me.rbtnSTProfesional.AutoSize = True
        Me.rbtnSTProfesional.ForeColor = System.Drawing.Color.Black
        Me.rbtnSTProfesional.Location = New System.Drawing.Point(6, 99)
        Me.rbtnSTProfesional.Name = "rbtnSTProfesional"
        Me.rbtnSTProfesional.Size = New System.Drawing.Size(98, 22)
        Me.rbtnSTProfesional.TabIndex = 3
        Me.rbtnSTProfesional.Text = "Profesional"
        Me.rbtnSTProfesional.UseVisualStyleBackColor = True
        '
        'rbtnSTTecnico
        '
        Me.rbtnSTTecnico.AutoSize = True
        Me.rbtnSTTecnico.ForeColor = System.Drawing.Color.Black
        Me.rbtnSTTecnico.Location = New System.Drawing.Point(6, 76)
        Me.rbtnSTTecnico.Name = "rbtnSTTecnico"
        Me.rbtnSTTecnico.Size = New System.Drawing.Size(73, 22)
        Me.rbtnSTTecnico.TabIndex = 2
        Me.rbtnSTTecnico.Text = "Técnico"
        Me.rbtnSTTecnico.UseVisualStyleBackColor = True
        '
        'rbtnSTAdministrativo
        '
        Me.rbtnSTAdministrativo.AutoSize = True
        Me.rbtnSTAdministrativo.ForeColor = System.Drawing.Color.Black
        Me.rbtnSTAdministrativo.Location = New System.Drawing.Point(6, 53)
        Me.rbtnSTAdministrativo.Name = "rbtnSTAdministrativo"
        Me.rbtnSTAdministrativo.Size = New System.Drawing.Size(120, 22)
        Me.rbtnSTAdministrativo.TabIndex = 1
        Me.rbtnSTAdministrativo.Text = "Administrativo"
        Me.rbtnSTAdministrativo.UseVisualStyleBackColor = True
        '
        'rbtnSTObrero
        '
        Me.rbtnSTObrero.AutoSize = True
        Me.rbtnSTObrero.Checked = True
        Me.rbtnSTObrero.ForeColor = System.Drawing.Color.Black
        Me.rbtnSTObrero.Location = New System.Drawing.Point(6, 30)
        Me.rbtnSTObrero.Name = "rbtnSTObrero"
        Me.rbtnSTObrero.Size = New System.Drawing.Size(73, 22)
        Me.rbtnSTObrero.TabIndex = 0
        Me.rbtnSTObrero.TabStop = True
        Me.rbtnSTObrero.Text = "Obrero"
        Me.rbtnSTObrero.UseVisualStyleBackColor = True
        '
        'tmHora
        '
        '
        'gbNomDia
        '
        Me.gbNomDia.Controls.Add(Me.gbNDSemana)
        Me.gbNomDia.Controls.Add(Me.gbNDDatos)
        Me.gbNomDia.Location = New System.Drawing.Point(202, 67)
        Me.gbNomDia.Name = "gbNomDia"
        Me.gbNomDia.Size = New System.Drawing.Size(564, 482)
        Me.gbNomDia.TabIndex = 10
        Me.gbNomDia.TabStop = False
        Me.gbNomDia.Visible = False
        '
        'gbNDDatos
        '
        Me.gbNDDatos.Controls.Add(Me.btnNDDLimpiar)
        Me.gbNDDatos.Controls.Add(Me.btnNDDCalcular)
        Me.gbNDDatos.Controls.Add(Me.txtNDDNumero)
        Me.gbNDDatos.Controls.Add(Me.Label5)
        Me.gbNDDatos.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.gbNDDatos.Location = New System.Drawing.Point(6, 19)
        Me.gbNDDatos.Name = "gbNDDatos"
        Me.gbNDDatos.Size = New System.Drawing.Size(552, 215)
        Me.gbNDDatos.TabIndex = 0
        Me.gbNDDatos.TabStop = False
        Me.gbNDDatos.Text = "Ingrese datos:"
        '
        'gbNDSemana
        '
        Me.gbNDSemana.Controls.Add(Me.txtNDNSemana)
        Me.gbNDSemana.Controls.Add(Me.Label6)
        Me.gbNDSemana.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.gbNDSemana.Location = New System.Drawing.Point(6, 240)
        Me.gbNDSemana.Name = "gbNDSemana"
        Me.gbNDSemana.Size = New System.Drawing.Size(558, 236)
        Me.gbNDSemana.TabIndex = 1
        Me.gbNDSemana.TabStop = False
        Me.gbNDSemana.Text = "Día de la semana:"
        '
        'btnNDDLimpiar
        '
        Me.btnNDDLimpiar.AutoSize = True
        Me.btnNDDLimpiar.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNDDLimpiar.Location = New System.Drawing.Point(294, 153)
        Me.btnNDDLimpiar.Name = "btnNDDLimpiar"
        Me.btnNDDLimpiar.Size = New System.Drawing.Size(99, 36)
        Me.btnNDDLimpiar.TabIndex = 12
        Me.btnNDDLimpiar.Text = "Limpiar"
        Me.btnNDDLimpiar.UseVisualStyleBackColor = True
        '
        'btnNDDCalcular
        '
        Me.btnNDDCalcular.AutoSize = True
        Me.btnNDDCalcular.Font = New System.Drawing.Font("Berlin Sans FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNDDCalcular.Location = New System.Drawing.Point(185, 153)
        Me.btnNDDCalcular.Name = "btnNDDCalcular"
        Me.btnNDDCalcular.Size = New System.Drawing.Size(103, 36)
        Me.btnNDDCalcular.TabIndex = 11
        Me.btnNDDCalcular.Text = "Calcular"
        Me.btnNDDCalcular.UseVisualStyleBackColor = True
        '
        'txtNDDNumero
        '
        Me.txtNDDNumero.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.txtNDDNumero.Location = New System.Drawing.Point(276, 78)
        Me.txtNDDNumero.Name = "txtNDDNumero"
        Me.txtNDDNumero.Size = New System.Drawing.Size(131, 31)
        Me.txtNDDNumero.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(152, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Número:"
        '
        'txtNDNSemana
        '
        Me.txtNDNSemana.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.txtNDNSemana.Location = New System.Drawing.Point(276, 103)
        Me.txtNDNSemana.MaxLength = 0
        Me.txtNDNSemana.Name = "txtNDNSemana"
        Me.txtNDNSemana.Size = New System.Drawing.Size(131, 31)
        Me.txtNDNSemana.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(152, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Semana:"
        '
        'gbBienvenida
        '
        Me.gbBienvenida.Controls.Add(Me.Label7)
        Me.gbBienvenida.Location = New System.Drawing.Point(202, 64)
        Me.gbBienvenida.Name = "gbBienvenida"
        Me.gbBienvenida.Size = New System.Drawing.Size(570, 485)
        Me.gbBienvenida.TabIndex = 13
        Me.gbBienvenida.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei Light", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(503, 208)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "¡Bienvenido!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Espero que este programa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sea de tu agrado y útil." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Transparent
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(740, 13)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 32)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.pMenu)
        Me.Controls.Add(Me.pControl)
        Me.Controls.Add(Me.pMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UI Design"
        Me.pMenu.ResumeLayout(False)
        Me.pPerfil.ResumeLayout(False)
        Me.pControl.ResumeLayout(False)
        Me.pMain.ResumeLayout(False)
        Me.gbDiaMes.ResumeLayout(False)
        Me.gbDiaMes.PerformLayout()
        Me.gbSalario.ResumeLayout(False)
        Me.gbSalario.PerformLayout()
        CType(Me.nudSHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSAniosServicio.ResumeLayout(False)
        Me.gbSAniosServicio.PerformLayout()
        Me.gbSInscripto.ResumeLayout(False)
        Me.gbSInscripto.PerformLayout()
        Me.gbSClaseTrabajador.ResumeLayout(False)
        Me.gbSClaseTrabajador.PerformLayout()
        Me.gbNomDia.ResumeLayout(False)
        Me.gbNDDatos.ResumeLayout(False)
        Me.gbNDDatos.PerformLayout()
        Me.gbNDSemana.ResumeLayout(False)
        Me.gbNDSemana.PerformLayout()
        Me.gbBienvenida.ResumeLayout(False)
        Me.gbBienvenida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pMenu As Panel
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents pControl As Panel
    Friend WithEvents pPerfil As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnNomDia As Button
    Friend WithEvents btnDiasMes As Button
    Friend WithEvents btnSalario As Button
    Friend WithEvents pMain As Panel
    Friend WithEvents lblHora As Label
    Friend WithEvents tmHora As Timer
    Friend WithEvents gbSalario As GroupBox
    Friend WithEvents lblTexto As Label
    Friend WithEvents btnSLimpiar As Button
    Friend WithEvents btnSCalcular As Button
    Friend WithEvents nudSHijos As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents gbSAniosServicio As GroupBox
    Friend WithEvents rbtnSASMas10 As RadioButton
    Friend WithEvents rbtnSASEntre5y10 As RadioButton
    Friend WithEvents rbtnSASMenos5 As RadioButton
    Friend WithEvents gbSInscripto As GroupBox
    Friend WithEvents rbtnSINo As RadioButton
    Friend WithEvents rbtnSISi As RadioButton
    Friend WithEvents gbSClaseTrabajador As GroupBox
    Friend WithEvents rbtnSTProfesional As RadioButton
    Friend WithEvents rbtnSTTecnico As RadioButton
    Friend WithEvents rbtnSTAdministrativo As RadioButton
    Friend WithEvents rbtnSTObrero As RadioButton
    Friend WithEvents gbDiaMes As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDMLimpiar As Button
    Friend WithEvents btnDMCalcular As Button
    Friend WithEvents txtDMAnio As TextBox
    Friend WithEvents txtDMNumMes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbNomDia As GroupBox
    Friend WithEvents gbNDSemana As GroupBox
    Friend WithEvents txtNDNSemana As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gbNDDatos As GroupBox
    Friend WithEvents btnNDDLimpiar As Button
    Friend WithEvents btnNDDCalcular As Button
    Friend WithEvents txtNDDNumero As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents gbBienvenida As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSalir As Button
End Class
