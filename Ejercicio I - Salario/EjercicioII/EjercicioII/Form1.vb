Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Total, Trabajo, Sindicato, Servicio, Hijos As Integer
        Total = 0
        Trabajo = 0
        Sindicato = 0
        Servicio = 0

        If (RadioButton1.Checked = True) Then
            Trabajo = 800
            Total = Trabajo
        ElseIf (RadioButton2.Checked = True) Then
            Trabajo = 900
            Total = Trabajo
        ElseIf (RadioButton3.Checked = True) Then
            Trabajo = 1000
            Total = Trabajo
        ElseIf (RadioButton4.Checked = True) Then
            Trabajo = 1200
            Total = Trabajo
        End If

        If (RadioButton5.Checked = True) Then
            Sindicato = 50
            Total = Total + Sindicato
        End If

        If (RadioButton8.Checked = True) Then
            Servicio = 100
            Total = Total + Servicio
        ElseIf (RadioButton9.Checked = True) Then
            Servicio = 200
            Total = Total + Servicio
        End If

        Hijos = NumericUpDown1.Value * 100
        Total = Total + Hijos

        MsgBox("Clase trabajador: US$" + Trabajo.ToString + vbNewLine + "Sindicato: US$" + Sindicato.ToString + vbNewLine + "Años de servicio: US$" + Servicio.ToString + vbNewLine + "Hijos: US$" + Hijos.ToString + vbNewLine + vbNewLine + "Total: US$" + Total.ToString)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = True
        RadioButton6.Checked = True
        RadioButton7.Checked = True
        NumericUpDown1.Value = 0
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class