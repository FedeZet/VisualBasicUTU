Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Mes As Integer = txtMes.Text
        Dim Anio As Integer = txtAnio.Text

        If (Mes >= 1 And Mes <= 12) Then
            If (Anio >= 1919 And Anio <= 2119) Then
                Dim Dias As Integer = System.DateTime.DaysInMonth(Anio, Mes)
                MsgBox("El mes tiene " + Dias.ToString + " días.")
            Else
                MsgBox("El año ingresado no es correcto.")
            End If
        Else
            MsgBox("El mes ingresado no es correcto, eliga desde el 1 al 12.")
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtMes.Text = ""
        txtAnio.Text = ""
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
