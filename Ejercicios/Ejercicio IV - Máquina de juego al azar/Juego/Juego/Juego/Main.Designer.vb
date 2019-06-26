<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblJGanadas = New System.Windows.Forms.Label()
        Me.lblJugadas = New System.Windows.Forms.Label()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.lblCasilla1 = New System.Windows.Forms.Label()
        Me.lblCasilla2 = New System.Windows.Forms.Label()
        Me.lblCasilla3 = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(81, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 50)
        Me.Label3.TabIndex = 2
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(81, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 50)
        Me.Label4.TabIndex = 3
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(81, 461)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 50)
        Me.Label5.TabIndex = 4
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(58, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(278, 48)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "¡Gana!, con un 7 en la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "primera casilla, o si las dos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "últimas casillas tienen 7" &
    ""
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJGanadas
        '
        Me.lblJGanadas.BackColor = System.Drawing.Color.Transparent
        Me.lblJGanadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblJGanadas.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJGanadas.ForeColor = System.Drawing.Color.White
        Me.lblJGanadas.Image = CType(resources.GetObject("lblJGanadas.Image"), System.Drawing.Image)
        Me.lblJGanadas.Location = New System.Drawing.Point(257, 401)
        Me.lblJGanadas.Name = "lblJGanadas"
        Me.lblJGanadas.Size = New System.Drawing.Size(50, 50)
        Me.lblJGanadas.TabIndex = 6
        Me.lblJGanadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJugadas
        '
        Me.lblJugadas.BackColor = System.Drawing.Color.Transparent
        Me.lblJugadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblJugadas.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugadas.ForeColor = System.Drawing.Color.White
        Me.lblJugadas.Image = CType(resources.GetObject("lblJugadas.Image"), System.Drawing.Image)
        Me.lblJugadas.Location = New System.Drawing.Point(257, 341)
        Me.lblJugadas.Name = "lblJugadas"
        Me.lblJugadas.Size = New System.Drawing.Size(50, 50)
        Me.lblJugadas.TabIndex = 9
        Me.lblJugadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPorcentaje.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentaje.ForeColor = System.Drawing.Color.White
        Me.lblPorcentaje.Image = CType(resources.GetObject("lblPorcentaje.Image"), System.Drawing.Image)
        Me.lblPorcentaje.Location = New System.Drawing.Point(257, 461)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(50, 50)
        Me.lblPorcentaje.TabIndex = 10
        Me.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCasilla1
        '
        Me.lblCasilla1.BackColor = System.Drawing.Color.Transparent
        Me.lblCasilla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCasilla1.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasilla1.ForeColor = System.Drawing.Color.White
        Me.lblCasilla1.Image = CType(resources.GetObject("lblCasilla1.Image"), System.Drawing.Image)
        Me.lblCasilla1.Location = New System.Drawing.Point(120, 273)
        Me.lblCasilla1.Name = "lblCasilla1"
        Me.lblCasilla1.Size = New System.Drawing.Size(50, 50)
        Me.lblCasilla1.TabIndex = 11
        Me.lblCasilla1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCasilla2
        '
        Me.lblCasilla2.BackColor = System.Drawing.Color.Transparent
        Me.lblCasilla2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCasilla2.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasilla2.ForeColor = System.Drawing.Color.White
        Me.lblCasilla2.Image = CType(resources.GetObject("lblCasilla2.Image"), System.Drawing.Image)
        Me.lblCasilla2.Location = New System.Drawing.Point(176, 273)
        Me.lblCasilla2.Name = "lblCasilla2"
        Me.lblCasilla2.Size = New System.Drawing.Size(50, 50)
        Me.lblCasilla2.TabIndex = 12
        Me.lblCasilla2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCasilla3
        '
        Me.lblCasilla3.BackColor = System.Drawing.Color.Transparent
        Me.lblCasilla3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCasilla3.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasilla3.ForeColor = System.Drawing.Color.White
        Me.lblCasilla3.Image = CType(resources.GetObject("lblCasilla3.Image"), System.Drawing.Image)
        Me.lblCasilla3.Location = New System.Drawing.Point(232, 273)
        Me.lblCasilla3.Name = "lblCasilla3"
        Me.lblCasilla3.Size = New System.Drawing.Size(50, 50)
        Me.lblCasilla3.TabIndex = 13
        Me.lblCasilla3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.Transparent
        Me.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImagen.ErrorImage = Nothing
        Me.pbImagen.Image = Global.Juego.My.Resources.Resources.pikachu
        Me.pbImagen.Location = New System.Drawing.Point(159, 523)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(80, 80)
        Me.pbImagen.TabIndex = 14
        Me.pbImagen.TabStop = False
        '
        'btnJugar
        '
        Me.btnJugar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnJugar.BackColor = System.Drawing.Color.Transparent
        Me.btnJugar.BackgroundImage = CType(resources.GetObject("btnJugar.BackgroundImage"), System.Drawing.Image)
        Me.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJugar.ForeColor = System.Drawing.Color.Transparent
        Me.btnJugar.Location = New System.Drawing.Point(106, 609)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(92, 34)
        Me.btnJugar.TabIndex = 15
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Transparent
        Me.btnSalir.Location = New System.Drawing.Point(204, 609)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 34)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(84, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(396, 660)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnJugar)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.lblCasilla3)
        Me.Controls.Add(Me.lblCasilla2)
        Me.Controls.Add(Me.lblCasilla1)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.lblJugadas)
        Me.Controls.Add(Me.lblJGanadas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PokéRandom"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblJGanadas As System.Windows.Forms.Label
    Friend WithEvents lblJugadas As System.Windows.Forms.Label
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents lblCasilla1 As System.Windows.Forms.Label
    Friend WithEvents lblCasilla2 As System.Windows.Forms.Label
    Friend WithEvents lblCasilla3 As System.Windows.Forms.Label
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents btnJugar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
