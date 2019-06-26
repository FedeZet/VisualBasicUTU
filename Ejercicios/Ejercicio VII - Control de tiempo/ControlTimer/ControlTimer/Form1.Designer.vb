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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblImagen2 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblImagen1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(160, 70)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(160, 110)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblImagen2
        '
        Me.lblImagen2.Image = CType(resources.GetObject("lblImagen2.Image"), System.Drawing.Image)
        Me.lblImagen2.Location = New System.Drawing.Point(38, 60)
        Me.lblImagen2.Name = "lblImagen2"
        Me.lblImagen2.Size = New System.Drawing.Size(80, 80)
        Me.lblImagen2.TabIndex = 3
        Me.lblImagen2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblImagen2.Visible = False
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(70, 15)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(100, 25)
        Me.lblHora.TabIndex = 4
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'lblImagen1
        '
        Me.lblImagen1.Image = CType(resources.GetObject("lblImagen1.Image"), System.Drawing.Image)
        Me.lblImagen1.Location = New System.Drawing.Point(40, 60)
        Me.lblImagen1.Name = "lblImagen1"
        Me.lblImagen1.Size = New System.Drawing.Size(80, 80)
        Me.lblImagen1.TabIndex = 2
        Me.lblImagen1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 168)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblImagen2)
        Me.Controls.Add(Me.lblImagen1)
        Me.Name = "Form1"
        Me.Text = "Timer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lblImagen2 As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lblImagen1 As System.Windows.Forms.Label

End Class
