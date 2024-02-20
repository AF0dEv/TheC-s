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
        btnInserir = New Button()
        btnContar = New Button()
        btnEliminarTodos = New Button()
        btnEliminaFirst = New Button()
        txtNome = New TextBox()
        dgvNomes = New DataGridView()
        CType(dgvNomes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnInserir
        ' 
        btnInserir.Location = New Point(12, 163)
        btnInserir.Name = "btnInserir"
        btnInserir.Size = New Size(330, 29)
        btnInserir.TabIndex = 0
        btnInserir.Text = "Inserir Este Nome na Grid"
        btnInserir.UseVisualStyleBackColor = True
        ' 
        ' btnContar
        ' 
        btnContar.Location = New Point(12, 48)
        btnContar.Name = "btnContar"
        btnContar.Size = New Size(330, 30)
        btnContar.TabIndex = 1
        btnContar.Text = "Contar os Elementos"
        btnContar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarTodos
        ' 
        btnEliminarTodos.Location = New Point(12, 12)
        btnEliminarTodos.Name = "btnEliminarTodos"
        btnEliminarTodos.Size = New Size(330, 30)
        btnEliminarTodos.TabIndex = 2
        btnEliminarTodos.Text = "Eliminar Todos os Elementos"
        btnEliminarTodos.UseVisualStyleBackColor = True
        ' 
        ' btnEliminaFirst
        ' 
        btnEliminaFirst.Location = New Point(12, 348)
        btnEliminaFirst.Name = "btnEliminaFirst"
        btnEliminaFirst.Size = New Size(330, 29)
        btnEliminaFirst.TabIndex = 3
        btnEliminaFirst.Text = "Elimina a 1ª Linha da Grid"
        btnEliminaFirst.UseVisualStyleBackColor = True
        ' 
        ' txtNome
        ' 
        txtNome.Location = New Point(12, 198)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(330, 27)
        txtNome.TabIndex = 4
        ' 
        ' dgvNomes
        ' 
        dgvNomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNomes.Location = New Point(348, 12)
        dgvNomes.Name = "dgvNomes"
        dgvNomes.RowHeadersWidth = 51
        dgvNomes.RowTemplate.Height = 29
        dgvNomes.Size = New Size(300, 426)
        dgvNomes.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 450)
        Controls.Add(dgvNomes)
        Controls.Add(txtNome)
        Controls.Add(btnEliminaFirst)
        Controls.Add(btnEliminarTodos)
        Controls.Add(btnContar)
        Controls.Add(btnInserir)
        Name = "Form1"
        Text = "Form1"
        CType(dgvNomes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnInserir As Button
    Friend WithEvents btnContar As Button
    Friend WithEvents btnEliminarTodos As Button
    Friend WithEvents btnEliminaFirst As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents dgvNomes As DataGridView
End Class
