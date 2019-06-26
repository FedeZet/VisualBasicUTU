Public Class Form1
    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub soloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetras.KeyPress
        soloLetras(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String = txtCorreo.Text

        Dim verifica As String
        verifica = cadena.Contains("@gmail.com")

        If verifica = True Then
            MsgBox("La cadena contiene la palabra @gmail.com")
        Else
            MsgBox("La cadena no contiene la palabra @gmail.com")
        End If
    End Sub
End Class
