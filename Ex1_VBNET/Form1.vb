Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim n1 As Integer
        Dim n2 As Integer
        n1 = CInt(txtN1.Text)
        n2 = CInt(txtN2.Text)

        Dim resultado As Integer

        resultado = n1 + n2

        txtResultado.Text = CStr(resultado)
    End Sub
End Class
