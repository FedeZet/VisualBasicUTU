Public Class Main
    Dim turno As String
    Dim contTurnos, contX, contO As Integer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        turno = "X"
        contTurnos = 0
        contX = 0
        contO = 0

    End Sub

    Public Sub turnos(casillas As Integer, turn As String)

        Dim xo As String

        If turn = "X" Then
            xo = "X"
            turno = "O"
        Else
            xo = "O"
            turno = "X"
        End If

        lblTurno.Text = "Turno de " + turno

        If casillas = 1 Then
            btnCasilla1.Text = xo
            btnCasilla1.Enabled = False
        ElseIf casillas = 2 Then
            btnCasilla2.Text = xo
            btnCasilla2.Enabled = False
        ElseIf casillas = 3 Then
            btnCasilla3.Text = xo
            btnCasilla3.Enabled = False
        ElseIf casillas = 4 Then
            btnCasilla4.Text = xo
            btnCasilla4.Enabled = False
        ElseIf casillas = 5 Then
            btnCasilla5.Text = xo
            btnCasilla5.Enabled = False
        ElseIf casillas = 6 Then
            btnCasilla6.Text = xo
            btnCasilla6.Enabled = False
        ElseIf casillas = 7 Then
            btnCasilla7.Text = xo
            btnCasilla7.Enabled = False
        ElseIf casillas = 8 Then
            btnCasilla8.Text = xo
            btnCasilla8.Enabled = False
        ElseIf casillas = 9 Then
            btnCasilla9.Text = xo
            btnCasilla9.Enabled = False
        End If

        contTurnos = contTurnos + 1

        resultado()
    End Sub

    Public Sub resultado()

        'Ganador X
        If btnCasilla1.Text = "X" And btnCasilla2.Text = "X" And btnCasilla3.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        If btnCasilla4.Text = "X" And btnCasilla5.Text = "X" And btnCasilla6.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        If btnCasilla7.Text = "X" And btnCasilla8.Text = "X" And btnCasilla9.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        If btnCasilla1.Text = "X" And btnCasilla4.Text = "X" And btnCasilla7.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        If btnCasilla2.Text = "X" And btnCasilla5.Text = "X" And btnCasilla8.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        If btnCasilla3.Text = "X" And btnCasilla6.Text = "X" And btnCasilla9.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        If btnCasilla1.Text = "X" And btnCasilla5.Text = "X" And btnCasilla9.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        If btnCasilla3.Text = "X" And btnCasilla5.Text = "X" And btnCasilla7.Text = "X" Then
            contX = contX + 1
            MsgBox("Felicidades X has ganado.")
            finPartida()
        End If

        'Ganador O
        If btnCasilla1.Text = "O" And btnCasilla2.Text = "O" And btnCasilla3.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        If btnCasilla4.Text = "O" And btnCasilla5.Text = "O" And btnCasilla6.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        If btnCasilla7.Text = "O" And btnCasilla8.Text = "O" And btnCasilla9.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        If btnCasilla1.Text = "O" And btnCasilla4.Text = "O" And btnCasilla7.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        If btnCasilla2.Text = "O" And btnCasilla5.Text = "O" And btnCasilla8.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        If btnCasilla3.Text = "O" And btnCasilla6.Text = "O" And btnCasilla9.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        If btnCasilla1.Text = "O" And btnCasilla5.Text = "O" And btnCasilla9.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        If btnCasilla3.Text = "O" And btnCasilla5.Text = "O" And btnCasilla7.Text = "O" Then
            contO = contO + 1
            MsgBox("Felicidades O has ganado.")
            finPartida()
        End If

        'Empate
        If contTurnos = 9 Then
            MsgBox("¡Empate!")
            finPartida()
        End If
    End Sub

    Public Sub finPartida()
        btnCasilla1.Text = ""
        btnCasilla1.Enabled = True
        btnCasilla2.Text = ""
        btnCasilla2.Enabled = True
        btnCasilla3.Text = ""
        btnCasilla3.Enabled = True
        btnCasilla4.Text = ""
        btnCasilla4.Enabled = True
        btnCasilla5.Text = ""
        btnCasilla5.Enabled = True
        btnCasilla6.Text = ""
        btnCasilla6.Enabled = True
        btnCasilla7.Text = ""
        btnCasilla7.Enabled = True
        btnCasilla8.Text = ""
        btnCasilla8.Enabled = True
        btnCasilla9.Text = ""
        btnCasilla9.Enabled = True

        contTurnos = 0

        lblTurno.Text = "Seleccione una casilla"
        turno = "X"
    End Sub
    Private Sub BtnCasilla1_Click(sender As Object, e As EventArgs) Handles btnCasilla1.Click
        turnos(1, turno)
    End Sub

    Private Sub BtnCasilla2_Click(sender As Object, e As EventArgs) Handles btnCasilla2.Click
        turnos(2, turno)
    End Sub

    Private Sub BtnCasilla3_Click(sender As Object, e As EventArgs) Handles btnCasilla3.Click
        turnos(3, turno)
    End Sub

    Private Sub BtnCasilla4_Click(sender As Object, e As EventArgs) Handles btnCasilla4.Click
        turnos(4, turno)
    End Sub

    Private Sub BtnCasilla5_Click(sender As Object, e As EventArgs) Handles btnCasilla5.Click
        turnos(5, turno)
    End Sub

    Private Sub BtnCasilla6_Click(sender As Object, e As EventArgs) Handles btnCasilla6.Click
        turnos(6, turno)
    End Sub

    Private Sub BtnCasilla7_Click(sender As Object, e As EventArgs) Handles btnCasilla7.Click
        turnos(7, turno)
    End Sub

    Private Sub BtnCasilla8_Click(sender As Object, e As EventArgs) Handles btnCasilla8.Click
        turnos(8, turno)
    End Sub

    Private Sub BtnCasilla9_Click(sender As Object, e As EventArgs) Handles btnCasilla9.Click
        turnos(9, turno)
    End Sub
End Class
