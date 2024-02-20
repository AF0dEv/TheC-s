Public Class Form1
    Private Sub btnInicializarLista_Click(sender As Object, e As EventArgs) Handles btnInicializarLista.Click
        lstClubes.Items.Add("Porto")
        lstClubes.Items.Add("Estoril")
        lstClubes.Items.Add("Braga")
        lstClubes.Items.Add("Sporting")
        lstClubes.Items.Add("Benfica")
        lstClubes.Items.Add("Santa Clara")
        lstClubes.Items.Add("Feirense")
        lstClubes.Items.Add("Boavista")
        lstClubes.Items.Add("Paços de Ferreira")
        lstClubes.Items.Add("Moreirense")
        lstClubes.Items.Add("Belenenses")
        lstClubes.Items.Add("Tondela")
        lstClubes.Items.Add("Académica")
        lstClubes.Items.Add("Varzim")
        lstClubes.Items.Add("Vizela")
        lstClubes.Items.Add("Farense")
        lstClubes.Items.Add("Freamunde")
        lstClubes.Items.Add("Aves")
        lstClubes.Items.Add("Olhanense")
        lstClubes.Items.Add("União da Madeira")
        lstClubes.Items.Add("Vianense")
        lstClubes.Items.Add("Académico de Viseu")
        lstClubes.Items.Add("Fafe")
        lstClubes.Items.Add("Covilhã")
        lstClubes.Items.Add("Portimonense")
        lstClubes.Items.Add("Salgueiros")
        lstClubes.Items.Add("Oriental")
        lstClubes.Items.Add("Atlético")
        lstClubes.Items.Add("Barreirense")
    End Sub

    Private Sub btnAdicionarLista_Click(sender As Object, e As EventArgs) Handles btnAdicionarLista.Click
        Dim Clube As String
        Clube = txtClube.Text
        lstClubes.Items.Add(Clube)
    End Sub

    Private Sub btnLimparLista_Click(sender As Object, e As EventArgs) Handles btnLimparLista.Click
        lstClubes.Items.Clear()
    End Sub

    Private Sub btnRemoverClube_Click(sender As Object, e As EventArgs) Handles btnRemoverClube.Click
        Dim Clube As String
        Dim pos As Integer
        Dim existe As Boolean
        Clube = txtClube.Text

        existe = lstClubes.Items.Contains(Clube)

        If existe Then
            pos = lstClubes.Items.IndexOf(Clube)
            lstClubes.Items.RemoveAt(pos)
        End If
    End Sub

    Private Sub btnContagem_Click(sender As Object, e As EventArgs) Handles btnContagem.Click
        txtContagem.Text = lstClubes.Items.Count
    End Sub

    Private Sub btnEliminarFirstFive_Click(sender As Object, e As EventArgs) Handles btnEliminarFirstFive.Click
        Dim contagem As Integer
        contagem = 0
        Try
            While contagem < 5
                lstClubes.Items.RemoveAt(0)
                contagem = contagem + 1
            End While
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEliminarLastFive_Click(sender As Object, e As EventArgs) Handles btnEliminarLastFive.Click
        Dim contagem As Integer
        Dim conta As Integer
        conta = lstClubes.Items.Count

        contagem = 0
        If conta > 4 Then
            While contagem < 5
                lstClubes.Items.RemoveAt(lstClubes.Items.Count - 1)
                contagem = contagem + 1
            End While
        Else
            For index = 0 To conta - 1
                lstClubes.Items.RemoveAt(0)
            Next
        End If
    End Sub

    Private Sub btnExisteLista_Click(sender As Object, e As EventArgs) Handles btnExisteLista.Click
        Dim ClubeaProcurar As String
        Dim existe As Boolean
        ClubeaProcurar = txtClubeExiste.Text
        existe = lstClubes.Items.Contains(ClubeaProcurar)
        If existe Then
            txtRespostaExiste.Text = "Sim"
        Else
            txtRespostaExiste.Text = "Não"
        End If
    End Sub

    Private Sub btnSubstituir_Click(sender As Object, e As EventArgs) Handles btnSubstituir.Click
        Dim ClubeATrocar As String
        Dim ClubeTrocado As String
        Dim existe As Boolean
        Dim pos As Integer
        ClubeATrocar = txtClubeATrocar.Text
        ClubeTrocado = txtClubeTrocado.Text

        Try
            existe = lstClubes.Items.Contains(ClubeATrocar)
            If existe Then
                pos = lstClubes.Items.IndexOf(ClubeATrocar)
                MessageBox.Show(Convert.ToString(pos + 1))
                lstClubes.Items(pos) = ClubeTrocado
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
