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
        dgvRegistos = New DataGridView()
        btnCriarViagem = New Button()
        btnEliminarViagem = New Button()
        gbxViagem = New GroupBox()
        rbtListarMenor1Dia = New RadioButton()
        rbtListarMaior1dia = New RadioButton()
        cbxListaViagem = New ComboBox()
        btnListarViagem = New Button()
        gbxViatura = New GroupBox()
        btnListarViatura = New Button()
        btnCriarViatura = New Button()
        btnEliminarViatura = New Button()
        CType(dgvRegistos, ComponentModel.ISupportInitialize).BeginInit()
        gbxViagem.SuspendLayout()
        gbxViatura.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvRegistos
        ' 
        dgvRegistos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRegistos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRegistos.Location = New Point(10, 10)
        dgvRegistos.Name = "dgvRegistos"
        dgvRegistos.RowHeadersWidth = 51
        dgvRegistos.Size = New Size(547, 258)
        dgvRegistos.TabIndex = 0
        ' 
        ' btnCriarViagem
        ' 
        btnCriarViagem.Location = New Point(6, 22)
        btnCriarViagem.Name = "btnCriarViagem"
        btnCriarViagem.Size = New Size(100, 23)
        btnCriarViagem.TabIndex = 1
        btnCriarViagem.Text = "Criar"
        btnCriarViagem.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarViagem
        ' 
        btnEliminarViagem.Location = New Point(112, 22)
        btnEliminarViagem.Name = "btnEliminarViagem"
        btnEliminarViagem.Size = New Size(96, 23)
        btnEliminarViagem.TabIndex = 2
        btnEliminarViagem.Text = "Eliminar"
        btnEliminarViagem.UseVisualStyleBackColor = True
        ' 
        ' gbxViagem
        ' 
        gbxViagem.Controls.Add(rbtListarMenor1Dia)
        gbxViagem.Controls.Add(rbtListarMaior1dia)
        gbxViagem.Controls.Add(cbxListaViagem)
        gbxViagem.Controls.Add(btnListarViagem)
        gbxViagem.Controls.Add(btnCriarViagem)
        gbxViagem.Controls.Add(btnEliminarViagem)
        gbxViagem.Location = New Point(571, 12)
        gbxViagem.Name = "gbxViagem"
        gbxViagem.Size = New Size(235, 106)
        gbxViagem.TabIndex = 3
        gbxViagem.TabStop = False
        gbxViagem.Text = "Viagem"
        ' 
        ' rbtListarMenor1Dia
        ' 
        rbtListarMenor1Dia.AutoSize = True
        rbtListarMenor1Dia.Checked = True
        rbtListarMenor1Dia.Location = New Point(0, 82)
        rbtListarMenor1Dia.Name = "rbtListarMenor1Dia"
        rbtListarMenor1Dia.Size = New Size(106, 19)
        rbtListarMenor1Dia.TabIndex = 7
        rbtListarMenor1Dia.TabStop = True
        rbtListarMenor1Dia.Text = "Viagens < 1 Dia"
        rbtListarMenor1Dia.UseVisualStyleBackColor = True
        ' 
        ' rbtListarMaior1dia
        ' 
        rbtListarMaior1dia.AutoSize = True
        rbtListarMaior1dia.Location = New Point(123, 82)
        rbtListarMaior1dia.Name = "rbtListarMaior1dia"
        rbtListarMaior1dia.Size = New Size(106, 19)
        rbtListarMaior1dia.TabIndex = 6
        rbtListarMaior1dia.Text = "Viagens > 1 Dia"
        rbtListarMaior1dia.UseVisualStyleBackColor = True
        ' 
        ' cbxListaViagem
        ' 
        cbxListaViagem.FormattingEnabled = True
        cbxListaViagem.Location = New Point(87, 52)
        cbxListaViagem.Name = "cbxListaViagem"
        cbxListaViagem.Size = New Size(121, 23)
        cbxListaViagem.TabIndex = 5
        ' 
        ' btnListarViagem
        ' 
        btnListarViagem.Location = New Point(6, 51)
        btnListarViagem.Name = "btnListarViagem"
        btnListarViagem.Size = New Size(75, 23)
        btnListarViagem.TabIndex = 4
        btnListarViagem.Text = "Listar"
        btnListarViagem.UseVisualStyleBackColor = True
        ' 
        ' gbxViatura
        ' 
        gbxViatura.Controls.Add(btnListarViatura)
        gbxViatura.Controls.Add(btnCriarViatura)
        gbxViatura.Controls.Add(btnEliminarViatura)
        gbxViatura.Location = New Point(571, 124)
        gbxViatura.Name = "gbxViatura"
        gbxViatura.Size = New Size(235, 85)
        gbxViatura.TabIndex = 4
        gbxViatura.TabStop = False
        gbxViatura.Text = "Viatura"
        ' 
        ' btnListarViatura
        ' 
        btnListarViatura.Location = New Point(82, 56)
        btnListarViatura.Name = "btnListarViatura"
        btnListarViatura.Size = New Size(75, 23)
        btnListarViatura.TabIndex = 4
        btnListarViatura.Text = "Listar"
        btnListarViatura.UseVisualStyleBackColor = True
        ' 
        ' btnCriarViatura
        ' 
        btnCriarViatura.Location = New Point(6, 21)
        btnCriarViatura.Name = "btnCriarViatura"
        btnCriarViatura.Size = New Size(100, 23)
        btnCriarViatura.TabIndex = 1
        btnCriarViatura.Text = "Criar"
        btnCriarViatura.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarViatura
        ' 
        btnEliminarViatura.Location = New Point(127, 21)
        btnEliminarViatura.Name = "btnEliminarViatura"
        btnEliminarViatura.Size = New Size(96, 23)
        btnEliminarViatura.TabIndex = 2
        btnEliminarViatura.Text = "Eliminar"
        btnEliminarViatura.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(808, 279)
        Controls.Add(gbxViatura)
        Controls.Add(gbxViagem)
        Controls.Add(dgvRegistos)
        Name = "Form1"
        Text = "Form1"
        CType(dgvRegistos, ComponentModel.ISupportInitialize).EndInit()
        gbxViagem.ResumeLayout(False)
        gbxViagem.PerformLayout()
        gbxViatura.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvRegistos As DataGridView
    Friend WithEvents btnCriarViagem As Button
    Friend WithEvents btnEliminarViagem As Button
    Friend WithEvents gbxViagem As GroupBox
    Friend WithEvents btnListarViagem As Button
    Friend WithEvents rbtListarMaior1dia As RadioButton
    Friend WithEvents cbxListaViagem As ComboBox
    Friend WithEvents gbxViatura As GroupBox
    Friend WithEvents btnListarViatura As Button
    Friend WithEvents btnCriarViatura As Button
    Friend WithEvents btnEliminarViatura As Button
    Friend WithEvents rbtListarMenor1Dia As RadioButton

End Class
