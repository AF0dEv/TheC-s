Public Class Form2
    Private Sub btnCriaViatura_Click(sender As Object, e As EventArgs) Handles btnCriaViatura.Click
        Dim marca As String
        marca = txtMarcaAdicionar.Text
        Dim obj As New Viatura
        Try
            obj.Criar(marca)
            MessageBox.Show("Viatura Criada com Sucesso!", "SUCESSO:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
        Catch ex As Exception
            DialogResult = DialogResult.No
            MessageBox.Show("Viatura Não Criada!", "ERRO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class