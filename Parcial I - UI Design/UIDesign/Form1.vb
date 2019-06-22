Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.lblHora.Text = String.Format("{00:HH:mm:ss}", DateTime.Now)
        tmHora.Interval = 1000
        tmHora.Start()
    End Sub
    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Dim x, y, ancho, alto As Integer
        ancho = 100
        alto = 100
        x = (pbFoto.Width - ancho) / 2
        y = (pbFoto.Height - alto) / 2
        Dim pn As New Pen(Color.White, 5)

        ofdFoto.Filter = "Image Files |*.jpg;*.png"
        Dim eleccion As Integer = ofdFoto.ShowDialog(Me)

        If eleccion = DialogResult.OK Then
            pbFoto.Image = System.Drawing.Image.FromFile(ofdFoto.FileName)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
            Dim figura As GraphicsPath = New GraphicsPath
            figura.AddEllipse(New Rectangle(x, y, ancho, alto))
            pbFoto.Region = New Region(figura)
        End If
    End Sub

    Private Sub TmHora_Tick(sender As Object, e As EventArgs) Handles tmHora.Tick
        Me.lblHora.Text = String.Format("{00:HH:mm:ss}", DateTime.Now)
    End Sub
    Private Sub BtnSalario_Click(sender As Object, e As EventArgs) Handles btnSalario.Click
        btnSalario.BackColor = ColorTranslator.FromHtml("#0C86C8")
        btnDiasMes.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnNomDia.BackColor = ColorTranslator.FromHtml("#00A6FF")
        Salario.Show()
    End Sub
    Private Sub btnDiasMes_Click(sender As Object, e As EventArgs) Handles btnDiasMes.Click
        btnSalario.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnDiasMes.BackColor = ColorTranslator.FromHtml("#0C86C8")
        btnNomDia.BackColor = ColorTranslator.FromHtml("#00A6FF")
    End Sub

    Private Sub BtnNomDia_Click(sender As Object, e As EventArgs) Handles btnNomDia.Click
        btnSalario.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnDiasMes.BackColor = ColorTranslator.FromHtml("#00A6FF")
        btnNomDia.BackColor = ColorTranslator.FromHtml("#0C86C8")
    End Sub
End Class