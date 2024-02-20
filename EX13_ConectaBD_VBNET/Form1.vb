Imports System.DirectoryServices.ActiveDirectory

Public Class Form1
    Private Sub btnCopiaBDProdutos_Click(sender As Object, e As EventArgs) Handles btnCopiaBDProdutos.Click
        ' Estanciar Classe Nova
        Dim obj As New DataBaseAccess

        ' Definir a String SQL
        Dim strSQL As String

        ' Definir a String SQL
        Dim strSQLInv0 As String

        ' Definir a String Connection 
        Dim strConn As String = obj.ConnectionString()

        ' Se o Botão Todos para a BD estiver Acionado
        If rbtTodosBdParaGrid.Checked Then

            ' Definir a String SQL
            strSQL = "SELECT * FROM Produtos"

            ' Trazer os Fornecedores e atribui-los à Grid
            dgvBD.DataSource = obj.BuscarDados(strConn, strSQL)

            ' Se o Botão QTD 0 estiver Acionado
        ElseIf rbtBdParaGridQtdZero.Checked Then

            ' Definir a String SQL
            strSQLInv0 = "SELECT * FROM Produtos WHERE Existências = 0"

            ' Trazer os Fornecedores e atribui-los à Grid
            dgvBD.DataSource = obj.BuscarDados(strConn, strSQLInv0)
        End If
    End Sub
    ' ######################### FUNÇÃO PROCURAR LINHA DGV ################################## 
    'Function ProcurarLinhaDGV(dgv As DataGridView, str As String) As Integer

    '    ' ####################### DECLARAÇÕES #################################

    '    Dim dgvBD As New DataGridView ' Declarar dgvBD como DataGridView
    '    Dim nome As String ' Declarar nome como String
    '    Dim pos As Integer ' Declarar pos como inteiro
    '    Dim index As Integer = 0
    '    Dim existe As Boolean = False
    '    ' ####################### INICIALIZAÇÕES ##############################

    '    dgvBD = dgv ' Inicializar dgvBD com argumento recebido dgv
    '    nome = str ' Inicializar nome com argumento recebido str


    '    ' #################### PROCUAR LINHA DGV #############################

    '    For i = dgvBD.Rows.Count - 1 To 0 Step -1 ' Ciclo do Tamanho de DGV até 0
    '        If nome = dgvBD.Rows(i).Cells(1).Value.ToString() Then ' Se Nome igual a Algum da DGV
    '            pos = i ' Guardar a Posição
    '        Else
    '            pos = -1
    '        End If
    '    Next

    '    While index < dgvBD.Rows.Count - 1 And existe = False
    '        If nome = dgvBD.Rows(index).Cells(1).Value.ToString() Then ' Se Nome igual a Algum da DGV
    '            pos = index ' Guardar a Posição
    '            existe = True
    '        End If
    '        index = index + 1
    '    End While
    '    Return pos
    'End Function

    ' ######################## FUNÇÃO PROCURAR LINHA LISTBOX #######################################
    Function ProcurarLinhaLST(lst As ListBox, str As String) As Integer

        ' ####################### DECLARAÇÕES #################################

        Dim lstNomesGrid As New ListBox ' Declarar lstNomesGrid como ListBox
        Dim nome As String ' Declarar nome como String
        Dim pos As Integer ' Declarar pos como inteiro

        ' ####################### INICIALIZAÇÕES ##############################

        lstNomesGrid = lst ' Inicializar lstNomesGrid com argumento recebido lst
        nome = str ' Inicializar nome com argumento recebido str
        pos = -1 ' Inicializar pos com -1 Para se Não Encontrar

        ' #################### PROCUAR LINHA LISTBOX #############################

        For i = lstNomesGrid.Items.Count - 1 To 0 Step -1 'ciclo tamanho linhas ate 0
            If nome = lstNomesGrid.Items(i) Then ' se nome for Igual a Algum da Lista
                pos = i
            End If
        Next

        Return pos
    End Function

    Private Sub btnLimpaGrid_Click(sender As Object, e As EventArgs) Handles btnLimpaGrid.Click
        dgvBD.DataSource = Nothing ' Limpar A lista
    End Sub

    Private Sub btnRemoveNomeGrid_Click(sender As Object, e As EventArgs) Handles btnRemoveNomeGrid.Click
        Dim nome As String ' declarar variavel
        Dim pos As Integer ' Declarar variavel
        'pos = ProcurarLinhaDGV(dgvBD, nome) ' Inicializar Variavel
        nome = txtRemoverNomeGrid.Text ' inicializar variavel

        For i = dgvBD.Rows.Count - 1 To 0 Step -1 ' Ciclo do Tamanho de DGV até 0
            If nome = dgvBD.Rows(i).Cells(1).Value.ToString() Then ' Se Nome igual a Algum da DGV
                dgvBD.Rows.RemoveAt(i)
            End If
        Next

    End Sub

    Private Sub btnContaGrid_Click(sender As Object, e As EventArgs) Handles btnContaGrid.Click
        txtContarGrid.Text = Convert.ToString(dgvBD.Rows.Count) ' Contar Linhas DGV
    End Sub

    Private Sub btnNomesGridParaList_Click(sender As Object, e As EventArgs) Handles btnNomesGridParaList.Click
        For i = 0 To dgvBD.Rows.Count - 1
            lstNomesGrid.Items.Add(dgvBD.Rows(i).Cells(1).Value.ToString) ' Copiar Nomes DGV para ListBox
        Next
    End Sub

    Private Sub btnLimparList_Click(sender As Object, e As EventArgs) Handles btnLimparList.Click
        lstNomesGrid.Items.Clear() ' Apagar Lista
    End Sub

    Private Sub btnContarList_Click(sender As Object, e As EventArgs) Handles btnContarList.Click
        MessageBox.Show(Convert.ToString(lstNomesGrid.Items.Count), "Dados: ", MessageBoxButtons.OK, MessageBoxIcon.Information) ' Contar Elementos da Lista
    End Sub

    Private Sub btnEliminarNomeLista_Click(sender As Object, e As EventArgs) Handles btnEliminarNomeLista.Click
        Dim nome As String ' Declarar Variavél 
        Dim pos As Integer ' Declarar Variavel

        nome = txtNomeAEliminar.Text ' Inicializar variavel 
        pos = ProcurarLinhaLST(lstNomesGrid, nome) ' Inicializar Variavel

        If pos = -1 Then
            MessageBox.Show("NOME INEXISTENTE !", "ERRO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lstNomesGrid.Items.RemoveAt(pos)
        End If


    End Sub

    Private Sub btnInsereDados_Click(sender As Object, e As EventArgs) Handles btnInsereDados.Click
        ' ##################### DECLARAÇÃO ##############################

        Dim nome As String ' nome do produto
        Dim fornecedor As String ' codigo fornecedor
        Dim categoria As String ' codigo categoria
        Dim preco As String ' preço produto

        ' ###################### INICIALIZAÇÃO ########################
        nome = txtInsereNome.Text
        fornecedor = txtInsereFornecedor.Text
        categoria = txtInsereCategoria.Text
        preco = txtInserePreco.Text

        ' Estanciar Classe Nova
        Dim obj As New DataBaseAccess

        ' Definir a String SQL
        Dim strSQL As String
        Dim strSQLshow As String
        ' Definir a String Connection 
        Dim strConn As String = obj.ConnectionString()

        strSQL = "INSERT INTO Produtos (NomeDoProduto, CódigoDoFornecedor, CódigoDaCategoria, PreçoUnitário, Descontinuado) VALUES (" + "'" + nome + "', '" + fornecedor + "', '" + categoria + "', '" + preco + "', 'False');"
        MessageBox.Show(strSQL)
        ' Trazer a Query e atribui-los à Grid

        dgvBD.DataSource = obj.BuscarDados(strConn, strSQL)
        strSQLshow = "SELECT * FROM Produtos"
        dgvBD.DataSource = obj.BuscarDados(strConn, strSQLshow)

    End Sub

    Private Sub btnContarProdutos_Click(sender As Object, e As EventArgs) Handles btnContarProdutos.Click
        ' Contar Produtos

        Dim strSQL As String = "SELECT COUNT(Produtos.NomeDoProduto)   
                                FROM Produtos" 'QUERY Buscar COUNT 
        Dim obj As New DataBaseAccess ' Estanciar Nova Classe
        Dim strConn As String = obj.ConnectionString() ' Definir a String Connection
        Dim tabela As DataTable = obj.BuscarDados(strConn, strSQL) 'Receber Dados da Query
        txtContaProdutos.Text = tabela(0)(0).ToString() 'Enviar esses Dados para TextBox
    End Sub

    Private Sub btnAtualizarLinha_Click(sender As Object, e As EventArgs) Handles btnAtualizarLinha.Click
        ' ####################### DECLARAÇÕES #################################
        Dim NomeProdutos As String
        Dim CodigoFornecedor As String
        Dim CodigoCategoria As String
        Dim Preco As String
        Dim Existencias As String
        Dim UnidadesEncomendas As String
        Dim ExistenciaMinima As String
        Dim Descontinuado As String
        Dim id As String
        ' Estanciar Classe Nova
        Dim obj As New DataBaseAccess

        ' Definir a String SQL
        Dim strSQL As String

        ' Definir a String Connection 
        Dim strConn As String = obj.ConnectionString()

        ' ####################### INICIALIZAÇÕES ##############################
        NomeProdutos = dgvBD.CurrentRow.Cells(1).Value.ToString()
        CodigoFornecedor = dgvBD.CurrentRow.Cells(2).Value.ToString()
        CodigoCategoria = dgvBD.CurrentRow.Cells(3).Value.ToString()
        Preco = dgvBD.CurrentRow.Cells(4).Value.ToString()
        Existencias = dgvBD.CurrentRow.Cells(5).Value.ToString()
        UnidadesEncomendas = dgvBD.CurrentRow.Cells(6).Value.ToString()
        ExistenciaMinima = dgvBD.CurrentRow.Cells(7).Value.ToString()
        Descontinuado = dgvBD.CurrentRow.Cells(8).Value.ToString()
        id = dgvBD.CurrentRow.Cells(0).Value.ToString()

        strSQL = "UPDATE Produtos
                  SET NomeDoProduto = '" + NomeProdutos +
                  "', CódigoDoFornecedor = '" + CodigoFornecedor +
                  "', CódigoDaCategoria = '" + CodigoCategoria +
                  "', PreçoUnitário = '" + Preco +
                  "', Existências = '" + Existencias +
                  "', UnidadesEncomendadas = '" + UnidadesEncomendas +
                  "', ExistênciaMínima = '" + ExistenciaMinima +
                  "', Descontinuado = '" + Descontinuado +
                  "'
                  WHERE CódigoDoProduto = '" + id + "';"
        MessageBox.Show(strSQL)
        obj.BuscarDados(strConn, strSQL)

    End Sub
End Class
