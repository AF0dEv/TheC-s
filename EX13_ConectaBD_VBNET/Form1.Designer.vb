<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btnCopiaBDProdutos = New Button()
        btnEliminarNomeLista = New Button()
        btnNomesGridParaList = New Button()
        btnLimparList = New Button()
        btnContarList = New Button()
        btnAtualizarLinha = New Button()
        btnContarProdutos = New Button()
        btnInsereDados = New Button()
        btnContaGrid = New Button()
        btnRemoveNomeGrid = New Button()
        btnLimpaGrid = New Button()
        txtInsereFornecedor = New TextBox()
        txtInserePreco = New TextBox()
        txtInsereCategoria = New TextBox()
        txtInsereNome = New TextBox()
        txtContaProdutos = New TextBox()
        Label1 = New Label()
        lstNomesGrid = New ListBox()
        txtNomeAEliminar = New TextBox()
        Label2 = New Label()
        txtContarGrid = New TextBox()
        txtRemoverNomeGrid = New TextBox()
        dgvBD = New DataGridView()
        rbtTodosBdParaGrid = New RadioButton()
        rbtBdParaGridQtdZero = New RadioButton()
        CType(dgvBD, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCopiaBDProdutos
        ' 
        btnCopiaBDProdutos.Location = New Point(14, 16)
        btnCopiaBDProdutos.Margin = New Padding(3, 4, 3, 4)
        btnCopiaBDProdutos.Name = "btnCopiaBDProdutos"
        btnCopiaBDProdutos.Size = New Size(289, 31)
        btnCopiaBDProdutos.TabIndex = 0
        btnCopiaBDProdutos.Text = "Copia da BD os Produtos para a Grid"
        btnCopiaBDProdutos.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarNomeLista
        ' 
        btnEliminarNomeLista.Location = New Point(371, 632)
        btnEliminarNomeLista.Margin = New Padding(3, 4, 3, 4)
        btnEliminarNomeLista.Name = "btnEliminarNomeLista"
        btnEliminarNomeLista.Size = New Size(207, 31)
        btnEliminarNomeLista.TabIndex = 1
        btnEliminarNomeLista.Text = "Eliminar Este da Lista"
        btnEliminarNomeLista.UseVisualStyleBackColor = True
        ' 
        ' btnNomesGridParaList
        ' 
        btnNomesGridParaList.Location = New Point(14, 632)
        btnNomesGridParaList.Margin = New Padding(3, 4, 3, 4)
        btnNomesGridParaList.Name = "btnNomesGridParaList"
        btnNomesGridParaList.Size = New Size(207, 31)
        btnNomesGridParaList.TabIndex = 2
        btnNomesGridParaList.Text = "Nomes da Grid Para a List"
        btnNomesGridParaList.UseVisualStyleBackColor = True
        ' 
        ' btnLimparList
        ' 
        btnLimparList.Location = New Point(14, 671)
        btnLimparList.Margin = New Padding(3, 4, 3, 4)
        btnLimparList.Name = "btnLimparList"
        btnLimparList.Size = New Size(207, 31)
        btnLimparList.TabIndex = 3
        btnLimparList.Text = "Limpar a List"
        btnLimparList.UseVisualStyleBackColor = True
        ' 
        ' btnContarList
        ' 
        btnContarList.Location = New Point(14, 709)
        btnContarList.Margin = New Padding(3, 4, 3, 4)
        btnContarList.Name = "btnContarList"
        btnContarList.Size = New Size(207, 31)
        btnContarList.TabIndex = 4
        btnContarList.Text = "Contar Elementos na List"
        btnContarList.UseVisualStyleBackColor = True
        ' 
        ' btnAtualizarLinha
        ' 
        btnAtualizarLinha.Location = New Point(14, 768)
        btnAtualizarLinha.Margin = New Padding(3, 4, 3, 4)
        btnAtualizarLinha.Name = "btnAtualizarLinha"
        btnAtualizarLinha.Size = New Size(447, 59)
        btnAtualizarLinha.TabIndex = 5
        btnAtualizarLinha.Text = "Atualizar Linha Corrente da Grid, Para a Tabela"
        btnAtualizarLinha.UseVisualStyleBackColor = True
        ' 
        ' btnContarProdutos
        ' 
        btnContarProdutos.Location = New Point(14, 835)
        btnContarProdutos.Margin = New Padding(3, 4, 3, 4)
        btnContarProdutos.Name = "btnContarProdutos"
        btnContarProdutos.Size = New Size(207, 59)
        btnContarProdutos.TabIndex = 6
        btnContarProdutos.Text = "Contar Produtos da Tabela"
        btnContarProdutos.UseVisualStyleBackColor = True
        ' 
        ' btnInsereDados
        ' 
        btnInsereDados.Location = New Point(14, 901)
        btnInsereDados.Margin = New Padding(3, 4, 3, 4)
        btnInsereDados.Name = "btnInsereDados"
        btnInsereDados.Size = New Size(447, 77)
        btnInsereDados.TabIndex = 7
        btnInsereDados.Text = "Insere das Texts para a Tabela (nome, fornecedor, categoria, preço) [Nota 1: o identity está ativo?] [Nota 2: O Campo Descontinuado permite NULL?]"
        btnInsereDados.UseVisualStyleBackColor = True
        ' 
        ' btnContaGrid
        ' 
        btnContaGrid.Location = New Point(841, 16)
        btnContaGrid.Margin = New Padding(3, 4, 3, 4)
        btnContaGrid.Name = "btnContaGrid"
        btnContaGrid.Size = New Size(181, 31)
        btnContaGrid.TabIndex = 8
        btnContaGrid.Text = "Conta na Grid"
        btnContaGrid.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveNomeGrid
        ' 
        btnRemoveNomeGrid.Location = New Point(467, 16)
        btnRemoveNomeGrid.Margin = New Padding(3, 4, 3, 4)
        btnRemoveNomeGrid.Name = "btnRemoveNomeGrid"
        btnRemoveNomeGrid.Size = New Size(226, 31)
        btnRemoveNomeGrid.TabIndex = 9
        btnRemoveNomeGrid.Text = "Remove da Grid (pelo Nome) -->"
        btnRemoveNomeGrid.UseVisualStyleBackColor = True
        ' 
        ' btnLimpaGrid
        ' 
        btnLimpaGrid.Location = New Point(310, 16)
        btnLimpaGrid.Margin = New Padding(3, 4, 3, 4)
        btnLimpaGrid.Name = "btnLimpaGrid"
        btnLimpaGrid.Size = New Size(151, 31)
        btnLimpaGrid.TabIndex = 10
        btnLimpaGrid.Text = "Limpa a Grid"
        btnLimpaGrid.UseVisualStyleBackColor = True
        ' 
        ' txtInsereFornecedor
        ' 
        txtInsereFornecedor.Location = New Point(589, 927)
        txtInsereFornecedor.Margin = New Padding(3, 4, 3, 4)
        txtInsereFornecedor.Name = "txtInsereFornecedor"
        txtInsereFornecedor.Size = New Size(140, 27)
        txtInsereFornecedor.TabIndex = 11
        txtInsereFornecedor.Text = "Insira ID Fornecedor"
        ' 
        ' txtInserePreco
        ' 
        txtInserePreco.Location = New Point(883, 927)
        txtInserePreco.Margin = New Padding(3, 4, 3, 4)
        txtInserePreco.Name = "txtInserePreco"
        txtInserePreco.Size = New Size(140, 27)
        txtInserePreco.TabIndex = 12
        txtInserePreco.Text = "Insira o Preço"
        ' 
        ' txtInsereCategoria
        ' 
        txtInsereCategoria.Location = New Point(736, 927)
        txtInsereCategoria.Margin = New Padding(3, 4, 3, 4)
        txtInsereCategoria.Name = "txtInsereCategoria"
        txtInsereCategoria.Size = New Size(140, 27)
        txtInsereCategoria.TabIndex = 13
        txtInsereCategoria.Text = "Insira ID Categoria"
        ' 
        ' txtInsereNome
        ' 
        txtInsereNome.Location = New Point(467, 927)
        txtInsereNome.Margin = New Padding(3, 4, 3, 4)
        txtInsereNome.Name = "txtInsereNome"
        txtInsereNome.Size = New Size(114, 27)
        txtInsereNome.TabIndex = 14
        txtInsereNome.Text = "Insira o Nome"
        ' 
        ' txtContaProdutos
        ' 
        txtContaProdutos.Location = New Point(227, 851)
        txtContaProdutos.Margin = New Padding(3, 4, 3, 4)
        txtContaProdutos.Name = "txtContaProdutos"
        txtContaProdutos.Size = New Size(114, 27)
        txtContaProdutos.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(-5, 744)
        Label1.Name = "Label1"
        Label1.Size = New Size(1755, 20)
        Label1.TabIndex = 16
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' lstNomesGrid
        ' 
        lstNomesGrid.FormattingEnabled = True
        lstNomesGrid.ItemHeight = 20
        lstNomesGrid.Location = New Point(227, 635)
        lstNomesGrid.Margin = New Padding(3, 4, 3, 4)
        lstNomesGrid.Name = "lstNomesGrid"
        lstNomesGrid.Size = New Size(137, 104)
        lstNomesGrid.TabIndex = 17
        ' 
        ' txtNomeAEliminar
        ' 
        txtNomeAEliminar.Location = New Point(371, 671)
        txtNomeAEliminar.Margin = New Padding(3, 4, 3, 4)
        txtNomeAEliminar.Name = "txtNomeAEliminar"
        txtNomeAEliminar.Size = New Size(206, 27)
        txtNomeAEliminar.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(-310, 608)
        Label2.Name = "Label2"
        Label2.Size = New Size(1755, 20)
        Label2.TabIndex = 19
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' txtContarGrid
        ' 
        txtContarGrid.Location = New Point(1029, 16)
        txtContarGrid.Margin = New Padding(3, 4, 3, 4)
        txtContarGrid.Name = "txtContarGrid"
        txtContarGrid.Size = New Size(102, 27)
        txtContarGrid.TabIndex = 20
        ' 
        ' txtRemoverNomeGrid
        ' 
        txtRemoverNomeGrid.Location = New Point(701, 16)
        txtRemoverNomeGrid.Margin = New Padding(3, 4, 3, 4)
        txtRemoverNomeGrid.Name = "txtRemoverNomeGrid"
        txtRemoverNomeGrid.Size = New Size(133, 27)
        txtRemoverNomeGrid.TabIndex = 21
        ' 
        ' dgvBD
        ' 
        dgvBD.AllowUserToAddRows = False
        dgvBD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBD.Location = New Point(14, 55)
        dgvBD.Margin = New Padding(3, 4, 3, 4)
        dgvBD.Name = "dgvBD"
        dgvBD.RowHeadersWidth = 51
        dgvBD.RowTemplate.Height = 25
        dgvBD.Size = New Size(1118, 515)
        dgvBD.TabIndex = 22
        ' 
        ' rbtTodosBdParaGrid
        ' 
        rbtTodosBdParaGrid.AutoSize = True
        rbtTodosBdParaGrid.Checked = True
        rbtTodosBdParaGrid.Location = New Point(663, 579)
        rbtTodosBdParaGrid.Margin = New Padding(3, 4, 3, 4)
        rbtTodosBdParaGrid.Name = "rbtTodosBdParaGrid"
        rbtTodosBdParaGrid.Size = New Size(191, 24)
        rbtTodosBdParaGrid.TabIndex = 23
        rbtTodosBdParaGrid.TabStop = True
        rbtTodosBdParaGrid.Text = "Todos da BD Para a Grid"
        rbtTodosBdParaGrid.UseVisualStyleBackColor = True
        ' 
        ' rbtBdParaGridQtdZero
        ' 
        rbtBdParaGridQtdZero.AutoSize = True
        rbtBdParaGridQtdZero.Location = New Point(841, 577)
        rbtBdParaGridQtdZero.Margin = New Padding(3, 4, 3, 4)
        rbtBdParaGridQtdZero.Name = "rbtBdParaGridQtdZero"
        rbtBdParaGridQtdZero.Size = New Size(322, 24)
        rbtBdParaGridQtdZero.TabIndex = 24
        rbtBdParaGridQtdZero.Text = "Da BD Para a Grid, Apenas Quantidade Zero"
        rbtBdParaGridQtdZero.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1145, 995)
        Controls.Add(rbtBdParaGridQtdZero)
        Controls.Add(rbtTodosBdParaGrid)
        Controls.Add(dgvBD)
        Controls.Add(txtRemoverNomeGrid)
        Controls.Add(txtContarGrid)
        Controls.Add(Label2)
        Controls.Add(txtNomeAEliminar)
        Controls.Add(lstNomesGrid)
        Controls.Add(Label1)
        Controls.Add(txtContaProdutos)
        Controls.Add(txtInsereNome)
        Controls.Add(txtInsereCategoria)
        Controls.Add(txtInserePreco)
        Controls.Add(txtInsereFornecedor)
        Controls.Add(btnLimpaGrid)
        Controls.Add(btnRemoveNomeGrid)
        Controls.Add(btnContaGrid)
        Controls.Add(btnInsereDados)
        Controls.Add(btnContarProdutos)
        Controls.Add(btnAtualizarLinha)
        Controls.Add(btnContarList)
        Controls.Add(btnLimparList)
        Controls.Add(btnNomesGridParaList)
        Controls.Add(btnEliminarNomeLista)
        Controls.Add(btnCopiaBDProdutos)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBD, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCopiaBDProdutos As Button
    Friend WithEvents btnEliminarNomeLista As Button
    Friend WithEvents btnNomesGridParaList As Button
    Friend WithEvents btnLimparList As Button
    Friend WithEvents btnContarList As Button
    Friend WithEvents btnAtualizarLinha As Button
    Friend WithEvents btnContarProdutos As Button
    Friend WithEvents btnInsereDados As Button
    Friend WithEvents btnContaGrid As Button
    Friend WithEvents btnRemoveNomeGrid As Button
    Friend WithEvents btnLimpaGrid As Button
    Friend WithEvents txtInsereFornecedor As TextBox
    Friend WithEvents txtInserePreco As TextBox
    Friend WithEvents txtInsereCategoria As TextBox
    Friend WithEvents txtInsereNome As TextBox
    Friend WithEvents txtContaProdutos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstNomesGrid As ListBox
    Friend WithEvents txtNomeAEliminar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContarGrid As TextBox
    Friend WithEvents txtRemoverNomeGrid As TextBox
    Friend WithEvents dgvBD As DataGridView
    Friend WithEvents rbtTodosBdParaGrid As RadioButton
    Friend WithEvents rbtBdParaGridQtdZero As RadioButton
End Class
