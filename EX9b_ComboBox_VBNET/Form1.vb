Public Class Form1
    Private Sub btnAdicionarString_Click(sender As Object, e As EventArgs) Handles btnAdicionarString.Click
        cbxLista.Items.Add(txtNome.Text)
    End Sub

    Private Sub btnContarElementos_Click(sender As Object, e As EventArgs) Handles btnContarElementos.Click
        Dim count As String
        count = Convert.ToString(cbxLista.Items.Count)
        MessageBox.Show(count)
    End Sub

    Private Sub btnEliminarPrimeiro_Click(sender As Object, e As EventArgs) Handles btnEliminarPrimeiro.Click
        Try
            cbxLista.Items.RemoveAt(0)
            MessageBox.Show("Registo Eliminado")
        Catch ex As Exception
            MessageBox.Show("Lista Sem Dados")
        End Try
    End Sub

    Private Sub btnEliminarUltimo_Click(sender As Object, e As EventArgs) Handles btnEliminarUltimo.Click
        Dim count As Integer
        count = cbxLista.Items.Count - 1
        Try
            cbxLista.Items.RemoveAt(count)
            MessageBox.Show("Registo Eliminado")
        Catch ex As Exception
            MessageBox.Show("Não há Dados na Lista")
        End Try
    End Sub

    Private Sub btnEliminarSelecionado_Click(sender As Object, e As EventArgs) Handles btnEliminarSelecionado.Click
        cbxLista.Items.Remove(cbxLista.SelectedItem)
        MessageBox.Show("Registo Selecionado Eliminado")
    End Sub

    Private Sub btnLimparTodos_Click(sender As Object, e As EventArgs) Handles btnLimparTodos.Click
        cbxLista.Items.Clear()
        MessageBox.Show("Tudo Eliminado")
    End Sub

    Private Sub btnExisteNome_Click(sender As Object, e As EventArgs) Handles btnExisteNome.Click
        Dim nome As String
        Dim existe As Boolean
        nome = txtNome.Text

        If cbxLista.Items.Contains(Convert.ToString(nome)) Then
            MessageBox.Show("O Nome está na Lista")
        Else
            MessageBox.Show("O Nome não está na Lista")
        End If

    End Sub
End Class
