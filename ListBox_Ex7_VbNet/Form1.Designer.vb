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
        btnInserirNome = New Button()
        btnContarNome = New Button()
        btnLimparLista = New Button()
        txtNomeInserido = New TextBox()
        txtNomesContados = New TextBox()
        lstNomes = New ListBox()
        SuspendLayout()
        ' 
        ' btnInserirNome
        ' 
        btnInserirNome.Location = New Point(12, 12)
        btnInserirNome.Name = "btnInserirNome"
        btnInserirNome.Size = New Size(100, 23)
        btnInserirNome.TabIndex = 0
        btnInserirNome.Text = "Inserir Nome"
        btnInserirNome.UseVisualStyleBackColor = True
        ' 
        ' btnContarNome
        ' 
        btnContarNome.Location = New Point(12, 70)
        btnContarNome.Name = "btnContarNome"
        btnContarNome.Size = New Size(100, 23)
        btnContarNome.TabIndex = 1
        btnContarNome.Text = "Contar Nomes"
        btnContarNome.UseVisualStyleBackColor = True
        ' 
        ' btnLimparLista
        ' 
        btnLimparLista.Location = New Point(12, 128)
        btnLimparLista.Name = "btnLimparLista"
        btnLimparLista.Size = New Size(75, 23)
        btnLimparLista.TabIndex = 2
        btnLimparLista.Text = "Limpar Lista"
        btnLimparLista.UseVisualStyleBackColor = True
        ' 
        ' txtNomeInserido
        ' 
        txtNomeInserido.Location = New Point(12, 41)
        txtNomeInserido.Name = "txtNomeInserido"
        txtNomeInserido.Size = New Size(100, 23)
        txtNomeInserido.TabIndex = 3
        ' 
        ' txtNomesContados
        ' 
        txtNomesContados.Location = New Point(12, 99)
        txtNomesContados.Name = "txtNomesContados"
        txtNomesContados.Size = New Size(100, 23)
        txtNomesContados.TabIndex = 4
        ' 
        ' lstNomes
        ' 
        lstNomes.FormattingEnabled = True
        lstNomes.ItemHeight = 15
        lstNomes.Location = New Point(193, 28)
        lstNomes.Name = "lstNomes"
        lstNomes.Size = New Size(120, 94)
        lstNomes.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(327, 166)
        Controls.Add(lstNomes)
        Controls.Add(txtNomesContados)
        Controls.Add(txtNomeInserido)
        Controls.Add(btnLimparLista)
        Controls.Add(btnContarNome)
        Controls.Add(btnInserirNome)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInserirNome As Button
    Friend WithEvents btnContarNome As Button
    Friend WithEvents btnLimparLista As Button
    Friend WithEvents txtNomeInserido As TextBox
    Friend WithEvents txtNomesContados As TextBox
    Friend WithEvents lstNomes As ListBox
End Class
