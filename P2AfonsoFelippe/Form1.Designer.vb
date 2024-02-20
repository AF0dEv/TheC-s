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
        dgvProdutos = New DataGridView()
        cbxCategorias = New ComboBox()
        lblCategorias = New Label()
        lblFornecedores = New Label()
        cbxFornecedores = New ComboBox()
        lblProdutoMaisCaro = New Label()
        lblTotalLinhas = New Label()
        lblPrecoMedio = New Label()
        txtProdutoMaisCaro = New TextBox()
        txtSqlProdutoMaisCaro = New TextBox()
        txtPrecoMedio = New TextBox()
        txtSqlPrecoMedio = New TextBox()
        txtTotalLinhas = New TextBox()
        txtSqlTotalLinhas = New TextBox()
        lblCalculosSql = New Label()
        lblCalculosGrid = New Label()
        btnTodasCategorias = New Button()
        btnTodosFornecedores = New Button()
        btnTodosProdutos = New Button()
        btnExit = New Button()
        CType(dgvProdutos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProdutos
        ' 
        dgvProdutos.AllowUserToAddRows = False
        dgvProdutos.AllowUserToDeleteRows = False
        dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProdutos.Location = New Point(12, 141)
        dgvProdutos.Name = "dgvProdutos"
        dgvProdutos.ReadOnly = True
        dgvProdutos.RowHeadersVisible = False
        dgvProdutos.RowHeadersWidth = 51
        dgvProdutos.RowTemplate.Height = 29
        dgvProdutos.Size = New Size(1009, 395)
        dgvProdutos.TabIndex = 0
        ' 
        ' cbxCategorias
        ' 
        cbxCategorias.FormattingEnabled = True
        cbxCategorias.Location = New Point(12, 96)
        cbxCategorias.Name = "cbxCategorias"
        cbxCategorias.Size = New Size(360, 28)
        cbxCategorias.TabIndex = 1
        ' 
        ' lblCategorias
        ' 
        lblCategorias.AutoSize = True
        lblCategorias.Location = New Point(12, 73)
        lblCategorias.Name = "lblCategorias"
        lblCategorias.Size = New Size(80, 20)
        lblCategorias.TabIndex = 2
        lblCategorias.Text = "Categorias"
        ' 
        ' lblFornecedores
        ' 
        lblFornecedores.AutoSize = True
        lblFornecedores.Location = New Point(389, 73)
        lblFornecedores.Name = "lblFornecedores"
        lblFornecedores.Size = New Size(98, 20)
        lblFornecedores.TabIndex = 4
        lblFornecedores.Text = "Fornecedores"
        ' 
        ' cbxFornecedores
        ' 
        cbxFornecedores.FormattingEnabled = True
        cbxFornecedores.Location = New Point(389, 96)
        cbxFornecedores.Name = "cbxFornecedores"
        cbxFornecedores.Size = New Size(360, 28)
        cbxFornecedores.TabIndex = 3
        ' 
        ' lblProdutoMaisCaro
        ' 
        lblProdutoMaisCaro.AutoSize = True
        lblProdutoMaisCaro.Location = New Point(364, 558)
        lblProdutoMaisCaro.Name = "lblProdutoMaisCaro"
        lblProdutoMaisCaro.Size = New Size(194, 20)
        lblProdutoMaisCaro.TabIndex = 5
        lblProdutoMaisCaro.Text = "Produto e preço (mais caro)"
        ' 
        ' lblTotalLinhas
        ' 
        lblTotalLinhas.AutoSize = True
        lblTotalLinhas.Location = New Point(12, 558)
        lblTotalLinhas.Name = "lblTotalLinhas"
        lblTotalLinhas.Size = New Size(105, 20)
        lblTotalLinhas.TabIndex = 6
        lblTotalLinhas.Text = "Total de linhas"
        ' 
        ' lblPrecoMedio
        ' 
        lblPrecoMedio.AutoSize = True
        lblPrecoMedio.Location = New Point(187, 558)
        lblPrecoMedio.Name = "lblPrecoMedio"
        lblPrecoMedio.Size = New Size(93, 20)
        lblPrecoMedio.TabIndex = 7
        lblPrecoMedio.Text = "Preço médio"
        ' 
        ' txtProdutoMaisCaro
        ' 
        txtProdutoMaisCaro.BorderStyle = BorderStyle.FixedSingle
        txtProdutoMaisCaro.Location = New Point(364, 591)
        txtProdutoMaisCaro.Name = "txtProdutoMaisCaro"
        txtProdutoMaisCaro.ReadOnly = True
        txtProdutoMaisCaro.Size = New Size(247, 27)
        txtProdutoMaisCaro.TabIndex = 8
        ' 
        ' txtSqlProdutoMaisCaro
        ' 
        txtSqlProdutoMaisCaro.BorderStyle = BorderStyle.FixedSingle
        txtSqlProdutoMaisCaro.Location = New Point(364, 652)
        txtSqlProdutoMaisCaro.Name = "txtSqlProdutoMaisCaro"
        txtSqlProdutoMaisCaro.ReadOnly = True
        txtSqlProdutoMaisCaro.Size = New Size(247, 27)
        txtSqlProdutoMaisCaro.TabIndex = 9
        ' 
        ' txtPrecoMedio
        ' 
        txtPrecoMedio.BorderStyle = BorderStyle.FixedSingle
        txtPrecoMedio.Location = New Point(192, 591)
        txtPrecoMedio.Name = "txtPrecoMedio"
        txtPrecoMedio.ReadOnly = True
        txtPrecoMedio.Size = New Size(125, 27)
        txtPrecoMedio.TabIndex = 10
        ' 
        ' txtSqlPrecoMedio
        ' 
        txtSqlPrecoMedio.BorderStyle = BorderStyle.FixedSingle
        txtSqlPrecoMedio.Location = New Point(190, 652)
        txtSqlPrecoMedio.Name = "txtSqlPrecoMedio"
        txtSqlPrecoMedio.ReadOnly = True
        txtSqlPrecoMedio.Size = New Size(125, 27)
        txtSqlPrecoMedio.TabIndex = 11
        ' 
        ' txtTotalLinhas
        ' 
        txtTotalLinhas.BorderStyle = BorderStyle.FixedSingle
        txtTotalLinhas.Location = New Point(12, 591)
        txtTotalLinhas.Name = "txtTotalLinhas"
        txtTotalLinhas.ReadOnly = True
        txtTotalLinhas.Size = New Size(125, 27)
        txtTotalLinhas.TabIndex = 12
        ' 
        ' txtSqlTotalLinhas
        ' 
        txtSqlTotalLinhas.BorderStyle = BorderStyle.FixedSingle
        txtSqlTotalLinhas.Location = New Point(12, 652)
        txtSqlTotalLinhas.Name = "txtSqlTotalLinhas"
        txtSqlTotalLinhas.ReadOnly = True
        txtSqlTotalLinhas.Size = New Size(125, 27)
        txtSqlTotalLinhas.TabIndex = 13
        ' 
        ' lblCalculosSql
        ' 
        lblCalculosSql.AutoSize = True
        lblCalculosSql.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblCalculosSql.Location = New Point(702, 648)
        lblCalculosSql.Name = "lblCalculosSql"
        lblCalculosSql.Size = New Size(262, 31)
        lblCalculosSql.TabIndex = 14
        lblCalculosSql.Text = "[ CÁLCULOS COM SQL ]"
        ' 
        ' lblCalculosGrid
        ' 
        lblCalculosGrid.AutoSize = True
        lblCalculosGrid.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lblCalculosGrid.Location = New Point(646, 587)
        lblCalculosGrid.Name = "lblCalculosGrid"
        lblCalculosGrid.Size = New Size(362, 31)
        lblCalculosGrid.TabIndex = 15
        lblCalculosGrid.Text = "[ CÁLCULOS A PARTIR DA GRID ]"
        ' 
        ' btnTodasCategorias
        ' 
        btnTodasCategorias.Location = New Point(12, 12)
        btnTodasCategorias.Name = "btnTodasCategorias"
        btnTodasCategorias.Size = New Size(360, 39)
        btnTodasCategorias.TabIndex = 16
        btnTodasCategorias.Text = "Todas as categorias"
        btnTodasCategorias.UseVisualStyleBackColor = True
        ' 
        ' btnTodosFornecedores
        ' 
        btnTodosFornecedores.Location = New Point(389, 12)
        btnTodosFornecedores.Name = "btnTodosFornecedores"
        btnTodosFornecedores.Size = New Size(360, 39)
        btnTodosFornecedores.TabIndex = 17
        btnTodosFornecedores.Text = "Todos os fornecedores"
        btnTodosFornecedores.UseVisualStyleBackColor = True
        ' 
        ' btnTodosProdutos
        ' 
        btnTodosProdutos.Location = New Point(755, 12)
        btnTodosProdutos.Name = "btnTodosProdutos"
        btnTodosProdutos.Size = New Size(168, 112)
        btnTodosProdutos.TabIndex = 18
        btnTodosProdutos.Text = "Todos os produtos"
        btnTodosProdutos.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(929, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(92, 112)
        btnExit.TabIndex = 19
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1044, 794)
        ControlBox = False
        Controls.Add(btnExit)
        Controls.Add(btnTodosFornecedores)
        Controls.Add(btnTodosProdutos)
        Controls.Add(btnTodasCategorias)
        Controls.Add(lblCalculosGrid)
        Controls.Add(lblCalculosSql)
        Controls.Add(txtSqlTotalLinhas)
        Controls.Add(txtTotalLinhas)
        Controls.Add(txtSqlPrecoMedio)
        Controls.Add(txtPrecoMedio)
        Controls.Add(txtSqlProdutoMaisCaro)
        Controls.Add(txtProdutoMaisCaro)
        Controls.Add(lblPrecoMedio)
        Controls.Add(lblTotalLinhas)
        Controls.Add(lblProdutoMaisCaro)
        Controls.Add(lblFornecedores)
        Controls.Add(cbxFornecedores)
        Controls.Add(lblCategorias)
        Controls.Add(cbxCategorias)
        Controls.Add(dgvProdutos)
        FormBorderStyle = FormBorderStyle.FixedSingle
        ImeMode = ImeMode.Hiragana
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Produtos"
        CType(dgvProdutos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents cbxCategorias As ComboBox
    Friend WithEvents cbxFornecedores As ComboBox
    Friend WithEvents lblCategorias As Label
    Friend WithEvents lblFornecedores As Label
    Friend WithEvents lblProdutoMaisCaro As Label
    Friend WithEvents lblTotalLinhas As Label
    Friend WithEvents lblPrecoMedio As Label
    Friend WithEvents lblCalculosGrid As Label
    Friend WithEvents lblCalculosSql As Label
    Friend WithEvents txtTotalLinhas As TextBox
    Friend WithEvents txtProdutoMaisCaro As TextBox
    Friend WithEvents txtPrecoMedio As TextBox
    Friend WithEvents txtSqlProdutoMaisCaro As TextBox
    Friend WithEvents txtSqlPrecoMedio As TextBox
    Friend WithEvents txtSqlTotalLinhas As TextBox
    Friend WithEvents btnTodasCategorias As Button
    Friend WithEvents btnTodosFornecedores As Button
    Friend WithEvents btnTodosProdutos As Button
    Friend WithEvents btnExit As Button
End Class
