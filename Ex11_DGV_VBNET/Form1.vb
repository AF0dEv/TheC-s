Imports System.ComponentModel.DataAnnotations
Imports System.Text

Public Class Form1
    Sub InicializarDGV()
        ' Tentar AddRange
        'Dim Col1 As DataGridViewColumn()
        'Dim Col2 As DataGridViewColumn
        'dgvRegistos.Columns.AddRange(Col1, Col2)

        dgvRegistos.Columns.Add("Nome", "Nomes")
        dgvRegistos.Columns.Add("Cidade", "Cidades")
        dgvRegistos.Columns.Add("Ano Nascimento", "Anos Nasc.")

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDGV()
    End Sub

    Private Sub btnInicializar_Click(sender As Object, e As EventArgs) Handles btnInicializar.Click
        Dim registo1 As New DataGridViewRow()
        Dim registo2 As New DataGridViewRow()
        Dim registo3 As New DataGridViewRow()
        Dim registo4 As New DataGridViewRow()

        If dgvRegistos.Rows.Count = 0 Then
            dgvRegistos.Rows.AddRange(New DataGridViewRow() {registo1, registo2, registo3, registo4})
            registo1.Cells(0).Value = ""
            registo1.Cells(1).Value = "Porto"
            registo1.Cells(2).Value = "2000"
            registo2.Cells(0).Value = "João"
            registo2.Cells(1).Value = "Guimarães"
            registo2.Cells(2).Value = "1987"
            registo3.Cells(0).Value = ""
            registo3.Cells(1).Value = "Braga"
            registo3.Cells(2).Value = "1990"
            registo4.Cells(0).Value = "PêJota"
            registo4.Cells(1).Value = "Trofa"
            registo4.Cells(2).Value = "1968"
        Else
            MessageBox.Show("A Lista já tem Registos")
        End If
    End Sub

    Private Sub btnEliminarTudo_Click(sender As Object, e As EventArgs) Handles btnEliminarTudo.Click
        'dgvRegistos.Columns.Clear()
        dgvRegistos.Rows.Clear()
    End Sub

    Private Sub btnInserirRegisto_Click(sender As Object, e As EventArgs) Handles btnInserirRegisto.Click
        Dim nome As String
        Dim cidade As String
        Dim ano As Integer
        Dim NomeValido As Boolean
        Dim CidadeValido As Boolean
        Dim AnoValido As Boolean

        Try
            ano = Convert.ToInt16(txtAno.Text)
            AnoValido = True
        Catch ex As Exception
            AnoValido = False
        End Try

        Try
            nome = Convert.ToInt16(txtNome.Text)
            NomeValido = False
        Catch ex As Exception
            NomeValido = True
        End Try
        Try
            cidade = Convert.ToInt16(txtCidade.Text)
            CidadeValido = False
        Catch ex As Exception
            CidadeValido = True
        End Try
        If NomeValido = True And CidadeValido = True And AnoValido = True Then
            dgvRegistos.Rows.Add(txtNome.Text, txtCidade.Text, Convert.ToString(ano))
        Else
            MessageBox.Show("Insira Dados Validos")
        End If

    End Sub

    Private Sub btnMostrarNomes_Click(sender As Object, e As EventArgs) Handles btnMostrarNomes.Click
        If dgvRegistos.RowCount > 0 Then
            mostrarEmMessageBox(dgvRegistos)
        Else
            MessageBox.Show("Nao ha dados na tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub mostrarEmMessageBox(dataGridView As DataGridView)
        Dim message As New StringBuilder()
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                message.Append(cell.Value?.ToString() & "   ")
            Next
            message.AppendLine()
        Next
        MessageBox.Show(message.ToString(), "Dados: ", MessageBoxButtons.OK, MessageBoxIcon.Information)


        'Dim nomes As String
        'For i = 0 To dgvRegistos.Rows.Count - 1
        '    nomes = nomes + dgvRegistos.Rows(i).Cells(0).Value + " "

        'Next
        'MessageBox.Show(nomes)

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Dim nome As String
        Dim existe As Boolean
        Dim pos As Integer
        nome = txtNomeSearchDestroy.Text

        If dgvRegistos.Rows.Count <= 0 Then
            MessageBox.Show("Nao ha dados na tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For i = 0 To dgvRegistos.Rows.Count - 1
                If dgvRegistos.Rows(i).Cells(0).Value = nome Then
                    existe = True
                    pos = i + 1
                End If
            Next
        End If

        If existe = True Then
            MessageBox.Show("Este Nome existe, esta na linha " + pos.ToString(), "Dados: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf existe = False And dgvRegistos.Rows.Count > 0 Then
            MessageBox.Show("Nao ha este dado na tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnEliminarNome_Click(sender As Object, e As EventArgs) Handles btnEliminarNome.Click
        Dim nome As String
        Dim pos As String
        Dim existe As Boolean
        nome = txtNomeSearchDestroy.Text
        If dgvRegistos.Rows.Count <= 0 Then
            MessageBox.Show("Nao ha dados na tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For i = 0 To dgvRegistos.Rows.Count - 1
                If dgvRegistos.Rows(i).Cells(0).Value = nome Then
                    existe = True
                    pos = i
                End If
            Next
        End If

        If existe = True Then
            dgvRegistos.Rows.RemoveAt(pos)
        ElseIf existe = False And dgvRegistos.Rows.Count > 0 Then
            MessageBox.Show("Nao ha este dado na tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarLinhasVazias_Click(sender As Object, e As EventArgs) Handles btnEliminarLinhasVazias.Click
        Dim pos As Integer
        Dim tamanho As Integer
        tamanho = dgvRegistos.Rows.Count - 1
        If dgvRegistos.Rows.Count <= 0 Then
            MessageBox.Show("Nao ha dados na tabela", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For i = tamanho To 0 Step -1
                If String.IsNullOrEmpty(dgvRegistos.Rows(i).Cells(0).Value.ToString()) Then
                    dgvRegistos.Rows.RemoveAt(i)
                End If
            Next
        End If
    End Sub
End Class
