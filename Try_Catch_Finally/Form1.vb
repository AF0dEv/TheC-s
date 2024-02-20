Public Class Form1
    Private Sub btnDuplicar_Click(sender As Object, e As EventArgs) Handles btnDuplicar.Click
        Dim varLocal As Integer

        Try
            'verifica se gera exceçao
            varLocal = Convert.ToInt16(txtTotal.Text)
        Catch ex As Exception
            ' houve exceção, faz o seguinte
            varLocal = 0
        Finally
            ' em ambos os casos anteriores, duplica e envia para a text
            txtTotal.Text = Convert.ToString(varLocal * 2)
        End Try

    End Sub
End Class
