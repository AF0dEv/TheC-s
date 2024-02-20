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
        btnContar = New Button()
        btnDeleteSelected = New Button()
        btnLimpaTudo = New Button()
        btnEliminarPrimeiro = New Button()
        btnEliminarUltimo = New Button()
        btnExisteString = New Button()
        txtString = New TextBox()
        cbxStrings = New ComboBox()
        SuspendLayout()
        ' 
        ' btnAdicionarString
        ' 
        btnAdicionarString.Location = New Point(12, 41)
        btnAdicionarString.Name = "btnAdicionarString"
        btnAdicionarString.Size = New Size(233, 23)
        btnAdicionarString.TabIndex = 0
        btnAdicionarString.Text = "Adicionar String ComboBox"
        btnAdicionarString.UseVisualStyleBackColor = True
        ' 
        ' btnContar
        ' 
        btnContar.Location = New Point(251, 157)
        btnContar.Name = "btnContar"
        btnContar.Size = New Size(233, 23)
        btnContar.TabIndex = 1
        btnContar.Text = "Contar Elementos"
        btnContar.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteSelected
        ' 
        btnDeleteSelected.Location = New Point(251, 128)
        btnDeleteSelected.Name = "btnDeleteSelected"
        btnDeleteSelected.Size = New Size(233, 23)
        btnDeleteSelected.TabIndex = 2
        btnDeleteSelected.Text = "Eliminar Selecionado"
        btnDeleteSelected.UseVisualStyleBackColor = True
        ' 
        ' btnLimpaTudo
        ' 
        btnLimpaTudo.Location = New Point(251, 99)
        btnLimpaTudo.Name = "btnLimpaTudo"
        btnLimpaTudo.Size = New Size(233, 23)
        btnLimpaTudo.TabIndex = 3
        btnLimpaTudo.Text = "Limpar Tudo"
        btnLimpaTudo.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarPrimeiro
        ' 
        btnEliminarPrimeiro.Location = New Point(251, 70)
        btnEliminarPrimeiro.Name = "btnEliminarPrimeiro"
        btnEliminarPrimeiro.Size = New Size(233, 23)
        btnEliminarPrimeiro.TabIndex = 4
        btnEliminarPrimeiro.Text = "Eliminar Primeiro"
        btnEliminarPrimeiro.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarUltimo
        ' 
        btnEliminarUltimo.Location = New Point(251, 41)
        btnEliminarUltimo.Name = "btnEliminarUltimo"
        btnEliminarUltimo.Size = New Size(233, 23)
        btnEliminarUltimo.TabIndex = 5
        btnEliminarUltimo.Text = "Eliminar Ultimo"
        btnEliminarUltimo.UseVisualStyleBackColor = True
        ' 
        ' btnExisteString
        ' 
        btnExisteString.Location = New Point(12, 70)
        btnExisteString.Name = "btnExisteString"
        btnExisteString.Size = New Size(233, 23)
        btnExisteString.TabIndex = 6
        btnExisteString.Text = "Existe String na ComboBox?"
        btnExisteString.UseVisualStyleBackColor = True
        ' 
        ' txtString
        ' 
        txtString.Location = New Point(12, 12)
        txtString.Name = "txtString"
        txtString.Size = New Size(233, 23)
        txtString.TabIndex = 7
        ' 
        ' cbxStrings
        ' 
        cbxStrings.FormattingEnabled = True
        cbxStrings.Location = New Point(251, 12)
        cbxStrings.Name = "cbxStrings"
        cbxStrings.Size = New Size(233, 23)
        cbxStrings.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(490, 188)
        Controls.Add(cbxStrings)
        Controls.Add(txtString)
        Controls.Add(btnExisteString)
        Controls.Add(btnEliminarUltimo)
        Controls.Add(btnEliminarPrimeiro)
        Controls.Add(btnLimpaTudo)
        Controls.Add(btnDeleteSelected)
        Controls.Add(btnContar)
        Controls.Add(btnAdicionarString)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdicionarString As Button
    Friend WithEvents btnContar As Button
    Friend WithEvents btnDeleteSelected As Button
    Friend WithEvents btnLimpaTudo As Button
    Friend WithEvents btnEliminarPrimeiro As Button
    Friend WithEvents btnEliminarUltimo As Button
    Friend WithEvents btnExisteString As Button
    Friend WithEvents txtString As TextBox
    Friend WithEvents cbxStrings As ComboBox
End Class
