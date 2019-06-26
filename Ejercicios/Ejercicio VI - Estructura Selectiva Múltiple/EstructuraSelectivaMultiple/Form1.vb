Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Numero As Integer

        If txtNumero.Text = "" Then
            'Hola 😄
        Else
            Numero = txtNumero.Text
        End If

        Dim Dia As String = Convertidor(Numero)

        If Convertidor(Numero) = "Error" Then
            MsgBox("Error, agregue o utilice otro número.")
        Else
            txtDia.Text = Dia
        End If

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNumero.Text = ""
        txtDia.Text = ""
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
