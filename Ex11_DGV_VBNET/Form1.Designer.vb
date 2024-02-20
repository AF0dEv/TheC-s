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
        btnInicializar = New Button()
        btnEliminarLinhasVazias = New Button()
        btnEliminarNome = New Button()
        btnLocalizar = New Button()
        btnMostrarNomes = New Button()
        btnInserirRegisto = New Button()
        btnEliminarTudo = New Button()
        txtCidade = New TextBox()
        txtNomeSearchDestroy = New TextBox()
        txtAno = New TextBox()
        txtNome = New TextBox()
        dgvRegistos = New DataGridView()
        CType(dgvRegistos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnInicializar
        ' 
        btnInicializar.Location = New Point(10, 9)
        btnInicializar.Margin = New Padding(3, 2, 3, 2)
        btnInicializar.Name = "btnInicializar"
        btnInicializar.Size = New Size(206, 22)
        btnInicializar.TabIndex = 0
        btnInicializar.Text = "1: Inicializa GridView com 4 Nomes"
        btnInicializar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarLinhasVazias
        ' 
        btnEliminarLinhasVazias.Location = New Point(10, 166)
        btnEliminarLinhasVazias.Margin = New Padding(3, 2, 3, 2)
        btnEliminarLinhasVazias.Name = "btnEliminarLinhasVazias"
        btnEliminarLinhasVazias.Size = New Size(206, 22)
        btnEliminarLinhasVazias.TabIndex = 1
        btnEliminarLinhasVazias.Text = "Eliminar Linhas Com Nome Vazio"
        btnEliminarLinhasVazias.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarNome
        ' 
        btnEliminarNome.Location = New Point(10, 140)
        btnEliminarNome.Margin = New Padding(3, 2, 3, 2)
        btnEliminarNome.Name = "btnEliminarNome"
        btnEliminarNome.Size = New Size(206, 22)
        btnEliminarNome.TabIndex = 2
        btnEliminarNome.Text = "6: Eliminar Linha Com Este Nome ---->"
        btnEliminarNome.UseVisualStyleBackColor = True
        ' 
        ' btnLocalizar
        ' 
        btnLocalizar.Location = New Point(10, 114)
        btnLocalizar.Margin = New Padding(3, 2, 3, 2)
        btnLocalizar.Name = "btnLocalizar"
        btnLocalizar.Size = New Size(206, 22)
        btnLocalizar.TabIndex = 3
        btnLocalizar.Text = "5: Localiza Este Nome ----->"
        btnLocalizar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrarNomes
        ' 
        btnMostrarNomes.Location = New Point(10, 88)
        btnMostrarNomes.Margin = New Padding(3, 2, 3, 2)
        btnMostrarNomes.Name = "btnMostrarNomes"
        btnMostrarNomes.Size = New Size(206, 22)
        btnMostrarNomes.TabIndex = 4
        btnMostrarNomes.Text = "4: Mostrar Nomes Window"
        btnMostrarNomes.UseVisualStyleBackColor = True
        ' 
        ' btnInserirRegisto
        ' 
        btnInserirRegisto.Location = New Point(10, 62)
        btnInserirRegisto.Margin = New Padding(3, 2, 3, 2)
        btnInserirRegisto.Name = "btnInserirRegisto"
        btnInserirRegisto.Size = New Size(206, 22)
        btnInserirRegisto.TabIndex = 5
        btnInserirRegisto.Text = "3: Inserir Este Registo ----->"
        btnInserirRegisto.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarTudo
        ' 
        btnEliminarTudo.Location = New Point(10, 35)
        btnEliminarTudo.Margin = New Padding(3, 2, 3, 2)
        btnEliminarTudo.Name = "btnEliminarTudo"
        btnEliminarTudo.Size = New Size(206, 22)
        btnEliminarTudo.TabIndex = 6
        btnEliminarTudo.Text = "2: Limpa a Grid - Elimina Tudo"
        btnEliminarTudo.UseVisualStyleBackColor = True
        ' 
        ' txtCidade
        ' 
        txtCidade.Location = New Point(221, 88)
        txtCidade.Margin = New Padding(3, 2, 3, 2)
        txtCidade.Name = "txtCidade"
        txtCidade.Size = New Size(193, 23)
        txtCidade.TabIndex = 7
        txtCidade.Text = "A sua Cidade"
        ' 
        ' txtNomeSearchDestroy
        ' 
        txtNomeSearchDestroy.Location = New Point(221, 128)
        txtNomeSearchDestroy.Margin = New Padding(3, 2, 3, 2)
        txtNomeSearchDestroy.Name = "txtNomeSearchDestroy"
        txtNomeSearchDestroy.Size = New Size(193, 23)
        txtNomeSearchDestroy.TabIndex = 8
        txtNomeSearchDestroy.Text = "Nome a Localizar/Eliminar"
        ' 
        ' txtAno
        ' 
        txtAno.Location = New Point(336, 63)
        txtAno.Margin = New Padding(3, 2, 3, 2)
        txtAno.Name = "txtAno"
        txtAno.Size = New Size(78, 23)
        txtAno.TabIndex = 9
        txtAno.Text = "O seu Ano"
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(221, 63)
        txtNome.Margin = New Padding(3, 2, 3, 2)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(110, 23)
        txtNome.TabIndex = 10
        txtNome.Text = "O seu Nome"
        ' 
        ' dgvRegistos
        ' 
        dgvRegistos.AllowUserToAddRows = False
        dgvRegistos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistos.Location = New Point(10, 193)
        dgvRegistos.Margin = New Padding(3, 2, 3, 2)
        dgvRegistos.Name = "dgvRegistos"
        dgvRegistos.RowHeadersWidth = 51
        dgvRegistos.RowTemplate.Height = 29
        dgvRegistos.Size = New Size(403, 141)
        dgvRegistos.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 335)
        Controls.Add(dgvRegistos)
        Controls.Add(txtNome)
        Controls.Add(txtAno)
        Controls.Add(txtNomeSearchDestroy)
        Controls.Add(txtCidade)
        Controls.Add(btnEliminarTudo)
        Controls.Add(btnInserirRegisto)
        Controls.Add(btnMostrarNomes)
        Controls.Add(btnLocalizar)
        Controls.Add(btnEliminarNome)
        Controls.Add(btnEliminarLinhasVazias)
        Controls.Add(btnInicializar)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        CType(dgvRegistos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInicializar As Button
    Friend WithEvents btnEliminarLinhasVazias As Button
    Friend WithEvents btnEliminarNome As Button
    Friend WithEvents btnLocalizar As Button
    Friend WithEvents btnMostrarNomes As Button
    Friend WithEvents btnInserirRegisto As Button
    Friend WithEvents btnEliminarTudo As Button
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtNomeSearchDestroy As TextBox
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents dgvRegistos As DataGridView
End Class
