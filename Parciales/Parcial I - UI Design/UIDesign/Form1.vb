Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblHora.Text = String.Format("{00:HH:mm:ss}", DateTime.Now)
        tmHora.Interval = 1000
        tmHora.Start()
    End Sub

    Private Sub TmHora_Tick(sender As Object, e As EventArgs) Handles tmHora.Tick
        Me.lblHora.Text = String.Format("{00:HH:mm:ss}", DateTime.Now)
    End Sub
    Private Sub BtnSalario_Click(sender As Object, e As EventArgs) Handles btnSalario.Click
        btnSalario.BackColor = ColorTranslator.FromHtml("#0C86C8")
        btnDiasMes.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnNomDia.BackColor = ColorTranslator.FromHtml("#00A6FF")
        gbBienvenida.Visible = False
        gbDiaMes.Visible = False
        gbNomDia.Visible = False
        gbSalario.Visible = True
    End Sub
    Private Sub btnDiasMes_Click(sender As Object, e As EventArgs) Handles btnDiasMes.Click
        btnSalario.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnDiasMes.BackColor = ColorTranslator.FromHtml("#0C86C8")
        btnNomDia.BackColor = ColorTranslator.FromHtml("#00A6FF")
        gbBienvenida.Visible = False
        gbSalario.Visible = False
        gbNomDia.Visible = False
        gbDiaMes.Visible = True
    End Sub

    Private Sub BtnNomDia_Click(sender As Object, e As EventArgs) Handles btnNomDia.Click
        btnSalario.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnDiasMes.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnNomDia.BackColor = ColorTranslator.FromHtml("#0C86C8")
        gbBienvenida.Visible = False
        gbSalario.Visible = False
        gbDiaMes.Visible = False
        gbNomDia.Visible = True
    End Sub

    Private Sub BtnSCalcular_Click(sender As Object, e As EventArgs) Handles btnSCalcular.Click
        Dim Total, Trabajo, Sindicato, Servicio, Hijos As Integer
        Total = 0
        Trabajo = 0
        Sindicato = 0
        Servicio = 0

        If (rbtnSTObrero.Checked = True) Then
            Trabajo = 800
            Total = Trabajo
        ElseIf (rbtnSTAdministrativo.Checked = True) Then
            Trabajo = 900
            Total = Trabajo
        ElseIf (rbtnSTTecnico.Checked = True) Then
            Trabajo = 1000
            Total = Trabajo
        ElseIf (rbtnSTProfesional.Checked = True) Then
            Trabajo = 1200
            Total = Trabajo
        End If

        If (rbtnSISi.Checked = True) Then
            Sindicato = 50
            Total = Total + Sindicato
        End If

        If (rbtnSASEntre5y10.Checked = True) Then
            Servicio = 100
            Total = Total + Servicio
        ElseIf (rbtnSASMas10.Checked = True) Then
            Servicio = 200
            Total = Total + Servicio
        End If

        Hijos = nudSHijos.Value * 100
        Total = Total + Hijos

        MsgBox("Clase trabajador: US$" + Trabajo.ToString + vbNewLine + "Sindicato: US$" + Sindicato.ToString + vbNewLine + "Años de servicio: US$" + Servicio.ToString + vbNewLine + "Hijos: US$" + Hijos.ToString + vbNewLine + vbNewLine + "Total: US$" + Total.ToString)
    End Sub

    Private Sub BtnSLimpiar_Click(sender As Object, e As EventArgs) Handles btnSLimpiar.Click
        rbtnSTObrero.Checked = True
        rbtnSINo.Checked = True
        rbtnSASMenos5.Checked = True
        nudSHijos.Value = 0
    End Sub

    Private Sub BtnDMCalcular_Click(sender As Object, e As EventArgs) Handles btnDMCalcular.Click
        Dim Mes As Integer = txtDMNumMes.Text
        Dim Anio As Integer = txtDMAnio.Text

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

    Private Sub BtnDMLimpiar_Click(sender As Object, e As EventArgs) Handles btnDMLimpiar.Click
        txtDMNumMes.Text = ""
        txtDMAnio.Text = ""
    End Sub

    Private Sub BtnNDDCalcular_Click(sender As Object, e As EventArgs) Handles btnNDDCalcular.Click
        Dim Numero As Integer

        If txtNDDNumero.Text <> "" Then
            Numero = txtNDDNumero.Text
        End If

        Dim Dia As String = NDConvertidor(Numero)

        If NDConvertidor(Numero) = "Error" Then
            MsgBox("Error, agregue o utilice otro número.")
        Else
            txtNDNSemana.Text = Dia
        End If
    End Sub

    Private Sub BtnNDDLimpiar_Click(sender As Object, e As EventArgs) Handles btnNDDLimpiar.Click
        txtNDDNumero.Text = ""
        txtNDNSemana.Text = ""
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class