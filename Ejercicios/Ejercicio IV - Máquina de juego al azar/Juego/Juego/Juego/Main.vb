Public Class Main

    Private Sub btnJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJugar.Click

        Dim Ganar As Boolean = False
        Dim numAleatorio As New Random(CInt(Date.Now.Ticks And Integer.MaxValue))

        lblCasilla1.Text = System.Convert.ToString(numAleatorio.Next(1, 10))
        lblCasilla2.Text = System.Convert.ToString(numAleatorio.Next(1, 10))
        lblCasilla3.Text = System.Convert.ToString(numAleatorio.Next(1, 10))

        If lblCasilla1.Text = "7" And lblCasilla2.Text = "7" And lblCasilla3.Text = "7" Then
            Ganar = True
            pbImagen.Image = Global.Juego.My.Resources.Winner
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf lblCasilla1.Text = "7" Then
        Ganar = True
            pbImagen.Image = Global.Juego.My.Resources.One_Star
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf lblCasilla2.Text = "7" And lblCasilla3.Text = "7" Then
            Ganar = True
            pbImagen.Image = Global.Juego.My.Resources.Two_Star
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            pbImagen.Image = Global.Juego.My.Resources.Lose
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        If Ganar = True Then
            Ganadas = Ganadas + 1
            Beep()
        End If

        Contador = Contador + 1
        Porcentaje = Ganadas / Contador * 100

        lblJugadas.Text = CStr(Contador.ToString)
        lblJGanadas.Text = CStr(Ganadas.ToString)
        lblPorcentaje.Text = CStr(Porcentaje.ToString + "%")

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        pbImagen.Image = Global.Juego.My.Resources.pikachu
        pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class