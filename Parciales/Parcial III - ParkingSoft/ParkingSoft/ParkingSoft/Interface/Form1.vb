Public Class Form1

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        AbrirFormulario(Of RegistroVehículo)()
    End Sub

    Private Sub btnRetirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetirar.Click

    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub AbrirFormulario(Of T As {Form, New})()
        Dim formulario As Form = Panel2.Controls.OfType(Of T)().FirstOrDefault()

        If formulario IsNot Nothing Then

            If formulario.WindowState = FormWindowState.Minimized Then
                formulario.WindowState = FormWindowState.Normal
            End If

            formulario.BringToFront()
            Return
        End If

        formulario = New T()
        formulario.TopLevel = False
        Panel2.Controls.Add(formulario)
        Panel2.Tag = formulario
        formulario.Show()
    End Sub
End Class


