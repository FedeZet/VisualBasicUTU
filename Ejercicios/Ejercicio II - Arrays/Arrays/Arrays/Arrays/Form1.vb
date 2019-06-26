Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Edades() As Integer = {14, 29, 80, 17, 16, 20, 25}
        Dim Suma, Promedio As Integer
        Suma = 0

        For Each items As Integer In Edades
            ComboBox1.Items.Add(items)
            Suma = items + Suma
        Next

        Promedio = Suma / 7
        TextBox1.Text = Promedio.ToString

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
