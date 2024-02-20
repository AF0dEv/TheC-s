Public Class Form1
    Private Sub btnAdicionarString_Click(sender As Object, e As EventArgs) Handles btnAdicionarString.Click
        Dim str As String
        str = txtString.Text
        If str <> "" Then
            cbxStrings.Items.Add(str)
        End If


    End Sub

    Private Sub btnExisteString_Click(sender As Object, e As EventArgs) Handles btnExisteString.Click
        Dim existe As Boolean
        Dim str As String

        str = txtString.Text
        existe = cbxStrings.Items.Contains(str)

        If existe Then
            MessageBox.Show("Sim, Existe")
        Else
            MessageBox.Show("Não Existe")
        End If

    End Sub

    Private Sub btnEliminarUltimo_Click(sender As Object, e As EventArgs) Handles btnEliminarUltimo.Click
        Dim count As Integer
        count = cbxStrings.Items.Count
        If count <> 0 Then
            cbxStrings.Items.RemoveAt(count - 1)
        End If
    End Sub

    Private Sub btnEliminarPrimeiro_Click(sender As Object, e As EventArgs) Handles btnEliminarPrimeiro.Click
        Dim count As Integer
        count = cbxStrings.Items.Count
        If count <> 0 Then
            cbxStrings.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub btnLimpaTudo_Click(sender As Object, e As EventArgs) Handles btnLimpaTudo.Click
        cbxStrings.Items.Clear()
    End Sub

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        Try
            cbxStrings.Items.RemoveAt(cbxStrings.SelectedIndex)
        Catch ex As Exception
            MessageBox.Show("Nenhum Selecionado")
        End Try

    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        Dim count As Integer
        count = cbxStrings.Items.Count
        MessageBox.Show(Convert.ToString(count))
    End Sub
End Class
