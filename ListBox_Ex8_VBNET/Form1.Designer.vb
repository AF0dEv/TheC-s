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
        btnInicializarLista = New Button()
        btnAdicionarLista = New Button()
        btnContagem = New Button()
        btnEliminarFirstFive = New Button()
        btnExisteLista = New Button()
        btnEliminarLastFive = New Button()
        btnRemoverClube = New Button()
        btnLimparLista = New Button()
        txtClube = New TextBox()
        txtContagem = New TextBox()
        txtRespostaExiste = New TextBox()
        txtClubeATrocar = New TextBox()
        txtClubeExiste = New TextBox()
        txtClubeTrocado = New TextBox()
        lstClubes = New ListBox()
        btnSubstituir = New Button()
        SuspendLayout()
        ' 
        ' btnInicializarLista
        ' 
        btnInicializarLista.Location = New Point(12, 128)
        btnInicializarLista.Name = "btnInicializarLista"
        btnInicializarLista.Size = New Size(358, 23)
        btnInicializarLista.TabIndex = 0
        btnInicializarLista.Text = "Inicializar Lista com Vários Clubes"
        btnInicializarLista.UseVisualStyleBackColor = True
        ' 
        ' btnAdicionarLista
        ' 
        btnAdicionarLista.Location = New Point(12, 70)
        btnAdicionarLista.Name = "btnAdicionarLista"
        btnAdicionarLista.Size = New Size(358, 23)
        btnAdicionarLista.TabIndex = 1
        btnAdicionarLista.Text = "Adicionar Clube à Lista"
        btnAdicionarLista.UseVisualStyleBackColor = True
        ' 
        ' btnContagem
        ' 
        btnContagem.Location = New Point(12, 157)
        btnContagem.Name = "btnContagem"
        btnContagem.Size = New Size(183, 23)
        btnContagem.TabIndex = 2
        btnContagem.Text = "Contagem Lista"
        btnContagem.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarFirstFive
        ' 
        btnEliminarFirstFive.Location = New Point(12, 186)
        btnEliminarFirstFive.Name = "btnEliminarFirstFive"
        btnEliminarFirstFive.Size = New Size(358, 23)
        btnEliminarFirstFive.TabIndex = 3
        btnEliminarFirstFive.Text = "Eliminar os Primeiros 5 Clubes"
        btnEliminarFirstFive.UseVisualStyleBackColor = True
        ' 
        ' btnExisteLista
        ' 
        btnExisteLista.Location = New Point(118, 273)
        btnExisteLista.Name = "btnExisteLista"
        btnExisteLista.Size = New Size(146, 23)
        btnExisteLista.TabIndex = 4
        btnExisteLista.Text = "Existe na Lista?"
        btnExisteLista.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarLastFive
        ' 
        btnEliminarLastFive.Location = New Point(12, 215)
        btnEliminarLastFive.Name = "btnEliminarLastFive"
        btnEliminarLastFive.Size = New Size(358, 23)
        btnEliminarLastFive.TabIndex = 5
        btnEliminarLastFive.Text = "Eliminar Ultimos 5 Clubes ~8mesmo que tenha menos)"
        btnEliminarLastFive.UseVisualStyleBackColor = True
        ' 
        ' btnRemoverClube
        ' 
        btnRemoverClube.Location = New Point(12, 99)
        btnRemoverClube.Name = "btnRemoverClube"
        btnRemoverClube.Size = New Size(358, 23)
        btnRemoverClube.TabIndex = 6
        btnRemoverClube.Text = "Remover Clube da Lista"
        btnRemoverClube.UseVisualStyleBackColor = True
        ' 
        ' btnLimparLista
        ' 
        btnLimparLista.Location = New Point(12, 41)
        btnLimparLista.Name = "btnLimparLista"
        btnLimparLista.Size = New Size(358, 23)
        btnLimparLista.TabIndex = 7
        btnLimparLista.Text = "Limpar a Lista"
        btnLimparLista.UseVisualStyleBackColor = True
        ' 
        ' txtClube
        ' 
        txtClube.Location = New Point(12, 12)
        txtClube.Name = "txtClube"
        txtClube.Size = New Size(358, 23)
        txtClube.TabIndex = 9
        txtClube.Text = "Insira Aqui o Clube........"
        ' 
        ' txtContagem
        ' 
        txtContagem.Location = New Point(201, 157)
        txtContagem.Name = "txtContagem"
        txtContagem.Size = New Size(169, 23)
        txtContagem.TabIndex = 10
        ' 
        ' txtRespostaExiste
        ' 
        txtRespostaExiste.Location = New Point(270, 274)
        txtRespostaExiste.Name = "txtRespostaExiste"
        txtRespostaExiste.Size = New Size(100, 23)
        txtRespostaExiste.TabIndex = 11
        ' 
        ' txtClubeATrocar
        ' 
        txtClubeATrocar.Location = New Point(12, 339)
        txtClubeATrocar.Name = "txtClubeATrocar"
        txtClubeATrocar.Size = New Size(100, 23)
        txtClubeATrocar.TabIndex = 12
        ' 
        ' txtClubeExiste
        ' 
        txtClubeExiste.Location = New Point(12, 273)
        txtClubeExiste.Name = "txtClubeExiste"
        txtClubeExiste.Size = New Size(100, 23)
        txtClubeExiste.TabIndex = 13
        ' 
        ' txtClubeTrocado
        ' 
        txtClubeTrocado.Location = New Point(12, 368)
        txtClubeTrocado.Name = "txtClubeTrocado"
        txtClubeTrocado.Size = New Size(100, 23)
        txtClubeTrocado.TabIndex = 14
        ' 
        ' lstClubes
        ' 
        lstClubes.FormattingEnabled = True
        lstClubes.ItemHeight = 15
        lstClubes.Location = New Point(376, 12)
        lstClubes.Name = "lstClubes"
        lstClubes.Size = New Size(120, 379)
        lstClubes.TabIndex = 15
        ' 
        ' btnSubstituir
        ' 
        btnSubstituir.Location = New Point(118, 339)
        btnSubstituir.Name = "btnSubstituir"
        btnSubstituir.Size = New Size(75, 52)
        btnSubstituir.TabIndex = 16
        btnSubstituir.Text = "Substituir se Existir"
        btnSubstituir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(511, 404)
        Controls.Add(btnSubstituir)
        Controls.Add(lstClubes)
        Controls.Add(txtClubeTrocado)
        Controls.Add(txtClubeExiste)
        Controls.Add(txtClubeATrocar)
        Controls.Add(txtRespostaExiste)
        Controls.Add(txtContagem)
        Controls.Add(txtClube)
        Controls.Add(btnLimparLista)
        Controls.Add(btnRemoverClube)
        Controls.Add(btnEliminarLastFive)
        Controls.Add(btnExisteLista)
        Controls.Add(btnEliminarFirstFive)
        Controls.Add(btnContagem)
        Controls.Add(btnAdicionarLista)
        Controls.Add(btnInicializarLista)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInicializarLista As Button
    Friend WithEvents btnAdicionarLista As Button
    Friend WithEvents btnContagem As Button
    Friend WithEvents btnEliminarFirstFive As Button
    Friend WithEvents btnExisteLista As Button
    Friend WithEvents btnEliminarLastFive As Button
    Friend WithEvents btnRemoverClube As Button
    Friend WithEvents btnLimparLista As Button
    Friend WithEvents txtClube As TextBox
    Friend WithEvents txtContagem As TextBox
    Friend WithEvents txtRespostaExiste As TextBox
    Friend WithEvents txtClubeATrocar As TextBox
    Friend WithEvents txtClubeExiste As TextBox
    Friend WithEvents txtClubeTrocado As TextBox
    Friend WithEvents lstClubes As ListBox
    Friend WithEvents btnSubstituir As Button
End Class
