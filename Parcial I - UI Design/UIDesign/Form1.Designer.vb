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
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ofdFoto = New System.Windows.Forms.OpenFileDialog()
        Me.pControl = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.pMain = New System.Windows.Forms.Panel()
        Me.tmHora = New System.Windows.Forms.Timer(Me.components)
        Me.pMenu.SuspendLayout()
        Me.pPerfil.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pControl.SuspendLayout()
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
        Me.pPerfil.Controls.Add(Me.pbFoto)
        Me.pPerfil.Controls.Add(Me.lblNombre)
        Me.pPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.pPerfil.Location = New System.Drawing.Point(0, 0)
        Me.pPerfil.Name = "pPerfil"
        Me.pPerfil.Size = New System.Drawing.Size(196, 172)
        Me.pPerfil.TabIndex = 3
        '
        'pbFoto
        '
        Me.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbFoto.Location = New System.Drawing.Point(44, 15)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(110, 110)
        Me.pbFoto.TabIndex = 2
        Me.pbFoto.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(12, 135)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(172, 29)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pControl
        '
        Me.pControl.BackColor = System.Drawing.Color.White
        Me.pControl.Controls.Add(Me.lblHora)
        Me.pControl.Controls.Add(Me.btnEditProfile)
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
        'btnEditProfile
        '
        Me.btnEditProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProfile.ForeColor = System.Drawing.Color.Transparent
        Me.btnEditProfile.Image = CType(resources.GetObject("btnEditProfile.Image"), System.Drawing.Image)
        Me.btnEditProfile.Location = New System.Drawing.Point(740, 14)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.Size = New System.Drawing.Size(32, 32)
        Me.btnEditProfile.TabIndex = 0
        Me.btnEditProfile.UseVisualStyleBackColor = False
        '
        'pMain
        '
        Me.pMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pMain.Location = New System.Drawing.Point(0, 0)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(784, 561)
        Me.pMain.TabIndex = 2
        '
        'tmHora
        '
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
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pControl.ResumeLayout(False)
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
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents pMain As Panel
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lblHora As Label
    Friend WithEvents tmHora As Timer
End Class
