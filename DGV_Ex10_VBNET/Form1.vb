Public Class Form1
    Sub InicializarDataGridView() ' Criar DGV

        ' Criar Coluna
        dgvNomes.Columns.Add("Nome", "Nomes")
    End Sub
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Dim inputValido As Boolean ' Se o Input Não for Compativel
        Dim nome As String ' Guardar Nome Inserido
        Dim nrNome As Integer ' Variavel Guardar Nr para Verificar se é Input Válido 
        nome = txtNome.Text ' Guardar Nome Inserido

        Try
            nrNome = Convert.ToInt16(nome) ' Verificar se Converte
            inputValido = False ' Se Converteu Input Não Válido
        Catch ex As Exception
            inputValido = True ' Se Não Converteu Input é Válido
        End Try

        If nome <> "" And inputValido = True Then ' Se o Nome Não é Vazio e o Input é Valido
            dgvNomes.Rows.Add(nome) ' Adicionar Nome
        Else
            MessageBox.Show("Insira um Nome Válido Por Favor!") ' Senão, Nova Window a Pedir Dados Corretos
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarDataGridView() ' Inicializar DGV
    End Sub

    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnContar.Click
        Dim contagem As Integer ' VAR guardar a contagem Nomes
        contagem = dgvNomes.Rows.Count ' Guardar Contagem
        MessageBox.Show(Convert.ToString(contagem - 1)) ' Mostrar Contagem Nova Window
    End Sub

    Private Sub btnEliminarTodos_Click(sender As Object, e As EventArgs) Handles btnEliminarTodos.Click
        dgvNomes.Rows.Clear() ' Apagar Tudo
        ' Aparecer Mensagem de Lista Vazia
        Try
            dgvNomes.Rows.RemoveAt(0) ' Tentar Remover 1 Linha
        Catch ex As Exception
            MessageBox.Show("Lista Vazia") ' Quando Vazia
        End Try
    End Sub

    Private Sub btnEliminaFirst_Click(sender As Object, e As EventArgs) Handles btnEliminaFirst.Click
        ' Tentar Apagar 1 Nome se Não Estiver Vazia
        Try
            dgvNomes.Rows.RemoveAt(0) ' Apagar 1 Linha
        Catch ex As Exception
            MessageBox.Show("Lista Vazia") ' Quando Vazia
        End Try
    End Sub
End Class
