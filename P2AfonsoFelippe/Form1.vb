Public Class Form1

    Dim obj As New DataBaseAccess

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Inicia a dataGridView com todos os dados da tabela Produtos
        dgvProdutos.DataSource = buscarDataTable()

        'Carrega a comboBox Fornecedores com os dados da tabela Fornecedores, e adiciona um nova linha "Todos" com value "0"
        preencherCbxFornecedores()

        'Carrega a comboBox Categorias com os dados da tabela Categorias, e adiciona um nova linha "Todos" com value "0"
        preencherCbxCategorias()

        'Mudar aparencia da dataGridView
        formatarDataGrid()

        'Preencher as textBox de calculos
        atualizarCalculosDgv()
        atualizarCalculosSql()

    End Sub

    Sub formatarDataGrid()

        'Mudar aparencia da dataGridView
        With dgvProdutos
            .GridColor = SystemColors.ActiveBorder
            .BackgroundColor = Color.Honeydew
            .Columns(0).HeaderText = "# Prod."
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Cod. Fornecedores"
            .Columns(3).HeaderText = "Cod. Categorias"
            .Columns(4).HeaderText = "Preço"
            .Columns(4).DefaultCellStyle.Format = "C2"
            .Columns(6).HeaderText = "Unidades Encomendadas"
            .Columns(7).HeaderText = "Existências Minimas"
            .ColumnHeadersDefaultCellStyle.Font = New Font(Control.DefaultFont, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

    End Sub

    Sub preencherCbxFornecedores()

        Dim dataTable As DataTable

        'Carrega a comboBox Fornecedores com os dados da tabela Fornecedores, e adiciona um nova linha "Todos" com value "0"
        Dim ssqlFornecedores As String = "SELECT * FROM Fornecedores;"
        dataTable = obj.BuscarDados(ssqlFornecedores)
        dataTable.Rows.InsertAt(dataTable.NewRow, 0)
        dataTable.Rows(0)("NomeDaEmpresa") = "Todos"
        dataTable.Rows(0)("CódigoDoFornecedor") = 0
        cbxFornecedores.DataSource = dataTable
        cbxFornecedores.DisplayMember = "NomeDaEmpresa"
        cbxFornecedores.ValueMember = "CódigoDoFornecedor"

    End Sub

    Sub preencherCbxCategorias()

        Dim dataTable As DataTable

        'Carrega a comboBox Categorias com os dados da tabela Categorias, e adiciona um nova linha "Todos" com value "0"
        Dim ssqlCategorias As String = "SELECT * FROM Categorias;"
        dataTable = obj.BuscarDados(ssqlCategorias)
        dataTable.Rows.InsertAt(dataTable.NewRow, 0)
        dataTable.Rows(0)("NomeDaCategoria") = "Todos"
        dataTable.Rows(0)("CódigoDaCategoria") = 0
        cbxCategorias.DataSource = dataTable
        cbxCategorias.DisplayMember = "NomeDaCategoria"
        cbxCategorias.ValueMember = "CódigoDaCategoria"

    End Sub

    Private Sub cbxCategorias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxCategorias.SelectionChangeCommitted

        dgvProdutos.DataSource = buscarDataTable()
        atualizarCalculosDgv()
        atualizarCalculosSql()

    End Sub

    Private Sub cbxFornecedores_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxFornecedores.SelectionChangeCommitted

        dgvProdutos.DataSource = buscarDataTable()
        atualizarCalculosDgv()
        atualizarCalculosSql()

    End Sub

    Private Sub btnTodasCategorias_Click(sender As Object, e As EventArgs) Handles btnTodasCategorias.Click

        cbxCategorias.SelectedValue = 0
        cbxCategorias_SelectionChangeCommitted(e, e)

    End Sub

    Private Sub btnTodosFornecedores_Click(sender As Object, e As EventArgs) Handles btnTodosFornecedores.Click

        cbxFornecedores.SelectedValue = 0
        cbxFornecedores_SelectionChangeCommitted(e, e)

    End Sub

    Private Sub btnTodosProdutos_Click(sender As Object, e As EventArgs) Handles btnTodosProdutos.Click

        cbxCategorias.SelectedValue = 0
        cbxFornecedores.SelectedValue = 0

        dgvProdutos.DataSource = buscarDataTable()
        atualizarCalculosDgv()
        atualizarCalculosSql()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function buscarDataTable() As DataTable

        Dim dataTable As New DataTable
        Dim ssql As String

        Try

            Dim codFornecedor As String = cbxFornecedores.SelectedValue.ToString()
            Dim codCategoria As String = cbxCategorias.SelectedValue.ToString()

            If codCategoria <> "0" And codFornecedor = "0" Then
                ssql = "SELECT * FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + ";"
            ElseIf codFornecedor <> "0" And codCategoria = "0" Then
                ssql = "SELECT * FROM Produtos WHERE CódigoDoFornecedor = " + codFornecedor + ";"
            ElseIf codFornecedor <> "0" And codCategoria <> "0" Then
                ssql = "SELECT * FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + "AND CódigoDoFornecedor = " + codFornecedor + ";"
            Else
                ssql = "SELECT * FROM Produtos"
            End If

            dataTable = obj.BuscarDados(ssql)

            Return dataTable

        Catch ex As Exception

            ssql = "SELECT * FROM Produtos"

            dataTable = obj.BuscarDados(ssql)

            Return dataTable

        End Try

    End Function

    Sub atualizarCalculosDgv()

        If dgvProdutos.RowCount > 0 Then

            'Calcular preco médio dgv e encontrar produto mais caro
            Dim acumulador As Decimal = 0
            Dim indiceMaiorPreco As Integer = 0

            For Each row In dgvProdutos.Rows
                acumulador += Convert.ToDecimal(row.cells("PreçoUnitário").Value)

                If row.cells("PreçoUnitário").Value > dgvProdutos.Rows(indiceMaiorPreco).Cells("PreçoUnitário").Value Then
                    indiceMaiorPreco = dgvProdutos.Rows.IndexOf(row)
                End If

            Next

            Dim nomeDoMaisCaro As String = dgvProdutos.Rows(indiceMaiorPreco).Cells("NomeDoProduto").Value.ToString()
            Dim precoDoMaisCaro As String = Convert.ToDecimal(dgvProdutos.Rows(indiceMaiorPreco).Cells("PreçoUnitário").Value).ToString("C2")

            txtProdutoMaisCaro.Text = nomeDoMaisCaro + " ( " + precoDoMaisCaro + " )"
            txtPrecoMedio.Text = (acumulador / dgvProdutos.RowCount).ToString("C2")
            txtTotalLinhas.Text = dgvProdutos.RowCount().ToString()

        Else

            txtProdutoMaisCaro.Text = ""
            txtPrecoMedio.Text = 0.ToString("C2")
            txtTotalLinhas.Text = "0"

        End If

    End Sub

    Sub atualizarCalculosSql()

        Dim codFornecedor As String = cbxFornecedores.SelectedValue.ToString()
        Dim codCategoria As String = cbxCategorias.SelectedValue.ToString()

        Dim ssqlContagem As String
        Dim ssqlProdutoMaisCaro As String
        Dim ssqlPrecoMedio As String

        Dim dataTable As New DataTable

        If codCategoria <> "0" And codFornecedor = "0" Then
            ssqlContagem = "SELECT COUNT(*) FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + ";"
            ssqlProdutoMaisCaro = "SELECT NomeDoProduto, PreçoUnitário FROM Produtos WHERE PreçoUnitário = (SELECT MAX(PreçoUnitário) FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + ") AND CódigoDaCategoria = " + codCategoria + ";"
            ssqlPrecoMedio = "SELECT AVG(PreçoUnitário) FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + ";"
        ElseIf codFornecedor <> "0" And codCategoria = "0" Then
            ssqlContagem = "SELECT COUNT(*) FROM Produtos WHERE CódigoDoFornecedor = " + codFornecedor + ";"
            ssqlProdutoMaisCaro = "SELECT NomeDoProduto, PreçoUnitário FROM Produtos WHERE PreçoUnitário = (SELECT MAX(PreçoUnitário) FROM Produtos WHERE CódigoDoFornecedor = " + codFornecedor + ") AND CódigoDoFornecedor = " + codFornecedor + ";"
            ssqlPrecoMedio = "SELECT AVG(PreçoUnitário) FROM Produtos WHERE CódigoDoFornecedor = " + codFornecedor + ";"
        ElseIf codFornecedor <> "0" And codCategoria <> "0" Then
            ssqlContagem = "SELECT COUNT(*) FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + "AND CódigoDoFornecedor = " + codFornecedor + ";"
            ssqlProdutoMaisCaro = "SELECT NomeDoProduto, PreçoUnitário FROM Produtos WHERE PreçoUnitário = (SELECT MAX(PreçoUnitário) FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + "AND CódigoDoFornecedor = " + codFornecedor + ") AND CódigoDaCategoria = " + codCategoria + "AND CódigoDoFornecedor = " + codFornecedor + ";"
            ssqlPrecoMedio = "SELECT AVG(PreçoUnitário) FROM Produtos WHERE CódigoDaCategoria = " + codCategoria + "AND CódigoDoFornecedor = " + codFornecedor + ";"
        Else
            ssqlContagem = "SELECT COUNT(*) FROM Produtos"
            ssqlProdutoMaisCaro = "SELECT NomeDoProduto, PreçoUnitário FROM Produtos WHERE PreçoUnitário = (SELECT MAX(PreçoUnitário) FROM Produtos);"
            ssqlPrecoMedio = "SELECT AVG(PreçoUnitário) AS 'Preço médio' FROM Produtos;"
        End If

        'Contagem de linhas
        Try
            dataTable = obj.BuscarDados(ssqlContagem)
            txtSqlTotalLinhas.Text = dataTable(0)(0).ToString()
        Catch ex As Exception
            txtSqlTotalLinhas.Text = ""
        End Try

        'Preço médio
        Try
            dataTable = obj.BuscarDados(ssqlPrecoMedio)
            txtSqlPrecoMedio.Text = Convert.ToDecimal(dataTable(0)(0)).ToString("C2")
        Catch ex As Exception
            txtSqlPrecoMedio.Text = 0.ToString("C2")
        End Try

        'Produto mais caro
        Try
            dataTable = obj.BuscarDados(ssqlProdutoMaisCaro)
            txtSqlProdutoMaisCaro.Text = dataTable(0)(0).ToString + " ( " + Convert.ToDecimal(dataTable(0)(1)).ToString("C2") + " )"
        Catch ex As Exception
            txtSqlProdutoMaisCaro.Text = ""
        End Try
    End Sub

End Class
