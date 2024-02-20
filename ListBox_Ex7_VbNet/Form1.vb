Public Class Form1
    Private Sub btnInserirNome_Click(sender As Object, e As EventArgs) Handles btnInserirNome.Click
        If txtNomeInserido.Text = "" Then

        Else
            lstNomes.Items.Add(txtNomeInserido.Text)
        End If

    End Sub

    Private Sub btnContarNome_Click(sender As Object, e As EventArgs) Handles btnContarNome.Click
        txtNomesContados.Text = CStr(lstNomes.Items.Count)
    End Sub

    Private Sub btnLimparLista_Click(sender As Object, e As EventArgs) Handles btnLimparLista.Click
        lstNomes.Items.Clear()
    End Sub
End Class
