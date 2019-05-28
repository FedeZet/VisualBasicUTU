Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer2.Enabled = True
    End Sub

    Private Numero As Integer = 0

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Numero Mod 2 = 0 Then
            lblImagen1.Visible = True
            lblImagen2.Visible = False
        Else
            lblImagen1.Visible = False
            lblImagen2.Visible = True
        End If
        Numero = Numero + 1
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblHora.Text = TimeOfDay
    End Sub
End Class
