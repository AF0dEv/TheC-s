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
        btnAdicionarString = New Button()
        btnColonizarListaVetor = New Button()
        btnColonizarListaAddRange = New Button()
        btnExisteNome = New Button()
        btnLimparTodos = New Button()
        btnEliminarSelecionado = New Button()
        btnEliminarUltimo = New Button()
        btnEliminarPrimeiro = New Button()
        btnContarElementos = New Button()
        txtNome = New TextBox()
        cbxLista = New ComboBox()
        SuspendLayout()
        ' 
        ' btnAdicionarString
        ' 
        btnAdicionarString.Location = New Point(12, 12)
        btnAdicionarString.Name = "btnAdicionarString"
        btnAdicionarString.Size = New Size(165, 23)
        btnAdicionarString.TabIndex = 0
        btnAdicionarString.Text = "Adicionar String"
        btnAdicionarString.UseVisualStyleBackColor = True
        ' 
        ' btnColonizarListaVetor
        ' 
        btnColonizarListaVetor.Location = New Point(183, 70)
        btnColonizarListaVetor.Name = "btnColonizarListaVetor"
        btnColonizarListaVetor.Size = New Size(264, 23)
        btnColonizarListaVetor.TabIndex = 1
        btnColonizarListaVetor.Text = "Colonizar Lista (Manual, de Vetor)"
        btnColonizarListaVetor.UseVisualStyleBackColor = True
        ' 
        ' btnColonizarListaAddRange
        ' 
        btnColonizarListaAddRange.Location = New Point(183, 99)
        btnColonizarListaAddRange.Name = "btnColonizarListaAddRange"
        btnColonizarListaAddRange.Size = New Size(264, 23)
        btnColonizarListaAddRange.TabIndex = 2
        btnColonizarListaAddRange.Text = "Colonizar Lista (AddRange)"
        btnColonizarListaAddRange.UseVisualStyleBackColor = True
        ' 
        ' btnExisteNome
        ' 
        btnExisteNome.Location = New Point(12, 215)
        btnExisteNome.Name = "btnExisteNome"
        btnExisteNome.Size = New Size(165, 23)
        btnExisteNome.TabIndex = 3
        btnExisteNome.Text = "Existe Nome?"
        btnExisteNome.UseVisualStyleBackColor = True
        ' 
        ' btnLimparTodos
        ' 
        btnLimparTodos.Location = New Point(12, 157)
        btnLimparTodos.Name = "btnLimparTodos"
        btnLimparTodos.Size = New Size(165, 23)
        btnLimparTodos.TabIndex = 4
        btnLimparTodos.Text = "Limpar Todos"
        btnLimparTodos.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarSelecionado
        ' 
        btnEliminarSelecionado.Location = New Point(12, 128)
        btnEliminarSelecionado.Name = "btnEliminarSelecionado"
        btnEliminarSelecionado.Size = New Size(165, 23)
        btnEliminarSelecionado.TabIndex = 5
        btnEliminarSelecionado.Text = "Eliminar Selecionado"
        btnEliminarSelecionado.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarUltimo
        ' 
        btnEliminarUltimo.Location = New Point(12, 99)
        btnEliminarUltimo.Name = "btnEliminarUltimo"
        btnEliminarUltimo.Size = New Size(165, 23)
        btnEliminarUltimo.TabIndex = 6
        btnEliminarUltimo.Text = "Eliminar Ultimo"
        btnEliminarUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarPrimeiro
        ' 
        btnEliminarPrimeiro.Location = New Point(12, 70)
        btnEliminarPrimeiro.Name = "btnEliminarPrimeiro"
        btnEliminarPrimeiro.Size = New Size(165, 23)
        btnEliminarPrimeiro.TabIndex = 7
        btnEliminarPrimeiro.Text = "Eliminar Primeiro"
        btnEliminarPrimeiro.UseVisualStyleBackColor = True
        ' 
        ' btnContarElementos
        ' 
        btnContarElementos.Location = New Point(12, 41)
        btnContarElementos.Name = "btnContarElementos"
        btnContarElementos.Size = New Size(165, 23)
        btnContarElementos.TabIndex = 8
        btnContarElementos.Text = "Contar Elementos"
        btnContarElementos.UseVisualStyleBackColor = True
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(12, 186)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(165, 23)
        txtNome.TabIndex = 9
        ' 
        ' cbxLista
        ' 
        cbxLista.FormattingEnabled = True
        cbxLista.Location = New Point(183, 13)
        cbxLista.Name = "cbxLista"
        cbxLista.Size = New Size(264, 23)
        cbxLista.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 244)
        Controls.Add(cbxLista)
        Controls.Add(txtNome)
        Controls.Add(btnContarElementos)
        Controls.Add(btnEliminarPrimeiro)
        Controls.Add(btnEliminarUltimo)
        Controls.Add(btnEliminarSelecionado)
        Controls.Add(btnLimparTodos)
        Controls.Add(btnExisteNome)
        Controls.Add(btnColonizarListaAddRange)
        Controls.Add(btnColonizarListaVetor)
        Controls.Add(btnAdicionarString)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdicionarString As Button
    Friend WithEvents btnColonizarListaVetor As Button
    Friend WithEvents btnColonizarListaAddRange As Button
    Friend WithEvents btnExisteNome As Button
    Friend WithEvents btnLimparTodos As Button
    Friend WithEvents btnEliminarSelecionado As Button
    Friend WithEvents btnEliminarUltimo As Button
    Friend WithEvents btnEliminarPrimeiro As Button
    Friend WithEvents btnContarElementos As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents cbxLista As ComboBox
End Class
