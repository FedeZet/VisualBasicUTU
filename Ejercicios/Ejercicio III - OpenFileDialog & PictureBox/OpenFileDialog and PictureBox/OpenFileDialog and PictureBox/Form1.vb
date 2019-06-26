Public Class Form1
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim errores As String = ""

        If txtNombre.Text = "" Then
            errores &= "- El nombre no puede estar vacio " & vbCrLf
        End If

        If txtPassword.Text.Length < 6 Then
            errores &= "- La contraseña debe tener mínimo 6 caracteres. " & vbCrLf
        End If

        If DateDiff(DateInterval.Year, dtpNacimiento.Value, Date.Now) < 18 Then
            errores &= "- El usuario debe tener 18 o más años. " & vbCrLf
        End If

        If IsNothing(pbFoto.Image) Then
            errores &= "- Debes elegir una imagen. " & vbCrLf
        End If

        If txtEmail.Text = "" Then
            errores &= "- El email no puede estar vacio. " & vbCrLf
        End If

        If errores = "" Then
            MsgBox("Usuario correcto e insertado.")
        Else
            MsgBox(errores)
        End If
    End Sub

    Private Sub btnBuscarFoto_Click(sender As Object, e As EventArgs) Handles btnBuscarFoto.Click
        OpenFileDialog1.Filter = "PNG |*.png"
        Dim eleccion As Integer = OpenFileDialog1.ShowDialog(Me)

        If eleccion = DialogResult.OK Then
            pbFoto.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
